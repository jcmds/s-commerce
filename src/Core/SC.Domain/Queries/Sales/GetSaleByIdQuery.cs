﻿using System;
using SC.Core.Queries;
using SC.Domain.Queries.Models;

namespace SC.Domain.Queries.Sales
{
    public class GetSaleByIdQuery : IQuery<SaleViewQueryModel>
    {
        public GetSaleByIdQuery(Guid id)
        {
            Id = id;
            CacheToken = $"{nameof(GetSaleByIdQuery)}_{id}";
        }

        public Guid Id { get; }
        public string CacheToken { get; }
    }
}
