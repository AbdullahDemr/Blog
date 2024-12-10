using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TigrisTech.Services.Utilities.Tools
{
    public class ResponseModel
    {
        public bool IsSuccess { get; set; }
        public object Data { get; set; }
        public string ErrorMessage { get; set; }
        public HttpStatusCode Code { get; set; }

        public string HttpStatusCodeText
        {
            get
            {
                return Code.ToString();
            }
        }
    }
}
