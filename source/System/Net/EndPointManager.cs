using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000191 RID: 401
	[global::Cpp2ILInjected.Token(Token = "0x2000242")]
	internal sealed class EndPointManager
	{
		// Token: 0x06000D0D RID: 3341 RVA: 0x00005366 File Offset: 0x00003566
		[global::Cpp2ILInjected.Token(Token = "0x6000E8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F46FF4", Offset = "0x1F46FF4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private EndPointManager()
		{
			throw null;
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00005369 File Offset: 0x00003569
		[global::Cpp2ILInjected.Token(Token = "0x6000E8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F46FFC", Offset = "0x1F46FFC", Length = "0x6D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerPrefixCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<string>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointManager), Member = "AddPrefixInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointManager), Member = "RemovePrefix", MemberParameters = new object[]
		{
			typeof(string),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 50)]
		public static void AddListener(HttpListener listener)
		{
			throw null;
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x0000536C File Offset: 0x0000356C
		[global::Cpp2ILInjected.Token(Token = "0x6000E8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F479E0", Offset = "0x1F479E0", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerPrefixCollection), Member = "Add", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointManager), Member = "AddPrefixInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void AddPrefix(string prefix, HttpListener listener)
		{
			throw null;
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x0000536F File Offset: 0x0000356F
		[global::Cpp2ILInjected.Token(Token = "0x6000E8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4777C", Offset = "0x1F4777C", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointManager), Member = "AddListener", MemberParameters = new object[] { typeof(HttpListener) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointManager), Member = "AddPrefix", MemberParameters = new object[]
		{
			typeof(string),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListenerPrefix), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointManager), Member = "GetEPListener", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(HttpListener),
			typeof(bool)
		}, ReturnType = typeof(EndPointListener))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointListener), Member = "AddPrefix", MemberParameters = new object[]
		{
			typeof(ListenerPrefix),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static void AddPrefixInternal(string p, HttpListener listener)
		{
			throw null;
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00005372 File Offset: 0x00003572
		[global::Cpp2ILInjected.Token(Token = "0x6000E8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F47AFC", Offset = "0x1F47AFC", Length = "0x3CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointManager), Member = "AddPrefixInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointManager), Member = "RemovePrefixInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref IPAddress)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "GetHostByName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(HttpListener),
			typeof(IPAddress),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		private static EndPointListener GetEPListener(string host, int port, HttpListener listener, bool secure)
		{
			throw null;
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00005375 File Offset: 0x00003575
		[global::Cpp2ILInjected.Token(Token = "0x6000E90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4630C", Offset = "0x1F4630C", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointListener), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void RemoveEndPoint(EndPointListener epl, IPEndPoint ep)
		{
			throw null;
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00005378 File Offset: 0x00003578
		[global::Cpp2ILInjected.Token(Token = "0x6000E91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F47EC8", Offset = "0x1F47EC8", Length = "0x354")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerPrefixCollection), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerPrefixCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<string>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointManager), Member = "RemovePrefixInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public static void RemoveListener(HttpListener listener)
		{
			throw null;
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x0000537B File Offset: 0x0000357B
		[global::Cpp2ILInjected.Token(Token = "0x6000E92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F478C4", Offset = "0x1F478C4", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointManager), Member = "AddListener", MemberParameters = new object[] { typeof(HttpListener) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerPrefixCollection), Member = "Remove", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointManager), Member = "RemovePrefixInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void RemovePrefix(string prefix, HttpListener listener)
		{
			throw null;
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x0000537E File Offset: 0x0000357E
		[global::Cpp2ILInjected.Token(Token = "0x6000E93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4821C", Offset = "0x1F4821C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointManager), Member = "RemoveListener", MemberParameters = new object[] { typeof(HttpListener) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointManager), Member = "RemovePrefix", MemberParameters = new object[]
		{
			typeof(string),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListenerPrefix), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointManager), Member = "GetEPListener", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(HttpListener),
			typeof(bool)
		}, ReturnType = typeof(EndPointListener))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointListener), Member = "RemovePrefix", MemberParameters = new object[]
		{
			typeof(ListenerPrefix),
			typeof(HttpListener)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void RemovePrefixInternal(string prefix, HttpListener listener)
		{
			throw null;
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00005381 File Offset: 0x00003581
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000E94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F48324", Offset = "0x1F48324", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static EndPointManager()
		{
			throw null;
		}

		// Token: 0x04000939 RID: 2361
		[global::Cpp2ILInjected.Token(Token = "0x4000BE1")]
		private static Hashtable ip_to_endpoints;
	}
}
