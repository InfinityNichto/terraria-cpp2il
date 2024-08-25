using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000128")]
	internal class BsonBinary : BsonValue
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000239")]
		public BsonBinaryType BinaryType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B7B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A584", Offset = "0x1D3A584", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B7C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A58C", Offset = "0x1D3A58C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A594", Offset = "0x1D3A594", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BsonBinary(byte[] value, BsonBinaryType binaryType)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000454")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private BsonBinaryType <BinaryType>k__BackingField;
	}
}
