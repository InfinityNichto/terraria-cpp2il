using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x2000170")]
	[global::System.Serializable]
	[StructLayout(0)]
	public abstract class Delegate : global::System.ICloneable, global::System.Runtime.Serialization.ISerializable
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000156")]
		public global::System.Reflection.MethodInfo Method
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EC1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7BBC4", Offset = "0x1C7BBC4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.TypeExtensions", Member = "Method", MemberParameters = new object[] { typeof(global::System.Delegate) }, ReturnType = typeof(global::System.Reflection.MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Events.InvokableCall", Member = "Find", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.Reflection.MethodInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Events.InvokableCall`1", Member = "Find", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.Reflection.MethodInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Events.InvokableCall`2", Member = "Find", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.Reflection.MethodInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Events.InvokableCall`3", Member = "Find", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.Reflection.MethodInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Events.InvokableCall`4", Member = "Find", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.Reflection.MethodInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Events.UnityEvent`1", Member = "RemoveListener", MemberParameters = new object[] { "UnityEngine.Events.UnityAction`1<T0>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7BBD0", Offset = "0x1C7BBD0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern global::System.Reflection.MethodInfo GetVirtualMethod_internal();

		[global::Cpp2ILInjected.Token(Token = "0x17000157")]
		public object Target
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EC3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7BBD4", Offset = "0x1C7BBD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7BBDC", Offset = "0x1C7BBDC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern global::System.Delegate CreateDelegate_internal(global::System.Type type, object target, global::System.Reflection.MethodInfo info, bool throwOnBindFailure);

		[global::Cpp2ILInjected.Token(Token = "0x6000EC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7BBE4", Offset = "0x1C7BBE4", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(global::System.Reflection.MethodInfo),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static bool arg_type_match(global::System.Type delArgType, global::System.Type argType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7BD68", Offset = "0x1C7BD68", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(global::System.Reflection.MethodInfo),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static bool arg_type_match_this(global::System.Type delArgType, global::System.Type argType, bool boxedThis)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7BEA8", Offset = "0x1C7BEA8", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(global::System.Reflection.MethodInfo),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "GetCandidateMethod", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type),
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static bool return_type_match(global::System.Type delReturnType, global::System.Type returnType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7C0A8", Offset = "0x1C7C0A8", Length = "0x6E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Reflection.MethodInfo),
			typeof(bool)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DelegateSerializationHolder.DelegateEntry", Member = "DeserializeDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(int)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetMethod", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "return_type_match", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.TargetParameterCountException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "arg_type_match", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "arg_type_match_this", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		private static global::System.Delegate CreateDelegate(global::System.Type type, object firstArgument, global::System.Reflection.MethodInfo method, bool throwOnBindFailure, bool allowClosed)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7C78C", Offset = "0x1C7C78C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Events.InvokableCall", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Events.InvokableCall`1", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Events.InvokableCall`2", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Events.InvokableCall`3", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Events.InvokableCall`4", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(global::System.Reflection.MethodInfo),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Delegate))]
		public static global::System.Delegate CreateDelegate(global::System.Type type, object firstArgument, global::System.Reflection.MethodInfo method)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ECA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7C798", Offset = "0x1C7C798", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(global::System.Reflection.MethodInfo),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Delegate))]
		public static global::System.Delegate CreateDelegate(global::System.Type type, global::System.Reflection.MethodInfo method, bool throwOnBindFailure)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ECB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7C7B0", Offset = "0x1C7C7B0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.SecureStringHasher", Member = "GetHashCodeDelegate", ReturnType = "System.Xml.SecureStringHasher.HashCodeOfStringDelegate")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlQualifiedName", Member = "GetHashCodeDelegate", ReturnType = "System.Xml.XmlQualifiedName.HashCodeOfStringDelegate")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ReflectionMethodsCache", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(global::System.Reflection.MethodInfo),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Delegate))]
		public static global::System.Delegate CreateDelegate(global::System.Type type, global::System.Reflection.MethodInfo method)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ECC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7C7C4", Offset = "0x1C7C7C4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Delegate))]
		public static global::System.Delegate CreateDelegate(global::System.Type type, object target, string method)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ECD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7C7DC", Offset = "0x1C7C7DC", Length = "0x40C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetMethod", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "return_type_match", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private static global::System.Reflection.MethodInfo GetCandidateMethod(global::System.Type type, global::System.Type target, string method, global::System.Reflection.BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ECE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7CBE8", Offset = "0x1C7CBE8", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DelegateSerializationHolder.DelegateEntry", Member = "DeserializeDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(int)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "GetCandidateMethod", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type),
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static global::System.Delegate CreateDelegate(global::System.Type type, global::System.Type target, string method, bool ignoreCase, bool throwOnBindFailure)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ECF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7CD10", Offset = "0x1C7CD10", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Delegate))]
		public static global::System.Delegate CreateDelegate(global::System.Type type, global::System.Type target, string method)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ED0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7CD1C", Offset = "0x1C7CD1C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DefaultValueAttribute", Member = "<.ctor>g__TryConvertFromInvariantString|2_0", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Delegate))]
		public static global::System.Delegate CreateDelegate(global::System.Type type, global::System.Type target, string method, bool ignoreCase)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ED1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7CD28", Offset = "0x1C7CD28", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.DelegateSerializationHolder.DelegateEntry", Member = "DeserializeDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(int)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "GetCandidateMethod", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type),
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static global::System.Delegate CreateDelegate(global::System.Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ED2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7C7D0", Offset = "0x1C7C7D0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Delegate))]
		public static global::System.Delegate CreateDelegate(global::System.Type type, object target, string method, bool ignoreCase)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ED3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7CE04", Offset = "0x1C7CE04", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual object Clone()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ED4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7CE0C", Offset = "0x1C7CE0C", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MulticastDelegate), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ED5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7CFA0", Offset = "0x1C7CFA0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MulticastDelegate), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "GetHashCode", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ED6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7D00C", Offset = "0x1C7D00C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MulticastDelegate), Member = "GetMethodImpl", ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "GetMethodFromHandleNoGenericCheck", MemberParameters = new object[] { typeof(global::System.RuntimeMethodHandle) }, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected virtual global::System.Reflection.MethodInfo GetMethodImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ED7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7D114", Offset = "0x1C7D114", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ED8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7D334", Offset = "0x1C7D334", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual global::System.Delegate[] GetInvocationList()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ED9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C78294", Offset = "0x1C78294", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Alert", Member = "add_DismissedWithButton", MemberParameters = new object[] { "System.Action`1<Int32>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DrPlatform.User", Member = "add_PlatformUserChanged", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XBOChatPermissions.RequestResult", Member = "add_ResultCallbacks", MemberParameters = new object[] { "XBOChatPermissions.ChatPermissionsResult" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XBOOnlinePresencePermissions.RequestResult", Member = "add_ResultCallbacks", MemberParameters = new object[] { "XBOOnlinePresencePermissions.OnlinePresencePermissionsResult" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SingletonCleanup", Member = "add_CleanUpEvent", MemberParameters = new object[] { "SingletonCleanup.CleanupSingletonCallback" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.DrawableGameComponent", Member = "add_DrawOrderChanged", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.DrawableGameComponent", Member = "add_VisibleChanged", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.GameWindow", Member = "add_ClientSizeChanged", MemberParameters = new object[] { typeof(global::System.EventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.GameWindow", Member = "add_ScreenDeviceNameChanged", MemberParameters = new object[] { typeof(global::System.EventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.GameComponent", Member = "add_UpdateOrderChanged", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.GameComponent", Member = "add_EnabledChanged", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.GameComponentCollection", Member = "add_ComponentAdded", MemberParameters = new object[] { "System.EventHandler`1<GameComponentCollectionEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.GameComponentCollection", Member = "add_ComponentRemoved", MemberParameters = new object[] { "System.EventHandler`1<GameComponentCollectionEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "add_DeviceLost", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "add_DeviceReset", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "add_DeviceResetting", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "add_ResourceCreated", MemberParameters = new object[] { "System.EventHandler`1<ResourceCreatedEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "add_ResourceDestroyed", MemberParameters = new object[] { "System.EventHandler`1<ResourceDestroyedEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "add_Disposing", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "add_PresentationChanged", MemberParameters = new object[] { "System.EventHandler`1<PresentationEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsResource", Member = "add_Disposing", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.RenderTarget2D", Member = "add_ContentLost", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "add_OnEnginePreload", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "add_OnResolutionChanged", MemberParameters = new object[] { "System.Action`1<Vector2>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "add_OnEngineLoad", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "add_OnTickForThirdPartySoftwareOnly", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "add_OnTickForInternalCodeOnly", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "add_OnPreDraw", MemberParameters = new object[] { "System.Action`1<GameTime>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "add_OnPostDraw", MemberParameters = new object[] { "System.Action`1<GameTime>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "add_OnPostFullscreenMapDraw", MemberParameters = new object[] { "System.Action`2<Vector2, Single>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "add_OnRenderTargetsReleased", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "add_OnRenderTargetsInitialized", MemberParameters = new object[] { "Terraria.ResolutionChangeEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.MessageBuffer", Member = "add_OnTileChangeReceived", MemberParameters = new object[] { "Terraria.TileChangeReceivedEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Netplay", Member = "add_OnDisconnect", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player.Hooks", Member = "add_OnEnterWorld", MemberParameters = new object[] { "System.Action`1<Player>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.Hooks", Member = "add_OnWorldGenConfigProcess", MemberParameters = new object[] { "Terraria.WorldGen.Hooks.WorldGenConfigProcessEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.Hooks", Member = "add_OnWorldLoad", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Steam.CoreSocialModule", Member = "add_OnTick", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Discord.DiscordHooks", Member = "RegisterTo", MemberParameters = new object[] { "EventHandlers&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Discord.JoinRequestSocialModule", Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Base.ServerJoinRequestsManager", Member = "add_OnRequestAdded", MemberParameters = new object[] { "Terraria.Social.Base.ServerJoinRequestEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Base.ServerJoinRequestsManager", Member = "add_OnRequestRemoved", MemberParameters = new object[] { "Terraria.Social.Base.ServerJoinRequestEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Base.UserJoinToServerRequest", Member = "add_OnAccepted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Base.UserJoinToServerRequest", Member = "add_OnRejected", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Base.WorkshopIssueReporter", Member = "add_OnNeedToOpenUI", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Base.WorkshopIssueReporter", Member = "add_OnNeedToNotifyUI", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Server.Game", Member = "add_Activated", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Server.Game", Member = "add_Deactivated", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Server.Game", Member = "add_Disposed", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Server.Game", Member = "add_Exiting", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LanguageManager", Member = "add_OnLanguageChanging", MemberParameters = new object[] { "Terraria.Localization.LanguageChangeCallback" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LanguageManager", Member = "add_OnLanguageChanged", MemberParameters = new object[] { "Terraria.Localization.LanguageChangeCallback" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.Preferences", Member = "add_OnSave", MemberParameters = new object[] { "System.Action`1<Preferences>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.Preferences", Member = "add_OnLoad", MemberParameters = new object[] { "System.Action`1<Preferences>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.Preferences", Member = "add_OnProcessText", MemberParameters = new object[] { "Terraria.IO.Preferences.TextProcessAction" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "add_OnWorldLoad", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.DataStructures.TileEntity", Member = "add__UpdateStart", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.DataStructures.TileEntity", Member = "add__UpdateEnd", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.Achievement", Member = "add_OnCompleted", MemberParameters = new object[] { "Terraria.Achievements.Achievement.AchievementCompleted" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.AchievementCondition", Member = "add_OnComplete", MemberParameters = new object[] { "Terraria.Achievements.AchievementCondition.AchievementUpdate" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.AchievementManager", Member = "add_OnAchievementCompleted", MemberParameters = new object[] { "Terraria.Achievements.Achievement.AchievementCompleted" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameInput.PlayerInput", Member = "add_OnBindingChange", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameInput.PlayerInput", Member = "add_OnActionableInput", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSlot", Member = "add_OnItemTransferred", MemberParameters = new object[] { "Terraria.UI.ItemSlot.ItemTransferEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "add_OnLeftMouseDown", MemberParameters = new object[] { "Terraria.UI.UIElement.MouseEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "add_OnLeftMouseUp", MemberParameters = new object[] { "Terraria.UI.UIElement.MouseEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "add_OnLeftClick", MemberParameters = new object[] { "Terraria.UI.UIElement.MouseEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "add_OnLeftDoubleClick", MemberParameters = new object[] { "Terraria.UI.UIElement.MouseEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "add_OnRightMouseDown", MemberParameters = new object[] { "Terraria.UI.UIElement.MouseEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "add_OnRightMouseUp", MemberParameters = new object[] { "Terraria.UI.UIElement.MouseEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "add_OnRightClick", MemberParameters = new object[] { "Terraria.UI.UIElement.MouseEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "add_OnRightDoubleClick", MemberParameters = new object[] { "Terraria.UI.UIElement.MouseEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "add_OnMouseOver", MemberParameters = new object[] { "Terraria.UI.UIElement.MouseEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "add_OnMouseOut", MemberParameters = new object[] { "Terraria.UI.UIElement.MouseEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "add_OnScrollWheel", MemberParameters = new object[] { "Terraria.UI.UIElement.ScrollWheelEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "add_OnUpdate", MemberParameters = new object[] { "Terraria.UI.UIElement.ElementEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Effects.FilterManager", Member = "add_OnPostDraw", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Shaders.WaterShaderData", Member = "add_OnWaveDraw", MemberParameters = new object[] { "System.Action`1<TileBatch>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Bestiary.NPCStatsReportInfoElement", Member = "add_OnRefreshStats", MemberParameters = new object[] { "Terraria.GameContent.Bestiary.NPCStatsReportInfoElement.StatAdjustmentStep" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Achievements.AchievementsHelper", Member = "add_OnItemPickup", MemberParameters = new object[] { "Terraria.GameContent.Achievements.AchievementsHelper.ItemPickupEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Achievements.AchievementsHelper", Member = "add_OnItemCraft", MemberParameters = new object[] { "Terraria.GameContent.Achievements.AchievementsHelper.ItemCraftEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Achievements.AchievementsHelper", Member = "add_OnTileDestroyed", MemberParameters = new object[] { "Terraria.GameContent.Achievements.AchievementsHelper.TileDestroyedEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Achievements.AchievementsHelper", Member = "add_OnNPCKilled", MemberParameters = new object[] { "Terraria.GameContent.Achievements.AchievementsHelper.NPCKilledEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Achievements.AchievementsHelper", Member = "add_OnProgressionEvent", MemberParameters = new object[] { "Terraria.GameContent.Achievements.AchievementsHelper.ProgressionEventEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Liquid.LiquidRenderer", Member = "add_WaveFilters", MemberParameters = new object[] { "System.Action`2<Color[], Rectangle>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIBestiaryEntryGrid", Member = "add_OnGridContentsChanged", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIBestiarySortingOptionsGrid", Member = "add_OnClickingOption", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIBestiaryFilteringOptionsGrid", Member = "add_OnClickingOption", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UICreativeItemsInfiniteFilteringOptions", Member = "add_OnClickingOption", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UISearchBar", Member = "add_OnContentsChanged", MemberParameters = new object[] { "System.Action`1<String>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UISearchBar", Member = "add_OnStartTakingInput", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UISearchBar", Member = "add_OnEndTakingInput", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UISearchBar", Member = "add_OnCanceledTakingInput", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UISearchBar", Member = "add_OnNeedingVirtualKeyboard", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIText", Member = "add_OnInternalTextChange", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "add_KeyGenerated", MemberParameters = new object[] { typeof(Mono.Security.Cryptography.RSAManaged.KeyGeneratedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "add_KeyGenerated", MemberParameters = new object[] { typeof(Mono.Security.Cryptography.DSAManaged.KeyGeneratedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "add_DomainUnload", MemberParameters = new object[] { typeof(global::System.EventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "add_UnhandledException", MemberParameters = new object[] { typeof(global::System.UnhandledExceptionEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "add_FirstChanceException", MemberParameters = new object[] { typeof(global::System.EventHandler<global::System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "Combine", MemberParameters = new object[] { typeof(global::System.Delegate[]) }, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.SerializationEvents), Member = "AddOnDelegate", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Serialization.SerializationEventHandler),
			typeof(global::System.Collections.Generic.List<global::System.Reflection.MethodInfo>)
		}, ReturnType = typeof(global::System.Runtime.Serialization.SerializationEventHandler))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.ObjectManager), Member = "AddOnDeserialization", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.DeserializationEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "add_DownloadStringCompleted", MemberParameters = new object[] { "System.Net.DownloadStringCompletedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "add_DownloadDataCompleted", MemberParameters = new object[] { "System.Net.DownloadDataCompletedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "add_DownloadFileCompleted", MemberParameters = new object[] { "System.ComponentModel.AsyncCompletedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "add_UploadStringCompleted", MemberParameters = new object[] { "System.Net.UploadStringCompletedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "add_UploadDataCompleted", MemberParameters = new object[] { "System.Net.UploadDataCompletedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "add_UploadFileCompleted", MemberParameters = new object[] { "System.Net.UploadFileCompletedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "add_UploadValuesCompleted", MemberParameters = new object[] { "System.Net.UploadValuesCompletedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "add_OpenReadCompleted", MemberParameters = new object[] { "System.Net.OpenReadCompletedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "add_OpenWriteCompleted", MemberParameters = new object[] { "System.Net.OpenWriteCompletedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "add_DownloadProgressChanged", MemberParameters = new object[] { "System.Net.DownloadProgressChangedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "add_UploadProgressChanged", MemberParameters = new object[] { "System.Net.UploadProgressChangedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.SocketAsyncEventArgs", Member = "add_Completed", MemberParameters = new object[] { "System.EventHandler`1<SocketAsyncEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.BackgroundWorker", Member = "add_DoWork", MemberParameters = new object[] { "System.ComponentModel.DoWorkEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.BackgroundWorker", Member = "add_ProgressChanged", MemberParameters = new object[] { "System.ComponentModel.ProgressChangedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.BackgroundWorker", Member = "add_RunWorkerCompleted", MemberParameters = new object[] { "System.ComponentModel.RunWorkerCompletedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EventHandlerList", Member = "AddHandler", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Delegate)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.BindingList`1", Member = "add_AddingNew", MemberParameters = new object[] { "System.ComponentModel.AddingNewEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.BindingList`1", Member = "add_ListChanged", MemberParameters = new object[] { "System.ComponentModel.ListChangedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.PropertyDescriptor", Member = "AddValueChanged", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.EventHandler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectEventDescriptor", Member = "AddEventHandler", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Delegate)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "add_Refreshed", MemberParameters = new object[] { "System.ComponentModel.RefreshEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.PlayerAction", Member = "add_OnLastInputTypeChanged", MemberParameters = new object[] { "System.Action`1<BindingSourceType>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.PlayerAction", Member = "add_OnBindingsChanged", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.PlayerActionSet", Member = "add_OnLastInputTypeChanged", MemberParameters = new object[] { "System.Action`1<BindingSourceType>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.PlayerOneAxisAction", Member = "add_OnLastInputTypeChanged", MemberParameters = new object[] { "System.Action`1<BindingSourceType>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.PlayerTwoAxisAction", Member = "add_OnLastInputTypeChanged", MemberParameters = new object[] { "System.Action`1<BindingSourceType>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Logger", Member = "add_OnLogMessage", MemberParameters = new object[] { "System.Action`1<LogMessage>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputManager", Member = "add_OnSetup", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputManager", Member = "add_OnUpdate", MemberParameters = new object[] { "System.Action`2<UInt64, Single>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputManager", Member = "add_OnReset", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputManager", Member = "add_OnDeviceAttached", MemberParameters = new object[] { "System.Action`1<InputDevice>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputManager", Member = "add_OnDeviceDetached", MemberParameters = new object[] { "System.Action`1<InputDevice>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputManager", Member = "add_OnActiveDeviceChanged", MemberParameters = new object[] { "System.Action`1<InputDevice>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputManager", Member = "add_OnUpdateDevices", MemberParameters = new object[] { "System.Action`2<UInt64, Single>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputManager", Member = "add_OnCommitDevices", MemberParameters = new object[] { "System.Action`2<UInt64, Single>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "add_OnSetup", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonSerializer", Member = "add_Error", MemberParameters = new object[] { "System.EventHandler`1<ErrorEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JContainer", Member = "add_ListChanged", MemberParameters = new object[] { "System.ComponentModel.ListChangedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JContainer", Member = "add_AddingNew", MemberParameters = new object[] { "System.ComponentModel.AddingNewEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "add_PropertyChanged", MemberParameters = new object[] { "System.ComponentModel.PropertyChangedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "add_PropertyChanging", MemberParameters = new object[] { "System.ComponentModel.PropertyChangingEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Application", Member = "add_lowMemory", MemberParameters = new object[] { "UnityEngine.Application.LowMemoryCallback" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransform", Member = "add_reapplyDrivenProperties", MemberParameters = new object[] { "UnityEngine.RectTransform.ReapplyDrivenProperties" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.U2D.SpriteAtlasManager", Member = "add_atlasRegistered", MemberParameters = new object[] { "System.Action`1<SpriteAtlas>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SceneManagement.SceneManager", Member = "add_sceneLoaded", MemberParameters = new object[] { "UnityEngine.Events.UnityAction`2<Scene, LoadSceneMode>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Events.InvokableCall", Member = "add_Delegate", MemberParameters = new object[] { "UnityEngine.Events.UnityAction" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Events.InvokableCall`1", Member = "add_Delegate", MemberParameters = new object[] { "UnityEngine.Events.UnityAction`1<T1>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "RegisterDirtyLayoutCallback", MemberParameters = new object[] { "UnityEngine.Events.UnityAction" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "RegisterDirtyVerticesCallback", MemberParameters = new object[] { "UnityEngine.Events.UnityAction" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "RegisterDirtyMaterialCallback", MemberParameters = new object[] { "UnityEngine.Events.UnityAction" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "add_SaveProgress", MemberParameters = new object[] { "System.EventHandler`1<SaveProgressEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "add_ReadProgress", MemberParameters = new object[] { "System.EventHandler`1<ReadProgressEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "add_ExtractProgress", MemberParameters = new object[] { "System.EventHandler`1<ExtractProgressEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "add_AddProgress", MemberParameters = new object[] { "System.EventHandler`1<AddProgressEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "add_ZipError", MemberParameters = new object[] { "System.EventHandler`1<ZipErrorEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Android.PermissionCallbacks", Member = "add_PermissionGranted", MemberParameters = new object[] { "System.Action`1<String>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Android.PermissionCallbacks", Member = "add_PermissionDenied", MemberParameters = new object[] { "System.Action`1<String>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Android.PermissionCallbacks", Member = "add_PermissionDeniedAndDontAskAgain", MemberParameters = new object[] { "System.Action`1<String>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.PlayerActions", Member = "CreateWithDefaultBindings", ReturnType = "BindingsExample.PlayerActions")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Canvas", Member = "add_preWillRenderCanvases", MemberParameters = new object[] { "UnityEngine.Canvas.WillRenderCanvases" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Canvas", Member = "add_willRenderCanvases", MemberParameters = new object[] { "UnityEngine.Canvas.WillRenderCanvases" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Font", Member = "add_textureRebuilt", MemberParameters = new object[] { "System.Action`1<Font>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 172)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static global::System.Delegate Combine(global::System.Delegate a, global::System.Delegate b)
		{
			throw null;
		}

		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000EDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7D3B0", Offset = "0x1C7D3B0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DelegateSerializationHolder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "Combine", MemberParameters = new object[]
		{
			typeof(global::System.Delegate),
			typeof(global::System.Delegate)
		}, ReturnType = typeof(global::System.Delegate))]
		public static global::System.Delegate Combine(params global::System.Delegate[] delegates)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EDB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7D404", Offset = "0x1C7D404", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MulticastNotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected virtual global::System.Delegate CombineImpl(global::System.Delegate d)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C78478", Offset = "0x1C78478", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Alert", Member = "remove_DismissedWithButton", MemberParameters = new object[] { "System.Action`1<Int32>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DrPlatform.User", Member = "remove_PlatformUserChanged", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XBOChatPermissions.RequestResult", Member = "remove_ResultCallbacks", MemberParameters = new object[] { "XBOChatPermissions.ChatPermissionsResult" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XBOOnlinePresencePermissions.RequestResult", Member = "remove_ResultCallbacks", MemberParameters = new object[] { "XBOOnlinePresencePermissions.OnlinePresencePermissionsResult" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SingletonCleanup", Member = "remove_CleanUpEvent", MemberParameters = new object[] { "SingletonCleanup.CleanupSingletonCallback" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.DrawableGameComponent", Member = "remove_DrawOrderChanged", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.DrawableGameComponent", Member = "remove_VisibleChanged", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.GameWindow", Member = "remove_ClientSizeChanged", MemberParameters = new object[] { typeof(global::System.EventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.GameWindow", Member = "remove_ScreenDeviceNameChanged", MemberParameters = new object[] { typeof(global::System.EventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.GameComponent", Member = "remove_UpdateOrderChanged", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.GameComponent", Member = "remove_EnabledChanged", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.GameComponentCollection", Member = "remove_ComponentAdded", MemberParameters = new object[] { "System.EventHandler`1<GameComponentCollectionEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.GameComponentCollection", Member = "remove_ComponentRemoved", MemberParameters = new object[] { "System.EventHandler`1<GameComponentCollectionEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "remove_DeviceLost", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "remove_DeviceReset", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "remove_DeviceResetting", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "remove_ResourceCreated", MemberParameters = new object[] { "System.EventHandler`1<ResourceCreatedEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "remove_ResourceDestroyed", MemberParameters = new object[] { "System.EventHandler`1<ResourceDestroyedEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "remove_Disposing", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "remove_PresentationChanged", MemberParameters = new object[] { "System.EventHandler`1<PresentationEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsResource", Member = "remove_Disposing", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.RenderTarget2D", Member = "remove_ContentLost", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "remove_OnEnginePreload", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "remove_OnResolutionChanged", MemberParameters = new object[] { "System.Action`1<Vector2>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "remove_OnEngineLoad", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "remove_OnTickForThirdPartySoftwareOnly", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "remove_OnTickForInternalCodeOnly", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "remove_OnPreDraw", MemberParameters = new object[] { "System.Action`1<GameTime>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "remove_OnPostDraw", MemberParameters = new object[] { "System.Action`1<GameTime>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "remove_OnPostFullscreenMapDraw", MemberParameters = new object[] { "System.Action`2<Vector2, Single>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "remove_OnRenderTargetsReleased", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "remove_OnRenderTargetsInitialized", MemberParameters = new object[] { "Terraria.ResolutionChangeEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.MessageBuffer", Member = "remove_OnTileChangeReceived", MemberParameters = new object[] { "Terraria.TileChangeReceivedEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Netplay", Member = "remove_OnDisconnect", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player.Hooks", Member = "remove_OnEnterWorld", MemberParameters = new object[] { "System.Action`1<Player>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.Hooks", Member = "remove_OnWorldGenConfigProcess", MemberParameters = new object[] { "Terraria.WorldGen.Hooks.WorldGenConfigProcessEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.Hooks", Member = "remove_OnWorldLoad", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Steam.CoreSocialModule", Member = "remove_OnTick", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Discord.DiscordHooks", Member = "UnRegisterFrom", MemberParameters = new object[] { "EventHandlers&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Discord.JoinRequestSocialModule", Member = "Shutdown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Base.ServerJoinRequestsManager", Member = "remove_OnRequestAdded", MemberParameters = new object[] { "Terraria.Social.Base.ServerJoinRequestEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Base.ServerJoinRequestsManager", Member = "remove_OnRequestRemoved", MemberParameters = new object[] { "Terraria.Social.Base.ServerJoinRequestEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Base.UserJoinToServerRequest", Member = "remove_OnAccepted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Base.UserJoinToServerRequest", Member = "remove_OnRejected", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Base.WorkshopIssueReporter", Member = "remove_OnNeedToOpenUI", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Base.WorkshopIssueReporter", Member = "remove_OnNeedToNotifyUI", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Server.Game", Member = "remove_Activated", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Server.Game", Member = "remove_Deactivated", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Server.Game", Member = "remove_Disposed", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Server.Game", Member = "remove_Exiting", MemberParameters = new object[] { "System.EventHandler`1<EventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LanguageManager", Member = "remove_OnLanguageChanging", MemberParameters = new object[] { "Terraria.Localization.LanguageChangeCallback" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LanguageManager", Member = "remove_OnLanguageChanged", MemberParameters = new object[] { "Terraria.Localization.LanguageChangeCallback" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.Preferences", Member = "remove_OnSave", MemberParameters = new object[] { "System.Action`1<Preferences>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.Preferences", Member = "remove_OnLoad", MemberParameters = new object[] { "System.Action`1<Preferences>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.Preferences", Member = "remove_OnProcessText", MemberParameters = new object[] { "Terraria.IO.Preferences.TextProcessAction" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "remove_OnWorldLoad", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.DataStructures.TileEntity", Member = "remove__UpdateStart", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.DataStructures.TileEntity", Member = "remove__UpdateEnd", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.Achievement", Member = "remove_OnCompleted", MemberParameters = new object[] { "Terraria.Achievements.Achievement.AchievementCompleted" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.AchievementCondition", Member = "remove_OnComplete", MemberParameters = new object[] { "Terraria.Achievements.AchievementCondition.AchievementUpdate" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.AchievementManager", Member = "remove_OnAchievementCompleted", MemberParameters = new object[] { "Terraria.Achievements.Achievement.AchievementCompleted" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameInput.PlayerInput", Member = "remove_OnBindingChange", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameInput.PlayerInput", Member = "remove_OnActionableInput", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.ItemSlot", Member = "remove_OnItemTransferred", MemberParameters = new object[] { "Terraria.UI.ItemSlot.ItemTransferEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "remove_OnLeftMouseDown", MemberParameters = new object[] { "Terraria.UI.UIElement.MouseEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "remove_OnLeftMouseUp", MemberParameters = new object[] { "Terraria.UI.UIElement.MouseEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "remove_OnLeftClick", MemberParameters = new object[] { "Terraria.UI.UIElement.MouseEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "remove_OnLeftDoubleClick", MemberParameters = new object[] { "Terraria.UI.UIElement.MouseEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "remove_OnRightMouseDown", MemberParameters = new object[] { "Terraria.UI.UIElement.MouseEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "remove_OnRightMouseUp", MemberParameters = new object[] { "Terraria.UI.UIElement.MouseEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "remove_OnRightClick", MemberParameters = new object[] { "Terraria.UI.UIElement.MouseEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "remove_OnRightDoubleClick", MemberParameters = new object[] { "Terraria.UI.UIElement.MouseEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "remove_OnMouseOver", MemberParameters = new object[] { "Terraria.UI.UIElement.MouseEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "remove_OnMouseOut", MemberParameters = new object[] { "Terraria.UI.UIElement.MouseEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "remove_OnScrollWheel", MemberParameters = new object[] { "Terraria.UI.UIElement.ScrollWheelEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.UI.UIElement", Member = "remove_OnUpdate", MemberParameters = new object[] { "Terraria.UI.UIElement.ElementEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Effects.FilterManager", Member = "remove_OnPostDraw", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Shaders.WaterShaderData", Member = "remove_OnWaveDraw", MemberParameters = new object[] { "System.Action`1<TileBatch>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Bestiary.NPCStatsReportInfoElement", Member = "remove_OnRefreshStats", MemberParameters = new object[] { "Terraria.GameContent.Bestiary.NPCStatsReportInfoElement.StatAdjustmentStep" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Achievements.AchievementsHelper", Member = "remove_OnItemPickup", MemberParameters = new object[] { "Terraria.GameContent.Achievements.AchievementsHelper.ItemPickupEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Achievements.AchievementsHelper", Member = "remove_OnItemCraft", MemberParameters = new object[] { "Terraria.GameContent.Achievements.AchievementsHelper.ItemCraftEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Achievements.AchievementsHelper", Member = "remove_OnTileDestroyed", MemberParameters = new object[] { "Terraria.GameContent.Achievements.AchievementsHelper.TileDestroyedEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Achievements.AchievementsHelper", Member = "remove_OnNPCKilled", MemberParameters = new object[] { "Terraria.GameContent.Achievements.AchievementsHelper.NPCKilledEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Achievements.AchievementsHelper", Member = "remove_OnProgressionEvent", MemberParameters = new object[] { "Terraria.GameContent.Achievements.AchievementsHelper.ProgressionEventEvent" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Liquid.LiquidRenderer", Member = "remove_WaveFilters", MemberParameters = new object[] { "System.Action`2<Color[], Rectangle>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIBestiaryEntryGrid", Member = "remove_OnGridContentsChanged", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIBestiarySortingOptionsGrid", Member = "remove_OnClickingOption", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIBestiaryFilteringOptionsGrid", Member = "remove_OnClickingOption", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UICreativeItemsInfiniteFilteringOptions", Member = "remove_OnClickingOption", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UISearchBar", Member = "remove_OnContentsChanged", MemberParameters = new object[] { "System.Action`1<String>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UISearchBar", Member = "remove_OnStartTakingInput", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UISearchBar", Member = "remove_OnEndTakingInput", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UISearchBar", Member = "remove_OnCanceledTakingInput", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UISearchBar", Member = "remove_OnNeedingVirtualKeyboard", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Elements.UIText", Member = "remove_OnInternalTextChange", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.RSAManaged), Member = "remove_KeyGenerated", MemberParameters = new object[] { typeof(Mono.Security.Cryptography.RSAManaged.KeyGeneratedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.DSAManaged), Member = "remove_KeyGenerated", MemberParameters = new object[] { typeof(Mono.Security.Cryptography.DSAManaged.KeyGeneratedEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "remove_DomainUnload", MemberParameters = new object[] { typeof(global::System.EventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "remove_UnhandledException", MemberParameters = new object[] { typeof(global::System.UnhandledExceptionEventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "remove_FirstChanceException", MemberParameters = new object[] { typeof(global::System.EventHandler<global::System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "remove_DownloadStringCompleted", MemberParameters = new object[] { "System.Net.DownloadStringCompletedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "remove_DownloadDataCompleted", MemberParameters = new object[] { "System.Net.DownloadDataCompletedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "remove_DownloadFileCompleted", MemberParameters = new object[] { "System.ComponentModel.AsyncCompletedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "remove_UploadStringCompleted", MemberParameters = new object[] { "System.Net.UploadStringCompletedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "remove_UploadDataCompleted", MemberParameters = new object[] { "System.Net.UploadDataCompletedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "remove_UploadFileCompleted", MemberParameters = new object[] { "System.Net.UploadFileCompletedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "remove_UploadValuesCompleted", MemberParameters = new object[] { "System.Net.UploadValuesCompletedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "remove_OpenReadCompleted", MemberParameters = new object[] { "System.Net.OpenReadCompletedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "remove_OpenWriteCompleted", MemberParameters = new object[] { "System.Net.OpenWriteCompletedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "remove_DownloadProgressChanged", MemberParameters = new object[] { "System.Net.DownloadProgressChangedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient", Member = "remove_UploadProgressChanged", MemberParameters = new object[] { "System.Net.UploadProgressChangedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.SocketAsyncEventArgs", Member = "remove_Completed", MemberParameters = new object[] { "System.EventHandler`1<SocketAsyncEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.BackgroundWorker", Member = "remove_DoWork", MemberParameters = new object[] { "System.ComponentModel.DoWorkEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.BackgroundWorker", Member = "remove_ProgressChanged", MemberParameters = new object[] { "System.ComponentModel.ProgressChangedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.BackgroundWorker", Member = "remove_RunWorkerCompleted", MemberParameters = new object[] { "System.ComponentModel.RunWorkerCompletedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EventHandlerList", Member = "RemoveHandler", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Delegate)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.BindingList`1", Member = "remove_AddingNew", MemberParameters = new object[] { "System.ComponentModel.AddingNewEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.BindingList`1", Member = "remove_ListChanged", MemberParameters = new object[] { "System.ComponentModel.ListChangedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.PropertyDescriptor", Member = "RemoveValueChanged", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.EventHandler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectEventDescriptor", Member = "RemoveEventHandler", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Delegate)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "remove_Refreshed", MemberParameters = new object[] { "System.ComponentModel.RefreshEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.PlayerAction", Member = "remove_OnLastInputTypeChanged", MemberParameters = new object[] { "System.Action`1<BindingSourceType>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.PlayerAction", Member = "remove_OnBindingsChanged", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.PlayerActionSet", Member = "remove_OnLastInputTypeChanged", MemberParameters = new object[] { "System.Action`1<BindingSourceType>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.PlayerOneAxisAction", Member = "remove_OnLastInputTypeChanged", MemberParameters = new object[] { "System.Action`1<BindingSourceType>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.PlayerTwoAxisAction", Member = "remove_OnLastInputTypeChanged", MemberParameters = new object[] { "System.Action`1<BindingSourceType>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Logger", Member = "remove_OnLogMessage", MemberParameters = new object[] { "System.Action`1<LogMessage>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputManager", Member = "remove_OnSetup", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputManager", Member = "remove_OnUpdate", MemberParameters = new object[] { "System.Action`2<UInt64, Single>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputManager", Member = "remove_OnReset", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputManager", Member = "remove_OnDeviceAttached", MemberParameters = new object[] { "System.Action`1<InputDevice>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputManager", Member = "remove_OnDeviceDetached", MemberParameters = new object[] { "System.Action`1<InputDevice>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputManager", Member = "remove_OnActiveDeviceChanged", MemberParameters = new object[] { "System.Action`1<InputDevice>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputManager", Member = "remove_OnUpdateDevices", MemberParameters = new object[] { "System.Action`2<UInt64, Single>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputManager", Member = "remove_OnCommitDevices", MemberParameters = new object[] { "System.Action`2<UInt64, Single>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "remove_OnSetup", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.JsonSerializer", Member = "remove_Error", MemberParameters = new object[] { "System.EventHandler`1<ErrorEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JContainer", Member = "remove_ListChanged", MemberParameters = new object[] { "System.ComponentModel.ListChangedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JContainer", Member = "remove_AddingNew", MemberParameters = new object[] { "System.ComponentModel.AddingNewEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "remove_PropertyChanged", MemberParameters = new object[] { "System.ComponentModel.PropertyChangedEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "remove_PropertyChanging", MemberParameters = new object[] { "System.ComponentModel.PropertyChangingEventHandler" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Application", Member = "remove_lowMemory", MemberParameters = new object[] { "UnityEngine.Application.LowMemoryCallback" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransform", Member = "remove_reapplyDrivenProperties", MemberParameters = new object[] { "UnityEngine.RectTransform.ReapplyDrivenProperties" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.U2D.SpriteAtlasManager", Member = "remove_atlasRegistered", MemberParameters = new object[] { "System.Action`1<SpriteAtlas>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SceneManagement.SceneManager", Member = "remove_sceneLoaded", MemberParameters = new object[] { "UnityEngine.Events.UnityAction`2<Scene, LoadSceneMode>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Events.InvokableCall", Member = "remove_Delegate", MemberParameters = new object[] { "UnityEngine.Events.UnityAction" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Events.InvokableCall`1", Member = "remove_Delegate", MemberParameters = new object[] { "UnityEngine.Events.UnityAction`1<T1>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "UnregisterDirtyLayoutCallback", MemberParameters = new object[] { "UnityEngine.Events.UnityAction" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "UnregisterDirtyVerticesCallback", MemberParameters = new object[] { "UnityEngine.Events.UnityAction" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "UnregisterDirtyMaterialCallback", MemberParameters = new object[] { "UnityEngine.Events.UnityAction" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "remove_SaveProgress", MemberParameters = new object[] { "System.EventHandler`1<SaveProgressEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "remove_ReadProgress", MemberParameters = new object[] { "System.EventHandler`1<ReadProgressEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "remove_ExtractProgress", MemberParameters = new object[] { "System.EventHandler`1<ExtractProgressEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "remove_AddProgress", MemberParameters = new object[] { "System.EventHandler`1<AddProgressEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "remove_ZipError", MemberParameters = new object[] { "System.EventHandler`1<ZipErrorEventArgs>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Android.PermissionCallbacks", Member = "remove_PermissionGranted", MemberParameters = new object[] { "System.Action`1<String>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Android.PermissionCallbacks", Member = "remove_PermissionDenied", MemberParameters = new object[] { "System.Action`1<String>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Android.PermissionCallbacks", Member = "remove_PermissionDeniedAndDontAskAgain", MemberParameters = new object[] { "System.Action`1<String>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Canvas", Member = "remove_preWillRenderCanvases", MemberParameters = new object[] { "UnityEngine.Canvas.WillRenderCanvases" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Canvas", Member = "remove_willRenderCanvases", MemberParameters = new object[] { "UnityEngine.Canvas.WillRenderCanvases" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Font", Member = "remove_textureRebuilt", MemberParameters = new object[] { "System.Action`1<Font>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 167)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static global::System.Delegate Remove(global::System.Delegate source, global::System.Delegate value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EDD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7D458", Offset = "0x1C7D458", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual global::System.Delegate RemoveImpl(global::System.Delegate d)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7D47C", Offset = "0x1C7D47C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.DataStructures.PlacementHook", Member = "op_Equality", MemberParameters = new object[] { "Terraria.DataStructures.PlacementHook", "Terraria.DataStructures.PlacementHook" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.DataStructures.PlacementHook", Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool operator ==(global::System.Delegate d1, global::System.Delegate d2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EDF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7D4A4", Offset = "0x1C7D4A4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.DataStructures.PlacementHook", Member = "op_Inequality", MemberParameters = new object[] { "Terraria.DataStructures.PlacementHook", "Terraria.DataStructures.PlacementHook" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Biomes.MarbleBiome.Slab", Member = "get_IsSolid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SslStream", Member = "SetAndVerifyValidationCallback", MemberParameters = new object[] { "System.Net.Security.RemoteCertificateValidationCallback" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SslStream", Member = "SetAndVerifySelectionCallback", MemberParameters = new object[] { "System.Net.Security.LocalCertificateSelectionCallback" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static bool operator !=(global::System.Delegate d1, global::System.Delegate d2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7D4DC", Offset = "0x1C7D4DC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern global::System.MulticastDelegate AllocDelegateLike_internal(global::System.Delegate d);

		[global::Cpp2ILInjected.Token(Token = "0x400065C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.IntPtr method_ptr;

		[global::Cpp2ILInjected.Token(Token = "0x400065D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.IntPtr invoke_impl;

		[global::Cpp2ILInjected.Token(Token = "0x400065E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object m_target;

		[global::Cpp2ILInjected.Token(Token = "0x400065F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.IntPtr method;

		[global::Cpp2ILInjected.Token(Token = "0x4000660")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private global::System.IntPtr delegate_trampoline;

		[global::Cpp2ILInjected.Token(Token = "0x4000661")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::System.IntPtr extra_arg;

		[global::Cpp2ILInjected.Token(Token = "0x4000662")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private global::System.IntPtr method_code;

		[global::Cpp2ILInjected.Token(Token = "0x4000663")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private global::System.IntPtr interp_method;

		[global::Cpp2ILInjected.Token(Token = "0x4000664")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private global::System.IntPtr interp_invoke_impl;

		[global::Cpp2ILInjected.Token(Token = "0x4000665")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private global::System.Reflection.MethodInfo method_info;

		[global::Cpp2ILInjected.Token(Token = "0x4000666")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private global::System.Reflection.MethodInfo original_method_info;

		[global::Cpp2ILInjected.Token(Token = "0x4000667")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private global::System.DelegateData data;

		[global::Cpp2ILInjected.Token(Token = "0x4000668")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private bool method_is_virtual;
	}
}
