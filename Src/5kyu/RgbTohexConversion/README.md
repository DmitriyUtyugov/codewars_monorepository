The rgb function is incomplete. Complete it so that passing in RGB decimal values will result in a hexadecimal representation being returned.
Valid decimal values for RGB are 0 - 255. Any values that fall out of that range must be rounded to the closest valid value.

Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.

The following are examples of expected output values:
```C#
Rgb(255, 255, 255) # returns FFFFFF
Rgb(255, 255, 300) # returns FFFFFF
Rgb(0,0,0) # returns 000000
Rgb(148, 0, 211) # returns 9400D3
```

Fixed Tests:
```C#
Assert.AreEqual("FFFFFF", Kata.Rgb(255, 255, 255));
Assert.AreEqual("FFFFFF", Kata.Rgb(255, 255, 300));
Assert.AreEqual("000000", Kata.Rgb(0, 0, 0));
Assert.AreEqual("9400D3", Kata.Rgb(148, 0, 211));
Assert.AreEqual("9400D3", Kata.Rgb(148, -20, 211), "Handle negative numbers.");
Assert.AreEqual("90C3D4", Kata.Rgb(144, 195, 212));
Assert.AreEqual("D4350C", Kata.Rgb(212, 53, 12), "Consider single hex digit numbers.");
```
