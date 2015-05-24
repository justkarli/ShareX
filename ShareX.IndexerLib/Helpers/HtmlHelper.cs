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
using System.IO;
using System.Text;

namespace ShareX.IndexerLib
{
    public static class HtmlHelper
    {
        private const string HTML_CSS_IMPORT_FORMAT = "<style type=\"text/css\">\r\n{0}\r\n</style>";
        private const string HTML_STYLE_TAG_FORMAT = "style=\"{0}\"";
        private const string HTML_START_TAG_FORMAT = "<{0} {2} {1}>";
        private const string HTML_END_TAG_FORMAT = "</{0}>";

        public static string GetCssStyle(string css_file)
        {
            string css_import;

            if (!string.IsNullOrEmpty(css_file) && File.Exists(css_file))
                css_import = File.ReadAllText(css_file, Encoding.UTF8);
            else
                css_import = Resources.IndexerDefault;

            return string.Format(HTML_CSS_IMPORT_FORMAT, css_import);
        }

        public static string StartTag(string html_tag_name, string style_name = "", string attributes = "")
        {
            string css = string.Empty;

            if (!string.IsNullOrEmpty(style_name))
                css = string.Format(HTML_STYLE_TAG_FORMAT, style_name);

            return string.Format(HTML_START_TAG_FORMAT, html_tag_name, attributes, css);
        }

        public static string EndTag(string tag)
        {
            return string.Format(HTML_END_TAG_FORMAT, tag);
        }

        public static string Tag(string tag, string content, string style = "", string attributes = "")
        {
            return StartTag(tag, style, attributes) + URLHelpers.HtmlEncode(content) + EndTag(tag);
        }
    }
}