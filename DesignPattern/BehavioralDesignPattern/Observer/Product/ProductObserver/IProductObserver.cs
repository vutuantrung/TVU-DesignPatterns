using Observer.Product.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Product.ProductObserver
{
    public interface IProductObserver
    {
        void UpdateAvailability( Availability availability );
        void UpdatePromotion( double promotionPrice );
    }
}
