using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Payment, int, bool> PaymentData()
        {
            return new PaymentRepo();
        }
        public static IRepo<Client, int, bool> ClientData()
        {
            return new ClientRepo();
        }
    }
}
