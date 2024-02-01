using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Entities;

public class Status : BaseEntity
{
    [Key] public long Id { get; set; }

    public string Name { get; set; }

    public string Color { get; set; }
}