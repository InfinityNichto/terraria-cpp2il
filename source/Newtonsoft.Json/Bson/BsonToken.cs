using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000123")]
	internal abstract class BsonToken
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000230")]
		public abstract BsonType Type
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B63")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000231")]
		public BsonToken Parent
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B64")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A1E8", Offset = "0x1D3A1E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B65")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A1F0", Offset = "0x1D3A1F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000232")]
		public int CalculatedSize
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B66")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A1F8", Offset = "0x1D3A1F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B67")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A200", Offset = "0x1D3A200", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A208", Offset = "0x1D3A208", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected BsonToken()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400044C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private BsonToken <Parent>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400044D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int <CalculatedSize>k__BackingField;
	}
}
