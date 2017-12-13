using Project2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project2_IS_403.DAL
{
    public class MissionContext : DbContext
    {
        public MissionContext() : base("BlowOutContext") { }

        public DbSet<Mission> Mission { get; set; }
        public DbSet<MissionQuestions> MissionQuestions { get; set; }
        public DbSet<User> User { get; set; }

    }
}