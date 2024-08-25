using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	[global::Cpp2ILInjected.Token(Token = "0x200029F")]
	public abstract class IPGlobalProperties
	{
		[global::Cpp2ILInjected.Token(Token = "0x600127F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1C860", Offset = "0x1E1C860", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static IPGlobalProperties GetIPGlobalProperties()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001280")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1C8AC", Offset = "0x1E1C8AC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "IsLocal", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPGlobalPropertiesFactoryPal), Member = "Create", ReturnType = typeof(IPGlobalProperties))]
		internal static IPGlobalProperties InternalGetIPGlobalProperties()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000443")]
		public abstract string DomainName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001281")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001282")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1C8B0", Offset = "0x1E1C8B0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected IPGlobalProperties()
		{
			throw null;
		}
	}
}
