namespace MyPortfolio.DAL.Entities
{
    public class Message    // Mesajlar
    {
        public int MessageId { get; set; }
        public string NameSurname { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string MessageDetail { get; set; }
        public DateTime SendDate { get; set; }     // Gönderilme tarihi
        public bool IsRead { get; set; }      // Okundu mu (true, false)
    }
}
