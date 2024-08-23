using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Net
{
	// Token: 0x0200049C RID: 1180
	[global::Cpp2ILInjected.Token(Token = "0x20006A9")]
	public abstract class RemoteAddress
	{
		// Token: 0x06003364 RID: 13156
		[global::Cpp2ILInjected.Token(Token = "0x60038AA")]
		public abstract string GetIdentifier();

		// Token: 0x06003365 RID: 13157
		[global::Cpp2ILInjected.Token(Token = "0x60038AB")]
		public abstract string GetFriendlyName();

		// Token: 0x06003366 RID: 13158
		[global::Cpp2ILInjected.Token(Token = "0x60038AC")]
		public abstract bool IsLocalHost();

		// Token: 0x06003367 RID: 13159 RVA: 0x0002B301 File Offset: 0x00029501
		[global::Cpp2ILInjected.Token(Token = "0x60038AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x143D530", Offset = "0x143D530", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected RemoteAddress()
		{
			throw null;
		}

		// Token: 0x04006554 RID: 25940
		[global::Cpp2ILInjected.Token(Token = "0x4007956")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public AddressType Type;
	}
}
