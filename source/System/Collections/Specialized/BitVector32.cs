using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Specialized
{
	// Token: 0x02000304 RID: 772
	[global::Cpp2ILInjected.Token(Token = "0x2000417")]
	public struct BitVector32
	{
		// Token: 0x170005FE RID: 1534
		[global::Cpp2ILInjected.Token(Token = "0x17000640")]
		public bool this[int bit]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001C20")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8C7E8", Offset = "0x1E8C7E8", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "get_AllowPromptAsInput", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "get_IncludeLiterals", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "get_IncludePrompt", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "get_AsciiOnly", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "get_ResetOnPrompt", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "get_ResetOnSpace", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "get_SkipLiterals", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_AmbientValue", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_ChangedEventValue", ReturnType = typeof(EventDescriptor))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_IPropChangedEventValue", ReturnType = typeof(EventDescriptor))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_DefaultValue", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_GetMethodValue", ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_ResetMethodValue", ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_SetMethodValue", ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_ShouldSerializeMethodValue", ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "OnValueChanged", MemberParameters = new object[]
			{
				typeof(object),
				typeof(EventArgs)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001C21")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8C800", Offset = "0x1E8C800", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(CultureInfo),
				typeof(bool),
				typeof(char),
				typeof(char),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "set_IncludeLiterals", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "set_IncludePrompt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "set_ResetOnPrompt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "set_ResetOnSpace", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = "set_SkipLiterals", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(string),
				typeof(Type),
				typeof(PropertyInfo),
				typeof(MethodInfo),
				typeof(MethodInfo),
				typeof(Attribute[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(string),
				typeof(Type),
				typeof(Type),
				typeof(MethodInfo),
				typeof(MethodInfo),
				typeof(Attribute[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(PropertyDescriptor),
				typeof(Attribute[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_AmbientValue", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_ChangedEventValue", ReturnType = typeof(EventDescriptor))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_IPropChangedEventValue", ReturnType = typeof(EventDescriptor))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "set_IPropChangedEventValue", MemberParameters = new object[] { typeof(EventDescriptor) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_DefaultValue", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_GetMethodValue", ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_ResetMethodValue", ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_SetMethodValue", ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_ShouldSerializeMethodValue", ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x00007529 File Offset: 0x00005729
		[global::Cpp2ILInjected.Token(Token = "0x6001C22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8C81C", Offset = "0x1E8C81C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static int CreateMask()
		{
			throw null;
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x0000752C File Offset: 0x0000572C
		[global::Cpp2ILInjected.Token(Token = "0x6001C23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8C824", Offset = "0x1E8C824", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaskedTextProvider), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static int CreateMask(int previous)
		{
			throw null;
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x0000752F File Offset: 0x0000572F
		[global::Cpp2ILInjected.Token(Token = "0x6001C24")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8C890", Offset = "0x1E8C890", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object o)
		{
			throw null;
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00007532 File Offset: 0x00005732
		[global::Cpp2ILInjected.Token(Token = "0x6001C25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8C908", Offset = "0x1E8C908", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00007535 File Offset: 0x00005735
		[global::Cpp2ILInjected.Token(Token = "0x6001C26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8C96C", Offset = "0x1E8C96C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BitVector32), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static string ToString(BitVector32 value)
		{
			throw null;
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00007538 File Offset: 0x00005738
		[global::Cpp2ILInjected.Token(Token = "0x6001C27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8CA34", Offset = "0x1E8CA34", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "ToString", MemberParameters = new object[] { typeof(BitVector32) }, ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04000F54 RID: 3924
		[global::Cpp2ILInjected.Token(Token = "0x4001395")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private uint _data;
	}
}
