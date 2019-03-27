using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostCodeJsonTest
{
    public class PostCodeFileManager
    {
        public string LoadJson(string filename)
        {
            string json;
            using (StreamReader r = new StreamReader(filename))
            {
                json = r.ReadToEnd();           
            }
            return json;
        }
    }
}
