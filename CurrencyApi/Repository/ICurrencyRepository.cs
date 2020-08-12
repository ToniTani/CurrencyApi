using CurrencyApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyApi.Repository
{
    public interface ICurrencyRepository
    {
        RATE Create(RATE rATE);
        List<RATE> Read();
        RATE Read(string id, string name, string country, decimal rate);
        RATE Update(string id, RATE rATE);
   

    }
}
