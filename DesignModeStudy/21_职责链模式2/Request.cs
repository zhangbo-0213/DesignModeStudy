using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_职责链模式2
{
    public class Request
    {
        private string requestType;
        public string RequestType {
            get { return requestType; }
            set { requestType = value; }
        }

        private string requestContent;
        public string RequestContent {
            get { return requestContent; }
            set { requestContent = value; }
        }

        private int requestNumber;
        public int RequestNumber {
            get { return requestNumber; }
            set { requestNumber = value; }
        }
    }
}
