using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleClasseAbstraiteInteface
{
    // Classe abstraite servant de base aux notifications textuelles
    abstract class NotificationMessage : INotification
    {
        public string Message { get; set; }

        public NotificationMessage(string message)
        {
            Message = message;
        }

        // Méthode abstraite que les sous-classes doivent implémenter
        public abstract void Envoyer();
    }

}
