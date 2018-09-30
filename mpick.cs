// MPick project v1.0
// Developed using Developer Command Prompt for VS2015 and Visual Studio Code.
// Compile using csc mpick.cs and then run with mpick.exe.
// - Martin Sanders.

using System;
using System.IO;
using System.Text;

class bootMPick
{
    static void Main()
    {
        // Startup MPick by calling MPickStartPoint to boot the system and load files into memory.
        MPickMainClass bootMPickMainClass = new MPickMainClass();
        bootMPickMainClass.MPickStartPoint();
    }
}


public class MPickMainClass
{
    public void MPickStartPoint()
    {
        // Login presented upon MPick bootup. 
        string myLogin;
        string myPassword;
        Console.Write("\nStarting MPick...\n");
        Console.Write("login: ");
        myLogin = Console.ReadLine();
        Console.Write("password: ");
        myPassword = Console.ReadLine(); 

        var lines = File.ReadAllLines(@"C:\mycrm\logins.txt");
        foreach (var line in lines)
        {
            if (line.StartsWith(myLogin))
            {
                Console.WriteLine(line);
            }
        }
        Console.Write("\nMPick shutdown. Press enter");
        Console.ReadLine();
    }
}