using ReadyApp.Services;
using ReadyApp.Services.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadyApp
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        // Not to sure if I can cast here, but will see
        public UnitOfWork()
        {
            Auth = new();
            User = new();
            Business = new();
            Product = new();
            ProductItem = new();
            Order = new();
            OrderItem = new();
            Favorite = new();
            Notification = new();
        }
        public AuthService Auth { get; set; }
        public UserService User { get; set; }
        public BusinessService Business { get; set; }
        public ProductService Product { get; set; }
        public ProductItemService ProductItem { get; set; }
        public OrderService Order { get; set; }
        public OrderItemService OrderItem { get; set; }
        public FavoriteService Favorite { get ; set ; }
        public NotificationService Notification { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
