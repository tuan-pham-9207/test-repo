using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Entities;

public class ReviewProgress : BaseEntity
{
    [Key] public long Id { get; set; }

    public ReviewDrawing ReviewDrawing { get; set; }

    public RoutingSlips RoutingSlips { get; set; }

    public bool ReviewerUseFlag { get; set; }

    public DateTime? SubmissionDate { get; set; }

    public DateTime? ScheduledReturnDate { get; set; }

    public DateTime? ReturnDate { get; set; }
}