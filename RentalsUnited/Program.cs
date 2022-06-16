/*1. Writea function that will reverse the order of words in a sentence.
sentence, if has a value, has words separated by a space
the dot can be at the end of the sentence
After reversing the sentence, the dot always have to be at the end of the sentence

Input: "Ala ma kota.", "Sentence with a-dash."
Output: "kota ma Ala.", "a-dash with Sentence."
*/

string ex1 = "Ala ma kota.";
string ex2 = "Sentence with a-dash.";
System.Console.WriteLine(RentalsUnited.ReverseWordsInSentence(ex1));
System.Console.WriteLine(RentalsUnited.ReverseWordsInSentence(ex2));

 class RentalsUnited
{
    public static string ReverseWordsInSentence(string s)
    {
        var trimmed = s.TrimEnd('.');
        var splitted = trimmed.Split();
        var splitted2 = splitted.Reverse();
        string result = "";

        foreach (var item in splitted2)
        {
            result += item + " ";
        }

        string result2 = result.TrimEnd() + ".";
        return result2;
    }
}