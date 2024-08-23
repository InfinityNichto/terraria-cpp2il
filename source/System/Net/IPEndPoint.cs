using System;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Security;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000DB RID: 219
	[global::Cpp2ILInjected.Token(Token = "0x2000142")]
	[Serializable]
	public class IPEndPoint : EndPoint
	{
		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x00004274 File Offset: 0x00002474
		[global::Cpp2ILInjected.Token(Token = "0x1700019E")]
		public override AddressFamily AddressFamily
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EEA968", Offset = "0x1EEA968", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00004277 File Offset: 0x00002477
		[global::Cpp2ILInjected.Token(Token = "0x60007D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEA984", Offset = "0x1EEA984", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketPermissionAttribute), Member = "CreatePermission", ReturnType = typeof(IPermission))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPoint), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public IPEndPoint(long address, int port)
		{
			throw null;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0000427A File Offset: 0x0000247A
		[global::Cpp2ILInjected.Token(Token = "0x60007D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEAA4C", Offset = "0x1EEAA4C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationBroadcast", Member = "BroadcastThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Netplay", Member = "BroadcastThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.TcpAddress", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPEndPoint), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new object[]
		{
			typeof(CommandStream.PipelineEntry),
			typeof(ResponseDescription),
			typeof(bool),
			typeof(ref Stream),
			typeof(ref bool)
		}, ReturnType = typeof(CommandStream.PipelineInstruction))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "CreateFtpListenerSocket", MemberParameters = new object[] { typeof(FtpWebRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocketAddress), Member = "GetIPEndPoint", ReturnType = typeof(IPEndPoint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(HttpListener),
			typeof(IPAddress),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "Connect", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "BeginMConnect", MemberParameters = new object[] { typeof(SocketAsyncResult) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Socket), Member = "RemapIPEndPoint", MemberParameters = new object[] { typeof(IPEndPoint) }, ReturnType = typeof(IPEndPoint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TcpListener), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UdpClient), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(AddressFamily)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPoint), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public IPEndPoint(IPAddress address, int port)
		{
			throw null;
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x0000427D File Offset: 0x0000247D
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x00004280 File Offset: 0x00002480
		[global::Cpp2ILInjected.Token(Token = "0x1700019F")]
		public IPAddress Address
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EEAB04", Offset = "0x1EEAB04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60007D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EEAB0C", Offset = "0x1EEAB0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x00004283 File Offset: 0x00002483
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x00004286 File Offset: 0x00002486
		[global::Cpp2ILInjected.Token(Token = "0x170001A0")]
		public int Port
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EEAB14", Offset = "0x1EEAB14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60007D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EEAB1C", Offset = "0x1EEAB1C", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00004289 File Offset: 0x00002489
		[global::Cpp2ILInjected.Token(Token = "0x60007D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEAB7C", Offset = "0x1EEAB7C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0000428C File Offset: 0x0000248C
		[global::Cpp2ILInjected.Token(Token = "0x60007D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEAC30", Offset = "0x1EEAC30", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override SocketAddress Serialize()
		{
			throw null;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0000428F File Offset: 0x0000248F
		[global::Cpp2ILInjected.Token(Token = "0x60007DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEAC98", Offset = "0x1EEAC98", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAddress), Member = "get_Family", ReturnType = typeof(AddressFamily))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketAddress), Member = "GetIPEndPoint", ReturnType = typeof(IPEndPoint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override EndPoint Create(SocketAddress socketAddress)
		{
			throw null;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00004292 File Offset: 0x00002492
		[global::Cpp2ILInjected.Token(Token = "0x60007DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEAE5C", Offset = "0x1EEAE5C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object comparand)
		{
			throw null;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00004295 File Offset: 0x00002495
		[global::Cpp2ILInjected.Token(Token = "0x60007DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEAF04", Offset = "0x1EEAF04", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00004298 File Offset: 0x00002498
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60007DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EEAF2C", Offset = "0x1EEAF2C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static IPEndPoint()
		{
			throw null;
		}

		// Token: 0x040004C1 RID: 1217
		[global::Cpp2ILInjected.Token(Token = "0x4000647")]
		public const int MinPort = 0;

		// Token: 0x040004C2 RID: 1218
		[global::Cpp2ILInjected.Token(Token = "0x4000648")]
		public const int MaxPort = 65535;

		// Token: 0x040004C3 RID: 1219
		[global::Cpp2ILInjected.Token(Token = "0x4000649")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IPAddress _address;

		// Token: 0x040004C4 RID: 1220
		[global::Cpp2ILInjected.Token(Token = "0x400064A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _port;

		// Token: 0x040004C5 RID: 1221
		[global::Cpp2ILInjected.Token(Token = "0x400064B")]
		internal const int AnyPort = 0;

		// Token: 0x040004C6 RID: 1222
		[global::Cpp2ILInjected.Token(Token = "0x400064C")]
		internal static IPEndPoint Any;

		// Token: 0x040004C7 RID: 1223
		[global::Cpp2ILInjected.Token(Token = "0x400064D")]
		internal static IPEndPoint IPv6Any;
	}
}
