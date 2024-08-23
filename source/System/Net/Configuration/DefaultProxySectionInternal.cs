using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Configuration
{
	// Token: 0x020001F8 RID: 504
	[global::Cpp2ILInjected.Token(Token = "0x20002DD")]
	internal sealed class DefaultProxySectionInternal
	{
		// Token: 0x060010E1 RID: 4321 RVA: 0x00005E9A File Offset: 0x0000409A
		[global::Cpp2ILInjected.Token(Token = "0x60012DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E20CF8", Offset = "0x1E20CF8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "CreateDefaultProxy", ReturnType = typeof(IWebProxy))]
		private static IWebProxy GetDefaultProxy_UsingOldMonoCode()
		{
			throw null;
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x00005E9D File Offset: 0x0000409D
		[global::Cpp2ILInjected.Token(Token = "0x60012DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E20D00", Offset = "0x1E20D00", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "CreateDefaultProxy", ReturnType = typeof(IWebProxy))]
		private static IWebProxy GetSystemWebProxy()
		{
			throw null;
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x060010E3 RID: 4323 RVA: 0x00005EA0 File Offset: 0x000040A0
		[global::Cpp2ILInjected.Token(Token = "0x17000456")]
		internal static object ClassSyncObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E20D08", Offset = "0x1E20D08", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultProxySectionInternal), Member = "GetSection", ReturnType = typeof(DefaultProxySectionInternal))]
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

		// Token: 0x060010E4 RID: 4324 RVA: 0x00005EA3 File Offset: 0x000040A3
		[global::Cpp2ILInjected.Token(Token = "0x60012DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E20DA0", Offset = "0x1E20DA0", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "get_InternalDefaultWebProxy", ReturnType = typeof(IWebProxy))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultProxySectionInternal), Member = "get_ClassSyncObject", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "CreateDefaultProxy", ReturnType = typeof(IWebProxy))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static DefaultProxySectionInternal GetSection()
		{
			throw null;
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x060010E5 RID: 4325 RVA: 0x00005EA6 File Offset: 0x000040A6
		[global::Cpp2ILInjected.Token(Token = "0x17000457")]
		internal IWebProxy WebProxy
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E20EB0", Offset = "0x1E20EB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00005EA9 File Offset: 0x000040A9
		[global::Cpp2ILInjected.Token(Token = "0x60012DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E20EA8", Offset = "0x1E20EA8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DefaultProxySectionInternal()
		{
			throw null;
		}

		// Token: 0x04000B83 RID: 2947
		[global::Cpp2ILInjected.Token(Token = "0x4000F57")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IWebProxy webProxy;

		// Token: 0x04000B84 RID: 2948
		[global::Cpp2ILInjected.Token(Token = "0x4000F58")]
		private static object classSyncObject;
	}
}
