using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x02000022 RID: 34
	[global::Cpp2ILInjected.Token(Token = "0x2000065")]
	internal class MonoTlsStream : IDisposable
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000310D File Offset: 0x0000130D
		[global::Cpp2ILInjected.Token(Token = "0x17000058")]
		internal HttpWebRequest Request
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000182")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4E598", Offset = "0x1D4E598", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00003110 File Offset: 0x00001310
		[global::Cpp2ILInjected.Token(Token = "0x17000059")]
		internal WebExceptionStatus ExceptionStatus
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000183")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4E5A0", Offset = "0x1D4E5A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00003113 File Offset: 0x00001313
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00003116 File Offset: 0x00001316
		[global::Cpp2ILInjected.Token(Token = "0x1700005A")]
		internal bool CertificateValidationFailed
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000184")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4E5A8", Offset = "0x1D4E5A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000185")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4E5B0", Offset = "0x1D4E5B0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00003119 File Offset: 0x00001319
		[global::Cpp2ILInjected.Token(Token = "0x6000186")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4E5BC", Offset = "0x1D4E5BC", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsProviderFactory), Member = "GetProviderInternal", ReturnType = typeof(MobileTlsProvider))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChainValidationHelper), Member = "Create", MemberParameters = new object[]
		{
			typeof(MobileTlsProvider),
			typeof(ref MonoTlsSettings),
			typeof(MonoTlsStream)
		}, ReturnType = typeof(ChainValidationHelper))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public MonoTlsStream(HttpWebRequest request, NetworkStream networkStream)
		{
			throw null;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000311C File Offset: 0x0000131C
		[global::Cpp2ILInjected.Token(Token = "0x6000187")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4E684", Offset = "0x1D4E684", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "Start", MemberTypeParameters = new object[] { typeof(MonoTlsStream.<CreateStream>d__18) }, MemberParameters = new object[] { typeof(ref MonoTlsStream.<CreateStream>d__18) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal Task<Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000311F File Offset: 0x0000131F
		[global::Cpp2ILInjected.Token(Token = "0x6000188")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4E788", Offset = "0x1D4E788", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "CloseSocket", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00003122 File Offset: 0x00001322
		[global::Cpp2ILInjected.Token(Token = "0x6000189")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4E78C", Offset = "0x1D4E78C", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoTlsStream.<CreateStream>d__18), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void CloseSslStream()
		{
			throw null;
		}

		// Token: 0x04000063 RID: 99
		[global::Cpp2ILInjected.Token(Token = "0x400011E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly MobileTlsProvider provider;

		// Token: 0x04000064 RID: 100
		[global::Cpp2ILInjected.Token(Token = "0x400011F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly NetworkStream networkStream;

		// Token: 0x04000065 RID: 101
		[global::Cpp2ILInjected.Token(Token = "0x4000120")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly HttpWebRequest request;

		// Token: 0x04000066 RID: 102
		[global::Cpp2ILInjected.Token(Token = "0x4000121")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly MonoTlsSettings settings;

		// Token: 0x04000067 RID: 103
		[global::Cpp2ILInjected.Token(Token = "0x4000122")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private SslStream sslStream;

		// Token: 0x04000068 RID: 104
		[global::Cpp2ILInjected.Token(Token = "0x4000123")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly object sslStreamLock;

		// Token: 0x04000069 RID: 105
		[global::Cpp2ILInjected.Token(Token = "0x4000124")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private WebExceptionStatus status;

		// Token: 0x0400006A RID: 106
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000125")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private bool <CertificateValidationFailed>k__BackingField;

		// Token: 0x020003AB RID: 939
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000066")]
		[StructLayout(3)]
		private struct <CreateStream>d__18 : IAsyncStateMachine
		{
			// Token: 0x06001D15 RID: 7445 RVA: 0x00008033 File Offset: 0x00006233
			[global::Cpp2ILInjected.Token(Token = "0x600018A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4E860", Offset = "0x1D4E860", Length = "0x5BC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStream), Member = "get_InternalSocket", ReturnType = typeof(Socket))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Stream),
				typeof(bool),
				typeof(MonoTlsProvider),
				typeof(MonoTlsSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "get_Host", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "get_ClientCertificates", ReturnType = typeof(X509CertificateCollection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "get_ServicePoint", ReturnType = typeof(ServicePoint))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePoint), Member = "UpdateClientCertificate", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetResult", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(MonoTlsStream.<CreateStream>d__18)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref MonoTlsStream.<CreateStream>d__18)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsStream), Member = "CloseSslStream", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Socket), Member = "get_CleanedUp", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001D16 RID: 7446 RVA: 0x00008036 File Offset: 0x00006236
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600018B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4EE1C", Offset = "0x1D4EE1C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x0400106C RID: 4204
			[global::Cpp2ILInjected.Token(Token = "0x4000126")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400106D RID: 4205
			[global::Cpp2ILInjected.Token(Token = "0x4000127")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<Stream> <>t__builder;

			// Token: 0x0400106E RID: 4206
			[global::Cpp2ILInjected.Token(Token = "0x4000128")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public MonoTlsStream <>4__this;

			// Token: 0x0400106F RID: 4207
			[global::Cpp2ILInjected.Token(Token = "0x4000129")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public WebConnectionTunnel tunnel;

			// Token: 0x04001070 RID: 4208
			[global::Cpp2ILInjected.Token(Token = "0x400012A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public CancellationToken cancellationToken;

			// Token: 0x04001071 RID: 4209
			[global::Cpp2ILInjected.Token(Token = "0x400012B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private Socket <socket>5__2;

			// Token: 0x04001072 RID: 4210
			[global::Cpp2ILInjected.Token(Token = "0x400012C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
