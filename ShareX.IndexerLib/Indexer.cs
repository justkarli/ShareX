#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright © 2007-2015 ShareX Developers

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using System;
using System.IO;

namespace ShareX.IndexerLib
{
    public class Indexer
    {
        public Indexer(IndexerSettings settings)
        {
            IndexerSettings = settings;
        }

        public void Index(string folderPath)
        {
            DirectoryFileInfo = GetFolderInfo(folderPath);
            DirectoryFileInfo.CollectInfo();
        }

        /// <summary>
        /// Walk recursively through the directory and collect information about the directory and their files.
        /// </summary>
        /// <param name="folderPath"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        protected DirectoryFileInfo GetFolderInfo(string folderPath, int level = 0)
        {
            DirectoryFileInfo directory_file_info = new DirectoryFileInfo(folderPath);

            if (IndexerSettings.MaxDepthLevel == 0 || level < IndexerSettings.MaxDepthLevel)
            {
                DirectoryInfo currentDirectoryInfo = new DirectoryInfo(folderPath);

                foreach (DirectoryInfo directoryInfo in currentDirectoryInfo.GetDirectories())
                {
                    if (SkipHiddenFolders(directoryInfo))
                        continue;
                    
                    // walk recursivly through all subdirectories and collect their directory and file info
                    DirectoryFileInfo sub_directory = GetFolderInfo(directoryInfo.FullName, level + 1);
                    directory_file_info.Folders.Add(sub_directory);
                    sub_directory.Parent = directory_file_info;
                }

                GetFileInfo(currentDirectoryInfo, directory_file_info);
                directory_file_info.Files.Sort((x, y) => String.CompareOrdinal(x.Name, y.Name));
            }

            return directory_file_info;
        }

        /// <summary>
        /// Collects FileInfos from a directory.
        /// </summary>
        /// <param name="currentDirectoryInfo"></param>
        /// <param name="directory_file_info"></param>
        private void GetFileInfo(DirectoryInfo currentDirectoryInfo, DirectoryFileInfo directory_file_info)
        {
            foreach (FileInfo fileInfo in currentDirectoryInfo.GetFiles())
            {
                if (SkipHiddenFiles(fileInfo))
                    continue;

                directory_file_info.Files.Add(fileInfo);
            }
        }

        private bool SkipHiddenFiles(FileInfo fileInfo)
        {
            return IndexerSettings.SkipHiddenFiles && fileInfo.Attributes.HasFlag(FileAttributes.Hidden);
        }

        private bool SkipHiddenFolders(DirectoryInfo directoryInfo)
        {
            return IndexerSettings.SkipHiddenFolders && directoryInfo.Attributes.HasFlag(FileAttributes.Hidden);
        }

        public IndexerSettings IndexerSettings { get; private set; }

        public DirectoryFileInfo DirectoryFileInfo { get; private set; }
        public String FolderPath
        {
            get
            {
                if (DirectoryFileInfo != null)
                    return DirectoryFileInfo.FolderPath;

                return string.Empty;
            }
        }
    }
}