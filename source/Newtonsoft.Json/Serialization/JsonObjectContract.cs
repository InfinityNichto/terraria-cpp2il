using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000081 RID: 129
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000A5")]
	public class JsonObjectContract : JsonContainerContract
	{
		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x0000309E File Offset: 0x0000129E
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x000030A1 File Offset: 0x000012A1
		[global::Cpp2ILInjected.Token(Token = "0x1700011E")]
		public MemberSerialization MemberSerialization
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF304", Offset = "0x1CEF304", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF30C", Offset = "0x1CEF30C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x000030A4 File Offset: 0x000012A4
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x000030A7 File Offset: 0x000012A7
		[global::Cpp2ILInjected.Token(Token = "0x1700011F")]
		public Required? ItemRequired
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF314", Offset = "0x1CEF314", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF31C", Offset = "0x1CEF31C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x000030AA File Offset: 0x000012AA
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x000030AD File Offset: 0x000012AD
		[global::Cpp2ILInjected.Token(Token = "0x17000120")]
		public JsonPropertyCollection Properties
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF324", Offset = "0x1CEF324", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF32C", Offset = "0x1CEF32C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x000030B0 File Offset: 0x000012B0
		[Obsolete("ConstructorParameters is obsolete. Use CreatorParameters instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x17000121")]
		public JsonPropertyCollection ConstructorParameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF334", Offset = "0x1CEF334", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonObjectContract), Member = "get_CreatorParameters", ReturnType = typeof(JsonPropertyCollection))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x000030B3 File Offset: 0x000012B3
		[global::Cpp2ILInjected.Token(Token = "0x17000122")]
		public JsonPropertyCollection CreatorParameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE55DC", Offset = "0x1CE55DC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonObjectContract))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonObjectContract), Member = "get_ConstructorParameters", ReturnType = typeof(JsonPropertyCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(JsonObjectContract),
				typeof(JsonProperty),
				typeof(ObjectConstructor<object>),
				typeof(string)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ResolvePropertyAndCreatorValues", MemberParameters = new object[]
			{
				typeof(JsonObjectContract),
				typeof(JsonProperty),
				typeof(JsonReader),
				typeof(Type)
			}, ReturnType = typeof(List<JsonSerializerInternalReader.CreatorPropertyContext>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateNewObject", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(JsonObjectContract),
				typeof(JsonProperty),
				typeof(JsonProperty),
				typeof(string),
				typeof(ref bool)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPropertyCollection), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x000030B6 File Offset: 0x000012B6
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x000030B9 File Offset: 0x000012B9
		[Obsolete("OverrideConstructor is obsolete. Use OverrideCreator instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x17000123")]
		public ConstructorInfo OverrideConstructor
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF338", Offset = "0x1CEF338", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60005F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE555C", Offset = "0x1CE555C", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonObjectContract))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x000030BC File Offset: 0x000012BC
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x000030BF File Offset: 0x000012BF
		[Obsolete("ParametrizedConstructor is obsolete. Use OverrideCreator instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x17000124")]
		public ConstructorInfo ParametrizedConstructor
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF340", Offset = "0x1CEF340", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60005F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE57A4", Offset = "0x1CE57A4", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonObjectContract))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_ReflectionDelegateFactory", ReturnType = typeof(ReflectionDelegateFactory))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x000030C2 File Offset: 0x000012C2
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x000030C5 File Offset: 0x000012C5
		[global::Cpp2ILInjected.Token(Token = "0x17000125")]
		public ObjectConstructor<object> OverrideCreator
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF348", Offset = "0x1CEF348", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60005F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF350", Offset = "0x1CEF350", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x000030C8 File Offset: 0x000012C8
		[global::Cpp2ILInjected.Token(Token = "0x17000126")]
		internal ObjectConstructor<object> ParameterizedCreator
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF358", Offset = "0x1CEF358", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x000030CB File Offset: 0x000012CB
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x000030CE File Offset: 0x000012CE
		[global::Cpp2ILInjected.Token(Token = "0x17000127")]
		public ExtensionDataSetter ExtensionDataSetter
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF360", Offset = "0x1CEF360", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF368", Offset = "0x1CEF368", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x000030D1 File Offset: 0x000012D1
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x000030D4 File Offset: 0x000012D4
		[global::Cpp2ILInjected.Token(Token = "0x17000128")]
		public ExtensionDataGetter ExtensionDataGetter
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF370", Offset = "0x1CEF370", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF378", Offset = "0x1CEF378", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x000030D7 File Offset: 0x000012D7
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x000030DA File Offset: 0x000012DA
		[global::Cpp2ILInjected.Token(Token = "0x17000129")]
		public Type ExtensionDataValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF380", Offset = "0x1CEF380", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60005FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE6440", Offset = "0x1CE6440", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "SetExtensionDataDelegates", MemberParameters = new object[]
			{
				typeof(JsonObjectContract),
				typeof(MemberInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x000030DD File Offset: 0x000012DD
		[global::Cpp2ILInjected.Token(Token = "0x1700012A")]
		internal bool HasRequiredOrDefaultValueProperties
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF388", Offset = "0x1CEF388", Length = "0x3D0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(JsonObjectContract),
				typeof(JsonProperty),
				typeof(ObjectConstructor<object>),
				typeof(string)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new object[]
			{
				typeof(object),
				typeof(JsonReader),
				typeof(JsonObjectContract),
				typeof(JsonProperty),
				typeof(string)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = "GetValueOrDefault", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collection<>), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonProperty), Member = "get_Required", ReturnType = typeof(Required))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x000030E0 File Offset: 0x000012E0
		[global::Cpp2ILInjected.Token(Token = "0x60005FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE4E70", Offset = "0x1CE4E70", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateObjectContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonObjectContract))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContainerContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPropertyCollection), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public JsonObjectContract(Type underlyingType)
		{
			throw null;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x000030E3 File Offset: 0x000012E3
		[global::Cpp2ILInjected.Token(Token = "0x60005FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEF758", Offset = "0x1CEF758", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "get_FullyTrusted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "GetUninitializedObject", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal object GetUninitializedObject()
		{
			throw null;
		}

		// Token: 0x04000250 RID: 592
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
		private MemberSerialization <MemberSerialization>k__BackingField;

		// Token: 0x04000251 RID: 593
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private Required? <ItemRequired>k__BackingField;

		// Token: 0x04000252 RID: 594
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private JsonPropertyCollection <Properties>k__BackingField;

		// Token: 0x04000253 RID: 595
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private ExtensionDataSetter <ExtensionDataSetter>k__BackingField;

		// Token: 0x04000254 RID: 596
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private ExtensionDataGetter <ExtensionDataGetter>k__BackingField;

		// Token: 0x04000255 RID: 597
		[global::Cpp2ILInjected.Token(Token = "0x40002B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		internal bool ExtensionDataIsJToken;

		// Token: 0x04000256 RID: 598
		[global::Cpp2ILInjected.Token(Token = "0x40002B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE1")]
		private bool? _hasRequiredOrDefaultValueProperties;

		// Token: 0x04000257 RID: 599
		[global::Cpp2ILInjected.Token(Token = "0x40002B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private ConstructorInfo _parametrizedConstructor;

		// Token: 0x04000258 RID: 600
		[global::Cpp2ILInjected.Token(Token = "0x40002B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private ConstructorInfo _overrideConstructor;

		// Token: 0x04000259 RID: 601
		[global::Cpp2ILInjected.Token(Token = "0x40002B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private ObjectConstructor<object> _overrideCreator;

		// Token: 0x0400025A RID: 602
		[global::Cpp2ILInjected.Token(Token = "0x40002B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private ObjectConstructor<object> _parameterizedCreator;

		// Token: 0x0400025B RID: 603
		[global::Cpp2ILInjected.Token(Token = "0x40002BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private JsonPropertyCollection _creatorParameters;

		// Token: 0x0400025C RID: 604
		[global::Cpp2ILInjected.Token(Token = "0x40002BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private Type _extensionDataValueType;
	}
}
