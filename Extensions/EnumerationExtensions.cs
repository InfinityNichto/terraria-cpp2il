using System;
using Cpp2IlInjected;

namespace Extensions;

[Cpp2IlInjected.Token(Token = "0x20002FD")]
public static class EnumerationExtensions
{
	[Cpp2IlInjected.Token(Token = "0x200082F")]
	private class _Value
	{
		[Cpp2IlInjected.Token(Token = "0x4007E19")]
		private static Type _UInt64;

		[Cpp2IlInjected.Token(Token = "0x4007E1A")]
		private static Type _UInt32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007E1B")]
		public long? Signed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007E1C")]
		public ulong? Unsigned;

		[Cpp2IlInjected.Token(Token = "0x6004998")]
		[Cpp2IlInjected.Address(RVA = "0x20D25C4", Offset = "0x20D25C4", VA = "0x20D25C4")]
		public _Value(object value, Type type)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001938")]
	[Cpp2IlInjected.Address(RVA = "0x15AACC8", Offset = "0x15AACC8", VA = "0x15AACC8")]
	public static T Include<T>(this Enum value, T append)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001939")]
	[Cpp2IlInjected.Address(RVA = "0x15AAF5C", Offset = "0x15AAF5C", VA = "0x15AAF5C")]
	public static T Remove<T>(this Enum value, T remove)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600193A")]
	[Cpp2IlInjected.Address(RVA = "0x1677FE4", Offset = "0x1677FE4", VA = "0x1677FE4")]
	public static bool Has<T>(this Enum value, T check)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600193B")]
	[Cpp2IlInjected.Address(RVA = "0x16781F4", Offset = "0x16781F4", VA = "0x16781F4")]
	public static bool Missing<T>(this Enum obj, T value)
	{
		return default(bool);
	}
}
