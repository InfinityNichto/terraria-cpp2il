using System;
using System.Collections;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting
{
	// Token: 0x020002A4 RID: 676
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000342")]
	[global::System.Serializable]
	public class ObjRef : global::System.Runtime.Serialization.IObjectReference, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x060019B1 RID: 6577 RVA: 0x00018D2B File Offset: 0x00016F2B
		[global::Cpp2ILInjected.Token(Token = "0x6001BD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2566C", Offset = "0x1B2566C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ObjRef()
		{
			throw null;
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00018D2E File Offset: 0x00016F2E
		[global::Cpp2ILInjected.Token(Token = "0x6001BD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B256DC", Offset = "0x1B256DC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal ObjRef(string uri, IChannelInfo cinfo)
		{
			throw null;
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x00018D31 File Offset: 0x00016F31
		[global::Cpp2ILInjected.Token(Token = "0x6001BD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B25708", Offset = "0x1B25708", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMessageBase), Member = "UnmarshalArgument", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Collections.ArrayList)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Copy", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Channels.CrossAppDomainData), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelInfo), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Channels.CADSerializer), Member = "DeserializeObjectSafe", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal ObjRef DeserializeInTheCurrentDomain(int domainId, byte[] tInfo)
		{
			throw null;
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x00018D34 File Offset: 0x00016F34
		[global::Cpp2ILInjected.Token(Token = "0x6001BD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2582C", Offset = "0x1B2582C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADObjRef), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ObjRef),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMessageBase), Member = "MarshalArgument", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref global::System.Collections.ArrayList)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Channels.CADSerializer), Member = "SerializeObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.IO.MemoryStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal byte[] SerializeType()
		{
			throw null;
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x00018D37 File Offset: 0x00016F37
		[global::Cpp2ILInjected.Token(Token = "0x6001BD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2589C", Offset = "0x1B2589C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "Connect", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "Connect", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeInfo), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelInfo), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal ObjRef(global::System.Type type, string url, object remoteChannelData)
		{
			throw null;
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x00018D3A File Offset: 0x00016F3A
		[global::Cpp2ILInjected.Token(Token = "0x6001BD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B25990", Offset = "0x1B25990", Length = "0x4F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "get_Value", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		protected ObjRef(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060019B7 RID: 6583 RVA: 0x00018D3D File Offset: 0x00016F3D
		[global::Cpp2ILInjected.Token(Token = "0x17000334")]
		internal bool IsReferenceToWellKnow
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BDA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B25E80", Offset = "0x1B25E80", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "Unmarshal", MemberParameters = new object[]
			{
				typeof(ObjRef),
				typeof(bool)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = "CanCastTo", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060019B8 RID: 6584 RVA: 0x00018D40 File Offset: 0x00016F40
		[global::Cpp2ILInjected.Token(Token = "0x17000335")]
		public virtual IChannelInfo ChannelInfo
		{
			[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
			[global::Cpp2ILInjected.Token(Token = "0x6001BDB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B25EE8", Offset = "0x1B25EE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060019B9 RID: 6585 RVA: 0x00018D43 File Offset: 0x00016F43
		// (set) Token: 0x060019BA RID: 6586 RVA: 0x00018D46 File Offset: 0x00016F46
		[global::Cpp2ILInjected.Token(Token = "0x17000336")]
		public virtual IEnvoyInfo EnvoyInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BDC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B25EF0", Offset = "0x1B25EF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001BDD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B25EF8", Offset = "0x1B25EF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060019BB RID: 6587 RVA: 0x00018D49 File Offset: 0x00016F49
		// (set) Token: 0x060019BC RID: 6588 RVA: 0x00018D4C File Offset: 0x00016F4C
		[global::Cpp2ILInjected.Token(Token = "0x17000337")]
		public virtual IRemotingTypeInfo TypeInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BDE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B25F00", Offset = "0x1B25F00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001BDF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B25F08", Offset = "0x1B25F08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060019BD RID: 6589 RVA: 0x00018D4F File Offset: 0x00016F4F
		// (set) Token: 0x060019BE RID: 6590 RVA: 0x00018D52 File Offset: 0x00016F52
		[global::Cpp2ILInjected.Token(Token = "0x17000338")]
		public virtual string URI
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BE0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B25F10", Offset = "0x1B25F10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001BE1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B25F18", Offset = "0x1B25F18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x00018D55 File Offset: 0x00016F55
		[global::Cpp2ILInjected.Token(Token = "0x6001BE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B25F20", Offset = "0x1B25F20", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "SetType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public virtual void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x00018D58 File Offset: 0x00016F58
		[global::Cpp2ILInjected.Token(Token = "0x6001BE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B260F0", Offset = "0x1B260F0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual object GetRealObject(global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x00018D5B File Offset: 0x00016F5B
		[global::Cpp2ILInjected.Token(Token = "0x6001BE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B25688", Offset = "0x1B25688", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServerIdentity), Member = "CreateObjRef", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(ObjRef))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChannelInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void UpdateChannelInfo()
		{
			throw null;
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x00018D5E File Offset: 0x00016F5E
		[global::Cpp2ILInjected.Token(Token = "0x17000339")]
		internal global::System.Type ServerType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BE5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B261EC", Offset = "0x1B261EC", Length = "0x13C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "Unmarshal", MemberParameters = new object[]
			{
				typeof(ObjRef),
				typeof(bool)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00018D61 File Offset: 0x00016F61
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001BE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B26328", Offset = "0x1B26328", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static ObjRef()
		{
			throw null;
		}

		// Token: 0x04000B4A RID: 2890
		[global::Cpp2ILInjected.Token(Token = "0x4000E2A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IChannelInfo channel_info;

		// Token: 0x04000B4B RID: 2891
		[global::Cpp2ILInjected.Token(Token = "0x4000E2B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string uri;

		// Token: 0x04000B4C RID: 2892
		[global::Cpp2ILInjected.Token(Token = "0x4000E2C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private IRemotingTypeInfo typeInfo;

		// Token: 0x04000B4D RID: 2893
		[global::Cpp2ILInjected.Token(Token = "0x4000E2D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private IEnvoyInfo envoyInfo;

		// Token: 0x04000B4E RID: 2894
		[global::Cpp2ILInjected.Token(Token = "0x4000E2E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int flags;

		// Token: 0x04000B4F RID: 2895
		[global::Cpp2ILInjected.Token(Token = "0x4000E2F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::System.Type _serverType;

		// Token: 0x04000B50 RID: 2896
		[global::Cpp2ILInjected.Token(Token = "0x4000E30")]
		private static int MarshalledObjectRef;

		// Token: 0x04000B51 RID: 2897
		[global::Cpp2ILInjected.Token(Token = "0x4000E31")]
		private static int WellKnowObjectRef;
	}
}
