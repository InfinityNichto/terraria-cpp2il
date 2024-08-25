using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002BA")]
	internal class LinuxUnicastIPAddressInformation : UnicastIPAddressInformation
	{
		[global::Cpp2ILInjected.Token(Token = "0x60012B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1F78C", Offset = "0x1E1F78C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LinuxUnicastIPAddressInformation(IPAddress address)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000EFF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IPAddress address;
	}
}
