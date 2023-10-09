namespace Events_Practice
{
    internal class Program
    {
        static void Main()
        {
            var messageService = new MessageService();

            // Step 4: Subscribe to the event
            messageService.MessageReceived += OnMessageReceived;

            // Simulate receiving a message
            messageService.ReceiveMessage("Hello, World!");

            Console.ReadKey();
        }

        // Event handler
        static void OnMessageReceived(string message)
        {
            Console.WriteLine($"Program: Message received - {message}");
        }

    }
}