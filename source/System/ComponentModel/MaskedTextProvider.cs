using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003A2")]
	public class MaskedTextProvider : ICloneable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001834")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50B7C", Offset = "0x1E50B7C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public MaskedTextProvider(string mask)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001835")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50F48", Offset = "0x1E50F48", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CultureInfo),
			typeof(bool),
			typeof(char),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public MaskedTextProvider(string mask, bool restrictToAscii)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001836")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50F60", Offset = "0x1E50F60", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CultureInfo),
			typeof(bool),
			typeof(char),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public MaskedTextProvider(string mask, CultureInfo culture)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001837")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50F74", Offset = "0x1E50F74", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CultureInfo),
			typeof(bool),
			typeof(char),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public MaskedTextProvider(string mask, CultureInfo culture, bool restrictToAscii)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001838")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50F88", Offset = "0x1E50F88", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CultureInfo),
			typeof(bool),
			typeof(char),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public MaskedTextProvider(string mask, char passwordChar, bool allowPromptAsInput)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001839")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50FA0", Offset = "0x1E50FA0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CultureInfo),
			typeof(bool),
			typeof(char),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public MaskedTextProvider(string mask, CultureInfo culture, char passwordChar, bool allowPromptAsInput)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600183A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50B94", Offset = "0x1E50B94", Length = "0x3B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CultureInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CultureInfo),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "IsPrintableChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "GetCultures", MemberParameters = new object[] { typeof(CultureTypes) }, ReturnType = typeof(CultureInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "ReadOnly", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public MaskedTextProvider(string mask, CultureInfo culture, bool allowPromptAsInput, char promptChar, char passwordChar, bool restrictToAscii)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600183B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5106C", Offset = "0x1E5106C", Length = "0x3FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CultureInfo),
			typeof(bool),
			typeof(char),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_DateSeparator", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_TimeSeparator", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Capacity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void Initialize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000589")]
		public bool AllowPromptAsInput
		{
			[global::Cpp2ILInjected.Token(Token = "0x600183C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E514AC", Offset = "0x1E514AC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "TestChar", MemberParameters = new object[]
			{
				typeof(char),
				typeof(int),
				typeof(ref MaskedTextResultHint)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700058A")]
		public int AssignedEditPositionCount
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600183D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E51514", Offset = "0x1E51514", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600183E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5151C", Offset = "0x1E5151C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700058B")]
		public int AvailableEditPositionCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x600183F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E51524", Offset = "0x1E51524", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001840")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E51544", Offset = "0x1E51544", Length = "0x420")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_AllowPromptAsInput", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_AsciiOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CultureInfo),
			typeof(bool),
			typeof(char),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityUtils), Member = "SecureCreateInstance", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "set_ResetOnPrompt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "set_ResetOnSpace", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "set_SkipLiterals", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_ResetOnPrompt", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_ResetOnSpace", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_SkipLiterals", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_IncludeLiterals", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "set_IncludeLiterals", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_IncludePrompt", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "set_IncludePrompt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public object Clone()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700058C")]
		public CultureInfo Culture
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001841")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E51E4C", Offset = "0x1E51E4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700058D")]
		public static char DefaultPasswordChar
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001842")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E51E54", Offset = "0x1E51E54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700058E")]
		public int EditPositionCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001843")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E51538", Offset = "0x1E51538", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700058F")]
		public IEnumerator EditPositions
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001844")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E51E5C", Offset = "0x1E51E5C", Length = "0x29C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000590")]
		public bool IncludeLiterals
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001845")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E51C8C", Offset = "0x1E51C8C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "ToString", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "ToString", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001846")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E51CF4", Offset = "0x1E51CF4", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000591")]
		public bool IncludePrompt
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001847")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E51D6C", Offset = "0x1E51D6C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "ToString", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "ToString", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001848")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E51DD4", Offset = "0x1E51DD4", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000592")]
		public bool AsciiOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001849")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E51964", Offset = "0x1E51964", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "TestChar", MemberParameters = new object[]
			{
				typeof(char),
				typeof(int),
				typeof(ref MaskedTextResultHint)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000593")]
		public bool IsPassword
		{
			[global::Cpp2ILInjected.Token(Token = "0x600184A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E520F8", Offset = "0x1E520F8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600184B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E52108", Offset = "0x1E52108", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000594")]
		public static int InvalidIndex
		{
			[global::Cpp2ILInjected.Token(Token = "0x600184C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E52184", Offset = "0x1E52184", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000595")]
		public int LastAssignedPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x600184D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5218C", Offset = "0x1E5218C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Add", MemberParameters = new object[]
			{
				typeof(char),
				typeof(ref int),
				typeof(ref MaskedTextResultHint)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Add", MemberParameters = new object[]
			{
				typeof(string),
				typeof(ref int),
				typeof(ref MaskedTextResultHint)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "InsertAtInt", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(ref int),
				typeof(ref MaskedTextResultHint),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Remove", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Remove", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(ref MaskedTextResultHint)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "RemoveAtInt", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(ref int),
				typeof(ref MaskedTextResultHint),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(int),
				typeof(ref int),
				typeof(ref MaskedTextResultHint)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindEditPositionInRange", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(byte)
			}, ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000596")]
		public int Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x600184E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E52244", Offset = "0x1E52244", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000597")]
		public string Mask
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600184F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E52250", Offset = "0x1E52250", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000598")]
		public bool MaskCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001850")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E52258", Offset = "0x1E52258", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000599")]
		public bool MaskFull
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001851")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E52268", Offset = "0x1E52268", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700059A")]
		public char PasswordChar
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001852")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E52280", Offset = "0x1E52280", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001853")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E52288", Offset = "0x1E52288", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "IsValidPasswordChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700059B")]
		public char PromptChar
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001854")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E523F0", Offset = "0x1E523F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001855")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E523F8", Offset = "0x1E523F8", Length = "0x184")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "IsPrintableChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "IsEditPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Chars", MemberParameters = new object[]
			{
				typeof(int),
				typeof(char)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700059C")]
		public bool ResetOnPrompt
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001856")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E51B54", Offset = "0x1E51B54", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "TestChar", MemberParameters = new object[]
			{
				typeof(char),
				typeof(int),
				typeof(ref MaskedTextResultHint)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "TestEscapeChar", MemberParameters = new object[]
			{
				typeof(char),
				typeof(int),
				typeof(MaskedTextProvider.CharDescriptor)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001857")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E519CC", Offset = "0x1E519CC", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700059D")]
		public bool ResetOnSpace
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001858")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E51BBC", Offset = "0x1E51BBC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "TestChar", MemberParameters = new object[]
			{
				typeof(char),
				typeof(int),
				typeof(ref MaskedTextResultHint)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "TestEscapeChar", MemberParameters = new object[]
			{
				typeof(char),
				typeof(int),
				typeof(MaskedTextProvider.CharDescriptor)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001859")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E51A44", Offset = "0x1E51A44", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700059E")]
		public bool SkipLiterals
		{
			[global::Cpp2ILInjected.Token(Token = "0x600185A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E51C24", Offset = "0x1E51C24", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "TestChar", MemberParameters = new object[]
			{
				typeof(char),
				typeof(int),
				typeof(ref MaskedTextResultHint)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "TestEscapeChar", MemberParameters = new object[]
			{
				typeof(char),
				typeof(int),
				typeof(MaskedTextProvider.CharDescriptor)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600185B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E51ABC", Offset = "0x1E51ABC", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700059F")]
		public char this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600185C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5262C", Offset = "0x1E5262C", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600185D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E526D4", Offset = "0x1E526D4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "Add", MemberParameters = new object[]
		{
			typeof(char),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		public bool Add(char input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600185E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E526F4", Offset = "0x1E526F4", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Add", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_LastAssignedPosition", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(MaskedTextProvider.CharType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestSetChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		public bool Add(char input, out int testPosition, out MaskedTextResultHint resultHint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600185F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E52884", Offset = "0x1E52884", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "Add", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		public bool Add(string input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001860")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E528A4", Offset = "0x1E528A4", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Add", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_LastAssignedPosition", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool Add(string input, out int testPosition, out MaskedTextResultHint resultHint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001861")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E529A0", Offset = "0x1E529A0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "Clear", MemberParameters = new object[] { typeof(ref MaskedTextResultHint) }, ReturnType = typeof(void))]
		public void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001862")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E529B8", Offset = "0x1E529B8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Set", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "ResetChar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public void Clear(out MaskedTextResultHint resultHint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001863")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E521D0", Offset = "0x1E521D0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "ResetString", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Set", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindEditPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(byte)
		}, ReturnType = typeof(int))]
		public int FindAssignedEditPositionFrom(int position, bool direction)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001864")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E52ADC", Offset = "0x1E52ADC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int FindAssignedEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001865")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E527D4", Offset = "0x1E527D4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(MaskedTextProvider.CharType)
		}, ReturnType = typeof(int))]
		public int FindEditPositionFrom(int position, bool direction)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001866")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E52BE0", Offset = "0x1E52BE0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int FindEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001867")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E52AF8", Offset = "0x1E52AF8", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "get_LastAssignedPosition", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "FindAssignedEditPositionFrom", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "FindUnassignedEditPositionFrom", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "FindUnassignedEditPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "InsertAtInt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "RemoveAtInt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "ResetString", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "ToString", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(MaskedTextProvider.CharType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int FindEditPositionInRange(int startPosition, int endPosition, bool direction, byte assignedStatus)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001868")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E52CD0", Offset = "0x1E52CD0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(MaskedTextProvider.CharType)
		}, ReturnType = typeof(int))]
		public int FindNonEditPositionFrom(int position, bool direction)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001869")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E52D20", Offset = "0x1E52D20", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(MaskedTextProvider.CharType)
		}, ReturnType = typeof(int))]
		public int FindNonEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600186A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E52BEC", Offset = "0x1E52BEC", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Add", MemberParameters = new object[]
		{
			typeof(char),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "FindEditPositionFrom", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "FindEditPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(byte)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "FindNonEditPositionFrom", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "FindNonEditPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "InsertAtInt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "RemoveAtInt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "SetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "TestString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "ToString", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int FindPositionInRange(int startPosition, int endPosition, bool direction, MaskedTextProvider.CharType charTypeFlags)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600186B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E52D2C", Offset = "0x1E52D2C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindEditPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(byte)
		}, ReturnType = typeof(int))]
		public int FindUnassignedEditPositionFrom(int position, bool direction)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600186C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E52D7C", Offset = "0x1E52D7C", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindEditPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(byte)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int FindUnassignedEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600186D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E52E88", Offset = "0x1E52E88", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool GetOperationResultFromHint(MaskedTextResultHint hint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600186E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E52E94", Offset = "0x1E52E94", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "InsertAt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		public bool InsertAt(char input, int position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600186F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E52F28", Offset = "0x1E52F28", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "InsertAt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		public bool InsertAt(char input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001870")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E52F08", Offset = "0x1E52F08", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "InsertAt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		public bool InsertAt(string input, int position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001871")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E52F80", Offset = "0x1E52F80", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "InsertAt", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "InsertAt", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "InsertAt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool InsertAt(string input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001872")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5304C", Offset = "0x1E5304C", Length = "0x340")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(MaskedTextProvider.CharType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindEditPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(byte)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_LastAssignedPosition", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "SetChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "ResetChar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "SetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool InsertAtInt(string input, int position, out int testPosition, out MaskedTextResultHint resultHint, bool testOnly)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001873")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E53A88", Offset = "0x1E53A88", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsAscii(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001874")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E53A9C", Offset = "0x1E53A9C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsAciiAlphanumeric(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001875")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E53AD8", Offset = "0x1E53AD8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "TestChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool IsAlphanumeric(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001876")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E53B60", Offset = "0x1E53B60", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsAsciiLetter(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001877")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E53B8C", Offset = "0x1E53B8C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool IsAvailablePosition(int position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001878")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5257C", Offset = "0x1E5257C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "set_PromptChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "ResetChar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool IsEditPosition(int position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001879")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E51498", Offset = "0x1E51498", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsEditPosition(MaskedTextProvider.CharDescriptor charDescriptor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600187A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E53C48", Offset = "0x1E53C48", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsLiteralPosition(MaskedTextProvider.CharDescriptor charDescriptor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600187B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50FB4", Offset = "0x1E50FB4", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(CultureInfo),
			typeof(bool),
			typeof(char),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "set_PromptChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "IsValidInputChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "IsValidMaskChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "IsValidPasswordChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "TestChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsPunctuation", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsSymbol", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool IsPrintableChar(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600187C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E53C64", Offset = "0x1E53C64", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "IsPrintableChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsValidInputChar(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600187D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E53CB8", Offset = "0x1E53CB8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "IsPrintableChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsValidMaskChar(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600187E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E52388", Offset = "0x1E52388", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "set_PasswordChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "IsPrintableChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsValidPasswordChar(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600187F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E53D0C", Offset = "0x1E53D0C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_LastAssignedPosition", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "ResetChar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public bool Remove()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001880")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E53D38", Offset = "0x1E53D38", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_LastAssignedPosition", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "ResetChar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public bool Remove(out int testPosition, out MaskedTextResultHint resultHint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001881")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E53D98", Offset = "0x1E53D98", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "RemoveAt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		public bool RemoveAt(int position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001882")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E53DBC", Offset = "0x1E53DBC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "RemoveAt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		public bool RemoveAt(int startPosition, int endPosition)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001883")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E53DDC", Offset = "0x1E53DDC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "RemoveAt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		public bool RemoveAt(int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001884")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E53E6C", Offset = "0x1E53E6C", Length = "0x318")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_LastAssignedPosition", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(MaskedTextProvider.CharType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindEditPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(byte)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "SetChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "ResetChar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "ResetString", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool RemoveAtInt(int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint, bool testOnly)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001885")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E51B34", Offset = "0x1E51B34", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		public bool Replace(char input, int position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001886")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E54210", Offset = "0x1E54210", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestEscapeChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(MaskedTextProvider.CharType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestSetChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		public bool Replace(char input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001887")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E54364", Offset = "0x1E54364", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestSetChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		public bool Replace(char input, int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001888")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E54750", Offset = "0x1E54750", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		public bool Replace(string input, int position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001889")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E54770", Offset = "0x1E54770", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestSetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "RemoveAt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool Replace(string input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600188A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5443C", Offset = "0x1E5443C", Length = "0x314")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "RemoveAtInt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "RemoveAt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_LastAssignedPosition", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(MaskedTextProvider.CharType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "SetChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "SetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool Replace(string input, int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600188B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E52A28", Offset = "0x1E52A28", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Clear", MemberParameters = new object[] { typeof(ref MaskedTextResultHint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "InsertAtInt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Remove", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Remove", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "RemoveAtInt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "ResetString", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "SetChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(MaskedTextProvider.CharDescriptor)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "IsEditPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Chars", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void ResetChar(int testPosition)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600188C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E54184", Offset = "0x1E54184", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "RemoveAtInt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Set", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindAssignedEditPositionFrom", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindEditPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(byte)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "ResetChar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		private void ResetString(int startPosition, int endPosition)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600188D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E54864", Offset = "0x1E54864", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "Set", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		public bool Set(string input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600188E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E54884", Offset = "0x1E54884", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Set", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestSetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindAssignedEditPositionFrom", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "ResetString", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "Clear", MemberParameters = new object[] { typeof(ref MaskedTextResultHint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool Set(string input, out int testPosition, out MaskedTextResultHint resultHint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600188F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5396C", Offset = "0x1E5396C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "InsertAtInt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "RemoveAtInt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "SetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "TestSetChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "SetChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(MaskedTextProvider.CharDescriptor)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void SetChar(char input, int position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001890")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E54970", Offset = "0x1E54970", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "SetChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestEscapeChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(MaskedTextProvider.CharDescriptor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "ResetChar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsUpper", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Chars", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void SetChar(char input, int position, MaskedTextProvider.CharDescriptor charDescriptor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001891")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E539DC", Offset = "0x1E539DC", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "InsertAtInt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "TestSetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestEscapeChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(MaskedTextProvider.CharType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "SetChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void SetString(string input, int testPosition)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001892")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E534F4", Offset = "0x1E534F4", Length = "0x478")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "InsertAtInt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "RemoveAtInt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "TestSetChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "TestString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "VerifyChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "IsPrintableChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_SkipLiterals", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_ResetOnPrompt", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_AllowPromptAsInput", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_ResetOnSpace", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "IsAlphanumeric", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_AsciiOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private bool TestChar(char input, int position, out MaskedTextResultHint resultHint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001893")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E542F4", Offset = "0x1E542F4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "SetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "TestString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "VerifyEscapeChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestEscapeChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(MaskedTextProvider.CharDescriptor)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool TestEscapeChar(char input, int position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001894")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E54B00", Offset = "0x1E54B00", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "SetChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(MaskedTextProvider.CharDescriptor)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "TestEscapeChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_SkipLiterals", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_ResetOnPrompt", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_ResetOnSpace", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool TestEscapeChar(char input, int position, MaskedTextProvider.CharDescriptor charDex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001895")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E52824", Offset = "0x1E52824", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Add", MemberParameters = new object[]
		{
			typeof(char),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "SetChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(void))]
		private bool TestSetChar(char input, int position, out MaskedTextResultHint resultHint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001896")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5295C", Offset = "0x1E5295C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Set", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "SetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		private bool TestSetString(string input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001897")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5338C", Offset = "0x1E5338C", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "InsertAtInt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "TestSetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "VerifyString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "VerifyString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestEscapeChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(MaskedTextProvider.CharType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		private bool TestString(string input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001898")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E54BEC", Offset = "0x1E54BEC", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public string ToDisplayString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001899")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E54D50", Offset = "0x1E54D50", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_IncludePrompt", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_IncludeLiterals", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600189A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E55078", Offset = "0x1E55078", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_IncludePrompt", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_IncludeLiterals", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "ToString", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		public string ToString(bool ignorePasswordChar)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600189B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E550D8", Offset = "0x1E550D8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_IncludePrompt", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_IncludeLiterals", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "ToString", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		public string ToString(int startPosition, int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600189C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E55128", Offset = "0x1E55128", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_IncludePrompt", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "get_IncludeLiterals", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "ToString", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		public string ToString(bool ignorePasswordChar, int startPosition, int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600189D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5517C", Offset = "0x1E5517C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "ToString", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		public string ToString(bool includePrompt, bool includeLiterals)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600189E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E551C0", Offset = "0x1E551C0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "ToString", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		public string ToString(bool includePrompt, bool includeLiterals, int startPosition, int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600189F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E54DA4", Offset = "0x1E54DA4", Length = "0x2D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "ToString", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "ToString", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "ToString", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "ToString", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "ToString", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(MaskedTextProvider.CharType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "FindEditPositionInRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(byte)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public string ToString(bool ignorePasswordChar, bool includePrompt, bool includeLiterals, int startPosition, int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E551DC", Offset = "0x1E551DC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		public bool VerifyChar(char input, int position, out MaskedTextResultHint hint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E55254", Offset = "0x1E55254", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestEscapeChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(bool))]
		public bool VerifyEscapeChar(char input, int position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E552A8", Offset = "0x1E552A8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		public bool VerifyString(string input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E552E8", Offset = "0x1E552E8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskedTextProvider), Member = "TestString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(ref int),
			typeof(ref MaskedTextResultHint)
		}, ReturnType = typeof(bool))]
		public bool VerifyString(string input, out int testPosition, out MaskedTextResultHint resultHint)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60018A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E55318", Offset = "0x1E55318", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "CreateMask", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "CreateMask", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static MaskedTextProvider()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400125B")]
		private const char SPACE_CHAR = ' ';

		[global::Cpp2ILInjected.Token(Token = "0x400125C")]
		private const char DEFAULT_PROMPT_CHAR = '_';

		[global::Cpp2ILInjected.Token(Token = "0x400125D")]
		private const char NULL_PASSWORD_CHAR = '\0';

		[global::Cpp2ILInjected.Token(Token = "0x400125E")]
		private const bool DEFAULT_ALLOW_PROMPT = true;

		[global::Cpp2ILInjected.Token(Token = "0x400125F")]
		private const int INVALID_INDEX = -1;

		[global::Cpp2ILInjected.Token(Token = "0x4001260")]
		private const byte EDIT_ANY = 0;

		[global::Cpp2ILInjected.Token(Token = "0x4001261")]
		private const byte EDIT_UNASSIGNED = 1;

		[global::Cpp2ILInjected.Token(Token = "0x4001262")]
		private const byte EDIT_ASSIGNED = 2;

		[global::Cpp2ILInjected.Token(Token = "0x4001263")]
		private const bool FORWARD = true;

		[global::Cpp2ILInjected.Token(Token = "0x4001264")]
		private const bool BACKWARD = false;

		[global::Cpp2ILInjected.Token(Token = "0x4001265")]
		private static int s_ASCII_ONLY;

		[global::Cpp2ILInjected.Token(Token = "0x4001266")]
		private static int s_ALLOW_PROMPT_AS_INPUT;

		[global::Cpp2ILInjected.Token(Token = "0x4001267")]
		private static int s_INCLUDE_PROMPT;

		[global::Cpp2ILInjected.Token(Token = "0x4001268")]
		private static int s_INCLUDE_LITERALS;

		[global::Cpp2ILInjected.Token(Token = "0x4001269")]
		private static int s_RESET_ON_PROMPT;

		[global::Cpp2ILInjected.Token(Token = "0x400126A")]
		private static int s_RESET_ON_LITERALS;

		[global::Cpp2ILInjected.Token(Token = "0x400126B")]
		private static int s_SKIP_SPACE;

		[global::Cpp2ILInjected.Token(Token = "0x400126C")]
		private static Type s_maskTextProviderType;

		[global::Cpp2ILInjected.Token(Token = "0x400126D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private BitVector32 _flagState;

		[global::Cpp2ILInjected.Token(Token = "0x400126E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private StringBuilder _testString;

		[global::Cpp2ILInjected.Token(Token = "0x400126F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _requiredCharCount;

		[global::Cpp2ILInjected.Token(Token = "0x4001270")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int _requiredEditChars;

		[global::Cpp2ILInjected.Token(Token = "0x4001271")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _optionalEditChars;

		[global::Cpp2ILInjected.Token(Token = "0x4001272")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private char _passwordChar;

		[global::Cpp2ILInjected.Token(Token = "0x4001273")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E")]
		private char _promptChar;

		[global::Cpp2ILInjected.Token(Token = "0x4001274")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private List<MaskedTextProvider.CharDescriptor> _stringDescriptor;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001275")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int <AssignedEditPositionCount>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001276")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly CultureInfo <Culture>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001277")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private readonly string <Mask>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x20003A3")]
		private enum CaseConversion
		{
			[global::Cpp2ILInjected.Token(Token = "0x4001279")]
			None,
			[global::Cpp2ILInjected.Token(Token = "0x400127A")]
			ToLower,
			[global::Cpp2ILInjected.Token(Token = "0x400127B")]
			ToUpper
		}

		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x20003A4")]
		private enum CharType
		{
			[global::Cpp2ILInjected.Token(Token = "0x400127D")]
			EditOptional = 1,
			[global::Cpp2ILInjected.Token(Token = "0x400127E")]
			EditRequired = 2,
			[global::Cpp2ILInjected.Token(Token = "0x400127F")]
			Separator = 4,
			[global::Cpp2ILInjected.Token(Token = "0x4001280")]
			Literal = 8,
			[global::Cpp2ILInjected.Token(Token = "0x4001281")]
			Modifier = 16
		}

		[global::Cpp2ILInjected.Token(Token = "0x20003A5")]
		private class CharDescriptor
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E51468", Offset = "0x1E51468", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public CharDescriptor(int maskPos, MaskedTextProvider.CharType charType)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60018A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5543C", Offset = "0x1E5543C", Length = "0x1E8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(IFormatProvider),
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			public override string ToString()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001282")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int MaskPosition;

			[global::Cpp2ILInjected.Token(Token = "0x4001283")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public MaskedTextProvider.CaseConversion CaseConversion;

			[global::Cpp2ILInjected.Token(Token = "0x4001284")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public MaskedTextProvider.CharType CharType;

			[global::Cpp2ILInjected.Token(Token = "0x4001285")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public bool IsAssigned;
		}
	}
}
