﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Constructor | global::System.AttributeTargets.Method, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20005C8")]
	internal sealed class StackTraceHiddenAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002D4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C04810", Offset = "0x1C04810", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public StackTraceHiddenAttribute()
		{
			throw null;
		}
	}
}
