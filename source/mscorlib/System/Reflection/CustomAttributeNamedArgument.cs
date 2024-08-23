using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Runtime.Augments;

namespace System.Reflection
{
	// Token: 0x02000439 RID: 1081
	[global::Cpp2ILInjected.Token(Token = "0x20004F8")]
	public struct CustomAttributeNamedArgument
	{
		// Token: 0x06002241 RID: 8769 RVA: 0x0001A474 File Offset: 0x00018674
		[global::Cpp2ILInjected.Token(Token = "0x60024DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B86A7C", Offset = "0x1B86A7C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal CustomAttributeNamedArgument(global::System.Type attributeType, string memberName, bool isField, CustomAttributeTypedArgument typedValue)
		{
			throw null;
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x0001A477 File Offset: 0x00018677
		[global::Cpp2ILInjected.Token(Token = "0x60024DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B86AA4", Offset = "0x1B86AA4", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeMethodInfo), Member = "GetDllImportAttributeData", ReturnType = typeof(CustomAttributeData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeTypedArgument), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public CustomAttributeNamedArgument(MemberInfo memberInfo, object value)
		{
			throw null;
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x0001A47A File Offset: 0x0001867A
		[global::Cpp2ILInjected.Token(Token = "0x60024DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B86CC8", Offset = "0x1B86CC8", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public CustomAttributeNamedArgument(MemberInfo memberInfo, CustomAttributeTypedArgument typedArgument)
		{
			throw null;
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x0001A47D File Offset: 0x0001867D
		[global::Cpp2ILInjected.Token(Token = "0x17000512")]
		public readonly CustomAttributeTypedArgument TypedValue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60024DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B86DE4", Offset = "0x1B86DE4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06002245 RID: 8773 RVA: 0x0001A480 File Offset: 0x00018680
		[global::Cpp2ILInjected.Token(Token = "0x17000513")]
		public readonly bool IsField
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60024DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B86DF0", Offset = "0x1B86DF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06002246 RID: 8774 RVA: 0x0001A483 File Offset: 0x00018683
		[global::Cpp2ILInjected.Token(Token = "0x17000514")]
		public readonly string MemberName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60024E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B86DF8", Offset = "0x1B86DF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x0001A486 File Offset: 0x00018686
		[global::Cpp2ILInjected.Token(Token = "0x17000515")]
		public MemberInfo MemberInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x60024E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B86E00", Offset = "0x1B86E00", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(MemberInfo),
				typeof(MemberInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetProperty", MemberParameters = new object[]
			{
				typeof(string),
				typeof(BindingFlags)
			}, ReturnType = typeof(PropertyInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Runtime.Augments.ReflectionExecutionDomainCallbacks), Member = "CreateMissingMetadataException", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x0001A489 File Offset: 0x00018689
		[global::Cpp2ILInjected.Token(Token = "0x60024E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B86EFC", Offset = "0x1B86EFC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeNamedArgument), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(CustomAttributeNamedArgument),
			typeof(CustomAttributeNamedArgument)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeNamedArgument), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(CustomAttributeNamedArgument),
			typeof(CustomAttributeNamedArgument)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeData), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x0001A48C File Offset: 0x0001868C
		[global::Cpp2ILInjected.Token(Token = "0x60024E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B86F74", Offset = "0x1B86F74", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeData), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x0001A48F File Offset: 0x0001868F
		[global::Cpp2ILInjected.Token(Token = "0x60024E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B86FE0", Offset = "0x1B86FE0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeNamedArgument), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool operator ==(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right)
		{
			throw null;
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x0001A492 File Offset: 0x00018692
		[global::Cpp2ILInjected.Token(Token = "0x60024E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B87060", Offset = "0x1B87060", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeNamedArgument), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool operator !=(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right)
		{
			throw null;
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x0001A495 File Offset: 0x00018695
		[global::Cpp2ILInjected.Token(Token = "0x60024E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B870E4", Offset = "0x1B870E4", Length = "0x31C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeData), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueType), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeTypedArgument), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04001125 RID: 4389
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400143F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly CustomAttributeTypedArgument <TypedValue>k__BackingField;

		// Token: 0x04001126 RID: 4390
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001440")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <IsField>k__BackingField;

		// Token: 0x04001127 RID: 4391
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001441")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string <MemberName>k__BackingField;

		// Token: 0x04001128 RID: 4392
		[global::Cpp2ILInjected.Token(Token = "0x4001442")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly global::System.Type _attributeType;

		// Token: 0x04001129 RID: 4393
		[global::Cpp2ILInjected.Token(Token = "0x4001443")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private MemberInfo _lazyMemberInfo;
	}
}
