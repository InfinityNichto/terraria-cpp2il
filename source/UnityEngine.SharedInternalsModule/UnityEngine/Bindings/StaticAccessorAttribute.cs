﻿using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Bindings
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property)]
	[VisibleToOtherModules]
	[global::Cpp2ILInjected.Token(Token = "0x2000019")]
	internal class StaticAccessorAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000014")]
		public string Name
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000034")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA41A8", Offset = "0x1FA41A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000015")]
		public StaticAccessorType Type
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000035")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA41B0", Offset = "0x1FA41B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[VisibleToOtherModules]
		[global::Cpp2ILInjected.Token(Token = "0x6000036")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA41B8", Offset = "0x1FA41B8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		internal StaticAccessorAttribute(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000037")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA41E0", Offset = "0x1FA41E0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public StaticAccessorAttribute(string name, StaticAccessorType type)
		{
			throw null;
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000022")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <Name>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000023")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private StaticAccessorType <Type>k__BackingField;
	}
}
