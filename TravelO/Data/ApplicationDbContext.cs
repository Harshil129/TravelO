using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TravelO.Models;

namespace TravelO.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Province> Provinces { get; set; }

        public DbSet<Place> Places { get; set; }

        public DbSet<ToDoList> ToDoLists { get; set; }

        public DbSet<Cost> Costs { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
