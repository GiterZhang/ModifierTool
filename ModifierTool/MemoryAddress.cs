using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ModifierTool
{
    [XmlType]
    public class MemoryAddress
    {
        [XmlAttribute]
        public bool IsPtr { get; set; }
        [XmlElement]
        public bool IsContainModuleAddr { get; set; }
        [XmlElement]
        public long Address { get; set; }
        [XmlElement]
        public long RealAddress { get; set; }       //暂时做保留
        [XmlArray]
        public List<int> Offsets { get; set; }

        public string GetAddrString(string moduleName = "module")
        {
            string addrString = "";

            if (IsContainModuleAddr)
                addrString = string.Format("[{0} + {1}]", moduleName, Address.ToString("x2"));
            else
                addrString = string.Format("[{0}]", Address.ToString("x2"));

            if (IsPtr)
            {
                foreach (var offset in Offsets)
                {
                    addrString = string.Format("[{0} + {1}]",addrString, offset.ToString("x2"));
                }
                if (Offsets.Count == 0)
                {
                    addrString = string.Format("[{0}]", addrString);
                }
            }
            return addrString;
        }
    }
}
