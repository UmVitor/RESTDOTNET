﻿using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace REST_API.Hypermedia.Abstract
{
    public interface IResponseEnricher
    {
        bool CanEnrich(ResultExecutingContext context);
        Task Enrich(ResultExecutingContext context);
    }
}
