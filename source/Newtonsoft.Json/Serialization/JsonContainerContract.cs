using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000063 RID: 99
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200007C")]
	public class JsonContainerContract : JsonContract
	{
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x00002C93 File Offset: 0x00000E93
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x00002C96 File Offset: 0x00000E96
		[global::Cpp2ILInjected.Token(Token = "0x170000BB")]
		internal JsonContract ItemContract
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000454")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDFBD8", Offset = "0x1CDFBD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000455")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDFBE0", Offset = "0x1CDFBE0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new object[]
			{
				typeof(IDictionary),
				typeof(JsonReader),
				typeof(JsonDictionaryContract),
				typeof(JsonProperty),
				typeof(string)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new object[]
			{
				typeof(IList),
				typeof(JsonReader),
				typeof(JsonArrayContract),
				typeof(JsonProperty),
				typeof(string)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "WriteStartArray", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(object),
				typeof(JsonArrayContract),
				typeof(JsonProperty),
				typeof(JsonContainerContract),
				typeof(JsonProperty)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new object[]
			{
				typeof(JsonWriter),
				typeof(IDictionary),
				typeof(JsonDictionaryContract),
				typeof(JsonProperty),
				typeof(JsonContainerContract),
				typeof(JsonProperty)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsSealed", ReturnType = typeof(bool))]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x00002C99 File Offset: 0x00000E99
		[global::Cpp2ILInjected.Token(Token = "0x170000BC")]
		internal JsonContract FinalItemContract
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000456")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDFC1C", Offset = "0x1CDFC1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00002C9C File Offset: 0x00000E9C
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x00002C9F File Offset: 0x00000E9F
		[global::Cpp2ILInjected.Token(Token = "0x170000BD")]
		public JsonConverter ItemConverter
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000457")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDFC24", Offset = "0x1CDFC24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000458")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDFC2C", Offset = "0x1CDFC2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00002CA2 File Offset: 0x00000EA2
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x00002CA5 File Offset: 0x00000EA5
		[global::Cpp2ILInjected.Token(Token = "0x170000BE")]
		public bool? ItemIsReference
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000459")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDFC34", Offset = "0x1CDFC34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600045A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDFC3C", Offset = "0x1CDFC3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00002CA8 File Offset: 0x00000EA8
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x00002CAB File Offset: 0x00000EAB
		[global::Cpp2ILInjected.Token(Token = "0x170000BF")]
		public ReferenceLoopHandling? ItemReferenceLoopHandling
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600045B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDFC44", Offset = "0x1CDFC44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600045C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDFC4C", Offset = "0x1CDFC4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00002CAE File Offset: 0x00000EAE
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00002CB1 File Offset: 0x00000EB1
		[global::Cpp2ILInjected.Token(Token = "0x170000C0")]
		public TypeNameHandling? ItemTypeNameHandling
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600045D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDFC54", Offset = "0x1CDFC54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600045E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CDFC5C", Offset = "0x1CDFC5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00002CB4 File Offset: 0x00000EB4
		[global::Cpp2ILInjected.Token(Token = "0x600045F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CDFC64", Offset = "0x1CDFC64", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonISerializableContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateISerializableContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonISerializableContract))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonArrayContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonDictionaryContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonObjectContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "GetCachedAttribute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(object) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonTypeReflector), Member = "CreateJsonConverterInstance", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object[])
		}, ReturnType = typeof(JsonConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal JsonContainerContract(Type underlyingType)
		{
			throw null;
		}

		// Token: 0x040001C6 RID: 454
		[global::Cpp2ILInjected.Token(Token = "0x400020B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private JsonContract _itemContract;

		// Token: 0x040001C7 RID: 455
		[global::Cpp2ILInjected.Token(Token = "0x400020C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private JsonContract _finalItemContract;

		// Token: 0x040001C8 RID: 456
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400020D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private JsonConverter <ItemConverter>k__BackingField;

		// Token: 0x040001C9 RID: 457
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400020E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private bool? <ItemIsReference>k__BackingField;

		// Token: 0x040001CA RID: 458
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400020F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
		private ReferenceLoopHandling? <ItemReferenceLoopHandling>k__BackingField;

		// Token: 0x040001CB RID: 459
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000210")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
		private TypeNameHandling? <ItemTypeNameHandling>k__BackingField;
	}
}
