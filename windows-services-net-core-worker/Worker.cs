using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace windows_services_net_core_worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogDebug("Worker running at: {time}", DateTimeOffset.Now);
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                _logger.LogWarning("Worker running at: {time}", DateTimeOffset.Now);
                _logger.LogError("Worker running at: {time}", DateTimeOffset.Now);
                _logger.LogTrace("Worker running at: {time}", DateTimeOffset.Now);
                _logger.LogCritical("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
