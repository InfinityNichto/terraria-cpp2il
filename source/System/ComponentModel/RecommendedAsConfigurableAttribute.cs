using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002B3 RID: 691
	[AttributeUsage(AttributeTargets.Property)]
	[Obsolete("Use System.ComponentModel.SettingsBindableAttribute instead to work with the new settings model.")]
	[global::Cpp2ILInjected.Token(Token = "0x20003B0")]
	public class RecommendedAsConfigurableAttribute : Attribute
	{
		// Token: 0x060016D2 RID: 5842 RVA: 0x00006E8A File Offset: 0x0000508A
		[global::Cpp2ILInjected.Token(Token = "0x6001931")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A358", Offset = "0x1E5A358", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public RecommendedAsConfigurableAttribute(bool recommendedAsConfigurable)
		{
			throw null;
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x060016D3 RID: 5843 RVA: 0x00006E8D File Offset: 0x0000508D
		[global::Cpp2ILInjected.Token(Token = "0x170005C7")]
		public bool RecommendedAsConfigurable
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001932")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5A380", Offset = "0x1E5A380", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x00006E90 File Offset: 0x00005090
		[global::Cpp2ILInjected.Token(Token = "0x6001933")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A388", Offset = "0x1E5A388", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00006E93 File Offset: 0x00005093
		[global::Cpp2ILInjected.Token(Token = "0x6001934")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A430", Offset = "0x1E5A430", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x00006E96 File Offset: 0x00005096
		[global::Cpp2ILInjected.Token(Token = "0x6001935")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A438", Offset = "0x1E5A438", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x00006E99 File Offset: 0x00005099
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001936")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A448", Offset = "0x1E5A448", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static RecommendedAsConfigurableAttribute()
		{
			throw null;
		}

		// Token: 0x04000E98 RID: 3736
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <RecommendedAsConfigurable>k__BackingField;

		// Token: 0x04000E99 RID: 3737
		[global::Cpp2ILInjected.Token(Token = "0x40012B6")]
		public static readonly RecommendedAsConfigurableAttribute No;

		// Token: 0x04000E9A RID: 3738
		[global::Cpp2ILInjected.Token(Token = "0x40012B7")]
		public static readonly RecommendedAsConfigurableAttribute Yes;

		// Token: 0x04000E9B RID: 3739
		[global::Cpp2ILInjected.Token(Token = "0x40012B8")]
		public static readonly RecommendedAsConfigurableAttribute Default;
	}
}
