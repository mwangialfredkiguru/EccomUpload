using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EccomUpload.Models
{
    public class Products_Table
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Upload")]
        public string Product_Image { get; set; }
        [DisplayName("Item")]
        public HttpPostedFileBase ImageFile { get; set; }
        [DisplayName("Item name")]
        public string Product_Name { get; set; }
        [DisplayName("Item description")]
        public string Product_Desc { get; set; }
        [DisplayName(" Item Price")]
        public string Product_Price { get; set; }
    }
}