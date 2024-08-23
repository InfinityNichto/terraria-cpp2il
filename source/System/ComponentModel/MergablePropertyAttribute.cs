using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000251 RID: 593
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x2000343")]
	public sealed class MergablePropertyAttribute : Attribute
	{
		// Token: 0x06001379 RID: 4985 RVA: 0x000065CF File Offset: 0x000047CF
		[global::Cpp2ILInjected.Token(Token = "0x60015B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CDDC", Offset = "0x1E3CDDC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public MergablePropertyAttribute(bool allowMerge)
		{
			throw null;
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x0600137A RID: 4986 RVA: 0x000065D2 File Offset: 0x000047D2
		[global::Cpp2ILInjected.Token(Token = "0x170004F3")]
		public bool AllowMerge
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3CE04", Offset = "0x1E3CE04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x000065D5 File Offset: 0x000047D5
		[global::Cpp2ILInjected.Token(Token = "0x60015BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CE0C", Offset = "0x1E3CE0C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x000065D8 File Offset: 0x000047D8
		[global::Cpp2ILInjected.Token(Token = "0x60015BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CEF0", Offset = "0x1E3CEF0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x000065DB File Offset: 0x000047DB
		[global::Cpp2ILInjected.Token(Token = "0x60015BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CEF8", Offset = "0x1E3CEF8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x000065DE File Offset: 0x000047DE
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60015BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CF60", Offset = "0x1E3CF60", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static MergablePropertyAttribute()
		{
			throw null;
		}

		// Token: 0x04000DA8 RID: 3496
		[global::Cpp2ILInjected.Token(Token = "0x40011A8")]
		public static readonly MergablePropertyAttribute Yes;

		// Token: 0x04000DA9 RID: 3497
		[global::Cpp2ILInjected.Token(Token = "0x40011A9")]
		public static readonly MergablePropertyAttribute No;

		// Token: 0x04000DAA RID: 3498
		[global::Cpp2ILInjected.Token(Token = "0x40011AA")]
		public static readonly MergablePropertyAttribute Default;

		// Token: 0x04000DAB RID: 3499
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <AllowMerge>k__BackingField;
	}
}
