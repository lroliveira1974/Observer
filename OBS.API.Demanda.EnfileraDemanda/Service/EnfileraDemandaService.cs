using OBS.Domain.Entity;
using RabbitMQ.Client;
using System.Text;

namespace OBS.API.Demanda.EnfileraDemanda.Service
{
    public class EnfileraDemandaService
    {
        public bool EnfileraDemanda(DemandaEntity oDemanda, string RabbitMQHost, string QueueNamed)
        {
            try
            {
                // ESTABELECE CONEXAO COM O RABBITMQ
                var factory = new ConnectionFactory() { HostName = RabbitMQHost };
                using (var connection = factory.CreateConnection())
                using (var channel = connection.CreateModel())
                {

                    // CRIA UMA FILA PARA TRANSMITIR AS MENSAGENS
                    channel.QueueDeclare(queue: QueueNamed,
                                         durable: true,
                                         exclusive: false,
                                         autoDelete: false,
                                         arguments: null);

                    // DEFINE A MENSAGEM A SER TRANSMITIDA
                    string message = System.Text.Json.JsonSerializer.Serialize(oDemanda);
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "",
                                         routingKey: QueueNamed,
                                         basicProperties: null,
                                         body: body);


                    return true;

                }
            }
            catch (global::System.Exception oEx)
            {
                return false;
            }
        }
    }
}
