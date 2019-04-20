using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hotel.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Room Number")]
        public string RoomNumber { get => "RM" + FloorNumber + "0" + RoomId; }

        [Display(Name = "Floor Number")]
        public int FloorNumber { get; set; }
        
        public int RoomId { get; set; }

    }
}