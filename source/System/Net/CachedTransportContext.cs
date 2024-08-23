using System;
using System.Security.Authentication.ExtendedProtection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200013F RID: 319
	[global::Cpp2ILInjected.Token(Token = "0x20001C6")]
	internal class CachedTransportContext : TransportContext
	{
		// Token: 0x060009D6 RID: 2518 RVA: 0x000049FA File Offset: 0x00002BFA
		[global::Cpp2ILInjected.Token(Token = "0x6000AE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F116E0", Offset = "0x1F116E0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CachedTransportContext(ChannelBinding binding)
		{
			throw null;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x000049FD File Offset: 0x00002BFD
		[global::Cpp2ILInjected.Token(Token = "0x6000AE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F11708", Offset = "0x1F11708", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override ChannelBinding GetChannelBinding(ChannelBindingKind kind)
		{
			throw null;
		}

		// Token: 0x04000775 RID: 1909
		[global::Cpp2ILInjected.Token(Token = "0x400098E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ChannelBinding binding;
	}
}
