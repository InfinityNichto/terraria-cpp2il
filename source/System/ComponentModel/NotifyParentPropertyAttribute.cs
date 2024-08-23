using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002F0 RID: 752
	[AttributeUsage(AttributeTargets.Property)]
	[global::Cpp2ILInjected.Token(Token = "0x2000401")]
	public sealed class NotifyParentPropertyAttribute : Attribute
	{
		// Token: 0x06001906 RID: 6406 RVA: 0x0000749C File Offset: 0x0000569C
		[global::Cpp2ILInjected.Token(Token = "0x6001BDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A5C8", Offset = "0x1E8A5C8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public NotifyParentPropertyAttribute(bool notifyParent)
		{
			throw null;
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001907 RID: 6407 RVA: 0x0000749F File Offset: 0x0000569F
		[global::Cpp2ILInjected.Token(Token = "0x17000638")]
		public bool NotifyParent
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BDF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8A5F0", Offset = "0x1E8A5F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x000074A2 File Offset: 0x000056A2
		[global::Cpp2ILInjected.Token(Token = "0x6001BE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A5F8", Offset = "0x1E8A5F8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x000074A5 File Offset: 0x000056A5
		[global::Cpp2ILInjected.Token(Token = "0x6001BE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A678", Offset = "0x1E8A678", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x000074A8 File Offset: 0x000056A8
		[global::Cpp2ILInjected.Token(Token = "0x6001BE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A680", Offset = "0x1E8A680", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x000074AB File Offset: 0x000056AB
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001BE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A6E8", Offset = "0x1E8A6E8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static NotifyParentPropertyAttribute()
		{
			throw null;
		}

		// Token: 0x04000F39 RID: 3897
		[global::Cpp2ILInjected.Token(Token = "0x4001379")]
		public static readonly NotifyParentPropertyAttribute Yes;

		// Token: 0x04000F3A RID: 3898
		[global::Cpp2ILInjected.Token(Token = "0x400137A")]
		public static readonly NotifyParentPropertyAttribute No;

		// Token: 0x04000F3B RID: 3899
		[global::Cpp2ILInjected.Token(Token = "0x400137B")]
		public static readonly NotifyParentPropertyAttribute Default;

		// Token: 0x04000F3C RID: 3900
		[global::Cpp2ILInjected.Token(Token = "0x400137C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool notifyParent;
	}
}
