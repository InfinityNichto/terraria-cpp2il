﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x2000181")]
	internal static class MonoCustomAttrs
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000F0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DED8", Offset = "0x1C7DED8", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributesBase", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributesDataBase", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Collections.Generic.IList<global::System.Reflection.CustomAttributeData>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static bool IsUserCattrProvider(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7E094", Offset = "0x1C7E094", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern global::System.Attribute[] GetCustomAttributesInternal(global::System.Reflection.ICustomAttributeProvider obj, global::System.Type attributeType, bool pseudoAttrs);

		[global::Cpp2ILInjected.Token(Token = "0x6000F0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7E09C", Offset = "0x1C7E09C", Length = "0x2B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributesBase", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeParameterInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		internal static object[] GetPseudoCustomAttributes(global::System.Reflection.ICustomAttributeProvider obj, global::System.Type attributeType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F10")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7E34C", Offset = "0x1C7E34C", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_Attributes", ReturnType = typeof(global::System.Reflection.TypeAttributes))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SerializableAttribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.ComImportAttribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static object[] GetPseudoCustomAttributes(global::System.Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7E488", Offset = "0x1C7E488", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "IsUserCattrProvider", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static object[] GetCustomAttributesBase(global::System.Reflection.ICustomAttributeProvider obj, global::System.Type attributeType, bool inheritedOnly)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F12")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7E620", Offset = "0x1C7E620", Length = "0x938")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "InternalGetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.PropertyInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "InternalGetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.EventInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "RetrieveAttributeUsageNoCache", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.AttributeUsageAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeAssembly), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeEventInfo), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeFieldInfo), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeConstructorInfo), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeModule), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeParameterInfo), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimePropertyInfo), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributesBase", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetBase", MemberParameters = new object[] { typeof(global::System.Reflection.ICustomAttributeProvider) }, ReturnType = typeof(global::System.Reflection.ICustomAttributeProvider))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsSealed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "RetrieveAttributeUsage", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.AttributeUsageAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.CustomAttributeFormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 61)]
		internal static object[] GetCustomAttributes(global::System.Reflection.ICustomAttributeProvider obj, global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F13")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7F460", Offset = "0x1C7F460", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeAssembly), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeEventInfo), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeFieldInfo), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeConstructorInfo), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeModule), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeParameterInfo), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimePropertyInfo), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributesBase", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal static object[] GetCustomAttributes(global::System.Reflection.ICustomAttributeProvider obj, bool inherit)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F14")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7F5CC", Offset = "0x1C7F5CC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern global::System.Reflection.CustomAttributeData[] GetCustomAttributesDataInternal(global::System.Reflection.ICustomAttributeProvider obj);

		[global::Cpp2ILInjected.Token(Token = "0x6000F15")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7F5D0", Offset = "0x1C7F5D0", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.CustomAttributeData), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(global::System.Reflection.Assembly) }, ReturnType = typeof(global::System.Collections.Generic.IList<global::System.Reflection.CustomAttributeData>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.CustomAttributeData), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(global::System.Reflection.MemberInfo) }, ReturnType = typeof(global::System.Collections.Generic.IList<global::System.Reflection.CustomAttributeData>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.CustomAttributeData), Member = "GetCustomAttributesInternal", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(global::System.Collections.Generic.IList<global::System.Reflection.CustomAttributeData>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.CustomAttributeData), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(global::System.Reflection.Module) }, ReturnType = typeof(global::System.Collections.Generic.IList<global::System.Reflection.CustomAttributeData>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.CustomAttributeData), Member = "GetCustomAttributes", MemberParameters = new object[] { typeof(global::System.Reflection.ParameterInfo) }, ReturnType = typeof(global::System.Collections.Generic.IList<global::System.Reflection.CustomAttributeData>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Collections.Generic.IList<global::System.Reflection.CustomAttributeData>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal static global::System.Collections.Generic.IList<global::System.Reflection.CustomAttributeData> GetCustomAttributesData(global::System.Reflection.ICustomAttributeProvider obj, bool inherit = false)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F16")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7F89C", Offset = "0x1C7F89C", Length = "0x125C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(bool)
		}, ReturnType = typeof(global::System.Collections.Generic.IList<global::System.Reflection.CustomAttributeData>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributesDataBase", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Collections.Generic.IList<global::System.Reflection.CustomAttributeData>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetBase", MemberParameters = new object[] { typeof(global::System.Reflection.ICustomAttributeProvider) }, ReturnType = typeof(global::System.Reflection.ICustomAttributeProvider))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsSealed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "RetrieveAttributeUsage", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.AttributeUsageAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.CustomAttributeData), Member = "get_AttributeType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.CustomAttributeFormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 108)]
		internal static global::System.Collections.Generic.IList<global::System.Reflection.CustomAttributeData> GetCustomAttributesData(global::System.Reflection.ICustomAttributeProvider obj, global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F17")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7F6F8", Offset = "0x1C7F6F8", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Collections.Generic.IList<global::System.Reflection.CustomAttributeData>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "IsUserCattrProvider", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type)
		}, ReturnType = typeof(global::System.Reflection.CustomAttributeData[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array[]), Member = "AsReadOnly", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(object[]) }, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal static global::System.Collections.Generic.IList<global::System.Reflection.CustomAttributeData> GetCustomAttributesDataBase(global::System.Reflection.ICustomAttributeProvider obj, global::System.Type attributeType, bool inheritedOnly)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C80AF8", Offset = "0x1C80AF8", Length = "0x2B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributesDataBase", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Collections.Generic.IList<global::System.Reflection.CustomAttributeData>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(global::System.Reflection.CustomAttributeData[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(global::System.Reflection.CustomAttributeData[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeParameterInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(global::System.Reflection.CustomAttributeData[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Reflection.CustomAttributeData[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.CustomAttributeData), Member = "get_AttributeType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal static global::System.Reflection.CustomAttributeData[] GetPseudoCustomAttributesData(global::System.Reflection.ICustomAttributeProvider obj, global::System.Type attributeType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C80DAC", Offset = "0x1C80DAC", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type)
		}, ReturnType = typeof(global::System.Reflection.CustomAttributeData[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_Attributes", ReturnType = typeof(global::System.Reflection.TypeAttributes))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetConstructor", MemberParameters = new object[] { typeof(global::System.Type[]) }, ReturnType = typeof(global::System.Reflection.ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.CustomAttributeData), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Reflection.ConstructorInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static global::System.Reflection.CustomAttributeData[] GetPseudoCustomAttributesData(global::System.Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C80F98", Offset = "0x1C80F98", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "InternalIsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.PropertyInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "InternalIsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.EventInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeAssembly), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeEventInfo), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeFieldInfo), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeConstructorInfo), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeModule), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeParameterInfo), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimePropertyInfo), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "IsUserCattrProvider", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "RetrieveAttributeUsage", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.AttributeUsageAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetBase", MemberParameters = new object[] { typeof(global::System.Reflection.ICustomAttributeProvider) }, ReturnType = typeof(global::System.Reflection.ICustomAttributeProvider))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		internal static bool IsDefined(global::System.Reflection.ICustomAttributeProvider obj, global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8120C", Offset = "0x1C8120C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern bool IsDefinedInternal(global::System.Reflection.ICustomAttributeProvider obj, global::System.Type AttributeType);

		[global::Cpp2ILInjected.Token(Token = "0x6000F1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C81210", Offset = "0x1C81210", Length = "0x2A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetBase", MemberParameters = new object[] { typeof(global::System.Reflection.ICustomAttributeProvider) }, ReturnType = typeof(global::System.Reflection.ICustomAttributeProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "get_IsVirtual", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "GetBaseMethod", ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetProperty", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetProperty", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static global::System.Reflection.PropertyInfo GetBasePropertyDefinition(global::System.Reflection.RuntimePropertyInfo property)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C814B8", Offset = "0x1C814B8", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetBase", MemberParameters = new object[] { typeof(global::System.Reflection.ICustomAttributeProvider) }, ReturnType = typeof(global::System.Reflection.ICustomAttributeProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "get_IsVirtual", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "GetBaseMethod", ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static global::System.Reflection.EventInfo GetBaseEventDefinition(global::System.Reflection.RuntimeEventInfo evt)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7EF58", Offset = "0x1C7EF58", Length = "0x398")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Collections.Generic.IList<global::System.Reflection.CustomAttributeData>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "get_IsVirtual", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "GetBaseMethod", ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetBaseEventDefinition", MemberParameters = new object[] { typeof(global::System.Reflection.RuntimeEventInfo) }, ReturnType = typeof(global::System.Reflection.EventInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetBasePropertyDefinition", MemberParameters = new object[] { typeof(global::System.Reflection.RuntimePropertyInfo) }, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static global::System.Reflection.ICustomAttributeProvider GetBase(global::System.Reflection.ICustomAttributeProvider obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C816B4", Offset = "0x1C816B4", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "RetrieveAttributeUsage", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.AttributeUsageAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AttributeUsageAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.AttributeTargets) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "RetrieveAttributeUsage", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.AttributeUsageAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private static global::System.AttributeUsageAttribute RetrieveAttributeUsageNoCache(global::System.Type attributeType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000F20")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7F2F0", Offset = "0x1C7F2F0", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Collections.Generic.IList<global::System.Reflection.CustomAttributeData>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "RetrieveAttributeUsageNoCache", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.AttributeUsageAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "RetrieveAttributeUsageNoCache", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.AttributeUsageAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static global::System.AttributeUsageAttribute RetrieveAttributeUsage(global::System.Type attributeType)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000F21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C818DC", Offset = "0x1C818DC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.AttributeUsageAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.AttributeTargets) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static MonoCustomAttrs()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000683")]
		private static global::System.Reflection.Assembly corlib;

		[global::System.ThreadStatic]
		[global::Cpp2ILInjected.Token(Token = "0x4000684")]
		private static global::System.Collections.Generic.Dictionary<global::System.Type, global::System.AttributeUsageAttribute> usage_cache;

		[global::Cpp2ILInjected.Token(Token = "0x4000685")]
		private static readonly global::System.AttributeUsageAttribute DefaultAttributeUsage;

		[global::Cpp2ILInjected.Token(Token = "0x2000182")]
		private class AttributeInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F22")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7F454", Offset = "0x1C7F454", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public AttributeInfo(global::System.AttributeUsageAttribute usage, int inheritanceLevel)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700015D")]
			public global::System.AttributeUsageAttribute Usage
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000F23")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C81950", Offset = "0x1C81950", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700015E")]
			public int InheritanceLevel
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000F24")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C81958", Offset = "0x1C81958", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000686")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private global::System.AttributeUsageAttribute _usage;

			[global::Cpp2ILInjected.Token(Token = "0x4000687")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _inheritanceLevel;
		}
	}
}
