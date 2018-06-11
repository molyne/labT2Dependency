﻿using LabT2Dependency.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabT2Dependency.Data
{
    public class TravelContext : DbContext
    {
        public TravelContext(DbContextOptions<TravelContext> options) : base(options)
        {
        }

        public DbSet<Journey> Journeys { get; set; }
        public DbSet<Costumer> Costumers { get; set; }
    }
}
