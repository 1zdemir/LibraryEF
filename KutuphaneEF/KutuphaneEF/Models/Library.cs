using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneEF.Models
{
    public class Library
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public int BookCount { get; set; }  
        public short Capacity { get; set; } 
        public DateTime EstablishmentDate { get; set; }
        public short DistrictId { get; set; }
        [ForeignKey("DistrictId")] 
        public District District { get; set; }

    }
}
