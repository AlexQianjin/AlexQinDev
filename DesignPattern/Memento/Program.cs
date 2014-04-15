using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        /// <summary>
        /// 备忘录（Memento）
        /// 在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。
        /// 这样以后就可以将该对象恢复到原先保存的状态。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On";
            o.Show();

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            o.State = "Off";
            o.Show();

            o.SetMemento(c.Memento);
            o.Show();

            Console.Read();
        }
    }
}
