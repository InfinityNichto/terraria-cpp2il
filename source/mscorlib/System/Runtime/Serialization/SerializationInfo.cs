using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x02000345 RID: 837
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003ED")]
	public sealed class SerializationInfo
	{
		// Token: 0x06001D65 RID: 7525 RVA: 0x00019736 File Offset: 0x00017936
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001FA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B59C30", Offset = "0x1B59C30", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "CreateISerializable", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			"Newtonsoft.Json.Serialization.JsonISerializableContract",
			"Newtonsoft.Json.Serialization.JsonProperty",
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "SerializeISerializable", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonWriter",
			typeof(ISerializable),
			"Newtonsoft.Json.Serialization.JsonISerializableContract",
			"Newtonsoft.Json.Serialization.JsonProperty",
			"Newtonsoft.Json.Serialization.JsonContainerContract",
			"Newtonsoft.Json.Serialization.JsonProperty"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public SerializationInfo(global::System.Type type, IFormatterConverter converter)
		{
			throw null;
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x00019739 File Offset: 0x00017939
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001FA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B59C38", Offset = "0x1B59C38", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo), Member = "InitSerialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectWriter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo), Member = "InitSerialize", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ReadObjectInfo), Member = "InitDataStore", MemberParameters = new object[]
		{
			typeof(ref SerializationInfo),
			typeof(ref object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public SerializationInfo(global::System.Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust)
		{
			throw null;
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x0001973C File Offset: 0x0001793C
		[global::Cpp2ILInjected.Token(Token = "0x1700043E")]
		public string FullTypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001FA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B59E08", Offset = "0x1B59E08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x0001973F File Offset: 0x0001793F
		[global::Cpp2ILInjected.Token(Token = "0x1700043F")]
		public string AssemblyName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001FA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B59E10", Offset = "0x1B59E10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x00019742 File Offset: 0x00017942
		[global::Cpp2ILInjected.Token(Token = "0x6001FA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B591FC", Offset = "0x1B591FC", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.OrdinalCaseSensitiveComparer), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.OrdinalIgnoreCaseComparer), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.UnitySerializationHolder), Member = "GetUnitySerializationInfo", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.UnitySerializationHolder), Member = "GetUnitySerializationInfo", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.UnitySerializationHolder), Member = "GetUnitySerializationInfo", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(int),
			typeof(string),
			typeof(global::System.Reflection.RuntimeAssembly)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DelegateSerializationHolder), Member = "GetDelegateData", MemberParameters = new object[]
		{
			typeof(global::System.Delegate),
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.ObjRef), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeSerializationManager), Member = "CompleteSerialization", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.MemberInfoSerializationHolder), Member = "GetSerializationInfo", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(string),
			typeof(global::System.RuntimeType),
			typeof(string),
			typeof(string),
			typeof(global::System.Reflection.MemberTypes),
			typeof(global::System.Type[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.EnumEqualityComparer<>), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "IsAssemblyNameAssignmentSafe", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void SetType(global::System.Type type)
		{
			throw null;
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x00019745 File Offset: 0x00017945
		[global::Cpp2ILInjected.Token(Token = "0x6001FA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B59E1C", Offset = "0x1B59E1C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationInfo), Member = "IsAssemblyNameAssignmentSafe", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private static bool Compare(byte[] a, byte[] b)
		{
			throw null;
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x00019748 File Offset: 0x00017948
		[global::Cpp2ILInjected.Token(Token = "0x6001FA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B59E18", Offset = "0x1B59E18", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "IsAssemblyNameAssignmentSafe", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName)
		{
			throw null;
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x0001974B File Offset: 0x0001794B
		[global::Cpp2ILInjected.Token(Token = "0x6001FAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B59E8C", Offset = "0x1B59E8C", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationInfo), Member = "SetType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationInfo), Member = "DemandForUnsafeAssemblyNameAssignments", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo), Member = "CheckTypeForwardedFrom", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.SerObjectInfoCache),
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AssemblyName), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AssemblyName), Member = "GetPublicKeyToken", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName)
		{
			throw null;
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x0001974E File Offset: 0x0001794E
		[global::Cpp2ILInjected.Token(Token = "0x17000440")]
		public int MemberCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001FAB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B59FB4", Offset = "0x1B59FB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x00019751 File Offset: 0x00017951
		[global::Cpp2ILInjected.Token(Token = "0x17000441")]
		public global::System.Type ObjectType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001FAC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B59FBC", Offset = "0x1B59FBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x00019754 File Offset: 0x00017954
		[global::Cpp2ILInjected.Token(Token = "0x17000442")]
		public bool IsFullTypeNameSetExplicit
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001FAD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B59FC4", Offset = "0x1B59FC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x00019757 File Offset: 0x00017957
		[global::Cpp2ILInjected.Token(Token = "0x17000443")]
		public bool IsAssemblyNameSetExplicit
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001FAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B59FCC", Offset = "0x1B59FCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x0001975A File Offset: 0x0001795A
		[global::Cpp2ILInjected.Token(Token = "0x6001FAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B59FD4", Offset = "0x1B59FD4", Length = "0x94")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo), Member = "InitSiWrite", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public SerializationInfoEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x0001975D File Offset: 0x0001795D
		[global::Cpp2ILInjected.Token(Token = "0x6001FB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5A068", Offset = "0x1B5A068", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationInfo), Member = "AddValueInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void ExpandArrays()
		{
			throw null;
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x00019760 File Offset: 0x00017960
		[global::Cpp2ILInjected.Token(Token = "0x6001FB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B59180", Offset = "0x1B59180", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 91)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValueInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void AddValue(string name, object value, global::System.Type type)
		{
			throw null;
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x00019763 File Offset: 0x00017963
		[global::Cpp2ILInjected.Token(Token = "0x6001FB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5A310", Offset = "0x1B5A310", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 119)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void AddValue(string name, object value)
		{
			throw null;
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x00019766 File Offset: 0x00017966
		[global::Cpp2ILInjected.Token(Token = "0x6001FB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5A3C8", Offset = "0x1B5A3C8", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CultureAwareComparer), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.OrdinalCaseSensitiveComparer), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.OrdinalIgnoreCaseComparer), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WeakReference), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WeakReference<>), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.Encoding), Member = "SerializeEncoding", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Principal.WindowsIdentity), Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.StrongNameKeyPair), Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FileWebRequest", Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebProxy", Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.OrderedDictionary", Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase", Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddValue(string name, bool value)
		{
			throw null;
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x00019769 File Offset: 0x00017969
		[global::Cpp2ILInjected.Token(Token = "0x6001FB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5A49C", Offset = "0x1B5A49C", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddValue(string name, byte value)
		{
			throw null;
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x0001976C File Offset: 0x0001796C
		[global::Cpp2ILInjected.Token(Token = "0x6001FB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5A570", Offset = "0x1B5A570", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddValue(string name, short value)
		{
			throw null;
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x0001976F File Offset: 0x0001796F
		[global::Cpp2ILInjected.Token(Token = "0x6001FB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5A644", Offset = "0x1B5A644", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 35)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddValue(string name, int value)
		{
			throw null;
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x00019772 File Offset: 0x00017972
		[global::Cpp2ILInjected.Token(Token = "0x6001FB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5A718", Offset = "0x1B5A718", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IntPtr), Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexMatchTimeoutException", Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FileWebRequest", Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FileWebResponse", Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebResponse", Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddValue(string name, long value)
		{
			throw null;
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x00019775 File Offset: 0x00017975
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6001FB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5A7EC", Offset = "0x1B5A7EC", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.UIntPtr), Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddValue(string name, ulong value)
		{
			throw null;
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x00019778 File Offset: 0x00017978
		[global::Cpp2ILInjected.Token(Token = "0x6001FB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5A8C0", Offset = "0x1B5A8C0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Hashtable), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddValue(string name, float value)
		{
			throw null;
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x0001977B File Offset: 0x0001797B
		[global::Cpp2ILInjected.Token(Token = "0x6001FBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5A99C", Offset = "0x1B5A99C", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void AddValue(string name, global::System.DateTime value)
		{
			throw null;
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x0001977E File Offset: 0x0001797E
		[global::Cpp2ILInjected.Token(Token = "0x6001FBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5A174", Offset = "0x1B5A174", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationInfo), Member = "UpdateValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, int>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, int>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "ExpandArrays", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal void AddValueInternal(string name, object value, global::System.Type type)
		{
			throw null;
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x00019781 File Offset: 0x00017981
		[global::Cpp2ILInjected.Token(Token = "0x6001FBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B56848", Offset = "0x1B56848", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new object[]
		{
			typeof(ObjectHolder),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "FindElement", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValueInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void UpdateValue(string name, object value, global::System.Type type)
		{
			throw null;
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x00019784 File Offset: 0x00017984
		[global::Cpp2ILInjected.Token(Token = "0x6001FBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5AA70", Offset = "0x1B5AA70", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationInfo), Member = "UpdateValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationInfo), Member = "GetElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationInfo), Member = "GetElementNoThrow", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationInfo), Member = "GetValueNoThrow", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private int FindElement(string name)
		{
			throw null;
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x00019787 File Offset: 0x00017987
		[global::Cpp2ILInjected.Token(Token = "0x6001FBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5AB2C", Offset = "0x1B5AB2C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationInfo), Member = "GetBoolean", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationInfo), Member = "GetInt64", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationInfo), Member = "GetSingle", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "FindElement", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private object GetElement(string name, out global::System.Type foundType)
		{
			throw null;
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x0001978A File Offset: 0x0001798A
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6001FBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5ABE8", Offset = "0x1B5ABE8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "FindElement", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		private object GetElementNoThrow(string name, out global::System.Type foundType)
		{
			throw null;
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x0001978D File Offset: 0x0001798D
		[global::Cpp2ILInjected.Token(Token = "0x6001FC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B58DF4", Offset = "0x1B58DF4", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 105)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public object GetValue(string name, global::System.Type type)
		{
			throw null;
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x00019790 File Offset: 0x00017990
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6001FC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B58CDC", Offset = "0x1B58CDC", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CultureAwareComparer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DelegateSerializationHolder.DelegateEntry", Member = "DeserializeDelegate", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(int)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeSerializationManager), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.MemberInfoSerializationHolder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.MemberInfoSerializationHolder), Member = "GetRealObject", MemberParameters = new object[] { typeof(StreamingContext) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "FindElement", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal object GetValueNoThrow(string name, global::System.Type type)
		{
			throw null;
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x00019793 File Offset: 0x00017993
		[global::Cpp2ILInjected.Token(Token = "0x6001FC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5AC38", Offset = "0x1B5AC38", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CultureAwareComparer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WeakReference), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WeakReference<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Principal.WindowsIdentity), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.StrongNameKeyPair), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebProxy", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.OrderedDictionary", Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase", Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public bool GetBoolean(string name)
		{
			throw null;
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x00019796 File Offset: 0x00017996
		[global::Cpp2ILInjected.Token(Token = "0x6001FC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5ADAC", Offset = "0x1B5ADAC", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeLoadException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.UnitySerializationHolder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.MemberInfoSerializationHolder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.AssemblyName), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Hashtable), Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebHeaderCollection", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FileWebRequest", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FileWebResponse", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.Win32Exception", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.OrderedDictionary", Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.NameObjectCollectionBase", Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Generic.LinkedList`1", Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Generic.HashSet`1", Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public int GetInt32(string name)
		{
			throw null;
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x00019799 File Offset: 0x00017999
		[global::Cpp2ILInjected.Token(Token = "0x6001FC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5AF14", Offset = "0x1B5AF14", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IntPtr), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexMatchTimeoutException", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FileWebRequest", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FileWebResponse", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebResponse", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public long GetInt64(string name)
		{
			throw null;
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x0001979C File Offset: 0x0001799C
		[global::Cpp2ILInjected.Token(Token = "0x6001FC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5B07C", Offset = "0x1B5B07C", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Hashtable), Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public float GetSingle(string name)
		{
			throw null;
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x0001979F File Offset: 0x0001799F
		[global::Cpp2ILInjected.Token(Token = "0x6001FC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5B1E4", Offset = "0x1B5B1E4", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 60)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public string GetString(string name)
		{
			throw null;
		}

		// Token: 0x04000CD9 RID: 3289
		[global::Cpp2ILInjected.Token(Token = "0x4000FCB")]
		private const int defaultSize = 4;

		// Token: 0x04000CDA RID: 3290
		[global::Cpp2ILInjected.Token(Token = "0x4000FCC")]
		private const string s_mscorlibAssemblySimpleName = "mscorlib";

		// Token: 0x04000CDB RID: 3291
		[global::Cpp2ILInjected.Token(Token = "0x4000FCD")]
		private const string s_mscorlibFileName = "mscorlib.dll";

		// Token: 0x04000CDC RID: 3292
		[global::Cpp2ILInjected.Token(Token = "0x4000FCE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal string[] m_members;

		// Token: 0x04000CDD RID: 3293
		[global::Cpp2ILInjected.Token(Token = "0x4000FCF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal object[] m_data;

		// Token: 0x04000CDE RID: 3294
		[global::Cpp2ILInjected.Token(Token = "0x4000FD0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal global::System.Type[] m_types;

		// Token: 0x04000CDF RID: 3295
		[global::Cpp2ILInjected.Token(Token = "0x4000FD1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Collections.Generic.Dictionary<string, int> m_nameToIndex;

		// Token: 0x04000CE0 RID: 3296
		[global::Cpp2ILInjected.Token(Token = "0x4000FD2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal int m_currMember;

		// Token: 0x04000CE1 RID: 3297
		[global::Cpp2ILInjected.Token(Token = "0x4000FD3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal IFormatterConverter m_converter;

		// Token: 0x04000CE2 RID: 3298
		[global::Cpp2ILInjected.Token(Token = "0x4000FD4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string m_fullTypeName;

		// Token: 0x04000CE3 RID: 3299
		[global::Cpp2ILInjected.Token(Token = "0x4000FD5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string m_assemName;

		// Token: 0x04000CE4 RID: 3300
		[global::Cpp2ILInjected.Token(Token = "0x4000FD6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private global::System.Type objectType;

		// Token: 0x04000CE5 RID: 3301
		[global::Cpp2ILInjected.Token(Token = "0x4000FD7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private bool isFullTypeNameSetExplicit;

		// Token: 0x04000CE6 RID: 3302
		[global::Cpp2ILInjected.Token(Token = "0x4000FD8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x59")]
		private bool isAssemblyNameSetExplicit;

		// Token: 0x04000CE7 RID: 3303
		[global::Cpp2ILInjected.Token(Token = "0x4000FD9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5A")]
		private bool requireSameTokenInPartialTrust;
	}
}
