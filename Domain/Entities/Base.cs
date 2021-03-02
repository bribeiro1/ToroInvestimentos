using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public class Base
    {
        [Key]
        public Guid Id { get; set; }
    }
}
