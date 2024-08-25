using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000221")]
	internal class AutoWebProxyScriptEngine
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000DD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3B724", Offset = "0x1F3B724", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "set_AutoDetect", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "set_ScriptLocation", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AutoWebProxyScriptEngine(WebProxy proxy, bool useRegistry)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E4")]
		public Uri AutomaticConfigurationScript
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000DD1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3B72C", Offset = "0x1F3B72C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000DD2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3B734", Offset = "0x1F3B734", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002E5")]
		public bool AutomaticallyDetectSettings
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000DD3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3B73C", Offset = "0x1F3B73C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000DD4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3B744", Offset = "0x1F3B744", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3B750", Offset = "0x1F3B750", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "GetProxyAuto", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "IsBypassedAuto", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public bool GetProxies(Uri destination, out IList<string> proxyList)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3B75C", Offset = "0x1F3B75C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "GetProxiesAuto", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref int)
		}, ReturnType = typeof(Uri[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool GetProxies(Uri destination, out IList<string> proxyList, ref int syncStatus)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3B768", Offset = "0x1F3B768", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "set_Address", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "set_BypassProxyOnLocal", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "set_BypassList", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "DeleteScriptEngine", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public void Close()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3B76C", Offset = "0x1F3B76C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProxyScriptChain), Member = "Abort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "AbortGetProxiesAuto", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void Abort(ref int syncStatus)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3B770", Offset = "0x1F3B770", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "CheckForChanges", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void CheckForChanges()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000B7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Uri <AutomaticConfigurationScript>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000B7F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool <AutomaticallyDetectSettings>k__BackingField;
	}
}
