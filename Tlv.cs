using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BertTlv
{
    internal class Tlv :IFile,ITlv
    {
        List<TlvModel> modelList = new();
        string parser = "";
        String empty = "";
        string ascii = "";
        int decValue = 0;
        int step = 0;
        public Tlv()
        {
           
        }
        public void readTag()
        {
            String line = "";
            
            StreamReader sr = new StreamReader("./taglist.txt");
            while ((line = sr.ReadLine()) != null)
            {
                modelList.Add(new()
                {
                    tag = line.Split(",")[0].Trim(),
                    description = line.Split(",")[1].Trim()
                });

            }
            sr.Close();


        }
        public void insertTag()
        {
            try
            {
                StreamWriter sw = new StreamWriter("test.txt");
                foreach (var item in modelList)
                {
                    sw.WriteLine($"{item.tag},{item.description}");
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }
        public int writeFile(String parser)
        {
            StreamWriter sw = new StreamWriter("output.txt");
            sw.WriteLine(parser);
            sw.Close();
            return 0;
        }

        public string TlvParser(String data, int i = 0, string tag = "")
        {
            if (i == 0)
            {
                readTag();
            }
            if (i < data.Length)
            {
                tag += data[i];
                TlvModel model = getTag(tag);
                if (model != null)
                {
                    model.length = data.Substring(i + 1, 2);
                    decValue = int.Parse(model.length, System.Globalization.NumberStyles.HexNumber);
                 
                    if (model.description.Contains("Template"))
                    {
                        parser += $"\r\n{empty}tag [0x{model.length[0]}{model.length[1]}] : {model.tag}\r\n({model.description})\r\n";
                        step += 1;
                        empty = "";
                        return TlvParser(data, i + 3, "");
                    }
                    else
                    {
                        
                        parser += $"\r\n{empty}tag [0x{model.length[0]}{model.length[1]}] : {model.tag} \r\n({model.description}){empty} \r\nvalue:{data.Substring(i + 3, decValue * 2)}\r\n ASCII:{ConvertHex(data.Substring(i + 3, decValue * 2))}\r\n";
                    }
                    i += 3 + decValue * 2;
                    return TlvParser(data, i, "");

                }
                else
                {
                    return TlvParser(data, i + 1, tag);
                }
            }
            return parser;
           // return writeFile(parser);

        }

        public TlvModel getTag(string tag) => modelList.Find(i => i.tag == tag);

        public string ConvertHex(string hex)
        {

            ascii = "";
            for (int i = 0; i < hex.Length; i += 2)
            {
                ascii += System.Convert.ToChar(System.Convert.ToUInt32(hex.Substring(i, 2), 16));
            }
            return ascii;
        }

        private string Empty()
        {
            for (int s = 0; s < step; s++)
            {
                empty += "\t";
            }
            return empty;
        }
      

        public void setTag(TlvModel model)
        {
            modelList.Add(model);
            insertTag();
        }
    }
}
