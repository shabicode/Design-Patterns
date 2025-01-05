using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

Console.WriteLine("**** Singleton Pattern Demostration **** \n");
Console.WriteLine(Singleton.Instance.msg);
Console.WriteLine(WeddingCake.MyInt);

Console.WriteLine("Trying to get a Singleton instance, calledfirstInstance.");
WeddingCake firstInstance = WeddingCake.GetInstance;
Console.WriteLine("Trying to get another Singleton instance,called secondInstance.");
WeddingCake secondInstance = WeddingCake.GetInstance;
if (firstInstance.Equals(secondInstance)){
     Console.WriteLine("The firstInstance and secondInstance are the same");
} else  {
    Console.WriteLine("Different instances exist.");
}
 Console.Read();
           

Console.WriteLine(MaxScore("00"));
//0 1 1 1 0 1
int MaxScore(string s) {
    int maxScore = 0;
    for(int i = 0; i < s.Length - 1; i++ ) {
        int leftScore = calculateScore('0', s[..(i+1)]);
        int rightScore = calculateScore('1',s[(i+1)..]);
        maxScore = Math.Max(leftScore, rightScore);
    }
    return maxScore;
}

int calculateScore(char number, string subString) {
    int count = 0;
    foreach (char c in subString) {
        if (c == number) { count += 1; }
    }
    return count;
}
//words = ["aba","bcb","ece","aa","e"], queries = [[0,2],[1,4],[1,1]]
string[] words =["aba","bcb","ece","aa","e"];
int[][] queries = [[0,2],[1,4],[1,1]];

//0,1 1,0, 2,1

var result = vowelStrings(words, queries);
Console.WriteLine(result);
int[] vowelStrings(string[] words, int[][] queries) {
    int[] result = new int[queries.Length];
    int[] wordsWithVowel = arrayVowelWords(words);
    int[] prefixSum = new int[wordsWithVowel.Length + 1];

    for(int i = 0; i < wordsWithVowel.Length; i++){
        prefixSum[i + 1] = prefixSum[i] + wordsWithVowel[i];
    } 

    for (int i = 0; i <= queries.Length - 1; i ++) {
        result[i] = prefixSum[queries[i][1] + 1] - prefixSum[queries[i][0]];
    }
    return result;

}
///////////////////////////////////////////////////////////
int[] arrayVowelWords (string[] words) {
    int[] vowelWords = new int[words.Length];
    var regex = new Regex("^[aeiouAEIOU](.*[aeiouAEIOU])?$");
    for(int i = 0; i < words.Length; i ++) { 
        vowelWords[i] = regex.IsMatch(words[i]) ? 1 : 0;
    }
    return vowelWords;
}