using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Http
{
	// Token: 0x02000027 RID: 39
	[global::Cpp2ILInjected.Token(Token = "0x200006D")]
	internal class NtlmClient : IAuthenticationModule
	{
		// Token: 0x06000120 RID: 288 RVA: 0x0000313A File Offset: 0x0000133A
		[global::Cpp2ILInjected.Token(Token = "0x6000197")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4F454", Offset = "0x1D4F454", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConditionalWeakTable<, >.CreateValueCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConditionalWeakTable<, >), Member = "GetValue", MemberParameters = new object[] { "TKey", "CreateValueCallback<TKey, TValue>" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NtlmSession), Member = "Authenticate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebRequest),
			typeof(ICredentials)
		}, ReturnType = typeof(Authorization))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			throw null;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000313D File Offset: 0x0000133D
		[global::Cpp2ILInjected.Token(Token = "0x6000198")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4F78C", Offset = "0x1D4F78C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			throw null;
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00003140 File Offset: 0x00001340
		[global::Cpp2ILInjected.Token(Token = "0x1700005B")]
		public string AuthenticationType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000199")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4F794", Offset = "0x1D4F794", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00003143 File Offset: 0x00001343
		[global::Cpp2ILInjected.Token(Token = "0x1700005C")]
		public bool CanPreAuthenticate
		{
			[global::Cpp2ILInjected.Token(Token = "0x600019A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4F7D4", Offset = "0x1D4F7D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00003146 File Offset: 0x00001346
		[global::Cpp2ILInjected.Token(Token = "0x600019B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4F7DC", Offset = "0x1D4F7DC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NtlmClient), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public NtlmClient()
		{
			throw null;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00003149 File Offset: 0x00001349
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600019C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4F7E4", Offset = "0x1D4F7E4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConditionalWeakTable<, >), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static NtlmClient()
		{
			throw null;
		}

		// Token: 0x0400006E RID: 110
		[global::Cpp2ILInjected.Token(Token = "0x4000132")]
		private static readonly ConditionalWeakTable<HttpWebRequest, NtlmSession> cache;

		// Token: 0x020003AE RID: 942
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200006E")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001D1B RID: 7451 RVA: 0x00008045 File Offset: 0x00006245
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600019D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4F870", Offset = "0x1D4F870", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06001D1C RID: 7452 RVA: 0x00008048 File Offset: 0x00006248
			[global::Cpp2ILInjected.Token(Token = "0x600019E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4F8CC", Offset = "0x1D4F8CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06001D1D RID: 7453 RVA: 0x0000804B File Offset: 0x0000624B
			[global::Cpp2ILInjected.Token(Token = "0x600019F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4F8D4", Offset = "0x1D4F8D4", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal NtlmSession <Authenticate>b__1_0(HttpWebRequest x)
			{
				throw null;
			}

			// Token: 0x04001075 RID: 4213
			[global::Cpp2ILInjected.Token(Token = "0x4000133")]
			public static readonly NtlmClient.<>c <>9;

			// Token: 0x04001076 RID: 4214
			[global::Cpp2ILInjected.Token(Token = "0x4000134")]
			public static ConditionalWeakTable<HttpWebRequest, NtlmSession>.CreateValueCallback <>9__1_0;
		}
	}
}
