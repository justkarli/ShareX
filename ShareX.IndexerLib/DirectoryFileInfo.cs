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

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShareX.IndexerLib
{
    /// <summary>
    /// Structure to model a directory containing subdirectories and files. 
    /// </summary>
    public class DirectoryFileInfo
    {
        public DirectoryFileInfo(string folderPath)
        {
            FolderPath = folderPath;
            Files = new List<FileInfo>();
            Folders = new List<DirectoryFileInfo>();
        }

        public string FolderPath { get; set; }
        public long DataSize { get; private set; }
        public int TotalFileCount { get; private set; }
        public int TotalFolderCount { get; private set; }

        public DirectoryFileInfo Parent { get; set; }
        public List<FileInfo> Files { get; set; }
        public List<DirectoryFileInfo> Folders { get; set; }

        public string FolderName
        {
            get { return Path.GetFileName(FolderPath); }
        }

        public bool IsEmpty
        {
            get { return TotalFileCount == 0 && TotalFolderCount == 0; }
        }


        /// <summary>
        /// Collects information of all subdirectories and files in this directory recursively
        /// </summary>
        public void CollectInfo()
        {
            Folders.ForEach(x => x.CollectInfo());
            DataSize = Folders.Sum(x => x.DataSize) + Files.Sum(x => x.Length);
            TotalFileCount = Files.Count + Folders.Sum(x => x.TotalFileCount);
            TotalFolderCount = Folders.Count + Folders.Sum(x => x.TotalFolderCount);
        }
    }
}