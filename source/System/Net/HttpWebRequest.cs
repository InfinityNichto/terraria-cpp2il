using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net.Cache;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000255")]
	[Serializable]
	public class HttpWebRequest : WebRequest, ISerializable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000F89")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F51B04", Offset = "0x1F51B04", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RequestCachePolicy), Member = ".ctor", MemberParameters = new object[] { typeof(RequestCacheLevel) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static HttpWebRequest()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F51758", Offset = "0x1F51758", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpRequestCreator), Member = "Create", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(WebRequest))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(MobileTlsProvider),
			typeof(MonoTlsSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = "get_InternalDefaultWebProxy", ReturnType = typeof(IWebProxy))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", MemberParameters = new object[] { typeof(WebHeaderCollectionType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "ResetAuthorization", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public HttpWebRequest(Uri uri)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F51BE8", Offset = "0x1F51BE8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		internal HttpWebRequest(Uri uri, MobileTlsProvider tlsProvider, MonoTlsSettings settings = null)
		{
			throw null;
		}

		[Obsolete("Serialization is obsoleted for this type.  http://go.microsoft.com/fwlink/?linkid=14202")]
		[global::Cpp2ILInjected.Token(Token = "0x6000F8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F51C10", Offset = "0x1F51C10", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequest), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		protected HttpWebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F51B88", Offset = "0x1F51B88", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest.AuthorizationState), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(HttpWebRequest),
			typeof(bool)
		}, ReturnType = typeof(void))]
		private void ResetAuthorization()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F51D38", Offset = "0x1F51D38", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_Accept", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_ContentType", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "SetDateHeaderHelper", MemberParameters = new object[]
		{
			typeof(string),
			typeof(DateTime)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "CheckBadChars", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "RemoveInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "AddInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SetSpecialHeaders(string HeaderName, string value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700035B")]
		public string Accept
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F8F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F51DE8", Offset = "0x1F51DE8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000F90")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F51E34", Offset = "0x1F51E34", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "CopyHeadersTo", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CheckRequestStarted", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "SetSpecialHeaders", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700035C")]
		public Uri Address
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F91")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F51EF0", Offset = "0x1F51EF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000F92")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F51EF8", Offset = "0x1F51EF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700035D")]
		public virtual bool AllowAutoRedirect
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F93")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F51F00", Offset = "0x1F51F00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000F94")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F51F08", Offset = "0x1F51F08", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700035E")]
		public virtual bool AllowWriteStreamBuffering
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F95")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F51F14", Offset = "0x1F51F14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000F96")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F51F1C", Offset = "0x1F51F1C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700035F")]
		public virtual bool AllowReadStreamBuffering
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F97")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F51F28", Offset = "0x1F51F28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000F98")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F51F30", Offset = "0x1F51F30", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F51F3C", Offset = "0x1F51F3C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static Exception GetMustImplement()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000360")]
		public DecompressionMethods AutomaticDecompression
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F9A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F51F90", Offset = "0x1F51F90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000F9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F51F98", Offset = "0x1F51F98", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CheckRequestStarted", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000361")]
		internal bool InternalAllowBuffering
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F9C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F51FBC", Offset = "0x1F51FBC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(WebConnection),
				typeof(WebOperation),
				typeof(Stream),
				typeof(WebConnectionTunnel)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000362")]
		private bool MethodWithBuffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F9D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F51FD0", Offset = "0x1F51FD0", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new object[]
			{
				typeof(HttpStatusCode),
				typeof(WebResponse)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetRewriteHandler", MemberParameters = new object[]
			{
				typeof(HttpWebResponse),
				typeof(bool)
			}, ReturnType = typeof(ValueTuple<Task<BufferOffsetSize>, WebException>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "CheckFinalStatus", MemberParameters = new object[] { typeof(HttpWebResponse) }, ReturnType = typeof(ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000363")]
		internal MobileTlsProvider TlsProvider
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F9E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F520CC", Offset = "0x1F520CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000364")]
		internal MonoTlsSettings TlsSettings
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F9F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F520D4", Offset = "0x1F520D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000365")]
		public X509CertificateCollection ClientCertificates
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FA0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F520DC", Offset = "0x1F520DC", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MonoTlsStream.<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FA1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52140", Offset = "0x1F52140", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000366")]
		public string Connection
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FA2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F5219C", Offset = "0x1F5219C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FA3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F521E8", Offset = "0x1F521E8", Length = "0x17C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "CopyHeadersTo", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CheckRequestStarted", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "RemoveInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpValidationHelpers), Member = "CheckBadHeaderValueChars", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "CheckUpdate", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000367")]
		public override string ConnectionGroupName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FA4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52364", Offset = "0x1F52364", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F5236C", Offset = "0x1F5236C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000368")]
		public override long ContentLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52374", Offset = "0x1F52374", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FA7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F5237C", Offset = "0x1F5237C", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CheckRequestStarted", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000369")]
		internal long InternalContentLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FA8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52408", Offset = "0x1F52408", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700036A")]
		internal bool ThrowOnError
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000FA9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52410", Offset = "0x1F52410", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000FAA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52418", Offset = "0x1F52418", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700036B")]
		public override string ContentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FAB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52424", Offset = "0x1F52424", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FAC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52470", Offset = "0x1F52470", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "SetSpecialHeaders", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700036C")]
		public HttpContinueDelegate ContinueDelegate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FAD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F524C8", Offset = "0x1F524C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F524D0", Offset = "0x1F524D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700036D")]
		public virtual CookieContainer CookieContainer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FAF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F524D8", Offset = "0x1F524D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FB0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F524E0", Offset = "0x1F524E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700036E")]
		public override ICredentials Credentials
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FB1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F524E8", Offset = "0x1F524E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FB2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F524F0", Offset = "0x1F524F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700036F")]
		public DateTime Date
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FB3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F524F8", Offset = "0x1F524F8", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(IFormatProvider)
			}, ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FB4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F5260C", Offset = "0x1F5260C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F52664", Offset = "0x1F52664", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpProtocolUtils), Member = "date2string", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "SetSpecialHeaders", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SetDateHeaderHelper(string headerName, DateTime dateTime)
		{
			throw null;
		}

		[MonoTODO]
		[global::Cpp2ILInjected.Token(Token = "0x17000370")]
		public static int DefaultMaximumErrorResponseLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FB6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F526FC", Offset = "0x1F526FC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FB7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52754", Offset = "0x1F52754", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000371")]
		public string Expect
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FB8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F527B0", Offset = "0x1F527B0", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FB9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F527FC", Offset = "0x1F527FC", Length = "0x118")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "CopyHeadersTo", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CheckRequestStarted", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "CheckUpdate", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "RemoveInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000372")]
		public virtual bool HaveResponse
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FBA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52914", Offset = "0x1F52914", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000373")]
		public override WebHeaderCollection Headers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FBB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F5291C", Offset = "0x1F5291C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FBC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52924", Offset = "0x1F52924", Length = "0xE4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CheckRequestStarted", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", MemberParameters = new object[] { typeof(WebHeaderCollectionType) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000374")]
		public string Host
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FBD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52A08", Offset = "0x1F52A08", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.ChainValidationHelper.<>c__DisplayClass11_0", Member = "<GetValidationCallback>b__0", MemberParameters = new object[]
			{
				typeof(object),
				typeof(X509Certificate),
				typeof(X509Chain),
				typeof(SslPolicyErrors)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MonoTlsStream.<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new object[]
			{
				typeof(HttpStatusCode),
				typeof(WebResponse)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetRequestHeaders", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(Uri)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FBE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52B04", Offset = "0x1F52B04", Length = "0x160")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "CopyHeadersTo", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CheckRequestStarted", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "TryGetHostUri", MemberParameters = new object[]
			{
				typeof(string),
				typeof(ref Uri)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F52C64", Offset = "0x1F52C64", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_Host", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_PathAndQuery", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool TryGetHostUri(string hostName, out Uri hostUri)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000375")]
		public DateTime IfModifiedSince
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FC0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52D30", Offset = "0x1F52D30", Length = "0x13C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoHttpDate), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FC1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52E6C", Offset = "0x1F52E6C", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CheckRequestStarted", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(IFormatProvider)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "SetInternal", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000376")]
		public bool KeepAlive
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FC2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52F14", Offset = "0x1F52F14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FC3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52F1C", Offset = "0x1F52F1C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000377")]
		public int MaximumAutomaticRedirections
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FC4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52F28", Offset = "0x1F52F28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FC5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52F30", Offset = "0x1F52F30", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		[MonoTODO("Use this")]
		[global::Cpp2ILInjected.Token(Token = "0x17000378")]
		public int MaximumResponseHeadersLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FC6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52FAC", Offset = "0x1F52FAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FC7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F52FB4", Offset = "0x1F52FB4", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CheckRequestStarted", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		[MonoTODO("Use this")]
		[global::Cpp2ILInjected.Token(Token = "0x17000379")]
		public static int DefaultMaximumResponseHeadersLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FC8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F5303C", Offset = "0x1F5303C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FC9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53094", Offset = "0x1F53094", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700037A")]
		public int ReadWriteTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FCA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F530F0", Offset = "0x1F530F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FCB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F530F8", Offset = "0x1F530F8", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CheckRequestStarted", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		[MonoTODO]
		[global::Cpp2ILInjected.Token(Token = "0x1700037B")]
		public int ContinueTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FCC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53188", Offset = "0x1F53188", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FCD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53190", Offset = "0x1F53190", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CheckRequestStarted", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700037C")]
		public string MediaType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FCE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53218", Offset = "0x1F53218", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FCF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53220", Offset = "0x1F53220", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700037D")]
		public override string Method
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FD0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53228", Offset = "0x1F53228", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FD1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53230", Offset = "0x1F53230", Length = "0x220")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpValidationHelpers), Member = "IsInvalidMethodOrHeaderString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpperInvariant", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
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

		[global::Cpp2ILInjected.Token(Token = "0x1700037E")]
		public bool Pipelined
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FD2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53450", Offset = "0x1F53450", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FD3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53458", Offset = "0x1F53458", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700037F")]
		public override bool PreAuthenticate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FD4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53464", Offset = "0x1F53464", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FD5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F5346C", Offset = "0x1F5346C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000380")]
		public Version ProtocolVersion
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FD6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53478", Offset = "0x1F53478", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FD7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53480", Offset = "0x1F53480", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Version), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Version),
				typeof(Version)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000381")]
		public override IWebProxy Proxy
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FD8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F5358C", Offset = "0x1F5358C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FD9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53594", Offset = "0x1F53594", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CheckRequestStarted", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000382")]
		public string Referer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FDA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F536F0", Offset = "0x1F536F0", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FDB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F5373C", Offset = "0x1F5373C", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "CopyHeadersTo", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CheckRequestStarted", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "SetInternal", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "RemoveInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000383")]
		public override Uri RequestUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FDC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F537C8", Offset = "0x1F537C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000384")]
		public bool SendChunked
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FDD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F537D0", Offset = "0x1F537D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FDE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F537D8", Offset = "0x1F537D8", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CheckRequestStarted", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000385")]
		public ServicePoint ServicePoint
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FDF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F537FC", Offset = "0x1F537FC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChainValidationHelper), Member = "ValidateChain", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool),
				typeof(X509Certificate),
				typeof(ref X509Chain),
				typeof(X509CertificateCollection),
				typeof(SslPolicyErrors)
			}, ReturnType = typeof(ValidationResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MonoTlsStream.<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlDownloadManager.<GetNonFileStreamAsync>d__5", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlDownloadManager", Member = "GetNonFileStream", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(ICredentials),
				typeof(IWebProxy),
				typeof(RequestCachePolicy)
			}, ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "GetServicePoint", ReturnType = typeof(ServicePoint))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000386")]
		internal ServicePoint ServicePointNoLock
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FE0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53800", Offset = "0x1F53800", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000387")]
		public virtual bool SupportsCookieContainer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FE1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53808", Offset = "0x1F53808", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000388")]
		public override int Timeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FE2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53810", Offset = "0x1F53810", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FE3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53818", Offset = "0x1F53818", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000389")]
		public string TransferEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FE4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53878", Offset = "0x1F53878", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "MyGetRequestStreamAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task<Stream>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "BeginGetResponse", MemberParameters = new object[]
			{
				typeof(AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FE5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F538C4", Offset = "0x1F538C4", Length = "0x18C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CheckRequestStarted", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "RemoveInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpValidationHelpers), Member = "CheckBadHeaderValueChars", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "CheckUpdate", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700038A")]
		public override bool UseDefaultCredentials
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FE6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53A50", Offset = "0x1F53A50", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FE7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53AC8", Offset = "0x1F53AC8", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700038B")]
		public string UserAgent
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FE8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53B40", Offset = "0x1F53B40", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FE9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53B8C", Offset = "0x1F53B8C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "CopyHeadersTo", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "SetInternal", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700038C")]
		public bool UnsafeAuthenticatedConnectionSharing
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FEA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53BE8", Offset = "0x1F53BE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FEB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53BF0", Offset = "0x1F53BF0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700038D")]
		internal bool GotRequestStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FEC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53BFC", Offset = "0x1F53BFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700038E")]
		internal bool ExpectContinue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53C04", Offset = "0x1F53C04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FEE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53C0C", Offset = "0x1F53C0C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700038F")]
		internal Uri AuthUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FEF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53C18", Offset = "0x1F53C18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000390")]
		internal bool ProxyQuery
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FF0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53C20", Offset = "0x1F53C20", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest.<GetResponseFromData>d__244), Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000391")]
		internal ServerCertValidationCallback ServerCertValidationCallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FF1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53C44", Offset = "0x1F53C44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000392")]
		public RemoteCertificateValidationCallback ServerCertificateValidationCallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000FF2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53C4C", Offset = "0x1F53C4C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000FF3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F53C64", Offset = "0x1F53C64", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerCertValidationCallback), Member = ".ctor", MemberParameters = new object[] { typeof(RemoteCertificateValidationCallback) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F535C0", Offset = "0x1F535C0", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "get_ServicePoint", ReturnType = typeof(ServicePoint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "SendRequest", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(BufferOffsetSize),
			typeof(CancellationToken)
		}, ReturnType = typeof(WebOperation))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointManager), Member = "FindServicePoint", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(IWebProxy)
		}, ReturnType = typeof(ServicePoint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal ServicePoint GetServicePoint()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F53CCC", Offset = "0x1F53CCC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddRange(int range)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F53FAC", Offset = "0x1F53FAC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddRange(int from, int to)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F54278", Offset = "0x1F54278", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "AddRange", MemberParameters = new object[]
		{
			typeof(string),
			typeof(long)
		}, ReturnType = typeof(void))]
		public void AddRange(string rangeSpecifier, int range)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F54280", Offset = "0x1F54280", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "AddRange", MemberParameters = new object[]
		{
			typeof(string),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		public void AddRange(string rangeSpecifier, int from, int to)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5428C", Offset = "0x1F5428C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "AddRange", MemberParameters = new object[]
		{
			typeof(string),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddRange(long range)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F542E4", Offset = "0x1F542E4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "AddRange", MemberParameters = new object[]
		{
			typeof(string),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddRange(long from, long to)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F53D24", Offset = "0x1F53D24", Length = "0x288")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "AddRange", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "AddRange", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "IsValidToken", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "ChangeInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public void AddRange(string rangeSpecifier, long range)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5400C", Offset = "0x1F5400C", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "AddRange", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "AddRange", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "IsValidToken", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "ChangeInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public void AddRange(string rangeSpecifier, long from, long to)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F54344", Offset = "0x1F54344", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest.<MyGetResponseAsync>d__243), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "MyGetRequestStreamAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task<Stream>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(HttpWebRequest),
			typeof(BufferOffsetSize),
			typeof(bool),
			typeof(CancellationToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "GetServicePoint", ReturnType = typeof(ServicePoint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePoint), Member = "SendRequest", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5455C", Offset = "0x1F5455C", Length = "0x35C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "get_TransferEncoding", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "SendRequest", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(BufferOffsetSize),
			typeof(CancellationToken)
		}, ReturnType = typeof(WebOperation))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "GetRequestStream", ReturnType = typeof(Task<Stream>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProtocolViolationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CreateRequestAbortedException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		private Task<Stream> MyGetRequestStreamAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5499C", Offset = "0x1F5499C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<CancellationToken, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "RunWithTimeout", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Func`2<CancellationToken, Task`1<T>>" }, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "Begin", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001000")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F54A54", Offset = "0x1F54A54", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskToApm[]), Member = "End", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "GetWebException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override Stream EndGetRequestStream(IAsyncResult asyncResult)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001001")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F54BF8", Offset = "0x1F54BF8", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "get_Result", ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "GetWebException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override Stream GetRequestStream()
		{
			throw null;
		}

		[MonoTODO]
		[global::Cpp2ILInjected.Token(Token = "0x6001002")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F54CF0", Offset = "0x1F54CF0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Stream GetRequestStream(out TransportContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001003")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F54D28", Offset = "0x1F54D28", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<CancellationToken, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "RunWithTimeout", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Func`2<CancellationToken, Task`1<T>>" }, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override Task<Stream> GetRequestStreamAsync()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001004")]
		[global::Cpp2ILInjected.Address(RVA = "0x158B684", Offset = "0x158B684", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "ProcessRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "CreateLinkedTokenSource", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(CancellationTokenSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func, int timeout, Action abort, Func<bool> aborted, CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001005")]
		[global::Cpp2ILInjected.Address(RVA = "0x158B874", Offset = "0x158B874", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "Start", MemberTypeParameters = new object[] { typeof(HttpWebRequest.<RunWithTimeoutWorker>d__241<int>) }, MemberParameters = new object[] { typeof(ref HttpWebRequest.<RunWithTimeoutWorker>d__241<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static Task<T> RunWithTimeoutWorker<T>(Task<T> workerTask, int timeout, Action abort, Func<bool> aborted, CancellationTokenSource cts)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001006")]
		[global::Cpp2ILInjected.Address(RVA = "0x158B52C", Offset = "0x158B52C", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "BeginGetRequestStream", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetRequestStreamAsync", ReturnType = typeof(Task<Stream>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "BeginGetResponse", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001007")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F54DC0", Offset = "0x1F54DC0", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "Start", MemberTypeParameters = new object[] { typeof(HttpWebRequest.<MyGetResponseAsync>d__243) }, MemberParameters = new object[] { typeof(ref HttpWebRequest.<MyGetResponseAsync>d__243) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private Task<HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001008")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F54ECC", Offset = "0x1F54ECC", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest.<MyGetResponseAsync>d__243), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>), Member = "Start", MemberTypeParameters = new object[] { typeof(HttpWebRequest.<GetResponseFromData>d__244) }, MemberParameters = new object[] { typeof(ref HttpWebRequest.<GetResponseFromData>d__244) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private Task<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001009")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F54FD4", Offset = "0x1F54FD4", Length = "0xB0")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetWebException", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool)
		}, ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<CreateStream>d__18", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnectionStream), Member = "GetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebReadStream), Member = "GetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AggregateException), Member = "Flatten", ReturnType = typeof(AggregateException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static Exception FlattenException(Exception e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600100A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F54B74", Offset = "0x1F54B74", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest.<MyGetResponseAsync>d__243), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "EndGetRequestStream", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetRequestStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "EndGetResponse", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(WebResponse))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetResponse", ReturnType = typeof(WebResponse))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "GetWebException", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool)
		}, ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private WebException GetWebException(Exception e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600100B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F55084", Offset = "0x1F55084", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest.<RunWithTimeoutWorker>d__241<>), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetWebException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "FlattenException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CreateRequestAbortedException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(WebExceptionStatus),
			typeof(WebResponse)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static WebException GetWebException(Exception e, bool aborted)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600100C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F548E0", Offset = "0x1F548E0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest.<MyGetResponseAsync>d__243), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "MyGetRequestStreamAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task<Stream>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetWebException", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(bool)
		}, ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "BeginGetResponse", MemberParameters = new object[]
		{
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnectionStream), Member = "GetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebReadStream), Member = "GetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "GetReadException", MemberParameters = new object[]
		{
			typeof(WebExceptionStatus),
			typeof(Exception),
			typeof(string)
		}, ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static WebException CreateRequestAbortedException()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600100D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F55224", Offset = "0x1F55224", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "get_TransferEncoding", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<CancellationToken, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "RunWithTimeout", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Func`2<CancellationToken, Task`1<T>>" }, ReturnType = "System.Threading.Tasks.Task`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "Begin", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CreateRequestAbortedException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600100E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F55394", Offset = "0x1F55394", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskToApm[]), Member = "End", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "GetWebException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override WebResponse EndGetResponse(IAsyncResult asyncResult)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600100F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F554B4", Offset = "0x1F554B4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public Stream EndGetRequestStream(IAsyncResult asyncResult, out TransportContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001010")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5551C", Offset = "0x1F5551C", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "get_Result", ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "GetWebException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override WebResponse GetResponse()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000393")]
		internal bool FinishedReading
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001011")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F55614", Offset = "0x1F55614", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001012")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F5561C", Offset = "0x1F5561C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000394")]
		internal bool Aborted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001013")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F548B8", Offset = "0x1F548B8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest.<MyGetResponseAsync>d__243), Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "<RunWithTimeout>b__242_0", MemberTypeParameters = new object[] { "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebOperation), Member = "get_Aborted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001014")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F55628", Offset = "0x1F55628", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "Abort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "TrySetCanceled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override void Abort()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001015")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F55738", Offset = "0x1F55738", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001016")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F55770", Offset = "0x1F55770", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001017")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F51E94", Offset = "0x1F51E94", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_Accept", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_AutomaticDecompression", MemberParameters = new object[] { typeof(DecompressionMethods) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_Connection", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_ContentLength", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_Expect", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_Headers", MemberParameters = new object[] { typeof(WebHeaderCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_Host", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_IfModifiedSince", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_MaximumResponseHeadersLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_ReadWriteTimeout", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_ContinueTimeout", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_Proxy", MemberParameters = new object[] { typeof(IWebProxy) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_Referer", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_SendChunked", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_TransferEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void CheckRequestStarted()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001018")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F557A8", Offset = "0x1F557A8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "GetResponse", MemberParameters = new object[]
		{
			typeof(BufferOffsetSize),
			typeof(ref int),
			typeof(ref ReadState)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001019")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F557C4", Offset = "0x1F557C4", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new object[]
		{
			typeof(HttpStatusCode),
			typeof(WebResponse)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "RemoveInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void RewriteRedirectToGet()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600101A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5583C", Offset = "0x1F5583C", Length = "0x4A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "CheckFinalStatus", MemberParameters = new object[] { typeof(HttpWebResponse) }, ReturnType = typeof(ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "RewriteRedirectToGet", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProtocolViolationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "get_MethodWithBuffer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequestStream), Member = "get_WriteBufferLength", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(WebExceptionStatus),
			typeof(WebResponse)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "get_Host", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Authority", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		private bool Redirect(HttpStatusCode code, WebResponse response)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600101B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F55CE4", Offset = "0x1F55CE4", Length = "0x5E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetRequestHeaders", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "ChangeInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "RemoveInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "SetInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Version), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Version),
			typeof(Version)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePoint), Member = "get_SendContinue", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "GetCookieHeader", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "DoPreAuthenticate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private string GetHeaders()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600101C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F562C4", Offset = "0x1F562C4", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetHeaders", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticationManager), Member = "PreAuthenticate", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(ICredentials)
		}, ReturnType = typeof(Authorization))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "RemoveInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void DoPreAuthenticate()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600101D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F564AC", Offset = "0x1F564AC", Length = "0x2B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebRequestStream.<SetHeadersAsync>d__37", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "get_Host", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_PathAndQuery", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Version), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Version),
			typeof(Version)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Version), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(Version),
			typeof(Version)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "GetHeaders", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal byte[] GetRequestHeaders()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600101E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5675C", Offset = "0x1F5675C", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest.<GetResponseFromData>d__244), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(HttpWebRequest),
			typeof(BufferOffsetSize),
			typeof(bool),
			typeof(CancellationToken)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "SetPriorityRequest", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTuple<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private ValueTuple<WebOperation, bool> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600101F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F569D0", Offset = "0x1F569D0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "CheckFinalStatus", MemberParameters = new object[] { typeof(HttpWebResponse) }, ReturnType = typeof(ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest.AuthorizationState), Member = "CheckAuthorization", MemberParameters = new object[]
		{
			typeof(WebResponse),
			typeof(HttpStatusCode)
		}, ReturnType = typeof(bool))]
		private bool CheckAuthorization(WebResponse response, HttpStatusCode code)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001020")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F569F0", Offset = "0x1F569F0", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "CheckFinalStatus", MemberParameters = new object[] { typeof(HttpWebResponse) }, ReturnType = typeof(ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "get_MethodWithBuffer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequestStream), Member = "get_WriteBufferLength", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequestStream), Member = "GetWriteBuffer", ReturnType = typeof(BufferOffsetSize))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task[]), Member = "FromResult", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(object) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTuple<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(WebExceptionStatus),
			typeof(WebResponse)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private ValueTuple<Task<BufferOffsetSize>, WebException> GetRewriteHandler(HttpWebResponse response, bool redirect)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001021")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F56BD4", Offset = "0x1F56BD4", Length = "0x46C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest.<GetResponseFromData>d__244), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(WebExceptionStatus),
			typeof(WebResponse)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CheckAuthorization", MemberParameters = new object[]
		{
			typeof(WebResponse),
			typeof(HttpStatusCode)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "get_MethodWithBuffer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "GetRewriteHandler", MemberParameters = new object[]
		{
			typeof(HttpWebResponse),
			typeof(bool)
		}, ReturnType = typeof(ValueTuple<Task<BufferOffsetSize>, WebException>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnectionStream), Member = "InternalClose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new object[]
		{
			typeof(HttpStatusCode),
			typeof(WebResponse)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest.AuthorizationState), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTuple<, , , >), Member = ".ctor", MemberParameters = new object[] { "T1", "T2", "T3", "T4" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException> CheckFinalStatus(HttpWebResponse response)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000395")]
		internal bool ReuseConnection
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001022")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F57040", Offset = "0x1F57040", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001023")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F57048", Offset = "0x1F57048", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001024")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57054", Offset = "0x1F57054", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static StringBuilder GenerateConnectionGroup(string connectionGroupName, bool unsafeConnectionGroup, bool isInternalGroup)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6001025")]
		[global::Cpp2ILInjected.Address(RVA = "0x158B524", Offset = "0x158B524", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "get_Aborted", ReturnType = typeof(bool))]
		private bool <RunWithTimeout>b__242_0<T>()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6001026")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57130", Offset = "0x1F57130", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "Start", MemberTypeParameters = new object[] { typeof(HttpWebRequest.<<GetRewriteHandler>b__271_0>d) }, MemberParameters = new object[] { typeof(ref HttpWebRequest.<<GetRewriteHandler>b__271_0>d) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private Task<BufferOffsetSize> <GetRewriteHandler>b__271_0()
		{
			throw null;
		}

		[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x6001027")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5721C", Offset = "0x1F5721C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public HttpWebRequest()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000C64")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Uri requestUri;

		[global::Cpp2ILInjected.Token(Token = "0x4000C65")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Uri actualUri;

		[global::Cpp2ILInjected.Token(Token = "0x4000C66")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool hostChanged;

		[global::Cpp2ILInjected.Token(Token = "0x4000C67")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
		private bool allowAutoRedirect;

		[global::Cpp2ILInjected.Token(Token = "0x4000C68")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4A")]
		private bool allowBuffering;

		[global::Cpp2ILInjected.Token(Token = "0x4000C69")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4B")]
		private bool allowReadStreamBuffering;

		[global::Cpp2ILInjected.Token(Token = "0x4000C6A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private X509CertificateCollection certificates;

		[global::Cpp2ILInjected.Token(Token = "0x4000C6B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string connectionGroup;

		[global::Cpp2ILInjected.Token(Token = "0x4000C6C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private bool haveContentLength;

		[global::Cpp2ILInjected.Token(Token = "0x4000C6D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private long contentLength;

		[global::Cpp2ILInjected.Token(Token = "0x4000C6E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private HttpContinueDelegate continueDelegate;

		[global::Cpp2ILInjected.Token(Token = "0x4000C6F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private CookieContainer cookieContainer;

		[global::Cpp2ILInjected.Token(Token = "0x4000C70")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private ICredentials credentials;

		[global::Cpp2ILInjected.Token(Token = "0x4000C71")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private bool haveResponse;

		[global::Cpp2ILInjected.Token(Token = "0x4000C72")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x89")]
		private bool requestSent;

		[global::Cpp2ILInjected.Token(Token = "0x4000C73")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private WebHeaderCollection webHeaders;

		[global::Cpp2ILInjected.Token(Token = "0x4000C74")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private bool keepAlive;

		[global::Cpp2ILInjected.Token(Token = "0x4000C75")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		private int maxAutoRedirect;

		[global::Cpp2ILInjected.Token(Token = "0x4000C76")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private string mediaType;

		[global::Cpp2ILInjected.Token(Token = "0x4000C77")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private string method;

		[global::Cpp2ILInjected.Token(Token = "0x4000C78")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private string initialMethod;

		[global::Cpp2ILInjected.Token(Token = "0x4000C79")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private bool pipelined;

		[global::Cpp2ILInjected.Token(Token = "0x4000C7A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB9")]
		private bool preAuthenticate;

		[global::Cpp2ILInjected.Token(Token = "0x4000C7B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xBA")]
		private bool usedPreAuth;

		[global::Cpp2ILInjected.Token(Token = "0x4000C7C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private Version version;

		[global::Cpp2ILInjected.Token(Token = "0x4000C7D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private bool force_version;

		[global::Cpp2ILInjected.Token(Token = "0x4000C7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private Version actualVersion;

		[global::Cpp2ILInjected.Token(Token = "0x4000C7F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private IWebProxy proxy;

		[global::Cpp2ILInjected.Token(Token = "0x4000C80")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private bool sendChunked;

		[global::Cpp2ILInjected.Token(Token = "0x4000C81")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private ServicePoint servicePoint;

		[global::Cpp2ILInjected.Token(Token = "0x4000C82")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private int timeout;

		[global::Cpp2ILInjected.Token(Token = "0x4000C83")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
		private int continueTimeout;

		[global::Cpp2ILInjected.Token(Token = "0x4000C84")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private WebRequestStream writeStream;

		[global::Cpp2ILInjected.Token(Token = "0x4000C85")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private HttpWebResponse webResponse;

		[global::Cpp2ILInjected.Token(Token = "0x4000C86")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private WebCompletionSource responseTask;

		[global::Cpp2ILInjected.Token(Token = "0x4000C87")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private WebOperation currentOperation;

		[global::Cpp2ILInjected.Token(Token = "0x4000C88")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		private int aborted;

		[global::Cpp2ILInjected.Token(Token = "0x4000C89")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11C")]
		private bool gotRequestStream;

		[global::Cpp2ILInjected.Token(Token = "0x4000C8A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		private int redirects;

		[global::Cpp2ILInjected.Token(Token = "0x4000C8B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x124")]
		private bool expectContinue;

		[global::Cpp2ILInjected.Token(Token = "0x4000C8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x125")]
		private bool getResponseCalled;

		[global::Cpp2ILInjected.Token(Token = "0x4000C8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		private object locker;

		[global::Cpp2ILInjected.Token(Token = "0x4000C8E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		private bool finished_reading;

		[global::Cpp2ILInjected.Token(Token = "0x4000C8F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x134")]
		private DecompressionMethods auto_decomp;

		[global::Cpp2ILInjected.Token(Token = "0x4000C90")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		private int maxResponseHeadersLength;

		[global::Cpp2ILInjected.Token(Token = "0x4000C91")]
		private static int defaultMaxResponseHeadersLength;

		[global::Cpp2ILInjected.Token(Token = "0x4000C92")]
		private static int defaultMaximumErrorResponseLength;

		[global::Cpp2ILInjected.Token(Token = "0x4000C93")]
		private static RequestCachePolicy defaultCachePolicy;

		[global::Cpp2ILInjected.Token(Token = "0x4000C94")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x13C")]
		private int readWriteTimeout;

		[global::Cpp2ILInjected.Token(Token = "0x4000C95")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		private MobileTlsProvider tlsProvider;

		[global::Cpp2ILInjected.Token(Token = "0x4000C96")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private MonoTlsSettings tlsSettings;

		[global::Cpp2ILInjected.Token(Token = "0x4000C97")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private ServerCertValidationCallback certValidationCallback;

		[global::Cpp2ILInjected.Token(Token = "0x4000C98")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private bool hostHasPort;

		[global::Cpp2ILInjected.Token(Token = "0x4000C99")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private Uri hostUri;

		[global::Cpp2ILInjected.Token(Token = "0x4000C9A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private HttpWebRequest.AuthorizationState auth_state;

		[global::Cpp2ILInjected.Token(Token = "0x4000C9B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private HttpWebRequest.AuthorizationState proxy_auth_state;

		[global::Cpp2ILInjected.Token(Token = "0x4000C9C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		[NonSerialized]
		internal Func<Stream, Task> ResendContentFactory;

		[global::Cpp2ILInjected.Token(Token = "0x4000C9D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		internal readonly int ID;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000C9E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x194")]
		private bool <ThrowOnError>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4000C9F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x195")]
		private bool unsafe_auth_blah;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000CA0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x196")]
		private bool <ReuseConnection>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x2000256")]
		private enum NtlmAuthState
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000CA2")]
			None,
			[global::Cpp2ILInjected.Token(Token = "0x4000CA3")]
			Challenge,
			[global::Cpp2ILInjected.Token(Token = "0x4000CA4")]
			Response
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000257")]
		private struct AuthorizationState
		{
			[global::Cpp2ILInjected.Token(Token = "0x17000396")]
			public bool IsCompleted
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001028")]
				[global::Cpp2ILInjected.Address(RVA = "0x1DFD874", Offset = "0x1DFD874", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000397")]
			public HttpWebRequest.NtlmAuthState NtlmAuthState
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001029")]
				[global::Cpp2ILInjected.Address(RVA = "0x1DFD87C", Offset = "0x1DFD87C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000398")]
			public bool IsNtlmAuthenticated
			{
				[global::Cpp2ILInjected.Token(Token = "0x600102A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1DFD884", Offset = "0x1DFD884", Length = "0x20")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x600102B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DFD8A4", Offset = "0x1DFD8A4", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "ResetAuthorization", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			public AuthorizationState(HttpWebRequest request, bool isProxy)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600102C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DFD8BC", Offset = "0x1DFD8BC", Length = "0x2EC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "CheckAuthorization", MemberParameters = new object[]
			{
				typeof(WebResponse),
				typeof(HttpStatusCode)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticationManager), Member = "Authenticate", MemberParameters = new object[]
			{
				typeof(string),
				typeof(WebRequest),
				typeof(ICredentials)
			}, ReturnType = typeof(Authorization))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			public bool CheckAuthorization(WebResponse response, HttpStatusCode code)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600102D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DFDBA8", Offset = "0x1DFDBA8", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "CheckFinalStatus", MemberParameters = new object[] { typeof(HttpWebResponse) }, ReturnType = typeof(ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "RemoveInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public void Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600102E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DFDC28", Offset = "0x1DFDC28", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public override string ToString()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000CA5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly HttpWebRequest request;

			[global::Cpp2ILInjected.Token(Token = "0x4000CA6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private readonly bool isProxy;

			[global::Cpp2ILInjected.Token(Token = "0x4000CA7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x9")]
			private bool isCompleted;

			[global::Cpp2ILInjected.Token(Token = "0x4000CA8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			private HttpWebRequest.NtlmAuthState ntlm_auth_state;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000258")]
		[Serializable]
		private sealed class <>c__241<T>
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600102F")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B1AD8", Offset = "0x15B1AD8", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			static <>c__241()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001030")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B1BC4", Offset = "0x15B1BC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__241()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001031")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B1BCC", Offset = "0x15B1BCC", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_Exception", ReturnType = typeof(AggregateException))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal int? <RunWithTimeoutWorker>b__241_0(Task<T> t)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000CA9")]
			public static readonly HttpWebRequest.<>c__241<T> <>9;

			[global::Cpp2ILInjected.Token(Token = "0x4000CAA")]
			public static Func<Task<T>, int?> <>9__241_0;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000259")]
		[StructLayout(3)]
		private struct <RunWithTimeoutWorker>d__241<T> : IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001032")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BB728", Offset = "0x15BB728", Length = "0x75C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServicePointScheduler), Member = "WaitAsync", MemberParameters = new object[]
			{
				typeof(Task),
				typeof(int)
			}, ReturnType = typeof(Task<bool>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<bool>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter),
				typeof(HttpWebRequest.<RunWithTimeoutWorker>d__241<int>)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter),
				typeof(ref HttpWebRequest.<RunWithTimeoutWorker>d__241<int>)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetResult", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(WebExceptionStatus)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "GetWebException", MemberParameters = new object[]
			{
				typeof(Exception),
				typeof(bool)
			}, ReturnType = typeof(WebException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 67)]
			private void MoveNext()
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001033")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BBE84", Offset = "0x15BBE84", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000CAB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000CAC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[global::Cpp2ILInjected.Token(Token = "0x4000CAD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Task<T> workerTask;

			[global::Cpp2ILInjected.Token(Token = "0x4000CAE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int timeout;

			[global::Cpp2ILInjected.Token(Token = "0x4000CAF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public CancellationTokenSource cts;

			[global::Cpp2ILInjected.Token(Token = "0x4000CB0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Action abort;

			[global::Cpp2ILInjected.Token(Token = "0x4000CB1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Func<bool> aborted;

			[global::Cpp2ILInjected.Token(Token = "0x4000CB2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter <>u__1;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200025A")]
		[StructLayout(3)]
		private struct <MyGetResponseAsync>d__243 : IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001034")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DFDD28", Offset = "0x1DFDD28", Length = "0xD18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "get_Aborted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "ThrowOnError", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "get_Task", ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "get_WriteStream", ReturnType = typeof(WebRequestStream))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "SendRequest", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(BufferOffsetSize),
				typeof(CancellationToken)
			}, ReturnType = typeof(WebOperation))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CreateRequestAbortedException", ReturnType = typeof(WebException))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponseStream), Member = "ReadAllAsync", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(CancellationToken)
			}, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "Finish", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "GetRequestStreamInternal", ReturnType = typeof(Task<WebRequestStream>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequestStream), Member = "WriteRequestAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "GetResponseStream", ReturnType = typeof(Task<WebResponseStream>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter<object>), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter<object>), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "GetResponseFromData", MemberParameters = new object[]
			{
				typeof(WebResponseStream),
				typeof(CancellationToken)
			}, ReturnType = typeof(Task<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<ValueTuple<object, bool, bool, object, object>>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<ValueTuple<object, bool, bool, object, object>>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<ValueTuple<object, bool, bool, object, object>>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<ValueTuple<object, bool, bool, object, object>>.ConfiguredTaskAwaiter),
				typeof(HttpWebRequest.<MyGetResponseAsync>d__243)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<ValueTuple<object, bool, bool, object, object>>.ConfiguredTaskAwaiter),
				typeof(ref HttpWebRequest.<MyGetResponseAsync>d__243)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(TaskAwaiter<object>),
				typeof(HttpWebRequest.<MyGetResponseAsync>d__243)
			}, MemberParameters = new object[]
			{
				typeof(ref TaskAwaiter<object>),
				typeof(ref HttpWebRequest.<MyGetResponseAsync>d__243)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(HttpWebRequest.<MyGetResponseAsync>d__243)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref HttpWebRequest.<MyGetResponseAsync>d__243)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "TrySetCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetResult", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(HttpWebRequest.<MyGetResponseAsync>d__243)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(ref HttpWebRequest.<MyGetResponseAsync>d__243)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "TrySetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "GetWebException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(WebException))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 74)]
			private void MoveNext()
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001035")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DFEA8C", Offset = "0x1DFEA8C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000CB3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000CB4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<HttpWebResponse> <>t__builder;

			[global::Cpp2ILInjected.Token(Token = "0x4000CB5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public HttpWebRequest <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000CB6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			[global::Cpp2ILInjected.Token(Token = "0x4000CB7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private WebCompletionSource <completion>5__2;

			[global::Cpp2ILInjected.Token(Token = "0x4000CB8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private WebOperation <operation>5__3;

			[global::Cpp2ILInjected.Token(Token = "0x4000CB9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private WebException <throwMe>5__4;

			[global::Cpp2ILInjected.Token(Token = "0x4000CBA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private HttpWebResponse <response>5__5;

			[global::Cpp2ILInjected.Token(Token = "0x4000CBB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private WebResponseStream <stream>5__6;

			[global::Cpp2ILInjected.Token(Token = "0x4000CBC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private bool <redirect>5__7;

			[global::Cpp2ILInjected.Token(Token = "0x4000CBD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x59")]
			private bool <mustReadAll>5__8;

			[global::Cpp2ILInjected.Token(Token = "0x4000CBE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private WebOperation <ntlm>5__9;

			[global::Cpp2ILInjected.Token(Token = "0x4000CBF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private BufferOffsetSize <writeBuffer>5__10;

			[global::Cpp2ILInjected.Token(Token = "0x4000CC0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter <>u__1;

			[global::Cpp2ILInjected.Token(Token = "0x4000CC1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			[global::Cpp2ILInjected.Token(Token = "0x4000CC2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
			private TaskAwaiter<WebResponseStream> <>u__3;

			[TupleElementNames(new string[] { "response", "redirect", "mustReadAll", "writeBuffer", "ntlm" })]
			[global::Cpp2ILInjected.Token(Token = "0x4000CC3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
			private ConfiguredTaskAwaitable<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.ConfiguredTaskAwaiter <>u__4;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200025B")]
		[StructLayout(3)]
		private struct <GetResponseFromData>d__244 : IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001036")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DFEAE4", Offset = "0x1DFEAE4", Length = "0x6F8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string),
				typeof(WebResponseStream),
				typeof(CookieContainer)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CheckFinalStatus", MemberParameters = new object[] { typeof(HttpWebResponse) }, ReturnType = typeof(ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponseStream), Member = "ReadAllAsync", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(CancellationToken)
			}, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(HttpWebRequest.<GetResponseFromData>d__244)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref HttpWebRequest.<GetResponseFromData>d__244)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "get_ProxyQuery", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(HttpWebRequest.<GetResponseFromData>d__244)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(ref HttpWebRequest.<GetResponseFromData>d__244)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "RemoveInternal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "HandleNtlmAuth", MemberParameters = new object[]
			{
				typeof(WebResponseStream),
				typeof(HttpWebResponse),
				typeof(BufferOffsetSize),
				typeof(CancellationToken)
			}, ReturnType = typeof(ValueTuple<WebOperation, bool>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequestStream), Member = "KillBuffer", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTuple<object, bool, bool, object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(bool),
				typeof(bool),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>), Member = "SetResult", MemberParameters = new object[] { typeof(ValueTuple<object, bool, bool, object, object>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
			private void MoveNext()
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001037")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DFF498", Offset = "0x1DFF498", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000CC4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[TupleElementNames(new string[] { "response", "redirect", "mustReadAll", "writeBuffer", "ntlm" })]
			[global::Cpp2ILInjected.Token(Token = "0x4000CC5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> <>t__builder;

			[global::Cpp2ILInjected.Token(Token = "0x4000CC6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public HttpWebRequest <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000CC7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public WebResponseStream stream;

			[global::Cpp2ILInjected.Token(Token = "0x4000CC8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public CancellationToken cancellationToken;

			[global::Cpp2ILInjected.Token(Token = "0x4000CC9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private HttpWebResponse <response>5__2;

			[global::Cpp2ILInjected.Token(Token = "0x4000CCA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private WebException <throwMe>5__3;

			[global::Cpp2ILInjected.Token(Token = "0x4000CCB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private bool <redirect>5__4;

			[global::Cpp2ILInjected.Token(Token = "0x4000CCC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
			private bool <mustReadAll>5__5;

			[global::Cpp2ILInjected.Token(Token = "0x4000CCD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			[global::Cpp2ILInjected.Token(Token = "0x4000CCE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private ConfiguredTaskAwaitable<BufferOffsetSize>.ConfiguredTaskAwaiter <>u__2;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200025C")]
		[StructLayout(3)]
		private struct <<GetRewriteHandler>b__271_0>d : IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001038")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DFF4F0", Offset = "0x1DFF4F0", Length = "0x3C8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(HttpWebRequest.<<GetRewriteHandler>b__271_0>d)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref HttpWebRequest.<<GetRewriteHandler>b__271_0>d)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferOffsetSize), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetResult", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
			private void MoveNext()
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001039")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DFF8B8", Offset = "0x1DFF8B8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<object>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000CCF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000CD0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<BufferOffsetSize> <>t__builder;

			[global::Cpp2ILInjected.Token(Token = "0x4000CD1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public HttpWebRequest <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000CD2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private MemoryStream <ms>5__2;

			[global::Cpp2ILInjected.Token(Token = "0x4000CD3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
