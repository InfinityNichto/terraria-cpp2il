using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001C8 RID: 456
	[global::Cpp2ILInjected.Token(Token = "0x20002AA")]
	internal sealed class AixNetworkInterface : UnixNetworkInterface
	{
		// Token: 0x060010AB RID: 4267 RVA: 0x00005E04 File Offset: 0x00004004
		[global::Cpp2ILInjected.Token(Token = "0x60012A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1E240", Offset = "0x1E1E240", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnixNetworkInterface), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		internal AixNetworkInterface(string name, uint ifa_flags, int ifru_mtu)
		{
			throw null;
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00005E07 File Offset: 0x00004007
		[global::Cpp2ILInjected.Token(Token = "0x60012A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1E3B4", Offset = "0x1E1E3B4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AixIPInterfaceProperties), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AixNetworkInterface),
			typeof(List<IPAddress>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IPInterfaceProperties GetIPProperties()
		{
			throw null;
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x00005E0A File Offset: 0x0000400A
		[global::Cpp2ILInjected.Token(Token = "0x1700044B")]
		public override OperationalStatus OperationalStatus
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1E430", Offset = "0x1E1E430", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000AED RID: 2797
		[global::Cpp2ILInjected.Token(Token = "0x4000EBE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private uint _ifa_flags;

		// Token: 0x04000AEE RID: 2798
		[global::Cpp2ILInjected.Token(Token = "0x4000EBF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int _ifru_mtu;
	}
}
