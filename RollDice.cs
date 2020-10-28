using System;


namespace C__Project

{

    public class RollDice
    {
        Random rnd = new Random();

	    public int rollD4() 
        {
	        int x = rnd.Next(1, 4);
		    return x;  
		}
		
		public int rollD6() 
        {
	        int x = rnd.Next(1, 6);
		    return x;
		}
		
		public int rollD8() 
        {
    	    int x = rnd.Next(1, 8);
    		return x;
		}
		
		public int rollD10() 
        {
	        int x = rnd.Next(1, 10);
		    return x;
		}
		
		public int rollD20() 
        {
	        int x = rnd.Next(1, 20);
		    return x;
		}

    }
}