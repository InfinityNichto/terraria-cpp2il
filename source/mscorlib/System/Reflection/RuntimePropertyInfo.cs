using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono;

namespace System.Reflection
{
	// Token: 0x02000452 RID: 1106
	[global::Cpp2ILInjected.Token(Token = "0x2000514")]
	[global::System.Serializable]
	[StructLayout(0)]
	internal class RuntimePropertyInfo : PropertyInfo, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x060023A2 RID: 9122
		[global::Cpp2ILInjected.Token(Token = "0x6002640")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B925F8", Offset = "0x1B925F8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern void get_property_info(RuntimePropertyInfo prop, ref MonoPropertyInfo info, PInfo req_info);

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060023A3 RID: 9123 RVA: 0x0001A7FB File Offset: 0x000189FB
		[global::Cpp2ILInjected.Token(Token = "0x17000562")]
		internal BindingFlags BindingFlags
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002641")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B925FC", Offset = "0x1B925FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new object[]
			{
				typeof(string),
				typeof(BindingFlags),
				typeof(global::System.Type[]),
				typeof(bool)
			}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<PropertyInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x0001A7FE File Offset: 0x000189FE
		[global::Cpp2ILInjected.Token(Token = "0x17000563")]
		public override Module Module
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002642")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B92604", Offset = "0x1B92604", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimePropertyInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(global::System.RuntimeType))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetRuntimeModule", ReturnType = typeof(RuntimeModule))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x0001A801 File Offset: 0x00018A01
		[global::Cpp2ILInjected.Token(Token = "0x6002643")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9262C", Offset = "0x1B9262C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimePropertyInfo), Member = "get_Module", ReturnType = typeof(Module))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimePropertyInfo), Member = "GetRuntimeModule", ReturnType = typeof(RuntimeModule))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal global::System.RuntimeType GetDeclaringTypeInternal()
		{
			throw null;
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060023A6 RID: 9126 RVA: 0x0001A804 File Offset: 0x00018A04
		[global::Cpp2ILInjected.Token(Token = "0x17000564")]
		private global::System.RuntimeType ReflectedTypeInternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002644")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B926B0", Offset = "0x1B926B0", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimePropertyInfo), Member = "GetObjectData", MemberParameters = new object[]
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

		// Token: 0x060023A7 RID: 9127 RVA: 0x0001A807 File Offset: 0x00018A07
		[global::Cpp2ILInjected.Token(Token = "0x6002645")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B92618", Offset = "0x1B92618", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimePropertyInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetRuntimeModule", ReturnType = typeof(RuntimeModule))]
		internal RuntimeModule GetRuntimeModule()
		{
			throw null;
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x0001A80A File Offset: 0x00018A0A
		[global::Cpp2ILInjected.Token(Token = "0x6002646")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B92734", Offset = "0x1B92734", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x0001A80D File Offset: 0x00018A0D
		[global::Cpp2ILInjected.Token(Token = "0x6002647")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9273C", Offset = "0x1B9273C", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimePropertyInfo), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimePropertyInfo), Member = "SerializationToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeParameterInfo), Member = "FormatParameters", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			typeof(ParameterInfo[]),
			typeof(CallingConventions),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private string FormatNameAndSig(bool serialization)
		{
			throw null;
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x0001A810 File Offset: 0x00018A10
		[global::Cpp2ILInjected.Token(Token = "0x6002648")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B928A0", Offset = "0x1B928A0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimePropertyInfo), Member = "get_ReflectedTypeInternal", ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimePropertyInfo), Member = "FormatNameAndSig", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
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

		// Token: 0x060023AB RID: 9131 RVA: 0x0001A813 File Offset: 0x00018A13
		[global::Cpp2ILInjected.Token(Token = "0x6002649")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9296C", Offset = "0x1B9296C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberInfoSerializationHolder), Member = "GetRealObject", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimePropertyInfo), Member = "FormatNameAndSig", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		internal string SerializationToString()
		{
			throw null;
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x0001A816 File Offset: 0x00018A16
		[global::Cpp2ILInjected.Token(Token = "0x600264A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B92974", Offset = "0x1B92974", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void CachePropertyInfo(PInfo flags)
		{
			throw null;
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060023AD RID: 9133 RVA: 0x0001A819 File Offset: 0x00018A19
		[global::Cpp2ILInjected.Token(Token = "0x17000565")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x600264B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B929B4", Offset = "0x1B929B4", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(MethodInfo),
				typeof(MethodInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x0001A81C File Offset: 0x00018A1C
		[global::Cpp2ILInjected.Token(Token = "0x17000566")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x600264C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B929F4", Offset = "0x1B929F4", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(MethodInfo),
				typeof(MethodInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060023AF RID: 9135 RVA: 0x0001A81F File Offset: 0x00018A1F
		[global::Cpp2ILInjected.Token(Token = "0x17000567")]
		public override global::System.Type PropertyType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600264D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B92A34", Offset = "0x1B92A34", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(MethodInfo),
				typeof(MethodInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x0001A822 File Offset: 0x00018A22
		[global::Cpp2ILInjected.Token(Token = "0x17000568")]
		public override global::System.Type ReflectedType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600264E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B92AC8", Offset = "0x1B92AC8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060023B1 RID: 9137 RVA: 0x0001A825 File Offset: 0x00018A25
		[global::Cpp2ILInjected.Token(Token = "0x17000569")]
		public override global::System.Type DeclaringType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600264F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B92B00", Offset = "0x1B92B00", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060023B2 RID: 9138 RVA: 0x0001A828 File Offset: 0x00018A28
		[global::Cpp2ILInjected.Token(Token = "0x1700056A")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002650")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B92B38", Offset = "0x1B92B38", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x0001A82B File Offset: 0x00018A2B
		[global::Cpp2ILInjected.Token(Token = "0x6002651")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B92B70", Offset = "0x1B92B70", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override MethodInfo GetGetMethod(bool nonPublic)
		{
			throw null;
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x0001A82E File Offset: 0x00018A2E
		[global::Cpp2ILInjected.Token(Token = "0x6002652")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B92BEC", Offset = "0x1B92BEC", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeParameterInfo), Member = "New", MemberParameters = new object[]
		{
			typeof(ParameterInfo),
			typeof(MemberInfo)
		}, ReturnType = typeof(ParameterInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override ParameterInfo[] GetIndexParameters()
		{
			throw null;
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x0001A831 File Offset: 0x00018A31
		[global::Cpp2ILInjected.Token(Token = "0x6002653")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B92D70", Offset = "0x1B92D70", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override MethodInfo GetSetMethod(bool nonPublic)
		{
			throw null;
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x0001A834 File Offset: 0x00018A34
		[global::Cpp2ILInjected.Token(Token = "0x6002654")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B92DEC", Offset = "0x1B92DEC", Length = "0x6C")]
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

		// Token: 0x060023B7 RID: 9143 RVA: 0x0001A837 File Offset: 0x00018A37
		[global::Cpp2ILInjected.Token(Token = "0x6002655")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B92E58", Offset = "0x1B92E58", Length = "0x5C")]
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

		// Token: 0x060023B8 RID: 9144 RVA: 0x0001A83A File Offset: 0x00018A3A
		[global::Cpp2ILInjected.Token(Token = "0x6002656")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B92EB4", Offset = "0x1B92EB4", Length = "0x6C")]
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

		// Token: 0x060023B9 RID: 9145 RVA: 0x0001A83D File Offset: 0x00018A3D
		[global::Cpp2ILInjected.Token(Token = "0x6002657")]
		[global::Cpp2ILInjected.Address(RVA = "0x159AFF0", Offset = "0x159AFF0", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static object GetterAdapterFrame<T, R>(RuntimePropertyInfo.Getter<T, R> getter, object obj)
		{
			throw null;
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x0001A840 File Offset: 0x00018A40
		[global::Cpp2ILInjected.Token(Token = "0x6002658")]
		[global::Cpp2ILInjected.Address(RVA = "0x159B078", Offset = "0x159B078", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static object StaticGetterAdapterFrame<R>(RuntimePropertyInfo.StaticGetter<R> getter, object obj)
		{
			throw null;
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x0001A843 File Offset: 0x00018A43
		[global::Cpp2ILInjected.Token(Token = "0x6002659")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B92F20", Offset = "0x1B92F20", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override object GetValue(object obj, object[] index)
		{
			throw null;
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x0001A846 File Offset: 0x00018A46
		[global::Cpp2ILInjected.Token(Token = "0x600265A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B92F40", Offset = "0x1B92F40", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TargetInvocationException), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, global::System.Globalization.CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x0001A849 File Offset: 0x00018A49
		[global::Cpp2ILInjected.Token(Token = "0x600265B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9311C", Offset = "0x1B9311C", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, global::System.Globalization.CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060023BE RID: 9150 RVA: 0x0001A84C File Offset: 0x00018A4C
		[global::Cpp2ILInjected.Token(Token = "0x1700056B")]
		public override int MetadataToken
		{
			[global::Cpp2ILInjected.Token(Token = "0x600265C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B932F0", Offset = "0x1B932F0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060023BF RID: 9151
		[global::Cpp2ILInjected.Token(Token = "0x600265D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B932F4", Offset = "0x1B932F4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern int get_metadata_token(RuntimePropertyInfo monoProperty);

		// Token: 0x060023C0 RID: 9152
		[global::Cpp2ILInjected.Token(Token = "0x600265E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B932F8", Offset = "0x1B932F8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern PropertyInfo internal_from_handle_type(global::System.IntPtr event_handle, global::System.IntPtr type_handle);

		// Token: 0x060023C1 RID: 9153 RVA: 0x0001A84F File Offset: 0x00018A4F
		[global::Cpp2ILInjected.Token(Token = "0x600265F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B932FC", Offset = "0x1B932FC", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetPropertiesByName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(RuntimePropertyInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(PropertyInfo),
			typeof(PropertyInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static PropertyInfo GetPropertyFromHandle(global::Mono.RuntimePropertyHandle handle, global::System.RuntimeTypeHandle reflectedType)
		{
			throw null;
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x0001A852 File Offset: 0x00018A52
		[global::Cpp2ILInjected.Token(Token = "0x6002660")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B933F0", Offset = "0x1B933F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyInfo), Member = ".ctor", ReturnType = typeof(void))]
		public RuntimePropertyInfo()
		{
			throw null;
		}

		// Token: 0x040011EF RID: 4591
		[global::Cpp2ILInjected.Token(Token = "0x400150D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal global::System.IntPtr klass;

		// Token: 0x040011F0 RID: 4592
		[global::Cpp2ILInjected.Token(Token = "0x400150E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal global::System.IntPtr prop;

		// Token: 0x040011F1 RID: 4593
		[global::Cpp2ILInjected.Token(Token = "0x400150F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private MonoPropertyInfo info;

		// Token: 0x040011F2 RID: 4594
		[global::Cpp2ILInjected.Token(Token = "0x4001510")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private PInfo cached;

		// Token: 0x040011F3 RID: 4595
		[global::Cpp2ILInjected.Token(Token = "0x4001511")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private RuntimePropertyInfo.GetterAdapter cached_getter;

		// Token: 0x0200060D RID: 1549
		// (Invoke) Token: 0x06004176 RID: 16758
		[global::Cpp2ILInjected.Token(Token = "0x2000515")]
		private delegate object GetterAdapter(object _this);

		// Token: 0x0200060E RID: 1550
		// (Invoke) Token: 0x06004178 RID: 16760
		[global::Cpp2ILInjected.Token(Token = "0x2000516")]
		private delegate R Getter<T, R>(T _this);

		// Token: 0x0200060F RID: 1551
		// (Invoke) Token: 0x0600417A RID: 16762
		[global::Cpp2ILInjected.Token(Token = "0x2000517")]
		private delegate R StaticGetter<R>();
	}
}
