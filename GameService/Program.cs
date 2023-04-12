
using GameService.Models;
using GameService.Services;

UserService userService = new UserService();

try
{
    Player player = userService.AddPlayer(new Player() { Username = "Tural" });

    Console.WriteLine(player.Lig.ToString());
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

