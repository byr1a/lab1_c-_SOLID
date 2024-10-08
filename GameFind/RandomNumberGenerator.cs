﻿using System;

public class RandomNumberGenerator : IRandomNumberGenerator
{
    private Random _random = new Random();

    public int Generate(int min, int max)
    {
        return _random.Next(min, max + 1);
    }
}
