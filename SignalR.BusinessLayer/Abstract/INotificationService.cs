﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstract
{
    public interface INotificationService: IGenericService<Notification>
    {
        int TNotificationCountByStatusFalse();

        List<Notification> TGetAllNotificationByFalse();

        void TNotificationStatusChangeToTrue(int id);

        void TNotificationStatusChangeToFalse(int id);
    }
}
