using BuyRealEstate.Core.DTos;
using BuyRealEstate.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Core.Interfaces
{
    public interface IPaymentService
    {
        Task<IEnumerable<PaymentDTO>> GetAllPaymentsAsync();
        Task<PaymentDTO> GetPaymentByIdAsync(int id);
        Task AddPaymentAsync(PaymentDTO payment);
        Task UpdatePaymentAsync(PaymentDTO payment);
        Task DeletePaymentAsync(int id);
    }
}

