using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContactBook.Models;

namespace ContactBook.Data
{
    public class ContactBookContext : DbContext
    {
        public ContactBookContext (DbContextOptions<ContactBookContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<ContactBook.Models.Contact> Contact { get; set; }
    }
}
