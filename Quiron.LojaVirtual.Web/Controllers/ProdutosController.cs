﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private ProdutosRepositorio repositorio;
        // GET: Produtos
        public ActionResult Index()
        {
            repositorio = new ProdutosRepositorio();
            var produtos = repositorio.Produtos;
            
            return View(produtos);
        }
    }
}