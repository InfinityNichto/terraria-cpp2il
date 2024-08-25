using System;
using System.Collections.Concurrent;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200026F")]
	public class ServicePointManager
	{
		[global::Cpp2ILInjected.Token(Token = "0x60010F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E06A58", Offset = "0x1E06A58", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static ServicePointManager()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E06B08", Offset = "0x1E06B08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private ServicePointManager()
		{
			throw null;
		}

		[Obsolete("Use ServerCertificateValidationCallback instead", false)]
		[global::Cpp2ILInjected.Token(Token = "0x170003D9")]
		public static ICertificatePolicy CertificatePolicy
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E06B10", Offset = "0x1E06B10", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultCertificatePolicy), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60010F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E06BD4", Offset = "0x1E06BD4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E06C30", Offset = "0x1E06C30", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ICertificatePolicy GetLegacyCertificatePolicy()
		{
			throw null;
		}

		[MonoTODO("CRL checks not implemented")]
		[global::Cpp2ILInjected.Token(Token = "0x170003DA")]
		public static bool CheckCertificateRevocationList
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E06C88", Offset = "0x1E06C88", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60010FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E06CE0", Offset = "0x1E06CE0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003DB")]
		public static int DefaultConnectionLimit
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E06D38", Offset = "0x1E06D38", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60010FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E06D90", Offset = "0x1E06D90", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60010FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E06E3C", Offset = "0x1E06E3C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointManager), Member = "get_EnableDnsRoundRobin", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointManager), Member = "set_EnableDnsRoundRobin", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static Exception GetMustImplement()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003DC")]
		public static int DnsRefreshTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E06E90", Offset = "0x1E06E90", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001100")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E06EE8", Offset = "0x1E06EE8", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		[MonoTODO]
		[global::Cpp2ILInjected.Token(Token = "0x170003DD")]
		public static bool EnableDnsRoundRobin
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001101")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E06F80", Offset = "0x1E06F80", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointManager), Member = "GetMustImplement", ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001102")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E06FB4", Offset = "0x1E06FB4", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointManager), Member = "GetMustImplement", ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003DE")]
		public static int MaxServicePointIdleTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001103")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E06FE8", Offset = "0x1E06FE8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001104")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E07040", Offset = "0x1E07040", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003DF")]
		public static int MaxServicePoints
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001105")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E070EC", Offset = "0x1E070EC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001106")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E07144", Offset = "0x1E07144", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			set
			{
				throw null;
			}
		}

		[MonoTODO]
		[global::Cpp2ILInjected.Token(Token = "0x170003E0")]
		public static bool ReusePort
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001107")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E071EC", Offset = "0x1E071EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001108")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E071F4", Offset = "0x1E071F4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003E1")]
		public static SecurityProtocolType SecurityProtocol
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001109")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0722C", Offset = "0x1E0722C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600110A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E07284", Offset = "0x1E07284", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003E2")]
		internal static ServerCertValidationCallback ServerCertValidationCallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x600110B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E072E0", Offset = "0x1E072E0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003E3")]
		public static RemoteCertificateValidationCallback ServerCertificateValidationCallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x600110C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E07338", Offset = "0x1E07338", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TlsStream), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(NetworkStream),
				typeof(Socket),
				typeof(string),
				typeof(X509CertificateCollection)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultCertificatePolicy), Member = "CheckValidationResult", MemberParameters = new object[]
			{
				typeof(ServicePoint),
				typeof(X509Certificate),
				typeof(WebRequest),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600110D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E073B8", Offset = "0x1E073B8", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerCertValidationCallback), Member = ".ctor", MemberParameters = new object[] { typeof(RemoteCertificateValidationCallback) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		[MonoTODO("Always returns EncryptionPolicy.RequireEncryption.")]
		[global::Cpp2ILInjected.Token(Token = "0x170003E4")]
		public static EncryptionPolicy EncryptionPolicy
		{
			[global::Cpp2ILInjected.Token(Token = "0x600110E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E07464", Offset = "0x1E07464", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003E5")]
		public static bool Expect100Continue
		{
			[global::Cpp2ILInjected.Token(Token = "0x600110F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0746C", Offset = "0x1E0746C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001110")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E074C4", Offset = "0x1E074C4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003E6")]
		public static bool UseNagleAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001111")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E07520", Offset = "0x1E07520", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001112")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E07578", Offset = "0x1E07578", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003E7")]
		internal static bool DisableStrongCrypto
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001113")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E075D4", Offset = "0x1E075D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003E8")]
		internal static bool DisableSendAuxRecord
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001114")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E075DC", Offset = "0x1E075DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001115")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E075E4", Offset = "0x1E075E4", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001116")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E076E8", Offset = "0x1E076E8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "get_ServicePoint", ReturnType = typeof(ServicePoint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ServicePoint FindServicePoint(Uri address)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001117")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E07D58", Offset = "0x1E07D58", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointManager), Member = "FindServicePoint", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(IWebProxy)
		}, ReturnType = typeof(ServicePoint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static ServicePoint FindServicePoint(string uriString, IWebProxy proxy)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001118")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E07740", Offset = "0x1E07740", Length = "0x618")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetServicePoint", ReturnType = typeof(ServicePoint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointManager), Member = "FindServicePoint", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IWebProxy)
		}, ReturnType = typeof(ServicePoint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Authority", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePoint), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ServicePointManager.SPKey),
			typeof(Uri),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePoint), Member = "SetTcpKeepAlive", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<object, object>), Member = "GetOrAdd", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001119")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E07E24", Offset = "0x1E07E24", Length = "0x3CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<object, object>), Member = "get_Values", ReturnType = "System.Collections.Generic.ICollection`1<TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePoint), Member = "CloseConnectionGroup", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		internal static void CloseConnectionGroup(string connectionGroupName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600111A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E081F0", Offset = "0x1E081F0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointScheduler), Member = "FinalCleanup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<object, object>), Member = "TryRemove", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static void RemoveServicePoint(ServicePoint sp)
		{
			throw null;
		}

		[Obsolete("This API is no longer supported.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x170003E9")]
		public static CipherSuitesCallback ClientCipherSuitesCallback
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600111B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0827C", Offset = "0x1E0827C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600111C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E082D4", Offset = "0x1E082D4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[Obsolete("This API is no longer supported.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x170003EA")]
		public static CipherSuitesCallback ServerCipherSuitesCallback
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600111D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E08330", Offset = "0x1E08330", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600111E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E08388", Offset = "0x1E08388", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000D42")]
		private static ConcurrentDictionary<ServicePointManager.SPKey, ServicePoint> servicePoints;

		[global::Cpp2ILInjected.Token(Token = "0x4000D43")]
		private static ICertificatePolicy policy;

		[global::Cpp2ILInjected.Token(Token = "0x4000D44")]
		private static int defaultConnectionLimit;

		[global::Cpp2ILInjected.Token(Token = "0x4000D45")]
		private static int maxServicePointIdleTime;

		[global::Cpp2ILInjected.Token(Token = "0x4000D46")]
		private static int maxServicePoints;

		[global::Cpp2ILInjected.Token(Token = "0x4000D47")]
		private static int dnsRefreshTimeout;

		[global::Cpp2ILInjected.Token(Token = "0x4000D48")]
		private static bool _checkCRL;

		[global::Cpp2ILInjected.Token(Token = "0x4000D49")]
		private static SecurityProtocolType _securityProtocol;

		[global::Cpp2ILInjected.Token(Token = "0x4000D4A")]
		private static bool expectContinue;

		[global::Cpp2ILInjected.Token(Token = "0x4000D4B")]
		private static bool useNagle;

		[global::Cpp2ILInjected.Token(Token = "0x4000D4C")]
		private static ServerCertValidationCallback server_cert_cb;

		[global::Cpp2ILInjected.Token(Token = "0x4000D4D")]
		private static bool tcp_keepalive;

		[global::Cpp2ILInjected.Token(Token = "0x4000D4E")]
		private static int tcp_keepalive_time;

		[global::Cpp2ILInjected.Token(Token = "0x4000D4F")]
		private static int tcp_keepalive_interval;

		[global::Cpp2ILInjected.Token(Token = "0x4000D50")]
		public const int DefaultNonPersistentConnectionLimit = 4;

		[global::Cpp2ILInjected.Token(Token = "0x4000D51")]
		public const int DefaultPersistentConnectionLimit = 10;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000D52")]
		private static CipherSuitesCallback <ClientCipherSuitesCallback>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000D53")]
		private static CipherSuitesCallback <ServerCipherSuitesCallback>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x2000270")]
		internal class SPKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x600111F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E07DE8", Offset = "0x1E07DE8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public SPKey(Uri uri, Uri proxy, bool use_connect)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170003EB")]
			public Uri Uri
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001120")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E083E4", Offset = "0x1E083E4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170003EC")]
			public bool UseConnect
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001121")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E083EC", Offset = "0x1E083EC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170003ED")]
			public bool UsesProxy
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001122")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E083F4", Offset = "0x1E083F4", Length = "0x60")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointManager.SPKey), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new object[]
				{
					typeof(Uri),
					typeof(Uri)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001123")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E08454", Offset = "0x1E08454", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(Uri)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override int GetHashCode()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001124")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E08518", Offset = "0x1E08518", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointManager.SPKey), Member = "get_UsesProxy", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override bool Equals(object obj)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000D54")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private Uri uri;

			[global::Cpp2ILInjected.Token(Token = "0x4000D55")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private Uri proxy;

			[global::Cpp2ILInjected.Token(Token = "0x4000D56")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private bool use_connect;
		}
	}
}
