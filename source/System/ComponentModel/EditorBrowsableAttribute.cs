using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200023B RID: 571
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
	[global::Cpp2ILInjected.Token(Token = "0x200032C")]
	public sealed class EditorBrowsableAttribute : Attribute
	{
		// Token: 0x060012EF RID: 4847 RVA: 0x0000645E File Offset: 0x0000465E
		[global::Cpp2ILInjected.Token(Token = "0x600152D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A140", Offset = "0x1E3A140", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public EditorBrowsableAttribute(EditorBrowsableState state)
		{
			throw null;
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00006461 File Offset: 0x00004661
		[global::Cpp2ILInjected.Token(Token = "0x600152E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A168", Offset = "0x1E3A168", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public EditorBrowsableAttribute()
		{
			throw null;
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x00006464 File Offset: 0x00004664
		[global::Cpp2ILInjected.Token(Token = "0x170004D6")]
		public EditorBrowsableState State
		{
			[global::Cpp2ILInjected.Token(Token = "0x600152F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3A184", Offset = "0x1E3A184", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00006467 File Offset: 0x00004667
		[global::Cpp2ILInjected.Token(Token = "0x6001530")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A18C", Offset = "0x1E3A18C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x0000646A File Offset: 0x0000466A
		[global::Cpp2ILInjected.Token(Token = "0x6001531")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3A20C", Offset = "0x1E3A20C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x04000D71 RID: 3441
		[global::Cpp2ILInjected.Token(Token = "0x400116E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private EditorBrowsableState browsableState;
	}
}
