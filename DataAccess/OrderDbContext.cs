using BoraIlkProje2.Models;
using FakeData;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BoraIlkProje2.DataAccess
{
    public class OrderDbContext : IdentityDbContext<AppUser, AppRole, int>  //identity
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {
        }

        public DbSet<AppUser> AppUser { get; set; } //TABLOLARI VERİTABANINDA TEMSİL EDECEK PROPERTYLER
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<AppRole> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Standart Identity Ayarları

            builder.Entity<AppUser>(b =>
            {
                // Primary key
                b.HasKey(u => u.Id);

                // Indexes for "normalized" username and email, to allow efficient lookups
                b.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
                b.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

                // Maps to the AspNetUsers table
                b.ToTable("AspNetUsers");

                // A concurrency token for use with the optimistic concurrency checking
                b.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

                // Limit the size of columns to use efficient database types
                b.Property(u => u.Id).HasMaxLength(256);
                b.Property(u => u.NormalizedUserName).HasMaxLength(256);
                b.Property(u => u.Email).HasMaxLength(256);
                b.Property(u => u.NormalizedEmail).HasMaxLength(256);

                // The relationships between User and other entity types
                // Note that these relationships are configured with no navigation properties

                // Each User can have many UserClaims
                b.HasMany<IdentityUserClaim<int>>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

                // Each User can have many UserLogins
                b.HasMany<IdentityUserLogin<int>>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

                // Each User can have many UserTokens
                b.HasMany<IdentityUserToken<int>>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

                // Each User can have many entries in the UserRole join table
                b.HasMany<IdentityUserRole<int>>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();
            });

            builder.Entity<IdentityUserClaim<int>>(b =>
            {
                // Primary key
                b.HasKey(uc => uc.Id);

                // Maps to the AspNetUserClaims table
                b.ToTable("AspNetUserClaims");
            });

            builder.Entity<IdentityUserLogin<int>>(b =>
            {
                // Composite primary key consisting of the LoginProvider and the key to use
                // with that provider
                b.HasKey(l => new { l.LoginProvider, l.ProviderKey });

                // Limit the size of the composite key columns due to common DB restrictions
                b.Property(l => l.LoginProvider).HasMaxLength(128);
                b.Property(l => l.ProviderKey).HasMaxLength(128);

                // Maps to the AspNetUserLogins table
                b.ToTable("AspNetUserLogins");
            });

            builder.Entity<IdentityUserToken<int>>(b =>
            {
                // Composite primary key consisting of the UserId, LoginProvider and Name
                b.HasKey(t => new { t.UserId, t.LoginProvider, t.Name });

                // Limit the size of the composite key columns due to common DB restrictions
                b.Property(t => t.LoginProvider).HasMaxLength(128);
                b.Property(t => t.Name).HasMaxLength(128);

                // Maps to the AspNetUserTokens table
                b.ToTable("AspNetUserTokens");
            });

            builder.Entity<AppRole>(b =>
            {
                // Primary key
                b.HasKey(r => r.Id);

                // Index for "normalized" role name to allow efficient lookups
                b.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();

                // Maps to the AspNetRoles table
                b.ToTable("AspNetRoles");

                // A concurrency token for use with the optimistic concurrency checking
                b.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

                // Limit the size of columns to use efficient database types
                b.Property(u => u.Name).HasMaxLength(256);
                b.Property(u => u.NormalizedName).HasMaxLength(256);

                // The relationships between Role and other entity types
                // Note that these relationships are configured with no navigation properties

                // Each Role can have many entries in the UserRole join table
                b.HasMany<IdentityUserRole<int>>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

                // Each Role can have many associated RoleClaims
                b.HasMany<IdentityRoleClaim<int>>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();
            });

            builder.Entity<IdentityRoleClaim<int>>(b =>
            {
                // Primary key
                b.HasKey(rc => rc.Id);

                // Maps to the AspNetRoleClaims table
                b.ToTable("AspNetRoleClaims");
            });

            builder.Entity<IdentityUserRole<int>>(b =>
            {
                // Primary key
                b.HasKey(r => new { r.UserId, r.RoleId });

                // Maps to the AspNetUserRoles table
                b.ToTable("AspNetUserRoles");
            });

            #endregion

            List<Product> products = new List<Product>();
            List<Order> orders = new List<Order>();
            List<AppUser> appUsers = new List<AppUser>();
            List<OrderDetail> ordersDetail = new List<OrderDetail>();
            List<AppRole> roles = new List<AppRole>();

            roles.Add(new AppRole
            {
                Id = 1,
                Name = "admin"

            });
            roles.Add(new AppRole
            {
                Id = 2,
                Name = "editor"

            });
            roles.Add(new AppRole
            {
                Id = 3,
                Name = "moderator"
            });



            for (int i = 1; i < 10; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    ProductName = NameData.GetCompanyName(),
                    Price = NumberData.GetNumber(5000, 10000),
                    ImageName = $"{i}.jpg"

                });
                //orders.Add(new Order
                //{
                //    Id = i,
                //    CreatedDate = DateTimeData.GetDatetime(),
                //    Ouantity = NumberData.GetNumber(1, 100),
                //    Price = NumberData.GetNumber(1000, 2000),

                //});
                appUsers.Add(new AppUser
                {
                    Id = i,
                    UserName = NameData.GetFirstName(),

                    PhoneNumber = PhoneNumberData.GetPhoneNumber(),
                });

                //ordersDetail.Add(new OrderDetail
                //{
                //    Id = i,
                //    Quantity = NumberData.GetNumber(1, 100)

                //});

            }

            builder.Entity<Product>().HasData(products);
            //builder.Entity<Order>().HasData(orders);
            builder.Entity<AppUser>().HasData(appUsers);
            builder.Entity<AppRole>().HasData(roles);



        }

    }
}
