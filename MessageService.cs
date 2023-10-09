using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Practice
{
    internal class MessageService
    {
        // Step 1: Declare the delegate
        public delegate void MessageReceivedHandler(string message);

        // Step 2: Declare the event using the delegate
        public event MessageReceivedHandler MessageReceived;

        // Method to simulate receiving a message and raising the event


        public void ReceiveMessage(string message)
        {
            Console.WriteLine("MessageService: Received a message.");

            // Step 3: Raise the event
            MessageReceived?.Invoke(message);
        }
    }
}
