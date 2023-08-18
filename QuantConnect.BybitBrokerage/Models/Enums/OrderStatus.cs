﻿namespace QuantConnect.BybitBrokerage.Models.Enums;

public enum OrderStatus
{
    Created,
    New,
    Rejected,
    PartiallyFilled,
    PartiallyFilledCanceled,
    Filled,
    Cancelled,
    Untriggered,
    Triggered,
    Deactivated,
    Active
}