# RandomIntList
 This is a C# console application that generates a list of randomly-ordered unique integers between 1-10000.
 It uses the modern version of the Fisher-Yates Shuffle algorithm with Mersenne Twister as the PRNG.
 
## Recommended Prerequisites
- Visual Studio 2017 (Past versions of Visual Studio may work)
- Latest version of .NET framework

## Build and Run
Use Visual Studio to build & run the program.

Alternatively compiling in cmd is possible.
https://superuser.com/questions/604953/how-can-i-compile-a-net-project-without-having-visual-studio-installed

## Tests
RandomIntListTests  is a unit test project to test the logic of Shuffle.cs in the RandomIntList project.
To run the tests, use Visual Studio 2017 built in test explorer.

## Acknowledgements
- Mersenne Twister implementation by Mitil Ooyama
http://www.math.sci.hiroshima-u.ac.jp/~m-mat/MT/VERSIONS/C-LANG/c-lang.html
