/*1. Writea function that will reverse the order of words in a sentence.
sentence, if has a value, has words separated by a space
the dot can be at the end of the sentence
After reversing the sentence, the dot always have to be at the end of the sentence

Input: "Ala ma kota.", "Sentence with a-dash"
Output: "kota ma Ala.", "a-dash with Sentence."
*/
string ex1 = "Ala ma kota.";
System.Console.WriteLine(RentalsUnited.ReverseWordsInSentence(ex1));

 class RentalsUnited
{
    public static string ReverseWordsInSentence(string s)
    {
        var splitted = s.Split(' ');
        var splitted2 = splitted.Reverse();
        var result = Convert.ToString(splitted2);
     
        return result;
        // string result = "";
        // for (int i = s.Length - 1; i >= 0; i--)
        // {
        //     result += s[i];
        // }
        // return result;
    }
}