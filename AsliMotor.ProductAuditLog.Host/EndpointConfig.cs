using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;
using BonaStoco.Inf.Reporting;
using Spring.Context.Support;
using AsliMotor.AuditLog.Repository;

namespace AsliMotor.AuditLog.Host
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

    public static class ServiceInstaller
    {
        public static NServiceBus.Configure InstallRepositories(this NServiceBus.Configure cfg)
        {
            cfg.Configurer.ConfigureComponent<InvoiceLogRepository>(NServiceBus.ObjectBuilder.ComponentCallModelEnum.Singlecall);
            
            return cfg;
        }
    }
}
