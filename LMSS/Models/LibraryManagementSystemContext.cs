using System;
using LMSS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LMSS.Models
{
    public partial class LibraryManagementSystemContext : DbContext
    {
        

        public LibraryManagementSystemContext(DbContextOptions<LibraryManagementSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<LendRequest> LendRequests { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }

    }
}
