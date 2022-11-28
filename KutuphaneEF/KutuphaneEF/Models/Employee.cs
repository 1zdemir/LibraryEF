using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneEF.Models
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int LibraryId { get; set; }
        [ForeignKey("LibraryId")]
        public Library Library { get; set; }
    }
}
