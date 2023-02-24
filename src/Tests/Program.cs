using SteganographyCodec.Codec.Codec;
using SteganographyCodec.Domain.Enteties.Files;

string Value = "Hello World!";

var result = IncodeLogic.IncodeAlphabetString(Value);
Console.WriteLine(result);
Console.ReadLine();
