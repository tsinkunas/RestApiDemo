using RestApiDemo.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApiDemo.WebApi.Services
{
    public class FruitService
    {

        private List<Fruit> Fruits = new List<Fruit>();

        private int number = 0;

        public List<Fruit> GetAll()
        {
            return Fruits;
        }

        public Fruit Get(int id)
        {
            Fruit requestFruit = null;
            foreach (var fruit in Fruits)
            {
                if (fruit.Id == id)
                {
                    requestFruit = fruit;
                }
            }
            return requestFruit;
        }

        public void Add(Fruit fruit)
        {
            number += 1;
            fruit.Id = number;
            Fruits.Add(fruit);
        }

        public void Delete(int id)
        {
            Fruits = Fruits.Where(i => i.Id != id).ToList();
        }

        public void Edit(int id, Fruit fruit)
        {
            Fruit updatedFruit = Fruits.FirstOrDefault(selected => selected.Id == id);
            if (updatedFruit != null)
            {
                updatedFruit.Id = id;
                updatedFruit.Name = fruit.Name;
            }
        }

    }
}
