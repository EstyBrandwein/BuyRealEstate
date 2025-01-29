//using AutoMapper;
//using BuyRealEstate.Core.DTos;
//using BuyRealEstate.Core.Interfaces;
//using BuyRealEstate.Domain.Interfaces;
//using BuyRealEstate.Domain.Models;
//using BuyRealEstate.Domain.Repositories;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace BuyRealEstate.Core.Services
//{
//    public class PaymentService : IPaymentService

//    {
//        private readonly IPaymentRepository _paymentRepository;
//        private readonly IMapper _mapper;
//        public PaymentService(IPaymentRepository paymentRepository, IMapper mapper)
//        {
//            _paymentRepository = paymentRepository;
//            _mapper = mapper;
//        }

//        public async Task AddPaymentAsync(PaymentDTO p)
//        {
//            var payment = new Payment
//            {
//                PaymentConfirmation = (ICollection<Document>)p.PaymentConfirmation,
//                Title = p.Title,
//                movement = p.movement,
//                dose = p.dose,
//                HNagainst = p.HNagainst,
//                Datereference = p.Datereference,
//                DataValue = p.DataValue,
//                Detiels = p.Detiels,
//                Surplus = p.Surplus,
//                Amount = p.Amount,
//                Professional = p.Professional,
//                LastPaymentDate = p.LastPaymentDate,
//                PaymentExecutionMethodID = p.PaymentExecutionMethodID,
//                PaymentStatusId = p.PaymentStatusId,
//                //PaymentPlots = (ICollection<RelationshipPaymentsPlots>)p.PaymentPlots,
//                PaymentPlots = p.PaymentPlots,
//                PaymentProject = p.PaymentProject
//            };
//            await _paymentRepository.AddPaymentAsync(payment);
//        }

//        public async Task DeletePaymentAsync(int id)
//        {
//            await _paymentRepository.DeletePaymentAsync(id);
//        }

//        public async Task<IEnumerable<PaymentDTO>> GetAllPaymentsAsync()
//        {
//            var payments = await _paymentRepository.GetAllPaymentsAsync();
//            return _mapper.Map<IEnumerable<PaymentDTO>>(payments);
//        }

//        public async Task<PaymentDTO> GetPaymentByIdAsync(int id)
//        {
//            var p = await _paymentRepository.GetPaymentByIdAsync(id);
//            if (p == null) return null;
//            return new PaymentDTO();
//        }

//        public async Task UpdatePaymentAsync(PaymentDTO p)
//        {
//            var payment = new Payment
//            {
//                PaymentConfirmation = (ICollection<Document>)p.PaymentConfirmation,
//                Title = p.Title,
//                movement = p.movement,
//                dose = p.dose,
//                HNagainst = p.HNagainst,
//                Datereference = p.Datereference,
//                DataValue = p.DataValue,
//                Detiels = p.Detiels,
//                Surplus = p.Surplus,
//                Amount = p.Amount,
//                Professional = p.Professional,
//                LastPaymentDate = p.LastPaymentDate,
//                PaymentExecutionMethodID = p.PaymentExecutionMethodID,
//                PaymentStatusId = p.PaymentStatusId,
//                //PaymentPlots = (ICollection<RelationshipPaymentsPlots>)p.PaymentPlots,
//                PaymentPlots = p.PaymentPlots,
//                PaymentProject = p.PaymentProject
//            };
//            await _paymentRepository.UpdatePaymentAsync(payment);
//        }
//    }
//}


using AutoMapper;
using BuyRealEstate.Core.DTos;
using BuyRealEstate.Core.Interfaces;
using BuyRealEstate.Domain.Interfaces;
using BuyRealEstate.Domain.Models;
using BuyRealEstate.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuyRealEstate.Core.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IMapper _mapper;

        public PaymentService(IPaymentRepository paymentRepository, IMapper mapper)
        {
            _paymentRepository = paymentRepository;
            _mapper = mapper;
        }

        public async Task AddPaymentAsync(PaymentDTO paymentDto)
        {
            var payment = _mapper.Map<Payment>(paymentDto);
            await _paymentRepository.AddPaymentAsync(payment);
        }

        public async Task DeletePaymentAsync(int id)
        {
            await _paymentRepository.DeletePaymentAsync(id);
        }

        public async Task<IEnumerable<PaymentDTO>> GetAllPaymentsAsync()
        {
            var payments = await _paymentRepository.GetAllPaymentsAsync();
            return _mapper.Map<IEnumerable<PaymentDTO>>(payments);
        }

        public async Task<PaymentDTO> GetPaymentByIdAsync(int id)
        {
            var payment = await _paymentRepository.GetPaymentByIdAsync(id);
            return payment == null ? null : _mapper.Map<PaymentDTO>(payment);
        }

        public async Task UpdatePaymentAsync(PaymentDTO paymentDto)
        {
            var payment = _mapper.Map<Payment>(paymentDto);
            await _paymentRepository.UpdatePaymentAsync(payment);
        }
    }
}
