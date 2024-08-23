using System;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000199 RID: 409
	[global::Cpp2ILInjected.Token(Token = "0x200024E")]
	public sealed class HttpListenerRequest
	{
		// Token: 0x06000D91 RID: 3473 RVA: 0x000054F2 File Offset: 0x000036F2
		[global::Cpp2ILInjected.Token(Token = "0x6000F15")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4DEC8", Offset = "0x1F4DEC8", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerContext), Member = ".ctor", MemberParameters = new object[] { typeof(HttpConnection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal HttpListenerRequest(HttpListenerContext context)
		{
			throw null;
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x000054F5 File Offset: 0x000036F5
		[global::Cpp2ILInjected.Token(Token = "0x6000F16")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4AF60", Offset = "0x1F4AF60", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "ProcessInput", MemberParameters = new object[] { typeof(MemoryStream) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Version), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		internal void SetRequestLine(string req)
		{
			throw null;
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x000054F8 File Offset: 0x000036F8
		[global::Cpp2ILInjected.Token(Token = "0x6000F17")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4E8F4", Offset = "0x1F4E8F4", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char),
			typeof(StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "UrlDecode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void CreateQueryString(string query)
		{
			throw null;
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x000054FB File Offset: 0x000036FB
		[global::Cpp2ILInjected.Token(Token = "0x6000F18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4EAE8", Offset = "0x1F4EAE8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool MaybeUri(string s)
		{
			throw null;
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x000054FE File Offset: 0x000036FE
		[global::Cpp2ILInjected.Token(Token = "0x6000F19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4EB88", Offset = "0x1F4EB88", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static bool IsPredefinedScheme(string scheme)
		{
			throw null;
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00005501 File Offset: 0x00003701
		[global::Cpp2ILInjected.Token(Token = "0x6000F1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4A4E0", Offset = "0x1F4A4E0", Length = "0x5B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "OnReadInternal", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequest), Member = "get_UserHostName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Version), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(Version),
			typeof(Version)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequest), Member = "MaybeUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_PathAndQuery", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "get_LocalEndPoint", ReturnType = typeof(IPEndPoint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Query", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequest), Member = "CreateQueryString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Authority", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_LocalPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequestUriBuilder), Member = "GetRequestUri", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Version), Member = "op_GreaterThanOrEqual", MemberParameters = new object[]
		{
			typeof(Version),
			typeof(Version)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebUtility), Member = "HtmlEncode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "GetResponseStream", ReturnType = typeof(ResponseStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResponseStream), Member = "InternalWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "SendError", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		internal bool FinishInitialization()
		{
			throw null;
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00005504 File Offset: 0x00003704
		[global::Cpp2ILInjected.Token(Token = "0x6000F1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4EE00", Offset = "0x1F4EE00", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "AddHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		internal static string Unquote(string str)
		{
			throw null;
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00005507 File Offset: 0x00003707
		[global::Cpp2ILInjected.Token(Token = "0x6000F1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4B23C", Offset = "0x1F4B23C", Length = "0x814")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "ProcessInput", MemberParameters = new object[] { typeof(MemoryStream) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "SetInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char),
			typeof(StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequest), Member = "Unquote", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "set_Path", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "set_Domain", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "set_Port", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = "Add", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "set_Name", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cookie), Member = "set_Version", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 51)]
		internal void AddHeader(string header)
		{
			throw null;
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x0000550A File Offset: 0x0000370A
		[global::Cpp2ILInjected.Token(Token = "0x6000F1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4BE6C", Offset = "0x1F4BE6C", Length = "0x298")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequest), Member = "get_InputStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		internal bool FlushInput()
		{
			throw null;
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x0000550D File Offset: 0x0000370D
		[global::Cpp2ILInjected.Token(Token = "0x17000327")]
		public string[] AcceptTypes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F1E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4EF18", Offset = "0x1F4EF18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x00005510 File Offset: 0x00003710
		[global::Cpp2ILInjected.Token(Token = "0x17000328")]
		public int ClientCertificateError
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F1F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4EF20", Offset = "0x1F4EF20", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x00005513 File Offset: 0x00003713
		[global::Cpp2ILInjected.Token(Token = "0x17000329")]
		public Encoding ContentEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F20")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4EFA0", Offset = "0x1F4EFA0", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x00005516 File Offset: 0x00003716
		[global::Cpp2ILInjected.Token(Token = "0x1700032A")]
		public long ContentLength64
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F21")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4EFC0", Offset = "0x1F4EFC0", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x00005519 File Offset: 0x00003719
		[global::Cpp2ILInjected.Token(Token = "0x1700032B")]
		public string ContentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F22")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4EFD8", Offset = "0x1F4EFD8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x0000551C File Offset: 0x0000371C
		[global::Cpp2ILInjected.Token(Token = "0x1700032C")]
		public CookieCollection Cookies
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F23")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F024", Offset = "0x1F4F024", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieCollection), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x0000551F File Offset: 0x0000371F
		[global::Cpp2ILInjected.Token(Token = "0x1700032D")]
		public bool HasEntityBody
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F24")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4EE60", Offset = "0x1F4EE60", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x00005522 File Offset: 0x00003722
		[global::Cpp2ILInjected.Token(Token = "0x1700032E")]
		public NameValueCollection Headers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F25")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F088", Offset = "0x1F4F088", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x00005525 File Offset: 0x00003725
		[global::Cpp2ILInjected.Token(Token = "0x1700032F")]
		public string HttpMethod
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F26")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F090", Offset = "0x1F4F090", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x00005528 File Offset: 0x00003728
		[global::Cpp2ILInjected.Token(Token = "0x17000330")]
		public Stream InputStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F27")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4EE84", Offset = "0x1F4EE84", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "FlushInput", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "GetRequestStream", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(long)
			}, ReturnType = typeof(RequestStream))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x0000552B File Offset: 0x0000372B
		[MonoTODO("Always returns false")]
		[global::Cpp2ILInjected.Token(Token = "0x17000331")]
		public bool IsAuthenticated
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F28")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F098", Offset = "0x1F4F098", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x0000552E File Offset: 0x0000372E
		[global::Cpp2ILInjected.Token(Token = "0x17000332")]
		public bool IsLocal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F29")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F0A0", Offset = "0x1F4F0A0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "get_LocalEndPoint", ReturnType = typeof(IPEndPoint))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "get_RemoteEndPoint", ReturnType = typeof(IPEndPoint))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x00005531 File Offset: 0x00003731
		[global::Cpp2ILInjected.Token(Token = "0x17000333")]
		public bool IsSecureConnection
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F2A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4EDE4", Offset = "0x1F4EDE4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x00005534 File Offset: 0x00003734
		[global::Cpp2ILInjected.Token(Token = "0x17000334")]
		public bool KeepAlive
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F2B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4BD1C", Offset = "0x1F4BD1C", Length = "0x150")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerResponse), Member = "SendHeaders", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(MemoryStream)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Version), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Version),
				typeof(Version)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(StringComparison)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x00005537 File Offset: 0x00003737
		[global::Cpp2ILInjected.Token(Token = "0x17000335")]
		public IPEndPoint LocalEndPoint
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F2C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4EDF4", Offset = "0x1F4EDF4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "get_LocalEndPoint", ReturnType = typeof(IPEndPoint))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x0000553A File Offset: 0x0000373A
		[global::Cpp2ILInjected.Token(Token = "0x17000336")]
		public Version ProtocolVersion
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F2D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F0E8", Offset = "0x1F4F0E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x0000553D File Offset: 0x0000373D
		[global::Cpp2ILInjected.Token(Token = "0x17000337")]
		public NameValueCollection QueryString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F2E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F0F0", Offset = "0x1F4F0F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x00005540 File Offset: 0x00003740
		[global::Cpp2ILInjected.Token(Token = "0x17000338")]
		public string RawUrl
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F2F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F0F8", Offset = "0x1F4F0F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000DAC RID: 3500 RVA: 0x00005543 File Offset: 0x00003743
		[global::Cpp2ILInjected.Token(Token = "0x17000339")]
		public IPEndPoint RemoteEndPoint
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F30")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F0DC", Offset = "0x1F4F0DC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "get_RemoteEndPoint", ReturnType = typeof(IPEndPoint))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x00005546 File Offset: 0x00003746
		[MonoTODO("Always returns Guid.Empty")]
		[global::Cpp2ILInjected.Token(Token = "0x1700033A")]
		public Guid RequestTraceIdentifier
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F31")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F100", Offset = "0x1F4F100", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000DAE RID: 3502 RVA: 0x00005549 File Offset: 0x00003749
		[global::Cpp2ILInjected.Token(Token = "0x1700033B")]
		public Uri Url
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F32")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F148", Offset = "0x1F4F148", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x0000554C File Offset: 0x0000374C
		[global::Cpp2ILInjected.Token(Token = "0x1700033C")]
		public Uri UrlReferrer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F33")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F150", Offset = "0x1F4F150", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x0000554F File Offset: 0x0000374F
		[global::Cpp2ILInjected.Token(Token = "0x1700033D")]
		public string UserAgent
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F34")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F158", Offset = "0x1F4F158", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x00005552 File Offset: 0x00003752
		[global::Cpp2ILInjected.Token(Token = "0x1700033E")]
		public string UserHostAddress
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F35")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4EDC4", Offset = "0x1F4EDC4", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "get_LocalEndPoint", ReturnType = typeof(IPEndPoint))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x00005555 File Offset: 0x00003755
		[global::Cpp2ILInjected.Token(Token = "0x1700033F")]
		public string UserHostName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F36")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4ED78", Offset = "0x1F4ED78", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameValueCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x00005558 File Offset: 0x00003758
		[global::Cpp2ILInjected.Token(Token = "0x17000340")]
		public string[] UserLanguages
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F37")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F1A4", Offset = "0x1F4F1A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0000555B File Offset: 0x0000375B
		[global::Cpp2ILInjected.Token(Token = "0x6000F38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4F1AC", Offset = "0x1F4F1AC", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerRequest.GCCDelegate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public IAsyncResult BeginGetClientCertificate(AsyncCallback requestCallback, object state)
		{
			throw null;
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0000555E File Offset: 0x0000375E
		[global::Cpp2ILInjected.Token(Token = "0x6000F39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4F328", Offset = "0x1F4F328", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public X509Certificate2 EndGetClientCertificate(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00005561 File Offset: 0x00003761
		[global::Cpp2ILInjected.Token(Token = "0x6000F3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4F3BC", Offset = "0x1F4F3BC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public X509Certificate2 GetClientCertificate()
		{
			throw null;
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x00005564 File Offset: 0x00003764
		[MonoTODO]
		[global::Cpp2ILInjected.Token(Token = "0x17000341")]
		public string ServiceName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F3B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F3CC", Offset = "0x1F4F3CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x00005567 File Offset: 0x00003767
		[global::Cpp2ILInjected.Token(Token = "0x17000342")]
		public TransportContext TransportContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F3C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F3D4", Offset = "0x1F4F3D4", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TransportContext), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x0000556A File Offset: 0x0000376A
		[MonoTODO]
		[global::Cpp2ILInjected.Token(Token = "0x17000343")]
		public bool IsWebSocketRequest
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F3D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F430", Offset = "0x1F4F430", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0000556D File Offset: 0x0000376D
		[global::Cpp2ILInjected.Token(Token = "0x6000F3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4F438", Offset = "0x1F4F438", Length = "0x118")]
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
		public Task<X509Certificate2> GetClientCertificateAsync()
		{
			throw null;
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00005570 File Offset: 0x00003770
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000F3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4F550", Offset = "0x1F4F550", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static HttpListenerRequest()
		{
			throw null;
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00005573 File Offset: 0x00003773
		[global::Cpp2ILInjected.Token(Token = "0x6000F40")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4F604", Offset = "0x1F4F604", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal HttpListenerRequest()
		{
			throw null;
		}

		// Token: 0x0400097B RID: 2427
		[global::Cpp2ILInjected.Token(Token = "0x4000C32")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string[] accept_types;

		// Token: 0x0400097C RID: 2428
		[global::Cpp2ILInjected.Token(Token = "0x4000C33")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Encoding content_encoding;

		// Token: 0x0400097D RID: 2429
		[global::Cpp2ILInjected.Token(Token = "0x4000C34")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private long content_length;

		// Token: 0x0400097E RID: 2430
		[global::Cpp2ILInjected.Token(Token = "0x4000C35")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool cl_set;

		// Token: 0x0400097F RID: 2431
		[global::Cpp2ILInjected.Token(Token = "0x4000C36")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private CookieCollection cookies;

		// Token: 0x04000980 RID: 2432
		[global::Cpp2ILInjected.Token(Token = "0x4000C37")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private WebHeaderCollection headers;

		// Token: 0x04000981 RID: 2433
		[global::Cpp2ILInjected.Token(Token = "0x4000C38")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string method;

		// Token: 0x04000982 RID: 2434
		[global::Cpp2ILInjected.Token(Token = "0x4000C39")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Stream input_stream;

		// Token: 0x04000983 RID: 2435
		[global::Cpp2ILInjected.Token(Token = "0x4000C3A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Version version;

		// Token: 0x04000984 RID: 2436
		[global::Cpp2ILInjected.Token(Token = "0x4000C3B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private NameValueCollection query_string;

		// Token: 0x04000985 RID: 2437
		[global::Cpp2ILInjected.Token(Token = "0x4000C3C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private string raw_url;

		// Token: 0x04000986 RID: 2438
		[global::Cpp2ILInjected.Token(Token = "0x4000C3D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private Uri url;

		// Token: 0x04000987 RID: 2439
		[global::Cpp2ILInjected.Token(Token = "0x4000C3E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private Uri referrer;

		// Token: 0x04000988 RID: 2440
		[global::Cpp2ILInjected.Token(Token = "0x4000C3F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private string[] user_languages;

		// Token: 0x04000989 RID: 2441
		[global::Cpp2ILInjected.Token(Token = "0x4000C40")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private HttpListenerContext context;

		// Token: 0x0400098A RID: 2442
		[global::Cpp2ILInjected.Token(Token = "0x4000C41")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private bool is_chunked;

		// Token: 0x0400098B RID: 2443
		[global::Cpp2ILInjected.Token(Token = "0x4000C42")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x89")]
		private bool ka_set;

		// Token: 0x0400098C RID: 2444
		[global::Cpp2ILInjected.Token(Token = "0x4000C43")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8A")]
		private bool keep_alive;

		// Token: 0x0400098D RID: 2445
		[global::Cpp2ILInjected.Token(Token = "0x4000C44")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private HttpListenerRequest.GCCDelegate gcc_delegate;

		// Token: 0x0400098E RID: 2446
		[global::Cpp2ILInjected.Token(Token = "0x4000C45")]
		private static byte[] _100continue;

		// Token: 0x0400098F RID: 2447
		[global::Cpp2ILInjected.Token(Token = "0x4000C46")]
		private static char[] separators;

		// Token: 0x02000419 RID: 1049
		[global::Cpp2ILInjected.Token(Token = "0x200024F")]
		private class Context : TransportContext
		{
			// Token: 0x06001E23 RID: 7715 RVA: 0x000082F4 File Offset: 0x000064F4
			[global::Cpp2ILInjected.Token(Token = "0x6000F41")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F63C", Offset = "0x1F4F63C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override ChannelBinding GetChannelBinding(ChannelBindingKind kind)
			{
				throw null;
			}

			// Token: 0x06001E24 RID: 7716 RVA: 0x000082F7 File Offset: 0x000064F7
			[global::Cpp2ILInjected.Token(Token = "0x6000F42")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4F428", Offset = "0x1F4F428", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TransportContext), Member = ".ctor", ReturnType = typeof(void))]
			public Context()
			{
				throw null;
			}
		}

		// Token: 0x0200041A RID: 1050
		// (Invoke) Token: 0x06001E26 RID: 7718
		[global::Cpp2ILInjected.Token(Token = "0x2000250")]
		private delegate X509Certificate2 GCCDelegate();
	}
}
