﻿using OnlineShop.Libs.Models;

namespace OnlineShop.Libs.Data.Contracts
{
    public interface IEfDataProvider : IEfUnitOfWork
    {
        IEfQuerable<Category> Categories { get; }

        IEfQuerable<Product> Products { get; }

        IEfQuerable<PhotoItem> PhotoItems { get; }
    }
}
