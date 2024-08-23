using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x0200043A RID: 1082
	[global::Cpp2ILInjected.Token(Token = "0x20004F9")]
	public struct CustomAttributeTypedArgument
	{
		// Token: 0x0600224D RID: 8781 RVA: 0x0001A498 File Offset: 0x00018698
		[global::Cpp2ILInjected.Token(Token = "0x60024E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B87C8C", Offset = "0x1B87C8C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeTypedArgument), Member = "CanonicalizeValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public CustomAttributeTypedArgument(object value)
		{
			throw null;
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x0001A49B File Offset: 0x0001869B
		[global::Cpp2ILInjected.Token(Token = "0x60024E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B81ADC", Offset = "0x1B81ADC", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FieldInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeNamedArgument), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeTypedArgument), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeMethodInfo), Member = "GetDllImportAttributeData", ReturnType = typeof(CustomAttributeData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeTypedArgument), Member = "CanonicalizeValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeTypedArgument), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<CustomAttributeTypedArgument>), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IList<CustomAttributeTypedArgument>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public CustomAttributeTypedArgument(global::System.Type argumentType, object value)
		{
			throw null;
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x0600224F RID: 8783 RVA: 0x0001A49E File Offset: 0x0001869E
		[global::Cpp2ILInjected.Token(Token = "0x17000516")]
		public readonly global::System.Type ArgumentType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60024E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B87DC0", Offset = "0x1B87DC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x0001A4A1 File Offset: 0x000186A1
		[global::Cpp2ILInjected.Token(Token = "0x17000517")]
		public readonly object Value
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60024EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B87DC8", Offset = "0x1B87DC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002251 RID: 8785 RVA: 0x0001A4A4 File Offset: 0x000186A4
		[global::Cpp2ILInjected.Token(Token = "0x60024EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B87DD0", Offset = "0x1B87DD0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeTypedArgument), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(CustomAttributeTypedArgument),
			typeof(CustomAttributeTypedArgument)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeTypedArgument), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(CustomAttributeTypedArgument),
			typeof(CustomAttributeTypedArgument)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeData), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x0001A4A7 File Offset: 0x000186A7
		[global::Cpp2ILInjected.Token(Token = "0x60024EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B87E40", Offset = "0x1B87E40", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeData), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x0001A4AA File Offset: 0x000186AA
		[global::Cpp2ILInjected.Token(Token = "0x60024ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B87EA4", Offset = "0x1B87EA4", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeTypedArgument), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool operator ==(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right)
		{
			throw null;
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x0001A4AD File Offset: 0x000186AD
		[global::Cpp2ILInjected.Token(Token = "0x60024EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B87F1C", Offset = "0x1B87F1C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeTypedArgument), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool operator !=(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right)
		{
			throw null;
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x0001A4B0 File Offset: 0x000186B0
		[global::Cpp2ILInjected.Token(Token = "0x60024EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B87F98", Offset = "0x1B87F98", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeTypedArgument), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x0001A4B3 File Offset: 0x000186B3
		[global::Cpp2ILInjected.Token(Token = "0x60024F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B87400", Offset = "0x1B87400", Length = "0x88C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeNamedArgument), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeTypedArgument), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeTypedArgument), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeData), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueType), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_FullNameOrDefault", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_NameOrDefault", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsArray", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomAttributeTypedArgument), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 50)]
		internal string ToString(bool typed)
		{
			throw null;
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x0001A4B6 File Offset: 0x000186B6
		[global::Cpp2ILInjected.Token(Token = "0x60024F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B87D10", Offset = "0x1B87D10", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeTypedArgument), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeTypedArgument), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "GetValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static object CanonicalizeValue(object value)
		{
			throw null;
		}

		// Token: 0x0400112A RID: 4394
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001444")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly global::System.Type <ArgumentType>k__BackingField;

		// Token: 0x0400112B RID: 4395
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001445")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private readonly object <Value>k__BackingField;
	}
}
