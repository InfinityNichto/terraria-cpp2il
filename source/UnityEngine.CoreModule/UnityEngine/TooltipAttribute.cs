﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200008B")]
	public class TooltipAttribute : PropertyAttribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600027F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78A40", Offset = "0x1F78A40", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public TooltipAttribute(string tooltip)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000322")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly string tooltip;
	}
}
