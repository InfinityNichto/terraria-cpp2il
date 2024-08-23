using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.UI.States;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006BB RID: 1723
	[global::Cpp2ILInjected.Token(Token = "0x2000A98")]
	public class UIBestiaryEntryGrid : UIElement
	{
		// Token: 0x14000056 RID: 86
		// (add) Token: 0x060043C4 RID: 17348 RVA: 0x0002E1F3 File Offset: 0x0002C3F3
		// (remove) Token: 0x060043C5 RID: 17349 RVA: 0x0002E1F6 File Offset: 0x0002C3F6
		[global::Cpp2ILInjected.Token(Token = "0x1400005C")]
		public event Action OnGridContentsChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005007")]
			[global::Cpp2ILInjected.Address(RVA = "0x9074DC", Offset = "0x9074DC", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "BuildPage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005008")]
			[global::Cpp2ILInjected.Address(RVA = "0x90757C", Offset = "0x90757C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x0002E1F9 File Offset: 0x0002C3F9
		[global::Cpp2ILInjected.Token(Token = "0x6005009")]
		[global::Cpp2ILInjected.Address(RVA = "0x90761C", Offset = "0x90761C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "BuildPage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryGrid), Member = "FillBestiarySpaceWithEntries", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public UIBestiaryEntryGrid(List<BestiaryEntry> workingSet, UIElement.MouseEvent clickOnEntryEvent)
		{
			throw null;
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x0002E1FC File Offset: 0x0002C3FC
		[global::Cpp2ILInjected.Token(Token = "0x600500A")]
		[global::Cpp2ILInjected.Address(RVA = "0x907724", Offset = "0x907724", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void UpdateEntries()
		{
			throw null;
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x0002E1FF File Offset: 0x0002C3FF
		[global::Cpp2ILInjected.Token(Token = "0x600500B")]
		[global::Cpp2ILInjected.Address(RVA = "0x907768", Offset = "0x907768", Length = "0x410")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "FillBestiarySpaceWithEntries", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryGrid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(List<BestiaryEntry>),
			typeof(UIElement.MouseEvent)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryGrid), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryGrid), Member = "OffsetLibrary", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RemoveAllChildren", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "ToRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryGrid), Member = "FixBestiaryRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryButton), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(BestiaryEntry),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetSnapPoint", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(Vector2?),
			typeof(Vector2?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public void FillBestiarySpaceWithEntries()
		{
			throw null;
		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x0002E202 File Offset: 0x0002C402
		[global::Cpp2ILInjected.Token(Token = "0x600500C")]
		[global::Cpp2ILInjected.Address(RVA = "0x907CF4", Offset = "0x907CF4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryGrid), Member = "FillBestiarySpaceWithEntries", ReturnType = typeof(void))]
		public override void Recalculate()
		{
			throw null;
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x0002E205 File Offset: 0x0002C405
		[global::Cpp2ILInjected.Token(Token = "0x600500D")]
		[global::Cpp2ILInjected.Address(RVA = "0x907B78", Offset = "0x907B78", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "ToRectangle", ReturnType = typeof(Rectangle))]
		public void GetEntriesToShow(out int maxEntriesWidth, out int maxEntriesHeight, out int maxEntriesToHave)
		{
			throw null;
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x0002E208 File Offset: 0x0002C408
		[global::Cpp2ILInjected.Token(Token = "0x600500E")]
		[global::Cpp2ILInjected.Address(RVA = "0x907D10", Offset = "0x907D10", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "UpdateBestiaryGridRange", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "ToRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public string GetRangeText()
		{
			throw null;
		}

		// Token: 0x060043CC RID: 17356 RVA: 0x0002E20B File Offset: 0x0002C40B
		[global::Cpp2ILInjected.Token(Token = "0x600500F")]
		[global::Cpp2ILInjected.Address(RVA = "0x907E6C", Offset = "0x907E6C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "AddBackAndForwardButtons", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void MakeButtonGoByOffset(UIElement element, int howManyPages)
		{
			throw null;
		}

		// Token: 0x060043CD RID: 17357 RVA: 0x0002E20E File Offset: 0x0002C40E
		[global::Cpp2ILInjected.Token(Token = "0x6005010")]
		[global::Cpp2ILInjected.Address(RVA = "0x907F38", Offset = "0x907F38", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryGrid.<>c__DisplayClass13_0), Member = "<MakeButtonGoByOffset>b__0", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "ToRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryGrid), Member = "OffsetLibrary", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public void OffsetLibraryByPages(int howManyPages)
		{
			throw null;
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x0002E211 File Offset: 0x0002C411
		[global::Cpp2ILInjected.Token(Token = "0x6005011")]
		[global::Cpp2ILInjected.Address(RVA = "0x907FAC", Offset = "0x907FAC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryGrid), Member = "OffsetLibraryByPages", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "ToRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryGrid), Member = "FixBestiaryRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryGrid), Member = "FillBestiarySpaceWithEntries", ReturnType = typeof(void))]
		public void OffsetLibrary(int offset)
		{
			throw null;
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x0002E214 File Offset: 0x0002C414
		[global::Cpp2ILInjected.Token(Token = "0x6005012")]
		[global::Cpp2ILInjected.Address(RVA = "0x907BF4", Offset = "0x907BF4", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryGrid), Member = "FillBestiarySpaceWithEntries", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryGrid), Member = "OffsetLibrary", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void FixBestiaryRange(int offset, int maxEntriesToHave)
		{
			throw null;
		}

		// Token: 0x04006FBA RID: 28602
		[global::Cpp2ILInjected.Token(Token = "0x40088E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private List<BestiaryEntry> _workingSetEntries;

		// Token: 0x04006FBB RID: 28603
		[global::Cpp2ILInjected.Token(Token = "0x40088E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private UIElement.MouseEvent _clickOnEntryEvent;

		// Token: 0x04006FBC RID: 28604
		[global::Cpp2ILInjected.Token(Token = "0x40088EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private int _atEntryIndex;

		// Token: 0x04006FBD RID: 28605
		[global::Cpp2ILInjected.Token(Token = "0x40088EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x15C")]
		private int _lastEntry;

		// Token: 0x04006FBE RID: 28606
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40088EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private Action OnGridContentsChanged;

		// Token: 0x02000AB9 RID: 2745
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000A99")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x0600526F RID: 21103 RVA: 0x0003089F File Offset: 0x0002EA9F
			[global::Cpp2ILInjected.Token(Token = "0x6005013")]
			[global::Cpp2ILInjected.Address(RVA = "0x907F30", Offset = "0x907F30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass13_0()
			{
				throw null;
			}

			// Token: 0x06005270 RID: 21104 RVA: 0x000308A2 File Offset: 0x0002EAA2
			[global::Cpp2ILInjected.Token(Token = "0x6005014")]
			[global::Cpp2ILInjected.Address(RVA = "0x908028", Offset = "0x908028", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryGrid), Member = "OffsetLibraryByPages", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			internal void <MakeButtonGoByOffset>b__0(UIMouseEvent e, UIElement v)
			{
				throw null;
			}

			// Token: 0x04008F3A RID: 36666
			[global::Cpp2ILInjected.Token(Token = "0x40088ED")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public UIBestiaryEntryGrid <>4__this;

			// Token: 0x04008F3B RID: 36667
			[global::Cpp2ILInjected.Token(Token = "0x40088EE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int howManyPages;
		}
	}
}
