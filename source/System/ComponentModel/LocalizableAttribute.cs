using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000250 RID: 592
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x2000342")]
	public sealed class LocalizableAttribute : Attribute
	{
		// Token: 0x06001373 RID: 4979 RVA: 0x000065BD File Offset: 0x000047BD
		[global::Cpp2ILInjected.Token(Token = "0x60015B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CBC0", Offset = "0x1E3CBC0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public LocalizableAttribute(bool isLocalizable)
		{
			throw null;
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x000065C0 File Offset: 0x000047C0
		[global::Cpp2ILInjected.Token(Token = "0x170004F2")]
		public bool IsLocalizable
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60015B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3CBE8", Offset = "0x1E3CBE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x000065C3 File Offset: 0x000047C3
		[global::Cpp2ILInjected.Token(Token = "0x60015B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CBF0", Offset = "0x1E3CBF0", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x000065C6 File Offset: 0x000047C6
		[global::Cpp2ILInjected.Token(Token = "0x60015B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CCD4", Offset = "0x1E3CCD4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x000065C9 File Offset: 0x000047C9
		[global::Cpp2ILInjected.Token(Token = "0x60015B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CCDC", Offset = "0x1E3CCDC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x000065CC File Offset: 0x000047CC
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60015B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3CD54", Offset = "0x1E3CD54", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static LocalizableAttribute()
		{
			throw null;
		}

		// Token: 0x04000DA4 RID: 3492
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <IsLocalizable>k__BackingField;

		// Token: 0x04000DA5 RID: 3493
		[global::Cpp2ILInjected.Token(Token = "0x40011A5")]
		public static readonly LocalizableAttribute Yes;

		// Token: 0x04000DA6 RID: 3494
		[global::Cpp2ILInjected.Token(Token = "0x40011A6")]
		public static readonly LocalizableAttribute No;

		// Token: 0x04000DA7 RID: 3495
		[global::Cpp2ILInjected.Token(Token = "0x40011A7")]
		public static readonly LocalizableAttribute Default;
	}
}
