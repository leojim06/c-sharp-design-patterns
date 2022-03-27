using FirebaseDumy;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Proxy
{
    public class FirebaseProxy : IFirebaseSender
    {
        private readonly IFirebaseSender _realFirebaseService;

        public FirebaseProxy()
        {
            _realFirebaseService = new FirebaseSender();
        }

        public void Connect(string username, string password)
        {
            _realFirebaseService.Connect(username, password);
        }

        public bool Send(Device device, Message message)
        {
            Console.WriteLine($"LOG: {DateTime.Now.ToString()} - Solicitud de envío: {device.DeviceId} - {message.Title} - {message.BodyMessage}");
            bool firebaseSendResult = _realFirebaseService.Send(device, message);
            Console.WriteLine($"LOG: {DateTime.Now.ToString()} - Resultado de envío: {firebaseSendResult}");
            return firebaseSendResult;
        }
    }
}
