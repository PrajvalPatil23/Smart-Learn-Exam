﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("StateTbl")]
    public class State
    {
        [Key]
        public Int64 StateID {  get; set; }
        
        public String StateName { get; set; }
        [ForeignKey("Country")]
        public Int64 CountryID {  get; set; }
        public virtual Country Country { get; set; }
        public virtual List<City> Cities { get; set; }

    }
}