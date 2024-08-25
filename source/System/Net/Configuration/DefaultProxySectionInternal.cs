using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Configuration
{
	[global::Cpp2ILInjected.Token(Token = "0x20002DD")]
	internal sealed class DefaultProxySectionInternal
	{
		[global::Cpp2ILInjected.Token(Token = "0x60012DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E20CF8", Offset = "0x1E20CF8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "CreateDefaultProxy", ReturnType = typeof(IWebProxy))]
		private static IWebProxy GetDefaultProxy_UsingOldMonoCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E20D00", Offset = "0x1E20D00", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebProxy), Member = "CreateDefaultProxy", ReturnType = typeof(IWebProxy))]
		private static IWebProxy GetSystemWebProxy()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60012DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E20EA8", Offset = "0x1E20EA8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DefaultProxySectionInternal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000F57")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IWebProxy webProxy;

		[global::Cpp2ILInjected.Token(Token = "0x4000F58")]
		private static object classSyncObject;
	}
}
