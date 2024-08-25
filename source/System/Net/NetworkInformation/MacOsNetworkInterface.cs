using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002BD")]
	internal sealed class MacOsNetworkInterface : UnixNetworkInterface
	{
		[global::Cpp2ILInjected.Token(Token = "0x60012B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E20364", Offset = "0x1E20364", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnixNetworkInterface), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		internal MacOsNetworkInterface(string name, uint ifa_flags)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E20388", Offset = "0x1E20388", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MacOsIPInterfaceProperties), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MacOsNetworkInterface),
			typeof(List<IPAddress>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IPInterfaceProperties GetIPProperties()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700044F")]
		public override OperationalStatus OperationalStatus
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E203F4", Offset = "0x1E203F4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000F01")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private uint _ifa_flags;
	}
}
