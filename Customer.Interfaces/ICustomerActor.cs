﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;
using MyCommerce.SF.Dto;

namespace Customer.Interfaces
{
    /// <summary>
    /// This interface defines the methods exposed by an actor.
    /// Clients use this interface to interact with the actor that implements it.
    /// </summary>
    public interface ICustomerActor : IActor
    {
        Task<CustomerInfoDto> GetCustomerInfoAsync();

        Task<bool> EnableCustomerAsync(bool enable);

        Task<ShoppingCartInfoDto> GetCurrentShoppingCartAsync();

        Task<bool> AddProductToShoppingCartAsync(string productId, string productDescription, decimal unitCost, int quantity);
    }
}
