using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Entities
{
    public class SubClassification : BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public long Order { get; set; }

        public long MainClassificationId { get; set; }
        public MainClassification MainClassification { get; set; }

    }
}
