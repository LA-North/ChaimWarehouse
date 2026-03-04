using ChaimWarehouse.WarehouseFolder;
using Serilog;
//using WarehouseManager.WarehouseFolder;
namespace ChaimWarehouse.Application
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            EventMessageService eventMessageService = new EventMessageService(Warehouse.GetWarehouse());
            Log.Logger = new LoggerConfiguration()
                 .MinimumLevel.Debug()
                 .WriteTo.Console()
                 .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day)
                 .CreateLogger();
            try
            {
                Log.Information("Starting application");
                var app = new App();
                app.ShowWelcome();
                app.Run();

            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
       
    }
}
