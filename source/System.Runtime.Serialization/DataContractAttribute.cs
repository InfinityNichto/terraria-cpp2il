﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000002")]
	public sealed class DataContractAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000001")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5C3D8", Offset = "0x1D5C3D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DataContractAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000001")]
		public bool IsReference
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000002")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5C3E0", Offset = "0x1D5C3E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000001")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool isReference;
	}
}
