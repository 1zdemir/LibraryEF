using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneEF.Models
{
    public class District
    {
        public short Id { get; set; }  // otomatik primary key olarak algılar
        public string Name { get; set; }
        public byte CityId { get; set; }    
        public int Population { get; set; }

        [ForeignKey("CityId")]        
        public City City { get; set; }

    }
}
