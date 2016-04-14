
namespace eu.sig.training.ch05.buildandsendmail.v2
{
    public class BuildAndSendMail
    {

        // tag::buildAndSendMail[]
        public void DoBuildAndSendMail(MailMan m, MailAddress mAddress,
            MailBody mBody)
        {
            // Build the mail
            Mail mail = new Mail(mAddress, mBody);
            // Send the mail
            m.SendMail(mail);
        }

        public class Mail
        {
            public MailAddress Address { get; set; }
            public MailBody Body { get; set; }

            public Mail(MailAddress mAddress, MailBody mBody)
            {
                this.Address = mAddress;
                this.Body = mBody;
            }
        }

        public class MailBody
        {
            public string Subject { get; set; }
            public MailMessage Message { get; set; }

            public MailBody(string subject, MailMessage message)
            {
                this.Subject = subject;
                this.Message = message;
            }
        }

        public class MailAddress
        {
            public string MsgId { get; private set; }

            public MailAddress(string firstName, string lastName,
                string division)
            {
                this.MsgId = $"{firstName[0]}.{lastName.Substring(0, 7)}" +
                    $"@{division.Substring(0, 5)}.compa.ny";
            }
        }
        // end::buildAndSendMail[]

        public MailMessage FormatMessage(MailFont font, string s)
        {
            return null;
        }

        public class MailMan
        {
            public void Send(string mId, string subject, MailMessage mMessage) { }
            public void SendMail(Mail mail) { }
        }

        public class MailFont { }

        public class MailMessage { }

    }
}
