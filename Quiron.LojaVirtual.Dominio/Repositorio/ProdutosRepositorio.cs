﻿using Quiron.LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EfDbContext context = new EfDbContext();

        public IEnumerable<Produto> Produtos
        {
            get { return context.Produtos; }
        }

    }
}
