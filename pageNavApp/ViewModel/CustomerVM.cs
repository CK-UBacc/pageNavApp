using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pageNavApp.Model;//Gives access to the Model folder

namespace pageNavApp.ViewModel
{
    internal class CustomerVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public int CustomerID
        {
            //Whenever something tries to get the value of "CustomerID" then it gets the value from /Model/PageModel.cs
            get { return _pageModel.CustomerCount; }

            //Whenever something tries to set the value of "CustomerID" then it sets the value in /Model/PageModel.cs then tells stuff that the value has been changed
            set { _pageModel.CustomerCount = value; OnPropertyChanged(); }
        }

        public CustomerVM()
        {
            _pageModel = new PageModel();
            CustomerID = 100528;
        }
    }
}
