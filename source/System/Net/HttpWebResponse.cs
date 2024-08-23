using System;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200019F RID: 415
	[global::Cpp2ILInjected.Token(Token = "0x200025D")]
	[Serializable]
	public class HttpWebResponse : WebResponse, ISerializable, IDisposable
	{
		// Token: 0x06000E9E RID: 3742 RVA: 0x00005819 File Offset: 0x00003A19
		[global::Cpp2ILInjected.Token(Token = "0x600103A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFF910", Offset = "0x1DFF910", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponse), Member = ".ctor", ReturnType = typeof(void))]
		public HttpWebResponse()
		{
			throw null;
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0000581C File Offset: 0x00003A1C
		[global::Cpp2ILInjected.Token(Token = "0x600103B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFF918", Offset = "0x1DFF918", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionTunnel.<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponse), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpStatusDescription), Member = "Get", MemberParameters = new object[] { typeof(HttpStatusCode) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal HttpWebResponse(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers)
		{
			throw null;
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x0000581F File Offset: 0x00003A1F
		[global::Cpp2ILInjected.Token(Token = "0x600103C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFF1DC", Offset = "0x1DFF1DC", Length = "0x2BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.<GetResponseFromData>d__244", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponse), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpStatusDescription), Member = "Get", MemberParameters = new object[] { typeof(HttpStatusCode) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebResponse), Member = "FillCookies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "Remove", MemberParameters = new object[] { typeof(HttpRequestHeader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		internal HttpWebResponse(Uri uri, string method, WebResponseStream stream, CookieContainer container)
		{
			throw null;
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00005822 File Offset: 0x00003A22
		[Obsolete("Serialization is obsoleted for this type", false)]
		[global::Cpp2ILInjected.Token(Token = "0x600103D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFFBBC", Offset = "0x1DFFBBC", Length = "0x390")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponse), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetInt64", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		protected HttpWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x00005825 File Offset: 0x00003A25
		[global::Cpp2ILInjected.Token(Token = "0x17000399")]
		public string CharacterSet
		{
			[global::Cpp2ILInjected.Token(Token = "0x600103E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DFFF4C", Offset = "0x1DFFF4C", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
			{
				typeof(string),
				typeof(StringComparison)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
			{
				typeof(char),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x00005828 File Offset: 0x00003A28
		[global::Cpp2ILInjected.Token(Token = "0x1700039A")]
		public string ContentEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x600103F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E00038", Offset = "0x1E00038", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x0000582B File Offset: 0x00003A2B
		[global::Cpp2ILInjected.Token(Token = "0x1700039B")]
		public override long ContentLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001040")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E00128", Offset = "0x1E00128", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x0000582E File Offset: 0x00003A2E
		[global::Cpp2ILInjected.Token(Token = "0x1700039C")]
		public override string ContentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001041")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E00130", Offset = "0x1E00130", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x00005831 File Offset: 0x00003A31
		// (set) Token: 0x06000EA7 RID: 3751 RVA: 0x00005834 File Offset: 0x00003A34
		[global::Cpp2ILInjected.Token(Token = "0x1700039D")]
		public virtual CookieCollection Cookies
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001042")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E001BC", Offset = "0x1E001BC", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001043")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E00228", Offset = "0x1E00228", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x00005837 File Offset: 0x00003A37
		[global::Cpp2ILInjected.Token(Token = "0x1700039E")]
		public override WebHeaderCollection Headers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001044")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E0024C", Offset = "0x1E0024C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x0000583A File Offset: 0x00003A3A
		[global::Cpp2ILInjected.Token(Token = "0x6001045")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E00254", Offset = "0x1E00254", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = "get_IsMutuallyAuthenticated", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static Exception GetMustImplement()
		{
			throw null;
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x0000583D File Offset: 0x00003A3D
		[MonoTODO]
		[global::Cpp2ILInjected.Token(Token = "0x1700039F")]
		public override bool IsMutuallyAuthenticated
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001046")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E002A8", Offset = "0x1E002A8", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebResponse), Member = "GetMustImplement", ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x00005840 File Offset: 0x00003A40
		[global::Cpp2ILInjected.Token(Token = "0x170003A0")]
		public DateTime LastModified
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001047")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E002CC", Offset = "0x1E002CC", Length = "0x120")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoHttpDate), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x00005843 File Offset: 0x00003A43
		[global::Cpp2ILInjected.Token(Token = "0x170003A1")]
		public virtual string Method
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001048")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E004D8", Offset = "0x1E004D8", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x00005846 File Offset: 0x00003A46
		[global::Cpp2ILInjected.Token(Token = "0x170003A2")]
		public Version ProtocolVersion
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001049")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E004F0", Offset = "0x1E004F0", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x00005849 File Offset: 0x00003A49
		[global::Cpp2ILInjected.Token(Token = "0x170003A3")]
		public override Uri ResponseUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x600104A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E00508", Offset = "0x1E00508", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x0000584C File Offset: 0x00003A4C
		[global::Cpp2ILInjected.Token(Token = "0x170003A4")]
		public string Server
		{
			[global::Cpp2ILInjected.Token(Token = "0x600104B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E00520", Offset = "0x1E00520", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x0000584F File Offset: 0x00003A4F
		[global::Cpp2ILInjected.Token(Token = "0x170003A5")]
		public virtual HttpStatusCode StatusCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600104C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E005A0", Offset = "0x1E005A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x00005852 File Offset: 0x00003A52
		[global::Cpp2ILInjected.Token(Token = "0x170003A6")]
		public virtual string StatusDescription
		{
			[global::Cpp2ILInjected.Token(Token = "0x600104D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E005A8", Offset = "0x1E005A8", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x00005855 File Offset: 0x00003A55
		[global::Cpp2ILInjected.Token(Token = "0x170003A7")]
		public override bool SupportsHeaders
		{
			[global::Cpp2ILInjected.Token(Token = "0x600104E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E005C0", Offset = "0x1E005C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00005858 File Offset: 0x00003A58
		[global::Cpp2ILInjected.Token(Token = "0x600104F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E005C8", Offset = "0x1E005C8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string GetResponseHeader(string headerName)
		{
			throw null;
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x0000585B File Offset: 0x00003A5B
		[global::Cpp2ILInjected.Token(Token = "0x6001050")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E00638", Offset = "0x1E00638", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebResponse), Member = "CheckDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override Stream GetResponseStream()
		{
			throw null;
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x0000585E File Offset: 0x00003A5E
		[global::Cpp2ILInjected.Token(Token = "0x6001051")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E006D4", Offset = "0x1E006D4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00005861 File Offset: 0x00003A61
		[global::Cpp2ILInjected.Token(Token = "0x6001052")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E006E0", Offset = "0x1E006E0", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00005864 File Offset: 0x00003A64
		[global::Cpp2ILInjected.Token(Token = "0x6001053")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E008A0", Offset = "0x1E008A0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00005867 File Offset: 0x00003A67
		[global::Cpp2ILInjected.Token(Token = "0x6001054")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E008D0", Offset = "0x1E008D0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.IDisposable.Dispose()
		{
			throw null;
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x0000586A File Offset: 0x00003A6A
		[global::Cpp2ILInjected.Token(Token = "0x6001055")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E008E0", Offset = "0x1E008E0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebResponse), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x0000586D File Offset: 0x00003A6D
		[global::Cpp2ILInjected.Token(Token = "0x6001056")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E000B8", Offset = "0x1E000B8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = "get_ContentEncoding", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = "get_ContentType", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = "get_Cookies", ReturnType = typeof(CookieCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = "set_Cookies", MemberParameters = new object[] { typeof(CookieCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = "get_LastModified", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = "get_Method", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = "get_ProtocolVersion", ReturnType = typeof(Version))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = "get_ResponseUri", ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = "get_Server", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = "get_StatusDescription", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = "GetResponseHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = "GetResponseStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void CheckDisposed()
		{
			throw null;
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00005870 File Offset: 0x00003A70
		[global::Cpp2ILInjected.Token(Token = "0x6001057")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFF9CC", Offset = "0x1DFF9CC", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(WebResponseStream),
			typeof(CookieContainer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(CookieCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "Add", MemberParameters = new object[] { typeof(CookieCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private void FillCookies()
		{
			throw null;
		}

		// Token: 0x040009EA RID: 2538
		[global::Cpp2ILInjected.Token(Token = "0x4000CD4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Uri uri;

		// Token: 0x040009EB RID: 2539
		[global::Cpp2ILInjected.Token(Token = "0x4000CD5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private WebHeaderCollection webHeaders;

		// Token: 0x040009EC RID: 2540
		[global::Cpp2ILInjected.Token(Token = "0x4000CD6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private CookieCollection cookieCollection;

		// Token: 0x040009ED RID: 2541
		[global::Cpp2ILInjected.Token(Token = "0x4000CD7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string method;

		// Token: 0x040009EE RID: 2542
		[global::Cpp2ILInjected.Token(Token = "0x4000CD8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Version version;

		// Token: 0x040009EF RID: 2543
		[global::Cpp2ILInjected.Token(Token = "0x4000CD9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private HttpStatusCode statusCode;

		// Token: 0x040009F0 RID: 2544
		[global::Cpp2ILInjected.Token(Token = "0x4000CDA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string statusDescription;

		// Token: 0x040009F1 RID: 2545
		[global::Cpp2ILInjected.Token(Token = "0x4000CDB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private long contentLength;

		// Token: 0x040009F2 RID: 2546
		[global::Cpp2ILInjected.Token(Token = "0x4000CDC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private string contentType;

		// Token: 0x040009F3 RID: 2547
		[global::Cpp2ILInjected.Token(Token = "0x4000CDD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private CookieContainer cookie_container;

		// Token: 0x040009F4 RID: 2548
		[global::Cpp2ILInjected.Token(Token = "0x4000CDE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private bool disposed;

		// Token: 0x040009F5 RID: 2549
		[global::Cpp2ILInjected.Token(Token = "0x4000CDF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private Stream stream;
	}
}
