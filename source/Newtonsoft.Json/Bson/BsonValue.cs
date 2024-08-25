using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000126")]
	internal class BsonValue : BsonToken
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000B73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A520", Offset = "0x1D3A520", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BsonValue(object value, BsonType type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000235")]
		public object Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B74")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A550", Offset = "0x1D3A550", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000236")]
		public override BsonType Type
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000B75")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3A558", Offset = "0x1D3A558", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000450")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly object _value;

		[global::Cpp2ILInjected.Token(Token = "0x4000451")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly BsonType _type;
	}
}
