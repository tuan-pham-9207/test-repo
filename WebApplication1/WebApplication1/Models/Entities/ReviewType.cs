using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Entities;

public class ReviewType : BaseEntity
{
    [Key] public long Id { get; set; }

    public long FieldId { get; set; }

    public string Name { get; set; } = string.Empty;

    public DrawingCategory DrawingCategory { get; set; }
}