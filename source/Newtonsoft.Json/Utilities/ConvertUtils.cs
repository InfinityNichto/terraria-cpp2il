using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200004C RID: 76
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200005A")]
	internal static class ConvertUtils
	{
		// Token: 0x06000304 RID: 772 RVA: 0x0000298A File Offset: 0x00000B8A
		[global::Cpp2ILInjected.Token(Token = "0x600031E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCD754", Offset = "0x1CCD754", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(ref bool)
		}, ReturnType = typeof(PrimitiveTypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConvertUtils), Member = "IsInteger", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "GetDefaultValue", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonPrimitiveContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "IsJsonPrimitiveType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(ref bool)
		}, ReturnType = typeof(PrimitiveTypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static PrimitiveTypeCode GetTypeCode(Type t)
		{
			throw null;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000298D File Offset: 0x00000B8D
		[global::Cpp2ILInjected.Token(Token = "0x600031F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD1A6C", Offset = "0x1CD1A6C", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(PrimitiveTypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, Int32Enum>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref Int32Enum)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(PrimitiveTypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum)
		{
			throw null;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00002990 File Offset: 0x00000B90
		[global::Cpp2ILInjected.Token(Token = "0x6000320")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCE8A8", Offset = "0x1CCE8A8", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(PrimitiveTypeCode),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static TypeInformation GetTypeInformation(IConvertible convertable)
		{
			throw null;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002993 File Offset: 0x00000B93
		[global::Cpp2ILInjected.Token(Token = "0x6000321")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD1DB0", Offset = "0x1CD1DB0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConvertUtils), Member = "TryConvertInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(CultureInfo),
			typeof(Type),
			typeof(ref object)
		}, ReturnType = typeof(ConvertUtils.ConvertResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool IsConvertible(Type t)
		{
			throw null;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002996 File Offset: 0x00000B96
		[global::Cpp2ILInjected.Token(Token = "0x6000322")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD1E3C", Offset = "0x1CD1E3C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConvertUtils), Member = "TryConvertInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(CultureInfo),
			typeof(Type),
			typeof(ref object)
		}, ReturnType = typeof(ConvertUtils.ConvertResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "op_Explicit", MemberParameters = new object[] { typeof(JToken) }, ReturnType = typeof(TimeSpan?))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static TimeSpan ParseTimeSpan(string input)
		{
			throw null;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002999 File Offset: 0x00000B99
		[global::Cpp2ILInjected.Token(Token = "0x6000323")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD1E94", Offset = "0x1CD1E94", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type[])
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private static Func<object, object> CreateCastConverter(ConvertUtils.TypeConvertKey t)
		{
			throw null;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000299C File Offset: 0x00000B9C
		[global::Cpp2ILInjected.Token(Token = "0x6000324")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD20A8", Offset = "0x1CD20A8", Length = "0x24C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "TryConvertInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(CultureInfo),
			typeof(Type),
			typeof(ref object)
		}, ReturnType = typeof(ConvertUtils.ConvertResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public static object Convert(object initialValue, CultureInfo culture, Type targetType)
		{
			throw null;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000299F File Offset: 0x00000B9F
		[global::Cpp2ILInjected.Token(Token = "0x6000325")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD2BEC", Offset = "0x1CD2BEC", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConvertUtils), Member = "ConvertOrCast", MemberParameters = new object[]
		{
			typeof(object),
			typeof(CultureInfo),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "TryConvertInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(CultureInfo),
			typeof(Type),
			typeof(ref object)
		}, ReturnType = typeof(ConvertUtils.ConvertResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value)
		{
			throw null;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000029A2 File Offset: 0x00000BA2
		[global::Cpp2ILInjected.Token(Token = "0x6000326")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD22F4", Offset = "0x1CD22F4", Length = "0x8F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConvertUtils), Member = "Convert", MemberParameters = new object[]
		{
			typeof(object),
			typeof(CultureInfo),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConvertUtils), Member = "TryConvert", MemberParameters = new object[]
		{
			typeof(object),
			typeof(CultureInfo),
			typeof(Type),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "IsConvertible", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "IsInteger", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "GetConverter", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "CanConvertTo", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "CanConvertFrom", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = ".ctor", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsAbstract", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "ToByteArray", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "Parse", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "ParseTimeSpan", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsNullable", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "EnsureTypeAssignable", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "VersionTryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref Version)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 62)]
		private static ConvertUtils.ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value)
		{
			throw null;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000029A5 File Offset: 0x00000BA5
		[global::Cpp2ILInjected.Token(Token = "0x6000327")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD3150", Offset = "0x1CD3150", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EnsureType", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object),
			typeof(CultureInfo),
			typeof(JsonContract),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringEnumConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsNullable", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "TryConvert", MemberParameters = new object[]
		{
			typeof(object),
			typeof(CultureInfo),
			typeof(Type),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "EnsureTypeAssignable", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType)
		{
			throw null;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000029A8 File Offset: 0x00000BA8
		[global::Cpp2ILInjected.Token(Token = "0x6000328")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD2F4C", Offset = "0x1CD2F4C", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConvertUtils), Member = "TryConvertInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(CultureInfo),
			typeof(Type),
			typeof(ref object)
		}, ReturnType = typeof(ConvertUtils.ConvertResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConvertUtils), Member = "ConvertOrCast", MemberParameters = new object[]
		{
			typeof(object),
			typeof(CultureInfo),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadSafeStore<ConvertUtils.TypeConvertKey, object>), Member = "Get", MemberParameters = new object[] { typeof(ConvertUtils.TypeConvertKey) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsNullable", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static object EnsureTypeAssignable(object value, Type initialType, Type targetType)
		{
			throw null;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000029AB File Offset: 0x00000BAB
		[global::Cpp2ILInjected.Token(Token = "0x6000329")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD2E60", Offset = "0x1CD2E60", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConvertUtils), Member = "TryConvertInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(CultureInfo),
			typeof(Type),
			typeof(ref object)
		}, ReturnType = typeof(ConvertUtils.ConvertResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CanConvertToString", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "TryConvertToString", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "GetTypeConverter", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static TypeConverter GetConverter(Type t)
		{
			throw null;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x000029AE File Offset: 0x00000BAE
		[global::Cpp2ILInjected.Token(Token = "0x600032A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD2D7C", Offset = "0x1CD2D7C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConvertUtils), Member = "TryConvertInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(CultureInfo),
			typeof(Type),
			typeof(ref object)
		}, ReturnType = typeof(ConvertUtils.ConvertResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Version), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static bool VersionTryParse(string input, out Version result)
		{
			throw null;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000029B1 File Offset: 0x00000BB1
		[global::Cpp2ILInjected.Token(Token = "0x600032B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD2CF4", Offset = "0x1CD2CF4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConvertUtils), Member = "TryConvertInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(CultureInfo),
			typeof(Type),
			typeof(ref object)
		}, ReturnType = typeof(ConvertUtils.ConvertResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiscellaneousUtils), Member = "ValueEquals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EnsureType", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object),
			typeof(CultureInfo),
			typeof(JsonContract),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(PrimitiveTypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsInteger(object value)
		{
			throw null;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000029B4 File Offset: 0x00000BB4
		[global::Cpp2ILInjected.Token(Token = "0x600032C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD32D8", Offset = "0x1CD32D8", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ParseNumber", MemberParameters = new object[] { typeof(ReadType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryReadOffset", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(int),
			typeof(ref TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value)
		{
			throw null;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x000029B7 File Offset: 0x00000BB7
		[global::Cpp2ILInjected.Token(Token = "0x600032D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD33FC", Offset = "0x1CD33FC", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ParseNumber", MemberParameters = new object[] { typeof(ReadType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DateTimeUtils), Member = "TryParseMicrosoftDate", MemberParameters = new object[]
		{
			typeof(StringReference),
			typeof(ref long),
			typeof(ref TimeSpan),
			typeof(ref DateTimeKind)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value)
		{
			throw null;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x000029BA File Offset: 0x00000BBA
		[global::Cpp2ILInjected.Token(Token = "0x600032E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD350C", Offset = "0x1CD350C", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ParseString", MemberParameters = new object[]
		{
			typeof(char),
			typeof(ReadType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonReader), Member = "ReadAsBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Group), Member = "get_Success", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static bool TryConvertGuid(string s, out Guid g)
		{
			throw null;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000029BD File Offset: 0x00000BBD
		[global::Cpp2ILInjected.Token(Token = "0x600032F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD3634", Offset = "0x1CD3634", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ParseUnicode", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "HexCharToInt", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int HexTextToInt(char[] text, int start, int end)
		{
			throw null;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x000029C0 File Offset: 0x00000BC0
		[global::Cpp2ILInjected.Token(Token = "0x6000330")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD36F4", Offset = "0x1CD36F4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConvertUtils), Member = "HexTextToInt", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static int HexCharToInt(char ch)
		{
			throw null;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x000029C3 File Offset: 0x00000BC3
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000331")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD37B8", Offset = "0x1CD37B8", Length = "0xF38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, Int32Enum>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, Int32Enum>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			"System.Int32Enum"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<ConvertUtils.TypeConvertKey, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadSafeStore<ConvertUtils.TypeConvertKey, object>), Member = ".ctor", MemberParameters = new object[] { typeof(Func<ConvertUtils.TypeConvertKey, object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 96)]
		static ConvertUtils()
		{
			throw null;
		}

		// Token: 0x040001A3 RID: 419
		[global::Cpp2ILInjected.Token(Token = "0x40001CD")]
		private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap;

		// Token: 0x040001A4 RID: 420
		[global::Cpp2ILInjected.Token(Token = "0x40001CE")]
		private static readonly TypeInformation[] PrimitiveTypeCodes;

		// Token: 0x040001A5 RID: 421
		[global::Cpp2ILInjected.Token(Token = "0x40001CF")]
		private static readonly ThreadSafeStore<ConvertUtils.TypeConvertKey, Func<object, object>> CastConverters;

		// Token: 0x02000100 RID: 256
		[global::Cpp2ILInjected.Token(Token = "0x200005B")]
		internal struct TypeConvertKey
		{
			// Token: 0x17000214 RID: 532
			// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x00003F5C File Offset: 0x0000215C
			[global::Cpp2ILInjected.Token(Token = "0x17000099")]
			public Type InitialType
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000332")]
				[global::Cpp2ILInjected.Address(RVA = "0x1CD46F0", Offset = "0x1CD46F0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000215 RID: 533
			// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x00003F5F File Offset: 0x0000215F
			[global::Cpp2ILInjected.Token(Token = "0x1700009A")]
			public Type TargetType
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000333")]
				[global::Cpp2ILInjected.Address(RVA = "0x1CD46F8", Offset = "0x1CD46F8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000AA2 RID: 2722 RVA: 0x00003F62 File Offset: 0x00002162
			[global::Cpp2ILInjected.Token(Token = "0x6000334")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD32D0", Offset = "0x1CD32D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public TypeConvertKey(Type initialType, Type targetType)
			{
				throw null;
			}

			// Token: 0x06000AA3 RID: 2723 RVA: 0x00003F65 File Offset: 0x00002165
			[global::Cpp2ILInjected.Token(Token = "0x6000335")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD4700", Offset = "0x1CD4700", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int GetHashCode()
			{
				throw null;
			}

			// Token: 0x06000AA4 RID: 2724 RVA: 0x00003F68 File Offset: 0x00002168
			[global::Cpp2ILInjected.Token(Token = "0x6000336")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD473C", Offset = "0x1CD473C", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Equals(object obj)
			{
				throw null;
			}

			// Token: 0x06000AA5 RID: 2725 RVA: 0x00003F6B File Offset: 0x0000216B
			[global::Cpp2ILInjected.Token(Token = "0x6000337")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD47C4", Offset = "0x1CD47C4", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool Equals(ConvertUtils.TypeConvertKey other)
			{
				throw null;
			}

			// Token: 0x0400038E RID: 910
			[global::Cpp2ILInjected.Token(Token = "0x40001D0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly Type _initialType;

			// Token: 0x0400038F RID: 911
			[global::Cpp2ILInjected.Token(Token = "0x40001D1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private readonly Type _targetType;
		}

		// Token: 0x02000101 RID: 257
		[global::Cpp2ILInjected.Token(Token = "0x200005C")]
		internal enum ConvertResult
		{
			// Token: 0x04000391 RID: 913
			[global::Cpp2ILInjected.Token(Token = "0x40001D3")]
			Success,
			// Token: 0x04000392 RID: 914
			[global::Cpp2ILInjected.Token(Token = "0x40001D4")]
			CannotConvertNull,
			// Token: 0x04000393 RID: 915
			[global::Cpp2ILInjected.Token(Token = "0x40001D5")]
			NotInstantiableType,
			// Token: 0x04000394 RID: 916
			[global::Cpp2ILInjected.Token(Token = "0x40001D6")]
			NoValidConversion
		}

		// Token: 0x02000102 RID: 258
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200005D")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06000AA6 RID: 2726 RVA: 0x00003F6E File Offset: 0x0000216E
			[global::Cpp2ILInjected.Token(Token = "0x6000338")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD20A0", Offset = "0x1CD20A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass9_0()
			{
				throw null;
			}

			// Token: 0x06000AA7 RID: 2727 RVA: 0x00003F71 File Offset: 0x00002171
			[global::Cpp2ILInjected.Token(Token = "0x6000339")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD47E8", Offset = "0x1CD47E8", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			internal object <CreateCastConverter>b__0(object o)
			{
				throw null;
			}

			// Token: 0x04000395 RID: 917
			[global::Cpp2ILInjected.Token(Token = "0x40001D7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public MethodCall<object, object> call;
		}
	}
}
