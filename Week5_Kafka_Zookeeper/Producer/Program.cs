// See https://aka.ms/new-console-template for more information
using System;
using Confluent.Kafka;

class Program
{
    static void Main(string[] args)
    {
        var config = new ProducerConfig { BootstrapServers = "localhost:3030" };
        string topic = "chat";
        using (var producer = new ProducerBuilder<Null, string>(config).Build())
        {
            while (true)
            {
                Console.Write("You: ");
                var input = Console.ReadLine();
                if (input == "exit") break;
                producer.Produce(topic, new Message<Null, string> { Value = input });
            }
        }
    }
}

