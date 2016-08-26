using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ModifierTool
{
    [XmlType]
    public class FunctionItem
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlElement]
        public string ValueType { get; set; }
        [XmlElement]
        public bool ReadOnly { get; set; }
        [XmlElement]
        public double MaxValue { get; set; }
        [XmlElement]
        public double MinValue { get; set; }
        [XmlElement]
        public int Size { get; set; }
        [XmlElement]
        public string FormStyle { get; set; }

        [XmlElement]
        public MemoryAddress Address { get; set; }

        //只有非浮点型和控件样式为combox才具备这个属性
        [XmlElement]
        public ValueStringMap ValueStringMap { get;set; }


    }
}
