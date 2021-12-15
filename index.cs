    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public void Main()
            {
                var firstLock = false;
                var secondLock = false;
     
                if(true | Unlock(ref firstLock, ref secondLock))
                {
                    if (firstLock && secondLock)
                    {
                        Console.WriteLine("Open");
                    } else
                    {
                        Console.WriteLine("Close");
                    }
                    
                }
            }
     
            public bool Unlock(ref bool firstLock, ref bool secondLock)
            {
                firstLock = !firstLock;
                secondLock = !secondLock;
                return secondLock;
            }
        }
    }