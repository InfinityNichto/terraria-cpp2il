using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.States
{
	// Token: 0x020006A4 RID: 1700
	[global::Cpp2ILInjected.Token(Token = "0x2000A6F")]
	public class UIBestiaryTest : UIState
	{
		// Token: 0x060042A1 RID: 17057 RVA: 0x0002DE96 File Offset: 0x0002C096
		[global::Cpp2ILInjected.Token(Token = "0x6004EB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EBE40", Offset = "0x8EBE40", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntryFilterer<, >), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntrySorter<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Filters.BySearch), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntryFilterer<, >), Member = "SetSearchFilterObject", MemberTypeParameters = new object[] { "Z" }, MemberParameters = new object[] { "Z" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntryFilterer<, >), Member = "AddFilters", MemberParameters = new object[] { "System.Collections.Generic.List`1<U>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntrySorter<object, object>), Member = "AddSortSteps", MemberParameters = new object[] { typeof(List<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public UIBestiaryTest(BestiaryDatabase database)
		{
			throw null;
		}

		// Token: 0x060042A2 RID: 17058 RVA: 0x0002DE99 File Offset: 0x0002C099
		[global::Cpp2ILInjected.Token(Token = "0x6004EBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EC780", Offset = "0x8EC780", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void OnOpenPage()
		{
			throw null;
		}

		// Token: 0x060042A3 RID: 17059 RVA: 0x0002DE9C File Offset: 0x0002C09C
		[global::Cpp2ILInjected.Token(Token = "0x6004EBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EC01C", Offset = "0x8EC01C", Length = "0x764")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RemoveAllChildren", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "MakeExitButton", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryInfoPage), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "AddSortAndFilterButtons", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(UIBestiaryEntryInfoPage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "AddSearchBar", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(UIBestiaryEntryInfoPage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "FillProgressBottomBar", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryGrid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(List<BestiaryEntry>),
			typeof(UIElement.MouseEvent)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryGrid), Member = "add_OnGridContentsChanged", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "AddBackAndForwardButtons", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiarySortingOptionsGrid), Member = ".ctor", MemberParameters = new object[] { typeof(EntrySorter<BestiaryEntry, IBestiarySortStep>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiarySortingOptionsGrid), Member = "add_OnClickingOption", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = ".ctor", MemberParameters = new object[] { typeof(EntryFilterer<BestiaryEntry, IBestiaryEntryFilter>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "add_OnClickingOption", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "SetupAvailabilityTest", MemberParameters = new object[] { typeof(List<BestiaryEntry>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "SetContents", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "UpdateBestiaryContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		private void BuildPage()
		{
			throw null;
		}

		// Token: 0x060042A4 RID: 17060 RVA: 0x0002DE9F File Offset: 0x0002C09F
		[global::Cpp2ILInjected.Token(Token = "0x6004EBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x8ED92C", Offset = "0x8ED92C", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "BuildPage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIColoredSliderSimple), Member = ".ctor", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void FillProgressBottomBar(UIElement container)
		{
			throw null;
		}

		// Token: 0x060042A5 RID: 17061 RVA: 0x0002DEA2 File Offset: 0x0002C0A2
		[global::Cpp2ILInjected.Token(Token = "0x6004EBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EE0D8", Offset = "0x8EE0D8", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "GetCompletionPercentText", ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ShowStats_Completion(UIElement element)
		{
			throw null;
		}

		// Token: 0x060042A6 RID: 17062 RVA: 0x0002DEA5 File Offset: 0x0002C0A5
		[global::Cpp2ILInjected.Token(Token = "0x6004EBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EE180", Offset = "0x8EE180", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "ShowStats_Completion", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "UpdateBestiaryContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryUnlockProgressReport), Member = "get_CompletionPercent", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "PrettifyPercentDisplay", MemberParameters = new object[]
		{
			typeof(float),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<>f__AnonymousType6<>), Member = ".ctor", MemberParameters = new object[] { "<Percent>j__TPar" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValueWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private string GetCompletionPercentText()
		{
			throw null;
		}

		// Token: 0x060042A7 RID: 17063 RVA: 0x0002DEA8 File Offset: 0x0002C0A8
		[global::Cpp2ILInjected.Token(Token = "0x6004EBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EE284", Offset = "0x8EE284", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryUnlockProgressReport), Member = "get_CompletionPercent", ReturnType = typeof(float))]
		private float GetProgressPercent()
		{
			throw null;
		}

		// Token: 0x060042A8 RID: 17064 RVA: 0x0002DEAB File Offset: 0x0002C0AB
		[global::Cpp2ILInjected.Token(Token = "0x6004EC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EE290", Offset = "0x8EE290", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void EmptyInteraction(float input)
		{
			throw null;
		}

		// Token: 0x060042A9 RID: 17065 RVA: 0x0002DEAE File Offset: 0x0002C0AE
		[global::Cpp2ILInjected.Token(Token = "0x6004EC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EE294", Offset = "0x8EE294", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void EmptyInteraction2()
		{
			throw null;
		}

		// Token: 0x060042AA RID: 17066 RVA: 0x0002DEB1 File Offset: 0x0002C0B1
		[global::Cpp2ILInjected.Token(Token = "0x6004EC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EE298", Offset = "0x8EE298", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryUnlockProgressReport), Member = "get_CompletionPercent", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private Color GetColorAtBlip(float percentile)
		{
			throw null;
		}

		// Token: 0x060042AB RID: 17067 RVA: 0x0002DEB4 File Offset: 0x0002C0B4
		[global::Cpp2ILInjected.Token(Token = "0x6004EC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EDB00", Offset = "0x8EDB00", Length = "0x5D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "BuildPage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageButton), Member = ".ctor", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageButton), Member = "SetVisibility", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetSnapPoint", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(Vector2?),
			typeof(Vector2?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryGrid), Member = "MakeButtonGoByOffset", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private void AddBackAndForwardButtons(UIElement innerTopContainer)
		{
			throw null;
		}

		// Token: 0x060042AC RID: 17068 RVA: 0x0002DEB7 File Offset: 0x0002C0B7
		[global::Cpp2ILInjected.Token(Token = "0x6004EC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x8ECAC8", Offset = "0x8ECAC8", Length = "0x670")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "BuildPage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageButton), Member = ".ctor", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageButton), Member = "SetVisibility", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetSnapPoint", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(Vector2?),
			typeof(Vector2?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		private void AddSortAndFilterButtons(UIElement innerTopContainer, UIBestiaryEntryInfoPage infoSpace)
		{
			throw null;
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x0002DEBA File Offset: 0x0002C0BA
		[global::Cpp2ILInjected.Token(Token = "0x6004EC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x8ED138", Offset = "0x8ED138", Length = "0x7F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "BuildPage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageButton), Member = ".ctor", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageButton), Member = "SetVisibility", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetSnapPoint", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(Vector2?),
			typeof(Vector2?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "add_OnContentsChanged", MemberParameters = new object[] { typeof(Action<string>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "add_OnStartTakingInput", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "add_OnEndTakingInput", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "add_OnNeedingVirtualKeyboard", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOver", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		private void AddSearchBar(UIElement innerTopContainer, UIBestiaryEntryInfoPage infoSpace)
		{
			throw null;
		}

		// Token: 0x060042AE RID: 17070 RVA: 0x0002DEBD File Offset: 0x0002C0BD
		[global::Cpp2ILInjected.Token(Token = "0x6004EC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EE2FC", Offset = "0x8EE2FC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "get_HasContents", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "SetContents", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		private void searchCancelButton_OnClick(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x060042AF RID: 17071 RVA: 0x0002DEC0 File Offset: 0x0002C0C0
		[global::Cpp2ILInjected.Token(Token = "0x6004EC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EE354", Offset = "0x8EE354", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		private void searchCancelButton_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x060042B0 RID: 17072 RVA: 0x0002DEC3 File Offset: 0x0002C0C3
		[global::Cpp2ILInjected.Token(Token = "0x6004EC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EE374", Offset = "0x8EE374", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard.KeyboardSubmitEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(UIVirtualKeyboard.KeyboardSubmitEvent),
			typeof(Action),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = "SetState", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void OpenVirtualKeyboardWhenNeeded()
		{
			throw null;
		}

		// Token: 0x060042B1 RID: 17073 RVA: 0x0002DEC6 File Offset: 0x0002C0C6
		[global::Cpp2ILInjected.Token(Token = "0x6004EC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EF998", Offset = "0x8EF998", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "SetContents", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		private void OnFinishedSettingName(string name)
		{
			throw null;
		}

		// Token: 0x060042B2 RID: 17074 RVA: 0x0002DEC9 File Offset: 0x0002C0C9
		[global::Cpp2ILInjected.Token(Token = "0x6004ECA")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EF9D0", Offset = "0x8EF9D0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = "SetState", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "ToggleTakingText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void GoBackHere()
		{
			throw null;
		}

		// Token: 0x060042B3 RID: 17075 RVA: 0x0002DECC File Offset: 0x0002C0CC
		[global::Cpp2ILInjected.Token(Token = "0x6004ECB")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EFA40", Offset = "0x8EFA40", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnStartTakingInput()
		{
			throw null;
		}

		// Token: 0x060042B4 RID: 17076 RVA: 0x0002DECF File Offset: 0x0002C0CF
		[global::Cpp2ILInjected.Token(Token = "0x6004ECC")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EFAA4", Offset = "0x8EFAA4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void OnEndTakingInput()
		{
			throw null;
		}

		// Token: 0x060042B5 RID: 17077 RVA: 0x0002DED2 File Offset: 0x0002C0D2
		[global::Cpp2ILInjected.Token(Token = "0x6004ECD")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EFAE0", Offset = "0x8EFAE0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntryFilterer<, >), Member = "SetSearchFilter", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "UpdateBestiaryContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnSearchContentsChanged(string contents)
		{
			throw null;
		}

		// Token: 0x060042B6 RID: 17078 RVA: 0x0002DED5 File Offset: 0x0002C0D5
		[global::Cpp2ILInjected.Token(Token = "0x6004ECE")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EFB44", Offset = "0x8EFB44", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "ToggleTakingText", ReturnType = typeof(void))]
		private void Click_SearchArea(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x060042B7 RID: 17079 RVA: 0x0002DED8 File Offset: 0x0002C0D8
		[global::Cpp2ILInjected.Token(Token = "0x6004ECF")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EFB7C", Offset = "0x8EFB7C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "LeftClick", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void LeftClick(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x060042B8 RID: 17080 RVA: 0x0002DEDB File Offset: 0x0002C0DB
		[global::Cpp2ILInjected.Token(Token = "0x6004ED0")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EFBA8", Offset = "0x8EFBA8", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RightClick", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void RightClick(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x060042B9 RID: 17081 RVA: 0x0002DEDE File Offset: 0x0002C0DE
		[global::Cpp2ILInjected.Token(Token = "0x6004ED1")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EFB9C", Offset = "0x8EFB9C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void AttemptStoppingUsingSearchbar(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x060042BA RID: 17082 RVA: 0x0002DEE1 File Offset: 0x0002C0E1
		[global::Cpp2ILInjected.Token(Token = "0x6004ED2")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EFBC8", Offset = "0x8EFBC8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISearchBar), Member = "ToggleTakingText", ReturnType = typeof(void))]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x0002DEE4 File Offset: 0x0002C0E4
		[global::Cpp2ILInjected.Token(Token = "0x6004ED3")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EFC08", Offset = "0x8EFC08", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "UpdateBestiaryContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void FilterEntries()
		{
			throw null;
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x0002DEE7 File Offset: 0x0002C0E7
		[global::Cpp2ILInjected.Token(Token = "0x6004ED4")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EFD0C", Offset = "0x8EFD0C", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "UpdateBestiaryContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(IComparer<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private void SortEntries()
		{
			throw null;
		}

		// Token: 0x060042BD RID: 17085 RVA: 0x0002DEEA File Offset: 0x0002C0EA
		[global::Cpp2ILInjected.Token(Token = "0x6004ED5")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EFFE8", Offset = "0x8EFFE8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "UpdateBestiaryContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryInfoPage), Member = "FillInfoForEntry", MemberParameters = new object[]
		{
			typeof(BestiaryEntry),
			typeof(ExtraBestiaryInfoPageInformation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "GetUnlockProgress", ReturnType = typeof(BestiaryUnlockProgressReport))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryGrid), Member = "FillBestiarySpaceWithEntries", ReturnType = typeof(void))]
		private void FillBestiarySpaceWithEntries()
		{
			throw null;
		}

		// Token: 0x060042BE RID: 17086 RVA: 0x0002DEED File Offset: 0x0002C0ED
		[global::Cpp2ILInjected.Token(Token = "0x6004ED6")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F018C", Offset = "0x8F018C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryGrid), Member = "GetRangeText", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = "SetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public void UpdateBestiaryGridRange()
		{
			throw null;
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x0002DEF0 File Offset: 0x0002C0F0
		[global::Cpp2ILInjected.Token(Token = "0x6004ED7")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F01B4", Offset = "0x8F01B4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "FillBestiarySpaceWithEntries", ReturnType = typeof(void))]
		public override void Recalculate()
		{
			throw null;
		}

		// Token: 0x060042C0 RID: 17088 RVA: 0x0002DEF3 File Offset: 0x0002C0F3
		[global::Cpp2ILInjected.Token(Token = "0x6004ED8")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F01D0", Offset = "0x8F01D0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "ToRectangle", ReturnType = typeof(Rectangle))]
		private void GetEntriesToShow(out int maxEntriesWidth, out int maxEntriesHeight, out int maxEntriesToHave)
		{
			throw null;
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x0002DEF6 File Offset: 0x0002C0F6
		[global::Cpp2ILInjected.Token(Token = "0x6004ED9")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EC884", Offset = "0x8EC884", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "BuildPage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = ".ctor", MemberParameters = new object[]
		{
			"T",
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "FromPixelsAndPercent", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(StyleDimension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "FromPixels", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(StyleDimension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOver", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOut", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftMouseDown", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetSnapPoint", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(Vector2?),
			typeof(Vector2?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void MakeExitButton(UIElement outerContainer)
		{
			throw null;
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x0002DEF9 File Offset: 0x0002C0F9
		[global::Cpp2ILInjected.Token(Token = "0x6004EDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F0250", Offset = "0x8F0250", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IngameFancyUI), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void Click_GoBack(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x060042C3 RID: 17091 RVA: 0x0002DEFC File Offset: 0x0002C0FC
		[global::Cpp2ILInjected.Token(Token = "0x6004EDB")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F02F0", Offset = "0x8F02F0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "UpdateBestiaryContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RemoveChild", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		private void OpenOrCloseSortingOptions(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x060042C4 RID: 17092 RVA: 0x0002DEFF File Offset: 0x0002C0FF
		[global::Cpp2ILInjected.Token(Token = "0x6004EDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F0370", Offset = "0x8F0370", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "UpdateBestiaryContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RemoveChild", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		private void OpenOrCloseFilteringGrid(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x060042C5 RID: 17093 RVA: 0x0002DF02 File Offset: 0x0002C102
		[global::Cpp2ILInjected.Token(Token = "0x6004EDD")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F03F4", Offset = "0x8F03F4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "UpdateBestiaryContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RemoveChild", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		private void Click_CloseFilteringGrid(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x060042C6 RID: 17094 RVA: 0x0002DF05 File Offset: 0x0002C105
		[global::Cpp2ILInjected.Token(Token = "0x6004EDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F03D4", Offset = "0x8F03D4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "UpdateBestiaryContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RemoveChild", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		private void CloseFilteringGrid()
		{
			throw null;
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x0002DF08 File Offset: 0x0002C108
		[global::Cpp2ILInjected.Token(Token = "0x6004EDF")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EC784", Offset = "0x8EC784", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "BuildPage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "OnSearchContentsChanged", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "OpenOrCloseSortingOptions", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "OpenOrCloseFilteringGrid", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "Click_CloseFilteringGrid", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "CloseFilteringGrid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "Click_CloseSortingGrid", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "CloseSortingGrid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryFilteringOptionsGrid), Member = "UpdateAvailability", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntrySorter<object, object>), Member = "GetDisplayName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = "SetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntryFilterer<, >), Member = "GetDisplayName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "FilterEntries", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "SortEntries", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "FillBestiarySpaceWithEntries", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "GetUnlockProgress", ReturnType = typeof(BestiaryUnlockProgressReport))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "GetCompletionPercentText", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BestiaryUnlockProgressReport), Member = "get_CompletionPercent", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void UpdateBestiaryContents()
		{
			throw null;
		}

		// Token: 0x060042C8 RID: 17096 RVA: 0x0002DF0B File Offset: 0x0002C10B
		[global::Cpp2ILInjected.Token(Token = "0x6004EE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F042C", Offset = "0x8F042C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "UpdateBestiaryContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RemoveChild", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		private void Click_CloseSortingGrid(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x060042C9 RID: 17097 RVA: 0x0002DF0E File Offset: 0x0002C10E
		[global::Cpp2ILInjected.Token(Token = "0x6004EE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F0350", Offset = "0x8F0350", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryTest), Member = "UpdateBestiaryContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RemoveChild", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		private void CloseSortingGrid()
		{
			throw null;
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x0002DF11 File Offset: 0x0002C111
		[global::Cpp2ILInjected.Token(Token = "0x6004EE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F0464", Offset = "0x8F0464", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void FadedMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x0002DF14 File Offset: 0x0002C114
		[global::Cpp2ILInjected.Token(Token = "0x6004EE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F059C", Offset = "0x8F059C", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void FadedMouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x060042CC RID: 17100 RVA: 0x0002DF17 File Offset: 0x0002C117
		[global::Cpp2ILInjected.Token(Token = "0x6004EE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F06B8", Offset = "0x8F06B8", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Click_SelectEntryButton(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x0002DF1A File Offset: 0x0002C11A
		[global::Cpp2ILInjected.Token(Token = "0x6004EE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F0748", Offset = "0x8F0748", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryInfoPage), Member = "FillInfoForEntry", MemberParameters = new object[]
		{
			typeof(BestiaryEntry),
			typeof(ExtraBestiaryInfoPageInformation)
		}, ReturnType = typeof(void))]
		private void SelectEntryButton(UIBestiaryEntryButton button)
		{
			throw null;
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x0002DF1D File Offset: 0x0002C11D
		[global::Cpp2ILInjected.Token(Token = "0x6004EE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F003C", Offset = "0x8F003C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBestiaryEntryInfoPage), Member = "FillInfoForEntry", MemberParameters = new object[]
		{
			typeof(BestiaryEntry),
			typeof(ExtraBestiaryInfoPageInformation)
		}, ReturnType = typeof(void))]
		private void DeselectEntryButton()
		{
			throw null;
		}

		// Token: 0x060042CF RID: 17103 RVA: 0x0002DF20 File Offset: 0x0002C120
		[global::Cpp2ILInjected.Token(Token = "0x6004EE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F0050", Offset = "0x8F0050", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "FillBestiarySpaceWithEntries", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "UpdateBestiaryContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public BestiaryUnlockProgressReport GetUnlockProgress()
		{
			throw null;
		}

		// Token: 0x060042D0 RID: 17104 RVA: 0x0002DF23 File Offset: 0x0002C123
		[global::Cpp2ILInjected.Token(Token = "0x6004EE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F078C", Offset = "0x8F078C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		public override void Draw(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x04006ED6 RID: 28374
		[global::Cpp2ILInjected.Token(Token = "0x40087CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private UIElement _bestiarySpace;

		// Token: 0x04006ED7 RID: 28375
		[global::Cpp2ILInjected.Token(Token = "0x40087D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private UIBestiaryEntryInfoPage _infoSpace;

		// Token: 0x04006ED8 RID: 28376
		[global::Cpp2ILInjected.Token(Token = "0x40087D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private UIBestiaryEntryButton _selectedEntryButton;

		// Token: 0x04006ED9 RID: 28377
		[global::Cpp2ILInjected.Token(Token = "0x40087D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private List<BestiaryEntry> _originalEntriesList;

		// Token: 0x04006EDA RID: 28378
		[global::Cpp2ILInjected.Token(Token = "0x40087D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private List<BestiaryEntry> _workingSetEntries;

		// Token: 0x04006EDB RID: 28379
		[global::Cpp2ILInjected.Token(Token = "0x40087D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private UIText _indexesRangeText;

		// Token: 0x04006EDC RID: 28380
		[global::Cpp2ILInjected.Token(Token = "0x40087D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private EntryFilterer<BestiaryEntry, IBestiaryEntryFilter> _filterer;

		// Token: 0x04006EDD RID: 28381
		[global::Cpp2ILInjected.Token(Token = "0x40087D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		private EntrySorter<BestiaryEntry, IBestiarySortStep> _sorter;

		// Token: 0x04006EDE RID: 28382
		[global::Cpp2ILInjected.Token(Token = "0x40087D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		private UIBestiaryEntryGrid _entryGrid;

		// Token: 0x04006EDF RID: 28383
		[global::Cpp2ILInjected.Token(Token = "0x40087D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		private UIBestiarySortingOptionsGrid _sortingGrid;

		// Token: 0x04006EE0 RID: 28384
		[global::Cpp2ILInjected.Token(Token = "0x40087D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
		private UIBestiaryFilteringOptionsGrid _filteringGrid;

		// Token: 0x04006EE1 RID: 28385
		[global::Cpp2ILInjected.Token(Token = "0x40087DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
		private UISearchBar _searchBar;

		// Token: 0x04006EE2 RID: 28386
		[global::Cpp2ILInjected.Token(Token = "0x40087DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
		private UIPanel _searchBoxPanel;

		// Token: 0x04006EE3 RID: 28387
		[global::Cpp2ILInjected.Token(Token = "0x40087DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
		private UIText _sortingText;

		// Token: 0x04006EE4 RID: 28388
		[global::Cpp2ILInjected.Token(Token = "0x40087DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
		private UIText _filteringText;

		// Token: 0x04006EE5 RID: 28389
		[global::Cpp2ILInjected.Token(Token = "0x40087DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
		private string _searchString;

		// Token: 0x04006EE6 RID: 28390
		[global::Cpp2ILInjected.Token(Token = "0x40087DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
		private BestiaryUnlockProgressReport _progressReport;

		// Token: 0x04006EE7 RID: 28391
		[global::Cpp2ILInjected.Token(Token = "0x40087E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
		private UIText _progressPercentText;

		// Token: 0x04006EE8 RID: 28392
		[global::Cpp2ILInjected.Token(Token = "0x40087E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
		private UIColoredSliderSimple _unlocksProgressBar;

		// Token: 0x04006EE9 RID: 28393
		[global::Cpp2ILInjected.Token(Token = "0x40087E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
		private bool _didClickSomething;

		// Token: 0x04006EEA RID: 28394
		[global::Cpp2ILInjected.Token(Token = "0x40087E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E1")]
		private bool _didClickSearchBar;
	}
}
