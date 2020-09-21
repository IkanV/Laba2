using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab222222222
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Boolean value -> ");
            bool boolValue = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Byte value -> ");
            byte byteValue = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Sbyte value -> ");
            sbyte sbyteValue = Convert.ToSByte(Console.ReadLine());

            Console.WriteLine("Char value -> ");
            char charValue = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Decimal value -> ");
            decimal decimalValue = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Double value -> ");
            double doubleValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Float value -> ");
            float floatValue = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Int value -> ");
            int intValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Uint value -> ");
            uint uintValue = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Long value -> ");
            long longValue = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("ULong value -> ");
            ulong ulongValue = Convert.ToUInt64(Console.ReadLine());

            Console.WriteLine("Short value -> ");
            short shortValue = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("UShort value -> ");
            ushort ushortValue = Convert.ToUInt16(Console.ReadLine());

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tThe table \"Types and Values\"");
            Console.ResetColor();

            Console.WriteLine(" -----------------------------------------------");
            Console.WriteLine("|\tTypes\t\t|     Values\t\t|");
            Console.WriteLine(" -----------------------------------------------");
            Console.WriteLine($"|\tBoolean\t\t|     {boolValue}\t\t|");
            Console.WriteLine(" -----------------------------------------------");
            Console.WriteLine($"|\tByte\t\t|\t{byteValue}\t\t|");
            Console.WriteLine(" -----------------------------------------------");
            Console.WriteLine($"|\tSByte\t\t|\t{sbyteValue}\t\t|");
            Console.WriteLine(" -----------------------------------------------");
            Console.WriteLine($"|\tChar\t\t|\t{charValue}\t\t|");
            Console.WriteLine(" -----------------------------------------------");
            Console.WriteLine($"|\tDecimal\t\t|\t{decimalValue}\t\t|");
            Console.WriteLine(" -----------------------------------------------");
            Console.WriteLine($"|\tDouble\t\t|\t{doubleValue}\t\t|");
            Console.WriteLine(" -----------------------------------------------");
            Console.WriteLine($"|\tFloat\t\t|\t{floatValue}\t\t|");
            Console.WriteLine(" -----------------------------------------------");
            Console.WriteLine($"|\tInt\t\t|\t{intValue}\t\t|");
            Console.WriteLine(" -----------------------------------------------");
            Console.WriteLine($"|\tUInt\t\t|\t{uintValue}\t\t|");
            Console.WriteLine(" -----------------------------------------------");
            Console.WriteLine($"|\tLong\t\t|\t{longValue}\t\t|");
            Console.WriteLine(" -----------------------------------------------");
            Console.WriteLine($"|\tULong\t\t|\t{ulongValue}\t\t|");
            Console.WriteLine(" -----------------------------------------------");
            Console.WriteLine($"|\tShort\t\t|\t{shortValue}\t\t|");
            Console.WriteLine(" -----------------------------------------------");
            Console.WriteLine($"|\tUShort\t\t|\t{ushortValue}\t\t|");
            Console.WriteLine(" -----------------------------------------------");

            int anotherIntValue = 12;
            long anotherLongValue = anotherIntValue;            //implicit conversion

            byte anotherByteValue = 255;
            short anotherShortValue = (short)anotherByteValue; //explicit conversion

            uint anotherUIntValue = 574;
            object uintBox = anotherUIntValue;                  //boxing
            uint unboxUIntValue = (uint)uintBox;               //unboxing

            var implicitInt = 12;                           // var неявно типизированная переменная
            var implicitChar = 'a';
            //implicitChar = 12;                                //строка выдает ошибку, потому что первоначальное значение переменной типа System.Char,
            //а мы пытаемся присвоить ей значение целочисленного типа
            int? nullableInt = null;
            char? nullableChar = null;


            Console.WriteLine("\n-------------------------------------------------------");
            string myName = "Slava";
            string mySurname = "Ikan";
            string lowerCaseString = "abcdiloveyou";
            string rabota = String.Copy(myName);

            Console.WriteLine("Value of myName => " + myName);
            Console.WriteLine("Length of myName => " + myName.Length);
            Console.WriteLine("myName in uppercase => " + myName.ToUpper());
            Console.WriteLine("myName contains the letter a? - " + myName.Contains("a"));
            Console.WriteLine("myName after replace => " + myName.Replace("S", "sha"));
            Console.WriteLine("is equal? -> " + myName.Equals(mySurname));
            Console.WriteLine("Exit concat stirng => " + String.Concat(myName, " ", mySurname));
            Console.WriteLine("Substring -> " + lowerCaseString.Substring(4, 8));
            Console.WriteLine("Insert substirng -> " + myName.Insert(myName.Length, " <- insetrt_stirng"));
            Console.WriteLine("Remove substring -> " + mySurname.Remove(1, 2));

            Console.WriteLine("\nLet's go\n");

            string initString = "abcdef";
            string emptyString = "";
            string nullString = null;

            if (String.IsNullOrEmpty(initString))
            {
                Console.WriteLine("string is null or empty");
            }
            else
            {
                Console.WriteLine($"\"{initString}\"is neither null nor empty");
            }

            if (String.IsNullOrEmpty(emptyString))
            {
                Console.WriteLine("string is null or empty");
            }
            else
            {
                Console.WriteLine($"\"{emptyString}\"is neither null nor empty");
            }

            if (String.IsNullOrEmpty(nullString))
            {
                Console.WriteLine("string is null or empty");
            }
            else
            {
                Console.WriteLine($"\"{nullString}\"is neither null nor empty");
            }

            StringBuilder stringMadeByStringBuilder = new StringBuilder("AbCdEfGhIjKlM");

            Console.WriteLine("Original string => " + stringMadeByStringBuilder);

            Console.WriteLine($"Length stringMadeByStringBuilder => " + stringMadeByStringBuilder.Length);
            Console.WriteLine($"Capacity stringMadeByStringBuilder => " + stringMadeByStringBuilder.Capacity); // size of memory

            stringMadeByStringBuilder.Replace("EfG", "XXX");
            Console.WriteLine(stringMadeByStringBuilder);

            stringMadeByStringBuilder.Remove(2, 3);
            Console.WriteLine(stringMadeByStringBuilder);

            stringMadeByStringBuilder.Append(" string added by method Append()");
            Console.WriteLine(stringMadeByStringBuilder);
            Console.WriteLine("-------------------------------------------------------\n");

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            Console.WriteLine("\n-------------------------------------------------------");
            int row = 5, col = 5;
            int[,] matrix = new int[row, col];

            for (int i = 0; i < row; i++)    //fill
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = (i + 1) * (j + 1);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine();

            string[] animals = new[] { "kotik", "sobaka", "rat", "pig", "cow" };
            Console.Write("Original array => ");
            foreach (var i in animals)          // every element in array - foreach
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Enter index for change => ");
            int intValueForChange = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a value for changed element => ");
            string stringValueForChange = Console.ReadLine();

            animals[intValueForChange] = stringValueForChange;

            Console.Write("Changed array => ");
            foreach (var i in animals)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nThe length of array \"animals\" is -> " + animals.Length);

            Console.WriteLine();



            int rowSteppedArray = 3;
            float[][] steppedArray = new float[3][];

            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                steppedArray[i] = new float[random.Next(2, 4)];
                for (int j = 0; j < steppedArray[i].Length; j++)
                {
                    Console.WriteLine($"Enter [{i}][{j}] element => ");
                    float a = Convert.ToSingle(Console.ReadLine());
                    steppedArray[i][j] = a;
                }
            }
            Console.WriteLine("\nReceived array");
            for (int i = 0; i < rowSteppedArray; i++)
            {
                for (int j = 0; j < steppedArray[i].Length; j++)
                {
                    Console.Write(steppedArray[i][j] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("\n-------------------------------------------------------");
            (int, string, char, string, ulong) touple = (3, "Sad", 'q', "kotik", 12345678);
            Console.WriteLine(touple);

            Console.WriteLine($"First element => {touple.Item1}\nSecond element => {touple.Item2}");
            int valueFromTouple = touple.Item1;


            (int, int) intTouple1 = (2, 2);
            (int, int) intTouple2 = (2, 2);


            Console.WriteLine("Touple 1 -> " + intTouple1);
            Console.WriteLine("Touple 2 -> " + intTouple2);

            if ((intTouple1.Item1 == intTouple2.Item1 ? intTouple1.Item2 - intTouple2.Item2 : -1) == 0)
            {
                Console.WriteLine("Touple intTouple1 == intTouple2");
            }
            else
            {
                Console.WriteLine("Touple intTouple1 != intTouple2");
            }

            /////////////////////////5 kvest

            (int, int, int, char) toupleComparsion(int[] intArray, string maBoy)
            {
                Array.Sort(intArray);
                (int, int, int, char) returnTouple;    //for  time touple
                returnTouple.Item1 = intArray[0];
                returnTouple.Item2 = intArray[intArray.Length - 1];
                int sum = 0;

                foreach (var elem in intArray)
                {
                    sum += elem;
                }

                returnTouple.Item3 = sum;
                returnTouple.Item4 = maBoy[0];

                return returnTouple;
            }

            (int, int, int, char) toupleForFunction = toupleComparsion(new int[] { 5, 4, 8, 9, 11, 3, 6, 12, 9 }, "Kityaka");

            Console.WriteLine("After a calling touple function => ");

            Console.WriteLine($"Min: {toupleForFunction.Item1}");
            Console.WriteLine($"Max: {toupleForFunction.Item2}");
            Console.WriteLine($"Sum: {toupleForFunction.Item3}");
            Console.WriteLine($"First Letter: {toupleForFunction.Item4}");
            Console.WriteLine("-------------------------------------------------------\n");


            Console.WriteLine("\n-------------------------------------------------------");
            void checkedFunction()
            {
                checked
                {
                    byte sum = (byte)Add(Byte.MaxValue, 1); // overflow exception
                    Console.WriteLine("sum is -> " + sum);
                }
            }

            void uncheckedFunnction()
            {
                unchecked
                {
                    byte sum = (byte)Add(Byte.MaxValue, 10);
                    Console.WriteLine("sum is -> " + sum);
                }
            }

            int Add(int x, int y) { return x + y; }

            //checkedFunction();
            uncheckedFunnction();
            Console.WriteLine("-------------------------------------------------------\n");

            Console.ReadLine();

        }
    }
}
