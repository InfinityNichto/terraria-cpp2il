using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000246 RID: 582
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event)]
	[global::Cpp2ILInjected.Token(Token = "0x2000337")]
	public sealed class DesignerSerializationVisibilityAttribute : Attribute
	{
		// Token: 0x0600133F RID: 4927 RVA: 0x0000654E File Offset: 0x0000474E
		[global::Cpp2ILInjected.Token(Token = "0x600157D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C180", Offset = "0x1E3C180", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility visibility)
		{
			throw null;
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001340 RID: 4928 RVA: 0x00006551 File Offset: 0x00004751
		[global::Cpp2ILInjected.Token(Token = "0x170004E6")]
		public DesignerSerializationVisibility Visibility
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600157E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3C1A8", Offset = "0x1E3C1A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x00006554 File Offset: 0x00004754
		[global::Cpp2ILInjected.Token(Token = "0x600157F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C1B0", Offset = "0x1E3C1B0", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x00006557 File Offset: 0x00004757
		[global::Cpp2ILInjected.Token(Token = "0x6001580")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C288", Offset = "0x1E3C288", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0000655A File Offset: 0x0000475A
		[global::Cpp2ILInjected.Token(Token = "0x6001581")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C290", Offset = "0x1E3C290", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x0000655D File Offset: 0x0000475D
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001582")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C2F8", Offset = "0x1E3C2F8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static DesignerSerializationVisibilityAttribute()
		{
			throw null;
		}

		// Token: 0x04000D96 RID: 3478
		[global::Cpp2ILInjected.Token(Token = "0x4001193")]
		public static readonly DesignerSerializationVisibilityAttribute Content;

		// Token: 0x04000D97 RID: 3479
		[global::Cpp2ILInjected.Token(Token = "0x4001194")]
		public static readonly DesignerSerializationVisibilityAttribute Hidden;

		// Token: 0x04000D98 RID: 3480
		[global::Cpp2ILInjected.Token(Token = "0x4001195")]
		public static readonly DesignerSerializationVisibilityAttribute Visible;

		// Token: 0x04000D99 RID: 3481
		[global::Cpp2ILInjected.Token(Token = "0x4001196")]
		public static readonly DesignerSerializationVisibilityAttribute Default;

		// Token: 0x04000D9A RID: 3482
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001197")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly DesignerSerializationVisibility <Visibility>k__BackingField;
	}
}
