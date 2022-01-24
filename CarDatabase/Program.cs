using System;

namespace CarDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            CarDatabase carDatabase = new CarDatabase();

            Car bmwx6 = new Personenautos("bmw", "x6", "2020");
            Car volkswagenup = new Personenautos("volkswagen", "up", "2018");
            Car volkswagenpolo = new Personenautos("volkswagen", "polo", "2008");

            carDatabase.AddCar(bmwx6);
            carDatabase.AddCar(volkswagenup);
            carDatabase.AddCar(volkswagenpolo);

            Program();


            

            void Program()
            {
                while (true)
                {
                    Console.WriteLine("Welcome to the Database of Cars. What would you like to do?");
                    Console.WriteLine("If you want to add a car, enter A. If you want to view all cars, enter B.");

                    string ans = Console.ReadLine();

                    if (ans == "A" || ans == "a")
                    {
                        askInput("You can now add a car. Please enter brand, make and year in the following format:");
                        askInput("<brand> [ENTER]");
                        askInput("<model> [ENTER]");
                        askInput("<year>  [ENTER]");
                        string inputBrand = Console.ReadLine();
                        string inputModel = Console.ReadLine();
                        string inputYear = Console.ReadLine();

                        createCar(inputBrand, inputModel, inputYear);
                    }
                    else if (ans == "B" || ans == "b")
                    {
                        foreach (Car car in carDatabase.GetCars())
                        {
                            string information = car.GetInformation();
                            Console.WriteLine(information);
                        }
                    }
                    else
                    {
                        inputInvalid("If you want to add a car, press A. If you want to view all cars, press B.");
                        Program();
                    }

                }
            }
            void askInput(string input)
            {
                Console.WriteLine(input);
            }

            void inputInvalid(string message)
            {
                Console.WriteLine("Input invalid." + message);
            }

            void createCar(string model, string brand, string year)
            {
                Car newCar = new Personenautos(model, brand, year);
            }


        }
    }
}
