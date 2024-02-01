using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Entities;

public class ReviewDrawing : BaseEntity
{
    [Key] public long Id { get; set; }

    public ConstructionDrawing ConstructionDrawing { get; set; }
    public IList<ReviewProgress> ReviewsProgresses { get; set; }

    public long ReviewTypeId { get; set; }
    public ReviewType ReviewType { get; set; }

    public Status Status { get; set; }

    public bool PostApprovalChangeFlag { get; set; }

    public string CommentRoomId { get; set; } = string.Empty;

    public string Memo { get; set; } = string.Empty;

    public bool AdvanceSharingFlag { get; set; }

    public bool SharedFlag { get; set; }

    public string AdvanceSharingMemo { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

}