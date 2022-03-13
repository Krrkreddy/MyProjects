using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ContactsApp
{
    public partial class ContactsAppData : DbContext
    {
        public ContactsAppData()
            : base("name=ContactsApp")
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<UserRegistration> UserRegistrations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
