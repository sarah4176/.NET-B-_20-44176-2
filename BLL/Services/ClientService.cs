using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL.Services
{
    public class ClientService
    {
        public static List<ClientDTO> Get()
        {
            var data = DataAccessFactory.ClientData().Get();
            var mapper = MapperService<Client, ClientDTO>.GetMapper();
            return mapper.Map<List<ClientDTO>>(data);
        }
        public static ClientDTO Get(int id)
        {
            var data = DataAccessFactory.ClientData().Get(id);
            var mapper = MapperService<Client, ClientDTO>.GetMapper();
            return mapper.Map<ClientDTO>(data);
        }
        public static bool Add(ClientDTO Client)
        {
            var mapper = MapperService<ClientDTO, Client>.GetMapper();
            var mapped = mapper.Map<Client>(Client);
            return DataAccessFactory.ClientData().Create(mapped);

        }
        public static bool Update(ClientDTO Client)
        {
            var mapper = MapperService<ClientDTO, Client>.GetMapper();
            var mapped = mapper.Map<Client>(Client);
            return DataAccessFactory.ClientData().Update(mapped);

        }
        public static bool Delete(int id)
        {

            return DataAccessFactory.ClientData().Delete(id);

        }
        public static ClientPaymentDTO GetWithPaymentDetails(int id)
        {
            var data = DataAccessFactory.ClientData().Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Client, ClientDTO>();
                cfg.CreateMap<Payment, PaymentDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrted = mapper.Map<ClientPaymentDTO>(data);
            return cnvrted;
        }
       
    }
    
}
