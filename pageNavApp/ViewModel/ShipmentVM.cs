using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pageNavApp.Model;

namespace pageNavApp.ViewModel
{
    class ShipmentVM : Utilities.ViewModelBase
    {
        private readonly PageModel  _pageModel;
        public DateTime ShipmentTracking //TimeOnly
        {
            get { return _pageModel.ShipmentDelivery; }
            set {  _pageModel.ShipmentDelivery = value; OnPropertyChanged(); }
        }

        public ShipmentVM()
        {
            _pageModel= new PageModel();
            //DateTime time = DateTime.Now; // <--- Substitute code
            //TimeOnly time = TimeOnly.FromDateTime(DateTime.Now); // <--- Proper code
            //ShipmentTracking = time;

            ShipmentTracking = DateTime.Now;
        }
    }
}
