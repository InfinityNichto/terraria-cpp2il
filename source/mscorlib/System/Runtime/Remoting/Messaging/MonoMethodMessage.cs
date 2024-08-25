using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Proxies;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	[global::Cpp2ILInjected.Token(Token = "0x20003B7")]
	[global::System.Serializable]
	[StructLayout(0)]
	internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001E75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4DA64", Offset = "0x1B4DA64", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoMethodMessage), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoMethodMessage), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(object[]),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.ParameterInfo), Member = "get_IsOut", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal void InitMessage(global::System.Reflection.RuntimeMethodInfo method, object[] out_args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4DC68", Offset = "0x1B4DC68", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(global::System.Reflection.MethodBase)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoMethodMessage), Member = "InitMessage", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.RuntimeMethodInfo),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public MonoMethodMessage(global::System.Reflection.MethodBase method, object[] out_args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E77")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B34318", Offset = "0x1B34318", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.TransparentProxy), Member = "LoadRemoteFieldNew", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.TransparentProxy), Member = "StoreRemoteField", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoMethodMessage), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoMethodMessage), Member = "InitMessage", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.RuntimeMethodInfo),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal MonoMethodMessage(global::System.Reflection.MethodInfo minfo, object[] in_args, object[] out_args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4DD30", Offset = "0x1B4DD30", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoMethodMessage), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetMethod", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static global::System.Reflection.MethodInfo GetMethodInfo(global::System.Type type, string methodName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4DDD8", Offset = "0x1B4DDD8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoMethodMessage), Member = "GetMethodInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoMethodMessage), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(object[]),
			typeof(object[])
		}, ReturnType = typeof(void))]
		public MonoMethodMessage(global::System.Type type, string methodName, object[] in_args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003EC")]
		public global::System.Collections.IDictionary Properties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E7A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4DE10", Offset = "0x1B4DE10", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MCMDictionary), Member = ".ctor", MemberParameters = new object[] { typeof(IMethodMessage) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003ED")]
		public int ArgCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E7B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4DE74", Offset = "0x1B4DE74", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoMethodMessage), Member = "get_CallType", ReturnType = typeof(CallType))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003EE")]
		public object[] Args
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E7C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4DEAC", Offset = "0x1B4DEAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003EF")]
		public LogicalCallContext LogicalCallContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E7D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4DEB4", Offset = "0x1B4DEB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001E7E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4DEBC", Offset = "0x1B4DEBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003F0")]
		public global::System.Reflection.MethodBase MethodBase
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E7F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4DEC4", Offset = "0x1B4DEC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003F1")]
		public string MethodName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E80")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4DECC", Offset = "0x1B4DECC", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.MethodInfo),
				typeof(global::System.Reflection.MethodInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003F2")]
		public object MethodSignature
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E81")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4DF44", Offset = "0x1B4DF44", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003F3")]
		public string TypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E82")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E030", Offset = "0x1B4E030", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.MethodInfo),
				typeof(global::System.Reflection.MethodInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003F4")]
		public string Uri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E83")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E0B8", Offset = "0x1B4E0B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001E84")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E0C0", Offset = "0x1B4E0C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B363A0", Offset = "0x1B363A0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public object GetArg(int arg_num)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003F5")]
		public global::System.Exception Exception
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E86")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E0C8", Offset = "0x1B4E0C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003F6")]
		public int OutArgCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E87")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E0D0", Offset = "0x1B4E0D0", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoMethodMessage), Member = "get_OutArgs", ReturnType = typeof(object[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003F7")]
		public object[] OutArgs
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E88")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E11C", Offset = "0x1B4E11C", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoMethodMessage), Member = "get_OutArgCount", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003F8")]
		public object ReturnValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E89")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E20C", Offset = "0x1B4E20C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003F9")]
		private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E8A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E214", Offset = "0x1B4E214", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001E8B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E21C", Offset = "0x1B4E21C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003FA")]
		public AsyncResult AsyncResult
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E8C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4E224", Offset = "0x1B4E224", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170003FB")]
		internal CallType CallType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001E8D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B35250", Offset = "0x1B35250", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RealProxy), Member = "PrivateInvoke", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Remoting.Proxies.RealProxy),
				typeof(IMessage),
				typeof(ref global::System.Exception),
				typeof(ref object[])
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = "Invoke", MemberParameters = new object[] { typeof(IMessage) }, ReturnType = typeof(IMessage))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoMethodMessage), Member = "get_ArgCount", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingServices), Member = "IsOneWay", MemberParameters = new object[] { typeof(global::System.Reflection.MethodBase) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001E8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B36330", Offset = "0x1B36330", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RealProxy), Member = "ProcessResponse", MemberParameters = new object[]
		{
			typeof(IMethodReturnMessage),
			typeof(MonoMethodMessage)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool NeedsOutProcessing(out int outCount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000F4B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Reflection.RuntimeMethodInfo method;

		[global::Cpp2ILInjected.Token(Token = "0x4000F4C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object[] args;

		[global::Cpp2ILInjected.Token(Token = "0x4000F4D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string[] names;

		[global::Cpp2ILInjected.Token(Token = "0x4000F4E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] arg_types;

		[global::Cpp2ILInjected.Token(Token = "0x4000F4F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public LogicalCallContext ctx;

		[global::Cpp2ILInjected.Token(Token = "0x4000F50")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public object rval;

		[global::Cpp2ILInjected.Token(Token = "0x4000F51")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public global::System.Exception exc;

		[global::Cpp2ILInjected.Token(Token = "0x4000F52")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private AsyncResult asyncResult;

		[global::Cpp2ILInjected.Token(Token = "0x4000F53")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private CallType call_type;

		[global::Cpp2ILInjected.Token(Token = "0x4000F54")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string uri;

		[global::Cpp2ILInjected.Token(Token = "0x4000F55")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private MCMDictionary properties;

		[global::Cpp2ILInjected.Token(Token = "0x4000F56")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private Identity identity;

		[global::Cpp2ILInjected.Token(Token = "0x4000F57")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private global::System.Type[] methodSignature;
	}
}
