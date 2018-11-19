using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phones.ViewModels
{
    public class SearchTermsVM
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public float minPrice { get; set; }
        public float maxPrice { get; set; }
    }
}