using EasyLOB.Library;
using System;
using System.Linq.Expressions;

namespace EasyLOB.Shell
{
    partial class Program
    {
        private static void DOTNETLambdaDemo<TEntity>()
            where TEntity : class
        {
            Console.WriteLine("\nLambda Expressions Demo");

            {
                {
                    Entity entity = new Entity();
                    Func<Entity, object> lambda;

                    lambda = (x => x.XInt);
                    Console.WriteLine("[ " + lambda(entity).ToString() + " ]");

                    lambda = (x => x.XString);
                    Console.WriteLine("[ " + lambda(entity).ToString() + " ]");

                    lambda = (x => x.XDateTime);
                    Console.WriteLine("[ " + lambda(entity).ToString() + " ]");

                    lambda = (x => x.XCollection);
                    Console.WriteLine("[ " + lambda(entity).ToString() + " ]");

                    Console.WriteLine("[ " + lambda.ToString() + " ]");
                }

                {
                    var parameterExpression = Expression.Parameter(typeof(TEntity), "x");
                    var memberExpression = Expression.PropertyOrField(parameterExpression, "XInt");
                    var lambda = Expression.Lambda<Func<TEntity, int>>(memberExpression, parameterExpression); // int !?!

                    Console.WriteLine("[ " + lambda.ToString() + " ]");
                }

                {
                    Entity entity = new Entity();
                    // x => x.XString == "ABC"
                    var parameter = Expression.Parameter(typeof(Entity), "x");
                    var member = Expression.Property(parameter, "XString");
                    var value = Expression.Constant("ABC");
                    var equal = Expression.Equal(member, value);
                    var lambda = Expression.Lambda<Func<Entity, bool>>(equal, parameter);

                    Console.WriteLine("[ " + lambda.ToString() + " ]");
                }

                {
                    Entity entity = new Entity();
                    // x => x.XString
                    var parameter = Expression.Parameter(typeof(Entity), "x");
                    var member = Expression.Property(parameter, "XString");
                    var lambda = Expression.Lambda<Func<Entity, object>>(member, parameter);

                    Console.WriteLine("[ " + lambda.ToString() + " ]");
                }

                //PropertyInfo[] properties = typeof(TEntity).GetProperties();
                //foreach (PropertyInfo p in properties)
                //{
                //    var parameterExpression = Expression.Parameter(typeof(TEntity), "x");
                //    var memberExpression = Expression.PropertyOrField(parameterExpression, p.Name);

                //    var memberExpressionConversion = Expression.Convert(memberExpression, typeof(object));
                //    var lambda = Expression.Lambda<Func<TEntity, object>>(memberExpressionConversion, parameterExpression);
                //    Console.WriteLine("[ " + lambda.ToString() + " ]");
                //}
            }
        }

        private static void DOTNETLambdaHelperDemo<TEntity>()
            where TEntity : class
        {
            Console.WriteLine("\nLambda Expressions Helper Demo");

            {
                {
                    Expression<Func<TEntity, object>> lambda = LambdaHelper<TEntity>.ToFuncProperty("XString");
                    Console.WriteLine("[ " + lambda.ToString() + " ]");
                }

                {
                    Expression<Func<TEntity, object>> lambda = LambdaHelper<TEntity>.ToFuncProperty("XCollection");
                    Console.WriteLine("[ " + lambda.ToString() + " ]");
                }

                //PropertyInfo[] properties = typeof(TEntity).GetProperties();
                //foreach (PropertyInfo p in properties)
                //{
                //    Expression<Func<TEntity, object>> lambda = LambdaHelper<TEntity>.ToFunEntObj(p.Name);
                //    //Expression<Func<TEntity, object>> lambda = LambdaHelper<TEntity>.ToFunEntObj(p);
                //    Console.WriteLine("[ " + lambda.ToString() + " ]");
                //}
            }
        }
    }

    public class Entity
    {
        public int XInt { get { return 1; } set { } }

        public string XString { get { return "ABC"; } set { } }

        public DateTime XDateTime { get { return DateTime.Now; } set { } }

        public EntityCollection XCollection { get { return new EntityCollection(); } set { } }
    }

    public class EntityCollection
    {
        public int XInt { get { return 1; } set { } }

        public string XString { get { return "ABC"; } set { } }

        public DateTime XDateTime { get { return DateTime.Now; } set { } }
    }
}