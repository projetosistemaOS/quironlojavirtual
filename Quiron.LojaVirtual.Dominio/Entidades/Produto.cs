﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Entidades
{
    class Produto
    {
        public int ProdutoId { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string Categoria { get; set; }

    }
}