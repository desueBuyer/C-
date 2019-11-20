using System;

namespace Array1
{
    class Program
    {
        public static void Main()
        {
            var ints = new[] { 1, 2 };
            var strings = new[] { "A", "B" };

            Print(Combine(ints, ints));
            Print(Combine(ints, ints, ints));
            Print(Combine(ints));
            Print(Combine());
            Print(Combine(strings, strings));
            Print(Combine(ints, strings));
        }

        static void Print(Array array)
        {
            if (array == null)
            {
                Console.WriteLine("null");
                return;
            }
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array.GetValue(i));
            Console.WriteLine();
        }
        static Array Combine(params Array[] arrays)
        {
            if (arrays.Length == 0)
                return null;
            var elementType = arrays[0].GetType().GetElementType();
            int length = 0;
            foreach (var array in arrays)
            {
                if (array.GetType().GetElementType() != elementType)
                    return null;
                length += array.Length;
            }
            var result = Array.CreateInstance(elementType, length);
            int counter = 0;
            foreach (var array in arrays)
                foreach (var elem in array)
                {
                    result.SetValue(elem, counter);
                    counter++;
                }
            return result;
        }
    }
}
