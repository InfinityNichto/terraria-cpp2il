using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000039 RID: 57
	[TypeConverter(typeof(UriTypeConverter))]
	[global::Cpp2ILInjected.Token(Token = "0x2000083")]
	[Serializable]
	public class Uri : ISerializable
	{
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000322A File Offset: 0x0000142A
		[global::Cpp2ILInjected.Token(Token = "0x17000065")]
		private bool IsImplicitFile
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0CB0", Offset = "0x1DF0CB0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0000322D File Offset: 0x0000142D
		[global::Cpp2ILInjected.Token(Token = "0x17000066")]
		private bool IsUncOrDosPath
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0CBC", Offset = "0x1DF0CBC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00003230 File Offset: 0x00001430
		[global::Cpp2ILInjected.Token(Token = "0x17000067")]
		private bool IsDosPath
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0CCC", Offset = "0x1DF0CCC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00003233 File Offset: 0x00001433
		[global::Cpp2ILInjected.Token(Token = "0x17000068")]
		private bool IsUncPath
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0CD8", Offset = "0x1DF0CD8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00003236 File Offset: 0x00001436
		[global::Cpp2ILInjected.Token(Token = "0x17000069")]
		private Uri.Flags HostType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0CE4", Offset = "0x1DF0CE4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00003239 File Offset: 0x00001439
		[global::Cpp2ILInjected.Token(Token = "0x1700006A")]
		private UriParser Syntax
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000200")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0CF0", Offset = "0x1DF0CF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000323C File Offset: 0x0000143C
		[global::Cpp2ILInjected.Token(Token = "0x1700006B")]
		private bool IsNotAbsoluteUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000201")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0CF8", Offset = "0x1DF0CF8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000323F File Offset: 0x0000143F
		[global::Cpp2ILInjected.Token(Token = "0x6000202")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0D08", Offset = "0x1DF0D08", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(ushort),
			typeof(ref ParsingError),
			typeof(ref Uri.Flags),
			typeof(UriParser),
			typeof(ref string)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(ref int),
			typeof(char),
			typeof(char),
			typeof(char),
			typeof(UnescapeMode),
			typeof(UriParser),
			typeof(bool)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new object[] { typeof(UriSyntaxFlags) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal unsafe static bool IriParsingStatic(UriParser syntax)
		{
			throw null;
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00003242 File Offset: 0x00001442
		[global::Cpp2ILInjected.Token(Token = "0x1700006C")]
		private bool AllowIdn
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000203")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0D94", Offset = "0x1DF0D94", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_OriginalStringSwitched", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_DnsSafeHost", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimalIri", MemberParameters = new object[]
			{
				typeof(string),
				typeof(ushort)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CreateThisFromUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00003245 File Offset: 0x00001445
		[global::Cpp2ILInjected.Token(Token = "0x6000204")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0E60", Offset = "0x1DF0E60", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(ushort),
			typeof(ref ParsingError),
			typeof(ref Uri.Flags),
			typeof(UriParser),
			typeof(ref string)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleDnsIri", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(UriParser),
			typeof(string),
			typeof(ref Uri.Flags),
			typeof(ref bool),
			typeof(ref string),
			typeof(ref ParsingError)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleAnyHostIri", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(UriParser),
			typeof(ref Uri.Flags),
			typeof(ref string),
			typeof(ref ParsingError)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private unsafe bool AllowIdnStatic(UriParser syntax, Uri.Flags flags)
		{
			throw null;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00003248 File Offset: 0x00001448
		[global::Cpp2ILInjected.Token(Token = "0x6000205")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0F34", Offset = "0x1DF0F34", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool IsIntranet(string schemeHost)
		{
			throw null;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0000324B File Offset: 0x0000144B
		[global::Cpp2ILInjected.Token(Token = "0x1700006D")]
		internal bool UserDrivenParsing
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000206")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0F3C", Offset = "0x1DF0F3C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriParser), Member = "Resolve", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(Uri),
				typeof(ref UriFormatException)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriParser), Member = "GetComponents", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(UriComponents),
				typeof(UriFormat)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000324E File Offset: 0x0000144E
		[global::Cpp2ILInjected.Token(Token = "0x6000207")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0F48", Offset = "0x1DF0F48", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void SetUserDrivenParsing()
		{
			throw null;
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00003251 File Offset: 0x00001451
		[global::Cpp2ILInjected.Token(Token = "0x1700006E")]
		private ushort SecuredPathIndex
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000208")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF0F5C", Offset = "0x1DF0F5C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetEscapedParts", MemberParameters = new object[] { typeof(UriComponents) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetUnescapedParts", MemberParameters = new object[]
			{
				typeof(UriComponents),
				typeof(UriFormat)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetCanonicalPath", MemberParameters = new object[]
			{
				typeof(char[]),
				typeof(ref int),
				typeof(UriFormat)
			}, ReturnType = typeof(char[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string),
				typeof(UriFormat)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00003254 File Offset: 0x00001454
		[global::Cpp2ILInjected.Token(Token = "0x6000209")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0E50", Offset = "0x1DF0E50", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool NotAny(Uri.Flags flags)
		{
			throw null;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00003257 File Offset: 0x00001457
		[global::Cpp2ILInjected.Token(Token = "0x600020A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0FAC", Offset = "0x1DF0FAC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool InFact(Uri.Flags flags)
		{
			throw null;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000325A File Offset: 0x0000145A
		[global::Cpp2ILInjected.Token(Token = "0x600020B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0F28", Offset = "0x1DF0F28", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool StaticNotAny(Uri.Flags allFlags, Uri.Flags checkFlags)
		{
			throw null;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000325D File Offset: 0x0000145D
		[global::Cpp2ILInjected.Token(Token = "0x600020C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0FBC", Offset = "0x1DF0FBC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool StaticInFact(Uri.Flags allFlags, Uri.Flags checkFlags)
		{
			throw null;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00003260 File Offset: 0x00001460
		[global::Cpp2ILInjected.Token(Token = "0x600020D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0FC8", Offset = "0x1DF0FC8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new object[] { typeof(Uri.Flags) }, ReturnType = typeof(void))]
		private Uri.UriInfo EnsureUriInfo()
		{
			throw null;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00003263 File Offset: 0x00001463
		[global::Cpp2ILInjected.Token(Token = "0x600020E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF1538", Offset = "0x1DF1538", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void EnsureParseRemaining()
		{
			throw null;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00003266 File Offset: 0x00001466
		[global::Cpp2ILInjected.Token(Token = "0x600020F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF2080", Offset = "0x1DF2080", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_HostNameType", ReturnType = typeof(UriHostNameType))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_IsLoopback", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_DnsSafeHost", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(ushort),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new object[] { typeof(Uri.Flags) }, ReturnType = typeof(void))]
		private void EnsureHostString(bool allowDnsOptimization)
		{
			throw null;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00003269 File Offset: 0x00001469
		[global::Cpp2ILInjected.Token(Token = "0x6000210")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF24D4", Offset = "0x1DF24D4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriBuilder), Member = "get_Uri", ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "set_BaseAddress", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(WebRequest))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "CreateHttp", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HttpWebRequest))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServiceNameStore), Member = "ExtractHostname", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxyDataBuilder), Member = "ParseProxyUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "CreateProxyUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "ProxyUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "AddHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointManager), Member = "FindServicePoint", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IWebProxy)
		}, ReturnType = typeof(ServicePoint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointManager), Member = "FindServicePoint", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(IWebProxy)
		}, ReturnType = typeof(ServicePoint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeLicenseContext), Member = "GetLocalPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlResolver), Member = "ResolveUri", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.UriConverter", Member = "ReadJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			typeof(Type),
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Uri(string uriString)
		{
			throw null;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000326C File Offset: 0x0000146C
		[global::Cpp2ILInjected.Token(Token = "0x6000211")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF26F0", Offset = "0x1DF26F0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriTypeConverter), Member = "ConvertFrom", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlResolver), Member = "ResolveUri", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(CultureInfo),
			typeof(Type),
			typeof(ref object)
		}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateThis", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(UriKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Uri(string uriString, UriKind uriKind)
		{
			throw null;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000326F File Offset: 0x0000146F
		[global::Cpp2ILInjected.Token(Token = "0x6000212")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF2774", Offset = "0x1DF2774", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new object[]
		{
			typeof(HttpStatusCode),
			typeof(WebResponse)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlResolver), Member = "ResolveUri", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateUri", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public Uri(Uri baseUri, string relativeUri)
		{
			throw null;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00003272 File Offset: 0x00001472
		[global::Cpp2ILInjected.Token(Token = "0x6000213")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF2844", Offset = "0x1DF2844", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateThis", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(UriKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri),
			typeof(ref string),
			typeof(ref bool),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateThisFromUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InternalResolve", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape)
		{
			throw null;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00003275 File Offset: 0x00001475
		[global::Cpp2ILInjected.Token(Token = "0x6000214")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF2F88", Offset = "0x1DF2F88", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "MapToDefaultMethod", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateThisFromUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri),
			typeof(ref string),
			typeof(ref bool),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InternalResolve", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateThis", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(UriKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public Uri(Uri baseUri, Uri relativeUri)
		{
			throw null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00003278 File Offset: 0x00001478
		[global::Cpp2ILInjected.Token(Token = "0x6000215")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF3198", Offset = "0x1DF3198", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri),
			typeof(ref string),
			typeof(ref bool),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CheckSchemeSyntax", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(ref UriParser)
		}, ReturnType = typeof(ParsingError))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_OriginalStringSwitched", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private unsafe static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result)
		{
			throw null;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000327B File Offset: 0x0000147B
		[global::Cpp2ILInjected.Token(Token = "0x6000216")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF3EC0", Offset = "0x1DF3EC0", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ParseMinimal", ReturnType = typeof(UriFormatException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CreateHostStringHelper", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ushort),
			typeof(ushort),
			typeof(ref Uri.Flags),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetHostViaCustomSyntax", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new object[]
		{
			typeof(ParsingError),
			typeof(UriKind),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriFormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private static UriFormatException GetException(ParsingError err)
		{
			throw null;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000327E File Offset: 0x0000147E
		[global::Cpp2ILInjected.Token(Token = "0x6000217")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF405C", Offset = "0x1DF405C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateThis", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(UriKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected Uri(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00003281 File Offset: 0x00001481
		[global::Cpp2ILInjected.Token(Token = "0x6000218")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF4158", Offset = "0x1DF4158", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00003284 File Offset: 0x00001484
		[global::Cpp2ILInjected.Token(Token = "0x6000219")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF415C", Offset = "0x1DF415C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00003287 File Offset: 0x00001487
		[global::Cpp2ILInjected.Token(Token = "0x1700006F")]
		public string AbsolutePath
		{
			[global::Cpp2ILInjected.Token(Token = "0x600021A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF4210", Offset = "0x1DF4210", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "TryUpdateResponseUri", MemberParameters = new object[]
			{
				typeof(string),
				typeof(FtpWebRequest)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CredentialKey), Member = "IsPrefix", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(Uri)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = "VerifySetDefaults", MemberParameters = new object[]
			{
				typeof(CookieVariant),
				typeof(Uri),
				typeof(bool),
				typeof(string),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "BuildCookieCollectionFromDomainMatches", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(bool),
				typeof(int),
				typeof(CookieCollection),
				typeof(List<string>),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = "SearchListener", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(ref ListenerPrefix)
			}, ReturnType = typeof(HttpListener))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_PrivateAbsolutePath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000328A File Offset: 0x0000148A
		[global::Cpp2ILInjected.Token(Token = "0x17000070")]
		private string PrivateAbsolutePath
		{
			[global::Cpp2ILInjected.Token(Token = "0x600021B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF42C8", Offset = "0x1DF42C8", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_AbsolutePath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_Segments", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new object[] { typeof(Uri.Flags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri.MoreInfo), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
			{
				typeof(UriComponents),
				typeof(UriFormat)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000196 RID: 406 RVA: 0x0000328D File Offset: 0x0000148D
		[global::Cpp2ILInjected.Token(Token = "0x17000071")]
		public string AbsoluteUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x600021C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF4360", Offset = "0x1DF4360", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "Create", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(bool)
			}, ReturnType = typeof(WebRequest))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "RegisterPrefix", MemberParameters = new object[]
			{
				typeof(string),
				typeof(IWebRequestCreate)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string),
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(CookieCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new object[] { typeof(Uri.Flags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri.MoreInfo), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
			{
				typeof(UriComponents),
				typeof(UriFormat)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00003290 File Offset: 0x00001490
		[global::Cpp2ILInjected.Token(Token = "0x17000072")]
		public string LocalPath
		{
			[global::Cpp2ILInjected.Token(Token = "0x600021D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF444C", Offset = "0x1DF444C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "GetRequestStreamCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebResponse), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(FileWebRequest),
				typeof(Uri),
				typeof(FileAccess),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeLicenseContext), Member = "GetLocalPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlDownloadManager.<>c__DisplayClass4_0", Member = "<GetStreamAsync>b__0", ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlDownloadManager", Member = "GetStream", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(ICredentials),
				typeof(IWebProxy),
				typeof(RequestCachePolicy)
			}, ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00003293 File Offset: 0x00001493
		[global::Cpp2ILInjected.Token(Token = "0x17000073")]
		public string Authority
		{
			[global::Cpp2ILInjected.Token(Token = "0x600021E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF4A30", Offset = "0x1DF4A30", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new object[]
			{
				typeof(HttpStatusCode),
				typeof(WebResponse)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePointManager), Member = "FindServicePoint", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(IWebProxy)
			}, ReturnType = typeof(ServicePoint))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionTunnel.<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
			{
				typeof(UriComponents),
				typeof(UriFormat)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00003296 File Offset: 0x00001496
		[global::Cpp2ILInjected.Token(Token = "0x17000074")]
		public UriHostNameType HostNameType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600021F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF4AA4", Offset = "0x1DF4AA4", Length = "0xF8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServicePoint), Member = "get_HostEntry", ReturnType = typeof(IPHostEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new object[] { typeof(Uri.Flags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "EnsureHostString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00003299 File Offset: 0x00001499
		[global::Cpp2ILInjected.Token(Token = "0x17000075")]
		public bool IsDefaultPort
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000220")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF4B9C", Offset = "0x1DF4B9C", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "IsMatchInBypassList", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "get_Host", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "set_Host", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetHeaders", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new object[] { typeof(Uri.Flags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "EnsureHostString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0000329C File Offset: 0x0000149C
		[global::Cpp2ILInjected.Token(Token = "0x17000076")]
		public bool IsFile
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000221")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF4C44", Offset = "0x1DF4C44", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0000329F File Offset: 0x0000149F
		[global::Cpp2ILInjected.Token(Token = "0x17000077")]
		public bool IsLoopback
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000222")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF4D04", Offset = "0x1DF4D04", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "EnsureHostString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600019D RID: 413 RVA: 0x000032A2 File Offset: 0x000014A2
		[global::Cpp2ILInjected.Token(Token = "0x17000078")]
		public string PathAndQuery
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000223")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF4D84", Offset = "0x1DF4D84", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestSession), Member = "HA2", MemberParameters = new object[] { typeof(HttpWebRequest) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestSession), Member = "Authenticate", MemberParameters = new object[]
			{
				typeof(WebRequest),
				typeof(ICredentials)
			}, ReturnType = typeof(Authorization))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "TryGetHostUri", MemberParameters = new object[]
			{
				typeof(string),
				typeof(ref Uri)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetRequestHeaders", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
			{
				typeof(UriComponents),
				typeof(UriFormat)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600019E RID: 414 RVA: 0x000032A5 File Offset: 0x000014A5
		[global::Cpp2ILInjected.Token(Token = "0x17000079")]
		public string[] Segments
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000224")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF4E44", Offset = "0x1DF4E44", Length = "0x1FC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "TryUpdateResponseUri", MemberParameters = new object[]
			{
				typeof(string),
				typeof(FtpWebRequest)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_PrivateAbsolutePath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600019F RID: 415 RVA: 0x000032A8 File Offset: 0x000014A8
		[global::Cpp2ILInjected.Token(Token = "0x1700007A")]
		public bool IsUnc
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000225")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF5040", Offset = "0x1DF5040", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string),
				typeof(UriFormat)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x000032AB File Offset: 0x000014AB
		[global::Cpp2ILInjected.Token(Token = "0x1700007B")]
		public string Host
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000226")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF50B4", Offset = "0x1DF50B4", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
			{
				typeof(UriComponents),
				typeof(UriFormat)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000032AE File Offset: 0x000014AE
		[global::Cpp2ILInjected.Token(Token = "0x6000227")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF5128", Offset = "0x1DF5128", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new object[] { typeof(UriSyntaxFlags) }, ReturnType = typeof(bool))]
		private static bool StaticIsFile(UriParser syntax)
		{
			throw null;
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x000032B1 File Offset: 0x000014B1
		[global::Cpp2ILInjected.Token(Token = "0x1700007C")]
		private static object InitializeLock
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000228")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF5134", Offset = "0x1DF5134", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "InitializeUriConfig", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref object),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000032B4 File Offset: 0x000014B4
		[global::Cpp2ILInjected.Token(Token = "0x6000229")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF5200", Offset = "0x1DF5200", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(ushort),
			typeof(ref ParsingError),
			typeof(ref Uri.Flags),
			typeof(UriParser),
			typeof(ref string)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new object[]
		{
			typeof(ParsingError),
			typeof(UriKind),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_InitializeLock", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private unsafe static void InitializeUriConfig()
		{
			throw null;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000032B7 File Offset: 0x000014B7
		[global::Cpp2ILInjected.Token(Token = "0x600022A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF44B8", Offset = "0x1DF44B8", Length = "0x578")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_IsFile", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_OriginalStringSwitched", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_IsLoopback", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "EnsureHostString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetUnescapedParts", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(ref int),
			typeof(char),
			typeof(char),
			typeof(char),
			typeof(UnescapeMode),
			typeof(UriParser),
			typeof(bool)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "Compress", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(ushort),
			typeof(ref int),
			typeof(UriParser)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Remove", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private string GetLocalPath()
		{
			throw null;
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x000032BA File Offset: 0x000014BA
		[global::Cpp2ILInjected.Token(Token = "0x1700007D")]
		public int Port
		{
			[global::Cpp2ILInjected.Token(Token = "0x600022B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF58BC", Offset = "0x1DF58BC", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebRequest.<CreateConnectionAsync>d__86", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = "CreateConnection", ReturnType = typeof(FtpControlStream))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CredentialKey), Member = "IsPrefix", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(Uri)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Cookie), Member = "VerifySetDefaults", MemberParameters = new object[]
			{
				typeof(CookieVariant),
				typeof(Uri),
				typeof(bool),
				typeof(string),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "InternalGetCookies", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(CookieCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxy), Member = "IsMatchInBypassList", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EndPointListener), Member = "SearchListener", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(ref ListenerPrefix)
			}, ReturnType = typeof(HttpListener))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "get_Host", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnectionTunnel.<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new object[] { typeof(Uri.Flags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "EnsureHostString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x000032BD File Offset: 0x000014BD
		[global::Cpp2ILInjected.Token(Token = "0x1700007E")]
		public string Query
		{
			[global::Cpp2ILInjected.Token(Token = "0x600022C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF5974", Offset = "0x1DF5974", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new object[] { typeof(Uri.Flags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri.MoreInfo), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
			{
				typeof(UriComponents),
				typeof(UriFormat)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x000032C0 File Offset: 0x000014C0
		[global::Cpp2ILInjected.Token(Token = "0x1700007F")]
		public string Fragment
		{
			[global::Cpp2ILInjected.Token(Token = "0x600022D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF5A64", Offset = "0x1DF5A64", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeLicenseContext), Member = "GetLocalPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new object[] { typeof(Uri.Flags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri.MoreInfo), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
			{
				typeof(UriComponents),
				typeof(UriFormat)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000032C3 File Offset: 0x000014C3
		[global::Cpp2ILInjected.Token(Token = "0x17000080")]
		public string Scheme
		{
			[global::Cpp2ILInjected.Token(Token = "0x600022E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF5B54", Offset = "0x1DF5B54", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 37)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x000032C6 File Offset: 0x000014C6
		[global::Cpp2ILInjected.Token(Token = "0x17000081")]
		private bool OriginalStringSwitched
		{
			[global::Cpp2ILInjected.Token(Token = "0x600022F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF5BC4", Offset = "0x1DF5BC4", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetCombinedString", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string),
				typeof(bool),
				typeof(ref string)
			}, ReturnType = typeof(ParsingError))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetHashCode", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string),
				typeof(UriFormat)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(Uri),
				typeof(ref string),
				typeof(ref bool),
				typeof(ref UriFormatException)
			}, ReturnType = typeof(Uri))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CreateThisFromUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001AA RID: 426 RVA: 0x000032C9 File Offset: 0x000014C9
		[global::Cpp2ILInjected.Token(Token = "0x17000082")]
		public string OriginalString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000230")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF3508", Offset = "0x1DF3508", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriParser), Member = "Resolve", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(Uri),
				typeof(ref UriFormatException)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlResolver), Member = "ResolveUri", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string)
			}, ReturnType = typeof(Uri))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.Datatype_anyURI", Member = "TryParseValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(XmlNameTable),
				typeof(IXmlNamespaceResolver),
				typeof(ref object)
			}, ReturnType = typeof(Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.StringFacetsChecker", Member = "MatchEnumeration", MemberParameters = new object[]
			{
				typeof(string),
				typeof(ArrayList),
				typeof(XmlSchemaDatatype)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "AnyUriToString", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValue", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadAsString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(char)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JTokenReader", Member = "SetToken", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.BooleanQueryExpression", Member = "EqualsWithStringCoercion", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JValue", "Newtonsoft.Json.Linq.JValue" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.UriConverter", Member = "WriteJson", MemberParameters = new object[]
			{
				"Newtonsoft.Json.JsonWriter",
				typeof(object),
				"Newtonsoft.Json.JsonSerializer"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_OriginalStringSwitched", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001AB RID: 427 RVA: 0x000032CC File Offset: 0x000014CC
		[global::Cpp2ILInjected.Token(Token = "0x17000083")]
		public string DnsSafeHost
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000231")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF5C0C", Offset = "0x1DF5C0C", Length = "0x230")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string),
				typeof(UriFormat)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new object[] { typeof(Uri.Flags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "EnsureHostString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(int),
				typeof(char[]),
				typeof(ref int),
				typeof(char),
				typeof(char),
				typeof(char),
				typeof(UnescapeMode),
				typeof(UriParser),
				typeof(bool)
			}, ReturnType = typeof(char[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
			{
				typeof(char[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001AC RID: 428 RVA: 0x000032CF File Offset: 0x000014CF
		[global::Cpp2ILInjected.Token(Token = "0x17000084")]
		public bool IsAbsoluteUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000232")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF2834", Offset = "0x1DF2834", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriParser), Member = "Resolve", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(Uri),
				typeof(ref UriFormatException)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriParser), Member = "GetComponents", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(UriComponents),
				typeof(UriFormat)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "MapToDefaultMethod", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlResolver), Member = "ResolveUri", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(string)
			}, ReturnType = typeof(Uri))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001AD RID: 429 RVA: 0x000032D2 File Offset: 0x000014D2
		[global::Cpp2ILInjected.Token(Token = "0x17000085")]
		public bool UserEscaped
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000233")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF5E3C", Offset = "0x1DF5E3C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001AE RID: 430 RVA: 0x000032D5 File Offset: 0x000014D5
		[global::Cpp2ILInjected.Token(Token = "0x17000086")]
		public string UserInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000234")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DF5E48", Offset = "0x1DF5E48", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
			{
				typeof(UriComponents),
				typeof(UriFormat)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000032D8 File Offset: 0x000014D8
		[global::Cpp2ILInjected.Token(Token = "0x6000235")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF5EBC", Offset = "0x1DF5EBC", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServiceNameCollection), Member = "NormalizeServiceName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv6AddressHelper), Member = "IsValid", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv4AddressHelper), Member = "IsValid", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(ref int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DomainNameHelper), Member = "IsValid", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(ref int),
			typeof(ref bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DomainNameHelper), Member = "IsValidByIri", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(ref int),
			typeof(ref bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public unsafe static UriHostNameType CheckHostName(string name)
		{
			throw null;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000032DB File Offset: 0x000014DB
		[global::Cpp2ILInjected.Token(Token = "0x6000236")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF60D8", Offset = "0x1DF60D8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IriHelper), Member = "CheckIsReserved", MemberParameters = new object[]
		{
			typeof(char),
			typeof(UriComponents)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static bool IsGenDelim(char ch)
		{
			throw null;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000032DE File Offset: 0x000014DE
		[global::Cpp2ILInjected.Token(Token = "0x6000237")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF6124", Offset = "0x1DF6124", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPv6AddressHelper), Member = "IsValidStrict", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPv6AddressHelper), Member = "InternalIsValid", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public unsafe static bool IsHexDigit(char character)
		{
			throw null;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000032E1 File Offset: 0x000014E1
		[global::Cpp2ILInjected.Token(Token = "0x6000238")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF6160", Offset = "0x1DF6160", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPv6AddressHelper), Member = "Parse", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<char>),
			typeof(ushort*),
			typeof(int),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public unsafe static int FromHex(char digit)
		{
			throw null;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000032E4 File Offset: 0x000014E4
		[global::Cpp2ILInjected.Token(Token = "0x6000239")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF620C", Offset = "0x1DF620C", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new object[] { typeof(Uri.Flags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri.MoreInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CalculateCaseInsensitiveHashCode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_OriginalStringSwitched", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000032E7 File Offset: 0x000014E7
		[global::Cpp2ILInjected.Token(Token = "0x600023A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF63CC", Offset = "0x1DF63CC", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new object[] { typeof(Uri.Flags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_OriginalStringSwitched", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000032EA File Offset: 0x000014EA
		[global::Cpp2ILInjected.Token(Token = "0x600023B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF6680", Offset = "0x1DF6680", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 37)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool operator ==(Uri uri1, Uri uri2)
		{
			throw null;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000032ED File Offset: 0x000014ED
		[global::Cpp2ILInjected.Token(Token = "0x600023C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF2E40", Offset = "0x1DF2E40", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		public static bool operator !=(Uri uri1, Uri uri2)
		{
			throw null;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000032F0 File Offset: 0x000014F0
		[global::Cpp2ILInjected.Token(Token = "0x600023D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF66B4", Offset = "0x1DF66B4", Length = "0x50C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_OriginalStringSwitched", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new object[] { typeof(Uri.Flags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "EnsureHostString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri.MoreInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override bool Equals(object comparand)
		{
			throw null;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000032F3 File Offset: 0x000014F3
		[global::Cpp2ILInjected.Token(Token = "0x600023E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF6C78", Offset = "0x1DF6C78", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOfAny", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool CheckForColonInFirstPathSegment(string uriString)
		{
			throw null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000032F6 File Offset: 0x000014F6
		[global::Cpp2ILInjected.Token(Token = "0x600023F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF6D28", Offset = "0x1DF6D28", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriBuilder), Member = "set_Path", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(ref int),
			typeof(bool),
			typeof(char),
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static string InternalEscapeString(string rawString)
		{
			throw null;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000032F9 File Offset: 0x000014F9
		[global::Cpp2ILInjected.Token(Token = "0x6000240")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF6E08", Offset = "0x1DF6E08", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CreateThis", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(UriKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CreateHelper", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(UriKind),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "ParseSchemeCheckImplicitFile", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(ref ParsingError),
			typeof(ref Uri.Flags),
			typeof(ref UriParser)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static ParsingError ParseScheme(string uriString, ref Uri.Flags flags, ref UriParser syntax)
		{
			throw null;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000032FC File Offset: 0x000014FC
		[global::Cpp2ILInjected.Token(Token = "0x6000241")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF7428", Offset = "0x1DF7428", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriParser), Member = "InitializeAndValidate", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetException", MemberParameters = new object[] { typeof(ParsingError) }, ReturnType = typeof(UriFormatException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal UriFormatException ParseMinimal()
		{
			throw null;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000032FF File Offset: 0x000014FF
		[global::Cpp2ILInjected.Token(Token = "0x6000242")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF74A8", Offset = "0x1DF74A8", Length = "0x630")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ParseMinimal", ReturnType = typeof(UriFormatException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new object[]
		{
			typeof(ParsingError),
			typeof(UriKind),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "IsAllSet", MemberParameters = new object[] { typeof(UriSyntaxFlags) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new object[] { typeof(UriSyntaxFlags) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(ushort),
			typeof(ref ParsingError),
			typeof(ref Uri.Flags),
			typeof(UriParser),
			typeof(ref string)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "NotAny", MemberParameters = new object[] { typeof(UriSyntaxFlags) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "PrivateParseMinimalIri", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private unsafe ParsingError PrivateParseMinimal()
		{
			throw null;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00003302 File Offset: 0x00001502
		[global::Cpp2ILInjected.Token(Token = "0x6000243")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF8940", Offset = "0x1DF8940", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		private void PrivateParseMinimalIri(string newHost, ushort idx)
		{
			throw null;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00003305 File Offset: 0x00001505
		[global::Cpp2ILInjected.Token(Token = "0x6000244")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF0FEC", Offset = "0x1DF0FEC", Length = "0x54C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "EnsureUriInfo", ReturnType = typeof(Uri.UriInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "EnsureHostString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_PrivateAbsolutePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_AbsoluteUri", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_HostNameType", ReturnType = typeof(UriHostNameType))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_Query", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_Fragment", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_DnsSafeHost", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri.UriInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void CreateUriInfo(Uri.Flags cF)
		{
			throw null;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00003308 File Offset: 0x00001508
		[global::Cpp2ILInjected.Token(Token = "0x6000245")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF20D8", Offset = "0x1DF20D8", Length = "0x3FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetHostViaCustomSyntax", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateHostStringHelper", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ushort),
			typeof(ushort),
			typeof(ref Uri.Flags),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CheckCanonical", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ref ushort),
			typeof(ushort),
			typeof(char)
		}, ReturnType = typeof(Uri.Check))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(ref int),
			typeof(bool),
			typeof(char),
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private unsafe void CreateHostString()
		{
			throw null;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000330B File Offset: 0x0000150B
		[global::Cpp2ILInjected.Token(Token = "0x6000246")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF8DCC", Offset = "0x1DF8DCC", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetHostViaCustomSyntax", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DomainNameHelper), Member = "ParseCanonicalName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv4AddressHelper), Member = "ParseCanonicalName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv6AddressHelper), Member = "ParseCanonicalName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref bool),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UncNameHelper), Member = "ParseCanonicalName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetException", MemberParameters = new object[] { typeof(ParsingError) }, ReturnType = typeof(UriFormatException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Uri.Flags flags, ref string scopeId)
		{
			throw null;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000330E File Offset: 0x0000150E
		[global::Cpp2ILInjected.Token(Token = "0x6000247")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF8A08", Offset = "0x1DF8A08", Length = "0x3C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InternalGetComponents", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(ushort),
			typeof(ref ParsingError),
			typeof(ref Uri.Flags),
			typeof(UriParser),
			typeof(ref string)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateHostStringHelper", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ushort),
			typeof(ushort),
			typeof(ref Uri.Flags),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriFormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetException", MemberParameters = new object[] { typeof(ParsingError) }, ReturnType = typeof(UriFormatException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private unsafe void GetHostViaCustomSyntax()
		{
			throw null;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00003311 File Offset: 0x00001511
		[global::Cpp2ILInjected.Token(Token = "0x6000248")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF420C", Offset = "0x1DF420C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		internal string GetParts(UriComponents uriParts, UriFormat formatAs)
		{
			throw null;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00003314 File Offset: 0x00001514
		[global::Cpp2ILInjected.Token(Token = "0x6000249")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF955C", Offset = "0x1DF955C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_SecuredPathIndex", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(ushort),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetUriPartsFromUserString", MemberParameters = new object[] { typeof(UriComponents) }, ReturnType = typeof(string))]
		private string GetEscapedParts(UriComponents uriParts)
		{
			throw null;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00003317 File Offset: 0x00001517
		[global::Cpp2ILInjected.Token(Token = "0x600024A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF57F8", Offset = "0x1DF57F8", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_SecuredPathIndex", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(ushort),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetUriPartsFromUserString", MemberParameters = new object[] { typeof(UriComponents) }, ReturnType = typeof(string))]
		private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs)
		{
			throw null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000331A File Offset: 0x0000151A
		[global::Cpp2ILInjected.Token(Token = "0x600024B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF9AD4", Offset = "0x1DF9AD4", Length = "0xB40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetEscapedParts", MemberParameters = new object[] { typeof(UriComponents) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetUnescapedParts", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "EnsureHostString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(ref int),
			typeof(char),
			typeof(char),
			typeof(char),
			typeof(UnescapeMode),
			typeof(UriParser),
			typeof(bool)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(ref int),
			typeof(bool),
			typeof(char),
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DomainNameHelper), Member = "UnicodeEquivalent", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetCanonicalPath", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(ref int),
			typeof(UriFormat)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "get_ShouldUseLegacyV2Quirks", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private unsafe string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs)
		{
			throw null;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000331D File Offset: 0x0000151D
		[global::Cpp2ILInjected.Token(Token = "0x600024C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF9618", Offset = "0x1DF9618", Length = "0x4BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetEscapedParts", MemberParameters = new object[] { typeof(UriComponents) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetUnescapedParts", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private string GetUriPartsFromUserString(UriComponents uriParts)
		{
			throw null;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00003320 File Offset: 0x00001520
		[global::Cpp2ILInjected.Token(Token = "0x600024D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF1548", Offset = "0x1DF1548", Length = "0xB38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new object[]
		{
			typeof(ParsingError),
			typeof(UriKind),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new object[] { typeof(Uri.Flags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CheckCanonical", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ref ushort),
			typeof(ushort),
			typeof(char)
		}, ReturnType = typeof(Uri.Check))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new object[] { typeof(UriSyntaxFlags) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "FindEndOfComponent", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref ushort),
			typeof(ushort),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "EscapeUnescapeIri", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(UriComponents)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "get_ShouldUseLegacyV2Quirks", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Normalize", MemberParameters = new object[] { typeof(NormalizationForm) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetException", MemberParameters = new object[] { typeof(ParsingError) }, ReturnType = typeof(UriFormatException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		private unsafe void ParseRemaining()
		{
			throw null;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00003323 File Offset: 0x00001523
		[global::Cpp2ILInjected.Token(Token = "0x600024E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF6EE0", Offset = "0x1DF6EE0", Length = "0x548")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ParseScheme", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref Uri.Flags),
			typeof(ref UriParser)
		}, ReturnType = typeof(ParsingError))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "get_Size", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CheckKnownSchemes", MemberParameters = new object[]
		{
			typeof(long*),
			typeof(ushort),
			typeof(ref UriParser)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CheckSchemeSyntax", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(ref UriParser)
		}, ReturnType = typeof(ParsingError))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private unsafe static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Uri.Flags flags, ref UriParser syntax)
		{
			throw null;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00003326 File Offset: 0x00001526
		[global::Cpp2ILInjected.Token(Token = "0x600024F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFACAC", Offset = "0x1DFACAC", Length = "0x500")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ParseSchemeCheckImplicitFile", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(ref ParsingError),
			typeof(ref Uri.Flags),
			typeof(ref UriParser)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private unsafe static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax)
		{
			throw null;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00003329 File Offset: 0x00001529
		[global::Cpp2ILInjected.Token(Token = "0x6000250")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF33D4", Offset = "0x1DF33D4", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetCombinedString", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(bool),
			typeof(ref string)
		}, ReturnType = typeof(ParsingError))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ParseSchemeCheckImplicitFile", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(ref ParsingError),
			typeof(ref Uri.Flags),
			typeof(ref UriParser)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "FindOrFetchAsUnknownV1Syntax", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(UriParser))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax)
		{
			throw null;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000332C File Offset: 0x0000152C
		[global::Cpp2ILInjected.Token(Token = "0x6000251")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF7B44", Offset = "0x1DF7B44", Length = "0xDFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetHostViaCustomSyntax", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "IriParsingStatic", MemberParameters = new object[] { typeof(UriParser) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new object[] { typeof(UriSyntaxFlags) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv6AddressHelper), Member = "IsValid", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "InitializeUriConfig", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPv4AddressHelper), Member = "IsValid", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(ref int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DomainNameHelper), Member = "IsValid", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(ref int),
			typeof(ref bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "AllowIdnStatic", MemberParameters = new object[]
		{
			typeof(UriParser),
			typeof(Uri.Flags)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DomainNameHelper), Member = "UnicodeEquivalent", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DomainNameHelper), Member = "IsValidByIri", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(ref int),
			typeof(ref bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleDnsIri", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(UriParser),
			typeof(string),
			typeof(ref Uri.Flags),
			typeof(ref bool),
			typeof(ref string),
			typeof(ref ParsingError)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UncNameHelper), Member = "IsValid", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IriHelper), Member = "EscapeUnescapeIri", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int),
			typeof(UriComponents)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "get_ShouldUseLegacyV2Quirks", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Normalize", MemberParameters = new object[] { typeof(NormalizationForm) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleAnyHostIri", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(UriParser),
			typeof(ref Uri.Flags),
			typeof(ref string),
			typeof(ref ParsingError)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "NotAny", MemberParameters = new object[] { typeof(UriSyntaxFlags) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 44)]
		private unsafe ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Uri.Flags flags, UriParser syntax, ref string newHost)
		{
			throw null;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000332F File Offset: 0x0000152F
		[global::Cpp2ILInjected.Token(Token = "0x6000252")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFB1AC", Offset = "0x1DFB1AC", Length = "0x348")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(ushort),
			typeof(ref ParsingError),
			typeof(ref Uri.Flags),
			typeof(UriParser),
			typeof(ref string)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "AllowIdnStatic", MemberParameters = new object[]
		{
			typeof(UriParser),
			typeof(Uri.Flags)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DomainNameHelper), Member = "IdnEquivalent", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DomainNameHelper), Member = "UnicodeEquivalent", MemberParameters = new object[]
		{
			typeof(string),
			typeof(char*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "StripBidiControlCharacter", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Normalize", MemberParameters = new object[] { typeof(NormalizationForm) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private unsafe void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Uri.Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err)
		{
			throw null;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00003332 File Offset: 0x00001532
		[global::Cpp2ILInjected.Token(Token = "0x6000253")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFB4F4", Offset = "0x1DFB4F4", Length = "0x2B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelper", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(ushort),
			typeof(ref ParsingError),
			typeof(ref Uri.Flags),
			typeof(UriParser),
			typeof(ref string)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "AllowIdnStatic", MemberParameters = new object[]
		{
			typeof(UriParser),
			typeof(Uri.Flags)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DomainNameHelper), Member = "UnicodeEquivalent", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Normalize", MemberParameters = new object[] { typeof(NormalizationForm) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DomainNameHelper), Member = "IdnEquivalent", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private unsafe void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Uri.Flags flags, ref string newHost, ref ParsingError err)
		{
			throw null;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00003335 File Offset: 0x00001535
		[global::Cpp2ILInjected.Token(Token = "0x6000254")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFAC08", Offset = "0x1DFAC08", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "FindEndOfComponent", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ref ushort),
			typeof(ushort),
			typeof(char)
		}, ReturnType = typeof(void))]
		private unsafe void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim)
		{
			throw null;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00003338 File Offset: 0x00001538
		[global::Cpp2ILInjected.Token(Token = "0x6000255")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFB904", Offset = "0x1DFB904", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "FindEndOfComponent", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref ushort),
			typeof(ushort),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new object[] { typeof(UriSyntaxFlags) }, ReturnType = typeof(bool))]
		private unsafe void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim)
		{
			throw null;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000333B File Offset: 0x0000153B
		[global::Cpp2ILInjected.Token(Token = "0x6000256")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF8FA0", Offset = "0x1DF8FA0", Length = "0x3F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IriHelper), Member = "CheckIriUnicodeRange", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char),
			typeof(ref bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new object[] { typeof(UriSyntaxFlags) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IriHelper), Member = "CheckIriUnicodeRange", MemberParameters = new object[]
		{
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriHelper), Member = "EscapedAscii", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private unsafe Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim)
		{
			throw null;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000333E File Offset: 0x0000153E
		[global::Cpp2ILInjected.Token(Token = "0x6000257")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFA614", Offset = "0x1DFA614", Length = "0x5F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(ushort),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_SecuredPathIndex", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Remove", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(ref int),
			typeof(bool),
			typeof(char),
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new object[] { typeof(UriSyntaxFlags) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "UnescapeOnly", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(ref int),
			typeof(char),
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "Compress", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(ushort),
			typeof(ref int),
			typeof(UriParser)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(ref int),
			typeof(char),
			typeof(char),
			typeof(char),
			typeof(UnescapeMode),
			typeof(UriParser),
			typeof(bool)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private unsafe char[] GetCanonicalPath(char[] dest, ref int pos, UriFormat formatAs)
		{
			throw null;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00003341 File Offset: 0x00001541
		[global::Cpp2ILInjected.Token(Token = "0x6000258")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFB998", Offset = "0x1DFB998", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetCanonicalPath", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(ref int),
			typeof(UriFormat)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriHelper), Member = "EscapedAscii", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private unsafe static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3)
		{
			throw null;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00003344 File Offset: 0x00001544
		[global::Cpp2ILInjected.Token(Token = "0x6000259")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF53A0", Offset = "0x1DF53A0", Length = "0x458")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetLocalPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetCanonicalPath", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(ref int),
			typeof(UriFormat)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new object[] { typeof(UriSyntaxFlags) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "NotAny", MemberParameters = new object[] { typeof(UriSyntaxFlags) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "get_ShouldUseLegacyV2Quirks", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static char[] Compress(char[] dest, ushort start, ref int destLength, UriParser syntax)
		{
			throw null;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00003347 File Offset: 0x00001547
		[global::Cpp2ILInjected.Token(Token = "0x600025A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF6334", Offset = "0x1DF6334", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static int CalculateCaseInsensitiveHashCode(string text)
		{
			throw null;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000334A File Offset: 0x0000154A
		[global::Cpp2ILInjected.Token(Token = "0x600025B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF3530", Offset = "0x1DF3530", Length = "0x990")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetCombinedString", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(bool),
			typeof(ref string)
		}, ReturnType = typeof(ParsingError))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_OriginalStringSwitched", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new object[] { typeof(UriSyntaxFlags) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_IsUnc", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_DnsSafeHost", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_SecuredPathIndex", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "Compress", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(ushort),
			typeof(ref int),
			typeof(UriParser)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat)
		{
			throw null;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000334D File Offset: 0x0000154D
		[global::Cpp2ILInjected.Token(Token = "0x17000087")]
		internal bool HasAuthority
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DFBBB4", Offset = "0x1DFBBB4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriBuilder), Member = "Init", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriBuilder), Member = "SetFieldsFromUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00003350 File Offset: 0x00001550
		[global::Cpp2ILInjected.Token(Token = "0x600025D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF7AD8", Offset = "0x1DF7AD8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsLWS(char ch)
		{
			throw null;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00003353 File Offset: 0x00001553
		[global::Cpp2ILInjected.Token(Token = "0x600025E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF7B18", Offset = "0x1DF7B18", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsAsciiLetter(char character)
		{
			throw null;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00003356 File Offset: 0x00001556
		[global::Cpp2ILInjected.Token(Token = "0x600025F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFBBC0", Offset = "0x1DFBBC0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriHelper), Member = "IsUnreserved", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriHelper), Member = "Is3986Unreserved", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static bool IsAsciiLetterOrDigit(char character)
		{
			throw null;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00003359 File Offset: 0x00001559
		[global::Cpp2ILInjected.Token(Token = "0x6000260")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFBC3C", Offset = "0x1DFBC3C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IriHelper), Member = "EscapeUnescapeIri", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int),
			typeof(UriComponents)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriHelper), Member = "MatchUTF8Sequence", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char[]),
			typeof(ref int),
			typeof(char[]),
			typeof(int),
			typeof(byte[]),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal unsafe static bool IsBidiControlCharacter(char ch)
		{
			throw null;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000335C File Offset: 0x0000155C
		[global::Cpp2ILInjected.Token(Token = "0x6000261")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFB7A4", Offset = "0x1DFB7A4", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CheckAuthorityHelperHandleDnsIri", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(UriParser),
			typeof(string),
			typeof(ref Uri.Flags),
			typeof(ref bool),
			typeof(ref string),
			typeof(ref ParsingError)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DomainNameHelper), Member = "IdnEquivalent", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DomainNameHelper), Member = "UnicodeEquivalent", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal unsafe static string StripBidiControlCharacter(char* strToClean, int start, int length)
		{
			throw null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000335F File Offset: 0x0000155F
		[global::Cpp2ILInjected.Token(Token = "0x6000262")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF2554", Offset = "0x1DF2554", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CreateUri", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "ParseScheme", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref Uri.Flags),
			typeof(ref UriParser)
		}, ReturnType = typeof(ParsingError))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new object[]
		{
			typeof(ParsingError),
			typeof(UriKind),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void CreateThis(string uri, bool dontEscape, UriKind uriKind)
		{
			throw null;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00003362 File Offset: 0x00001562
		[global::Cpp2ILInjected.Token(Token = "0x6000263")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFBC84", Offset = "0x1DFBC84", Length = "0x4A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CreateThis", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(UriKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CreateHelper", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(UriKind),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetException", MemberParameters = new object[] { typeof(ParsingError) }, ReturnType = typeof(UriFormatException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CheckForConfigLoad", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "InitializeUriConfig", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new object[] { typeof(UriSyntaxFlags) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CheckForUnicode", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CheckForEscapedUnreserved", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "EscapeUnescapeIri", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(UriComponents)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "get_ShouldUseLegacyV2Quirks", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Normalize", MemberParameters = new object[] { typeof(NormalizationForm) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InternalOnNewUri", ReturnType = typeof(UriParser))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InternalValidate", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e)
		{
			throw null;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00003365 File Offset: 0x00001565
		[global::Cpp2ILInjected.Token(Token = "0x6000264")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFC12C", Offset = "0x1DFC12C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new object[]
		{
			typeof(ParsingError),
			typeof(UriKind),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		private bool CheckForConfigLoad(string data)
		{
			throw null;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00003368 File Offset: 0x00001568
		[global::Cpp2ILInjected.Token(Token = "0x6000265")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFC1D4", Offset = "0x1DFC1D4", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new object[]
		{
			typeof(ParsingError),
			typeof(UriKind),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(ref int),
			typeof(char),
			typeof(char),
			typeof(char),
			typeof(UnescapeMode),
			typeof(UriParser),
			typeof(bool)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool CheckForUnicode(string data)
		{
			throw null;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000336B File Offset: 0x0000156B
		[global::Cpp2ILInjected.Token(Token = "0x6000266")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFC2D4", Offset = "0x1DFC2D4", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new object[]
		{
			typeof(ParsingError),
			typeof(UriKind),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriHelper), Member = "EscapedAscii", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriHelper), Member = "Is3986Unreserved", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private bool CheckForEscapedUnreserved(string data)
		{
			throw null;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000336E File Offset: 0x0000156E
		[global::Cpp2ILInjected.Token(Token = "0x6000267")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF6BC0", Offset = "0x1DF6BC0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "IsWellFormedUriString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServiceNameCollection), Member = "NormalizeServiceName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingCookedPath", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingRawPath", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequestUriBuilder), Member = "BuildRequestUriUsingRawPath", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = "System.Net.HttpListenerRequestUriBuilder.ParsingResult")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebPermission), Member = "AddPermission", MemberParameters = new object[]
		{
			typeof(NetworkAccess),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequest), Member = "RegisterPrefix", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IWebRequestCreate)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebProxyDataBuilder), Member = "SetAutoProxyUrl", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieParser), Member = "Get", ReturnType = typeof(Cookie))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieContainer), Member = "Add", MemberParameters = new object[] { typeof(Cookie) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "TryGetHostUri", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "ToUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlConvert), Member = "TryToUri", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref Uri)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateHelper", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(UriKind),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool TryCreate(string uriString, UriKind uriKind, out Uri result)
		{
			throw null;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00003371 File Offset: 0x00001571
		[global::Cpp2ILInjected.Token(Token = "0x6000268")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFC6D0", Offset = "0x1DFC6D0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "TryUpdateResponseUri", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FtpWebRequest)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool TryCreate(Uri baseUri, string relativeUri, out Uri result)
		{
			throw null;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00003374 File Offset: 0x00001574
		[global::Cpp2ILInjected.Token(Token = "0x6000269")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFC798", Offset = "0x1DFC798", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "GetUri", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri),
			typeof(ref string),
			typeof(ref bool),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InternalResolve", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateHelper", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(UriKind),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result)
		{
			throw null;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00003377 File Offset: 0x00001577
		[global::Cpp2ILInjected.Token(Token = "0x600026A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF9398", Offset = "0x1DF9398", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 42)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetRelativeSerializationString", MemberParameters = new object[] { typeof(UriFormat) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InternalGetComponents", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public string GetComponents(UriComponents components, UriFormat format)
		{
			throw null;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000337A File Offset: 0x0000157A
		[global::Cpp2ILInjected.Token(Token = "0x600026B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFCB10", Offset = "0x1DFCB10", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "IsWellFormedUriString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InternalIsWellFormedOriginalString", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		public bool IsWellFormedOriginalString()
		{
			throw null;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000337D File Offset: 0x0000157D
		[global::Cpp2ILInjected.Token(Token = "0x600026C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFCF64", Offset = "0x1DFCF64", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServiceNameStore), Member = "ExtractHostname", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "IsWellFormedOriginalString", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsWellFormedUriString(string uriString, UriKind uriKind)
		{
			throw null;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00003380 File Offset: 0x00001580
		[global::Cpp2ILInjected.Token(Token = "0x600026D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFCB4C", Offset = "0x1DFCB4C", Length = "0x418")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriParser), Member = "IsWellFormedOriginalString", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_SecuredPathIndex", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CheckCanonical", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ref ushort),
			typeof(ushort),
			typeof(char)
		}, ReturnType = typeof(Uri.Check))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "get_ShouldUseLegacyV2Quirks", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CheckForColonInFirstPathSegment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal unsafe bool InternalIsWellFormedOriginalString()
		{
			throw null;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00003383 File Offset: 0x00001583
		[global::Cpp2ILInjected.Token(Token = "0x600026E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFCFF8", Offset = "0x1DFCFF8", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "ConvertFromSafeArgument", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.NetGroupInfo", Member = "ConvertFromSafeInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetRelativeSerializationString", MemberParameters = new object[] { typeof(UriFormat) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(ref int),
			typeof(char),
			typeof(char),
			typeof(char),
			typeof(UnescapeMode),
			typeof(UriParser),
			typeof(bool)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static string UnescapeDataString(string stringToUnescape)
		{
			throw null;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00003386 File Offset: 0x00001586
		[global::Cpp2ILInjected.Token(Token = "0x600026F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFD19C", Offset = "0x1DFD19C", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "ConvertToSafeArgument", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Net.NetGroupInfo", Member = "ConvertToSafeInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(ref int),
			typeof(bool),
			typeof(char),
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static string EscapeDataString(string stringToEscape)
		{
			throw null;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00003389 File Offset: 0x00001589
		[global::Cpp2ILInjected.Token(Token = "0x6000270")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFAC5C", Offset = "0x1DFAC5C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new object[]
		{
			typeof(ParsingError),
			typeof(UriKind),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IriHelper), Member = "EscapeUnescapeIri", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int),
			typeof(UriComponents)
		}, ReturnType = typeof(string))]
		internal unsafe string EscapeUnescapeIri(string input, int start, int end, UriComponents component)
		{
			throw null;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000338C File Offset: 0x0000158C
		[global::Cpp2ILInjected.Token(Token = "0x6000271")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFD2C8", Offset = "0x1DFD2C8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private Uri(Uri.Flags flags, UriParser uriParser, string uri)
		{
			throw null;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000338F File Offset: 0x0000158F
		[global::Cpp2ILInjected.Token(Token = "0x6000272")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFC484", Offset = "0x1DFC484", Length = "0x24C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "IsBaseOfHelper", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "ParseScheme", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref Uri.Flags),
			typeof(ref UriParser)
		}, ReturnType = typeof(ParsingError))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new object[]
		{
			typeof(ParsingError),
			typeof(UriKind),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e)
		{
			throw null;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00003392 File Offset: 0x00001592
		[global::Cpp2ILInjected.Token(Token = "0x6000273")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF29BC", Offset = "0x1DF29BC", Length = "0x484")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CreateUri", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri),
			typeof(ref Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "IsBaseOfHelper", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriParser), Member = "Resolve", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_OriginalStringSwitched", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InFact", MemberParameters = new object[] { typeof(UriSyntaxFlags) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetCombinedString", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(bool),
			typeof(ref string)
		}, ReturnType = typeof(ParsingError))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e)
		{
			throw null;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00003395 File Offset: 0x00001595
		[global::Cpp2ILInjected.Token(Token = "0x6000274")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFC900", Offset = "0x1DFC900", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriHelper), Member = "EscapeString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(ref int),
			typeof(bool),
			typeof(char),
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "UnescapeDataString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriHelper), Member = "UnescapeString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(ref int),
			typeof(char),
			typeof(char),
			typeof(char),
			typeof(UnescapeMode),
			typeof(UriParser),
			typeof(bool)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private string GetRelativeSerializationString(UriFormat format)
		{
			throw null;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00003398 File Offset: 0x00001598
		[global::Cpp2ILInjected.Token(Token = "0x6000275")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF6480", Offset = "0x1DF6480", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriParser), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "EnsureHostString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetEscapedParts", MemberParameters = new object[] { typeof(UriComponents) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetUnescapedParts", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat)
		{
			throw null;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000339B File Offset: 0x0000159B
		[global::Cpp2ILInjected.Token(Token = "0x6000276")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFD308", Offset = "0x1DFD308", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "TryUpdateResponseUri", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FtpWebRequest)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "get_IsSimple", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "InternalIsBaseOf", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool IsBaseOf(Uri uri)
		{
			throw null;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000339E File Offset: 0x0000159E
		[global::Cpp2ILInjected.Token(Token = "0x6000277")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFD3B4", Offset = "0x1DFD3B4", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriParser), Member = "IsBaseOf", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri),
			typeof(ref string),
			typeof(ref bool),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "CreateHelper", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(UriKind),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriHelper), Member = "TestForSubPath", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(char*),
			typeof(ushort),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal unsafe bool IsBaseOfHelper(Uri uriLink)
		{
			throw null;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000033A1 File Offset: 0x000015A1
		[global::Cpp2ILInjected.Token(Token = "0x6000278")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DF2E88", Offset = "0x1DF2E88", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CreateUri", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_OriginalStringSwitched", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_AllowIdn", ReturnType = typeof(bool))]
		private void CreateThisFromUri(Uri otherUri)
		{
			throw null;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000033A4 File Offset: 0x000015A4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000279")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DFD59C", Offset = "0x1DFD59C", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "GetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		static Uri()
		{
			throw null;
		}

		// Token: 0x040000AA RID: 170
		[global::Cpp2ILInjected.Token(Token = "0x400017A")]
		public static readonly string UriSchemeFile;

		// Token: 0x040000AB RID: 171
		[global::Cpp2ILInjected.Token(Token = "0x400017B")]
		public static readonly string UriSchemeFtp;

		// Token: 0x040000AC RID: 172
		[global::Cpp2ILInjected.Token(Token = "0x400017C")]
		public static readonly string UriSchemeGopher;

		// Token: 0x040000AD RID: 173
		[global::Cpp2ILInjected.Token(Token = "0x400017D")]
		public static readonly string UriSchemeHttp;

		// Token: 0x040000AE RID: 174
		[global::Cpp2ILInjected.Token(Token = "0x400017E")]
		public static readonly string UriSchemeHttps;

		// Token: 0x040000AF RID: 175
		[global::Cpp2ILInjected.Token(Token = "0x400017F")]
		internal static readonly string UriSchemeWs;

		// Token: 0x040000B0 RID: 176
		[global::Cpp2ILInjected.Token(Token = "0x4000180")]
		internal static readonly string UriSchemeWss;

		// Token: 0x040000B1 RID: 177
		[global::Cpp2ILInjected.Token(Token = "0x4000181")]
		public static readonly string UriSchemeMailto;

		// Token: 0x040000B2 RID: 178
		[global::Cpp2ILInjected.Token(Token = "0x4000182")]
		public static readonly string UriSchemeNews;

		// Token: 0x040000B3 RID: 179
		[global::Cpp2ILInjected.Token(Token = "0x4000183")]
		public static readonly string UriSchemeNntp;

		// Token: 0x040000B4 RID: 180
		[global::Cpp2ILInjected.Token(Token = "0x4000184")]
		public static readonly string UriSchemeNetTcp;

		// Token: 0x040000B5 RID: 181
		[global::Cpp2ILInjected.Token(Token = "0x4000185")]
		public static readonly string UriSchemeNetPipe;

		// Token: 0x040000B6 RID: 182
		[global::Cpp2ILInjected.Token(Token = "0x4000186")]
		public static readonly string SchemeDelimiter;

		// Token: 0x040000B7 RID: 183
		[global::Cpp2ILInjected.Token(Token = "0x4000187")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string m_String;

		// Token: 0x040000B8 RID: 184
		[global::Cpp2ILInjected.Token(Token = "0x4000188")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string m_originalUnicodeString;

		// Token: 0x040000B9 RID: 185
		[global::Cpp2ILInjected.Token(Token = "0x4000189")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private UriParser m_Syntax;

		// Token: 0x040000BA RID: 186
		[global::Cpp2ILInjected.Token(Token = "0x400018A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string m_DnsSafeHost;

		// Token: 0x040000BB RID: 187
		[global::Cpp2ILInjected.Token(Token = "0x400018B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Uri.Flags m_Flags;

		// Token: 0x040000BC RID: 188
		[global::Cpp2ILInjected.Token(Token = "0x400018C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Uri.UriInfo m_Info;

		// Token: 0x040000BD RID: 189
		[global::Cpp2ILInjected.Token(Token = "0x400018D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool m_iriParsing;

		// Token: 0x040000BE RID: 190
		[global::Cpp2ILInjected.Token(Token = "0x400018E")]
		private static bool s_ConfigInitialized;

		// Token: 0x040000BF RID: 191
		[global::Cpp2ILInjected.Token(Token = "0x400018F")]
		private static bool s_ConfigInitializing;

		// Token: 0x040000C0 RID: 192
		[global::Cpp2ILInjected.Token(Token = "0x4000190")]
		private static UriIdnScope s_IdnScope;

		// Token: 0x040000C1 RID: 193
		[global::Cpp2ILInjected.Token(Token = "0x4000191")]
		private static bool s_IriParsing;

		// Token: 0x040000C2 RID: 194
		[global::Cpp2ILInjected.Token(Token = "0x4000192")]
		private static bool useDotNetRelativeOrAbsolute;

		// Token: 0x040000C3 RID: 195
		[global::Cpp2ILInjected.Token(Token = "0x4000193")]
		internal static readonly bool IsWindowsFileSystem;

		// Token: 0x040000C4 RID: 196
		[global::Cpp2ILInjected.Token(Token = "0x4000194")]
		private static object s_initLock;

		// Token: 0x040000C5 RID: 197
		[global::Cpp2ILInjected.Token(Token = "0x4000195")]
		internal static readonly char[] HexLowerChars;

		// Token: 0x040000C6 RID: 198
		[global::Cpp2ILInjected.Token(Token = "0x4000196")]
		private static readonly char[] _WSchars;

		// Token: 0x020003B2 RID: 946
		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x2000084")]
		private enum Flags : ulong
		{
			// Token: 0x04001082 RID: 4226
			[global::Cpp2ILInjected.Token(Token = "0x4000198")]
			Zero = 0UL,
			// Token: 0x04001083 RID: 4227
			[global::Cpp2ILInjected.Token(Token = "0x4000199")]
			SchemeNotCanonical = 1UL,
			// Token: 0x04001084 RID: 4228
			[global::Cpp2ILInjected.Token(Token = "0x400019A")]
			UserNotCanonical = 2UL,
			// Token: 0x04001085 RID: 4229
			[global::Cpp2ILInjected.Token(Token = "0x400019B")]
			HostNotCanonical = 4UL,
			// Token: 0x04001086 RID: 4230
			[global::Cpp2ILInjected.Token(Token = "0x400019C")]
			PortNotCanonical = 8UL,
			// Token: 0x04001087 RID: 4231
			[global::Cpp2ILInjected.Token(Token = "0x400019D")]
			PathNotCanonical = 16UL,
			// Token: 0x04001088 RID: 4232
			[global::Cpp2ILInjected.Token(Token = "0x400019E")]
			QueryNotCanonical = 32UL,
			// Token: 0x04001089 RID: 4233
			[global::Cpp2ILInjected.Token(Token = "0x400019F")]
			FragmentNotCanonical = 64UL,
			// Token: 0x0400108A RID: 4234
			[global::Cpp2ILInjected.Token(Token = "0x40001A0")]
			CannotDisplayCanonical = 127UL,
			// Token: 0x0400108B RID: 4235
			[global::Cpp2ILInjected.Token(Token = "0x40001A1")]
			E_UserNotCanonical = 128UL,
			// Token: 0x0400108C RID: 4236
			[global::Cpp2ILInjected.Token(Token = "0x40001A2")]
			E_HostNotCanonical = 256UL,
			// Token: 0x0400108D RID: 4237
			[global::Cpp2ILInjected.Token(Token = "0x40001A3")]
			E_PortNotCanonical = 512UL,
			// Token: 0x0400108E RID: 4238
			[global::Cpp2ILInjected.Token(Token = "0x40001A4")]
			E_PathNotCanonical = 1024UL,
			// Token: 0x0400108F RID: 4239
			[global::Cpp2ILInjected.Token(Token = "0x40001A5")]
			E_QueryNotCanonical = 2048UL,
			// Token: 0x04001090 RID: 4240
			[global::Cpp2ILInjected.Token(Token = "0x40001A6")]
			E_FragmentNotCanonical = 4096UL,
			// Token: 0x04001091 RID: 4241
			[global::Cpp2ILInjected.Token(Token = "0x40001A7")]
			E_CannotDisplayCanonical = 8064UL,
			// Token: 0x04001092 RID: 4242
			[global::Cpp2ILInjected.Token(Token = "0x40001A8")]
			ShouldBeCompressed = 8192UL,
			// Token: 0x04001093 RID: 4243
			[global::Cpp2ILInjected.Token(Token = "0x40001A9")]
			FirstSlashAbsent = 16384UL,
			// Token: 0x04001094 RID: 4244
			[global::Cpp2ILInjected.Token(Token = "0x40001AA")]
			BackslashInPath = 32768UL,
			// Token: 0x04001095 RID: 4245
			[global::Cpp2ILInjected.Token(Token = "0x40001AB")]
			IndexMask = 65535UL,
			// Token: 0x04001096 RID: 4246
			[global::Cpp2ILInjected.Token(Token = "0x40001AC")]
			HostTypeMask = 458752UL,
			// Token: 0x04001097 RID: 4247
			[global::Cpp2ILInjected.Token(Token = "0x40001AD")]
			HostNotParsed = 0UL,
			// Token: 0x04001098 RID: 4248
			[global::Cpp2ILInjected.Token(Token = "0x40001AE")]
			IPv6HostType = 65536UL,
			// Token: 0x04001099 RID: 4249
			[global::Cpp2ILInjected.Token(Token = "0x40001AF")]
			IPv4HostType = 131072UL,
			// Token: 0x0400109A RID: 4250
			[global::Cpp2ILInjected.Token(Token = "0x40001B0")]
			DnsHostType = 196608UL,
			// Token: 0x0400109B RID: 4251
			[global::Cpp2ILInjected.Token(Token = "0x40001B1")]
			UncHostType = 262144UL,
			// Token: 0x0400109C RID: 4252
			[global::Cpp2ILInjected.Token(Token = "0x40001B2")]
			BasicHostType = 327680UL,
			// Token: 0x0400109D RID: 4253
			[global::Cpp2ILInjected.Token(Token = "0x40001B3")]
			UnusedHostType = 393216UL,
			// Token: 0x0400109E RID: 4254
			[global::Cpp2ILInjected.Token(Token = "0x40001B4")]
			UnknownHostType = 458752UL,
			// Token: 0x0400109F RID: 4255
			[global::Cpp2ILInjected.Token(Token = "0x40001B5")]
			UserEscaped = 524288UL,
			// Token: 0x040010A0 RID: 4256
			[global::Cpp2ILInjected.Token(Token = "0x40001B6")]
			AuthorityFound = 1048576UL,
			// Token: 0x040010A1 RID: 4257
			[global::Cpp2ILInjected.Token(Token = "0x40001B7")]
			HasUserInfo = 2097152UL,
			// Token: 0x040010A2 RID: 4258
			[global::Cpp2ILInjected.Token(Token = "0x40001B8")]
			LoopbackHost = 4194304UL,
			// Token: 0x040010A3 RID: 4259
			[global::Cpp2ILInjected.Token(Token = "0x40001B9")]
			NotDefaultPort = 8388608UL,
			// Token: 0x040010A4 RID: 4260
			[global::Cpp2ILInjected.Token(Token = "0x40001BA")]
			UserDrivenParsing = 16777216UL,
			// Token: 0x040010A5 RID: 4261
			[global::Cpp2ILInjected.Token(Token = "0x40001BB")]
			CanonicalDnsHost = 33554432UL,
			// Token: 0x040010A6 RID: 4262
			[global::Cpp2ILInjected.Token(Token = "0x40001BC")]
			ErrorOrParsingRecursion = 67108864UL,
			// Token: 0x040010A7 RID: 4263
			[global::Cpp2ILInjected.Token(Token = "0x40001BD")]
			DosPath = 134217728UL,
			// Token: 0x040010A8 RID: 4264
			[global::Cpp2ILInjected.Token(Token = "0x40001BE")]
			UncPath = 268435456UL,
			// Token: 0x040010A9 RID: 4265
			[global::Cpp2ILInjected.Token(Token = "0x40001BF")]
			ImplicitFile = 536870912UL,
			// Token: 0x040010AA RID: 4266
			[global::Cpp2ILInjected.Token(Token = "0x40001C0")]
			MinimalUriInfoSet = 1073741824UL,
			// Token: 0x040010AB RID: 4267
			[global::Cpp2ILInjected.Token(Token = "0x40001C1")]
			AllUriInfoSet = 2147483648UL,
			// Token: 0x040010AC RID: 4268
			[global::Cpp2ILInjected.Token(Token = "0x40001C2")]
			IdnHost = 4294967296UL,
			// Token: 0x040010AD RID: 4269
			[global::Cpp2ILInjected.Token(Token = "0x40001C3")]
			HasUnicode = 8589934592UL,
			// Token: 0x040010AE RID: 4270
			[global::Cpp2ILInjected.Token(Token = "0x40001C4")]
			HostUnicodeNormalized = 17179869184UL,
			// Token: 0x040010AF RID: 4271
			[global::Cpp2ILInjected.Token(Token = "0x40001C5")]
			RestUnicodeNormalized = 34359738368UL,
			// Token: 0x040010B0 RID: 4272
			[global::Cpp2ILInjected.Token(Token = "0x40001C6")]
			UnicodeHost = 68719476736UL,
			// Token: 0x040010B1 RID: 4273
			[global::Cpp2ILInjected.Token(Token = "0x40001C7")]
			IntranetUri = 137438953472UL,
			// Token: 0x040010B2 RID: 4274
			[global::Cpp2ILInjected.Token(Token = "0x40001C8")]
			UseOrigUncdStrOffset = 274877906944UL,
			// Token: 0x040010B3 RID: 4275
			[global::Cpp2ILInjected.Token(Token = "0x40001C9")]
			UserIriCanonical = 549755813888UL,
			// Token: 0x040010B4 RID: 4276
			[global::Cpp2ILInjected.Token(Token = "0x40001CA")]
			PathIriCanonical = 1099511627776UL,
			// Token: 0x040010B5 RID: 4277
			[global::Cpp2ILInjected.Token(Token = "0x40001CB")]
			QueryIriCanonical = 2199023255552UL,
			// Token: 0x040010B6 RID: 4278
			[global::Cpp2ILInjected.Token(Token = "0x40001CC")]
			FragmentIriCanonical = 4398046511104UL,
			// Token: 0x040010B7 RID: 4279
			[global::Cpp2ILInjected.Token(Token = "0x40001CD")]
			IriCanonical = 8246337208320UL,
			// Token: 0x040010B8 RID: 4280
			[global::Cpp2ILInjected.Token(Token = "0x40001CE")]
			CompressedSlashes = 17592186044416UL
		}

		// Token: 0x020003B3 RID: 947
		[global::Cpp2ILInjected.Token(Token = "0x2000085")]
		private class UriInfo
		{
			// Token: 0x06001D2A RID: 7466 RVA: 0x00008072 File Offset: 0x00006272
			[global::Cpp2ILInjected.Token(Token = "0x600027A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA3A48", Offset = "0x1EA3A48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CreateUriInfo", MemberParameters = new object[] { "System.Uri.Flags" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public UriInfo()
			{
				throw null;
			}

			// Token: 0x040010B9 RID: 4281
			[global::Cpp2ILInjected.Token(Token = "0x40001CF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string Host;

			// Token: 0x040010BA RID: 4282
			[global::Cpp2ILInjected.Token(Token = "0x40001D0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public string ScopeId;

			// Token: 0x040010BB RID: 4283
			[global::Cpp2ILInjected.Token(Token = "0x40001D1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public string String;

			// Token: 0x040010BC RID: 4284
			[global::Cpp2ILInjected.Token(Token = "0x40001D2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public Uri.Offset Offset;

			// Token: 0x040010BD RID: 4285
			[global::Cpp2ILInjected.Token(Token = "0x40001D3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public string DnsSafeHost;

			// Token: 0x040010BE RID: 4286
			[global::Cpp2ILInjected.Token(Token = "0x40001D4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public Uri.MoreInfo MoreInfo;
		}

		// Token: 0x020003B4 RID: 948
		[global::Cpp2ILInjected.Token(Token = "0x2000086")]
		[StructLayout(0, Pack = 1, Size = 16)]
		private struct Offset
		{
			// Token: 0x040010BF RID: 4287
			[global::Cpp2ILInjected.Token(Token = "0x40001D5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public ushort Scheme;

			// Token: 0x040010C0 RID: 4288
			[global::Cpp2ILInjected.Token(Token = "0x40001D6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
			public ushort User;

			// Token: 0x040010C1 RID: 4289
			[global::Cpp2ILInjected.Token(Token = "0x40001D7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public ushort Host;

			// Token: 0x040010C2 RID: 4290
			[global::Cpp2ILInjected.Token(Token = "0x40001D8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x6")]
			public ushort PortValue;

			// Token: 0x040010C3 RID: 4291
			[global::Cpp2ILInjected.Token(Token = "0x40001D9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public ushort Path;

			// Token: 0x040010C4 RID: 4292
			[global::Cpp2ILInjected.Token(Token = "0x40001DA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA")]
			public ushort Query;

			// Token: 0x040010C5 RID: 4293
			[global::Cpp2ILInjected.Token(Token = "0x40001DB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public ushort Fragment;

			// Token: 0x040010C6 RID: 4294
			[global::Cpp2ILInjected.Token(Token = "0x40001DC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xE")]
			public ushort End;
		}

		// Token: 0x020003B5 RID: 949
		[global::Cpp2ILInjected.Token(Token = "0x2000087")]
		private class MoreInfo
		{
			// Token: 0x06001D2B RID: 7467 RVA: 0x00008075 File Offset: 0x00006275
			[global::Cpp2ILInjected.Token(Token = "0x600027B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA3A50", Offset = "0x1EA3A50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_PrivateAbsolutePath", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_AbsoluteUri", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_Query", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_Fragment", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetHashCode", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public MoreInfo()
			{
				throw null;
			}

			// Token: 0x040010C7 RID: 4295
			[global::Cpp2ILInjected.Token(Token = "0x40001DD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string Path;

			// Token: 0x040010C8 RID: 4296
			[global::Cpp2ILInjected.Token(Token = "0x40001DE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public string Query;

			// Token: 0x040010C9 RID: 4297
			[global::Cpp2ILInjected.Token(Token = "0x40001DF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public string Fragment;

			// Token: 0x040010CA RID: 4298
			[global::Cpp2ILInjected.Token(Token = "0x40001E0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public string AbsoluteUri;

			// Token: 0x040010CB RID: 4299
			[global::Cpp2ILInjected.Token(Token = "0x40001E1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public int Hash;

			// Token: 0x040010CC RID: 4300
			[global::Cpp2ILInjected.Token(Token = "0x40001E2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public string RemoteUrl;
		}

		// Token: 0x020003B6 RID: 950
		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x2000088")]
		private enum Check
		{
			// Token: 0x040010CE RID: 4302
			[global::Cpp2ILInjected.Token(Token = "0x40001E4")]
			None = 0,
			// Token: 0x040010CF RID: 4303
			[global::Cpp2ILInjected.Token(Token = "0x40001E5")]
			EscapedCanonical = 1,
			// Token: 0x040010D0 RID: 4304
			[global::Cpp2ILInjected.Token(Token = "0x40001E6")]
			DisplayCanonical = 2,
			// Token: 0x040010D1 RID: 4305
			[global::Cpp2ILInjected.Token(Token = "0x40001E7")]
			DotSlashAttn = 4,
			// Token: 0x040010D2 RID: 4306
			[global::Cpp2ILInjected.Token(Token = "0x40001E8")]
			DotSlashEscaped = 128,
			// Token: 0x040010D3 RID: 4307
			[global::Cpp2ILInjected.Token(Token = "0x40001E9")]
			BackslashInPath = 16,
			// Token: 0x040010D4 RID: 4308
			[global::Cpp2ILInjected.Token(Token = "0x40001EA")]
			ReservedFound = 32,
			// Token: 0x040010D5 RID: 4309
			[global::Cpp2ILInjected.Token(Token = "0x40001EB")]
			NotIriCanonical = 64,
			// Token: 0x040010D6 RID: 4310
			[global::Cpp2ILInjected.Token(Token = "0x40001EC")]
			FoundNonAscii = 8
		}
	}
}
