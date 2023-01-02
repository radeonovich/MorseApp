namespace MorseApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //ApplicationConfiguration.Initialize();
            Model model = new Model();
            Form1 view = new Form1(model);
            Application.Run(view);
        }
    }
}