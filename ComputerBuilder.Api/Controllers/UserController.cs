﻿using ComputerBuilder.DataModels.CustomModels;
using ComputerBuilder.Logic.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;





namespace ComputerBuilder.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpGet]
        [Route("GetCategories")]
        public IActionResult GetCategories()
        {
            var data = _userService.GetCategories();
            return Ok(data);
        }

        [HttpGet]
        [Route("GetProductByCategoryId")]
        public IActionResult GetProductByCategoryId(int categoryId)
        {
            var data = _userService.GetProductByCategoryId(categoryId);
            return Ok(data);
        }
        [HttpPost]
        [Route("RegisterUser")]

        public IActionResult RegisterUser(RegisterModel registerModel)
        {
            var data = _userService.RegisterUser(registerModel);
            return Ok(data);
        }

        [HttpPost]
        [Route("LoginUser")]
        public IActionResult LoginUser(LoginModel loginModel)
        {
            var data = _userService.LoginUser(loginModel);
            return Ok(data);
        }

        [HttpPost]
        [Route("Checkout")]
        public IActionResult Checkout(List<CartModel> cartItems)
        {
            var data = _userService.Checkout(cartItems);
            return Ok(data);
        }
        [HttpPost]
        [Route("GetOrdersByCustomerId")]
        public IActionResult GetOrdersByCustomerId(int CustomerId)
        {
            var data = _userService.GetOrdersByCustomerId(CustomerId);
            return Ok(data);
        }

        [HttpPost]
        [Route("GetOrderDetailForCustomer")]
        public IActionResult GetOrderDetailForCustomer(int CustomerId, string order_number)
        {
            var data = _userService.GetOrderDetailForCustomer(CustomerId, order_number);
            return Ok(data);
        }

        [HttpPost]
        [Route("GetShippingStatusForOrder")]
        public IActionResult GetShippingStatusForOrder(string order_number)
        {
            var data = _userService.GetShippingStatusForOrder(order_number);
            return Ok(data);
        }

        [HttpPost]
        [Route("ChangePassword")]
        public IActionResult ChangePassword(PasswordModel passwordModel)
        {
            var data = _userService.ChangePassword(passwordModel);
            return Ok(data);
        }
    }
}
