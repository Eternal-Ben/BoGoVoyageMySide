using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoGoVoyage.Models
{
    public class Travel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int AvailableService { get; set; }
        public int CostPerPerson { get; set; }

        public void Reserving(int AvailableService)
        {

        }

        public int RaisonAnnulationDossier()
        {
        int client = 1;
        int placesinsufisante = 2;
        }
    }
}