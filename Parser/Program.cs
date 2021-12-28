using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Parser.Implementation;
using Parser.Interfaces;

namespace Parser
{
    static class Program
    {
        public static IContainer Container;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Container = Configure();
           Application.Run(new Form1(Container.Resolve<IDisciplineFormService>(),Container.Resolve<IOkatoFormService>(),Container.Resolve<IPersonFormService>()));
        }

        private static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DisciplineFormService>()
                .As<IDisciplineFormService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<OkatoFormService>()
                .As<IOkatoFormService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<PersonFormService>()
                .As<IPersonFormService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<Form1>();
            return builder.Build();
        }
    }
}
