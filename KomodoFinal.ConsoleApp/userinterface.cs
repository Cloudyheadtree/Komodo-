namespace KomodoFinal.ConsoleApp
{
    public class ProgramUI
    {
        //menu repo
        private KomoMenu_Repo _menu = new KomoMenu_Repo();

        public void Run()
        {
            SeedListMenu();
            MainMenu();
        }
        public void SeedListMenu()
        {
            //seed content for menu
            SushiItem selection1 = new SushiItem(01,
            "Green Dragon Roll",
            "Nori sheet, cooked sushi rice, boiled shrimp, cucumber, mayo, avocado, and tobiko fish roe, /n" +
            "Add sriracha mayo for an extra kick.",
            8);

            SushiItem selection2 = new SushiItem (02,
            "Yellow Tail Roll",
            "Nori sheet, raw yellowtail, and cooked sushi rice.",
            "A very mild taste for beginner sushi nommers.",
            8);

            SushiItem selection3 = new SushiItem (03, 
            "Fugu",
            "A red flag on a plate",
            "Blowfish has a reputation for being highly toxic but our sushi chefs know exactly how to prepare it.",
            8);

            _menu.AddSushiItem(selection1);
            _menu.AddSushiItem(selection2);
            _menu.AddSushiItem(selection3);



        }
        public void MainMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine("Sushi For You");
                Console.WriteLine("1> Look Here");
                Console.WriteLine("2> Add New Sushi");
                Console.WriteLine("3> Update Sushi");
                Console.WriteLine("4> Delete Old Sushi");
                Console.WriteLine("5> Bye Bye");
                Console.WriteLine("Choose Here");
                string sushiSelection = Console.ReadLine();

                switch (sushiSelection)
                {
                    case "1":
                    ShowSushi();
                    break;
                    case "2":
                    AddNewSushi();
                    break;
                    case "3":
                    UpdateSushi();
                    break;
                    case "4":
                    DeleteSushi();
                    break;
                    case "5":
                    isRunning = false;
                    break;
                    default:
                    break;
                }
            }
        }
        public void ShowSushi()
        {
            Console.Clear();

            List<SushiItem> sushiItems = _menu.GetMenu();

            foreach (SushiItem item in sushiItems)
            {
                Console.WriteLine("Sushi number     " + item.SushiNumber);
                Console.WriteLine("Sushi Name   " + item.SushiName);
                Console.WriteLine("Sushi Description   " + item.Description);
                Console.WriteLine("Sushi Ingredients  " + item.Ingredients);
                Console.WriteLine("Sushi Price   $" + item.Price);

                Console.WriteLine("");
            }
            Console.WriteLine("Press Enter to Leave");
            Console.ReadKey();
        }

        public void UpdateSushi()
        {
        SushiItem oldSushi = new SushiItem();
        Console.Clear();

        Console.WriteLine("Update Sushi Menu");
        Console.WriteLine("Type Sushi Item Number for the Sushi Item you would like to change:");
        int oldSushiNum = Convert.ToInt32(Console.ReadLine());
        oldSushi = _menu.GetSushiItemBySushiNum(oldSushiNum);
        bool looper = true;
        while (looper)
        {
            Console.Clear();

                Console.WriteLine("1> Sushi number     " + oldSushi.SushiNumber);
                Console.WriteLine("2> Sushi Name   " + oldSushi.SushiName);
                Console.WriteLine("3> Sushi Description   " + oldSushi.Description);
                Console.WriteLine("4> Sushi Ingredients  " + oldSushi.Ingredients);
                Console.WriteLine("5> Sushi Price   $" + oldSushi.Price);
                Console.WriteLine("6> Finished");

                Console.WriteLine("Select a Sushi You Want to Update");
                string sushiSelection = Console.ReadLine();
                switch (sushiSelection)
                {
                    case "1":
                    Console.WriteLine("Enter New Sushi Number");
                    oldSushi.SushiNumber = Convert.ToInt32(Console.ReadLine());
                    break;
                    case "2":
                    Console.WriteLine("Enter New Sushi");
                    oldSushi.SushiName = Console.ReadLine();
                    break;
                    case "3":
                    Console.WriteLine("Enter Description For New Sushi");
                    oldSushi.Description = Console.ReadLine();
                    break;
                    case "4":
                    Console.WriteLine("Add New Ingredients");
                    oldSushi.Ingredients = Console.ReadLine();
                    break;
                    case "5":
                    Console.WriteLine("What Is The New Price");
                    oldSushi.Price = Convert.ToInt32(Console.ReadLine());
                    break;
                    case "6":
                    looper = false;
                    break;
                }


        }
        bool isUpdated = _menu.UpdateCurrentSushiItem(oldSushiNum, oldSushi);
        if (isUpdated == true)
        {
            Console.WriteLine("Sushi Menu Has Been Updated. Press Any Key to Return to Start");

        }
        else 
        {
            Console.WriteLine("Update Unsuccessful.");
        }


        Console.ReadKey();


        }
        public void DeleteSushi()
        {
            SushiItem oldSushi = new SushiItem();

            Console.Clear();

            Console.WriteLine("Select the Number of the Sushi You'd Like to Yeet.");
            int sushiNum = Convert.ToInt32(Console.ReadLine());
            oldSushi = _menu.GetSushiItemBySushiNum(sushiNum);

             Console.WriteLine("1> Sushi number     " + oldSushi.SushiNumber);
                Console.WriteLine("2> Sushi Name   " + oldSushi.SushiName);
                Console.WriteLine("3> Sushi Description   " + oldSushi.Description);
                Console.WriteLine("4> Sushi Ingredients  " + oldSushi.Ingredients);
                Console.WriteLine("5> Sushi Price   $" + oldSushi.Price);

                Console.WriteLine("Are You Sure You Want to Yeet This Sushi? Y/N?");
                string confirmYeet = Console.ReadLine();
                if (confirmYeet.ToUpper() == "y")
                {
                    bool yeetSushi = _menu.DeleteSushiItem(oldSushi);
                    if (yeetSushi == true)
                    {
                        Console.WriteLine("Sayonara, Sushi");
                        Console.WriteLine("Press Any Key To Exit.");
                    }
                    else
                    {
                        Console.WriteLine("Yeet Unsuccessful.");
                        Console.WriteLine("Press Any Key To Exit.");
                    }
                }
                else
                {
                    Console.WriteLine("Canceled" + " \nPress Any Key To Exit.");
                }
                Console.ReadKey();


        }
    }

}