using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	[global::Cpp2ILInjected.Token(Token = "0x2000581")]
	public static class CharUnicodeInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002A50")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD4B78", Offset = "0x1BD4B78", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharUnicodeInfo), Member = "InternalGetUnicodeCategory", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		internal static int InternalConvertToUtf32(string s, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A51")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD4C04", Offset = "0x1BD4C04", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharUnicodeInfo), Member = "GetNumericValue", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CharUnicodeInfo), Member = "get_NumericLevel1Index", ReturnType = typeof(global::System.ReadOnlySpan<byte>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CharUnicodeInfo), Member = "get_NumericLevel2Index", ReturnType = typeof(global::System.ReadOnlySpan<byte>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CharUnicodeInfo), Member = "get_NumericLevel3Index", ReturnType = typeof(global::System.ReadOnlySpan<byte>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CharUnicodeInfo), Member = "get_NumericValues", ReturnType = typeof(global::System.ReadOnlySpan<byte>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.Unsafe), Member = "AsRef", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&" }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static double InternalGetNumericValue(int ch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A52")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD4EE4", Offset = "0x1BD4EE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "GetNumericValue", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CharUnicodeInfo), Member = "InternalGetNumericValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(double))]
		public static double GetNumericValue(char ch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A53")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD4EEC", Offset = "0x1BD4EEC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "IsDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "IsLetter", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "IsUpper", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "IsLower", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "IsPunctuation", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "IsNumber", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "IsSymbol", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexCharClass", Member = "CharInCategory", MemberParameters = new object[]
		{
			typeof(char),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CharUnicodeInfo), Member = "InternalGetCategoryValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte))]
		public static UnicodeCategory GetUnicodeCategory(char ch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A54")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD4F20", Offset = "0x1BD4F20", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "IsNumber", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharUnicodeInfo), Member = "IsWhiteSpace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CharUnicodeInfo), Member = "InternalConvertToUtf32", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CharUnicodeInfo), Member = "InternalGetCategoryValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static UnicodeCategory GetUnicodeCategory(string s, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD4F08", Offset = "0x1BD4F08", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "GetUnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CharUnicodeInfo), Member = "InternalGetCategoryValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte))]
		public static UnicodeCategory GetUnicodeCategory(int codePoint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A56")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD4FE4", Offset = "0x1BD4FE4", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharUnicodeInfo), Member = "InternalGetUnicodeCategory", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharUnicodeInfo), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CharUnicodeInfo), Member = "get_CategoryLevel1Index", ReturnType = typeof(global::System.ReadOnlySpan<byte>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CharUnicodeInfo), Member = "get_CategoryLevel2Index", ReturnType = typeof(global::System.ReadOnlySpan<byte>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.Unsafe), Member = "AsRef", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&" }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CharUnicodeInfo), Member = "get_CategoryLevel3Index", ReturnType = typeof(global::System.ReadOnlySpan<byte>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CharUnicodeInfo), Member = "get_CategoriesValue", ReturnType = typeof(global::System.ReadOnlySpan<byte>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static byte InternalGetCategoryValue(int ch, int offset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A57")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD4FC8", Offset = "0x1BD4FC8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "GetUnicodeCategory", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(UnicodeCategory))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CharUnicodeInfo), Member = "InternalConvertToUtf32", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CharUnicodeInfo), Member = "InternalGetCategoryValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte))]
		internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A58")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD5284", Offset = "0x1BD5284", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(UnicodeCategory))]
		internal static bool IsWhiteSpace(string s, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002A59")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD52A0", Offset = "0x1BD52A0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CharUnicodeInfo), Member = "InternalGetCategoryValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte))]
		internal static bool IsWhiteSpace(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000611")]
		private static global::System.ReadOnlySpan<byte> CategoryLevel1Index
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A5A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD50B4", Offset = "0x1BD50B4", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharUnicodeInfo), Member = "InternalGetCategoryValue", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(byte))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000612")]
		private static global::System.ReadOnlySpan<byte> CategoryLevel2Index
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A5B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD5128", Offset = "0x1BD5128", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharUnicodeInfo), Member = "InternalGetCategoryValue", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(byte))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000613")]
		private static global::System.ReadOnlySpan<byte> CategoryLevel3Index
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A5C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD519C", Offset = "0x1BD519C", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharUnicodeInfo), Member = "InternalGetCategoryValue", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(byte))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000614")]
		private static global::System.ReadOnlySpan<byte> CategoriesValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A5D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD5210", Offset = "0x1BD5210", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharUnicodeInfo), Member = "InternalGetCategoryValue", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(byte))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000615")]
		private static global::System.ReadOnlySpan<byte> NumericLevel1Index
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A5E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD4D14", Offset = "0x1BD4D14", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharUnicodeInfo), Member = "InternalGetNumericValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000616")]
		private static global::System.ReadOnlySpan<byte> NumericLevel2Index
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A5F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD4D88", Offset = "0x1BD4D88", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharUnicodeInfo), Member = "InternalGetNumericValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000617")]
		private static global::System.ReadOnlySpan<byte> NumericLevel3Index
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A60")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD4DFC", Offset = "0x1BD4DFC", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharUnicodeInfo), Member = "InternalGetNumericValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000618")]
		private static global::System.ReadOnlySpan<byte> NumericValues
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002A61")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD4E70", Offset = "0x1BD4E70", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CharUnicodeInfo), Member = "InternalGetNumericValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}
	}
}
