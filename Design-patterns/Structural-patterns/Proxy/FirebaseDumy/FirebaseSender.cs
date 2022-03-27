using System;

namespace FirebaseDumy
{
    public class FirebaseSender : IFirebaseSender
    {
        public void Connect(string username, string password)
        {
            Console.WriteLine("Conectandose al servicio de Firebase");
            Console.WriteLine($"Conexión exitosa con usuario: {username}");
        }

        public bool Send(Device device, Message message)
        {
            Console.WriteLine($"Enviando mensaje {message.Title} al dispositivo {device.DeviceId}");
            Random random = new Random();
            bool randomBool = random.Next(2) == 1;
            return randomBool;
        }
    }
}
