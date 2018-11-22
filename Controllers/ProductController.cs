using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models;

namespace WebServer.Controllers
{
    [Route("api/products")]
    public class ProductsController : Controller
    {

        [HttpGet]
        public IEnumerable GetProduct()
        {
            
         return Repo.RepoList.Values;
         
        }

        [HttpGet("{id}")]
        public Product GetProduct(int id)
        {
            if(Repo.RepoList.ContainsKey(id))
            {
                    var product = Repo.RepoList[id];
                    return product;
            }
            return null;
           
        }

        [HttpPut("{id}")]

        public void PutProduct([FromBody]Product product,[FromQuery]int id)
        {
             if(Repo.RepoList.ContainsKey(id))
            {
                Repo.RepoList[id].ID = product.ID;
                Repo.RepoList[id].Name = product.Name;
            }

        }

        [HttpPost]

        public Product PostProduct([FromBody]Product product)
        {
            
            Repo.RepoList.Add(product.ID,product);

            return product;
        }

    }
}