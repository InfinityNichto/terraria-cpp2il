﻿using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000119 RID: 281
	[global::Cpp2ILInjected.Token(Token = "0x20001A0")]
	internal static class NclUtilities
	{
		// Token: 0x06000967 RID: 2407 RVA: 0x000048D4 File Offset: 0x00002AD4
		[global::Cpp2ILInjected.Token(Token = "0x6000A76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0E300", Offset = "0x1F0E300", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "GetAvailableThreads", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		internal static bool IsThreadPoolLow()
		{
			throw null;
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x000048D7 File Offset: 0x00002AD7
		[global::Cpp2ILInjected.Token(Token = "0x1700021C")]
		internal static bool HasShutdownStarted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A77")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0E32C", Offset = "0x1F0E32C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_HasShutdownStarted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AppDomain), Member = "get_CurrentDomain", ReturnType = typeof(AppDomain))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AppDomain), Member = "IsFinalizingForUnload", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x000048DA File Offset: 0x00002ADA
		[global::Cpp2ILInjected.Token(Token = "0x6000A78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0E35C", Offset = "0x1F0E35C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static bool IsCredentialFailure(SecurityStatus error)
		{
			throw null;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x000048DD File Offset: 0x00002ADD
		[global::Cpp2ILInjected.Token(Token = "0x6000A79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0E3B4", Offset = "0x1F0E3B4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static bool IsClientFault(SecurityStatus error)
		{
			throw null;
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x000048E0 File Offset: 0x00002AE0
		[global::Cpp2ILInjected.Token(Token = "0x1700021D")]
		internal static ContextCallback ContextRelativeDemandCallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A7A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0E410", Offset = "0x1F0E410", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextCallback), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000048E3 File Offset: 0x00002AE3
		[global::Cpp2ILInjected.Token(Token = "0x6000A7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0E4C8", Offset = "0x1F0E4C8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void DemandCallback(object state)
		{
			throw null;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x000048E6 File Offset: 0x00002AE6
		[global::Cpp2ILInjected.Token(Token = "0x6000A7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0E4CC", Offset = "0x1F0E4CC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static bool GuessWhetherHostIsLoopback(string host)
		{
			throw null;
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x000048E9 File Offset: 0x00002AE9
		[global::Cpp2ILInjected.Token(Token = "0x6000A7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0E55C", Offset = "0x1F0E55C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.TimerThread.TimerNode", Member = "Fire", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimerThread), Member = "ThreadProc", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static bool IsFatal(Exception exception)
		{
			throw null;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000048EC File Offset: 0x00002AEC
		[global::Cpp2ILInjected.Token(Token = "0x6000A7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0E61C", Offset = "0x1F0E61C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "IsLocal", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NclUtilities), Member = "get_LocalAddresses", ReturnType = typeof(IPAddress[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "Equals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		internal static bool IsAddressLocal(IPAddress ipAddress)
		{
			throw null;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x000048EF File Offset: 0x00002AEF
		[global::Cpp2ILInjected.Token(Token = "0x6000A7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0EAEC", Offset = "0x1F0EAEC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NclUtilities), Member = "get_LocalAddresses", ReturnType = typeof(IPAddress[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "GetHostName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "GetHostByName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static IPHostEntry GetLocalHost()
		{
			throw null;
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x000048F2 File Offset: 0x00002AF2
		[global::Cpp2ILInjected.Token(Token = "0x1700021E")]
		internal static IPAddress[] LocalAddresses
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A80")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0E68C", Offset = "0x1F0E68C", Length = "0x460")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NclUtilities), Member = "IsAddressLocal", MemberParameters = new object[] { typeof(IPAddress) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NclUtilities), Member = "get_LocalAddressesLock", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NclUtilities), Member = "GetLocalHost", ReturnType = typeof(IPHostEntry))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x000048F5 File Offset: 0x00002AF5
		[global::Cpp2ILInjected.Token(Token = "0x1700021F")]
		private static object LocalAddressesLock
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A81")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0EB44", Offset = "0x1F0EB44", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NclUtilities), Member = "get_LocalAddresses", ReturnType = typeof(IPAddress[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref object),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000639 RID: 1593
		[global::Cpp2ILInjected.Token(Token = "0x4000852")]
		private static ContextCallback s_ContextRelativeDemandCallback;

		// Token: 0x0400063A RID: 1594
		[global::Cpp2ILInjected.Token(Token = "0x4000853")]
		private static IPAddress[] _LocalAddresses;

		// Token: 0x0400063B RID: 1595
		[global::Cpp2ILInjected.Token(Token = "0x4000854")]
		private static object _LocalAddressesLock;

		// Token: 0x0400063C RID: 1596
		[global::Cpp2ILInjected.Token(Token = "0x4000855")]
		private const int HostNameBufferLength = 256;

		// Token: 0x0400063D RID: 1597
		[global::Cpp2ILInjected.Token(Token = "0x4000856")]
		internal static string _LocalDomainName;
	}
}