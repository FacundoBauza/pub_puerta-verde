namespace WebApi_PUB_PV
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSignalR(); // Agrega esta l�nea para configurar SignalR

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

        }
    }
}

