using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter14
{

    internal class UsingExpressionTree
    {
        static void MainUsingExpressionTree()
        {
            Expression const1 = Expression.Constant(1);
            Expression const2 = Expression.Constant(2);
            Expression leftExp = Expression.Multiply(const1, const2);
            Expression param1 = Expression.Parameter(typeof(int));
            Expression param2 = Expression.Parameter(typeof(int));
            Expression rightExp = Expression.Subtract(param1, param2);
            Expression exp = Expression.Add(leftExp, rightExp);
            Expression<Func<int, int, int>> expression =
                Expression<Func<int, int, int>>.Lambda<Func<int, int, int>>(
                    exp, new ParameterExpression[]
                    {
                        (ParameterExpression)param1,
                        (ParameterExpression)param2,
                    });
            Func<int, int, int> func = expression.Compile();


            
        }
    }
}
