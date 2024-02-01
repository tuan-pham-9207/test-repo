using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Entities
{
    public class ConstructionDrawing : BaseEntity
    {

        [Key]
        public long Id { get; set; }

        public long FieldId { get; set; }

        public string Name { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime CompletionDateline { get; set; }

        public long Order { get; set; }

        public SubClassification SubClassification { get; set; }

        public long SubClassificationId { get; set; }

        public long MainClassificationId { get; set; }

        public IList<ReviewDrawing> ReviewDrawings { get; set; }


    }
}
