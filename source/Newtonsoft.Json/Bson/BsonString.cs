using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000127")]
	internal class BsonString : BsonValue
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000237")]
		public int ByteCount
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B76")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A560", Offset = "0x1D3A560", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B77")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A568", Offset = "0x1D3A568", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000238")]
		public bool IncludeLength
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B78")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A570", Offset = "0x1D3A570", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B79")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A578", Offset = "0x1D3A578", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A330", Offset = "0x1D3A330", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BsonString(object value, bool includeLength)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000452")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int <ByteCount>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000453")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool <IncludeLength>k__BackingField;
	}
}
