using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200005B RID: 91
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000070")]
	internal static class ReflectionUtils
	{
		// Token: 0x060003B9 RID: 953 RVA: 0x00002B97 File Offset: 0x00000D97
		[global::Cpp2ILInjected.Token(Token = "0x60003ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDB498", Offset = "0x1CDB498", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static ReflectionUtils()
		{
			throw null;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00002B9A File Offset: 0x00000D9A
		[global::Cpp2ILInjected.Token(Token = "0x60003EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDB510", Offset = "0x1CDB510", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils.<>c__DisplayClass42_0), Member = "<GetChildPrivateProperties>b__2", MemberParameters = new object[] { typeof(PropertyInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "IsOverridenGenericMember", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(BindingFlags)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "GetChildPrivateProperties", MemberParameters = new object[]
		{
			typeof(IList<PropertyInfo>),
			typeof(Type),
			typeof(BindingFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "GetDataMemberAttribute", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(DataMemberAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyInfo), Member = "GetGetMethod", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "get_IsVirtual", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyInfo), Member = "GetSetMethod", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool IsVirtual(this PropertyInfo propertyInfo)
		{
			throw null;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00002B9D File Offset: 0x00000D9D
		[global::Cpp2ILInjected.Token(Token = "0x60003EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDB5A0", Offset = "0x1CDB5A0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils.<>c__DisplayClass42_0), Member = "<GetChildPrivateProperties>b__2", MemberParameters = new object[] { typeof(PropertyInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyInfo), Member = "GetGetMethod", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyInfo), Member = "GetSetMethod", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static MethodInfo GetBaseDefinition(this PropertyInfo propertyInfo)
		{
			throw null;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00002BA0 File Offset: 0x00000DA0
		[global::Cpp2ILInjected.Token(Token = "0x60003F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDB624", Offset = "0x1CDB624", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "GetChildPrivateProperties", MemberParameters = new object[]
		{
			typeof(IList<PropertyInfo>),
			typeof(Type),
			typeof(BindingFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyInfo), Member = "GetGetMethod", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyInfo), Member = "GetSetMethod", ReturnType = typeof(MethodInfo))]
		public static bool IsPublic(PropertyInfo property)
		{
			throw null;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00002BA3 File Offset: 0x00000DA3
		[global::Cpp2ILInjected.Token(Token = "0x60003F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD32C0", Offset = "0x1CD32C0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EnsureType", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object),
			typeof(CultureInfo),
			typeof(JsonContract),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IsoDateTimeConverter), Member = "WriteJson", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		public static Type GetObjectType(object v)
		{
			throw null;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00002BA6 File Offset: 0x00000DA6
		[global::Cpp2ILInjected.Token(Token = "0x60003F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDB68C", Offset = "0x1CDB68C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteTypeProperty", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static string GetTypeName(Type t, FormatterAssemblyStyle assemblyFormat, SerializationBinder binder)
		{
			throw null;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002BA9 File Offset: 0x00000DA9
		[global::Cpp2ILInjected.Token(Token = "0x60003F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDB74C", Offset = "0x1CDB74C", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static string RemoveAssemblyDetails(string fullyQualifiedTypeName)
		{
			throw null;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00002BAC File Offset: 0x00000DAC
		[global::Cpp2ILInjected.Token(Token = "0x60003F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD11B0", Offset = "0x1CD11B0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionObject), Member = "Create", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MethodBase),
			typeof(string[])
		}, ReturnType = typeof(ReflectionObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "GetJsonConverterCreator", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Func<object[], JsonConverter>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetDefaultConstructor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool HasDefaultConstructor(Type t, bool nonPublic)
		{
			throw null;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002BAF File Offset: 0x00000DAF
		[global::Cpp2ILInjected.Token(Token = "0x60003F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDB9A4", Offset = "0x1CDB9A4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetDefaultConstructor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ConstructorInfo GetDefaultConstructor(Type t)
		{
			throw null;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002BB2 File Offset: 0x00000DB2
		[global::Cpp2ILInjected.Token(Token = "0x60003F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDB878", Offset = "0x1CDB878", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LateBoundReflectionDelegateFactory), Member = "CreateDefaultConstructor", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(Type) }, ReturnType = "System.Func`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "HasDefaultConstructor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "GetDefaultConstructor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "SingleOrDefault", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic)
		{
			throw null;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002BB5 File Offset: 0x00000DB5
		[global::Cpp2ILInjected.Token(Token = "0x60003F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD2EB8", Offset = "0x1CD2EB8", Length = "0x94")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConvertUtils), Member = "EnsureTypeAssignable", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "GetDefaultValue", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JavaScriptDateTimeConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool IsNullable(Type t)
		{
			throw null;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002BB8 File Offset: 0x00000DB8
		[global::Cpp2ILInjected.Token(Token = "0x60003F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD1CD8", Offset = "0x1CD1CD8", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(ref bool)
		}, ReturnType = typeof(PrimitiveTypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConvertUtils), Member = "TryConvertInternal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(CultureInfo),
			typeof(Type),
			typeof(ref object)
		}, ReturnType = typeof(ConvertUtils.ConvertResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CollectionWrapper<>), Member = "IsCompatibleObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "IsNullable", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "EnsureNotNullableType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "IsIConvertible", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonArrayContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonDictionaryContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Extensions), Member = "Convert", MemberTypeParameters = new object[] { "T", "U" }, MemberParameters = new object[] { "T" }, ReturnType = "U")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyValuePairConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyValuePairConverter), Member = "CanConvert", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringEnumConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringEnumConverter), Member = "CanConvert", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IsoDateTimeConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JavaScriptDateTimeConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool IsNullableType(Type t)
		{
			throw null;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002BBB File Offset: 0x00000DBB
		[global::Cpp2ILInjected.Token(Token = "0x60003F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDBA0C", Offset = "0x1CDBA0C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Type EnsureNotNullableType(Type t)
		{
			throw null;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002BBE File Offset: 0x00000DBE
		[global::Cpp2ILInjected.Token(Token = "0x60003FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDBA80", Offset = "0x1CDBA80", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "SetExtensionDataDelegates", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(MemberInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonArrayContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonDictionaryContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			throw null;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002BC1 File Offset: 0x00000DC1
		[global::Cpp2ILInjected.Token(Token = "0x60003FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD9DEC", Offset = "0x1CD9DEC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "ImplementsGenericDefinition", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type),
			typeof(ref Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition)
		{
			throw null;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00002BC4 File Offset: 0x00000DC4
		[global::Cpp2ILInjected.Token(Token = "0x60003FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDBAD8", Offset = "0x1CDBAD8", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "ImplementsGenericDefinition", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "GetCollectionItemType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "GetDictionaryKeyValueTypes", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(ref Type),
			typeof(ref Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver.<>c", Member = "<GetExtensionDataMemberForType>b__33_1", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "SetExtensionDataDelegates", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(MemberInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonArrayContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonDictionaryContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType)
		{
			throw null;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00002BC7 File Offset: 0x00000DC7
		[global::Cpp2ILInjected.Token(Token = "0x60003FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDBCC0", Offset = "0x1CDBCC0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonArrayContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonArrayContract), Member = "CreateWrapper", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IWrappedCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "InheritsGenericDefinition", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type),
			typeof(ref Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition)
		{
			throw null;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00002BCA File Offset: 0x00000DCA
		[global::Cpp2ILInjected.Token(Token = "0x60003FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDBD34", Offset = "0x1CDBD34", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "InheritsGenericDefinition", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonArrayContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonDictionaryContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsClass", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "InheritsGenericDefinitionInternal", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type),
			typeof(ref Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType)
		{
			throw null;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00002BCD File Offset: 0x00000DCD
		[global::Cpp2ILInjected.Token(Token = "0x60003FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDBE88", Offset = "0x1CDBE88", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "InheritsGenericDefinition", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type),
			typeof(ref Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool InheritsGenericDefinitionInternal(Type currentType, Type genericClassDefinition, out Type implementingType)
		{
			throw null;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00002BD0 File Offset: 0x00000DD0
		[global::Cpp2ILInjected.Token(Token = "0x6000400")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDBF78", Offset = "0x1CDBF78", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonArrayContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "ImplementsGenericDefinition", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type),
			typeof(ref Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static Type GetCollectionItemType(Type type)
		{
			throw null;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002BD3 File Offset: 0x00000DD3
		[global::Cpp2ILInjected.Token(Token = "0x6000401")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDC17C", Offset = "0x1CDC17C", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonDictionaryContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "ImplementsGenericDefinition", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type),
			typeof(ref Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType)
		{
			throw null;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00002BD6 File Offset: 0x00000DD6
		[global::Cpp2ILInjected.Token(Token = "0x6000402")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD1528", Offset = "0x1CD1528", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionObject), Member = "Create", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MethodBase),
			typeof(string[])
		}, ReturnType = typeof(ReflectionObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "IsOverridenGenericMember", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(BindingFlags)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver.<>c", Member = "<GetExtensionDataMemberForType>b__33_1", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "SetExtensionDataDelegates", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(MemberInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperty", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(MemberSerialization)
		}, ReturnType = typeof(JsonProperty))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "SetIsSpecifiedActions", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(MemberInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static Type GetMemberUnderlyingType(MemberInfo member)
		{
			throw null;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00002BD9 File Offset: 0x00000DD9
		[global::Cpp2ILInjected.Token(Token = "0x6000403")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDC37C", Offset = "0x1CDC37C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver.<>c", Member = "<GetSerializableMembers>b__30_0", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver.<>c", Member = "<GetSerializableMembers>b__30_1", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool IsIndexedProperty(MemberInfo member)
		{
			throw null;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00002BDC File Offset: 0x00000DDC
		[global::Cpp2ILInjected.Token(Token = "0x6000404")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDC448", Offset = "0x1CDC448", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool IsIndexedProperty(PropertyInfo property)
		{
			throw null;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00002BDF File Offset: 0x00000DDF
		[global::Cpp2ILInjected.Token(Token = "0x6000405")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDC4B4", Offset = "0x1CDC4B4", Length = "0x304")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionValueProvider), Member = "GetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public static object GetMemberValue(MemberInfo member, object target)
		{
			throw null;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00002BE2 File Offset: 0x00000DE2
		[global::Cpp2ILInjected.Token(Token = "0x6000406")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDC7B8", Offset = "0x1CDC7B8", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionValueProvider), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void SetMemberValue(MemberInfo member, object target, object value)
		{
			throw null;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002BE5 File Offset: 0x00000DE5
		[global::Cpp2ILInjected.Token(Token = "0x6000407")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD126C", Offset = "0x1CD126C", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionObject), Member = "Create", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MethodBase),
			typeof(string[])
		}, ReturnType = typeof(ReflectionObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver.<>c", Member = "<GetExtensionDataMemberForType>b__33_1", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperty", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(MemberSerialization)
		}, ReturnType = typeof(JsonProperty))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool CanReadMemberValue(MemberInfo member, bool nonPublic)
		{
			throw null;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00002BE8 File Offset: 0x00000DE8
		[global::Cpp2ILInjected.Token(Token = "0x6000408")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD13A8", Offset = "0x1CD13A8", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionObject), Member = "Create", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MethodBase),
			typeof(string[])
		}, ReturnType = typeof(ReflectionObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "SetExtensionDataDelegates", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(MemberInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperty", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(MemberSerialization)
		}, ReturnType = typeof(JsonProperty))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "SetIsSpecifiedActions", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(MemberInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = "get_IsLiteral", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = "get_IsInitOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly)
		{
			throw null;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00002BEB File Offset: 0x00000DEB
		[global::Cpp2ILInjected.Token(Token = "0x6000409")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDC9B8", Offset = "0x1CDC9B8", Length = "0xA00")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "GetSerializableMembers", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(List<MemberInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetFields", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(BindingFlags)
		}, ReturnType = typeof(IEnumerable<FieldInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionUtils), Member = "AddRange", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"System.Collections.Generic.IList`1<T>",
			typeof(IEnumerable)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetProperties", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(BindingFlags)
		}, ReturnType = typeof(IEnumerable<PropertyInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "GroupBy", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, object>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<IGrouping`2<TKey, TSource>>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsOverridenGenericMember", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(BindingFlags)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 54)]
		public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr)
		{
			throw null;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00002BEE File Offset: 0x00000DEE
		[global::Cpp2ILInjected.Token(Token = "0x600040A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDD760", Offset = "0x1CDD760", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "GetFieldsAndProperties", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(BindingFlags)
		}, ReturnType = typeof(List<MemberInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsVirtual", MemberParameters = new object[] { typeof(PropertyInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetMemberUnderlyingType", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr)
		{
			throw null;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00002BF1 File Offset: 0x00000DF1
		[global::Cpp2ILInjected.Token(Token = "0x600040B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1595900", Offset = "0x1595900", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "SetExtensionDataDelegates", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(MemberInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static T GetAttribute<T>(object attributeProvider) where T : Attribute
		{
			throw null;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002BF4 File Offset: 0x00000DF4
		[global::Cpp2ILInjected.Token(Token = "0x600040C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1595970", Offset = "0x1595970", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static T GetAttribute<T>(object attributeProvider, bool inherit) where T : Attribute
		{
			throw null;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002BF7 File Offset: 0x00000DF7
		[global::Cpp2ILInjected.Token(Token = "0x600040D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1595A08", Offset = "0x1595A08", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static T[] GetAttributes<T>(object attributeProvider, bool inherit) where T : Attribute
		{
			throw null;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002BFA File Offset: 0x00000DFA
		[global::Cpp2ILInjected.Token(Token = "0x600040E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDD8E0", Offset = "0x1CDD8E0", Length = "0x4F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "GetAttributes", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionAttributeProvider), Member = "GetAttributes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(IList<Attribute>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionAttributeProvider), Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(IList<Attribute>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "GetAssociateMetadataTypeFromAttribute", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(Type)
		}, ReturnType = typeof(Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(Module),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(ParameterInfo),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Cast", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable) }, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToArray", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "TSource[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Union", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(IEnumerable<object>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(Assembly) }, ReturnType = typeof(Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(bool)
		}, ReturnType = typeof(Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(Module),
			typeof(bool)
		}, ReturnType = typeof(Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(ParameterInfo),
			typeof(bool)
		}, ReturnType = typeof(Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002BFD File Offset: 0x00000DFD
		[global::Cpp2ILInjected.Token(Token = "0x600040F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDDDD8", Offset = "0x1CDDDD8", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ResolveTypeName", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(ref Type),
			typeof(ref JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetAssemblyDelimiterIndex", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void SplitFullyQualifiedTypeName(string fullyQualifiedTypeName, out string typeName, out string assemblyName)
		{
			throw null;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002C00 File Offset: 0x00000E00
		[global::Cpp2ILInjected.Token(Token = "0x6000410")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDDEB8", Offset = "0x1CDDEB8", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "SplitFullyQualifiedTypeName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static int? GetAssemblyDelimiterIndex(string fullyQualifiedTypeName)
		{
			throw null;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002C03 File Offset: 0x00000E03
		[global::Cpp2ILInjected.Token(Token = "0x6000411")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDDF88", Offset = "0x1CDDF88", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "GetProperties", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(BindingFlags)
		}, ReturnType = typeof(IEnumerable<PropertyInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "GetDataMemberAttribute", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(DataMemberAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "GetAttribute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Select", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, object>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToArray", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "TSource[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags),
			typeof(Binder),
			typeof(Type),
			typeof(Type[]),
			typeof(ParameterModifier[])
		}, ReturnType = typeof(PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "SingleOrDefault", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo)
		{
			throw null;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002C06 File Offset: 0x00000E06
		[global::Cpp2ILInjected.Token(Token = "0x6000412")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDD3B8", Offset = "0x1CDD3B8", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "GetFieldsAndProperties", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(BindingFlags)
		}, ReturnType = typeof(List<MemberInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetChildPrivateFields", MemberParameters = new object[]
		{
			typeof(IList<MemberInfo>),
			typeof(Type),
			typeof(BindingFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Cast", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable) }, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr)
		{
			throw null;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002C09 File Offset: 0x00000E09
		[global::Cpp2ILInjected.Token(Token = "0x6000413")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDE1E8", Offset = "0x1CDE1E8", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "GetFields", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(BindingFlags)
		}, ReturnType = typeof(IEnumerable<FieldInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Cast", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable) }, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionUtils), Member = "AddRange", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.IList`1<T>", "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type targetType, BindingFlags bindingAttr)
		{
			throw null;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002C0C File Offset: 0x00000E0C
		[global::Cpp2ILInjected.Token(Token = "0x6000414")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDD4C8", Offset = "0x1CDD4C8", Length = "0x298")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "GetFieldsAndProperties", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(BindingFlags)
		}, ReturnType = typeof(List<MemberInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetChildPrivateProperties", MemberParameters = new object[]
		{
			typeof(IList<PropertyInfo>),
			typeof(Type),
			typeof(BindingFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetMemberInfoFromType", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MemberInfo)
		}, ReturnType = typeof(MemberInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr)
		{
			throw null;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002C0F File Offset: 0x00000E0F
		[global::Cpp2ILInjected.Token(Token = "0x6000415")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDE3C4", Offset = "0x1CDE3C4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static BindingFlags RemoveFlag(this BindingFlags bindingAttr, BindingFlags flag)
		{
			throw null;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00002C12 File Offset: 0x00000E12
		[global::Cpp2ILInjected.Token(Token = "0x6000416")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDE3D4", Offset = "0x1CDE3D4", Length = "0x45C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionUtils), Member = "GetProperties", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(BindingFlags)
		}, ReturnType = typeof(IEnumerable<PropertyInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsPublic", MemberParameters = new object[] { typeof(PropertyInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsVirtual", MemberParameters = new object[] { typeof(PropertyInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionUtils), Member = "IndexOf", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<T>", "System.Func`2<T, Boolean>" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type targetType, BindingFlags bindingAttr)
		{
			throw null;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00002C15 File Offset: 0x00000E15
		[global::Cpp2ILInjected.Token(Token = "0x6000417")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDE838", Offset = "0x1CDE838", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method)
		{
			throw null;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00002C18 File Offset: 0x00000E18
		[global::Cpp2ILInjected.Token(Token = "0x6000418")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDE93C", Offset = "0x1CDE93C", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonProperty), Member = "GetResolvedDefaultValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteDynamicProperty", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(PrimitiveTypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsNullable", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static object GetDefaultValue(Type type)
		{
			throw null;
		}

		// Token: 0x040001BF RID: 447
		[global::Cpp2ILInjected.Token(Token = "0x40001FA")]
		public static readonly Type[] EmptyTypes;

		// Token: 0x02000107 RID: 263
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000071")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000ABA RID: 2746 RVA: 0x00003FAA File Offset: 0x000021AA
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000419")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDEB5C", Offset = "0x1CDEB5C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06000ABB RID: 2747 RVA: 0x00003FAD File Offset: 0x000021AD
			[global::Cpp2ILInjected.Token(Token = "0x600041A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDEBB8", Offset = "0x1CDEBB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06000ABC RID: 2748 RVA: 0x00003FB0 File Offset: 0x000021B0
			[global::Cpp2ILInjected.Token(Token = "0x600041B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDEBC0", Offset = "0x1CDEBC0", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <GetDefaultConstructor>b__10_0(ConstructorInfo c)
			{
				throw null;
			}

			// Token: 0x06000ABD RID: 2749 RVA: 0x00003FB3 File Offset: 0x000021B3
			[global::Cpp2ILInjected.Token(Token = "0x600041C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDEC24", Offset = "0x1CDEC24", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal string <GetFieldsAndProperties>b__29_0(MemberInfo m)
			{
				throw null;
			}

			// Token: 0x06000ABE RID: 2750 RVA: 0x00003FB6 File Offset: 0x000021B6
			[global::Cpp2ILInjected.Token(Token = "0x600041D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDEC34", Offset = "0x1CDEC34", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal Type <GetMemberInfoFromType>b__37_0(ParameterInfo p)
			{
				throw null;
			}

			// Token: 0x06000ABF RID: 2751 RVA: 0x00003FB9 File Offset: 0x000021B9
			[global::Cpp2ILInjected.Token(Token = "0x600041E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDEC44", Offset = "0x1CDEC44", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = "get_IsPrivate", ReturnType = typeof(bool))]
			internal bool <GetChildPrivateFields>b__39_0(FieldInfo f)
			{
				throw null;
			}

			// Token: 0x0400039F RID: 927
			[global::Cpp2ILInjected.Token(Token = "0x40001FB")]
			public static readonly ReflectionUtils.<>c <>9;

			// Token: 0x040003A0 RID: 928
			[global::Cpp2ILInjected.Token(Token = "0x40001FC")]
			public static Func<ConstructorInfo, bool> <>9__10_0;

			// Token: 0x040003A1 RID: 929
			[global::Cpp2ILInjected.Token(Token = "0x40001FD")]
			public static Func<MemberInfo, string> <>9__29_0;

			// Token: 0x040003A2 RID: 930
			[global::Cpp2ILInjected.Token(Token = "0x40001FE")]
			public static Func<ParameterInfo, Type> <>9__37_0;

			// Token: 0x040003A3 RID: 931
			[global::Cpp2ILInjected.Token(Token = "0x40001FF")]
			public static Func<FieldInfo, bool> <>9__39_0;
		}

		// Token: 0x02000108 RID: 264
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000072")]
		private sealed class <>c__DisplayClass42_0
		{
			// Token: 0x06000AC0 RID: 2752 RVA: 0x00003FBC File Offset: 0x000021BC
			[global::Cpp2ILInjected.Token(Token = "0x600041F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDE830", Offset = "0x1CDE830", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass42_0()
			{
				throw null;
			}

			// Token: 0x06000AC1 RID: 2753 RVA: 0x00003FBF File Offset: 0x000021BF
			[global::Cpp2ILInjected.Token(Token = "0x6000420")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDEC50", Offset = "0x1CDEC50", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			internal bool <GetChildPrivateProperties>b__0(PropertyInfo p)
			{
				throw null;
			}

			// Token: 0x06000AC2 RID: 2754 RVA: 0x00003FC2 File Offset: 0x000021C2
			[global::Cpp2ILInjected.Token(Token = "0x6000421")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDEC98", Offset = "0x1CDEC98", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			internal bool <GetChildPrivateProperties>b__1(PropertyInfo p)
			{
				throw null;
			}

			// Token: 0x06000AC3 RID: 2755 RVA: 0x00003FC5 File Offset: 0x000021C5
			[global::Cpp2ILInjected.Token(Token = "0x6000422")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDED28", Offset = "0x1CDED28", Length = "0x11C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsVirtual", MemberParameters = new object[] { typeof(PropertyInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetBaseDefinition", MemberParameters = new object[] { typeof(PropertyInfo) }, ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal bool <GetChildPrivateProperties>b__2(PropertyInfo p)
			{
				throw null;
			}

			// Token: 0x040003A4 RID: 932
			[global::Cpp2ILInjected.Token(Token = "0x4000200")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public PropertyInfo subTypeProperty;
		}

		// Token: 0x02000109 RID: 265
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000073")]
		private sealed class <>c__DisplayClass43_0
		{
			// Token: 0x06000AC4 RID: 2756 RVA: 0x00003FC8 File Offset: 0x000021C8
			[global::Cpp2ILInjected.Token(Token = "0x6000423")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDE934", Offset = "0x1CDE934", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass43_0()
			{
				throw null;
			}

			// Token: 0x06000AC5 RID: 2757 RVA: 0x00003FCB File Offset: 0x000021CB
			[global::Cpp2ILInjected.Token(Token = "0x6000424")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDEE44", Offset = "0x1CDEE44", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			internal bool <IsMethodOverridden>b__0(MethodInfo info)
			{
				throw null;
			}

			// Token: 0x040003A5 RID: 933
			[global::Cpp2ILInjected.Token(Token = "0x4000201")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string method;

			// Token: 0x040003A6 RID: 934
			[global::Cpp2ILInjected.Token(Token = "0x4000202")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Type methodDeclaringType;
		}
	}
}
