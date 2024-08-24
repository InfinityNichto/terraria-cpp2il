using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006BE RID: 1726
	[global::Cpp2ILInjected.Token(Token = "0x2000A9D")]
	public class UICreativeItemsInfiniteFilteringOptions : UIElement
	{
		// Token: 0x14000059 RID: 89
		// (add) Token: 0x060043E3 RID: 17379 RVA: 0x0002E250 File Offset: 0x0002C450
		// (remove) Token: 0x060043E4 RID: 17380 RVA: 0x0002E253 File Offset: 0x0002C453
		[global::Cpp2ILInjected.Token(Token = "0x1400005F")]
		public event Action OnClickingOption
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600502A")]
			[global::Cpp2ILInjected.Address(RVA = "0x90A6E8", Offset = "0x90A6E8", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildInfinitesMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.Token(Token = "0x600502B")]
			[global::Cpp2ILInjected.Address(RVA = "0x90A788", Offset = "0x90A788", Length = "0xA0")]
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

		// Token: 0x060043E5 RID: 17381 RVA: 0x0002E256 File Offset: 0x0002C456
		[global::Cpp2ILInjected.Token(Token = "0x600502C")]
		[global::Cpp2ILInjected.Address(RVA = "0x90A828", Offset = "0x90A828", Length = "0x5D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildInfinitesMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageFramed), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOver", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetSnapPoint", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(Vector2?),
			typeof(Vector2?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeItemsInfiniteFilteringOptions), Member = "AddOnHover", MemberParameters = new object[]
		{
			typeof(IItemEntryFilter),
			typeof(UIElement),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeItemsInfiniteFilteringOptions), Member = "UpdateVisuals", MemberParameters = new object[]
		{
			typeof(UIImageFramed),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public UICreativeItemsInfiniteFilteringOptions(EntryFilterer<Item, IItemEntryFilter> filterer, string snapPointsName)
		{
			throw null;
		}

		// Token: 0x060043E6 RID: 17382 RVA: 0x0002E259 File Offset: 0x0002C459
		[global::Cpp2ILInjected.Token(Token = "0x600502D")]
		[global::Cpp2ILInjected.Address(RVA = "0x90B114", Offset = "0x90B114", Length = "0x20")]
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
		private void button_OnMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x060043E7 RID: 17383 RVA: 0x0002E25C File Offset: 0x0002C45C
		[global::Cpp2ILInjected.Token(Token = "0x600502E")]
		[global::Cpp2ILInjected.Address(RVA = "0x90B134", Offset = "0x90B134", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntryFilterer<, >), Member = "ToggleFilter", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeItemsInfiniteFilteringOptions), Member = "UpdateVisuals", MemberParameters = new object[]
		{
			typeof(UIImageFramed),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void singleFilterButtonClick(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x060043E8 RID: 17384 RVA: 0x0002E25F File Offset: 0x0002C45F
		[global::Cpp2ILInjected.Token(Token = "0x600502F")]
		[global::Cpp2ILInjected.Address(RVA = "0x90AF18", Offset = "0x90AF18", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeItemsInfiniteFilteringOptions.<>c__DisplayClass12_0), Member = "<AddOnHover>b__1", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeItemsInfiniteFilteringOptions), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(EntryFilterer<Item, IItemEntryFilter>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeItemsInfiniteFilteringOptions), Member = "singleFilterButtonClick", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EntryFilterer<, >), Member = "IsFilterActive", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageFramed), Member = "SetFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void UpdateVisuals(UIImageFramed button, int indexOfFilter)
		{
			throw null;
		}

		// Token: 0x060043E9 RID: 17385 RVA: 0x0002E262 File Offset: 0x0002C462
		[global::Cpp2ILInjected.Token(Token = "0x6005030")]
		[global::Cpp2ILInjected.Address(RVA = "0x90AE00", Offset = "0x90AE00", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeItemsInfiniteFilteringOptions), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(EntryFilterer<Item, IItemEntryFilter>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void AddOnHover(IItemEntryFilter filter, UIElement button, int indexOfFilter)
		{
			throw null;
		}

		// Token: 0x060043EA RID: 17386 RVA: 0x0002E265 File Offset: 0x0002C465
		[global::Cpp2ILInjected.Token(Token = "0x6005031")]
		[global::Cpp2ILInjected.Address(RVA = "0x90B2D4", Offset = "0x90B2D4", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeItemsInfiniteFilteringOptions.<>c__DisplayClass12_0), Member = "<AddOnHover>b__0", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
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
		private void ShowButtonName(UIElement element, IItemEntryFilter number, int indexOfFilter)
		{
			throw null;
		}

		// Token: 0x04006FCA RID: 28618
		[global::Cpp2ILInjected.Token(Token = "0x40088FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private EntryFilterer<Item, IItemEntryFilter> _filterer;

		// Token: 0x04006FCB RID: 28619
		[global::Cpp2ILInjected.Token(Token = "0x40088FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private Dictionary<UIImageFramed, IItemEntryFilter> _filtersByButtons;

		// Token: 0x04006FCC RID: 28620
		[global::Cpp2ILInjected.Token(Token = "0x40088FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private Dictionary<UIImageFramed, UIElement> _iconsByButtons;

		// Token: 0x04006FCD RID: 28621
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40088FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private Action OnClickingOption;

		// Token: 0x04006FCE RID: 28622
		[global::Cpp2ILInjected.Token(Token = "0x4008900")]
		private const int barFramesX = 2;

		// Token: 0x04006FCF RID: 28623
		[global::Cpp2ILInjected.Token(Token = "0x4008901")]
		private const int barFramesY = 4;

		// Token: 0x02000ABB RID: 2747
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000A9E")]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06005273 RID: 21107 RVA: 0x000308AB File Offset: 0x0002EAAB
			[global::Cpp2ILInjected.Token(Token = "0x6005032")]
			[global::Cpp2ILInjected.Address(RVA = "0x90B2CC", Offset = "0x90B2CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass12_0()
			{
				throw null;
			}

			// Token: 0x06005274 RID: 21108 RVA: 0x000308AE File Offset: 0x0002EAAE
			[global::Cpp2ILInjected.Token(Token = "0x6005033")]
			[global::Cpp2ILInjected.Address(RVA = "0x90B3EC", Offset = "0x90B3EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeItemsInfiniteFilteringOptions), Member = "ShowButtonName", MemberParameters = new object[]
			{
				typeof(UIElement),
				typeof(IItemEntryFilter),
				typeof(int)
			}, ReturnType = typeof(void))]
			internal void <AddOnHover>b__0(UIElement element)
			{
				throw null;
			}

			// Token: 0x06005275 RID: 21109 RVA: 0x000308B1 File Offset: 0x0002EAB1
			[global::Cpp2ILInjected.Token(Token = "0x6005034")]
			[global::Cpp2ILInjected.Address(RVA = "0x90B3F4", Offset = "0x90B3F4", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativeItemsInfiniteFilteringOptions), Member = "UpdateVisuals", MemberParameters = new object[]
			{
				typeof(UIImageFramed),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <AddOnHover>b__1(UIElement element)
			{
				throw null;
			}

			// Token: 0x04008F3E RID: 36670
			[global::Cpp2ILInjected.Token(Token = "0x4008902")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public UICreativeItemsInfiniteFilteringOptions <>4__this;

			// Token: 0x04008F3F RID: 36671
			[global::Cpp2ILInjected.Token(Token = "0x4008903")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public IItemEntryFilter filter;

			// Token: 0x04008F40 RID: 36672
			[global::Cpp2ILInjected.Token(Token = "0x4008904")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public int indexOfFilter;

			// Token: 0x04008F41 RID: 36673
			[global::Cpp2ILInjected.Token(Token = "0x4008905")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public UIElement button;
		}
	}
}
