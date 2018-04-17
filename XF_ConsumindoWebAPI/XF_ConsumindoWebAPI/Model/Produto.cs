using System;
using System.Collections.Generic;
using System.Text;

namespace XF_ConsumindoWebAPI.Model
{
    public class Produto
    {
       public int Id { get; set; }
       public string Nome { get; set; }
       public string Categoria { get; set; }
       public decimal Preco { get; set; }

    }
}
