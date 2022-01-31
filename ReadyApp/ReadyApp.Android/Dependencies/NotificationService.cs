using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ReadyApp.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using ReadyApp.Models;
using System.Threading.Tasks;

[assembly: Dependency(typeof(ReadyApp.Droid.Dependencies.NotificationService))]
namespace ReadyApp.Droid.Dependencies
{
    public class NotificationService : Java.Lang.Object, INotificationService
    {
        public Task<Models.Notification> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Models.Notification> Get(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Models.Notification>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Models.Notification> Update(Models.Notification model)
        {
            throw new NotImplementedException();
        }
    }
}