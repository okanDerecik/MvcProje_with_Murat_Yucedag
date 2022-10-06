using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{

    /* Burası Örnek Olarak Durması İçin Silinmemiştir. Yapılmaması gereken, bizi kod tekrarına düşüren bir yapıdır. Kullanılmamalıdır.
    public interface ICategoryDal
    {
        //CRUD operasyonları
        List<Category> List();

        void Insert(Category p);

        void Update(Category p);

        void Delete(Category p);
    }
    */

    public interface ICategoryDal : IRepository<Category>
    {

    }

    
}
