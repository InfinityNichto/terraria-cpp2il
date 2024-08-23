using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono;
using Mono.Security.Cryptography;

namespace System
{
	// Token: 0x02000123 RID: 291
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000164")]
	public static class Environment
	{
		// Token: 0x06000D89 RID: 3465 RVA: 0x00016BD1 File Offset: 0x00014DD1
		[global::Cpp2ILInjected.Token(Token = "0x6000E67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7516C", Offset = "0x1C7516C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 394)]
		internal static string GetResourceString(string key)
		{
			throw null;
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00016BD4 File Offset: 0x00014DD4
		[global::Cpp2ILInjected.Token(Token = "0x6000E68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C76EB4", Offset = "0x1C76EB4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 120)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static string GetResourceString(string key, params object[] values)
		{
			throw null;
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00016BD7 File Offset: 0x00014DD7
		[global::Cpp2ILInjected.Token(Token = "0x6000E69")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C78848", Offset = "0x1C78848", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.Encoding), Member = "get_EncodingName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static string GetResourceStringEncodingName(int codePage)
		{
			throw null;
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x00016BDA File Offset: 0x00014DDA
		[global::Cpp2ILInjected.Token(Token = "0x17000143")]
		public static string CurrentDirectory
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E6A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C789C4", Offset = "0x1C789C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Directory), Member = "GetCurrentDirectory", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Directory), Member = "InsecureGetCurrentDirectory", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x00016BDD File Offset: 0x00014DDD
		[global::Cpp2ILInjected.Token(Token = "0x17000144")]
		public static int CurrentManagedThreadId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E6B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C789CC", Offset = "0x1C789CC", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 37)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentThread", ReturnType = typeof(global::System.Threading.Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000D8E RID: 3470
		[global::Cpp2ILInjected.Token(Token = "0x17000145")]
		public static extern bool HasShutdownStarted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E6C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C789E4", Offset = "0x1C789E4", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Gen2GcCallback), Member = "Finalize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ThreadPoolWorkQueueThreadLocals), Member = "Finalize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskExceptionHolder), Member = "Finalize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NclUtilities", Member = "get_HasShutdownStarted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000D8F RID: 3471
		[global::Cpp2ILInjected.Token(Token = "0x17000146")]
		public static extern string MachineName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E6D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C789E8", Offset = "0x1C789E8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.Type1Message", Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.Type3Message", Member = ".ctor", MemberParameters = new object[] { "Mono.Security.Protocol.Ntlm.Type2Message" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x06000D90 RID: 3472
		[global::Cpp2ILInjected.Token(Token = "0x6000E6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C789EC", Offset = "0x1C789EC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern string GetNewLine();

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x00016BE0 File Offset: 0x00014DE0
		[global::Cpp2ILInjected.Token(Token = "0x17000147")]
		public static string NewLine
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E6F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C789F0", Offset = "0x1C789F0", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 78)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000D92 RID: 3474
		[global::Cpp2ILInjected.Token(Token = "0x17000148")]
		internal static extern global::System.PlatformID Platform
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000E70")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C78A58", Offset = "0x1C78A58", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x06000D93 RID: 3475
		[global::Cpp2ILInjected.Token(Token = "0x6000E71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C78A5C", Offset = "0x1C78A5C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern string GetOSVersionString();

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x00016BE3 File Offset: 0x00014DE3
		[global::Cpp2ILInjected.Token(Token = "0x17000149")]
		public static global::System.OperatingSystem OSVersion
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E72")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C78A60", Offset = "0x1C78A60", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.Security.Cryptography.KeyPairPersistence), Member = "CanSecure", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Platform", Member = "CheckOS", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "CreatePipe", MemberParameters = new object[]
			{
				typeof(ref global::System.IntPtr),
				typeof(ref global::System.IntPtr),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "get_IsWindows", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.UnixIPGlobalPropertiesFactoryPal", Member = "Create", ReturnType = "System.Net.NetworkInformation.IPGlobalProperties")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.UnixNetworkInterfaceFactoryPal", Member = "Create", ReturnType = "System.Net.NetworkInformation.NetworkInterfaceFactory")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "CreateVersionFromString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Version))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OperatingSystem), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.PlatformID),
				typeof(global::System.Version)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00016BE6 File Offset: 0x00014DE6
		[global::Cpp2ILInjected.Token(Token = "0x6000E73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C78B14", Offset = "0x1C78B14", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "get_OSVersion", ReturnType = typeof(global::System.OperatingSystem))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Version), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static global::System.Version CreateVersionFromString(string info)
		{
			throw null;
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x00016BE9 File Offset: 0x00014DE9
		[global::Cpp2ILInjected.Token(Token = "0x1700014A")]
		public static string StackTrace
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E74")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C78D30", Offset = "0x1C78D30", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.TraceEventCache", Member = "get_Callstack", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.TraceListener", Member = "WriteFooter", MemberParameters = new object[] { "System.Diagnostics.TraceEventCache" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Diagnostics.StackTrace), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000D97 RID: 3479
		[global::Cpp2ILInjected.Token(Token = "0x1700014B")]
		public static extern int TickCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E75")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C78D94", Offset = "0x1C78D94", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 36)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x00016BEC File Offset: 0x00014DEC
		[global::Cpp2ILInjected.Token(Token = "0x1700014C")]
		public static string UserDomainName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E76")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C78D98", Offset = "0x1C78D98", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.Type1Message", Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000D99 RID: 3481
		[global::Cpp2ILInjected.Token(Token = "0x1700014D")]
		public static extern string UserName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E77")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C78D9C", Offset = "0x1C78D9C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.Type3Message", Member = ".ctor", MemberParameters = new object[] { "Mono.Security.Protocol.Ntlm.Type2Message" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x06000D9A RID: 3482
		[global::Cpp2ILInjected.Token(Token = "0x6000E78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C78DA0", Offset = "0x1C78DA0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern void Exit(int exitCode);

		// Token: 0x06000D9B RID: 3483 RVA: 0x00016BEF File Offset: 0x00014DEF
		[global::Cpp2ILInjected.Token(Token = "0x6000E79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C78DA4", Offset = "0x1C78DA4", Length = "0x2B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Base.PathService", Member = "ExpandPathVariables", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetEnvironmentVariablesNoCase", ReturnType = typeof(global::System.Collections.Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static string ExpandEnvironmentVariables(string name)
		{
			throw null;
		}

		// Token: 0x06000D9C RID: 3484
		[global::Cpp2ILInjected.Token(Token = "0x6000E7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7914C", Offset = "0x1C7914C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern string internalGetEnvironmentVariable_native(global::System.IntPtr variable);

		// Token: 0x06000D9D RID: 3485 RVA: 0x00016BF2 File Offset: 0x00014DF2
		[global::Cpp2ILInjected.Token(Token = "0x6000E7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C79150", Offset = "0x1C79150", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "ExpandEnvironmentVariables", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "GetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "GetEnvironmentVariablesNoCase", ReturnType = typeof(global::System.Collections.Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "GetEnvironmentVariables", ReturnType = typeof(global::System.Collections.IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "ReadXdgUserDir", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "UnixGetFolderPath", MemberParameters = new object[]
		{
			typeof(global::System.Environment.SpecialFolder),
			typeof(global::System.Environment.SpecialFolderOption)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ConsoleDriver), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "SearchTerminfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "get_UseManagedCollation", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.RuntimeMarshal), Member = "MarshalString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::Mono.SafeStringMarshal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeStringMarshal), Member = "get_Value", ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeStringMarshal), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static string internalGetEnvironmentVariable(string variable)
		{
			throw null;
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00016BF5 File Offset: 0x00014DF5
		[global::Cpp2ILInjected.Token(Token = "0x6000E7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7905C", Offset = "0x1C7905C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.OSX.PathService", Member = "GetStoragePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Linux.PathService", Member = "GetStoragePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetTzEnvironmentVariable", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetTimeZoneDirectory", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MonoIO), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MonoTlsProviderFactory", Member = "CreateDefaultProviderImpl", ReturnType = "Mono.Net.Security.MobileTlsProvider")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.DefaultTraceListener", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.SafeSocketHandle", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		public static string GetEnvironmentVariable(string variable)
		{
			throw null;
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00016BF8 File Offset: 0x00014DF8
		[global::Cpp2ILInjected.Token(Token = "0x6000E7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C79078", Offset = "0x1C79078", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "ExpandEnvironmentVariables", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.CaseInsensitiveHashCodeProvider), Member = "get_Default", ReturnType = typeof(global::System.Collections.CaseInsensitiveHashCodeProvider))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.CaseInsensitiveComparer), Member = "get_Default", ReturnType = typeof(global::System.Collections.CaseInsensitiveComparer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Collections.IHashCodeProvider),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static global::System.Collections.Hashtable GetEnvironmentVariablesNoCase()
		{
			throw null;
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00016BFB File Offset: 0x00014DFB
		[global::Cpp2ILInjected.Token(Token = "0x6000E7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7921C", Offset = "0x1C7921C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.ProcessStartInfo", Member = "get_EnvironmentVariables", ReturnType = "System.Collections.Specialized.StringDictionary")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static global::System.Collections.IDictionary GetEnvironmentVariables()
		{
			throw null;
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00016BFE File Offset: 0x00014DFE
		[global::Cpp2ILInjected.Token(Token = "0x6000E7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C792CC", Offset = "0x1C792CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.OS.Windows.PathService", Member = "GetStoragePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.Security.Cryptography.KeyPairPersistence), Member = "get_UserPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.Security.Cryptography.KeyPairPersistence), Member = "get_MachinePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListener", Member = "LoadCertificateAndKey", MemberParameters = new object[]
		{
			"System.Net.IPAddress",
			typeof(int)
		}, ReturnType = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_CurrentUserPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_LocalMachinePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_NewCurrentUserPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_NewLocalMachinePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		public static string GetFolderPath(global::System.Environment.SpecialFolder folder)
		{
			throw null;
		}

		// Token: 0x06000DA2 RID: 3490
		[global::Cpp2ILInjected.Token(Token = "0x6000E80")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C79308", Offset = "0x1C79308", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern string GetWindowsFolderPath(int folder);

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00016C01 File Offset: 0x00014E01
		[global::Cpp2ILInjected.Token(Token = "0x6000E81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C792D4", Offset = "0x1C792D4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.SecurityManager), Member = "EnsureElevatedPermissions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "UnixGetFolderPath", MemberParameters = new object[]
		{
			typeof(global::System.Environment.SpecialFolder),
			typeof(global::System.Environment.SpecialFolderOption)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string GetFolderPath(global::System.Environment.SpecialFolder folder, global::System.Environment.SpecialFolderOption option)
		{
			throw null;
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00016C04 File Offset: 0x00014E04
		[global::Cpp2ILInjected.Token(Token = "0x6000E82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C797A8", Offset = "0x1C797A8", Length = "0x450")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.StreamReader), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWithOrdinalUnchecked", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback)
		{
			throw null;
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00016C07 File Offset: 0x00014E07
		[global::Cpp2ILInjected.Token(Token = "0x6000E83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7930C", Offset = "0x1C7930C", Length = "0x49C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "GetFolderPath", MemberParameters = new object[]
		{
			typeof(global::System.Environment.SpecialFolder),
			typeof(global::System.Environment.SpecialFolderOption)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 43)]
		internal static string UnixGetFolderPath(global::System.Environment.SpecialFolder folder, global::System.Environment.SpecialFolderOption option)
		{
			throw null;
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00016C0A File Offset: 0x00014E0A
		[global::Cpp2ILInjected.Token(Token = "0x6000E84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C79BFC", Offset = "0x1C79BFC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ManifestBasedResourceGroveler), Member = "HandleResourceStreamMissing", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void FailFast(string message)
		{
			throw null;
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00016C0D File Offset: 0x00014E0D
		[global::Cpp2ILInjected.Token(Token = "0x6000E85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C79C0C", Offset = "0x1C79C0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ExecutionContext), Member = "OnAsyncLocalContextChanged", MemberParameters = new object[]
		{
			typeof(global::System.Threading.ExecutionContext),
			typeof(global::System.Threading.ExecutionContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void FailFast(string message, global::System.Exception exception)
		{
			throw null;
		}

		// Token: 0x06000DA8 RID: 3496
		[global::Cpp2ILInjected.Token(Token = "0x6000E86")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C79C08", Offset = "0x1C79C08", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern void FailFast(string message, global::System.Exception exception, string errorSource);

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000DA9 RID: 3497
		[global::Cpp2ILInjected.Token(Token = "0x1700014E")]
		public static extern int ProcessorCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E87")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C79C14", Offset = "0x1C79C14", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ThreadPoolGlobals), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1.PerCoreLockedStacks", Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x00016C10 File Offset: 0x00014E10
		[global::Cpp2ILInjected.Token(Token = "0x1700014F")]
		internal static bool IsRunningOnWindows
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E88")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C79060", Offset = "0x1C79060", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "InsecureGetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "GetInvalidFileNameChars", ReturnType = typeof(char[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "GetInvalidPathChars", ReturnType = typeof(char[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Path), Member = "CanonicalizePath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000DAB RID: 3499
		[global::Cpp2ILInjected.Token(Token = "0x6000E89")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C79218", Offset = "0x1C79218", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern string[] GetEnvironmentVariableNames();

		// Token: 0x06000DAC RID: 3500
		[global::Cpp2ILInjected.Token(Token = "0x6000E8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C79C18", Offset = "0x1C79C18", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingConfiguration), Member = "LoadDefaultDelayedChannels", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern string GetMachineConfigPath();

		// Token: 0x06000DAD RID: 3501
		[global::Cpp2ILInjected.Token(Token = "0x6000E8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C79BF8", Offset = "0x1C79BF8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern string internalGetHome();

		// Token: 0x06000DAE RID: 3502
		[global::Cpp2ILInjected.Token(Token = "0x6000E8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C79C1C", Offset = "0x1C79C1C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Thread), Member = "GetProcessDefaultStackSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern int GetPageSize();

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x00016C13 File Offset: 0x00014E13
		[global::Cpp2ILInjected.Token(Token = "0x17000150")]
		internal static bool IsUnix
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E8D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C79C20", Offset = "0x1C79C20", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Principal.WindowsIdentity), Member = "SetToken", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00016C16 File Offset: 0x00014E16
		[global::Cpp2ILInjected.Token(Token = "0x6000E8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C79C58", Offset = "0x1C79C58", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = "GetStackTrace", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Diagnostics.StackTrace), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Diagnostics.StackTrace), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Diagnostics.StackTrace), Member = "ToString", MemberParameters = new object[] { typeof(global::System.Diagnostics.StackTrace.TraceFormat) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static string GetStackTrace(global::System.Exception e, bool needFileInfo)
		{
			throw null;
		}

		// Token: 0x04000465 RID: 1125
		[global::Cpp2ILInjected.Token(Token = "0x40005F7")]
		private const string mono_corlib_version = "1A5E0066-58DC-428A-B21C-0AD6CDAE2789";

		// Token: 0x04000466 RID: 1126
		[global::Cpp2ILInjected.Token(Token = "0x40005F8")]
		private static string nl;

		// Token: 0x04000467 RID: 1127
		[global::Cpp2ILInjected.Token(Token = "0x40005F9")]
		private static global::System.OperatingSystem os;

		// Token: 0x02000595 RID: 1429
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x2000165")]
		public enum SpecialFolder
		{
			// Token: 0x0400183A RID: 6202
			[global::Cpp2ILInjected.Token(Token = "0x40005FB")]
			MyDocuments = 5,
			// Token: 0x0400183B RID: 6203
			[global::Cpp2ILInjected.Token(Token = "0x40005FC")]
			Desktop = 0,
			// Token: 0x0400183C RID: 6204
			[global::Cpp2ILInjected.Token(Token = "0x40005FD")]
			MyComputer = 17,
			// Token: 0x0400183D RID: 6205
			[global::Cpp2ILInjected.Token(Token = "0x40005FE")]
			Programs = 2,
			// Token: 0x0400183E RID: 6206
			[global::Cpp2ILInjected.Token(Token = "0x40005FF")]
			Personal = 5,
			// Token: 0x0400183F RID: 6207
			[global::Cpp2ILInjected.Token(Token = "0x4000600")]
			Favorites,
			// Token: 0x04001840 RID: 6208
			[global::Cpp2ILInjected.Token(Token = "0x4000601")]
			Startup,
			// Token: 0x04001841 RID: 6209
			[global::Cpp2ILInjected.Token(Token = "0x4000602")]
			Recent,
			// Token: 0x04001842 RID: 6210
			[global::Cpp2ILInjected.Token(Token = "0x4000603")]
			SendTo,
			// Token: 0x04001843 RID: 6211
			[global::Cpp2ILInjected.Token(Token = "0x4000604")]
			StartMenu = 11,
			// Token: 0x04001844 RID: 6212
			[global::Cpp2ILInjected.Token(Token = "0x4000605")]
			MyMusic = 13,
			// Token: 0x04001845 RID: 6213
			[global::Cpp2ILInjected.Token(Token = "0x4000606")]
			DesktopDirectory = 16,
			// Token: 0x04001846 RID: 6214
			[global::Cpp2ILInjected.Token(Token = "0x4000607")]
			Templates = 21,
			// Token: 0x04001847 RID: 6215
			[global::Cpp2ILInjected.Token(Token = "0x4000608")]
			ApplicationData = 26,
			// Token: 0x04001848 RID: 6216
			[global::Cpp2ILInjected.Token(Token = "0x4000609")]
			LocalApplicationData = 28,
			// Token: 0x04001849 RID: 6217
			[global::Cpp2ILInjected.Token(Token = "0x400060A")]
			InternetCache = 32,
			// Token: 0x0400184A RID: 6218
			[global::Cpp2ILInjected.Token(Token = "0x400060B")]
			Cookies,
			// Token: 0x0400184B RID: 6219
			[global::Cpp2ILInjected.Token(Token = "0x400060C")]
			History,
			// Token: 0x0400184C RID: 6220
			[global::Cpp2ILInjected.Token(Token = "0x400060D")]
			CommonApplicationData,
			// Token: 0x0400184D RID: 6221
			[global::Cpp2ILInjected.Token(Token = "0x400060E")]
			System = 37,
			// Token: 0x0400184E RID: 6222
			[global::Cpp2ILInjected.Token(Token = "0x400060F")]
			ProgramFiles,
			// Token: 0x0400184F RID: 6223
			[global::Cpp2ILInjected.Token(Token = "0x4000610")]
			MyPictures,
			// Token: 0x04001850 RID: 6224
			[global::Cpp2ILInjected.Token(Token = "0x4000611")]
			CommonProgramFiles = 43,
			// Token: 0x04001851 RID: 6225
			[global::Cpp2ILInjected.Token(Token = "0x4000612")]
			MyVideos = 14,
			// Token: 0x04001852 RID: 6226
			[global::Cpp2ILInjected.Token(Token = "0x4000613")]
			NetworkShortcuts = 19,
			// Token: 0x04001853 RID: 6227
			[global::Cpp2ILInjected.Token(Token = "0x4000614")]
			Fonts,
			// Token: 0x04001854 RID: 6228
			[global::Cpp2ILInjected.Token(Token = "0x4000615")]
			CommonStartMenu = 22,
			// Token: 0x04001855 RID: 6229
			[global::Cpp2ILInjected.Token(Token = "0x4000616")]
			CommonPrograms,
			// Token: 0x04001856 RID: 6230
			[global::Cpp2ILInjected.Token(Token = "0x4000617")]
			CommonStartup,
			// Token: 0x04001857 RID: 6231
			[global::Cpp2ILInjected.Token(Token = "0x4000618")]
			CommonDesktopDirectory,
			// Token: 0x04001858 RID: 6232
			[global::Cpp2ILInjected.Token(Token = "0x4000619")]
			PrinterShortcuts = 27,
			// Token: 0x04001859 RID: 6233
			[global::Cpp2ILInjected.Token(Token = "0x400061A")]
			Windows = 36,
			// Token: 0x0400185A RID: 6234
			[global::Cpp2ILInjected.Token(Token = "0x400061B")]
			UserProfile = 40,
			// Token: 0x0400185B RID: 6235
			[global::Cpp2ILInjected.Token(Token = "0x400061C")]
			SystemX86,
			// Token: 0x0400185C RID: 6236
			[global::Cpp2ILInjected.Token(Token = "0x400061D")]
			ProgramFilesX86,
			// Token: 0x0400185D RID: 6237
			[global::Cpp2ILInjected.Token(Token = "0x400061E")]
			CommonProgramFilesX86 = 44,
			// Token: 0x0400185E RID: 6238
			[global::Cpp2ILInjected.Token(Token = "0x400061F")]
			CommonTemplates,
			// Token: 0x0400185F RID: 6239
			[global::Cpp2ILInjected.Token(Token = "0x4000620")]
			CommonDocuments,
			// Token: 0x04001860 RID: 6240
			[global::Cpp2ILInjected.Token(Token = "0x4000621")]
			CommonAdminTools,
			// Token: 0x04001861 RID: 6241
			[global::Cpp2ILInjected.Token(Token = "0x4000622")]
			AdminTools,
			// Token: 0x04001862 RID: 6242
			[global::Cpp2ILInjected.Token(Token = "0x4000623")]
			CommonMusic = 53,
			// Token: 0x04001863 RID: 6243
			[global::Cpp2ILInjected.Token(Token = "0x4000624")]
			CommonPictures,
			// Token: 0x04001864 RID: 6244
			[global::Cpp2ILInjected.Token(Token = "0x4000625")]
			CommonVideos,
			// Token: 0x04001865 RID: 6245
			[global::Cpp2ILInjected.Token(Token = "0x4000626")]
			Resources,
			// Token: 0x04001866 RID: 6246
			[global::Cpp2ILInjected.Token(Token = "0x4000627")]
			LocalizedResources,
			// Token: 0x04001867 RID: 6247
			[global::Cpp2ILInjected.Token(Token = "0x4000628")]
			CommonOemLinks,
			// Token: 0x04001868 RID: 6248
			[global::Cpp2ILInjected.Token(Token = "0x4000629")]
			CDBurning
		}

		// Token: 0x02000596 RID: 1430
		[global::Cpp2ILInjected.Token(Token = "0x2000166")]
		public enum SpecialFolderOption
		{
			// Token: 0x0400186A RID: 6250
			[global::Cpp2ILInjected.Token(Token = "0x400062B")]
			None,
			// Token: 0x0400186B RID: 6251
			[global::Cpp2ILInjected.Token(Token = "0x400062C")]
			DoNotVerify = 16384,
			// Token: 0x0400186C RID: 6252
			[global::Cpp2ILInjected.Token(Token = "0x400062D")]
			Create = 32768
		}
	}
}
