using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pageNavApp.Model;

namespace pageNavApp.ViewModel
{
    internal class OrderVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public DateTime DisplayOrderDate //DateOnly
        {
            get { return _pageModel.OrderDate; }
            set { _pageModel.OrderDate = value; OnPropertyChanged(); }
        }

        public OrderVM()
        {
            _pageModel= new PageModel();
            DisplayOrderDate = DateTime.Now; // <--- Substitute code

            //DateOnly.FromDateTime(DateTime.Now); // <--- Actual code
        }
    }
}
