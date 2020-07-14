using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TempAverage.Logic;
using Unity;
using Unity.Lifetime;

namespace TempAverage
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var unityContainer = BuildUnityContainer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(unityContainer.Resolve<MainForm>());
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<DataLogic>(new HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
