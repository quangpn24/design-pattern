﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.ConcreteCommand
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            
        }
        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
