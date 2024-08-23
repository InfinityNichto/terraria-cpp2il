using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000045 RID: 69
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000053")]
	internal struct StringReference
	{
		// Token: 0x17000093 RID: 147
		[global::Cpp2ILInjected.Token(Token = "0x17000093")]
		public char this[int i]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000307")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD1868", Offset = "0x1CD1868", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00002948 File Offset: 0x00000B48
		[global::Cpp2ILInjected.Token(Token = "0x17000094")]
		public char[] Chars
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000308")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD1878", Offset = "0x1CD1878", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002EF RID: 751 RVA: 0x0000294B File Offset: 0x00000B4B
		[global::Cpp2ILInjected.Token(Token = "0x17000095")]
		public int StartIndex
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000309")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD1880", Offset = "0x1CD1880", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000294E File Offset: 0x00000B4E
		[global::Cpp2ILInjected.Token(Token = "0x17000096")]
		public int Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x600030A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD1888", Offset = "0x1CD1888", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002951 File Offset: 0x00000B51
		[global::Cpp2ILInjected.Token(Token = "0x600030B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD1890", Offset = "0x1CD1890", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringIntoBuffer", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ParseUnquotedProperty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ParseConstructor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ParseNumber", MemberParameters = new object[] { typeof(ReadType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public StringReference(char[] chars, int startIndex, int length)
		{
			throw null;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002954 File Offset: 0x00000B54
		[global::Cpp2ILInjected.Token(Token = "0x600030C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD189C", Offset = "0x1CD189C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ParseString", MemberParameters = new object[]
		{
			typeof(char),
			typeof(ReadType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadAsBoolean", ReturnType = typeof(bool?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadNumberValue", MemberParameters = new object[] { typeof(ReadType) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ParseProperty", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ParseConstructor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ParseNumber", MemberParameters = new object[] { typeof(ReadType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04000167 RID: 359
		[global::Cpp2ILInjected.Token(Token = "0x4000191")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly char[] _chars;

		// Token: 0x04000168 RID: 360
		[global::Cpp2ILInjected.Token(Token = "0x4000192")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private readonly int _startIndex;

		// Token: 0x04000169 RID: 361
		[global::Cpp2ILInjected.Token(Token = "0x4000193")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private readonly int _length;
	}
}
