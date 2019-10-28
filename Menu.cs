using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstNew
{
    class Menu
    {
        public void Menus()
        {

            var account = new Account();

            bool shouldNotExit = true;

            Console.Clear();

            while (shouldNotExit)
            {
                Console.WriteLine("1. Add something");
                Console.WriteLine("2. List something");
                Console.WriteLine("3. Exit");

                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        account.Register();
                        break;
                    case 2:
                        account.DisplayCustomers();
                        break;
                    case 3:
                        shouldNotExit = false;
                        break;



                }

                Console.Clear();
            }
        }
    }
}
