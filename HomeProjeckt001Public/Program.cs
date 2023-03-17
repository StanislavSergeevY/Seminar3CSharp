string checkPalindrome(int number, int index)
{
  int[] digit = new int[index];
  for (int i = 1; i <= digit.Length; i++)
  {
    int step = digit.Length - i;
    digit[step] = number % 10;
    number /= 10;
  }

  int x = 0;
  int check =0;

  if(digit.Length % 2 == 0) // НЕ ЗЕРКАЛЬНЫй ПАЛИНДРОМ
  {
    for(int j = digit.Length - 1; j >= digit.Length / 2; j--)
    {
      if(x <= digit.Length / 2)
      {
        if(digit[x] == digit[j])
          check = check + 1;
          x = x + 1;
      }
    }
    if(check == digit.Length / 2)
      return "Введенное число является палиндромом";
    else
      return "Введенное число не является палиндромом";
  }
  else /////////////////////////// ЗЕРКАЛЬНЫй ПАЛИНДРОМ
  {
    for(int j = digit.Length - 1; j > digit.Length / 2; j--)
    {
      if(x < digit.Length / 2)
      {
        if(digit[x] == digit[j])
          check = check + 1;
          x = x + 1;
      }
    }
    if(check == digit.Length / 2)
      return "Введенное число является палиндромом";
    else
      return "Введенное число не является палиндромом";
  }
}

Console.Write("Введите значение: ");

string txtVolue = Console.ReadLine();
int index = Convert.ToInt32(txtVolue.Length);
int volue = Convert.ToInt32(txtVolue);

Console.WriteLine(checkPalindrome(volue, index));