using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProjectApp.Entities
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Fluent API
        // Moze se koristiti umjesto DbSet
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>();
            //  modelBuilder.Ignore<Address>(); Nece biti mapirana u bazi

            // Postavljanje primarnog kljuca putem Fluent API-a
            // modelBuilder.Entity<Person>().HasKey(x => x.PersonId);

            //KOMPOZITNI primarni kljuc
            //  modelBuilder.Entity<Person>().HasKey(x => new { x.PersonId, x.FirstName });

            //Required polje kroz Fluent API
            modelBuilder.Entity<Address>().Property(x => x.City).IsRequired();

            //MaxLength kroz Fluent API

            modelBuilder.Entity<Address>().Property(x => x.ZipCode).HasMaxLength(5);

            //Generated property values /Identity, Compute, None kroz Fluent API

            //Never
            modelBuilder.Entity<Car>().Property(x => x.CarId).ValueGeneratedNever();

            //On Add
            // modelBuilder.Entity<Car>().Property(x => x.Datum).ValueGeneratedOnAdd();

            //On Add or Update
            //modelBuilder.Entity<Car>().Property(x => x.Datum).ValueGeneratedOnAddOrUpdate();



            //Concurency Check kroz Fluent API

            // modelBuilder.Entity<Person>().Property(x => x.LastName).IsConcurrencyToken();

            //Timestamp kroz Fluent API, koristi se .ValueGeneratedOnAddOrUpdate() uz timestamp property

            // modelBuilder.Entity<Person>().Property(x => x.TimeStamp)
            // .ValueGeneratedOnAddOrUpdate()
            // .IsConcurrencyToken();


            //Indexi kroz Fluent API

           // modelBuilder.Entity<Person>().HasIndex(x => x.FirstName);
            //Da li je index unique ili nije 
            //You can also specify that an index should be unique, meaning that 
            //no two entities can have the same value(s) for the given property(s).
            modelBuilder.Entity<Person>().HasIndex(x => x.PersonId).IsUnique();

            //Multiple Columns Index

          //  modelBuilder.Entity<Person>().HasIndex(x => new { x.PersonId, x.FirstName });


            //Mapiranje klasa u tabele kroz Fluent API
            //Table Mapping

            //modelBuilder.Entity<Address>().ToTable("Addresses");

            //sa shemom
            //modelBuilder.Entity<Address>().ToTable("Addresses",schema:"Address");

            //Mapiranje kolona kroz FluentApi
            //Column Mapping
            //mapiranje u kolonu proizvoljnog imena u bazi

            //modelBuilder.Entity<Address>().Property(x => x.StreetName).HasColumnName("Ulica");

            //mapiranje u kolonu proizvoljnog imena i proizvoljnog tipa 

            //modelBuilder.Entity<Address>().Property(x => x.StreetName).HasColumnType("varchar(300)");
            //modelBuilder.Entity<Address>().Property(x => x.StreetName).HasColumnName("Ulica").HasColumnType("varchar(300)");

            //Computed column kroz Fluent API
            //sastoji se od vise kolona koje se spajaju, nije moguce uraditi kroz data anotacije, nego samo kroz Fluent API

            modelBuilder.Entity<Person>().Property(x => x.DisplayName).HasComputedColumnSql("[FirstName]" + "," + "[LastName]");


        }




        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
