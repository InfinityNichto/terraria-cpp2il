using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020000DD RID: 221
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000126")]
	internal class BsonValue : BsonToken
	{
		// Token: 0x06000A36 RID: 2614 RVA: 0x00003E1E File Offset: 0x0000201E
		[global::Cpp2ILInjected.Token(Token = "0x6000B73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3A520", Offset = "0x1D3A520", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BsonValue(object value, BsonType type)
		{
			throw null;
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x00003E21 File Offset: 0x00002021
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

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x00003E24 File Offset: 0x00002024
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

		// Token: 0x04000329 RID: 809
		[global::Cpp2ILInjected.Token(Token = "0x4000450")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly object _value;

		// Token: 0x0400032A RID: 810
		[global::Cpp2ILInjected.Token(Token = "0x4000451")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly BsonType _type;
	}
}
