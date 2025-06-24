using Microsoft.VisualBasic;
using System.Collections;
using System.Xml.Linq;

namespace HelloWorld      //Route nmaespace
{
    // class , struct , Enum , Interface
    internal class Program
    {
        private static int number02;

        /// <summary>
        /// This Function can Sum Two int numbers
        /// </summary>
        /// <param name="num1">This is the first number</param>
        /// /// <param name="num2">This is the second number</param>
        /// <Retuen> The Result Will be The sum of num1 + num2 </Retuen>
        /// 

        static int sum(int num1 , int num2)
        {
        return num1 + num2; 
        }
        static void Main(string[] args)  //Entry Point
        {
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
            // Console : Class
            // WriteLine : Function in Class
            #region Comment and regions
            //This is my first comment [ Single Line Comment ]
            //int x = 5;
            //int y = 5;

            /*
            This is my first Multiple Line Comment
             int x = 5;
             int y = 5;
              */

            #endregion

            #region Naming Conventions
            //Pascal Case  [C#]
            //Mariam Shindy

            //Camel case [js]
            //maiam Shindy Route

            //Kebab-Case  [Angular]
            //    Mariam -Shindy - Route

            //    Snake_Case
            //    Mariam_Shindy_Route

            #endregion

            #region Variables declaration
            //int studentAge = 20;   //4 bytes in stack [value = 20]
            //Console.WriteLine(studentAge);
            //Datatype   Name[camelCase]    value
            //int 9number    invalid
            //int _number = 20;  //Valid
            //int @class = 200;
            //Console.WriteLine(@class);
            //int @struct = 200;

            //PascalCase===> MyNmae
            //camelCase==> myNmae
            //snake_case==> my_name
            //kebab-Case==> my-name

            //    int number = 20; , number02 =200;
            //    //int x, y;
            //    Console.WriteLine(number);
            //string myName = "mariam";

            //Int32 X = 29;
            //int x = 29;  //   alias [c# KEYWORD]
            //String name = "Mariam";
            //string name = "Mariam";

            #endregion

            #region Value Types
            //string name = "Mariam";
            //String myName = "Mariam";

            //Single number = 10;
            //float muNumber = 10;

            //int x;
            ////allocate 4 bytes in stack [uninitialized]
            //x =5;
            ////assign value into variable
            //Console.WriteLine(x);
            //int y = 10;
            //Console.WriteLine(y);
            //Console.WriteLine();
            //y = x; // y = x =5
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //y++;
            //Console.WriteLine();
            //Console.WriteLine(x);
            //Console.WriteLine(y);   

            //int x = 10;
            //string name = "Mariam";
            //Console.Write(x);
            //Console.WriteLine(name);

            point p1;
            //Allocate 4 bytes in stack
            //Allocate 0 bytes in heap

            p1  = new point();
            //[1] Allocate required bytes in heap [8 bytes]
            //[2] Initialize each field with the default value based on data type
            //[3] Call user defined constructor if exist
            //[4] Assign reference to the object in the heap
            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y);
            //Console.WriteLine();
            point p2 = new point() { x= 5, y = 10 };
            Console.WriteLine(p2.x);
            Console.WriteLine(p2.y);

            p1 = p2;  //x =5 , y=10
            Console.WriteLine(p1.x);
            Console.WriteLine(p1.y);
            Console.WriteLine(p2.x);
            Console.WriteLine(p2.y);

            p1.x =30;
            Console.WriteLine();

            Console.WriteLine(p1.y);
            Console.WriteLine(p2.x);
            Console.WriteLine("Demo1");
            #region object1

            #endregion
            #endregion

            ///////


        }
    }
}
