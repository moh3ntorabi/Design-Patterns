﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Uml
{
    public abstract class Component
    {
        public abstract void operation();
    }

    public class ConcreteComponent : Component
    {
        public override void operation()
        {
            Console.WriteLine("Concretecomponent=Run");
        }
    }
}
