// known array
int[] scores = { 100, 98, 85, 72, 49 }; //創建一個陣列，數值已知。 注意已知的陣列用大括號{}
//如果打錯數字，不回頭改的方法: scores[4] = 59; 把五號同學的分數從死當變成活當，可以先修下學期，明年跟學弟妹擠一擠:>
for (int i = 0; i < scores.Length; i++ ) //能用loop就用，解放手指，延長換鍵盤軸體的週期~
{
    System.Console.WriteLine($"Number {i+1}'s Score is: {scores[i]}"); //N號同學的成績是多少
}

// unknown array
string[] phone = new string[5]; //創一個數值未知但可以放12個位置的陣列，用來放手機號碼 type: str
phone[0]= "0912-345-678";
phone[1]= "0922345678";

for (int i = 0; i < phone.Length; i++)
{
    if (phone[i] == null)  //如果沒資料就顯示Blank
    {
        phone[i] = "Null";
        System.Console.WriteLine($"Number {i + 1}'s Phone number is: Blank");
    }
    else
    {
        System.Console.WriteLine($"Number {i + 1}'s Phone number is: {phone[i]}");
    }
}