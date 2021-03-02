using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Product : Base
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
