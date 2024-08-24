using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.NetworkInformation;
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
	// Token: 0x02000253 RID: 595
	[global::Cpp2ILInjected.Token(Token = "0x2000310")]
	public class Client : Common
	{
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x00024DEB File Offset: 0x00022FEB
		[global::Cpp2ILInjected.Token(Token = "0x170001CC")]
		public bool Connected
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001258")]
			[global::Cpp2ILInjected.Address(RVA = "0xA77A5C", Offset = "0xA77A5C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "TcpLocalClientLoop", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "TcpClientLoop", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "ClientUpdateFrame", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "ClientLoopFrameUpdate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x00024DEE File Offset: 0x00022FEE
		[global::Cpp2ILInjected.Token(Token = "0x170001CD")]
		public bool Connecting
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001259")]
			[global::Cpp2ILInjected.Address(RVA = "0xA77A84", Offset = "0xA77A84", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "TcpLocalClientLoop", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "TcpClientLoop", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x00024DF1 File Offset: 0x00022FF1
		[global::Cpp2ILInjected.Token(Token = "0x600125A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA77A9C", Offset = "0xA77A9C", Length = "0x358")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Client), Member = "ReceiveThreadFunction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char),
			typeof(StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private bool GetIPV6AddressFromIPV4(string hostname, out string ipv6Address)
		{
			throw null;
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x00024DF4 File Offset: 0x00022FF4
		[global::Cpp2ILInjected.Token(Token = "0x600125B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA77DF4", Offset = "0xA77DF4", Length = "0x770")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Client.<>c__DisplayClass13_0), Member = "<Connect>b__0", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "set_NoDelay", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "set_SendTimeout", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadStart), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Common), Member = "ReceiveLoop", MemberParameters = new object[]
		{
			typeof(int),
			typeof(TcpClient),
			typeof(ConcurrentQueue<Message>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Interrupt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SocketException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Client), Member = "GetIPV6AddressFromIPV4", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = ".ctor", MemberParameters = new object[] { typeof(AddressFamily) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "set_DualMode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<>), Member = "Enqueue", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 79)]
		private void ReceiveThreadFunction(string ip, int port)
		{
			throw null;
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x00024DF7 File Offset: 0x00022FF7
		[global::Cpp2ILInjected.Token(Token = "0x600125C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA78A0C", Offset = "0xA78A0C", Length = "0x45C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkInterface), Member = "GetAllNetworkInterfaces", ReturnType = typeof(NetworkInterface[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "IsLoopback", MemberParameters = new object[] { typeof(IPAddress) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private IPAddress GetIPAddress()
		{
			throw null;
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00024DFA File Offset: 0x00022FFA
		[global::Cpp2ILInjected.Token(Token = "0x600125D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA78E68", Offset = "0xA78E68", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationClient), Member = "Connect", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = "Connect", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "TcpLocalClientLoop", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "TcpClientLoop", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentQueue<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeQueue<>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadStart), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new object[] { typeof(ThreadStart) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public void Connect(string ip, int port)
		{
			throw null;
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00024DFD File Offset: 0x00022FFD
		[global::Cpp2ILInjected.Token(Token = "0x600125E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7402C", Offset = "0xA7402C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIErrorScreen), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINetPlayStatusMenu), Member = "Quit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationClient), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = "Shutdown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "OnApplicationQuit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "EnsureLocalPlayerIsPresent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "InnerClientLoop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Interrupt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Join", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeQueue<>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpClient), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Disconnect()
		{
			throw null;
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x00024E00 File Offset: 0x00023000
		[global::Cpp2ILInjected.Token(Token = "0x600125F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA790B0", Offset = "0xA790B0", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationClient), Member = "SendDataFunction", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public bool Send(byte[] data, int length)
		{
			throw null;
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x00024E03 File Offset: 0x00023003
		[global::Cpp2ILInjected.Token(Token = "0x6001260")]
		[global::Cpp2ILInjected.Address(RVA = "0xA79288", Offset = "0xA79288", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationClient), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemoteConnection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeQueue<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public Client()
		{
			throw null;
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x00024E06 File Offset: 0x00023006
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6001261")]
		[global::Cpp2ILInjected.Address(RVA = "0xA793EC", Offset = "0xA793EC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void <ReceiveThreadFunction>b__11_0()
		{
			throw null;
		}

		// Token: 0x04001C21 RID: 7201
		[global::Cpp2ILInjected.Token(Token = "0x40021EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public TcpClient client;

		// Token: 0x04001C22 RID: 7202
		[global::Cpp2ILInjected.Token(Token = "0x40021EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Thread receiveThread;

		// Token: 0x04001C23 RID: 7203
		[global::Cpp2ILInjected.Token(Token = "0x40021F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Thread sendThread;

		// Token: 0x04001C24 RID: 7204
		[global::Cpp2ILInjected.Token(Token = "0x40021F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool _Connecting;

		// Token: 0x04001C25 RID: 7205
		[global::Cpp2ILInjected.Token(Token = "0x40021F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private SafeQueue<byte[]> sendQueue;

		// Token: 0x04001C26 RID: 7206
		[global::Cpp2ILInjected.Token(Token = "0x40021F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private ManualResetEvent sendPending;

		// Token: 0x0200081C RID: 2076
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000311")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06004928 RID: 18728 RVA: 0x0002EF91 File Offset: 0x0002D191
			[global::Cpp2ILInjected.Token(Token = "0x6001262")]
			[global::Cpp2ILInjected.Address(RVA = "0xA790A8", Offset = "0xA790A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass13_0()
			{
				throw null;
			}

			// Token: 0x06004929 RID: 18729 RVA: 0x0002EF94 File Offset: 0x0002D194
			[global::Cpp2ILInjected.Token(Token = "0x6001263")]
			[global::Cpp2ILInjected.Address(RVA = "0xA797A4", Offset = "0xA797A4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Client), Member = "ReceiveThreadFunction", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(void))]
			internal void <Connect>b__0()
			{
				throw null;
			}

			// Token: 0x04007D8B RID: 32139
			[global::Cpp2ILInjected.Token(Token = "0x40021F4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Client <>4__this;

			// Token: 0x04007D8C RID: 32140
			[global::Cpp2ILInjected.Token(Token = "0x40021F5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public string ip;

			// Token: 0x04007D8D RID: 32141
			[global::Cpp2ILInjected.Token(Token = "0x40021F6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public int port;
		}
	}
}
