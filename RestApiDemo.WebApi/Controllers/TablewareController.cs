using Microsoft.AspNetCore.Mvc;
using RestApiDemo.WebApi.Models;
using RestApiDemo.WebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDemo.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TablewareController : ControllerBase
    {
        private readonly TablewareService _tablewareService;

        public TablewareController(TablewareService tablewareService)
        {
            _tablewareService = tablewareService;
        }

        [HttpGet]
        public List<Tableware> GetAll()
        {
            return _tablewareService.GetAll();
        }

        [HttpGet("{id}")]
        public Tableware Get(int id)
        {
            return _tablewareService.Get(id);
        }

        [HttpPost]
        public void Add(Tableware tableware)
        {
            _tablewareService.Add(tableware);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _tablewareService.Delete(id);
        }

        [HttpPut("{id}")]
        public void Put(int id, Tableware tableware)
        {
            _tablewareService.Edit(id, tableware);
        }
    }
}
