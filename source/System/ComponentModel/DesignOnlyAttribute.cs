using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000243 RID: 579
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x2000334")]
	public sealed class DesignOnlyAttribute : Attribute
	{
		// Token: 0x06001331 RID: 4913 RVA: 0x00006524 File Offset: 0x00004724
		[global::Cpp2ILInjected.Token(Token = "0x600156F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3BC84", Offset = "0x1E3BC84", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DesignOnlyAttribute(bool isDesignOnly)
		{
			throw null;
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x00006527 File Offset: 0x00004727
		[global::Cpp2ILInjected.Token(Token = "0x170004E3")]
		public bool IsDesignOnly
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001570")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3BCAC", Offset = "0x1E3BCAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x0000652A File Offset: 0x0000472A
		[global::Cpp2ILInjected.Token(Token = "0x6001571")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3BCB4", Offset = "0x1E3BCB4", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x0000652D File Offset: 0x0000472D
		[global::Cpp2ILInjected.Token(Token = "0x6001572")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3BD98", Offset = "0x1E3BD98", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00006530 File Offset: 0x00004730
		[global::Cpp2ILInjected.Token(Token = "0x6001573")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3BDB8", Offset = "0x1E3BDB8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x00006533 File Offset: 0x00004733
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001574")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3BE30", Offset = "0x1E3BE30", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static DesignOnlyAttribute()
		{
			throw null;
		}

		// Token: 0x04000D89 RID: 3465
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001186")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <IsDesignOnly>k__BackingField;

		// Token: 0x04000D8A RID: 3466
		[global::Cpp2ILInjected.Token(Token = "0x4001187")]
		public static readonly DesignOnlyAttribute Yes;

		// Token: 0x04000D8B RID: 3467
		[global::Cpp2ILInjected.Token(Token = "0x4001188")]
		public static readonly DesignOnlyAttribute No;

		// Token: 0x04000D8C RID: 3468
		[global::Cpp2ILInjected.Token(Token = "0x4001189")]
		public static readonly DesignOnlyAttribute Default;
	}
}
