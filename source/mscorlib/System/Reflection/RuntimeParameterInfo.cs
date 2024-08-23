using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x0200044F RID: 1103
	[global::System.Runtime.InteropServices.ComDefaultInterface(typeof(global::System.Runtime.InteropServices._ParameterInfo))]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	[global::Cpp2ILInjected.Token(Token = "0x2000511")]
	[global::System.Serializable]
	internal class RuntimeParameterInfo : ParameterInfo
	{
		// Token: 0x06002395 RID: 9109 RVA: 0x0001A7D4 File Offset: 0x000189D4
		[global::Cpp2ILInjected.Token(Token = "0x6002633")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B918B0", Offset = "0x1B918B0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParameterInfo), Member = ".ctor", ReturnType = typeof(void))]
		internal RuntimeParameterInfo(string name, global::System.Type type, int position, int attrs, object defaultValue, MemberInfo member, global::System.Runtime.InteropServices.MarshalAsAttribute marshalAs)
		{
			throw null;
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x0001A7D7 File Offset: 0x000189D7
		[global::Cpp2ILInjected.Token(Token = "0x6002634")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8F078", Offset = "0x1B8F078", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeMethodInfo), Member = "FormatNameAndSig", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimePropertyInfo), Member = "FormatNameAndSig", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "TrimEnd", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static void FormatParameters(global::System.Text.StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization)
		{
			throw null;
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x0001A7DA File Offset: 0x000189DA
		[global::Cpp2ILInjected.Token(Token = "0x6002635")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91918", Offset = "0x1B91918", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeParameterInfo), Member = "New", MemberParameters = new object[]
		{
			typeof(ParameterInfo),
			typeof(MemberInfo)
		}, ReturnType = typeof(ParameterInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParameterInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeParameterInfo), Member = "GetDefaultValueImpl", MemberParameters = new object[] { typeof(ParameterInfo) }, ReturnType = typeof(object))]
		internal RuntimeParameterInfo(ParameterInfo pinfo, MemberInfo member)
		{
			throw null;
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x0001A7DD File Offset: 0x000189DD
		[global::Cpp2ILInjected.Token(Token = "0x6002636")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91A58", Offset = "0x1B91A58", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParameterInfo), Member = ".ctor", ReturnType = typeof(void))]
		internal RuntimeParameterInfo(global::System.Type type, MemberInfo member, global::System.Runtime.InteropServices.MarshalAsAttribute marshalAs)
		{
			throw null;
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06002399 RID: 9113 RVA: 0x0001A7E0 File Offset: 0x000189E0
		[global::Cpp2ILInjected.Token(Token = "0x17000561")]
		public override object DefaultValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002637")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B91AA8", Offset = "0x1B91AA8", Length = "0x2FC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x0001A7E3 File Offset: 0x000189E3
		[global::Cpp2ILInjected.Token(Token = "0x6002638")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91DA4", Offset = "0x1B91DA4", Length = "0x5C")]
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

		// Token: 0x0600239B RID: 9115 RVA: 0x0001A7E6 File Offset: 0x000189E6
		[global::Cpp2ILInjected.Token(Token = "0x6002639")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91E00", Offset = "0x1B91E00", Length = "0x6C")]
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

		// Token: 0x0600239C RID: 9116 RVA: 0x0001A7E9 File Offset: 0x000189E9
		[global::Cpp2ILInjected.Token(Token = "0x600263A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B919A0", Offset = "0x1B919A0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeParameterInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ParameterInfo),
			typeof(MemberInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal object GetDefaultValueImpl(ParameterInfo pinfo)
		{
			throw null;
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x0001A7EC File Offset: 0x000189EC
		[global::Cpp2ILInjected.Token(Token = "0x600263B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91E6C", Offset = "0x1B91E6C", Length = "0x70")]
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

		// Token: 0x0600239E RID: 9118 RVA: 0x0001A7EF File Offset: 0x000189EF
		[global::Cpp2ILInjected.Token(Token = "0x600263C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91EDC", Offset = "0x1B91EDC", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(global::System.Type)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParameterInfo), Member = "get_IsIn", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParameterInfo), Member = "get_IsOut", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParameterInfo), Member = "get_IsOptional", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.InAttribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.OutAttribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.OptionalAttribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MarshalAsAttribute), Member = "Copy", ReturnType = typeof(global::System.Runtime.InteropServices.MarshalAsAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal object[] GetPseudoCustomAttributes()
		{
			throw null;
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x0001A7F2 File Offset: 0x000189F2
		[global::Cpp2ILInjected.Token(Token = "0x600263D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B920F0", Offset = "0x1B920F0", Length = "0x4A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(global::System.Type)
		}, ReturnType = typeof(CustomAttributeData[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParameterInfo), Member = "get_IsIn", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParameterInfo), Member = "get_IsOut", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParameterInfo), Member = "get_IsOptional", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetConstructor", MemberParameters = new object[] { typeof(global::System.Type[]) }, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeData), Member = ".ctor", MemberParameters = new object[] { typeof(ConstructorInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeTypedArgument), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ConstructorInfo),
			typeof(global::System.Collections.Generic.IList<CustomAttributeTypedArgument>),
			typeof(global::System.Collections.Generic.IList<CustomAttributeNamedArgument>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		internal CustomAttributeData[] GetPseudoCustomAttributesData()
		{
			throw null;
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x0001A7F5 File Offset: 0x000189F5
		[global::Cpp2ILInjected.Token(Token = "0x600263E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B92590", Offset = "0x1B92590", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimePropertyInfo), Member = "GetIndexParameters", ReturnType = typeof(ParameterInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeParameterInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ParameterInfo),
			typeof(MemberInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member)
		{
			throw null;
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x0001A7F8 File Offset: 0x000189F8
		[global::Cpp2ILInjected.Token(Token = "0x600263F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8ED84", Offset = "0x1B8ED84", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoMethodInfo), Member = "GetReturnParameterInfo", MemberParameters = new object[] { typeof(RuntimeMethodInfo) }, ReturnType = typeof(ParameterInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParameterInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ParameterInfo New(global::System.Type type, MemberInfo member, global::System.Runtime.InteropServices.MarshalAsAttribute marshalAs)
		{
			throw null;
		}

		// Token: 0x040011E1 RID: 4577
		[global::Cpp2ILInjected.Token(Token = "0x40014FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal global::System.Runtime.InteropServices.MarshalAsAttribute marshalAs;
	}
}
