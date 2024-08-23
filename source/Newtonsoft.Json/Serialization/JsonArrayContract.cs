using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000076 RID: 118
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000098")]
	public class JsonArrayContract : JsonContainerContract
	{
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00002EE5 File Offset: 0x000010E5
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x00002EE8 File Offset: 0x000010E8
		[global::Cpp2ILInjected.Token(Token = "0x170000DC")]
		public Type CollectionItemType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600053C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEC194", Offset = "0x1CEC194", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600053D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEC19C", Offset = "0x1CEC19C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00002EEB File Offset: 0x000010EB
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x00002EEE File Offset: 0x000010EE
		[global::Cpp2ILInjected.Token(Token = "0x170000DD")]
		public bool IsMultidimensionalArray
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600053E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEC1A4", Offset = "0x1CEC1A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600053F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEC1AC", Offset = "0x1CEC1AC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00002EF1 File Offset: 0x000010F1
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x00002EF4 File Offset: 0x000010F4
		[global::Cpp2ILInjected.Token(Token = "0x170000DE")]
		internal bool IsArray
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000540")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEC1B8", Offset = "0x1CEC1B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000541")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEC1C0", Offset = "0x1CEC1C0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00002EF7 File Offset: 0x000010F7
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00002EFA File Offset: 0x000010FA
		[global::Cpp2ILInjected.Token(Token = "0x170000DF")]
		internal bool ShouldCreateWrapper
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000542")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEC1CC", Offset = "0x1CEC1CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000543")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEC1D4", Offset = "0x1CEC1D4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00002EFD File Offset: 0x000010FD
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00002F00 File Offset: 0x00001100
		[global::Cpp2ILInjected.Token(Token = "0x170000E0")]
		internal bool CanDeserialize
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000544")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEC1E0", Offset = "0x1CEC1E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000545")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEC1E8", Offset = "0x1CEC1E8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x00002F03 File Offset: 0x00001103
		[global::Cpp2ILInjected.Token(Token = "0x170000E1")]
		internal ObjectConstructor<object> ParameterizedCreator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000546")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEC1F4", Offset = "0x1CEC1F4", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(Type),
				typeof(JsonContract),
				typeof(JsonProperty),
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00002F06 File Offset: 0x00001106
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00002F09 File Offset: 0x00001109
		[global::Cpp2ILInjected.Token(Token = "0x170000E2")]
		public ObjectConstructor<object> OverrideCreator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000547")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEC268", Offset = "0x1CEC268", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000548")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE9914", Offset = "0x1CE9914", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00002F0C File Offset: 0x0000110C
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00002F0F File Offset: 0x0000110F
		[global::Cpp2ILInjected.Token(Token = "0x170000E3")]
		public bool HasParameterizedCreator
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000549")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEC270", Offset = "0x1CEC270", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600054A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEC278", Offset = "0x1CEC278", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00002F12 File Offset: 0x00001112
		[global::Cpp2ILInjected.Token(Token = "0x170000E4")]
		internal bool HasParameterizedCreatorInternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x600054B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEC284", Offset = "0x1CEC284", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00002F15 File Offset: 0x00001115
		[global::Cpp2ILInjected.Token(Token = "0x600054C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE9104", Offset = "0x1CE9104", Length = "0x810")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateArrayContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonArrayContract))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContainerContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetCollectionItemType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "set_CreatedType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionUtils), Member = "ResolveEnumerableCollectionConstructor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "InheritsGenericDefinition", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "InheritsGenericDefinition", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type),
			typeof(ref Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "IsGenericType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 45)]
		public JsonArrayContract(Type underlyingType)
		{
			throw null;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00002F18 File Offset: 0x00001118
		[global::Cpp2ILInjected.Token(Token = "0x600054D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEC308", Offset = "0x1CEC308", Length = "0x370")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Populate", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateNewList", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(ref bool)
		}, ReturnType = typeof(IList))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(ObjectConstructor<object>),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "InheritsGenericDefinition", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new object[] { typeof(Type[]) }, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		internal IWrappedCollection CreateWrapper(object list)
		{
			throw null;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00002F1B File Offset: 0x0000111B
		[global::Cpp2ILInjected.Token(Token = "0x600054E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEC678", Offset = "0x1CEC678", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateNewList", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(ref bool)
		}, ReturnType = typeof(IList))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		internal IList CreateTemporaryCollection()
		{
			throw null;
		}

		// Token: 0x040001F4 RID: 500
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000251")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private Type <CollectionItemType>k__BackingField;

		// Token: 0x040001F5 RID: 501
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000252")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private bool <IsMultidimensionalArray>k__BackingField;

		// Token: 0x040001F6 RID: 502
		[global::Cpp2ILInjected.Token(Token = "0x4000253")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private readonly Type _genericCollectionDefinitionType;

		// Token: 0x040001F7 RID: 503
		[global::Cpp2ILInjected.Token(Token = "0x4000254")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private Type _genericWrapperType;

		// Token: 0x040001F8 RID: 504
		[global::Cpp2ILInjected.Token(Token = "0x4000255")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private ObjectConstructor<object> _genericWrapperCreator;

		// Token: 0x040001F9 RID: 505
		[global::Cpp2ILInjected.Token(Token = "0x4000256")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private Func<object> _genericTemporaryCollectionCreator;

		// Token: 0x040001FA RID: 506
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000257")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private bool <IsArray>k__BackingField;

		// Token: 0x040001FB RID: 507
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000258")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF1")]
		private bool <ShouldCreateWrapper>k__BackingField;

		// Token: 0x040001FC RID: 508
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000259")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF2")]
		private bool <CanDeserialize>k__BackingField;

		// Token: 0x040001FD RID: 509
		[global::Cpp2ILInjected.Token(Token = "0x400025A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private readonly ConstructorInfo _parameterizedConstructor;

		// Token: 0x040001FE RID: 510
		[global::Cpp2ILInjected.Token(Token = "0x400025B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private ObjectConstructor<object> _parameterizedCreator;

		// Token: 0x040001FF RID: 511
		[global::Cpp2ILInjected.Token(Token = "0x400025C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private ObjectConstructor<object> _overrideCreator;

		// Token: 0x04000200 RID: 512
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400025D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private bool <HasParameterizedCreator>k__BackingField;
	}
}
