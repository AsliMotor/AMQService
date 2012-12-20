using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;
using Spring.Context.Support;

namespace AsliMotor.SalesReports.Host
{
    public class EndpointConfig : IConfigureThisEndpoint,
        AsA_Server,
        IWantCustomInitialization,
        IWantCustomLogging,
        INameThisEndpoint,
        IWantToRunAtStartup
    {
        public void Init()
        {
            NServiceBus.SetLoggingLibrary.Log4Net(log4net.Config.XmlConfigurator.Configure);
            NServiceBus.Configure.With()
                .SpringFrameworkBuilder(new GenericApplicationContext(ContextRegistry.GetContext()))
                .BinarySerializer();
        }

        public string GetName()
        {
            string endpointName = System.Configuration.ConfigurationManager.AppSettings["endpointname"];
            return endpointName;
        }

        public void Run()
        {
            Console.WriteLine("Server Ready.");
        }

        public void Stop()
        {
        }
    }
}
