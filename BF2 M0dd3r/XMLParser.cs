using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace BF2_M0dd3r
{
    class XMLParser
    {
        
        XmlTextWriter textWriter = new XmlTextWriter(@"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\config.xml", null);

        public void writeVal(string element, string value)
        {
            textWriter.WriteStartDocument();
            textWriter.WriteStartElement("configuration_settings");

            textWriter.WriteStartElement(element);
            textWriter.WriteValue(value);
            textWriter.WriteEndElement();

            textWriter.WriteEndElement();
            textWriter.Close();
        }

        public string readVal(string value)
        {
            XmlTextReader read = new XmlTextReader(@"C:\Program Files\SirCapsAlot.NET\BF2 M0dd3r\config.xml");

            while (read.Read())
            {
                if (read.Name == value)
                {
                    string blah = read.ReadString();
                    read.Close();
                    return blah;
                }
            }

            return null;
        }
    }
}
