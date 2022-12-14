using System.Collections.Generic;
//EVEN MORE INDEPTH TESTING OF METHODS

static void aCalculator(int numba1, int numba2){
    int result = numba1 * numba2;
    Console.WriteLine(result);
}

aCalculator(11, 31);

//more indepth testing of methods

Console.WriteLine("Type in a number:");


int number = Convert.ToInt32(Console.ReadLine());
sqrt(number);


static int sqrt (int number) 
{
    int result = number * number;
    return result;
}
//for loop testing (also array) just type in "for" down arrow, then hit tab (autofill)
string[] yeah = {"yeah", "yur", "yup", "yurt", "yuh", "ye", "yea", "yep"};
for (int i = 0; i <= 7; i++){
   Console.WriteLine(yeah[i]);
}
//more for loop testing
for (double i = 1; i <= 50; i++)
{
    double numba = Math.Pow(2, i);
    Console.WriteLine(numba);
}
//EVEN MORE LOOP TESTING
for (int number1 = 0, number2 = 1, counting = 0; number1 != number2; counting++)
{
    Console.WriteLine("Enter to roll the dice:");
    Console.ReadKey();
    Random random1 = new Random();
    Random random2 = new Random();

    number1 = random1.Next(1,7);
    number2 = random2.Next(1,7);
    Console.WriteLine($"You rolled a {number1} and a {number2}");
    
}


//switch statement testing AGAIN

Console.WriteLine("Write a random letter:");

switch(Console.ReadLine()){
    case "a":{
        Console.WriteLine("A");
        break;
    }
     case "b":{
        Console.WriteLine("B");
        break;
    }
     case "c":{
        Console.WriteLine("C");
        break;
    }
     case "d":{
        Console.WriteLine("D");
        break;
    }
    default: 
    Console.WriteLine("This is default.");
    break; 
}



//array testing
await Task.Delay (100);

string[] bobby = {"name", "Another name", "yet another name", "and yeah what did you expect?"};



//testing to make sure we know about how to use methods 
static void test()
{
    Random number3 = new Random();
    Console.WriteLine($"Your date is {number3.Next(0,100)} years old.");
}


test();


//switch statement testing
Console.WriteLine("Insert:");

switch (Console.ReadLine()){
    case "a":
    {
        Console.WriteLine("Bobby");
        break;
    }
    case "b":
    {
        Console.WriteLine("Apple");
        break;
    }
    default:{
        Console.WriteLine("This is default");
        break;
    }
    
}

//writing randoms testing
Random namehere = new Random();

Console.WriteLine(namehere.Next(1,7));

string[] name2 = {"bobby", "Johnny", "third person"};

Console.WriteLine(name2[2]);



//calculator testing
Console.WriteLine("This is to test if syncing works with Onedrive.");
Console.WriteLine("CALCULATOR (because i'm bored and need some practice and learn) \n---------------------------------------------------------------");
Console.WriteLine("Testing to see if it works. AGAIN");

float num1 = 0;

float num2 = 0;

Console.WriteLine("Insert your first number:");

num1 = Convert.ToUInt64(Console.ReadLine());

Console.WriteLine("Insert your second number:");

num2 = Convert.ToUInt32(Console.ReadLine());

Console.WriteLine("What operand would you like to use?");


switch(Console.ReadLine()){
    case "+": 
    Console.WriteLine($"Result of {num1} + {num2} = " + (num1 + num2));
    break;
    case "-":
    Console.WriteLine($"Result of {num1} - {num2} = " + (num1 - num2));
    break;
    case "/":
    Console.WriteLine($"Result of {num1} / {num2} = " + (num1 / num2));
    break;
    case "*":
    Console.WriteLine($"Result of {num1} * {num2} = " + (num1 * num2));
    break;

}

Console.WriteLine("Press any key to close.");
Console.ReadKey();












Console.WriteLine("Your senses dim around you, the whole world seemingingly fading away at your mere touch.");

await Task.Delay(6000);

Console.WriteLine("You stand up, taking your hands off the ground.");

await Task.Delay(4000);

Console.WriteLine("Just from this, a ray of light from the top of the cavern squirmishes in. You look around, seeing 18 dead corpses.");

await Task.Delay(5000);

Console.WriteLine("You instinctively look at your hands, clean and empty. After a brief moment of confusion, you remember everything.");

await Task.Delay(6000);

