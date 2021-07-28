using System;
using System.Text;

namespace MaskSenstiveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompts user to enter secret -- any keys
            Console.WriteLine("Enter your secret");
            // creates user secret
            var userSecret = Console.ReadLine();
            // defines the number of keys using all keys but the final four
            var keys = userSecret.Length - 4;
            // defines the final four keys
            var fourKeys = userSecret.Remove(0, keys);
            // defines keys prior to final four
            var remainingKeys = userSecret.Remove(keys);
            var maskedKeys = new StringBuilder();
            // loops over keys prior to the final four and appends with *
            for (var i = 0; i < remainingKeys.Length; i++)
            {
                maskedKeys.Append('*');
            }
            // combines remaining keys, now masked, and final four keys to display for the user
            Console.WriteLine(maskedKeys + fourKeys);
        }
    }
}
