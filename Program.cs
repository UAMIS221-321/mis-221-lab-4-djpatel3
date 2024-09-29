
// start main

using System.Globalization;

string userInput = "";
while (userInput != "4"){
    DisplayMenu();
    userInput = GetUserInput();
        GoToMenu(userInput);

}
// end main

// Initial Menu
static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("Welcome to Crimson Crust!");
    System.Console.WriteLine("1. See Plain topping-less pizza slice\n2. See Cheese pizza slice\n3. See pepperoni pizza slice\n4. Exit");
}

static string GetUserInput(){
    return Console.ReadLine();
}

static void GoToMenu(string userInput){
    switch (userInput)
    {
        case "1":
            PlainPizza();
            break;
        case "2":
            CheesePizza();
            break;
        case "3":
            PepperoniPizza();
            break;
        case "4":
            Exit();
            break;
        default:
            System.Console.WriteLine("ERROR");
            System.Console.WriteLine("Invalid Input: Press any key to continue...");
            System.Console.ReadKey();
            break;
    }
}

static void PlainPizza(){
    Random randomPlain = new Random(); // generate number
    int randomPlainRows = randomPlain.Next(8, 13);
    
    System.Console.WriteLine(randomPlainRows);

    for (int i = randomPlainRows; i > 0; i--){
        Console.Write("\t");
        for (int j = 0; j < i; j ++){
            Console.Write("\t*");
        }
        System.Console.WriteLine();
        System.Console.WriteLine();
}
System.Console.ReadLine();
}

static void CheesePizza(){
    Random randomCheese = new Random();
    int randomCheeseRows = randomCheese.Next(8, 13);

    System.Console.WriteLine(randomCheeseRows);

    for (int i = randomCheeseRows; i >0; i--){
        System.Console.WriteLine("\t");
        if (i == randomCheeseRows){
            for (int j = 0; j < randomCheeseRows; j ++){
                Console.Write("\t*");
            }
        }
        else{
            Console.Write("\t*");
            if (i>1){
                for (int j = 1; j < i - 1; j++){
                    Console.Write("\t#");
                }
                Console.Write("\t*");
                }
            }
            System.Console.WriteLine();
        }
        System.Console.ReadLine();
    }

    static void PepperoniPizza(){
        Random randomPepperoni = new Random();
        int randomPepperoniRows = randomPepperoni.Next(8,13);

        System.Console.WriteLine(randomPepperoniRows);

for (int i = randomPepperoniRows; i > 0; i--){
            if (i == randomPepperoniRows){
                for (int j = 0; j < randomPepperoniRows; j++){
                    Console.Write("\t*");
                }
            }
            else{
                Console.Write("\t*");

            if (i > 1){
                    for (int j = 1; j < i - 1; j++){
                        if (randomPepperoni.Next(0, 5) == 0){
                            Console.Write("\t[]");
                        }
                        else{
                            Console.Write("\t#");
                        }
                    }
                    Console.Write("\t*");
                }
            }
                System.Console.WriteLine();
            }
    System.Console.ReadLine();
    }

    //Exit

    static void Exit(){
        System.Console.WriteLine("Goodbye!");
        System.Console.WriteLine("Press any key to continue...");
        System.Console.ReadKey();
    }
    
        