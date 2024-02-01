// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var testString = @"aabaa aaaab
bbabbaaaabababbaaba aaababbaaaaaa
babbbabaa bbaba
baaaaababbaa abbab
ababbaabbbabaababaaaabaa aaabaababbbabbabbaababbb
aaaabaaaaabbaaaa aa
abababaaaaabaaaaba ababba
aabbbababaabaaa baabababbaaaaa
bababa a
bbbbabaaababaabbaab baaaaab";
testString = @"
 
 ";

var testcases = testString.Split("\r\n").Select(m => m.Split(" "));
foreach (var testcase in testcases)
{
    //HackerRank.virusIndices(testcase[0], testcase[1]);
}

Console.WriteLine(TimeSpan.FromTicks(int.Parse(Console.ReadLine())));
//HackerRank.buildString(7890, 7891, "acbcrsjcrscrsjcrcbcrsjcrscrsjccbcrsjcrscrsjcrcbcrsjrscrsjcrcbcrsjcrscrsjccbcrsjcrscrsjcrcbcsbcbcrsjh");
Console.WriteLine("-----------End test------------");
Console.ReadLine();
