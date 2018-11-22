using System.Collections.Generic;

namespace WebServer.Models
{
    public static class Repo
    {
        public static IDictionary<int,Product> RepoList {get; set;}

        static Repo()
        {
            RepoList = new Dictionary<int,Product>();
            
            RepoList.Add(0,new Product{ID=0,Name="Basil"});
            RepoList.Add(2,new Product{ID=1,Name="Meenu"});
            RepoList.Add(1,new Product{ID=2,Name="Ponnu"});

        }
    }
}