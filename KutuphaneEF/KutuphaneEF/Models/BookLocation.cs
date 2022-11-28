using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneEF.Models
{
    public class BookLocation
    {

        // 1
        public string ISBN { get; set; }
        [ForeignKey("ISBN")]
        public Book Book { get; set; }

        // 2-  1 ve 2 no çift id olduğu için entity ye context class'ında belirtilir.
        public int LibraryId { get; set; }
        [ForeignKey("LibraryId")]
        public Library Library { get; set; }

        public string Cabinet { get; set; }
        public string Shelf { get; set; }
        public byte Amount { get; set; }


    }
}
