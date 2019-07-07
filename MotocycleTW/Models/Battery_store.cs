using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MotocycleTW.Models
{
    public class Battery_store
    {
        [Key]
        public int bs_id { get; set; }
        [Display(Name = "店名")]
        public string s_name { get; set; }
        [Display(Name = "區域")]
        public string bs_block { get; set; }
        [Display(Name = "地址")]
        public string bs_address { get; set; }
        [Display(Name ="交換站圖片")]
        public string bs_picture { get; set; }
    }
}