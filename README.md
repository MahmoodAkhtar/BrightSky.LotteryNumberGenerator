# Interview Test (18/06/2020)

## Purpose

> The Lottery Programming Challenge is a challenge for interview candidates to demonstrate that they can write a simple program in any language of their choice (e.g. C#, JavaScript). This is not a real application; ...

## Challenge

> You must write a simple "Lottery Number Generator" to choose 6 unique numbers randomly where each number is within 1 to 49 inclusive; the idea is that you could then use these numbers to enter the National Lottery. ...

## Requirements

> *	The program shall choose 6 numbers for the user. 
> *	The 6 numbers shall be unique. For example {8, 10, 15, 28, 35, 43} is okay {8, 10, 15, 28, 43, 43} is not.
> *	The numbers shall be presented to the user in numeric order.
> *	The numbers shall be in the range of 1 to 49 inclusive.
> *	The application shall be written in any language or languages.
> *	The application shall be any form of application so long as it has a UI, for example a console application, WPF application, a Phone app, Asp.Net it does not matter.
> *	EXTRA: The numbers should have a different coloured background: 1-9 grey, 10-19 blue, 20-29, pink, 30-39 green, 40-49 yellow.
> * EXTRA: Consider that the program should be able to be adapted in future to provide a bonus ball (7 balls instead of 6.)

# Getting Started

This is a .NET Core 3.1 solution written using VS2019 consisting of a `*.Core` project and `*.Cli` project both in the `\src` folder. There is an accompaning unit test project called `*.Core.Tests` in the `\test` folder. These unit tests verifiy the above requirements (including EXTRAs) are met. [FluentAssertions](https://fluentassertions.com/) have been used in the unit tests to make them more human readable. Overall there is nothing fancy, just code that meets the requirements. 

The UI is a console app. Make sure the `BrightSky.LotteryNumberGenerator.Cli` project is marked as the 'Start up Project'. Then just run and follow instructions.

# What to do next?

Give me the contract - _just kidding ... but seriously do give me the contract - lol_
