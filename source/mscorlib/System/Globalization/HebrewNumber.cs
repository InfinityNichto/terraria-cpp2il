using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	[global::Cpp2ILInjected.Token(Token = "0x2000593")]
	internal class HebrewNumber
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x400177D")]
		private static readonly HebrewNumber.HebrewValue[] s_hebrewValues;

		[global::Cpp2ILInjected.Token(Token = "0x400177E")]
		private static char s_maxHebrewNumberCh;

		[global::Cpp2ILInjected.Token(Token = "0x400177F")]
		private static readonly HebrewNumber.HS[] s_numberPasingState;

		[global::Cpp2ILInjected.Token(Token = "0x2000594")]
		private enum HebrewToken : short
		{
			[global::Cpp2ILInjected.Token(Token = "0x4001781")]
			Invalid = -1,
			[global::Cpp2ILInjected.Token(Token = "0x4001782")]
			Digit400,
			[global::Cpp2ILInjected.Token(Token = "0x4001783")]
			Digit200_300,
			[global::Cpp2ILInjected.Token(Token = "0x4001784")]
			Digit100,
			[global::Cpp2ILInjected.Token(Token = "0x4001785")]
			Digit10,
			[global::Cpp2ILInjected.Token(Token = "0x4001786")]
			Digit1,
			[global::Cpp2ILInjected.Token(Token = "0x4001787")]
			Digit6_7,
			[global::Cpp2ILInjected.Token(Token = "0x4001788")]
			Digit7,
			[global::Cpp2ILInjected.Token(Token = "0x4001789")]
			Digit9,
			[global::Cpp2ILInjected.Token(Token = "0x400178A")]
			SingleQuote,
			[global::Cpp2ILInjected.Token(Token = "0x400178B")]
			DoubleQuote
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000595")]
		private struct HebrewValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B24")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE1624", Offset = "0x1BE1624", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal HebrewValue(HebrewNumber.HebrewToken token, short value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400178C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal HebrewNumber.HebrewToken token;

			[global::Cpp2ILInjected.Token(Token = "0x400178D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
			internal short value;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000596")]
		internal enum HS : sbyte
		{
			[global::Cpp2ILInjected.Token(Token = "0x400178F")]
			_err = -1,
			[global::Cpp2ILInjected.Token(Token = "0x4001790")]
			Start,
			[global::Cpp2ILInjected.Token(Token = "0x4001791")]
			S400,
			[global::Cpp2ILInjected.Token(Token = "0x4001792")]
			S400_400,
			[global::Cpp2ILInjected.Token(Token = "0x4001793")]
			S400_X00,
			[global::Cpp2ILInjected.Token(Token = "0x4001794")]
			S400_X0,
			[global::Cpp2ILInjected.Token(Token = "0x4001795")]
			X00_DQ,
			[global::Cpp2ILInjected.Token(Token = "0x4001796")]
			S400_X00_X0,
			[global::Cpp2ILInjected.Token(Token = "0x4001797")]
			X0_DQ,
			[global::Cpp2ILInjected.Token(Token = "0x4001798")]
			X,
			[global::Cpp2ILInjected.Token(Token = "0x4001799")]
			X0,
			[global::Cpp2ILInjected.Token(Token = "0x400179A")]
			X00,
			[global::Cpp2ILInjected.Token(Token = "0x400179B")]
			S400_DQ,
			[global::Cpp2ILInjected.Token(Token = "0x400179C")]
			S400_400_DQ,
			[global::Cpp2ILInjected.Token(Token = "0x400179D")]
			S400_400_100,
			[global::Cpp2ILInjected.Token(Token = "0x400179E")]
			S9,
			[global::Cpp2ILInjected.Token(Token = "0x400179F")]
			X00_S9,
			[global::Cpp2ILInjected.Token(Token = "0x40017A0")]
			S9_DQ,
			[global::Cpp2ILInjected.Token(Token = "0x40017A1")]
			END = 100
		}
	}
}
