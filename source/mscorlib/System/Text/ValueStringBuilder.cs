using System;
using System.Globalization;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001F9 RID: 505
	[global::System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000287")]
	internal ref struct ValueStringBuilder
	{
		// Token: 0x06001445 RID: 5189 RVA: 0x00017DFE File Offset: 0x00015FFE
		[global::Cpp2ILInjected.Token(Token = "0x600161E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE2CE0", Offset = "0x1AE2CE0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatDecimal", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatDecimal", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatDouble", MemberParameters = new object[]
		{
			typeof(double),
			typeof(string),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatDouble", MemberParameters = new object[]
		{
			typeof(double),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatSingle", MemberParameters = new object[]
		{
			typeof(float),
			typeof(string),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatSingle", MemberParameters = new object[]
		{
			typeof(float),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatInt64", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatInt64", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemName), Member = "TranslateWin32Expression", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		public ValueStringBuilder(global::System.Span<char> initialBuffer)
		{
			throw null;
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x00017E01 File Offset: 0x00016001
		[global::Cpp2ILInjected.Token(Token = "0x17000233")]
		public int Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x600161F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE2CF0", Offset = "0x1AE2CF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001E8 RID: 488
		[global::Cpp2ILInjected.Token(Token = "0x17000234")]
		public ref char this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001620")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AE2CF8", Offset = "0x1AE2CF8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemName), Member = "TranslateWin32Expression", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x00017E07 File Offset: 0x00016007
		[global::Cpp2ILInjected.Token(Token = "0x6001621")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE2D04", Offset = "0x1AE2D04", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatDecimal", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatDouble", MemberParameters = new object[]
		{
			typeof(double),
			typeof(string),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatSingle", MemberParameters = new object[]
		{
			typeof(float),
			typeof(string),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatInt64", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemName), Member = "TranslateWin32Expression", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00017E0A File Offset: 0x0001600A
		[global::Cpp2ILInjected.Token(Token = "0x6001622")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE2E94", Offset = "0x1AE2E94", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatDecimal", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatDouble", MemberParameters = new object[]
		{
			typeof(double),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatSingle", MemberParameters = new object[]
		{
			typeof(float),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatInt32", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatUInt32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatInt64", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "TryFormatUInt64", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.IFormatProvider),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "TryCopyTo", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public bool TryCopyTo(global::System.Span<char> destination, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00017E0D File Offset: 0x0001600D
		[global::Cpp2ILInjected.Token(Token = "0x6001623")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3114", Offset = "0x1AE3114", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public void Append(char c)
		{
			throw null;
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00017E10 File Offset: 0x00016010
		[global::Cpp2ILInjected.Token(Token = "0x6001624")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE31F8", Offset = "0x1AE31F8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public void Append(string s)
		{
			throw null;
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00017E13 File Offset: 0x00016013
		[global::Cpp2ILInjected.Token(Token = "0x6001625")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3290", Offset = "0x1AE3290", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatCurrency", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatFixed", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(int[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatNumber", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatScientific", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatExponent", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(int),
			typeof(char),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatGeneral", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatPercent", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "CopyTo", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void AppendSlow(string s)
		{
			throw null;
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x00017E16 File Offset: 0x00016016
		[global::Cpp2ILInjected.Token(Token = "0x6001626")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3608", Offset = "0x1AE3608", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatFixed", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(int[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Append(char c, int count)
		{
			throw null;
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00017E19 File Offset: 0x00016019
		[global::Cpp2ILInjected.Token(Token = "0x6001627")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE36E4", Offset = "0x1AE36E4", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatExponent", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(int),
			typeof(char),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public unsafe void Append(char* value, int length)
		{
			throw null;
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00017E1C File Offset: 0x0001601C
		[global::Cpp2ILInjected.Token(Token = "0x6001628")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE37C4", Offset = "0x1AE37C4", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(256)]
		public global::System.Span<char> AppendSpan(int length)
		{
			throw null;
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00017E1F File Offset: 0x0001601F
		[global::Cpp2ILInjected.Token(Token = "0x6001629")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3184", Offset = "0x1AE3184", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "NumberToStringFormat", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatCurrency", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatFixed", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(int[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatNumber", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatScientific", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatExponent", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(int),
			typeof(char),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatGeneral", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatPercent", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Enumeration.FileSystemName), Member = "TranslateWin32Expression", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(8)]
		private void GrowAndAppend(char c)
		{
			throw null;
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x00017E22 File Offset: 0x00016022
		[global::Cpp2ILInjected.Token(Token = "0x600162A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE33B8", Offset = "0x1AE33B8", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Number), Member = "FormatFixed", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref global::System.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.NumberFormatInfo),
			typeof(int[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueStringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueStringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueStringBuilder), Member = "AppendSpan", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Span<char>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "CopyTo", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		[MethodImpl(8)]
		private unsafe void Grow(int requiredAdditionalCapacity)
		{
			throw null;
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00017E25 File Offset: 0x00016025
		[global::Cpp2ILInjected.Token(Token = "0x600162B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AE3884", Offset = "0x1AE3884", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		[MethodImpl(256)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x040008DE RID: 2270
		[global::Cpp2ILInjected.Token(Token = "0x4000B58")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private char[] _arrayToReturnToPool;

		// Token: 0x040008DF RID: 2271
		[global::Cpp2ILInjected.Token(Token = "0x4000B59")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private global::System.Span<char> _chars;

		// Token: 0x040008E0 RID: 2272
		[global::Cpp2ILInjected.Token(Token = "0x4000B5A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _pos;
	}
}
