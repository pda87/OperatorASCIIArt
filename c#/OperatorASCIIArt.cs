using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad
{
  class OperatorASCIIArt
  {
    public string A(string symbol, int size)
    {
      switch (symbol)
      {
        case "+":

          string output = "";

          for (int i = 0; i < size; i++)
          {
            if (i == size / 2)
            {
              output += string.Join("", Enumerable.Repeat("+", size)) + "\r\n";
            }
            else
            {
              output += "+".PadLeft(size - size / 2, ' ').PadRight(size - size / 2, ' ') + "\r\n";
            }
          }

          return output;

        case "=":
          return string.Join("\r\n", new string[] { string.Join("", Enumerable.Repeat("=", size)), string.Join("", Enumerable.Repeat("=", size)) });

        case "-":
          return string.Join("", Enumerable.Repeat("-", size));

        case "/":

          string output2 = "";

          for (int i = size; i > 0; i--)
          {
            output2 += "/".PadLeft(i) + "\r\n";
          }

          return output2;

        case "x":

          string output3 = "";
          int x = 0;

          string[] strings = new string[size];

          for (int i = size; i > 0; i--)
          {
            if (size - x - x < 0)
            {
              output3 += "x".PadLeft(x + 1);
              break;
            }

            string row = string.Join("", Enumerable.Repeat(" ", x))
              + "x"
              + string.Join("", Enumerable.Repeat(" ", size - x - x)) + "x" + "\r\n";

            output3 += row;
            x++;

            strings[x] = row;

            if (i == size / 2)
            {
              break;
            }
          }

          output3 += "\r\n";

          for (int i = strings.Length - 1; i > 0; i--)
          {
            if (string.IsNullOrEmpty(strings[i]))
            {
              continue;
            }

            output3 += strings[i];
          }

          return output3;

        default:
          return "";
      }
    }
  }
}