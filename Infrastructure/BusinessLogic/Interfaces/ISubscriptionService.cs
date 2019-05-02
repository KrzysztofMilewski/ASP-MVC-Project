﻿using Infrastructure.Dtos;
using System.Collections.Generic;

namespace Infrastructure.BusinessLogic.Interfaces
{
    public interface ISubscriptionService
    {
        ResultDto<bool> IsUserSubscribedTo(string publisherId, string subscriberId);
        ResultDto CreateSubscrition(string publisherId, string subscriberId);
        ResultDto DeleteSubscription(string publisherId, string subscriberId);
        ResultDto<IEnumerable<SubscriptionDto>> GetUserSubscriptions(string userId);
    }
}
