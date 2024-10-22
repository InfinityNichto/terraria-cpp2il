﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x2000158")]
	[global::System.Serializable]
	[StructLayout(0)]
	internal class RuntimeType : global::System.Reflection.TypeInfo, global::System.Runtime.Serialization.ISerializable, global::System.ICloneable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6B120", Offset = "0x1C6B120", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "GetType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "GetType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "GetType", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypeSpec), Member = "Resolve", MemberParameters = new object[]
		{
			typeof(global::System.Func<global::System.Reflection.AssemblyName, global::System.Reflection.Assembly>),
			typeof(global::System.Func<global::System.Reflection.Assembly, string, bool, global::System.Type>),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "GetTypeByName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static global::System.RuntimeType GetType(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref global::System.Threading.StackCrawlMark stackMark)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6B188", Offset = "0x1C6B188", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "SanityCheckGenericArguments", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType[]),
			typeof(global::System.RuntimeType[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsPointer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static void ThrowIfTypeNeverValidGenericArgument(global::System.RuntimeType type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6B2C0", Offset = "0x1C6B2C0", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "MakeGenericType", MemberParameters = new object[] { typeof(global::System.Type[]) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "ThrowIfTypeNeverValidGenericArgument", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal static void SanityCheckGenericArguments(global::System.RuntimeType[] genericArguments, global::System.RuntimeType[] genericParamters)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6B47C", Offset = "0x1C6B47C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Type>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetNestedType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void SplitName(string fullname, out string name, out string ns)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6B560", Offset = "0x1C6B560", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeEventInfo), Member = "GetBindingFlags", ReturnType = typeof(global::System.Reflection.BindingFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static global::System.Reflection.BindingFlags FilterPreCalculate(bool isPublic, bool isInherited, bool isStatic)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6B59C", Offset = "0x1C6B59C", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "FilterHelper", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(ref string),
			typeof(ref bool),
			typeof(ref global::System.RuntimeType.MemberListType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.MethodInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.ConstructorInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Type[]),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.PropertyInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEventCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.EventInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetFieldCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.FieldInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Type>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.MethodInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new object[] { typeof(global::System.Globalization.CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void FilterHelper(global::System.Reflection.BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out global::System.RuntimeType.MemberListType listType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6B6B0", Offset = "0x1C6B6B0", Length = "0x8C")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterHelper", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(ref string),
			typeof(bool),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref global::System.RuntimeType.MemberListType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void FilterHelper(global::System.Reflection.BindingFlags bindingFlags, ref string name, out bool ignoreCase, out global::System.RuntimeType.MemberListType listType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6B73C", Offset = "0x1C6B73C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "FilterApplyBase", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.MethodInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.ConstructorInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Type[]),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.PropertyInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEventCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.EventInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetFieldCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.FieldInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.MethodInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		private static bool FilterApplyPrefixLookup(global::System.Reflection.MemberInfo memberInfo, string name, bool ignoreCase)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6B794", Offset = "0x1C6B794", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "FilterApplyType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Reflection.BindingFlags),
			typeof(string),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterApplyPrefixLookup", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "get_IsVirtual", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "get_IsAbstract", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool FilterApplyBase(global::System.Reflection.MemberInfo memberInfo, global::System.Reflection.BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D98")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6B960", Offset = "0x1C6B960", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Type>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetNestedType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsNestedPublic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsNestedAssembly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterApplyBase", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool FilterApplyType(global::System.Type type, global::System.Reflection.BindingFlags bindingFlags, string name, bool prefixLookup, string ns)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6BA70", Offset = "0x1C6BA70", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.MethodInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "InvokeMember", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object),
			typeof(object[]),
			typeof(global::System.Reflection.ParameterModifier[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(string[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.MethodInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "get_BindingFlags", ReturnType = typeof(global::System.Reflection.BindingFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool FilterApplyMethodInfo(global::System.Reflection.RuntimeMethodInfo method, global::System.Reflection.BindingFlags bindingFlags, global::System.Reflection.CallingConventions callConv, global::System.Type[] argumentTypes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6BD00", Offset = "0x1C6BD00", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.ConstructorInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(object[]),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeConstructorInfo), Member = "get_BindingFlags", ReturnType = typeof(global::System.Reflection.BindingFlags))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterApplyMethodBase", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool FilterApplyConstructorInfo(global::System.Reflection.RuntimeConstructorInfo constructor, global::System.Reflection.BindingFlags bindingFlags, global::System.Reflection.CallingConventions callConv, global::System.Type[] argumentTypes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6BAF8", Offset = "0x1C6BAF8", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "FilterApplyConstructorInfo", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.RuntimeConstructorInfo),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.SignatureTypeExtensions), Member = "MatchesParameterTypeExactly", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Reflection.ParameterInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.ParameterInfo), Member = "get_IsOptional", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsArray", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool FilterApplyMethodBase(global::System.Reflection.MethodBase methodBase, global::System.Reflection.BindingFlags methodFlags, global::System.Reflection.BindingFlags bindingFlags, global::System.Reflection.CallingConventions callConv, global::System.Type[] argumentTypes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6BD88", Offset = "0x1C6BD88", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ReflectionOnlyType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.TypeInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal RuntimeType()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6BDC8", Offset = "0x1C6BDC8", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethods", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.MethodInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMember", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.MemberTypes),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.MemberInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterHelper", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(ref string),
			typeof(bool),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref global::System.RuntimeType.MemberListType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetMethodsByName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimeMethodInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterApplyMethodInfo", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.RuntimeMethodInfo),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterApplyPrefixLookup", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private global::System.RuntimeType.ListBuilder<global::System.Reflection.MethodInfo> GetMethodCandidates(string name, global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.CallingConventions callConv, global::System.Type[] types, int genericParamCount, bool allowPrefixLookup)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6C2CC", Offset = "0x1C6C2CC", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetConstructors", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.ConstructorInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetConstructorImpl", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMember", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.MemberTypes),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.MemberInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterHelper", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(ref string),
			typeof(bool),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref global::System.RuntimeType.MemberListType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetConstructors_internal", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimeConstructorInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterApplyConstructorInfo", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.RuntimeConstructorInfo),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterApplyPrefixLookup", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private global::System.RuntimeType.ListBuilder<global::System.Reflection.ConstructorInfo> GetConstructorCandidates(string name, global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.CallingConventions callConv, global::System.Type[] types, bool allowPrefixLookup)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6C750", Offset = "0x1C6C750", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetProperties", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.PropertyInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetPropertyImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMember", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.MemberTypes),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.MemberInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterHelper", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(ref string),
			typeof(bool),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref global::System.RuntimeType.MemberListType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetPropertiesByName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimePropertyInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimePropertyInfo), Member = "get_BindingFlags", ReturnType = typeof(global::System.Reflection.BindingFlags))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterApplyPrefixLookup", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private global::System.RuntimeType.ListBuilder<global::System.Reflection.PropertyInfo> GetPropertyCandidates(string name, global::System.Reflection.BindingFlags bindingAttr, global::System.Type[] types, bool allowPrefixLookup)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6CC14", Offset = "0x1C6CC14", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEvents", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.EventInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMember", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.MemberTypes),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.MemberInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterHelper", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(ref string),
			typeof(bool),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref global::System.RuntimeType.MemberListType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetEvents_internal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimeEventInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeEventInfo), Member = "get_BindingFlags", ReturnType = typeof(global::System.Reflection.BindingFlags))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterApplyPrefixLookup", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private global::System.RuntimeType.ListBuilder<global::System.Reflection.EventInfo> GetEventCandidates(string name, global::System.Reflection.BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6D060", Offset = "0x1C6D060", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetFields", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.FieldInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMember", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.MemberTypes),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.MemberInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterHelper", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(ref string),
			typeof(bool),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref global::System.RuntimeType.MemberListType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetFields_internal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimeFieldInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeFieldInfo), Member = "get_BindingFlags", ReturnType = typeof(global::System.Reflection.BindingFlags))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterApplyPrefixLookup", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private global::System.RuntimeType.ListBuilder<global::System.Reflection.FieldInfo> GetFieldCandidates(string name, global::System.Reflection.BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6D4F0", Offset = "0x1C6D4F0", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMember", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.MemberTypes),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.MemberInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "SplitName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterHelper", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(ref string),
			typeof(bool),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref global::System.RuntimeType.MemberListType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetNestedTypes_internal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType)
		}, ReturnType = typeof(global::System.RuntimeType[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterApplyType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Reflection.BindingFlags),
			typeof(string),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private global::System.RuntimeType.ListBuilder<global::System.Type> GetNestedTypeCandidates(string fullname, global::System.Reflection.BindingFlags bindingAttr, bool allowPrefixLookup)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6DA04", Offset = "0x1C6DA04", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetMethodCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.MethodInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override global::System.Reflection.MethodInfo[] GetMethods(global::System.Reflection.BindingFlags bindingAttr)
		{
			throw null;
		}

		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000DA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6DA90", Offset = "0x1C6DA90", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.ConstructorInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override global::System.Reflection.ConstructorInfo[] GetConstructors(global::System.Reflection.BindingFlags bindingAttr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6DB28", Offset = "0x1C6DB28", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Type[]),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.PropertyInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override global::System.Reflection.PropertyInfo[] GetProperties(global::System.Reflection.BindingFlags bindingAttr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6DBAC", Offset = "0x1C6DBAC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetEventCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.EventInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override global::System.Reflection.EventInfo[] GetEvents(global::System.Reflection.BindingFlags bindingAttr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6DC2C", Offset = "0x1C6DC2C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetFieldCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.FieldInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override global::System.Reflection.FieldInfo[] GetFields(global::System.Reflection.BindingFlags bindingAttr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6DCAC", Offset = "0x1C6DCAC", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.ConstructorInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_DefaultBinder", ReturnType = typeof(global::System.Reflection.Binder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "ExactBinding", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase[]),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected override global::System.Reflection.ConstructorInfo GetConstructorImpl(global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.Binder binder, global::System.Reflection.CallingConventions callConvention, global::System.Type[] types, global::System.Reflection.ParameterModifier[] modifiers)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6DEB0", Offset = "0x1C6DEB0", Length = "0x270")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Type[]),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.PropertyInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_DefaultBinder", ReturnType = typeof(global::System.Reflection.Binder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "ExactPropertyBinding", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.PropertyInfo[]),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AmbiguousMatchException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		protected override global::System.Reflection.PropertyInfo GetPropertyImpl(string name, global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.Binder binder, global::System.Type returnType, global::System.Type[] types, global::System.Reflection.ParameterModifier[] modifiers)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6E120", Offset = "0x1C6E120", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterHelper", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(ref string),
			typeof(ref bool),
			typeof(ref global::System.RuntimeType.MemberListType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetEvents_internal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimeEventInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeEventInfo), Member = "get_BindingFlags", ReturnType = typeof(global::System.Reflection.BindingFlags))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.EventInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.EventInfo),
			typeof(global::System.Reflection.EventInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AmbiguousMatchException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override global::System.Reflection.EventInfo GetEvent(string name, global::System.Reflection.BindingFlags bindingAttr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6E2CC", Offset = "0x1C6E2CC", Length = "0x2A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterHelper", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(ref string),
			typeof(ref bool),
			typeof(ref global::System.RuntimeType.MemberListType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetFields_internal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimeFieldInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeFieldInfo), Member = "get_BindingFlags", ReturnType = typeof(global::System.Reflection.BindingFlags))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(global::System.Reflection.FieldInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(global::System.Reflection.FieldInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AmbiguousMatchException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override global::System.Reflection.FieldInfo GetField(string name, global::System.Reflection.BindingFlags bindingAttr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6E574", Offset = "0x1C6E574", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "SplitName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterHelper", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(ref string),
			typeof(ref bool),
			typeof(ref global::System.RuntimeType.MemberListType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetNestedTypes_internal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType)
		}, ReturnType = typeof(global::System.RuntimeType[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterApplyType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Reflection.BindingFlags),
			typeof(string),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AmbiguousMatchException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override global::System.Type GetNestedType(string fullname, global::System.Reflection.BindingFlags bindingAttr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6E74C", Offset = "0x1C6E74C", Length = "0x4E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetMethodCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.MethodInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.ConstructorInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Type[]),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.PropertyInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetEventCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.EventInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetFieldCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.FieldInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Type>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public override global::System.Reflection.MemberInfo[] GetMember(string name, global::System.Reflection.MemberTypes type, global::System.Reflection.BindingFlags bindingAttr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000125")]
		public override global::System.Reflection.Module Module
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C6EC34", Offset = "0x1C6EC34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "GetModule", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(global::System.Reflection.RuntimeModule))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6EC3C", Offset = "0x1C6EC3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeEventInfo), Member = "get_Module", ReturnType = typeof(global::System.Reflection.Module))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeEventInfo), Member = "GetRuntimeModule", ReturnType = typeof(global::System.Reflection.RuntimeModule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeFieldInfo), Member = "get_Module", ReturnType = typeof(global::System.Reflection.Module))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeFieldInfo), Member = "GetRuntimeModule", ReturnType = typeof(global::System.Reflection.RuntimeModule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "GetRuntimeModule", ReturnType = typeof(global::System.Reflection.RuntimeModule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimePropertyInfo), Member = "get_Module", ReturnType = typeof(global::System.Reflection.Module))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimePropertyInfo), Member = "GetRuntimeModule", ReturnType = typeof(global::System.Reflection.RuntimeModule))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "GetModule", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(global::System.Reflection.RuntimeModule))]
		internal global::System.Reflection.RuntimeModule GetRuntimeModule()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000126")]
		public override global::System.Reflection.Assembly Assembly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DB0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C6EC44", Offset = "0x1C6EC44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "GetAssembly", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(global::System.Reflection.RuntimeAssembly))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6EC4C", Offset = "0x1C6EC4C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.UnitySerializationHolder), Member = "GetUnitySerializationInfo", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "GetAssembly", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(global::System.Reflection.RuntimeAssembly))]
		internal global::System.Reflection.RuntimeAssembly GetRuntimeAssembly()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000127")]
		public override global::System.RuntimeTypeHandle TypeHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DB2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C6EC54", Offset = "0x1C6EC54", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6EC78", Offset = "0x1C6EC78", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "IsInstanceOfType", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(object)
		}, ReturnType = typeof(bool))]
		public override bool IsInstanceOfType(object o)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6EC80", Offset = "0x1C6EC80", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "CanCastTo", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsAssignableFrom(global::System.Type c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6ED58", Offset = "0x1C6ED58", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "IsEquivalentTo", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsEquivalentTo(global::System.Type other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000128")]
		public override global::System.Type BaseType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DB6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C6EE08", Offset = "0x1C6EE08", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6EE0C", Offset = "0x1C6EE0C", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "get_IsEnum", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "IsGenericVariable", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "GetBaseType", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private global::System.RuntimeType GetBaseType()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000129")]
		public override global::System.Type UnderlyingSystemType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DB8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C6EFD8", Offset = "0x1C6EFD8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6EFDC", Offset = "0x1C6EFDC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "GetAttributes", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(global::System.Reflection.TypeAttributes))]
		protected override global::System.Reflection.TypeAttributes GetAttributeFlagsImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6EFE4", Offset = "0x1C6EFE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "IsContextful", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(bool))]
		protected override bool IsContextfulImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6EFEC", Offset = "0x1C6EFEC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "IsByRef", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(bool))]
		protected override bool IsByRefImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6EFF4", Offset = "0x1C6EFF4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "IsPrimitive", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(bool))]
		protected override bool IsPrimitiveImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6EFFC", Offset = "0x1C6EFFC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "IsPointer", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(bool))]
		protected override bool IsPointerImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6F004", Offset = "0x1C6F004", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "IsComObject", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		protected override bool IsCOMObjectImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6F010", Offset = "0x1C6F010", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected override bool IsValueTypeImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700012A")]
		public override bool IsEnum
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DC0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C6F130", Offset = "0x1C6F130", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetBaseType", ReturnType = typeof(global::System.RuntimeType))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6F1A4", Offset = "0x1C6F1A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "HasElementType", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(bool))]
		protected override bool HasElementTypeImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700012B")]
		public override global::System.Reflection.GenericParameterAttributes GenericParameterAttributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DC2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C6F1AC", Offset = "0x1C6F1AC", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700012C")]
		internal override bool IsSzArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DC3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C6F270", Offset = "0x1C6F270", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "IsSzArray", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6F278", Offset = "0x1C6F278", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "IsArray", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(bool))]
		protected override bool IsArrayImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6F280", Offset = "0x1C6F280", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "GetArrayRank", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override int GetArrayRank()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6F304", Offset = "0x1C6F304", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "GetElementType", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(global::System.RuntimeType))]
		public override global::System.Type GetElementType()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6F30C", Offset = "0x1C6F30C", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "InternalGetNames", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override string[] GetEnumNames()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6F420", Offset = "0x1C6F420", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "InternalGetValues", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(ulong[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(int)
		}, ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ulong)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override global::System.Array GetEnumValues()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6F578", Offset = "0x1C6F578", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override global::System.Type GetEnumUnderlyingType()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DCA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6F648", Offset = "0x1C6F648", Length = "0x474")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "IsIntegerType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "InternalGetValues", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(ulong[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToUInt64", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array[]), Member = "BinarySearch", MemberTypeParameters = new object[] { typeof(ulong) }, MemberParameters = new object[]
		{
			typeof(ulong[]),
			typeof(ulong)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "InternalGetNames", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array[]), Member = "IndexOf", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
		public override bool IsEnumDefined(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DCB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6FABC", Offset = "0x1C6FABC", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "IsIntegerType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "InternalGetValues", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(ulong[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToUInt64", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array[]), Member = "BinarySearch", MemberTypeParameters = new object[] { typeof(ulong) }, MemberParameters = new object[]
		{
			typeof(ulong[]),
			typeof(ulong)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "InternalGetNames", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override string GetEnumName(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DCC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6FC88", Offset = "0x1C6FC88", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "MakeGenericType", MemberParameters = new object[] { typeof(global::System.Type[]) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal global::System.RuntimeType[] GetGenericArgumentsInternal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DCD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6FD00", Offset = "0x1C6FD00", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override global::System.Type[] GetGenericArguments()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DCE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6FD90", Offset = "0x1C6FD90", Length = "0x46C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetGenericArgumentsInternal", ReturnType = typeof(global::System.RuntimeType[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "SanityCheckGenericArguments", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType[]),
			typeof(global::System.RuntimeType[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "MakeGenericSignatureType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeFeature), Member = "get_IsDynamicCodeSupported", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeLoadException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		public override global::System.Type MakeGenericType(params global::System.Type[] instantiation)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700012D")]
		public override bool IsGenericTypeDefinition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DCF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C70200", Offset = "0x1C70200", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "IsGenericTypeDefinition", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700012E")]
		public override bool IsGenericParameter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DD0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C70208", Offset = "0x1C70208", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "IsGenericVariable", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700012F")]
		public override int GenericParameterPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DD1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C70210", Offset = "0x1C70210", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C70294", Offset = "0x1C70294", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "GetGenericTypeDefinition", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override global::System.Type GetGenericTypeDefinition()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000130")]
		public override bool IsGenericType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DD3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C70318", Offset = "0x1C70318", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "HasInstantiation", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000131")]
		public override bool IsConstructedGenericType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DD4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C70320", Offset = "0x1C70320", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000DD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C70368", Offset = "0x1C70368", Length = "0x1084")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array[]), Member = "IndexOf", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetDefaultMemberName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_DefaultBinder", ReturnType = typeof(global::System.Reflection.Binder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Activator), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(global::System.Reflection.FieldInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsArray", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterApplyMethodInfo", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.RuntimeMethodInfo),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "CopyTo", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetValue", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(global::System.Reflection.MethodBase)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MissingMethodException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MissingFieldException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 94)]
		public override object InvokeMember(string name, global::System.Reflection.BindingFlags bindingFlags, global::System.Reflection.Binder binder, object target, object[] providedArgs, global::System.Reflection.ParameterModifier[] modifiers, global::System.Globalization.CultureInfo culture, string[] namedParams)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C714C8", Offset = "0x1C714C8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5D624", Offset = "0x1C5D624", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeTypeHandle), Member = "GetTypeByName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterServices), Member = "GetParentTypes", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(ref global::System.RuntimeType[]),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.SafeSerializationManager), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.SafeSerializationManager), Member = "System.Runtime.Serialization.IObjectReference.GetRealObject", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "FindType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.MemberInfoSerializationHolder), Member = "GetRealObject", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		public static bool operator ==(global::System.RuntimeType left, global::System.RuntimeType right)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5FF34", Offset = "0x1C5FF34", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TypedReference), Member = "MakeTypedReference", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Reflection.FieldInfo[])
		}, ReturnType = typeof(global::System.TypedReference))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueType), Member = "DefaultEquals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterServices), Member = "InternalGetSerializableMembers", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(global::System.Reflection.MemberInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterServices), Member = "GetParentTypes", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(ref global::System.RuntimeType[]),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public static bool operator !=(global::System.RuntimeType left, global::System.RuntimeType right)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C714D4", Offset = "0x1C714D4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public object Clone()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C714D8", Offset = "0x1C714D8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.UnitySerializationHolder), Member = "GetUnitySerializationInfo", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DDB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7153C", Offset = "0x1C7153C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C715DC", Offset = "0x1C715DC", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override object[] GetCustomAttributes(global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DDD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C71770", Offset = "0x1C71770", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override bool IsDefined(global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C71904", Offset = "0x1C71904", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetRootElementType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsNested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override string FormatTypeName(bool serialization)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000132")]
		public override global::System.Reflection.MemberTypes MemberType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DDF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C71AD0", Offset = "0x1C71AD0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsPublic", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsNotPublic", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000133")]
		public override global::System.Type ReflectedType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DE0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C71B14", Offset = "0x1C71B14", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000134")]
		public override int MetadataToken
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DE1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C71B20", Offset = "0x1C71B20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "GetToken", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C71B28", Offset = "0x1C71B28", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(object[]),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceDefaultCtor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceSlow", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetRootElementType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private void CreateInstanceCheckThis()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5D630", Offset = "0x1C5D630", Length = "0x880")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Activator), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceCheckThis", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_DefaultBinder", ReturnType = typeof(global::System.Reflection.Binder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceDefaultCtor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterApplyConstructorInfo", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.RuntimeConstructorInfo),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "CopyTo", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(global::System.Reflection.MethodBase)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Activator), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MissingMethodException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 73)]
		internal object CreateInstanceImpl(global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.Binder binder, object[] args, global::System.Globalization.CultureInfo culture, object[] activationAttributes, ref global::System.Threading.StackCrawlMark stackMark)
		{
			throw null;
		}

		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000DE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5E070", Offset = "0x1C5E070", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Activator), Member = "CreateInstance", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(object[]),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceCheckThis", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceMono", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, bool wrapExceptions, ref global::System.Threading.StackCrawlMark stackMark)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C71D68", Offset = "0x1C71D68", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceMono", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceForAnotherGenericParameter", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoTypeInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.ConstructorInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ConstructorInfo),
			typeof(global::System.Reflection.ConstructorInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal global::System.Reflection.RuntimeConstructorInfo GetDefaultConstructor()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C713EC", Offset = "0x1C713EC", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "InvokeMember", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object),
			typeof(object[]),
			typeof(global::System.Reflection.ParameterModifier[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(string[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private string GetDefaultMemberName()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C71ED8", Offset = "0x1C71ED8", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.ObjectManager), Member = "GetConstructor", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(global::System.Reflection.RuntimeConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.SafeSerializationManager), Member = "System.Runtime.Serialization.IObjectReference.GetRealObject", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.ConstructorInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ConstructorInfo),
			typeof(global::System.Reflection.ConstructorInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetConstructor", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal global::System.Reflection.RuntimeConstructorInfo GetSerializationCtor()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C71D2C", Offset = "0x1C71D2C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceCheckThis", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceMono", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		internal object CreateInstanceSlow(bool publicOnly, bool wrapExceptions, bool skipCheckThis, bool fillCache)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7209C", Offset = "0x1C7209C", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceDefaultCtor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceSlow", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetDefaultConstructor", ReturnType = typeof(global::System.Reflection.RuntimeConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.ConstructorInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ConstructorInfo),
			typeof(global::System.Reflection.ConstructorInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.ConstructorInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ConstructorInfo),
			typeof(global::System.Reflection.ConstructorInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetRootElementType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsAbstract", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeConstructorInfo), Member = "InternalInvoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[]),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MissingMethodException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MissingMethodException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private object CreateInstanceMono(bool nonPublic, bool wrapExceptions)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C72360", Offset = "0x1C72360", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeFieldInfo), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "ConvertValues", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Binder),
			typeof(object[]),
			typeof(global::System.Reflection.ParameterInfo[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "TryConvertToType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_DefaultBinder", ReturnType = typeof(global::System.Reflection.Binder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentUICulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal object CheckValue(object value, global::System.Reflection.Binder binder, global::System.Globalization.CultureInfo culture, global::System.Reflection.BindingFlags invokeAttr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C724B4", Offset = "0x1C724B4", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CheckValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "IsConvertibleToPrimitiveType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsPointer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private object TryConvertToType(object value, ref bool failed)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C72708", Offset = "0x1C72708", Length = "0x988")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "TryConvertToType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.TypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 60)]
		private static object IsConvertibleToPrimitiveType(object value, global::System.Type targetType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C71A80", Offset = "0x1C71A80", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private string GetCachedName(global::System.TypeNameKind kind)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C73090", Offset = "0x1C73090", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern global::System.Type make_array_type(int rank);

		[global::Cpp2ILInjected.Token(Token = "0x6000DEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C73094", Offset = "0x1C73094", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override global::System.Type MakeArrayType()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7309C", Offset = "0x1C7309C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override global::System.Type MakeArrayType(int rank)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C730E4", Offset = "0x1C730E4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern global::System.Type make_byref_type();

		[global::Cpp2ILInjected.Token(Token = "0x6000DF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C730E8", Offset = "0x1C730E8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeLoadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override global::System.Type MakeByRefType()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C73150", Offset = "0x1C73150", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern global::System.Type MakePointerType(global::System.Type type);

		[global::Cpp2ILInjected.Token(Token = "0x6000DF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C73154", Offset = "0x1C73154", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeLoadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override global::System.Type MakePointerType()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000135")]
		public override bool ContainsGenericParameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000DF5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C73238", Offset = "0x1C73238", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_HasElementType", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C73324", Offset = "0x1C73324", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "GetGenericParameterInfo", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.RuntimeGenericParamInfoHandle), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.RuntimeGenericParamInfoHandle), Member = "get_Constraints", ReturnType = typeof(global::System.Type[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override global::System.Type[] GetGenericParameterConstraints()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C73418", Offset = "0x1C73418", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Comparer<>), Member = "CreateComparer", ReturnType = "System.Collections.Generic.Comparer`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.EqualityComparer<>), Member = "CreateComparer", ReturnType = "System.Collections.Generic.EqualityComparer`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetDefaultConstructor", ReturnType = typeof(global::System.Reflection.RuntimeConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeConstructorInfo), Member = "InternalInvoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[]),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static object CreateInstanceForAnotherGenericParameter(global::System.Type genericType, global::System.RuntimeType genericArgument)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C701FC", Offset = "0x1C701FC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern global::System.Type MakeGenericType(global::System.Type gt, global::System.Type[] types);

		[global::Cpp2ILInjected.Token(Token = "0x6000DF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C73514", Offset = "0x1C73514", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal extern global::System.IntPtr GetMethodsByName_native(global::System.IntPtr namePtr, global::System.Reflection.BindingFlags bindingAttr, global::System.RuntimeType.MemberListType listType);

		[global::Cpp2ILInjected.Token(Token = "0x6000DFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6BFF8", Offset = "0x1C6BFF8", Length = "0x2D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.MethodInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.MethodInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeStringMarshal), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeStringMarshal), Member = "get_Value", ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "GetMethodFromHandleNoGenericCheck", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeMethodHandle),
			typeof(global::System.RuntimeTypeHandle)
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeStringMarshal), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		internal global::System.Reflection.RuntimeMethodInfo[] GetMethodsByName(string name, global::System.Reflection.BindingFlags bindingAttr, global::System.RuntimeType.MemberListType listType, global::System.RuntimeType reflectedType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C73518", Offset = "0x1C73518", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern global::System.IntPtr GetPropertiesByName_native(global::System.IntPtr name, global::System.Reflection.BindingFlags bindingAttr, global::System.RuntimeType.MemberListType listType);

		[global::Cpp2ILInjected.Token(Token = "0x6000DFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7351C", Offset = "0x1C7351C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern global::System.IntPtr GetConstructors_native(global::System.Reflection.BindingFlags bindingAttr);

		[global::Cpp2ILInjected.Token(Token = "0x6000DFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6C530", Offset = "0x1C6C530", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.ConstructorInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "GetMethodFromHandleNoGenericCheck", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeMethodHandle),
			typeof(global::System.RuntimeTypeHandle)
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private global::System.Reflection.RuntimeConstructorInfo[] GetConstructors_internal(global::System.Reflection.BindingFlags bindingAttr, global::System.RuntimeType reflectedType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6C940", Offset = "0x1C6C940", Length = "0x2D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Type[]),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.PropertyInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeStringMarshal), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeStringMarshal), Member = "get_Value", ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimePropertyInfo), Member = "GetPropertyFromHandle", MemberParameters = new object[]
		{
			typeof(global::Mono.RuntimePropertyHandle),
			typeof(global::System.RuntimeTypeHandle)
		}, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeStringMarshal), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private global::System.Reflection.RuntimePropertyInfo[] GetPropertiesByName(string name, global::System.Reflection.BindingFlags bindingAttr, global::System.RuntimeType.MemberListType listType, global::System.RuntimeType reflectedType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000DFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C73520", Offset = "0x1C73520", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override global::System.TypeCode GetTypeCodeImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C73574", Offset = "0x1C73574", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern global::System.TypeCode GetTypeCodeImplInternal(global::System.Type type);

		[global::Cpp2ILInjected.Token(Token = "0x6000E01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C73578", Offset = "0x1C73578", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C71D24", Offset = "0x1C71D24", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool IsGenericCOMObjectImpl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7235C", Offset = "0x1C7235C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern object CreateInstanceInternal(global::System.Type type);

		[global::Cpp2ILInjected.Token(Token = "0x17000136")]
		public override extern global::System.Reflection.MethodBase DeclaringMethod
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E04")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C73590", Offset = "0x1C73590", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C73584", Offset = "0x1C73584", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal extern string getFullName(bool full_name, bool assembly_qualified);

		[global::Cpp2ILInjected.Token(Token = "0x6000E06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6FCF8", Offset = "0x1C6FCF8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern global::System.Type[] GetGenericArgumentsInternal(bool runtimeArray);

		[global::Cpp2ILInjected.Token(Token = "0x6000E07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6F22C", Offset = "0x1C6F22C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "GetGenericParameterInfo", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.RuntimeGenericParamInfoHandle), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.RuntimeGenericParamInfoHandle), Member = "get_Attributes", ReturnType = typeof(global::System.Reflection.GenericParameterAttributes))]
		private global::System.Reflection.GenericParameterAttributes GetGenericParameterAttributes()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E08")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C70290", Offset = "0x1C70290", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern int GetGenericParameterPosition();

		[global::Cpp2ILInjected.Token(Token = "0x6000E09")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C73594", Offset = "0x1C73594", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern global::System.IntPtr GetEvents_native(global::System.IntPtr name, global::System.RuntimeType.MemberListType listType);

		[global::Cpp2ILInjected.Token(Token = "0x6000E0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C73598", Offset = "0x1C73598", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern global::System.IntPtr GetFields_native(global::System.IntPtr name, global::System.Reflection.BindingFlags bindingAttr, global::System.RuntimeType.MemberListType listType);

		[global::Cpp2ILInjected.Token(Token = "0x6000E0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6D21C", Offset = "0x1C6D21C", Length = "0x2D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetFieldCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.FieldInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetField", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.FieldInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeStringMarshal), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeStringMarshal), Member = "get_Value", ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "GetFieldFromHandle", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeFieldHandle),
			typeof(global::System.RuntimeTypeHandle)
		}, ReturnType = typeof(global::System.Reflection.FieldInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeStringMarshal), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private global::System.Reflection.RuntimeFieldInfo[] GetFields_internal(string name, global::System.Reflection.BindingFlags bindingAttr, global::System.RuntimeType.MemberListType listType, global::System.RuntimeType reflectedType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6CDCC", Offset = "0x1C6CDCC", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEventCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.EventInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEvent", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Reflection.EventInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeStringMarshal), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeStringMarshal), Member = "get_Value", ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.EventInfo), Member = "GetEventFromHandle", MemberParameters = new object[]
		{
			typeof(global::Mono.RuntimeEventHandle),
			typeof(global::System.RuntimeTypeHandle)
		}, ReturnType = typeof(global::System.Reflection.EventInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeStringMarshal), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private global::System.Reflection.RuntimeEventInfo[] GetEvents_internal(string name, global::System.Reflection.BindingFlags bindingAttr, global::System.RuntimeType.MemberListType listType, global::System.RuntimeType reflectedType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7359C", Offset = "0x1C7359C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public override extern global::System.Type[] GetInterfaces();

		[global::Cpp2ILInjected.Token(Token = "0x6000E0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C735A0", Offset = "0x1C735A0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern global::System.IntPtr GetNestedTypes_native(global::System.IntPtr name, global::System.Reflection.BindingFlags bindingAttr, global::System.RuntimeType.MemberListType listType);

		[global::Cpp2ILInjected.Token(Token = "0x6000E0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6D694", Offset = "0x1C6D694", Length = "0x370")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Type>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetNestedType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeIdentifiers), Member = "FromDisplay", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.TypeIdentifier))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeStringMarshal), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeStringMarshal), Member = "get_Value", ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeGPtrArrayHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Mono.SafeStringMarshal), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private global::System.RuntimeType[] GetNestedTypes_internal(string displayName, global::System.Reflection.BindingFlags bindingAttr, global::System.RuntimeType.MemberListType listType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000137")]
		public override string AssemblyQualifiedName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E10")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C735A4", Offset = "0x1C735A4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000138")]
		public override extern global::System.Type DeclaringType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E11")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C735B0", Offset = "0x1C735B0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000139")]
		public override extern string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E12")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C735B4", Offset = "0x1C735B4", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700013A")]
		public override extern string Namespace
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E13")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C735B8", Offset = "0x1C735B8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E14")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C735BC", Offset = "0x1C735BC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700013B")]
		public override string FullName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E15")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C73680", Offset = "0x1C73680", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetRootElementType", ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoTypeInfo), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700013C")]
		public override bool IsSZArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E16")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7373C", Offset = "0x1C7373C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsArray", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000E17")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7378C", Offset = "0x1C7378C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "IsSubclassOf", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override bool IsSubclassOf(global::System.Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C73880", Offset = "0x1C73880", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		protected override global::System.Reflection.MethodInfo GetMethodImpl(string name, global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.Binder binder, global::System.Reflection.CallingConventions callConv, global::System.Type[] types, global::System.Reflection.ParameterModifier[] modifiers)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C738B0", Offset = "0x1C738B0", Length = "0x29C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetMethodCandidates", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(bool)
		}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.MethodInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_DefaultBinder", ReturnType = typeof(global::System.Reflection.Binder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "CompareMethodSig", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase),
			typeof(global::System.Reflection.MethodBase)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = "FindMostDerivedNewSlotMeth", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodBase[]),
			typeof(int)
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AmbiguousMatchException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private global::System.Reflection.MethodInfo GetMethodImplCommon(string name, int genericParameterCount, global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.Binder binder, global::System.Reflection.CallingConventions callConv, global::System.Type[] types, global::System.Reflection.ParameterModifier[] modifiers)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C73B4C", Offset = "0x1C73B4C", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterHelper", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(ref string),
			typeof(bool),
			typeof(ref bool),
			typeof(ref bool),
			typeof(ref global::System.RuntimeType.MemberListType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetMethodsByName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimeMethodInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterApplyMethodInfo", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.RuntimeMethodInfo),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterApplyPrefixLookup", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType.ListBuilder<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private global::System.RuntimeType.ListBuilder<global::System.Reflection.MethodInfo> GetMethodCandidates(string name, int genericParameterCount, global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.CallingConventions callConv, global::System.Type[] types, bool allowPrefixLookup)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000E1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C73D3C", Offset = "0x1C73D3C", Length = "0x1388")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		static RuntimeType()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400054A")]
		internal static readonly global::System.RuntimeType ValueType;

		[global::Cpp2ILInjected.Token(Token = "0x400054B")]
		internal static readonly global::System.RuntimeType EnumType;

		[global::Cpp2ILInjected.Token(Token = "0x400054C")]
		private static readonly global::System.RuntimeType ObjectType;

		[global::Cpp2ILInjected.Token(Token = "0x400054D")]
		private static readonly global::System.RuntimeType StringType;

		[global::Cpp2ILInjected.Token(Token = "0x400054E")]
		private static readonly global::System.RuntimeType DelegateType;

		[global::Cpp2ILInjected.Token(Token = "0x400054F")]
		private static global::System.Type[] s_SICtorParamTypes;

		[global::Cpp2ILInjected.Token(Token = "0x4000550")]
		internal static global::System.Func<global::System.Type, global::System.Type[], global::System.Type> MakeTypeBuilderInstantiation;

		[global::Cpp2ILInjected.Token(Token = "0x4000551")]
		private const global::System.Reflection.BindingFlags MemberBindingMask = (global::System.Reflection.BindingFlags)255;

		[global::Cpp2ILInjected.Token(Token = "0x4000552")]
		private const global::System.Reflection.BindingFlags InvocationMask = global::System.Reflection.BindingFlags.InvokeMethod | global::System.Reflection.BindingFlags.CreateInstance | global::System.Reflection.BindingFlags.GetField | global::System.Reflection.BindingFlags.SetField | global::System.Reflection.BindingFlags.GetProperty | global::System.Reflection.BindingFlags.SetProperty | global::System.Reflection.BindingFlags.PutDispProperty | global::System.Reflection.BindingFlags.PutRefDispProperty;

		[global::Cpp2ILInjected.Token(Token = "0x4000553")]
		private const global::System.Reflection.BindingFlags BinderNonCreateInstance = global::System.Reflection.BindingFlags.InvokeMethod | global::System.Reflection.BindingFlags.GetField | global::System.Reflection.BindingFlags.SetField | global::System.Reflection.BindingFlags.GetProperty | global::System.Reflection.BindingFlags.SetProperty;

		[global::Cpp2ILInjected.Token(Token = "0x4000554")]
		private const global::System.Reflection.BindingFlags BinderGetSetProperty = global::System.Reflection.BindingFlags.GetProperty | global::System.Reflection.BindingFlags.SetProperty;

		[global::Cpp2ILInjected.Token(Token = "0x4000555")]
		private const global::System.Reflection.BindingFlags BinderSetInvokeProperty = global::System.Reflection.BindingFlags.InvokeMethod | global::System.Reflection.BindingFlags.SetProperty;

		[global::Cpp2ILInjected.Token(Token = "0x4000556")]
		private const global::System.Reflection.BindingFlags BinderGetSetField = global::System.Reflection.BindingFlags.GetField | global::System.Reflection.BindingFlags.SetField;

		[global::Cpp2ILInjected.Token(Token = "0x4000557")]
		private const global::System.Reflection.BindingFlags BinderSetInvokeField = global::System.Reflection.BindingFlags.InvokeMethod | global::System.Reflection.BindingFlags.SetField;

		[global::Cpp2ILInjected.Token(Token = "0x4000558")]
		private const global::System.Reflection.BindingFlags BinderNonFieldGetSet = (global::System.Reflection.BindingFlags)16773888;

		[global::Cpp2ILInjected.Token(Token = "0x4000559")]
		private const global::System.Reflection.BindingFlags ClassicBindingMask = global::System.Reflection.BindingFlags.InvokeMethod | global::System.Reflection.BindingFlags.GetProperty | global::System.Reflection.BindingFlags.SetProperty | global::System.Reflection.BindingFlags.PutDispProperty | global::System.Reflection.BindingFlags.PutRefDispProperty;

		[global::Cpp2ILInjected.Token(Token = "0x400055A")]
		private static global::System.RuntimeType s_typedRef;

		[global::Cpp2ILInjected.Token(Token = "0x400055B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		[global::System.NonSerialized]
		private global::System.MonoTypeInfo type_info;

		[global::Cpp2ILInjected.Token(Token = "0x400055C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal object GenericCache;

		[global::Cpp2ILInjected.Token(Token = "0x400055D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Reflection.RuntimeConstructorInfo m_serializationCtor;

		[global::Cpp2ILInjected.Token(Token = "0x400055E")]
		private const int GenericParameterCountAny = -1;

		[global::Cpp2ILInjected.Token(Token = "0x2000159")]
		internal enum MemberListType
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000560")]
			All,
			[global::Cpp2ILInjected.Token(Token = "0x4000561")]
			CaseSensitive,
			[global::Cpp2ILInjected.Token(Token = "0x4000562")]
			CaseInsensitive,
			[global::Cpp2ILInjected.Token(Token = "0x4000563")]
			HandleToInfo
		}

		[global::Cpp2ILInjected.Token(Token = "0x200015A")]
		private struct ListBuilder<T> where T : class
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E1C")]
			[global::Cpp2ILInjected.Address(RVA = "0x172B06C", Offset = "0x172B06C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodCandidates", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.CallingConventions),
				typeof(global::System.Type[]),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.MethodInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.CallingConventions),
				typeof(global::System.Type[]),
				typeof(bool)
			}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.ConstructorInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Type[]),
				typeof(bool)
			}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.PropertyInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEventCandidates", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags),
				typeof(bool)
			}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.EventInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetFieldCandidates", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags),
				typeof(bool)
			}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.FieldInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags),
				typeof(bool)
			}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Type>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodCandidates", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.CallingConventions),
				typeof(global::System.Type[]),
				typeof(bool)
			}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.MethodInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			public ListBuilder(int capacity)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700013D")]
			public T this[int index]
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000E1D")]
				[global::Cpp2ILInjected.Address(RVA = "0x172B078", Offset = "0x172B078", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetConstructorImpl", MemberParameters = new object[]
				{
					typeof(global::System.Reflection.BindingFlags),
					typeof(global::System.Reflection.Binder),
					typeof(global::System.Reflection.CallingConventions),
					typeof(global::System.Type[]),
					typeof(global::System.Reflection.ParameterModifier[])
				}, ReturnType = typeof(global::System.Reflection.ConstructorInfo))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetPropertyImpl", MemberParameters = new object[]
				{
					typeof(string),
					typeof(global::System.Reflection.BindingFlags),
					typeof(global::System.Reflection.Binder),
					typeof(global::System.Type),
					typeof(global::System.Type[]),
					typeof(global::System.Reflection.ParameterModifier[])
				}, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new object[]
				{
					typeof(string),
					typeof(int),
					typeof(global::System.Reflection.BindingFlags),
					typeof(global::System.Reflection.Binder),
					typeof(global::System.Reflection.CallingConventions),
					typeof(global::System.Type[]),
					typeof(global::System.Reflection.ParameterModifier[])
				}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000E1E")]
			[global::Cpp2ILInjected.Address(RVA = "0x172B094", Offset = "0x172B094", Length = "0x12C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethods", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.MethodInfo[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetConstructors", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.ConstructorInfo[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetProperties", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.PropertyInfo[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEvents", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.EventInfo[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetFields", MemberParameters = new object[] { typeof(global::System.Reflection.BindingFlags) }, ReturnType = typeof(global::System.Reflection.FieldInfo[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetConstructorImpl", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.Binder),
				typeof(global::System.Reflection.CallingConventions),
				typeof(global::System.Type[]),
				typeof(global::System.Reflection.ParameterModifier[])
			}, ReturnType = typeof(global::System.Reflection.ConstructorInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetPropertyImpl", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.Binder),
				typeof(global::System.Type),
				typeof(global::System.Type[]),
				typeof(global::System.Reflection.ParameterModifier[])
			}, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMember", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.MemberTypes),
				typeof(global::System.Reflection.BindingFlags)
			}, ReturnType = typeof(global::System.Reflection.MemberInfo[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.Binder),
				typeof(global::System.Reflection.CallingConventions),
				typeof(global::System.Type[]),
				typeof(global::System.Reflection.ParameterModifier[])
			}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public T[] ToArray()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000E1F")]
			[global::Cpp2ILInjected.Address(RVA = "0x172B1C0", Offset = "0x172B1C0", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMember", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.MemberTypes),
				typeof(global::System.Reflection.BindingFlags)
			}, ReturnType = typeof(global::System.Reflection.MemberInfo[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int),
				typeof(global::System.Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public void CopyTo(object[] array, int index)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x1700013E")]
			public int Count
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000E20")]
				[global::Cpp2ILInjected.Address(RVA = "0x172B23C", Offset = "0x172B23C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000E21")]
			[global::Cpp2ILInjected.Address(RVA = "0x172B244", Offset = "0x172B244", Length = "0x110")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodCandidates", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.CallingConventions),
				typeof(global::System.Type[]),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.MethodInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.CallingConventions),
				typeof(global::System.Type[]),
				typeof(bool)
			}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.ConstructorInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Type[]),
				typeof(bool)
			}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.PropertyInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEventCandidates", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags),
				typeof(bool)
			}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.EventInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetFieldCandidates", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags),
				typeof(bool)
			}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.FieldInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags),
				typeof(bool)
			}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Type>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodCandidates", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.CallingConventions),
				typeof(global::System.Type[]),
				typeof(bool)
			}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<global::System.Reflection.MethodInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public void Add(T item)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000564")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private T[] _items;

			[global::Cpp2ILInjected.Token(Token = "0x4000565")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private T _item;

			[global::Cpp2ILInjected.Token(Token = "0x4000566")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _count;

			[global::Cpp2ILInjected.Token(Token = "0x4000567")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _capacity;
		}
	}
}
