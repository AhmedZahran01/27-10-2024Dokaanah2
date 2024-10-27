﻿using Dokaanah.Models;
using Dokaanah.Repositories.RepoInterfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace Dokaanah.Repositories.RepoClasses
{
    public class OrdersRepo: GenericRepository<Order,int> , IOrdersRepo
    { 
        public OrdersRepo(Dokkanah2Contex dokkanah2 ):base(dokkanah2)
        { 
        }
         
    }
}