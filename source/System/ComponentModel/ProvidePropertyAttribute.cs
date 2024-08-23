using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002B2 RID: 690
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003AF")]
	public sealed class ProvidePropertyAttribute : Attribute
	{
		// Token: 0x060016CB RID: 5835 RVA: 0x00006E75 File Offset: 0x00005075
		[global::Cpp2ILInjected.Token(Token = "0x600192A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A1D0", Offset = "0x1E5A1D0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ProvidePropertyAttribute(string propertyName, Type receiverType)
		{
			throw null;
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x00006E78 File Offset: 0x00005078
		[global::Cpp2ILInjected.Token(Token = "0x600192B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A214", Offset = "0x1E5A214", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ProvidePropertyAttribute(string propertyName, string receiverTypeName)
		{
			throw null;
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x00006E7B File Offset: 0x0000507B
		[global::Cpp2ILInjected.Token(Token = "0x170005C4")]
		public string PropertyName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600192C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5A240", Offset = "0x1E5A240", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x00006E7E File Offset: 0x0000507E
		[global::Cpp2ILInjected.Token(Token = "0x170005C5")]
		public string ReceiverTypeName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600192D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5A248", Offset = "0x1E5A248", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x00006E81 File Offset: 0x00005081
		[global::Cpp2ILInjected.Token(Token = "0x600192E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A250", Offset = "0x1E5A250", Length = "0x9C")]
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

		// Token: 0x060016D0 RID: 5840 RVA: 0x00006E84 File Offset: 0x00005084
		[global::Cpp2ILInjected.Token(Token = "0x600192F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A2EC", Offset = "0x1E5A2EC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x00006E87 File Offset: 0x00005087
		[global::Cpp2ILInjected.Token(Token = "0x170005C6")]
		public override object TypeId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001930")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5A328", Offset = "0x1E5A328", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000E96 RID: 3734
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <PropertyName>k__BackingField;

		// Token: 0x04000E97 RID: 3735
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string <ReceiverTypeName>k__BackingField;
	}
}
