﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Domain
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new MatchesMap());

            modelBuilder.Configurations.Add(new UsersMap());

            modelBuilder.Configurations.Add(new GroupsMap());
        }


        public System.Data.Entity.DbSet<Domain.League> Leagues { get; set; }

        public System.Data.Entity.DbSet<Domain.Team> Teams { get; set; }

        public System.Data.Entity.DbSet<Domain.Tournament> Tournaments { get; set; }

        public System.Data.Entity.DbSet<Domain.TournamentGroup> TournamentGroups { get; set; }
    }
}
