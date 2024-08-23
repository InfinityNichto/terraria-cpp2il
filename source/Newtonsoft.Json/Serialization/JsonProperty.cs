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
	// Token: 0x0200007E RID: 126
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000A2")]
	public class JsonProperty
	{
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00002FCC File Offset: 0x000011CC
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00002FCF File Offset: 0x000011CF
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

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00002FD2 File Offset: 0x000011D2
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x00002FD5 File Offset: 0x000011D5
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

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00002FD8 File Offset: 0x000011D8
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x00002FDB File Offset: 0x000011DB
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

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00002FDE File Offset: 0x000011DE
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00002FE1 File Offset: 0x000011E1
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

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00002FE4 File Offset: 0x000011E4
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00002FE7 File Offset: 0x000011E7
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

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00002FEA File Offset: 0x000011EA
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00002FED File Offset: 0x000011ED
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

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00002FF0 File Offset: 0x000011F0
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00002FF3 File Offset: 0x000011F3
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

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00002FF6 File Offset: 0x000011F6
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00002FF9 File Offset: 0x000011F9
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

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00002FFC File Offset: 0x000011FC
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00002FFF File Offset: 0x000011FF
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

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00003002 File Offset: 0x00001202
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x00003005 File Offset: 0x00001205
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

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00003008 File Offset: 0x00001208
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x0000300B File Offset: 0x0000120B
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

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0000300E File Offset: 0x0000120E
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x00003011 File Offset: 0x00001211
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

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00003014 File Offset: 0x00001214
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x00003017 File Offset: 0x00001217
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

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x0000301A File Offset: 0x0000121A
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x0000301D File Offset: 0x0000121D
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

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00003020 File Offset: 0x00001220
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00003023 File Offset: 0x00001223
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

		// Token: 0x06000555 RID: 1365 RVA: 0x00003026 File Offset: 0x00001226
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

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x00003029 File Offset: 0x00001229
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x0000302C File Offset: 0x0000122C
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

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x0000302F File Offset: 0x0000122F
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x00003032 File Offset: 0x00001232
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

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x00003035 File Offset: 0x00001235
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x00003038 File Offset: 0x00001238
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

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x0000303B File Offset: 0x0000123B
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x0000303E File Offset: 0x0000123E
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

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x00003041 File Offset: 0x00001241
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x00003044 File Offset: 0x00001244
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

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x00003047 File Offset: 0x00001247
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x0000304A File Offset: 0x0000124A
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

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x0000304D File Offset: 0x0000124D
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x00003050 File Offset: 0x00001250
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

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x00003053 File Offset: 0x00001253
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x00003056 File Offset: 0x00001256
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

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x00003059 File Offset: 0x00001259
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x0000305C File Offset: 0x0000125C
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

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x0000305F File Offset: 0x0000125F
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x00003062 File Offset: 0x00001262
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

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00003065 File Offset: 0x00001265
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x00003068 File Offset: 0x00001268
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

		// Token: 0x0600056C RID: 1388 RVA: 0x0000306B File Offset: 0x0000126B
		[global::Cpp2ILInjected.Token(Token = "0x60005D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEF0B8", Offset = "0x1CEF0B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x0000306E File Offset: 0x0000126E
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x00003071 File Offset: 0x00001271
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

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00003074 File Offset: 0x00001274
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x00003077 File Offset: 0x00001277
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

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x0000307A File Offset: 0x0000127A
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x0000307D File Offset: 0x0000127D
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

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00003080 File Offset: 0x00001280
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x00003083 File Offset: 0x00001283
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

		// Token: 0x06000575 RID: 1397 RVA: 0x00003086 File Offset: 0x00001286
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

		// Token: 0x06000576 RID: 1398 RVA: 0x00003089 File Offset: 0x00001289
		[global::Cpp2ILInjected.Token(Token = "0x60005DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE6C90", Offset = "0x1CE6C90", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public JsonProperty()
		{
			throw null;
		}

		// Token: 0x0400022D RID: 557
		[global::Cpp2ILInjected.Token(Token = "0x400028C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal Required? _required;

		// Token: 0x0400022E RID: 558
		[global::Cpp2ILInjected.Token(Token = "0x400028D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal bool _hasExplicitDefaultValue;

		// Token: 0x0400022F RID: 559
		[global::Cpp2ILInjected.Token(Token = "0x400028E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object _defaultValue;

		// Token: 0x04000230 RID: 560
		[global::Cpp2ILInjected.Token(Token = "0x400028F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _hasGeneratedDefaultValue;

		// Token: 0x04000231 RID: 561
		[global::Cpp2ILInjected.Token(Token = "0x4000290")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string _propertyName;

		// Token: 0x04000232 RID: 562
		[global::Cpp2ILInjected.Token(Token = "0x4000291")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal bool _skipPropertyNameEscape;

		// Token: 0x04000233 RID: 563
		[global::Cpp2ILInjected.Token(Token = "0x4000292")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Type _propertyType;

		// Token: 0x04000234 RID: 564
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000293")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private JsonContract <PropertyContract>k__BackingField;

		// Token: 0x04000235 RID: 565
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000294")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Type <DeclaringType>k__BackingField;

		// Token: 0x04000236 RID: 566
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000295")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int? <Order>k__BackingField;

		// Token: 0x04000237 RID: 567
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000296")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private string <UnderlyingName>k__BackingField;

		// Token: 0x04000238 RID: 568
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000297")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private IValueProvider <ValueProvider>k__BackingField;

		// Token: 0x04000239 RID: 569
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000298")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private IAttributeProvider <AttributeProvider>k__BackingField;

		// Token: 0x0400023A RID: 570
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000299")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private JsonConverter <Converter>k__BackingField;

		// Token: 0x0400023B RID: 571
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400029A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private JsonConverter <MemberConverter>k__BackingField;

		// Token: 0x0400023C RID: 572
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400029B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private bool <Ignored>k__BackingField;

		// Token: 0x0400023D RID: 573
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400029C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x89")]
		private bool <Readable>k__BackingField;

		// Token: 0x0400023E RID: 574
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400029D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8A")]
		private bool <Writable>k__BackingField;

		// Token: 0x0400023F RID: 575
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400029E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8B")]
		private bool <HasMemberAttribute>k__BackingField;

		// Token: 0x04000240 RID: 576
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400029F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private bool? <IsReference>k__BackingField;

		// Token: 0x04000241 RID: 577
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private NullValueHandling? <NullValueHandling>k__BackingField;

		// Token: 0x04000242 RID: 578
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private DefaultValueHandling? <DefaultValueHandling>k__BackingField;

		// Token: 0x04000243 RID: 579
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private ReferenceLoopHandling? <ReferenceLoopHandling>k__BackingField;

		// Token: 0x04000244 RID: 580
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private ObjectCreationHandling? <ObjectCreationHandling>k__BackingField;

		// Token: 0x04000245 RID: 581
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private TypeNameHandling? <TypeNameHandling>k__BackingField;

		// Token: 0x04000246 RID: 582
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private Predicate<object> <ShouldSerialize>k__BackingField;

		// Token: 0x04000247 RID: 583
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private Predicate<object> <ShouldDeserialize>k__BackingField;

		// Token: 0x04000248 RID: 584
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private Predicate<object> <GetIsSpecified>k__BackingField;

		// Token: 0x04000249 RID: 585
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private Action<object, object> <SetIsSpecified>k__BackingField;

		// Token: 0x0400024A RID: 586
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private JsonConverter <ItemConverter>k__BackingField;

		// Token: 0x0400024B RID: 587
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private bool? <ItemIsReference>k__BackingField;

		// Token: 0x0400024C RID: 588
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
		private TypeNameHandling? <ItemTypeNameHandling>k__BackingField;

		// Token: 0x0400024D RID: 589
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
		private ReferenceLoopHandling? <ItemReferenceLoopHandling>k__BackingField;
	}
}
