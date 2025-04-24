using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Unity;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Manager manager = new Manager() { Name = "Manager 1" };
            //TeamLead teamLead = new TeamLead() { Name = "TeamLead 1" };
            //Developer developer = new Developer { Name = "Developer 1" };

            //Task task1 = new Task { Title = "Task 1", Description = "Description of Task 1" };
            //Task task2 = new Task { Title = "Task 2", Description = "Description of Task 2" };

            //teamLead.AssignTask(task1, developer);
            //manager.AssignTask(task2, teamLead);

            WindsorContainer container = new WindsorContainer();
            container.Register(Component.For<Shopper>().ImplementedBy<Shopper>());
            container = new WindsorContainer();
            container.Register(Component.For<Shopper>().ImplementedBy<Shopper>());
            container.Register(Component.For<ICreditCard>().ImplementedBy<VisaCard>());
            Shopper shoper = container.Resolve<Shopper>();

            UnityContainer container2 = new UnityContainer();
            container2.RegisterType<Shopper, Shopper>();
            container2.RegisterType<ICreditCard, VisaCard>();
            Shopper shoper2 = container2.Resolve<Shopper>();
            ICreditCard creditCard2 = container2.Resolve<ICreditCard>();
            shoper2.Checkout(creditCard2);
        }
    }
}
