using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Entities;

public class RoutingSlips : BaseEntity
{
    [Key] public long Id { get; set; }

    public long CompanyId { get; set; }

    public long FieldId { get; set; }

    public long Order { get; set; }

    public string Name { get; set; } = string.Empty;
}