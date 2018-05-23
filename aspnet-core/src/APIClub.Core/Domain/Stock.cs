using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;

namespace APIClub.Domain
{
    public class Stock : FullAuditedEntity, IPassivable
    {
        public Stock()
        {
            IsActive = true;
        }

        [Required]
        public string Symbol { get; set; }

        [Required]
        public string Name { get; set; }

        public bool IsActive { get; set;}
    }


}
