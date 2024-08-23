using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000152 RID: 338
	[global::Cpp2ILInjected.Token(Token = "0x200019D")]
	internal class PointerSpec : global::System.ModifierSpec
	{
		// Token: 0x06000ED4 RID: 3796 RVA: 0x00016EFE File Offset: 0x000150FE
		[global::Cpp2ILInjected.Token(Token = "0x6000FD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C89994", Offset = "0x1C89994", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal PointerSpec(int pointer_level)
		{
			throw null;
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00016F01 File Offset: 0x00015101
		[global::Cpp2ILInjected.Token(Token = "0x6000FD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C899BC", Offset = "0x1C899BC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.Type Resolve(global::System.Type type)
		{
			throw null;
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00016F04 File Offset: 0x00015104
		[global::Cpp2ILInjected.Token(Token = "0x6000FD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C89A08", Offset = "0x1C89A08", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		public global::System.Text.StringBuilder Append(global::System.Text.StringBuilder sb)
		{
			throw null;
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00016F07 File Offset: 0x00015107
		[global::Cpp2ILInjected.Token(Token = "0x6000FD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C89A1C", Offset = "0x1C89A1C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x040006AD RID: 1709
		[global::Cpp2ILInjected.Token(Token = "0x4000884")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int pointer_level;
	}
}
