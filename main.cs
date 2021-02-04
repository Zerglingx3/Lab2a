using System;

class MainClass {
  public static void Main (string[] args) {

// inputs and variable assign
  Console.WriteLine ("Enter item name");
  string itemName = Console.ReadLine(); 

  Console.WriteLine ("Enter the quantity");
  int itemQuantity = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine ("Enter the price (in dollars)");
  double itemPrice = Convert.ToDouble(Console.ReadLine());

// arithmetic

  double totalPrice = itemQuantity * itemPrice;

// output

  Console.WriteLine ("Total price of " + itemName + " is" + " $" + totalPrice);
  }
}