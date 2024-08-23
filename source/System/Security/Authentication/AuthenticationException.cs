using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security;

namespace System.Security.Authentication
{
	// Token: 0x02000089 RID: 137
	[global::Cpp2ILInjected.Token(Token = "0x20000E4")]
	[Serializable]
	public class AuthenticationException : SystemException
	{
		// Token: 0x0600049B RID: 1179 RVA: 0x00003B5D File Offset: 0x00001D5D
		[global::Cpp2ILInjected.Token(Token = "0x600053B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECC778", Offset = "0x1ECC778", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public AuthenticationException()
		{
			throw null;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00003B60 File Offset: 0x00001D60
		[global::Cpp2ILInjected.Token(Token = "0x600053C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECC7D0", Offset = "0x1ECC7D0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "GetSSPIException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		public AuthenticationException(string message, Exception innerException)
		{
			throw null;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00003B63 File Offset: 0x00001D63
		[global::Cpp2ILInjected.Token(Token = "0x600053D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ECC7D8", Offset = "0x1ECC7D8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		protected AuthenticationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}
	}
}
