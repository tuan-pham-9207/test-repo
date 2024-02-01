using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Entities;

public class DrawingCategory : BaseEntity
{
    [Key] public long Id { get; set; }

    public string Name { get; set; } = string.Empty;

}