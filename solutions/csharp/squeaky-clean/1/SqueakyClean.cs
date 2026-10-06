using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var builder = new StringBuilder();
        bool kebab = false;
        foreach(char i in identifier){
            if(i == ' ')
                builder.Append("_");
            else if(char.IsControl(i))
                builder.Append("CTRL");
            else if(i == '-'){
                kebab = true;
            }
            else if(kebab){
                builder.Append(char.ToUpper(i));
                kebab = false;
            }
            else if(!char.IsLetter(i)){
                
            }
            else if(i >= '\u03B1' && i <= '\u03C9'){
                
            }
            else
                builder.Append(i);
        }
        return builder.ToString();
    }
}
