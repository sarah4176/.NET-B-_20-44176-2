using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ClientPaymentDTO : ClientDTO
    {
        public List<PaymentDTO> Payment { get; set; }
        public ClientPaymentDTO()
        {
            Payment = new List<PaymentDTO>();
        }
    }
}
