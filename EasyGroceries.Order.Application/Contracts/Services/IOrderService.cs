﻿using EasyGroceries.Order.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGroceries.Order.Application.Contracts.Services
{
    public interface IOrderService
    {
        Task<ResponseDto<OrderHeaderDto>> CreateOrder(CartDto cartDto);
        Task<ResponseDto<OrderHeaderDto>> GetOrderByUserId(int id);
    }
}
