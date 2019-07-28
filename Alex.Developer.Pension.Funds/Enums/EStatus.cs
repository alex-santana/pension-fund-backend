using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Enums
{
    public enum EStatus
    {
        Active = 1,
        SelfSponsored = 2,
        DeferredProportionalBenefit =3,
        DisconnectedWaiting =4,
        DisconnectedSettled =5,
        Disconnected =6,
        Assisted = 7,
        Excluded = 8

    }
}
