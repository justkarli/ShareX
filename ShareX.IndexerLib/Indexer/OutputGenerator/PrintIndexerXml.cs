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
using System.Xml;

namespace ShareX.IndexerLib
{
    public class PrintIndexerXml : PrintIndexerOutput
    {
        protected override string PrintFolderInfo()
        {
            XmlWriterSettings xml_writer_settings = new XmlWriterSettings();
            xml_writer_settings.Encoding = new UTF8Encoding(false);
            xml_writer_settings.ConformanceLevel = ConformanceLevel.Document;
            xml_writer_settings.Indent = true;

            using (MemoryStream ms = new MemoryStream())
            {
                using (_xml_writer = XmlWriter.Create(ms, xml_writer_settings))
                {
                    _xml_writer.WriteStartDocument();
                    PrintFolderInfo(Indexer.DirectoryFileInfo);
                    _xml_writer.WriteEndDocument();
                    _xml_writer.Flush();
                }

                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }

        protected string PrintFolderInfo(DirectoryFileInfo dir, int level = 0)
        {
            _xml_writer.WriteStartElement("Folder");

            if (IndexerSettings.UseAttribute)
            {
                _xml_writer.WriteAttributeString("Name", dir.FolderName);

                if (!dir.IsEmpty)
                    _xml_writer.WriteAttributeString("Size", dir.DataSize.ToSizeString(IndexerSettings.BinaryUnits));
            }
            else
            {
                _xml_writer.WriteElementString("Name", dir.FolderName);

                if (!dir.IsEmpty)
                    _xml_writer.WriteElementString("Size", dir.DataSize.ToSizeString(IndexerSettings.BinaryUnits));
            }

            if (dir.Files.Count > 0)
            {
                _xml_writer.WriteStartElement("Files");

                foreach (FileInfo fi in dir.Files)
                {
                    _xml_writer.WriteStartElement("File");

                    if (IndexerSettings.UseAttribute)
                    {
                        _xml_writer.WriteAttributeString("Name", fi.Name);
                        _xml_writer.WriteAttributeString("Size", fi.Length.ToSizeString(IndexerSettings.BinaryUnits));
                    }
                    else
                    {
                        _xml_writer.WriteElementString("Name", fi.Name);
                        _xml_writer.WriteElementString("Size", fi.Length.ToSizeString(IndexerSettings.BinaryUnits));
                    }

                    _xml_writer.WriteEndElement();
                }

                _xml_writer.WriteEndElement();
            }

            if (dir.Folders.Count > 0)
            {
                _xml_writer.WriteStartElement("Folders");

                foreach (DirectoryFileInfo subdir in dir.Folders)
                    PrintFolderInfo(subdir);

                _xml_writer.WriteEndElement();
            }

            _xml_writer.WriteEndElement();
            return _xml_writer.ToString();
        }

        private XmlWriter _xml_writer;
    }
}