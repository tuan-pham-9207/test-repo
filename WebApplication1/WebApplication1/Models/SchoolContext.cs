using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models;

public class BloggingContext : DbContext
{
    public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
    {

    }
    public DbSet<ConstructionDrawing> ConstructionDrawings { get; set; } = null!;

    public DbSet<DrawingCategory> DrawingCategories { get; set; }

    public DbSet<MainClassification> MainClassification { get; set; }

    public DbSet<ReviewDrawing> ReviewDrawings { get; set; }

    public DbSet<ReviewProgress> ReviewProgresses { get; set; }

    public DbSet<RoutingSlips> RoutingSlips { get; set; }

    public DbSet<Status> Statuses { get; set; }

    public DbSet<SubClassification> SubClassification { get; set; }
}

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; } = null!;

    public List<Post> Posts { get; } = new();
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;

    public int BlogId { get; set; }
    public Blog Blog { get; set; } = null!;
}