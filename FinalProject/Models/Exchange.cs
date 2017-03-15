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
        public string NameType { get; set; }
        public string Info { get; set; }
        public string GetGive { get; set; }
        public string Quantity { get; set; }
        public DateTime PostTime { get; set; }
        public string ExchangeUserName { get; set; }


    }
}