//1-dim array 
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

//2-dim array [row, column]
//[,,] 3dim [,,,] 4dim ...以此類推

int[,] matrix = {
    { 1, 2, 3, 4 }, 
    { 5, 6, 7, 8 }, 
    { 9, 10, 11, 12 } 
};
System.Console.WriteLine($"matrix[1,2] is: {matrix[1,2]}"); 

int[,] m2 = new int[3, 4]; // row 3, col 4
m2[0, 0] = 1;
m2[0, 1] = 2;

System.Console.WriteLine("2-dim array m2 is: ");
for (int r = 0; r < m2.GetLength(0); r++) //GetLength(0) = row數
{
    for (int c = 0; c < m2.GetLength(1); c++) //GetLength(1)= col數
    {
        System.Console.Write($"{m2[r,c]} \t"); //\t tab
    }
    System.Console.WriteLine();
}   

int[,,] cube = new int[3, 4, 2]; //3dim array
cube[0, 0, 0] = 1;
cube[0, 2, 1] = 2;
cube[1, 0, 0] = 3;
cube[1, 0, 1] = 4;
cube[2, 3, 0] = 5; 
cube[2, 0, 1] = 6;

System.Console.WriteLine($"3-dim array cube is:");
for (int r = 0; r < cube.GetLength(0); r++) //GetLength(0) = row數
{
    for (int c = 0; c < cube.GetLength(1); c++) //GetLength(1)= col數
    {
        for (int d = 0; d < cube.GetLength(2); d++) //GetLength(2)= depth數
        {
            System.Console.Write($"{cube[r, c, d]} \t"); //\t tab
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}