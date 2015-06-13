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
    public class LayoutData
    {
        [DataMember]
        public int canvasW { get; set; }

        [DataMember]
        public int canvasH { get; set; }

        [DataMember]
        public int gridW { get; set; }

        [DataMember]
        public int gridH { get; set; }

        [DataMember]
        public LayoutObj[] objs { get; set; }
    }
}
