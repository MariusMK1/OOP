

using ShopApp.Services;

var applicationService = new ApplicationService();

while (true)
{
    Console.WriteLine("Enter your comand");
    string command = Console.ReadLine().ToUpper();
    applicationService.Process(command);
}