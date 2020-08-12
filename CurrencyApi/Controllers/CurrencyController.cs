using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using CurrencyApi.Models;
using CurrencyApi.Repository;
using CurrencyApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyApi.Controllers
{
    [Route("rates")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyService _currencyService;
        private readonly ICurrencyRepository _currencyRepository;

        public CurrencyController(ICurrencyService currencyService, ICurrencyRepository currencyRepository)
        {
            _currencyService = currencyService;
            _currencyRepository = currencyRepository;
        }

        [HttpGet]
        public ActionResult<List<RATE>> Get()
        {
            return new JsonResult(_currencyService.Read());
        }

        [HttpGet("{country}")]
        public ActionResult<RATE> Get(string id, string name, string country, decimal rate)
        {
            return new JsonResult(_currencyService.Read(id, name, country, rate));
        }

        [HttpPost]
        public ActionResult<RATE> Post(RATE rATE)
        {
            return _currencyService.CreateCurrency(rATE);
        }

        [HttpPut("{id}")]
        public ActionResult<RATE> Put(string id, RATE rATE)
        {
            return _currencyService.Update(id, rATE);
        }
    }
}
