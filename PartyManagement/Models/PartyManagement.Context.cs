//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Party_Management.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PartiesManagementEntities : DbContext
    {
        public PartiesManagementEntities()
            : base("name=PartiesManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Attendee> Attendees { get; set; }
        public virtual DbSet<Organiser> Organisers { get; set; }
        public virtual DbSet<Party> Parties { get; set; }

        public System.Data.Entity.DbSet<Party_Management.Models.event_details> event_details { get; set; }
    }
}
