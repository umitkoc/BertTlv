using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tlv_project
{
    public interface ITlv
    {
        public TlvModel getTag(String tag);
        public void  setTag(TlvModel model);
        public String ConvertHex(String hex);

    }

}