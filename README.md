# PoP - Assignment 6
PoP - 6i

This assignment was about continued fractions. In this case, we were tasked with creating and reversing continued fractions.

# PoP - 6g


## Kode


Biblioteket compiles med fsharpc;

	$ fsharpc -a continuedFraction.fsi continuedFraction.fs


Nu compiles testen med fsharpc og køres med mono;

	$ fsharpc -r continuedFraction.dll continuedFractionTest.fsx
	$ mono continuedFractionTest.exe


continuedFraction.fsi compiles til XML med fsharpc;

	$ fsharpc --doc:continuedFraction.xml -a continuedFraction.fsi continuedFraction.fs
