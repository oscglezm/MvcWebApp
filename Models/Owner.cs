using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvcWebApp.Models
{
    [Table("Owners")]
    public class Owner
    {

        public int id { get; set; }
        public string name { get; set; }
        public string lookupcode { get; set; }
        public int statusid { get; set; }

    }
}