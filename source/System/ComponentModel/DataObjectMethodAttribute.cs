using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Method)]
	[global::Cpp2ILInjected.Token(Token = "0x2000363")]
	public sealed class DataObjectMethodAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60016A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47B9C", Offset = "0x1E47B9C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DataObjectMethodAttribute(DataObjectMethodType methodType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47BC8", Offset = "0x1E47BC8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DataObjectMethodAttribute(DataObjectMethodType methodType, bool isDefault)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000526")]
		public bool IsDefault
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60016A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E47BF8", Offset = "0x1E47BF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000527")]
		public DataObjectMethodType MethodType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60016A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E47C00", Offset = "0x1E47C00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47C08", Offset = "0x1E47C08", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47CA8", Offset = "0x1E47CA8", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47CF0", Offset = "0x1E47CF0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Match(object obj)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <IsDefault>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private readonly DataObjectMethodType <MethodType>k__BackingField;
	}
}
