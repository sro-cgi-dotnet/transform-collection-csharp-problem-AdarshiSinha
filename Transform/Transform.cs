using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public delegate int ExpressionDelegate(int numbers);
    public static class Transform 
    {
        public static int[] Map(this int[] array, ExpressionDelegate expressionDelegate)
        {
                int[] result=new int[array.Length];
                // logic
                for(int i=0; i< array.Length; i++)
                {
                    result[i]=expressionDelegate(array[i]);
                }
                return result;
        }
    }
}
