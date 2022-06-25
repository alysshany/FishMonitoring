using System;
using System.IO;

namespace ParsingLibrary
{
    public class Parsing
    {
        public static string[] Parse(string path)
        {
            string[] infoTemp = null;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                int i = 1;
                int k = 0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (i % 2 == 0)
                    {
                        infoTemp[k] = ";" + line;
                    }
                    else
                    {
                        infoTemp[k] = line;
                    }
                    i++;
                    k++;
                }
            }
            return infoTemp;
        }
    }
}
