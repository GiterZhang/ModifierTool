using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ModifierTool
{
    [XmlType]
    public class ValueStringMap
    {
        [XmlArray]
        public List<string> Map { get; set; }

        public static string Separator = "=>";

        public Dictionary<string,string> GetMapDictionary()
        {
            //处理map
            return new Dictionary<string, string>();
        }
        public void AddMap(string key,string value)
        {
            if (Map == null)
            {
                Map = new List<string>();
            }
            if(key != null && value != null)
                Map.Add(key + Separator + value);
        }
        public void ClearMap()
        {
            Map = null;
        }
        public override string ToString()
        {
            string res = "";
            if (Map != null && Map.Count != 0)
            {
                foreach(var str in Map)
                {
                    if (res != "")
                    {
                        res += "\r\n";
                    }
                    res += str;
                }
            }
            return res;
        }
    }
}
