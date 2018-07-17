using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Practice_Form
{
    public class StatFunctions
    {
        private delegate bool WordCondition(string input);

        private void Run()
        {

        }

        private bool WordsLongerThanThreeCharacters(string stringInput)
        {
            return stringInput.Length > 3;
        }

        private bool WordsContainingO(string stringInput)
        {
            return stringInput.IndexOf('o') != -1 || stringInput.IndexOf('O') != -1;
        }

        private bool WordsContainingOddCharacters(string stringInput)
        {
            return stringInput.Length % 2 != 0;
        }

        private int RunChecks(List<string> listInput, WordCondition check)
        {
            int count = 0;

            foreach (string word in listInput)
            {
                if (check(word))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
