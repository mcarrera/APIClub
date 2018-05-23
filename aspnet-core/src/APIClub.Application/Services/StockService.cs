using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using APIClub.Domain;
using APIClub.Services.Dto;

namespace APIClub.Services
{
    [AbpAuthorize]
    public class StockService : AsyncCrudAppService<Stock, StockDto>
    {
       
        public StockService(IRepository<Stock> repository) : base(repository)
        {

        }
    }
}
