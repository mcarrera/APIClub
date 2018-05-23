using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using APIClub.Domain;
using System;
using System.ComponentModel.DataAnnotations;

namespace APIClub.Services.Dto
{
    [AutoMap(typeof(Stock))]
    public class StockDto : EntityDto, IHasCreationTime
    {
        [Required]
        public string Symbol { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime CreationTime { get; set; }
    }
}