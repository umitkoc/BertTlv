using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tlv_project
{
    public class Tlv : ITlv, IFile
    {
        List<TlvModel> modelList=new();
        string parser = "";
        string length = "";
        String empty = "";
        string ascii = "";
        int decValue = 0;
        int step = 0;
        public Tlv(String data)
        {
            TlvParser(data.Replace(" ",""));
        }
        public void readTag()
        {
            String line = "";
            StreamReader sr = new StreamReader("taglist.txt");
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
        public void insertTag(List<TlvModel> model)
        {
            try
            {
                StreamWriter sw = new StreamWriter("test.txt");
                foreach (var item in model)
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

        private int TlvParser(String data, int i = 0, string tag = "")
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

                    decValue = int.Parse(data.Substring(i + 1, 2), System.Globalization.NumberStyles.HexNumber);
                    // lengthControl(data,i+3,decValue);
                    if (model.description.Contains("Template"))
                    {
                        parser += $"{empty}|------ tag: {model.tag}({model.description})\n";
                        step += 1;
                        empty = Empty();
                        return TlvParser(data, i + 3, "");
                    }
                    else
                    {
                        parser += $"{empty}|------ tag: {model.tag}({model.description}){empty}|------ value -->  {ConvertHex(data.Substring(i + 3, decValue * 2))} \n";
                    }
                    i += 3 + decValue * 2;
                    return TlvParser(data, i, "");

                }
                else
                {
                    return TlvParser(data, i + 1, tag);
                }
            }
            return writeFile(parser);

        }

        public TlvModel getTag(string tag)
        {
            return modelList.Find(i => i.tag == tag);
        }

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
        // public bool lengthControl(string data,int start,int length){
        //     if(step==0){
        //        return data.Substring(start,);
        //     }else{
        //         return false;
        //     }
        // }

        public void setTag(TlvModel model)
        {
            modelList.Add(model);
            insertTag(modelList);
        }
    }
}