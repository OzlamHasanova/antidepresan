
using Core1.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DataAccess1.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<SlideItem> SlideItems { get; set; } =null!;
    public DbSet<ShippingItem> ShippingItems { get; set; }=null!;
}
