using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ramada_Hotel_WebUI.Dtos.ContactDto
{
    public class InboxContactDto
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
