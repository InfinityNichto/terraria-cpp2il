using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.UI.States;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006BD RID: 1725
	[global::Cpp2ILInjected.Token(Token = "0x2000A9B")]
	public class UIBestiaryFilteringOptionsGrid : UIPanel
	{
		// Token: 0x14000058 RID: 88
		// (add) Token: 0x060043D6 RID: 17366 RVA: 0x0002E229 File Offset: 0x0002C429
		// (remove) Token: 0x060043D7 RID: 17367 RVA: 0x0002E22C File Offset: 0x0002C42C
		[global::Cpp2ILInjected.Token(Token = "0x1400005E")]
		public event Action OnClickingOption
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600501B")]
			[global::Cpp2ILInjected.Address(RVA = "0x908D08", Offset = "0x908D08", Length = "0xA0")]
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
			[global::Cpp2ILInjected.Token(Token = "0x600501C")]
			[global::Cpp2ILInjected.Address(RVA = "0x908DA8", Offset = "0x908DA8", Length = "0xA0")]
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

		// Token: 0x060043D8 RID: 17368 RVA: 0x0002E22F File Offset: 0x0002C42F
		[global::Cpp2ILInjected.Token(Token = "0x600501D")]
		[global::Cpp2ILInjected.Address(RVA = "0x908E48", Offset = "0x908E48", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "BuildPage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<bool>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "BuildContainer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public UIBestiaryFilteringOptionsGrid(EntryFilterer<BestiaryEntry, IBestiaryEntryFilter> filterer)
		{
			throw null;
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x0002E232 File Offset: 0x0002C432
		[global::Cpp2ILInjected.Token(Token = "0x600501E")]
		[global::Cpp2ILInjected.Address(RVA = "0x909060", Offset = "0x909060", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = ".ctor", MemberParameters = new object[] { typeof(EntryFilterer<BestiaryEntry, IBestiaryEntryFilter>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "GetDisplaySettings", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref float),
			typeof(ref float),
			typeof(ref int)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void BuildContainer()
		{
			throw null;
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x0002E235 File Offset: 0x0002C435
		[global::Cpp2ILInjected.Token(Token = "0x600501F")]
		[global::Cpp2ILInjected.Address(RVA = "0x90936C", Offset = "0x90936C", Length = "0x2D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "BuildPage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void SetupAvailabilityTest(List<BestiaryEntry> allAvailableEntries)
		{
			throw null;
		}

		// Token: 0x060043DB RID: 17371 RVA: 0x0002E238 File Offset: 0x0002C438
		[global::Cpp2ILInjected.Token(Token = "0x6005020")]
		[global::Cpp2ILInjected.Address(RVA = "0x90963C", Offset = "0x90963C", Length = "0x8C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "UpdateBestiaryContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "GetDisplaySettings", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref float),
			typeof(ref float),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RemoveAllChildren", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "GetIsFilterAvailableForEntries", MemberParameters = new object[]
		{
			typeof(IBestiaryEntryFilter),
			typeof(List<BestiaryEntry>)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupOptionButton<int>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(LocalizedText),
			typeof(LocalizedText),
			typeof(Color),
			typeof(string),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetSnapPoint", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(Vector2?),
			typeof(Vector2?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "AddOnHover", MemberParameters = new object[]
		{
			typeof(IBestiaryEntryFilter),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageFramed), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "UpdateButtonSelections", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public void UpdateAvailability()
		{
			throw null;
		}

		// Token: 0x060043DC RID: 17372 RVA: 0x0002E23B File Offset: 0x0002C43B
		[global::Cpp2ILInjected.Token(Token = "0x6005021")]
		[global::Cpp2ILInjected.Address(RVA = "0x90A444", Offset = "0x90A444", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "GetDisplaySettings", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref float),
			typeof(ref float),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void GetEntriesToShow(out int maxEntriesWidth, out int maxEntriesHeight, out int maxEntriesToHave)
		{
			throw null;
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x0002E23E File Offset: 0x0002C43E
		[global::Cpp2ILInjected.Token(Token = "0x6005022")]
		[global::Cpp2ILInjected.Address(RVA = "0x909260", Offset = "0x909260", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "BuildContainer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "UpdateAvailability", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "GetEntriesToShow", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void GetDisplaySettings(out int widthPerButton, out int heightPerButton, out int widthWithSpacing, out int heightWithSpacing, out int perRow, out float offsetLeft, out float offsetTop, out int howManyRows)
		{
			throw null;
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x0002E241 File Offset: 0x0002C441
		[global::Cpp2ILInjected.Token(Token = "0x6005023")]
		[global::Cpp2ILInjected.Address(RVA = "0x90A214", Offset = "0x90A214", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "UpdateAvailability", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "ClickOption", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntryFilterer<, >), Member = "IsFilterActive", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupOptionButton<int>), Member = "SetColor", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void UpdateButtonSelections()
		{
			throw null;
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x0002E244 File Offset: 0x0002C444
		[global::Cpp2ILInjected.Token(Token = "0x6005024")]
		[global::Cpp2ILInjected.Address(RVA = "0x909F00", Offset = "0x909F00", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "UpdateAvailability", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private bool GetIsFilterAvailableForEntries(IBestiaryEntryFilter filter, List<BestiaryEntry> entries)
		{
			throw null;
		}

		// Token: 0x060043E0 RID: 17376 RVA: 0x0002E247 File Offset: 0x0002C447
		[global::Cpp2ILInjected.Token(Token = "0x6005025")]
		[global::Cpp2ILInjected.Address(RVA = "0x90A154", Offset = "0x90A154", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "UpdateAvailability", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void AddOnHover(IBestiaryEntryFilter filter, UIElement button)
		{
			throw null;
		}

		// Token: 0x060043E1 RID: 17377 RVA: 0x0002E24A File Offset: 0x0002C44A
		[global::Cpp2ILInjected.Token(Token = "0x6005026")]
		[global::Cpp2ILInjected.Address(RVA = "0x90A4F4", Offset = "0x90A4F4", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryFilteringOptionsGrid.<>c__DisplayClass16_0), Member = "<AddOnHover>b__0", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(byte),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ShowButtonName(UIElement element, IBestiaryEntryFilter number)
		{
			throw null;
		}

		// Token: 0x060043E2 RID: 17378 RVA: 0x0002E24D File Offset: 0x0002C44D
		[global::Cpp2ILInjected.Token(Token = "0x6005027")]
		[global::Cpp2ILInjected.Address(RVA = "0x90A60C", Offset = "0x90A60C", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntryFilterer<, >), Member = "ToggleFilter", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "UpdateButtonSelections", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void ClickOption(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x04006FC4 RID: 28612
		[global::Cpp2ILInjected.Token(Token = "0x40088F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private EntryFilterer<BestiaryEntry, IBestiaryEntryFilter> _filterer;

		// Token: 0x04006FC5 RID: 28613
		[global::Cpp2ILInjected.Token(Token = "0x40088F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private List<GroupOptionButton<int>> _filterButtons;

		// Token: 0x04006FC6 RID: 28614
		[global::Cpp2ILInjected.Token(Token = "0x40088F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private List<bool> _areFiltersAvailable;

		// Token: 0x04006FC7 RID: 28615
		[global::Cpp2ILInjected.Token(Token = "0x40088F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		private List<List<BestiaryEntry>> _filterAvailabilityTests;

		// Token: 0x04006FC8 RID: 28616
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40088F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		private Action OnClickingOption;

		// Token: 0x04006FC9 RID: 28617
		[global::Cpp2ILInjected.Token(Token = "0x40088F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		private UIElement _container;

		// Token: 0x02000ABA RID: 2746
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000A9C")]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06005271 RID: 21105 RVA: 0x000308A5 File Offset: 0x0002EAA5
			[global::Cpp2ILInjected.Token(Token = "0x6005028")]
			[global::Cpp2ILInjected.Address(RVA = "0x90A4EC", Offset = "0x90A4EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass16_0()
			{
				throw null;
			}

			// Token: 0x06005272 RID: 21106 RVA: 0x000308A8 File Offset: 0x0002EAA8
			[global::Cpp2ILInjected.Token(Token = "0x6005029")]
			[global::Cpp2ILInjected.Address(RVA = "0x90A6E0", Offset = "0x90A6E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "ShowButtonName", MemberParameters = new object[]
			{
				typeof(UIElement),
				typeof(IBestiaryEntryFilter)
			}, ReturnType = typeof(void))]
			internal void <AddOnHover>b__0(UIElement element)
			{
				throw null;
			}

			// Token: 0x04008F3C RID: 36668
			[global::Cpp2ILInjected.Token(Token = "0x40088FA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public UIBestiaryFilteringOptionsGrid <>4__this;

			// Token: 0x04008F3D RID: 36669
			[global::Cpp2ILInjected.Token(Token = "0x40088FB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public IBestiaryEntryFilter filter;
		}
	}
}
