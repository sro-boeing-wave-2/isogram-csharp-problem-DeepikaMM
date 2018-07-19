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
                for (int j = 0; j < TestInput.Length; j++)
                {
                    if (!dictionary.ContainsKey(TestInput[j]))
                    {
                        if (char.IsLetter(TestInput[j]))
                        {
                            dictionary.Add(TestInput[j], j);
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
