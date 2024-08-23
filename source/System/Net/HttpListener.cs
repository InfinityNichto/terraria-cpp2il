using System;
using System.Collections;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security.Private;
using Mono.Security.Authenticode;
using Mono.Security.Interface;

namespace System.Net
{
	// Token: 0x02000195 RID: 405
	[global::Cpp2ILInjected.Token(Token = "0x2000249")]
	public sealed class HttpListener : IDisposable
	{
		// Token: 0x06000D48 RID: 3400 RVA: 0x00005417 File Offset: 0x00003617
		[global::Cpp2ILInjected.Token(Token = "0x6000EC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4C274", Offset = "0x1F4C274", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = ".ctor", ReturnType = typeof(void))]
		internal HttpListener(X509Certificate certificate, MonoTlsProvider tlsProvider, MonoTlsSettings tlsSettings)
		{
			throw null;
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0000541A File Offset: 0x0000361A
		[global::Cpp2ILInjected.Token(Token = "0x6000EC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F446FC", Offset = "0x1F446FC", Length = "0x3E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(HttpListener),
			typeof(IPAddress),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new object[] { typeof(Environment.SpecialFolder) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PrivateKey), Member = "CreateFromFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(PrivateKey))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new object[] { typeof(X509Certificate2Impl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		internal X509Certificate LoadCertificateAndKey(IPAddress addr, int port)
		{
			throw null;
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x0000541D File Offset: 0x0000361D
		[global::Cpp2ILInjected.Token(Token = "0x6000ECA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F49644", Offset = "0x1F49644", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Socket),
			typeof(EndPointListener),
			typeof(bool),
			typeof(X509Certificate)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsProviderFactory), Member = "GetProvider", ReturnType = typeof(MonoTlsProvider))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsSettings), Member = "get_DefaultSettings", ReturnType = typeof(MonoTlsSettings))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsSettings), Member = "Clone", ReturnType = typeof(MonoTlsSettings))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CallbackHelpers), Member = "PublicToMono", MemberParameters = new object[] { typeof(RemoteCertificateValidationCallback) }, ReturnType = typeof(MonoRemoteCertificateValidationCallback))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(MonoTlsProvider),
			typeof(MonoTlsSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal SslStream CreateSslStream(Stream innerStream, bool ownsStream, RemoteCertificateValidationCallback callback)
		{
			throw null;
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00005420 File Offset: 0x00003620
		[global::Cpp2ILInjected.Token(Token = "0x6000ECB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4C2AC", Offset = "0x1F4C2AC", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(MonoTlsProvider),
			typeof(MonoTlsSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerPrefixCollection), Member = ".ctor", MemberParameters = new object[] { typeof(HttpListener) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = "Synchronized", MemberParameters = new object[] { typeof(Hashtable) }, ReturnType = typeof(Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServiceNameStore), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExtendedProtectionPolicy), Member = ".ctor", MemberParameters = new object[] { typeof(PolicyEnforcement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public HttpListener()
		{
			throw null;
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x00005423 File Offset: 0x00003623
		// (set) Token: 0x06000D4D RID: 3405 RVA: 0x00005426 File Offset: 0x00003626
		[global::Cpp2ILInjected.Token(Token = "0x17000310")]
		public AuthenticationSchemes AuthenticationSchemes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ECC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4C4D4", Offset = "0x1F4C4D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000ECD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4C4DC", Offset = "0x1F4C4DC", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x00005429 File Offset: 0x00003629
		// (set) Token: 0x06000D4F RID: 3407 RVA: 0x0000542C File Offset: 0x0000362C
		[global::Cpp2ILInjected.Token(Token = "0x17000311")]
		public AuthenticationSchemeSelector AuthenticationSchemeSelectorDelegate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ECE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4C56C", Offset = "0x1F4C56C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000ECF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4C574", Offset = "0x1F4C574", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x0000542F File Offset: 0x0000362F
		// (set) Token: 0x06000D51 RID: 3409 RVA: 0x00005432 File Offset: 0x00003632
		[global::Cpp2ILInjected.Token(Token = "0x17000312")]
		public HttpListener.ExtendedProtectionSelector ExtendedProtectionSelectorDelegate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ED0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4C598", Offset = "0x1F4C598", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000ED1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4C5A0", Offset = "0x1F4C5A0", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x00005435 File Offset: 0x00003635
		// (set) Token: 0x06000D53 RID: 3411 RVA: 0x00005438 File Offset: 0x00003638
		[global::Cpp2ILInjected.Token(Token = "0x17000313")]
		public bool IgnoreWriteExceptions
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ED2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4C670", Offset = "0x1F4C670", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000ED3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4C678", Offset = "0x1F4C678", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000D54 RID: 3412 RVA: 0x0000543B File Offset: 0x0000363B
		[global::Cpp2ILInjected.Token(Token = "0x17000314")]
		public bool IsListening
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ED4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4C69C", Offset = "0x1F4C69C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x0000543E File Offset: 0x0000363E
		[global::Cpp2ILInjected.Token(Token = "0x17000315")]
		public static bool IsSupported
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ED5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4C6A4", Offset = "0x1F4C6A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x00005441 File Offset: 0x00003641
		[global::Cpp2ILInjected.Token(Token = "0x17000316")]
		public HttpListenerPrefixCollection Prefixes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ED6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F476D4", Offset = "0x1F476D4", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x00005444 File Offset: 0x00003644
		[MonoTODO]
		[global::Cpp2ILInjected.Token(Token = "0x17000317")]
		public HttpListenerTimeoutManager TimeoutManager
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ED7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4C6AC", Offset = "0x1F4C6AC", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000D58 RID: 3416 RVA: 0x00005447 File Offset: 0x00003647
		// (set) Token: 0x06000D59 RID: 3417 RVA: 0x0000544A File Offset: 0x0000364A
		[MonoTODO("not used anywhere in the implementation")]
		[global::Cpp2ILInjected.Token(Token = "0x17000318")]
		public ExtendedProtectionPolicy ExtendedProtectionPolicy
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ED8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4C6E4", Offset = "0x1F4C6E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000ED9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4C6EC", Offset = "0x1F4C6EC", Length = "0x170")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExtendedProtectionPolicy), Member = "get_PolicyEnforcement", ReturnType = typeof(PolicyEnforcement))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExtendedProtectionPolicy), Member = "get_CustomChannelBinding", ReturnType = typeof(ChannelBinding))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x0000544D File Offset: 0x0000364D
		[global::Cpp2ILInjected.Token(Token = "0x17000319")]
		public ServiceNameCollection DefaultServiceNames
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EDA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4C85C", Offset = "0x1F4C85C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServiceNameStore), Member = "get_ServiceNames", ReturnType = typeof(ServiceNameCollection))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x00005450 File Offset: 0x00003650
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x00005453 File Offset: 0x00003653
		[global::Cpp2ILInjected.Token(Token = "0x1700031A")]
		public string Realm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EDB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4C868", Offset = "0x1F4C868", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000EDC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4C870", Offset = "0x1F4C870", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x00005456 File Offset: 0x00003656
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x00005459 File Offset: 0x00003659
		[MonoTODO("Support for NTLM needs some loving.")]
		[global::Cpp2ILInjected.Token(Token = "0x1700031B")]
		public bool UnsafeConnectionNtlmAuthentication
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EDD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4C894", Offset = "0x1F4C894", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000EDE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4C89C", Offset = "0x1F4C89C", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x0000545C File Offset: 0x0000365C
		[global::Cpp2ILInjected.Token(Token = "0x6000EDF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4C8C0", Offset = "0x1F4C8C0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Abort()
		{
			throw null;
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x0000545F File Offset: 0x0000365F
		[global::Cpp2ILInjected.Token(Token = "0x6000EE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4C950", Offset = "0x1F4C950", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void Close()
		{
			throw null;
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00005462 File Offset: 0x00003662
		[global::Cpp2ILInjected.Token(Token = "0x6000EE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4C8DC", Offset = "0x1F4C8DC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "Stop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointManager), Member = "RemoveListener", MemberParameters = new object[] { typeof(HttpListener) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "Cleanup", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Close(bool force)
		{
			throw null;
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00005465 File Offset: 0x00003665
		[global::Cpp2ILInjected.Token(Token = "0x6000EE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4C984", Offset = "0x1F4C984", Length = "0x980")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 49)]
		private void Cleanup(bool close_existing)
		{
			throw null;
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00005468 File Offset: 0x00003668
		[global::Cpp2ILInjected.Token(Token = "0x6000EE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4D304", Offset = "0x1F4D304", Length = "0x29C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "GetContext", ReturnType = typeof(HttpListenerContext))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new object[]
		{
			typeof(HttpListenerContext),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListenerAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "GetContextFromQueue", ReturnType = typeof(HttpListenerContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new object[]
		{
			typeof(HttpListenerContext),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public IAsyncResult BeginGetContext(AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0000546B File Offset: 0x0000366B
		[global::Cpp2ILInjected.Token(Token = "0x6000EE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4D654", Offset = "0x1F4D654", Length = "0x2B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "GetContext", ReturnType = typeof(HttpListenerContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListenerAsyncResult), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListenerAsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListenerAsyncResult), Member = "GetContext", ReturnType = typeof(HttpListenerContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerContext), Member = "ParseAuthentication", MemberParameters = new object[] { typeof(AuthenticationSchemes) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public HttpListenerContext EndGetContext(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0000546E File Offset: 0x0000366E
		[global::Cpp2ILInjected.Token(Token = "0x6000EE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4D908", Offset = "0x1F4D908", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new object[]
		{
			typeof(HttpListenerContext),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal AuthenticationSchemes SelectAuthenticationScheme(HttpListenerContext context)
		{
			throw null;
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00005471 File Offset: 0x00003671
		[global::Cpp2ILInjected.Token(Token = "0x6000EE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4DA18", Offset = "0x1F4DA18", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "BeginGetContext", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "EndGetContext", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(HttpListenerContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public HttpListenerContext GetContext()
		{
			throw null;
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00005474 File Offset: 0x00003674
		[global::Cpp2ILInjected.Token(Token = "0x6000EE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4DB6C", Offset = "0x1F4DB6C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EndPointManager), Member = "AddListener", MemberParameters = new object[] { typeof(HttpListener) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Start()
		{
			throw null;
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00005477 File Offset: 0x00003677
		[global::Cpp2ILInjected.Token(Token = "0x6000EE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4DBDC", Offset = "0x1F4DBDC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void Stop()
		{
			throw null;
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0000547A File Offset: 0x0000367A
		[global::Cpp2ILInjected.Token(Token = "0x6000EE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4DBFC", Offset = "0x1F4DBFC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		private void System.IDisposable.Dispose()
		{
			throw null;
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x0000547D File Offset: 0x0000367D
		[global::Cpp2ILInjected.Token(Token = "0x6000EEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4DC2C", Offset = "0x1F4DC2C", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "get_Factory", ReturnType = "System.Threading.Tasks.TaskFactory`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskFactory<object>), Member = "FromAsync", MemberParameters = new object[]
		{
			typeof(Func<AsyncCallback, object, IAsyncResult>),
			typeof(Func<IAsyncResult, object>),
			typeof(object)
		}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public Task<HttpListenerContext> GetContextAsync()
		{
			throw null;
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00005480 File Offset: 0x00003680
		[global::Cpp2ILInjected.Token(Token = "0x6000EEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4C500", Offset = "0x1F4C500", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void CheckDisposed()
		{
			throw null;
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00005483 File Offset: 0x00003683
		[global::Cpp2ILInjected.Token(Token = "0x6000EEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4D5A0", Offset = "0x1F4D5A0", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "BeginGetContext", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private HttpListenerContext GetContextFromQueue()
		{
			throw null;
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00005486 File Offset: 0x00003686
		[global::Cpp2ILInjected.Token(Token = "0x6000EED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4AAD8", Offset = "0x1F4AAD8", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "OnReadInternal", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListenerAsyncResult), Member = "Complete", MemberParameters = new object[] { typeof(HttpListenerContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal void RegisterContext(HttpListenerContext context)
		{
			throw null;
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x00005489 File Offset: 0x00003689
		[global::Cpp2ILInjected.Token(Token = "0x6000EEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F45974", Offset = "0x1F45974", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "Unbind", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal void UnregisterContext(HttpListenerContext context)
		{
			throw null;
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0000548C File Offset: 0x0000368C
		[global::Cpp2ILInjected.Token(Token = "0x6000EEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4AAC0", Offset = "0x1F4AAC0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void AddConnection(HttpConnection cnc)
		{
			throw null;
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x0000548F File Offset: 0x0000368F
		[global::Cpp2ILInjected.Token(Token = "0x6000EF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4AE10", Offset = "0x1F4AE10", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void RemoveConnection(HttpConnection cnc)
		{
			throw null;
		}

		// Token: 0x0400095E RID: 2398
		[global::Cpp2ILInjected.Token(Token = "0x4000C15")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private MonoTlsProvider tlsProvider;

		// Token: 0x0400095F RID: 2399
		[global::Cpp2ILInjected.Token(Token = "0x4000C16")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private MonoTlsSettings tlsSettings;

		// Token: 0x04000960 RID: 2400
		[global::Cpp2ILInjected.Token(Token = "0x4000C17")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private X509Certificate certificate;

		// Token: 0x04000961 RID: 2401
		[global::Cpp2ILInjected.Token(Token = "0x4000C18")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private AuthenticationSchemes auth_schemes;

		// Token: 0x04000962 RID: 2402
		[global::Cpp2ILInjected.Token(Token = "0x4000C19")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private HttpListenerPrefixCollection prefixes;

		// Token: 0x04000963 RID: 2403
		[global::Cpp2ILInjected.Token(Token = "0x4000C1A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private AuthenticationSchemeSelector auth_selector;

		// Token: 0x04000964 RID: 2404
		[global::Cpp2ILInjected.Token(Token = "0x4000C1B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string realm;

		// Token: 0x04000965 RID: 2405
		[global::Cpp2ILInjected.Token(Token = "0x4000C1C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool ignore_write_exceptions;

		// Token: 0x04000966 RID: 2406
		[global::Cpp2ILInjected.Token(Token = "0x4000C1D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
		private bool unsafe_ntlm_auth;

		// Token: 0x04000967 RID: 2407
		[global::Cpp2ILInjected.Token(Token = "0x4000C1E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4A")]
		private bool listening;

		// Token: 0x04000968 RID: 2408
		[global::Cpp2ILInjected.Token(Token = "0x4000C1F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4B")]
		private bool disposed;

		// Token: 0x04000969 RID: 2409
		[global::Cpp2ILInjected.Token(Token = "0x4000C20")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly object _internalLock;

		// Token: 0x0400096A RID: 2410
		[global::Cpp2ILInjected.Token(Token = "0x4000C21")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private Hashtable registry;

		// Token: 0x0400096B RID: 2411
		[global::Cpp2ILInjected.Token(Token = "0x4000C22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private ArrayList ctx_queue;

		// Token: 0x0400096C RID: 2412
		[global::Cpp2ILInjected.Token(Token = "0x4000C23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private ArrayList wait_queue;

		// Token: 0x0400096D RID: 2413
		[global::Cpp2ILInjected.Token(Token = "0x4000C24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private Hashtable connections;

		// Token: 0x0400096E RID: 2414
		[global::Cpp2ILInjected.Token(Token = "0x4000C25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private ServiceNameStore defaultServiceNames;

		// Token: 0x0400096F RID: 2415
		[global::Cpp2ILInjected.Token(Token = "0x4000C26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private ExtendedProtectionPolicy extendedProtectionPolicy;

		// Token: 0x04000970 RID: 2416
		[global::Cpp2ILInjected.Token(Token = "0x4000C27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private HttpListener.ExtendedProtectionSelector extendedProtectionSelectorDelegate;

		// Token: 0x02000418 RID: 1048
		// (Invoke) Token: 0x06001E20 RID: 7712
		[global::Cpp2ILInjected.Token(Token = "0x200024A")]
		public delegate ExtendedProtectionPolicy ExtendedProtectionSelector(HttpListenerRequest request);
	}
}
