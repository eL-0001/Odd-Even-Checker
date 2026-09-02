using System;	
					
public class Program	
{
	static void Main()	
	{
		Console.WriteLine("Odd/Even checker");		
	
		while (true)	
		{
			Console.WriteLine();
			Console.Write("Enter number to be checked: ");
			string input = Console.ReadLine();

			if(!int.TryParse(input, out int num))
			{
				Console.WriteLine();
				Console.WriteLine("Invalid input. Please enter a whole number.");
				continue;
			}
			
			long ans = num % 2;
			
			if(ans != 0)
			{
				Console.WriteLine("The number is Odd");
			}
			else 
			{
				Console.WriteLine("The number is Even");
			}
			AskToExit();
		}
		void AskToExit()
		{
			Console.WriteLine();
			
			Console.Write("Exit program? (Y/N): ");
			string exit = Console.ReadLine();
				if(exit == "N")
				{
					return;
				}
				else if (exit == "Y")
				{
					Environment.Exit(0);
				}
				else
				{
					Console.WriteLine("Error, please enter [Y] or [N]");
					AskToExit();
				}
		}
	}
}
