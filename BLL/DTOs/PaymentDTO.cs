using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PaymentDTO

    {
        public int Id { get; set; }
        public DateTime ReceivedDate { get; set; }
        public int ReceivedPayment { get; set; }
    }
}
