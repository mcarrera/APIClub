using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;

namespace APIClub.Domain
{
    public class Stock : FullAuditedEntity
    {
        [Required]
        public string Symbol { get; set; }

        [Required]
        public string Name { get; set; }
    }


}
