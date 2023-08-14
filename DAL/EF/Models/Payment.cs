using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.EF.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime ReceivedDate { get; set; }
        public int ReceivedPayment { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public Payment()
        {
            Clients = new List<Client>();

        }
    }
}
