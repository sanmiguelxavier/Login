class Login
{
    static void Main(string[] args)
    {
        string correctUsername = "Admin";
        string correctPassword = "Admin1234!";
        int maxAttempts = 3;
        int attempts = 0;

        System.Console.WriteLine("Login");

        while (attempts < maxAttempts)
        {
            System.Console.Write("Enter your username: ");
            string username = System.Console.ReadLine();

            System.Console.Write("Enter your password: ");
            string password = System.Console.ReadLine();

            if (username == correctUsername && password == correctPassword)
            {
                System.Console.WriteLine("Login successful!");
                break;
            }
            else
            {
                System.Console.WriteLine("Incorrect username or password. Please try again.");
                attempts++;
            }
        }

        if (attempts == maxAttempts)
        {
            System.Console.WriteLine("Maximum login attempts reached. Please try again later.");
        }
    }
}
