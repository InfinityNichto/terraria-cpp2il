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
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000A5")]
	public class JsonObjectContract : JsonContainerContract
	{
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

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
		private MemberSerialization <MemberSerialization>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private Required? <ItemRequired>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private JsonPropertyCollection <Properties>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private ExtensionDataSetter <ExtensionDataSetter>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private ExtensionDataGetter <ExtensionDataGetter>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x40002B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		internal bool ExtensionDataIsJToken;

		[global::Cpp2ILInjected.Token(Token = "0x40002B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE1")]
		private bool? _hasRequiredOrDefaultValueProperties;

		[global::Cpp2ILInjected.Token(Token = "0x40002B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private ConstructorInfo _parametrizedConstructor;

		[global::Cpp2ILInjected.Token(Token = "0x40002B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private ConstructorInfo _overrideConstructor;

		[global::Cpp2ILInjected.Token(Token = "0x40002B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private ObjectConstructor<object> _overrideCreator;

		[global::Cpp2ILInjected.Token(Token = "0x40002B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private ObjectConstructor<object> _parameterizedCreator;

		[global::Cpp2ILInjected.Token(Token = "0x40002BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private JsonPropertyCollection _creatorParameters;

		[global::Cpp2ILInjected.Token(Token = "0x40002BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private Type _extensionDataValueType;
	}
}
