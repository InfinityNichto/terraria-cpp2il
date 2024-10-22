﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000013")]
	public class ResizableTextAreaAttribute : DrawerAttribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000033")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB56F0", Offset = "0x1CB56F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ResizableTextAreaAttribute()
		{
			throw null;
		}
	}
}
