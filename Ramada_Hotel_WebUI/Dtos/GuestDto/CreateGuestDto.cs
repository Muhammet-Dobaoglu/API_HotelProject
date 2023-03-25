using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ramada_Hotel_WebUI.Dtos.GuestDto
{
    public class CreateGuestDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }
}
