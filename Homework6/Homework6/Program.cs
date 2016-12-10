//Assignment #6

//Copy this block into your Visual Studio.

// Review and Redo this code line by line at home.  

// Place comments on each line and describe what the code is doing

using System;

namespace ConsoleApplication1
{
    public struct Pet //Define variables of the structure : name and type of pet
    {
        public string Name;
        public string TypeOfPet;
    }

    class Program
    {
        static void Main()
        {
            var numberOfPets = 0; // Inizialization of number of pets
            var pets = new Pet[10]; // creates an array of structure pet (called pets) that have 10 elements

            while (true) //Never ending loop
            {
                Console.Write("A)dd D)elete L)ist pets:"); //Give the user options to be done
                var choice = Console.ReadLine(); //Read the input

                switch (choice) //Switch loop that executes different code depending on the users input
                {
                    case "A": //Add pet
                    case "a":
                        {
                            //Gives values to the two variables of the structure: name and type of pet
                            Console.Write("Name :");
                            var name = Console.ReadLine();

                            Console.Write("Type of pet :");
                            var typeOfPet = Console.ReadLine();

                            // Always add the pet at the end of the array
                            pets[numberOfPets].Name = name;
                            pets[numberOfPets].TypeOfPet = typeOfPet;

                            //Now we have one more pet so the last element is one position further in the array
                            numberOfPets++;
                            break;
                        }

                    case "D"://Delete pet
                    case "d":
                        {
                            if (numberOfPets == 0) //Check if the array is empty
                            {
                                Console.WriteLine("No pets");//Notify the user that there are no pets in the array
                                break;
                            }

                            for (var index = 0; index < numberOfPets; index++)//Read the array, asign one number for each pet and shows the list to the user
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                            }

                            Console.Write("Which pet to remove (1-{0})", numberOfPets); //Ask for input

                            var petNumberToDelete = Console.ReadLine();//Read the input
                            var indexToDelete = int.Parse(petNumberToDelete); //Convert the input to integer

                            // Squish the array from index to the end

                            for (var index = indexToDelete - 1; index < numberOfPets; index++)
                            {
                                // Just copy the pet from the next index into the current index
                                pets[index] = pets[index + 1];
                            }

                            // We have one less pet
                            numberOfPets--;

                            break;
                        }

                    case "L": //Option list the pets
                    case "l":
                        {
                            if (numberOfPets == 0) //Check if the array is empty
                            {
                                Console.WriteLine("No pets");
                            }

                            for (int index = 0; index < numberOfPets; index++) //Read the array and shows it to the user
                            {
                                Console.WriteLine("{0}. {1,-10} {2}", index + 1, pets[index].Name, pets[index].TypeOfPet);
                            }

                            break;
                        }
                    default: //Emergengy exit for the loop in case previous "cases" did not occur.
                        {
                            Console.WriteLine("Invalid option [{0}]", choice);
                            break;
                        }
                }
            }
        }
    }
}



