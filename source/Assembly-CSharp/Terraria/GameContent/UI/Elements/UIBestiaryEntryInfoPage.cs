using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.UI.States;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006C0 RID: 1728
	[global::Cpp2ILInjected.Token(Token = "0x2000AA0")]
	public class UIBestiaryEntryInfoPage : UIPanel
	{
		// Token: 0x060043EF RID: 17391 RVA: 0x0002E274 File Offset: 0x0002C474
		[global::Cpp2ILInjected.Token(Token = "0x6005039")]
		[global::Cpp2ILInjected.Address(RVA = "0x90B938", Offset = "0x90B938", Length = "0x270")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "BuildPage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "FromPixelsAndPercent", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(StyleDimension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIScrollbar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIScrollbar), Member = "SetView", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIList), Member = "SetScrollbar", MemberParameters = new object[] { typeof(UIScrollbar) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryInfoPage), Member = "CheckScrollBar", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryInfoPage), Member = "AppendBorderOverEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public UIBestiaryEntryInfoPage()
		{
			throw null;
		}

		// Token: 0x060043F0 RID: 17392 RVA: 0x0002E277 File Offset: 0x0002C477
		[global::Cpp2ILInjected.Token(Token = "0x600503A")]
		[global::Cpp2ILInjected.Address(RVA = "0x90BD28", Offset = "0x90BD28", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIScrollbar), Member = "set_ViewPosition", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		public void UpdateScrollbar(int scrollWheelValue)
		{
			throw null;
		}

		// Token: 0x060043F1 RID: 17393 RVA: 0x0002E27A File Offset: 0x0002C47A
		[global::Cpp2ILInjected.Token(Token = "0x600503B")]
		[global::Cpp2ILInjected.Address(RVA = "0x90BC04", Offset = "0x90BC04", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryInfoPage), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void AppendBorderOverEverything()
		{
			throw null;
		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x0002E27D File Offset: 0x0002C47D
		[global::Cpp2ILInjected.Token(Token = "0x600503C")]
		[global::Cpp2ILInjected.Address(RVA = "0x90BD48", Offset = "0x90BD48", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void ManualIfnoSortingMethod(List<UIElement> list)
		{
			throw null;
		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x0002E280 File Offset: 0x0002C480
		[global::Cpp2ILInjected.Token(Token = "0x600503D")]
		[global::Cpp2ILInjected.Address(RVA = "0x90BD4C", Offset = "0x90BD4C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryInfoPage), Member = "CheckScrollBar", ReturnType = typeof(void))]
		public override void Recalculate()
		{
			throw null;
		}

		// Token: 0x060043F4 RID: 17396 RVA: 0x0002E283 File Offset: 0x0002C483
		[global::Cpp2ILInjected.Token(Token = "0x600503E")]
		[global::Cpp2ILInjected.Address(RVA = "0x90BBA8", Offset = "0x90BBA8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryInfoPage), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryInfoPage), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIScrollbar), Member = "get_CanScroll", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		private void CheckScrollBar()
		{
			throw null;
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x0002E286 File Offset: 0x0002C486
		[global::Cpp2ILInjected.Token(Token = "0x600503F")]
		[global::Cpp2ILInjected.Address(RVA = "0x90BD68", Offset = "0x90BD68", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "FillBestiarySpaceWithEntries", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "SelectEntryButton", MemberParameters = new object[] { typeof(UIBestiaryEntryButton) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "DeselectEntryButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryInfoPage), Member = "AddInfoToList", MemberParameters = new object[]
		{
			typeof(BestiaryEntry),
			typeof(ExtraBestiaryInfoPageInformation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void FillInfoForEntry(BestiaryEntry entry, ExtraBestiaryInfoPageInformation extraInfo)
		{
			throw null;
		}

		// Token: 0x060043F6 RID: 17398 RVA: 0x0002E289 File Offset: 0x0002C489
		[global::Cpp2ILInjected.Token(Token = "0x6005040")]
		[global::Cpp2ILInjected.Address(RVA = "0x90C76C", Offset = "0x90C76C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryInfoPage), Member = "AddInfoToList", MemberParameters = new object[]
		{
			typeof(BestiaryEntry),
			typeof(ExtraBestiaryInfoPageInformation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private BestiaryUICollectionInfo GetUICollectionInfo(BestiaryEntry entry, ExtraBestiaryInfoPageInformation extraInfo)
		{
			throw null;
		}

		// Token: 0x060043F7 RID: 17399 RVA: 0x0002E28C File Offset: 0x0002C48C
		[global::Cpp2ILInjected.Token(Token = "0x6005041")]
		[global::Cpp2ILInjected.Address(RVA = "0x90BDCC", Offset = "0x90BDCC", Length = "0x9A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryInfoPage), Member = "FillInfoForEntry", MemberParameters = new object[]
		{
			typeof(BestiaryEntry),
			typeof(ExtraBestiaryInfoPageInformation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryInfoPage), Member = "GetUICollectionInfo", MemberParameters = new object[]
		{
			typeof(BestiaryEntry),
			typeof(ExtraBestiaryInfoPageInformation)
		}, ReturnType = typeof(BestiaryUICollectionInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, Int32Enum>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "GroupBy", MemberTypeParameters = new object[] { "TSource", "TKey" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>" }, ReturnType = "System.Collections.Generic.IEnumerable`1<IGrouping`2<TKey, TSource>>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "OrderBy", MemberTypeParameters = new object[]
		{
			typeof(object),
			"System.Int32Enum"
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, Int32Enum>)
		}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, float>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "OrderByDescending", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(float)
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, float>)
		}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIHorizontalSeparator), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "FromPixelsAndPercent", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(StyleDimension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 53)]
		private void AddInfoToList(BestiaryEntry entry, ExtraBestiaryInfoPageInformation extraInfo)
		{
			throw null;
		}

		// Token: 0x060043F8 RID: 17400 RVA: 0x0002E28F File Offset: 0x0002C48F
		[global::Cpp2ILInjected.Token(Token = "0x6005042")]
		[global::Cpp2ILInjected.Address(RVA = "0x90C818", Offset = "0x90C818", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private float GetIndividualElementPriority(IBestiaryInfoElement element)
		{
			throw null;
		}

		// Token: 0x060043F9 RID: 17401 RVA: 0x0002E292 File Offset: 0x0002C492
		[global::Cpp2ILInjected.Token(Token = "0x6005043")]
		[global::Cpp2ILInjected.Address(RVA = "0x90C8D0", Offset = "0x90C8D0", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private UIBestiaryEntryInfoPage.BestiaryInfoCategory GetBestiaryInfoCategory(IBestiaryInfoElement element)
		{
			throw null;
		}

		// Token: 0x04006FD5 RID: 28629
		[global::Cpp2ILInjected.Token(Token = "0x400890B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private UIList _list;

		// Token: 0x04006FD6 RID: 28630
		[global::Cpp2ILInjected.Token(Token = "0x400890C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private UIScrollbar _scrollbar;

		// Token: 0x04006FD7 RID: 28631
		[global::Cpp2ILInjected.Token(Token = "0x400890D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private bool _isScrollbarAttached;

		// Token: 0x02000ABC RID: 2748
		[global::Cpp2ILInjected.Token(Token = "0x2000AA1")]
		private enum BestiaryInfoCategory
		{
			// Token: 0x04008F43 RID: 36675
			[global::Cpp2ILInjected.Token(Token = "0x400890F")]
			Nameplate,
			// Token: 0x04008F44 RID: 36676
			[global::Cpp2ILInjected.Token(Token = "0x4008910")]
			Portrait,
			// Token: 0x04008F45 RID: 36677
			[global::Cpp2ILInjected.Token(Token = "0x4008911")]
			FlavorText,
			// Token: 0x04008F46 RID: 36678
			[global::Cpp2ILInjected.Token(Token = "0x4008912")]
			Stats,
			// Token: 0x04008F47 RID: 36679
			[global::Cpp2ILInjected.Token(Token = "0x4008913")]
			ItemsFromCatchingNPC,
			// Token: 0x04008F48 RID: 36680
			[global::Cpp2ILInjected.Token(Token = "0x4008914")]
			ItemsFromDrops,
			// Token: 0x04008F49 RID: 36681
			[global::Cpp2ILInjected.Token(Token = "0x4008915")]
			Misc
		}

		// Token: 0x02000ABD RID: 2749
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000AA2")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005276 RID: 21110 RVA: 0x000308B4 File Offset: 0x0002EAB4
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6005044")]
			[global::Cpp2ILInjected.Address(RVA = "0x90CAD0", Offset = "0x90CAD0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06005277 RID: 21111 RVA: 0x000308B7 File Offset: 0x0002EAB7
			[global::Cpp2ILInjected.Token(Token = "0x6005045")]
			[global::Cpp2ILInjected.Address(RVA = "0x90CB2C", Offset = "0x90CB2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06005278 RID: 21112 RVA: 0x000308BA File Offset: 0x0002EABA
			[global::Cpp2ILInjected.Token(Token = "0x6005046")]
			[global::Cpp2ILInjected.Address(RVA = "0x90CB34", Offset = "0x90CB34", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal UIBestiaryEntryInfoPage.BestiaryInfoCategory <AddInfoToList>b__11_0(IGrouping<UIBestiaryEntryInfoPage.BestiaryInfoCategory, IBestiaryInfoElement> x)
			{
				throw null;
			}

			// Token: 0x04008F4A RID: 36682
			[global::Cpp2ILInjected.Token(Token = "0x4008916")]
			public static readonly UIBestiaryEntryInfoPage.<>c <>9;

			// Token: 0x04008F4B RID: 36683
			[global::Cpp2ILInjected.Token(Token = "0x4008917")]
			public static Func<IGrouping<UIBestiaryEntryInfoPage.BestiaryInfoCategory, IBestiaryInfoElement>, UIBestiaryEntryInfoPage.BestiaryInfoCategory> <>9__11_0;
		}
	}
}
