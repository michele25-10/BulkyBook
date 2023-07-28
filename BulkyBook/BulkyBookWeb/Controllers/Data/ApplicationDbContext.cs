﻿using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BulkyBookWeb.Controllers.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        //Crea la tabella categories prendendo i dati settati nel model Category
        public DbSet<Category> Categories { get; set; }
         
    }
}
