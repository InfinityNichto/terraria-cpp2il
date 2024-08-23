using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200027A RID: 634
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
	[global::Cpp2ILInjected.Token(Token = "0x2000370")]
	public sealed class DesignTimeVisibleAttribute : Attribute
	{
		// Token: 0x060014AB RID: 5291 RVA: 0x00006932 File Offset: 0x00004B32
		[global::Cpp2ILInjected.Token(Token = "0x60016F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A454", Offset = "0x1E4A454", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DesignTimeVisibleAttribute(bool visible)
		{
			throw null;
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00006935 File Offset: 0x00004B35
		[global::Cpp2ILInjected.Token(Token = "0x60016F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A47C", Offset = "0x1E4A47C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DesignTimeVisibleAttribute()
		{
			throw null;
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x00006938 File Offset: 0x00004B38
		[global::Cpp2ILInjected.Token(Token = "0x17000534")]
		public bool Visible
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60016F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4A484", Offset = "0x1E4A484", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0000693B File Offset: 0x00004B3B
		[global::Cpp2ILInjected.Token(Token = "0x60016F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A48C", Offset = "0x1E4A48C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0000693E File Offset: 0x00004B3E
		[global::Cpp2ILInjected.Token(Token = "0x60016F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A518", Offset = "0x1E4A518", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x00006941 File Offset: 0x00004B41
		[global::Cpp2ILInjected.Token(Token = "0x60016F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A5AC", Offset = "0x1E4A5AC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x00006944 File Offset: 0x00004B44
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60016F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A624", Offset = "0x1E4A624", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static DesignTimeVisibleAttribute()
		{
			throw null;
		}

		// Token: 0x04000E0F RID: 3599
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001214")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <Visible>k__BackingField;

		// Token: 0x04000E10 RID: 3600
		[global::Cpp2ILInjected.Token(Token = "0x4001215")]
		public static readonly DesignTimeVisibleAttribute Yes;

		// Token: 0x04000E11 RID: 3601
		[global::Cpp2ILInjected.Token(Token = "0x4001216")]
		public static readonly DesignTimeVisibleAttribute No;

		// Token: 0x04000E12 RID: 3602
		[global::Cpp2ILInjected.Token(Token = "0x4001217")]
		public static readonly DesignTimeVisibleAttribute Default;
	}
}
