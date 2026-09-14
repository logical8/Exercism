using System.Text;

public static class RotationalCipher
{
    private const string alphabet = "abcdefghijklmnopqrstuvwxyz";
    private const int maxLength = 26;
    
    public static string Rotate(string text, int shiftKey)
    {
        if(shiftKey > maxLength || shiftKey < 0) throw new ArgumentException();
        
        var builder = new StringBuilder();
        for(int i = 0; i < text.Length; i++){
            var @char = GetChar(text[i], shiftKey);
            builder.Append(@char);
        }

        return builder.ToString();
    }

    private static char GetChar(char currentChar, int shiftKey){
        var @char = currentChar;
        var lowerChar = char.ToLower(@char);
        if(alphabet.Contains(lowerChar)){
            var index = CalculateIndex(lowerChar, shiftKey);
            @char = char.IsUpper(@char) ? char.ToUpper(alphabet[index]) : alphabet[index];
        }
        return @char;
    }

    private static int CalculateIndex(char @char, int shiftKey){
        var currentIndex = alphabet.IndexOf(@char);
        var shifted = currentIndex + shiftKey;
        if(shifted >= maxLength) return shifted - maxLength;
        return shifted;
    }
}