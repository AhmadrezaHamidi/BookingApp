﻿namespace BookingApp.Core.Model
{
    public interface IAggregate<out T> : IAggregate
    {
        T Id { get; }
    }

    public interface IAggregate
    {

    }
}