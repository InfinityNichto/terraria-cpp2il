using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000629")]
	public class EntrySorter<TEntryType, TStepType> : IComparer<TEntryType> where TEntryType : new() where TStepType : IEntrySortStep<TEntryType>
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6003601")]
		[global::Cpp2ILInjected.Address(RVA = "0x16419E4", Offset = "0x16419E4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetPrioritizedStepIndex(int index)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x40076CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public List<TStepType> Steps;

		[global::Cpp2ILInjected.Token(Token = "0x40076CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int _prioritizedStep;
	}
}
