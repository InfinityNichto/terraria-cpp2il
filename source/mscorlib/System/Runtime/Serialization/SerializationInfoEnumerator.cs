using System;
using System.Collections;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Security.Claims;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x02000324 RID: 804
	[global::Cpp2ILInjected.Token(Token = "0x20003CA")]
	public sealed class SerializationInfoEnumerator : global::System.Collections.IEnumerator
	{
		// Token: 0x06001C95 RID: 7317 RVA: 0x000194E4 File Offset: 0x000176E4
		[global::Cpp2ILInjected.Token(Token = "0x6001ECE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B50AD0", Offset = "0x1B50AD0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal SerializationInfoEnumerator(string[] members, object[] info, global::System.Type[] types, int numItems)
		{
			throw null;
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x000194E7 File Offset: 0x000176E7
		[global::Cpp2ILInjected.Token(Token = "0x6001ECF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B50B20", Offset = "0x1B50B20", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ExecutionContext), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.SecurityException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsPrincipal), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ObjRef), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodCall), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Hashtable), Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase", Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlException", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlSchemaException", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "SerializeISerializable", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonWriter",
			typeof(ISerializable),
			"Newtonsoft.Json.Serialization.JsonISerializableContract",
			"Newtonsoft.Json.Serialization.JsonProperty",
			"Newtonsoft.Json.Serialization.JsonContainerContract",
			"Newtonsoft.Json.Serialization.JsonProperty"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		public bool MoveNext()
		{
			throw null;
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001C97 RID: 7319 RVA: 0x000194EA File Offset: 0x000176EA
		[global::Cpp2ILInjected.Token(Token = "0x1700040C")]
		private object System.Collections.IEnumerator.Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001ED0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B50B4C", Offset = "0x1B50B4C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Current", ReturnType = typeof(SerializationEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x000194ED File Offset: 0x000176ED
		[global::Cpp2ILInjected.Token(Token = "0x1700040D")]
		public SerializationEntry Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001ED1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B50BBC", Offset = "0x1B50BBC", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodCall), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodResponse), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationInfoEnumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlException", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlSchemaException", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "SerializeISerializable", MemberParameters = new object[]
			{
				"Newtonsoft.Json.JsonWriter",
				typeof(ISerializable),
				"Newtonsoft.Json.Serialization.JsonISerializableContract",
				"Newtonsoft.Json.Serialization.JsonProperty",
				"Newtonsoft.Json.Serialization.JsonContainerContract",
				"Newtonsoft.Json.Serialization.JsonProperty"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x000194F0 File Offset: 0x000176F0
		[global::Cpp2ILInjected.Token(Token = "0x6001ED2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B50C44", Offset = "0x1B50C44", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001C9A RID: 7322 RVA: 0x000194F3 File Offset: 0x000176F3
		[global::Cpp2ILInjected.Token(Token = "0x1700040E")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001ED3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B50C54", Offset = "0x1B50C54", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ExecutionContext), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.SecurityException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsIdentity), Member = "Deserialize", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsPrincipal), Member = "Deserialize", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ObjRef), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo), Member = "InitSiWrite", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Hashtable), Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase", Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001C9B RID: 7323 RVA: 0x000194F6 File Offset: 0x000176F6
		[global::Cpp2ILInjected.Token(Token = "0x1700040F")]
		public object Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001ED4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B50CC0", Offset = "0x1B50CC0", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ExecutionContext), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.SecurityException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ObjRef), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo), Member = "InitSiWrite", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001C9C RID: 7324 RVA: 0x000194F9 File Offset: 0x000176F9
		[global::Cpp2ILInjected.Token(Token = "0x17000410")]
		public global::System.Type ObjectType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001ED5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B50D2C", Offset = "0x1B50D2C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo), Member = "InitSiWrite", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000C8A RID: 3210
		[global::Cpp2ILInjected.Token(Token = "0x4000F79")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string[] _members;

		// Token: 0x04000C8B RID: 3211
		[global::Cpp2ILInjected.Token(Token = "0x4000F7A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly object[] _data;

		// Token: 0x04000C8C RID: 3212
		[global::Cpp2ILInjected.Token(Token = "0x4000F7B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly global::System.Type[] _types;

		// Token: 0x04000C8D RID: 3213
		[global::Cpp2ILInjected.Token(Token = "0x4000F7C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly int _numItems;

		// Token: 0x04000C8E RID: 3214
		[global::Cpp2ILInjected.Token(Token = "0x4000F7D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int _currItem;

		// Token: 0x04000C8F RID: 3215
		[global::Cpp2ILInjected.Token(Token = "0x4000F7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool _current;
	}
}
