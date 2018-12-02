using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Desk.Models
{
   public class return_filling
    {
        public int ID { get; set; }
        public int ClientId { get; set; }
        public string AsessmentYear { get; set; }
        public DateTime DateOfFilling { get; set; }
        public DateTime DateOfDispatch { get; set; }
        public string PrAckNo { get; set; }
        //Refund Or Tax
        public string type { get; set; }
        public string EVC_No { get; set; }
        public DateTime DateOfEreciept { get; set; }
        public string remarks { get; set; }
    }
}
