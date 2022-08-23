class Utils
{
    public static string Input(String msm){
        Console.Write(msm);
        return Console.ReadLine()??"";
    }

    public static int InputInt(String msm){
        Console.Write(msm);
        return Int16.Parse(Console.ReadLine()??"");
    }
    public static float InputFloat(String msm){
        Console.Write(msm);
        return float.Parse(Console.ReadLine()??"");
    }

    public static DateTime InputDate(String msm){
        Console.Write(msm);
        return DateTime.Parse(Console.ReadLine()??"");
    }

}