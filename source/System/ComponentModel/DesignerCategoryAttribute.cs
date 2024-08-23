using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000244 RID: 580
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000335")]
	public sealed class DesignerCategoryAttribute : Attribute
	{
		// Token: 0x06001337 RID: 4919 RVA: 0x00006536 File Offset: 0x00004736
		[global::Cpp2ILInjected.Token(Token = "0x6001575")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3BEB8", Offset = "0x1E3BEB8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesignerCategoryAttribute), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public DesignerCategoryAttribute()
		{
			throw null;
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00006539 File Offset: 0x00004739
		[global::Cpp2ILInjected.Token(Token = "0x6001576")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3BF14", Offset = "0x1E3BF14", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DesignerCategoryAttribute(string category)
		{
			throw null;
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x0000653C File Offset: 0x0000473C
		[global::Cpp2ILInjected.Token(Token = "0x170004E4")]
		public string Category
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001577")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3BF3C", Offset = "0x1E3BF3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x0000653F File Offset: 0x0000473F
		[global::Cpp2ILInjected.Token(Token = "0x6001578")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3BF44", Offset = "0x1E3BF44", Length = "0x84")]
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

		// Token: 0x0600133B RID: 4923 RVA: 0x00006542 File Offset: 0x00004742
		[global::Cpp2ILInjected.Token(Token = "0x6001579")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3BFC8", Offset = "0x1E3BFC8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00006545 File Offset: 0x00004745
		[global::Cpp2ILInjected.Token(Token = "0x600157A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3BFD8", Offset = "0x1E3BFD8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x00006548 File Offset: 0x00004748
		[global::Cpp2ILInjected.Token(Token = "0x170004E5")]
		public override object TypeId
		{
			[global::Cpp2ILInjected.Token(Token = "0x600157B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3C044", Offset = "0x1E3C044", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x0000654B File Offset: 0x0000474B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600157C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C074", Offset = "0x1E3C074", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DesignerCategoryAttribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static DesignerCategoryAttribute()
		{
			throw null;
		}

		// Token: 0x04000D8D RID: 3469
		[global::Cpp2ILInjected.Token(Token = "0x400118A")]
		public static readonly DesignerCategoryAttribute Component;

		// Token: 0x04000D8E RID: 3470
		[global::Cpp2ILInjected.Token(Token = "0x400118B")]
		public static readonly DesignerCategoryAttribute Default;

		// Token: 0x04000D8F RID: 3471
		[global::Cpp2ILInjected.Token(Token = "0x400118C")]
		public static readonly DesignerCategoryAttribute Form;

		// Token: 0x04000D90 RID: 3472
		[global::Cpp2ILInjected.Token(Token = "0x400118D")]
		public static readonly DesignerCategoryAttribute Generic;

		// Token: 0x04000D91 RID: 3473
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400118E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <Category>k__BackingField;
	}
}
