using Confluent.Kafka;
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var config = new ProducerConfig { BootstrapServers = "kafka:9093" };

        using (var producer = new ProducerBuilder<Null, string>(config).Build())
        {
            var result = await producer.ProduceAsync("test-topic", new Message<Null, string> { Value = "Hello Kafka" });
            Console.WriteLine($"Produced message to: {result.TopicPartitionOffset}");
        }
    }
}
