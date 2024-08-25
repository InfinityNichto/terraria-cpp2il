using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	[global::System.CLSCompliant(false)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003B5")]
	[global::System.Serializable]
	public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, global::System.Runtime.Serialization.ISerializable, IInternalMessage
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001E5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3F814", Offset = "0x1B3F814", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.ChannelServices), Member = "CheckReturnMessage", MemberParameters = new object[]
		{
			typeof(IMessage),
			typeof(IMessage)
		}, ReturnType = typeof(IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CrossAppDomainSink), Member = "ProcessMessageInDomain", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(CADMethodCallMessage)
		}, ReturnType = "System.Runtime.Remoting.Channels.CrossAppDomainSink.ProcessMessageRes")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.AppDomainLevelActivator), Member = "Activate", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Activation.IConstructionReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConstructionResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Exception),
			typeof(IMethodCallMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal MethodResponse(global::System.Exception e, IMethodCallMessage msg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B37320", Offset = "0x1B37320", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = "Invoke", MemberParameters = new object[] { typeof(IMessage) }, ReturnType = typeof(IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = "ActivateRemoteObject", MemberParameters = new object[] { typeof(IMethodMessage) }, ReturnType = typeof(IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "CreateInstanceFromMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.RemoteActivator), Member = "Activate", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Activation.IConstructionReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConstructionResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(LogicalCallContext),
			typeof(IMethodCallMessage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal MethodResponse(object returnValue, object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B40DB4", Offset = "0x1B40DB4", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CrossAppDomainSink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(IMessage) }, ReturnType = typeof(IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMethodReturnMessage), Member = "GetArguments", ReturnType = typeof(global::System.Collections.ArrayList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMethodReturnMessage), Member = "GetException", MemberParameters = new object[] { typeof(global::System.Collections.ArrayList) }, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "UnmarshalArgument", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Collections.ArrayList)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "UnmarshalArguments", MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(global::System.Collections.ArrayList)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "GetLogicalCallContext", MemberParameters = new object[] { typeof(global::System.Collections.ArrayList) }, ReturnType = typeof(LogicalCallContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CADMessageBase), Member = "UnmarshalProperties", MemberParameters = new object[]
		{
			typeof(global::System.Collections.IDictionary),
			typeof(int),
			typeof(global::System.Collections.ArrayList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal MethodResponse(IMethodCallMessage msg, CADMethodReturnMessage retmsg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B49FD8", Offset = "0x1B49FD8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfoEnumerator), Member = "get_Current", ReturnType = typeof(global::System.Runtime.Serialization.SerializationEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodResponse), Member = "InitMethodProperty", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		internal MethodResponse(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4C848", Offset = "0x1B4C848", Length = "0x4A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::<PrivateImplementationDetails>), Member = "ComputeStringHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		internal void InitMethodProperty(string key, object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003DE")]
		public int ArgCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E60")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4CCE8", Offset = "0x1B4CCE8", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003DF")]
		public object[] Args
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E61")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4CD00", Offset = "0x1B4CD00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003E0")]
		public global::System.Exception Exception
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E62")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4CD08", Offset = "0x1B4CD08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003E1")]
		public LogicalCallContext LogicalCallContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E63")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4CD10", Offset = "0x1B4CD10", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003E2")]
		public global::System.Reflection.MethodBase MethodBase
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E64")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4CD74", Offset = "0x1B4CD74", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodResponse), Member = "get_OutArgs", ReturnType = typeof(object[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.MethodBase),
				typeof(global::System.Reflection.MethodBase)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodResponse), Member = "get_MethodName", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodResponse), Member = "get_TypeName", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "GetMethodBaseFromMethodMessage", MemberParameters = new object[] { typeof(IMethodMessage) }, ReturnType = typeof(global::System.Reflection.MethodBase))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003E3")]
		public string MethodName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E65")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4CE80", Offset = "0x1B4CE80", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodResponse), Member = "get_MethodBase", ReturnType = typeof(global::System.Reflection.MethodBase))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003E4")]
		public object MethodSignature
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E66")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4CFF0", Offset = "0x1B4CFF0", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003E5")]
		public object[] OutArgs
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E67")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4D104", Offset = "0x1B4D104", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodResponse), Member = "get_MethodBase", ReturnType = typeof(global::System.Reflection.MethodBase))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgInfo), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.MethodBase),
				typeof(ArgInfoType)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgInfo), Member = "GetInOutArgs", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(object[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003E6")]
		public virtual global::System.Collections.IDictionary Properties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E68")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4A048", Offset = "0x1B4A048", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodReturnDictionary), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodReturnMessage) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003E7")]
		public object ReturnValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E69")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4D29C", Offset = "0x1B4D29C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003E8")]
		public string TypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E6A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4CF38", Offset = "0x1B4CF38", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodResponse), Member = "get_MethodBase", ReturnType = typeof(global::System.Reflection.MethodBase))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003E9")]
		public string Uri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E6B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4D2A4", Offset = "0x1B4D2A4", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodResponse), Member = "System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001E6C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4D35C", Offset = "0x1B4D35C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003EA")]
		private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E6D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4D364", Offset = "0x1B4D364", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodResponse), Member = "get_Uri", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001E6E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4D368", Offset = "0x1B4D368", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4D370", Offset = "0x1B4D370", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public object GetArg(int argNum)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4D38C", Offset = "0x1B4D38C", Length = "0x498")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public virtual void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003EB")]
		private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E71")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4D824", Offset = "0x1B4D824", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001E72")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4D82C", Offset = "0x1B4D82C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000F3A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _methodName;

		[global::Cpp2ILInjected.Token(Token = "0x4000F3B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _uri;

		[global::Cpp2ILInjected.Token(Token = "0x4000F3C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string _typeName;

		[global::Cpp2ILInjected.Token(Token = "0x4000F3D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Reflection.MethodBase _methodBase;

		[global::Cpp2ILInjected.Token(Token = "0x4000F3E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private object _returnValue;

		[global::Cpp2ILInjected.Token(Token = "0x4000F3F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::System.Exception _exception;

		[global::Cpp2ILInjected.Token(Token = "0x4000F40")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private global::System.Type[] _methodSignature;

		[global::Cpp2ILInjected.Token(Token = "0x4000F41")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private ArgInfo _inArgInfo;

		[global::Cpp2ILInjected.Token(Token = "0x4000F42")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private object[] _args;

		[global::Cpp2ILInjected.Token(Token = "0x4000F43")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private object[] _outArgs;

		[global::Cpp2ILInjected.Token(Token = "0x4000F44")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private IMethodCallMessage _callMsg;

		[global::Cpp2ILInjected.Token(Token = "0x4000F45")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private LogicalCallContext _callContext;

		[global::Cpp2ILInjected.Token(Token = "0x4000F46")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private Identity _targetIdentity;

		[global::Cpp2ILInjected.Token(Token = "0x4000F47")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		protected global::System.Collections.IDictionary ExternalProperties;

		[global::Cpp2ILInjected.Token(Token = "0x4000F48")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		protected global::System.Collections.IDictionary InternalProperties;
	}
}
