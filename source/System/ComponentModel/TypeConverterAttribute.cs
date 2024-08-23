using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002C1 RID: 705
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x20003BF")]
	public sealed class TypeConverterAttribute : Attribute
	{
		// Token: 0x0600171F RID: 5919 RVA: 0x00006F65 File Offset: 0x00005165
		[global::Cpp2ILInjected.Token(Token = "0x6001980")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5E978", Offset = "0x1E5E978", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeConverterAttribute), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public TypeConverterAttribute()
		{
			throw null;
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x00006F68 File Offset: 0x00005168
		[global::Cpp2ILInjected.Token(Token = "0x6001981")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5E9D4", Offset = "0x1E5E9D4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public TypeConverterAttribute(Type type)
		{
			throw null;
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x00006F6B File Offset: 0x0000516B
		[global::Cpp2ILInjected.Token(Token = "0x6001982")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5EA10", Offset = "0x1E5EA10", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public TypeConverterAttribute(string typeName)
		{
			throw null;
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x00006F6E File Offset: 0x0000516E
		[global::Cpp2ILInjected.Token(Token = "0x170005D5")]
		public string ConverterTypeName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001983")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5EA38", Offset = "0x1E5EA38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x00006F71 File Offset: 0x00005171
		[global::Cpp2ILInjected.Token(Token = "0x6001984")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5EA40", Offset = "0x1E5EA40", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x00006F74 File Offset: 0x00005174
		[global::Cpp2ILInjected.Token(Token = "0x6001985")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5EAB4", Offset = "0x1E5EAB4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00006F77 File Offset: 0x00005177
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001986")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5EAC4", Offset = "0x1E5EAC4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeConverterAttribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static TypeConverterAttribute()
		{
			throw null;
		}

		// Token: 0x04000EB5 RID: 3765
		[global::Cpp2ILInjected.Token(Token = "0x40012D3")]
		public static readonly TypeConverterAttribute Default;

		// Token: 0x04000EB6 RID: 3766
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <ConverterTypeName>k__BackingField;
	}
}
