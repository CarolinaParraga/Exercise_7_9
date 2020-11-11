using System;

//digit counter of a number entered by the user
using System;

class digits
{
    static void Main()
    {
	
	int number;
		  
	string dato = " ";
	
		
	Console.Write("Insert a number: ");
	dato = Console.ReadLine();
		number = Convert.ToInt32(dato);
        
        //repeat proces until number 0
	while (number != 0)
	{
	    if(number/10 == 0)
	    Console.WriteLine("The number has one digit");
	        else if (number/100 == 0)
		Console.WriteLine("The number has two digit");
		    else if (number/1000 == 0)
		    Console.WriteLine("The number has three digit");
		        else if (number/10000 ==0)
			Console.WriteLine("The number has four digit");
								    
			Console.WriteLine("Introduce un numero:");
			number = Convert.ToInt32(Console.ReadLine());
		}
					    
	}
}
