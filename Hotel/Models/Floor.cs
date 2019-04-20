using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Floor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FloorNumber { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}