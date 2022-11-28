using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneEF.Models
{
    public class City
    {
        [Key] //Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.None)]  //Identity kapatma
        public byte PlateCode { get; set; }  
        public string Name { get; set; }
        
        

    }
}
