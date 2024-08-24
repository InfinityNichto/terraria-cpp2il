using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.DataStructures
{
	// Token: 0x0200042E RID: 1070
	[global::Cpp2ILInjected.Token(Token = "0x2000629")]
	public class EntrySorter<TEntryType, TStepType> : IComparer<TEntryType> where TEntryType : new() where TStepType : IEntrySortStep<TEntryType>
	{
		// Token: 0x060030E2 RID: 12514 RVA: 0x0002ABDE File Offset: 0x00028DDE
		[global::Cpp2ILInjected.Token(Token = "0x60035FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x16417F4", Offset = "0x16417F4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = ".ctor", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddSortSteps(List<TStepType> sortSteps)
		{
			throw null;
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x0002ABE1 File Offset: 0x00028DE1
		[global::Cpp2ILInjected.Token(Token = "0x6003600")]
		[global::Cpp2ILInjected.Address(RVA = "0x164180C", Offset = "0x164180C", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public int Compare(TEntryType x, TEntryType y)
		{
			throw null;
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x0002ABE4 File Offset: 0x00028DE4
		[global::Cpp2ILInjected.Token(Token = "0x6003601")]
		[global::Cpp2ILInjected.Address(RVA = "0x16419E4", Offset = "0x16419E4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetPrioritizedStepIndex(int index)
		{
			throw null;
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x0002ABE7 File Offset: 0x00028DE7
		[global::Cpp2ILInjected.Token(Token = "0x6003602")]
		[global::Cpp2ILInjected.Address(RVA = "0x16419EC", Offset = "0x16419EC", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string GetDisplayName()
		{
			throw null;
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x0002ABEA File Offset: 0x00028DEA
		[global::Cpp2ILInjected.Token(Token = "0x6003603")]
		[global::Cpp2ILInjected.Address(RVA = "0x1641A98", Offset = "0x1641A98", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = ".ctor", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public EntrySorter()
		{
			throw null;
		}

		// Token: 0x040062E4 RID: 25316
		[global::Cpp2ILInjected.Token(Token = "0x40076CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public List<TStepType> Steps;

		// Token: 0x040062E5 RID: 25317
		[global::Cpp2ILInjected.Token(Token = "0x40076CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _prioritizedStep;
	}
}
