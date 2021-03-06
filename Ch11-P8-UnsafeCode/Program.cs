﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_P8_UnsafeCode
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            int myInt2 = 5;
            //SquareIntPointer(&myInt2);
            //Console.WriteLine("myInt: {0}", myInt2);

            //unsafe
            //{
            //    int myInt = 10;
            //    // OK, because we are in an unsafe context.
            //    SquareIntPointer(&myInt);
            //    Console.WriteLine("myInt: {0}", myInt);
            //}

            //int myInt2 = 5;
            //// Compiler error! Must be in unsafe context!
            //SquareIntPointer(&myInt2);
            //Console.WriteLine("myInt: {0}", myInt2);

            //PrintValueAndAddress();

            #region Calling method with unsafe code 


            //Console.WriteLine("***** Calling method with unsafe code *****");

            //// Values for swap.
            //int i = 10, j = 20;

            //// Swap values "safely."
            //Console.WriteLine("\n***** Safe swap *****");
            //Console.WriteLine("Values before safe swap: i = {0}, j = {1}", i, j);
            //SafeSwap(ref i, ref j);
            //Console.WriteLine("Values after safe swap: i = {0}, j = {1}", i, j);

            //// Swap values "unsafely."
            //Console.WriteLine("\n***** Unsafe swap *****");
            //Console.WriteLine("Values before unsafe swap: i = {0}, j = {1}", i, j);
            //UnsafeSwap(&i, &j);
            //Console.WriteLine("Values after unsafe swap: i = {0}, j = {1}", i, j);
            #endregion

            //UsePointerToPoint();

            #region Fixed keyword in C#

            fixed( char* c = "c based string" )
            {
                //c = "new value for string";
                //char* ptr = c;
                //Console.WriteLine(" *ptr = " + *ptr);
                //Console.WriteLine(" (*c) = " + (c[4]));
                //for (int i = 0; i < 14; i++)
                //{
                //    Console.Write(c[i]);
                //}
                //Console.WriteLine();
                //ptr++;
                //ptr++;
                //Console.WriteLine( " *ptr++ = "+ *ptr);
                //Console.WriteLine( " *c = "+ *c);
            }
            //int number = 3;
            //fixed( int* numberPtr = &number )
            //{

            //}
            #endregion

            UseSizeOfOperator();

            Console.ReadLine();
        }

        static void UseSizeOfOperator()
        {
            Console.WriteLine("The size of short is {0}.", sizeof(short));
            Console.WriteLine("The size of int is {0}.", sizeof(int));
            Console.WriteLine("The size of long is {0}.", sizeof(long));
        }

        private static unsafe void UnsafeStackAlloc()
        {
            //char* p = stackalloc char[256];
            //char* p;
            // p = stackalloc char[256];

            //int* intarray = stackalloc int[100];
            //int* intarray = new int[100];

            char* p = stackalloc char[256];
            for (int k = 0; k < 256; k++)
                p[k] = (char)k;
        }

        private static unsafe void UsePointerToPoint()
        {
            // use of regular Dot Operator
            Point point = new Point { x = 2, y = 4 };
            int x = point.x;
            int y = point.y;

            // field access operator " -> "
            Point* PtrPoint = &point;
            int nox = PtrPoint->x;
            int noy = PtrPoint->y;
            Console.WriteLine(" PtrPoint->x : {0} " , PtrPoint->x);
            Console.WriteLine(" PtrPoint->y : {0} " , PtrPoint->y);


            // Access members via pointer indirection (derefernce).
            Point point2;
            Point* p2 = &point2;
            (*p2).x = 100;
            (*p2).y = 200;
            Console.WriteLine((*p2).ToString());
        }

        private static unsafe void PrintValueAndAddress()
        {
            //    // No! This is incorrect under C#!
            //    int* pi, *pj;
            //    // Yes! This is the way of C#.
            //    int* pi, pj;
            
            int myInt;
            // Define an int pointer, and assign it the address of myInt.
            int* ptrToMyInt = &myInt;
            // Assign value of myInt using pointer indirection.
            *ptrToMyInt = 123;
            // Print some stats.
            Console.WriteLine("Value of myInt {0}", myInt);
            Console.WriteLine("Address of myInt {0:X}", (int)&ptrToMyInt);
        }

        private static unsafe void UnsafeSwap(int* no1 , int* no2)
        {
            Console.WriteLine(" First Number : {0} " , *no1);
            Console.WriteLine(" 2nd Number   : {0} " , *no2);

            int temp = *no1;
            *no1 = *no2;
            *no2 = temp;
        }
        public static void SafeSwap(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }
        static unsafe void SquareIntPointer(int* myIntPointer)
        {
            // Square the value just for a test.
            *myIntPointer *= *myIntPointer;
        }
    }
}
