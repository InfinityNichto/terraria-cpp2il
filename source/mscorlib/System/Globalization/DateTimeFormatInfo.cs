using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004AA RID: 1194
	[global::Cpp2ILInjected.Token(Token = "0x2000588")]
	[global::System.Serializable]
	public sealed class DateTimeFormatInfo : global::System.IFormatProvider, global::System.ICloneable
	{
		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x0001B302 File Offset: 0x00019502
		[global::Cpp2ILInjected.Token(Token = "0x17000620")]
		private string CultureName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AA8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD9B70", Offset = "0x1BD9B70", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06002779 RID: 10105 RVA: 0x0001B305 File Offset: 0x00019505
		[global::Cpp2ILInjected.Token(Token = "0x17000621")]
		private CultureInfo Culture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AA9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD9B90", Offset = "0x1BD9B90", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new object[]
			{
				typeof(global::System.TokenType),
				typeof(ref global::System.TokenType),
				typeof(ref int),
				typeof(ref global::System.__DTString)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InsertAtCurrentHashNode", MemberParameters = new object[]
			{
				typeof(DateTimeFormatInfo.TokenHashValue[]),
				typeof(string),
				typeof(char),
				typeof(global::System.TokenType),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new object[]
			{
				typeof(DateTimeFormatInfo.TokenHashValue[]),
				typeof(string),
				typeof(global::System.TokenType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CompareStringIgnoreCaseOptimized", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(int),
				typeof(string),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x0001B308 File Offset: 0x00019508
		[global::Cpp2ILInjected.Token(Token = "0x17000622")]
		private string LanguageName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AAA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD9C0C", Offset = "0x1BD9C0C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x0001B30B File Offset: 0x0001950B
		[global::Cpp2ILInjected.Token(Token = "0x6002AAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD9C2C", Offset = "0x1BD9C2C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private string[] internalGetAbbreviatedDayOfWeekNames()
		{
			throw null;
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x0001B30E File Offset: 0x0001950E
		[global::Cpp2ILInjected.Token(Token = "0x6002AAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD9C40", Offset = "0x1BD9C40", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedDayNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedDayName", MemberParameters = new object[] { typeof(global::System.DayOfWeek) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "AbbreviatedDayNames", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[MethodImpl(8)]
		private string[] internalGetAbbreviatedDayOfWeekNamesCore()
		{
			throw null;
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x0001B311 File Offset: 0x00019511
		[global::Cpp2ILInjected.Token(Token = "0x6002AAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD9C80", Offset = "0x1BD9C80", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private string[] internalGetDayOfWeekNames()
		{
			throw null;
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x0001B314 File Offset: 0x00019514
		[global::Cpp2ILInjected.Token(Token = "0x6002AAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD9C94", Offset = "0x1BD9C94", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_DayNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetDayName", MemberParameters = new object[] { typeof(global::System.DayOfWeek) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "DayNames", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[MethodImpl(8)]
		private string[] internalGetDayOfWeekNamesCore()
		{
			throw null;
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x0001B317 File Offset: 0x00019517
		[global::Cpp2ILInjected.Token(Token = "0x6002AAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD9CD4", Offset = "0x1BD9CD4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private string[] internalGetAbbreviatedMonthNames()
		{
			throw null;
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x0001B31A File Offset: 0x0001951A
		[global::Cpp2ILInjected.Token(Token = "0x6002AB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD9CE8", Offset = "0x1BD9CE8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedMonthNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthName", MemberParameters = new object[]
		{
			typeof(int),
			typeof(MonthNameStyles),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedMonthName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "AbbreviatedMonthNames", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[MethodImpl(8)]
		private string[] internalGetAbbreviatedMonthNamesCore()
		{
			throw null;
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x0001B31D File Offset: 0x0001951D
		[global::Cpp2ILInjected.Token(Token = "0x6002AB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD9D28", Offset = "0x1BD9D28", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private string[] internalGetMonthNames()
		{
			throw null;
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x0001B320 File Offset: 0x00019520
		[global::Cpp2ILInjected.Token(Token = "0x6002AB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD9D3C", Offset = "0x1BD9D3C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_MonthNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthName", MemberParameters = new object[]
		{
			typeof(int),
			typeof(MonthNameStyles),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetMonthName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "MonthNames", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[MethodImpl(8)]
		private string[] internalGetMonthNamesCore()
		{
			throw null;
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x0001B323 File Offset: 0x00019523
		[global::Cpp2ILInjected.Token(Token = "0x6002AB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD9D7C", Offset = "0x1BD9D7C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "get_DateTimeFormat", ReturnType = typeof(DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpProtocolUtils", Member = "date2string", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GregorianCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public DateTimeFormatInfo()
		{
			throw null;
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x0001B326 File Offset: 0x00019526
		[global::Cpp2ILInjected.Token(Token = "0x6002AB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD9F38", Offset = "0x1BD9F38", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "get_DateTimeFormat", ReturnType = typeof(DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal DateTimeFormatInfo(CultureData cultureData, Calendar cal)
		{
			throw null;
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x0001B329 File Offset: 0x00019529
		[global::Cpp2ILInjected.Token(Token = "0x6002AB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD9E44", Offset = "0x1BD9E44", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new object[] { typeof(Calendar) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "DateSeparator", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "get_LongTimes", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "get_ShortTimes", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "LongDates", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "ShortDates", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "YearMonths", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		private void InitializeOverridableProperties(CultureData cultureData, int calendarId)
		{
			throw null;
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06002786 RID: 10118 RVA: 0x0001B32C File Offset: 0x0001952C
		[global::Cpp2ILInjected.Token(Token = "0x17000623")]
		public static DateTimeFormatInfo InvariantInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AB6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDA208", Offset = "0x1BDA208", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(ref global::System.DateTime),
				typeof(ref DateTimeFormatInfo),
				typeof(ref global::System.TimeSpan)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatStringBuilder", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo),
				typeof(global::System.TimeSpan)
			}, ReturnType = typeof(global::System.Text.StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(ref DateTimeFormatInfo),
				typeof(ref global::System.ParsingInfo),
				typeof(ref global::System.DateTimeResult)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(DateTimeFormatInfo.TokenHashValue[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06002787 RID: 10119 RVA: 0x0001B32F File Offset: 0x0001952F
		[global::Cpp2ILInjected.Token(Token = "0x17000624")]
		public static DateTimeFormatInfo CurrentInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AB7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDA2CC", Offset = "0x1BDA2CC", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIMultiplayerHost", Member = "WorldDraw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIWorldSelectMenu", Member = "WorldDraw", MemberParameters = new object[]
			{
				"ItemGrid_Layout",
				typeof(int),
				"Microsoft.Xna.Framework.Vector2",
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUISaveSynchronisation_FileList", Member = "WorldDraw", MemberParameters = new object[]
			{
				"ItemGrid_Layout",
				typeof(int),
				"Microsoft.Xna.Framework.Vector2",
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetInstance", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(DateTimeFormatInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x0001B332 File Offset: 0x00019532
		[global::Cpp2ILInjected.Token(Token = "0x6002AB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDA3D0", Offset = "0x1BDA3D0", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(global::System.IFormatProvider),
			typeof(DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(DateTimeStyles),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(DateTimeStyles),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(DateTimeStyles),
			typeof(ref global::System.DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(DateTimeStyles),
			typeof(ref global::System.DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "TryFormat", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
			typeof(global::System.IFormatProvider),
			typeof(ref TimeSpanParse.TimeSpanResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static DateTimeFormatInfo GetInstance(global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x0001B335 File Offset: 0x00019535
		[global::Cpp2ILInjected.Token(Token = "0x6002AB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDA590", Offset = "0x1BDA590", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public object GetFormat(global::System.Type formatType)
		{
			throw null;
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x0001B338 File Offset: 0x00019538
		[global::Cpp2ILInjected.Token(Token = "0x6002ABA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDA628", Offset = "0x1BDA628", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref global::System.DateTime),
			typeof(ref DateTimeFormatInfo),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref DateTimeFormatInfo),
			typeof(ref global::System.ParsingInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader.<>c", Member = "<ReadTime>b__51_0", ReturnType = typeof(DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public object Clone()
		{
			throw null;
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x0600278B RID: 10123 RVA: 0x0001B33B File Offset: 0x0001953B
		[global::Cpp2ILInjected.Token(Token = "0x17000625")]
		public string AMDesignator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002ABB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDA71C", Offset = "0x1BDA71C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomized", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo),
				typeof(global::System.TimeSpan),
				typeof(global::System.Text.StringBuilder)
			}, ReturnType = typeof(global::System.Text.StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "AdjustTimeMark", MemberParameters = new object[]
			{
				typeof(DateTimeFormatInfo),
				typeof(ref global::System.DateTimeRawInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchTimeMark", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(DateTimeFormatInfo),
				typeof(ref global::System.DateTimeParse.TM)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedTimeMark", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(DateTimeFormatInfo),
				typeof(ref global::System.DateTimeParse.TM)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x0600278C RID: 10124 RVA: 0x0001B33E File Offset: 0x0001953E
		// (set) Token: 0x0600278D RID: 10125 RVA: 0x0001B341 File Offset: 0x00019541
		[global::Cpp2ILInjected.Token(Token = "0x17000626")]
		public Calendar Calendar
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002ABC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDA73C", Offset = "0x1BDA73C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002ABD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BD9F7C", Offset = "0x1BD9F7C", Length = "0x28C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "ExpandPredefinedFormat", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(ref global::System.DateTime),
				typeof(ref DateTimeFormatInfo),
				typeof(ref global::System.TimeSpan)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ExpandPredefinedFormat", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(ref DateTimeFormatInfo),
				typeof(ref global::System.ParsingInfo),
				typeof(ref global::System.DateTimeResult)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetJapaneseCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetTaiwanCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_IsReadOnly", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCalendarIds", ReturnType = typeof(CalendarId[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeOverridableProperties", MemberParameters = new object[]
			{
				typeof(CultureData),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x0600278E RID: 10126 RVA: 0x0001B344 File Offset: 0x00019544
		[global::Cpp2ILInjected.Token(Token = "0x17000627")]
		private CalendarId[] OptionalCalendars
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002ABE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDA7E8", Offset = "0x1BDA7E8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCalendarIds", ReturnType = typeof(CalendarId[]))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x0001B347 File Offset: 0x00019547
		[global::Cpp2ILInjected.Token(Token = "0x17000628")]
		internal string[] EraNames
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002ABF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDA820", Offset = "0x1BDA820", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetEraName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "EraNames", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x0001B34A File Offset: 0x0001954A
		[global::Cpp2ILInjected.Token(Token = "0x6002AC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDA868", Offset = "0x1BDA868", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomized", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(DateTimeFormatInfo),
			typeof(global::System.TimeSpan),
			typeof(global::System.Text.StringBuilder)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchEraName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedEraName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(DateTimeFormatInfo.TokenHashValue[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_EraNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public string GetEraName(int era)
		{
			throw null;
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x0001B34D File Offset: 0x0001954D
		[global::Cpp2ILInjected.Token(Token = "0x17000629")]
		internal string[] AbbreviatedEraNames
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AC1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDA91C", Offset = "0x1BDA91C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedEraName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "AbbrevEraNames", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x0001B350 File Offset: 0x00019550
		[global::Cpp2ILInjected.Token(Token = "0x6002AC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDA964", Offset = "0x1BDA964", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchEraName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(DateTimeFormatInfo.TokenHashValue[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedEraNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetEraName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public string GetAbbreviatedEraName(int era)
		{
			throw null;
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06002793 RID: 10131 RVA: 0x0001B353 File Offset: 0x00019553
		[global::Cpp2ILInjected.Token(Token = "0x1700062A")]
		internal string[] AbbreviatedEnglishEraNames
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AC3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDAA34", Offset = "0x1BDAA34", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(DateTimeFormatInfo.TokenHashValue[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new object[]
			{
				typeof(DateTimeFormatInfo.TokenHashValue[]),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "AbbreviatedEnglishEraNames", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06002794 RID: 10132 RVA: 0x0001B356 File Offset: 0x00019556
		[global::Cpp2ILInjected.Token(Token = "0x1700062B")]
		public string DateSeparator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AC4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDAA7C", Offset = "0x1BDAA7C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomized", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo),
				typeof(global::System.TimeSpan),
				typeof(global::System.Text.StringBuilder)
			}, ReturnType = typeof(global::System.Text.StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo),
				typeof(DateTimeStyles),
				typeof(ref global::System.DateTimeResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(ref global::System.__DTString),
				typeof(ref global::System.ParsingInfo),
				typeof(DateTimeFormatInfo),
				typeof(ref global::System.DateTimeResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(DateTimeFormatInfo.TokenHashValue[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new object[]
			{
				typeof(DateTimeFormatInfo.TokenHashValue[]),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MaskedTextProvider", Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "DateSeparator", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x0001B359 File Offset: 0x00019559
		[global::Cpp2ILInjected.Token(Token = "0x1700062C")]
		public string FullDateTimePattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AC5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDAAC4", Offset = "0x1BDAAC4", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "GetRealFormat", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedLongDatePatterns", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06002796 RID: 10134 RVA: 0x0001B35C File Offset: 0x0001955C
		[global::Cpp2ILInjected.Token(Token = "0x1700062D")]
		public string LongDatePattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AC6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDAB44", Offset = "0x1BDAB44", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "GetRealFormat", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedLongDatePatterns", ReturnType = typeof(string[]))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06002797 RID: 10135 RVA: 0x0001B35F File Offset: 0x0001955F
		[global::Cpp2ILInjected.Token(Token = "0x1700062E")]
		public string LongTimePattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AC7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDAB6C", Offset = "0x1BDAB6C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "GetRealFormat", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullDateTimePattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralLongTimePattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_DateTimeOffsetPattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongTimePatterns", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "get_LongTimes", ReturnType = typeof(string[]))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06002798 RID: 10136 RVA: 0x0001B362 File Offset: 0x00019562
		[global::Cpp2ILInjected.Token(Token = "0x1700062F")]
		public string MonthDayPattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AC8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDAC14", Offset = "0x1BDAC14", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "GetRealFormat", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNN", MemberParameters = new object[]
			{
				typeof(ref global::System.DateTimeResult),
				typeof(ref DateTimeStyles),
				typeof(ref global::System.DateTimeRawInfo),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfMN", MemberParameters = new object[]
			{
				typeof(ref global::System.DateTimeResult),
				typeof(ref DateTimeStyles),
				typeof(ref global::System.DateTimeRawInfo),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetHebrewDayOfNM", MemberParameters = new object[]
			{
				typeof(ref global::System.DateTimeResult),
				typeof(ref global::System.DateTimeRawInfo),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNM", MemberParameters = new object[]
			{
				typeof(ref global::System.DateTimeResult),
				typeof(ref DateTimeStyles),
				typeof(ref global::System.DateTimeRawInfo),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "GetDateWordsOfDTFI", MemberParameters = new object[] { typeof(DateTimeFormatInfo) }, ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "MonthDay", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06002799 RID: 10137 RVA: 0x0001B365 File Offset: 0x00019565
		[global::Cpp2ILInjected.Token(Token = "0x17000630")]
		public string PMDesignator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AC9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDAC5C", Offset = "0x1BDAC5C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomized", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo),
				typeof(global::System.TimeSpan),
				typeof(global::System.Text.StringBuilder)
			}, ReturnType = typeof(global::System.Text.StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "AdjustTimeMark", MemberParameters = new object[]
			{
				typeof(DateTimeFormatInfo),
				typeof(ref global::System.DateTimeRawInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchTimeMark", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(DateTimeFormatInfo),
				typeof(ref global::System.DateTimeParse.TM)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedTimeMark", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(DateTimeFormatInfo),
				typeof(ref global::System.DateTimeParse.TM)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x0600279A RID: 10138 RVA: 0x0001B368 File Offset: 0x00019568
		[global::Cpp2ILInjected.Token(Token = "0x17000631")]
		public string RFC1123Pattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002ACA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDAC7C", Offset = "0x1BDAC7C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "GetRealFormat", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x0600279B RID: 10139 RVA: 0x0001B36B File Offset: 0x0001956B
		[global::Cpp2ILInjected.Token(Token = "0x17000632")]
		public string ShortDatePattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002ACB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDACBC", Offset = "0x1BDACBC", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "GetRealFormat", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNNN", MemberParameters = new object[]
			{
				typeof(ref global::System.DateTimeResult),
				typeof(ref global::System.DateTimeRawInfo),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfMNN", MemberParameters = new object[]
			{
				typeof(ref global::System.DateTimeResult),
				typeof(ref global::System.DateTimeRawInfo),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfYNN", MemberParameters = new object[]
			{
				typeof(ref global::System.DateTimeResult),
				typeof(ref global::System.DateTimeRawInfo),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNNY", MemberParameters = new object[]
			{
				typeof(ref global::System.DateTimeResult),
				typeof(ref global::System.DateTimeRawInfo),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDateOfNNDS", MemberParameters = new object[]
			{
				typeof(ref global::System.DateTimeResult),
				typeof(ref global::System.DateTimeRawInfo),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new object[]
			{
				"System.ComponentModel.ITypeDescriptorContext",
				typeof(CultureInfo),
				typeof(object),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new object[]
			{
				"System.ComponentModel.ITypeDescriptorContext",
				typeof(CultureInfo),
				typeof(object),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(string[]))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x0600279C RID: 10140 RVA: 0x0001B36E File Offset: 0x0001956E
		[global::Cpp2ILInjected.Token(Token = "0x17000633")]
		public string ShortTimePattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002ACC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDAD2C", Offset = "0x1BDAD2C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "GetRealFormat", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralShortTimePattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortTimePatterns", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeConverter", Member = "ConvertTo", MemberParameters = new object[]
			{
				"System.ComponentModel.ITypeDescriptorContext",
				typeof(CultureInfo),
				typeof(object),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new object[]
			{
				"System.ComponentModel.ITypeDescriptorContext",
				typeof(CultureInfo),
				typeof(object),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "get_ShortTimes", ReturnType = typeof(string[]))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x0600279D RID: 10141 RVA: 0x0001B371 File Offset: 0x00019571
		[global::Cpp2ILInjected.Token(Token = "0x17000634")]
		public string SortableDateTimePattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002ACD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDAD8C", Offset = "0x1BDAD8C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "GetRealFormat", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x0600279E RID: 10142 RVA: 0x0001B374 File Offset: 0x00019574
		[global::Cpp2ILInjected.Token(Token = "0x17000635")]
		internal string GeneralShortTimePattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002ACE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDADCC", Offset = "0x1BDADCC", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "GetRealFormat", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_ShortTimePattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x0600279F RID: 10143 RVA: 0x0001B377 File Offset: 0x00019577
		[global::Cpp2ILInjected.Token(Token = "0x17000636")]
		internal string GeneralLongTimePattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002ACF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDAE4C", Offset = "0x1BDAE4C", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "GetRealFormat", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060027A0 RID: 10144 RVA: 0x0001B37A File Offset: 0x0001957A
		[global::Cpp2ILInjected.Token(Token = "0x17000637")]
		internal string DateTimeOffsetPattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AD0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDAECC", Offset = "0x1BDAECC", Length = "0x17C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatStringBuilder", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo),
				typeof(global::System.TimeSpan)
			}, ReturnType = typeof(global::System.Text.StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060027A1 RID: 10145 RVA: 0x0001B37D File Offset: 0x0001957D
		[global::Cpp2ILInjected.Token(Token = "0x17000638")]
		public string TimeSeparator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AD1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDB048", Offset = "0x1BDB048", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomized", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo),
				typeof(global::System.TimeSpan),
				typeof(global::System.Text.StringBuilder)
			}, ReturnType = typeof(global::System.Text.StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo),
				typeof(DateTimeStyles),
				typeof(ref global::System.DateTimeResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(ref global::System.__DTString),
				typeof(ref global::System.ParsingInfo),
				typeof(DateTimeFormatInfo),
				typeof(ref global::System.DateTimeResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MaskedTextProvider", Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x0001B380 File Offset: 0x00019580
		[global::Cpp2ILInjected.Token(Token = "0x17000639")]
		public string UniversalSortableDateTimePattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AD2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDB068", Offset = "0x1BDB068", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "GetRealFormat", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060027A3 RID: 10147 RVA: 0x0001B383 File Offset: 0x00019583
		[global::Cpp2ILInjected.Token(Token = "0x1700063A")]
		public string YearMonthPattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AD3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDB0A8", Offset = "0x1BDB0A8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "GetRealFormat", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfMN", MemberParameters = new object[]
			{
				typeof(ref global::System.DateTimeResult),
				typeof(ref DateTimeStyles),
				typeof(ref global::System.DateTimeRawInfo),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "GetDayOfNM", MemberParameters = new object[]
			{
				typeof(ref global::System.DateTimeResult),
				typeof(ref DateTimeStyles),
				typeof(ref global::System.DateTimeRawInfo),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedYearMonthPatterns", ReturnType = typeof(string[]))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060027A4 RID: 10148 RVA: 0x0001B386 File Offset: 0x00019586
		[global::Cpp2ILInjected.Token(Token = "0x1700063B")]
		public string[] AbbreviatedDayNames
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AD4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDB118", Offset = "0x1BDB118", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedDayOfWeekNamesCore", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060027A5 RID: 10149 RVA: 0x0001B389 File Offset: 0x00019589
		[global::Cpp2ILInjected.Token(Token = "0x1700063C")]
		public string[] DayNames
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AD5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDB194", Offset = "0x1BDB194", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetDayOfWeekNamesCore", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060027A6 RID: 10150 RVA: 0x0001B38C File Offset: 0x0001958C
		[global::Cpp2ILInjected.Token(Token = "0x1700063D")]
		public string[] AbbreviatedMonthNames
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AD6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDB210", Offset = "0x1BDB210", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedMonthNamesCore", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060027A7 RID: 10151 RVA: 0x0001B38F File Offset: 0x0001958F
		[global::Cpp2ILInjected.Token(Token = "0x1700063E")]
		public string[] MonthNames
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AD7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDB28C", Offset = "0x1BDB28C", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthNamesCore", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060027A8 RID: 10152 RVA: 0x0001B392 File Offset: 0x00019592
		[global::Cpp2ILInjected.Token(Token = "0x1700063F")]
		internal bool HasSpacesInMonthNames
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AD8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDB308", Offset = "0x1BDB308", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(DateTimeFormatInfo),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchMonthName", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(DateTimeFormatInfo),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060027A9 RID: 10153 RVA: 0x0001B395 File Offset: 0x00019595
		[global::Cpp2ILInjected.Token(Token = "0x17000640")]
		internal bool HasSpacesInDayNames
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AD9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDB348", Offset = "0x1BDB348", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedDayName", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(DateTimeFormatInfo),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchDayName", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(DateTimeFormatInfo),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x0001B398 File Offset: 0x00019598
		[global::Cpp2ILInjected.Token(Token = "0x6002ADA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDB370", Offset = "0x1BDB370", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatHebrewMonthName", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(int),
			typeof(DateTimeFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomized", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(DateTimeFormatInfo),
			typeof(global::System.TimeSpan),
			typeof(global::System.Text.StringBuilder)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(DateTimeFormatInfo.TokenHashValue[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetGenitiveMonthNames", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetLeapYearMonthNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedMonthNamesCore", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthNamesCore", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated)
		{
			throw null;
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x0001B39B File Offset: 0x0001959B
		[global::Cpp2ILInjected.Token(Token = "0x6002ADB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDB4B4", Offset = "0x1BDB4B4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthName", MemberParameters = new object[]
		{
			typeof(int),
			typeof(MonthNameStyles),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_MonthGenitiveNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "AbbreviatedGenitiveMonthNames", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GenitiveMonthNames", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		private string[] internalGetGenitiveMonthNames(bool abbreviated)
		{
			throw null;
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x0001B39E File Offset: 0x0001959E
		[global::Cpp2ILInjected.Token(Token = "0x6002ADC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDB534", Offset = "0x1BDB534", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchMonthName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthName", MemberParameters = new object[]
		{
			typeof(int),
			typeof(MonthNameStyles),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "LeapYearMonthNames", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
		internal string[] internalGetLeapYearMonthNames()
		{
			throw null;
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x0001B3A1 File Offset: 0x000195A1
		[global::Cpp2ILInjected.Token(Token = "0x6002ADD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDB57C", Offset = "0x1BDB57C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatDayOfWeek", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(DateTimeFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedDayName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(DateTimeFormatInfo.TokenHashValue[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedDayOfWeekNamesCore", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public string GetAbbreviatedDayName(global::System.DayOfWeek dayofweek)
		{
			throw null;
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x0001B3A4 File Offset: 0x000195A4
		[global::Cpp2ILInjected.Token(Token = "0x6002ADE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDB65C", Offset = "0x1BDB65C", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString)
		{
			throw null;
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x0001B3A7 File Offset: 0x000195A7
		[global::Cpp2ILInjected.Token(Token = "0x6002ADF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDB780", Offset = "0x1BDB780", Length = "0x340")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "GetDateWordsOfDTFI", MemberParameters = new object[] { typeof(DateTimeFormatInfo) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongDatePatterns", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_MonthDayPattern", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortDatePatterns", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongTimePatterns", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AllYearMonthPatterns", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortTimePatterns", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetCombinedPatterns", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(string[]),
			typeof(string)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public string[] GetAllDateTimePatterns(char format)
		{
			throw null;
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x0001B3AA File Offset: 0x000195AA
		[global::Cpp2ILInjected.Token(Token = "0x6002AE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDBD54", Offset = "0x1BDBD54", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatDayOfWeek", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(DateTimeFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchDayName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(DateTimeFormatInfo.TokenHashValue[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetDayOfWeekNamesCore", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public string GetDayName(global::System.DayOfWeek dayofweek)
		{
			throw null;
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x0001B3AD File Offset: 0x000195AD
		[global::Cpp2ILInjected.Token(Token = "0x6002AE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDBE34", Offset = "0x1BDBE34", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatMonth", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(DateTimeFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatHebrewMonthName", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(int),
			typeof(DateTimeFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(DateTimeFormatInfo.TokenHashValue[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "AddMonthNames", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetAbbreviatedMonthNamesCore", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public string GetAbbreviatedMonthName(int month)
		{
			throw null;
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x0001B3B0 File Offset: 0x000195B0
		[global::Cpp2ILInjected.Token(Token = "0x6002AE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDBF18", Offset = "0x1BDBF18", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatMonth", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(DateTimeFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatHebrewMonthName", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(int),
			typeof(DateTimeFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchMonthName", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(DateTimeFormatInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(DateTimeFormatInfo.TokenHashValue[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "AddMonthNames", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthNamesCore", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public string GetMonthName(int month)
		{
			throw null;
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x0001B3B3 File Offset: 0x000195B3
		[global::Cpp2ILInjected.Token(Token = "0x6002AE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDBFFC", Offset = "0x1BDBFFC", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllYearMonthPatterns", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortDatePatterns", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortTimePatterns", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongDatePatterns", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongTimePatterns", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static string[] GetMergedPatterns(string[] patterns, string defaultPattern)
		{
			throw null;
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060027B4 RID: 10164 RVA: 0x0001B3B6 File Offset: 0x000195B6
		[global::Cpp2ILInjected.Token(Token = "0x17000641")]
		private string[] AllYearMonthPatterns
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AE4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDBCD0", Offset = "0x1BDBCD0", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedYearMonthPatterns", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new object[]
			{
				typeof(string[]),
				typeof(string)
			}, ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060027B5 RID: 10165 RVA: 0x0001B3B9 File Offset: 0x000195B9
		[global::Cpp2ILInjected.Token(Token = "0x17000642")]
		private string[] AllShortDatePatterns
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AE5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDBAC0", Offset = "0x1BDBAC0", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedShortDatePatterns", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new object[]
			{
				typeof(string[]),
				typeof(string)
			}, ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060027B6 RID: 10166 RVA: 0x0001B3BC File Offset: 0x000195BC
		[global::Cpp2ILInjected.Token(Token = "0x17000643")]
		private string[] AllShortTimePatterns
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AE6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDBBC8", Offset = "0x1BDBBC8", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "get_ShortTimes", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_ShortTimePattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new object[]
			{
				typeof(string[]),
				typeof(string)
			}, ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060027B7 RID: 10167 RVA: 0x0001B3BF File Offset: 0x000195BF
		[global::Cpp2ILInjected.Token(Token = "0x17000644")]
		private string[] AllLongDatePatterns
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AE7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDBB44", Offset = "0x1BDBB44", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_UnclonedLongDatePatterns", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new object[]
			{
				typeof(string[]),
				typeof(string)
			}, ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060027B8 RID: 10168 RVA: 0x0001B3C2 File Offset: 0x000195C2
		[global::Cpp2ILInjected.Token(Token = "0x17000645")]
		private string[] AllLongTimePatterns
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AE8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDBC4C", Offset = "0x1BDBC4C", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "get_LongTimes", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_LongTimePattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMergedPatterns", MemberParameters = new object[]
			{
				typeof(string[]),
				typeof(string)
			}, ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060027B9 RID: 10169 RVA: 0x0001B3C5 File Offset: 0x000195C5
		[global::Cpp2ILInjected.Token(Token = "0x17000646")]
		private string[] UnclonedYearMonthPatterns
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AE9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDB0D0", Offset = "0x1BDB0D0", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_YearMonthPattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllYearMonthPatterns", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "YearMonths", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x0001B3C8 File Offset: 0x000195C8
		[global::Cpp2ILInjected.Token(Token = "0x17000647")]
		private string[] UnclonedShortDatePatterns
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AEA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDACE4", Offset = "0x1BDACE4", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_ShortDatePattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralShortTimePattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_GeneralLongTimePattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_DateTimeOffsetPattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllShortDatePatterns", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "ShortDates", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060027BB RID: 10171 RVA: 0x0001B3CB File Offset: 0x000195CB
		[global::Cpp2ILInjected.Token(Token = "0x17000648")]
		private string[] UnclonedLongDatePatterns
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AEB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDABA4", Offset = "0x1BDABA4", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullDateTimePattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_LongDatePattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_AllLongDatePatterns", ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "LongDates", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string[]))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060027BC RID: 10172 RVA: 0x0001B3CE File Offset: 0x000195CE
		[global::Cpp2ILInjected.Token(Token = "0x17000649")]
		private string[] UnclonedShortTimePatterns
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AEC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDAD64", Offset = "0x1BDAD64", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "get_ShortTimes", ReturnType = typeof(string[]))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060027BD RID: 10173 RVA: 0x0001B3D1 File Offset: 0x000195D1
		[global::Cpp2ILInjected.Token(Token = "0x1700064A")]
		private string[] UnclonedLongTimePatterns
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDABEC", Offset = "0x1BDABEC", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "get_LongTimes", ReturnType = typeof(string[]))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x0001B3D4 File Offset: 0x000195D4
		[global::Cpp2ILInjected.Token(Token = "0x6002AEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDC198", Offset = "0x1BDC198", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultureInfo), Member = "ReadOnly", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_IsReadOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Calendar), Member = "ReadOnly", MemberParameters = new object[] { typeof(Calendar) }, ReturnType = typeof(Calendar))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static DateTimeFormatInfo ReadOnly(DateTimeFormatInfo dtfi)
		{
			throw null;
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060027BF RID: 10175 RVA: 0x0001B3D7 File Offset: 0x000195D7
		[global::Cpp2ILInjected.Token(Token = "0x1700064B")]
		public bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AEF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDA744", Offset = "0x1BDA744", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new object[] { typeof(Calendar) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "ReadOnly", MemberParameters = new object[] { typeof(DateTimeFormatInfo) }, ReturnType = typeof(DateTimeFormatInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x060027C0 RID: 10176 RVA: 0x0001B3DA File Offset: 0x000195DA
		[global::Cpp2ILInjected.Token(Token = "0x1700064C")]
		public string[] MonthGenitiveNames
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AF0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDC290", Offset = "0x1BDC290", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchMonthName", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(DateTimeFormatInfo),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetGenitiveMonthNames", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060027C1 RID: 10177 RVA: 0x0001B3DD File Offset: 0x000195DD
		[global::Cpp2ILInjected.Token(Token = "0x1700064D")]
		internal string FullTimeSpanPositivePattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AF1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDC308", Offset = "0x1BDC308", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanNegativePattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new object[]
			{
				typeof(global::System.TimeSpan),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(global::System.IFormatProvider)
			}, ReturnType = typeof(global::System.Text.StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.TimeSpanParse.TimeSpanRawInfo", Member = "Init", MemberParameters = new object[] { typeof(DateTimeFormatInfo) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(global::System.IFormatProvider),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(CultureData))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new object[] { typeof(CultureData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060027C2 RID: 10178 RVA: 0x0001B3E0 File Offset: 0x000195E0
		[global::Cpp2ILInjected.Token(Token = "0x1700064E")]
		internal string FullTimeSpanNegativePattern
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AF2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDC3D0", Offset = "0x1BDC3D0", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanFormat), Member = "FormatToBuilder", MemberParameters = new object[]
			{
				typeof(global::System.TimeSpan),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(global::System.IFormatProvider)
			}, ReturnType = typeof(global::System.Text.StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.TimeSpanParse.TimeSpanRawInfo", Member = "Init", MemberParameters = new object[] { typeof(DateTimeFormatInfo) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TimeSpanParse), Member = "TryParseTimeSpan", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				"System.Globalization.TimeSpanParse.TimeSpanStandardStyles",
				typeof(global::System.IFormatProvider),
				typeof(ref TimeSpanParse.TimeSpanResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanPositivePattern", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060027C3 RID: 10179 RVA: 0x0001B3E3 File Offset: 0x000195E3
		[global::Cpp2ILInjected.Token(Token = "0x1700064F")]
		internal CompareInfo CompareInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AF3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDC438", Offset = "0x1BDC438", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.__DTString), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureData), Member = "get_SCOMPAREINFO", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "GetCompareInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CompareInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x0001B3E6 File Offset: 0x000195E6
		[global::Cpp2ILInjected.Token(Token = "0x6002AF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDC4B0", Offset = "0x1BDC4B0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(global::System.IFormatProvider),
			typeof(DateTimeStyles)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(DateTimeStyles),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(DateTimeStyles),
			typeof(ref global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static void ValidateStyles(DateTimeStyles style, string parameterName)
		{
			throw null;
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x060027C5 RID: 10181 RVA: 0x0001B3E9 File Offset: 0x000195E9
		[global::Cpp2ILInjected.Token(Token = "0x17000650")]
		internal DateTimeFormatFlags FormatFlags
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AF5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDB330", Offset = "0x1BDB330", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomized", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo),
				typeof(global::System.TimeSpan),
				typeof(global::System.Text.StringBuilder)
			}, ReturnType = typeof(global::System.Text.StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "TryParse", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo),
				typeof(DateTimeStyles),
				typeof(ref global::System.DateTimeResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchAbbreviatedMonthName", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(DateTimeFormatInfo),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchMonthName", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(DateTimeFormatInfo),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DoStrictParse", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeStyles),
				typeof(DateTimeFormatInfo),
				typeof(ref global::System.DateTimeResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.__DTString), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x0001B3EC File Offset: 0x000195EC
		[global::Cpp2ILInjected.Token(Token = "0x6002AF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDC57C", Offset = "0x1BDC57C", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_HasSpacesInMonthNames", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_HasSpacesInDayNames", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_HasYearMonthAdjustment", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "YearMonthAdjustment", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(DateTimeFormatInfo.TokenHashValue[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new object[]
		{
			typeof(global::System.TokenType),
			typeof(ref global::System.TokenType),
			typeof(ref int),
			typeof(ref global::System.__DTString)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_MonthNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetGenitiveMonthNames", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedMonthNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "GetFormatFlagGenitiveMonth", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(string[]),
			typeof(string[]),
			typeof(string[])
		}, ReturnType = typeof(FORMATFLAGS))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "GetFormatFlagUseSpaceInMonthNames", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(string[]),
			typeof(string[]),
			typeof(string[])
		}, ReturnType = typeof(FORMATFLAGS))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_DayNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedDayNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "GetFormatFlagUseSpaceInDayNames", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(string[])
		}, ReturnType = typeof(FORMATFLAGS))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "GetFormatFlagUseHebrewCalendar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(FORMATFLAGS))]
		[MethodImpl(8)]
		private DateTimeFormatFlags InitializeFormatFlags()
		{
			throw null;
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x060027C7 RID: 10183 RVA: 0x0001B3EF File Offset: 0x000195EF
		[global::Cpp2ILInjected.Token(Token = "0x17000651")]
		internal bool HasForceTwoDigitYears
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AF7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDC68C", Offset = "0x1BDC68C", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomized", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeFormatInfo),
				typeof(global::System.TimeSpan),
				typeof(global::System.Text.StringBuilder)
			}, ReturnType = typeof(global::System.Text.StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ParseByFormat", MemberParameters = new object[]
			{
				typeof(ref global::System.__DTString),
				typeof(ref global::System.__DTString),
				typeof(ref global::System.ParsingInfo),
				typeof(DateTimeFormatInfo),
				typeof(ref global::System.DateTimeResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x0001B3F2 File Offset: 0x000195F2
		[global::Cpp2ILInjected.Token(Token = "0x17000652")]
		internal bool HasYearMonthAdjustment
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002AF8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDC6B8", Offset = "0x1BDC6B8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DoStrictParse", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlySpan<char>),
				typeof(global::System.ReadOnlySpan<char>),
				typeof(DateTimeStyles),
				typeof(DateTimeFormatInfo),
				typeof(ref global::System.DateTimeResult)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x0001B3F5 File Offset: 0x000195F5
		[global::Cpp2ILInjected.Token(Token = "0x6002AF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDC6E0", Offset = "0x1BDC6E0", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "ProcessHebrewTerminalState", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(ref DateTimeStyles),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(DateTimeFormatInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DoStrictParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(DateTimeStyles),
			typeof(DateTimeFormatInfo),
			typeof(ref global::System.DateTimeResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName)
		{
			throw null;
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x0001B3F8 File Offset: 0x000195F8
		[global::Cpp2ILInjected.Token(Token = "0x6002AFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDC804", Offset = "0x1BDC804", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Lex", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeToken),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.DateTimeResult),
			typeof(ref DateTimeFormatInfo),
			typeof(DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JapaneseCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new object[] { typeof(Calendar) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal static DateTimeFormatInfo GetJapaneseCalendarDTFI()
		{
			throw null;
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x0001B3FB File Offset: 0x000195FB
		[global::Cpp2ILInjected.Token(Token = "0x6002AFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDC98C", Offset = "0x1BDC98C", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "Lex", MemberParameters = new object[]
		{
			typeof(global::System.DateTimeParse.DS),
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeToken),
			typeof(ref global::System.DateTimeRawInfo),
			typeof(ref global::System.DateTimeResult),
			typeof(ref DateTimeFormatInfo),
			typeof(DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaiwanCalendar), Member = "GetDefaultInstance", ReturnType = typeof(Calendar))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "set_Calendar", MemberParameters = new object[] { typeof(Calendar) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal static DateTimeFormatInfo GetTaiwanCalendarDTFI()
		{
			throw null;
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x0001B3FE File Offset: 0x000195FE
		[global::Cpp2ILInjected.Token(Token = "0x6002AFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDA810", Offset = "0x1BDA810", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void ClearTokenHashTable()
		{
			throw null;
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x0001B401 File Offset: 0x00019601
		[global::Cpp2ILInjected.Token(Token = "0x6002AFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDCB14", Offset = "0x1BDCB14", Length = "0x890")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new object[]
		{
			typeof(global::System.TokenType),
			typeof(ref global::System.TokenType),
			typeof(ref int),
			typeof(ref global::System.__DTString)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(string),
			typeof(global::System.TokenType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_DateSeparator", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "AddMonthNames", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedMonthName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "internalGetMonthName", MemberParameters = new object[]
		{
			typeof(int),
			typeof(MonthNameStyles),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetDayName", MemberParameters = new object[] { typeof(global::System.DayOfWeek) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedDayName", MemberParameters = new object[] { typeof(global::System.DayOfWeek) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetEraName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedEraName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMonthName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedEnglishEraNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		internal DateTimeFormatInfo.TokenHashValue[] CreateTokenHashTable()
		{
			throw null;
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x0001B404 File Offset: 0x00019604
		[global::Cpp2ILInjected.Token(Token = "0x6002AFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDD66C", Offset = "0x1BDD66C", Length = "0x890")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(DateTimeFormatInfo.TokenHashValue[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(string),
			typeof(global::System.TokenType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfoScanner), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "GetDateWordsOfDTFI", MemberParameters = new object[] { typeof(DateTimeFormatInfo) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "AddMonthNames", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_DateSeparator", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedDayName", MemberParameters = new object[] { typeof(global::System.DayOfWeek) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "IsJapaneseCalendar", MemberParameters = new object[] { typeof(Calendar) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetJapaneseCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetEraName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedEraName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_AbbreviatedEnglishEraNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetTaiwanCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private void PopulateSpecialTokenHashTable(DateTimeFormatInfo.TokenHashValue[] temp, ref bool useDateSepAsIgnorableSymbol)
		{
			throw null;
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x0001B407 File Offset: 0x00019607
		[global::Cpp2ILInjected.Token(Token = "0x6002AFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDDFA0", Offset = "0x1BDDFA0", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static bool IsJapaneseCalendar(Calendar calendar)
		{
			throw null;
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x0001B40A File Offset: 0x0001960A
		[global::Cpp2ILInjected.Token(Token = "0x6002B00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDDEFC", Offset = "0x1BDDEFC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(DateTimeFormatInfo.TokenHashValue[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetMonthName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(string),
			typeof(global::System.TokenType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAbbreviatedMonthName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		private void AddMonthNames(DateTimeFormatInfo.TokenHashValue[] temp, string monthPostfix)
		{
			throw null;
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x0001B40D File Offset: 0x0001960D
		[global::Cpp2ILInjected.Token(Token = "0x6002B01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDE0CC", Offset = "0x1BDE0CC", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new object[]
		{
			typeof(global::System.TokenType),
			typeof(ref global::System.TokenType),
			typeof(ref int),
			typeof(ref global::System.__DTString)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HebrewNumber), Member = "IsDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HebrewNumberParsingContext), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HebrewNumber), Member = "ParseByChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(ref HebrewNumberParsingContext)
		}, ReturnType = typeof(HebrewNumberParsingState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "Advance", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static bool TryParseHebrewNumber(ref global::System.__DTString str, out bool badFormat, out int number)
		{
			throw null;
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x0001B410 File Offset: 0x00019610
		[global::Cpp2ILInjected.Token(Token = "0x6002B02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDE1F0", Offset = "0x1BDE1F0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsHebrewChar(char ch)
		{
			throw null;
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x0001B413 File Offset: 0x00019613
		[global::Cpp2ILInjected.Token(Token = "0x6002B03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDE204", Offset = "0x1BDE204", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(256)]
		private bool IsAllowedJapaneseTokenFollowedByNonSpaceLetter(string tokenString, char nextCh)
		{
			throw null;
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x0001B416 File Offset: 0x00019616
		[global::Cpp2ILInjected.Token(Token = "0x6002B04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDE2FC", Offset = "0x1BDE2FC", Length = "0x564")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.__DTString), Member = "GetRegularToken", MemberParameters = new object[]
		{
			typeof(ref global::System.TokenType),
			typeof(ref int),
			typeof(DateTimeFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.__DTString), Member = "GetSeparatorToken", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo),
			typeof(ref int),
			typeof(ref char)
		}, ReturnType = typeof(global::System.TokenType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(DateTimeFormatInfo.TokenHashValue[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string),
			typeof(CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "MatchSpecifiedWords", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "TryParseHebrewNumber", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.__DTString), Member = "Advance", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal bool Tokenize(global::System.TokenType TokenMask, out global::System.TokenType tokenType, out int tokenValue, ref global::System.__DTString str)
		{
			throw null;
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x0001B419 File Offset: 0x00019619
		[global::Cpp2ILInjected.Token(Token = "0x6002B05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDE860", Offset = "0x1BDE860", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(string),
			typeof(global::System.TokenType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo.TokenHashValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.TokenType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void InsertAtCurrentHashNode(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, char ch, global::System.TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe)
		{
			throw null;
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x0001B41C File Offset: 0x0001961C
		[global::Cpp2ILInjected.Token(Token = "0x6002B06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDD3A4", Offset = "0x1BDD3A4", Length = "0x2C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "CreateTokenHashTable", ReturnType = typeof(DateTimeFormatInfo.TokenHashValue[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "AddMonthNames", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 54)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "CompareStringIgnoreCaseOptimized", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo.TokenHashValue), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.TokenType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "InsertAtCurrentHashNode", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(string),
			typeof(char),
			typeof(global::System.TokenType),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void InsertHash(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, global::System.TokenType tokenType, int tokenValue)
		{
			throw null;
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x0001B41F File Offset: 0x0001961F
		[global::Cpp2ILInjected.Token(Token = "0x6002B07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDE9DC", Offset = "0x1BDE9DC", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new object[]
		{
			typeof(DateTimeFormatInfo.TokenHashValue[]),
			typeof(string),
			typeof(global::System.TokenType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeFormatInfo), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
		private bool CompareStringIgnoreCaseOptimized(string string1, int offset1, int length1, string string2, int offset2, int length2)
		{
			throw null;
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x0001B422 File Offset: 0x00019622
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002B08")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BDEAB8", Offset = "0x1BDEAB8", Length = "0x1074")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static DateTimeFormatInfo()
		{
			throw null;
		}

		// Token: 0x0400138A RID: 5002
		[global::Cpp2ILInjected.Token(Token = "0x40016E5")]
		private static DateTimeFormatInfo s_invariantInfo;

		// Token: 0x0400138B RID: 5003
		[global::Cpp2ILInjected.Token(Token = "0x40016E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[global::System.NonSerialized]
		private CultureData _cultureData;

		// Token: 0x0400138C RID: 5004
		[global::Cpp2ILInjected.Token(Token = "0x40016E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _name;

		// Token: 0x0400138D RID: 5005
		[global::Cpp2ILInjected.Token(Token = "0x40016E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[global::System.NonSerialized]
		private string _langName;

		// Token: 0x0400138E RID: 5006
		[global::Cpp2ILInjected.Token(Token = "0x40016E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		[global::System.NonSerialized]
		private CompareInfo _compareInfo;

		// Token: 0x0400138F RID: 5007
		[global::Cpp2ILInjected.Token(Token = "0x40016EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		[global::System.NonSerialized]
		private CultureInfo _cultureInfo;

		// Token: 0x04001390 RID: 5008
		[global::Cpp2ILInjected.Token(Token = "0x40016EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string amDesignator;

		// Token: 0x04001391 RID: 5009
		[global::Cpp2ILInjected.Token(Token = "0x40016EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string pmDesignator;

		// Token: 0x04001392 RID: 5010
		[global::Cpp2ILInjected.Token(Token = "0x40016ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string dateSeparator;

		// Token: 0x04001393 RID: 5011
		[global::Cpp2ILInjected.Token(Token = "0x40016EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string generalShortTimePattern;

		// Token: 0x04001394 RID: 5012
		[global::Cpp2ILInjected.Token(Token = "0x40016EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string generalLongTimePattern;

		// Token: 0x04001395 RID: 5013
		[global::Cpp2ILInjected.Token(Token = "0x40016F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private string timeSeparator;

		// Token: 0x04001396 RID: 5014
		[global::Cpp2ILInjected.Token(Token = "0x40016F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private string monthDayPattern;

		// Token: 0x04001397 RID: 5015
		[global::Cpp2ILInjected.Token(Token = "0x40016F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private string dateTimeOffsetPattern;

		// Token: 0x04001398 RID: 5016
		[global::Cpp2ILInjected.Token(Token = "0x40016F3")]
		private const string rfc1123Pattern = "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'";

		// Token: 0x04001399 RID: 5017
		[global::Cpp2ILInjected.Token(Token = "0x40016F4")]
		private const string sortableDateTimePattern = "yyyy'-'MM'-'dd'T'HH':'mm':'ss";

		// Token: 0x0400139A RID: 5018
		[global::Cpp2ILInjected.Token(Token = "0x40016F5")]
		private const string universalSortableDateTimePattern = "yyyy'-'MM'-'dd HH':'mm':'ss'Z'";

		// Token: 0x0400139B RID: 5019
		[global::Cpp2ILInjected.Token(Token = "0x40016F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private Calendar calendar;

		// Token: 0x0400139C RID: 5020
		[global::Cpp2ILInjected.Token(Token = "0x40016F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private int firstDayOfWeek;

		// Token: 0x0400139D RID: 5021
		[global::Cpp2ILInjected.Token(Token = "0x40016F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		private int calendarWeekRule;

		// Token: 0x0400139E RID: 5022
		[global::Cpp2ILInjected.Token(Token = "0x40016F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private string fullDateTimePattern;

		// Token: 0x0400139F RID: 5023
		[global::Cpp2ILInjected.Token(Token = "0x40016FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private string[] abbreviatedDayNames;

		// Token: 0x040013A0 RID: 5024
		[global::Cpp2ILInjected.Token(Token = "0x40016FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private string[] m_superShortDayNames;

		// Token: 0x040013A1 RID: 5025
		[global::Cpp2ILInjected.Token(Token = "0x40016FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private string[] dayNames;

		// Token: 0x040013A2 RID: 5026
		[global::Cpp2ILInjected.Token(Token = "0x40016FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private string[] abbreviatedMonthNames;

		// Token: 0x040013A3 RID: 5027
		[global::Cpp2ILInjected.Token(Token = "0x40016FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private string[] monthNames;

		// Token: 0x040013A4 RID: 5028
		[global::Cpp2ILInjected.Token(Token = "0x40016FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private string[] genitiveMonthNames;

		// Token: 0x040013A5 RID: 5029
		[global::Cpp2ILInjected.Token(Token = "0x4001700")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private string[] m_genitiveAbbreviatedMonthNames;

		// Token: 0x040013A6 RID: 5030
		[global::Cpp2ILInjected.Token(Token = "0x4001701")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private string[] leapYearMonthNames;

		// Token: 0x040013A7 RID: 5031
		[global::Cpp2ILInjected.Token(Token = "0x4001702")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private string longDatePattern;

		// Token: 0x040013A8 RID: 5032
		[global::Cpp2ILInjected.Token(Token = "0x4001703")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private string shortDatePattern;

		// Token: 0x040013A9 RID: 5033
		[global::Cpp2ILInjected.Token(Token = "0x4001704")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private string yearMonthPattern;

		// Token: 0x040013AA RID: 5034
		[global::Cpp2ILInjected.Token(Token = "0x4001705")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private string longTimePattern;

		// Token: 0x040013AB RID: 5035
		[global::Cpp2ILInjected.Token(Token = "0x4001706")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private string shortTimePattern;

		// Token: 0x040013AC RID: 5036
		[global::Cpp2ILInjected.Token(Token = "0x4001707")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private string[] allYearMonthPatterns;

		// Token: 0x040013AD RID: 5037
		[global::Cpp2ILInjected.Token(Token = "0x4001708")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private string[] allShortDatePatterns;

		// Token: 0x040013AE RID: 5038
		[global::Cpp2ILInjected.Token(Token = "0x4001709")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private string[] allLongDatePatterns;

		// Token: 0x040013AF RID: 5039
		[global::Cpp2ILInjected.Token(Token = "0x400170A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private string[] allShortTimePatterns;

		// Token: 0x040013B0 RID: 5040
		[global::Cpp2ILInjected.Token(Token = "0x400170B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		private string[] allLongTimePatterns;

		// Token: 0x040013B1 RID: 5041
		[global::Cpp2ILInjected.Token(Token = "0x400170C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		private string[] m_eraNames;

		// Token: 0x040013B2 RID: 5042
		[global::Cpp2ILInjected.Token(Token = "0x400170D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		private string[] m_abbrevEraNames;

		// Token: 0x040013B3 RID: 5043
		[global::Cpp2ILInjected.Token(Token = "0x400170E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		private string[] m_abbrevEnglishEraNames;

		// Token: 0x040013B4 RID: 5044
		[global::Cpp2ILInjected.Token(Token = "0x400170F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		private CalendarId[] optionalCalendars;

		// Token: 0x040013B5 RID: 5045
		[global::Cpp2ILInjected.Token(Token = "0x4001710")]
		private const int DEFAULT_ALL_DATETIMES_SIZE = 132;

		// Token: 0x040013B6 RID: 5046
		[global::Cpp2ILInjected.Token(Token = "0x4001711")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		internal bool _isReadOnly;

		// Token: 0x040013B7 RID: 5047
		[global::Cpp2ILInjected.Token(Token = "0x4001712")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x144")]
		private DateTimeFormatFlags formatFlags;

		// Token: 0x040013B8 RID: 5048
		[global::Cpp2ILInjected.Token(Token = "0x4001713")]
		private static readonly char[] s_monthSpaces;

		// Token: 0x040013B9 RID: 5049
		[global::Cpp2ILInjected.Token(Token = "0x4001714")]
		internal const string RoundtripFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK";

		// Token: 0x040013BA RID: 5050
		[global::Cpp2ILInjected.Token(Token = "0x4001715")]
		internal const string RoundtripDateTimeUnfixed = "yyyy'-'MM'-'ddTHH':'mm':'ss zzz";

		// Token: 0x040013BB RID: 5051
		[global::Cpp2ILInjected.Token(Token = "0x4001716")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private string _fullTimeSpanPositivePattern;

		// Token: 0x040013BC RID: 5052
		[global::Cpp2ILInjected.Token(Token = "0x4001717")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private string _fullTimeSpanNegativePattern;

		// Token: 0x040013BD RID: 5053
		[global::Cpp2ILInjected.Token(Token = "0x4001718")]
		internal const DateTimeStyles InvalidDateTimeStyles = ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite | DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal | DateTimeStyles.RoundtripKind);

		// Token: 0x040013BE RID: 5054
		[global::Cpp2ILInjected.Token(Token = "0x4001719")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		[global::System.NonSerialized]
		private DateTimeFormatInfo.TokenHashValue[] _dtfiTokenHash;

		// Token: 0x040013BF RID: 5055
		[global::Cpp2ILInjected.Token(Token = "0x400171A")]
		private const int TOKEN_HASH_SIZE = 199;

		// Token: 0x040013C0 RID: 5056
		[global::Cpp2ILInjected.Token(Token = "0x400171B")]
		private const int SECOND_PRIME = 197;

		// Token: 0x040013C1 RID: 5057
		[global::Cpp2ILInjected.Token(Token = "0x400171C")]
		private const string dateSeparatorOrTimeZoneOffset = "-";

		// Token: 0x040013C2 RID: 5058
		[global::Cpp2ILInjected.Token(Token = "0x400171D")]
		private const string invariantDateSeparator = "/";

		// Token: 0x040013C3 RID: 5059
		[global::Cpp2ILInjected.Token(Token = "0x400171E")]
		private const string invariantTimeSeparator = ":";

		// Token: 0x040013C4 RID: 5060
		[global::Cpp2ILInjected.Token(Token = "0x400171F")]
		internal const string IgnorablePeriod = ".";

		// Token: 0x040013C5 RID: 5061
		[global::Cpp2ILInjected.Token(Token = "0x4001720")]
		internal const string IgnorableComma = ",";

		// Token: 0x040013C6 RID: 5062
		[global::Cpp2ILInjected.Token(Token = "0x4001721")]
		internal const string CJKYearSuff = "年";

		// Token: 0x040013C7 RID: 5063
		[global::Cpp2ILInjected.Token(Token = "0x4001722")]
		internal const string CJKMonthSuff = "月";

		// Token: 0x040013C8 RID: 5064
		[global::Cpp2ILInjected.Token(Token = "0x4001723")]
		internal const string CJKDaySuff = "日";

		// Token: 0x040013C9 RID: 5065
		[global::Cpp2ILInjected.Token(Token = "0x4001724")]
		internal const string KoreanYearSuff = "년";

		// Token: 0x040013CA RID: 5066
		[global::Cpp2ILInjected.Token(Token = "0x4001725")]
		internal const string KoreanMonthSuff = "월";

		// Token: 0x040013CB RID: 5067
		[global::Cpp2ILInjected.Token(Token = "0x4001726")]
		internal const string KoreanDaySuff = "일";

		// Token: 0x040013CC RID: 5068
		[global::Cpp2ILInjected.Token(Token = "0x4001727")]
		internal const string KoreanHourSuff = "시";

		// Token: 0x040013CD RID: 5069
		[global::Cpp2ILInjected.Token(Token = "0x4001728")]
		internal const string KoreanMinuteSuff = "분";

		// Token: 0x040013CE RID: 5070
		[global::Cpp2ILInjected.Token(Token = "0x4001729")]
		internal const string KoreanSecondSuff = "초";

		// Token: 0x040013CF RID: 5071
		[global::Cpp2ILInjected.Token(Token = "0x400172A")]
		internal const string CJKHourSuff = "時";

		// Token: 0x040013D0 RID: 5072
		[global::Cpp2ILInjected.Token(Token = "0x400172B")]
		internal const string ChineseHourSuff = "时";

		// Token: 0x040013D1 RID: 5073
		[global::Cpp2ILInjected.Token(Token = "0x400172C")]
		internal const string CJKMinuteSuff = "分";

		// Token: 0x040013D2 RID: 5074
		[global::Cpp2ILInjected.Token(Token = "0x400172D")]
		internal const string CJKSecondSuff = "秒";

		// Token: 0x040013D3 RID: 5075
		[global::Cpp2ILInjected.Token(Token = "0x400172E")]
		internal const string JapaneseEraStart = "元";

		// Token: 0x040013D4 RID: 5076
		[global::Cpp2ILInjected.Token(Token = "0x400172F")]
		internal const string LocalTimeMark = "T";

		// Token: 0x040013D5 RID: 5077
		[global::Cpp2ILInjected.Token(Token = "0x4001730")]
		internal const string GMTName = "GMT";

		// Token: 0x040013D6 RID: 5078
		[global::Cpp2ILInjected.Token(Token = "0x4001731")]
		internal const string ZuluName = "Z";

		// Token: 0x040013D7 RID: 5079
		[global::Cpp2ILInjected.Token(Token = "0x4001732")]
		internal const string KoreanLangName = "ko";

		// Token: 0x040013D8 RID: 5080
		[global::Cpp2ILInjected.Token(Token = "0x4001733")]
		internal const string JapaneseLangName = "ja";

		// Token: 0x040013D9 RID: 5081
		[global::Cpp2ILInjected.Token(Token = "0x4001734")]
		internal const string EnglishLangName = "en";

		// Token: 0x040013DA RID: 5082
		[global::Cpp2ILInjected.Token(Token = "0x4001735")]
		private static DateTimeFormatInfo s_jajpDTFI;

		// Token: 0x040013DB RID: 5083
		[global::Cpp2ILInjected.Token(Token = "0x4001736")]
		private static DateTimeFormatInfo s_zhtwDTFI;

		// Token: 0x02000628 RID: 1576
		[global::Cpp2ILInjected.Token(Token = "0x2000589")]
		internal class TokenHashValue
		{
			// Token: 0x06004204 RID: 16900 RVA: 0x00020066 File Offset: 0x0001E266
			[global::Cpp2ILInjected.Token(Token = "0x6002B09")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BDFB2C", Offset = "0x1BDFB2C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InsertAtCurrentHashNode", MemberParameters = new object[]
			{
				typeof(DateTimeFormatInfo.TokenHashValue[]),
				typeof(string),
				typeof(char),
				typeof(global::System.TokenType),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InsertHash", MemberParameters = new object[]
			{
				typeof(DateTimeFormatInfo.TokenHashValue[]),
				typeof(string),
				typeof(global::System.TokenType),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal TokenHashValue(string tokenString, global::System.TokenType tokenType, int tokenValue)
			{
				throw null;
			}

			// Token: 0x040019E1 RID: 6625
			[global::Cpp2ILInjected.Token(Token = "0x4001737")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal string tokenString;

			// Token: 0x040019E2 RID: 6626
			[global::Cpp2ILInjected.Token(Token = "0x4001738")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal global::System.TokenType tokenType;

			// Token: 0x040019E3 RID: 6627
			[global::Cpp2ILInjected.Token(Token = "0x4001739")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			internal int tokenValue;
		}
	}
}
