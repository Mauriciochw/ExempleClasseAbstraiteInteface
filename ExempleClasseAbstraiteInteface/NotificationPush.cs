using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleClasseAbstraiteInteface
{
    // Notification Push implémente directement INotification «Interface»
    class NotificationPush : INotification
    {
        public string IdentifiantDispositif { get; set; }

        public NotificationPush(string identifiantDispositif)
        {
            IdentifiantDispositif = identifiantDispositif;
        }

        public void Envoyer()
        {
            Console.WriteLine($"Envoi d'une notification Push au dispositif {IdentifiantDispositif}");
        }
    }
}
