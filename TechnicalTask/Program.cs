
string username = "Maga";
string password = "Nasibov";
int attempts = 0;

while (attempts < 5)
{
    Console.Write("enter username: ");
    string enteredUsername = Console.ReadLine();
    Console.Write("enter password: ");
    string enteredPassword = Console.ReadLine();

    if (enteredUsername == username && enteredPassword == password)
    {
        Console.WriteLine("success! username and password matched:");
        Console.WriteLine("username: {0}", username);
        Console.WriteLine("password: {0}", password);
        return;
    }
    else
    {
        Console.WriteLine("incorrect username or password. Please try again.");
        attempts++;
    }
}