using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000039 RID: 57
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200003B")]
	public abstract class JsonWriter : IDisposable
	{
		// Token: 0x0600023F RID: 575 RVA: 0x0000275F File Offset: 0x0000095F
		[global::Cpp2ILInjected.Token(Token = "0x6000241")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCA324", Offset = "0x1CCA324", Length = "0x524")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EnumUtils), Member = "GetValues", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(IList<object>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		internal static JsonWriter.State[][] BuildStateArray()
		{
			throw null;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002762 File Offset: 0x00000962
		[global::Cpp2ILInjected.Token(Token = "0x6000242")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCAD38", Offset = "0x1CCAD38", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "BuildStateArray", ReturnType = typeof(JsonWriter.State[][]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		static JsonWriter()
		{
			throw null;
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00002765 File Offset: 0x00000965
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00002768 File Offset: 0x00000968
		[global::Cpp2ILInjected.Token(Token = "0x17000081")]
		public bool CloseOutput
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000243")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CCB010", Offset = "0x1CCB010", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000244")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CCB018", Offset = "0x1CCB018", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0000276B File Offset: 0x0000096B
		[global::Cpp2ILInjected.Token(Token = "0x17000082")]
		protected internal int Top
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000245")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CCB024", Offset = "0x1CCB024", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteIndent", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "AutoCompleteAll", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "AutoCompleteClose", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(object),
				typeof(JsonObjectContract),
				typeof(JsonProperty),
				typeof(JsonContainerContract),
				typeof(JsonProperty)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(IEnumerable),
				typeof(JsonArrayContract),
				typeof(JsonProperty),
				typeof(JsonContainerContract),
				typeof(JsonProperty)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(Array),
				typeof(JsonArrayContract),
				typeof(JsonProperty),
				typeof(JsonContainerContract),
				typeof(JsonProperty)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(IDictionary),
				typeof(JsonDictionaryContract),
				typeof(JsonProperty),
				typeof(JsonContainerContract),
				typeof(JsonProperty)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "HandleError", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteEnd", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0000276E File Offset: 0x0000096E
		[global::Cpp2ILInjected.Token(Token = "0x17000083")]
		public WriteState WriteState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000246")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CCB07C", Offset = "0x1CCB07C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "HandleError", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(string),
				typeof(Exception)
			}, ReturnType = typeof(JsonWriterException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00002771 File Offset: 0x00000971
		[global::Cpp2ILInjected.Token(Token = "0x17000084")]
		internal string ContainerPath
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000247")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CCB118", Offset = "0x1CCB118", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(string),
				typeof(Exception)
			}, ReturnType = typeof(JsonWriterException))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CheckForCircularReference", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(object),
				typeof(JsonProperty),
				typeof(JsonContract),
				typeof(JsonContainerContract),
				typeof(JsonProperty)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "GetReference", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(object)
			}, ReturnType = typeof(string))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(IEnumerable),
				typeof(JsonArrayContract),
				typeof(JsonProperty),
				typeof(JsonContainerContract),
				typeof(JsonProperty)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(Array),
				typeof(JsonArrayContract),
				typeof(JsonProperty),
				typeof(int),
				typeof(int[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeISerializable", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(ISerializable),
				typeof(JsonISerializableContract),
				typeof(JsonProperty),
				typeof(JsonContainerContract),
				typeof(JsonProperty)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(IDictionary),
				typeof(JsonDictionaryContract),
				typeof(JsonProperty),
				typeof(JsonContainerContract),
				typeof(JsonProperty)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition), Member = "BuildPath", MemberParameters = new object[]
			{
				typeof(List<JsonPosition>),
				typeof(JsonPosition?)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00002774 File Offset: 0x00000974
		[global::Cpp2ILInjected.Token(Token = "0x17000085")]
		public string Path
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000248")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CCB1C4", Offset = "0x1CCB1C4", Length = "0x124")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "Serialize", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(object),
				typeof(Type)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "CheckForCircularReference", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(object),
				typeof(JsonProperty),
				typeof(JsonContract),
				typeof(JsonContainerContract),
				typeof(JsonProperty)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteReference", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerializing", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(JsonContract),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerialized", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(JsonContract),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteReferenceIdProperty", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(Type),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteTypeProperty", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(Type)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeConvertable", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(JsonConverter),
				typeof(object),
				typeof(JsonContract),
				typeof(JsonContainerContract),
				typeof(JsonProperty)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "ShouldSerialize", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(JsonProperty),
				typeof(object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "IsSpecified", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(JsonProperty),
				typeof(object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition?), Member = ".ctor", MemberParameters = new object[] { typeof(JsonPosition) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition), Member = "BuildPath", MemberParameters = new object[]
			{
				typeof(List<JsonPosition>),
				typeof(JsonPosition?)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00002777 File Offset: 0x00000977
		// (set) Token: 0x06000248 RID: 584 RVA: 0x0000277A File Offset: 0x0000097A
		[global::Cpp2ILInjected.Token(Token = "0x17000086")]
		public Formatting Formatting
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000249")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CCB2E8", Offset = "0x1CCB2E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600024A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CCB2F0", Offset = "0x1CCB2F0", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "SerializeObjectInternal", MemberParameters = new object[]
			{
				typeof(object),
				typeof(Type),
				typeof(JsonSerializer)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(object),
				typeof(Type)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JToken), Member = "ToString", MemberParameters = new object[]
			{
				typeof(Formatting),
				typeof(JsonConverter[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0000277D File Offset: 0x0000097D
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00002780 File Offset: 0x00000980
		[global::Cpp2ILInjected.Token(Token = "0x17000087")]
		public DateFormatHandling DateFormatHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600024B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CCB350", Offset = "0x1CCB350", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600024C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CCB358", Offset = "0x1CCB358", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(object),
				typeof(Type)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceJsonWriter), Member = ".ctor", MemberParameters = new object[] { typeof(JsonWriter) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00002783 File Offset: 0x00000983
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00002786 File Offset: 0x00000986
		[global::Cpp2ILInjected.Token(Token = "0x17000088")]
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600024D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CCB3B8", Offset = "0x1CCB3B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600024E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CCB3C0", Offset = "0x1CCB3C0", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(object),
				typeof(Type)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceJsonWriter), Member = ".ctor", MemberParameters = new object[] { typeof(JsonWriter) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00002789 File Offset: 0x00000989
		// (set) Token: 0x0600024E RID: 590 RVA: 0x0000278C File Offset: 0x0000098C
		[global::Cpp2ILInjected.Token(Token = "0x17000089")]
		public StringEscapeHandling StringEscapeHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600024F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CCB420", Offset = "0x1CCB420", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000250")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CCB428", Offset = "0x1CCB428", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(object),
				typeof(Type)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000278F File Offset: 0x0000098F
		[global::Cpp2ILInjected.Token(Token = "0x6000251")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB490", Offset = "0x1CCB490", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void OnStringEscapeHandlingChanged()
		{
			throw null;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00002792 File Offset: 0x00000992
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00002795 File Offset: 0x00000995
		[global::Cpp2ILInjected.Token(Token = "0x1700008A")]
		public FloatFormatHandling FloatFormatHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000252")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CCB494", Offset = "0x1CCB494", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000253")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CCB49C", Offset = "0x1CCB49C", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(object),
				typeof(Type)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceJsonWriter), Member = ".ctor", MemberParameters = new object[] { typeof(JsonWriter) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00002798 File Offset: 0x00000998
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0000279B File Offset: 0x0000099B
		[global::Cpp2ILInjected.Token(Token = "0x1700008B")]
		public string DateFormatString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000254")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CCB4FC", Offset = "0x1CCB4FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000255")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CCB504", Offset = "0x1CCB504", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0000279E File Offset: 0x0000099E
		// (set) Token: 0x06000255 RID: 597 RVA: 0x000027A1 File Offset: 0x000009A1
		[global::Cpp2ILInjected.Token(Token = "0x1700008C")]
		public CultureInfo Culture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000256")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CCB50C", Offset = "0x1CCB50C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "SerializeInternal", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(object),
				typeof(Type)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceJsonWriter), Member = ".ctor", MemberParameters = new object[] { typeof(JsonWriter) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "GetPropertyName", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(object),
				typeof(JsonContract),
				typeof(ref bool)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000257")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CCB574", Offset = "0x1CCB574", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000027A4 File Offset: 0x000009A4
		[global::Cpp2ILInjected.Token(Token = "0x6000258")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB57C", Offset = "0x1CCB57C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = ".ctor", MemberParameters = new object[] { typeof(JContainer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = ".ctor", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected JsonWriter()
		{
			throw null;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000027A7 File Offset: 0x000009A7
		[global::Cpp2ILInjected.Token(Token = "0x6000259")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB5A8", Offset = "0x1CCB5A8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteObjectId", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteRegex", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal void UpdateScopeWithFinishedValue()
		{
			throw null;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000027AA File Offset: 0x000009AA
		[global::Cpp2ILInjected.Token(Token = "0x600025A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB5C0", Offset = "0x1CCB5C0", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "InternalWriteStart", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(JsonContainerType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<JsonPosition>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition), Member = ".ctor", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void Push(JsonContainerType value)
		{
			throw null;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000027AD File Offset: 0x000009AD
		[global::Cpp2ILInjected.Token(Token = "0x600025B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB718", Offset = "0x1CCB718", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "AutoCompleteClose", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<JsonPosition>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<JsonPosition>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private JsonContainerType Pop()
		{
			throw null;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000027B0 File Offset: 0x000009B0
		[global::Cpp2ILInjected.Token(Token = "0x600025C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB074", Offset = "0x1CCB074", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private JsonContainerType Peek()
		{
			throw null;
		}

		// Token: 0x0600025B RID: 603
		[global::Cpp2ILInjected.Token(Token = "0x600025D")]
		public abstract void Flush();

		// Token: 0x0600025C RID: 604 RVA: 0x000027B3 File Offset: 0x000009B3
		[global::Cpp2ILInjected.Token(Token = "0x600025E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB7E0", Offset = "0x1CCB7E0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public virtual void Close()
		{
			throw null;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000027B6 File Offset: 0x000009B6
		[global::Cpp2ILInjected.Token(Token = "0x600025F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB824", Offset = "0x1CCB824", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteStartObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteStartObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public virtual void WriteStartObject()
		{
			throw null;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000027B9 File Offset: 0x000009B9
		[global::Cpp2ILInjected.Token(Token = "0x6000260")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB870", Offset = "0x1CCB870", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoCompleteClose", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(void))]
		public virtual void WriteEndObject()
		{
			throw null;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000027BC File Offset: 0x000009BC
		[global::Cpp2ILInjected.Token(Token = "0x6000261")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB87C", Offset = "0x1CCB87C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteStartArray", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteStartArray", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteStart", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(JsonContainerType)
		}, ReturnType = typeof(void))]
		public virtual void WriteStartArray()
		{
			throw null;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000027BF File Offset: 0x000009BF
		[global::Cpp2ILInjected.Token(Token = "0x6000262")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB888", Offset = "0x1CCB888", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoCompleteClose", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(void))]
		public virtual void WriteEndArray()
		{
			throw null;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000027C2 File Offset: 0x000009C2
		[global::Cpp2ILInjected.Token(Token = "0x6000263")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB890", Offset = "0x1CCB890", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteStartConstructor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteStart", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(JsonContainerType)
		}, ReturnType = typeof(void))]
		public virtual void WriteStartConstructor(string name)
		{
			throw null;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000027C5 File Offset: 0x000009C5
		[global::Cpp2ILInjected.Token(Token = "0x6000264")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB89C", Offset = "0x1CCB89C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoCompleteClose", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(void))]
		public virtual void WriteEndConstructor()
		{
			throw null;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x000027C8 File Offset: 0x000009C8
		[global::Cpp2ILInjected.Token(Token = "0x6000265")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB8A4", Offset = "0x1CCB8A4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WritePropertyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WritePropertyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WritePropertyName(string name)
		{
			throw null;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000027CB File Offset: 0x000009CB
		[global::Cpp2ILInjected.Token(Token = "0x6000266")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB8C4", Offset = "0x1CCB8C4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void WritePropertyName(string name, bool escape)
		{
			throw null;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000027CE File Offset: 0x000009CE
		[global::Cpp2ILInjected.Token(Token = "0x6000267")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB8D4", Offset = "0x1CCB8D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void WriteEnd()
		{
			throw null;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000027D1 File Offset: 0x000009D1
		[global::Cpp2ILInjected.Token(Token = "0x6000268")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB998", Offset = "0x1CCB998", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateJToken", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract)
		}, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JRaw), Member = "Create", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(JRaw))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void WriteToken(JsonReader reader)
		{
			throw null;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000027D4 File Offset: 0x000009D4
		[global::Cpp2ILInjected.Token(Token = "0x6000269")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB9A0", Offset = "0x1CCB9A0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void WriteToken(JsonReader reader, bool writeChildren)
		{
			throw null;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000027D7 File Offset: 0x000009D7
		[global::Cpp2ILInjected.Token(Token = "0x600026A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCBA68", Offset = "0x1CCBA68", Length = "0x5AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "WriteToken", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "WriteToken", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDateTime", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscellaneousUtils), Member = "CreateArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(ArgumentOutOfRangeException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		public void WriteToken(JsonToken token, object value)
		{
			throw null;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000027DA File Offset: 0x000009DA
		[global::Cpp2ILInjected.Token(Token = "0x600026B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCC10C", Offset = "0x1CCC10C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteToken", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(object)
		}, ReturnType = typeof(void))]
		public void WriteToken(JsonToken token)
		{
			throw null;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000027DD File Offset: 0x000009DD
		[global::Cpp2ILInjected.Token(Token = "0x600026C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCC114", Offset = "0x1CCC114", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteToken", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteConstructorDate", MemberParameters = new object[] { typeof(JsonReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteToken", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
			throw null;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000027E0 File Offset: 0x000009E0
		[global::Cpp2ILInjected.Token(Token = "0x600026D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCC2D8", Offset = "0x1CCC2D8", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "WriteToken", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "ConvertJavaScriptTicksToDateTime", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonWriterException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void WriteConstructorDate(JsonReader reader)
		{
			throw null;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000027E3 File Offset: 0x000009E3
		[global::Cpp2ILInjected.Token(Token = "0x600026E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB8DC", Offset = "0x1CCB8DC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonWriterException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void WriteEnd(JsonContainerType type)
		{
			throw null;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000027E6 File Offset: 0x000009E6
		[global::Cpp2ILInjected.Token(Token = "0x600026F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB7E4", Offset = "0x1CCB7E4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceJsonWriter), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Top", ReturnType = typeof(int))]
		private void AutoCompleteAll()
		{
			throw null;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x000027E9 File Offset: 0x000009E9
		[global::Cpp2ILInjected.Token(Token = "0x6000270")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCC54C", Offset = "0x1CCC54C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "AutoCompleteClose", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonWriterException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private JsonToken GetCloseTokenForType(JsonContainerType type)
		{
			throw null;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000027EC File Offset: 0x000009EC
		[global::Cpp2ILInjected.Token(Token = "0x6000271")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCC5D4", Offset = "0x1CCC5D4", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "WriteEndObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "WriteEndArray", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "WriteEndConstructor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "SetWriteState", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "InternalWriteEnd", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteEndArray", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteEndConstructor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteEndObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "get_Top", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<JsonPosition>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "Pop", ReturnType = typeof(JsonContainerType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "GetCloseTokenForType", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(JsonToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonWriterException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void AutoCompleteClose(JsonContainerType type)
		{
			throw null;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x000027EF File Offset: 0x000009EF
		[global::Cpp2ILInjected.Token(Token = "0x6000272")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCC7AC", Offset = "0x1CCC7AC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteEnd", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		protected virtual void WriteEnd(JsonToken token)
		{
			throw null;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000027F2 File Offset: 0x000009F2
		[global::Cpp2ILInjected.Token(Token = "0x6000273")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCC7B0", Offset = "0x1CCC7B0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void WriteIndent()
		{
			throw null;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000027F5 File Offset: 0x000009F5
		[global::Cpp2ILInjected.Token(Token = "0x6000274")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCC7B4", Offset = "0x1CCC7B4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void WriteValueDelimiter()
		{
			throw null;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x000027F8 File Offset: 0x000009F8
		[global::Cpp2ILInjected.Token(Token = "0x6000275")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCC7B8", Offset = "0x1CCC7B8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void WriteIndentSpace()
		{
			throw null;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x000027FB File Offset: 0x000009FB
		[global::Cpp2ILInjected.Token(Token = "0x6000276")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCC7BC", Offset = "0x1CCC7BC", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 56)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonWriterException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal void AutoComplete(JsonToken tokenBeingWritten)
		{
			throw null;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000027FE File Offset: 0x000009FE
		[global::Cpp2ILInjected.Token(Token = "0x6000277")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCA54", Offset = "0x1CCCA54", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteNull()
		{
			throw null;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002801 File Offset: 0x00000A01
		[global::Cpp2ILInjected.Token(Token = "0x6000278")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCA88", Offset = "0x1CCCA88", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteUndefined", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteUndefined()
		{
			throw null;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002804 File Offset: 0x00000A04
		[global::Cpp2ILInjected.Token(Token = "0x6000279")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCAA4", Offset = "0x1CCCAA4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public virtual void WriteRaw(string json)
		{
			throw null;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002807 File Offset: 0x00000A07
		[global::Cpp2ILInjected.Token(Token = "0x600027A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCAAC", Offset = "0x1CCCAAC", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void WriteRawValue(string json)
		{
			throw null;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000280A File Offset: 0x00000A0A
		[global::Cpp2ILInjected.Token(Token = "0x600027B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCAFC", Offset = "0x1CCCAFC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteValue(string value)
		{
			throw null;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000280D File Offset: 0x00000A0D
		[global::Cpp2ILInjected.Token(Token = "0x600027C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCB18", Offset = "0x1CCCB18", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteValue(int value)
		{
			throw null;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002810 File Offset: 0x00000A10
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600027D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCB34", Offset = "0x1CCCB34", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteValue(uint value)
		{
			throw null;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002813 File Offset: 0x00000A13
		[global::Cpp2ILInjected.Token(Token = "0x600027E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCB50", Offset = "0x1CCCB50", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteValue(long value)
		{
			throw null;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002816 File Offset: 0x00000A16
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600027F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCB6C", Offset = "0x1CCCB6C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteValue(ulong value)
		{
			throw null;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002819 File Offset: 0x00000A19
		[global::Cpp2ILInjected.Token(Token = "0x6000280")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCB88", Offset = "0x1CCCB88", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteValue(float value)
		{
			throw null;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000281C File Offset: 0x00000A1C
		[global::Cpp2ILInjected.Token(Token = "0x6000281")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCBA4", Offset = "0x1CCCBA4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteValue(double value)
		{
			throw null;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000281F File Offset: 0x00000A1F
		[global::Cpp2ILInjected.Token(Token = "0x6000282")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCBC0", Offset = "0x1CCCBC0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteValue(bool value)
		{
			throw null;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002822 File Offset: 0x00000A22
		[global::Cpp2ILInjected.Token(Token = "0x6000283")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCBDC", Offset = "0x1CCCBDC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteValue(short value)
		{
			throw null;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002825 File Offset: 0x00000A25
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000284")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCBF8", Offset = "0x1CCCBF8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteValue(ushort value)
		{
			throw null;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002828 File Offset: 0x00000A28
		[global::Cpp2ILInjected.Token(Token = "0x6000285")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCC14", Offset = "0x1CCCC14", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteValue(char value)
		{
			throw null;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000282B File Offset: 0x00000A2B
		[global::Cpp2ILInjected.Token(Token = "0x6000286")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCC30", Offset = "0x1CCCC30", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteValue(byte value)
		{
			throw null;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000282E File Offset: 0x00000A2E
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000287")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCC4C", Offset = "0x1CCCC4C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteValue(sbyte value)
		{
			throw null;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002831 File Offset: 0x00000A31
		[global::Cpp2ILInjected.Token(Token = "0x6000288")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCC68", Offset = "0x1CCCC68", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteValue(decimal value)
		{
			throw null;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002834 File Offset: 0x00000A34
		[global::Cpp2ILInjected.Token(Token = "0x6000289")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCC84", Offset = "0x1CCCC84", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteValue(DateTime value)
		{
			throw null;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002837 File Offset: 0x00000A37
		[global::Cpp2ILInjected.Token(Token = "0x600028A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCCA0", Offset = "0x1CCCCA0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteValue(DateTimeOffset value)
		{
			throw null;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000283A File Offset: 0x00000A3A
		[global::Cpp2ILInjected.Token(Token = "0x600028B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCCBC", Offset = "0x1CCCCBC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(Guid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(Guid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteValue(Guid value)
		{
			throw null;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000283D File Offset: 0x00000A3D
		[global::Cpp2ILInjected.Token(Token = "0x600028C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCCD8", Offset = "0x1CCCCD8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteValue(TimeSpan value)
		{
			throw null;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002840 File Offset: 0x00000A40
		[global::Cpp2ILInjected.Token(Token = "0x600028D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCCF4", Offset = "0x1CCCCF4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void WriteValue(int? value)
		{
			throw null;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002843 File Offset: 0x00000A43
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600028E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCD70", Offset = "0x1CCCD70", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void WriteValue(uint? value)
		{
			throw null;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002846 File Offset: 0x00000A46
		[global::Cpp2ILInjected.Token(Token = "0x600028F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCDEC", Offset = "0x1CCCDEC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void WriteValue(long? value)
		{
			throw null;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002849 File Offset: 0x00000A49
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000290")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCE78", Offset = "0x1CCCE78", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void WriteValue(ulong? value)
		{
			throw null;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000284C File Offset: 0x00000A4C
		[global::Cpp2ILInjected.Token(Token = "0x6000291")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCF04", Offset = "0x1CCCF04", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void WriteValue(float? value)
		{
			throw null;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000284F File Offset: 0x00000A4F
		[global::Cpp2ILInjected.Token(Token = "0x6000292")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCF84", Offset = "0x1CCCF84", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void WriteValue(double? value)
		{
			throw null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002852 File Offset: 0x00000A52
		[global::Cpp2ILInjected.Token(Token = "0x6000293")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCD014", Offset = "0x1CCD014", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void WriteValue(bool? value)
		{
			throw null;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002855 File Offset: 0x00000A55
		[global::Cpp2ILInjected.Token(Token = "0x6000294")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCD09C", Offset = "0x1CCD09C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void WriteValue(short? value)
		{
			throw null;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002858 File Offset: 0x00000A58
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000295")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCD118", Offset = "0x1CCD118", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void WriteValue(ushort? value)
		{
			throw null;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000285B File Offset: 0x00000A5B
		[global::Cpp2ILInjected.Token(Token = "0x6000296")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCD194", Offset = "0x1CCD194", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void WriteValue(char? value)
		{
			throw null;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000285E File Offset: 0x00000A5E
		[global::Cpp2ILInjected.Token(Token = "0x6000297")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCD210", Offset = "0x1CCD210", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(byte?) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void WriteValue(byte? value)
		{
			throw null;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002861 File Offset: 0x00000A61
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000298")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCD28C", Offset = "0x1CCD28C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void WriteValue(sbyte? value)
		{
			throw null;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002864 File Offset: 0x00000A64
		[global::Cpp2ILInjected.Token(Token = "0x6000299")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCD308", Offset = "0x1CCD308", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void WriteValue(decimal? value)
		{
			throw null;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002867 File Offset: 0x00000A67
		[global::Cpp2ILInjected.Token(Token = "0x600029A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCD388", Offset = "0x1CCD388", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void WriteValue(DateTime? value)
		{
			throw null;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000286A File Offset: 0x00000A6A
		[global::Cpp2ILInjected.Token(Token = "0x600029B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCD414", Offset = "0x1CCD414", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void WriteValue(DateTimeOffset? value)
		{
			throw null;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000286D File Offset: 0x00000A6D
		[global::Cpp2ILInjected.Token(Token = "0x600029C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCD494", Offset = "0x1CCD494", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void WriteValue(Guid? value)
		{
			throw null;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002870 File Offset: 0x00000A70
		[global::Cpp2ILInjected.Token(Token = "0x600029D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCD518", Offset = "0x1CCD518", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual void WriteValue(TimeSpan? value)
		{
			throw null;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002873 File Offset: 0x00000A73
		[global::Cpp2ILInjected.Token(Token = "0x600029E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCD5A4", Offset = "0x1CCD5A4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void WriteValue(byte[] value)
		{
			throw null;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002876 File Offset: 0x00000A76
		[global::Cpp2ILInjected.Token(Token = "0x600029F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCD5D4", Offset = "0x1CCD5D4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual void WriteValue(Uri value)
		{
			throw null;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002879 File Offset: 0x00000A79
		[global::Cpp2ILInjected.Token(Token = "0x60002A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCD680", Offset = "0x1CCD680", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(PrimitiveTypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(PrimitiveTypeCode),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual void WriteValue(object value)
		{
			throw null;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000287C File Offset: 0x00000A7C
		[global::Cpp2ILInjected.Token(Token = "0x60002A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCE7A8", Offset = "0x1CCE7A8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JTokenWriter), Member = "WriteComment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		public virtual void WriteComment(string text)
		{
			throw null;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000287F File Offset: 0x00000A7F
		[global::Cpp2ILInjected.Token(Token = "0x60002A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCE7B8", Offset = "0x1CCE7B8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void WriteWhitespace(string ws)
		{
			throw null;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002882 File Offset: 0x00000A82
		[global::Cpp2ILInjected.Token(Token = "0x60002A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCE818", Offset = "0x1CCE818", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void System.IDisposable.Dispose()
		{
			throw null;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002885 File Offset: 0x00000A85
		[global::Cpp2ILInjected.Token(Token = "0x60002A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCE888", Offset = "0x1CCE888", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002888 File Offset: 0x00000A88
		[global::Cpp2ILInjected.Token(Token = "0x60002A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCD7BC", Offset = "0x1CCD7BC", Length = "0xFEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(PrimitiveTypeCode),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializePrimitive", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonPrimitiveContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float?), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte?), Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime?), Member = ".ctor", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double?), Member = ".ctor", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan?), Member = ".ctor", MemberParameters = new object[] { typeof(TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong?), Member = ".ctor", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal?), Member = ".ctor", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid?), Member = ".ctor", MemberParameters = new object[] { typeof(Guid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(sbyte?), Member = ".ctor", MemberParameters = new object[] { typeof(sbyte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char?), Member = ".ctor", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short?), Member = ".ctor", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint?), Member = ".ctor", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort?), Member = ".ctor", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long?), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset?), Member = ".ctor", MemberParameters = new object[] { typeof(DateTimeOffset) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "GetTypeInformation", MemberParameters = new object[] { typeof(IConvertible) }, ReturnType = typeof(TypeInformation))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(PrimitiveTypeCode),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "CreateUnsupportedTypeException", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object)
		}, ReturnType = typeof(JsonWriterException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 94)]
		internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value)
		{
			throw null;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000288B File Offset: 0x00000A8B
		[global::Cpp2ILInjected.Token(Token = "0x60002A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCE978", Offset = "0x1CCE978", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(PrimitiveTypeCode),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonWriterException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value)
		{
			throw null;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000288E File Offset: 0x00000A8E
		[global::Cpp2ILInjected.Token(Token = "0x60002A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCEAB8", Offset = "0x1CCEAB8", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "InternalWriteStart", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(JsonContainerType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoCompleteClose", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		protected void SetWriteState(JsonToken token, object value)
		{
			throw null;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002891 File Offset: 0x00000A91
		[global::Cpp2ILInjected.Token(Token = "0x60002A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB878", Offset = "0x1CCB878", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoCompleteClose", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(void))]
		internal void InternalWriteEnd(JsonContainerType container)
		{
			throw null;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002894 File Offset: 0x00000A94
		[global::Cpp2ILInjected.Token(Token = "0x60002A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB8B4", Offset = "0x1CCB8B4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WritePropertyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WritePropertyName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		internal void InternalWritePropertyName(string name)
		{
			throw null;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002897 File Offset: 0x00000A97
		[global::Cpp2ILInjected.Token(Token = "0x60002AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCAA8", Offset = "0x1CCCAA8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void InternalWriteRaw()
		{
			throw null;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000289A File Offset: 0x00000A9A
		[global::Cpp2ILInjected.Token(Token = "0x60002AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCB830", Offset = "0x1CCB830", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteStartObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteStartArray", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteStartConstructor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "WriteStartArray", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "WriteStartConstructor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonWriter), Member = "SetWriteState", MemberParameters = new object[]
		{
			typeof(JsonToken),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteStartArray", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteStartConstructor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteStartObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "Push", MemberParameters = new object[] { typeof(JsonContainerType) }, ReturnType = typeof(void))]
		internal void InternalWriteStart(JsonToken token, JsonContainerType container)
		{
			throw null;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000289D File Offset: 0x00000A9D
		[global::Cpp2ILInjected.Token(Token = "0x60002AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCCA70", Offset = "0x1CCCA70", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		internal void InternalWriteValue(JsonToken token)
		{
			throw null;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000028A0 File Offset: 0x00000AA0
		[global::Cpp2ILInjected.Token(Token = "0x60002AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCE7BC", Offset = "0x1CCE7BC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceJsonWriter), Member = "WriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriterException), Member = "Create", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(JsonWriterException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void InternalWriteWhitespace(string ws)
		{
			throw null;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x000028A3 File Offset: 0x00000AA3
		[global::Cpp2ILInjected.Token(Token = "0x60002AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CCE7B0", Offset = "0x1CCE7B0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextWriter), Member = "WriteComment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonWriter), Member = "AutoComplete", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		internal void InternalWriteComment()
		{
			throw null;
		}

		// Token: 0x04000122 RID: 290
		[global::Cpp2ILInjected.Token(Token = "0x4000131")]
		private static readonly JsonWriter.State[][] StateArray;

		// Token: 0x04000123 RID: 291
		[global::Cpp2ILInjected.Token(Token = "0x4000132")]
		internal static readonly JsonWriter.State[][] StateArrayTempate;

		// Token: 0x04000124 RID: 292
		[global::Cpp2ILInjected.Token(Token = "0x4000133")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<JsonPosition> _stack;

		// Token: 0x04000125 RID: 293
		[global::Cpp2ILInjected.Token(Token = "0x4000134")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private JsonPosition _currentPosition;

		// Token: 0x04000126 RID: 294
		[global::Cpp2ILInjected.Token(Token = "0x4000135")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private JsonWriter.State _currentState;

		// Token: 0x04000127 RID: 295
		[global::Cpp2ILInjected.Token(Token = "0x4000136")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private Formatting _formatting;

		// Token: 0x04000128 RID: 296
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000137")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool <CloseOutput>k__BackingField;

		// Token: 0x04000129 RID: 297
		[global::Cpp2ILInjected.Token(Token = "0x4000138")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private DateFormatHandling _dateFormatHandling;

		// Token: 0x0400012A RID: 298
		[global::Cpp2ILInjected.Token(Token = "0x4000139")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private DateTimeZoneHandling _dateTimeZoneHandling;

		// Token: 0x0400012B RID: 299
		[global::Cpp2ILInjected.Token(Token = "0x400013A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private StringEscapeHandling _stringEscapeHandling;

		// Token: 0x0400012C RID: 300
		[global::Cpp2ILInjected.Token(Token = "0x400013B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private FloatFormatHandling _floatFormatHandling;

		// Token: 0x0400012D RID: 301
		[global::Cpp2ILInjected.Token(Token = "0x400013C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string _dateFormatString;

		// Token: 0x0400012E RID: 302
		[global::Cpp2ILInjected.Token(Token = "0x400013D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private CultureInfo _culture;

		// Token: 0x020000F4 RID: 244
		[global::Cpp2ILInjected.Token(Token = "0x200003C")]
		internal enum State
		{
			// Token: 0x04000374 RID: 884
			[global::Cpp2ILInjected.Token(Token = "0x400013F")]
			Start,
			// Token: 0x04000375 RID: 885
			[global::Cpp2ILInjected.Token(Token = "0x4000140")]
			Property,
			// Token: 0x04000376 RID: 886
			[global::Cpp2ILInjected.Token(Token = "0x4000141")]
			ObjectStart,
			// Token: 0x04000377 RID: 887
			[global::Cpp2ILInjected.Token(Token = "0x4000142")]
			Object,
			// Token: 0x04000378 RID: 888
			[global::Cpp2ILInjected.Token(Token = "0x4000143")]
			ArrayStart,
			// Token: 0x04000379 RID: 889
			[global::Cpp2ILInjected.Token(Token = "0x4000144")]
			Array,
			// Token: 0x0400037A RID: 890
			[global::Cpp2ILInjected.Token(Token = "0x4000145")]
			ConstructorStart,
			// Token: 0x0400037B RID: 891
			[global::Cpp2ILInjected.Token(Token = "0x4000146")]
			Constructor,
			// Token: 0x0400037C RID: 892
			[global::Cpp2ILInjected.Token(Token = "0x4000147")]
			Closed,
			// Token: 0x0400037D RID: 893
			[global::Cpp2ILInjected.Token(Token = "0x4000148")]
			Error
		}
	}
}
