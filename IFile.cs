using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tlv_project
{
    public interface IFile
    {
        public void readTag();
        public void insertTag();
        public int writeFile(String parser);
    }
}