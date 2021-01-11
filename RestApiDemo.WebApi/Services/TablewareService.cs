using RestApiDemo.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDemo.WebApi.Services
{
    public class TablewareService
    {
        private List<Tableware> Tablewares = new List<Tableware>();

        private int number = 0;

        public List<Tableware> GetAll()
        {
            return Tablewares;
        }

        public Tableware Get(int id)
        {
            Tableware requestTableware = null;
            foreach (var tableware in Tablewares)
            {
                if (tableware.Id == id)
                {
                    requestTableware = tableware;
                }
            }
            return requestTableware;
        }

        public void Add(Tableware tableware)
        {
            number += 1;
            tableware.Id = number;
            Tablewares.Add(tableware);
        }

        public void Delete(int id)
        {
            Tablewares = Tablewares.Where(i => i.Id != id).ToList();
        }

        public void Edit(int id, Tableware tableware)
        {
            Tableware updatedTableware = Tablewares.FirstOrDefault(selected => selected.Id == id);
            if (updatedTableware != null)
            {
                updatedTableware.Id = id;
                updatedTableware.Name = tableware.Name;
            }
        }
    }
}
