using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000258 RID: 600
	[AttributeUsage(AttributeTargets.Property)]
	[global::Cpp2ILInjected.Token(Token = "0x200034C")]
	public class AttributeProviderAttribute : Attribute
	{
		// Token: 0x060013B2 RID: 5042 RVA: 0x0000666E File Offset: 0x0000486E
		[global::Cpp2ILInjected.Token(Token = "0x60015F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3EF54", Offset = "0x1E3EF54", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public AttributeProviderAttribute(string typeName)
		{
			throw null;
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x00006671 File Offset: 0x00004871
		[global::Cpp2ILInjected.Token(Token = "0x60015F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3EFC8", Offset = "0x1E3EFC8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public AttributeProviderAttribute(string typeName, string propertyName)
		{
			throw null;
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x00006674 File Offset: 0x00004874
		[global::Cpp2ILInjected.Token(Token = "0x60015F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3F064", Offset = "0x1E3F064", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public AttributeProviderAttribute(Type type)
		{
			throw null;
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x00006677 File Offset: 0x00004877
		[global::Cpp2ILInjected.Token(Token = "0x170004FE")]
		public string TypeName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3F140", Offset = "0x1E3F140", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x0000667A File Offset: 0x0000487A
		[global::Cpp2ILInjected.Token(Token = "0x170004FF")]
		public string PropertyName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3F148", Offset = "0x1E3F148", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000DB9 RID: 3513
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <TypeName>k__BackingField;

		// Token: 0x04000DBA RID: 3514
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string <PropertyName>k__BackingField;
	}
}
