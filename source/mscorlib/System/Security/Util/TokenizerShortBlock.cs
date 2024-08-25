using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Util
{
	[global::Cpp2ILInjected.Token(Token = "0x20002A4")]
	internal sealed class TokenizerShortBlock
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4000BD4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal short[] m_block;

		[global::Cpp2ILInjected.Token(Token = "0x4000BD5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal TokenizerShortBlock m_next;
	}
}
