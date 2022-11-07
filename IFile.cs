using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BertTlv
{
    internal interface IFile
    {
        public void readTag();
        public void insertTag();
        public int writeFile(String parser);
    }
}
