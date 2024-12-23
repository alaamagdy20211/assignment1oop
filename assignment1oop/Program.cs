namespace assignment1oop
{
    internal class Program
    {
        public struct person1
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public person1(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public static person1 GetPersonDetails(int personNumber)
            {
                Console.WriteLine($"Enter details for Person {personNumber}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                return new person1(name, age);
            }

            public static person1 GetOldestPerson(person1 p1, person1 p2, person1 p3)
            {
                if (p1.Age >= p2.Age && p1.Age >= p3.Age)
                    return p1;
                else if (p2.Age >= p1.Age && p2.Age >= p3.Age)
                    return p2;
                else
                    return p3;
            }
        }


        public struct point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double DistanceTo(point other)
            {
                return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
            }
        }

        public struct person
        {

            public string Name { get; set; }
            public int Age { get; set; }


            public person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        enum Colors
        {
            Red,
            Green,
            Blue
        }
        [Flags]
        enum Permissions
        {
            None = 0,
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            #region q1
            //Console.WriteLine("Days of the Week:");

            //// Iterate through all values of the WeekDays enum
            //foreach (var day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion
            #region q2
            //person[] people = new person[3];


            //people[0] = new person("Alice", 25);
            //people[1] = new person("Bob", 30);
            //people[2] = new person("Charlie", 35);
            //Console.WriteLine("Person Details:");
            //foreach (var person in people)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}
            #endregion
            #region q3
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //string input = Console.ReadLine();

            //// Try to parse the user input to a Season enum
            //if (Enum.TryParse(input, true, out Season season))
            //{
            //    // Display the corresponding month range
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered. Please enter Spring, Summer, Autumn, or Winter.");
            //}
            //#endregion
            //#region q4
            //Permissions userPermissions = Permissions.None;

            //userPermissions |= Permissions.Read;
            //userPermissions |= Permissions.Write;

            //Console.WriteLine($"Current Permissions: {userPermissions}");

            //if ((userPermissions & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("Read permission is granted.");
            //}

            //if ((userPermissions & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("Delete permission is granted.");
            //}
            //else
            //{
            //    Console.WriteLine("Delete permission is not granted.");
            //}

            //userPermissions &= ~Permissions.Write;
            //Console.WriteLine($"Permissions after removing Write: {userPermissions}");

            //if ((userPermissions & Permissions.Write) == Permissions.Write)
            //{
            //    Console.WriteLine("Write permission is still granted.");
            //}
            //else
            //{
            //    Console.WriteLine("Write permission is not granted.");
            //}
            #endregion
            #region q5
            //Console.WriteLine("Enter a color name:");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Colors color))
            //{
            //    Console.WriteLine($"{color} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{input} is not a primary color.");
            //}
            #endregion
            #region q6
            //Console.WriteLine("Enter a color name:");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Colors color))
            //{
            //    Console.WriteLine($"{color} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{input} is not a primary color.");
            //}
            #endregion
            #region q7
            //Console.WriteLine("Enter the coordinates for the first point (X1, Y1):");
            //Console.Write("X1: ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("Y1: ");
            //double y1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the coordinates for the second point (X2, Y2):");
            //Console.Write("X2: ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("Y2: ");
            //double y2 = double.Parse(Console.ReadLine());

            //point point1 = new point(x1, y1);
            //point point2 = new point(x2, y2);

            //double distance = point1.DistanceTo(point2);

            //Console.WriteLine($"The distance between the two points is: {distance:F2}");
            #endregion
            #region q8
            person1 person1 = person1.GetPersonDetails(1);
            person1 person2 = person1.GetPersonDetails(2);
            person1 person3 = person1.GetPersonDetails(3);

            person1 oldestPerson = person1.GetOldestPerson(person1, person2, person3);

            Console.WriteLine($"The oldest person is {oldestPerson.Name} with {oldestPerson.Age} years.");
            #endregion
        }
    }
}
