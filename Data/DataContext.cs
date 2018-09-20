﻿using Microsoft.EntityFrameworkCore;
using MVC_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Practice.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) 
        {
        }
        public DbSet<Value> Values { get; set; }
    }
}
