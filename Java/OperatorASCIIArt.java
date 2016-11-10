/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package scratchpad.CodeGolf;

/**
 *
 * @author Peter arden
 */
public class OperatorASCIIArt {
    
    public String GetASCIIArt(String character, int size) {
      switch (character)
      {
        case "+":
          return Plus(size);
        case "=":
            return Equals(size);
        case "-":
          return Minus(size);
        case "/":
          return Divide(size);
        case "x":
          return Multiply(size);
        default:
          return "";
      }
    }

    private String Divide(int size) {
      String output = "";

      for (int i = size; i > 0; i--)
      {
        output += this.PadLeft("/", i) + "\r\n";
      }

      return output;
    }

    private String Equals(int size) {
      return Repeat("=", size) + "\r\n" + Repeat("=", size);
    }

    private String Minus(int size) {
      return Repeat("-", size);
    }

    private String Multiply(int size) {
      if (size == 1 || size == 2 || size == 3)
      {
        return "x";
      }

      String output = "";

      int correction = 0;

      String[] rows = new String[size];

      for (int i = size; i > 0; i--)
      {
        if (size - correction - correction < 0)
        {
          //output += "x".PadLeft(correction + 1) + "\r\n";
          output += this.PadLeft("x", correction +1) + "\r\n";
          break;
        }
        
        String row = this.Repeat(" ", correction)
          + "x"
          + this.Repeat(" ", size - correction - correction) + "x" + "\r\n";

        output += row;
        correction++;
        rows[correction] = row;

        if (i == size / 2)
        {
          break;
        }
      }

      for (int i = rows.length - 1; i > 0; i--)
      {
        if (rows[i] == null || rows[i] == "")
        {
          continue;
        }
        output += rows[i];
      }

      return size % 2 == 0 ? "Multiply requires an odd number" : output;
    }

    private String Plus(int size) {
      String output = "";

      for (int i = 0; i < size; i++)
      {
        if (i == size / 2)
        {
          output += Repeat("+", size) + "\r\n";
        }
        else
        {
          output += this.PadLeft("+", size - size / 2) + this.PadRight(" ", size - size / 2) + "\r\n";
        }
      }

      return size % 2 == 0 ? "Plus requires an odd number" : output;
    }

    private String Repeat(String repeatedCharacter, int numberOfCharacters) {
        
        String output = "";
        
        for (int i = 0; i < numberOfCharacters; i++) {
            output += repeatedCharacter;
        }
        
        return output;
    }
 
    private String PadLeft(String string, int size){
        
        String[] chars = new String[size];
        
        for (int i = 0; i < chars.length - 1; i++) {
            chars[i] = " ";
        }
        
        chars[chars.length - 1] = string;
        
        return String.join("", chars);
    }
    
    private String PadRight(String string, int size){
        
        String[] chars = new String[size];
        
        chars[0] = string;
        
        for (int i = 1; i < chars.length; i++) {
            chars[i] = " ";
        }
        
        return String.join("", chars);
    }
}