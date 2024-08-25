using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002C7")]
	internal abstract class UnixIPInterfaceProperties : IPInterfaceProperties
	{
		[global::Cpp2ILInjected.Token(Token = "0x60012CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1CF1C", Offset = "0x1E1CF1C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public UnixIPInterfaceProperties(UnixNetworkInterface iface, List<IPAddress> addresses)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000453")]
		public override UnicastIPAddressInformationCollection UnicastAddresses
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E20A00", Offset = "0x1E20A00", Length = "0x220")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnicastIPAddressInformationCollection), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "get_IsIPv6Multicast", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnicastIPAddressInformationCollection), Member = "InternalAdd", MemberParameters = new object[] { typeof(UnicastIPAddressInformation) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "GetAddressBytes", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			get
			{
				throw null;
			}
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60012CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E20C20", Offset = "0x1E20C20", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static UnixIPInterfaceProperties()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000F12")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected UnixNetworkInterface iface;

		[global::Cpp2ILInjected.Token(Token = "0x4000F13")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<IPAddress> addresses;

		[global::Cpp2ILInjected.Token(Token = "0x4000F14")]
		private static Regex ns;

		[global::Cpp2ILInjected.Token(Token = "0x4000F15")]
		private static Regex search;
	}
}
