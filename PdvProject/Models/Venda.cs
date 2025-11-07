using System;
using System.Collections.Generic;

namespace PdvProject.Models
{
    public class Venda
    {
        public DateTime Data { get; set; } = DateTime.Now;
        public List<Produto> Itens { get; set; } = new List<Produto>();
        public decimal Total
        {
            get
            {
                decimal total = 0;
                foreach (var item in Itens)
                    total += item.Preco;
                return total;
            }
        }
    }
}