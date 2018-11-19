using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phones.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PhoneData> PhoneData { get; set; }
    }
}