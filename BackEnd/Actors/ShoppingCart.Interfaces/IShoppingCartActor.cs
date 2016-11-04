﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;

namespace ShoppingCart.Interfaces
{
    /// <summary>
    /// This interface defines the methods exposed by an actor.
    /// Clients use this interface to interact with the actor that implements it.
    /// </summary>
    public interface IShoppingCartActor : IActor
    {
        Task SetCustomerAsync(string username);

        Task<bool> AddProductAsync(string productId, string productDescription, decimal unitCost, int quantity);
    }
}