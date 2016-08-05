using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MScompare
{
    /// <summary>
    /// Reverse Polish Notation
    /// 逆波兰式
    /// </summary>
    public class RPN
    {
        private List<Main.MSset> SRC;
        private string fma;

        public RPN(string formula, List<Main.MSset> SRC)
        {
            this.fma = formula;
            this.SRC = SRC;
        }
        static List<String> Compute(List<String> leftSet, List<String> rightSet, char op)
        {
            switch (op)
            {
                case '+': return leftSet.Union(rightSet).ToList<String>();
                case '-': return leftSet.Except(rightSet).ToList<String>();
                case '&': return leftSet.Intersect(rightSet).ToList<String>();
                default: return new List<String>();
            }
        }
        /// <summary>
        /// 逆波兰式算法
        ///1、从左至右扫描一中缀表达式。
        ///2、若读取的是操作数，则判断该操作数的类型，并将该操作数存入操作数堆栈
        ///3、若读取的是运算符
        /// (1) 该运算符为左括号"("，则直接存入运算符堆栈。
        ///	(2) 该运算符为右括号")"，则输出运算符堆栈中的运算符到操作数堆栈，直到遇到左括号为止，此时抛弃该左括号。
        ///	(3) 该运算符为非括号运算符：
        ///		(a) 若运算符堆栈栈顶的运算符为左括号，则直接存入运算符堆栈。
        ///		(b) 若比运算符堆栈栈顶的运算符优先级高，则直接存入运算符堆栈。(##本例中不涉及##)
        ///		(c) 若比运算符堆栈栈顶的运算符优先级低或相等，则输出栈顶运算符到操作数堆栈，直至运算符栈栈顶运算符低于（不包括等于）该运算符优先级，或为左括号，并将当前运算符压入运算符堆栈。
        ///4、当表达式读取完成后运算符堆栈中尚有运算符时，则依序取出运算符到操作数堆栈，直到运算符堆栈为空。
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        static Queue<object> expConvert(String expression)
        {
            var rpn = new Queue<object>();
            var opStack = new Stack<char>();
            char cur;
            String curSet="";
            for (int i = 0; i < expression.Length;i++)
            {
                cur = expression[i];
                if (cur=='#')
                {
                    if (curSet != "")
                    {
                        rpn.Enqueue(int.Parse(curSet.Split('_')[0].Substring(1)));
                        curSet = "";
                    }
                    else
                    {
                        curSet = cur.ToString();
                        while (expression[++i] != '#')
                            curSet += expression[i];
                        i--;
                    }
                }
                else
                {
                    if (cur == '(')
                        opStack.Push(cur);
                    else if (cur == ')')
                    {
                        while (opStack.Peek() != '(')
                            rpn.Enqueue(opStack.Pop());
                        opStack.Pop();
                    }
                    else if(cur =='+'||cur=='-'||cur=='&')
                    {
                        if (opStack.Count == 0)
                            opStack.Push(cur);
                        else if (opStack.Peek() == '(')
                            rpn.Enqueue(cur);
                        else
                        {
                            while (opStack.Peek() != '(')
                                rpn.Enqueue(opStack.Pop());
                            rpn.Enqueue(cur);
                        }
                    }
                }

            }
            while (opStack.Count > 0)
                rpn.Enqueue(opStack.Pop());
            return rpn;
        }
        public List<String> Evaluate()
        {
            try
            {
                var rpn = expConvert(this.fma);
                var calcuStack = new Stack<List<String>>();
                List<String> left, right;
                object cur;
                while (rpn.Count > 0)
                {
                    cur = rpn.Dequeue();
                    if (cur is char)
                    {
                        right = calcuStack.Pop();
                        left = calcuStack.Pop();
                        calcuStack.Push(Compute(left, right, (char)cur));
                    }
                    else if (cur is int)
                    {
                        calcuStack.Push(this.SRC[Convert.ToInt32(cur)].Index);
                    }
                }
                return calcuStack.Pop();
            }
            catch
            {
                MessageBox.Show("Expression has error(s), please check!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<String>();
            }
        }
    }
}
