﻿using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DatingAppDbContext:DbContext
    {
        public DatingAppDbContext(DbContextOptions<DatingAppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}
