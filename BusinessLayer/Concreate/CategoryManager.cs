using DataAccessLayer.Concreate.Repositories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class CategoryManager
    {
        GenericRepository<Category> Repo = new GenericRepository<Category>();

        public List<Category> GetAllBL()
        {
            return Repo.List();
        }

        public void CategoryAddBL(Category p)
        {
            if(p.CategoryName == "" || p.CategoryName.Length <3 || p.Description == "" || p.CategoryName.Length >= 51)
            {
                // hata mesajı                
            }
            else
            {
                Repo.Insert(p);
            }
        }
    }
}
