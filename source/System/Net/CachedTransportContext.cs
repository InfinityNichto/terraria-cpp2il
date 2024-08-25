using System;
using System.Security.Authentication.ExtendedProtection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001C6")]
	internal class CachedTransportContext : TransportContext
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000AE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F116E0", Offset = "0x1F116E0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CachedTransportContext(ChannelBinding binding)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F11708", Offset = "0x1F11708", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override ChannelBinding GetChannelBinding(ChannelBindingKind kind)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400098E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ChannelBinding binding;
	}
}
