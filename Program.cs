//after I pick a category, it doesn't return a restaurant. data validation on play again option is good. 
bool playagain = true;
string choice;
string decision;
while(playagain == true)
{
    string [] burgerplaces = {"McDonalds","Burger King", "Wendy's", "Moo Moo's","Flip's", "East Main", "Five Star","Squeeze","BurgerIM","Nation's"};
    string [] chickenplaces = {"Popeye's","Raising Canes","Church's","Wingstop","KFC","Chik-Fil-A","Luu's","L&L","Manny's","Krispy Krunchy Chicken"};
    string [] chineseplaces = {"China Village","China Palace","Peking Restaurant","Dave Wong's","Yen Du Restaurant","Mandarin Villa Express","Tsing Tao","China Palace","Louie's Chinese Restaurant","Oriental Chef"};

    Console.WriteLine("Please pick a category:Burger, Chicken, Chinese.");
    choice = Console.ReadLine();

    if(choice == "Burger")
    {
        Random numGen = new Random();
        int burger = numGen.Next(0,burgerplaces.Length);
        Console.WriteLine("We're going to " + burgerplaces[burger]);
    }

    else if(choice == "Chicken")
    {
        Random numGen = new Random();
        int chicken = numGen.Next(0,chickenplaces.Length);
        Console.WriteLine("We're going to " + chickenplaces[chicken]);
    }

    else if(choice == "Chinese")
    {
        Random numGen = new Random();
        int chinese = numGen.Next(0,chineseplaces.Length);
        Console.WriteLine("We're going to " + burgerplaces[chinese]);
    }
    Console.WriteLine("Would you like to try again?Type Y to try again or N to end.");
    decision = Console.ReadLine().ToUpper();
    //if the user wanted to try again, pressing "Y" will send them to the beginning
   if(decision == "Y")
    {
      playagain = true;
    }
    else if(decision == "N")
    {
      //if the user wanted to stop pressing "N" will end the program
      playagain = false;
    }
    else
    {
        Console.WriteLine("Please pick a valid option.");
    }     

}    