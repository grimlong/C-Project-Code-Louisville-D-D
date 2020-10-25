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
		Str = Helpers.Attrubite();
		Dex = Helpers.Attrubite();
		Con = Helpers.Attrubite();
		Int = Helpers.Attrubite();
		Wis = Helpers.Attrubite();
		Cha = Helpers.Attrubite();
		Hp = 10 + Helpers.Modifier(Con);
		Level = 1;
	}
	

	
  }


 }

