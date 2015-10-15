namespace eu.sig.training.ch05.buildandsendmail.v1
{
    public class BuildAndSendMail {
        // tag::buildAndSendMail[]
        public void buildAndSendMail(MailMan m, string firstName, string lastName,
            string division, string subject, MailFont font, string message1,
            string message2, string message3) {
            // Format the email address
            string mId = firstName[0] + "." + lastName.Substring(0, 7) + "@"
                + division.Substring(0, 5) + ".compa.ny";
            // Format the message given the content type and raw message
            MailMessage mMessage = formatMessage(font,
                message1 + message2 + message3);
            // Send message
            m.send(mId, subject, mMessage);
        }
        // end::buildAndSendMail[]

        public MailMessage formatMessage(MailFont font, string s) {
            return null;
        }

        public class MailMan {

            public void send(string mId, string subject, MailMessage mMessage) {}

        }

        public class MailFont {

        }

        public class MailMessage {

        }

    }
}
