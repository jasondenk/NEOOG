using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Exchange
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Item")]
        public string NameType { get; set; }
        [Display(Name = "Gardener's Notes")]
        public string Info { get; set; }
        [Display(Name = "Have or Need?")]
        public string GetGive { get; set; }
        public string Quantity { get; set; }
        [Display(Name = "Date Posted")]
        public DateTime PostTime { get; set; }
        [Display(Name = "Username")]
        public string ExchangeUserName { get; set; }


    }
}