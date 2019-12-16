using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using P2Translator.Data.Models;

namespace P2Translator.Data
{
  public class P2TranslatorDbContext : DbContext
  {
    public DbSet<Message> Message { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseNpgsql("server=localhost;database=postgres;user id=postgres;password=postgres");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.HasSequence<int>("MessageId").StartsAt(4).IncrementsBy(1);
      modelBuilder.Entity<Message>(o => o.HasKey(k => k.MessageId));
      modelBuilder.Entity<Message>().Property(p => p.MessageId).HasDefaultValueSql("nextval('\"MessageId\"')");

      modelBuilder.Entity<Message>().HasData(new List<Message>()
      {
        new Message(){ MessageId = 1, Content = "first message", MessageDateTime = DateTime.Now},
        new Message(){ MessageId = 2, Content = "second message", MessageDateTime = DateTime.Now}
      });
    }
  }
}