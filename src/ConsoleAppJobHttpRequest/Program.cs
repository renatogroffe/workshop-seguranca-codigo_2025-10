﻿using Microsoft.Extensions.Configuration;
using Serilog.Sinks.SystemConsole.Themes;
using Serilog;

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .AddEnvironmentVariables()
    .Build();

var logger = new LoggerConfiguration()
    .WriteTo.Console(theme: AnsiConsoleTheme.Literate)
    .CreateLogger();

logger.Information("Iniciando a execucao do Job...");

try
{
    using var httpClient = new HttpClient();
    var endpointRequest = configuration["EndpointRequest"];
    var response = await httpClient.GetAsync(endpointRequest);
    response.EnsureSuccessStatusCode();
    logger.Information($"URL para envio da requisicao: {endpointRequest}");
    logger.Information("Notificacao enviada com sucesso!");
    logger.Information($"Dados recebidos = {await response.Content.ReadAsStringAsync()}");
    logger.Information("Job executado com sucesso!");
}
catch (Exception ex)
{
    logger.Error($"Erro durante a execucao do Job: {ex.Message}");
    Environment.ExitCode = 1;
}