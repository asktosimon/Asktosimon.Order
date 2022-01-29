using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asktosimon.Order
{
    public abstract class Delivery
    {

    }

    public class HomeDelivery : Delivery { }
    
    public class PickPointDelivery : Delivery { }

    public class ShopDelivery : Delivery { }
}
