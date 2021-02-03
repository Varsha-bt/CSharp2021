using System;

namespace ArithmaticDecrement
{
    class DecrementValue
    {
        /* decrementValue class to perform decrement
   * Author name: Varsha B T
   * date: 03 feb 2021 */
        static void Main(string[] args)
        {
            /* variable intialization*/

            int value = 10;

            /*displaying variable value*/

            Console.WriteLine("value before decrement: " + value);

            --value;
            Console.WriteLine("value after pre-decrement: " + value);
            value--;
            Console.WriteLine("value after post-decrement: " + value);
        }
    }
}
