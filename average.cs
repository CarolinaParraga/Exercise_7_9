// calculates the average of a set of marks, until the user types
“end”
using System;

public class Average
{
    public static void Main()
    {
	double note = 0.0;
	double average = 0.0;
	double sum = 0.0;
	int counter = 1; 
	string mark = " ";
		
	Console.Write("Insert a note: ");
	mark = Console.ReadLine();
	note = Convert.ToDouble(mark);	
			
	//repeat proces until enter "end" or note insn't 0
        while(mark!="end" && note !=0)
        {
	    Console.Write("Insert a note: ");
	    mark = Console.ReadLine();
	    note = Convert.ToDouble(mark);
	    sum = sum+note;  
	    counter++;
	    average=sum/counter;  //calculate the average
	    Console.WriteLine("The average is {0}.",average);
        }
     }
}