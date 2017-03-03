using Shared;
using System;
using System.Windows.Forms;
using LightInject;

namespace TestSYS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            //DbSetup.SetUpDb();
            var container = ConfigureServices();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(container.GetInstance<frmWelcome>());
            //Application.Run(new frmMenu()); 
            //Application.Run(new frmQAdd());
        }

        public static IServiceContainer ConfigureServices()
        {
            var container = new ServiceContainer();

            container.RegisterInstance<IServiceContainer>(container);
            container.Register<IConfig>( _ => AppSettingsConfigurationReader.GetMaxStudents(), new PerContainerLifetime());

            container.Register<frmWelcome>(new PerContainerLifetime());
            container.Register<frmLogin>(); // frmWelcome Parent

            container.Register<string, int, frmMenu>((factory, name, id) => new frmMenu(name, id));

            var frmMenuFactory = container.GetInstance<Func<string, int, frmMenu>>();
            var menu = frmMenuFactory("someName", 111);

            container.Register<string, int, frmQAdd>((factory, name, id) => new frmQAdd()); // was (name, id));
            container.Register<string, int, frmQAmd>((factory, name, id) => new frmQAmd());
            container.Register<string, int, frmQDel>((factory, name, id) => new frmQDel()); 
            container.Register<frmStudAdd>();
            container.Register<string, int, frmStudAmd>((factory, name, id) => new frmStudAmd()); // dontKnowYetWhat goesIn here));
            //container.Register<frmStudAmd>();
            container.Register<string, int, frmStudDel>((factory, name, id) => new frmStudDel());
            container.Register<string, int, frmTProfile>((factory, name, id) => new frmTProfile());
            container.Register<string, int, frmTTake>((factory, name, id) => new frmTTake()); 

            return container;
        }
    }
}
