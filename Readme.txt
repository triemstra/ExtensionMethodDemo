Readme
======

Create a generic extension method for strings that allows a user to pass in an enum type and it returns the matching enum or null if it doesnt match
====================================================================================================================================================

e.g. 

  string someString = "Orange";
  
  public enum Fruit
  {
	Apple,
	Pear,
	Orange
  }
  
  Fruit? someFruit = someString.ConvertToEnum<Fruit>();
