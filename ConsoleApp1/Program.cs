// See https://aka.ms/new-console-template for more information

int guess = 0;
string input = "";

do
{
    Console.WriteLine("What Was The First Sentence Lieutenant-Governor A.G. Archibald, say about their land?");
    if (guess== 2)
    {
        Console.WriteLine("Look through the drop-down links and find where it talks about treaties and who benefits from them");
    }
    else if(guess==4)
    {
        Console.WriteLine("Answer Is: Your Great Mother, therefore, will lay aside for you ‘lots’ of land to be used by you and your children forever ");
    }
    input = Console.ReadLine();
    guess++;

} while (input != "Your Great Mother, therefore, will lay aside for you ‘lots’ of land to be used by you and your children forever");

Console.WriteLine("Correct Answer!");
guess = 0;



do
{
    Console.WriteLine("Where does the quote “As long as the sun shines, the grass grows, and the water First Shows Up On the Website?");
    if (guess==2)
    {
        Console.WriteLine("look for the ‘Indian Treaty’ coin");
    }
    
       else if(guess==4)
    {
        Console.WriteLine("Correct Answer Is: the first webpage");
    }
    input = Console.ReadLine();
    guess++;
} while (input != "the first webpage");

Console.WriteLine("Good Job! Correct Answer");
guess = 0;
  
do
{
    Console.WriteLine("What Happened on May 12, 1870?");
    if (guess == 2)
    {
        Console.WriteLine("Find a historical timeline that talks about Manitoba and its treaty located somewhere on the education tab");
    }
    else if (guess == 5)
    {
        Console.WriteLine("Answer Is: Manitoba Act is passed, making Manitoba Canada’s fifth province");
    }
    input = Console.ReadLine();
    guess++;

} while (input != "Manitoba Act is passed, making Manitoba Canada’s fifth province");

Console.WriteLine("Correct Answer!");
guess = 0;


do
{
    Console.WriteLine("A speaker talks about: Historic and Contemporary Issues Surrounding the Treaties; Missing and Murdered Indigenous Women and Girls; Residential School System; and Spirit and Intent of the Treaties What is their name?  ");
    if (guess == 2)
    {
        Console.WriteLine("Learn and Explore about speaker profiles ");
    }
    else if (guess == 5)
    {
        Console.WriteLine("Answer Is: Manitoba Act is passed, making Manitoba Canada’s fifth province");
    }
    input = Console.ReadLine();
    guess++;

} while (input != "Manitoba Act is passed, making Manitoba Canada’s fifth province");

Console.WriteLine("Correct Answer!");
guess = 0;







