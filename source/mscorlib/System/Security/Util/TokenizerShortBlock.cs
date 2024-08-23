using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Util
{
	// Token: 0x0200020D RID: 525
	[global::Cpp2ILInjected.Token(Token = "0x20002A4")]
	internal sealed class TokenizerShortBlock
	{
		// Token: 0x0600152C RID: 5420 RVA: 0x00018083 File Offset: 0x00016283
		[global::Cpp2ILInjected.Token(Token = "0x6001737")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF07B8", Offset = "0x1AF07B8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TokenizerStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TokenizerStream), Member = "AddToken", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TokenizerShortBlock()
		{
			throw null;
		}

		// Token: 0x0400092F RID: 2351
		[global::Cpp2ILInjected.Token(Token = "0x4000BD4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal short[] m_block;

		// Token: 0x04000930 RID: 2352
		[global::Cpp2ILInjected.Token(Token = "0x4000BD5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal TokenizerShortBlock m_next;
	}
}
