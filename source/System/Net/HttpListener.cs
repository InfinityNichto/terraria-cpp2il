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
	[global::Cpp2ILInjected.Token(Token = "0x2000249")]
	public sealed class HttpListener : IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000EC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4C274", Offset = "0x1F4C274", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = ".ctor", ReturnType = typeof(void))]
		internal HttpListener(X509Certificate certificate, MonoTlsProvider tlsProvider, MonoTlsSettings tlsSettings)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000EDF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4C8C0", Offset = "0x1F4C8C0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Abort()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4C950", Offset = "0x1F4C950", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void Close()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000EE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4DBDC", Offset = "0x1F4DBDC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void Stop()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4DBFC", Offset = "0x1F4DBFC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListener), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		private void System.IDisposable.Dispose()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000EEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4C500", Offset = "0x1F4C500", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointManager), Member = "AddListener", MemberParameters = new object[] { typeof(HttpListener) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointManager), Member = "RemoveListener", MemberParameters = new object[] { typeof(HttpListener) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "set_AuthenticationSchemes", MemberParameters = new object[] { typeof(AuthenticationSchemes) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "set_AuthenticationSchemeSelectorDelegate", MemberParameters = new object[] { typeof(AuthenticationSchemeSelector) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "set_ExtendedProtectionSelectorDelegate", MemberParameters = new object[] { typeof(HttpListener.ExtendedProtectionSelector) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "set_IgnoreWriteExceptions", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "get_Prefixes", ReturnType = typeof(HttpListenerPrefixCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "set_ExtendedProtectionPolicy", MemberParameters = new object[] { typeof(ExtendedProtectionPolicy) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "set_Realm", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "set_UnsafeConnectionNtlmAuthentication", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "BeginGetContext", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "EndGetContext", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(HttpListenerContext))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "Stop", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerPrefixCollection), Member = "Add", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerPrefixCollection), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerPrefixCollection), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerPrefixCollection), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerPrefixCollection), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerPrefixCollection), Member = "Remove", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void CheckDisposed()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000EEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4AAC0", Offset = "0x1F4AAC0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void AddConnection(HttpConnection cnc)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4AE10", Offset = "0x1F4AE10", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void RemoveConnection(HttpConnection cnc)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000C15")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private MonoTlsProvider tlsProvider;

		[global::Cpp2ILInjected.Token(Token = "0x4000C16")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private MonoTlsSettings tlsSettings;

		[global::Cpp2ILInjected.Token(Token = "0x4000C17")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private X509Certificate certificate;

		[global::Cpp2ILInjected.Token(Token = "0x4000C18")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private AuthenticationSchemes auth_schemes;

		[global::Cpp2ILInjected.Token(Token = "0x4000C19")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private HttpListenerPrefixCollection prefixes;

		[global::Cpp2ILInjected.Token(Token = "0x4000C1A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private AuthenticationSchemeSelector auth_selector;

		[global::Cpp2ILInjected.Token(Token = "0x4000C1B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string realm;

		[global::Cpp2ILInjected.Token(Token = "0x4000C1C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool ignore_write_exceptions;

		[global::Cpp2ILInjected.Token(Token = "0x4000C1D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
		private bool unsafe_ntlm_auth;

		[global::Cpp2ILInjected.Token(Token = "0x4000C1E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4A")]
		private bool listening;

		[global::Cpp2ILInjected.Token(Token = "0x4000C1F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4B")]
		private bool disposed;

		[global::Cpp2ILInjected.Token(Token = "0x4000C20")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly object _internalLock;

		[global::Cpp2ILInjected.Token(Token = "0x4000C21")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private Hashtable registry;

		[global::Cpp2ILInjected.Token(Token = "0x4000C22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private ArrayList ctx_queue;

		[global::Cpp2ILInjected.Token(Token = "0x4000C23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private ArrayList wait_queue;

		[global::Cpp2ILInjected.Token(Token = "0x4000C24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private Hashtable connections;

		[global::Cpp2ILInjected.Token(Token = "0x4000C25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private ServiceNameStore defaultServiceNames;

		[global::Cpp2ILInjected.Token(Token = "0x4000C26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private ExtendedProtectionPolicy extendedProtectionPolicy;

		[global::Cpp2ILInjected.Token(Token = "0x4000C27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private HttpListener.ExtendedProtectionSelector extendedProtectionSelectorDelegate;

		[global::Cpp2ILInjected.Token(Token = "0x200024A")]
		public delegate ExtendedProtectionPolicy ExtendedProtectionSelector(HttpListenerRequest request);
	}
}
