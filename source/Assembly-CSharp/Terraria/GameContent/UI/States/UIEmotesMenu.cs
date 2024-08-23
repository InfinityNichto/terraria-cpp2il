using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.GameContent.Events;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.States
{
	// Token: 0x020006A6 RID: 1702
	[global::Cpp2ILInjected.Token(Token = "0x2000A76")]
	public class UIEmotesMenu : UIState
	{
		// Token: 0x060042F0 RID: 17136 RVA: 0x0002DF83 File Offset: 0x0002C183
		[global::Cpp2ILInjected.Token(Token = "0x6004F09")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F28DC", Offset = "0x8F28DC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIEmotesMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void OnActivate()
		{
			throw null;
		}

		// Token: 0x060042F1 RID: 17137 RVA: 0x0002DF86 File Offset: 0x0002C186
		[global::Cpp2ILInjected.Token(Token = "0x6004F0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F2998", Offset = "0x8F2998", Length = "0x698")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "OnActivate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RemoveAllChildren", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIScrollbar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIScrollbar), Member = "SetView", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "FromPixels", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(StyleDimension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIList), Member = "SetScrollbar", MemberParameters = new object[] { typeof(UIScrollbar) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = ".ctor", MemberParameters = new object[]
		{
			"T",
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOver", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOut", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetSnapPoint", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(Vector2?),
			typeof(Vector2?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIEmotesMenu), Member = "GetEmotesGeneral", ReturnType = typeof(List<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIEmotesMenu), Member = "TryAddingList", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(ref int),
			typeof(int),
			typeof(List<int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIEmotesMenu), Member = "GetEmotesRPS", ReturnType = typeof(List<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIEmotesMenu), Member = "GetEmotesItems", ReturnType = typeof(List<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIEmotesMenu), Member = "GetEmotesBiomesAndEvents", ReturnType = typeof(List<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIEmotesMenu), Member = "GetEmotesTownNPCs", ReturnType = typeof(List<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIEmotesMenu), Member = "GetEmotesCritters", ReturnType = typeof(List<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIEmotesMenu), Member = "GetEmotesBosses", ReturnType = typeof(List<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public void InitializePage()
		{
			throw null;
		}

		// Token: 0x060042F2 RID: 17138 RVA: 0x0002DF89 File Offset: 0x0002C189
		[global::Cpp2ILInjected.Token(Token = "0x6004F0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F3AB0", Offset = "0x8F3AB0", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EmotesGroupListItem), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void TryAddingList(LocalizedText title, ref int currentGroupIndex, int maxEmotesPerRow, List<int> emoteIds)
		{
			throw null;
		}

		// Token: 0x060042F3 RID: 17139 RVA: 0x0002DF8C File Offset: 0x0002C18C
		[global::Cpp2ILInjected.Token(Token = "0x6004F0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F3030", Offset = "0x8F3030", Length = "0xA80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private List<int> GetEmotesGeneral()
		{
			throw null;
		}

		// Token: 0x060042F4 RID: 17140 RVA: 0x0002DF8F File Offset: 0x0002C18F
		[global::Cpp2ILInjected.Token(Token = "0x6004F0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F3BAC", Offset = "0x8F3BAC", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private List<int> GetEmotesRPS()
		{
			throw null;
		}

		// Token: 0x060042F5 RID: 17141 RVA: 0x0002DF92 File Offset: 0x0002C192
		[global::Cpp2ILInjected.Token(Token = "0x6004F0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F3E40", Offset = "0x8F3E40", Length = "0x874")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private List<int> GetEmotesItems()
		{
			throw null;
		}

		// Token: 0x060042F6 RID: 17142 RVA: 0x0002DF95 File Offset: 0x0002C195
		[global::Cpp2ILInjected.Token(Token = "0x6004F0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F46B4", Offset = "0x8F46B4", Length = "0x874")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private List<int> GetEmotesBiomesAndEvents()
		{
			throw null;
		}

		// Token: 0x060042F7 RID: 17143 RVA: 0x0002DF98 File Offset: 0x0002C198
		[global::Cpp2ILInjected.Token(Token = "0x6004F10")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F4F28", Offset = "0x8F4F28", Length = "0xADC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private List<int> GetEmotesTownNPCs()
		{
			throw null;
		}

		// Token: 0x060042F8 RID: 17144 RVA: 0x0002DF9B File Offset: 0x0002C19B
		[global::Cpp2ILInjected.Token(Token = "0x6004F11")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F5A04", Offset = "0x8F5A04", Length = "0x388")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private List<int> GetEmotesCritters()
		{
			throw null;
		}

		// Token: 0x060042F9 RID: 17145 RVA: 0x0002DF9E File Offset: 0x0002C19E
		[global::Cpp2ILInjected.Token(Token = "0x6004F12")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F5D8C", Offset = "0x8F5D8C", Length = "0xCCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DD2Event), Member = "get_DownedInvasionAnyDifficulty", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		private List<int> GetEmotesBosses()
		{
			throw null;
		}

		// Token: 0x060042FA RID: 17146 RVA: 0x0002DFA1 File Offset: 0x0002C1A1
		[global::Cpp2ILInjected.Token(Token = "0x6004F13")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F6A58", Offset = "0x8F6A58", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIScrollbar), Member = "get_CanScroll", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "RemoveChild", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Recalculate", ReturnType = typeof(void))]
		public override void Recalculate()
		{
			throw null;
		}

		// Token: 0x060042FB RID: 17147 RVA: 0x0002DFA4 File Offset: 0x0002C1A4
		[global::Cpp2ILInjected.Token(Token = "0x6004F14")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F6AFC", Offset = "0x8F6AFC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_menuMode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IngameFancyUI), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void GoBackClick(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x060042FC RID: 17148 RVA: 0x0002DFA7 File Offset: 0x0002C1A7
		[global::Cpp2ILInjected.Token(Token = "0x6004F15")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F6B58", Offset = "0x8F6B58", Length = "0x138")]
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

		// Token: 0x060042FD RID: 17149 RVA: 0x0002DFAA File Offset: 0x0002C1AA
		[global::Cpp2ILInjected.Token(Token = "0x6004F16")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F6C90", Offset = "0x8F6C90", Length = "0x11C")]
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

		// Token: 0x060042FE RID: 17150 RVA: 0x0002DFAD File Offset: 0x0002C1AD
		[global::Cpp2ILInjected.Token(Token = "0x6004F17")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F6DAC", Offset = "0x8F6DAC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		public override void Draw(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x0002DFB0 File Offset: 0x0002C1B0
		[global::Cpp2ILInjected.Token(Token = "0x6004F18")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F6DB4", Offset = "0x8F6DB4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIState), Member = ".ctor", ReturnType = typeof(void))]
		public UIEmotesMenu()
		{
			throw null;
		}

		// Token: 0x04006EFB RID: 28411
		[global::Cpp2ILInjected.Token(Token = "0x4008809")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private UIElement _outerContainer;

		// Token: 0x04006EFC RID: 28412
		[global::Cpp2ILInjected.Token(Token = "0x400880A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private UIElement _backPanel;

		// Token: 0x04006EFD RID: 28413
		[global::Cpp2ILInjected.Token(Token = "0x400880B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private UIElement _container;

		// Token: 0x04006EFE RID: 28414
		[global::Cpp2ILInjected.Token(Token = "0x400880C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private UIList _list;

		// Token: 0x04006EFF RID: 28415
		[global::Cpp2ILInjected.Token(Token = "0x400880D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private UIScrollbar _scrollBar;

		// Token: 0x04006F00 RID: 28416
		[global::Cpp2ILInjected.Token(Token = "0x400880E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private bool _isScrollbarAttached;
	}
}
