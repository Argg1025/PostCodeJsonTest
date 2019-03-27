using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostCodeJsonTest
{
    public class PostcodeDTO
    {
        public PostCodeRoot PostCode { get; set; }
        public Result Results { get; set; }
        public Codes Code { get; set; }

        public void DeserializePostCode(string PostCodeResponse)
        {
            PostCode = JsonConvert.DeserializeObject<PostCodeRoot>(PostCodeResponse);
            Results = PostCode.result;
            Code = PostCode.result.codes;

        }
    }
}
