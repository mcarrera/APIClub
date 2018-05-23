using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using APIClub.Authorization.Users;
using System;
using System.Collections.Generic;

namespace APIClub.Domain
{
    public class Portfolio : FullAuditedEntity, IPassivable
    {
        public Portfolio()
        {
            IsActive = true;
        }

        public bool IsActive { get; set; }

        public User User { get; set; }
        
        public virtual ICollection<Transanction> Transanctions { get; set; }
    }
}
