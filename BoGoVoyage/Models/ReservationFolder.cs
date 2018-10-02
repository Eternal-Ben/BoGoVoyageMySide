using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoGoVoyage.Models
{
    public class ReservationFolder
    {
        public int UniqueNumber { get; set; }
        public string CreditCardNumber { get; set; }
        public int CostPerPerson { get; set; }
        public int TotalCost { get; set; }

        public void Cancel()
        {

        }

        public void CreditValidate()
        {

        }

        public void Accepted()
        {

        }
    }
}