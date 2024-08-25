using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20006A9")]
	public abstract class RemoteAddress
	{
		[global::Cpp2ILInjected.Token(Token = "0x60038AA")]
		public abstract string GetIdentifier();

		[global::Cpp2ILInjected.Token(Token = "0x60038AB")]
		public abstract string GetFriendlyName();

		[global::Cpp2ILInjected.Token(Token = "0x60038AC")]
		public abstract bool IsLocalHost();

		[global::Cpp2ILInjected.Token(Token = "0x60038AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x143D530", Offset = "0x143D530", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected RemoteAddress()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007956")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public AddressType Type;
	}
}
