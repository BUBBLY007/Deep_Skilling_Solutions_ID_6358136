// See https://aka.ms/new-console-template for more information
using System;
using Confluent.Kafka;

class Program
{
    static void Main(string[] args)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "chat-group",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };
        string topic = "chat";
        using (var consumer = new ConsumerBuilder<Null, string>(config).Build())
        {
            consumer.Subscribe(topic);
            Console.WriteLine("Listening for messages...");
            while (true)
            {
                var msg = consumer.Consume();
                Console.WriteLine($"Received: {msg.Message.Value}");
            }
        }
    }
}

