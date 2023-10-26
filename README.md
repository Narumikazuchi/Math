![Logo](../release/logo.png)

![Tests](https://img.shields.io/github/actions/workflow/status/Narumikazuchi/Math/linux-tests.yml?label=linux-tests) ![Tests](https://img.shields.io/github/actions/workflow/status/Narumikazuchi/Math/windows-tests.yml?label=windows-tests) [![NuGet](https://img.shields.io/nuget/v/Narumikazuchi.Math.svg)](https://www.nuget.org/packages/Narumikazuchi.Math)  

# Introduction
The functionalities that are implemented here are mostly just for the purpose of 'building it myself'. It was a fun challenge to build formatters for base-3, base-5 and base-7 number representations, which are also p-adic numbers due to the base being a prime number.
Speaking of prime numbers, there is also a generator for prime numbers in this library, just in case one is needed.

# Contents
Upon looking at the signatures of the classes their capabilities should be clear at a glance. They are also documented, so the should be little confusion as to how they are used. A little side node for the ```PrimeInteger```, since
this struct has an implicit conversion, it can throw runtime exceptions for wrong parameters while also providing a clear signature of was a method expects. For example ```public void Foobar(PrimeInteger prime)``` clearly conveys the intent and what the
method expects as parameter.  

1. Prime Stuff
	1. ```static class PrimeGenerator```
	1. ```struct PrimeEnumerator```
	1. ```readonly struct PrimeInteger```
1. Formatters
	1. ```interface IIntegerFormatter<TInteger>```
	1. ```interface IFloatingPointFormatter<TFloatingPoint>```
	1. ```sealed class RomanIntegerFormatter```
	1. ```sealed class ThreeAdicIntegerFormatter```
	1. ```sealed class ThreeAdicFloatingPointFormatter```
	1. ```sealed class FiveAdicIntegerFormatter```
	1. ```sealed class FiveAdicFloatingPointFormatter```
	1. ```sealed class SevenAdicIntegerFormatter```
	1. ```sealed class SevenAdicFloatingPointFormatter```