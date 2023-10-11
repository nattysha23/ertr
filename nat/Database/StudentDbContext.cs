﻿using Microsoft.EntityFrameworkCore;
using nat.Database.Configurations;
using nat.Models;

namespace nat.Database
{
    public class StudentDbContext: DbContext
    {//Добавляем таблицы
        DbSet<Student> Students { get; set; }
        DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Добавляем конфигурации к таблицам
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
        }
        public StudentDbContext(DbContextOptions<StudentDbContext> options): base(options)
        { 
        }  
    }
}
