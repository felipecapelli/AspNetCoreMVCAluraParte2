﻿using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.aula1.antes.Models.ViewModels
{
    public class CarrinhoViewModel
    {
        public IList<ItemPedido> Itens { get; }
        public decimal Total => Itens.Sum(i => i.Quantidade * i.PrecoUnitario);

        public CarrinhoViewModel(IList<ItemPedido> itens)
        {
            Itens = itens;
        }
    }
}
