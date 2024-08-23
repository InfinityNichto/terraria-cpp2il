using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000087 RID: 135
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000B0")]
	internal static class JsonTypeReflector
	{
		// Token: 0x06000632 RID: 1586 RVA: 0x000032B1 File Offset: 0x000014B1
		[global::Cpp2ILInjected.Token(Token = "0x60006A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x158ECB4", Offset = "0x158ECB4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContainerContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonObjectContract))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "GetObjectMemberSerialization", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(MemberSerialization))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "GetJsonConverter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JsonConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static T GetCachedAttribute<T>(object attributeProvider) where T : Attribute
		{
			throw null;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x000032B4 File Offset: 0x000014B4
		[global::Cpp2ILInjected.Token(Token = "0x60006A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D01928", Offset = "0x1D01928", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "GetSerializableMembers", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(List<MemberInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "SetPropertySettingsFromAttributes", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(object),
			typeof(string),
			typeof(Type),
			typeof(MemberSerialization),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "GetObjectMemberSerialization", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(MemberSerialization))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CachedAttributeGetter<>), Member = "GetAttribute", MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "BaseType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static DataContractAttribute GetDataContractAttribute(Type type)
		{
			throw null;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x000032B7 File Offset: 0x000014B7
		[global::Cpp2ILInjected.Token(Token = "0x60006A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D019BC", Offset = "0x1D019BC", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "SetPropertySettingsFromAttributes", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(object),
			typeof(string),
			typeof(Type),
			typeof(MemberSerialization),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "MemberType", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(MemberTypes))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CachedAttributeGetter<>), Member = "GetAttribute", MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsVirtual", MemberParameters = new object[] { typeof(PropertyInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetMemberInfoFromType", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MemberInfo)
		}, ReturnType = typeof(MemberInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "BaseType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo)
		{
			throw null;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x000032BA File Offset: 0x000014BA
		[global::Cpp2ILInjected.Token(Token = "0x60006A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D01BF4", Offset = "0x1D01BF4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "GetSerializableMembers", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(List<MemberInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonObjectContract))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "GetCachedAttribute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "GetDataContractAttribute", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(DataContractAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute)
		{
			throw null;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x000032BD File Offset: 0x000014BD
		[global::Cpp2ILInjected.Token(Token = "0x60006A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D01CE4", Offset = "0x1D01CE4", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "ResolveContractConverter", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "SetPropertySettingsFromAttributes", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(object),
			typeof(string),
			typeof(Type),
			typeof(MemberSerialization),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "GetCachedAttribute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadSafeStore<, >), Member = "Get", MemberParameters = new object[] { "TKey" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static JsonConverter GetJsonConverter(object attributeProvider)
		{
			throw null;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x000032C0 File Offset: 0x000014C0
		[global::Cpp2ILInjected.Token(Token = "0x60006A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D01DC0", Offset = "0x1D01DC0", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContainerContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "SetPropertySettingsFromAttributes", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(object),
			typeof(string),
			typeof(Type),
			typeof(MemberSerialization),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadSafeStore<, >), Member = "Get", MemberParameters = new object[] { "TKey" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] converterArgs)
		{
			throw null;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x000032C3 File Offset: 0x000014C3
		[global::Cpp2ILInjected.Token(Token = "0x60006AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D01E5C", Offset = "0x1D01E5C", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "HasDefaultConstructor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static Func<object[], JsonConverter> GetJsonConverterCreator(Type converterType)
		{
			throw null;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x000032C6 File Offset: 0x000014C6
		[global::Cpp2ILInjected.Token(Token = "0x60006AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D02050", Offset = "0x1D02050", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConvertUtils), Member = "GetConverter", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetConverter", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static TypeConverter GetTypeConverter(Type type)
		{
			throw null;
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x000032C9 File Offset: 0x000014C9
		[global::Cpp2ILInjected.Token(Token = "0x60006AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D020A8", Offset = "0x1D020A8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "GetAttribute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(Type) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "GetAttribute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadSafeStore<, >), Member = "Get", MemberParameters = new object[] { "TKey" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static Type GetAssociatedMetadataType(Type type)
		{
			throw null;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x000032CC File Offset: 0x000014CC
		[global::Cpp2ILInjected.Token(Token = "0x60006AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D02120", Offset = "0x1D02120", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionObject), Member = "Create", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string[])
		}, ReturnType = typeof(ReflectionObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionObject), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static Type GetAssociateMetadataTypeFromAttribute(Type type)
		{
			throw null;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x000032CF File Offset: 0x000014CF
		[global::Cpp2ILInjected.Token(Token = "0x60006AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x158EB60", Offset = "0x158EB60", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "GetAssociatedMetadataType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static T GetAttribute<T>(Type type) where T : Attribute
		{
			throw null;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000032D2 File Offset: 0x000014D2
		[global::Cpp2ILInjected.Token(Token = "0x60006AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x158E844", Offset = "0x158E844", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "GetAssociatedMetadataType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetMemberInfoFromType", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MemberInfo)
		}, ReturnType = typeof(MemberInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static T GetAttribute<T>(MemberInfo memberInfo) where T : Attribute
		{
			throw null;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x000032D5 File Offset: 0x000014D5
		[global::Cpp2ILInjected.Token(Token = "0x60006B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x158EA20", Offset = "0x158EA20", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "GetSerializableMembers", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(List<MemberInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "SetPropertySettingsFromAttributes", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(object),
			typeof(string),
			typeof(Type),
			typeof(MemberSerialization),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static T GetAttribute<T>(object provider) where T : Attribute
		{
			throw null;
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x000032D8 File Offset: 0x000014D8
		[global::Cpp2ILInjected.Token(Token = "0x17000148")]
		public static bool DynamicCodeGeneration
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D02368", Offset = "0x1D02368", Length = "0x28C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "get_DynamicCodeGeneration", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionPermission), Member = ".ctor", MemberParameters = new object[] { typeof(ReflectionPermissionFlag) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = "Demand", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityPermission), Member = ".ctor", MemberParameters = new object[] { typeof(SecurityPermissionFlag) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityPermission), Member = ".ctor", MemberParameters = new object[] { typeof(PermissionState) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x000032DB File Offset: 0x000014DB
		[global::Cpp2ILInjected.Token(Token = "0x17000149")]
		public static bool FullyTrusted
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D010EC", Offset = "0x1D010EC", Length = "0x1D0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonObjectContract))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonObjectContract), Member = "GetUninitializedObject", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateISerializable", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(JsonISerializableContract),
				typeof(JsonProperty),
				typeof(string)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeISerializable", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(ISerializable),
				typeof(JsonISerializableContract),
				typeof(JsonProperty),
				typeof(JsonContainerContract),
				typeof(JsonProperty)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityPermission), Member = ".ctor", MemberParameters = new object[] { typeof(PermissionState) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CodeAccessPermission), Member = "Demand", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x000032DE File Offset: 0x000014DE
		[global::Cpp2ILInjected.Token(Token = "0x1700014A")]
		public static ReflectionDelegateFactory ReflectionDelegateFactory
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01FC8", Offset = "0x1D01FC8", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectionObject), Member = "Create", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(MethodBase),
				typeof(string[])
			}, ReturnType = typeof(ReflectionObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConvertUtils), Member = "CreateCastConverter", MemberParameters = new object[] { typeof(ConvertUtils.TypeConvertKey) }, ReturnType = typeof(Func<object, object>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "SetExtensionDataDelegates", MemberParameters = new object[]
			{
				typeof(JsonObjectContract),
				typeof(MemberInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "GetDefaultCreator", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Func<object>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateDictionaryContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonDictionaryContract))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateArrayContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonArrayContract))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateISerializableContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonISerializableContract))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateShouldSerializeTest", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(Predicate<object>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "SetIsSpecifiedActions", MemberParameters = new object[]
			{
				typeof(JsonProperty),
				typeof(MemberInfo),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonArrayContract), Member = "get_ParameterizedCreator", ReturnType = typeof(ObjectConstructor<object>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonArrayContract), Member = "CreateWrapper", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IWrappedCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonArrayContract), Member = "CreateTemporaryCollection", ReturnType = typeof(IList))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonDictionaryContract), Member = "get_ParameterizedCreator", ReturnType = typeof(ObjectConstructor<object>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonDictionaryContract), Member = "CreateWrapper", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IWrappedDictionary))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonDictionaryContract), Member = "CreateTemporaryDictionary", ReturnType = typeof(IDictionary))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonObjectContract), Member = "set_OverrideConstructor", MemberParameters = new object[] { typeof(ConstructorInfo) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonObjectContract), Member = "set_ParametrizedConstructor", MemberParameters = new object[] { typeof(ConstructorInfo) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector.<>c__DisplayClass18_0), Member = "<GetJsonConverterCreator>b__0", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(JsonConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "GetJsonConverterCreator", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Func<object[], JsonConverter>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x000032E1 File Offset: 0x000014E1
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60006B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D025F4", Offset = "0x1D025F4", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadSafeStore<, >), Member = ".ctor", MemberParameters = new object[] { "System.Func`2<TKey, TValue>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		static JsonTypeReflector()
		{
			throw null;
		}

		// Token: 0x04000268 RID: 616
		[global::Cpp2ILInjected.Token(Token = "0x40002D7")]
		private static bool? _dynamicCodeGeneration;

		// Token: 0x04000269 RID: 617
		[global::Cpp2ILInjected.Token(Token = "0x40002D8")]
		private static bool? _fullyTrusted;

		// Token: 0x0400026A RID: 618
		[global::Cpp2ILInjected.Token(Token = "0x40002D9")]
		public const string IdPropertyName = "$id";

		// Token: 0x0400026B RID: 619
		[global::Cpp2ILInjected.Token(Token = "0x40002DA")]
		public const string RefPropertyName = "$ref";

		// Token: 0x0400026C RID: 620
		[global::Cpp2ILInjected.Token(Token = "0x40002DB")]
		public const string TypePropertyName = "$type";

		// Token: 0x0400026D RID: 621
		[global::Cpp2ILInjected.Token(Token = "0x40002DC")]
		public const string ValuePropertyName = "$value";

		// Token: 0x0400026E RID: 622
		[global::Cpp2ILInjected.Token(Token = "0x40002DD")]
		public const string ArrayValuesPropertyName = "$values";

		// Token: 0x0400026F RID: 623
		[global::Cpp2ILInjected.Token(Token = "0x40002DE")]
		public const string ShouldSerializePrefix = "ShouldSerialize";

		// Token: 0x04000270 RID: 624
		[global::Cpp2ILInjected.Token(Token = "0x40002DF")]
		public const string SpecifiedPostfix = "Specified";

		// Token: 0x04000271 RID: 625
		[global::Cpp2ILInjected.Token(Token = "0x40002E0")]
		private static readonly ThreadSafeStore<Type, Func<object[], JsonConverter>> JsonConverterCreatorCache;

		// Token: 0x04000272 RID: 626
		[global::Cpp2ILInjected.Token(Token = "0x40002E1")]
		private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache;

		// Token: 0x04000273 RID: 627
		[global::Cpp2ILInjected.Token(Token = "0x40002E2")]
		private static ReflectionObject _metadataTypeAttributeReflectionObject;

		// Token: 0x0200011A RID: 282
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000B1")]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x06000AF1 RID: 2801 RVA: 0x0000404F File Offset: 0x0000224F
			[global::Cpp2ILInjected.Token(Token = "0x60006B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D01FC0", Offset = "0x1D01FC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass18_0()
			{
				throw null;
			}

			// Token: 0x06000AF2 RID: 2802 RVA: 0x00004052 File Offset: 0x00002252
			[global::Cpp2ILInjected.Token(Token = "0x60006B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D02770", Offset = "0x1D02770", Length = "0x44C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new object[] { typeof(Type[]) }, ReturnType = typeof(ConstructorInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(IFormatProvider),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 43)]
			internal JsonConverter <GetJsonConverterCreator>b__0(object[] parameters)
			{
				throw null;
			}

			// Token: 0x040003CF RID: 975
			[global::Cpp2ILInjected.Token(Token = "0x40002E3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Type converterType;

			// Token: 0x040003D0 RID: 976
			[global::Cpp2ILInjected.Token(Token = "0x40002E4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Func<object> defaultConstructor;
		}

		// Token: 0x0200011B RID: 283
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000B2")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000AF3 RID: 2803 RVA: 0x00004055 File Offset: 0x00002255
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60006B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D02BBC", Offset = "0x1D02BBC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06000AF4 RID: 2804 RVA: 0x00004058 File Offset: 0x00002258
			[global::Cpp2ILInjected.Token(Token = "0x60006B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D02C18", Offset = "0x1D02C18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06000AF5 RID: 2805 RVA: 0x0000405B File Offset: 0x0000225B
			[global::Cpp2ILInjected.Token(Token = "0x60006B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D02C20", Offset = "0x1D02C20", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			internal Type <GetJsonConverterCreator>b__18_1(object param)
			{
				throw null;
			}

			// Token: 0x040003D1 RID: 977
			[global::Cpp2ILInjected.Token(Token = "0x40002E5")]
			public static readonly JsonTypeReflector.<>c <>9;

			// Token: 0x040003D2 RID: 978
			[global::Cpp2ILInjected.Token(Token = "0x40002E6")]
			public static Func<object, Type> <>9__18_1;
		}
	}
}
