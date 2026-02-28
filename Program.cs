using System.Security.AccessControl;

namespace G_NET_46_OOPPO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1: a) A University has Departments. If the university is closed, the departments no longer exist.
            // Composition....the departments cannot exist without the university
            //     b) A Driver uses a Car. The driver does not own the car.
            // Association , independent he has it ehile driving but not contain it.
            //     c) A Dog is an Animal. Inheritance dog an animal inherit animal properities.
            //     d) A Team has Players. If the team is deleted, the players still exist.
            // Aggregation , has a but weak.
            //     e) A method receives a Logger as a parameter and calls it inside the method only.
            // Dependency. temporary . method that depend and work only with logging and stop.


            // Q2: a) A parent class has a protected field. Can a child class in a different assembly access it? What about through an object instance from outside?
            // Yes. A protected member is accessible within its class and by derived class instances, even if they are located in a different assembly
            //     b) What is the difference between protected internal and private protected?
            // protected internal	OR Logic: Accessible by any code in the same assembly OR by any derived class (even in a different assembly).
            // private protected AND Logic: Accessible only by derived classes that are located within the same assembly.


    }
    }
}
