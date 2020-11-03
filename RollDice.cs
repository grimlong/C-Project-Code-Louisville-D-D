using System;

namespace C__Project

{
     public class RollDice
     {
        Random rnd = new Random();

	    public int rollD4() 
        {
	        int x = rnd.Next(1, 5);
		    return x;  
		}
		
		public int rollD6() 
        {
	        int x = rnd.Next(1, 7);
		    return x;
		}
		
		public int rollD8() 
        {
    	    int x = rnd.Next(1, 9);
    		return x;
		}
		
		public int rollD10() 
        {
	        int x = rnd.Next(1, 11);
		    return x;
		}
		
		public int rollD20() 
        {
	        int x = rnd.Next(1, 21);
		    return x;
		}
    }
}