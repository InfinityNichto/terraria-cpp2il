using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System
{
	// Token: 0x02000070 RID: 112
	[global::Cpp2ILInjected.Token(Token = "0x2000097")]
	public static class Convert
	{
		// Token: 0x06000414 RID: 1044 RVA: 0x0001515B File Offset: 0x0001335B
		[global::Cpp2ILInjected.Token(Token = "0x60004AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBBF64", Offset = "0x1BBBF64", Length = "0x368")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "TryFromBase64Chars", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Span<byte>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "GetReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static bool TryDecodeFromUtf16(global::System.ReadOnlySpan<char> utf16, global::System.Span<byte> bytes, out int consumed, out int written)
		{
			throw null;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0001515E File Offset: 0x0001335E
		[global::Cpp2ILInjected.Token(Token = "0x60004AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBC2CC", Offset = "0x1BBC2CC", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		private static int Decode(ref char encodedChars, ref sbyte decodingMap)
		{
			throw null;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00015161 File Offset: 0x00013361
		[global::Cpp2ILInjected.Token(Token = "0x60004B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBC31C", Offset = "0x1BBC31C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		private static void WriteThreeLowOrderBytes(ref byte destination, int value)
		{
			throw null;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00015164 File Offset: 0x00013364
		[global::Cpp2ILInjected.Token(Token = "0x60004B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBC334", Offset = "0x1BBC334", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "InternalFormattedHexString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "ToUInt64", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static global::System.TypeCode GetTypeCode(object value)
		{
			throw null;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00015167 File Offset: 0x00013367
		[global::Cpp2ILInjected.Token(Token = "0x60004B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBC3F8", Offset = "0x1BBC3F8", Length = "0x838")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.Converter), Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonFormatterConverter", Member = "Convert", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.TypeCode)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
		public static object ChangeType(object value, global::System.TypeCode typeCode, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0001516A File Offset: 0x0001336A
		[global::Cpp2ILInjected.Token(Token = "0x60004B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB8510", Offset = "0x1BB8510", Length = "0xBC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "System.IConvertible.ToType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(bool), Member = "System.IConvertible.ToType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(byte), Member = "System.IConvertible.ToType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(char), Member = "System.IConvertible.ToType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DBNull), Member = "System.IConvertible.ToType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "System.IConvertible.ToType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "System.IConvertible.ToType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "System.IConvertible.ToType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "System.IConvertible.ToType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "System.IConvertible.ToType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "System.IConvertible.ToType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "System.IConvertible.ToType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "System.IConvertible.ToType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 69)]
		internal static object DefaultToType(global::System.IConvertible value, global::System.Type targetType, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0001516D File Offset: 0x0001336D
		[global::Cpp2ILInjected.Token(Token = "0x60004B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBCC30", Offset = "0x1BBCC30", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Content.ContentManager", Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.Preferences", Member = "Get", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(string),
			"T"
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.ID.SetFactory", Member = "CreateCustomSet", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T", "System.Object[]" }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static object ChangeType(object value, global::System.Type conversionType)
		{
			throw null;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00015170 File Offset: 0x00013370
		[global::Cpp2ILInjected.Token(Token = "0x60004B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBCCCC", Offset = "0x1BBCCCC", Length = "0xAE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "TryParseEnum", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(bool),
			typeof(ref global::System.Enum.EnumResult)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterConverter), Member = "Convert", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DefaultValueAttribute", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.BaseNumberConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Type),
			typeof(ref object)
		}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonFormatterConverter", Member = "GetTokenValue", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "EnsureType", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			typeof(object),
			typeof(global::System.Globalization.CultureInfo),
			"Newtonsoft.Json.Serialization.JsonContract",
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.Extensions", Member = "Convert", MemberTypeParameters = new object[] { "T", "U" }, MemberParameters = new object[] { "T" }, ReturnType = "U")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 57)]
		public static object ChangeType(object value, global::System.Type conversionType, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00015173 File Offset: 0x00013373
		[global::Cpp2ILInjected.Token(Token = "0x60004B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBD7B4", Offset = "0x1BBD7B4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToChar", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToChar", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToChar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToChar", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToChar", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToChar", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		[MethodImpl(8)]
		private static void ThrowCharOverflowException()
		{
			throw null;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00015176 File Offset: 0x00013376
		[global::Cpp2ILInjected.Token(Token = "0x60004B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBD800", Offset = "0x1BBD800", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		[MethodImpl(8)]
		private static void ThrowByteOverflowException()
		{
			throw null;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00015179 File Offset: 0x00013379
		[global::Cpp2ILInjected.Token(Token = "0x60004B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBD84C", Offset = "0x1BBD84C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		[MethodImpl(8)]
		private static void ThrowSByteOverflowException()
		{
			throw null;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0001517C File Offset: 0x0001337C
		[global::Cpp2ILInjected.Token(Token = "0x60004B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBD898", Offset = "0x1BBD898", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		[MethodImpl(8)]
		private static void ThrowInt16OverflowException()
		{
			throw null;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0001517F File Offset: 0x0001337F
		[global::Cpp2ILInjected.Token(Token = "0x60004BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBD8E4", Offset = "0x1BBD8E4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		[MethodImpl(8)]
		private static void ThrowUInt16OverflowException()
		{
			throw null;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00015182 File Offset: 0x00013382
		[global::Cpp2ILInjected.Token(Token = "0x60004BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBD930", Offset = "0x1BBD930", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		[MethodImpl(8)]
		private static void ThrowInt32OverflowException()
		{
			throw null;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00015185 File Offset: 0x00013385
		[global::Cpp2ILInjected.Token(Token = "0x60004BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBD97C", Offset = "0x1BBD97C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt32", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt32", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt32", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt32", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt32", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		[MethodImpl(8)]
		private static void ThrowUInt32OverflowException()
		{
			throw null;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00015188 File Offset: 0x00013388
		[global::Cpp2ILInjected.Token(Token = "0x60004BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBD9C8", Offset = "0x1BBD9C8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt64", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		[MethodImpl(8)]
		private static void ThrowInt64OverflowException()
		{
			throw null;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0001518B File Offset: 0x0001338B
		[global::Cpp2ILInjected.Token(Token = "0x60004BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDA14", Offset = "0x1BBDA14", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt64", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt64", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt64", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt64", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		[MethodImpl(8)]
		private static void ThrowUInt64OverflowException()
		{
			throw null;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0001518E File Offset: 0x0001338E
		[global::Cpp2ILInjected.Token(Token = "0x60004BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDA60", Offset = "0x1BBDA60", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "System.IConvertible.ToBoolean", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterConverter), Member = "ToBoolean", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ReadAsBoolean", ReturnType = "System.Nullable`1<Boolean>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadAsBoolean", ReturnType = "System.Nullable`1<Boolean>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonWriter", Member = "WriteToken", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonToken",
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<Boolean>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Compare", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Linq.JTokenType",
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "WriteTo", MemberParameters = new object[] { "Newtonsoft.Json.JsonWriter", "Newtonsoft.Json.JsonConverter[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ConvertTokenToXmlValue", MemberParameters = new object[] { "Newtonsoft.Json.JsonReader" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool ToBoolean(object value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00015191 File Offset: 0x00013391
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDB64", Offset = "0x1BBDB64", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToBoolean", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool ToBoolean(sbyte value)
		{
			throw null;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00015194 File Offset: 0x00013394
		[global::Cpp2ILInjected.Token(Token = "0x60004C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9A80", Offset = "0x1BB9A80", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Bson.BsonReader", Member = "ReadType", MemberParameters = new object[] { "Newtonsoft.Json.Bson.BsonType" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool ToBoolean(byte value)
		{
			throw null;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00015197 File Offset: 0x00013397
		[global::Cpp2ILInjected.Token(Token = "0x60004C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDB70", Offset = "0x1BBDB70", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "System.IConvertible.ToBoolean", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool ToBoolean(short value)
		{
			throw null;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0001519A File Offset: 0x0001339A
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDB7C", Offset = "0x1BBDB7C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToBoolean", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool ToBoolean(ushort value)
		{
			throw null;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0001519D File Offset: 0x0001339D
		[global::Cpp2ILInjected.Token(Token = "0x60004C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDB88", Offset = "0x1BBDB88", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "System.IConvertible.ToBoolean", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.NegotiateStreamPal", Member = "EstablishSecurityContext", MemberParameters = new object[]
		{
			"System.Net.Security.SafeFreeNegoCredentials",
			"System.Net.Security.SafeDeleteContext&",
			typeof(string),
			"System.Net.ContextFlagsPal",
			"System.Net.Security.SecurityBuffer",
			"System.Net.Security.SecurityBuffer",
			"System.Net.ContextFlagsPal&"
		}, ReturnType = "System.Net.SecurityStatusPal")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static bool ToBoolean(int value)
		{
			throw null;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x000151A0 File Offset: 0x000133A0
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDB94", Offset = "0x1BBDB94", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToBoolean", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool ToBoolean(uint value)
		{
			throw null;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000151A3 File Offset: 0x000133A3
		[global::Cpp2ILInjected.Token(Token = "0x60004C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDBA0", Offset = "0x1BBDBA0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "System.IConvertible.ToBoolean", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool ToBoolean(long value)
		{
			throw null;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000151A6 File Offset: 0x000133A6
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDBAC", Offset = "0x1BBDBAC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToBoolean", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool ToBoolean(ulong value)
		{
			throw null;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000151A9 File Offset: 0x000133A9
		[global::Cpp2ILInjected.Token(Token = "0x60004C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDBB8", Offset = "0x1BBDBB8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "System.IConvertible.ToBoolean", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool ToBoolean(string value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x000151AC File Offset: 0x000133AC
		[global::Cpp2ILInjected.Token(Token = "0x60004C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDC20", Offset = "0x1BBDC20", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "System.IConvertible.ToBoolean", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool ToBoolean(float value)
		{
			throw null;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000151AF File Offset: 0x000133AF
		[global::Cpp2ILInjected.Token(Token = "0x60004CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDC2C", Offset = "0x1BBDC2C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "System.IConvertible.ToBoolean", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool ToBoolean(double value)
		{
			throw null;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000151B2 File Offset: 0x000133B2
		[global::Cpp2ILInjected.Token(Token = "0x60004CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDC38", Offset = "0x1BBDC38", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "System.IConvertible.ToBoolean", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(decimal)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool ToBoolean(decimal value)
		{
			throw null;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x000151B5 File Offset: 0x000133B5
		[global::Cpp2ILInjected.Token(Token = "0x60004CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDCAC", Offset = "0x1BBDCAC", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "System.IConvertible.ToChar", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<Char>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static char ToChar(object value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000151B8 File Offset: 0x000133B8
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDDB0", Offset = "0x1BBDDB0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToChar", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowCharOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static char ToChar(sbyte value)
		{
			throw null;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000151BB File Offset: 0x000133BB
		[global::Cpp2ILInjected.Token(Token = "0x60004CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9AE4", Offset = "0x1BB9AE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Extension", Member = "WriteLine", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static char ToChar(byte value)
		{
			throw null;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x000151BE File Offset: 0x000133BE
		[global::Cpp2ILInjected.Token(Token = "0x60004CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDE04", Offset = "0x1BBDE04", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "System.IConvertible.ToChar", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowCharOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static char ToChar(short value)
		{
			throw null;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x000151C1 File Offset: 0x000133C1
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDE5C", Offset = "0x1BBDE5C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToChar", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static char ToChar(ushort value)
		{
			throw null;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x000151C4 File Offset: 0x000133C4
		[global::Cpp2ILInjected.Token(Token = "0x60004D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDE60", Offset = "0x1BBDE60", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "System.IConvertible.ToChar", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseUnicode", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowCharOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static char ToChar(int value)
		{
			throw null;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000151C7 File Offset: 0x000133C7
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDEB8", Offset = "0x1BBDEB8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToChar", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowCharOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static char ToChar(uint value)
		{
			throw null;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000151CA File Offset: 0x000133CA
		[global::Cpp2ILInjected.Token(Token = "0x60004D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDF10", Offset = "0x1BBDF10", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "System.IConvertible.ToChar", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowCharOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static char ToChar(long value)
		{
			throw null;
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000151CD File Offset: 0x000133CD
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDF68", Offset = "0x1BBDF68", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToChar", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowCharOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static char ToChar(ulong value)
		{
			throw null;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x000151D0 File Offset: 0x000133D0
		[global::Cpp2ILInjected.Token(Token = "0x60004D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBDFC0", Offset = "0x1BBDFC0", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "System.IConvertible.ToChar", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static char ToChar(string value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x000151D3 File Offset: 0x000133D3
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE05C", Offset = "0x1BBE05C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "System.IConvertible.ToSByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<SByte>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static sbyte ToSByte(object value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000151D6 File Offset: 0x000133D6
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB7F70", Offset = "0x1BB7F70", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static sbyte ToSByte(bool value)
		{
			throw null;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000151D9 File Offset: 0x000133D9
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBAB94", Offset = "0x1BBAB94", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static sbyte ToSByte(char value)
		{
			throw null;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x000151DC File Offset: 0x000133DC
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9B44", Offset = "0x1BB9B44", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static sbyte ToSByte(byte value)
		{
			throw null;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x000151DF File Offset: 0x000133DF
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE160", Offset = "0x1BBE160", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "System.IConvertible.ToSByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static sbyte ToSByte(short value)
		{
			throw null;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000151E2 File Offset: 0x000133E2
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE1C0", Offset = "0x1BBE1C0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToSByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static sbyte ToSByte(ushort value)
		{
			throw null;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000151E5 File Offset: 0x000133E5
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE21C", Offset = "0x1BBE21C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "System.IConvertible.ToSByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static sbyte ToSByte(int value)
		{
			throw null;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000151E8 File Offset: 0x000133E8
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE274", Offset = "0x1BBE274", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToSByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static sbyte ToSByte(uint value)
		{
			throw null;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x000151EB File Offset: 0x000133EB
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE2CC", Offset = "0x1BBE2CC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "System.IConvertible.ToSByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static sbyte ToSByte(long value)
		{
			throw null;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000151EE File Offset: 0x000133EE
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE324", Offset = "0x1BBE324", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToSByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static sbyte ToSByte(ulong value)
		{
			throw null;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x000151F1 File Offset: 0x000133F1
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE37C", Offset = "0x1BBE37C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "System.IConvertible.ToSByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static sbyte ToSByte(float value)
		{
			throw null;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x000151F4 File Offset: 0x000133F4
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE3D8", Offset = "0x1BBE3D8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "System.IConvertible.ToSByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static sbyte ToSByte(double value)
		{
			throw null;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x000151F7 File Offset: 0x000133F7
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE530", Offset = "0x1BBE530", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "System.IConvertible.ToSByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "Round", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToSByte", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static sbyte ToSByte(decimal value)
		{
			throw null;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x000151FA File Offset: 0x000133FA
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE5A4", Offset = "0x1BBE5A4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "System.IConvertible.ToSByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(sbyte), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(sbyte))]
		public static sbyte ToSByte(string value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x000151FD File Offset: 0x000133FD
		[global::Cpp2ILInjected.Token(Token = "0x60004E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE5B4", Offset = "0x1BBE5B4", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "System.IConvertible.ToByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadArrayIntoByteArray", ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<Byte>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.BinaryConverter", Member = "ReadByteArray", MemberParameters = new object[] { "Newtonsoft.Json.JsonReader" }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static byte ToByte(object value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00015200 File Offset: 0x00013400
		[global::Cpp2ILInjected.Token(Token = "0x60004E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB7FD4", Offset = "0x1BB7FD4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "InternalFormattedHexString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static byte ToByte(bool value)
		{
			throw null;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00015203 File Offset: 0x00013403
		[global::Cpp2ILInjected.Token(Token = "0x60004E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBAC48", Offset = "0x1BBAC48", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte ToByte(char value)
		{
			throw null;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00015206 File Offset: 0x00013406
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE6B8", Offset = "0x1BBE6B8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte ToByte(sbyte value)
		{
			throw null;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00015209 File Offset: 0x00013409
		[global::Cpp2ILInjected.Token(Token = "0x60004E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE710", Offset = "0x1BBE710", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "System.IConvertible.ToByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte ToByte(short value)
		{
			throw null;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0001520C File Offset: 0x0001340C
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE76C", Offset = "0x1BBE76C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte ToByte(ushort value)
		{
			throw null;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0001520F File Offset: 0x0001340F
		[global::Cpp2ILInjected.Token(Token = "0x60004EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE7C8", Offset = "0x1BBE7C8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "System.IConvertible.ToByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoConfig), Member = "EncodeOID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte ToByte(int value)
		{
			throw null;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00015212 File Offset: 0x00013412
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE820", Offset = "0x1BBE820", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte ToByte(uint value)
		{
			throw null;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00015215 File Offset: 0x00013415
		[global::Cpp2ILInjected.Token(Token = "0x60004EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE878", Offset = "0x1BBE878", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "System.IConvertible.ToByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoConfig), Member = "EncodeOID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoConfig), Member = "EncodeLongNumber", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte ToByte(long value)
		{
			throw null;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00015218 File Offset: 0x00013418
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE8D0", Offset = "0x1BBE8D0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte ToByte(ulong value)
		{
			throw null;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0001521B File Offset: 0x0001341B
		[global::Cpp2ILInjected.Token(Token = "0x60004EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE928", Offset = "0x1BBE928", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "System.IConvertible.ToByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte ToByte(float value)
		{
			throw null;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0001521E File Offset: 0x0001341E
		[global::Cpp2ILInjected.Token(Token = "0x60004EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE984", Offset = "0x1BBE984", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "System.IConvertible.ToByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte ToByte(double value)
		{
			throw null;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00015221 File Offset: 0x00013421
		[global::Cpp2ILInjected.Token(Token = "0x60004F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE9E4", Offset = "0x1BBE9E4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "System.IConvertible.ToByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "Round", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToByte", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte ToByte(decimal value)
		{
			throw null;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00015224 File Offset: 0x00013424
		[global::Cpp2ILInjected.Token(Token = "0x60004F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBEA58", Offset = "0x1BBEA58", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoConfig), Member = "EncodeOID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte ToByte(string value)
		{
			throw null;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00015227 File Offset: 0x00013427
		[global::Cpp2ILInjected.Token(Token = "0x60004F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBEACC", Offset = "0x1BBEACC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "System.IConvertible.ToByte", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "GetPortV4", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(byte))]
		public static byte ToByte(string value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0001522A File Offset: 0x0001342A
		[global::Cpp2ILInjected.Token(Token = "0x60004F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBEAE0", Offset = "0x1BBEAE0", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "System.IConvertible.ToInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<Int16>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static short ToInt16(object value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0001522D File Offset: 0x0001342D
		[global::Cpp2ILInjected.Token(Token = "0x60004F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB8038", Offset = "0x1BB8038", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static short ToInt16(bool value)
		{
			throw null;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00015230 File Offset: 0x00013430
		[global::Cpp2ILInjected.Token(Token = "0x60004F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBACFC", Offset = "0x1BBACFC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowInt16OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static short ToInt16(char value)
		{
			throw null;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00015233 File Offset: 0x00013433
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBEBE4", Offset = "0x1BBEBE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static short ToInt16(sbyte value)
		{
			throw null;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00015236 File Offset: 0x00013436
		[global::Cpp2ILInjected.Token(Token = "0x60004F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9BFC", Offset = "0x1BB9BFC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static short ToInt16(byte value)
		{
			throw null;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00015239 File Offset: 0x00013439
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBEBEC", Offset = "0x1BBEBEC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowInt16OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static short ToInt16(ushort value)
		{
			throw null;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0001523C File Offset: 0x0001343C
		[global::Cpp2ILInjected.Token(Token = "0x60004F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBEC44", Offset = "0x1BBEC44", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "System.IConvertible.ToInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowInt16OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static short ToInt16(int value)
		{
			throw null;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0001523F File Offset: 0x0001343F
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBEC9C", Offset = "0x1BBEC9C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowInt16OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static short ToInt16(uint value)
		{
			throw null;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00015242 File Offset: 0x00013442
		[global::Cpp2ILInjected.Token(Token = "0x60004FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBECF4", Offset = "0x1BBECF4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "System.IConvertible.ToInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowInt16OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static short ToInt16(long value)
		{
			throw null;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00015245 File Offset: 0x00013445
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60004FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBED4C", Offset = "0x1BBED4C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowInt16OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static short ToInt16(ulong value)
		{
			throw null;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00015248 File Offset: 0x00013448
		[global::Cpp2ILInjected.Token(Token = "0x60004FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBEDA4", Offset = "0x1BBEDA4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "System.IConvertible.ToInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static short ToInt16(float value)
		{
			throw null;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0001524B File Offset: 0x0001344B
		[global::Cpp2ILInjected.Token(Token = "0x60004FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBEE00", Offset = "0x1BBEE00", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "System.IConvertible.ToInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static short ToInt16(double value)
		{
			throw null;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0001524E File Offset: 0x0001344E
		[global::Cpp2ILInjected.Token(Token = "0x60004FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBEE60", Offset = "0x1BBEE60", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "System.IConvertible.ToInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "Round", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToInt16", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static short ToInt16(decimal value)
		{
			throw null;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00015251 File Offset: 0x00013451
		[global::Cpp2ILInjected.Token(Token = "0x6000500")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBEED4", Offset = "0x1BBEED4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "System.IConvertible.ToInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "GetLastModifiedFrom213Response", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "CheckValid", MemberParameters = new object[]
		{
			"System.Net.ResponseDescription",
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.ASN1Convert", Member = "ToDateTime", MemberParameters = new object[] { "Mono.Security.ASN1" }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(short))]
		public static short ToInt16(string value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00015254 File Offset: 0x00013454
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000501")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBEEEC", Offset = "0x1BBEEEC", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "System.IConvertible.ToUInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<UInt16>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static ushort ToUInt16(object value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00015257 File Offset: 0x00013457
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000502")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB809C", Offset = "0x1BB809C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static ushort ToUInt16(bool value)
		{
			throw null;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0001525A File Offset: 0x0001345A
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000503")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBADAC", Offset = "0x1BBADAC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static ushort ToUInt16(char value)
		{
			throw null;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0001525D File Offset: 0x0001345D
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000504")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBEFF0", Offset = "0x1BBEFF0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToUInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowUInt16OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ushort ToUInt16(sbyte value)
		{
			throw null;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00015260 File Offset: 0x00013460
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000505")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9C5C", Offset = "0x1BB9C5C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static ushort ToUInt16(byte value)
		{
			throw null;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00015263 File Offset: 0x00013463
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000506")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF044", Offset = "0x1BBF044", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "System.IConvertible.ToUInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowUInt16OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ushort ToUInt16(short value)
		{
			throw null;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00015266 File Offset: 0x00013466
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000507")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF09C", Offset = "0x1BBF09C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "System.IConvertible.ToUInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowUInt16OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ushort ToUInt16(int value)
		{
			throw null;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00015269 File Offset: 0x00013469
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000508")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF0F4", Offset = "0x1BBF0F4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToUInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowUInt16OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ushort ToUInt16(uint value)
		{
			throw null;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0001526C File Offset: 0x0001346C
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000509")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF14C", Offset = "0x1BBF14C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "System.IConvertible.ToUInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowUInt16OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ushort ToUInt16(long value)
		{
			throw null;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0001526F File Offset: 0x0001346F
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600050A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF1A4", Offset = "0x1BBF1A4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToUInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowUInt16OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ushort ToUInt16(ulong value)
		{
			throw null;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00015272 File Offset: 0x00013472
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600050B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF1FC", Offset = "0x1BBF1FC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "System.IConvertible.ToUInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ushort ToUInt16(float value)
		{
			throw null;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00015275 File Offset: 0x00013475
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600050C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF258", Offset = "0x1BBF258", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "System.IConvertible.ToUInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ushort ToUInt16(double value)
		{
			throw null;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00015278 File Offset: 0x00013478
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600050D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF2B8", Offset = "0x1BBF2B8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "System.IConvertible.ToUInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "Round", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToUInt16", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ushort ToUInt16(decimal value)
		{
			throw null;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0001527B File Offset: 0x0001347B
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600050E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF32C", Offset = "0x1BBF32C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "System.IConvertible.ToUInt16", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(ushort))]
		public static ushort ToUInt16(string value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0001527E File Offset: 0x0001347E
		[global::Cpp2ILInjected.Token(Token = "0x600050F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF344", Offset = "0x1BBF344", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Reflection.IdDictionary.<>c__DisplayClass15_0", Member = "<Create>b__2", MemberParameters = new object[] { typeof(global::System.Reflection.FieldInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Reflection.IdDictionary", Member = "Create", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = "ReLogic.Reflection.IdDictionary")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ObjRef), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static int ToInt32(object value)
		{
			throw null;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00015281 File Offset: 0x00013481
		[global::Cpp2ILInjected.Token(Token = "0x6000510")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF438", Offset = "0x1BBF438", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "System.IConvertible.ToInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterConverter), Member = "ToInt32", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadAsInt32", ReturnType = "System.Nullable`1<Int32>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<Int32>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Bson.BsonBinaryWriter", Member = "WriteTokenInternal", MemberParameters = new object[] { "Newtonsoft.Json.Bson.BsonToken" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.Extensions.KeyUsageExtension", Member = "Support", MemberParameters = new object[] { "Mono.Security.X509.Extensions.KeyUsages" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static int ToInt32(object value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00015284 File Offset: 0x00013484
		[global::Cpp2ILInjected.Token(Token = "0x6000511")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB8100", Offset = "0x1BB8100", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int ToInt32(bool value)
		{
			throw null;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00015287 File Offset: 0x00013487
		[global::Cpp2ILInjected.Token(Token = "0x6000512")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBAE08", Offset = "0x1BBAE08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int ToInt32(char value)
		{
			throw null;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0001528A File Offset: 0x0001348A
		[global::Cpp2ILInjected.Token(Token = "0x6000513")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9CBC", Offset = "0x1BB9CBC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int ToInt32(byte value)
		{
			throw null;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0001528D File Offset: 0x0001348D
		[global::Cpp2ILInjected.Token(Token = "0x6000514")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF53C", Offset = "0x1BBF53C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "System.IConvertible.ToInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static int ToInt32(short value)
		{
			throw null;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00015290 File Offset: 0x00013490
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000515")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF544", Offset = "0x1BBF544", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static int ToInt32(ushort value)
		{
			throw null;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00015293 File Offset: 0x00013493
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000516")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF54C", Offset = "0x1BBF54C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowInt32OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int ToInt32(uint value)
		{
			throw null;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00015296 File Offset: 0x00013496
		[global::Cpp2ILInjected.Token(Token = "0x6000517")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF5A0", Offset = "0x1BBF5A0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "System.IConvertible.ToInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowInt32OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int ToInt32(long value)
		{
			throw null;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00015299 File Offset: 0x00013499
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000518")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF5F8", Offset = "0x1BBF5F8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative.GssBuffer", Member = "Copy", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative.GssBuffer", Member = "ToByteArray", ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowInt32OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int ToInt32(ulong value)
		{
			throw null;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0001529C File Offset: 0x0001349C
		[global::Cpp2ILInjected.Token(Token = "0x6000519")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF650", Offset = "0x1BBF650", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "System.IConvertible.ToInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int ToInt32(float value)
		{
			throw null;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0001529F File Offset: 0x0001349F
		[global::Cpp2ILInjected.Token(Token = "0x600051A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBE438", Offset = "0x1BBE438", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "System.IConvertible.ToInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static int ToInt32(double value)
		{
			throw null;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x000152A2 File Offset: 0x000134A2
		[global::Cpp2ILInjected.Token(Token = "0x600051B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF6AC", Offset = "0x1BBF6AC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "System.IConvertible.ToInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "Round", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToInt32", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int ToInt32(decimal value)
		{
			throw null;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x000152A5 File Offset: 0x000134A5
		[global::Cpp2ILInjected.Token(Token = "0x600051C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF720", Offset = "0x1BBF720", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Input.GamepadTranslator", Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "setServerWorldRollbacks", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "LoadDedConfig", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.LaunchInitializer", Member = "LoadServerParameters", MemberParameters = new object[] { "Terraria.Main" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.VersionInfo", Member = "UnityVersion", ReturnType = "InControl.VersionInfo")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int ToInt32(string value)
		{
			throw null;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000152A8 File Offset: 0x000134A8
		[global::Cpp2ILInjected.Token(Token = "0x600051D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF798", Offset = "0x1BBF798", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "System.IConvertible.ToInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "GetLastModifiedFrom213Response", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "GetPortV6", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.JPath", Member = "ParseArrayIndexer", MemberParameters = new object[] { typeof(char) }, ReturnType = "Newtonsoft.Json.Linq.JsonPath.PathFilter")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(int))]
		public static int ToInt32(string value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000152AB File Offset: 0x000134AB
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600051E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF7B0", Offset = "0x1BBF7B0", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.TouchScreenKeyboard", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			"UnityEngine.TouchScreenKeyboardType",
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static uint ToUInt32(object value)
		{
			throw null;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x000152AE File Offset: 0x000134AE
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600051F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF8A4", Offset = "0x1BBF8A4", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "System.IConvertible.ToUInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<UInt32>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static uint ToUInt32(object value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x000152B1 File Offset: 0x000134B1
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000520")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB8164", Offset = "0x1BB8164", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.TouchScreenKeyboard", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			"UnityEngine.TouchScreenKeyboardType",
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static uint ToUInt32(bool value)
		{
			throw null;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x000152B4 File Offset: 0x000134B4
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000521")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBAE68", Offset = "0x1BBAE68", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static uint ToUInt32(char value)
		{
			throw null;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000152B7 File Offset: 0x000134B7
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000522")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF9A8", Offset = "0x1BBF9A8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToUInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowUInt32OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static uint ToUInt32(sbyte value)
		{
			throw null;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x000152BA File Offset: 0x000134BA
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000523")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9D1C", Offset = "0x1BB9D1C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static uint ToUInt32(byte value)
		{
			throw null;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x000152BD File Offset: 0x000134BD
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000524")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBF9FC", Offset = "0x1BBF9FC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "System.IConvertible.ToUInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowUInt32OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static uint ToUInt32(short value)
		{
			throw null;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x000152C0 File Offset: 0x000134C0
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000525")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBFA50", Offset = "0x1BBFA50", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToUInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static uint ToUInt32(ushort value)
		{
			throw null;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000152C3 File Offset: 0x000134C3
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000526")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBFA58", Offset = "0x1BBFA58", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "System.IConvertible.ToUInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowUInt32OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static uint ToUInt32(int value)
		{
			throw null;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000152C6 File Offset: 0x000134C6
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000527")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBFAAC", Offset = "0x1BBFAAC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "System.IConvertible.ToUInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowUInt32OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static uint ToUInt32(long value)
		{
			throw null;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000152C9 File Offset: 0x000134C9
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000528")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBFB04", Offset = "0x1BBFB04", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToUInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowUInt32OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static uint ToUInt32(ulong value)
		{
			throw null;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000152CC File Offset: 0x000134CC
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000529")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBFB5C", Offset = "0x1BBFB5C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "System.IConvertible.ToUInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static uint ToUInt32(float value)
		{
			throw null;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x000152CF File Offset: 0x000134CF
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600052A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBFBB8", Offset = "0x1BBFBB8", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "System.IConvertible.ToUInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static uint ToUInt32(double value)
		{
			throw null;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x000152D2 File Offset: 0x000134D2
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600052B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBFC5C", Offset = "0x1BBFC5C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "System.IConvertible.ToUInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "Round", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToUInt32", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static uint ToUInt32(decimal value)
		{
			throw null;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x000152D5 File Offset: 0x000134D5
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600052C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBFCD0", Offset = "0x1BBFCD0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "System.IConvertible.ToUInt32", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(uint))]
		public static uint ToUInt32(string value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x000152D8 File Offset: 0x000134D8
		[global::Cpp2ILInjected.Token(Token = "0x600052D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBFCE8", Offset = "0x1BBFCE8", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Extensions.EnumerationExtensions._Value", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Extensions.EnumerationExtensions", Member = "Include", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(global::System.Enum),
			"T"
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Extensions.EnumerationExtensions", Member = "Remove", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(global::System.Enum),
			"T"
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Extensions.EnumerationExtensions", Member = "Has", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(global::System.Enum),
			"T"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Lang.<>c__DisplayClass52_0`2", Member = "<FillNameCacheArray>b__1", MemberParameters = new object[] { typeof(global::System.Reflection.FieldInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static long ToInt64(object value)
		{
			throw null;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x000152DB File Offset: 0x000134DB
		[global::Cpp2ILInjected.Token(Token = "0x600052E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBFDDC", Offset = "0x1BBFDDC", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "ToUInt64", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "System.IConvertible.ToInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterConverter), Member = "ToInt64", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertFrom", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonWriter", Member = "WriteToken", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonToken",
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<Int64>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Compare", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Linq.JTokenType",
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "WriteTo", MemberParameters = new object[] { "Newtonsoft.Json.JsonWriter", "Newtonsoft.Json.JsonConverter[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ConvertTokenToXmlValue", MemberParameters = new object[] { "Newtonsoft.Json.JsonReader" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Bson.BsonBinaryWriter", Member = "WriteTokenInternal", MemberParameters = new object[] { "Newtonsoft.Json.Bson.BsonToken" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static long ToInt64(object value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x000152DE File Offset: 0x000134DE
		[global::Cpp2ILInjected.Token(Token = "0x600052F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB81C8", Offset = "0x1BB81C8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static long ToInt64(bool value)
		{
			throw null;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x000152E1 File Offset: 0x000134E1
		[global::Cpp2ILInjected.Token(Token = "0x6000530")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBAEC8", Offset = "0x1BBAEC8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static long ToInt64(char value)
		{
			throw null;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x000152E4 File Offset: 0x000134E4
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000531")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBFEE0", Offset = "0x1BBFEE0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static long ToInt64(sbyte value)
		{
			throw null;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x000152E7 File Offset: 0x000134E7
		[global::Cpp2ILInjected.Token(Token = "0x6000532")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9D7C", Offset = "0x1BB9D7C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static long ToInt64(byte value)
		{
			throw null;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x000152EA File Offset: 0x000134EA
		[global::Cpp2ILInjected.Token(Token = "0x6000533")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBFEE8", Offset = "0x1BBFEE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualControllerInputState.<>c", Member = "<SetupLookups>b__3_1", MemberParameters = new object[] { typeof(global::System.Reflection.FieldInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "System.IConvertible.ToInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static long ToInt64(short value)
		{
			throw null;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x000152ED File Offset: 0x000134ED
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000534")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBFEF0", Offset = "0x1BBFEF0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static long ToInt64(ushort value)
		{
			throw null;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000152F0 File Offset: 0x000134F0
		[global::Cpp2ILInjected.Token(Token = "0x6000535")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBFEF8", Offset = "0x1BBFEF8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "System.IConvertible.ToInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static long ToInt64(int value)
		{
			throw null;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x000152F3 File Offset: 0x000134F3
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000536")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBFF00", Offset = "0x1BBFF00", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static long ToInt64(uint value)
		{
			throw null;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x000152F6 File Offset: 0x000134F6
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000537")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBFF08", Offset = "0x1BBFF08", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowInt64OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static long ToInt64(ulong value)
		{
			throw null;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x000152F9 File Offset: 0x000134F9
		[global::Cpp2ILInjected.Token(Token = "0x6000538")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBFF5C", Offset = "0x1BBFF5C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "System.IConvertible.ToInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static long ToInt64(float value)
		{
			throw null;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x000152FC File Offset: 0x000134FC
		[global::Cpp2ILInjected.Token(Token = "0x6000539")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBFFB8", Offset = "0x1BBFFB8", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "System.IConvertible.ToInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static long ToInt64(double value)
		{
			throw null;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x000152FF File Offset: 0x000134FF
		[global::Cpp2ILInjected.Token(Token = "0x600053A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC00C8", Offset = "0x1BC00C8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "System.IConvertible.ToInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "Round", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static long ToInt64(decimal value)
		{
			throw null;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00015302 File Offset: 0x00013502
		[global::Cpp2ILInjected.Token(Token = "0x600053B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC013C", Offset = "0x1BC013C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoConfig), Member = "EncodeOID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static long ToInt64(string value)
		{
			throw null;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00015305 File Offset: 0x00013505
		[global::Cpp2ILInjected.Token(Token = "0x600053C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC01B4", Offset = "0x1BC01B4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "System.IConvertible.ToInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpControlStream", Member = "GetContentLengthFrom213Response", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(long))]
		public static long ToInt64(string value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00015308 File Offset: 0x00013508
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600053D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC01CC", Offset = "0x1BC01CC", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Extensions.EnumerationExtensions._Value", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Extensions.EnumerationExtensions", Member = "Include", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(global::System.Enum),
			"T"
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Extensions.EnumerationExtensions", Member = "Remove", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(global::System.Enum),
			"T"
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Extensions.EnumerationExtensions", Member = "Has", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(global::System.Enum),
			"T"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static ulong ToUInt64(object value)
		{
			throw null;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0001530B File Offset: 0x0001350B
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600053E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC02C0", Offset = "0x1BC02C0", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "ToUInt64", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "System.IConvertible.ToUInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<UInt64>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static ulong ToUInt64(object value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0001530E File Offset: 0x0001350E
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600053F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB822C", Offset = "0x1BB822C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static ulong ToUInt64(bool value)
		{
			throw null;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00015311 File Offset: 0x00013511
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000540")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BBAF28", Offset = "0x1BBAF28", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static ulong ToUInt64(char value)
		{
			throw null;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00015314 File Offset: 0x00013514
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000541")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC03C4", Offset = "0x1BC03C4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToUInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowUInt64OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ulong ToUInt64(sbyte value)
		{
			throw null;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00015317 File Offset: 0x00013517
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000542")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9DDC", Offset = "0x1BB9DDC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static ulong ToUInt64(byte value)
		{
			throw null;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0001531A File Offset: 0x0001351A
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000543")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC041C", Offset = "0x1BC041C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "System.IConvertible.ToUInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowUInt64OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ulong ToUInt64(short value)
		{
			throw null;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0001531D File Offset: 0x0001351D
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000544")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0474", Offset = "0x1BC0474", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToUInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static ulong ToUInt64(ushort value)
		{
			throw null;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00015320 File Offset: 0x00013520
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000545")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC047C", Offset = "0x1BC047C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "System.IConvertible.ToUInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowUInt64OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ulong ToUInt64(int value)
		{
			throw null;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00015323 File Offset: 0x00013523
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000546")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC04D0", Offset = "0x1BC04D0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToUInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static ulong ToUInt64(uint value)
		{
			throw null;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00015326 File Offset: 0x00013526
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000547")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC04D8", Offset = "0x1BC04D8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "System.IConvertible.ToUInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowUInt64OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ulong ToUInt64(long value)
		{
			throw null;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00015329 File Offset: 0x00013529
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000548")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC052C", Offset = "0x1BC052C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "System.IConvertible.ToUInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ulong ToUInt64(float value)
		{
			throw null;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0001532C File Offset: 0x0001352C
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000549")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0588", Offset = "0x1BC0588", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "System.IConvertible.ToUInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static ulong ToUInt64(double value)
		{
			throw null;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0001532F File Offset: 0x0001352F
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600054A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0684", Offset = "0x1BC0684", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "System.IConvertible.ToUInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "Round", MemberParameters = new object[]
		{
			typeof(decimal),
			typeof(int)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToUInt64", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ulong ToUInt64(decimal value)
		{
			throw null;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00015332 File Offset: 0x00013532
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600054B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC06F8", Offset = "0x1BC06F8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "System.IConvertible.ToUInt64", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(ulong))]
		public static ulong ToUInt64(string value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00015335 File Offset: 0x00013535
		[global::Cpp2ILInjected.Token(Token = "0x600054C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0710", Offset = "0x1BC0710", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "System.IConvertible.ToSingle", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterConverter), Member = "ToSingle", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<Single>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static float ToSingle(object value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00015338 File Offset: 0x00013538
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600054D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0814", Offset = "0x1BC0814", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToSingle", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static float ToSingle(sbyte value)
		{
			throw null;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0001533B File Offset: 0x0001353B
		[global::Cpp2ILInjected.Token(Token = "0x600054E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9E3C", Offset = "0x1BB9E3C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static float ToSingle(byte value)
		{
			throw null;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0001533E File Offset: 0x0001353E
		[global::Cpp2ILInjected.Token(Token = "0x600054F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0820", Offset = "0x1BC0820", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "System.IConvertible.ToSingle", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static float ToSingle(short value)
		{
			throw null;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00015341 File Offset: 0x00013541
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000550")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC082C", Offset = "0x1BC082C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToSingle", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static float ToSingle(ushort value)
		{
			throw null;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00015344 File Offset: 0x00013544
		[global::Cpp2ILInjected.Token(Token = "0x6000551")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0838", Offset = "0x1BC0838", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "System.IConvertible.ToSingle", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static float ToSingle(int value)
		{
			throw null;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00015347 File Offset: 0x00013547
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000552")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0840", Offset = "0x1BC0840", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToSingle", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static float ToSingle(uint value)
		{
			throw null;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0001534A File Offset: 0x0001354A
		[global::Cpp2ILInjected.Token(Token = "0x6000553")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC084C", Offset = "0x1BC084C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "System.IConvertible.ToSingle", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static float ToSingle(long value)
		{
			throw null;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0001534D File Offset: 0x0001354D
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000554")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0854", Offset = "0x1BC0854", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToSingle", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static float ToSingle(ulong value)
		{
			throw null;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00015350 File Offset: 0x00013550
		[global::Cpp2ILInjected.Token(Token = "0x6000555")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0860", Offset = "0x1BC0860", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "System.IConvertible.ToSingle", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static float ToSingle(double value)
		{
			throw null;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00015353 File Offset: 0x00013553
		[global::Cpp2ILInjected.Token(Token = "0x6000556")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0868", Offset = "0x1BC0868", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "System.IConvertible.ToSingle", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Explicit", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static float ToSingle(decimal value)
		{
			throw null;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00015356 File Offset: 0x00013556
		[global::Cpp2ILInjected.Token(Token = "0x6000557")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC08D0", Offset = "0x1BC08D0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "System.IConvertible.ToSingle", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.SingleConverter", Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(float))]
		public static float ToSingle(string value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00015359 File Offset: 0x00013559
		[global::Cpp2ILInjected.Token(Token = "0x6000558")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB8298", Offset = "0x1BB8298", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static float ToSingle(bool value)
		{
			throw null;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0001535C File Offset: 0x0001355C
		[global::Cpp2ILInjected.Token(Token = "0x6000559")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC08EC", Offset = "0x1BC08EC", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "System.IConvertible.ToDouble", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadAsDouble", ReturnType = "System.Nullable`1<Double>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonWriter", Member = "WriteToken", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonToken",
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.MiscellaneousUtils", Member = "ValueEquals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<Double>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "CompareFloat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "WriteTo", MemberParameters = new object[] { "Newtonsoft.Json.JsonWriter", "Newtonsoft.Json.JsonConverter[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ConvertTokenToXmlValue", MemberParameters = new object[] { "Newtonsoft.Json.JsonReader" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Bson.BsonBinaryWriter", Member = "WriteTokenInternal", MemberParameters = new object[] { "Newtonsoft.Json.Bson.BsonToken" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static double ToDouble(object value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0001535F File Offset: 0x0001355F
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600055A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC09F0", Offset = "0x1BC09F0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToDouble", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static double ToDouble(sbyte value)
		{
			throw null;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00015362 File Offset: 0x00013562
		[global::Cpp2ILInjected.Token(Token = "0x600055B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9EA0", Offset = "0x1BB9EA0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static double ToDouble(byte value)
		{
			throw null;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00015365 File Offset: 0x00013565
		[global::Cpp2ILInjected.Token(Token = "0x600055C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC09FC", Offset = "0x1BC09FC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "System.IConvertible.ToDouble", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static double ToDouble(short value)
		{
			throw null;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00015368 File Offset: 0x00013568
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600055D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0A08", Offset = "0x1BC0A08", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToDouble", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static double ToDouble(ushort value)
		{
			throw null;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0001536B File Offset: 0x0001356B
		[global::Cpp2ILInjected.Token(Token = "0x600055E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0A14", Offset = "0x1BC0A14", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "System.IConvertible.ToDouble", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static double ToDouble(int value)
		{
			throw null;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0001536E File Offset: 0x0001356E
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600055F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0A1C", Offset = "0x1BC0A1C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToDouble", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static double ToDouble(uint value)
		{
			throw null;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00015371 File Offset: 0x00013571
		[global::Cpp2ILInjected.Token(Token = "0x6000560")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0A24", Offset = "0x1BC0A24", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "System.IConvertible.ToDouble", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseNumber", MemberParameters = new object[] { "Newtonsoft.Json.ReadType" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static double ToDouble(long value)
		{
			throw null;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00015374 File Offset: 0x00013574
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000561")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0A2C", Offset = "0x1BC0A2C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToDouble", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static double ToDouble(ulong value)
		{
			throw null;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00015377 File Offset: 0x00013577
		[global::Cpp2ILInjected.Token(Token = "0x6000562")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0A34", Offset = "0x1BC0A34", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "System.IConvertible.ToDouble", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static double ToDouble(float value)
		{
			throw null;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0001537A File Offset: 0x0001357A
		[global::Cpp2ILInjected.Token(Token = "0x6000563")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0A3C", Offset = "0x1BC0A3C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "System.IConvertible.ToDouble", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Explicit", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static double ToDouble(decimal value)
		{
			throw null;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0001537D File Offset: 0x0001357D
		[global::Cpp2ILInjected.Token(Token = "0x6000564")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0AA4", Offset = "0x1BC0AA4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "System.IConvertible.ToDouble", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DoubleConverter", Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(double))]
		public static double ToDouble(string value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00015380 File Offset: 0x00013580
		[global::Cpp2ILInjected.Token(Token = "0x6000565")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB8310", Offset = "0x1BB8310", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static double ToDouble(bool value)
		{
			throw null;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00015383 File Offset: 0x00013583
		[global::Cpp2ILInjected.Token(Token = "0x6000566")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0AC0", Offset = "0x1BC0AC0", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Enum), Member = "System.IConvertible.ToDecimal", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadAsDecimal", ReturnType = "System.Nullable`1<Decimal>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.MiscellaneousUtils", Member = "ValueEquals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<Decimal>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Compare", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Linq.JTokenType",
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Bson.BsonReader", Member = "ReadType", MemberParameters = new object[] { "Newtonsoft.Json.Bson.BsonType" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static decimal ToDecimal(object value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00015386 File Offset: 0x00013586
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000567")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0BE8", Offset = "0x1BC0BE8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "System.IConvertible.ToDecimal", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Implicit", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static decimal ToDecimal(sbyte value)
		{
			throw null;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00015389 File Offset: 0x00013589
		[global::Cpp2ILInjected.Token(Token = "0x6000568")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB9F04", Offset = "0x1BB9F04", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Implicit", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static decimal ToDecimal(byte value)
		{
			throw null;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0001538C File Offset: 0x0001358C
		[global::Cpp2ILInjected.Token(Token = "0x6000569")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0C40", Offset = "0x1BC0C40", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "System.IConvertible.ToDecimal", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Implicit", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static decimal ToDecimal(short value)
		{
			throw null;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0001538F File Offset: 0x0001358F
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600056A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0C98", Offset = "0x1BC0C98", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "System.IConvertible.ToDecimal", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Implicit", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static decimal ToDecimal(ushort value)
		{
			throw null;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00015392 File Offset: 0x00013592
		[global::Cpp2ILInjected.Token(Token = "0x600056B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0CF0", Offset = "0x1BC0CF0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(int), Member = "System.IConvertible.ToDecimal", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static decimal ToDecimal(int value)
		{
			throw null;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00015395 File Offset: 0x00013595
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600056C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0D48", Offset = "0x1BC0D48", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(uint), Member = "System.IConvertible.ToDecimal", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Implicit", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static decimal ToDecimal(uint value)
		{
			throw null;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00015398 File Offset: 0x00013598
		[global::Cpp2ILInjected.Token(Token = "0x600056D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0DA0", Offset = "0x1BC0DA0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(long), Member = "System.IConvertible.ToDecimal", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseNumber", MemberParameters = new object[] { "Newtonsoft.Json.ReadType" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Implicit", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static decimal ToDecimal(long value)
		{
			throw null;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0001539B File Offset: 0x0001359B
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600056E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0DF8", Offset = "0x1BC0DF8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ulong), Member = "System.IConvertible.ToDecimal", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Implicit", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static decimal ToDecimal(ulong value)
		{
			throw null;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0001539E File Offset: 0x0001359E
		[global::Cpp2ILInjected.Token(Token = "0x600056F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0E50", Offset = "0x1BC0E50", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(float), Member = "System.IConvertible.ToDecimal", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Explicit", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static decimal ToDecimal(float value)
		{
			throw null;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x000153A1 File Offset: 0x000135A1
		[global::Cpp2ILInjected.Token(Token = "0x6000570")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0EB0", Offset = "0x1BC0EB0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(double), Member = "System.IConvertible.ToDecimal", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Explicit", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static decimal ToDecimal(double value)
		{
			throw null;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x000153A4 File Offset: 0x000135A4
		[global::Cpp2ILInjected.Token(Token = "0x6000571")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0F10", Offset = "0x1BC0F10", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "System.IConvertible.ToDecimal", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DecimalConverter", Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static decimal ToDecimal(string value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x000153A7 File Offset: 0x000135A7
		[global::Cpp2ILInjected.Token(Token = "0x6000572")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB8380", Offset = "0x1BB8380", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static decimal ToDecimal(bool value)
		{
			throw null;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x000153AA File Offset: 0x000135AA
		[global::Cpp2ILInjected.Token(Token = "0x6000573")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC0F98", Offset = "0x1BC0F98", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonWriter", Member = "WriteToken", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonToken",
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<DateTime>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<DateTimeOffset>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Compare", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Linq.JTokenType",
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "WriteTo", MemberParameters = new object[] { "Newtonsoft.Json.JsonWriter", "Newtonsoft.Json.JsonConverter[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ConvertTokenToXmlValue", MemberParameters = new object[] { "Newtonsoft.Json.JsonReader" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static global::System.DateTime ToDateTime(object value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x000153AD File Offset: 0x000135AD
		[global::Cpp2ILInjected.Token(Token = "0x6000574")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC10C8", Offset = "0x1BC10C8", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "System.IConvertible.ToDateTime", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.DateTime ToDateTime(string value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x000153B0 File Offset: 0x000135B0
		[global::Cpp2ILInjected.Token(Token = "0x6000575")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC1158", Offset = "0x1BC1158", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterConverter), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "GetPropertyName", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonWriter",
			typeof(object),
			"Newtonsoft.Json.Serialization.JsonContract",
			typeof(ref bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(global::System.Guid))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<Guid>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Nullable`1<TimeSpan>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = "System.Uri")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Compare", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Linq.JTokenType",
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static string ToString(object value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x000153B3 File Offset: 0x000135B3
		[global::Cpp2ILInjected.Token(Token = "0x6000576")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC12F8", Offset = "0x1BC12F8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexNode", Member = "ReduceConcatenation", ReturnType = "System.Text.RegularExpressions.RegexNode")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		public static string ToString(char value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x000153B6 File Offset: 0x000135B6
		[global::Cpp2ILInjected.Token(Token = "0x6000577")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC1310", Offset = "0x1BC1310", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Netplay", Member = "AddCurrentServerToRecentList", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string ToString(int value)
		{
			throw null;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x000153B9 File Offset: 0x000135B9
		[global::Cpp2ILInjected.Token(Token = "0x6000578")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC1378", Offset = "0x1BC1378", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexParser", Member = "AssignNameSlots", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(string))]
		public static string ToString(int value, global::System.IFormatProvider provider)
		{
			throw null;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x000153BC File Offset: 0x000135BC
		[global::Cpp2ILInjected.Token(Token = "0x6000579")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC1394", Offset = "0x1BC1394", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ByteConverter", Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParseNumbers), Member = "StringToInt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowByteOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static byte ToByte(string value, int fromBase)
		{
			throw null;
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x000153BF File Offset: 0x000135BF
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600057A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC149C", Offset = "0x1BC149C", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.SByteConverter", Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParseNumbers), Member = "StringToInt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowSByteOverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static sbyte ToSByte(string value, int fromBase)
		{
			throw null;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x000153C2 File Offset: 0x000135C2
		[global::Cpp2ILInjected.Token(Token = "0x600057B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC15B4", Offset = "0x1BC15B4", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.Int16Converter", Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParseNumbers), Member = "StringToInt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowInt16OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static short ToInt16(string value, int fromBase)
		{
			throw null;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000153C5 File Offset: 0x000135C5
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600057C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC16CC", Offset = "0x1BC16CC", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.UInt16Converter", Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParseNumbers), Member = "StringToInt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ThrowUInt16OverflowException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static ushort ToUInt16(string value, int fromBase)
		{
			throw null;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x000153C8 File Offset: 0x000135C8
		[global::Cpp2ILInjected.Token(Token = "0x600057D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC17D4", Offset = "0x1BC17D4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.Int32Converter", Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseNumber", MemberParameters = new object[] { "Newtonsoft.Json.ReadType" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParseNumbers), Member = "StringToInt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static int ToInt32(string value, int fromBase)
		{
			throw null;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x000153CB File Offset: 0x000135CB
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600057E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC18A8", Offset = "0x1BC18A8", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.UInt32Converter", Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParseNumbers), Member = "StringToInt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static uint ToUInt32(string value, int fromBase)
		{
			throw null;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000153CE File Offset: 0x000135CE
		[global::Cpp2ILInjected.Token(Token = "0x600057F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC197C", Offset = "0x1BC197C", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.Int64Converter", Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseNumber", MemberParameters = new object[] { "Newtonsoft.Json.ReadType" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParseNumbers), Member = "StringToLong", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static long ToInt64(string value, int fromBase)
		{
			throw null;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000153D1 File Offset: 0x000135D1
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000580")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC1A50", Offset = "0x1BC1A50", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.UInt64Converter", Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParseNumbers), Member = "StringToLong", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static ulong ToUInt64(string value, int fromBase)
		{
			throw null;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000153D4 File Offset: 0x000135D4
		[global::Cpp2ILInjected.Token(Token = "0x6000581")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC1B24", Offset = "0x1BC1B24", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "ToXmlString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSA), Member = "ToXmlString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSA), Member = "ToXmlString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Http.NtlmSession", Member = "Authenticate", MemberParameters = new object[]
		{
			typeof(string),
			"System.Net.WebRequest",
			"System.Net.ICredentials"
		}, ReturnType = "System.Net.Authorization")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NTAuthentication", Member = "GetOutgoingBlob", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.BasicClient", Member = "InternalAuthenticate", MemberParameters = new object[] { "System.Net.WebRequest", "System.Net.ICredentials" }, ReturnType = "System.Net.Authorization")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.DigestSession", Member = "get_CNonce", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.PlayerActionSet", Member = "Save", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "Base64BinaryToString", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JToken" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JsonPath.BooleanQueryExpression", Member = "EqualsWithStringCoercion", MemberParameters = new object[] { "Newtonsoft.Json.Linq.JValue", "Newtonsoft.Json.Linq.JValue" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.RSAManaged", Member = "ToXmlString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 40)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static string ToBase64String(byte[] inArray)
		{
			throw null;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x000153D7 File Offset: 0x000135D7
		[global::Cpp2ILInjected.Token(Token = "0x6000582")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC1D8C", Offset = "0x1BC1D8C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = "SerializeClaims", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsPrincipal), Member = "SerializeIdentities", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string ToBase64String(byte[] inArray, int offset, int length)
		{
			throw null;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x000153DA File Offset: 0x000135DA
		[global::Cpp2ILInjected.Token(Token = "0x6000583")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC1DFC", Offset = "0x1BC1DFC", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToBase64String", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Base64FormattingOptions)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static string ToBase64String(byte[] inArray, int offset, int length, global::System.Base64FormattingOptions options)
		{
			throw null;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x000153DD File Offset: 0x000135DD
		[global::Cpp2ILInjected.Token(Token = "0x6000584")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC1BDC", Offset = "0x1BC1BDC", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToBase64String", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(global::System.Base64FormattingOptions)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToBase64_CalculateAndValidateOutputLength", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "GetReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.ReadOnlySpan`1<T>" }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ConvertToBase64Array", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(byte*),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public unsafe static string ToBase64String(global::System.ReadOnlySpan<byte> bytes, global::System.Base64FormattingOptions options = global::System.Base64FormattingOptions.None)
		{
			throw null;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x000153E0 File Offset: 0x000135E0
		[global::Cpp2ILInjected.Token(Token = "0x6000585")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC2288", Offset = "0x1BC2288", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.ToBase64Transform), Member = "TransformBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.ToBase64Transform), Member = "TransformFinalBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Base64Encoder", Member = "Encode", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Base64Encoder", Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.Base64Encoder", Member = "Encode", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.Base64Encoder", Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut)
		{
			throw null;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x000153E3 File Offset: 0x000135E3
		[global::Cpp2ILInjected.Token(Token = "0x6000586")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC2310", Offset = "0x1BC2310", Length = "0x2F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToBase64_CalculateAndValidateOutputLength", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ConvertToBase64Array", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(byte*),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		public unsafe static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, global::System.Base64FormattingOptions options)
		{
			throw null;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x000153E6 File Offset: 0x000135E6
		[global::Cpp2ILInjected.Token(Token = "0x6000587")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC2050", Offset = "0x1BC2050", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToBase64String", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Base64FormattingOptions)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToBase64CharArray", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(int),
			typeof(global::System.Base64FormattingOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks)
		{
			throw null;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x000153E9 File Offset: 0x000135E9
		[global::Cpp2ILInjected.Token(Token = "0x6000588")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC1FA0", Offset = "0x1BC1FA0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToBase64String", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Base64FormattingOptions)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToBase64CharArray", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(char[]),
			typeof(int),
			typeof(global::System.Base64FormattingOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OutOfMemoryException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks)
		{
			throw null;
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x000153EC File Offset: 0x000135EC
		[global::Cpp2ILInjected.Token(Token = "0x6000589")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC2604", Offset = "0x1BC2604", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 38)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static byte[] FromBase64String(string s)
		{
			throw null;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000153EF File Offset: 0x000135EF
		[global::Cpp2ILInjected.Token(Token = "0x600058A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC285C", Offset = "0x1BC285C", Length = "0x4E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "FromBase64CharPtr", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "TryDecodeFromUtf16", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Span<byte>),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "CopyToTempBufferWithoutWhiteSpace", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Span<char>),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public unsafe static bool TryFromBase64Chars(global::System.ReadOnlySpan<char> chars, global::System.Span<byte> bytes, out int bytesWritten)
		{
			throw null;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x000153F2 File Offset: 0x000135F2
		[global::Cpp2ILInjected.Token(Token = "0x600058B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC2D44", Offset = "0x1BC2D44", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "TryFromBase64Chars", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Span<byte>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void CopyToTempBufferWithoutWhiteSpace(global::System.ReadOnlySpan<char> chars, global::System.Span<char> tempBuffer, out int consumed, out int charsWritten)
		{
			throw null;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x000153F5 File Offset: 0x000135F5
		[global::Cpp2ILInjected.Token(Token = "0x600058C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC2E58", Offset = "0x1BC2E58", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		private static bool IsSpace(this char c)
		{
			throw null;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x000153F8 File Offset: 0x000135F8
		[global::Cpp2ILInjected.Token(Token = "0x600058D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC2E90", Offset = "0x1BC2E90", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.FromBase64Transform), Member = "TransformBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.FromBase64Transform), Member = "TransformFinalBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseString", MemberParameters = new object[]
		{
			typeof(char),
			"Newtonsoft.Json.ReadType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "FromBase64CharPtr", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public unsafe static byte[] FromBase64CharArray(char[] inArray, int offset, int length)
		{
			throw null;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x000153FB File Offset: 0x000135FB
		[global::Cpp2ILInjected.Token(Token = "0x600058E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC26B8", Offset = "0x1BC26B8", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "FromBase64CharArray", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "FromBase64_ComputeResultLength", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "TryFromBase64Chars", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Span<byte>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private unsafe static byte[] FromBase64CharPtr(char* inputPtr, int inputLength)
		{
			throw null;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x000153FE File Offset: 0x000135FE
		[global::Cpp2ILInjected.Token(Token = "0x600058F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC3068", Offset = "0x1BC3068", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "FromBase64CharPtr", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private unsafe static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength)
		{
			throw null;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00015401 File Offset: 0x00013601
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000590")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BC3124", Offset = "0x1BC3124", Length = "0x1668")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 54)]
		static Convert()
		{
			throw null;
		}

		// Token: 0x04000130 RID: 304
		[global::Cpp2ILInjected.Token(Token = "0x4000217")]
		private static readonly sbyte[] s_decodingMap;

		// Token: 0x04000131 RID: 305
		[global::Cpp2ILInjected.Token(Token = "0x4000218")]
		internal static readonly global::System.Type[] ConvertTypes;

		// Token: 0x04000132 RID: 306
		[global::Cpp2ILInjected.Token(Token = "0x4000219")]
		private static readonly global::System.Type EnumType;

		// Token: 0x04000133 RID: 307
		[global::Cpp2ILInjected.Token(Token = "0x400021A")]
		internal static readonly char[] base64Table;

		// Token: 0x04000134 RID: 308
		[global::Cpp2ILInjected.Token(Token = "0x400021B")]
		public static readonly object DBNull;
	}
}
