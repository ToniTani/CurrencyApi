
using System;
using System.Collections.Generic;
using CurrencyApi.Models;
using CurrencyApi.Repository;


namespace CurrencyApi.Service
    {
        public class CurrencyService : ICurrencyService
        {
            private readonly ICurrencyRepository _currencyRepository;

            public CurrencyService(ICurrencyRepository currencyRepository)
            {
                _currencyRepository = currencyRepository;
            }

            public RATE CreateCurrency(RATE rATE)
            {
                return _currencyRepository.Create(rATE);
            }

            public List<RATE> Read()
            {
                return _currencyRepository.Read();
            }

            public RATE Read(string id, string name, string country, decimal rate)
            {
                return _currencyRepository.Read(id, name, country, rate);
            }

            public RATE Update(string id, RATE rATE)
            {
                var savedCurrency = _currencyRepository.Read();
                if (savedCurrency == null)
                {
                    throw new Exception("Error, try again");
                }
                else
                {
                    return _currencyRepository.Update(id, rATE);
                }
            }      
        }
    }
