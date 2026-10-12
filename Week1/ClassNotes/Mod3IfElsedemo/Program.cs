namespace Mod3IfElsedemo
{
    internal class Program
    {

        static void CheckSpeed(int speed)
        {
            if(speed>55)
            {
                if(speed<=65)
                {
                    Console.WriteLine("within limits");
                }
                else if((speed>65) &&  (speed<=85))
                {
                    Console.WriteLine("Speeding ticket issued..");
                }
                else if(speed>85)
                {
                    Console.WriteLine("License revoked!!");
                }
            }
            else
            {
                Console.WriteLine("wait for next car..");
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Speed Checker");
            int speed;
            char choice = 'y';
            //while(condition is true)
           // {
           //keep on doing this
           // }
            while (choice == 'y' || choice == 'Y')
            {
                Console.WriteLine("Enter speed");
                speed = Int32.Parse(Console.ReadLine());
                CheckSpeed(speed);
                Console.WriteLine("Do you want to check next car?(y/Y)");
                choice =char.Parse(Console.ReadLine());
            }

            #region syntaxforifelse
            /*if(condition) if the condition evaluates to true
                * {
                *  //statements
                * }
                * else
                * {
                * 
                * }
                * 
                * if(condition)
                * {
                * 
                * }
                * else if(condition)
                * {
                * 
                * }
                * 
                */

            #endregion
        }
    }
}
