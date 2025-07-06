using EFCoreMySql.Data;
using Microsoft.EntityFrameworkCore;
using EFCoreMySql.Models;
using System;
using System.Threading.Tasks;

Console.WriteLine(">> Program Started");
using var context = new AppDbContext();


var products = await context.Products.Include(p => p.Category).ToListAsync();
Console.WriteLine("All Products:");
foreach (var p in products)
    Console.WriteLine($"{p.Name} - ₹{p.Price} (Category: {p.Category?.Name})");



var found = await context.Products.FindAsync(1);
Console.WriteLine($"\nFound by ID: {found?.Name}");



var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 5000);
Console.WriteLine($"\nFirst Expensive Product: {expensive?.Name}");
