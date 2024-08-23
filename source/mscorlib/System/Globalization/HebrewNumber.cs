using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	// Token: 0x020004B3 RID: 1203
	[global::Cpp2ILInjected.Token(Token = "0x2000593")]
	internal class HebrewNumber
	{
		// Token: 0x060027EF RID: 10223 RVA: 0x0001B467 File Offset: 0x00019667
		[global::Cpp2ILInjected.Token(Token = "0x6002B20")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE109C", Offset = "0x1BE109C", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "HebrewFormatDigits", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static string ToString(int Number)
		{
			throw null;
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x0001B46A File Offset: 0x0001966A
		[global::Cpp2ILInjected.Token(Token = "0x6002B21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE12EC", Offset = "0x1BE12EC", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "MatchHebrewDigits", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "TryParseHebrewNumber", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context)
		{
			throw null;
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x0001B46D File Offset: 0x0001966D
		[global::Cpp2ILInjected.Token(Token = "0x6002B22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE1440", Offset = "0x1BE1440", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeFormatInfo), Member = "TryParseHebrewNumber", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref bool),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static bool IsDigit(char ch)
		{
			throw null;
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x0001B470 File Offset: 0x00019670
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002B23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE14F8", Offset = "0x1BE14F8", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static HebrewNumber()
		{
			throw null;
		}

		// Token: 0x04001419 RID: 5145
		[global::Cpp2ILInjected.Token(Token = "0x400177D")]
		private static readonly HebrewNumber.HebrewValue[] s_hebrewValues;

		// Token: 0x0400141A RID: 5146
		[global::Cpp2ILInjected.Token(Token = "0x400177E")]
		private static char s_maxHebrewNumberCh;

		// Token: 0x0400141B RID: 5147
		[global::Cpp2ILInjected.Token(Token = "0x400177F")]
		private static readonly HebrewNumber.HS[] s_numberPasingState;

		// Token: 0x0200062A RID: 1578
		[global::Cpp2ILInjected.Token(Token = "0x2000594")]
		private enum HebrewToken : short
		{
			// Token: 0x040019EB RID: 6635
			[global::Cpp2ILInjected.Token(Token = "0x4001781")]
			Invalid = -1,
			// Token: 0x040019EC RID: 6636
			[global::Cpp2ILInjected.Token(Token = "0x4001782")]
			Digit400,
			// Token: 0x040019ED RID: 6637
			[global::Cpp2ILInjected.Token(Token = "0x4001783")]
			Digit200_300,
			// Token: 0x040019EE RID: 6638
			[global::Cpp2ILInjected.Token(Token = "0x4001784")]
			Digit100,
			// Token: 0x040019EF RID: 6639
			[global::Cpp2ILInjected.Token(Token = "0x4001785")]
			Digit10,
			// Token: 0x040019F0 RID: 6640
			[global::Cpp2ILInjected.Token(Token = "0x4001786")]
			Digit1,
			// Token: 0x040019F1 RID: 6641
			[global::Cpp2ILInjected.Token(Token = "0x4001787")]
			Digit6_7,
			// Token: 0x040019F2 RID: 6642
			[global::Cpp2ILInjected.Token(Token = "0x4001788")]
			Digit7,
			// Token: 0x040019F3 RID: 6643
			[global::Cpp2ILInjected.Token(Token = "0x4001789")]
			Digit9,
			// Token: 0x040019F4 RID: 6644
			[global::Cpp2ILInjected.Token(Token = "0x400178A")]
			SingleQuote,
			// Token: 0x040019F5 RID: 6645
			[global::Cpp2ILInjected.Token(Token = "0x400178B")]
			DoubleQuote
		}

		// Token: 0x0200062B RID: 1579
		[global::Cpp2ILInjected.Token(Token = "0x2000595")]
		private struct HebrewValue
		{
			// Token: 0x06004205 RID: 16901 RVA: 0x00020069 File Offset: 0x0001E269
			[global::Cpp2ILInjected.Token(Token = "0x6002B24")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE1624", Offset = "0x1BE1624", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal HebrewValue(HebrewNumber.HebrewToken token, short value)
			{
				throw null;
			}

			// Token: 0x040019F6 RID: 6646
			[global::Cpp2ILInjected.Token(Token = "0x400178C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal HebrewNumber.HebrewToken token;

			// Token: 0x040019F7 RID: 6647
			[global::Cpp2ILInjected.Token(Token = "0x400178D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
			internal short value;
		}

		// Token: 0x0200062C RID: 1580
		[global::Cpp2ILInjected.Token(Token = "0x2000596")]
		internal enum HS : sbyte
		{
			// Token: 0x040019F9 RID: 6649
			[global::Cpp2ILInjected.Token(Token = "0x400178F")]
			_err = -1,
			// Token: 0x040019FA RID: 6650
			[global::Cpp2ILInjected.Token(Token = "0x4001790")]
			Start,
			// Token: 0x040019FB RID: 6651
			[global::Cpp2ILInjected.Token(Token = "0x4001791")]
			S400,
			// Token: 0x040019FC RID: 6652
			[global::Cpp2ILInjected.Token(Token = "0x4001792")]
			S400_400,
			// Token: 0x040019FD RID: 6653
			[global::Cpp2ILInjected.Token(Token = "0x4001793")]
			S400_X00,
			// Token: 0x040019FE RID: 6654
			[global::Cpp2ILInjected.Token(Token = "0x4001794")]
			S400_X0,
			// Token: 0x040019FF RID: 6655
			[global::Cpp2ILInjected.Token(Token = "0x4001795")]
			X00_DQ,
			// Token: 0x04001A00 RID: 6656
			[global::Cpp2ILInjected.Token(Token = "0x4001796")]
			S400_X00_X0,
			// Token: 0x04001A01 RID: 6657
			[global::Cpp2ILInjected.Token(Token = "0x4001797")]
			X0_DQ,
			// Token: 0x04001A02 RID: 6658
			[global::Cpp2ILInjected.Token(Token = "0x4001798")]
			X,
			// Token: 0x04001A03 RID: 6659
			[global::Cpp2ILInjected.Token(Token = "0x4001799")]
			X0,
			// Token: 0x04001A04 RID: 6660
			[global::Cpp2ILInjected.Token(Token = "0x400179A")]
			X00,
			// Token: 0x04001A05 RID: 6661
			[global::Cpp2ILInjected.Token(Token = "0x400179B")]
			S400_DQ,
			// Token: 0x04001A06 RID: 6662
			[global::Cpp2ILInjected.Token(Token = "0x400179C")]
			S400_400_DQ,
			// Token: 0x04001A07 RID: 6663
			[global::Cpp2ILInjected.Token(Token = "0x400179D")]
			S400_400_100,
			// Token: 0x04001A08 RID: 6664
			[global::Cpp2ILInjected.Token(Token = "0x400179E")]
			S9,
			// Token: 0x04001A09 RID: 6665
			[global::Cpp2ILInjected.Token(Token = "0x400179F")]
			X00_S9,
			// Token: 0x04001A0A RID: 6666
			[global::Cpp2ILInjected.Token(Token = "0x40017A0")]
			S9_DQ,
			// Token: 0x04001A0B RID: 6667
			[global::Cpp2ILInjected.Token(Token = "0x40017A1")]
			END = 100
		}
	}
}
