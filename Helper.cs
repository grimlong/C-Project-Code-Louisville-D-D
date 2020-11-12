using System;
using System.Linq;

namespace C__Project
{
	class Helper{
// Hit points is equal to 10 plus a modifier that is the value of CON minus ten, divided by two.
	public static int Modifier(int score)
	  {
		  return (int)Math.Floor((score - 10f) /2f);
	  }

// Creates an array of 4 values between 1 and 6 puts them in order smallest to largest and skips 
// the first value in the array then adds the ones that are left.
// This is to simulate rolling 4 six sided dice and removing the lowest to make a character stat.
    static readonly Random s_rnd = new Random();
	public static int Attrubite()
	  {
	    return new[] { s_rnd.Next(1, 7), s_rnd.Next(1, 7), s_rnd.Next(1, 7), s_rnd.Next(1, 7) }.OrderBy(v => v).Skip(1).Sum();	
	  }
 }
}




