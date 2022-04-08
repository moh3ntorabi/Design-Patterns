using System;

namespace Decorator_Uml
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ConcreteComponent concrete = new ConcreteComponent();
            //concrete.operation();
            ConcreteDecorator concreteDecorator = new ConcreteDecorator(concrete);
            concreteDecorator.operation();

            SendEmail send = new SendEmail();
            EmailDecorator emailDecorator = new EmailDecorator(send);
            emailDecorator.Send();
            Console.ReadLine();
        }
    }
}
