﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cs3750LMS.Models.validation
{
    public class SearchValidation
    {
        public int Department { get; set; }
        
        public string Title { get; set; }
    }
}
