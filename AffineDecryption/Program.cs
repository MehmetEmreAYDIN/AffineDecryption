﻿char[] alphabet = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ".ToCharArray();    //Enter the letters of the alphabet in this field.
char[] cipherText = "ŞifreliMetin".ToUpper().ToCharArray();   //Enter the cipher text in this field.
int a = 2; int b = 3;   //Enter the key parameters a and b in the respective fields. 

int d = 1;
while (true)
{
    if ((alphabet.Length * d + 1) % a == 0) d = (alphabet.Length * d + 1) / a; break;
    d++;
}

string plainText = string.Empty;
for (int i = 0; i < cipherText.Length; i++)
{
    int ndx = (Array.IndexOf(alphabet, cipherText[i]) - b) * d % alphabet.Length;
while (ndx < 0) ndx += alphabet.Length;
    plainText += alphabet[ndx];
}
Console.WriteLine(plainText);
