﻿using ControleDeContatos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleDeContatos.Data
{
        public class BancoContext : DbContext
        {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        {

        }
        public DbSet<ContatoModel> Contatos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }

        }
}
