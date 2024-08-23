using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000145 RID: 325
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200018C")]
	[global::System.Serializable]
	public struct RuntimeTypeHandle : global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06000E66 RID: 3686 RVA: 0x00016DFF File Offset: 0x00014FFF
		[global::Cpp2ILInjected.Token(Token = "0x6000F51")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82D0C", Offset = "0x1C82D0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal RuntimeTypeHandle(global::System.IntPtr val)
		{
			throw null;
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x00016E02 File Offset: 0x00015002
		[global::Cpp2ILInjected.Token(Token = "0x6000F52")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82D14", Offset = "0x1C82D14", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "get_TypeHandle", ReturnType = typeof(global::System.RuntimeTypeHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodsByName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimeMethodInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetConstructors_internal", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimeConstructorInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetPropertiesByName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimePropertyInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetFields_internal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimeFieldInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEvents_internal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimeEventInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		internal RuntimeTypeHandle(global::System.RuntimeType type)
		{
			throw null;
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00016E05 File Offset: 0x00015005
		[global::Cpp2ILInjected.Token(Token = "0x6000F53")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82D20", Offset = "0x1C82D20", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private RuntimeTypeHandle(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00016E08 File Offset: 0x00015008
		[global::Cpp2ILInjected.Token(Token = "0x17000161")]
		public global::System.IntPtr Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F54")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C82EC4", Offset = "0x1C82EC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00016E0B File Offset: 0x0001500B
		[global::Cpp2ILInjected.Token(Token = "0x6000F55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82ECC", Offset = "0x1C82ECC", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeHandle", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(global::System.RuntimeTypeHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00016E0E File Offset: 0x0001500E
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6000F56")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8307C", Offset = "0x1C8307C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00016E11 File Offset: 0x00015011
		[global::Cpp2ILInjected.Token(Token = "0x6000F57")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83178", Offset = "0x1C83178", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000E6D RID: 3693
		[global::Cpp2ILInjected.Token(Token = "0x6000F58")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83180", Offset = "0x1C83180", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetAttributeFlagsImpl", ReturnType = typeof(global::System.Reflection.TypeAttributes))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern global::System.Reflection.TypeAttributes GetAttributes(global::System.RuntimeType type);

		// Token: 0x06000E6E RID: 3694
		[global::Cpp2ILInjected.Token(Token = "0x6000F59")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83184", Offset = "0x1C83184", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern int GetMetadataToken(global::System.RuntimeType type);

		// Token: 0x06000E6F RID: 3695 RVA: 0x00016E14 File Offset: 0x00015014
		[global::Cpp2ILInjected.Token(Token = "0x6000F5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83188", Offset = "0x1C83188", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "get_MetadataToken", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static int GetToken(global::System.RuntimeType type)
		{
			throw null;
		}

		// Token: 0x06000E70 RID: 3696
		[global::Cpp2ILInjected.Token(Token = "0x6000F5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8318C", Offset = "0x1C8318C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern global::System.Type GetGenericTypeDefinition_impl(global::System.RuntimeType type);

		// Token: 0x06000E71 RID: 3697 RVA: 0x00016E17 File Offset: 0x00015017
		[global::Cpp2ILInjected.Token(Token = "0x6000F5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83190", Offset = "0x1C83190", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetGenericTypeDefinition", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static global::System.Type GetGenericTypeDefinition(global::System.RuntimeType type)
		{
			throw null;
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00016E1A File Offset: 0x0001501A
		[global::Cpp2ILInjected.Token(Token = "0x6000F5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83194", Offset = "0x1C83194", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "IsPrimitiveImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static bool IsPrimitive(global::System.RuntimeType type)
		{
			throw null;
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00016E1D File Offset: 0x0001501D
		[global::Cpp2ILInjected.Token(Token = "0x6000F5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C831D4", Offset = "0x1C831D4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "IsByRefImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static bool IsByRef(global::System.RuntimeType type)
		{
			throw null;
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00016E20 File Offset: 0x00015020
		[global::Cpp2ILInjected.Token(Token = "0x6000F5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C831F0", Offset = "0x1C831F0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "IsPointerImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static bool IsPointer(global::System.RuntimeType type)
		{
			throw null;
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00016E23 File Offset: 0x00015023
		[global::Cpp2ILInjected.Token(Token = "0x6000F60")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8320C", Offset = "0x1C8320C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "IsArrayImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static bool IsArray(global::System.RuntimeType type)
		{
			throw null;
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00016E26 File Offset: 0x00015026
		[global::Cpp2ILInjected.Token(Token = "0x6000F61")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83234", Offset = "0x1C83234", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "get_IsSzArray", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static bool IsSzArray(global::System.RuntimeType type)
		{
			throw null;
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00016E29 File Offset: 0x00015029
		[global::Cpp2ILInjected.Token(Token = "0x6000F62")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83250", Offset = "0x1C83250", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "HasElementTypeImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static bool HasElementType(global::System.RuntimeType type)
		{
			throw null;
		}

		// Token: 0x06000E78 RID: 3704
		[global::Cpp2ILInjected.Token(Token = "0x6000F63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C831D0", Offset = "0x1C831D0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern global::System.Reflection.CorElementType GetCorElementType(global::System.RuntimeType type);

		// Token: 0x06000E79 RID: 3705
		[global::Cpp2ILInjected.Token(Token = "0x6000F64")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8328C", Offset = "0x1C8328C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "get_IsGenericType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern bool HasInstantiation(global::System.RuntimeType type);

		// Token: 0x06000E7A RID: 3706
		[global::Cpp2ILInjected.Token(Token = "0x6000F65")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83290", Offset = "0x1C83290", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern bool IsComObject(global::System.RuntimeType type);

		// Token: 0x06000E7B RID: 3707
		[global::Cpp2ILInjected.Token(Token = "0x6000F66")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83294", Offset = "0x1C83294", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "IsInstanceOfType", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern bool IsInstanceOfType(global::System.RuntimeType type, object o);

		// Token: 0x06000E7C RID: 3708
		[global::Cpp2ILInjected.Token(Token = "0x6000F67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83298", Offset = "0x1C83298", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "IsReferenceOrContainsReferences", MemberTypeParameters = new object[] { "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern bool HasReferences(global::System.RuntimeType type);

		// Token: 0x06000E7D RID: 3709 RVA: 0x00016E2C File Offset: 0x0001502C
		[global::Cpp2ILInjected.Token(Token = "0x6000F68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8329C", Offset = "0x1C8329C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "IsCOMObjectImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static bool IsComObject(global::System.RuntimeType type, bool isGenericCOM)
		{
			throw null;
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00016E2F File Offset: 0x0001502F
		[global::Cpp2ILInjected.Token(Token = "0x6000F69")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C832AC", Offset = "0x1C832AC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "IsContextfulImpl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static bool IsContextful(global::System.RuntimeType type)
		{
			throw null;
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00016E32 File Offset: 0x00015032
		[global::Cpp2ILInjected.Token(Token = "0x6000F6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83338", Offset = "0x1C83338", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "IsEquivalentTo", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static bool IsEquivalentTo(global::System.RuntimeType rtType1, global::System.RuntimeType rtType2)
		{
			throw null;
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00016E35 File Offset: 0x00015035
		[global::Cpp2ILInjected.Token(Token = "0x6000F6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83340", Offset = "0x1C83340", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_Attributes", ReturnType = typeof(global::System.Reflection.TypeAttributes))]
		internal static bool IsInterface(global::System.RuntimeType type)
		{
			throw null;
		}

		// Token: 0x06000E81 RID: 3713
		[global::Cpp2ILInjected.Token(Token = "0x6000F6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83358", Offset = "0x1C83358", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetArrayRank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern int GetArrayRank(global::System.RuntimeType type);

		// Token: 0x06000E82 RID: 3714
		[global::Cpp2ILInjected.Token(Token = "0x6000F6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8335C", Offset = "0x1C8335C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "get_Assembly", ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetRuntimeAssembly", ReturnType = typeof(global::System.Reflection.RuntimeAssembly))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern global::System.Reflection.RuntimeAssembly GetAssembly(global::System.RuntimeType type);

		// Token: 0x06000E83 RID: 3715
		[global::Cpp2ILInjected.Token(Token = "0x6000F6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83360", Offset = "0x1C83360", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetElementType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern global::System.RuntimeType GetElementType(global::System.RuntimeType type);

		// Token: 0x06000E84 RID: 3716
		[global::Cpp2ILInjected.Token(Token = "0x6000F6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83364", Offset = "0x1C83364", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "get_Module", ReturnType = typeof(global::System.Reflection.Module))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetRuntimeModule", ReturnType = typeof(global::System.Reflection.RuntimeModule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeConstructorInfo), Member = "GetRuntimeModule", ReturnType = typeof(global::System.Reflection.RuntimeModule))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern global::System.Reflection.RuntimeModule GetModule(global::System.RuntimeType type);

		// Token: 0x06000E85 RID: 3717
		[global::Cpp2ILInjected.Token(Token = "0x6000F70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83368", Offset = "0x1C83368", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetBaseType", ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "get_IsGenericParameter", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern bool IsGenericVariable(global::System.RuntimeType type);

		// Token: 0x06000E86 RID: 3718
		[global::Cpp2ILInjected.Token(Token = "0x6000F71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8336C", Offset = "0x1C8336C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetBaseType", ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern global::System.RuntimeType GetBaseType(global::System.RuntimeType type);

		// Token: 0x06000E87 RID: 3719 RVA: 0x00016E38 File Offset: 0x00015038
		[global::Cpp2ILInjected.Token(Token = "0x6000F72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83370", Offset = "0x1C83370", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "IsAssignableFrom", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static bool CanCastTo(global::System.RuntimeType type, global::System.RuntimeType target)
		{
			throw null;
		}

		// Token: 0x06000E88 RID: 3720
		[global::Cpp2ILInjected.Token(Token = "0x6000F73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83380", Offset = "0x1C83380", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool type_is_assignable_from(global::System.Type a, global::System.Type b);

		// Token: 0x06000E89 RID: 3721
		[global::Cpp2ILInjected.Token(Token = "0x6000F74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83384", Offset = "0x1C83384", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "get_IsGenericTypeDefinition", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern bool IsGenericTypeDefinition(global::System.RuntimeType type);

		// Token: 0x06000E8A RID: 3722
		[global::Cpp2ILInjected.Token(Token = "0x6000F75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83388", Offset = "0x1C83388", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetGenericParameterConstraints", ReturnType = typeof(global::System.Type[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetGenericParameterAttributes", ReturnType = typeof(global::System.Reflection.GenericParameterAttributes))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern global::System.IntPtr GetGenericParameterInfo(global::System.RuntimeType type);

		// Token: 0x06000E8B RID: 3723 RVA: 0x00016E3B File Offset: 0x0001503B
		[global::Cpp2ILInjected.Token(Token = "0x6000F76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8338C", Offset = "0x1C8338C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "IsSubclassOf", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static bool IsSubclassOf(global::System.RuntimeType childType, global::System.RuntimeType baseType)
		{
			throw null;
		}

		// Token: 0x06000E8C RID: 3724
		[global::Cpp2ILInjected.Token(Token = "0x6000F77")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C83398", Offset = "0x1C83398", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern bool is_subclass_of(global::System.IntPtr childType, global::System.IntPtr baseType);

		// Token: 0x06000E8D RID: 3725
		[global::Cpp2ILInjected.Token(Token = "0x6000F78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8339C", Offset = "0x1C8339C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern global::System.RuntimeType internal_from_name(string name, ref global::System.Threading.StackCrawlMark stackMark, global::System.Reflection.Assembly callerAssembly, bool throwOnError, bool ignoreCase, bool reflectionOnly);

		// Token: 0x06000E8E RID: 3726 RVA: 0x00016E3E File Offset: 0x0001503E
		[global::Cpp2ILInjected.Token(Token = "0x6000F79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C833AC", Offset = "0x1C833AC", Length = "0x34C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "ReflectionOnlyLoad", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeLoadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		internal static global::System.RuntimeType GetTypeByName(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref global::System.Threading.StackCrawlMark stackMark, bool loadTypeFromPartialName)
		{
			throw null;
		}

		// Token: 0x040004C6 RID: 1222
		[global::Cpp2ILInjected.Token(Token = "0x4000697")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.IntPtr value;
	}
}
