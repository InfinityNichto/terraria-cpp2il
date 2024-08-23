using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security;
using Mono.Net.Security.Private;
using Mono.Security.Interface;

namespace System.Net.Security
{
	// Token: 0x02000233 RID: 563
	[global::Cpp2ILInjected.Token(Token = "0x2000323")]
	public class SslStream : AuthenticatedStream
	{
		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001280 RID: 4736 RVA: 0x00006311 File Offset: 0x00004511
		[global::Cpp2ILInjected.Token(Token = "0x170004B8")]
		internal MobileAuthenticatedStream Impl
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E383E4", Offset = "0x1E383E4", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x00006314 File Offset: 0x00004514
		[global::Cpp2ILInjected.Token(Token = "0x170004B9")]
		internal string InternalTargetHost
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E38458", Offset = "0x1E38458", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.ChainValidationHelper.<>c__DisplayClass11_0", Member = "<GetValidationCallback>b__0", MemberParameters = new object[]
			{
				typeof(object),
				typeof(X509Certificate),
				typeof(X509Chain),
				typeof(SslPolicyErrors)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00006317 File Offset: 0x00004517
		[global::Cpp2ILInjected.Token(Token = "0x60014BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38474", Offset = "0x1E38474", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(RemoteCertificateValidationCallback),
			typeof(LocalCertificateSelectionCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Interface.MonoTlsProviderFactory), Member = "GetProvider", ReturnType = typeof(MonoTlsProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static MobileTlsProvider GetProvider()
		{
			throw null;
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x0000631A File Offset: 0x0000451A
		[global::Cpp2ILInjected.Token(Token = "0x60014BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E384E4", Offset = "0x1E384E4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TlsStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(NetworkStream),
			typeof(Socket),
			typeof(string),
			typeof(X509CertificateCollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback)
		{
			throw null;
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x0000631D File Offset: 0x0000451D
		[global::Cpp2ILInjected.Token(Token = "0x60014C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E384F0", Offset = "0x1E384F0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticatedStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "GetProvider", ReturnType = typeof(MobileTlsProvider))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsSettings), Member = "CopyDefaultSettings", ReturnType = typeof(MonoTlsSettings))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "SetAndVerifyValidationCallback", MemberParameters = new object[] { typeof(RemoteCertificateValidationCallback) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "SetAndVerifySelectionCallback", MemberParameters = new object[] { typeof(LocalCertificateSelectionCallback) }, ReturnType = typeof(void))]
		public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback)
		{
			throw null;
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00006320 File Offset: 0x00004520
		[global::Cpp2ILInjected.Token(Token = "0x60014C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38798", Offset = "0x1E38798", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MonoTlsStream.<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "CreateSslStream", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(RemoteCertificateValidationCallback)
		}, ReturnType = typeof(SslStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticatedStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsSettings), Member = "Clone", ReturnType = typeof(MonoTlsSettings))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal SslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings)
		{
			throw null;
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00006323 File Offset: 0x00004523
		[global::Cpp2ILInjected.Token(Token = "0x60014C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38574", Offset = "0x1E38574", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(RemoteCertificateValidationCallback),
			typeof(LocalCertificateSelectionCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CallbackHelpers), Member = "PublicToMono", MemberParameters = new object[] { typeof(RemoteCertificateValidationCallback) }, ReturnType = typeof(MonoRemoteCertificateValidationCallback))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback)
		{
			throw null;
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x00006326 File Offset: 0x00004526
		[global::Cpp2ILInjected.Token(Token = "0x60014C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38640", Offset = "0x1E38640", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(RemoteCertificateValidationCallback),
			typeof(LocalCertificateSelectionCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoLocalCertificateSelectionCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback)
		{
			throw null;
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00006329 File Offset: 0x00004529
		[global::Cpp2ILInjected.Token(Token = "0x60014C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E388B0", Offset = "0x1E388B0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "AuthenticateAsClient", MemberParameters = new object[]
		{
			typeof(string),
			typeof(X509CertificateCollection),
			typeof(SslProtocols),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			throw null;
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x0000632C File Offset: 0x0000452C
		[global::Cpp2ILInjected.Token(Token = "0x60014C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E388FC", Offset = "0x1E388FC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "AuthenticateAsClientAsync", MemberParameters = new object[]
		{
			typeof(string),
			typeof(X509CertificateCollection),
			typeof(SslProtocols),
			typeof(bool)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "Begin", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState)
		{
			throw null;
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x0000632F File Offset: 0x0000452F
		[global::Cpp2ILInjected.Token(Token = "0x60014C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38968", Offset = "0x1E38968", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "End", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00006332 File Offset: 0x00004532
		[global::Cpp2ILInjected.Token(Token = "0x60014C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38974", Offset = "0x1E38974", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "AuthenticateAsServer", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(bool),
			typeof(SslProtocols),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public virtual void AuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			throw null;
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00006335 File Offset: 0x00004535
		[global::Cpp2ILInjected.Token(Token = "0x60014C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E389C0", Offset = "0x1E389C0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "AuthenticateAsClientAsync", MemberParameters = new object[]
		{
			typeof(string),
			typeof(X509CertificateCollection),
			typeof(SslProtocols),
			typeof(bool)
		}, ReturnType = typeof(Task))]
		public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			throw null;
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x00006338 File Offset: 0x00004538
		[global::Cpp2ILInjected.Token(Token = "0x170004BA")]
		public override bool IsAuthenticated
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E38A0C", Offset = "0x1E38A0C", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x0600128E RID: 4750 RVA: 0x0000633B File Offset: 0x0000453B
		[global::Cpp2ILInjected.Token(Token = "0x170004BB")]
		public virtual X509Certificate LocalCertificate
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E38A30", Offset = "0x1E38A30", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "get_LocalCertificate", ReturnType = typeof(X509Certificate))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x0000633E File Offset: 0x0000453E
		[global::Cpp2ILInjected.Token(Token = "0x170004BC")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E38A4C", Offset = "0x1E38A4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001290 RID: 4752 RVA: 0x00006341 File Offset: 0x00004541
		[global::Cpp2ILInjected.Token(Token = "0x170004BD")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E38A54", Offset = "0x1E38A54", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x00006344 File Offset: 0x00004544
		[global::Cpp2ILInjected.Token(Token = "0x170004BE")]
		public override bool CanTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E38A6C", Offset = "0x1E38A6C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x00006347 File Offset: 0x00004547
		[global::Cpp2ILInjected.Token(Token = "0x170004BF")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E38A7C", Offset = "0x1E38A7C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x0000634A File Offset: 0x0000454A
		// (set) Token: 0x06001294 RID: 4756 RVA: 0x0000634D File Offset: 0x0000454D
		[global::Cpp2ILInjected.Token(Token = "0x170004C0")]
		public override int ReadTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E38A94", Offset = "0x1E38A94", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60014D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E38AB8", Offset = "0x1E38AB8", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x00006350 File Offset: 0x00004550
		// (set) Token: 0x06001296 RID: 4758 RVA: 0x00006353 File Offset: 0x00004553
		[global::Cpp2ILInjected.Token(Token = "0x170004C1")]
		public override int WriteTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E38AEC", Offset = "0x1E38AEC", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60014D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E38B10", Offset = "0x1E38B10", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x00006356 File Offset: 0x00004556
		[global::Cpp2ILInjected.Token(Token = "0x170004C2")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E38B44", Offset = "0x1E38B44", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x00006359 File Offset: 0x00004559
		// (set) Token: 0x06001299 RID: 4761 RVA: 0x0000635C File Offset: 0x0000455C
		[global::Cpp2ILInjected.Token(Token = "0x170004C3")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E38B64", Offset = "0x1E38B64", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60014D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E38B84", Offset = "0x1E38B84", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x0000635F File Offset: 0x0000455F
		[global::Cpp2ILInjected.Token(Token = "0x60014D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38BDC", Offset = "0x1E38BDC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00006362 File Offset: 0x00004562
		[global::Cpp2ILInjected.Token(Token = "0x60014D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38C10", Offset = "0x1E38C10", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00006365 File Offset: 0x00004565
		[global::Cpp2ILInjected.Token(Token = "0x60014D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38C68", Offset = "0x1E38C68", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00006368 File Offset: 0x00004568
		[global::Cpp2ILInjected.Token(Token = "0x60014D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38C7C", Offset = "0x1E38C7C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x0000636B File Offset: 0x0000456B
		[global::Cpp2ILInjected.Token(Token = "0x60014DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E383FC", Offset = "0x1E383FC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void CheckDisposed()
		{
			throw null;
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x0000636E File Offset: 0x0000456E
		[global::Cpp2ILInjected.Token(Token = "0x60014DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38C90", Offset = "0x1E38C90", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticatedStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00006371 File Offset: 0x00004571
		[global::Cpp2ILInjected.Token(Token = "0x60014DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38D3C", Offset = "0x1E38D3C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x00006374 File Offset: 0x00004574
		[global::Cpp2ILInjected.Token(Token = "0x60014DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38D88", Offset = "0x1E38D88", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x00006377 File Offset: 0x00004577
		[global::Cpp2ILInjected.Token(Token = "0x60014DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38DD4", Offset = "0x1E38DD4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0000637A File Offset: 0x0000457A
		[global::Cpp2ILInjected.Token(Token = "0x60014DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38E28", Offset = "0x1E38E28", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x0000637D File Offset: 0x0000457D
		[global::Cpp2ILInjected.Token(Token = "0x60014E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38E7C", Offset = "0x1E38E7C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "Begin", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x00006380 File Offset: 0x00004580
		[global::Cpp2ILInjected.Token(Token = "0x60014E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38EE0", Offset = "0x1E38EE0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "End", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int EndRead(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x00006383 File Offset: 0x00004583
		[global::Cpp2ILInjected.Token(Token = "0x60014E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38F28", Offset = "0x1E38F28", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "Begin", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x00006386 File Offset: 0x00004586
		[global::Cpp2ILInjected.Token(Token = "0x60014E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E38F8C", Offset = "0x1E38F8C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "End", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		public override void EndWrite(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x04000D59 RID: 3417
		[global::Cpp2ILInjected.Token(Token = "0x4001154")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private MobileTlsProvider provider;

		// Token: 0x04000D5A RID: 3418
		[global::Cpp2ILInjected.Token(Token = "0x4001155")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private MonoTlsSettings settings;

		// Token: 0x04000D5B RID: 3419
		[global::Cpp2ILInjected.Token(Token = "0x4001156")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private RemoteCertificateValidationCallback validationCallback;

		// Token: 0x04000D5C RID: 3420
		[global::Cpp2ILInjected.Token(Token = "0x4001157")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private LocalCertificateSelectionCallback selectionCallback;

		// Token: 0x04000D5D RID: 3421
		[global::Cpp2ILInjected.Token(Token = "0x4001158")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private MobileAuthenticatedStream impl;

		// Token: 0x04000D5E RID: 3422
		[global::Cpp2ILInjected.Token(Token = "0x4001159")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private bool explicitSettings;

		// Token: 0x02000452 RID: 1106
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000324")]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x06001ED2 RID: 7890 RVA: 0x000084F5 File Offset: 0x000066F5
			[global::Cpp2ILInjected.Token(Token = "0x60014E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E388A8", Offset = "0x1E388A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass21_0()
			{
				throw null;
			}

			// Token: 0x06001ED3 RID: 7891 RVA: 0x000084F8 File Offset: 0x000066F8
			[global::Cpp2ILInjected.Token(Token = "0x60014E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E38F98", Offset = "0x1E38F98", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal X509Certificate <SetAndVerifySelectionCallback>b__0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai)
			{
				throw null;
			}

			// Token: 0x0400137F RID: 4991
			[global::Cpp2ILInjected.Token(Token = "0x400115A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public LocalCertificateSelectionCallback callback;

			// Token: 0x04001380 RID: 4992
			[global::Cpp2ILInjected.Token(Token = "0x400115B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public SslStream <>4__this;
		}
	}
}
