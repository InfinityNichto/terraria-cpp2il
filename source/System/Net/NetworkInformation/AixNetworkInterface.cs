using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002AA")]
	internal sealed class AixNetworkInterface : UnixNetworkInterface
	{
		[global::Cpp2ILInjected.Token(Token = "0x60012A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1E240", Offset = "0x1E1E240", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnixNetworkInterface), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		internal AixNetworkInterface(string name, uint ifa_flags, int ifru_mtu)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000EBE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private uint _ifa_flags;

		[global::Cpp2ILInjected.Token(Token = "0x4000EBF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int _ifru_mtu;
	}
}
