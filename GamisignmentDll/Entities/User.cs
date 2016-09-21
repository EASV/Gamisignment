﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamisignmentDll.Entities
{
    public class User : AbstractEntity
    {
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<Chore> CompletedChores { get; set; }

    }
}
