using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004D3 RID: 1235
	[global::Cpp2ILInjected.Token(Token = "0x20005C4")]
	internal class Bootstring
	{
		// Token: 0x060029CD RID: 10701 RVA: 0x0001B9B3 File Offset: 0x00019BB3
		[global::Cpp2ILInjected.Token(Token = "0x6002D2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C03F50", Offset = "0x1C03F50", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Bootstring(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN)
		{
			throw null;
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x0001B9B6 File Offset: 0x00019BB6
		[global::Cpp2ILInjected.Token(Token = "0x6002D2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C03528", Offset = "0x1C03528", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IdnMapping), Member = "ToAscii", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bootstring), Member = "Adapt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public string Encode(string s, int offset)
		{
			throw null;
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x0001B9B9 File Offset: 0x00019BB9
		[global::Cpp2ILInjected.Token(Token = "0x6002D30")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C03FBC", Offset = "0x1C03FBC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private char EncodeDigit(int d)
		{
			throw null;
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x0001B9BC File Offset: 0x00019BBC
		[global::Cpp2ILInjected.Token(Token = "0x6002D31")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0404C", Offset = "0x1C0404C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int DecodeDigit(char c)
		{
			throw null;
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x0001B9BF File Offset: 0x00019BBF
		[global::Cpp2ILInjected.Token(Token = "0x6002D32")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C03FD4", Offset = "0x1C03FD4", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bootstring), Member = "Encode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Bootstring), Member = "Decode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		private int Adapt(int delta, int numPoints, bool firstTime)
		{
			throw null;
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x0001B9C2 File Offset: 0x00019BC2
		[global::Cpp2ILInjected.Token(Token = "0x6002D33")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C03C74", Offset = "0x1C03C74", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IdnMapping), Member = "ToUnicode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bootstring), Member = "Adapt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public string Decode(string s, int offset)
		{
			throw null;
		}

		// Token: 0x04001558 RID: 5464
		[global::Cpp2ILInjected.Token(Token = "0x400193B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly char delimiter;

		// Token: 0x04001559 RID: 5465
		[global::Cpp2ILInjected.Token(Token = "0x400193C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private readonly int base_num;

		// Token: 0x0400155A RID: 5466
		[global::Cpp2ILInjected.Token(Token = "0x400193D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly int tmin;

		// Token: 0x0400155B RID: 5467
		[global::Cpp2ILInjected.Token(Token = "0x400193E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private readonly int tmax;

		// Token: 0x0400155C RID: 5468
		[global::Cpp2ILInjected.Token(Token = "0x400193F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly int skew;

		// Token: 0x0400155D RID: 5469
		[global::Cpp2ILInjected.Token(Token = "0x4001940")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private readonly int damp;

		// Token: 0x0400155E RID: 5470
		[global::Cpp2ILInjected.Token(Token = "0x4001941")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly int initial_bias;

		// Token: 0x0400155F RID: 5471
		[global::Cpp2ILInjected.Token(Token = "0x4001942")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private readonly int initial_n;
	}
}
