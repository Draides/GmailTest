using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGmail
{
    public class Message
    {
        public readonly string To;
        public readonly string Subject;
        public readonly string Body;

        public Message(string To, string Subject, string Body)
        {
            this.To = To;
            this.Subject = Subject;
            this.Body = Body;
        }
    }
}
