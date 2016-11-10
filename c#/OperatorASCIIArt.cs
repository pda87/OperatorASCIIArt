using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.CodeGolf
{
  class OperatorASCIIArt
  {
    public string A(string s, int n)
    {
      string O = "";

      Func<string, int, string> R = (a, b) =>
      {
        return string.Join("", Enumerable.Repeat(a, b)) + "\r\n";
      };

      switch (s)
      {
        case "+":
          for (int i = 0; i < n; i++)
          {
            if (i == n / 2)
            {
              O += R("+", n);
            }
            else
            {
              O += "+".PadLeft(n - n / 2, ' ').PadRight(n - n / 2, ' ') + "\r\n";
            }
          }
          return O;
        case "=":
          return R("=", n) + R("=", n);
        case "-":
          return R("-", n);
        case "/":
          for (int i = n; i > 0; i--)
          {
            O += "/".PadLeft(i) + "\r\n";
          }
          return O;
        case "x":
          int x = 0;
          string[] r = new string[n];
          for (int i = n; i > 0; i--)
          {
            if (n - x - x < 0)
            {
              O += "x".PadLeft(x + 1) + "\r\n";
              break;
            }
            string row = string.Join("", Enumerable.Repeat(" ", x))
              + "x"
              + string.Join("", Enumerable.Repeat(" ", n - x - x)) + "x" + "\r\n";
            O += row;
            x++;
            r[x] = row;
            if (i == n / 2)
            {
              break;
            }
          }
          for (int i = r.Length - 1; i > 0; i--)
          {
            if (string.IsNullOrEmpty(r[i]))
            {
              continue;
            }
            O += r[i];
          }
          return O;
        default:
          return "";
      }
    }
  }
}
