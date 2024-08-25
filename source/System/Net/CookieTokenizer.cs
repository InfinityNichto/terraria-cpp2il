using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200020E")]
	internal class CookieTokenizer
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2E44C", Offset = "0x1F2E44C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CookieTokenizer(string tokenStream)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002B0")]
		internal bool EndOfCookie
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CF9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2E47C", Offset = "0x1F2E47C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000CFA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2E484", Offset = "0x1F2E484", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002B1")]
		internal bool Eof
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CFB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2E490", Offset = "0x1F2E490", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002B2")]
		internal string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CFC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2E4A0", Offset = "0x1F2E4A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000CFD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2E4A8", Offset = "0x1F2E4A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002B3")]
		internal bool Quoted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CFE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2E4B0", Offset = "0x1F2E4B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000CFF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2E4B8", Offset = "0x1F2E4B8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002B4")]
		internal CookieToken Token
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D00")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2E4C4", Offset = "0x1F2E4C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000D01")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2E4CC", Offset = "0x1F2E4CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002B5")]
		internal string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D02")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2E4D4", Offset = "0x1F2E4D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000D03")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2E4DC", Offset = "0x1F2E4DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2E4E4", Offset = "0x1F2E4E4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieTokenizer), Member = "Next", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(CookieToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal string Extract()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2E560", Offset = "0x1F2E560", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieTokenizer), Member = "Next", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(CookieToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2E7E0", Offset = "0x1F2E7E0", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieParser), Member = "Get", ReturnType = typeof(Cookie))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieParser), Member = "GetServer", ReturnType = typeof(Cookie))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieTokenizer), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieTokenizer), Member = "FindNext", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(CookieToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieTokenizer), Member = "Extract", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CookieTokenizer), Member = "TokenFromName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(CookieToken))]
		internal CookieToken Next(bool first, bool parseResponseCookies)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2E8D8", Offset = "0x1F2E8D8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieTokenizer), Member = "Next", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(CookieToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D08")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2E940", Offset = "0x1F2E940", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CookieTokenizer), Member = "Next", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(CookieToken))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal CookieToken TokenFromName(bool parseResponseCookies)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000D09")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2EADC", Offset = "0x1F2EADC", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		static CookieTokenizer()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000B24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool m_eofCookie;

		[global::Cpp2ILInjected.Token(Token = "0x4000B25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int m_index;

		[global::Cpp2ILInjected.Token(Token = "0x4000B26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int m_length;

		[global::Cpp2ILInjected.Token(Token = "0x4000B27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string m_name;

		[global::Cpp2ILInjected.Token(Token = "0x4000B28")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool m_quoted;

		[global::Cpp2ILInjected.Token(Token = "0x4000B29")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int m_start;

		[global::Cpp2ILInjected.Token(Token = "0x4000B2A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private CookieToken m_token;

		[global::Cpp2ILInjected.Token(Token = "0x4000B2B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int m_tokenLength;

		[global::Cpp2ILInjected.Token(Token = "0x4000B2C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string m_tokenStream;

		[global::Cpp2ILInjected.Token(Token = "0x4000B2D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string m_value;

		[global::Cpp2ILInjected.Token(Token = "0x4000B2E")]
		private static CookieTokenizer.RecognizedAttribute[] RecognizedAttributes;

		[global::Cpp2ILInjected.Token(Token = "0x4000B2F")]
		private static CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes;

		[global::Cpp2ILInjected.Token(Token = "0x200020F")]
		private struct RecognizedAttribute
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000D0A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2ED68", Offset = "0x1F2ED68", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal RecognizedAttribute(string name, CookieToken token)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170002B6")]
			internal CookieToken Token
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000D0B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F2ED74", Offset = "0x1F2ED74", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000D0C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F2EAB8", Offset = "0x1F2EAB8", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(StringComparison)
			}, ReturnType = typeof(int))]
			internal bool IsEqualTo(string value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000B30")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private string m_name;

			[global::Cpp2ILInjected.Token(Token = "0x4000B31")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private CookieToken m_token;
		}
	}
}
