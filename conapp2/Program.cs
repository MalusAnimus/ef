using System;
using System.Linq.Expressions;


namespace conapp2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const string exp = @"Math.Abs(Math.Round(-3.234323,2)) > 3";
            int[] values = new int[0];
            ParameterExpression[] parameters = new ParameterExpression[]{};
            var x = Math.Round(2.344, 2);
            var e = System.Linq.Dynamic.DynamicExpression.ParseLambda(parameters, typeof(bool), exp, values);
            var result = e.Compile().DynamicInvoke();
            Console.WriteLine(result);
            Console.ReadKey();


            Console.WriteLine("Hello World!");
        }
    }
}
