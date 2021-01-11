using Microsoft.AspNetCore.Mvc;
using RestApiDemo.WebApi.Models;
using RestApiDemo.WebApi.Services;
using System.Collections.Generic;

namespace RestApiDemo.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FruitController : ControllerBase
    {
        private readonly FruitService _fruitService;

        public FruitController(FruitService fruitService)
        {
            _fruitService = fruitService;
        }

        [HttpGet]
        public List<Fruit> GetAll()
        {
            return _fruitService.GetAll();
        }

        [HttpGet("{id}")]
        public Fruit Get(int id)
        {
            return _fruitService.Get(id);
        }

        [HttpPost]
        public void Add(Fruit fruit)
        {
            _fruitService.Add(fruit);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _fruitService.Delete(id);
        }

        [HttpPut("{id}")]
        public void Put(int id, Fruit fruit)
        {
            _fruitService.Edit(id, fruit);
        }
    }
}
