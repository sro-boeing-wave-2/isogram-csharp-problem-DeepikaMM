using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isogram_csharp_problem
{
    public class isogramClient
    {
        public static bool IsIsogram(string input)
        {
            string TestInput = input.Replace(" ", String.Empty);

            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            if (TestInput == null)
                return true;
            else
            {
                for (int i = 0; i < TestInput.Length; i++)
                {
                    if (!dictionary.ContainsKey(TestInput[i]))
                    {
                        if (char.IsLetter(TestInput[i]))
                        {
                            dictionary.Add(TestInput[i], i);
                        }
                    }

                    else
                        return false;
                }
                return true;

            }

            // throw new NotImplementedException();
        }

    }
}
