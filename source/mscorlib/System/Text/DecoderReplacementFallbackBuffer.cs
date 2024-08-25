using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	[global::Cpp2ILInjected.Token(Token = "0x2000268")]
	public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
	{
		[global::Cpp2ILInjected.Token(Token = "0x60014C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB38AC", Offset = "0x1CB38AC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DecoderReplacementFallbackBuffer(DecoderReplacementFallback fallback)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB3970", Offset = "0x1CB3970", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderFallbackBuffer), Member = "ThrowLastBytesRecursive", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		public override bool Fallback(byte[] bytesUnknown, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB39AC", Offset = "0x1CB39AC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		public override char GetNextChar()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700020F")]
		public override int Remaining
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB39E8", Offset = "0x1CB39E8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB39F4", Offset = "0x1CB39F4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60014CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB3A04", Offset = "0x1CB3A04", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal unsafe override int InternalFallback(byte[] bytes, byte* pBytes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000AF9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string _strDefault;

		[global::Cpp2ILInjected.Token(Token = "0x4000AFA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _fallbackCount;

		[global::Cpp2ILInjected.Token(Token = "0x4000AFB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int _fallbackIndex;
	}
}
