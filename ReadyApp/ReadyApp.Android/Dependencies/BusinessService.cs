using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ReadyApp.Models;
using ReadyApp.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(ReadyApp.Droid.Dependencies.BusinessService))]
namespace ReadyApp.Droid.Dependencies
{
    public class BusinessService : Java.Lang.Object, IBusinessService
    {
        public Task<Business> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Business> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Business>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Business> Update(Business model)
        {
            throw new NotImplementedException();
        }
    }
}