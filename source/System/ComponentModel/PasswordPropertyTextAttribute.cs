using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002AF RID: 687
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x20003AB")]
	public sealed class PasswordPropertyTextAttribute : Attribute
	{
		// Token: 0x06001672 RID: 5746 RVA: 0x00006D82 File Offset: 0x00004F82
		[global::Cpp2ILInjected.Token(Token = "0x60018CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56D20", Offset = "0x1E56D20", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public PasswordPropertyTextAttribute()
		{
			throw null;
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00006D85 File Offset: 0x00004F85
		[global::Cpp2ILInjected.Token(Token = "0x60018CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56D3C", Offset = "0x1E56D3C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public PasswordPropertyTextAttribute(bool password)
		{
			throw null;
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x00006D88 File Offset: 0x00004F88
		[global::Cpp2ILInjected.Token(Token = "0x170005AA")]
		public bool Password
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60018CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E56D64", Offset = "0x1E56D64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00006D8B File Offset: 0x00004F8B
		[global::Cpp2ILInjected.Token(Token = "0x60018CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56D6C", Offset = "0x1E56D6C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object o)
		{
			throw null;
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00006D8E File Offset: 0x00004F8E
		[global::Cpp2ILInjected.Token(Token = "0x60018CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56DE8", Offset = "0x1E56DE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00006D91 File Offset: 0x00004F91
		[global::Cpp2ILInjected.Token(Token = "0x60018CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56DF0", Offset = "0x1E56DF0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x00006D94 File Offset: 0x00004F94
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60018D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56E58", Offset = "0x1E56E58", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static PasswordPropertyTextAttribute()
		{
			throw null;
		}

		// Token: 0x04000E82 RID: 3714
		[global::Cpp2ILInjected.Token(Token = "0x400129D")]
		public static readonly PasswordPropertyTextAttribute Yes;

		// Token: 0x04000E83 RID: 3715
		[global::Cpp2ILInjected.Token(Token = "0x400129E")]
		public static readonly PasswordPropertyTextAttribute No;

		// Token: 0x04000E84 RID: 3716
		[global::Cpp2ILInjected.Token(Token = "0x400129F")]
		public static readonly PasswordPropertyTextAttribute Default;

		// Token: 0x04000E85 RID: 3717
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <Password>k__BackingField;
	}
}
