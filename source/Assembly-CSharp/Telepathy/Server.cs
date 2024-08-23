using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.Localization;
using Terraria.Net;
using UnityEngine;

namespace Telepathy
{
	// Token: 0x02000259 RID: 601
	[global::Cpp2ILInjected.Token(Token = "0x2000317")]
	public class Server : Common
	{
		// Token: 0x0600111D RID: 4381 RVA: 0x00024E39 File Offset: 0x00023039
		[global::Cpp2ILInjected.Token(Token = "0x6001274")]
		[global::Cpp2ILInjected.Address(RVA = "0xA79F14", Offset = "0xA79F14", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Server), Member = "Listen", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<, >), Member = "TryGetValue", MemberParameters = new object[] { "TKey", "TValue&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_RemoteEndPoint", ReturnType = typeof(EndPoint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Server), Member = "Disconnect", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private int NextConnectionId(TcpClient newClient)
		{
			throw null;
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600111E RID: 4382 RVA: 0x00024E3C File Offset: 0x0002303C
		[global::Cpp2ILInjected.Token(Token = "0x170001D0")]
		public bool Active
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001275")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7A1A8", Offset = "0xA7A1A8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_IsAlive", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00024E3F File Offset: 0x0002303F
		[global::Cpp2ILInjected.Token(Token = "0x6001276")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7A1BC", Offset = "0xA7A1BC", Length = "0x408")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Server.<>c__DisplayClass9_0), Member = "<Start>b__0", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpListener), Member = "AcceptTcpClient", ReturnType = typeof(TcpClient))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Server), Member = "NextConnectionId", MemberParameters = new object[] { typeof(TcpClient) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Server.ClientToken), Member = ".ctor", MemberParameters = new object[] { typeof(TcpClient) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<, >), Member = "set_Item", MemberParameters = new object[] { "TKey", "TValue" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadStart), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		private void Listen(int port)
		{
			throw null;
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00024E42 File Offset: 0x00023042
		[global::Cpp2ILInjected.Token(Token = "0x6001277")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7A68C", Offset = "0xA7A68C", Length = "0x438")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationHost), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = "Startup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "StartListening", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_IsAlive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpListener), Member = "Create", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(TcpListener))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "set_NoDelay", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "set_SendTimeout", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpListener), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadStart), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "set_Priority", MemberParameters = new object[] { typeof(ThreadPriority) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformUser), Member = "get_CurrentUser", ReturnType = typeof(PlatformUser))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpListener), Member = "Stop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public bool Start(int port)
		{
			throw null;
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00024E45 File Offset: 0x00023045
		[global::Cpp2ILInjected.Token(Token = "0x6001278")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7AACC", Offset = "0xA7AACC", Length = "0x3F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Server), Member = "Stop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<, >), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<KeyValuePair`2<TKey, TValue>>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "GetStream", ReturnType = typeof(NetworkStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<, >), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		private void Cleanup()
		{
			throw null;
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x00024E48 File Offset: 0x00023048
		[global::Cpp2ILInjected.Token(Token = "0x6001279")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7AEBC", Offset = "0xA7AEBC", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationHost), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = "Shutdown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "RunServerCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "StopListening", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "ServerLoop", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_IsAlive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpListener), Member = "Stop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Interrupt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Server), Member = "Cleanup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Stop()
		{
			throw null;
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00024E4B File Offset: 0x0002304B
		[global::Cpp2ILInjected.Token(Token = "0x600127A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7AFDC", Offset = "0xA7AFDC", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationHost), Member = "SendDataFunction", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetManager), Member = "SendToClient", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<, >), Member = "TryGetValue", MemberParameters = new object[] { "TKey", "TValue&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeQueue<>), Member = "Enqueue", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public bool Send(int connectionId, byte[] data, int length)
		{
			throw null;
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00024E4E File Offset: 0x0002304E
		[global::Cpp2ILInjected.Token(Token = "0x600127B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7B210", Offset = "0xA7B210", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationHost), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "AddBan", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "ServerUpdateFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "OnConnectionAccepted", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<, >), Member = "TryGetValue", MemberParameters = new object[] { "TKey", "TValue&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_RemoteEndPoint", ReturnType = typeof(EndPoint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public string GetClientAddress(int connectionId)
		{
			throw null;
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00024E51 File Offset: 0x00023051
		[global::Cpp2ILInjected.Token(Token = "0x600127C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7A09C", Offset = "0xA7A09C", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Server), Member = "NextConnectionId", MemberParameters = new object[] { typeof(TcpClient) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "ServerLoopUpdateFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<, >), Member = "TryGetValue", MemberParameters = new object[] { "TKey", "TValue&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool Disconnect(int connectionId)
		{
			throw null;
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00024E54 File Offset: 0x00023054
		[global::Cpp2ILInjected.Token(Token = "0x600127D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7B300", Offset = "0xA7B300", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationHost), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemoteServer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<, >), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Common), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Server()
		{
			throw null;
		}

		// Token: 0x04001C39 RID: 7225
		[global::Cpp2ILInjected.Token(Token = "0x4002209")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public TcpListener listener;

		// Token: 0x04001C3A RID: 7226
		[global::Cpp2ILInjected.Token(Token = "0x400220A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Thread listenerThread;

		// Token: 0x04001C3B RID: 7227
		[global::Cpp2ILInjected.Token(Token = "0x400220B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private ConcurrentDictionary<int, Server.ClientToken> clients;

		// Token: 0x04001C3C RID: 7228
		[global::Cpp2ILInjected.Token(Token = "0x400220C")]
		private static int counter;

		// Token: 0x0200081D RID: 2077
		[global::Cpp2ILInjected.Token(Token = "0x2000318")]
		private class ClientToken
		{
			// Token: 0x0600492A RID: 18730 RVA: 0x0002EF97 File Offset: 0x0002D197
			[global::Cpp2ILInjected.Token(Token = "0x600127E")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7A5CC", Offset = "0xA7A5CC", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Server), Member = "Listen", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeQueue<>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public ClientToken(TcpClient client)
			{
				throw null;
			}

			// Token: 0x04007D8E RID: 32142
			[global::Cpp2ILInjected.Token(Token = "0x400220D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public TcpClient client;

			// Token: 0x04007D8F RID: 32143
			[global::Cpp2ILInjected.Token(Token = "0x400220E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public SafeQueue<byte[]> sendQueue;

			// Token: 0x04007D90 RID: 32144
			[global::Cpp2ILInjected.Token(Token = "0x400220F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public ManualResetEvent sendPending;
		}

		// Token: 0x0200081E RID: 2078
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000319")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x0600492B RID: 18731 RVA: 0x0002EF9A File Offset: 0x0002D19A
			[global::Cpp2ILInjected.Token(Token = "0x600127F")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7A5C4", Offset = "0xA7A5C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass8_0()
			{
				throw null;
			}

			// Token: 0x0600492C RID: 18732 RVA: 0x0002EF9D File Offset: 0x0002D19D
			[global::Cpp2ILInjected.Token(Token = "0x6001280")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7B39C", Offset = "0xA7B39C", Length = "0x1B0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Common), Member = "SendLoop", MemberParameters = new object[]
			{
				typeof(int),
				typeof(TcpClient),
				typeof(SafeQueue<byte[]>),
				typeof(ManualResetEvent)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			internal void <Listen>b__0()
			{
				throw null;
			}

			// Token: 0x0600492D RID: 18733 RVA: 0x0002EFA0 File Offset: 0x0002D1A0
			[global::Cpp2ILInjected.Token(Token = "0x6001281")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7B54C", Offset = "0xA7B54C", Length = "0x254")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Common), Member = "ReceiveLoop", MemberParameters = new object[]
			{
				typeof(int),
				typeof(TcpClient),
				typeof(ConcurrentQueue<Message>),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<, >), Member = "TryRemove", MemberParameters = new object[] { "TKey", "TValue&" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Interrupt", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
			internal void <Listen>b__1()
			{
				throw null;
			}

			// Token: 0x04007D91 RID: 32145
			[global::Cpp2ILInjected.Token(Token = "0x4002210")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int connectionId;

			// Token: 0x04007D92 RID: 32146
			[global::Cpp2ILInjected.Token(Token = "0x4002211")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public TcpClient client;

			// Token: 0x04007D93 RID: 32147
			[global::Cpp2ILInjected.Token(Token = "0x4002212")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public Server.ClientToken token;

			// Token: 0x04007D94 RID: 32148
			[global::Cpp2ILInjected.Token(Token = "0x4002213")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public Thread sendThread;

			// Token: 0x04007D95 RID: 32149
			[global::Cpp2ILInjected.Token(Token = "0x4002214")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public Server <>4__this;
		}

		// Token: 0x0200081F RID: 2079
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200031A")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x0600492E RID: 18734 RVA: 0x0002EFA3 File Offset: 0x0002D1A3
			[global::Cpp2ILInjected.Token(Token = "0x6001282")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7AAC4", Offset = "0xA7AAC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass9_0()
			{
				throw null;
			}

			// Token: 0x0600492F RID: 18735 RVA: 0x0002EFA6 File Offset: 0x0002D1A6
			[global::Cpp2ILInjected.Token(Token = "0x6001283")]
			[global::Cpp2ILInjected.Address(RVA = "0xA7B7A0", Offset = "0xA7B7A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Server), Member = "Listen", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			internal void <Start>b__0()
			{
				throw null;
			}

			// Token: 0x04007D96 RID: 32150
			[global::Cpp2ILInjected.Token(Token = "0x4002215")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Server <>4__this;

			// Token: 0x04007D97 RID: 32151
			[global::Cpp2ILInjected.Token(Token = "0x4002216")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int port;
		}
	}
}
