using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace System.Net
{
	// Token: 0x02000183 RID: 387
	[global::Cpp2ILInjected.Token(Token = "0x200022B")]
	internal class ServerCertValidationCallback
	{
		// Token: 0x06000C8E RID: 3214 RVA: 0x000051FE File Offset: 0x000033FE
		[global::Cpp2ILInjected.Token(Token = "0x6000DF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CC14", Offset = "0x1F3CC14", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChainValidationHelper), Member = "GetValidationCallback", MemberParameters = new object[] { typeof(MonoTlsSettings) }, ReturnType = typeof(ServerCertValidationCallback))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_ServerCertificateValidationCallback", MemberParameters = new object[] { typeof(RemoteCertificateValidationCallback) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointManager), Member = "set_ServerCertificateValidationCallback", MemberParameters = new object[] { typeof(RemoteCertificateValidationCallback) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ServerCertValidationCallback(RemoteCertificateValidationCallback validationCallback)
		{
			throw null;
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x00005201 File Offset: 0x00003401
		[global::Cpp2ILInjected.Token(Token = "0x170002EA")]
		internal RemoteCertificateValidationCallback ValidationCallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DF5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3CC8C", Offset = "0x1F3CC8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00005204 File Offset: 0x00003404
		[global::Cpp2ILInjected.Token(Token = "0x6000DF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CC94", Offset = "0x1F3CC94", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void Callback(object state)
		{
			throw null;
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00005207 File Offset: 0x00003407
		[global::Cpp2ILInjected.Token(Token = "0x6000DF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3CD38", Offset = "0x1F3CD38", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChainValidationHelper), Member = "InvokeCallback", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(X509Chain),
			typeof(SslPolicyErrors)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "CreateCopy", ReturnType = typeof(ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new object[]
		{
			typeof(ExecutionContext),
			typeof(ContextCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			throw null;
		}

		// Token: 0x04000915 RID: 2325
		[global::Cpp2ILInjected.Token(Token = "0x4000BA8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly RemoteCertificateValidationCallback m_ValidationCallback;

		// Token: 0x04000916 RID: 2326
		[global::Cpp2ILInjected.Token(Token = "0x4000BA9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly ExecutionContext m_Context;

		// Token: 0x0200040C RID: 1036
		[global::Cpp2ILInjected.Token(Token = "0x200022C")]
		private class CallbackContext
		{
			// Token: 0x06001E05 RID: 7685 RVA: 0x000082E2 File Offset: 0x000064E2
			[global::Cpp2ILInjected.Token(Token = "0x6000DF8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3CE9C", Offset = "0x1F3CE9C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal CallbackContext(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
			{
				throw null;
			}

			// Token: 0x0400121C RID: 4636
			[global::Cpp2ILInjected.Token(Token = "0x4000BAA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal readonly object request;

			// Token: 0x0400121D RID: 4637
			[global::Cpp2ILInjected.Token(Token = "0x4000BAB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal readonly X509Certificate certificate;

			// Token: 0x0400121E RID: 4638
			[global::Cpp2ILInjected.Token(Token = "0x4000BAC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal readonly X509Chain chain;

			// Token: 0x0400121F RID: 4639
			[global::Cpp2ILInjected.Token(Token = "0x4000BAD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal readonly SslPolicyErrors sslPolicyErrors;

			// Token: 0x04001220 RID: 4640
			[global::Cpp2ILInjected.Token(Token = "0x4000BAE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			internal bool result;
		}
	}
}
