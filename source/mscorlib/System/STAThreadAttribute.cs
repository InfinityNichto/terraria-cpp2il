﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Method)]
	[global::Cpp2ILInjected.Token(Token = "0x2000105")]
	public sealed class STAThreadAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60009A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4B5C4", Offset = "0x1C4B5C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public STAThreadAttribute()
		{
			throw null;
		}
	}
}
