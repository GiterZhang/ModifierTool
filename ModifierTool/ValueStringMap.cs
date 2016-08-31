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

        public Dictionary<string,string> GetMap()
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            if (Map != null)
            {
                foreach (var str in Map)
                {
                    var line = str.Split(Separator.ToCharArray());
                    map.Add(line[0],line[2]);
                }
            }
            return map;
        }
        public void FillMap(Dictionary<string,string> objects)
        {
            if (objects != null)
            {
                Map = new List<string>();
                foreach (var line in objects)
                {
                    Map.Add(line.Key + Separator + line.Value);
                }
            }           
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
