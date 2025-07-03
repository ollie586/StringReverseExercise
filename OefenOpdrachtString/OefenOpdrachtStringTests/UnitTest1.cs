using Microsoft.VisualStudio.TestPlatform.Utilities;
using OefenOpdrachtString;

namespace OefenOpdrachtStringTests;

public class UnitTest1
{
//    Input A:  ""
//Output B: 
    [Fact]
    public void Opdracht1_WithText_ReturnsReversedText()
    {
        //arrange
        string s = "Hello developer. Do you like any of these fruits: apple, pear, banana? I do!";
        string result = "do! I banana? pear, apple, fruits: these of any like you Do developer. Hello";

        //act
        var c = new StringReverser();
        string r = c.Opdracht1(s);

        //assert
        Assert.Equal(result, r);
    }

    [Fact]
    public void Opdracht2_WithText_ReturnsReversedWords()
    {
        //arrange
        string s = "Hello developer. Do you like any of these fruits: apple, pear, banana? I do!";
        string result = "olleH .repoleved oD uoy ekil yna fo eseht :stiurf ,elppa ,raep ?ananab I !od";

        //act
        var c = new StringReverser();
        string r = c.Opdracht2(s);

        //assert
        Assert.Equal(result, r);
    }

    // Reverse casing:

    // Capitalize each word:

    // Capitalize first letter of each sentence:

    [Fact]
    public void Opdracht3_1_WithText_ReturnsReversedCasing()
    {
        //arrange
        string s = "olleH .repoleved oD uoy ekil yna fo eseht :stiurf ,elppa ,raep ?ananab I !od";
        string result = "OLLEh .REPOLEVED Od UOY EKIL YNA FO ESEHT :STIURF ,ELPPA ,RAEP ?ANANAB i !OD";

        //act
        var c = new StringReverser();
        string r = c.Opdracht3_1(s);

        //assert
        Assert.Equal(result, r);
    }

    [Fact]
    public void Opdracht3_2_WithText_ReturnsReversedEachWordCapitalized()
    {
        //arrange
        string s = "olleH .repoleved oD uoy ekil yna fo eseht :stiurf ,elppa ,raep ?ananab I !od";
        string result = "Olleh .Repoleved Od Uoy Ekil Yna Fo Eseht :Stiurf ,Elppa ,Raep ?Ananab I !Od";

        //act
        var c = new StringReverser();
        string r = c.Opdracht3_2(s);

        //assert
        Assert.Equal(result, r);
    }

    [Fact]
    public void Opdracht3_3_WithText_ReturnsReversedEachFirstWordCapitalized()
    {
        //arrange
        string s = "olleH .repoleved oD uoy ekil yna fo eseht :stiurf ,elppa ,raep ?ananab I !od";
        string result = "Olleh. Repoleved od uoy ekil yna fo eseht :stiurf ,elppa ,raep? Ananab i! Od";

        //act
        var c = new StringReverser();
        string r = c.Opdracht3_3(s);

        //assert
        Assert.Equal(result, r);
    }

    
}
