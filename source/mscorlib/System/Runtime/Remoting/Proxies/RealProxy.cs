using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Proxies
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200035B")]
	[StructLayout(0)]
	public abstract class RealProxy
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001C9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B34F04", Offset = "0x1B34F04", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected RealProxy()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B34F14", Offset = "0x1B34F14", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProxyAttribute), Member = "CreateInstance", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.MarshalByRefObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected RealProxy(global::System.Type classToProxy)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B35094", Offset = "0x1B35094", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ClientIdentity)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RealProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.IntPtr),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal RealProxy(global::System.Type classToProxy, ClientIdentity identity)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B34F74", Offset = "0x1B34F74", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RealProxy), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ClientIdentity)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsMarshalByRef", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected RealProxy(global::System.Type classToProxy, global::System.IntPtr stub, object stubData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B35100", Offset = "0x1B35100", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern global::System.Type InternalGetProxyType(object transparentProxy);

		[global::Cpp2ILInjected.Token(Token = "0x6001C9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B35104", Offset = "0x1B35104", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new object[]
		{
			typeof(RealProxy),
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(ref global::System.Exception),
			typeof(ref object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingProxy), Member = "Invoke", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingProxy), Member = "get_TypeName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingProxy), Member = "CanCastTo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public global::System.Type GetProxiedType()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B351A8", Offset = "0x1B351A8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000350")]
		internal Identity ObjectIdentity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001CA1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B35240", Offset = "0x1B35240", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001CA2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B35248", Offset = "0x1B35248", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CA3")]
		public abstract global::System.Runtime.Remoting.Messaging.IMessage Invoke(global::System.Runtime.Remoting.Messaging.IMessage msg);

		[global::Cpp2ILInjected.Token(Token = "0x6001CA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B34420", Offset = "0x1B34420", Length = "0x84C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TransparentProxy), Member = "LoadRemoteFieldNew", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TransparentProxy), Member = "StoreRemoteField", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentThread", ReturnType = typeof(global::System.Threading.Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "GetMutableExecutionContext", ReturnType = typeof(global::System.Threading.ExecutionContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.MonoMethodMessage), Member = "get_CallType", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.CallType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.AsyncResult), Member = "EndInvoke", ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "get_IsConstructor", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RealProxy), Member = "GetProxiedType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingProxy), Member = "ActivateRemoteObject", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMethodMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.ReturnMessage), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[]),
			typeof(int),
			typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext), Member = "get_HasInfo", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext), Member = "Merge", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.LogicalCallContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RealProxy), Member = "ProcessResponse", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.IMethodReturnMessage),
			typeof(global::System.Runtime.Remoting.Messaging.MonoMethodMessage)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "FixRemotingException", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.ReturnMessage), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 49)]
		internal static object PrivateInvoke(RealProxy rp, global::System.Runtime.Remoting.Messaging.IMessage msg, out global::System.Exception exc, out object[] out_args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B360A0", Offset = "0x1B360A0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal virtual extern object InternalGetTransparentProxy(string className);

		[global::Cpp2ILInjected.Token(Token = "0x6001CA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B360A4", Offset = "0x1B360A4", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual object GetTransparentProxy()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B361FC", Offset = "0x1B361FC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected void AttachServer(global::System.MarshalByRefObject s)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B36204", Offset = "0x1B36204", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetTargetDomain(int domainId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3620C", Offset = "0x1B3620C", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetIdentityForUri", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Identity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal object GetAppDomainTarget()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001CAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B35A20", Offset = "0x1B35A20", Length = "0x680")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new object[]
		{
			typeof(RealProxy),
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(ref global::System.Exception),
			typeof(ref object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.MonoMethodMessage), Member = "NeedsOutProcessing", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.ParameterInfo), Member = "get_IsOut", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "UpdateOutArgObject", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ParameterInfo),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		private static object[] ProcessResponse(global::System.Runtime.Remoting.Messaging.IMethodReturnMessage mrm, global::System.Runtime.Remoting.Messaging.MonoMethodMessage call)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000E7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Type class_to_proxy;

		[global::Cpp2ILInjected.Token(Token = "0x4000E7F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal global::System.Runtime.Remoting.Contexts.Context _targetContext;

		[global::Cpp2ILInjected.Token(Token = "0x4000E80")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal global::System.MarshalByRefObject _server;

		[global::Cpp2ILInjected.Token(Token = "0x4000E81")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _targetDomainId;

		[global::Cpp2ILInjected.Token(Token = "0x4000E82")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal string _targetUri;

		[global::Cpp2ILInjected.Token(Token = "0x4000E83")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal Identity _objectIdentity;

		[global::Cpp2ILInjected.Token(Token = "0x4000E84")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private object _objTP;

		[global::Cpp2ILInjected.Token(Token = "0x4000E85")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private object _stubData;
	}
}
