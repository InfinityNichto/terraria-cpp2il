using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200003F")]
	internal struct DateTimeParser
	{
		[global::Cpp2ILInjected.Token(Token = "0x60002AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCED6C", Offset = "0x1CCED6C", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		static DateTimeParser()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCEFC0", Offset = "0x1CCEFC0", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeIso", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(DateTimeZoneHandling),
			typeof(ref DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseDateTimeOffsetIso", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(ref DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeParser), Member = "ParseDate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeParser), Member = "ParseTimeAndZoneAndWhitespace", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool Parse(char[] text, int startIndex, int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCF0A4", Offset = "0x1CCF0A4", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeParser), Member = "Parse4Digit", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "DaysInMonth", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private bool ParseDate(int start)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCF2E4", Offset = "0x1CCF2E4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeParser), Member = "Parse", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeParser), Member = "ParseTime", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeParser), Member = "ParseZone", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		private bool ParseTimeAndZoneAndWhitespace(int start)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCF424", Offset = "0x1CCF424", Length = "0x358")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeParser), Member = "ParseTimeAndZoneAndWhitespace", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private bool ParseTime(ref int start)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCF77C", Offset = "0x1CCF77C", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeParser), Member = "ParseTimeAndZoneAndWhitespace", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool ParseZone(int start)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCF324", Offset = "0x1CCF324", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeParser), Member = "ParseDate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private bool Parse4Digit(int start, out int num)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCF3BC", Offset = "0x1CCF3BC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool Parse2Digit(int start, out int num)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCF2B8", Offset = "0x1CCF2B8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool ParseChar(int start, char ch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000156")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int Year;

		[global::Cpp2ILInjected.Token(Token = "0x4000157")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int Month;

		[global::Cpp2ILInjected.Token(Token = "0x4000158")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int Day;

		[global::Cpp2ILInjected.Token(Token = "0x4000159")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public int Hour;

		[global::Cpp2ILInjected.Token(Token = "0x400015A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int Minute;

		[global::Cpp2ILInjected.Token(Token = "0x400015B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int Second;

		[global::Cpp2ILInjected.Token(Token = "0x400015C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int Fraction;

		[global::Cpp2ILInjected.Token(Token = "0x400015D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int ZoneHour;

		[global::Cpp2ILInjected.Token(Token = "0x400015E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int ZoneMinute;

		[global::Cpp2ILInjected.Token(Token = "0x400015F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public ParserTimeZone Zone;

		[global::Cpp2ILInjected.Token(Token = "0x4000160")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private char[] _text;

		[global::Cpp2ILInjected.Token(Token = "0x4000161")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _end;

		[global::Cpp2ILInjected.Token(Token = "0x4000162")]
		private static readonly int[] Power10;

		[global::Cpp2ILInjected.Token(Token = "0x4000163")]
		private static readonly int Lzyyyy;

		[global::Cpp2ILInjected.Token(Token = "0x4000164")]
		private static readonly int Lzyyyy_;

		[global::Cpp2ILInjected.Token(Token = "0x4000165")]
		private static readonly int Lzyyyy_MM;

		[global::Cpp2ILInjected.Token(Token = "0x4000166")]
		private static readonly int Lzyyyy_MM_;

		[global::Cpp2ILInjected.Token(Token = "0x4000167")]
		private static readonly int Lzyyyy_MM_dd;

		[global::Cpp2ILInjected.Token(Token = "0x4000168")]
		private static readonly int Lzyyyy_MM_ddT;

		[global::Cpp2ILInjected.Token(Token = "0x4000169")]
		private static readonly int LzHH;

		[global::Cpp2ILInjected.Token(Token = "0x400016A")]
		private static readonly int LzHH_;

		[global::Cpp2ILInjected.Token(Token = "0x400016B")]
		private static readonly int LzHH_mm;

		[global::Cpp2ILInjected.Token(Token = "0x400016C")]
		private static readonly int LzHH_mm_;

		[global::Cpp2ILInjected.Token(Token = "0x400016D")]
		private static readonly int LzHH_mm_ss;

		[global::Cpp2ILInjected.Token(Token = "0x400016E")]
		private static readonly int Lz_;

		[global::Cpp2ILInjected.Token(Token = "0x400016F")]
		private static readonly int Lz_zz;

		[global::Cpp2ILInjected.Token(Token = "0x4000170")]
		private const short MaxFractionDigits = 7;
	}
}
