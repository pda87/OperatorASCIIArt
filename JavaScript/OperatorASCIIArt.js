    function GetASCIIArt(character, size) {
      switch (character)
      {
        case "+":
          return "\r\n" + Plus(size);
        case "=":
            return "\r\n" + Equals(size);
        case "-":
          return "\r\n" + Minus(size);
        case "/":
          return "\r\n" + Divide(size);
        case "x":
          return "\r\n" + Multiply(size);
        default:
          return "";
      }
    }

    function Divide(size) {
      var output = "";

      for (d = size; d > 0; d--)
      {
        output += this.PadLeft("/", d) + "\r\n";
      }

      return output;
    }

    function Equals(size) {
      return Repeat("=", size) + "\r\n" + Repeat("=", size);
    }

    function Minus(size) {
      return Repeat("-", size);
    }

    function Multiply(size) {
      if (size == 1 || size == 2 || size == 3)
      {
        return "x";
      }

      var output = "";

      var correction = 0;

      var rows = new Array(Math.round(size));

      for (m = size; m > 0; m--)
      {
        if (size - correction - correction < 0)
        {
          output += this.PadLeft("x", correction +1) + "\r\n";
          break;
        }
        
        var row = this.Repeat(" ", correction)
          + "x"
          + this.Repeat(" ", size - correction - correction) + "x" + "\r\n";

        output += row;
        correction++;
        rows[correction] = row;

        if (m == size / 2)
        {
          break;
        }
      }

      for (m = rows.length - 1; m > 0; m--)
      {
        if (rows[m] == null || rows[m] == "")
        {
          continue;
        }
        output += rows[m];
      }

      return size % 2 == 0 ? "Multiply requires an odd number" : output;
    }

    function Plus( size) {
      var output = "";
	  
      for (p = 0; p < size; p++)
      {
        if (p == Math.round(size / 2) - 1)
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

    function Repeat(repeatedCharacter, numberOfCharacters) {
        
        var output = "";
        
        for (r = 0; r < numberOfCharacters; r++) {
            output += repeatedCharacter;
        }
        
        return output;
    }
 
    function PadLeft(string, size){
        
		var chars = new Array(Math.round(size));
        
        for (i = 0; i < chars.length; i++) {
            chars[i] = " ";
        }
        
        chars[chars.length - 1] = string;
        
		var padLeftOutput = "";
		
		for (i = 0; i < chars.length - 1; i++) {
			padLeftOutput += chars[i];
		}
		
		return padLeftOutput + string;
    }
    
    function PadRight(string, size){
        
        var chars = new Array(Math.round(size));
        
        chars[0] = string;
        
        for (i = 1; i < chars.length; i++) {
            chars[i] = " ";
        }
        
		var padRightOutput = string;
		
		for (i = 0; i < chars.length - 1; i++) {
			padRightOutput += chars[i];
		}
		
        return padRightOutput;
    } 