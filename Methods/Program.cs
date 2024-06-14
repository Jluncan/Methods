﻿using System.Net.Http.Headers;

namespace Methods {
    internal class Program {
        static void Main(string[] args) {
            
        
            TQL tql = new TQL ();
            tql.SecretNumber = 1;
            tql.DisplayClassname();
            var NewSecretNumber = tql.RandomizeSecretNumber(321);
            Console.WriteLine($"newSecretNumberis{NewSecretNumber}");
            tql.DisplayClassname();
        
        }
    }
}
internal class TQL {

        public int SecretNumber { get; set; }

    public void DisplayClassname() {
        Console.WriteLine($"Classname is TQL; SecretNumber is {SecretNumber}");
    }

    public int RandomizeSecretNumber(int RandomNumber) {
        SecretNumber *= RandomNumber;
        return SecretNumber;
    }


}