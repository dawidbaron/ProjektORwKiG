using BP.Domain;
using BP.Models.Fields;
using BP.Models.Match;
using BP.Models.ReservationPayment;
using BP.Models.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BP.Helpers
{
    public class DataBaseContext : DbContext
    {
        // public DataBaseContext() { }
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
        public DbSet<Field> Fields { get; set; }
        public DbSet<FieldContact> FieldContacts { get; set; }
        public DbSet<FieldType> FieldTypes { get; set; }
        public DbSet<SportType> SportTypes { get; set; }
        public DbSet<Match> Matches { get; set; }
        //public DbSet<MatchUsers> MatchUser { get; set; }
        public DbSet<Payment> Payments { get; set; }
       // public DbSet<Receipt> Receipts { get; set; }
        // public DbSet<PaymentStatusDictionary> PaymentStatusDictionary { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        //public DbSet<ReservationMatch> ReservationMatch { get; set; }
        //public DbSet<ReservationPayment> ReservationPayment { get; set; }
        //public DbSet<ReservationStatusDictionary> ReservationStatusDictionary { get; set; }
        public DbSet<LoginPrivilage> LoginPrivilages { get; set; }
        public DbSet<RoleDictionary> RoleDictionary { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserTypeDictionary> UserTypeDictionary { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            ApplyChanges();
            return base.SaveChangesAsync(cancellationToken);
        }
        private void ApplyChanges()
        {
            var addedEntities = ChangeTracker.Entries<IEntityBase>()
                .Where(x => x.State == EntityState.Added)
                .ToList();

            foreach (var addedEntity in addedEntities)
            {
                addedEntity.Property(x => x.CreatedOn).CurrentValue = DateTimeOffset.UtcNow;
            }

            var modifiedEntities = ChangeTracker.Entries<IEntityBase>()
                .Where(x => x.State == EntityState.Modified)
                .ToList();

            foreach (var modifiedEntity in modifiedEntities)
            {
                modifiedEntity.Property(x => x.ModifiedOn).CurrentValue = DateTimeOffset.UtcNow;
            }
        }

    }
}
