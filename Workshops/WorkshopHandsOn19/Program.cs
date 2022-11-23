using System;
using WorkshopHandsOn19.Notifications;
using WorkshopHandsOn19.Recipients;

namespace WorkshopHandsOn19
{
    class Program
    {
        static void Main(string[] args)
        {
            IRecipient recipient = Recipient.Create("Bernt", "0765533667", "bernt.g.johansson@Volvo.com");
            IRecipient recipient1 = Recipient.Create("Kalle", "070322288", "kalle.andersson@Volvo.com");

            IServiceAgent agent = SMS.Create(recipient, recipient1);
            INotificationService service = NotificationService.Create();

            service
                .SetServiceAgent(agent)
                .Send("Some kind of message.");

            service
                .SetServiceAgent(InformationMessage.Create(recipient))
                .Send("Another message.");

            recipient = Recipient.Create("Olle", "070999999", "olle.karlsson@Volvo.com");

            service
                .SetServiceAgent(ErrorMessage.Create(recipient1, recipient))
                .Send("Something is wrong.");

            Console.ReadKey();
        }
    }
}
