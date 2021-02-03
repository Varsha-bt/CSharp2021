using System;

namespace UserInput
{
    /* readuserdata class to take userinput
   * Author name: Varsha B T
   * date: 03 feb 2021 */
    class ReadUserData
    {
        /* main method */
        static void Main(string[] args)
        {
            Console.WriteLine("enter value of your choice:");

            int n = Convert.ToInt32(Console.ReadLine());
            string m = Console.ReadLine();

            Console.WriteLine("enterd value is:" + n+" "+m);

        }
    }
}
