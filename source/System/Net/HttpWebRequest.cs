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
	// Token: 0x0200019E RID: 414
	[global::Cpp2ILInjected.Token(Token = "0x2000255")]
	[Serializable]
	public class HttpWebRequest : WebRequest, ISerializable
	{
		// Token: 0x06000DFF RID: 3583 RVA: 0x0000563C File Offset: 0x0000383C
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

		// Token: 0x06000E00 RID: 3584 RVA: 0x0000563F File Offset: 0x0000383F
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

		// Token: 0x06000E01 RID: 3585 RVA: 0x00005642 File Offset: 0x00003842
		[global::Cpp2ILInjected.Token(Token = "0x6000F8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F51BE8", Offset = "0x1F51BE8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		internal HttpWebRequest(Uri uri, MobileTlsProvider tlsProvider, MonoTlsSettings settings = null)
		{
			throw null;
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00005645 File Offset: 0x00003845
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

		// Token: 0x06000E03 RID: 3587 RVA: 0x00005648 File Offset: 0x00003848
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

		// Token: 0x06000E04 RID: 3588 RVA: 0x0000564B File Offset: 0x0000384B
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

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000E05 RID: 3589 RVA: 0x0000564E File Offset: 0x0000384E
		// (set) Token: 0x06000E06 RID: 3590 RVA: 0x00005651 File Offset: 0x00003851
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

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x00005654 File Offset: 0x00003854
		// (set) Token: 0x06000E08 RID: 3592 RVA: 0x00005657 File Offset: 0x00003857
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

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x0000565A File Offset: 0x0000385A
		// (set) Token: 0x06000E0A RID: 3594 RVA: 0x0000565D File Offset: 0x0000385D
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

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x00005660 File Offset: 0x00003860
		// (set) Token: 0x06000E0C RID: 3596 RVA: 0x00005663 File Offset: 0x00003863
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

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x00005666 File Offset: 0x00003866
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x00005669 File Offset: 0x00003869
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

		// Token: 0x06000E0F RID: 3599 RVA: 0x0000566C File Offset: 0x0000386C
		[global::Cpp2ILInjected.Token(Token = "0x6000F99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F51F3C", Offset = "0x1F51F3C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static Exception GetMustImplement()
		{
			throw null;
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x0000566F File Offset: 0x0000386F
		// (set) Token: 0x06000E11 RID: 3601 RVA: 0x00005672 File Offset: 0x00003872
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

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x00005675 File Offset: 0x00003875
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

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x00005678 File Offset: 0x00003878
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

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x0000567B File Offset: 0x0000387B
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

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x0000567E File Offset: 0x0000387E
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

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x00005681 File Offset: 0x00003881
		// (set) Token: 0x06000E17 RID: 3607 RVA: 0x00005684 File Offset: 0x00003884
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

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x00005687 File Offset: 0x00003887
		// (set) Token: 0x06000E19 RID: 3609 RVA: 0x0000568A File Offset: 0x0000388A
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

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x0000568D File Offset: 0x0000388D
		// (set) Token: 0x06000E1B RID: 3611 RVA: 0x00005690 File Offset: 0x00003890
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

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x00005693 File Offset: 0x00003893
		// (set) Token: 0x06000E1D RID: 3613 RVA: 0x00005696 File Offset: 0x00003896
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

		// Token: 0x1700034E RID: 846
		// (set) Token: 0x06000E1E RID: 3614 RVA: 0x00005699 File Offset: 0x00003899
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

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x0000569C File Offset: 0x0000389C
		// (set) Token: 0x06000E20 RID: 3616 RVA: 0x0000569F File Offset: 0x0000389F
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

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x000056A2 File Offset: 0x000038A2
		// (set) Token: 0x06000E22 RID: 3618 RVA: 0x000056A5 File Offset: 0x000038A5
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

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x000056A8 File Offset: 0x000038A8
		// (set) Token: 0x06000E24 RID: 3620 RVA: 0x000056AB File Offset: 0x000038AB
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

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x000056AE File Offset: 0x000038AE
		// (set) Token: 0x06000E26 RID: 3622 RVA: 0x000056B1 File Offset: 0x000038B1
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

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x000056B4 File Offset: 0x000038B4
		// (set) Token: 0x06000E28 RID: 3624 RVA: 0x000056B7 File Offset: 0x000038B7
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

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x000056BA File Offset: 0x000038BA
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x000056BD File Offset: 0x000038BD
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

		// Token: 0x06000E2B RID: 3627 RVA: 0x000056C0 File Offset: 0x000038C0
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

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x000056C3 File Offset: 0x000038C3
		// (set) Token: 0x06000E2D RID: 3629 RVA: 0x000056C6 File Offset: 0x000038C6
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

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x000056C9 File Offset: 0x000038C9
		// (set) Token: 0x06000E2F RID: 3631 RVA: 0x000056CC File Offset: 0x000038CC
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

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x000056CF File Offset: 0x000038CF
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

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x000056D2 File Offset: 0x000038D2
		// (set) Token: 0x06000E32 RID: 3634 RVA: 0x000056D5 File Offset: 0x000038D5
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

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x000056D8 File Offset: 0x000038D8
		// (set) Token: 0x06000E34 RID: 3636 RVA: 0x000056DB File Offset: 0x000038DB
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

		// Token: 0x06000E35 RID: 3637 RVA: 0x000056DE File Offset: 0x000038DE
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

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x000056E1 File Offset: 0x000038E1
		// (set) Token: 0x06000E37 RID: 3639 RVA: 0x000056E4 File Offset: 0x000038E4
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

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x000056E7 File Offset: 0x000038E7
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x000056EA File Offset: 0x000038EA
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

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x000056ED File Offset: 0x000038ED
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x000056F0 File Offset: 0x000038F0
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

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x000056F3 File Offset: 0x000038F3
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x000056F6 File Offset: 0x000038F6
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

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x000056F9 File Offset: 0x000038F9
		// (set) Token: 0x06000E3F RID: 3647 RVA: 0x000056FC File Offset: 0x000038FC
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

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x000056FF File Offset: 0x000038FF
		// (set) Token: 0x06000E41 RID: 3649 RVA: 0x00005702 File Offset: 0x00003902
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

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x00005705 File Offset: 0x00003905
		// (set) Token: 0x06000E43 RID: 3651 RVA: 0x00005708 File Offset: 0x00003908
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

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x0000570B File Offset: 0x0000390B
		// (set) Token: 0x06000E45 RID: 3653 RVA: 0x0000570E File Offset: 0x0000390E
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

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x00005711 File Offset: 0x00003911
		// (set) Token: 0x06000E47 RID: 3655 RVA: 0x00005714 File Offset: 0x00003914
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

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x00005717 File Offset: 0x00003917
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x0000571A File Offset: 0x0000391A
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

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x0000571D File Offset: 0x0000391D
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x00005720 File Offset: 0x00003920
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

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x00005723 File Offset: 0x00003923
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x00005726 File Offset: 0x00003926
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

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x00005729 File Offset: 0x00003929
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x0000572C File Offset: 0x0000392C
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

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x0000572F File Offset: 0x0000392F
		// (set) Token: 0x06000E51 RID: 3665 RVA: 0x00005732 File Offset: 0x00003932
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

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x00005735 File Offset: 0x00003935
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

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x00005738 File Offset: 0x00003938
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x0000573B File Offset: 0x0000393B
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

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x0000573E File Offset: 0x0000393E
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

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x00005741 File Offset: 0x00003941
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

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x00005744 File Offset: 0x00003944
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

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00005747 File Offset: 0x00003947
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x0000574A File Offset: 0x0000394A
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

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x0000574D File Offset: 0x0000394D
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x00005750 File Offset: 0x00003950
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

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x00005753 File Offset: 0x00003953
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x00005756 File Offset: 0x00003956
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

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00005759 File Offset: 0x00003959
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x0000575C File Offset: 0x0000395C
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

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x0000575F File Offset: 0x0000395F
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x00005762 File Offset: 0x00003962
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

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x00005765 File Offset: 0x00003965
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

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x00005768 File Offset: 0x00003968
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x0000576B File Offset: 0x0000396B
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

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x0000576E File Offset: 0x0000396E
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

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x00005771 File Offset: 0x00003971
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

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x00005774 File Offset: 0x00003974
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

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00005777 File Offset: 0x00003977
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x0000577A File Offset: 0x0000397A
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

		// Token: 0x06000E6A RID: 3690 RVA: 0x0000577D File Offset: 0x0000397D
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

		// Token: 0x06000E6B RID: 3691 RVA: 0x00005780 File Offset: 0x00003980
		[global::Cpp2ILInjected.Token(Token = "0x6000FF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F53CCC", Offset = "0x1F53CCC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddRange(int range)
		{
			throw null;
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00005783 File Offset: 0x00003983
		[global::Cpp2ILInjected.Token(Token = "0x6000FF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F53FAC", Offset = "0x1F53FAC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddRange(int from, int to)
		{
			throw null;
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00005786 File Offset: 0x00003986
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

		// Token: 0x06000E6E RID: 3694 RVA: 0x00005789 File Offset: 0x00003989
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

		// Token: 0x06000E6F RID: 3695 RVA: 0x0000578C File Offset: 0x0000398C
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

		// Token: 0x06000E70 RID: 3696 RVA: 0x0000578F File Offset: 0x0000398F
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

		// Token: 0x06000E71 RID: 3697 RVA: 0x00005792 File Offset: 0x00003992
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

		// Token: 0x06000E72 RID: 3698 RVA: 0x00005795 File Offset: 0x00003995
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

		// Token: 0x06000E73 RID: 3699 RVA: 0x00005798 File Offset: 0x00003998
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

		// Token: 0x06000E74 RID: 3700 RVA: 0x0000579B File Offset: 0x0000399B
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

		// Token: 0x06000E75 RID: 3701 RVA: 0x0000579E File Offset: 0x0000399E
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

		// Token: 0x06000E76 RID: 3702 RVA: 0x000057A1 File Offset: 0x000039A1
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

		// Token: 0x06000E77 RID: 3703 RVA: 0x000057A4 File Offset: 0x000039A4
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

		// Token: 0x06000E78 RID: 3704 RVA: 0x000057A7 File Offset: 0x000039A7
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

		// Token: 0x06000E79 RID: 3705 RVA: 0x000057AA File Offset: 0x000039AA
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

		// Token: 0x06000E7A RID: 3706 RVA: 0x000057AD File Offset: 0x000039AD
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

		// Token: 0x06000E7B RID: 3707 RVA: 0x000057B0 File Offset: 0x000039B0
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

		// Token: 0x06000E7C RID: 3708 RVA: 0x000057B3 File Offset: 0x000039B3
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

		// Token: 0x06000E7D RID: 3709 RVA: 0x000057B6 File Offset: 0x000039B6
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

		// Token: 0x06000E7E RID: 3710 RVA: 0x000057B9 File Offset: 0x000039B9
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

		// Token: 0x06000E7F RID: 3711 RVA: 0x000057BC File Offset: 0x000039BC
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

		// Token: 0x06000E80 RID: 3712 RVA: 0x000057BF File Offset: 0x000039BF
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

		// Token: 0x06000E81 RID: 3713 RVA: 0x000057C2 File Offset: 0x000039C2
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

		// Token: 0x06000E82 RID: 3714 RVA: 0x000057C5 File Offset: 0x000039C5
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

		// Token: 0x06000E83 RID: 3715 RVA: 0x000057C8 File Offset: 0x000039C8
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

		// Token: 0x06000E84 RID: 3716 RVA: 0x000057CB File Offset: 0x000039CB
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

		// Token: 0x06000E85 RID: 3717 RVA: 0x000057CE File Offset: 0x000039CE
		[global::Cpp2ILInjected.Token(Token = "0x600100F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F554B4", Offset = "0x1F554B4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public Stream EndGetRequestStream(IAsyncResult asyncResult, out TransportContext context)
		{
			throw null;
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x000057D1 File Offset: 0x000039D1
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

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000E87 RID: 3719 RVA: 0x000057D4 File Offset: 0x000039D4
		// (set) Token: 0x06000E88 RID: 3720 RVA: 0x000057D7 File Offset: 0x000039D7
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

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000E89 RID: 3721 RVA: 0x000057DA File Offset: 0x000039DA
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

		// Token: 0x06000E8A RID: 3722 RVA: 0x000057DD File Offset: 0x000039DD
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

		// Token: 0x06000E8B RID: 3723 RVA: 0x000057E0 File Offset: 0x000039E0
		[global::Cpp2ILInjected.Token(Token = "0x6001015")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F55738", Offset = "0x1F55738", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x000057E3 File Offset: 0x000039E3
		[global::Cpp2ILInjected.Token(Token = "0x6001016")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F55770", Offset = "0x1F55770", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x000057E6 File Offset: 0x000039E6
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

		// Token: 0x06000E8E RID: 3726 RVA: 0x000057E9 File Offset: 0x000039E9
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

		// Token: 0x06000E8F RID: 3727 RVA: 0x000057EC File Offset: 0x000039EC
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

		// Token: 0x06000E90 RID: 3728 RVA: 0x000057EF File Offset: 0x000039EF
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

		// Token: 0x06000E91 RID: 3729 RVA: 0x000057F2 File Offset: 0x000039F2
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

		// Token: 0x06000E92 RID: 3730 RVA: 0x000057F5 File Offset: 0x000039F5
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

		// Token: 0x06000E93 RID: 3731 RVA: 0x000057F8 File Offset: 0x000039F8
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

		// Token: 0x06000E94 RID: 3732 RVA: 0x000057FB File Offset: 0x000039FB
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

		// Token: 0x06000E95 RID: 3733 RVA: 0x000057FE File Offset: 0x000039FE
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

		// Token: 0x06000E96 RID: 3734 RVA: 0x00005801 File Offset: 0x00003A01
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

		// Token: 0x06000E97 RID: 3735 RVA: 0x00005804 File Offset: 0x00003A04
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

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x00005807 File Offset: 0x00003A07
		// (set) Token: 0x06000E99 RID: 3737 RVA: 0x0000580A File Offset: 0x00003A0A
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

		// Token: 0x06000E9A RID: 3738 RVA: 0x0000580D File Offset: 0x00003A0D
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

		// Token: 0x06000E9B RID: 3739 RVA: 0x00005810 File Offset: 0x00003A10
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

		// Token: 0x06000E9C RID: 3740 RVA: 0x00005813 File Offset: 0x00003A13
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

		// Token: 0x06000E9D RID: 3741 RVA: 0x00005816 File Offset: 0x00003A16
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

		// Token: 0x040009AD RID: 2477
		[global::Cpp2ILInjected.Token(Token = "0x4000C64")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Uri requestUri;

		// Token: 0x040009AE RID: 2478
		[global::Cpp2ILInjected.Token(Token = "0x4000C65")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Uri actualUri;

		// Token: 0x040009AF RID: 2479
		[global::Cpp2ILInjected.Token(Token = "0x4000C66")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool hostChanged;

		// Token: 0x040009B0 RID: 2480
		[global::Cpp2ILInjected.Token(Token = "0x4000C67")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
		private bool allowAutoRedirect;

		// Token: 0x040009B1 RID: 2481
		[global::Cpp2ILInjected.Token(Token = "0x4000C68")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4A")]
		private bool allowBuffering;

		// Token: 0x040009B2 RID: 2482
		[global::Cpp2ILInjected.Token(Token = "0x4000C69")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4B")]
		private bool allowReadStreamBuffering;

		// Token: 0x040009B3 RID: 2483
		[global::Cpp2ILInjected.Token(Token = "0x4000C6A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private X509CertificateCollection certificates;

		// Token: 0x040009B4 RID: 2484
		[global::Cpp2ILInjected.Token(Token = "0x4000C6B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string connectionGroup;

		// Token: 0x040009B5 RID: 2485
		[global::Cpp2ILInjected.Token(Token = "0x4000C6C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private bool haveContentLength;

		// Token: 0x040009B6 RID: 2486
		[global::Cpp2ILInjected.Token(Token = "0x4000C6D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private long contentLength;

		// Token: 0x040009B7 RID: 2487
		[global::Cpp2ILInjected.Token(Token = "0x4000C6E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private HttpContinueDelegate continueDelegate;

		// Token: 0x040009B8 RID: 2488
		[global::Cpp2ILInjected.Token(Token = "0x4000C6F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private CookieContainer cookieContainer;

		// Token: 0x040009B9 RID: 2489
		[global::Cpp2ILInjected.Token(Token = "0x4000C70")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private ICredentials credentials;

		// Token: 0x040009BA RID: 2490
		[global::Cpp2ILInjected.Token(Token = "0x4000C71")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private bool haveResponse;

		// Token: 0x040009BB RID: 2491
		[global::Cpp2ILInjected.Token(Token = "0x4000C72")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x89")]
		private bool requestSent;

		// Token: 0x040009BC RID: 2492
		[global::Cpp2ILInjected.Token(Token = "0x4000C73")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private WebHeaderCollection webHeaders;

		// Token: 0x040009BD RID: 2493
		[global::Cpp2ILInjected.Token(Token = "0x4000C74")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private bool keepAlive;

		// Token: 0x040009BE RID: 2494
		[global::Cpp2ILInjected.Token(Token = "0x4000C75")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		private int maxAutoRedirect;

		// Token: 0x040009BF RID: 2495
		[global::Cpp2ILInjected.Token(Token = "0x4000C76")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private string mediaType;

		// Token: 0x040009C0 RID: 2496
		[global::Cpp2ILInjected.Token(Token = "0x4000C77")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private string method;

		// Token: 0x040009C1 RID: 2497
		[global::Cpp2ILInjected.Token(Token = "0x4000C78")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private string initialMethod;

		// Token: 0x040009C2 RID: 2498
		[global::Cpp2ILInjected.Token(Token = "0x4000C79")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private bool pipelined;

		// Token: 0x040009C3 RID: 2499
		[global::Cpp2ILInjected.Token(Token = "0x4000C7A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB9")]
		private bool preAuthenticate;

		// Token: 0x040009C4 RID: 2500
		[global::Cpp2ILInjected.Token(Token = "0x4000C7B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xBA")]
		private bool usedPreAuth;

		// Token: 0x040009C5 RID: 2501
		[global::Cpp2ILInjected.Token(Token = "0x4000C7C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private Version version;

		// Token: 0x040009C6 RID: 2502
		[global::Cpp2ILInjected.Token(Token = "0x4000C7D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private bool force_version;

		// Token: 0x040009C7 RID: 2503
		[global::Cpp2ILInjected.Token(Token = "0x4000C7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private Version actualVersion;

		// Token: 0x040009C8 RID: 2504
		[global::Cpp2ILInjected.Token(Token = "0x4000C7F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private IWebProxy proxy;

		// Token: 0x040009C9 RID: 2505
		[global::Cpp2ILInjected.Token(Token = "0x4000C80")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private bool sendChunked;

		// Token: 0x040009CA RID: 2506
		[global::Cpp2ILInjected.Token(Token = "0x4000C81")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private ServicePoint servicePoint;

		// Token: 0x040009CB RID: 2507
		[global::Cpp2ILInjected.Token(Token = "0x4000C82")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private int timeout;

		// Token: 0x040009CC RID: 2508
		[global::Cpp2ILInjected.Token(Token = "0x4000C83")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
		private int continueTimeout;

		// Token: 0x040009CD RID: 2509
		[global::Cpp2ILInjected.Token(Token = "0x4000C84")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private WebRequestStream writeStream;

		// Token: 0x040009CE RID: 2510
		[global::Cpp2ILInjected.Token(Token = "0x4000C85")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private HttpWebResponse webResponse;

		// Token: 0x040009CF RID: 2511
		[global::Cpp2ILInjected.Token(Token = "0x4000C86")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private WebCompletionSource responseTask;

		// Token: 0x040009D0 RID: 2512
		[global::Cpp2ILInjected.Token(Token = "0x4000C87")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private WebOperation currentOperation;

		// Token: 0x040009D1 RID: 2513
		[global::Cpp2ILInjected.Token(Token = "0x4000C88")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		private int aborted;

		// Token: 0x040009D2 RID: 2514
		[global::Cpp2ILInjected.Token(Token = "0x4000C89")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11C")]
		private bool gotRequestStream;

		// Token: 0x040009D3 RID: 2515
		[global::Cpp2ILInjected.Token(Token = "0x4000C8A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		private int redirects;

		// Token: 0x040009D4 RID: 2516
		[global::Cpp2ILInjected.Token(Token = "0x4000C8B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x124")]
		private bool expectContinue;

		// Token: 0x040009D5 RID: 2517
		[global::Cpp2ILInjected.Token(Token = "0x4000C8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x125")]
		private bool getResponseCalled;

		// Token: 0x040009D6 RID: 2518
		[global::Cpp2ILInjected.Token(Token = "0x4000C8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		private object locker;

		// Token: 0x040009D7 RID: 2519
		[global::Cpp2ILInjected.Token(Token = "0x4000C8E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		private bool finished_reading;

		// Token: 0x040009D8 RID: 2520
		[global::Cpp2ILInjected.Token(Token = "0x4000C8F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x134")]
		private DecompressionMethods auto_decomp;

		// Token: 0x040009D9 RID: 2521
		[global::Cpp2ILInjected.Token(Token = "0x4000C90")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		private int maxResponseHeadersLength;

		// Token: 0x040009DA RID: 2522
		[global::Cpp2ILInjected.Token(Token = "0x4000C91")]
		private static int defaultMaxResponseHeadersLength;

		// Token: 0x040009DB RID: 2523
		[global::Cpp2ILInjected.Token(Token = "0x4000C92")]
		private static int defaultMaximumErrorResponseLength;

		// Token: 0x040009DC RID: 2524
		[global::Cpp2ILInjected.Token(Token = "0x4000C93")]
		private static RequestCachePolicy defaultCachePolicy;

		// Token: 0x040009DD RID: 2525
		[global::Cpp2ILInjected.Token(Token = "0x4000C94")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x13C")]
		private int readWriteTimeout;

		// Token: 0x040009DE RID: 2526
		[global::Cpp2ILInjected.Token(Token = "0x4000C95")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		private MobileTlsProvider tlsProvider;

		// Token: 0x040009DF RID: 2527
		[global::Cpp2ILInjected.Token(Token = "0x4000C96")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private MonoTlsSettings tlsSettings;

		// Token: 0x040009E0 RID: 2528
		[global::Cpp2ILInjected.Token(Token = "0x4000C97")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private ServerCertValidationCallback certValidationCallback;

		// Token: 0x040009E1 RID: 2529
		[global::Cpp2ILInjected.Token(Token = "0x4000C98")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private bool hostHasPort;

		// Token: 0x040009E2 RID: 2530
		[global::Cpp2ILInjected.Token(Token = "0x4000C99")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private Uri hostUri;

		// Token: 0x040009E3 RID: 2531
		[global::Cpp2ILInjected.Token(Token = "0x4000C9A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private HttpWebRequest.AuthorizationState auth_state;

		// Token: 0x040009E4 RID: 2532
		[global::Cpp2ILInjected.Token(Token = "0x4000C9B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private HttpWebRequest.AuthorizationState proxy_auth_state;

		// Token: 0x040009E5 RID: 2533
		[global::Cpp2ILInjected.Token(Token = "0x4000C9C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		[NonSerialized]
		internal Func<Stream, Task> ResendContentFactory;

		// Token: 0x040009E6 RID: 2534
		[global::Cpp2ILInjected.Token(Token = "0x4000C9D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		internal readonly int ID;

		// Token: 0x040009E7 RID: 2535
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000C9E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x194")]
		private bool <ThrowOnError>k__BackingField;

		// Token: 0x040009E8 RID: 2536
		[global::Cpp2ILInjected.Token(Token = "0x4000C9F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x195")]
		private bool unsafe_auth_blah;

		// Token: 0x040009E9 RID: 2537
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000CA0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x196")]
		private bool <ReuseConnection>k__BackingField;

		// Token: 0x0200041B RID: 1051
		[global::Cpp2ILInjected.Token(Token = "0x2000256")]
		private enum NtlmAuthState
		{
			// Token: 0x04001241 RID: 4673
			[global::Cpp2ILInjected.Token(Token = "0x4000CA2")]
			None,
			// Token: 0x04001242 RID: 4674
			[global::Cpp2ILInjected.Token(Token = "0x4000CA3")]
			Challenge,
			// Token: 0x04001243 RID: 4675
			[global::Cpp2ILInjected.Token(Token = "0x4000CA4")]
			Response
		}

		// Token: 0x0200041C RID: 1052
		[global::Cpp2ILInjected.Token(Token = "0x2000257")]
		private struct AuthorizationState
		{
			// Token: 0x1700073E RID: 1854
			// (get) Token: 0x06001E29 RID: 7721 RVA: 0x000082FA File Offset: 0x000064FA
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

			// Token: 0x1700073F RID: 1855
			// (get) Token: 0x06001E2A RID: 7722 RVA: 0x000082FD File Offset: 0x000064FD
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

			// Token: 0x17000740 RID: 1856
			// (get) Token: 0x06001E2B RID: 7723 RVA: 0x00008300 File Offset: 0x00006500
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

			// Token: 0x06001E2C RID: 7724 RVA: 0x00008303 File Offset: 0x00006503
			[global::Cpp2ILInjected.Token(Token = "0x600102B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DFD8A4", Offset = "0x1DFD8A4", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "ResetAuthorization", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			public AuthorizationState(HttpWebRequest request, bool isProxy)
			{
				throw null;
			}

			// Token: 0x06001E2D RID: 7725 RVA: 0x00008306 File Offset: 0x00006506
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

			// Token: 0x06001E2E RID: 7726 RVA: 0x00008309 File Offset: 0x00006509
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

			// Token: 0x06001E2F RID: 7727 RVA: 0x0000830C File Offset: 0x0000650C
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

			// Token: 0x04001244 RID: 4676
			[global::Cpp2ILInjected.Token(Token = "0x4000CA5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly HttpWebRequest request;

			// Token: 0x04001245 RID: 4677
			[global::Cpp2ILInjected.Token(Token = "0x4000CA6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private readonly bool isProxy;

			// Token: 0x04001246 RID: 4678
			[global::Cpp2ILInjected.Token(Token = "0x4000CA7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x9")]
			private bool isCompleted;

			// Token: 0x04001247 RID: 4679
			[global::Cpp2ILInjected.Token(Token = "0x4000CA8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			private HttpWebRequest.NtlmAuthState ntlm_auth_state;
		}

		// Token: 0x0200041D RID: 1053
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000258")]
		[Serializable]
		private sealed class <>c__241<T>
		{
			// Token: 0x06001E30 RID: 7728 RVA: 0x0000830F File Offset: 0x0000650F
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

			// Token: 0x06001E31 RID: 7729 RVA: 0x00008312 File Offset: 0x00006512
			[global::Cpp2ILInjected.Token(Token = "0x6001030")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B1BC4", Offset = "0x15B1BC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__241()
			{
				throw null;
			}

			// Token: 0x06001E32 RID: 7730 RVA: 0x00008315 File Offset: 0x00006515
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

			// Token: 0x04001248 RID: 4680
			[global::Cpp2ILInjected.Token(Token = "0x4000CA9")]
			public static readonly HttpWebRequest.<>c__241<T> <>9;

			// Token: 0x04001249 RID: 4681
			[global::Cpp2ILInjected.Token(Token = "0x4000CAA")]
			public static Func<Task<T>, int?> <>9__241_0;
		}

		// Token: 0x0200041E RID: 1054
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000259")]
		[StructLayout(3)]
		private struct <RunWithTimeoutWorker>d__241<T> : IAsyncStateMachine
		{
			// Token: 0x06001E33 RID: 7731 RVA: 0x00008318 File Offset: 0x00006518
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

			// Token: 0x06001E34 RID: 7732 RVA: 0x0000831B File Offset: 0x0000651B
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

			// Token: 0x0400124A RID: 4682
			[global::Cpp2ILInjected.Token(Token = "0x4000CAB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400124B RID: 4683
			[global::Cpp2ILInjected.Token(Token = "0x4000CAC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			// Token: 0x0400124C RID: 4684
			[global::Cpp2ILInjected.Token(Token = "0x4000CAD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Task<T> workerTask;

			// Token: 0x0400124D RID: 4685
			[global::Cpp2ILInjected.Token(Token = "0x4000CAE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int timeout;

			// Token: 0x0400124E RID: 4686
			[global::Cpp2ILInjected.Token(Token = "0x4000CAF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public CancellationTokenSource cts;

			// Token: 0x0400124F RID: 4687
			[global::Cpp2ILInjected.Token(Token = "0x4000CB0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Action abort;

			// Token: 0x04001250 RID: 4688
			[global::Cpp2ILInjected.Token(Token = "0x4000CB1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Func<bool> aborted;

			// Token: 0x04001251 RID: 4689
			[global::Cpp2ILInjected.Token(Token = "0x4000CB2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200041F RID: 1055
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200025A")]
		[StructLayout(3)]
		private struct <MyGetResponseAsync>d__243 : IAsyncStateMachine
		{
			// Token: 0x06001E35 RID: 7733 RVA: 0x0000831E File Offset: 0x0000651E
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

			// Token: 0x06001E36 RID: 7734 RVA: 0x00008321 File Offset: 0x00006521
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

			// Token: 0x04001252 RID: 4690
			[global::Cpp2ILInjected.Token(Token = "0x4000CB3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001253 RID: 4691
			[global::Cpp2ILInjected.Token(Token = "0x4000CB4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<HttpWebResponse> <>t__builder;

			// Token: 0x04001254 RID: 4692
			[global::Cpp2ILInjected.Token(Token = "0x4000CB5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public HttpWebRequest <>4__this;

			// Token: 0x04001255 RID: 4693
			[global::Cpp2ILInjected.Token(Token = "0x4000CB6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			// Token: 0x04001256 RID: 4694
			[global::Cpp2ILInjected.Token(Token = "0x4000CB7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private WebCompletionSource <completion>5__2;

			// Token: 0x04001257 RID: 4695
			[global::Cpp2ILInjected.Token(Token = "0x4000CB8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private WebOperation <operation>5__3;

			// Token: 0x04001258 RID: 4696
			[global::Cpp2ILInjected.Token(Token = "0x4000CB9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private WebException <throwMe>5__4;

			// Token: 0x04001259 RID: 4697
			[global::Cpp2ILInjected.Token(Token = "0x4000CBA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private HttpWebResponse <response>5__5;

			// Token: 0x0400125A RID: 4698
			[global::Cpp2ILInjected.Token(Token = "0x4000CBB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private WebResponseStream <stream>5__6;

			// Token: 0x0400125B RID: 4699
			[global::Cpp2ILInjected.Token(Token = "0x4000CBC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private bool <redirect>5__7;

			// Token: 0x0400125C RID: 4700
			[global::Cpp2ILInjected.Token(Token = "0x4000CBD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x59")]
			private bool <mustReadAll>5__8;

			// Token: 0x0400125D RID: 4701
			[global::Cpp2ILInjected.Token(Token = "0x4000CBE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private WebOperation <ntlm>5__9;

			// Token: 0x0400125E RID: 4702
			[global::Cpp2ILInjected.Token(Token = "0x4000CBF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private BufferOffsetSize <writeBuffer>5__10;

			// Token: 0x0400125F RID: 4703
			[global::Cpp2ILInjected.Token(Token = "0x4000CC0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			private ConfiguredTaskAwaitable<WebRequestStream>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04001260 RID: 4704
			[global::Cpp2ILInjected.Token(Token = "0x4000CC1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;

			// Token: 0x04001261 RID: 4705
			[global::Cpp2ILInjected.Token(Token = "0x4000CC2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
			private TaskAwaiter<WebResponseStream> <>u__3;

			// Token: 0x04001262 RID: 4706
			[TupleElementNames(new string[] { "response", "redirect", "mustReadAll", "writeBuffer", "ntlm" })]
			[global::Cpp2ILInjected.Token(Token = "0x4000CC3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
			private ConfiguredTaskAwaitable<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>>.ConfiguredTaskAwaiter <>u__4;
		}

		// Token: 0x02000420 RID: 1056
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200025B")]
		[StructLayout(3)]
		private struct <GetResponseFromData>d__244 : IAsyncStateMachine
		{
			// Token: 0x06001E37 RID: 7735 RVA: 0x00008324 File Offset: 0x00006524
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

			// Token: 0x06001E38 RID: 7736 RVA: 0x00008327 File Offset: 0x00006527
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

			// Token: 0x04001263 RID: 4707
			[global::Cpp2ILInjected.Token(Token = "0x4000CC4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001264 RID: 4708
			[TupleElementNames(new string[] { "response", "redirect", "mustReadAll", "writeBuffer", "ntlm" })]
			[global::Cpp2ILInjected.Token(Token = "0x4000CC5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> <>t__builder;

			// Token: 0x04001265 RID: 4709
			[global::Cpp2ILInjected.Token(Token = "0x4000CC6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public HttpWebRequest <>4__this;

			// Token: 0x04001266 RID: 4710
			[global::Cpp2ILInjected.Token(Token = "0x4000CC7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public WebResponseStream stream;

			// Token: 0x04001267 RID: 4711
			[global::Cpp2ILInjected.Token(Token = "0x4000CC8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public CancellationToken cancellationToken;

			// Token: 0x04001268 RID: 4712
			[global::Cpp2ILInjected.Token(Token = "0x4000CC9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private HttpWebResponse <response>5__2;

			// Token: 0x04001269 RID: 4713
			[global::Cpp2ILInjected.Token(Token = "0x4000CCA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private WebException <throwMe>5__3;

			// Token: 0x0400126A RID: 4714
			[global::Cpp2ILInjected.Token(Token = "0x4000CCB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private bool <redirect>5__4;

			// Token: 0x0400126B RID: 4715
			[global::Cpp2ILInjected.Token(Token = "0x4000CCC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
			private bool <mustReadAll>5__5;

			// Token: 0x0400126C RID: 4716
			[global::Cpp2ILInjected.Token(Token = "0x4000CCD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x0400126D RID: 4717
			[global::Cpp2ILInjected.Token(Token = "0x4000CCE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private ConfiguredTaskAwaitable<BufferOffsetSize>.ConfiguredTaskAwaiter <>u__2;
		}

		// Token: 0x02000421 RID: 1057
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200025C")]
		[StructLayout(3)]
		private struct <<GetRewriteHandler>b__271_0>d : IAsyncStateMachine
		{
			// Token: 0x06001E39 RID: 7737 RVA: 0x0000832A File Offset: 0x0000652A
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

			// Token: 0x06001E3A RID: 7738 RVA: 0x0000832D File Offset: 0x0000652D
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

			// Token: 0x0400126E RID: 4718
			[global::Cpp2ILInjected.Token(Token = "0x4000CCF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400126F RID: 4719
			[global::Cpp2ILInjected.Token(Token = "0x4000CD0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<BufferOffsetSize> <>t__builder;

			// Token: 0x04001270 RID: 4720
			[global::Cpp2ILInjected.Token(Token = "0x4000CD1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public HttpWebRequest <>4__this;

			// Token: 0x04001271 RID: 4721
			[global::Cpp2ILInjected.Token(Token = "0x4000CD2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private MemoryStream <ms>5__2;

			// Token: 0x04001272 RID: 4722
			[global::Cpp2ILInjected.Token(Token = "0x4000CD3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
