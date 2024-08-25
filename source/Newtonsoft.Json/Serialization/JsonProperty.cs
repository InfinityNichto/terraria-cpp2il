using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000A2")]
	public class JsonProperty
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000100")]
		internal JsonContract PropertyContract
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600059D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEDF4", Offset = "0x1CEEDF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600059E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEDFC", Offset = "0x1CEEDFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000101")]
		public string PropertyName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600059F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEE04", Offset = "0x1CEEE04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60005A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE714C", Offset = "0x1CE714C", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreatePropertyFromConstructorParameter", MemberParameters = new object[]
			{
				typeof(JsonProperty),
				typeof(ParameterInfo)
			}, ReturnType = typeof(JsonProperty))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperties", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(MemberSerialization)
			}, ReturnType = typeof(IList<JsonProperty>))]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JavaScriptUtils), Member = "ShouldEscapeJavaScriptString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000102")]
		public Type DeclaringType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEE0C", Offset = "0x1CEEE0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEE14", Offset = "0x1CEEE14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000103")]
		public int? Order
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEE1C", Offset = "0x1CEEE1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEE24", Offset = "0x1CEEE24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000104")]
		public string UnderlyingName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEE2C", Offset = "0x1CEEE2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEE34", Offset = "0x1CEEE34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000105")]
		public IValueProvider ValueProvider
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEE3C", Offset = "0x1CEEE3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEE44", Offset = "0x1CEEE44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000106")]
		public IAttributeProvider AttributeProvider
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEE4C", Offset = "0x1CEEE4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEE54", Offset = "0x1CEEE54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000107")]
		public Type PropertyType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEE5C", Offset = "0x1CEEE5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60005AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE6C98", Offset = "0x1CE6C98", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000108")]
		public JsonConverter Converter
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEE64", Offset = "0x1CEEE64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEE6C", Offset = "0x1CEEE6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000109")]
		public JsonConverter MemberConverter
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEE74", Offset = "0x1CEEE74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEE7C", Offset = "0x1CEEE7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700010A")]
		public bool Ignored
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEE84", Offset = "0x1CEEE84", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEE8C", Offset = "0x1CEEE8C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700010B")]
		public bool Readable
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEE98", Offset = "0x1CEEE98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEEA0", Offset = "0x1CEEEA0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700010C")]
		public bool Writable
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEEAC", Offset = "0x1CEEEAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEEB4", Offset = "0x1CEEEB4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700010D")]
		public bool HasMemberAttribute
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEEC0", Offset = "0x1CEEEC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEEC8", Offset = "0x1CEEEC8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700010E")]
		public object DefaultValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE71D0", Offset = "0x1CE71D0", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60005BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE71E8", Offset = "0x1CE71E8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEEED4", Offset = "0x1CEEED4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CalculatePropertyDetails", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(ref JsonConverter),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(JsonReader),
			typeof(object),
			typeof(ref bool),
			typeof(ref object),
			typeof(ref JsonContract),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ShouldSetPropertyValue", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(ObjectConstructor<object>),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EndProcessProperty", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(int),
			typeof(JsonProperty),
			typeof(JsonSerializerInternalReader.PropertyPresence),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldWriteProperty", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonProperty)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetDefaultValue", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal object GetResolvedDefaultValue()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700010F")]
		public Required Required
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEF60", Offset = "0x1CEEF60", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonObjectContract), Member = "get_HasRequiredOrDefaultValueProperties", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60005BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEEFB0", Offset = "0x1CEEFB0", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000110")]
		public bool? IsReference
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF018", Offset = "0x1CEF018", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF020", Offset = "0x1CEF020", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000111")]
		public NullValueHandling? NullValueHandling
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF028", Offset = "0x1CEF028", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF030", Offset = "0x1CEF030", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000112")]
		public DefaultValueHandling? DefaultValueHandling
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF038", Offset = "0x1CEF038", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF040", Offset = "0x1CEF040", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000113")]
		public ReferenceLoopHandling? ReferenceLoopHandling
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF048", Offset = "0x1CEF048", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF050", Offset = "0x1CEF050", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000114")]
		public ObjectCreationHandling? ObjectCreationHandling
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF058", Offset = "0x1CEF058", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF060", Offset = "0x1CEF060", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000115")]
		public TypeNameHandling? TypeNameHandling
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF068", Offset = "0x1CEF068", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF070", Offset = "0x1CEF070", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000116")]
		public Predicate<object> ShouldSerialize
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF078", Offset = "0x1CEF078", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF080", Offset = "0x1CEF080", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000117")]
		public Predicate<object> ShouldDeserialize
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF088", Offset = "0x1CEF088", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF090", Offset = "0x1CEF090", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000118")]
		public Predicate<object> GetIsSpecified
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF098", Offset = "0x1CEF098", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF0A0", Offset = "0x1CEF0A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000119")]
		public Action<object, object> SetIsSpecified
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF0A8", Offset = "0x1CEF0A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF0B0", Offset = "0x1CEF0B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEF0B8", Offset = "0x1CEF0B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700011A")]
		public JsonConverter ItemConverter
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF0C0", Offset = "0x1CEF0C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF0C8", Offset = "0x1CEF0C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700011B")]
		public bool? ItemIsReference
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF0D0", Offset = "0x1CEF0D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF0D8", Offset = "0x1CEF0D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700011C")]
		public TypeNameHandling? ItemTypeNameHandling
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF0E0", Offset = "0x1CEF0E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF0E8", Offset = "0x1CEF0E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700011D")]
		public ReferenceLoopHandling? ItemReferenceLoopHandling
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF0F0", Offset = "0x1CEF0F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60005DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF0F8", Offset = "0x1CEF0F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEF100", Offset = "0x1CEF100", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CalculatePropertyValues", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonContainerContract),
			typeof(JsonProperty),
			typeof(JsonProperty),
			typeof(ref JsonContract),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void WritePropertyName(JsonWriter writer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE6C90", Offset = "0x1CE6C90", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public JsonProperty()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400028C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal Required? _required;

		[global::Cpp2ILInjected.Token(Token = "0x400028D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal bool _hasExplicitDefaultValue;

		[global::Cpp2ILInjected.Token(Token = "0x400028E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object _defaultValue;

		[global::Cpp2ILInjected.Token(Token = "0x400028F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _hasGeneratedDefaultValue;

		[global::Cpp2ILInjected.Token(Token = "0x4000290")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string _propertyName;

		[global::Cpp2ILInjected.Token(Token = "0x4000291")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal bool _skipPropertyNameEscape;

		[global::Cpp2ILInjected.Token(Token = "0x4000292")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Type _propertyType;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000293")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private JsonContract <PropertyContract>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000294")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Type <DeclaringType>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000295")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int? <Order>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000296")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private string <UnderlyingName>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000297")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private IValueProvider <ValueProvider>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000298")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private IAttributeProvider <AttributeProvider>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000299")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private JsonConverter <Converter>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400029A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private JsonConverter <MemberConverter>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400029B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private bool <Ignored>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400029C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x89")]
		private bool <Readable>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400029D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8A")]
		private bool <Writable>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400029E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8B")]
		private bool <HasMemberAttribute>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400029F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private bool? <IsReference>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private NullValueHandling? <NullValueHandling>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private DefaultValueHandling? <DefaultValueHandling>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private ReferenceLoopHandling? <ReferenceLoopHandling>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private ObjectCreationHandling? <ObjectCreationHandling>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private TypeNameHandling? <TypeNameHandling>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private Predicate<object> <ShouldSerialize>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private Predicate<object> <ShouldDeserialize>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private Predicate<object> <GetIsSpecified>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private Action<object, object> <SetIsSpecified>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private JsonConverter <ItemConverter>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private bool? <ItemIsReference>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
		private TypeNameHandling? <ItemTypeNameHandling>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
		private ReferenceLoopHandling? <ItemReferenceLoopHandling>k__BackingField;
	}
}
