using Microsoft.EntityFrameworkCore;
namespace SCP_Foundation.Models
{
    public class SCPcontext : DbContext
    {
        public SCPcontext(DbContextOptions<SCPcontext> options) : base(options)
        { }
        public DbSet<SCP> SCPs { get; set; }
        //public DbSet<ObjectClass> ObjectClasses { get; set; }
        //public DbSet<ThreatLevel> ThreatLevels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ObjectClass>().HasData(
            //     new ObjectClass { ObjectClassId = "S", ObjectClassName = "Safe" },
            //     new ObjectClass { ObjectClassId = "E", ObjectClassName = "Euclid" },
            //     new ObjectClass { ObjectClassId = "K", ObjectClassName = "Keter" },
            //     new ObjectClass { ObjectClassId = "T", ObjectClassName = "Thaumiel" },
            //     new ObjectClass { ObjectClassId = "N", ObjectClassName = "Neutralized" },
            //     new ObjectClass { ObjectClassId = "AP", ObjectClassName = "Apollyon" },
            //     new ObjectClass { ObjectClassId = "AN", ObjectClassName = "Anomalous" },
            //     new ObjectClass { ObjectClassId = "AR", ObjectClassName = "Archon" }

            // );

            //modelBuilder.Entity<ThreatLevel>().HasData(
            //     new ThreatLevel { ThreatLevelId = "D", ThreatLevelName = "Dark" },
            //     new ThreatLevel { ThreatLevelId = "V", ThreatLevelName = "Vlam" },
            //     new ThreatLevel { ThreatLevelId = "K", ThreatLevelName = "Keneq" },
            //     new ThreatLevel { ThreatLevelId = "Ek", ThreatLevelName = "Ekhi" },
            //     new ThreatLevel { ThreatLevelId = "A", ThreatLevelName = "Amida" }


            // );
            modelBuilder.Entity<SCP>().HasData(
                 new SCP
                 {
                     SCPID = 1,
                     IdNumber = "SCP-0003",
                     Name = "Biological Motherboard",
                     ObjectClass = "Euclid",
                     ThreatLevel = "Dark"
                 },

                 new SCP
                 {
                     SCPID = 2,
                     IdNumber = "SCP-0013",
                     Name = "Wooden Statue",
                     ObjectClass = "Keter",
                     ThreatLevel = "Amida"
                 },

                 new SCP
                 {
                     SCPID = 3,
                     IdNumber = "SCP-0023",
                     Name = "Oak Tree",
                     ObjectClass = "Archon",
                     ThreatLevel = "Vlam"
                 }
             );
        }
    }
}
