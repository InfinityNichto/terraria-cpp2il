using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200005F RID: 95
	[global::Cpp2ILInjected.Token(Token = "0x2000084")]
	[global::System.Serializable]
	public class ArgumentNullException : global::System.ArgumentException
	{
		// Token: 0x0600033D RID: 829 RVA: 0x00014EE8 File Offset: 0x000130E8
		[global::Cpp2ILInjected.Token(Token = "0x60003CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB5DFC", Offset = "0x1BB5DFC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "SanityCheckGenericArguments", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType[]),
			typeof(global::System.RuntimeType[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetPropertyImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEvent", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.EventInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetField", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.FieldInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetNestedType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMember", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.MemberTypes),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.MemberInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "MakeGenericType", MemberParameters = new object[] { typeof(global::System.Type[]) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskToApm), Member = "End", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskToApm), Member = "End", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.RemotingSurrogate), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ObjRefSurrogate), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "MakeGenericMethod", MemberParameters = new object[] { typeof(global::System.Type[]) }, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.RegionInfo), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListener", Member = "set_ExtendedProtectionSelectorDelegate", MemberParameters = new object[] { "System.Net.HttpListener.ExtendedProtectionSelector" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ArgumentNullException()
		{
			throw null;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00014EEB File Offset: 0x000130EB
		[global::Cpp2ILInjected.Token(Token = "0x60003CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAEEE4", Offset = "0x1BAEEE4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1181)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ArgumentNullException(string paramName)
		{
			throw null;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00014EEE File Offset: 0x000130EE
		[global::Cpp2ILInjected.Token(Token = "0x60003D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB5E58", Offset = "0x1BB5E58", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 164)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public ArgumentNullException(string paramName, string message)
		{
			throw null;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00014EF1 File Offset: 0x000130F1
		[global::Cpp2ILInjected.Token(Token = "0x60003D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB5E90", Offset = "0x1BB5E90", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected ArgumentNullException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
