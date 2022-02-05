using System;

namespace TamagotchiAPI.Models
{
    public class Playtime
    {
        public int Id { get; set; }
        public DateTime Birthday { get; set; }
        public int PetId { get; set; }
        public Pet Pet { get; set; }
    }
}