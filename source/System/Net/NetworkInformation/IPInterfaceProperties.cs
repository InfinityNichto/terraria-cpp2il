using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001BE RID: 446
	[global::Cpp2ILInjected.Token(Token = "0x20002A0")]
	public abstract class IPInterfaceProperties
	{
		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x0600108A RID: 4234
		[global::Cpp2ILInjected.Token(Token = "0x17000444")]
		public abstract UnicastIPAddressInformationCollection UnicastAddresses
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001283")]
			get;
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00005DB6 File Offset: 0x00003FB6
		[global::Cpp2ILInjected.Token(Token = "0x6001284")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1C8B8", Offset = "0x1E1C8B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected IPInterfaceProperties()
		{
			throw null;
		}
	}
}
