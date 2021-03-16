﻿using Padaria.Domain.Enum;
using Padaria.Domain.Interface;
using System.Collections.Generic;

namespace Padaria.Domain.Model
{
    public class Caixa : IBaseEntity
    {
        public int Id { get; set; }
        public StatusDoCaixaEnum Status { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public List<Venda> Vendas { get; set; }
    }
}
