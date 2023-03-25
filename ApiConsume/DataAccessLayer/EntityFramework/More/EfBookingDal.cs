using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework.More
{
    //public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    //{
    //    public EfBookingDal(Context context) : base(context)
    //    {

    //    }

    //    public void BookingStatusChangeApproved(Booking booking)
    //    {
    //        var context = new Context();
    //        var values = context.Bookings.Where(x => x.BookingID == booking.BookingID).FirstOrDefault();
    //        values.Status = "Onaylandı";
    //        context.SaveChanges();
    //    }

    //    public void BookingStatusChangeApproved2(int id)
    //    {
    //        var context = new Context();
    //        var values = context.Bookings.Find(id);
    //        values.Status = "Onaylandı";
    //        context.SaveChanges();
    //    }
    //}
}