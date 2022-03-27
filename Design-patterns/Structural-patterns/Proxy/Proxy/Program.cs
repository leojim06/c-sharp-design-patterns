using FirebaseDumy;
using System;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IFirebaseSender sender = new FirebaseSender();
            IFirebaseSender senderProxy = new FirebaseProxy();
            senderProxy.Connect("SuperUsuario", "MiContrasenaSuperSecreta1");

            Device device = new Device() { DeviceId = "QD126df-gseWQUOKHG123645" };
            Message message = new Message() { Title = "Mi primer mensaje push", BodyMessage = "Hola!!!" };
            bool fueEnviado = senderProxy.Send(device, message);

            if (fueEnviado)
                Console.WriteLine("Su mensaje fue enviado exitosamente");
            else
                Console.WriteLine("Existió un error enviando el mensaje push");
        }
    }
}
