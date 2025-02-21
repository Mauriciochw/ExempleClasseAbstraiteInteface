using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleClasseAbstraiteInteface
{
    class NotificationCourriel : NotificationMessage
    {
        public string CourrielDestinataire { get; set; }

        public NotificationCourriel(string courrielDestinataire, string message)
            : base(message)
        {
            CourrielDestinataire = courrielDestinataire;
        }

        public override void Envoyer()
        {
            Console.WriteLine($"Envoi d'un courriel à {CourrielDestinataire} : {Message}");
        }
    }
}
