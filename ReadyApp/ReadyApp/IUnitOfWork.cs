using ReadyApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadyApp
{
    public interface IUnitOfWork
    {
        AuthService Auth { get; set; }
        UserService User { get; set; }
        BusinessService Business { get; set; }
        ProductService Product { get; set; }
        ProductItemService ProductItem { get; set; }
        OrderService Order { get; set; }
        OrderItemService OrderItem { get; set; }
        FavoriteService Favorite { get; set; }
        NotificationService Notification { get; set; }
    }
}
