using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Client
    {
        public int id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Payment")]
        public int PId { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
