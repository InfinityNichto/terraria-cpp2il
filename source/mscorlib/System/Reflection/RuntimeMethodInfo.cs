using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x0200044C RID: 1100
	[global::Cpp2ILInjected.Token(Token = "0x200050E")]
	[global::System.Serializable]
	[StructLayout(0)]
	internal class RuntimeMethodInfo : MethodInfo, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x0001A6D2 File Offset: 0x000188D2
		[global::Cpp2ILInjected.Token(Token = "0x17000541")]
		internal BindingFlags BindingFlags
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8EE08", Offset = "0x1B8EE08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "FilterApplyMethodInfo", MemberParameters = new object[]
			{
				typeof(RuntimeMethodInfo),
				typeof(BindingFlags),
				typeof(CallingConventions),
				typeof(global::System.Type[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x0001A6D5 File Offset: 0x000188D5
		[global::Cpp2ILInjected.Token(Token = "0x17000542")]
		public override Module Module
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8EE10", Offset = "0x1B8EE10", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x0001A6D8 File Offset: 0x000188D8
		[global::Cpp2ILInjected.Token(Token = "0x17000543")]
		private global::System.RuntimeType ReflectedTypeInternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8EE9C", Offset = "0x1B8EE9C", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeMethodInfo), Member = "GetObjectData", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Serialization.SerializationInfo),
				typeof(global::System.Runtime.Serialization.StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x0001A6DB File Offset: 0x000188DB
		[global::Cpp2ILInjected.Token(Token = "0x60025D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8EF20", Offset = "0x1B8EF20", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeMethodHandle), Member = "ConstructInstantiation", MemberParameters = new object[]
		{
			typeof(RuntimeMethodInfo),
			typeof(global::System.TypeNameFormatFlags)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeParameterInfo), Member = "FormatParameters", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			typeof(ParameterInfo[]),
			typeof(CallingConventions),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal override string FormatNameAndSig(bool serialization)
		{
			throw null;
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x0001A6DE File Offset: 0x000188DE
		[global::Cpp2ILInjected.Token(Token = "0x60025D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F234", Offset = "0x1B8F234", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(MethodInfo)
		}, ReturnType = typeof(global::System.Delegate))]
		public override global::System.Delegate CreateDelegate(global::System.Type delegateType, object target)
		{
			throw null;
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x0001A6E1 File Offset: 0x000188E1
		[global::Cpp2ILInjected.Token(Token = "0x60025D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F24C", Offset = "0x1B8F24C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "FormatTypeName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x0001A6E4 File Offset: 0x000188E4
		[global::Cpp2ILInjected.Token(Token = "0x60025D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8EE14", Offset = "0x1B8EE14", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetRuntimeModule", ReturnType = typeof(RuntimeModule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal RuntimeModule GetRuntimeModule()
		{
			throw null;
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x0001A6E7 File Offset: 0x000188E7
		[global::Cpp2ILInjected.Token(Token = "0x60025D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F2D4", Offset = "0x1B8F2D4", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeMethodInfo), Member = "get_ReflectedTypeInternal", ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeMethodInfo), Member = "SerializationToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberInfoSerializationHolder), Member = "GetSerializationInfo", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(string),
			typeof(global::System.RuntimeType),
			typeof(string),
			typeof(string),
			typeof(MemberTypes),
			typeof(global::System.Type[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x0001A6EA File Offset: 0x000188EA
		[global::Cpp2ILInjected.Token(Token = "0x60025D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F3F4", Offset = "0x1B8F3F4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberInfoSerializationHolder), Member = "GetRealObject", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeMethodInfo), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal string SerializationToString()
		{
			throw null;
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x0001A6ED File Offset: 0x000188ED
		[global::Cpp2ILInjected.Token(Token = "0x60025D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F488", Offset = "0x1B8F488", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "GetMethodImpl", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static MethodBase GetMethodFromHandleNoGenericCheck(global::System.RuntimeMethodHandle handle)
		{
			throw null;
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x0001A6F0 File Offset: 0x000188F0
		[global::Cpp2ILInjected.Token(Token = "0x60025D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F4E4", Offset = "0x1B8F4E4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodsByName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(RuntimeMethodInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetConstructors_internal", MemberParameters = new object[]
		{
			typeof(BindingFlags),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(RuntimeConstructorInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static MethodBase GetMethodFromHandleNoGenericCheck(global::System.RuntimeMethodHandle handle, global::System.RuntimeTypeHandle reflectedType)
		{
			throw null;
		}

		// Token: 0x0600233B RID: 9019
		[global::Cpp2ILInjected.Token(Token = "0x60025D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F4EC", Offset = "0x1B8F4EC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern MethodBody GetMethodBodyInternal(global::System.IntPtr handle);

		// Token: 0x0600233C RID: 9020 RVA: 0x0001A6F3 File Offset: 0x000188F3
		[global::Cpp2ILInjected.Token(Token = "0x60025DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F4F0", Offset = "0x1B8F4F0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static MethodBody GetMethodBody(global::System.IntPtr handle)
		{
			throw null;
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x0001A6F6 File Offset: 0x000188F6
		[global::Cpp2ILInjected.Token(Token = "0x60025DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F4F4", Offset = "0x1B8F4F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodBase), Member = "GetMethodFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeMethodHandle) }, ReturnType = typeof(MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static MethodBase GetMethodFromHandleInternalType(global::System.IntPtr method_handle, global::System.IntPtr type_handle)
		{
			throw null;
		}

		// Token: 0x0600233E RID: 9022
		[global::Cpp2ILInjected.Token(Token = "0x60025DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F4DC", Offset = "0x1B8F4DC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern MethodBase GetMethodFromHandleInternalType_native(global::System.IntPtr method_handle, global::System.IntPtr type_handle, bool genericCheck);

		// Token: 0x0600233F RID: 9023 RVA: 0x0001A6F9 File Offset: 0x000188F9
		[global::Cpp2ILInjected.Token(Token = "0x60025DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F4FC", Offset = "0x1B8F4FC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = ".ctor", ReturnType = typeof(void))]
		internal RuntimeMethodInfo()
		{
			throw null;
		}

		// Token: 0x06002340 RID: 9024
		[global::Cpp2ILInjected.Token(Token = "0x60025DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F504", Offset = "0x1B8F504", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern string get_name(MethodBase method);

		// Token: 0x06002341 RID: 9025
		[global::Cpp2ILInjected.Token(Token = "0x60025DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F508", Offset = "0x1B8F508", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern RuntimeMethodInfo get_base_method(RuntimeMethodInfo method, bool definition);

		// Token: 0x06002342 RID: 9026
		[global::Cpp2ILInjected.Token(Token = "0x60025E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F510", Offset = "0x1B8F510", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern int get_metadata_token(RuntimeMethodInfo method);

		// Token: 0x06002343 RID: 9027 RVA: 0x0001A6FC File Offset: 0x000188FC
		[global::Cpp2ILInjected.Token(Token = "0x60025E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F514", Offset = "0x1B8F514", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override MethodInfo GetBaseDefinition()
		{
			throw null;
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x0001A6FF File Offset: 0x000188FF
		[global::Cpp2ILInjected.Token(Token = "0x60025E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F51C", Offset = "0x1B8F51C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "InternalParamGetCustomAttributes", MemberParameters = new object[]
		{
			typeof(ParameterInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetBasePropertyDefinition", MemberParameters = new object[] { typeof(RuntimePropertyInfo) }, ReturnType = typeof(PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetBaseEventDefinition", MemberParameters = new object[] { typeof(RuntimeEventInfo) }, ReturnType = typeof(EventInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetBase", MemberParameters = new object[] { typeof(ICustomAttributeProvider) }, ReturnType = typeof(ICustomAttributeProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal MethodInfo GetBaseMethod()
		{
			throw null;
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06002345 RID: 9029 RVA: 0x0001A702 File Offset: 0x00018902
		[global::Cpp2ILInjected.Token(Token = "0x17000544")]
		public override ParameterInfo ReturnParameter
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8F524", Offset = "0x1B8F524", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoMethodInfo), Member = "GetReturnParameterInfo", MemberParameters = new object[] { typeof(RuntimeMethodInfo) }, ReturnType = typeof(ParameterInfo))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06002346 RID: 9030 RVA: 0x0001A705 File Offset: 0x00018905
		[global::Cpp2ILInjected.Token(Token = "0x17000545")]
		public override global::System.Type ReturnType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8F528", Offset = "0x1B8F528", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x0001A708 File Offset: 0x00018908
		[global::Cpp2ILInjected.Token(Token = "0x17000546")]
		public override int MetadataToken
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8F554", Offset = "0x1B8F554", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x0001A70B File Offset: 0x0001890B
		[global::Cpp2ILInjected.Token(Token = "0x60025E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F558", Offset = "0x1B8F558", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			throw null;
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x0001A70E File Offset: 0x0001890E
		[global::Cpp2ILInjected.Token(Token = "0x60025E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F584", Offset = "0x1B8F584", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "FastCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override ParameterInfo[] GetParameters()
		{
			throw null;
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x0001A711 File Offset: 0x00018911
		[global::Cpp2ILInjected.Token(Token = "0x60025E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F60C", Offset = "0x1B8F60C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override ParameterInfo[] GetParametersInternal()
		{
			throw null;
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x0001A714 File Offset: 0x00018914
		[global::Cpp2ILInjected.Token(Token = "0x60025E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F618", Offset = "0x1B8F618", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override int GetParametersCount()
		{
			throw null;
		}

		// Token: 0x0600234C RID: 9036
		[global::Cpp2ILInjected.Token(Token = "0x60025EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F634", Offset = "0x1B8F634", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.AppDomain), Member = "InvokeInDomainByID", MemberParameters = new object[]
		{
			typeof(int),
			typeof(MethodInfo),
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "GetCustomMarshalerInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(global::System.Runtime.InteropServices.ICustomMarshaler))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal extern object InternalInvoke(object obj, object[] parameters, out global::System.Exception exc);

		// Token: 0x0600234D RID: 9037 RVA: 0x0001A717 File Offset: 0x00018917
		[global::System.Diagnostics.DebuggerHidden]
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::Cpp2ILInjected.Token(Token = "0x60025EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F638", Offset = "0x1B8F638", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeMethodInfo), Member = "ConvertValues", MemberParameters = new object[]
		{
			typeof(Binder),
			typeof(object[]),
			typeof(ParameterInfo[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(BindingFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TargetException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TargetInvocationException), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, global::System.Globalization.CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x0001A71A File Offset: 0x0001891A
		[global::Cpp2ILInjected.Token(Token = "0x60025EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F914", Offset = "0x1B8F914", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeMethodInfo), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BindingFlags),
			typeof(Binder),
			typeof(object[]),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "DoInvoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BindingFlags),
			typeof(Binder),
			typeof(object[]),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "CheckValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Binder),
			typeof(global::System.Globalization.CultureInfo),
			typeof(BindingFlags)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TargetParameterCountException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		internal static void ConvertValues(Binder binder, object[] args, ParameterInfo[] pinfo, global::System.Globalization.CultureInfo culture, BindingFlags invokeAttr)
		{
			throw null;
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x0001A71D File Offset: 0x0001891D
		[global::Cpp2ILInjected.Token(Token = "0x17000547")]
		public override global::System.RuntimeMethodHandle MethodHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8FB8C", Offset = "0x1B8FB8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x0001A720 File Offset: 0x00018920
		[global::Cpp2ILInjected.Token(Token = "0x17000548")]
		public override MethodAttributes Attributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8FB94", Offset = "0x1B8FB94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06002351 RID: 9041 RVA: 0x0001A723 File Offset: 0x00018923
		[global::Cpp2ILInjected.Token(Token = "0x17000549")]
		public override CallingConventions CallingConvention
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8FB9C", Offset = "0x1B8FB9C", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x0001A726 File Offset: 0x00018926
		[global::Cpp2ILInjected.Token(Token = "0x1700054A")]
		public override global::System.Type ReflectedType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8FBC8", Offset = "0x1B8FBC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06002353 RID: 9043 RVA: 0x0001A729 File Offset: 0x00018929
		[global::Cpp2ILInjected.Token(Token = "0x1700054B")]
		public override global::System.Type DeclaringType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8FBD0", Offset = "0x1B8FBD0", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06002354 RID: 9044 RVA: 0x0001A72C File Offset: 0x0001892C
		[global::Cpp2ILInjected.Token(Token = "0x1700054C")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8FBFC", Offset = "0x1B8FBFC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x0001A72F File Offset: 0x0001892F
		[global::Cpp2ILInjected.Token(Token = "0x60025F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8FC10", Offset = "0x1B8FC10", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsDefined(global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x0001A732 File Offset: 0x00018932
		[global::Cpp2ILInjected.Token(Token = "0x60025F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8FC80", Offset = "0x1B8FC80", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw null;
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x0001A735 File Offset: 0x00018935
		[global::Cpp2ILInjected.Token(Token = "0x60025F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8FCE8", Offset = "0x1B8FCE8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override object[] GetCustomAttributes(global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x06002358 RID: 9048
		[global::Cpp2ILInjected.Token(Token = "0x60025F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8FD58", Offset = "0x1B8FD58", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.DllImportAttribute), Member = "GetCustomAttribute", MemberParameters = new object[] { typeof(RuntimeMethodInfo) }, ReturnType = typeof(global::System.Attribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal extern void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName);

		// Token: 0x06002359 RID: 9049 RVA: 0x0001A738 File Offset: 0x00018938
		[global::Cpp2ILInjected.Token(Token = "0x60025F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8FD5C", Offset = "0x1B8FD5C", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(global::System.Type)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.PreserveSigAttribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.DllImportAttribute), Member = "GetCustomAttribute", MemberParameters = new object[] { typeof(RuntimeMethodInfo) }, ReturnType = typeof(global::System.Attribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal object[] GetPseudoCustomAttributes()
		{
			throw null;
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x0001A73B File Offset: 0x0001893B
		[global::Cpp2ILInjected.Token(Token = "0x60025F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8FE90", Offset = "0x1B8FE90", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(global::System.Type)
		}, ReturnType = typeof(CustomAttributeData[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetConstructor", MemberParameters = new object[] { typeof(global::System.Type[]) }, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeData), Member = ".ctor", MemberParameters = new object[] { typeof(ConstructorInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeMethodInfo), Member = "GetDllImportAttributeData", ReturnType = typeof(CustomAttributeData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal CustomAttributeData[] GetPseudoCustomAttributesData()
		{
			throw null;
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x0001A73E File Offset: 0x0001893E
		[global::Cpp2ILInjected.Token(Token = "0x60025F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B90030", Offset = "0x1B90030", Length = "0x650")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeMethodInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeTypedArgument), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetField", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(FieldInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeNamedArgument), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetConstructor", MemberParameters = new object[] { typeof(global::System.Type[]) }, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ConstructorInfo),
			typeof(global::System.Collections.Generic.IList<CustomAttributeTypedArgument>),
			typeof(global::System.Collections.Generic.IList<CustomAttributeNamedArgument>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		private CustomAttributeData GetDllImportAttributeData()
		{
			throw null;
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x0001A741 File Offset: 0x00018941
		[global::Cpp2ILInjected.Token(Token = "0x60025FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B90680", Offset = "0x1B90680", Length = "0x318")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public override MethodInfo MakeGenericMethod(params global::System.Type[] methodInstantiation)
		{
			throw null;
		}

		// Token: 0x0600235D RID: 9053
		[global::Cpp2ILInjected.Token(Token = "0x60025FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B90998", Offset = "0x1B90998", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern MethodInfo MakeGenericMethod_impl(global::System.Type[] types);

		// Token: 0x0600235E RID: 9054
		[global::Cpp2ILInjected.Token(Token = "0x60025FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9099C", Offset = "0x1B9099C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public override extern global::System.Type[] GetGenericArguments();

		// Token: 0x0600235F RID: 9055
		[global::Cpp2ILInjected.Token(Token = "0x60025FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B909A0", Offset = "0x1B909A0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern MethodInfo GetGenericMethodDefinition_impl();

		// Token: 0x06002360 RID: 9056 RVA: 0x0001A744 File Offset: 0x00018944
		[global::Cpp2ILInjected.Token(Token = "0x60025FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B909A4", Offset = "0x1B909A4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override MethodInfo GetGenericMethodDefinition()
		{
			throw null;
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06002361 RID: 9057
		[global::Cpp2ILInjected.Token(Token = "0x1700054D")]
		public override extern bool IsGenericMethodDefinition
		{
			[global::Cpp2ILInjected.Token(Token = "0x60025FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B90A00", Offset = "0x1B90A00", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06002362 RID: 9058
		[global::Cpp2ILInjected.Token(Token = "0x1700054E")]
		public override extern bool IsGenericMethod
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002600")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B90A04", Offset = "0x1B90A04", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06002363 RID: 9059 RVA: 0x0001A747 File Offset: 0x00018947
		[global::Cpp2ILInjected.Token(Token = "0x1700054F")]
		public override bool ContainsGenericParameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002601")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B90A08", Offset = "0x1B90A08", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x0001A74A File Offset: 0x0001894A
		[global::Cpp2ILInjected.Token(Token = "0x6002602")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B90AC0", Offset = "0x1B90AC0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override MethodBody GetMethodBody()
		{
			throw null;
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x0001A74D File Offset: 0x0001894D
		[global::Cpp2ILInjected.Token(Token = "0x6002603")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B90AC8", Offset = "0x1B90AC8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int get_core_clr_security_level()
		{
			throw null;
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06002366 RID: 9062 RVA: 0x0001A750 File Offset: 0x00018950
		[global::Cpp2ILInjected.Token(Token = "0x17000550")]
		public override bool IsSecurityCritical
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002604")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B90AD0", Offset = "0x1B90AD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040011D4 RID: 4564
		[global::Cpp2ILInjected.Token(Token = "0x40014F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal global::System.IntPtr mhandle;

		// Token: 0x040011D5 RID: 4565
		[global::Cpp2ILInjected.Token(Token = "0x40014F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string name;

		// Token: 0x040011D6 RID: 4566
		[global::Cpp2ILInjected.Token(Token = "0x40014F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Type reftype;
	}
}
