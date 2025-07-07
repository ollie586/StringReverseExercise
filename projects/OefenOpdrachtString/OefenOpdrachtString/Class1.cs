using System.Diagnostics.Metrics;

namespace OefenOpdrachtString;

public class StringReverser
{
    public string Opdracht1(string text)
    {
        // '' = character "" = string in c#
        var arr = text.Split(' ');
        var b = arr.Reverse();
        var result = string.Join(' ', b);
        return result;
    }

    public string Opdracht2(string text)
    {
        var arr = text.Split(' ');
        var words = arr.Count() - 1;
        var result = "";
        foreach (var b in arr)
        {
            var letters = b.ToCharArray().Reverse();
            foreach (var c in letters)
            {
                result += c;
            }

            if (arr[words] != b)
            {
                result += " ";
            }
        }

        return result;

    }
    // Reverse casing:
    public string Opdracht3_1(string text)
    {
        var arr = text.Split(" ");
        var words = arr.Count() - 1;
        var result = "";
        foreach (var b in arr)
        {
            var letters = b.ToCharArray();
            foreach (var c in letters)
            {
                if (char.IsUpper(c))
                {
                    result += char.ToLower(c);
                }
                else if (char.IsLower(c))
                {
                    result += char.ToUpper(c);
                }
                else
                {
                    result += c;
                }

            }

            if (arr[words] != b)
            {
                result += " ";
            }
        }
        return result;
    }

    // Capitalize each word:
    public string Opdracht3_2(string text)
    {
        var arr = text.Split(" ");
        var words = arr.Count() - 1;
        var result = "";
        foreach (var b in arr)
        {
            var letters = b.ToCharArray();
            var count = 1;
            foreach (var c in letters)
            {
                if (count == 1 && char.IsLower(c))
                {
                    result += char.ToUpper(c);
                    count++;
                }
                else if (count != 1)
                {
                    result += char.ToLower(c);
                    count++;
                }
                else
                {
                    result += c;

                }
            }

            if (arr[words] != b)
            {
                result += " ";
            }
        }
        return result;
    }

    //Capitalize first letter of each sentence:
    public string Opdracht3_3(string text)
    {
        var arr = text.Split(" ");
        var result = "";
        var words = arr.Count() - 1;
        var count = 1;
        foreach (var b in arr)
        {
            var letters = b.ToCharArray();

            foreach (var c in letters)
            {
                if (c == '.' || c == '!' || c == '?')
                {
                    count = 1;
                    var characters = result.Count();
                    var remaining = characters - 1;
                    result = result.Remove(remaining, 1);
                    result += c + " ";
                }
                else if (count == 1)
                {
                    result += char.ToUpper(c);
                    count++;
                }
                else if (count != 1)
                {
                    result += char.ToLower(c);

                }
                else
                {
                    result += c;
                }
            }

            if (arr[words] != b)
            {
                result += " ";
            }
        }
        return result;
    }
}
