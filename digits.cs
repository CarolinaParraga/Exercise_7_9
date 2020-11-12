//digit counter of a number entered by the user
using System;

class digits
{
    static void Main()
    {
	
	int number;
		  
	string dato = " ";
	
		
	Console.WriteLine("Insert a number: (to finish type end)");
	dato = Console.ReadLine();
	number = Convert.ToInt32(dato);
		
	//repeat proces until enter "end" or note insn't 0
	while (dato != "end" && number != 0)
	{
	    //conditions according to the number of digits
	    if((number != 0) && (number/10 == 0))
	        Console.WriteLine("The number has one digit");
	            else if (number/100 == 0)
		        Console.WriteLine("The number has two digit");
			    else if (number/1000 == 0)
			        Console.WriteLine("The number has three digit");
				    else if (number/10000 ==0)
				        Console.WriteLine("The number has four digit");
								    
								    
				        Console.WriteLine("Insert a number: (to finish type end)");
			                dato = Console.ReadLine();
									number = Convert.ToInt32(dato);
		}
					    
	}
}