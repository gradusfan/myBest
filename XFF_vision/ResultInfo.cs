using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFF_Vision
{
    [Serializable]
    class ResultInfo
    {
      
        public string Name { get; set; }
        public string UIName { get; set; }
        public bool IsNum { get; set; }
        public int Num { get; set; }
    }
}
 