using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000B1 RID: 177
	[global::Cpp2ILInjected.Token(Token = "0x20000E1")]
	[global::System.Serializable]
	public class NotSupportedException : global::System.SystemException
	{
		// Token: 0x060007A1 RID: 1953 RVA: 0x00015B5A File Offset: 0x00013D5A
		[global::Cpp2ILInjected.Token(Token = "0x6000846")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C376BC", Offset = "0x1C376BC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 176)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public NotSupportedException()
		{
			throw null;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00015B5D File Offset: 0x00013D5D
		[global::Cpp2ILInjected.Token(Token = "0x6000847")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C37718", Offset = "0x1C37718", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 320)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public NotSupportedException(string message)
		{
			throw null;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00015B60 File Offset: 0x00013D60
		[global::Cpp2ILInjected.Token(Token = "0x6000848")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C3773C", Offset = "0x1C3773C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MonoTlsProviderFactory", Member = "InitializeInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MonoTlsProviderFactory", Member = "LookupProvider", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = "Mono.Net.Security.MobileTlsProvider")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		public NotSupportedException(string message, global::System.Exception innerException)
		{
			throw null;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00015B63 File Offset: 0x00013D63
		[global::Cpp2ILInjected.Token(Token = "0x6000849")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C37760", Offset = "0x1C37760", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected NotSupportedException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
