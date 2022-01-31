using ReadyApp.Models;
using ReadyApp.Services.IService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReadyApp.Services
{
    public class NotificationService
    {
        private static INotificationService _notification = DependencyService.Get<INotificationService>();

        public async Task<Notification?> Delete(string id)
        {
            return await _notification.Delete(id);
        }

        public async Task<Notification?> Get(string id)
        {
            return await _notification.Get(id);
        }

        public async Task<IEnumerable<Notification>?> GetAll()
        {
            return await _notification.GetAll();
        }

        public async Task<Notification?> Update(Notification model)
        {
            return await _notification.Update(model);
        }
    }
}
