﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutrack.Notifications.PushNotifications.Contracts.Entities
{
    public class LoginApplicationEventMessage : BaseApplicationEvent
    {
        public List<int> DeviceIds { get; set; }
    }
}
