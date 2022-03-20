using OBS.Domain.Entity;
using RabbitMQ.Client;
using System.Text;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("v1/receberdemanda", (DemandaEntity oDemanda) => {

    try
    {        
        // ESTABELECE CONEXAO COM O RABBITMQ
        var factory = new ConnectionFactory() { HostName = "localhost" };
        using (var connection = factory.CreateConnection())
        using (var channel = connection.CreateModel())
        {

            // CRIA UMA FILA PARA TRANSMITIR AS MENSAGENS
            channel.QueueDeclare(queue: "qDemandasEntry",
                                 durable: true,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            // DEFINE A MENSAGEM A SER TRANSMITIDA
            string message = System.Text.Json.JsonSerializer.Serialize(oDemanda);
            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(exchange: "",
                                 routingKey: "qDemandasEntry",
                                 basicProperties: null,
                                 body: body);


            return Results.Ok(oDemanda);

        }
    }
    catch (global::System.Exception oEx)
    {
        return Results.BadRequest(oEx);
    }

});

app.Run();