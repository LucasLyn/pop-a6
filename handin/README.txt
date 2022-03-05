# PoP - 6g


## Kode


Biblioteket compiles med fsharpc;

	$ fsharpc -a continuedFraction.fsi continuedFraction.fs


Nu compiles testen med fsharpc og køres med mono;

	$ fsharpc -r continuedFraction.dll continuedFractionTest.fsx
	$ mono continuedFractionTest.exe


continuedFraction.fsi compiles til XML med fsharpc;

	$ fsharpc --doc:continuedFraction.xml -a continuedFraction.fsi continuedFraction.fs
