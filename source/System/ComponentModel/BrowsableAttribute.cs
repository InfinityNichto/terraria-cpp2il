using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000240 RID: 576
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x2000331")]
	public sealed class BrowsableAttribute : Attribute
	{
		// Token: 0x0600131E RID: 4894 RVA: 0x000064EB File Offset: 0x000046EB
		[global::Cpp2ILInjected.Token(Token = "0x600155C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3B1C0", Offset = "0x1E3B1C0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public BrowsableAttribute(bool browsable)
		{
			throw null;
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600131F RID: 4895 RVA: 0x000064EE File Offset: 0x000046EE
		[global::Cpp2ILInjected.Token(Token = "0x170004DE")]
		public bool Browsable
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600155D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3B1E8", Offset = "0x1E3B1E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x000064F1 File Offset: 0x000046F1
		[global::Cpp2ILInjected.Token(Token = "0x600155E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3B1F0", Offset = "0x1E3B1F0", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x000064F4 File Offset: 0x000046F4
		[global::Cpp2ILInjected.Token(Token = "0x600155F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3B2D4", Offset = "0x1E3B2D4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x000064F7 File Offset: 0x000046F7
		[global::Cpp2ILInjected.Token(Token = "0x6001560")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3B2F4", Offset = "0x1E3B2F4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x000064FA File Offset: 0x000046FA
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001561")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3B35C", Offset = "0x1E3B35C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static BrowsableAttribute()
		{
			throw null;
		}

		// Token: 0x04000D83 RID: 3459
		[global::Cpp2ILInjected.Token(Token = "0x4001180")]
		public static readonly BrowsableAttribute Yes;

		// Token: 0x04000D84 RID: 3460
		[global::Cpp2ILInjected.Token(Token = "0x4001181")]
		public static readonly BrowsableAttribute No;

		// Token: 0x04000D85 RID: 3461
		[global::Cpp2ILInjected.Token(Token = "0x4001182")]
		public static readonly BrowsableAttribute Default;

		// Token: 0x04000D86 RID: 3462
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001183")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <Browsable>k__BackingField;
	}
}
