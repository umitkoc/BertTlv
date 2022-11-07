using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BertTlv
{
    internal interface ITlv
    {
        public TlvModel getTag(String tag);
        public void setTag(TlvModel model);
        public String ConvertHex(String hex);
    }
}
