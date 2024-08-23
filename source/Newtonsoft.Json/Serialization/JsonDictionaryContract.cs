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
	// Token: 0x0200007D RID: 125
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000A1")]
	public class JsonDictionaryContract : JsonContainerContract
	{
		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x00002F8D File Offset: 0x0000118D
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00002F90 File Offset: 0x00001190
		[Obsolete("PropertyNameResolver is obsolete. Use DictionaryKeyResolver instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x170000F6")]
		public Func<string, string> PropertyNameResolver
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000588")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE840", Offset = "0x1CEE840", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000589")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE848", Offset = "0x1CEE848", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00002F93 File Offset: 0x00001193
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x00002F96 File Offset: 0x00001196
		[global::Cpp2ILInjected.Token(Token = "0x170000F7")]
		public Func<string, string> DictionaryKeyResolver
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600058A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE850", Offset = "0x1CEE850", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600058B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE858", Offset = "0x1CEE858", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00002F99 File Offset: 0x00001199
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00002F9C File Offset: 0x0000119C
		[global::Cpp2ILInjected.Token(Token = "0x170000F8")]
		public Type DictionaryKeyType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600058C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE860", Offset = "0x1CEE860", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600058D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE868", Offset = "0x1CEE868", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00002F9F File Offset: 0x0000119F
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00002FA2 File Offset: 0x000011A2
		[global::Cpp2ILInjected.Token(Token = "0x170000F9")]
		public Type DictionaryValueType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600058E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE870", Offset = "0x1CEE870", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600058F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE878", Offset = "0x1CEE878", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00002FA5 File Offset: 0x000011A5
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x00002FA8 File Offset: 0x000011A8
		[global::Cpp2ILInjected.Token(Token = "0x170000FA")]
		internal JsonContract KeyContract
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000590")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE880", Offset = "0x1CEE880", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000591")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE888", Offset = "0x1CEE888", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00002FAB File Offset: 0x000011AB
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x00002FAE File Offset: 0x000011AE
		[global::Cpp2ILInjected.Token(Token = "0x170000FB")]
		internal bool ShouldCreateWrapper
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000592")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE890", Offset = "0x1CEE890", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000593")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE898", Offset = "0x1CEE898", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00002FB1 File Offset: 0x000011B1
		[global::Cpp2ILInjected.Token(Token = "0x170000FC")]
		internal ObjectConstructor<object> ParameterizedCreator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000594")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE8A4", Offset = "0x1CEE8A4", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(Type),
				typeof(JsonContract),
				typeof(JsonProperty),
				typeof(JsonContainerContract),
				typeof(JsonProperty),
				typeof(object)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00002FB4 File Offset: 0x000011B4
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x00002FB7 File Offset: 0x000011B7
		[global::Cpp2ILInjected.Token(Token = "0x170000FD")]
		public ObjectConstructor<object> OverrideCreator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000595")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE918", Offset = "0x1CEE918", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000596")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE920", Offset = "0x1CEE920", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x00002FBA File Offset: 0x000011BA
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x00002FBD File Offset: 0x000011BD
		[global::Cpp2ILInjected.Token(Token = "0x170000FE")]
		public bool HasParameterizedCreator
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000597")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE928", Offset = "0x1CEE928", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000598")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE930", Offset = "0x1CEE930", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00002FC0 File Offset: 0x000011C0
		[global::Cpp2ILInjected.Token(Token = "0x170000FF")]
		internal bool HasParameterizedCreatorInternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000599")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE93C", Offset = "0x1CEE93C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00002FC3 File Offset: 0x000011C3
		[global::Cpp2ILInjected.Token(Token = "0x600059A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE8950", Offset = "0x1CE8950", Length = "0x514")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateDictionaryContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonDictionaryContract))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContainerContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetDictionaryKeyValueTypes", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(ref Type),
			typeof(ref Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "set_CreatedType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionUtils), Member = "ResolveEnumerableCollectionConstructor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "InheritsGenericDefinition", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type),
			typeof(ref Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		public JsonDictionaryContract(Type underlyingType)
		{
			throw null;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00002FC6 File Offset: 0x000011C6
		[global::Cpp2ILInjected.Token(Token = "0x600059B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEE964", Offset = "0x1CEE964", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Populate", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObject", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateNewDictionary", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonDictionaryContract),
			typeof(ref bool)
		}, ReturnType = typeof(IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(ObjectConstructor<object>),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new object[] { typeof(Type[]) }, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		internal IWrappedDictionary CreateWrapper(object dictionary)
		{
			throw null;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00002FC9 File Offset: 0x000011C9
		[global::Cpp2ILInjected.Token(Token = "0x600059C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEEBA4", Offset = "0x1CEEBA4", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateNewDictionary", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonDictionaryContract),
			typeof(ref bool)
		}, ReturnType = typeof(IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		internal IDictionary CreateTemporaryDictionary()
		{
			throw null;
		}

		// Token: 0x04000220 RID: 544
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400027F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private Func<string, string> <DictionaryKeyResolver>k__BackingField;

		// Token: 0x04000221 RID: 545
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000280")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private Type <DictionaryKeyType>k__BackingField;

		// Token: 0x04000222 RID: 546
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000281")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private Type <DictionaryValueType>k__BackingField;

		// Token: 0x04000223 RID: 547
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000282")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private JsonContract <KeyContract>k__BackingField;

		// Token: 0x04000224 RID: 548
		[global::Cpp2ILInjected.Token(Token = "0x4000283")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private readonly Type _genericCollectionDefinitionType;

		// Token: 0x04000225 RID: 549
		[global::Cpp2ILInjected.Token(Token = "0x4000284")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private Type _genericWrapperType;

		// Token: 0x04000226 RID: 550
		[global::Cpp2ILInjected.Token(Token = "0x4000285")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private ObjectConstructor<object> _genericWrapperCreator;

		// Token: 0x04000227 RID: 551
		[global::Cpp2ILInjected.Token(Token = "0x4000286")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private Func<object> _genericTemporaryDictionaryCreator;

		// Token: 0x04000228 RID: 552
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000287")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private bool <ShouldCreateWrapper>k__BackingField;

		// Token: 0x04000229 RID: 553
		[global::Cpp2ILInjected.Token(Token = "0x4000288")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private readonly ConstructorInfo _parameterizedConstructor;

		// Token: 0x0400022A RID: 554
		[global::Cpp2ILInjected.Token(Token = "0x4000289")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private ObjectConstructor<object> _overrideCreator;

		// Token: 0x0400022B RID: 555
		[global::Cpp2ILInjected.Token(Token = "0x400028A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		private ObjectConstructor<object> _parameterizedCreator;

		// Token: 0x0400022C RID: 556
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400028B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		private bool <HasParameterizedCreator>k__BackingField;
	}
}
