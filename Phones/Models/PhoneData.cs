using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Phones.Models
{
    public class PhoneData
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public float Price { get; set; }
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string ScreenSize { get; set; }
        public string ImageName { get; set; }
        public string Weight { get; set; }
        public string ScreenResolution { get; set; }
        public string ProcessorModel { get; set; }
        public string Ram { get; set; }
        public string Memory { get; set; }
        public string OperationSystem { get; set; }
    }
}