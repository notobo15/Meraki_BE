using Repositories.DTO;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IOrderService
    {
        public Task<dynamic> RequireAnExchangeOrderAsync(CreateExOrderDTO orderDTO);
        public Task<dynamic> AcceptRequiredExchangeOrderAsync(string orderId);
        public Task<dynamic> RefuseRequiredExchangeOrderAsync(string orderId);
        public Task<dynamic> CreateAnOrderForExchangeAsync(string orderId);
        public Task<dynamic> CreateAnOrderBuyFromCartAsync(CreateAnBuyOrderDTO orderDTO);

        public Task<double> RetrieveTotalMoneyByOrderId(string orderId);
        public Task FinishDeliveringStage(string orderId);
        public Task<List<Order>> GetAllOrders();
        public Task<List<Order>> GetOrdersByTypeAsync(string orderType);
        public Task<int> GetNumberOfOrders();
        public Task<int> GetNumberOfOrderBasedOnStatus(int status);
        public Task<dynamic> GetNumberOrderOfCustomerByStatus(int status);
        public Task<dynamic> GetNumberOrderOfCustomer();
        public Task<double> GetTotalEarnings();
        public Task CheckoutRequest(CheckoutRequest request);
    }
}
