using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001D8 RID: 472
	[global::Cpp2ILInjected.Token(Token = "0x20002BA")]
	internal class LinuxUnicastIPAddressInformation : UnicastIPAddressInformation
	{
		// Token: 0x060010BA RID: 4282 RVA: 0x00005E31 File Offset: 0x00004031
		[global::Cpp2ILInjected.Token(Token = "0x60012B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1F78C", Offset = "0x1E1F78C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LinuxUnicastIPAddressInformation(IPAddress address)
		{
			throw null;
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x00005E34 File Offset: 0x00004034
		[global::Cpp2ILInjected.Token(Token = "0x1700044E")]
		public override IPAddress Address
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1F7B4", Offset = "0x1E1F7B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000B2E RID: 2862
		[global::Cpp2ILInjected.Token(Token = "0x4000EFF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IPAddress address;
	}
}
