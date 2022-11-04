using System;

class DIO {
        
static void Main(string[] args){

        int n = int.Parse(Console.ReadLine());
        int p = 1, s = 0;
        while (n > 0){
             int l = n % 10; // 20,20,20,20
             p *= l;
             s += n % 10;
             n /= 10;
           }

           Console.WriteLine(p-s);
        }
    }