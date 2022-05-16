using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChargeProceesing.API.Models.Dtos
{
    public class PackModelDto
    {
        public int Id { get; set; }
        public long requestId { get; set; }
        public string componentType { get; set; }
        public int quantity { get; set; }
        public long packageCharges { get; set; }
        public long deliveryCharges { get; set; }
        public long totalCharges { get; set; }
    }
}
