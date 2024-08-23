using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Threading
{
	// Token: 0x02000718 RID: 1816
	[global::Cpp2ILInjected.Token(Token = "0x2000B11")]
	public static class FastParallel
	{
		// Token: 0x0600466A RID: 18026 RVA: 0x0002E9A6 File Offset: 0x0002CBA6
		[global::Cpp2ILInjected.Token(Token = "0x6005311")]
		[global::Cpp2ILInjected.Address(RVA = "0x940C5C", Offset = "0x940C5C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static FastParallel()
		{
			throw null;
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x0600466B RID: 18027 RVA: 0x0002E9A9 File Offset: 0x0002CBA9
		// (set) Token: 0x0600466C RID: 18028 RVA: 0x0002E9AC File Offset: 0x0002CBAC
		[global::Cpp2ILInjected.Token(Token = "0x170008F2")]
		public static bool ForceTasksOnCallingThread
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005312")]
			[global::Cpp2ILInjected.Address(RVA = "0x940CAC", Offset = "0x940CAC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005313")]
			[global::Cpp2ILInjected.Address(RVA = "0x940D04", Offset = "0x940D04", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x0002E9AF File Offset: 0x0002CBAF
		[global::Cpp2ILInjected.Token(Token = "0x6005314")]
		[global::Cpp2ILInjected.Address(RVA = "0x940D60", Offset = "0x940D60", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void For(int fromInclusive, int toExclusive, ParallelForAction callback, object context = null)
		{
			throw null;
		}

		// Token: 0x0600466E RID: 18030 RVA: 0x0002E9B2 File Offset: 0x0002CBB2
		[global::Cpp2ILInjected.Token(Token = "0x6005315")]
		[global::Cpp2ILInjected.Address(RVA = "0x940D80", Offset = "0x940D80", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void InvokeTask(object context)
		{
			throw null;
		}

		// Token: 0x04007166 RID: 29030
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008AEC")]
		private static bool <ForceTasksOnCallingThread>k__BackingField;

		// Token: 0x02000AD5 RID: 2773
		[global::Cpp2ILInjected.Token(Token = "0x2000B12")]
		private class RangeTask
		{
			// Token: 0x060052D3 RID: 21203 RVA: 0x000309BF File Offset: 0x0002EBBF
			[global::Cpp2ILInjected.Token(Token = "0x6005316")]
			[global::Cpp2ILInjected.Address(RVA = "0x940E38", Offset = "0x940E38", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public RangeTask(ParallelForAction action, int fromInclusive, int toExclusive, object context, CountdownEvent countdown)
			{
				throw null;
			}

			// Token: 0x060052D4 RID: 21204 RVA: 0x000309C2 File Offset: 0x0002EBC2
			[global::Cpp2ILInjected.Token(Token = "0x6005317")]
			[global::Cpp2ILInjected.Address(RVA = "0x940DFC", Offset = "0x940DFC", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CountdownEvent), Member = "Signal", ReturnType = typeof(bool))]
			public void Invoke()
			{
				throw null;
			}

			// Token: 0x04008F92 RID: 36754
			[global::Cpp2ILInjected.Token(Token = "0x4008AED")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly ParallelForAction _action;

			// Token: 0x04008F93 RID: 36755
			[global::Cpp2ILInjected.Token(Token = "0x4008AEE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private readonly int _fromInclusive;

			// Token: 0x04008F94 RID: 36756
			[global::Cpp2ILInjected.Token(Token = "0x4008AEF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private readonly int _toExclusive;

			// Token: 0x04008F95 RID: 36757
			[global::Cpp2ILInjected.Token(Token = "0x4008AF0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private readonly object _context;

			// Token: 0x04008F96 RID: 36758
			[global::Cpp2ILInjected.Token(Token = "0x4008AF1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private readonly CountdownEvent _countdown;
		}
	}
}
