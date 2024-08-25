using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Field, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000470")]
	public sealed class FixedBufferAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600220E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B73424", Offset = "0x1B73424", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public FixedBufferAttribute(global::System.Type elementType, int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000468")]
		public global::System.Type ElementType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600220F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B73454", Offset = "0x1B73454", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000469")]
		public int Length
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002210")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B7345C", Offset = "0x1B7345C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly global::System.Type <ElementType>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly int <Length>k__BackingField;
	}
}
