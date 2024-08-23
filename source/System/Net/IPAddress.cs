using System;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000D9 RID: 217
	[global::Cpp2ILInjected.Token(Token = "0x200013F")]
	[Serializable]
	public class IPAddress
	{
		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x000041B4 File Offset: 0x000023B4
		[global::Cpp2ILInjected.Token(Token = "0x17000192")]
		private bool IsIPv4
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000790")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE8698", Offset = "0x1EE8698", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x000041B7 File Offset: 0x000023B7
		[global::Cpp2ILInjected.Token(Token = "0x17000193")]
		private bool IsIPv6
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000791")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE86A8", Offset = "0x1EE86A8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x000041BA File Offset: 0x000023BA
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x000041BD File Offset: 0x000023BD
		[global::Cpp2ILInjected.Token(Token = "0x17000194")]
		private uint PrivateAddress
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000792")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE86B8", Offset = "0x1EE86B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000793")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE86C0", Offset = "0x1EE86C0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x000041C0 File Offset: 0x000023C0
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x000041C3 File Offset: 0x000023C3
		[global::Cpp2ILInjected.Token(Token = "0x17000195")]
		private uint PrivateScopeId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000794")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE86D0", Offset = "0x1EE86D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000795")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE86D8", Offset = "0x1EE86D8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000041C6 File Offset: 0x000023C6
		[global::Cpp2ILInjected.Token(Token = "0x6000796")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE86E8", Offset = "0x1EE86E8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress.ReadOnlyIPAddress), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = "MapToIPv4", ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddressParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAddress), Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPv6AddressFormatter), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AixNetworkInterfaceAPI), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LinuxNetworkInterfaceAPI), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MacOsNetworkInterfaceAPI), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public IPAddress(long newAddress)
		{
			throw null;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x000041C9 File Offset: 0x000023C9
		[global::Cpp2ILInjected.Token(Token = "0x6000797")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE8768", Offset = "0x1EE8768", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAddress), Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AixNetworkInterfaceAPI), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LinuxNetworkInterfaceAPI), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MacOsNetworkInterfaceAPI), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<byte>),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "ThrowAddressNullException", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public IPAddress(byte[] address, long scopeid)
		{
			throw null;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x000041CC File Offset: 0x000023CC
		[global::Cpp2ILInjected.Token(Token = "0x6000798")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE8830", Offset = "0x1EE8830", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public IPAddress(ReadOnlySpan<byte> address, long scopeid)
		{
			throw null;
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x000041CF File Offset: 0x000023CF
		[global::Cpp2ILInjected.Token(Token = "0x6000799")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE897C", Offset = "0x1EE897C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddressParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal unsafe IPAddress(ushort* numbers, int numbersLength, uint scopeid)
		{
			throw null;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x000041D2 File Offset: 0x000023D2
		[global::Cpp2ILInjected.Token(Token = "0x600079A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE8A1C", Offset = "0x1EE8A1C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private IPAddress(ushort[] numbers, uint scopeid)
		{
			throw null;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x000041D5 File Offset: 0x000023D5
		[global::Cpp2ILInjected.Token(Token = "0x600079B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE8A50", Offset = "0x1EE8A50", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "ThrowAddressNullException", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public IPAddress(byte[] address)
		{
			throw null;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x000041D8 File Offset: 0x000023D8
		[global::Cpp2ILInjected.Token(Token = "0x600079C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE8ABC", Offset = "0x1EE8ABC", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public IPAddress(ReadOnlySpan<byte> address)
		{
			throw null;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x000041DB File Offset: 0x000023DB
		[global::Cpp2ILInjected.Token(Token = "0x600079D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE8BD8", Offset = "0x1EE8BD8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal IPAddress(int newAddress)
		{
			throw null;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x000041DE File Offset: 0x000023DE
		[global::Cpp2ILInjected.Token(Token = "0x600079E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE8C08", Offset = "0x1EE8C08", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.TcpAddress", Member = "IsLocalHost", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.Sockets.TcpSocket", Member = "Terraria.Net.Sockets.ISocket.StartListening", MemberParameters = new object[] { "Terraria.Net.Sockets.SocketConnectionAccepted" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServiceNameStore), Member = "BuildServiceNames", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "IsLocal", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "GetHostAddresses", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPAddress[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointManager), Member = "GetEPListener", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(HttpListener),
			typeof(bool)
		}, ReturnType = typeof(EndPointListener))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddressParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool TryParse(string ipString, out IPAddress address)
		{
			throw null;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x000041E1 File Offset: 0x000023E1
		[global::Cpp2ILInjected.Token(Token = "0x600079F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE8E58", Offset = "0x1EE8E58", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddressParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(IPAddress))]
		public static bool TryParse(ReadOnlySpan<char> ipSpan, out IPAddress address)
		{
			throw null;
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000041E4 File Offset: 0x000023E4
		[global::Cpp2ILInjected.Token(Token = "0x60007A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE8E80", Offset = "0x1EE8E80", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string[]),
			typeof(string[])
		}, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "GetHostByAddressFromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndpointPermission), Member = "Resolve", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePoint), Member = "get_HostEntry", ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddressParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static IPAddress Parse(string ipString)
		{
			throw null;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x000041E7 File Offset: 0x000023E7
		[global::Cpp2ILInjected.Token(Token = "0x60007A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE8F18", Offset = "0x1EE8F18", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddressParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(IPAddress))]
		public static IPAddress Parse(ReadOnlySpan<char> ipSpan)
		{
			throw null;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x000041EA File Offset: 0x000023EA
		[global::Cpp2ILInjected.Token(Token = "0x60007A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE8F20", Offset = "0x1EE8F20", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new object[] { typeof(IPAddress) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool TryWriteBytes(Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x000041ED File Offset: 0x000023ED
		[global::Cpp2ILInjected.Token(Token = "0x60007A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE8FF8", Offset = "0x1EE8FF8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		private void WriteIPv6Bytes(Span<byte> destination)
		{
			throw null;
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x000041F0 File Offset: 0x000023F0
		[global::Cpp2ILInjected.Token(Token = "0x60007A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE9030", Offset = "0x1EE9030", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		private void WriteIPv4Bytes(Span<byte> destination)
		{
			throw null;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000041F3 File Offset: 0x000023F3
		[global::Cpp2ILInjected.Token(Token = "0x60007A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE903C", Offset = "0x1EE903C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "FormatAddress", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new object[] { typeof(IPAddress) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnixIPInterfaceProperties), Member = "get_UnicastAddresses", ReturnType = typeof(UnicastIPAddressInformationCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public byte[] GetAddressBytes()
		{
			throw null;
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x000041F6 File Offset: 0x000023F6
		[global::Cpp2ILInjected.Token(Token = "0x17000196")]
		public AddressFamily AddressFamily
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE9108", Offset = "0x1EE9108", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "GetIPV6AddressFromIPV4", MemberParameters = new object[]
			{
				typeof(string),
				typeof(ref string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Netplay", Member = "GetLocalIPAddress", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.TcpAddress", Member = "IsLocalHost", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new object[] { typeof(IPAddress) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string[]),
				typeof(string[])
			}, ReturnType = typeof(IPHostEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(HttpListener),
				typeof(IPAddress),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnixIPInterfaceProperties), Member = "get_UnicastAddresses", ReturnType = typeof(UnicastIPAddressInformationCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UdpClient), Member = "IsBroadcast", MemberParameters = new object[] { typeof(IPAddress) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x000041F9 File Offset: 0x000023F9
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x000041FC File Offset: 0x000023FC
		[global::Cpp2ILInjected.Token(Token = "0x17000197")]
		public long ScopeId
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE9120", Offset = "0x1EE9120", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new object[] { typeof(IPAddress) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60007A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE9170", Offset = "0x1EE9170", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x000041FF File Offset: 0x000023FF
		[global::Cpp2ILInjected.Token(Token = "0x60007A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE9204", Offset = "0x1EE9204", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddressParser), Member = "IPv6AddressToStringHelper", MemberParameters = new object[]
		{
			typeof(ushort[]),
			typeof(uint)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddressParser), Member = "IPv4AddressToStringHelper", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(char*)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public unsafe override string ToString()
		{
			throw null;
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00004202 File Offset: 0x00002402
		[global::Cpp2ILInjected.Token(Token = "0x60007AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE9310", Offset = "0x1EE9310", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddressParser), Member = "IPv4AddressToString", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		public bool TryFormat(Span<char> destination, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00004205 File Offset: 0x00002405
		[global::Cpp2ILInjected.Token(Token = "0x60007AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE94B8", Offset = "0x1EE94B8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = "NetworkToHostOrder", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static long HostToNetworkOrder(long host)
		{
			throw null;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00004208 File Offset: 0x00002408
		[global::Cpp2ILInjected.Token(Token = "0x60007AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE952C", Offset = "0x1EE952C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = "NetworkToHostOrder", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int HostToNetworkOrder(int host)
		{
			throw null;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0000420B File Offset: 0x0000240B
		[global::Cpp2ILInjected.Token(Token = "0x60007AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE9594", Offset = "0x1EE9594", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = "NetworkToHostOrder", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static short HostToNetworkOrder(short host)
		{
			throw null;
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0000420E File Offset: 0x0000240E
		[global::Cpp2ILInjected.Token(Token = "0x60007AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE9600", Offset = "0x1EE9600", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "HostToNetworkOrder", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static long NetworkToHostOrder(long network)
		{
			throw null;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00004211 File Offset: 0x00002411
		[global::Cpp2ILInjected.Token(Token = "0x60007AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE9654", Offset = "0x1EE9654", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "HostToNetworkOrder", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int NetworkToHostOrder(int network)
		{
			throw null;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00004214 File Offset: 0x00002414
		[global::Cpp2ILInjected.Token(Token = "0x60007B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE96A8", Offset = "0x1EE96A8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "HostToNetworkOrder", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static short NetworkToHostOrder(short network)
		{
			throw null;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00004217 File Offset: 0x00002417
		[global::Cpp2ILInjected.Token(Token = "0x60007B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE96FC", Offset = "0x1EE96FC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Client", Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.TcpAddress", Member = "IsLocalHost", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "IsLocal", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "ThrowAddressNullException", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static bool IsLoopback(IPAddress address)
		{
			throw null;
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x0000421A File Offset: 0x0000241A
		[global::Cpp2ILInjected.Token(Token = "0x17000198")]
		public bool IsIPv6Multicast
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE97BC", Offset = "0x1EE97BC", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnixIPInterfaceProperties), Member = "get_UnicastAddresses", ReturnType = typeof(UnicastIPAddressInformationCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x0000421D File Offset: 0x0000241D
		[global::Cpp2ILInjected.Token(Token = "0x17000199")]
		public bool IsIPv6LinkLocal
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE97DC", Offset = "0x1EE97DC", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x00004220 File Offset: 0x00002420
		[global::Cpp2ILInjected.Token(Token = "0x1700019A")]
		public bool IsIPv6SiteLocal
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE9804", Offset = "0x1EE9804", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00004223 File Offset: 0x00002423
		[global::Cpp2ILInjected.Token(Token = "0x1700019B")]
		public bool IsIPv6Teredo
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE982C", Offset = "0x1EE982C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00004226 File Offset: 0x00002426
		[global::Cpp2ILInjected.Token(Token = "0x1700019C")]
		public bool IsIPv4MappedToIPv6
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE985C", Offset = "0x1EE985C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x00004229 File Offset: 0x00002429
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x0000422C File Offset: 0x0000242C
		[Obsolete("This property has been deprecated. It is address family dependent. Please use IPAddress.Equals method to perform comparisons. https://go.microsoft.com/fwlink/?linkid=14202")]
		[global::Cpp2ILInjected.Token(Token = "0x1700019D")]
		public long Address
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE9898", Offset = "0x1EE9898", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60007B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE98E8", Offset = "0x1EE98E8", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", MemberParameters = new object[] { typeof(SocketError) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0000422F File Offset: 0x0000242F
		[global::Cpp2ILInjected.Token(Token = "0x60007B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE9994", Offset = "0x1EE9994", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NclUtilities), Member = "IsAddressLocal", MemberParameters = new object[] { typeof(IPAddress) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool Equals(object comparandObj, bool compareScopeId)
		{
			throw null;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00004232 File Offset: 0x00002432
		[global::Cpp2ILInjected.Token(Token = "0x60007BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE9AA0", Offset = "0x1EE9AA0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "Equals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		public override bool Equals(object comparand)
		{
			throw null;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00004235 File Offset: 0x00002435
		[global::Cpp2ILInjected.Token(Token = "0x60007BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE9AA8", Offset = "0x1EE9AA8", Length = "0x468")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryMarshal), Member = "GetReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.ReadOnlySpan`1<T>" }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlySpan<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "TryWriteBytes", MemberParameters = new object[]
		{
			typeof(Span<byte>),
			typeof(uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Span<>), Member = "op_Implicit", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Marvin", Member = "ComputeHash32", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(int),
			typeof(ulong)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00004238 File Offset: 0x00002438
		[global::Cpp2ILInjected.Token(Token = "0x60007BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE9F10", Offset = "0x1EE9F10", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "RemapIPEndPoint", MemberParameters = new object[] { typeof(IPEndPoint) }, ReturnType = typeof(IPEndPoint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IPAddress MapToIPv6()
		{
			throw null;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0000423B File Offset: 0x0000243B
		[global::Cpp2ILInjected.Token(Token = "0x60007BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE9FC4", Offset = "0x1EE9FC4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IPAddress MapToIPv4()
		{
			throw null;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0000423E File Offset: 0x0000243E
		[global::Cpp2ILInjected.Token(Token = "0x60007BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE87E4", Offset = "0x1EE87E4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = "IsLoopback", MemberParameters = new object[] { typeof(IPAddress) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static byte[] ThrowAddressNullException()
		{
			throw null;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00004241 File Offset: 0x00002441
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60007BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEA038", Offset = "0x1EEA038", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress.ReadOnlyIPAddress), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		static IPAddress()
		{
			throw null;
		}

		// Token: 0x040004B3 RID: 1203
		[global::Cpp2ILInjected.Token(Token = "0x4000639")]
		public static readonly IPAddress Any;

		// Token: 0x040004B4 RID: 1204
		[global::Cpp2ILInjected.Token(Token = "0x400063A")]
		public static readonly IPAddress Loopback;

		// Token: 0x040004B5 RID: 1205
		[global::Cpp2ILInjected.Token(Token = "0x400063B")]
		public static readonly IPAddress Broadcast;

		// Token: 0x040004B6 RID: 1206
		[global::Cpp2ILInjected.Token(Token = "0x400063C")]
		public static readonly IPAddress None;

		// Token: 0x040004B7 RID: 1207
		[global::Cpp2ILInjected.Token(Token = "0x400063D")]
		internal const long LoopbackMask = 255L;

		// Token: 0x040004B8 RID: 1208
		[global::Cpp2ILInjected.Token(Token = "0x400063E")]
		public static readonly IPAddress IPv6Any;

		// Token: 0x040004B9 RID: 1209
		[global::Cpp2ILInjected.Token(Token = "0x400063F")]
		public static readonly IPAddress IPv6Loopback;

		// Token: 0x040004BA RID: 1210
		[global::Cpp2ILInjected.Token(Token = "0x4000640")]
		public static readonly IPAddress IPv6None;

		// Token: 0x040004BB RID: 1211
		[global::Cpp2ILInjected.Token(Token = "0x4000641")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private uint _addressOrScopeId;

		// Token: 0x040004BC RID: 1212
		[global::Cpp2ILInjected.Token(Token = "0x4000642")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly ushort[] _numbers;

		// Token: 0x040004BD RID: 1213
		[global::Cpp2ILInjected.Token(Token = "0x4000643")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string _toString;

		// Token: 0x040004BE RID: 1214
		[global::Cpp2ILInjected.Token(Token = "0x4000644")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _hashCode;

		// Token: 0x040004BF RID: 1215
		[global::Cpp2ILInjected.Token(Token = "0x4000645")]
		internal const int NumberOfLabels = 8;

		// Token: 0x020003CE RID: 974
		[global::Cpp2ILInjected.Token(Token = "0x2000140")]
		private sealed class ReadOnlyIPAddress : IPAddress
		{
			// Token: 0x06001D69 RID: 7529 RVA: 0x00008123 File Offset: 0x00006323
			[global::Cpp2ILInjected.Token(Token = "0x60007C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EEA1B4", Offset = "0x1EEA1B4", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPAddress), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public ReadOnlyIPAddress(long newAddress)
			{
				throw null;
			}
		}
	}
}
