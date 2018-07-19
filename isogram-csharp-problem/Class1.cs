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
                for (int k = 0; k < TestInput.Length; k++)
                {
                    if (!dictionary.ContainsKey(TestInput[k]))
                    {
                        if (char.IsLetter(TestInput[k]))
                        {
                            dictionary.Add(TestInput[k], k);
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
