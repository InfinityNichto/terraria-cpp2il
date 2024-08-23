using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200003C RID: 60
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200003F")]
	internal struct DateTimeParser
	{
		// Token: 0x060002AD RID: 685 RVA: 0x000028A6 File Offset: 0x00000AA6
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

		// Token: 0x060002AE RID: 686 RVA: 0x000028A9 File Offset: 0x00000AA9
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

		// Token: 0x060002AF RID: 687 RVA: 0x000028AC File Offset: 0x00000AAC
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

		// Token: 0x060002B0 RID: 688 RVA: 0x000028AF File Offset: 0x00000AAF
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

		// Token: 0x060002B1 RID: 689 RVA: 0x000028B2 File Offset: 0x00000AB2
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

		// Token: 0x060002B2 RID: 690 RVA: 0x000028B5 File Offset: 0x00000AB5
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

		// Token: 0x060002B3 RID: 691 RVA: 0x000028B8 File Offset: 0x00000AB8
		[global::Cpp2ILInjected.Token(Token = "0x60002B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCF324", Offset = "0x1CCF324", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeParser), Member = "ParseDate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private bool Parse4Digit(int start, out int num)
		{
			throw null;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000028BB File Offset: 0x00000ABB
		[global::Cpp2ILInjected.Token(Token = "0x60002B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCF3BC", Offset = "0x1CCF3BC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool Parse2Digit(int start, out int num)
		{
			throw null;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000028BE File Offset: 0x00000ABE
		[global::Cpp2ILInjected.Token(Token = "0x60002B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCF2B8", Offset = "0x1CCF2B8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool ParseChar(int start, char ch)
		{
			throw null;
		}

		// Token: 0x0400013C RID: 316
		[global::Cpp2ILInjected.Token(Token = "0x4000156")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int Year;

		// Token: 0x0400013D RID: 317
		[global::Cpp2ILInjected.Token(Token = "0x4000157")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int Month;

		// Token: 0x0400013E RID: 318
		[global::Cpp2ILInjected.Token(Token = "0x4000158")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int Day;

		// Token: 0x0400013F RID: 319
		[global::Cpp2ILInjected.Token(Token = "0x4000159")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public int Hour;

		// Token: 0x04000140 RID: 320
		[global::Cpp2ILInjected.Token(Token = "0x400015A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int Minute;

		// Token: 0x04000141 RID: 321
		[global::Cpp2ILInjected.Token(Token = "0x400015B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int Second;

		// Token: 0x04000142 RID: 322
		[global::Cpp2ILInjected.Token(Token = "0x400015C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int Fraction;

		// Token: 0x04000143 RID: 323
		[global::Cpp2ILInjected.Token(Token = "0x400015D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int ZoneHour;

		// Token: 0x04000144 RID: 324
		[global::Cpp2ILInjected.Token(Token = "0x400015E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int ZoneMinute;

		// Token: 0x04000145 RID: 325
		[global::Cpp2ILInjected.Token(Token = "0x400015F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public ParserTimeZone Zone;

		// Token: 0x04000146 RID: 326
		[global::Cpp2ILInjected.Token(Token = "0x4000160")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private char[] _text;

		// Token: 0x04000147 RID: 327
		[global::Cpp2ILInjected.Token(Token = "0x4000161")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _end;

		// Token: 0x04000148 RID: 328
		[global::Cpp2ILInjected.Token(Token = "0x4000162")]
		private static readonly int[] Power10;

		// Token: 0x04000149 RID: 329
		[global::Cpp2ILInjected.Token(Token = "0x4000163")]
		private static readonly int Lzyyyy;

		// Token: 0x0400014A RID: 330
		[global::Cpp2ILInjected.Token(Token = "0x4000164")]
		private static readonly int Lzyyyy_;

		// Token: 0x0400014B RID: 331
		[global::Cpp2ILInjected.Token(Token = "0x4000165")]
		private static readonly int Lzyyyy_MM;

		// Token: 0x0400014C RID: 332
		[global::Cpp2ILInjected.Token(Token = "0x4000166")]
		private static readonly int Lzyyyy_MM_;

		// Token: 0x0400014D RID: 333
		[global::Cpp2ILInjected.Token(Token = "0x4000167")]
		private static readonly int Lzyyyy_MM_dd;

		// Token: 0x0400014E RID: 334
		[global::Cpp2ILInjected.Token(Token = "0x4000168")]
		private static readonly int Lzyyyy_MM_ddT;

		// Token: 0x0400014F RID: 335
		[global::Cpp2ILInjected.Token(Token = "0x4000169")]
		private static readonly int LzHH;

		// Token: 0x04000150 RID: 336
		[global::Cpp2ILInjected.Token(Token = "0x400016A")]
		private static readonly int LzHH_;

		// Token: 0x04000151 RID: 337
		[global::Cpp2ILInjected.Token(Token = "0x400016B")]
		private static readonly int LzHH_mm;

		// Token: 0x04000152 RID: 338
		[global::Cpp2ILInjected.Token(Token = "0x400016C")]
		private static readonly int LzHH_mm_;

		// Token: 0x04000153 RID: 339
		[global::Cpp2ILInjected.Token(Token = "0x400016D")]
		private static readonly int LzHH_mm_ss;

		// Token: 0x04000154 RID: 340
		[global::Cpp2ILInjected.Token(Token = "0x400016E")]
		private static readonly int Lz_;

		// Token: 0x04000155 RID: 341
		[global::Cpp2ILInjected.Token(Token = "0x400016F")]
		private static readonly int Lz_zz;

		// Token: 0x04000156 RID: 342
		[global::Cpp2ILInjected.Token(Token = "0x4000170")]
		private const short MaxFractionDigits = 7;
	}
}
