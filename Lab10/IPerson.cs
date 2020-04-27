using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab10
{
    public interface IPerson
    {

        public void Create();
        
        public int Age();

        public void Show();

        public bool Search(object search);
    }
}