using ReadyApp.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadyApp.Models
{
    public class Notification : ModelBase
    {
        public string SourceId { get; set; } = String.Empty;
        public string Title { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public NotificationType GetNotificationType { get; set; } = NotificationType.none;
    }
}
