using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Security.Principal;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.ObjectModel
{
	// Token: 0x0200050C RID: 1292
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(global::System.Collections.Generic.ICollectionDebugView<>))]
	[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[global::Cpp2ILInjected.Token(Token = "0x200061E")]
	[global::System.Serializable]
	public class Collection<T> : global::System.Collections.Generic.IList<T>, global::System.Collections.Generic.ICollection<T>, global::System.Collections.Generic.IEnumerable<T>, IEnumerable, IList, ICollection, global::System.Collections.Generic.IReadOnlyList<T>, global::System.Collections.Generic.IReadOnlyCollection<T>
	{
		// Token: 0x06002B8A RID: 11146 RVA: 0x0001BE57 File Offset: 0x0001A057
		[global::Cpp2ILInjected.Token(Token = "0x6002FCA")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EEEF0", Offset = "0x18EEEF0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.GameComponentCollection", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Security.Principal.IIdentity),
			typeof(global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim>),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Security.Claims.ClaimsIdentity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = "OnDeserializingMethod", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.ProcessStartInfo", Member = "get_ArgumentList", ReturnType = "System.Collections.ObjectModel.Collection`1<String>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.UnicastIPAddressInformationCollection", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonConverterCollection", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Collection()
		{
			throw null;
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x0001BE5A File Offset: 0x0001A05A
		[global::Cpp2ILInjected.Token(Token = "0x6002FCB")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EEF4C", Offset = "0x18EEF4C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JPropertyKeyedCollection", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		public Collection(global::System.Collections.Generic.IList<T> list)
		{
			throw null;
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06002B8C RID: 11148 RVA: 0x0001BE5D File Offset: 0x0001A05D
		[global::Cpp2ILInjected.Token(Token = "0x17000797")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FCC")]
			[global::Cpp2ILInjected.Address(RVA = "0x18EEF84", Offset = "0x18EEF84", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.GameComponentCollection", Member = "ClearItems", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Claims.ClaimsIdentity.<get_Claims>d__51", Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new object[] { "System.Diagnostics.ProcessStartInfo" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.UnicastIPAddressInformationCollection", Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
			{
				"Newtonsoft.Json.JsonReader",
				"Newtonsoft.Json.Serialization.JsonObjectContract",
				"Newtonsoft.Json.Serialization.JsonProperty",
				"Newtonsoft.Json.Serialization.ObjectConstructor`1<Object>",
				typeof(string)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "CreateNewObject", MemberParameters = new object[]
			{
				"Newtonsoft.Json.JsonReader",
				"Newtonsoft.Json.Serialization.JsonObjectContract",
				"Newtonsoft.Json.Serialization.JsonProperty",
				"Newtonsoft.Json.Serialization.JsonProperty",
				typeof(string),
				typeof(ref bool)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "SerializeObject", MemberParameters = new object[]
			{
				"Newtonsoft.Json.JsonWriter",
				typeof(object),
				"Newtonsoft.Json.Serialization.JsonObjectContract",
				"Newtonsoft.Json.Serialization.JsonProperty",
				"Newtonsoft.Json.Serialization.JsonContainerContract",
				"Newtonsoft.Json.Serialization.JsonProperty"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "WriteTo", MemberParameters = new object[] { "Newtonsoft.Json.JsonWriter", "Newtonsoft.Json.JsonConverter[]" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06002B8D RID: 11149 RVA: 0x0001BE60 File Offset: 0x0001A060
		[global::Cpp2ILInjected.Token(Token = "0x17000798")]
		protected global::System.Collections.Generic.IList<T> Items
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FCD")]
			[global::Cpp2ILInjected.Address(RVA = "0x18EF004", Offset = "0x18EF004", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006B7 RID: 1719
		[global::Cpp2ILInjected.Token(Token = "0x17000799")]
		public T this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FCE")]
			[global::Cpp2ILInjected.Address(RVA = "0x18EF00C", Offset = "0x18EF00C", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.GameComponentCollection", Member = "ClearItems", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.GameComponentCollection", Member = "RemoveItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Claims.ClaimsIdentity.<get_Claims>d__51", Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "SerializeObject", MemberParameters = new object[]
			{
				"Newtonsoft.Json.JsonWriter",
				typeof(object),
				"Newtonsoft.Json.Serialization.JsonObjectContract",
				"Newtonsoft.Json.Serialization.JsonProperty",
				"Newtonsoft.Json.Serialization.JsonContainerContract",
				"Newtonsoft.Json.Serialization.JsonProperty"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "WriteTo", MemberParameters = new object[] { "Newtonsoft.Json.JsonWriter", "Newtonsoft.Json.JsonConverter[]" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002FCF")]
			[global::Cpp2ILInjected.Address(RVA = "0x18EF0A0", Offset = "0x18EF0A0", Length = "0x15C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x0001BE69 File Offset: 0x0001A069
		[global::Cpp2ILInjected.Token(Token = "0x6002FD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EF1FC", Offset = "0x18EF1FC", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.UnicastIPAddressInformationCollection", Member = "InternalAdd", MemberParameters = new object[] { "System.Net.NetworkInformation.UnicastIPAddressInformation" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonPropertyCollection", Member = "AddProperty", MemberParameters = new object[] { "Newtonsoft.Json.Serialization.JsonProperty" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Add(T item)
		{
			throw null;
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x0001BE6C File Offset: 0x0001A06C
		[global::Cpp2ILInjected.Token(Token = "0x6002FD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EF344", Offset = "0x18EF344", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x0001BE6F File Offset: 0x0001A06F
		[global::Cpp2ILInjected.Token(Token = "0x6002FD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EF3F8", Offset = "0x18EF3F8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.UnicastIPAddressInformationCollection", Member = "CopyTo", MemberParameters = new object[]
		{
			"System.Net.NetworkInformation.UnicastIPAddressInformation[]",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void CopyTo(T[] array, int index)
		{
			throw null;
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x0001BE72 File Offset: 0x0001A072
		[global::Cpp2ILInjected.Token(Token = "0x6002FD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EF498", Offset = "0x18EF498", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.UnicastIPAddressInformationCollection", Member = "Contains", MemberParameters = new object[] { "System.Net.NetworkInformation.UnicastIPAddressInformation" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool Contains(T item)
		{
			throw null;
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x0001BE75 File Offset: 0x0001A075
		[global::Cpp2ILInjected.Token(Token = "0x6002FD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EF530", Offset = "0x18EF530", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new object[] { "System.Diagnostics.ProcessStartInfo" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.UnicastIPAddressInformationCollection", Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<UnicastIPAddressInformation>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonObjectContract", Member = "get_HasRequiredOrDefaultValueProperties", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			"Newtonsoft.Json.Serialization.JsonObjectContract",
			"Newtonsoft.Json.Serialization.JsonProperty",
			"Newtonsoft.Json.Serialization.ObjectConstructor`1<Object>",
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JObject.<GetEnumerator>d__58", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = "Newtonsoft.Json.Linq.JToken")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo", MemberParameters = new object[]
		{
			"System.Collections.Generic.KeyValuePair`2<String, JToken>[]",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x0001BE78 File Offset: 0x0001A078
		[global::Cpp2ILInjected.Token(Token = "0x6002FD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EF5B0", Offset = "0x18EF5B0", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.GameComponentCollection", Member = "InsertItem", MemberParameters = new object[]
		{
			typeof(int),
			"Microsoft.Xna.Framework.IGameComponent"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "CreateObjectUsingCreatorWithParameters", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			"Newtonsoft.Json.Serialization.JsonObjectContract",
			"Newtonsoft.Json.Serialization.JsonProperty",
			"Newtonsoft.Json.Serialization.ObjectConstructor`1<Object>",
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public int IndexOf(T item)
		{
			throw null;
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x0001BE7B File Offset: 0x0001A07B
		[global::Cpp2ILInjected.Token(Token = "0x6002FD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EF648", Offset = "0x18EF648", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonSerializer", Member = "ApplySerializerSettings", MemberParameters = new object[] { "Newtonsoft.Json.JsonSerializer", "Newtonsoft.Json.JsonSerializerSettings" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Insert(int index, T item)
		{
			throw null;
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x0001BE7E File Offset: 0x0001A07E
		[global::Cpp2ILInjected.Token(Token = "0x6002FD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EF7A4", Offset = "0x18EF7A4", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonPropertyCollection", Member = "AddProperty", MemberParameters = new object[] { "Newtonsoft.Json.Serialization.JsonProperty" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JPropertyKeyedCollection", Member = "Remove", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public bool Remove(T item)
		{
			throw null;
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x0001BE81 File Offset: 0x0001A081
		[global::Cpp2ILInjected.Token(Token = "0x6002FD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EF904", Offset = "0x18EF904", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x0001BE84 File Offset: 0x0001A084
		[global::Cpp2ILInjected.Token(Token = "0x6002FD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EFA58", Offset = "0x18EFA58", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.GameComponentCollection", Member = "ClearItems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JPropertyKeyedCollection", Member = "ClearItems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected virtual void ClearItems()
		{
			throw null;
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x0001BE87 File Offset: 0x0001A087
		[global::Cpp2ILInjected.Token(Token = "0x6002FDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EFADC", Offset = "0x18EFADC", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.GameComponentCollection", Member = "InsertItem", MemberParameters = new object[]
		{
			typeof(int),
			"Microsoft.Xna.Framework.IGameComponent"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JPropertyKeyedCollection", Member = "InsertItem", MemberParameters = new object[]
		{
			typeof(int),
			"Newtonsoft.Json.Linq.JToken"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected virtual void InsertItem(int index, T item)
		{
			throw null;
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x0001BE8A File Offset: 0x0001A08A
		[global::Cpp2ILInjected.Token(Token = "0x6002FDB")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EFB7C", Offset = "0x18EFB7C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.GameComponentCollection", Member = "RemoveItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JPropertyKeyedCollection", Member = "RemoveItem", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected virtual void RemoveItem(int index)
		{
			throw null;
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x0001BE8D File Offset: 0x0001A08D
		[global::Cpp2ILInjected.Token(Token = "0x6002FDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EFC14", Offset = "0x18EFC14", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JPropertyKeyedCollection", Member = "SetItem", MemberParameters = new object[]
		{
			typeof(int),
			"Newtonsoft.Json.Linq.JToken"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected virtual void SetItem(int index, T item)
		{
			throw null;
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06002B9D RID: 11165 RVA: 0x0001BE90 File Offset: 0x0001A090
		[global::Cpp2ILInjected.Token(Token = "0x1700079A")]
		private bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FDD")]
			[global::Cpp2ILInjected.Address(RVA = "0x18EFCB4", Offset = "0x18EFCB4", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x0001BE93 File Offset: 0x0001A093
		[global::Cpp2ILInjected.Token(Token = "0x6002FDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EFD38", Offset = "0x18EFD38", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06002B9F RID: 11167 RVA: 0x0001BE96 File Offset: 0x0001A096
		[global::Cpp2ILInjected.Token(Token = "0x1700079B")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FDF")]
			[global::Cpp2ILInjected.Address(RVA = "0x18EFDD0", Offset = "0x18EFDD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06002BA0 RID: 11168 RVA: 0x0001BE99 File Offset: 0x0001A099
		[global::Cpp2ILInjected.Token(Token = "0x1700079C")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FE0")]
			[global::Cpp2ILInjected.Address(RVA = "0x18EFDD8", Offset = "0x18EFDD8", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x0001BE9C File Offset: 0x0001A09C
		[global::Cpp2ILInjected.Token(Token = "0x6002FE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EFE94", Offset = "0x18EFE94", Length = "0x444")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetLowerBound", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexArgumentOutOfRange_NeedNonNegNumException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException_Argument_InvalidArrayType", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private void System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			throw null;
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06002BA2 RID: 11170 RVA: 0x0001BE9F File Offset: 0x0001A09F
		// (set) Token: 0x06002BA3 RID: 11171 RVA: 0x0001BEA2 File Offset: 0x0001A0A2
		[global::Cpp2ILInjected.Token(Token = "0x1700079D")]
		private object System.Collections.IList.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FE2")]
			[global::Cpp2ILInjected.Address(RVA = "0x18F02D8", Offset = "0x18F02D8", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002FE3")]
			[global::Cpp2ILInjected.Address(RVA = "0x18F036C", Offset = "0x18F036C", Length = "0x174")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.Type)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x0001BEA5 File Offset: 0x0001A0A5
		[global::Cpp2ILInjected.Token(Token = "0x1700079E")]
		private bool System.Collections.IList.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FE4")]
			[global::Cpp2ILInjected.Address(RVA = "0x18F04E0", Offset = "0x18F04E0", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06002BA5 RID: 11173 RVA: 0x0001BEA8 File Offset: 0x0001A0A8
		[global::Cpp2ILInjected.Token(Token = "0x1700079F")]
		private bool System.Collections.IList.IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002FE5")]
			[global::Cpp2ILInjected.Address(RVA = "0x18F0564", Offset = "0x18F0564", Length = "0x11C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x0001BEAB File Offset: 0x0001A0AB
		[global::Cpp2ILInjected.Token(Token = "0x6002FE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x18F0680", Offset = "0x18F0680", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private int System.Collections.IList.Add(object value)
		{
			throw null;
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x0001BEAE File Offset: 0x0001A0AE
		[global::Cpp2ILInjected.Token(Token = "0x6002FE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x18F0884", Offset = "0x18F0884", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool System.Collections.IList.Contains(object value)
		{
			throw null;
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x0001BEB1 File Offset: 0x0001A0B1
		[global::Cpp2ILInjected.Token(Token = "0x6002FE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x18F0944", Offset = "0x18F0944", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private int System.Collections.IList.IndexOf(object value)
		{
			throw null;
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x0001BEB4 File Offset: 0x0001A0B4
		[global::Cpp2ILInjected.Token(Token = "0x6002FE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x18F0A04", Offset = "0x18F0A04", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowWrongValueTypeArgumentException", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void System.Collections.IList.Insert(int index, object value)
		{
			throw null;
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x0001BEB7 File Offset: 0x0001A0B7
		[global::Cpp2ILInjected.Token(Token = "0x6002FEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x18F0C08", Offset = "0x18F0C08", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowNotSupportedException", MemberParameters = new object[] { typeof(global::System.ExceptionResource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void System.Collections.IList.Remove(object value)
		{
			throw null;
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x0001BEBA File Offset: 0x0001A0BA
		[global::Cpp2ILInjected.Token(Token = "0x6002FEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x18F0D54", Offset = "0x18F0D54", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool IsCompatibleObject(object value)
		{
			throw null;
		}

		// Token: 0x040015F8 RID: 5624
		[global::Cpp2ILInjected.Token(Token = "0x4001A41")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.Collections.Generic.IList<T> items;
	}
}
