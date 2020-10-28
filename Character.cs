using System;
using System.Linq;

namespace C__Project
 {
    class Character {
	  public int Str {get;}
      public int Dex {get;}
      public int Con {get;}
      public int Int {get;}
      public int Wis {get;}
      public int Cha {get;}
      public int Hp {get; set;}
	  public int Level {get; set;}

      public static Character Gernerate()
	{
		return new Character();
	}
	
    
   public Character()
	{
		Str = Helper.Attrubite();
		Dex = Helper.Attrubite();
		Con = Helper.Attrubite();
		Int = Helper.Attrubite();
		Wis = Helper.Attrubite();
		Cha = Helper.Attrubite();
		Hp = 10 + Helper.Modifier(Con);
		Level = 1;
	}
	

	
  }


 }

