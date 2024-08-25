using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Util
{
	[global::Cpp2ILInjected.Token(Token = "0x20002A6")]
	internal sealed class TokenizerStream
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001739")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF00FC", Offset = "0x1AF00FC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TokenizerShortBlock), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TokenizerStringBlock), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal TokenizerStream()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600173A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF0460", Offset = "0x1AF0460", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tokenizer), Member = "GetTokens", MemberParameters = new object[]
		{
			typeof(TokenizerStream),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TokenizerShortBlock), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void AddToken(short token)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600173B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF0514", Offset = "0x1AF0514", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tokenizer), Member = "GetTokens", MemberParameters = new object[]
		{
			typeof(TokenizerStream),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TokenizerStringBlock), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal void AddString(string str)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600173C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF01A0", Offset = "0x1AF01A0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600173D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF01BC", Offset = "0x1AF01BC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal short GetNextFullToken()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600173E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEEF68", Offset = "0x1AEEF68", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal short GetNextToken()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600173F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEF024", Offset = "0x1AEF024", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal string GetNextString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001740")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEEFAC", Offset = "0x1AEEFAC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void ThrowAwayNextString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001741")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEEFE0", Offset = "0x1AEEFE0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Parser), Member = "GetRequiredSizes", MemberParameters = new object[]
		{
			typeof(TokenizerStream),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		internal void TagLastToken(short tag)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001742")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF0868", Offset = "0x1AF0868", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal int GetTokenCount()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001743")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEFA1C", Offset = "0x1AEFA1C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Parser), Member = "DetermineFormat", MemberParameters = new object[] { typeof(TokenizerStream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal void GoToPosition(int position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000BD8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int m_countTokens;

		[global::Cpp2ILInjected.Token(Token = "0x4000BD9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private TokenizerShortBlock m_headTokens;

		[global::Cpp2ILInjected.Token(Token = "0x4000BDA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private TokenizerShortBlock m_lastTokens;

		[global::Cpp2ILInjected.Token(Token = "0x4000BDB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private TokenizerShortBlock m_currentTokens;

		[global::Cpp2ILInjected.Token(Token = "0x4000BDC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int m_indexTokens;

		[global::Cpp2ILInjected.Token(Token = "0x4000BDD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private TokenizerStringBlock m_headStrings;

		[global::Cpp2ILInjected.Token(Token = "0x4000BDE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private TokenizerStringBlock m_currentStrings;

		[global::Cpp2ILInjected.Token(Token = "0x4000BDF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int m_indexStrings;
	}
}
