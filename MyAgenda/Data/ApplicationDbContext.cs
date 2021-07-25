using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyAgenda.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAgenda.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Fazendo o Entityfremawork olhar na arquivo Agenda da pasta models e criar uma tabela com o nome de 'Contatos'
        public DbSet <Agenda> Contatos { get; set; }
    }
}
