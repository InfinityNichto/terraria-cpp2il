using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200007C RID: 124
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200009E")]
	public abstract class JsonContract
	{
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x00002F1E File Offset: 0x0000111E
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00002F21 File Offset: 0x00001121
		[global::Cpp2ILInjected.Token(Token = "0x170000E5")]
		public Type UnderlyingType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600055F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CECCDC", Offset = "0x1CECCDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000560")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CECCE4", Offset = "0x1CECCE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00002F24 File Offset: 0x00001124
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x00002F27 File Offset: 0x00001127
		[global::Cpp2ILInjected.Token(Token = "0x170000E6")]
		public Type CreatedType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000561")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CECCEC", Offset = "0x1CECCEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000562")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEC2AC", Offset = "0x1CEC2AC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonArrayContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonDictionaryContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "IsSealed", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "IsInterface", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "IsAbstract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x00002F2A File Offset: 0x0000112A
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x00002F2D File Offset: 0x0000112D
		[global::Cpp2ILInjected.Token(Token = "0x170000E7")]
		public bool? IsReference
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000563")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CECCF4", Offset = "0x1CECCF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000564")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CECCFC", Offset = "0x1CECCFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x00002F30 File Offset: 0x00001130
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x00002F33 File Offset: 0x00001133
		[global::Cpp2ILInjected.Token(Token = "0x170000E8")]
		public JsonConverter Converter
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000565")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CECD04", Offset = "0x1CECD04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000566")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CECD0C", Offset = "0x1CECD0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00002F36 File Offset: 0x00001136
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x00002F39 File Offset: 0x00001139
		[global::Cpp2ILInjected.Token(Token = "0x170000E9")]
		internal JsonConverter InternalConverter
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000567")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CECD14", Offset = "0x1CECD14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000568")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CECD1C", Offset = "0x1CECD1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00002F3C File Offset: 0x0000113C
		[global::Cpp2ILInjected.Token(Token = "0x170000EA")]
		public IList<SerializationCallback> OnDeserializedCallbacks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000569")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE7DEC", Offset = "0x1CE7DEC", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "ResolveCallbackMethods", MemberParameters = new object[]
			{
				typeof(JsonContract),
				typeof(Type)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "get_OnDeserialized", ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "set_OnDeserialized", MemberParameters = new object[] { typeof(MethodInfo) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00002F3F File Offset: 0x0000113F
		[global::Cpp2ILInjected.Token(Token = "0x170000EB")]
		public IList<SerializationCallback> OnDeserializingCallbacks
		{
			[global::Cpp2ILInjected.Token(Token = "0x600056A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE7D74", Offset = "0x1CE7D74", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "ResolveCallbackMethods", MemberParameters = new object[]
			{
				typeof(JsonContract),
				typeof(Type)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "get_OnDeserializing", ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "set_OnDeserializing", MemberParameters = new object[] { typeof(MethodInfo) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00002F42 File Offset: 0x00001142
		[global::Cpp2ILInjected.Token(Token = "0x170000EC")]
		public IList<SerializationCallback> OnSerializedCallbacks
		{
			[global::Cpp2ILInjected.Token(Token = "0x600056B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE7CFC", Offset = "0x1CE7CFC", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "ResolveCallbackMethods", MemberParameters = new object[]
			{
				typeof(JsonContract),
				typeof(Type)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "get_OnSerialized", ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "set_OnSerialized", MemberParameters = new object[] { typeof(MethodInfo) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00002F45 File Offset: 0x00001145
		[global::Cpp2ILInjected.Token(Token = "0x170000ED")]
		public IList<SerializationCallback> OnSerializingCallbacks
		{
			[global::Cpp2ILInjected.Token(Token = "0x600056C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE7C84", Offset = "0x1CE7C84", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "ResolveCallbackMethods", MemberParameters = new object[]
			{
				typeof(JsonContract),
				typeof(Type)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "get_OnSerializing", ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "set_OnSerializing", MemberParameters = new object[] { typeof(MethodInfo) }, ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(Type),
				typeof(JsonContract),
				typeof(JsonProperty),
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00002F48 File Offset: 0x00001148
		[global::Cpp2ILInjected.Token(Token = "0x170000EE")]
		public IList<SerializationErrorCallback> OnErrorCallbacks
		{
			[global::Cpp2ILInjected.Token(Token = "0x600056D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE7E64", Offset = "0x1CE7E64", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "ResolveCallbackMethods", MemberParameters = new object[]
			{
				typeof(JsonContract),
				typeof(Type)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "get_OnError", ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "set_OnError", MemberParameters = new object[] { typeof(MethodInfo) }, ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "CreateList", MemberParameters = new object[]
			{
				typeof(JsonReader),
				typeof(Type),
				typeof(JsonContract),
				typeof(JsonProperty),
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00002F4B File Offset: 0x0000114B
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x00002F4E File Offset: 0x0000114E
		[Obsolete("This property is obsolete and has been replaced by the OnDeserializedCallbacks collection.")]
		[global::Cpp2ILInjected.Token(Token = "0x170000EF")]
		public MethodInfo OnDeserialized
		{
			[global::Cpp2ILInjected.Token(Token = "0x600056E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CECD24", Offset = "0x1CECD24", Length = "0x13C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "get_OnDeserializedCallbacks", ReturnType = typeof(IList<SerializationCallback>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "Method", MemberParameters = new object[] { typeof(Delegate) }, ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600056F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CECE60", Offset = "0x1CECE60", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "get_OnDeserializedCallbacks", ReturnType = typeof(IList<SerializationCallback>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "CreateSerializationCallback", MemberParameters = new object[] { typeof(MethodInfo) }, ReturnType = typeof(SerializationCallback))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00002F51 File Offset: 0x00001151
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00002F54 File Offset: 0x00001154
		[Obsolete("This property is obsolete and has been replaced by the OnDeserializingCallbacks collection.")]
		[global::Cpp2ILInjected.Token(Token = "0x170000F0")]
		public MethodInfo OnDeserializing
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000570")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CECF88", Offset = "0x1CECF88", Length = "0x13C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "get_OnDeserializingCallbacks", ReturnType = typeof(IList<SerializationCallback>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "Method", MemberParameters = new object[] { typeof(Delegate) }, ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000571")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CED0C4", Offset = "0x1CED0C4", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "get_OnDeserializingCallbacks", ReturnType = typeof(IList<SerializationCallback>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "CreateSerializationCallback", MemberParameters = new object[] { typeof(MethodInfo) }, ReturnType = typeof(SerializationCallback))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00002F57 File Offset: 0x00001157
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00002F5A File Offset: 0x0000115A
		[Obsolete("This property is obsolete and has been replaced by the OnSerializedCallbacks collection.")]
		[global::Cpp2ILInjected.Token(Token = "0x170000F1")]
		public MethodInfo OnSerialized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000572")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CED1EC", Offset = "0x1CED1EC", Length = "0x13C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "get_OnSerializedCallbacks", ReturnType = typeof(IList<SerializationCallback>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "Method", MemberParameters = new object[] { typeof(Delegate) }, ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000573")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CED328", Offset = "0x1CED328", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "get_OnSerializedCallbacks", ReturnType = typeof(IList<SerializationCallback>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "CreateSerializationCallback", MemberParameters = new object[] { typeof(MethodInfo) }, ReturnType = typeof(SerializationCallback))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00002F5D File Offset: 0x0000115D
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00002F60 File Offset: 0x00001160
		[Obsolete("This property is obsolete and has been replaced by the OnSerializingCallbacks collection.")]
		[global::Cpp2ILInjected.Token(Token = "0x170000F2")]
		public MethodInfo OnSerializing
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000574")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CED450", Offset = "0x1CED450", Length = "0x13C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "get_OnSerializingCallbacks", ReturnType = typeof(IList<SerializationCallback>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "Method", MemberParameters = new object[] { typeof(Delegate) }, ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000575")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CED58C", Offset = "0x1CED58C", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "get_OnSerializingCallbacks", ReturnType = typeof(IList<SerializationCallback>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "CreateSerializationCallback", MemberParameters = new object[] { typeof(MethodInfo) }, ReturnType = typeof(SerializationCallback))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00002F63 File Offset: 0x00001163
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00002F66 File Offset: 0x00001166
		[Obsolete("This property is obsolete and has been replaced by the OnErrorCallbacks collection.")]
		[global::Cpp2ILInjected.Token(Token = "0x170000F3")]
		public MethodInfo OnError
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000576")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CED6B4", Offset = "0x1CED6B4", Length = "0x13C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "get_OnErrorCallbacks", ReturnType = typeof(IList<SerializationErrorCallback>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "Method", MemberParameters = new object[] { typeof(Delegate) }, ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000577")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CED7F0", Offset = "0x1CED7F0", Length = "0x128")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "get_OnErrorCallbacks", ReturnType = typeof(IList<SerializationErrorCallback>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "CreateSerializationErrorCallback", MemberParameters = new object[] { typeof(MethodInfo) }, ReturnType = typeof(SerializationErrorCallback))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00002F69 File Offset: 0x00001169
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00002F6C File Offset: 0x0000116C
		[global::Cpp2ILInjected.Token(Token = "0x170000F4")]
		public Func<object> DefaultCreator
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000578")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CED918", Offset = "0x1CED918", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000579")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CED920", Offset = "0x1CED920", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00002F6F File Offset: 0x0000116F
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x00002F72 File Offset: 0x00001172
		[global::Cpp2ILInjected.Token(Token = "0x170000F5")]
		public bool DefaultCreatorNonPublic
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600057A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CED928", Offset = "0x1CED928", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600057B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CED930", Offset = "0x1CED930", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00002F75 File Offset: 0x00001175
		[global::Cpp2ILInjected.Token(Token = "0x600057C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE31E0", Offset = "0x1CE31E0", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContainerContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonLinqContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonPrimitiveContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateLinqContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonLinqContract))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsNullable", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "set_CreatedType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "IsConvertible", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "IsEnum", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal JsonContract(Type underlyingType)
		{
			throw null;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00002F78 File Offset: 0x00001178
		[global::Cpp2ILInjected.Token(Token = "0x600057D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CED93C", Offset = "0x1CED93C", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerializing", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal void InvokeOnSerializing(object o, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00002F7B File Offset: 0x0000117B
		[global::Cpp2ILInjected.Token(Token = "0x600057E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEDC28", Offset = "0x1CEDC28", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "OnSerialized", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal void InvokeOnSerialized(object o, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00002F7E File Offset: 0x0000117E
		[global::Cpp2ILInjected.Token(Token = "0x600057F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEDF14", Offset = "0x1CEDF14", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "OnDeserializing", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal void InvokeOnDeserializing(object o, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00002F81 File Offset: 0x00001181
		[global::Cpp2ILInjected.Token(Token = "0x6000580")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEE200", Offset = "0x1CEE200", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "OnDeserialized", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal void InvokeOnDeserialized(object o, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00002F84 File Offset: 0x00001184
		[global::Cpp2ILInjected.Token(Token = "0x6000581")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEE354", Offset = "0x1CEE354", Length = "0x2FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalBase), Member = "IsErrorHandled", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonContract),
			typeof(object),
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext)
		{
			throw null;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00002F87 File Offset: 0x00001187
		[global::Cpp2ILInjected.Token(Token = "0x6000582")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE848C", Offset = "0x1CE848C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "GetCallbackMethodsForType", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(ref List<SerializationCallback>),
			typeof(ref List<SerializationCallback>),
			typeof(ref List<SerializationCallback>),
			typeof(ref List<SerializationCallback>),
			typeof(ref List<SerializationErrorCallback>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "set_OnDeserialized", MemberParameters = new object[] { typeof(MethodInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "set_OnDeserializing", MemberParameters = new object[] { typeof(MethodInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "set_OnSerialized", MemberParameters = new object[] { typeof(MethodInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "set_OnSerializing", MemberParameters = new object[] { typeof(MethodInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo)
		{
			throw null;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00002F8A File Offset: 0x0000118A
		[global::Cpp2ILInjected.Token(Token = "0x6000583")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE8530", Offset = "0x1CE8530", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "GetCallbackMethodsForType", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(ref List<SerializationCallback>),
			typeof(ref List<SerializationCallback>),
			typeof(ref List<SerializationCallback>),
			typeof(ref List<SerializationCallback>),
			typeof(ref List<SerializationErrorCallback>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonContract), Member = "set_OnError", MemberParameters = new object[] { typeof(MethodInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationErrorCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo)
		{
			throw null;
		}

		// Token: 0x0400020B RID: 523
		[global::Cpp2ILInjected.Token(Token = "0x4000268")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal bool IsNullable;

		// Token: 0x0400020C RID: 524
		[global::Cpp2ILInjected.Token(Token = "0x4000269")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		internal bool IsConvertable;

		// Token: 0x0400020D RID: 525
		[global::Cpp2ILInjected.Token(Token = "0x400026A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
		internal bool IsEnum;

		// Token: 0x0400020E RID: 526
		[global::Cpp2ILInjected.Token(Token = "0x400026B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal Type NonNullableUnderlyingType;

		// Token: 0x0400020F RID: 527
		[global::Cpp2ILInjected.Token(Token = "0x400026C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal ReadType InternalReadType;

		// Token: 0x04000210 RID: 528
		[global::Cpp2ILInjected.Token(Token = "0x400026D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal JsonContractType ContractType;

		// Token: 0x04000211 RID: 529
		[global::Cpp2ILInjected.Token(Token = "0x400026E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal bool IsReadOnlyOrFixedSize;

		// Token: 0x04000212 RID: 530
		[global::Cpp2ILInjected.Token(Token = "0x400026F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		internal bool IsSealed;

		// Token: 0x04000213 RID: 531
		[global::Cpp2ILInjected.Token(Token = "0x4000270")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
		internal bool IsInstantiable;

		// Token: 0x04000214 RID: 532
		[global::Cpp2ILInjected.Token(Token = "0x4000271")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private List<SerializationCallback> _onDeserializedCallbacks;

		// Token: 0x04000215 RID: 533
		[global::Cpp2ILInjected.Token(Token = "0x4000272")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private IList<SerializationCallback> _onDeserializingCallbacks;

		// Token: 0x04000216 RID: 534
		[global::Cpp2ILInjected.Token(Token = "0x4000273")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private IList<SerializationCallback> _onSerializedCallbacks;

		// Token: 0x04000217 RID: 535
		[global::Cpp2ILInjected.Token(Token = "0x4000274")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private IList<SerializationCallback> _onSerializingCallbacks;

		// Token: 0x04000218 RID: 536
		[global::Cpp2ILInjected.Token(Token = "0x4000275")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private IList<SerializationErrorCallback> _onErrorCallbacks;

		// Token: 0x04000219 RID: 537
		[global::Cpp2ILInjected.Token(Token = "0x4000276")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private Type _createdType;

		// Token: 0x0400021A RID: 538
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000277")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Type <UnderlyingType>k__BackingField;

		// Token: 0x0400021B RID: 539
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000278")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private bool? <IsReference>k__BackingField;

		// Token: 0x0400021C RID: 540
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000279")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private JsonConverter <Converter>k__BackingField;

		// Token: 0x0400021D RID: 541
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400027A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private JsonConverter <InternalConverter>k__BackingField;

		// Token: 0x0400021E RID: 542
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400027B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private Func<object> <DefaultCreator>k__BackingField;

		// Token: 0x0400021F RID: 543
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400027C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private bool <DefaultCreatorNonPublic>k__BackingField;

		// Token: 0x02000113 RID: 275
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200009F")]
		private sealed class <>c__DisplayClass73_0
		{
			// Token: 0x06000AE1 RID: 2785 RVA: 0x0000401F File Offset: 0x0000221F
			[global::Cpp2ILInjected.Token(Token = "0x6000584")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE650", Offset = "0x1CEE650", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass73_0()
			{
				throw null;
			}

			// Token: 0x06000AE2 RID: 2786 RVA: 0x00004022 File Offset: 0x00002222
			[global::Cpp2ILInjected.Token(Token = "0x6000585")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE660", Offset = "0x1CEE660", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object[])
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			internal void <CreateSerializationCallback>b__0(object o, StreamingContext context)
			{
				throw null;
			}

			// Token: 0x040003BD RID: 957
			[global::Cpp2ILInjected.Token(Token = "0x400027D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public MethodInfo callbackMethodInfo;
		}

		// Token: 0x02000114 RID: 276
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000A0")]
		private sealed class <>c__DisplayClass74_0
		{
			// Token: 0x06000AE3 RID: 2787 RVA: 0x00004025 File Offset: 0x00002225
			[global::Cpp2ILInjected.Token(Token = "0x6000586")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE658", Offset = "0x1CEE658", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass74_0()
			{
				throw null;
			}

			// Token: 0x06000AE4 RID: 2788 RVA: 0x00004028 File Offset: 0x00002228
			[global::Cpp2ILInjected.Token(Token = "0x6000587")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEE73C", Offset = "0x1CEE73C", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object[])
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			internal void <CreateSerializationErrorCallback>b__0(object o, StreamingContext context, ErrorContext econtext)
			{
				throw null;
			}

			// Token: 0x040003BE RID: 958
			[global::Cpp2ILInjected.Token(Token = "0x400027E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public MethodInfo callbackMethodInfo;
		}
	}
}
