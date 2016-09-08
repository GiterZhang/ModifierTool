using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ModifierTool
{
    [XmlType]
    public class ModifierConfig
    {
        [XmlAttribute]
        public string FileIdentifier { get; set; }
        [XmlElement]
        public string GameName { get; set; }
        [XmlElement]
        public string ProcessName { get; set; }
        [XmlElement]
        public string ModuleName { get; set; }
        [XmlElement]
        public string IconFileName { get; set; }

        [XmlArray]
        public List<Version> Versions { get; set; }
    }
    [XmlType]
    public class Version
    {       
        [XmlElement]
        public string VersionName { get; set; }
        [XmlElement]
        public string FileMd5 { get; set; }

        [XmlArray]
        public List<FunctionPage> Pages { get; set; }       
    }
}
