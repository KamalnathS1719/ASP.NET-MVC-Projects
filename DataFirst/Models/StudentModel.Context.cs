namespace DataFirst.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataFirstEFEntities : DbContext
    {
        public DataFirstEFEntities()
            : base("name=DataFirstEFEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<StudentInfo> StudentInfoes { get; set; }
    }
}
