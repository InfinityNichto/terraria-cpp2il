using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Interface;
using Mono.Unity;

namespace Mono.Net.Security
{
	// Token: 0x0200001B RID: 27
	[global::Cpp2ILInjected.Token(Token = "0x2000057")]
	internal abstract class MobileAuthenticatedStream : AuthenticatedStream, IDisposable
	{
		// Token: 0x0600008B RID: 139 RVA: 0x00002FCC File Offset: 0x000011CC
		[global::Cpp2ILInjected.Token(Token = "0x60000F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4721C", Offset = "0x1D4721C", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(SslStream),
			typeof(MonoTlsSettings),
			typeof(MobileTlsProvider)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticatedStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferOffsetSize2), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public MobileAuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider)
		{
			throw null;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00002FCF File Offset: 0x000011CF
		[global::Cpp2ILInjected.Token(Token = "0x17000023")]
		public SslStream SslStream
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4A670", Offset = "0x1D4A670", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002FD2 File Offset: 0x000011D2
		[global::Cpp2ILInjected.Token(Token = "0x17000024")]
		public MonoTlsSettings Settings
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4A678", Offset = "0x1D4A678", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00002FD5 File Offset: 0x000011D5
		[global::Cpp2ILInjected.Token(Token = "0x17000025")]
		public MobileTlsProvider Provider
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4A680", Offset = "0x1D4A680", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00002FD8 File Offset: 0x000011D8
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002FDB File Offset: 0x000011DB
		[global::Cpp2ILInjected.Token(Token = "0x17000026")]
		internal string TargetHost
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4A688", Offset = "0x1D4A688", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4A690", Offset = "0x1D4A690", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002FDE File Offset: 0x000011DE
		[global::Cpp2ILInjected.Token(Token = "0x60000F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4A698", Offset = "0x1D4A698", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream.<StartOperation>d__57), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "get_LocalCertificate", ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck = false)
		{
			throw null;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002FE1 File Offset: 0x000011E1
		[global::Cpp2ILInjected.Token(Token = "0x60000F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D488A0", Offset = "0x1D488A0", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest.<ProcessOperation>d__24", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream.<ProcessAuthentication>d__48), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "ProcessHandshake", MemberParameters = new object[]
		{
			typeof(AsyncOperationStatus),
			typeof(bool)
		}, ReturnType = typeof(AsyncOperationStatus))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static Exception GetSSPIException(Exception e)
		{
			throw null;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002FE4 File Offset: 0x000011E4
		[global::Cpp2ILInjected.Token(Token = "0x60000FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4A758", Offset = "0x1D4A758", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream.<StartOperation>d__57), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "InternalRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "InternalWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static Exception GetIOException(Exception e, string message)
		{
			throw null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002FE7 File Offset: 0x000011E7
		[global::Cpp2ILInjected.Token(Token = "0x60000FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4A8D4", Offset = "0x1D4A8D4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "InternalWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "ProcessHandshake", MemberParameters = new object[]
		{
			typeof(AsyncOperationStatus),
			typeof(bool)
		}, ReturnType = typeof(AsyncOperationStatus))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "ProcessRead", MemberParameters = new object[] { typeof(BufferOffsetSize) }, ReturnType = typeof(ValueTuple<int, bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "ProcessWrite", MemberParameters = new object[] { typeof(BufferOffsetSize) }, ReturnType = typeof(ValueTuple<int, bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static Exception GetInternalError()
		{
			throw null;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002FEA File Offset: 0x000011EA
		[global::Cpp2ILInjected.Token(Token = "0x60000FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4A920", Offset = "0x1D4A920", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream.<ProcessAuthentication>d__48), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream.<StartOperation>d__57), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static Exception GetInvalidNestedCallException()
		{
			throw null;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002FED File Offset: 0x000011ED
		[global::Cpp2ILInjected.Token(Token = "0x60000FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D483B4", Offset = "0x1D483B4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal ExceptionDispatchInfo SetException(Exception e)
		{
			throw null;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002FF0 File Offset: 0x000011F0
		[global::Cpp2ILInjected.Token(Token = "0x60000FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4A96C", Offset = "0x1D4A96C", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SslStream), Member = "AuthenticateAsClient", MemberParameters = new object[]
		{
			typeof(string),
			typeof(X509CertificateCollection),
			typeof(SslProtocols),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoSslClientAuthenticationOptions), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_None", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "ProcessAuthentication", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(MonoSslAuthenticationOptions),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Wait", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "FlattenException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			throw null;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002FF3 File Offset: 0x000011F3
		[global::Cpp2ILInjected.Token(Token = "0x60000FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4AC94", Offset = "0x1D4AC94", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SslStream), Member = "AuthenticateAsServer", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(bool),
			typeof(SslProtocols),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoSslServerAuthenticationOptions), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_None", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "ProcessAuthentication", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(MonoSslAuthenticationOptions),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Wait", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "FlattenException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public void AuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			throw null;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002FF6 File Offset: 0x000011F6
		[global::Cpp2ILInjected.Token(Token = "0x6000100")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4AEC8", Offset = "0x1D4AEC8", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SslStream), Member = "BeginAuthenticateAsClient", MemberParameters = new object[]
		{
			typeof(string),
			typeof(X509CertificateCollection),
			typeof(SslProtocols),
			typeof(bool),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SslStream), Member = "AuthenticateAsClientAsync", MemberParameters = new object[]
		{
			typeof(string),
			typeof(X509CertificateCollection),
			typeof(SslProtocols),
			typeof(bool)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoSslClientAuthenticationOptions), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_None", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "ProcessAuthentication", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(MonoSslAuthenticationOptions),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			throw null;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002FF9 File Offset: 0x000011F9
		[global::Cpp2ILInjected.Token(Token = "0x6000101")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4ABA0", Offset = "0x1D4ABA0", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "AuthenticateAsClient", MemberParameters = new object[]
		{
			typeof(string),
			typeof(X509CertificateCollection),
			typeof(SslProtocols),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "AuthenticateAsServer", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(bool),
			typeof(SslProtocols),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "AuthenticateAsClientAsync", MemberParameters = new object[]
		{
			typeof(string),
			typeof(X509CertificateCollection),
			typeof(SslProtocols),
			typeof(bool)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Create", ReturnType = typeof(AsyncTaskMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(MobileAuthenticatedStream.<ProcessAuthentication>d__48) }, MemberParameters = new object[] { typeof(ref MobileAuthenticatedStream.<ProcessAuthentication>d__48) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private Task ProcessAuthentication(bool runSynchronously, MonoSslAuthenticationOptions options, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600009B RID: 155
		[global::Cpp2ILInjected.Token(Token = "0x6000102")]
		protected abstract MobileTlsContext CreateContext(MonoSslAuthenticationOptions options);

		// Token: 0x0600009C RID: 156 RVA: 0x00002FFC File Offset: 0x000011FC
		[global::Cpp2ILInjected.Token(Token = "0x6000103")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4AFE4", Offset = "0x1D4AFE4", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncReadOrWriteRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream),
			typeof(bool),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_None", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "StartOperation", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream.OperationType),
			typeof(AsyncProtocolRequest),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<int>), Member = "get_Result", ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002FFF File Offset: 0x000011FF
		[global::Cpp2ILInjected.Token(Token = "0x6000104")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4B1D8", Offset = "0x1D4B1D8", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncReadOrWriteRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream),
			typeof(bool),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_None", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "StartOperation", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream.OperationType),
			typeof(AsyncProtocolRequest),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Wait", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003002 File Offset: 0x00001202
		[global::Cpp2ILInjected.Token(Token = "0x6000105")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4B29C", Offset = "0x1D4B29C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncReadOrWriteRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream),
			typeof(bool),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "StartOperation", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream.OperationType),
			typeof(AsyncProtocolRequest),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00003005 File Offset: 0x00001205
		[global::Cpp2ILInjected.Token(Token = "0x6000106")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4B330", Offset = "0x1D4B330", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncReadOrWriteRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream),
			typeof(bool),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "StartOperation", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream.OperationType),
			typeof(AsyncProtocolRequest),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00003008 File Offset: 0x00001208
		[global::Cpp2ILInjected.Token(Token = "0x6000107")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4B0BC", Offset = "0x1D4B0BC", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "Start", MemberTypeParameters = new object[] { typeof(MobileAuthenticatedStream.<StartOperation>d__57) }, MemberParameters = new object[] { typeof(ref MobileAuthenticatedStream.<StartOperation>d__57) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private Task<int> StartOperation(MobileAuthenticatedStream.OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000300B File Offset: 0x0000120B
		[global::Cpp2ILInjected.Token(Token = "0x6000108")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D45AFC", Offset = "0x1D45AFC", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "ReadCallback", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(IntPtr),
			typeof(UnityTls.unitytls_errorstate*)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "InternalRead", MemberParameters = new object[]
		{
			typeof(AsyncProtocolRequest),
			typeof(BufferOffsetSize),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(ValueTuple<int, bool>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "GetIOException", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(string)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal unsafe int InternalRead(byte[] buffer, int offset, int size, out bool outWantMore)
		{
			throw null;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000300E File Offset: 0x0000120E
		[global::Cpp2ILInjected.Token(Token = "0x6000109")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4B3C4", Offset = "0x1D4B3C4", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "InternalRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTuple<int, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncProtocolRequest), Member = "RequestRead", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private ValueTuple<int, bool> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003011 File Offset: 0x00001211
		[global::Cpp2ILInjected.Token(Token = "0x600010A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D45664", Offset = "0x1D45664", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "WriteCallback", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(IntPtr),
			typeof(UnityTls.unitytls_errorstate*)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "InternalWrite", MemberParameters = new object[]
		{
			typeof(AsyncProtocolRequest),
			typeof(BufferOffsetSize2),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "GetInternalError", ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "GetIOException", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(string)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		internal unsafe bool InternalWrite(byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00003014 File Offset: 0x00001214
		[global::Cpp2ILInjected.Token(Token = "0x600010B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4B534", Offset = "0x1D4B534", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "InternalWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferOffsetSize2), Member = "AppendData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferOffsetSize2), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00003017 File Offset: 0x00001217
		[global::Cpp2ILInjected.Token(Token = "0x600010C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D48E34", Offset = "0x1D48E34", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest.<InnerRead>d__25", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "Start", MemberTypeParameters = new object[] { typeof(MobileAuthenticatedStream.<InnerRead>d__66) }, MemberParameters = new object[] { typeof(ref MobileAuthenticatedStream.<InnerRead>d__66) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal Task<int> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000301A File Offset: 0x0000121A
		[global::Cpp2ILInjected.Token(Token = "0x600010D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D48A2C", Offset = "0x1D48A2C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest.<ProcessOperation>d__24", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Create", ReturnType = typeof(AsyncTaskMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(MobileAuthenticatedStream.<InnerWrite>d__67) }, MemberParameters = new object[] { typeof(ref MobileAuthenticatedStream.<InnerWrite>d__67) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal Task InnerWrite(bool sync, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000301D File Offset: 0x0000121D
		[global::Cpp2ILInjected.Token(Token = "0x600010E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D48FBC", Offset = "0x1D48FBC", Length = "0x39C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "GetInternalError", ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "GetSSPIException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status, bool renegotiate)
		{
			throw null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00003020 File Offset: 0x00001220
		[global::Cpp2ILInjected.Token(Token = "0x600010F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D494DC", Offset = "0x1D494DC", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncReadRequest), Member = "Run", MemberParameters = new object[] { typeof(AsyncOperationStatus) }, ReturnType = typeof(AsyncOperationStatus))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "GetInternalError", ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal ValueTuple<int, bool> ProcessRead(BufferOffsetSize userBuffer)
		{
			throw null;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00003023 File Offset: 0x00001223
		[global::Cpp2ILInjected.Token(Token = "0x6000110")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D49694", Offset = "0x1D49694", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncWriteRequest), Member = "Run", MemberParameters = new object[] { typeof(AsyncOperationStatus) }, ReturnType = typeof(AsyncOperationStatus))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "GetInternalError", ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal ValueTuple<int, bool> ProcessWrite(BufferOffsetSize userBuffer)
		{
			throw null;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00003026 File Offset: 0x00001226
		[global::Cpp2ILInjected.Token(Token = "0x17000027")]
		public override bool IsAuthenticated
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000111")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4B618", Offset = "0x1D4B618", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003029 File Offset: 0x00001229
		[global::Cpp2ILInjected.Token(Token = "0x6000112")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4B700", Offset = "0x1D4B700", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileTlsContext), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticatedStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000302C File Offset: 0x0000122C
		[global::Cpp2ILInjected.Token(Token = "0x6000113")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4B948", Offset = "0x1D4B948", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000302F File Offset: 0x0000122F
		[global::Cpp2ILInjected.Token(Token = "0x17000028")]
		public X509Certificate LocalCertificate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000114")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4B95C", Offset = "0x1D4B95C", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SslStream), Member = "get_LocalCertificate", ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "CheckThrow", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "get_InternalLocalCertificate", ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00003032 File Offset: 0x00001232
		[global::Cpp2ILInjected.Token(Token = "0x17000029")]
		public X509Certificate InternalLocalCertificate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000115")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4BA38", Offset = "0x1D4BA38", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "get_LocalCertificate", ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00003035 File Offset: 0x00001235
		[global::Cpp2ILInjected.Token(Token = "0x6000116")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4BB38", Offset = "0x1D4BB38", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003038 File Offset: 0x00001238
		[global::Cpp2ILInjected.Token(Token = "0x6000117")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4BB70", Offset = "0x1D4BB70", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000303B File Offset: 0x0000123B
		[global::Cpp2ILInjected.Token(Token = "0x1700002A")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000118")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4BB84", Offset = "0x1D4BB84", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000303E File Offset: 0x0000123E
		[global::Cpp2ILInjected.Token(Token = "0x1700002B")]
		public override bool CanTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000119")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4BBC0", Offset = "0x1D4BBC0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00003041 File Offset: 0x00001241
		[global::Cpp2ILInjected.Token(Token = "0x1700002C")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x600011A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4BBD0", Offset = "0x1D4BBD0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00003044 File Offset: 0x00001244
		[global::Cpp2ILInjected.Token(Token = "0x1700002D")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x600011B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4BC2C", Offset = "0x1D4BC2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00003047 File Offset: 0x00001247
		[global::Cpp2ILInjected.Token(Token = "0x1700002E")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x600011C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4BC34", Offset = "0x1D4BC34", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000304A File Offset: 0x0000124A
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000304D File Offset: 0x0000124D
		[global::Cpp2ILInjected.Token(Token = "0x1700002F")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x600011D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4BC44", Offset = "0x1D4BC44", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600011E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4BC54", Offset = "0x1D4BC54", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00003050 File Offset: 0x00001250
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00003053 File Offset: 0x00001253
		[global::Cpp2ILInjected.Token(Token = "0x17000030")]
		public override int ReadTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x600011F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4BC8C", Offset = "0x1D4BC8C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000120")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4BCA0", Offset = "0x1D4BCA0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00003056 File Offset: 0x00001256
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00003059 File Offset: 0x00001259
		[global::Cpp2ILInjected.Token(Token = "0x17000031")]
		public override int WriteTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000121")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4BCB4", Offset = "0x1D4BCB4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000122")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4BCC8", Offset = "0x1D4BCC8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000305C File Offset: 0x0000125C
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000123")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4BCDC", Offset = "0x1D4BCDC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static MobileAuthenticatedStream()
		{
			throw null;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000305F File Offset: 0x0000125F
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6000124")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4BD28", Offset = "0x1D4BD28", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void <InnerWrite>b__67_0()
		{
			throw null;
		}

		// Token: 0x0400003C RID: 60
		[global::Cpp2ILInjected.Token(Token = "0x40000CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private MobileTlsContext xobileTlsContext;

		// Token: 0x0400003D RID: 61
		[global::Cpp2ILInjected.Token(Token = "0x40000CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private ExceptionDispatchInfo lastException;

		// Token: 0x0400003E RID: 62
		[global::Cpp2ILInjected.Token(Token = "0x40000CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private AsyncProtocolRequest asyncHandshakeRequest;

		// Token: 0x0400003F RID: 63
		[global::Cpp2ILInjected.Token(Token = "0x40000D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private AsyncProtocolRequest asyncReadRequest;

		// Token: 0x04000040 RID: 64
		[global::Cpp2ILInjected.Token(Token = "0x40000D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private AsyncProtocolRequest asyncWriteRequest;

		// Token: 0x04000041 RID: 65
		[global::Cpp2ILInjected.Token(Token = "0x40000D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private BufferOffsetSize2 readBuffer;

		// Token: 0x04000042 RID: 66
		[global::Cpp2ILInjected.Token(Token = "0x40000D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private BufferOffsetSize2 writeBuffer;

		// Token: 0x04000043 RID: 67
		[global::Cpp2ILInjected.Token(Token = "0x40000D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private object ioLock;

		// Token: 0x04000044 RID: 68
		[global::Cpp2ILInjected.Token(Token = "0x40000D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private int closeRequested;

		// Token: 0x04000045 RID: 69
		[global::Cpp2ILInjected.Token(Token = "0x40000D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		private bool shutdown;

		// Token: 0x04000046 RID: 70
		[global::Cpp2ILInjected.Token(Token = "0x40000D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private MobileAuthenticatedStream.Operation operation;

		// Token: 0x04000047 RID: 71
		[global::Cpp2ILInjected.Token(Token = "0x40000D8")]
		private static int uniqueNameInteger;

		// Token: 0x04000048 RID: 72
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private readonly SslStream <SslStream>k__BackingField;

		// Token: 0x04000049 RID: 73
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private readonly MonoTlsSettings <Settings>k__BackingField;

		// Token: 0x0400004A RID: 74
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private readonly MobileTlsProvider <Provider>k__BackingField;

		// Token: 0x0400004B RID: 75
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private string <TargetHost>k__BackingField;

		// Token: 0x0400004C RID: 76
		[global::Cpp2ILInjected.Token(Token = "0x40000DD")]
		private static int nextId;

		// Token: 0x0400004D RID: 77
		[global::Cpp2ILInjected.Token(Token = "0x40000DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		internal readonly int ID;

		// Token: 0x020003A4 RID: 932
		[global::Cpp2ILInjected.Token(Token = "0x2000058")]
		private enum Operation
		{
			// Token: 0x04001043 RID: 4163
			[global::Cpp2ILInjected.Token(Token = "0x40000E0")]
			None,
			// Token: 0x04001044 RID: 4164
			[global::Cpp2ILInjected.Token(Token = "0x40000E1")]
			Handshake,
			// Token: 0x04001045 RID: 4165
			[global::Cpp2ILInjected.Token(Token = "0x40000E2")]
			Authenticated,
			// Token: 0x04001046 RID: 4166
			[global::Cpp2ILInjected.Token(Token = "0x40000E3")]
			Renegotiate,
			// Token: 0x04001047 RID: 4167
			[global::Cpp2ILInjected.Token(Token = "0x40000E4")]
			Read,
			// Token: 0x04001048 RID: 4168
			[global::Cpp2ILInjected.Token(Token = "0x40000E5")]
			Write,
			// Token: 0x04001049 RID: 4169
			[global::Cpp2ILInjected.Token(Token = "0x40000E6")]
			Close
		}

		// Token: 0x020003A5 RID: 933
		[global::Cpp2ILInjected.Token(Token = "0x2000059")]
		private enum OperationType
		{
			// Token: 0x0400104B RID: 4171
			[global::Cpp2ILInjected.Token(Token = "0x40000E8")]
			Read,
			// Token: 0x0400104C RID: 4172
			[global::Cpp2ILInjected.Token(Token = "0x40000E9")]
			Write,
			// Token: 0x0400104D RID: 4173
			[global::Cpp2ILInjected.Token(Token = "0x40000EA")]
			Renegotiate,
			// Token: 0x0400104E RID: 4174
			[global::Cpp2ILInjected.Token(Token = "0x40000EB")]
			Shutdown
		}

		// Token: 0x020003A6 RID: 934
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200005A")]
		[StructLayout(3)]
		private struct <ProcessAuthentication>d__48 : IAsyncStateMachine
		{
			// Token: 0x06001D0B RID: 7435 RVA: 0x00008015 File Offset: 0x00006215
			[global::Cpp2ILInjected.Token(Token = "0x6000125")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4BD4C", Offset = "0x1D4BD4C", Length = "0x7E8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncProtocolRequest), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(MobileAuthenticatedStream),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferOffsetSize2), Member = "Reset", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncProtocolRequest), Member = "StartOperation", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task<AsyncProtocolResult>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(MobileAuthenticatedStream.<ProcessAuthentication>d__48)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(ref MobileAuthenticatedStream.<ProcessAuthentication>d__48)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "GetInvalidNestedCallException", ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "GetSSPIException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(ExceptionDispatchInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 68)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001D0C RID: 7436 RVA: 0x00008018 File Offset: 0x00006218
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000126")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4C534", Offset = "0x1D4C534", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x0400104F RID: 4175
			[global::Cpp2ILInjected.Token(Token = "0x40000EC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001050 RID: 4176
			[global::Cpp2ILInjected.Token(Token = "0x40000ED")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001051 RID: 4177
			[global::Cpp2ILInjected.Token(Token = "0x40000EE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public MonoSslAuthenticationOptions options;

			// Token: 0x04001052 RID: 4178
			[global::Cpp2ILInjected.Token(Token = "0x40000EF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public MobileAuthenticatedStream <>4__this;

			// Token: 0x04001053 RID: 4179
			[global::Cpp2ILInjected.Token(Token = "0x40000F0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public bool runSynchronously;

			// Token: 0x04001054 RID: 4180
			[global::Cpp2ILInjected.Token(Token = "0x40000F1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public CancellationToken cancellationToken;

			// Token: 0x04001055 RID: 4181
			[global::Cpp2ILInjected.Token(Token = "0x40000F2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020003A7 RID: 935
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200005B")]
		[StructLayout(3)]
		private struct <StartOperation>d__57 : IAsyncStateMachine
		{
			// Token: 0x06001D0D RID: 7437 RVA: 0x0000801B File Offset: 0x0000621B
			[global::Cpp2ILInjected.Token(Token = "0x6000127")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4C540", Offset = "0x1D4C540", Length = "0x6AC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "CheckThrow", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "GetInvalidNestedCallException", ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferOffsetSize2), Member = "Reset", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncProtocolRequest), Member = "StartOperation", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task<AsyncProtocolResult>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(MobileAuthenticatedStream.<StartOperation>d__57)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(ref MobileAuthenticatedStream.<StartOperation>d__57)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MobileAuthenticatedStream), Member = "GetIOException", MemberParameters = new object[]
			{
				typeof(Exception),
				typeof(string)
			}, ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(ExceptionDispatchInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetResult", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 62)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001D0E RID: 7438 RVA: 0x0000801E File Offset: 0x0000621E
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000128")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4CBEC", Offset = "0x1D4CBEC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x04001056 RID: 4182
			[global::Cpp2ILInjected.Token(Token = "0x40000F3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001057 RID: 4183
			[global::Cpp2ILInjected.Token(Token = "0x40000F4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04001058 RID: 4184
			[global::Cpp2ILInjected.Token(Token = "0x40000F5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public MobileAuthenticatedStream <>4__this;

			// Token: 0x04001059 RID: 4185
			[global::Cpp2ILInjected.Token(Token = "0x40000F6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public MobileAuthenticatedStream.OperationType type;

			// Token: 0x0400105A RID: 4186
			[global::Cpp2ILInjected.Token(Token = "0x40000F7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public AsyncProtocolRequest asyncRequest;

			// Token: 0x0400105B RID: 4187
			[global::Cpp2ILInjected.Token(Token = "0x40000F8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public CancellationToken cancellationToken;

			// Token: 0x0400105C RID: 4188
			[global::Cpp2ILInjected.Token(Token = "0x40000F9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable<AsyncProtocolResult>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020003A8 RID: 936
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200005C")]
		private sealed class <>c__DisplayClass66_0
		{
			// Token: 0x06001D0F RID: 7439 RVA: 0x00008021 File Offset: 0x00006221
			[global::Cpp2ILInjected.Token(Token = "0x6000129")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4CC44", Offset = "0x1D4CC44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass66_0()
			{
				throw null;
			}

			// Token: 0x06001D10 RID: 7440 RVA: 0x00008024 File Offset: 0x00006224
			[global::Cpp2ILInjected.Token(Token = "0x600012A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4CC4C", Offset = "0x1D4CC4C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal int <InnerRead>b__0()
			{
				throw null;
			}

			// Token: 0x0400105D RID: 4189
			[global::Cpp2ILInjected.Token(Token = "0x40000FA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public MobileAuthenticatedStream <>4__this;

			// Token: 0x0400105E RID: 4190
			[global::Cpp2ILInjected.Token(Token = "0x40000FB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int len;
		}

		// Token: 0x020003A9 RID: 937
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200005D")]
		[StructLayout(3)]
		private struct <InnerRead>d__66 : IAsyncStateMachine
		{
			// Token: 0x06001D11 RID: 7441 RVA: 0x00008027 File Offset: 0x00006227
			[global::Cpp2ILInjected.Token(Token = "0x600012B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4CC7C", Offset = "0x1D4CC7C", Length = "0x3BC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<int>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Run", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { "System.Func`1<TResult>" }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<int>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetResult", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
				typeof(MobileAuthenticatedStream.<InnerRead>d__66)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
				typeof(ref MobileAuthenticatedStream.<InnerRead>d__66)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001D12 RID: 7442 RVA: 0x0000802A File Offset: 0x0000622A
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600012C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D038", Offset = "0x1D4D038", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x0400105F RID: 4191
			[global::Cpp2ILInjected.Token(Token = "0x40000FC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001060 RID: 4192
			[global::Cpp2ILInjected.Token(Token = "0x40000FD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04001061 RID: 4193
			[global::Cpp2ILInjected.Token(Token = "0x40000FE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public MobileAuthenticatedStream <>4__this;

			// Token: 0x04001062 RID: 4194
			[global::Cpp2ILInjected.Token(Token = "0x40000FF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			// Token: 0x04001063 RID: 4195
			[global::Cpp2ILInjected.Token(Token = "0x4000100")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public int requestedSize;

			// Token: 0x04001064 RID: 4196
			[global::Cpp2ILInjected.Token(Token = "0x4000101")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			public bool sync;

			// Token: 0x04001065 RID: 4197
			[global::Cpp2ILInjected.Token(Token = "0x4000102")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x020003AA RID: 938
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200005E")]
		[StructLayout(3)]
		private struct <InnerWrite>d__67 : IAsyncStateMachine
		{
			// Token: 0x06001D13 RID: 7443 RVA: 0x0000802D File Offset: 0x0000622D
			[global::Cpp2ILInjected.Token(Token = "0x600012D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D090", Offset = "0x1D4D090", Length = "0x23C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Run", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "WriteAsync", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(MobileAuthenticatedStream.<InnerWrite>d__67)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref MobileAuthenticatedStream.<InnerWrite>d__67)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001D14 RID: 7444 RVA: 0x00008030 File Offset: 0x00006230
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600012E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D2CC", Offset = "0x1D4D2CC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x04001066 RID: 4198
			[global::Cpp2ILInjected.Token(Token = "0x4000103")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001067 RID: 4199
			[global::Cpp2ILInjected.Token(Token = "0x4000104")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001068 RID: 4200
			[global::Cpp2ILInjected.Token(Token = "0x4000105")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public CancellationToken cancellationToken;

			// Token: 0x04001069 RID: 4201
			[global::Cpp2ILInjected.Token(Token = "0x4000106")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public MobileAuthenticatedStream <>4__this;

			// Token: 0x0400106A RID: 4202
			[global::Cpp2ILInjected.Token(Token = "0x4000107")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public bool sync;

			// Token: 0x0400106B RID: 4203
			[global::Cpp2ILInjected.Token(Token = "0x4000108")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
