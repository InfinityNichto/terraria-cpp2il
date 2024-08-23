using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Net
{
	// Token: 0x0200049D RID: 1181
	[global::Cpp2ILInjected.Token(Token = "0x20006AA")]
	public class TcpAddress : RemoteAddress
	{
		// Token: 0x06003368 RID: 13160 RVA: 0x0002B304 File Offset: 0x00029504
		[global::Cpp2ILInjected.Token(Token = "0x60038AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x143D538", Offset = "0x143D538", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "TcpLocalClientLoop", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TcpAddress(IPAddress address, int port)
		{
			throw null;
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x0002B307 File Offset: 0x00029507
		[global::Cpp2ILInjected.Token(Token = "0x60038AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x143D56C", Offset = "0x143D56C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "StartTcpClient", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TcpAddress(string host, int port)
		{
			throw null;
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x0002B30A File Offset: 0x0002950A
		[global::Cpp2ILInjected.Token(Token = "0x60038B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x143D5A0", Offset = "0x143D5A0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string GetIdentifier()
		{
			throw null;
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x0002B30D File Offset: 0x0002950D
		[global::Cpp2ILInjected.Token(Token = "0x60038B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x143D5B0", Offset = "0x143D5B0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsLocalHost()
		{
			throw null;
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x0002B310 File Offset: 0x00029510
		[global::Cpp2ILInjected.Token(Token = "0x60038B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x143D61C", Offset = "0x143D61C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x0002B313 File Offset: 0x00029513
		[global::Cpp2ILInjected.Token(Token = "0x60038B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x143D70C", Offset = "0x143D70C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string GetFriendlyName()
		{
			throw null;
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x0002B316 File Offset: 0x00029516
		[global::Cpp2ILInjected.Token(Token = "0x60038B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x143D718", Offset = "0x143D718", Length = "0x4F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationFinder), Member = "BroadcastRecieveThread", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationHost), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "ServerUpdateFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref IPAddress)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "IsLoopback", MemberParameters = new object[] { typeof(IPAddress) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkInterface), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public static bool IsLocalHost(string addressString)
		{
			throw null;
		}

		// Token: 0x04006555 RID: 25941
		[global::Cpp2ILInjected.Token(Token = "0x4007957")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public string Host;

		// Token: 0x04006556 RID: 25942
		[global::Cpp2ILInjected.Token(Token = "0x4007958")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public IPAddress Address;

		// Token: 0x04006557 RID: 25943
		[global::Cpp2ILInjected.Token(Token = "0x4007959")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int Port;
	}
}
