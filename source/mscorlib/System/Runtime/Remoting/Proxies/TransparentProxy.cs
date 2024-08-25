using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono;

namespace System.Runtime.Remoting.Proxies
{
	[global::Cpp2ILInjected.Token(Token = "0x200035A")]
	[StructLayout(0)]
	internal class TransparentProxy
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001C93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B33F60", Offset = "0x1B33F60", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TransparentProxy), Member = "get_IsContextBoundObject", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TransparentProxy), Member = "InCurrentContext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.RuntimeRemoteClassHandle), Member = "get_ProxyClass", ReturnType = typeof(global::Mono.RuntimeClassHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.RuntimeClassHandle), Member = "GetTypeHandle", ReturnType = typeof(global::System.RuntimeTypeHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal global::System.RuntimeType GetProxyType()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700034E")]
		private bool IsContextBoundObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C94")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B34030", Offset = "0x1B34030", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TransparentProxy), Member = "GetProxyType", ReturnType = typeof(global::System.RuntimeType))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsContextful", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700034F")]
		private global::System.Runtime.Remoting.Contexts.Context TargetContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C95")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B34044", Offset = "0x1B34044", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B34050", Offset = "0x1B34050", Length = "0x40")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TransparentProxy), Member = "GetProxyType", ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsContextful", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Thread), Member = "get_CurrentContext", ReturnType = typeof(global::System.Runtime.Remoting.Contexts.Context))]
		private bool InCurrentContext()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B34090", Offset = "0x1B34090", Length = "0x288")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.RuntimeClassHandle), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.RuntimeClassHandle), Member = "GetTypeHandle", ReturnType = typeof(global::System.RuntimeTypeHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "GetFieldFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeFieldHandle) }, ReturnType = typeof(global::System.Reflection.FieldInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TransparentProxy), Member = "InCurrentContext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.MonoMethodMessage), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(object[]),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new object[]
		{
			typeof(RealProxy),
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(ref global::System.Exception),
			typeof(ref object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MissingMethodException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		internal object LoadRemoteFieldNew(global::System.IntPtr classPtr, global::System.IntPtr fieldPtr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C98")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B34C6C", Offset = "0x1B34C6C", Length = "0x290")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.RuntimeClassHandle), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.RuntimeClassHandle), Member = "GetTypeHandle", ReturnType = typeof(global::System.RuntimeTypeHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "GetFieldFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeFieldHandle) }, ReturnType = typeof(global::System.Reflection.FieldInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TransparentProxy), Member = "InCurrentContext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Remoting.Messaging.MonoMethodMessage), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(object[]),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RealProxy), Member = "PrivateInvoke", MemberParameters = new object[]
		{
			typeof(RealProxy),
			typeof(global::System.Runtime.Remoting.Messaging.IMessage),
			typeof(ref global::System.Exception),
			typeof(ref object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MissingMethodException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		internal void StoreRemoteField(global::System.IntPtr classPtr, global::System.IntPtr fieldPtr, object arg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001C99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B34EFC", Offset = "0x1B34EFC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TransparentProxy()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000E7B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public RealProxy _rp;

		[global::Cpp2ILInjected.Token(Token = "0x4000E7C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::Mono.RuntimeRemoteClassHandle _class;

		[global::Cpp2ILInjected.Token(Token = "0x4000E7D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool _custom_type_info;
	}
}
