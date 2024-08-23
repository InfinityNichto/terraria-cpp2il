using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200030C RID: 780
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.CLSCompliant(false)]
	[global::Cpp2ILInjected.Token(Token = "0x20003B1")]
	[global::System.Serializable]
	public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, global::System.Runtime.Serialization.ISerializable, IInternalMessage
	{
		// Token: 0x06001BEC RID: 7148 RVA: 0x00019304 File Offset: 0x00017504
		[global::Cpp2ILInjected.Token(Token = "0x6001E1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B47E40", Offset = "0x1B47E40", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "get_Current", ReturnType = typeof(global::System.Runtime.Serialization.SerializationEntry))]
		internal MethodCall(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x00019307 File Offset: 0x00017507
		[global::Cpp2ILInjected.Token(Token = "0x6001E1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4A49C", Offset = "0x1B4A49C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "ProcessMessageInDomain", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(CADMethodCallMessage),
			typeof(ref byte[]),
			typeof(ref CADMethodReturnMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Copy", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMethodCallMessage), Member = "GetArguments", ReturnType = typeof(global::System.Collections.ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "UnmarshalArguments", MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(global::System.Collections.ArrayList)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "GetLogicalCallContext", MemberParameters = new object[] { typeof(global::System.Collections.ArrayList) }, ReturnType = typeof(LogicalCallContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "GetMethod", ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "UnmarshalProperties", MemberParameters = new object[]
		{
			typeof(global::System.Collections.IDictionary),
			typeof(int),
			typeof(global::System.Collections.ArrayList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal MethodCall(CADMethodCallMessage msg)
		{
			throw null;
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x0001930A File Offset: 0x0001750A
		[global::Cpp2ILInjected.Token(Token = "0x6001E20")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B47E34", Offset = "0x1B47E34", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal MethodCall()
		{
			throw null;
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x0001930D File Offset: 0x0001750D
		[global::Cpp2ILInjected.Token(Token = "0x6001E21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B378F8", Offset = "0x1B378F8", Length = "0x354")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = "ActivateRemoteObject", MemberParameters = new object[] { typeof(IMethodMessage) }, ReturnType = typeof(IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal void CopyFrom(IMethodMessage call)
		{
			throw null;
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x00019310 File Offset: 0x00017510
		[global::Cpp2ILInjected.Token(Token = "0x6001E22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4840C", Offset = "0x1B4840C", Length = "0x414")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::<PrivateImplementationDetails>), Member = "ComputeStringHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal virtual void InitMethodProperty(string key, object value)
		{
			throw null;
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x00019313 File Offset: 0x00017513
		[global::Cpp2ILInjected.Token(Token = "0x6001E23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B489B8", Offset = "0x1B489B8", Length = "0x47C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConstructionCall), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public virtual void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x00019316 File Offset: 0x00017516
		[global::Cpp2ILInjected.Token(Token = "0x170003C4")]
		public int ArgCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E24")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4A5A4", Offset = "0x1B4A5A4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x00019319 File Offset: 0x00017519
		[global::Cpp2ILInjected.Token(Token = "0x170003C5")]
		public object[] Args
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E25")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4A5B0", Offset = "0x1B4A5B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x0001931C File Offset: 0x0001751C
		[global::Cpp2ILInjected.Token(Token = "0x170003C6")]
		public LogicalCallContext LogicalCallContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E26")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4A5B8", Offset = "0x1B4A5B8", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x0001931F File Offset: 0x0001751F
		[global::Cpp2ILInjected.Token(Token = "0x170003C7")]
		public global::System.Reflection.MethodBase MethodBase
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E27")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4A61C", Offset = "0x1B4A61C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodCall), Member = "get_GenericArguments", ReturnType = typeof(global::System.Type[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.MethodBase),
				typeof(global::System.Reflection.MethodBase)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodCall), Member = "ResolveMethod", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x00019322 File Offset: 0x00017522
		[global::Cpp2ILInjected.Token(Token = "0x170003C8")]
		public string MethodName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E28")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4ABC0", Offset = "0x1B4ABC0", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001BF7 RID: 7159 RVA: 0x00019325 File Offset: 0x00017525
		[global::Cpp2ILInjected.Token(Token = "0x170003C9")]
		public object MethodSignature
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E29")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4ABEC", Offset = "0x1B4ABEC", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.MethodBase),
				typeof(global::System.Reflection.MethodBase)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x00019328 File Offset: 0x00017528
		[global::Cpp2ILInjected.Token(Token = "0x170003CA")]
		public virtual global::System.Collections.IDictionary Properties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E2A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B48E64", Offset = "0x1B48E64", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0001932B File Offset: 0x0001752B
		[global::Cpp2ILInjected.Token(Token = "0x6001E2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4ACE8", Offset = "0x1B4ACE8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MCMDictionary), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodMessage) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal virtual void InitDictionary()
		{
			throw null;
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001BFA RID: 7162 RVA: 0x0001932E File Offset: 0x0001752E
		[global::Cpp2ILInjected.Token(Token = "0x170003CB")]
		public string TypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E2C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4ADE0", Offset = "0x1B4ADE0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodCall), Member = "ResolveMethod", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001BFB RID: 7163 RVA: 0x00019331 File Offset: 0x00017531
		// (set) Token: 0x06001BFC RID: 7164 RVA: 0x00019334 File Offset: 0x00017534
		[global::Cpp2ILInjected.Token(Token = "0x170003CC")]
		public string Uri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E2D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4AE1C", Offset = "0x1B4AE1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001E2E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4AE24", Offset = "0x1B4AE24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001BFD RID: 7165 RVA: 0x00019337 File Offset: 0x00017537
		// (set) Token: 0x06001BFE RID: 7166 RVA: 0x0001933A File Offset: 0x0001753A
		[global::Cpp2ILInjected.Token(Token = "0x170003CD")]
		private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E2F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4AE2C", Offset = "0x1B4AE2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001E30")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4AE34", Offset = "0x1B4AE34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0001933D File Offset: 0x0001753D
		[global::Cpp2ILInjected.Token(Token = "0x6001E31")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4AE3C", Offset = "0x1B4AE3C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public object GetArg(int argNum)
		{
			throw null;
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x00019340 File Offset: 0x00017540
		[global::Cpp2ILInjected.Token(Token = "0x6001E32")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4AE4C", Offset = "0x1B4AE4C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Init()
		{
			throw null;
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x00019343 File Offset: 0x00017543
		[global::Cpp2ILInjected.Token(Token = "0x6001E33")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4A64C", Offset = "0x1B4A64C", Length = "0x574")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodCall), Member = "get_MethodBase", ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetServerTypeForUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodCall), Member = "CastTo", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetMethodBaseFromName", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(global::System.Reflection.MethodBase)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetVirtualMethod", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Reflection.MethodBase)
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetMethodBaseFromMethodMessage", MemberParameters = new object[] { typeof(IMethodMessage) }, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodCall), Member = "get_GenericArguments", ReturnType = typeof(global::System.Type[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodCall), Member = "get_TypeName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
		public void ResolveMethod()
		{
			throw null;
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x00019346 File Offset: 0x00017546
		[global::Cpp2ILInjected.Token(Token = "0x6001E34")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4AE50", Offset = "0x1B4AE50", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodCall), Member = "ResolveMethod", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodCall), Member = "GetTypeNameFromAssemblyQualifiedName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private global::System.Type CastTo(string clientType, global::System.Type serverType)
		{
			throw null;
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x00019349 File Offset: 0x00017549
		[global::Cpp2ILInjected.Token(Token = "0x6001E35")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4AFF4", Offset = "0x1B4AFF4", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodCall), Member = "CastTo", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static string GetTypeNameFromAssemblyQualifiedName(string aqname)
		{
			throw null;
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001C04 RID: 7172 RVA: 0x0001934C File Offset: 0x0001754C
		// (set) Token: 0x06001C05 RID: 7173 RVA: 0x0001934F File Offset: 0x0001754F
		[global::Cpp2ILInjected.Token(Token = "0x170003CE")]
		private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E36")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4B090", Offset = "0x1B4B090", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001E37")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4B098", Offset = "0x1B4B098", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x00019352 File Offset: 0x00017552
		[global::Cpp2ILInjected.Token(Token = "0x170003CF")]
		private global::System.Type[] GenericArguments
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E38")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4AFC0", Offset = "0x1B4AFC0", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodCall), Member = "ResolveMethod", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodCall), Member = "get_MethodBase", ReturnType = typeof(global::System.Reflection.MethodBase))]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000C3B RID: 3131
		[global::Cpp2ILInjected.Token(Token = "0x4000F27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _uri;

		// Token: 0x04000C3C RID: 3132
		[global::Cpp2ILInjected.Token(Token = "0x4000F28")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _typeName;

		// Token: 0x04000C3D RID: 3133
		[global::Cpp2ILInjected.Token(Token = "0x4000F29")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string _methodName;

		// Token: 0x04000C3E RID: 3134
		[global::Cpp2ILInjected.Token(Token = "0x4000F2A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private object[] _args;

		// Token: 0x04000C3F RID: 3135
		[global::Cpp2ILInjected.Token(Token = "0x4000F2B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private global::System.Type[] _methodSignature;

		// Token: 0x04000C40 RID: 3136
		[global::Cpp2ILInjected.Token(Token = "0x4000F2C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::System.Reflection.MethodBase _methodBase;

		// Token: 0x04000C41 RID: 3137
		[global::Cpp2ILInjected.Token(Token = "0x4000F2D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private LogicalCallContext _callContext;

		// Token: 0x04000C42 RID: 3138
		[global::Cpp2ILInjected.Token(Token = "0x4000F2E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Identity _targetIdentity;

		// Token: 0x04000C43 RID: 3139
		[global::Cpp2ILInjected.Token(Token = "0x4000F2F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private global::System.Type[] _genericArguments;

		// Token: 0x04000C44 RID: 3140
		[global::Cpp2ILInjected.Token(Token = "0x4000F30")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		protected global::System.Collections.IDictionary ExternalProperties;

		// Token: 0x04000C45 RID: 3141
		[global::Cpp2ILInjected.Token(Token = "0x4000F31")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		protected global::System.Collections.IDictionary InternalProperties;
	}
}
