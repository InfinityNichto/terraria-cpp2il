using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Remoting;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200010D RID: 269
	[global::System.AttributeUsage(global::System.AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000145")]
	[global::System.Serializable]
	public abstract class Attribute
	{
		// Token: 0x06000C03 RID: 3075 RVA: 0x000167DE File Offset: 0x000149DE
		[global::Cpp2ILInjected.Token(Token = "0x6000CD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5E194", Offset = "0x1C5E194", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static global::System.Attribute[] InternalGetCustomAttributes(global::System.Reflection.PropertyInfo element, global::System.Type type, bool inherit)
		{
			throw null;
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x000167E1 File Offset: 0x000149E1
		[global::Cpp2ILInjected.Token(Token = "0x6000CD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5E240", Offset = "0x1C5E240", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static global::System.Attribute[] InternalGetCustomAttributes(global::System.Reflection.EventInfo element, global::System.Type type, bool inherit)
		{
			throw null;
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x000167E4 File Offset: 0x000149E4
		[global::Cpp2ILInjected.Token(Token = "0x6000CD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5E2EC", Offset = "0x1C5E2EC", Length = "0x4E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ParameterInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ParameterInfo),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "GetBaseMethod", ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(int)
		}, ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private static global::System.Attribute[] InternalParamGetCustomAttributes(global::System.Reflection.ParameterInfo parameter, global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x000167E7 File Offset: 0x000149E7
		[global::Cpp2ILInjected.Token(Token = "0x6000CD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5E7D0", Offset = "0x1C5E7D0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool InternalIsDefined(global::System.Reflection.PropertyInfo element, global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x000167EA File Offset: 0x000149EA
		[global::Cpp2ILInjected.Token(Token = "0x6000CD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5E840", Offset = "0x1C5E840", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool InternalIsDefined(global::System.Reflection.EventInfo element, global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x000167ED File Offset: 0x000149ED
		[global::Cpp2ILInjected.Token(Token = "0x6000CD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5E8B0", Offset = "0x1C5E8B0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.CustomAttributeExtensions), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Type)
		}, ReturnType = typeof(global::System.Collections.Generic.IEnumerable<global::System.Attribute>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static global::System.Attribute[] GetCustomAttributes(global::System.Reflection.MemberInfo element, global::System.Type type)
		{
			throw null;
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x000167F0 File Offset: 0x000149F0
		[global::Cpp2ILInjected.Token(Token = "0x6000CD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5E8B8", Offset = "0x1C5E8B8", Length = "0x2E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "GetCustomAttribute", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = "System.Attribute[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MemberInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Reflection.MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = "InternalGetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.PropertyInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = "InternalGetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.EventInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public static global::System.Attribute[] GetCustomAttributes(global::System.Reflection.MemberInfo element, global::System.Type type, bool inherit)
		{
			throw null;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x000167F3 File Offset: 0x000149F3
		[global::Cpp2ILInjected.Token(Token = "0x6000CD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5EBA0", Offset = "0x1C5EBA0", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = "System.Attribute[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MemberInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Reflection.MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = "InternalGetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.PropertyInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = "InternalGetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.EventInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static global::System.Attribute[] GetCustomAttributes(global::System.Reflection.MemberInfo element, bool inherit)
		{
			throw null;
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x000167F6 File Offset: 0x000149F6
		[global::Cpp2ILInjected.Token(Token = "0x6000CD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5EDD8", Offset = "0x1C5EDD8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.CustomAttributeExtensions), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.AttributeHelperEngine", Member = "GetParentTypeDisallowingMultipleInclusion", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static bool IsDefined(global::System.Reflection.MemberInfo element, global::System.Type attributeType)
		{
			throw null;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x000167F9 File Offset: 0x000149F9
		[global::Cpp2ILInjected.Token(Token = "0x6000CDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5EDE0", Offset = "0x1C5EDE0", Length = "0x2C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MemberInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Reflection.MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = "InternalIsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.PropertyInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = "InternalIsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.EventInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static bool IsDefined(global::System.Reflection.MemberInfo element, global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x000167FC File Offset: 0x000149FC
		[global::Cpp2ILInjected.Token(Token = "0x6000CDB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5F0A8", Offset = "0x1C5F0A8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "Unmarshal", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.ObjRef),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "CreateClientProxyForContextBound", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.LicenseManager", Member = "ValidateInternalRecursive", MemberParameters = new object[]
		{
			"System.ComponentModel.LicenseContext",
			typeof(global::System.Type),
			typeof(object),
			typeof(bool),
			"System.ComponentModel.License&",
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AmbiguousMatchException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static global::System.Attribute GetCustomAttribute(global::System.Reflection.MemberInfo element, global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x000167FF File Offset: 0x000149FF
		[global::Cpp2ILInjected.Token(Token = "0x6000CDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5F134", Offset = "0x1C5F134", Length = "0x2A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = "System.Attribute[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MemberInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Reflection.MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = "InternalParamGetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ParameterInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public static global::System.Attribute[] GetCustomAttributes(global::System.Reflection.ParameterInfo element, global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00016802 File Offset: 0x00014A02
		[global::Cpp2ILInjected.Token(Token = "0x6000CDD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5F3DC", Offset = "0x1C5F3DC", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = "System.Attribute[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MemberInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Reflection.MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = "InternalParamGetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ParameterInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static global::System.Attribute[] GetCustomAttributes(global::System.Reflection.ParameterInfo element, bool inherit)
		{
			throw null;
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00016805 File Offset: 0x00014A05
		[global::Cpp2ILInjected.Token(Token = "0x6000CDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5F5A4", Offset = "0x1C5F5A4", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = "System.Attribute[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Module), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Module),
			typeof(global::System.Reflection.Module)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static global::System.Attribute[] GetCustomAttributes(global::System.Reflection.Module element, bool inherit)
		{
			throw null;
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00016808 File Offset: 0x00014A08
		[global::Cpp2ILInjected.Token(Token = "0x6000CDF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5F6F8", Offset = "0x1C5F6F8", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = "System.Attribute[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Module), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Module),
			typeof(global::System.Reflection.Module)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public static global::System.Attribute[] GetCustomAttributes(global::System.Reflection.Module element, global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0001680B File Offset: 0x00014A0B
		[global::Cpp2ILInjected.Token(Token = "0x6000CE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5F93C", Offset = "0x1C5F93C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = "System.Attribute[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static global::System.Attribute[] GetCustomAttributes(global::System.Reflection.Assembly element, global::System.Type attributeType)
		{
			throw null;
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0001680E File Offset: 0x00014A0E
		[global::Cpp2ILInjected.Token(Token = "0x6000CE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5F944", Offset = "0x1C5F944", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "GetCustomAttribute", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public static global::System.Attribute[] GetCustomAttributes(global::System.Reflection.Assembly element, global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00016811 File Offset: 0x00014A11
		[global::Cpp2ILInjected.Token(Token = "0x6000CE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5FB64", Offset = "0x1C5FB64", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = "System.Attribute[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static global::System.Attribute[] GetCustomAttributes(global::System.Reflection.Assembly element)
		{
			throw null;
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00016814 File Offset: 0x00014A14
		[global::Cpp2ILInjected.Token(Token = "0x6000CE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5FB6C", Offset = "0x1C5FB6C", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static global::System.Attribute[] GetCustomAttributes(global::System.Reflection.Assembly element, bool inherit)
		{
			throw null;
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x00016817 File Offset: 0x00014A17
		[global::Cpp2ILInjected.Token(Token = "0x6000CE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5FC94", Offset = "0x1C5FC94", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.CustomAttributeExtensions), Member = "GetCustomAttribute", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Type)
		}, ReturnType = typeof(global::System.Attribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static global::System.Attribute GetCustomAttribute(global::System.Reflection.Assembly element, global::System.Type attributeType)
		{
			throw null;
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0001681A File Offset: 0x00014A1A
		[global::Cpp2ILInjected.Token(Token = "0x6000CE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5FC9C", Offset = "0x1C5FC9C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AmbiguousMatchException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static global::System.Attribute GetCustomAttribute(global::System.Reflection.Assembly element, global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0001681D File Offset: 0x00014A1D
		[global::Cpp2ILInjected.Token(Token = "0x6000CE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5C2B4", Offset = "0x1C5C2B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 422)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected Attribute()
		{
			throw null;
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00016820 File Offset: 0x00014A20
		[global::Cpp2ILInjected.Token(Token = "0x6000CE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5FD28", Offset = "0x1C5FD28", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = "AreFieldValuesEqual", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00016823 File Offset: 0x00014A23
		[global::Cpp2ILInjected.Token(Token = "0x6000CE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5FF40", Offset = "0x1C5FF40", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "AreFieldValuesEqual", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsArray", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = "AreFieldValuesEqual", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static bool AreFieldValuesEqual(object thisValue, object thatValue)
		{
			throw null;
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00016826 File Offset: 0x00014A26
		[global::Cpp2ILInjected.Token(Token = "0x6000CE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C60100", Offset = "0x1C60100", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsArray", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x00016829 File Offset: 0x00014A29
		[global::Cpp2ILInjected.Token(Token = "0x1700011E")]
		public virtual object TypeId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CEA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C60214", Offset = "0x1C60214", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0001682C File Offset: 0x00014A2C
		[global::Cpp2ILInjected.Token(Token = "0x6000CEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6021C", Offset = "0x1C6021C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual bool Match(object obj)
		{
			throw null;
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0001682F File Offset: 0x00014A2F
		[global::Cpp2ILInjected.Token(Token = "0x6000CEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C60228", Offset = "0x1C60228", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual bool IsDefaultAttribute()
		{
			throw null;
		}
	}
}
