using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Entities
{
    public class MainClassification : BaseEntity
    {

        [Key]
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public long FieldId { get; set; }

        public long CompanyId { get; set; }

        public long Order { get; set; }

        public IList<SubClassification> SubClassification { get; set; }
    }
}
