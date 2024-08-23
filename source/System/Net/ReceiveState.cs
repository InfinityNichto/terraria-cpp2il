using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000DE RID: 222
	[global::Cpp2ILInjected.Token(Token = "0x2000148")]
	internal class ReceiveState
	{
		// Token: 0x06000737 RID: 1847 RVA: 0x000042F8 File Offset: 0x000024F8
		[global::Cpp2ILInjected.Token(Token = "0x6000800")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EECBB0", Offset = "0x1EECBB0", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CommandStream), Member = "ReceiveCommandResponse", ReturnType = typeof(ResponseDescription))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResponseDescription), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal ReceiveState(CommandStream connection)
		{
			throw null;
		}

		// Token: 0x040004DF RID: 1247
		[global::Cpp2ILInjected.Token(Token = "0x4000672")]
		private const int bufferSize = 1024;

		// Token: 0x040004E0 RID: 1248
		[global::Cpp2ILInjected.Token(Token = "0x4000673")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal ResponseDescription Resp;

		// Token: 0x040004E1 RID: 1249
		[global::Cpp2ILInjected.Token(Token = "0x4000674")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int ValidThrough;

		// Token: 0x040004E2 RID: 1250
		[global::Cpp2ILInjected.Token(Token = "0x4000675")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal byte[] Buffer;

		// Token: 0x040004E3 RID: 1251
		[global::Cpp2ILInjected.Token(Token = "0x4000676")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal CommandStream Connection;
	}
}
