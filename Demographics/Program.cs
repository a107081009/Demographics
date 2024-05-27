using System.Collections.Concurrent;
using System.Net.WebSockets;

var resultList = new List<string>();

bool shallExit = false;
bool noExit = true;
while (!shallExit)
{
    noExit = true;
    Console.WriteLine("請輸入您的姓名：");
    string name = Console.ReadLine();

    Console.WriteLine($"請輸入{name}的年紀：");
    int age = int.Parse(Console.ReadLine());

    Console.WriteLine($"請輸入{name}的身高： (公尺)");
    var height = float.Parse(Console.ReadLine());
    // 讓輸入的結果轉換成int做運算
    Console.WriteLine($"請輸入{name}的體重：");
    var weight = int.Parse(Console.ReadLine());
    // 輸入結果為string
    Console.WriteLine($"請輸入{name}為男或女：");
    string sex = Console.ReadLine();

    float BMI = weight / (height * height);
    string result = name + "今年" + age + "歲，身高" + height + "公尺，體重" + weight + "公斤，性別為" + sex + "，BMI為" + BMI;
    resultList.Add(result);

    while (noExit)
    {
        Console.WriteLine("請問要結束嗎？");
        Console.WriteLine("輸入Y繼續或輸入N結束");
        string userChoice = Console.ReadLine();

        if (userChoice.ToUpper() == "N")
        {
            shallExit = true;
            noExit = false;
        }
        else if (userChoice.ToUpper() == "Y")
        {
            shallExit = false;
            noExit = false;
        }
        else
        {
            shallExit = false;
            noExit = true;
            Console.WriteLine("無效輸入");
        }
    }
}

Console.WriteLine();
foreach (string singleResult in resultList)
{
    Console.WriteLine(singleResult);
}

Console.WriteLine("結束");
Console.ReadKey();

