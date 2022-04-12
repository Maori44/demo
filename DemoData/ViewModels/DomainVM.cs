using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DemoData.ViewModels
{
    public class DomainVM
    {
        [Key]
        public int ID { get; set; }
        public string CarNumber { get; set; }
        public DateTime Date { get; set; }
        public string Toll { get; set; }
    }
}
