using System;

namespace Testing_General {
    class Program {
        static void Main(string[] args) {
            /*foreach (int n in ArraysOfMultiples(7, 3)) {
                Console.WriteLine(n);
            }
        */
            int[] myInt = new int[] { 17, 46, 546, 764, 9, 90 };
            Console.WriteLine(DifferenceMaxMin(myInt));
        }
        
        // takes in a num and length. Returns an array of Count[length]() with each iteration being num + num
        // example output of ArraysOfMultiples(7,3) is {7, 14, 21}
        // solved 4/21/20
        public static int[] ArraysOfMultiples(int num, int length) {
            int[] myArray = new int[length];
            for (int i = 0; i < length; i++) {
                
                myArray[i] = (i + 1) * num;

            }
            return myArray;
        }

        //return smallest number in an array
        //Solved 4/21/20
        public static double FindSmallestNum(double[] arr) {
            double currentSmallest = arr[0];

            foreach(double n in arr) {
                if (n < currentSmallest) {
                    currentSmallest = n;
                }
               
            }
            return currentSmallest;
        }

        // take in an array and give the difference between the min and max
        // Solved 4/21/20
        public static int DifferenceMaxMin(int[] arr) {
            int myMin = arr[0];
            int myMax = arr[0];
            

            foreach (int num in arr) {
                if (num < myMin) {
                    myMin = num;
                }
                if (num > myMax) {
                    myMax = num;
                }
            }
            int result = myMax - myMin;
            return result;
        }


    }
}
