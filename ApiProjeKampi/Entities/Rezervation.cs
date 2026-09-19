namespace ApiProjeKampi.Entities
{
    public class Rezervation
    {
        public int RezervationId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime ReservationDate { get; set; }
        public string RezervationTime { get; set; }
        public int CountofPeople { get; set; }
        public string Message { get; set; }
        public string ReservationStatus { get; set; }
    }
}
