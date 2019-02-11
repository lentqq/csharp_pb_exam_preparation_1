using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Триъгълник
{
    class Триъгълник
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (4 * n) + 1;
            int heigth = (2 * n) + 1;
            char dots = '.';
            char hashtag = '#';
            char space = ' ';
            Console.WriteLine(new string(hashtag, width));
            int rows = n / 2;
            int countOfDots = 1;
            int countOfHashtags = (width - 3) / 2;
            int countOfSpaces = 1;
            string stringOfDots = string.Empty;
            string stringOfHashtags = string.Empty;
            string stringOfSpaces = string.Empty;

            for (int i = 0; i < rows; i++)
            {
                stringOfDots = new string(dots, countOfDots);
                stringOfHashtags = new string(hashtag, countOfHashtags);
                stringOfSpaces = new string(space, countOfSpaces);

                Console.WriteLine("{0}{1}{2}{1}{0}", stringOfDots, stringOfHashtags, stringOfSpaces);
                countOfDots++;
                countOfHashtags -= 2;
                countOfSpaces += 2;
            }
            string eye = "(@)";
            int countOfSpacesEye = (countOfSpaces - 3) / 2;
            string spacesEye = new string(space, countOfSpacesEye);
            stringOfDots = new string(dots, countOfDots);
            stringOfHashtags = new string(hashtag, countOfHashtags);
            stringOfSpaces = new string(space, countOfSpaces);

            Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}", stringOfDots,
                stringOfHashtags, spacesEye, eye);

            rows = n - (n / 2 + 1);
            for (int i = 0; i < rows; i++)
            {
                countOfDots++;
                countOfHashtags -= 2;
                countOfSpaces += 2;
                stringOfDots = new string(dots, countOfDots);
                stringOfHashtags = new string(hashtag, countOfHashtags);
                stringOfSpaces = new string(space, countOfSpaces);

                Console.WriteLine("{0}{1}{2}{1}{0}", stringOfDots, stringOfHashtags, stringOfSpaces);
            }
            countOfDots++;
            for (int i = 0; i < n; i++)
            {
                stringOfDots = new string(dots, countOfDots);
                stringOfSpaces = new string(hashtag, countOfSpaces);

                Console.WriteLine("{0}{1}{0}", stringOfDots, stringOfSpaces);
                countOfDots++;
                countOfSpaces -= 2;

            }
        }
    }
}
