using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleClasseAbstraiteInteface
{
    // Notification par SMS hérite de NotificationMessage
    class NotificationSMS : NotificationMessage
    {
        public string NumeroTelephone { get; set; }

        public NotificationSMS(string numeroTelephone, string message)
            : base(message)
        {
            NumeroTelephone = numeroTelephone;
        }

        public override void Envoyer()
        {
            Console.WriteLine($"Envoi d'un SMS à {NumeroTelephone} : {Message}");
        }
    }
}
