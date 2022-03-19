### EnumBenchmarkFromString

|                Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
|---------------------- |-----------:|----------:|----------:|-------:|----------:|
| EnumerationFromString | 185.190 ns | 3.7761 ns | 3.5322 ns | 0.0572 |     240 B |
|            EnumNative |  49.321 ns | 1.0011 ns | 1.2294 ns |      - |         - |
|    EnumStaticGetValue |   3.810 ns | 0.1045 ns | 0.0978 ns |      - |         - |


### EnumBenchmarkToString
|              Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
|-------------------- |-----------:|----------:|----------:|-------:|----------:|
|  EnumNativeToString | 21.0682 ns | 0.3439 ns | 0.3049 ns | 0.0057 |      24 B |
|  EnumStaticToString |  1.5153 ns | 0.0734 ns | 0.0687 ns |      - |         - |
| EnumerationToString |  0.5214 ns | 0.0710 ns | 0.0664 ns |      - |         - |
