using CurrencyApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CurrencyApi.Repository
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly CurrencydbContext _CurrencydbContext;

        public CurrencyRepository(CurrencydbContext currencydbContext)
        {
            _CurrencydbContext = currencydbContext;
        }

        public RATE Create(RATE rATE)
        {
            _CurrencydbContext.RATE.Add(rATE);
            _CurrencydbContext.SaveChanges();
            return rATE;
        }
        public List<RATE> Read()
        {
            return _CurrencydbContext.RATE.AsNoTracking().ToList();
        }

        public RATE Read(string id, string name, string country, decimal rate)
        {
            var names = _CurrencydbContext.RATE.FirstOrDefault(u => u.Country == country);
            return names;

        }
        public RATE Update(string id, RATE rATE)
        {
            _CurrencydbContext.Update(rATE);
            _CurrencydbContext.SaveChanges();
            return rATE;
        }
    }
}
