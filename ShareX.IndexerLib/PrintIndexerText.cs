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

using ShareX.HelpersLib;
using System.IO;
using System.Text;

namespace ShareX.IndexerLib
{
    public class PrintIndexerText : PrintIndexerOutput
    {
        protected override string PrintFolderInfo()
        {
            _output_content_builder = new StringBuilder();
            StringBuilder output_content_wrapper_builder = new StringBuilder();

            string content = PrintFolderInfo(Indexer.DirectoryFileInfo).Trim();
            output_content_wrapper_builder.AppendLine(content);

            if (IndexerSettings.AddFooter)
            {
                string footer = GetFooter();
                output_content_wrapper_builder.AppendLine("_".Repeat(footer.Length));
                output_content_wrapper_builder.AppendLine(footer);
            }

            return output_content_wrapper_builder.ToString().Trim();
        }

        protected string PrintFolderInfo(DirectoryFileInfo dir, int level = 0)
        {
            _output_content_builder.AppendLine(GetFolderNameRow(dir, level));

            foreach (DirectoryFileInfo subdir in dir.Folders)
            {
                if (IndexerSettings.AddEmptyLineAfterFolders)
                    _output_content_builder.AppendLine();

                PrintFolderInfo(subdir, level + 1);
            }

            if (dir.Files.Count > 0)
            {
                if (IndexerSettings.AddEmptyLineAfterFolders)
                    _output_content_builder.AppendLine();

                foreach (FileInfo fi in dir.Files)
                    _output_content_builder.AppendLine(GetFileNameRow(fi, level + 1));
            }

            return _output_content_builder.ToString();
        }

        protected StringBuilder _output_content_builder;
    }
}