﻿using System;

public class Dog : Animal, ISound
{
    public Dog(string name, int age, string gender)
        : base(name, age, gender)
    {
    }

    public override void ProduceSound()
    {
        Console.WriteLine(" is barking! Bark!");
    }
}

