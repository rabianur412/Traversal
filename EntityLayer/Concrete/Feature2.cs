﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Feature2
    {
        [Key]
        public int Feature2Id { get; set; }
        public string Feature2Title { get; set; }
        public string Feature2Description { get; set; }
        public string Feature2Image { get; set; }
        public bool Feature2Status { get; set; }
    }
}
