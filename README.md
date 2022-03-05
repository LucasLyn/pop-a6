# PoP - Assignment 6
PoP - 6i

This assignment was about continued fractions. In this case, we were tasked with creating and reversing continued fractions.

# PoP - 6g


## Kode


The library is compiled with fsharpc;

	$ fsharpc -a continuedFraction.fsi continuedFraction.fs


The code is compiled with the library with fsharpc and run with mono;

	$ fsharpc -r continuedFraction.dll continuedFractionTest.fsx
	$ mono continuedFractionTest.exe


The library is compiled to XML with fsharpc;

	$ fsharpc --doc:continuedFraction.xml -a continuedFraction.fsi continuedFraction.fs
