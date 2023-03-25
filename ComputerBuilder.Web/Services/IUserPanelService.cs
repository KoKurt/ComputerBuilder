using ComputerBuilder.DataModels.CustomModels;
using ComputerBuilder.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerBuilder.Web.Services
{
    public interface IUserPanelService
    {   
        Task<bool> IsUserLoggedIn(); 
        Task<List<CategoryModel>> GetCategories();
        Task<List<ProductModel>> GetProductByCategoryId(int categoryId);
        Task<ResponseModel> RegisterUser(RegisterModel registerModel);
        Task<ResponseModel> LoginUser(LoginModel loginModel);
        Task<ResponseModel> Checkout(List<CartModel> cartItems);
        Task<List<CustomerOrder>> GetOrdersByCustomerId(int cutomerId);
        Task<List<string>> GetShippingStatusForOrder(string order_number);
        Task<List<CartModel>> GetOrderDetailForCustomer(int customerId, string order_number);
        Task<ResponseModel> ChangePassword(PasswordModel passwordModel);
    }
}
