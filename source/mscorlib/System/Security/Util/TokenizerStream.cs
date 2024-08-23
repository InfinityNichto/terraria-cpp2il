using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Util
{
	// Token: 0x0200020F RID: 527
	[global::Cpp2ILInjected.Token(Token = "0x20002A6")]
	internal sealed class TokenizerStream
	{
		// Token: 0x0600152E RID: 5422 RVA: 0x00018089 File Offset: 0x00016289
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

		// Token: 0x0600152F RID: 5423 RVA: 0x0001808C File Offset: 0x0001628C
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

		// Token: 0x06001530 RID: 5424 RVA: 0x0001808F File Offset: 0x0001628F
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

		// Token: 0x06001531 RID: 5425 RVA: 0x00018092 File Offset: 0x00016292
		[global::Cpp2ILInjected.Token(Token = "0x600173C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF01A0", Offset = "0x1AF01A0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Reset()
		{
			throw null;
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00018095 File Offset: 0x00016295
		[global::Cpp2ILInjected.Token(Token = "0x600173D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF01BC", Offset = "0x1AF01BC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal short GetNextFullToken()
		{
			throw null;
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00018098 File Offset: 0x00016298
		[global::Cpp2ILInjected.Token(Token = "0x600173E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEEF68", Offset = "0x1AEEF68", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal short GetNextToken()
		{
			throw null;
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0001809B File Offset: 0x0001629B
		[global::Cpp2ILInjected.Token(Token = "0x600173F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEF024", Offset = "0x1AEF024", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal string GetNextString()
		{
			throw null;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0001809E File Offset: 0x0001629E
		[global::Cpp2ILInjected.Token(Token = "0x6001740")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEEFAC", Offset = "0x1AEEFAC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void ThrowAwayNextString()
		{
			throw null;
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x000180A1 File Offset: 0x000162A1
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

		// Token: 0x06001537 RID: 5431 RVA: 0x000180A4 File Offset: 0x000162A4
		[global::Cpp2ILInjected.Token(Token = "0x6001742")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF0868", Offset = "0x1AF0868", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal int GetTokenCount()
		{
			throw null;
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x000180A7 File Offset: 0x000162A7
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

		// Token: 0x04000933 RID: 2355
		[global::Cpp2ILInjected.Token(Token = "0x4000BD8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int m_countTokens;

		// Token: 0x04000934 RID: 2356
		[global::Cpp2ILInjected.Token(Token = "0x4000BD9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private TokenizerShortBlock m_headTokens;

		// Token: 0x04000935 RID: 2357
		[global::Cpp2ILInjected.Token(Token = "0x4000BDA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private TokenizerShortBlock m_lastTokens;

		// Token: 0x04000936 RID: 2358
		[global::Cpp2ILInjected.Token(Token = "0x4000BDB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private TokenizerShortBlock m_currentTokens;

		// Token: 0x04000937 RID: 2359
		[global::Cpp2ILInjected.Token(Token = "0x4000BDC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int m_indexTokens;

		// Token: 0x04000938 RID: 2360
		[global::Cpp2ILInjected.Token(Token = "0x4000BDD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private TokenizerStringBlock m_headStrings;

		// Token: 0x04000939 RID: 2361
		[global::Cpp2ILInjected.Token(Token = "0x4000BDE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private TokenizerStringBlock m_currentStrings;

		// Token: 0x0400093A RID: 2362
		[global::Cpp2ILInjected.Token(Token = "0x4000BDF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int m_indexStrings;
	}
}
