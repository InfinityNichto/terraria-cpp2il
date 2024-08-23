using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200017E RID: 382
	[global::Cpp2ILInjected.Token(Token = "0x2000221")]
	internal class AutoWebProxyScriptEngine
	{
		// Token: 0x06000C72 RID: 3186 RVA: 0x000051AA File Offset: 0x000033AA
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

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x000051AD File Offset: 0x000033AD
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x000051B0 File Offset: 0x000033B0
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

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x000051B3 File Offset: 0x000033B3
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x000051B6 File Offset: 0x000033B6
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

		// Token: 0x06000C77 RID: 3191 RVA: 0x000051B9 File Offset: 0x000033B9
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

		// Token: 0x06000C78 RID: 3192 RVA: 0x000051BC File Offset: 0x000033BC
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

		// Token: 0x06000C79 RID: 3193 RVA: 0x000051BF File Offset: 0x000033BF
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

		// Token: 0x06000C7A RID: 3194 RVA: 0x000051C2 File Offset: 0x000033C2
		[global::Cpp2ILInjected.Token(Token = "0x6000DD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3B76C", Offset = "0x1F3B76C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProxyScriptChain), Member = "Abort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "AbortGetProxiesAuto", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void Abort(ref int syncStatus)
		{
			throw null;
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x000051C5 File Offset: 0x000033C5
		[global::Cpp2ILInjected.Token(Token = "0x6000DD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3B770", Offset = "0x1F3B770", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "CheckForChanges", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void CheckForChanges()
		{
			throw null;
		}

		// Token: 0x04000911 RID: 2321
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000B7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Uri <AutomaticConfigurationScript>k__BackingField;

		// Token: 0x04000912 RID: 2322
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000B7F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool <AutomaticallyDetectSettings>k__BackingField;
	}
}
