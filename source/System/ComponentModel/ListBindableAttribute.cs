using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002A1 RID: 673
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x2000399")]
	public sealed class ListBindableAttribute : Attribute
	{
		// Token: 0x060015A3 RID: 5539 RVA: 0x00006B21 File Offset: 0x00004D21
		[global::Cpp2ILInjected.Token(Token = "0x60017F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F678", Offset = "0x1E4F678", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ListBindableAttribute(bool listBindable)
		{
			throw null;
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x00006B24 File Offset: 0x00004D24
		[global::Cpp2ILInjected.Token(Token = "0x60017F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F6A0", Offset = "0x1E4F6A0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ListBindableAttribute(BindableSupport flags)
		{
			throw null;
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x060015A5 RID: 5541 RVA: 0x00006B27 File Offset: 0x00004D27
		[global::Cpp2ILInjected.Token(Token = "0x17000573")]
		public bool ListBindable
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60017F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4F6DC", Offset = "0x1E4F6DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00006B2A File Offset: 0x00004D2A
		[global::Cpp2ILInjected.Token(Token = "0x60017F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F6E4", Offset = "0x1E4F6E4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00006B2D File Offset: 0x00004D2D
		[global::Cpp2ILInjected.Token(Token = "0x60017F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F770", Offset = "0x1E4F770", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00006B30 File Offset: 0x00004D30
		[global::Cpp2ILInjected.Token(Token = "0x60017F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F778", Offset = "0x1E4F778", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x00006B33 File Offset: 0x00004D33
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60017F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4F7FC", Offset = "0x1E4F7FC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static ListBindableAttribute()
		{
			throw null;
		}

		// Token: 0x04000E31 RID: 3633
		[global::Cpp2ILInjected.Token(Token = "0x400123B")]
		public static readonly ListBindableAttribute Yes;

		// Token: 0x04000E32 RID: 3634
		[global::Cpp2ILInjected.Token(Token = "0x400123C")]
		public static readonly ListBindableAttribute No;

		// Token: 0x04000E33 RID: 3635
		[global::Cpp2ILInjected.Token(Token = "0x400123D")]
		public static readonly ListBindableAttribute Default;

		// Token: 0x04000E34 RID: 3636
		[global::Cpp2ILInjected.Token(Token = "0x400123E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool _isDefault;

		// Token: 0x04000E35 RID: 3637
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400123F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		private readonly bool <ListBindable>k__BackingField;
	}
}
