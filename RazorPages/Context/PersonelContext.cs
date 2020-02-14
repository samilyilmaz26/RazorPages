using Microsoft.EntityFrameworkCore;
using RazorPages.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages.Context
{
    public class PersonelContext:DbContext

    {
        public PersonelContext(DbContextOptions<PersonelContext> options):base(options)
        {

        }
        DbSet<Personel> Personels { get; set; }
        DbSet<Roles> Roles { get; set; }
    }
}
