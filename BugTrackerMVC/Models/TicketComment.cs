using System.ComponentModel;

namespace BugTrackerMVC.Models
{
    public class TicketComment
    {
        public int Id { get; set; }

        [DisplayName("Ticket")]
        public int TicketId { get; set; }

    }
}