Console.WriteLine("You did this, everything that's happening, it's all because of you.");

await Task.Delay(5000);

Console.WriteLine("You look deeper into the cavern, seeing nothing but darkness.");

await Task.Delay(3000);

Console.WriteLine("\"Alright then,\" you say to yourself, you add 18 more to the mental count in your head. Then you half drag, half walk deeper into the cavern.");

Random idfk = new Random();


int randomly = idfk.Next(0,1000);

Console.WriteLine($"Random Number:{randomly}"); 



Random numberGen = new Random();
double roll = 0;
double roll2 = 1;
double attempts = 0;
Console.WriteLine("Press enter to roll the dice"); 
while (roll != roll2){
    Console.ReadKey();
    roll = numberGen.Next(1,7);
    roll2 = numberGen.Next(1,7);
    Console.WriteLine($"You rolled a {roll} on your first die.");
    Console.WriteLine($"You rolled a {roll2} on your second die.");
    attempts++;
}

Console.WriteLine($"It took you {attempts} attempts to roll a two-of-a-kind.");


Console.WriteLine("How much fuckos you got?");

int fuckos = Convert.ToInt32(Console.ReadLine());

string[] attendence1 = new string[fuckos];



for (int i = 0; i < fuckos; i++)
{
    attendence1[i] = Console.ReadLine();
}

Array.Sort(attendence1);

for (int i = 0; i < fuckos; i++)
{
    int numba = i + 1;
    Console.WriteLine($"{numba}. {attendence1[i]}");
}







List<string> attendence = new List<string>();


while (true){
    Console.WriteLine("Enter student's name. Write q to quit");
    string names = Console.ReadLine();

    if (names == "q"){
        break;
    }
    attendence.Add(names);
}




attendence.Sort();

for (int i = 0; i < attendence.Count; i++)
{
    int numba2 = i + 1;
    Console.WriteLine($"{numba2}. {attendence[i]}");
}













List<string> idek = new List<string>();

idek.Add("A friend");
idek.Add("pc upgrade");
idek.Add("laptop");
idek.Add("bedframe");
idek.Add("drawers");

for (int i = 0; i < idek.Count; i++)
{
    Console.WriteLine($"{idek[i]}");
}
idek.Remove("pc upgrade");
idek.RemoveAt(1);

Console.WriteLine("-------------------------------------");

for (int i = 0; i < idek.Count; i++)
{
    Console.WriteLine(idek[i]);
}







string[] idk2 = new string[4];

Console.WriteLine("Type in 4 random things mf.");

for (int greer = 0; greer < idk2.Length; greer++)
{
    idk2[greer] = Console.ReadLine();
}
Console.WriteLine("Here they are alphabetically cuz you didn't ask:");

Array.Sort(idk2); 

for (int ye = 0; ye < idk2.Length; ye++)
{
    int rank2 = ye + 1;
    Console.WriteLine($"{rank2}. {idk2[ye]}");
}







string[] idk = {"Gpu", "Cpu", "Mobo", "Tower"};

for (int i = 0; i < idk.Length; i++)
{
    int rank = i + 1;
    Console.WriteLine($"{rank}. {idk[i]}");
}













Console.WriteLine("How much bro?");

int count = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= count; i++)
{
    double result = Math.Pow(2, i);
    Console.WriteLine(result);
}



/*Console.WriteLine("Welcome Traveler, beers are 5 dollars");
double money = Convert.ToInt64(Console.ReadLine());
if(money == 5){
    Console.WriteLine("Thank you for the coins");
}
else if (money > 5 ){
    double change = money - 5;
}
else {
    Console.WriteLine("That's not enough coins.");
}
double age;
string gender;
Console.WriteLine("Hold on just a minute, you sure you're old enough?");
Console.WriteLine("How old are ya?");
age = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("You a lad or lady? Can't tell with that hood of yours on.");
gender = Console.ReadLine();
if (age >= 16 && gender == "lad"){
    Console.WriteLine("Hmmmm, alright then.");
}
else if (age >= 18 && gender == "lady"){
    Console.WriteLine($"Watchers will be on my ass if I give a {age} year old lady a beer, gimme that beer back. I'll give you your {money} coins.");
}
else if (age >= 18 || money == 10){
    Console.WriteLine("Hmmmm, alright. I'll give you beer for half the price.");
}
else {
    Console.WriteLine("Gimme that beer back kid");
  
}*/

Console.ReadKey();