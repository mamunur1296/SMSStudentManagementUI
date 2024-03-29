﻿using Microsoft.EntityFrameworkCore;
using SMS.BusinessObjectLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.DataAccessLayer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)  { }
        public DbSet<ContactInfo> Contacts { get; set; }

    }
}
