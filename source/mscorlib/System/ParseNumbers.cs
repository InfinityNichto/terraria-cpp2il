using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000BC RID: 188
	[global::Cpp2ILInjected.Token(Token = "0x20000EE")]
	internal static class ParseNumbers
	{
		// Token: 0x0600082E RID: 2094 RVA: 0x00015D01 File Offset: 0x00013F01
		[global::Cpp2ILInjected.Token(Token = "0x60008D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C445C0", Offset = "0x1C445C0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt64", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParseNumbers), Member = "StringToLong", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(long))]
		public static long StringToLong(global::System.ReadOnlySpan<char> s, int radix, int flags)
		{
			throw null;
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00015D04 File Offset: 0x00013F04
		[global::Cpp2ILInjected.Token(Token = "0x60008D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C445D8", Offset = "0x1C445D8", Length = "0x334")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "StringToLong", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int),
			typeof(int),
			typeof(ref long),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParseNumbers), Member = "StringToLong", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParseNumbers), Member = "EatWhiteSpace", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParseNumbers), Member = "GrabLongs", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public static long StringToLong(global::System.ReadOnlySpan<char> s, int radix, int flags, ref int currPos)
		{
			throw null;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00015D07 File Offset: 0x00013F07
		[global::Cpp2ILInjected.Token(Token = "0x60008D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C44B80", Offset = "0x1C44B80", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt32", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParseNumbers), Member = "StringToInt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		public static int StringToInt(global::System.ReadOnlySpan<char> s, int radix, int flags)
		{
			throw null;
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00015D0A File Offset: 0x00013F0A
		[global::Cpp2ILInjected.Token(Token = "0x60008D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C44B98", Offset = "0x1C44B98", Length = "0x388")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Guid), Member = "StringToInt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref global::System.Guid.GuidResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParseNumbers), Member = "StringToInt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParseNumbers), Member = "EatWhiteSpace", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParseNumbers), Member = "GrabInts", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public static int StringToInt(global::System.ReadOnlySpan<char> s, int radix, int flags, ref int currPos)
		{
			throw null;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00015D0D File Offset: 0x00013F0D
		[global::Cpp2ILInjected.Token(Token = "0x60008DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4490C", Offset = "0x1C4490C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParseNumbers), Member = "StringToLong", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParseNumbers), Member = "StringToInt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void EatWhiteSpace(global::System.ReadOnlySpan<char> s, ref int i)
		{
			throw null;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00015D10 File Offset: 0x00013F10
		[global::Cpp2ILInjected.Token(Token = "0x60008DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C449B4", Offset = "0x1C449B4", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParseNumbers), Member = "StringToLong", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParseNumbers), Member = "ThrowOverflowInt64Exception", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParseNumbers), Member = "ThrowOverflowUInt64Exception", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static long GrabLongs(int radix, global::System.ReadOnlySpan<char> s, ref int i, bool isUnsigned)
		{
			throw null;
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00015D13 File Offset: 0x00013F13
		[global::Cpp2ILInjected.Token(Token = "0x60008DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C44F20", Offset = "0x1C44F20", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParseNumbers), Member = "StringToInt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParseNumbers), Member = "ThrowOverflowInt32Exception", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParseNumbers), Member = "ThrowOverflowUInt32Exception", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static int GrabInts(int radix, global::System.ReadOnlySpan<char> s, ref int i, bool isUnsigned)
		{
			throw null;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00015D16 File Offset: 0x00013F16
		[global::Cpp2ILInjected.Token(Token = "0x60008DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C451AC", Offset = "0x1C451AC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParseNumbers), Member = "GrabInts", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void ThrowOverflowInt32Exception()
		{
			throw null;
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00015D19 File Offset: 0x00013F19
		[global::Cpp2ILInjected.Token(Token = "0x60008DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4511C", Offset = "0x1C4511C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParseNumbers), Member = "GrabLongs", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void ThrowOverflowInt64Exception()
		{
			throw null;
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00015D1C File Offset: 0x00013F1C
		[global::Cpp2ILInjected.Token(Token = "0x60008DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C451F4", Offset = "0x1C451F4", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParseNumbers), Member = "GrabInts", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void ThrowOverflowUInt32Exception()
		{
			throw null;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00015D1F File Offset: 0x00013F1F
		[global::Cpp2ILInjected.Token(Token = "0x60008E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C45164", Offset = "0x1C45164", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ParseNumbers), Member = "GrabLongs", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void ThrowOverflowUInt64Exception()
		{
			throw null;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00015D22 File Offset: 0x00013F22
		[global::Cpp2ILInjected.Token(Token = "0x60008E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4523C", Offset = "0x1C4523C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		private static bool IsDigit(char c, int radix, out int result)
		{
			throw null;
		}
	}
}
