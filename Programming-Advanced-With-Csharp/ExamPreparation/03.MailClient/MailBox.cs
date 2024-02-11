using System.Text;

namespace MailClient
{
    public class MailBox
    {
        public int Capacity { get; set; }

        public List<Mail> Inbox { get; set; }

        public List<Mail> Archive { get; set; }

        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new List<Mail>();
            Archive = new List<Mail>();
        }

        public void IncomingMail(Mail mail)
        {
            if (Capacity > Inbox.Count)
            {
                Inbox.Add(mail);
            }
        }

        public bool DeleteMail(string sender)
        {
            var toBeRemoved = Inbox.FirstOrDefault(s => s.Sender == sender);
            return Inbox.Remove(toBeRemoved);
        }

        public int ArchiveInboxMessages()
        {
            Archive.AddRange(Inbox);
            var mailMoved = Inbox.Count;
            Inbox.Clear();
            return mailMoved;
        }

        public string GetLongestMessage()
        {
            var longestMail = Inbox.MaxBy(b => b.Body.Length);

            return longestMail.ToString();
        }

        public string InboxView()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Inbox:");
            foreach (var mail in Inbox)
            {
                sb.AppendLine(mail.ToString());
            }

            return sb.ToString();
        }
    }
}
