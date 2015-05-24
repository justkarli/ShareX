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
using ShareX.IndexerLib.Properties;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ShareX.IndexerLib
{
    public class IndexerHtml : Indexer
    {
        protected StringBuilder _output_content_builder;

        public IndexerHtml(IndexerSettings indexerSettings)
            : base(indexerSettings)
        {
        }

        protected string PrintFolderInfo(DirectoryFileInfo dir, int level = 0)
        {
            _output_content_builder.AppendLine(GetFolderNameRow(dir, level));

            string divClass = GetDivBorderClass(level);
            _output_content_builder.AppendLine(HtmlHelper.StartTag("div", "", "class=\"" + divClass + "\""));

            if (dir.Files.Count > 0)
            {
                _output_content_builder.AppendLine(HtmlHelper.StartTag("ul"));

                foreach (FileInfo fi in dir.Files)
                    _output_content_builder.AppendLine(GetFileNameRow(fi, level));

                _output_content_builder.AppendLine(HtmlHelper.EndTag("ul"));
            }

            foreach (DirectoryFileInfo subdir in dir.Folders)
                PrintFolderInfo(subdir, level + 1);

            _output_content_builder.AppendLine(HtmlHelper.EndTag("div"));

            return _output_content_builder.ToString();
        }

        private static string GetDivBorderClass(int level)
        {
            return level > 0 ? "FolderBorder" : "MainFolderBorder";
        }

        public override string PrintFolderInfo()
        {
            _output_content_builder = new StringBuilder();

            StringBuilder html_body_builder = new StringBuilder();
            
            html_body_builder.AppendLine(Resources.doctype_xhtml);
            html_body_builder.AppendLine(HtmlHelper.Tag("title", "Index for " + Path.GetFileName(FolderPath)));
            html_body_builder.AppendLine(HtmlHelper.GetCssStyle(config.CssFilePath));
            html_body_builder.AppendLine(HtmlHelper.EndTag("head"));
            html_body_builder.AppendLine(HtmlHelper.StartTag("body"));

            string content = PrintFolderInfo(DirectoryFileInfo).Trim();
            html_body_builder.AppendLine(content);

            if (config.AddFooter)
                html_body_builder.AppendLine(HtmlHelper.StartTag("div") + GetFooter() + HtmlHelper.EndTag("div"));

            if (config.AddValidationIcons) 
                html_body_builder.AppendLine(Resources.valid_xhtml);

            html_body_builder.AppendLine(HtmlHelper.EndTag("body"));
            html_body_builder.AppendLine(HtmlHelper.EndTag("html"));

            return html_body_builder.ToString().Trim();
        }

        protected override string GetFolderNameRow(DirectoryFileInfo directory_info, int level = 0)
        {
            int heading = (level + 1).Between(1, 6);
            string folderInfoText = string.Empty;

            if (!directory_info.IsEmpty)
            {
                folderInfoText = directory_info.DataSize.ToSizeString(config.BinaryUnits) + " (";

                if (directory_info.TotalFileCount > 0)
                    folderInfoText += directory_info.TotalFileCount + " file" + (directory_info.TotalFileCount > 1 ? "s" : "");

                if (directory_info.TotalFolderCount > 0)
                {
                    if (directory_info.TotalFileCount > 0)
                        folderInfoText += ", ";

                    folderInfoText += directory_info.TotalFolderCount + " folder" + (directory_info.TotalFolderCount > 1 ? "s" : "");
                }

                folderInfoText += ")";
                folderInfoText = "  " + HtmlHelper.Tag("span", folderInfoText, "", "class=\"folderinfo\"");
            }

            return HtmlHelper.StartTag("h" + heading) + URLHelpers.HtmlEncode(directory_info.FolderName) + folderInfoText + HtmlHelper.EndTag("h" + heading);
        }

        protected override string GetFileNameRow(FileInfo fi, int level = 0)
        {
            string size = " " + HtmlHelper.Tag("span", fi.Length.ToSizeString(config.BinaryUnits), "", "class=\"filesize\"");
            return HtmlHelper.StartTag("li") + URLHelpers.HtmlEncode(fi.Name) + size + HtmlHelper.EndTag("li");
        }

        protected override string GetFooter()
        {
            return string.Format("Generated by {0} on {1}.", string.Format(INDEXER_LINK_FORMAT, Links.URL_WEBSITE, "ShareX " + Application.ProductVersion), DateTime.UtcNow.ToString(DATE_FORMAT));
        }
    }
}