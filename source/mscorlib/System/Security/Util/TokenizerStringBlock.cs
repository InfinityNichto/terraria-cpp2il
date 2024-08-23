using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Util
{
	// Token: 0x0200020E RID: 526
	[global::Cpp2ILInjected.Token(Token = "0x20002A5")]
	internal sealed class TokenizerStringBlock
	{
		// Token: 0x0600152D RID: 5421 RVA: 0x00018086 File Offset: 0x00016286
		[global::Cpp2ILInjected.Token(Token = "0x6001738")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF0810", Offset = "0x1AF0810", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TokenizerStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TokenizerStream), Member = "AddString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TokenizerStringBlock()
		{
			throw null;
		}

		// Token: 0x04000931 RID: 2353
		[global::Cpp2ILInjected.Token(Token = "0x4000BD6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal string[] m_block;

		// Token: 0x04000932 RID: 2354
		[global::Cpp2ILInjected.Token(Token = "0x4000BD7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal TokenizerStringBlock m_next;
	}
}
