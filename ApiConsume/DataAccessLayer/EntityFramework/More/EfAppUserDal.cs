using DataAccessLayer.Abstract.More;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework.More
{
    //public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    //{
    //    public EfAppUserDal(Context context) : base(context)
    //    {

    //    }
    //    public List<AppUser> UserListWithWorkLocation()
    //    {
    //        var context = new Context();
    //        return context.Users.Include(x => x.WorkLocation).ToList();
    //    }
    //}
}