using System.Security.Cryptography;

int variation;
Console.WriteLine("Выберите пункт:\n\n1 - Проанализировать предложение\n2 - Найти позицию первой заглавной буквы\n0 - Выход\n");
variation = int.Parse(Console.ReadLine()!);
Console.WriteLine();
while (variation !=0){
    if (variation == 1){
        first(Console.ReadLine()!);
    }
    else if (variation == 2){
        second(Console.ReadLine()!);
    }
    Console.WriteLine("Выберите пункт:\n1 - Проанализировать предложение\n2 - Найти позицию первой заглавной буквы\n0 - Выход\n");
    variation = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
}
Console.WriteLine("До свидания!");

void first(string sentence){
    int cnt_g = 0;
    int cnt_s = 0;
    int cnt_o = 0;
    string glasn = "аеёиоуыэюяАЕЁИОУЫЭЮЯAEIOUYaeiouy";
    string sogl = "бвгджзйклмнпрстфхцчшщБВГДЖЗЙКЛМНПРСТФХЦЧШЩBCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";
    foreach (char letter in sentence){
        if (glasn.Contains(letter)){
            cnt_g++;
        }else if (sogl.Contains(letter)){
            cnt_s++;
        }else if (letter == ' '){
            cnt_o++;
        }
    }
    Console.WriteLine($"Гласных: {cnt_g}\nСогласных: {cnt_s}\nПробелов: {cnt_o}\n");
}

void second(string sentence){
    int cnt = 0;int i = 0;
    foreach(char letter in sentence){
        if ("ABCDEFGHIJKLMNOPQRSTUVWXYZАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".Contains(letter)){
            Console.WriteLine($"Первая заглавная: {i+1} по счёту");cnt++;break;
        } else{
            i++;   
        }
        
    }
    if (cnt==0) Console.WriteLine("Заглавных в тексте нет");
    Console.WriteLine();
}