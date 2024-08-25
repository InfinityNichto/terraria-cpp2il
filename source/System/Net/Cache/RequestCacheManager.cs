using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Cache
{
	[global::Cpp2ILInjected.Token(Token = "0x20002E2")]
	internal sealed class RequestCacheManager
	{
		[global::Cpp2ILInjected.Token(Token = "0x60012F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E21094", Offset = "0x1E21094", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "get_DefaultCachePolicy", ReturnType = typeof(RequestCachePolicy))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "set_DefaultCachePolicy", MemberParameters = new object[] { typeof(RequestCachePolicy) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "SetupCacheProtocol", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RequestCacheManager), Member = "LoadConfigSettings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal static RequestCacheBinding GetBinding(string internedScheme)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E213FC", Offset = "0x1E213FC", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "set_DefaultCachePolicy", MemberParameters = new object[] { typeof(RequestCachePolicy) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RequestCacheManager), Member = "LoadConfigSettings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal static void SetBinding(string uriScheme, RequestCacheBinding binding)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E21284", Offset = "0x1E21284", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RequestCacheManager), Member = "GetBinding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(RequestCacheBinding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RequestCacheManager), Member = "SetBinding", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RequestCacheBinding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private static void LoadConfigSettings()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60012F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E2160C", Offset = "0x1E2160C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static RequestCacheManager()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000F6D")]
		private static RequestCachingSectionInternal s_CacheConfigSettings;

		[global::Cpp2ILInjected.Token(Token = "0x4000F6E")]
		private static readonly RequestCacheBinding s_BypassCacheBinding;

		[global::Cpp2ILInjected.Token(Token = "0x4000F6F")]
		private static RequestCacheBinding s_DefaultGlobalBinding;

		[global::Cpp2ILInjected.Token(Token = "0x4000F70")]
		private static RequestCacheBinding s_DefaultHttpBinding;

		[global::Cpp2ILInjected.Token(Token = "0x4000F71")]
		private static RequestCacheBinding s_DefaultFtpBinding;
	}
}
