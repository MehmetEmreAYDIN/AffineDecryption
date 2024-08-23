﻿char[] alphabet = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ".ToCharArray();    //Enter the letters of the alphabet into this field.
char[] cipherText = "ŞifreliMetin".ToUpper().ToCharArray();   // Enter the plain text into this field.
int a = 2; int b = 3;   //Enter the key parameters a and b into the respective fields. 
string plainText = string.Empty;

int d = 1;
while (true)
{
    if ((alphabet.Length * d + 1) % a == 0) d = (alphabet.Length * d + 1) / a; break;
    d++;
}
for (int i = 0; i < cipherText.Length; i++)
{
    int ndx = (Array.IndexOf(alphabet, cipherText[i]) - b) * d % alphabet.Length;
while (ndx < 0) ndx += alphabet.Length;
    plainText += alphabet[ndx];
}
Console.WriteLine(plainText);
