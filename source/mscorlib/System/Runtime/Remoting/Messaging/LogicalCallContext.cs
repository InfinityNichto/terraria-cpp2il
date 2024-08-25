using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000394")]
	[global::System.Serializable]
	public sealed class LogicalCallContext : global::System.Runtime.Serialization.ISerializable, global::System.ICloneable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001D8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B43890", Offset = "0x1B43890", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(LogicalCallContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal LogicalCallContext()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B43898", Offset = "0x1B43898", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "get_Value", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LogicalCallContext), Member = "get_Datastore", ReturnType = typeof(global::System.Collections.Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal LogicalCallContext(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B43BD4", Offset = "0x1B43BD4", Length = "0x344")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "SetType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B43F44", Offset = "0x1B43F44", Length = "0x5C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ExecutionContext), Member = "CreateCopy", ReturnType = typeof(global::System.Threading.ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ExecutionContext), Member = "CreateMutableCopy", ReturnType = typeof(global::System.Threading.ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LogicalCallContext.Reader), Member = "Clone", ReturnType = typeof(LogicalCallContext))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CallContextRemotingData), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CallContextSecurityData), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LogicalCallContext), Member = "get_Datastore", ReturnType = typeof(global::System.Collections.Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public object Clone()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B35800", Offset = "0x1B35800", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "DeserializeCallData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RealProxy), Member = "PrivateInvoke", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Proxies.RealProxy),
			typeof(IMessage),
			typeof(ref global::System.Exception),
			typeof(ref object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LogicalCallContext), Member = "get_Datastore", ReturnType = typeof(global::System.Collections.Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal void Merge(LogicalCallContext lc)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000391")]
		public bool HasInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D94")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B357A0", Offset = "0x1B357A0", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ExecutionContext), Member = "Capture", MemberParameters = new object[]
			{
				typeof(ref global::System.Threading.StackCrawlMark),
				typeof(global::System.Threading.ExecutionContext.CaptureOptions)
			}, ReturnType = typeof(global::System.Threading.ExecutionContext))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ExecutionContext), Member = "IsDefaultFTContext", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "DeserializeCallData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RealProxy), Member = "PrivateInvoke", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Remoting.Proxies.RealProxy),
				typeof(IMessage),
				typeof(ref global::System.Exception),
				typeof(ref object[])
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LogicalCallContext.Reader), Member = "get_HasInfo", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CADMessageBase), Member = "SaveLogicalCallContext", MemberParameters = new object[]
			{
				typeof(IMethodMessage),
				typeof(ref global::System.Collections.ArrayList)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000392")]
		private bool HasUserData
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D95")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B43F18", Offset = "0x1B43F18", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000393")]
		private global::System.Collections.Hashtable Datastore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D96")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B43B70", Offset = "0x1B43B70", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CallContext), Member = "LogicalGetData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LogicalCallContext.Reader), Member = "GetData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LogicalCallContext), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Serialization.SerializationInfo),
				typeof(global::System.Runtime.Serialization.StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LogicalCallContext), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LogicalCallContext), Member = "Merge", MemberParameters = new object[] { typeof(LogicalCallContext) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LogicalCallContext), Member = "GetData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LogicalCallContext), Member = "SetData", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B445E8", Offset = "0x1B445E8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LogicalCallContext), Member = "get_Datastore", ReturnType = typeof(global::System.Collections.Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public object GetData(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001D98")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4351C", Offset = "0x1B4351C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CallContext), Member = "LogicalSetData", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LogicalCallContext), Member = "get_Datastore", ReturnType = typeof(global::System.Collections.Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetData(string name, object data)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001D99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4460C", Offset = "0x1B4460C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static LogicalCallContext()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000EE2")]
		private static global::System.Type s_callContextType;

		[global::Cpp2ILInjected.Token(Token = "0x4000EE3")]
		private const string s_CorrelationMgrSlotName = "System.Diagnostics.Trace.CorrelationManagerSlot";

		[global::Cpp2ILInjected.Token(Token = "0x4000EE4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Collections.Hashtable m_Datastore;

		[global::Cpp2ILInjected.Token(Token = "0x4000EE5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private CallContextRemotingData m_RemotingData;

		[global::Cpp2ILInjected.Token(Token = "0x4000EE6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private CallContextSecurityData m_SecurityData;

		[global::Cpp2ILInjected.Token(Token = "0x4000EE7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private object m_HostContext;

		[global::Cpp2ILInjected.Token(Token = "0x4000EE8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool m_IsCorrelationMgr;

		[global::Cpp2ILInjected.Token(Token = "0x4000EE9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Header[] _sendHeaders;

		[global::Cpp2ILInjected.Token(Token = "0x4000EEA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Header[] _recvHeaders;

		[global::Cpp2ILInjected.Token(Token = "0x2000395")]
		internal struct Reader
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D9A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4469C", Offset = "0x1B4469C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public Reader(LogicalCallContext ctx)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000394")]
			public bool IsNull
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D9B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B446A4", Offset = "0x1B446A4", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "SerializeCallData", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(byte[]))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000395")]
			public bool HasInfo
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001D9C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B446B4", Offset = "0x1B446B4", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ExecutionContext), Member = "Capture", MemberParameters = new object[]
				{
					typeof(ref global::System.Threading.StackCrawlMark),
					typeof(global::System.Threading.ExecutionContext.CaptureOptions)
				}, ReturnType = typeof(global::System.Threading.ExecutionContext))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LogicalCallContext), Member = "get_HasInfo", ReturnType = typeof(bool))]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001D9D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B446C4", Offset = "0x1B446C4", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.ExecutionContext), Member = "Capture", MemberParameters = new object[]
			{
				typeof(ref global::System.Threading.StackCrawlMark),
				typeof(global::System.Threading.ExecutionContext.CaptureOptions)
			}, ReturnType = typeof(global::System.Threading.ExecutionContext))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "SerializeCallData", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LogicalCallContext), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public LogicalCallContext Clone()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001D9E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B43460", Offset = "0x1B43460", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LogicalCallContext), Member = "get_Datastore", ReturnType = typeof(global::System.Collections.Hashtable))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public object GetData(string name)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000EEB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private LogicalCallContext m_ctx;
		}
	}
}
