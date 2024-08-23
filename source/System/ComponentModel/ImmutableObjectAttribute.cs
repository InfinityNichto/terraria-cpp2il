using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200024D RID: 589
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x200033F")]
	public sealed class ImmutableObjectAttribute : Attribute
	{
		// Token: 0x06001366 RID: 4966 RVA: 0x00006596 File Offset: 0x00004796
		[global::Cpp2ILInjected.Token(Token = "0x60015A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C884", Offset = "0x1E3C884", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ImmutableObjectAttribute(bool immutable)
		{
			throw null;
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x00006599 File Offset: 0x00004799
		[global::Cpp2ILInjected.Token(Token = "0x170004F0")]
		public bool Immutable
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3C8AC", Offset = "0x1E3C8AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x0000659C File Offset: 0x0000479C
		[global::Cpp2ILInjected.Token(Token = "0x60015A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C8B4", Offset = "0x1E3C8B4", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x0000659F File Offset: 0x0000479F
		[global::Cpp2ILInjected.Token(Token = "0x60015A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C998", Offset = "0x1E3C998", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x000065A2 File Offset: 0x000047A2
		[global::Cpp2ILInjected.Token(Token = "0x60015A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C9A0", Offset = "0x1E3C9A0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x000065A5 File Offset: 0x000047A5
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60015AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CA08", Offset = "0x1E3CA08", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static ImmutableObjectAttribute()
		{
			throw null;
		}

		// Token: 0x04000D9F RID: 3487
		[global::Cpp2ILInjected.Token(Token = "0x400119F")]
		public static readonly ImmutableObjectAttribute Yes;

		// Token: 0x04000DA0 RID: 3488
		[global::Cpp2ILInjected.Token(Token = "0x40011A0")]
		public static readonly ImmutableObjectAttribute No;

		// Token: 0x04000DA1 RID: 3489
		[global::Cpp2ILInjected.Token(Token = "0x40011A1")]
		public static readonly ImmutableObjectAttribute Default;

		// Token: 0x04000DA2 RID: 3490
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <Immutable>k__BackingField;
	}
}
