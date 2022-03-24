using OBS.API.Demanda.EnfileraDemanda.Service;
using OBS.Domain.Entity;



var builder = WebApplication.CreateBuilder(args);

var rabbitMQHost = builder.Configuration.
                       GetSection("HostRabbitMQ");

var queueNamed = builder.Configuration.
                       GetSection("QueueNamed");

var app = builder.Build();

app.MapPost("v1/enfilerademanda", (DemandaEntity oDemanda) => {


    try
    {
        EnfileraDemandaService oEDS = new EnfileraDemandaService();

        if (oEDS.EnfileraDemanda(oDemanda, rabbitMQHost.Value, queueNamed.Value))
        {
            return Results.Ok(oDemanda);
        }
        else
        {
            return Results.BadRequest(oDemanda);
        }
    }
    catch (global::System.Exception oEx)
    {
        return Results.BadRequest(oEx);
    }

});

app.Run();