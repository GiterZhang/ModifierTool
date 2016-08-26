using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ModifierTool
{
    [XmlType]
    public class FunctionPage
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlArray]
        public List<FunctionItem> Items { get; set; }
    }
}
