using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        /// <summary>
        /// 解释器模式（Interpreter）
        /// 给定一个语言，定义它的文法的一种表示
        /// 并定义一个解释器，这个解释器使用该表示来解释语言中的句子。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Context context = new Context();
            IList<AbstractExpression> list = new List<AbstractExpression>();

            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }

            Console.Read();
        }
    }
}
