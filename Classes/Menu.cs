public class Menu
{
    private View _view;

    public Menu()
    {
        _view = new View();
    }

    public void MainMenu()
    {
        _view.ViewMainMenu();
        var key = Console.ReadKey(true).KeyChar;
        switch (key)
        {
            case '1':
                Test();
                break;
            case '2':
                Test();
                break;
            case '3':
                Test();
                break;
            case '4':
                Test();
                break;
            case '5':
                Environment.Exit(5);
                break;
        }
        MainMenu();
    }

    public void Test()
    {
        Console.Clear();
        Console.WriteLine("Test");
        Console.WriteLine();
        Console.WriteLine("Press any key to return to the main menu");
        Console.ReadKey();
    }
}
