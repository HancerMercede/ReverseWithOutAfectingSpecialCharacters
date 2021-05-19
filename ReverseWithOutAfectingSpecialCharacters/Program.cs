using System;

namespace ReverseWithOutAfectingSpecialCharacters
{
    class Program
    {
        // This method going to help me to reverse the chararray.
        public static void reverse(char[] strings)
        {
            // Initialize left and right pointers
            int right = strings.Length - 1, left = 0;

            // Traverse string from both ends until
            // 'left' and 'right'
            while (left < right)
            {
                // Here Ignore special characters
                if (!char.IsLetter(strings[left]))
                    left++;

                else if (!char.IsLetter(strings[right]))
                    right--;

                // Both strings[left] and strings[right] are not spacial
                else
                {
                    char tmp = strings[left];
                    strings[left] = strings[right];
                    strings[right] = tmp;
                    left++;
                    right--;
                }
            }
        }
        // Here in main i implement my reverse method
        static void Main(string[] args)
        {
            String str = "n,2,&,a,l,9,$,q,47,i,a,j,b,z,%,8";

            char[] charArray = str.ToCharArray();

            Console.WriteLine("Input the strings: " + str);
            reverse(charArray);

            String revStr = new String(charArray);

            Console.WriteLine("Output the strings: " + revStr);
        }
    }
}
