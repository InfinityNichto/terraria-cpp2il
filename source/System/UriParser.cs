using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000043 RID: 67
	[global::Cpp2ILInjected.Token(Token = "0x2000092")]
	public abstract class UriParser
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000205 RID: 517 RVA: 0x000033DA File Offset: 0x000015DA
		[global::Cpp2ILInjected.Token(Token = "0x17000088")]
		internal string SchemeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600028D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA4F38", Offset = "0x1EA4F38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000206 RID: 518 RVA: 0x000033DD File Offset: 0x000015DD
		[global::Cpp2ILInjected.Token(Token = "0x17000089")]
		internal int DefaultPort
		{
			[global::Cpp2ILInjected.Token(Token = "0x600028E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA4F40", Offset = "0x1EA4F40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000033E0 File Offset: 0x000015E0
		[global::Cpp2ILInjected.Token(Token = "0x600028F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA4F48", Offset = "0x1EA4F48", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual UriParser OnNewUri()
		{
			throw null;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000033E3 File Offset: 0x000015E3
		[global::Cpp2ILInjected.Token(Token = "0x6000290")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA4F4C", Offset = "0x1EA4F4C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "ParseMinimal", ReturnType = typeof(UriFormatException))]
		protected virtual void InitializeAndValidate(Uri uri, out UriFormatException parsingError)
		{
			throw null;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000033E6 File Offset: 0x000015E6
		[global::Cpp2ILInjected.Token(Token = "0x6000291")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA4F6C", Offset = "0x1EA4F6C", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_UserDrivenParsing", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_IsAbsoluteUri", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri),
			typeof(ref string),
			typeof(ref bool),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		protected virtual string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError)
		{
			throw null;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000033E9 File Offset: 0x000015E9
		[global::Cpp2ILInjected.Token(Token = "0x6000292")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA5120", Offset = "0x1EA5120", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "IsBaseOfHelper", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		protected virtual bool IsBaseOf(Uri baseUri, Uri relativeUri)
		{
			throw null;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x000033EC File Offset: 0x000015EC
		[global::Cpp2ILInjected.Token(Token = "0x6000293")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA5130", Offset = "0x1EA5130", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_UserDrivenParsing", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_IsAbsoluteUri", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "GetComponentsHelper", MemberParameters = new object[]
		{
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		protected virtual string GetComponents(Uri uri, UriComponents components, UriFormat format)
		{
			throw null;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000033EF File Offset: 0x000015EF
		[global::Cpp2ILInjected.Token(Token = "0x6000294")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA5324", Offset = "0x1EA5324", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
		protected virtual bool IsWellFormedOriginalString(Uri uri)
		{
			throw null;
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600020D RID: 525 RVA: 0x000033F2 File Offset: 0x000015F2
		[global::Cpp2ILInjected.Token(Token = "0x1700008A")]
		internal unsafe static bool ShouldUseLegacyV2Quirks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000295")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA4DB0", Offset = "0x1EA4DB0", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ReCreateParts", MemberParameters = new object[]
			{
				typeof(UriComponents),
				typeof(ushort),
				typeof(UriFormat)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "Compress", MemberParameters = new object[]
			{
				typeof(char[]),
				typeof(ushort),
				typeof(ref int),
				typeof(UriParser)
			}, ReturnType = typeof(char[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new object[]
			{
				typeof(ParsingError),
				typeof(UriKind),
				typeof(ref UriFormatException)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "InternalIsWellFormedOriginalString", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriHelper), Member = "IsReservedUnreservedOrHash", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriHelper), Member = "IsUnreserved", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriParser), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000033F5 File Offset: 0x000015F5
		[global::Cpp2ILInjected.Token(Token = "0x6000296")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA5330", Offset = "0x1EA5330", Length = "0x70C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "get_ShouldUseLegacyV2Quirks", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser.BuiltInUriParser), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(UriSyntaxFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		static UriParser()
		{
			throw null;
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600020F RID: 527 RVA: 0x000033F8 File Offset: 0x000015F8
		[global::Cpp2ILInjected.Token(Token = "0x1700008B")]
		internal UriSyntaxFlags Flags
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000297")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA5ABC", Offset = "0x1EA5ABC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000033FB File Offset: 0x000015FB
		[global::Cpp2ILInjected.Token(Token = "0x6000298")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA1F00", Offset = "0x1EA1F00", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "Compress", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(ushort),
			typeof(ref int),
			typeof(UriParser)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "IsFullMatch", MemberParameters = new object[]
		{
			typeof(UriSyntaxFlags),
			typeof(UriSyntaxFlags)
		}, ReturnType = typeof(bool))]
		internal unsafe bool NotAny(UriSyntaxFlags flags)
		{
			throw null;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000033FE File Offset: 0x000015FE
		[global::Cpp2ILInjected.Token(Token = "0x6000299")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA1EE4", Offset = "0x1EA1EE4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "IriParsingStatic", MemberParameters = new object[] { typeof(UriParser) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "StaticIsFile", MemberParameters = new object[] { typeof(UriParser) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ParseRemaining", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "FindEndOfComponent", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ref ushort),
			typeof(ushort),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CheckCanonical", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ref ushort),
			typeof(ushort),
			typeof(char)
		}, ReturnType = "System.Uri.Check")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetCanonicalPath", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(ref int),
			typeof(UriFormat)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "Compress", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(ushort),
			typeof(ref int),
			typeof(UriParser)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CombineUri", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new object[]
		{
			typeof(ParsingError),
			typeof(UriKind),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ResolveHelper", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri),
			typeof(ref string),
			typeof(ref bool),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 49)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "IsFullMatch", MemberParameters = new object[]
		{
			typeof(UriSyntaxFlags),
			typeof(UriSyntaxFlags)
		}, ReturnType = typeof(bool))]
		internal unsafe bool InFact(UriSyntaxFlags flags)
		{
			throw null;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00003401 File Offset: 0x00001601
		[global::Cpp2ILInjected.Token(Token = "0x600029A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA5B20", Offset = "0x1EA5B20", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "PrivateParseMinimal", ReturnType = typeof(ParsingError))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = "IsFullMatch", MemberParameters = new object[]
		{
			typeof(UriSyntaxFlags),
			typeof(UriSyntaxFlags)
		}, ReturnType = typeof(bool))]
		internal bool IsAllSet(UriSyntaxFlags flags)
		{
			throw null;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00003404 File Offset: 0x00001604
		[global::Cpp2ILInjected.Token(Token = "0x600029B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA5AC4", Offset = "0x1EA5AC4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriParser), Member = "NotAny", MemberParameters = new object[] { typeof(UriSyntaxFlags) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriParser), Member = "InFact", MemberParameters = new object[] { typeof(UriSyntaxFlags) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriParser), Member = "IsAllSet", MemberParameters = new object[] { typeof(UriSyntaxFlags) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected)
		{
			throw null;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00003407 File Offset: 0x00001607
		[global::Cpp2ILInjected.Token(Token = "0x600029C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA5B28", Offset = "0x1EA5B28", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriParser.BuiltInUriParser), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(UriSyntaxFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal UriParser(UriSyntaxFlags flags)
		{
			throw null;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000340A File Offset: 0x0000160A
		[global::Cpp2ILInjected.Token(Token = "0x600029D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA5B94", Offset = "0x1EA5B94", Length = "0x2BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CheckSchemeSyntax", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(ushort),
			typeof(ref UriParser)
		}, ReturnType = typeof(ParsingError))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser.BuiltInUriParser), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(UriSyntaxFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal unsafe static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme)
		{
			throw null;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000340D File Offset: 0x0000160D
		[global::Cpp2ILInjected.Token(Token = "0x600029E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA1E20", Offset = "0x1EA1E20", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriBuilder), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static UriParser GetSyntax(string lwrCaseScheme)
		{
			throw null;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00003410 File Offset: 0x00001610
		[global::Cpp2ILInjected.Token(Token = "0x1700008C")]
		internal bool IsSimple
		{
			[global::Cpp2ILInjected.Token(Token = "0x600029F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA5E50", Offset = "0x1EA5E50", Length = "0xC")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_HostNameType", ReturnType = typeof(UriHostNameType))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "CreateHostString", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new object[]
			{
				typeof(ParsingError),
				typeof(UriKind),
				typeof(ref UriFormatException)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(Uri),
				typeof(ref Uri)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
			{
				typeof(UriComponents),
				typeof(UriFormat)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "IsWellFormedOriginalString", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "IsBaseOf", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00003413 File Offset: 0x00001613
		[global::Cpp2ILInjected.Token(Token = "0x60002A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA5E5C", Offset = "0x1EA5E5C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new object[]
		{
			typeof(ParsingError),
			typeof(UriKind),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal UriParser InternalOnNewUri()
		{
			throw null;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00003416 File Offset: 0x00001616
		[global::Cpp2ILInjected.Token(Token = "0x60002A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA5E98", Offset = "0x1EA5E98", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "InitializeUri", MemberParameters = new object[]
		{
			typeof(ParsingError),
			typeof(UriKind),
			typeof(ref UriFormatException)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void InternalValidate(Uri thisUri, out UriFormatException parsingError)
		{
			throw null;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00003419 File Offset: 0x00001619
		[global::Cpp2ILInjected.Token(Token = "0x60002A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA5EA4", Offset = "0x1EA5EA4", Length = "0xC")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError)
		{
			throw null;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000341C File Offset: 0x0000161C
		[global::Cpp2ILInjected.Token(Token = "0x60002A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA5EB0", Offset = "0x1EA5EB0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "IsBaseOf", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool InternalIsBaseOf(Uri thisBaseUri, Uri uriLink)
		{
			throw null;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000341F File Offset: 0x0000161F
		[global::Cpp2ILInjected.Token(Token = "0x60002A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA5EBC", Offset = "0x1EA5EBC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetHostViaCustomSyntax", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "GetComponents", MemberParameters = new object[]
		{
			typeof(UriComponents),
			typeof(UriFormat)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat)
		{
			throw null;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00003422 File Offset: 0x00001622
		[global::Cpp2ILInjected.Token(Token = "0x60002A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA5EC8", Offset = "0x1EA5EC8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Uri), Member = "IsWellFormedOriginalString", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool InternalIsWellFormedOriginalString(Uri thisUri)
		{
			throw null;
		}

		// Token: 0x04000103 RID: 259
		[global::Cpp2ILInjected.Token(Token = "0x4000229")]
		private static readonly Dictionary<string, UriParser> m_Table;

		// Token: 0x04000104 RID: 260
		[global::Cpp2ILInjected.Token(Token = "0x400022A")]
		private static Dictionary<string, UriParser> m_TempTable;

		// Token: 0x04000105 RID: 261
		[global::Cpp2ILInjected.Token(Token = "0x400022B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private UriSyntaxFlags m_Flags;

		// Token: 0x04000106 RID: 262
		[global::Cpp2ILInjected.Token(Token = "0x400022C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private UriSyntaxFlags m_UpdatableFlags;

		// Token: 0x04000107 RID: 263
		[global::Cpp2ILInjected.Token(Token = "0x400022D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool m_UpdatableFlagsUsed;

		// Token: 0x04000108 RID: 264
		[global::Cpp2ILInjected.Token(Token = "0x400022E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int m_Port;

		// Token: 0x04000109 RID: 265
		[global::Cpp2ILInjected.Token(Token = "0x400022F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string m_Scheme;

		// Token: 0x0400010A RID: 266
		[global::Cpp2ILInjected.Token(Token = "0x4000230")]
		internal static UriParser HttpUri;

		// Token: 0x0400010B RID: 267
		[global::Cpp2ILInjected.Token(Token = "0x4000231")]
		internal static UriParser HttpsUri;

		// Token: 0x0400010C RID: 268
		[global::Cpp2ILInjected.Token(Token = "0x4000232")]
		internal static UriParser WsUri;

		// Token: 0x0400010D RID: 269
		[global::Cpp2ILInjected.Token(Token = "0x4000233")]
		internal static UriParser WssUri;

		// Token: 0x0400010E RID: 270
		[global::Cpp2ILInjected.Token(Token = "0x4000234")]
		internal static UriParser FtpUri;

		// Token: 0x0400010F RID: 271
		[global::Cpp2ILInjected.Token(Token = "0x4000235")]
		internal static UriParser FileUri;

		// Token: 0x04000110 RID: 272
		[global::Cpp2ILInjected.Token(Token = "0x4000236")]
		internal static UriParser GopherUri;

		// Token: 0x04000111 RID: 273
		[global::Cpp2ILInjected.Token(Token = "0x4000237")]
		internal static UriParser NntpUri;

		// Token: 0x04000112 RID: 274
		[global::Cpp2ILInjected.Token(Token = "0x4000238")]
		internal static UriParser NewsUri;

		// Token: 0x04000113 RID: 275
		[global::Cpp2ILInjected.Token(Token = "0x4000239")]
		internal static UriParser MailToUri;

		// Token: 0x04000114 RID: 276
		[global::Cpp2ILInjected.Token(Token = "0x400023A")]
		internal static UriParser UuidUri;

		// Token: 0x04000115 RID: 277
		[global::Cpp2ILInjected.Token(Token = "0x400023B")]
		internal static UriParser TelnetUri;

		// Token: 0x04000116 RID: 278
		[global::Cpp2ILInjected.Token(Token = "0x400023C")]
		internal static UriParser LdapUri;

		// Token: 0x04000117 RID: 279
		[global::Cpp2ILInjected.Token(Token = "0x400023D")]
		internal static UriParser NetTcpUri;

		// Token: 0x04000118 RID: 280
		[global::Cpp2ILInjected.Token(Token = "0x400023E")]
		internal static UriParser NetPipeUri;

		// Token: 0x04000119 RID: 281
		[global::Cpp2ILInjected.Token(Token = "0x400023F")]
		internal static UriParser VsMacrosUri;

		// Token: 0x0400011A RID: 282
		[global::Cpp2ILInjected.Token(Token = "0x4000240")]
		private static readonly UriParser.UriQuirksVersion s_QuirksVersion;

		// Token: 0x0400011B RID: 283
		[global::Cpp2ILInjected.Token(Token = "0x4000241")]
		private static readonly UriSyntaxFlags HttpSyntaxFlags;

		// Token: 0x0400011C RID: 284
		[global::Cpp2ILInjected.Token(Token = "0x4000242")]
		private static readonly UriSyntaxFlags FileSyntaxFlags;

		// Token: 0x020003B7 RID: 951
		[global::Cpp2ILInjected.Token(Token = "0x2000093")]
		private enum UriQuirksVersion
		{
			// Token: 0x040010D8 RID: 4312
			[global::Cpp2ILInjected.Token(Token = "0x4000244")]
			V2 = 2,
			// Token: 0x040010D9 RID: 4313
			[global::Cpp2ILInjected.Token(Token = "0x4000245")]
			V3
		}

		// Token: 0x020003B8 RID: 952
		[global::Cpp2ILInjected.Token(Token = "0x2000094")]
		private class BuiltInUriParser : UriParser
		{
			// Token: 0x06001D2C RID: 7468 RVA: 0x00008078 File Offset: 0x00006278
			[global::Cpp2ILInjected.Token(Token = "0x60002A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA5A3C", Offset = "0x1EA5A3C", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriParser), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UriParser), Member = "FindOrFetchAsUnknownV1Syntax", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(UriParser))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UriParser), Member = ".ctor", MemberParameters = new object[] { typeof(UriSyntaxFlags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal BuiltInUriParser(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags)
			{
				throw null;
			}
		}
	}
}
