﻿using System;
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class SoftUniAttribute : Attribute
{
    public string Name { get; }

    public SoftUniAttribute(string name)
    {
        this.Name = name;
    }
}