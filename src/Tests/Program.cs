using SteganographyCodec.Codec.Codec;
using SteganographyCodec.Domain.Enteties;
using SteganographyCodec.Domain.Enteties.Files;

string Value = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
char[] result = new char[11];
int[] array1 = new int[] {7, 30, 37, 37, 40, 52, 22, 40, 43, 37, 29};
for (int i = 0; i < array1.Length; i++)
{
    result[i] = Symbols.Alphabet[array1[i]];
}
Console.WriteLine(result);
Console.ReadLine();
