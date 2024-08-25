using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x20002C9")]
	internal abstract class UnixNetworkInterface : NetworkInterface
	{
		[global::Cpp2ILInjected.Token(Token = "0x60012D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1E32C", Offset = "0x1E1E32C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AixNetworkInterfaceAPI), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AixNetworkInterface), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(uint),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LinuxNetworkInterface), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MacOsNetworkInterfaceAPI), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MacOsNetworkInterface), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal UnixNetworkInterface(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1E268", Offset = "0x1E1E268", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AixNetworkInterfaceAPI), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LinuxNetworkInterfaceAPI), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MacOsNetworkInterfaceAPI), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void AddAddress(IPAddress address)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1E310", Offset = "0x1E1E310", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetLinkLayerInfo(int index, byte[] macAddress, NetworkInterfaceType type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000454")]
		public override string Description
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E20CE8", Offset = "0x1E20CE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000455")]
		public override NetworkInterfaceType NetworkInterfaceType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E20CF0", Offset = "0x1E20CF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000F16")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected IPInterfaceProperties ipproperties;

		[global::Cpp2ILInjected.Token(Token = "0x4000F17")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string name;

		[global::Cpp2ILInjected.Token(Token = "0x4000F18")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected List<IPAddress> addresses;

		[global::Cpp2ILInjected.Token(Token = "0x4000F19")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] macAddress;

		[global::Cpp2ILInjected.Token(Token = "0x4000F1A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private NetworkInterfaceType type;
	}
}
