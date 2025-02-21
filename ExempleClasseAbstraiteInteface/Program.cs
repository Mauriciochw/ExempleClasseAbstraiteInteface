using ExempleClasseAbstraiteInteface;

class Program
{
    static void Main()
    {
        INotification courriel = new NotificationCourriel("client@email.com", "Votre commande a été expédiée !");
        courriel.Envoyer(); // Sortie : "Envoi d'un courriel à client@email.com : Votre commande a été expédiée !"

        INotification sms = new NotificationSMS("+15145556666", "Votre code de vérification est 1234.");
        sms.Envoyer(); // Sortie : "Envoi d'un SMS à +15145556666 : Votre code de vérification est 1234."

        INotification push = new NotificationPush("appareil12345");
        push.Envoyer(); // Sortie : "Envoi d'une notification Push au dispositif appareil12345"
    }
}
