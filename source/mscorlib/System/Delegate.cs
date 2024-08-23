using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200012B RID: 299
	[global::Cpp2ILInjected.Token(Token = "0x2000170")]
	[global::System.Serializable]
	[StructLayout(0)]
	public abstract class Delegate : global::System.ICloneable, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x00016C8B File Offset: 0x00014E8B
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

		// Token: 0x06000DDC RID: 3548
		[global::Cpp2ILInjected.Token(Token = "0x6000EC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7BBD0", Offset = "0x1C7BBD0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern global::System.Reflection.MethodInfo GetVirtualMethod_internal();

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x00016C8E File Offset: 0x00014E8E
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

		// Token: 0x06000DDE RID: 3550
		[global::Cpp2ILInjected.Token(Token = "0x6000EC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7BBDC", Offset = "0x1C7BBDC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern global::System.Delegate CreateDelegate_internal(global::System.Type type, object target, global::System.Reflection.MethodInfo info, bool throwOnBindFailure);

		// Token: 0x06000DDF RID: 3551 RVA: 0x00016C91 File Offset: 0x00014E91
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

		// Token: 0x06000DE0 RID: 3552 RVA: 0x00016C94 File Offset: 0x00014E94
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

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00016C97 File Offset: 0x00014E97
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

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00016C9A File Offset: 0x00014E9A
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

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00016C9D File Offset: 0x00014E9D
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

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00016CA0 File Offset: 0x00014EA0
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

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00016CA3 File Offset: 0x00014EA3
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

		// Token: 0x06000DE6 RID: 3558 RVA: 0x00016CA6 File Offset: 0x00014EA6
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

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00016CA9 File Offset: 0x00014EA9
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

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00016CAC File Offset: 0x00014EAC
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

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00016CAF File Offset: 0x00014EAF
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

		// Token: 0x06000DEA RID: 3562 RVA: 0x00016CB2 File Offset: 0x00014EB2
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

		// Token: 0x06000DEB RID: 3563 RVA: 0x00016CB5 File Offset: 0x00014EB5
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

		// Token: 0x06000DEC RID: 3564 RVA: 0x00016CB8 File Offset: 0x00014EB8
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

		// Token: 0x06000DED RID: 3565 RVA: 0x00016CBB File Offset: 0x00014EBB
		[global::Cpp2ILInjected.Token(Token = "0x6000ED3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7CE04", Offset = "0x1C7CE04", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual object Clone()
		{
			throw null;
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00016CBE File Offset: 0x00014EBE
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

		// Token: 0x06000DEF RID: 3567 RVA: 0x00016CC1 File Offset: 0x00014EC1
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

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00016CC4 File Offset: 0x00014EC4
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

		// Token: 0x06000DF1 RID: 3569 RVA: 0x00016CC7 File Offset: 0x00014EC7
		[global::Cpp2ILInjected.Token(Token = "0x6000ED7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7D114", Offset = "0x1C7D114", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00016CCA File Offset: 0x00014ECA
		[global::Cpp2ILInjected.Token(Token = "0x6000ED8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7D334", Offset = "0x1C7D334", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual global::System.Delegate[] GetInvocationList()
		{
			throw null;
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00016CCD File Offset: 0x00014ECD
		[global::Cpp2ILInjected.Token(Token = "0x6000ED9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C78294", Offset = "0x1C78294", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00016CD0 File Offset: 0x00014ED0
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

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00016CD3 File Offset: 0x00014ED3
		[global::Cpp2ILInjected.Token(Token = "0x6000EDB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7D404", Offset = "0x1C7D404", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MulticastNotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected virtual global::System.Delegate CombineImpl(global::System.Delegate d)
		{
			throw null;
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00016CD6 File Offset: 0x00014ED6
		[global::Cpp2ILInjected.Token(Token = "0x6000EDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C78478", Offset = "0x1C78478", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00016CD9 File Offset: 0x00014ED9
		[global::Cpp2ILInjected.Token(Token = "0x6000EDD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7D458", Offset = "0x1C7D458", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual global::System.Delegate RemoveImpl(global::System.Delegate d)
		{
			throw null;
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00016CDC File Offset: 0x00014EDC
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

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00016CDF File Offset: 0x00014EDF
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

		// Token: 0x06000DFA RID: 3578
		[global::Cpp2ILInjected.Token(Token = "0x6000EE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7D4DC", Offset = "0x1C7D4DC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern global::System.MulticastDelegate AllocDelegateLike_internal(global::System.Delegate d);

		// Token: 0x04000494 RID: 1172
		[global::Cpp2ILInjected.Token(Token = "0x400065C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.IntPtr method_ptr;

		// Token: 0x04000495 RID: 1173
		[global::Cpp2ILInjected.Token(Token = "0x400065D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.IntPtr invoke_impl;

		// Token: 0x04000496 RID: 1174
		[global::Cpp2ILInjected.Token(Token = "0x400065E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object m_target;

		// Token: 0x04000497 RID: 1175
		[global::Cpp2ILInjected.Token(Token = "0x400065F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.IntPtr method;

		// Token: 0x04000498 RID: 1176
		[global::Cpp2ILInjected.Token(Token = "0x4000660")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private global::System.IntPtr delegate_trampoline;

		// Token: 0x04000499 RID: 1177
		[global::Cpp2ILInjected.Token(Token = "0x4000661")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::System.IntPtr extra_arg;

		// Token: 0x0400049A RID: 1178
		[global::Cpp2ILInjected.Token(Token = "0x4000662")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private global::System.IntPtr method_code;

		// Token: 0x0400049B RID: 1179
		[global::Cpp2ILInjected.Token(Token = "0x4000663")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private global::System.IntPtr interp_method;

		// Token: 0x0400049C RID: 1180
		[global::Cpp2ILInjected.Token(Token = "0x4000664")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private global::System.IntPtr interp_invoke_impl;

		// Token: 0x0400049D RID: 1181
		[global::Cpp2ILInjected.Token(Token = "0x4000665")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private global::System.Reflection.MethodInfo method_info;

		// Token: 0x0400049E RID: 1182
		[global::Cpp2ILInjected.Token(Token = "0x4000666")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private global::System.Reflection.MethodInfo original_method_info;

		// Token: 0x0400049F RID: 1183
		[global::Cpp2ILInjected.Token(Token = "0x4000667")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private global::System.DelegateData data;

		// Token: 0x040004A0 RID: 1184
		[global::Cpp2ILInjected.Token(Token = "0x4000668")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private bool method_is_virtual;
	}
}
