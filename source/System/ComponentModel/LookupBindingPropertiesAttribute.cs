using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002A8 RID: 680
	[AttributeUsage(AttributeTargets.Class)]
	[global::Cpp2ILInjected.Token(Token = "0x20003A0")]
	public sealed class LookupBindingPropertiesAttribute : Attribute
	{
		// Token: 0x060015CF RID: 5583 RVA: 0x00006B99 File Offset: 0x00004D99
		[global::Cpp2ILInjected.Token(Token = "0x600181D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50104", Offset = "0x1E50104", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public LookupBindingPropertiesAttribute()
		{
			throw null;
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00006B9C File Offset: 0x00004D9C
		[global::Cpp2ILInjected.Token(Token = "0x600181E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50124", Offset = "0x1E50124", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public LookupBindingPropertiesAttribute(string dataSource, string displayMember, string valueMember, string lookupMember)
		{
			throw null;
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x00006B9F File Offset: 0x00004D9F
		[global::Cpp2ILInjected.Token(Token = "0x17000581")]
		public string DataSource
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600181F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E50164", Offset = "0x1E50164", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060015D2 RID: 5586 RVA: 0x00006BA2 File Offset: 0x00004DA2
		[global::Cpp2ILInjected.Token(Token = "0x17000582")]
		public string DisplayMember
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001820")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5016C", Offset = "0x1E5016C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060015D3 RID: 5587 RVA: 0x00006BA5 File Offset: 0x00004DA5
		[global::Cpp2ILInjected.Token(Token = "0x17000583")]
		public string ValueMember
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001821")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E50174", Offset = "0x1E50174", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x00006BA8 File Offset: 0x00004DA8
		[global::Cpp2ILInjected.Token(Token = "0x17000584")]
		public string LookupMember
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001822")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5017C", Offset = "0x1E5017C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00006BAB File Offset: 0x00004DAB
		[global::Cpp2ILInjected.Token(Token = "0x6001823")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50184", Offset = "0x1E50184", Length = "0xB4")]
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

		// Token: 0x060015D6 RID: 5590 RVA: 0x00006BAE File Offset: 0x00004DAE
		[global::Cpp2ILInjected.Token(Token = "0x6001824")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50238", Offset = "0x1E50238", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x00006BB1 File Offset: 0x00004DB1
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001825")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E50240", Offset = "0x1E50240", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static LookupBindingPropertiesAttribute()
		{
			throw null;
		}

		// Token: 0x04000E49 RID: 3657
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001253")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <DataSource>k__BackingField;

		// Token: 0x04000E4A RID: 3658
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001254")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string <DisplayMember>k__BackingField;

		// Token: 0x04000E4B RID: 3659
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001255")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly string <ValueMember>k__BackingField;

		// Token: 0x04000E4C RID: 3660
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001256")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly string <LookupMember>k__BackingField;

		// Token: 0x04000E4D RID: 3661
		[global::Cpp2ILInjected.Token(Token = "0x4001257")]
		public static readonly LookupBindingPropertiesAttribute Default;
	}
}
