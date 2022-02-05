using System;

class Car {
    // Attributes
    string[]
        make,
        model;

    int[] speed;

    // Constructor
    public Car() {

        make = new string[3];
        model = new string[3];
        speed = new int[3];

        getInput();
    }

    // Member Functions
    void getInput() {

        Console.WriteLine("Enter three cars and their speeds:");

        for (var i = 0; i < 3; i++) {

            Console.Write("\nCar ");
            Console.WriteLine(i + 1);

            Console.Write("Enter Make: ");
            make[i] = Console.ReadLine();

            Console.Write("Enter Model: ");
            model[i] = Console.ReadLine();

            Console.Write("Enter Speed: ");
            speed[i] = Convert.ToInt16(Console.ReadLine());
        }
    }

    void speedCamera() { 
    
        
    }
    
    static void Main(string[] args) {

        new Car();
    }
}

