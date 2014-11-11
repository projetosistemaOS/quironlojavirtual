﻿using Quiron.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
       private  ProdutosRepositorio repositorio; 
        public int ProdutosPorPagina = 8;
        // GET: Vitrine
        public ActionResult ListaProdutos(int pagina = 1)
        {
            repositorio = new ProdutosRepositorio();
            var produtos = repositorio.Produtos.OrderBy(p => p.Nome).Skip((pagina-1)*ProdutosPorPagina).Take(ProdutosPorPagina);

            return View(produtos);
        }
    }
}