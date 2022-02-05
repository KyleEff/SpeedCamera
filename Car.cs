/**
 * Kyle Free
 * GAME 1343
 * Programming and Simulation I
 * 2/5/21
 * Speed Camera Program
 * **/

using System;

class Car {
    // Attributes
    string[]
        make,
        model;

    int[]
        speed,
        demerits;

    bool[] suspended;
    int speedLimit;

    // Constructor
    public Car() {

        make = new string[3];
        model = new string[3];
        speed = new int[3];
        demerits = new int[3];
        suspended = new bool[3];

        speedLimit = 40; // 40 MPH speed limit
        
        getInput();
        speedCamera();
    }

    // Member Functions
    void getInput() {

        /* // Allows the user to enter a speed limit
        Console.Write("Enter the speed limit (MPH): ");
        speedLimit = Convert.ToInt16(Console.ReadLine());
        */

        Console.WriteLine("Enter three cars and their speeds:");
        // This loop runs through the arrays and enters the corresponding data
        for (var i = 0; i < 3; i++) {

            Console.Write("\nCar ");
            Console.WriteLine(i + 1);

            Console.Write("Enter Make: ");
            make[i] = Console.ReadLine();

            Console.Write("Enter Model: ");
            model[i] = Console.ReadLine();

            Console.Write("Enter Speed: ");
            speed[i] = Convert.ToInt16(Console.ReadLine());

            demerits[i] = 0;
            suspended[i] = false;
        }
    }

    void speedCamera() {

        Console.WriteLine("\nSpeed Limit: " + Convert.ToString(speedLimit) + " MPH");

        /* This loop runs through all the arrays and decides whether the car is over 
         * the speed limit, and if it is then it counts how many MPH over and then
         * assigns demerits or suspends the license
         */
        for (var i = 0; i < 3; i++) {

            Console.Write('\n' +
                // Print make, model, and speed
                make[i] + ' ' + model[i] + ' ' +
                Convert.ToString(speed[i]) + "MPH: "
            ) ;

            if (speed[i] < speedLimit) // Under speed limit
                Console.WriteLine("OK");

            else if (speed[i] > speedLimit) {

                for (var j = speed[i]; j > speedLimit; j -= 5)
                    demerits[i]++;

                Console.WriteLine(demerits[i] + " demerits");

                if (demerits[i] > 10) { // If over 10 demerits
                    // Suspend license
                    suspended[i] = true;
                    Console.WriteLine("<LICENSE SUSPENDED>");
                }
            }
        }
    }
    
    static void Main(string[] args) {

        new Car();
    }
}

