using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	[global::Cpp2ILInjected.Token(Token = "0x20005C4")]
	internal class Bootstring
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002D2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C03F50", Offset = "0x1C03F50", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Bootstring(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6002D30")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C03FBC", Offset = "0x1C03FBC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private char EncodeDigit(int d)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002D31")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0404C", Offset = "0x1C0404C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int DecodeDigit(char c)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x400193B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly char delimiter;

		[global::Cpp2ILInjected.Token(Token = "0x400193C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private readonly int base_num;

		[global::Cpp2ILInjected.Token(Token = "0x400193D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly int tmin;

		[global::Cpp2ILInjected.Token(Token = "0x400193E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private readonly int tmax;

		[global::Cpp2ILInjected.Token(Token = "0x400193F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly int skew;

		[global::Cpp2ILInjected.Token(Token = "0x4001940")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private readonly int damp;

		[global::Cpp2ILInjected.Token(Token = "0x4001941")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly int initial_bias;

		[global::Cpp2ILInjected.Token(Token = "0x4001942")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private readonly int initial_n;
	}
}
