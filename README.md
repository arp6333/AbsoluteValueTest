**Absolute Value Test**

The AbsoluteValueTest is a program to test the speeds of various methods to get the absolute value of a number in C#.

**Results**

I performed 3 tests:

1. Math.Abs
   
```csharp
absolute = Math.Abs(i);
```

2. Multiply by -1 without checking if the number is negative
   
```csharp
absolute = i * -1;
```

3. Multiply by -1 while checking if the number is negative

```csharp
if (i < 0)
{
    absolute = i * -1;
}
```

Each test took the abosolute value of a negative number looping from -1 to -1,000,000. The tests ran 1,000 times and the elapsed time to create each absolute value was averaged for the result. The results were consistently: Math.abs ~= 3.2ms, *-1 ~= 1ms, *-1 with negative check ~= 2ms.

![Results](../master/media/absolutevaluetest.PNG)

**Conclusion**

If you know the number is negative, it seems to be best to multiply by negative one to get the absolute value. But in the end, it is such a miniscule difference and Math.abs is much more readable.
