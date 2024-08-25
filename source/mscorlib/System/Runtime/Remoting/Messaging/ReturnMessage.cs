using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Proxies;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003BD")]
	public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001E98")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B35638", Offset = "0x1B35638", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(IMethodCallMessage)
		}, ReturnType = typeof(IMethodReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RealProxy), Member = "PrivateInvoke", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Proxies.RealProxy),
			typeof(IMessage),
			typeof(ref global::System.Exception),
			typeof(ref object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = "Invoke", MemberParameters = new object[] { typeof(IMessage) }, ReturnType = typeof(IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public ReturnMessage(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B354F0", Offset = "0x1B354F0", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(IMethodCallMessage)
		}, ReturnType = typeof(IMethodReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RealProxy), Member = "PrivateInvoke", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Proxies.RealProxy),
			typeof(IMessage),
			typeof(ref global::System.Exception),
			typeof(ref object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.Remoting.Contexts.CrossContextChannel.ContextRestoreSink", Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(IMessage) }, ReturnType = typeof(IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.CrossContextChannel), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(IMessage) }, ReturnType = typeof(IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Contexts.CrossContextChannel), Member = "AsyncProcessMessage", MemberParameters = new object[]
		{
			typeof(IMessage),
			typeof(IMessageSink)
		}, ReturnType = typeof(IMessageCtrl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.ChannelServices), Member = "CheckIncomingMessage", MemberParameters = new object[] { typeof(IMessage) }, ReturnType = typeof(ReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CrossAppDomainSink), Member = "SyncProcessMessage", MemberParameters = new object[] { typeof(IMessage) }, ReturnType = typeof(IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "RemoteActivate", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public ReturnMessage(global::System.Exception e, IMethodCallMessage mcm)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003FC")]
		public int ArgCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E9A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E754", Offset = "0x1B4E754", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003FD")]
		public object[] Args
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E760", Offset = "0x1B4E760", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003FE")]
		public LogicalCallContext LogicalCallContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E9C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E768", Offset = "0x1B4E768", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003FF")]
		public global::System.Reflection.MethodBase MethodBase
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E9D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E7CC", Offset = "0x1B4E7CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000400")]
		public string MethodName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E9E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E7D4", Offset = "0x1B4E7D4", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.MethodBase),
				typeof(global::System.Reflection.MethodBase)
			}, ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000401")]
		public object MethodSignature
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E9F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E81C", Offset = "0x1B4E81C", Length = "0xFC")]
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

		[global::Cpp2ILInjected.Token(Token = "0x17000402")]
		public virtual global::System.Collections.IDictionary Properties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001EA0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E918", Offset = "0x1B4E918", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodReturnDictionary), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodReturnMessage) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000403")]
		public string TypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001EA1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E97C", Offset = "0x1B4E97C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.MethodBase),
				typeof(global::System.Reflection.MethodBase)
			}, ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000404")]
		public string Uri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001EA2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E9D4", Offset = "0x1B4E9D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001EA3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E9DC", Offset = "0x1B4E9DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000405")]
		private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001EA4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E9E4", Offset = "0x1B4E9E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001EA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E9EC", Offset = "0x1B4E9EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001EA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4E9F4", Offset = "0x1B4E9F4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public object GetArg(int argNum)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000406")]
		public global::System.Exception Exception
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001EA7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4EA04", Offset = "0x1B4EA04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000407")]
		public object[] OutArgs
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001EA8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4EA0C", Offset = "0x1B4EA0C", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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

		[global::Cpp2ILInjected.Token(Token = "0x17000408")]
		public virtual object ReturnValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001EA9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4EA9C", Offset = "0x1B4EA9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000409")]
		private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001EAA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4EAA4", Offset = "0x1B4EAA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001EAB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4EAAC", Offset = "0x1B4EAAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000F61")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object[] _outArgs;

		[global::Cpp2ILInjected.Token(Token = "0x4000F62")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object[] _args;

		[global::Cpp2ILInjected.Token(Token = "0x4000F63")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private LogicalCallContext _callCtx;

		[global::Cpp2ILInjected.Token(Token = "0x4000F64")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private object _returnValue;

		[global::Cpp2ILInjected.Token(Token = "0x4000F65")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string _uri;

		[global::Cpp2ILInjected.Token(Token = "0x4000F66")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::System.Exception _exception;

		[global::Cpp2ILInjected.Token(Token = "0x4000F67")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private global::System.Reflection.MethodBase _methodBase;

		[global::Cpp2ILInjected.Token(Token = "0x4000F68")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string _methodName;

		[global::Cpp2ILInjected.Token(Token = "0x4000F69")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private global::System.Type[] _methodSignature;

		[global::Cpp2ILInjected.Token(Token = "0x4000F6A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string _typeName;

		[global::Cpp2ILInjected.Token(Token = "0x4000F6B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private MethodReturnDictionary _properties;

		[global::Cpp2ILInjected.Token(Token = "0x4000F6C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private Identity _targetIdentity;

		[global::Cpp2ILInjected.Token(Token = "0x4000F6D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private ArgInfo _inArgInfo;
	}
}
