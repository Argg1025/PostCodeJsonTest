using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostCodeJsonTest
{
    public class PostcodeService
    {
        public PostCodeFileManager postCodeFileManger = new PostCodeFileManager();
        public PostcodeDTO postCodeDTO = new PostcodeDTO();
        public JObject PostCodeJson;

        public PostcodeService()
        {
            postCodeDTO.DeserializePostCode(postCodeFileManger.LoadJson(@"C:\Users\tech-w47a.LAPTOP-PQTVAAN5\source\repos\PostCodeJsonTest\PostCodeJsonTest\Resources\PostCodesJson.json"));
            PostCodeJson = JObject.Parse(postCodeFileManger.LoadJson(@"C:\Users\tech-w47a.LAPTOP-PQTVAAN5\source\repos\PostCodeJsonTest\PostCodeJsonTest\Resources\PostCodesJson.json"));

        }

        public bool PostCodeFormat(string postcode)
        {
            string str1 = postcode.Split(' ')[0], str2 = postcode.Split(' ')[1];
            if (str2.Length == 3 && (str1.Length >= 2 && str1.Length <= 4)) return true;
            else return false;
        }

        public bool QualityBetween1And9(int quality)
        {
            if (quality >= 1 && quality <= 9) return true;
            else return false;
        }
        public bool StringOrInt<T>(T obj)
        {
            if (obj == null) return true;
            else if (obj.GetType() == typeof(int)) return true;
            else return false;
        }

        public bool StringOrNull<T>(T obj)
        {
            if (obj == null) return true;
            else if (obj.GetType() == typeof(string)) return true;
            else return false;
        }

        public bool CheckDecimalPlaces(float num)
        {
            string decimals = num.ToString().Split('.')[1];
            if (decimals.Length <= 6) return true;
            else return false;
        }

        public bool CountryChecker(string country)
        {
            if (country == "England" || country == "Northern Ireland" || country == "Wales" || country == "Scotland") return true;
            else return false;
        }
    }
}
