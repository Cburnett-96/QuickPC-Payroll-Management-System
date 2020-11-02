// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"
#include <stdio.h>

extern "C"
{

	double dayhour = 8;
	double payperhour = 120;
	double overhour = 156;
	double absencehour = 120;

	__declspec(dllexport) double holiday(double a)
	{
		return a += payperhour * 2 * dayhour;
	}

	__declspec(dllexport) double incometaxes( double a, double b, double c)
	{
		double tax = 581.30 + ((a * 0.0275) / 2) + 100.00;
		return a += overhour * b - (tax + (c * absencehour));
	}

	__declspec(dllexport) double total(double a, double b, double c)
	{
		double tax = 581.30 + ((a * 0.0275) / 2) + 100.00;
		return a = payperhour * dayhour - tax;
	}
	__declspec(dllexport) double totaldeduction(double a, double b, double c)
	{
		double tax = 581.30 + ((a * 0.0275) / 2) + 100.00;
		double absent = absencehour * c;
		return a = tax + absent;
	}
}