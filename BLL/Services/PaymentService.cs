using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PaymentService
    {
       
            public static List<PaymentDTO> Get()
            {
                var data = DataAccessFactory.PaymentData().Get();
                var mapper = MapperService<Payment, PaymentDTO>.GetMapper();
                return mapper.Map<List<PaymentDTO>>(data);
            }
            public static PaymentDTO Get(int id)
            {
                var data = DataAccessFactory.PaymentData().Get(id);
                var mapper = MapperService<Payment, PaymentDTO>.GetMapper();
                return mapper.Map<PaymentDTO>(data);
            }
            public static bool Add(PaymentDTO payment)
            {
                var mapper = MapperService<PaymentDTO, Payment>.GetMapper();
                var mapped = mapper.Map<Payment>(payment);
                return DataAccessFactory.PaymentData().Create(mapped);

            }
            public static bool Update(PaymentDTO payment)
            {
                var mapper = MapperService<PaymentDTO, Payment>.GetMapper();
                var mapped = mapper.Map<Payment>(payment);
                return DataAccessFactory.PaymentData().Update(mapped);

            }
            public static bool Delete(int id)
            {

                return DataAccessFactory.PaymentData().Delete(id);

            }
        }
}
