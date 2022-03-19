using System.ComponentModel;
using BenchmarkDotNet.Attributes;

namespace ConsoleEnumBenchmark;

[MemoryDiagnoser]
public class EnumBenchmarkFromString
{
    [Benchmark]
    public TesteEnumClass EnumerationFromString()
    {
        return Enumeration.FromDisplayName<TesteEnumClass>("Item1");
    }
    
    [Benchmark]
    public TesteEnum EnumNative()
    {
        return Enum.Parse<TesteEnum>("Item1");
    }
    
    [Benchmark]
    public TesteEnum EnumStaticGetValue()
    {
        return EnumExtensions.GetTesteEnumValue("Item1");
    }
    
}


[MemoryDiagnoser]
public class EnumBenchmarkToString
{
    [Benchmark]
    public string EnumNativeToString()
    {
        return TesteEnum.Item1.ToString();
    }
    
    [Benchmark]
    public string EnumStaticToString()
    {
        return TesteEnum.Item1.GetString();
    }
    
    [Benchmark]
    public string EnumerationToString()
    {
        return TesteEnumClass.Item1.ToString();
    }
}

public enum TesteEnum
{
    Item1 = 1,
    Item2 = 2,
    Item3 = 3
}

public class TesteEnumClass: Enumeration
{
    public static TesteEnumClass Item1 = new(1, nameof(Item1));
    public static TesteEnumClass Item2 = new(2, nameof(Item2));
    public static TesteEnumClass Item3 = new(2, nameof(Item3));
    public TesteEnumClass(int id, string name) : base(id, name)
    { }
}

public static class EnumExtensions {
    public static string GetString(this TesteEnum tipo) => tipo switch
    {
        TesteEnum.Item1 => "Item1",  
        TesteEnum.Item2 => "Item2",  
        TesteEnum.Item3 => "Item3",  
        _ => throw new InvalidEnumArgumentException(nameof(TesteEnum))
    };
    public static TesteEnum GetTesteEnumValue(string enumItem) 
    {
        if (String.IsNullOrWhiteSpace(enumItem)) 
        { 
            throw new ArgumentException(" enumItem não pode ser vazio "); 
        }
        
        if (enumItem == "Item1")
            return TesteEnum.Item1;
        if (enumItem == "Item2")
            return TesteEnum.Item2;
        if (enumItem == "Item3")
            return TesteEnum.Item3;
        throw new InvalidEnumArgumentException(); 
    }
    
}