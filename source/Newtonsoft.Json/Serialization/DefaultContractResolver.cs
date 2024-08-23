using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000071 RID: 113
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200008A")]
	public class DefaultContractResolver : IContractResolver
	{
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00002E13 File Offset: 0x00001013
		[global::Cpp2ILInjected.Token(Token = "0x170000CE")]
		internal static IContractResolver Instance
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE3DF8", Offset = "0x1CE3DF8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x00002E16 File Offset: 0x00001016
		[global::Cpp2ILInjected.Token(Token = "0x170000CF")]
		public bool DynamicCodeGeneration
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE3E50", Offset = "0x1CE3E50", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_DynamicCodeGeneration", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00002E19 File Offset: 0x00001019
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00002E1C File Offset: 0x0000101C
		[Obsolete("DefaultMembersSearchFlags is obsolete. To modify the members serialized inherit from DefaultContractResolver and override the GetSerializableMembers method instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x170000D0")]
		public BindingFlags DefaultMembersSearchFlags
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60004D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE3EA0", Offset = "0x1CE3EA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60004D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE3EA8", Offset = "0x1CE3EA8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00002E1F File Offset: 0x0000101F
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00002E22 File Offset: 0x00001022
		[global::Cpp2ILInjected.Token(Token = "0x170000D1")]
		public bool SerializeCompilerGeneratedMembers
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60004D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE3EB0", Offset = "0x1CE3EB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60004D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE3EB8", Offset = "0x1CE3EB8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00002E25 File Offset: 0x00001025
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00002E28 File Offset: 0x00001028
		[global::Cpp2ILInjected.Token(Token = "0x170000D2")]
		public bool IgnoreSerializableInterface
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60004DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE3EC4", Offset = "0x1CE3EC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60004DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE3ECC", Offset = "0x1CE3ECC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00002E2B File Offset: 0x0000102B
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00002E2E File Offset: 0x0000102E
		[global::Cpp2ILInjected.Token(Token = "0x170000D3")]
		public bool IgnoreSerializableAttribute
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60004DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE3ED8", Offset = "0x1CE3ED8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60004DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE3EE0", Offset = "0x1CE3EE0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00002E31 File Offset: 0x00001031
		[global::Cpp2ILInjected.Token(Token = "0x60004DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE3EEC", Offset = "0x1CE3EEC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CamelCasePropertyNamesContractResolver), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolverState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DefaultContractResolver()
		{
			throw null;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00002E34 File Offset: 0x00001034
		[Obsolete("DefaultContractResolver(bool) is obsolete. Use the parameterless constructor and cache instances of the contract resolver within your application for optimal performance.")]
		[global::Cpp2ILInjected.Token(Token = "0x60004DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE3C78", Offset = "0x1CE3C78", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = ".ctor", ReturnType = typeof(void))]
		public DefaultContractResolver(bool shareCache)
		{
			throw null;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00002E37 File Offset: 0x00001037
		[global::Cpp2ILInjected.Token(Token = "0x60004E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE3F5C", Offset = "0x1CE3F5C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "SetupReader", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(ref CultureInfo),
			typeof(ref DateTimeZoneHandling?),
			typeof(ref DateParseHandling?),
			typeof(ref FloatParseHandling?),
			typeof(ref int?),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "ResolveContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperties", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MemberSerialization)
		}, ReturnType = typeof(IList<JsonProperty>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal DefaultContractResolverState GetState()
		{
			throw null;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00002E3A File Offset: 0x0000103A
		[global::Cpp2ILInjected.Token(Token = "0x60004E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE3FCC", Offset = "0x1CE3FCC", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "GetState", ReturnType = typeof(DefaultContractResolverState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ResolverContractKey, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(ResolverContractKey),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ResolverContractKey, object>), Member = ".ctor", MemberParameters = new object[] { typeof(IDictionary<ResolverContractKey, object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ResolverContractKey, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ResolverContractKey, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(ResolverContractKey),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public virtual JsonContract ResolveContract(Type type)
		{
			throw null;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00002E3D File Offset: 0x0000103D
		[global::Cpp2ILInjected.Token(Token = "0x60004E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE4228", Offset = "0x1CE4228", Length = "0x8EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "GetObjectMemberSerialization", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(MemberSerialization))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetFieldsAndProperties", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(BindingFlags)
		}, ReturnType = typeof(List<MemberInfo>))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "GetDataContractAttribute", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(DataContractAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "GetAttribute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "AssignableToTypeName", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(ref Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 50)]
		protected virtual List<MemberInfo> GetSerializableMembers(Type objectType)
		{
			throw null;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002E40 File Offset: 0x00001040
		[global::Cpp2ILInjected.Token(Token = "0x60004E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE4B14", Offset = "0x1CE4B14", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "IsGenericType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool ShouldSerializeEntityMember(MemberInfo memberInfo)
		{
			throw null;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00002E43 File Offset: 0x00001043
		[global::Cpp2ILInjected.Token(Token = "0x60004E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE4C04", Offset = "0x1CE4C04", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonObjectContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "GetObjectMemberSerialization", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(MemberSerialization))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionUtils), Member = "AddRange", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.IList`1<T>", "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "GetCachedAttribute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "GetAttributeConstructor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonObjectContract), Member = "set_OverrideConstructor", MemberParameters = new object[] { typeof(ConstructorInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonObjectContract), Member = "get_CreatorParameters", ReturnType = typeof(JsonPropertyCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "GetExtensionDataMemberForType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(MemberInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "SetExtensionDataDelegates", MemberParameters = new object[]
		{
			typeof(JsonObjectContract),
			typeof(MemberInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_FullyTrusted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "GetParameterizedConstructor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonObjectContract), Member = "set_ParametrizedConstructor", MemberParameters = new object[] { typeof(ConstructorInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		protected virtual JsonObjectContract CreateObjectContract(Type objectType)
		{
			throw null;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00002E46 File Offset: 0x00001046
		[global::Cpp2ILInjected.Token(Token = "0x60004E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE5824", Offset = "0x1CE5824", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonObjectContract))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "GetClassHierarchyForType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(List<Type>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "SelectMany", MemberTypeParameters = new object[] { "TSource", "TResult" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, IEnumerable`1<TResult>>" }, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "LastOrDefault", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private MemberInfo GetExtensionDataMemberForType(Type type)
		{
			throw null;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00002E49 File Offset: 0x00001049
		[global::Cpp2ILInjected.Token(Token = "0x60004E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE59E8", Offset = "0x1CE59E8", Length = "0x678")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonObjectContract))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetAttribute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetMemberUnderlyingType", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "ImplementsGenericDefinition", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type),
			typeof(ref Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsGenericDefinition", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionDelegateFactory), Member = "CreateGet", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = "System.Func`2<T, Object>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "CanSetMemberValue", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionDelegateFactory), Member = "CreateSet", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = "System.Action`2<T, Object>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type[])
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExtensionDataSetter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetConstructors", ReturnType = typeof(ConstructorInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExtensionDataGetter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonObjectContract), Member = "set_ExtensionDataValueType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 49)]
		private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member)
		{
			throw null;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00002E4C File Offset: 0x0000104C
		[global::Cpp2ILInjected.Token(Token = "0x60004E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE50F0", Offset = "0x1CE50F0", Length = "0x46C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonObjectContract))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateDictionaryContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonDictionaryContract))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateArrayContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonArrayContract))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new object[] { typeof(Type[]) }, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		private ConstructorInfo GetAttributeConstructor(Type objectType)
		{
			throw null;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00002E4F File Offset: 0x0000104F
		[global::Cpp2ILInjected.Token(Token = "0x60004E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE5644", Offset = "0x1CE5644", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonObjectContract))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private ConstructorInfo GetParameterizedConstructor(Type objectType)
		{
			throw null;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00002E52 File Offset: 0x00001052
		[global::Cpp2ILInjected.Token(Token = "0x60004E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE64E4", Offset = "0x1CE64E4", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPropertyCollection), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPropertyCollection), Member = "GetClosestMatchProperty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JsonProperty))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPropertyCollection), Member = "AddProperty", MemberParameters = new object[] { typeof(JsonProperty) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties)
		{
			throw null;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00002E55 File Offset: 0x00001055
		[global::Cpp2ILInjected.Token(Token = "0x60004EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE69FC", Offset = "0x1CE69FC", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionAttributeProvider), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "SetPropertySettingsFromAttributes", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(object),
			typeof(string),
			typeof(Type),
			typeof(MemberSerialization),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonProperty), Member = "set_PropertyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo)
		{
			throw null;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00002E58 File Offset: 0x00001058
		[global::Cpp2ILInjected.Token(Token = "0x60004EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE71F8", Offset = "0x1CE71F8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "GetJsonConverter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JsonConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual JsonConverter ResolveContractConverter(Type objectType)
		{
			throw null;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00002E5B File Offset: 0x0000105B
		[global::Cpp2ILInjected.Token(Token = "0x60004EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE7250", Offset = "0x1CE7250", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private Func<object> GetDefaultCreator(Type createdType)
		{
			throw null;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002E5E File Offset: 0x0000105E
		[global::Cpp2ILInjected.Token(Token = "0x60004ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE4EF0", Offset = "0x1CE4EF0", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonObjectContract))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateDictionaryContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonDictionaryContract))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateArrayContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonArrayContract))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreatePrimitiveContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonPrimitiveContract))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateLinqContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonLinqContract))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateISerializableContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonISerializableContract))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateStringContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonStringContract))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "GetCachedAttribute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "GetMatchingConverter", MemberParameters = new object[]
		{
			typeof(IList<JsonConverter>),
			typeof(Type)
		}, ReturnType = typeof(JsonConverter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "HasDefaultConstructor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "IsValueType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "GetDefaultCreator", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Func<object>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "GetDataContractAttribute", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(DataContractAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetDefaultConstructor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "ResolveCallbackMethods", MemberParameters = new object[]
		{
			typeof(JsonContract),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void InitializeContract(JsonContract contract)
		{
			throw null;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002E61 File Offset: 0x00001061
		[global::Cpp2ILInjected.Token(Token = "0x60004EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE72F4", Offset = "0x1CE72F4", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "GetCallbackMethodsForType", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(ref List<SerializationCallback>),
			typeof(ref List<SerializationCallback>),
			typeof(ref List<SerializationCallback>),
			typeof(ref List<SerializationCallback>),
			typeof(ref List<SerializationErrorCallback>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "get_OnSerializingCallbacks", ReturnType = typeof(IList<SerializationCallback>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionUtils), Member = "AddRange", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.IList`1<T>", "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "get_OnSerializedCallbacks", ReturnType = typeof(IList<SerializationCallback>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "get_OnDeserializingCallbacks", ReturnType = typeof(IList<SerializationCallback>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "get_OnDeserializedCallbacks", ReturnType = typeof(IList<SerializationCallback>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "get_OnErrorCallbacks", ReturnType = typeof(IList<SerializationErrorCallback>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ResolveCallbackMethods(JsonContract contract, Type t)
		{
			throw null;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002E64 File Offset: 0x00001064
		[global::Cpp2ILInjected.Token(Token = "0x60004EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE7408", Offset = "0x1CE7408", Length = "0x87C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "ResolveCallbackMethods", MemberParameters = new object[]
		{
			typeof(JsonContract),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "GetClassHierarchyForType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(List<Type>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "IsValidCallback", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(ParameterInfo[]),
			typeof(Type),
			typeof(MethodInfo),
			typeof(ref Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "CreateSerializationCallback", MemberParameters = new object[] { typeof(MethodInfo) }, ReturnType = typeof(SerializationCallback))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "CreateSerializationErrorCallback", MemberParameters = new object[] { typeof(MethodInfo) }, ReturnType = typeof(SerializationErrorCallback))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		private void GetCallbackMethodsForType(Type type, out List<SerializationCallback> onSerializing, out List<SerializationCallback> onSerialized, out List<SerializationCallback> onDeserializing, out List<SerializationCallback> onDeserialized, out List<SerializationErrorCallback> onError)
		{
			throw null;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00002E67 File Offset: 0x00001067
		[global::Cpp2ILInjected.Token(Token = "0x60004F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE7EE4", Offset = "0x1CE7EE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool ShouldSkipDeserialized(Type t)
		{
			throw null;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00002E6A File Offset: 0x0000106A
		[global::Cpp2ILInjected.Token(Token = "0x60004F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE7EDC", Offset = "0x1CE7EDC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool ShouldSkipSerializing(Type t)
		{
			throw null;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00002E6D File Offset: 0x0000106D
		[global::Cpp2ILInjected.Token(Token = "0x60004F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE6060", Offset = "0x1CE6060", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "GetExtensionDataMemberForType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(MemberInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "GetCallbackMethodsForType", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(ref List<SerializationCallback>),
			typeof(ref List<SerializationCallback>),
			typeof(ref List<SerializationCallback>),
			typeof(ref List<SerializationCallback>),
			typeof(ref List<SerializationErrorCallback>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "BaseType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Reverse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private List<Type> GetClassHierarchyForType(Type type)
		{
			throw null;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00002E70 File Offset: 0x00001070
		[global::Cpp2ILInjected.Token(Token = "0x60004F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE85D4", Offset = "0x1CE85D4", Length = "0x37C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonDictionaryContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "GetAttributeConstructor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType)
		{
			throw null;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00002E73 File Offset: 0x00001073
		[global::Cpp2ILInjected.Token(Token = "0x60004F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE8E64", Offset = "0x1CE8E64", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonArrayContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "GetAttributeConstructor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		protected virtual JsonArrayContract CreateArrayContract(Type objectType)
		{
			throw null;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00002E76 File Offset: 0x00001076
		[global::Cpp2ILInjected.Token(Token = "0x60004F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE9924", Offset = "0x1CE9924", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPrimitiveContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType)
		{
			throw null;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00002E79 File Offset: 0x00001079
		[global::Cpp2ILInjected.Token(Token = "0x60004F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE9994", Offset = "0x1CE9994", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual JsonLinqContract CreateLinqContract(Type objectType)
		{
			throw null;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00002E7C File Offset: 0x0000107C
		[global::Cpp2ILInjected.Token(Token = "0x60004F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE9A0C", Offset = "0x1CE9A0C", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContainerContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new object[]
		{
			typeof(BindingFlags),
			typeof(Binder),
			typeof(Type[]),
			typeof(ParameterModifier[])
		}, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		protected virtual JsonISerializableContract CreateISerializableContract(Type objectType)
		{
			throw null;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00002E7F File Offset: 0x0000107F
		[global::Cpp2ILInjected.Token(Token = "0x60004F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE9BD4", Offset = "0x1CE9BD4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonStringContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "InitializeContract", MemberParameters = new object[] { typeof(JsonContract) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual JsonStringContract CreateStringContract(Type objectType)
		{
			throw null;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00002E82 File Offset: 0x00001082
		[global::Cpp2ILInjected.Token(Token = "0x60004F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE9C48", Offset = "0x1CE9C48", Length = "0x348")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "IsJsonPrimitiveType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "EnsureNotNullableType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "GetCachedAttribute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionUtils), Member = "IsDictionaryType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "CanConvertToString", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "IsIConvertible", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		protected virtual JsonContract CreateContract(Type objectType)
		{
			throw null;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00002E85 File Offset: 0x00001085
		[global::Cpp2ILInjected.Token(Token = "0x60004FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE9F90", Offset = "0x1CE9F90", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(PrimitiveTypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static bool IsJsonPrimitiveType(Type t)
		{
			throw null;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00002E88 File Offset: 0x00001088
		[global::Cpp2ILInjected.Token(Token = "0x60004FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEA208", Offset = "0x1CEA208", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static bool IsIConvertible(Type t)
		{
			throw null;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00002E8B File Offset: 0x0000108B
		[global::Cpp2ILInjected.Token(Token = "0x60004FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE9FF4", Offset = "0x1CE9FF4", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonContract))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "GetConverter", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverter), Member = "CanConvertTo", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal static bool CanConvertToString(Type type)
		{
			throw null;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00002E8E File Offset: 0x0000108E
		[global::Cpp2ILInjected.Token(Token = "0x60004FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE7EEC", Offset = "0x1CE7EEC", Length = "0x5A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "GetCallbackMethodsForType", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(ref List<SerializationCallback>),
			typeof(ref List<SerializationCallback>),
			typeof(ref List<SerializationCallback>),
			typeof(ref List<SerializationCallback>),
			typeof(ref List<SerializationErrorCallback>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "get_IsVirtual", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "GetClrTypeFullName", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 51)]
		private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType)
		{
			throw null;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00002E91 File Offset: 0x00001091
		[global::Cpp2ILInjected.Token(Token = "0x60004FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEA374", Offset = "0x1CEA374", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver.<>c), Member = "<GetExtensionDataMemberForType>b__33_1", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "IsValidCallback", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(ParameterInfo[]),
			typeof(Type),
			typeof(MethodInfo),
			typeof(ref Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "IsGenericTypeDefinition", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "ContainsGenericParameters", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(IFormatProvider),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal static string GetClrTypeFullName(Type type)
		{
			throw null;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00002E94 File Offset: 0x00001094
		[global::Cpp2ILInjected.Token(Token = "0x60004FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEA4D4", Offset = "0x1CEA4D4", Length = "0x3D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPropertyCollection), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "GetState", ReturnType = typeof(DefaultContractResolverState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyNameTable), Member = "Add", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonProperty), Member = "set_PropertyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPropertyCollection), Member = "AddProperty", MemberParameters = new object[] { typeof(JsonProperty) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, int>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "OrderBy", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, int>)
		}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			throw null;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00002E97 File Offset: 0x00001097
		[global::Cpp2ILInjected.Token(Token = "0x6000500")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEA8AC", Offset = "0x1CEA8AC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionValueProvider), Member = ".ctor", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member)
		{
			throw null;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002E9A File Offset: 0x0000109A
		[global::Cpp2ILInjected.Token(Token = "0x6000501")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEA908", Offset = "0x1CEA908", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetMemberUnderlyingType", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionAttributeProvider), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "SetPropertySettingsFromAttributes", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(object),
			typeof(string),
			typeof(Type),
			typeof(MemberSerialization),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "CanReadMemberValue", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "CanSetMemberValue", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "CreateShouldSerializeTest", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(Predicate<object>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "SetIsSpecifiedActions", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(MemberInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			throw null;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002E9D File Offset: 0x0000109D
		[global::Cpp2ILInjected.Token(Token = "0x6000502")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE6CB0", Offset = "0x1CE6CB0", Length = "0x49C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreatePropertyFromConstructorParameter", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(ParameterInfo)
		}, ReturnType = typeof(JsonProperty))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperty", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(MemberSerialization)
		}, ReturnType = typeof(JsonProperty))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "GetDataContractAttribute", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(DataContractAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "GetAttribute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonProperty), Member = "set_PropertyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "GetJsonConverter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JsonConverter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "CreateJsonConverterInstance", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object[])
		}, ReturnType = typeof(JsonConverter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "GetDataMemberAttribute", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(DataMemberAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess)
		{
			throw null;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002EA0 File Offset: 0x000010A0
		[global::Cpp2ILInjected.Token(Token = "0x6000503")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEAAEC", Offset = "0x1CEAAEC", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperty", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(MemberSerialization)
		}, ReturnType = typeof(JsonProperty))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type[])
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private Predicate<object> CreateShouldSerializeTest(MemberInfo member)
		{
			throw null;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00002EA3 File Offset: 0x000010A3
		[global::Cpp2ILInjected.Token(Token = "0x6000504")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEAD24", Offset = "0x1CEAD24", Length = "0x29C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperty", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(MemberSerialization)
		}, ReturnType = typeof(JsonProperty))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetField", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(FieldInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetMemberUnderlyingType", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionDelegateFactory), Member = "CreateGet", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = "System.Func`2<T, Object>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "CanSetMemberValue", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionDelegateFactory), Member = "CreateSet", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = "System.Action`2<T, Object>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess)
		{
			throw null;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00002EA6 File Offset: 0x000010A6
		[global::Cpp2ILInjected.Token(Token = "0x6000505")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEAFD0", Offset = "0x1CEAFD0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual string ResolvePropertyName(string propertyName)
		{
			throw null;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00002EA9 File Offset: 0x000010A9
		[global::Cpp2ILInjected.Token(Token = "0x6000506")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEAFD8", Offset = "0x1CEAFD8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual string ResolveDictionaryKey(string dictionaryKey)
		{
			throw null;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00002EAC File Offset: 0x000010AC
		[global::Cpp2ILInjected.Token(Token = "0x6000507")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEAFE8", Offset = "0x1CEAFE8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyValuePairConverter), Member = "WriteJson", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegexConverter), Member = "WriteJson", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Regex),
			typeof(JsonSerializer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string GetResolvedPropertyName(string propertyName)
		{
			throw null;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00002EAF File Offset: 0x000010AF
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000508")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEAFF8", Offset = "0x1CEAFF8", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyValuePairConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonObjectIdConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RegexConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolverState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		static DefaultContractResolver()
		{
			throw null;
		}

		// Token: 0x040001E2 RID: 482
		[global::Cpp2ILInjected.Token(Token = "0x4000227")]
		private static readonly IContractResolver _instance;

		// Token: 0x040001E3 RID: 483
		[global::Cpp2ILInjected.Token(Token = "0x4000228")]
		private static readonly JsonConverter[] BuiltInConverters;

		// Token: 0x040001E4 RID: 484
		[global::Cpp2ILInjected.Token(Token = "0x4000229")]
		private static readonly object TypeContractCacheLock;

		// Token: 0x040001E5 RID: 485
		[global::Cpp2ILInjected.Token(Token = "0x400022A")]
		private static readonly DefaultContractResolverState _sharedState;

		// Token: 0x040001E6 RID: 486
		[global::Cpp2ILInjected.Token(Token = "0x400022B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly DefaultContractResolverState _instanceState;

		// Token: 0x040001E7 RID: 487
		[global::Cpp2ILInjected.Token(Token = "0x400022C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly bool _sharedCache;

		// Token: 0x040001E8 RID: 488
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400022D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private BindingFlags <DefaultMembersSearchFlags>k__BackingField;

		// Token: 0x040001E9 RID: 489
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400022E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool <SerializeCompilerGeneratedMembers>k__BackingField;

		// Token: 0x040001EA RID: 490
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400022F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
		private bool <IgnoreSerializableInterface>k__BackingField;

		// Token: 0x040001EB RID: 491
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000230")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
		private bool <IgnoreSerializableAttribute>k__BackingField;

		// Token: 0x0200010B RID: 267
		[global::Cpp2ILInjected.Token(Token = "0x200008B")]
		internal class EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : IEnumerable<KeyValuePair<object, object>>, IEnumerable
		{
			// Token: 0x06000AC9 RID: 2761 RVA: 0x00003FD7 File Offset: 0x000021D7
			[global::Cpp2ILInjected.Token(Token = "0x6000509")]
			[global::Cpp2ILInjected.Address(RVA = "0x16422C8", Offset = "0x16422C8", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
			{
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public EnumerableDictionaryWrapper(IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e)
			{
				throw null;
			}

			// Token: 0x06000ACA RID: 2762 RVA: 0x00003FDA File Offset: 0x000021DA
			[global::Cpp2ILInjected.Token(Token = "0x600050A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1642334", Offset = "0x1642334", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public IEnumerator<KeyValuePair<object, object>> GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06000ACB RID: 2763 RVA: 0x00003FDD File Offset: 0x000021DD
			[global::Cpp2ILInjected.Token(Token = "0x600050B")]
			[global::Cpp2ILInjected.Address(RVA = "0x164239C", Offset = "0x164239C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x040003A9 RID: 937
			[global::Cpp2ILInjected.Token(Token = "0x4000231")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;

			// Token: 0x0200013E RID: 318
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x200008C")]
			private sealed class <GetEnumerator>d__2 : IEnumerator<KeyValuePair<object, object>>, IDisposable, IEnumerator
			{
				// Token: 0x06000BB6 RID: 2998 RVA: 0x0000429E File Offset: 0x0000249E
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600050C")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BA750", Offset = "0x15BA750", Length = "0x28")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <GetEnumerator>d__2(int <>1__state)
				{
					throw null;
				}

				// Token: 0x06000BB7 RID: 2999 RVA: 0x000042A1 File Offset: 0x000024A1
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600050D")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BA778", Offset = "0x15BA778", Length = "0x2C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				private void System.IDisposable.Dispose()
				{
					throw null;
				}

				// Token: 0x06000BB8 RID: 3000 RVA: 0x000042A4 File Offset: 0x000024A4
				[global::Cpp2ILInjected.Token(Token = "0x600050E")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BA7A4", Offset = "0x15BA7A4", Length = "0x2D8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyValuePair<object, object>), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(object)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
				private bool MoveNext()
				{
					throw null;
				}

				// Token: 0x06000BB9 RID: 3001 RVA: 0x000042A7 File Offset: 0x000024A7
				[global::Cpp2ILInjected.Token(Token = "0x600050F")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BAA7C", Offset = "0x15BAA7C", Length = "0xB0")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				private void <>m__Finally1()
				{
					throw null;
				}

				// Token: 0x1700023D RID: 573
				// (get) Token: 0x06000BBA RID: 3002 RVA: 0x000042AA File Offset: 0x000024AA
				[global::Cpp2ILInjected.Token(Token = "0x170000D4")]
				private KeyValuePair<object, object> prop_KeyValuePair_2_Object_Object_0
				{
					[DebuggerHidden]
					[global::Cpp2ILInjected.Token(Token = "0x6000510")]
					[global::Cpp2ILInjected.Address(RVA = "0x15BAB2C", Offset = "0x15BAB2C", Length = "0xC")]
					[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					get
					{
						throw null;
					}
				}

				// Token: 0x06000BBB RID: 3003 RVA: 0x000042AD File Offset: 0x000024AD
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000511")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BAB38", Offset = "0x15BAB38", Length = "0x38")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				private void System.Collections.IEnumerator.Reset()
				{
					throw null;
				}

				// Token: 0x1700023E RID: 574
				// (get) Token: 0x06000BBC RID: 3004 RVA: 0x000042B0 File Offset: 0x000024B0
				[global::Cpp2ILInjected.Token(Token = "0x170000D5")]
				private object System.Collections.IEnumerator.Current
				{
					[DebuggerHidden]
					[global::Cpp2ILInjected.Token(Token = "0x6000512")]
					[global::Cpp2ILInjected.Address(RVA = "0x15BAB70", Offset = "0x15BAB70", Length = "0x5C")]
					[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
					[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
					[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
					[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
					get
					{
						throw null;
					}
				}

				// Token: 0x04000484 RID: 1156
				[global::Cpp2ILInjected.Token(Token = "0x4000232")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private int <>1__state;

				// Token: 0x04000485 RID: 1157
				[global::Cpp2ILInjected.Token(Token = "0x4000233")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private KeyValuePair<object, object> <>2__current;

				// Token: 0x04000486 RID: 1158
				[global::Cpp2ILInjected.Token(Token = "0x4000234")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				public DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> <>4__this;

				// Token: 0x04000487 RID: 1159
				[global::Cpp2ILInjected.Token(Token = "0x4000235")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				private IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> <>7__wrap1;
			}
		}

		// Token: 0x0200010C RID: 268
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200008D")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000ACC RID: 2764 RVA: 0x00003FE0 File Offset: 0x000021E0
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000513")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEB214", Offset = "0x1CEB214", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06000ACD RID: 2765 RVA: 0x00003FE3 File Offset: 0x000021E3
			[global::Cpp2ILInjected.Token(Token = "0x6000514")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEB270", Offset = "0x1CEB270", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06000ACE RID: 2766 RVA: 0x00003FE6 File Offset: 0x000021E6
			[global::Cpp2ILInjected.Token(Token = "0x6000515")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEB278", Offset = "0x1CEB278", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsIndexedProperty", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <GetSerializableMembers>b__30_0(MemberInfo m)
			{
				throw null;
			}

			// Token: 0x06000ACF RID: 2767 RVA: 0x00003FE9 File Offset: 0x000021E9
			[global::Cpp2ILInjected.Token(Token = "0x6000516")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEB2DC", Offset = "0x1CEB2DC", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsIndexedProperty", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <GetSerializableMembers>b__30_1(MemberInfo m)
			{
				throw null;
			}

			// Token: 0x06000AD0 RID: 2768 RVA: 0x00003FEC File Offset: 0x000021EC
			[global::Cpp2ILInjected.Token(Token = "0x6000517")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEB340", Offset = "0x1CEB340", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionUtils), Member = "AddRange", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.IList`1<T>", "System.Collections.Generic.IEnumerable`1<T>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal IEnumerable<MemberInfo> <GetExtensionDataMemberForType>b__33_0(Type baseType)
			{
				throw null;
			}

			// Token: 0x06000AD1 RID: 2769 RVA: 0x00003FEF File Offset: 0x000021EF
			[global::Cpp2ILInjected.Token(Token = "0x6000518")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEB418", Offset = "0x1CEB418", Length = "0x37C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "MemberType", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(MemberTypes))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "CanReadMemberValue", MemberParameters = new object[]
			{
				typeof(MemberInfo),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetMemberUnderlyingType", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "ImplementsGenericDefinition", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type),
				typeof(ref Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultContractResolver), Member = "GetClrTypeFullName", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(IFormatProvider),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
			internal bool <GetExtensionDataMemberForType>b__33_1(MemberInfo m)
			{
				throw null;
			}

			// Token: 0x06000AD2 RID: 2770 RVA: 0x00003FF2 File Offset: 0x000021F2
			[global::Cpp2ILInjected.Token(Token = "0x6000519")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEB794", Offset = "0x1CEB794", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal bool <GetAttributeConstructor>b__36_0(ConstructorInfo c)
			{
				throw null;
			}

			// Token: 0x06000AD3 RID: 2771 RVA: 0x00003FF5 File Offset: 0x000021F5
			[global::Cpp2ILInjected.Token(Token = "0x600051A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEB824", Offset = "0x1CEB824", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal int <CreateProperties>b__60_0(JsonProperty p)
			{
				throw null;
			}

			// Token: 0x040003AA RID: 938
			[global::Cpp2ILInjected.Token(Token = "0x4000236")]
			public static readonly DefaultContractResolver.<>c <>9;

			// Token: 0x040003AB RID: 939
			[global::Cpp2ILInjected.Token(Token = "0x4000237")]
			public static Func<MemberInfo, bool> <>9__30_0;

			// Token: 0x040003AC RID: 940
			[global::Cpp2ILInjected.Token(Token = "0x4000238")]
			public static Func<MemberInfo, bool> <>9__30_1;

			// Token: 0x040003AD RID: 941
			[global::Cpp2ILInjected.Token(Token = "0x4000239")]
			public static Func<Type, IEnumerable<MemberInfo>> <>9__33_0;

			// Token: 0x040003AE RID: 942
			[global::Cpp2ILInjected.Token(Token = "0x400023A")]
			public static Func<MemberInfo, bool> <>9__33_1;

			// Token: 0x040003AF RID: 943
			[global::Cpp2ILInjected.Token(Token = "0x400023B")]
			public static Func<ConstructorInfo, bool> <>9__36_0;

			// Token: 0x040003B0 RID: 944
			[global::Cpp2ILInjected.Token(Token = "0x400023C")]
			public static Func<JsonProperty, int> <>9__60_0;
		}

		// Token: 0x0200010D RID: 269
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200008E")]
		private sealed class <>c__DisplayClass34_0
		{
			// Token: 0x06000AD4 RID: 2772 RVA: 0x00003FF8 File Offset: 0x000021F8
			[global::Cpp2ILInjected.Token(Token = "0x600051B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE61CC", Offset = "0x1CE61CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass34_0()
			{
				throw null;
			}

			// Token: 0x040003B1 RID: 945
			[global::Cpp2ILInjected.Token(Token = "0x400023D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Func<object, object> getExtensionDataDictionary;

			// Token: 0x040003B2 RID: 946
			[global::Cpp2ILInjected.Token(Token = "0x400023E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public MemberInfo member;
		}

		// Token: 0x0200010E RID: 270
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200008F")]
		private sealed class <>c__DisplayClass34_1
		{
			// Token: 0x06000AD5 RID: 2773 RVA: 0x00003FFB File Offset: 0x000021FB
			[global::Cpp2ILInjected.Token(Token = "0x600051C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE61D4", Offset = "0x1CE61D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass34_1()
			{
				throw null;
			}

			// Token: 0x06000AD6 RID: 2774 RVA: 0x00003FFE File Offset: 0x000021FE
			[global::Cpp2ILInjected.Token(Token = "0x600051D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEB874", Offset = "0x1CEB874", Length = "0x1B4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(IFormatProvider),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			internal void <SetExtensionDataDelegates>b__0(object o, string key, object value)
			{
				throw null;
			}

			// Token: 0x040003B3 RID: 947
			[global::Cpp2ILInjected.Token(Token = "0x400023F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Action<object, object> setExtensionDataDictionary;

			// Token: 0x040003B4 RID: 948
			[global::Cpp2ILInjected.Token(Token = "0x4000240")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Func<object> createExtensionDataDictionary;

			// Token: 0x040003B5 RID: 949
			[global::Cpp2ILInjected.Token(Token = "0x4000241")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public MethodCall<object, object> setExtensionDataDictionaryValue;

			// Token: 0x040003B6 RID: 950
			[global::Cpp2ILInjected.Token(Token = "0x4000242")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public DefaultContractResolver.<>c__DisplayClass34_0 field_Public_<>c__DisplayClass34_0_0;
		}

		// Token: 0x0200010F RID: 271
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000090")]
		private sealed class <>c__DisplayClass34_2
		{
			// Token: 0x06000AD7 RID: 2775 RVA: 0x00004001 File Offset: 0x00002201
			[global::Cpp2ILInjected.Token(Token = "0x600051E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE630C", Offset = "0x1CE630C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass34_2()
			{
				throw null;
			}

			// Token: 0x06000AD8 RID: 2776 RVA: 0x00004004 File Offset: 0x00002204
			[global::Cpp2ILInjected.Token(Token = "0x600051F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEBA28", Offset = "0x1CEBA28", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			internal IEnumerable<KeyValuePair<object, object>> <SetExtensionDataDelegates>b__1(object o)
			{
				throw null;
			}

			// Token: 0x040003B7 RID: 951
			[global::Cpp2ILInjected.Token(Token = "0x4000243")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public ObjectConstructor<object> createEnumerableWrapper;

			// Token: 0x040003B8 RID: 952
			[global::Cpp2ILInjected.Token(Token = "0x4000244")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public DefaultContractResolver.<>c__DisplayClass34_0 field_Public_<>c__DisplayClass34_0_0;
		}

		// Token: 0x02000110 RID: 272
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000091")]
		private sealed class <>c__DisplayClass64_0
		{
			// Token: 0x06000AD9 RID: 2777 RVA: 0x00004007 File Offset: 0x00002207
			[global::Cpp2ILInjected.Token(Token = "0x6000520")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEAFC0", Offset = "0x1CEAFC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass64_0()
			{
				throw null;
			}

			// Token: 0x06000ADA RID: 2778 RVA: 0x0000400A File Offset: 0x0000220A
			[global::Cpp2ILInjected.Token(Token = "0x6000521")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEBB14", Offset = "0x1CEBB14", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal bool <CreateShouldSerializeTest>b__0(object o)
			{
				throw null;
			}

			// Token: 0x040003B9 RID: 953
			[global::Cpp2ILInjected.Token(Token = "0x4000245")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public MethodCall<object, object> shouldSerializeCall;
		}

		// Token: 0x02000111 RID: 273
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000092")]
		private sealed class <>c__DisplayClass65_0
		{
			// Token: 0x06000ADB RID: 2779 RVA: 0x0000400D File Offset: 0x0000220D
			[global::Cpp2ILInjected.Token(Token = "0x6000522")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEAFC8", Offset = "0x1CEAFC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass65_0()
			{
				throw null;
			}

			// Token: 0x06000ADC RID: 2780 RVA: 0x00004010 File Offset: 0x00002210
			[global::Cpp2ILInjected.Token(Token = "0x6000523")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEBBC4", Offset = "0x1CEBBC4", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal bool <SetIsSpecifiedActions>b__0(object o)
			{
				throw null;
			}

			// Token: 0x040003BA RID: 954
			[global::Cpp2ILInjected.Token(Token = "0x4000246")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Func<object, object> specifiedPropertyGet;
		}
	}
}
