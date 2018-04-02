﻿using System.Collections.Generic;
public class PersonAgeComparator : IComparer<Person>
{
    public int Compare(Person firstPerson, Person secondPerson)
    {
        return firstPerson.Age.CompareTo(secondPerson.Age);
    }
}