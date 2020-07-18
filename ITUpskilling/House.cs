using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUpskilling
{
    //You cannot create an object of an abstract class
    //This is to be tested in 'Test' class within this project
    abstract class House
    {
        //empty methods ('NumberOfFloor', 'NumberOfRooms' and 'NumberOfToilets') and the remaining two methods are fully 
        //implemented and they are called 'MainEntrance' and 'ExitRoute'

        public abstract void NumberOfFloor();
        public abstract void NumberOfRooms();
        public abstract void NumberOfToilets();

        public void MainEntrance()
        {
            Console.WriteLine("This is the main entrance");
        }

        public void ExitRoute()
        {
            Console.WriteLine("This is an exit route");
        }

    }
}
