using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace m256GameUILayoutEditor
{
    [DataContract]
    public class LayoutObj
    {
        [DataMember]
        public string name { get; set; }

        [DataMember]
        public int type { get; set; }

        [DataMember]
        public int x { get; set; }

        [DataMember]
        public int y { get; set; }

        [DataMember]
        public int w { get; set; }

        [DataMember]
        public int h { get; set; }

        [DataMember]
        public string path { get; set; }

        [DataMember]
        public string text { get; set; }

        [DataMember]
        public string fontName { get; set; }

        [DataMember]
        public int fontSize { get; set; }

        [DataMember]
        public int fontColorR { get; set; }

        [DataMember]
        public int fontColorG { get; set; }

        [DataMember]
        public int fontColorB { get; set; }
    }
}
