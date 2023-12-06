
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задайте массив символов (тип char []). 
// Создайте строку из символов этого массива. 

//Указание
//Конструктор строки вида string(char []) не использовать.


// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”


// string GetStringFromCharArray(char [] chars){
//     string res = "";
//     foreach (char elem in chars){
//         res += elem;
//     }
//     return res;
// }

// char [] chars = {'a','d','c','b'};
// string str = GetStringFromCharArray(chars);
// Console.WriteLine(str);

//На основе символов строки (тип string) сформировать 
//массив символов (тип char[]). Вывести массив на экран.

//Указание
//Метод строки ToCharArray() не использовать.

// char [] StringToCharArray(string str){
//     char [] chars = new char [str.Length];
//     for (int i=0; i<str.Length; i++){
//         chars[i] = str[i];
//     }
//     return chars;
// }

void ShowCharsArr(char [] chars){
    foreach(char elem in chars){
        Console.Write(elem+" ");
    }
}


// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
//Выяснить, сколько среди введённых букв гласных.

//Пример

//“hello” => 2
//“world” => 1

// int GetCountVovelsInString(string str, string str1){
// int count = 0;
// foreach(char elem in str){
//     foreach(char vol in str1){
//         if(vol == elem){
//             count++;
//         }
//     }
// }
// return count;
// }

//Определите, является ли исходная строка символов палиндромом
//(читается одинаково с начала и с конца). 
//Регистры символов и пробелы игнорируйте.

string FilterString(string str){
    string res = str.ToLower();
    string count = "";
    foreach(char elem in res){
        if(elem != ' '){
            count+=elem;
        }
    }
    return count;
}

string IsPalindrome(string str){
    for(int i = 0; i<str.Length/2; i++){
        if(str[i] != str[str.Length-i-1]){
            return("String is not palindrome");
        }
    }
    return("String is palindrome");
}


string str = "ROT     Ot";
string res = FilterString(str);
Console.WriteLine(IsPalindrome(res));
//int chars = GetCountVovelsInString(str, str1);
//Console.WriteLine($"Count of includes in {str} from {str1} is {chars}");
