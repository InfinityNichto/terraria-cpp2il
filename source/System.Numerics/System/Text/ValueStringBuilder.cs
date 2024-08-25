using System;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	[DefaultMember("Item")]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	[global::Cpp2ILInjected.Token(Token = "0x200000A")]
	internal ref struct ValueStringBuilder
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000040")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D57554", Offset = "0x1D57554", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ValueStringBuilder(Span<char> initialBuffer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000003")]
		public int Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000041")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5BD2C", Offset = "0x1D5BD2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000042")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D579B4", Offset = "0x1D579B4", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigNumber), Member = "FormatBigIntegerToHex", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(BigInteger),
			typeof(char),
			typeof(int),
			typeof(NumberFormatInfo),
			typeof(Span<char>),
			typeof(ref int),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(BigInteger),
			typeof(string),
			typeof(ReadOnlySpan<char>),
			typeof(NumberFormatInfo),
			typeof(Span<char>),
			typeof(ref int),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(Span<char>) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(ReadOnlySpan<char>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000043")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D57734", Offset = "0x1D57734", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigNumber), Member = "FormatBigIntegerToHex", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(BigInteger),
			typeof(char),
			typeof(int),
			typeof(NumberFormatInfo),
			typeof(Span<char>),
			typeof(ref int),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigNumber), Member = "FormatBigInteger", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(BigInteger),
			typeof(string),
			typeof(ReadOnlySpan<char>),
			typeof(NumberFormatInfo),
			typeof(Span<char>),
			typeof(ref int),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Span<char>), Member = "TryCopyTo", MemberParameters = new object[] { typeof(Span<char>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public bool TryCopyTo(Span<char> destination, out int charsWritten)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000044")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D57564", Offset = "0x1D57564", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigNumber), Member = "FormatBigIntegerToHex", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(BigInteger),
			typeof(char),
			typeof(int),
			typeof(NumberFormatInfo),
			typeof(Span<char>),
			typeof(ref int),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Span<char>), Member = "CopyTo", MemberParameters = new object[] { typeof(Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Span<char>), Member = "Fill", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void Insert(int index, char value, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000045")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5BF84", Offset = "0x1D5BF84", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public void Append(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000046")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5C068", Offset = "0x1D5C068", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public void Append(string s)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000047")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5C100", Offset = "0x1D5C100", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "NumberToString", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref FormatProvider.Number.NumberBuffer),
			typeof(char),
			typeof(int),
			typeof(NumberFormatInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "FormatCurrency", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref FormatProvider.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "FormatFixed", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref FormatProvider.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(NumberFormatInfo),
			typeof(int[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "FormatNumber", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref FormatProvider.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "FormatScientific", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref FormatProvider.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(NumberFormatInfo),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "FormatExponent", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(NumberFormatInfo),
			typeof(int),
			typeof(char),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "FormatGeneral", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref FormatProvider.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(NumberFormatInfo),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "FormatPercent", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref FormatProvider.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "NumberToStringFormat", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref FormatProvider.Number.NumberBuffer),
			typeof(ReadOnlySpan<char>),
			typeof(NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlySpan<char>), Member = "CopyTo", MemberParameters = new object[] { typeof(Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void AppendSlow(string s)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000048")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5AEE4", Offset = "0x1D5AEE4", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "FormatFixed", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref FormatProvider.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(NumberFormatInfo),
			typeof(int[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Append(char c, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000049")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5AE04", Offset = "0x1D5AE04", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "FormatFixed", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref FormatProvider.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(NumberFormatInfo),
			typeof(int[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public unsafe void Append(char* value, int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600004A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5C228", Offset = "0x1D5C228", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(256)]
		public Span<char> AppendSpan(int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600004B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5BFF4", Offset = "0x1D5BFF4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigNumber), Member = "FormatBigIntegerToHex", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(BigInteger),
			typeof(char),
			typeof(int),
			typeof(NumberFormatInfo),
			typeof(Span<char>),
			typeof(ref int),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "FormatCurrency", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref FormatProvider.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "FormatFixed", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref FormatProvider.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(NumberFormatInfo),
			typeof(int[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "FormatNumber", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref FormatProvider.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "FormatScientific", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref FormatProvider.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(NumberFormatInfo),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "FormatExponent", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(NumberFormatInfo),
			typeof(int),
			typeof(char),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "FormatGeneral", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref FormatProvider.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(NumberFormatInfo),
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "FormatPercent", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref FormatProvider.Number.NumberBuffer),
			typeof(int),
			typeof(int),
			typeof(NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Globalization.FormatProvider.Number", Member = "NumberToStringFormat", MemberParameters = new object[]
		{
			typeof(ref ValueStringBuilder),
			typeof(ref FormatProvider.Number.NumberBuffer),
			typeof(ReadOnlySpan<char>),
			typeof(NumberFormatInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueStringBuilder), Member = "Grow", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(8)]
		private void GrowAndAppend(char c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600004C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5BD34", Offset = "0x1D5BD34", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigNumber), Member = "FormatBigIntegerToHex", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(BigInteger),
			typeof(char),
			typeof(int),
			typeof(NumberFormatInfo),
			typeof(Span<char>),
			typeof(ref int),
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueStringBuilder), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			typeof(int)
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueStringBuilder), Member = "AppendSpan", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Span<char>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueStringBuilder), Member = "GrowAndAppend", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Span<char>), Member = "CopyTo", MemberParameters = new object[] { typeof(Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		[MethodImpl(8)]
		private unsafe void Grow(int requiredAdditionalCapacity)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600004D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5C2E8", Offset = "0x1D5C2E8", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		[MethodImpl(256)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400001A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private char[] _arrayToReturnToPool;

		[global::Cpp2ILInjected.Token(Token = "0x400001B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private Span<char> _chars;

		[global::Cpp2ILInjected.Token(Token = "0x400001C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _pos;
	}
}
