using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Uml
{
    public abstract class Decorator : Component
    {
        private readonly Component _component;
        public Decorator(Component component)
        {
            _component = component;
        }
        public override void operation()
        {
            _component.operation();
        }
    }
    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Component component):base (component)
        {
            ConcreteDecorator dc=component as ConcreteDecorator;

            if (dc == null)
            {
                //
            }
        }
        public override void operation()
        {
            base.operation();
            NewFeature();
        }
        public void NewFeature()
        {
            Console.WriteLine("new feature");
        }
    }

    //
    public class MyDecorator : ConcreteDecorator
    {
        public MyDecorator(Component component) : base(component)
        {

        }
        public override void operation()
        {
            base.operation();
        }
    }
    public class MyDecorator2 : ConcreteDecorator
    {
        public MyDecorator2(Component component) : base(component)
        {

        }
        public override void operation()
        {
            base.operation();
        }
    }
    
    
}
