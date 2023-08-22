﻿using app1.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1.Strategy
{
    class EmailNotificationStrategy : INotificationStrategy
    {
        public void SendNotification(string subject, string message)
        {
            new EmailNotification().Send(subject, message);
        }
    }
}
