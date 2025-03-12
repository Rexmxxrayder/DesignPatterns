using DesignPatterns.Creationnal.SingletonPattern;

AppSettings.GetInstance().Set("aa", "aa");
AppSettings.GetInstance().Set("bb", "bb");
Console.WriteLine(AppSettings.GetInstance().Get("bb"));

Test.Run();