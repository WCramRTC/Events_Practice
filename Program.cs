﻿using System.Diagnostics;

namespace Events_Practice
{
    internal class Program
    {
        static void Main()
        {
            var messageService = new MessageService();

            Player ednalynn = new Player("Ednalynn");

            // Step 4: Subscribe to the event
            messageService.MessageReceived += OnMessageReceived;
            messageService.MessageReceived += FightTheDonkey;
            messageService.MessageReceived += ednalynn.SayTheMessage;

            messageService.MessageReceived -= OnMessageReceived;

            // Simulate receiving a message
            messageService.ReceiveMessage("Hello, World!");

            Console.ReadKey();
        }

        // Event handler
        static void OnMessageReceived(string message)
        {
            Console.WriteLine($"Program: Message received - {message}");
        }

        static void FightTheDonkey(string message)
        {
            Console.WriteLine($"Fought the donkey - {message}");
        }

    }
}