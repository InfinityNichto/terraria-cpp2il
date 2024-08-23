using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.States;
using Terraria.Localization;
using Terraria.Net;
using Terraria.UI;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000680 RID: 1664
	[global::Cpp2ILInjected.Token(Token = "0x2000A12")]
	public class CreativeUI
	{
		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06004180 RID: 16768 RVA: 0x0002DB5D File Offset: 0x0002BD5D
		// (set) Token: 0x06004181 RID: 16769 RVA: 0x0002DB60 File Offset: 0x0002BD60
		[global::Cpp2ILInjected.Token(Token = "0x17000874")]
		public bool Enabled
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004C15")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B6274", Offset = "0x8B6274", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004C16")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B627C", Offset = "0x8B627C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06004182 RID: 16770 RVA: 0x0002DB63 File Offset: 0x0002BD63
		[global::Cpp2ILInjected.Token(Token = "0x17000875")]
		public bool Blocked
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004C17")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B6288", Offset = "0x8B6288", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004183 RID: 16771 RVA: 0x0002DB66 File Offset: 0x0002BD66
		[global::Cpp2ILInjected.Token(Token = "0x6004C18")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B6314", Offset = "0x8B6314", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public CreativeUI()
		{
			throw null;
		}

		// Token: 0x06004184 RID: 16772 RVA: 0x0002DB69 File Offset: 0x0002BD69
		[global::Cpp2ILInjected.Token(Token = "0x6004C19")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B6470", Offset = "0x8B6470", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = "SetState", MemberParameters = new object[] { typeof(UIState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void Initialize()
		{
			throw null;
		}

		// Token: 0x06004185 RID: 16773 RVA: 0x0002DB6C File Offset: 0x0002BD6C
		[global::Cpp2ILInjected.Token(Token = "0x6004C1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B6694", Offset = "0x8B6694", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_playerInventory", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x06004186 RID: 16774 RVA: 0x0002DB6F File Offset: 0x0002BD6F
		[global::Cpp2ILInjected.Token(Token = "0x6004C1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B6714", Offset = "0x8B6714", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeUI), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeUI), Member = "get_Blocked", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_inventoryScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeUI), Member = "DrawToggleButton", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(GameTime)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void Draw(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06004187 RID: 16775 RVA: 0x0002DB72 File Offset: 0x0002BD72
		[global::Cpp2ILInjected.Token(Token = "0x6004C1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B6CD4", Offset = "0x8B6CD4", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildSacrificeMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIItemSlot), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public UIElement ProvideItemSlotElement(int itemSlotContext)
		{
			throw null;
		}

		// Token: 0x06004188 RID: 16776 RVA: 0x0002DB75 File Offset: 0x0002BD75
		[global::Cpp2ILInjected.Token(Token = "0x6004C1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B6D4C", Offset = "0x8B6D4C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SaveTemporaryItemSlotContents", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ClearPlayerTempInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public Item GetItemByIndex(int itemSlotContext)
		{
			throw null;
		}

		// Token: 0x06004189 RID: 16777 RVA: 0x0002DB78 File Offset: 0x0002BD78
		[global::Cpp2ILInjected.Token(Token = "0x6004C1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B6D64", Offset = "0x8B6D64", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SetPlayerDataToOutOfClassFields", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void SetItembyIndex(Item item, int itemSlotContext)
		{
			throw null;
		}

		// Token: 0x0600418A RID: 16778 RVA: 0x0002DB7B File Offset: 0x0002BD7B
		[global::Cpp2ILInjected.Token(Token = "0x6004C1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B6900", Offset = "0x8B6900", Length = "0x3D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "CenteredRectangle", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_MouseScreen", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeftRelease", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeUI), Member = "ToggleMenu", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private void DrawToggleButton(SpriteBatch spritebatch, Vector2 location)
		{
			throw null;
		}

		// Token: 0x0600418B RID: 16779 RVA: 0x0002DB7E File Offset: 0x0002BD7E
		[global::Cpp2ILInjected.Token(Token = "0x6004C20")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B6F8C", Offset = "0x8B6F8C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "OverrideLeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Swap", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(ref object),
			typeof(ref object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void SwapItem(ref Item item)
		{
			throw null;
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x0002DB81 File Offset: 0x0002BD81
		[global::Cpp2ILInjected.Token(Token = "0x6004C21")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B700C", Offset = "0x8B700C", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileEntity), Member = "SetInteractionAnchor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(bool)
		}, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "StopPlayingResearchAnimations", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void CloseMenu()
		{
			throw null;
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x0002DB84 File Offset: 0x0002BD84
		[global::Cpp2ILInjected.Token(Token = "0x6004C22")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B6DAC", Offset = "0x8B6DAC", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ToggleCreativeMenu", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "DrawToggleButton", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "EscapeVirtualKeyboard", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "GoBackHere", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = "EscapeElements", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISliderBase), Member = "EscapeElements", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Recipe), Member = "FindRecipes", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInteractionAnchor), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeUI), Member = "RefreshAvailableInfiniteItemsList", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(bool)
		}, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "StopPlayingResearchAnimations", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void ToggleMenu()
		{
			throw null;
		}

		// Token: 0x0600418E RID: 16782 RVA: 0x0002DB87 File Offset: 0x0002BD87
		[global::Cpp2ILInjected.Token(Token = "0x6004C23")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B71CC", Offset = "0x8B71CC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "OverrideHover", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "OverrideLeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "get_IsShowingResearchMenu", ReturnType = typeof(bool))]
		public bool IsShowingResearchMenu()
		{
			throw null;
		}

		// Token: 0x0600418F RID: 16783 RVA: 0x0002DB8A File Offset: 0x0002BD8A
		[global::Cpp2ILInjected.Token(Token = "0x6004C24")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B71EC", Offset = "0x8B71EC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "OverrideLeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "SacrificeWhatsInResearchMenu", ReturnType = typeof(void))]
		public void SacrificeItemInSacrificeSlot()
		{
			throw null;
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x0002DB8D File Offset: 0x0002BD8D
		[global::Cpp2ILInjected.Token(Token = "0x6004C25")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B713C", Offset = "0x8B713C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICreativePowersMenu), Member = "StopPlayingResearchAnimations", ReturnType = typeof(void))]
		public void StopPlayingSacrificeAnimations()
		{
			throw null;
		}

		// Token: 0x06004191 RID: 16785 RVA: 0x0002DB90 File Offset: 0x0002BD90
		[global::Cpp2ILInjected.Token(Token = "0x6004C26")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B7200", Offset = "0x8B7200", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "descriptionText_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeItemSacrificesCatalog), Member = "TryGetSacrificeCountCapToUnlockInfiniteItems", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayerCreativeTracker", ReturnType = typeof(CreativeUnlocksTracker))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemsSacrificedUnlocksTracker), Member = "GetSacrificeCount", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool ShouldDrawSacrificeArea()
		{
			throw null;
		}

		// Token: 0x06004192 RID: 16786 RVA: 0x0002DB93 File Offset: 0x0002BD93
		[global::Cpp2ILInjected.Token(Token = "0x6004C27")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B73BC", Offset = "0x8B73BC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "descriptionText_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "SacrificeWhatYouCan", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayerCreativeTracker", ReturnType = typeof(CreativeUnlocksTracker))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool GetSacrificeNumbers(out int itemIdChecked, out int amountWeHave, out int amountNeededTotal)
		{
			throw null;
		}

		// Token: 0x06004193 RID: 16787 RVA: 0x0002DB96 File Offset: 0x0002BD96
		[global::Cpp2ILInjected.Token(Token = "0x6004C28")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B7584", Offset = "0x8B7584", Length = "0x354")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "SacrificeWhatYouCan", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayerCreativeTracker", ReturnType = typeof(CreativeUnlocksTracker))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemsSacrificedUnlocksTracker), Member = "TryGetSacrificeNumbers", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCreativeUnlocksPlayerReportModule), Member = "SerializeSacrificeRequest", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "SendToServerOrLoopback", MemberParameters = new object[] { typeof(NetPacket) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemsSacrificedUnlocksTracker), Member = "RegisterItemSacrifice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "TurnToAir", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativeUI), Member = "RefreshAvailableInfiniteItemsList", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(bool)
		}, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public CreativeUI.ItemSacrificeResult SacrificeItem(out int amountWeSacrificed)
		{
			throw null;
		}

		// Token: 0x06004194 RID: 16788 RVA: 0x0002DB99 File Offset: 0x0002BD99
		[global::Cpp2ILInjected.Token(Token = "0x6004C29")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B7150", Offset = "0x8B7150", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "ToggleMenu", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "SacrificeItem", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(CreativeUI.ItemSacrificeResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayerCreativeTracker", ReturnType = typeof(CreativeUnlocksTracker))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemsSacrificedUnlocksTracker), Member = "FillListOfItemsThatCanBeObtainedInfinitely", MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void RefreshAvailableInfiniteItemsList()
		{
			throw null;
		}

		// Token: 0x06004195 RID: 16789 RVA: 0x0002DB9C File Offset: 0x0002BD9C
		[global::Cpp2ILInjected.Token(Token = "0x6004C2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B7CAC", Offset = "0x8B7CAC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "TurnToAir", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x04006DBC RID: 28092
		[global::Cpp2ILInjected.Token(Token = "0x400863D")]
		public const int ItemSlotIndexes_SacrificeItem = 0;

		// Token: 0x04006DBD RID: 28093
		[global::Cpp2ILInjected.Token(Token = "0x400863E")]
		public const int ItemSlotIndexes_Count = 1;

		// Token: 0x04006DBE RID: 28094
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400863F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool <Enabled>k__BackingField;

		// Token: 0x04006DBF RID: 28095
		[global::Cpp2ILInjected.Token(Token = "0x4008640")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		private bool _initialized;

		// Token: 0x04006DC0 RID: 28096
		[global::Cpp2ILInjected.Token(Token = "0x4008641")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Asset<Texture2D> _buttonTexture;

		// Token: 0x04006DC1 RID: 28097
		[global::Cpp2ILInjected.Token(Token = "0x4008642")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Asset<Texture2D> _buttonBorderTexture;

		// Token: 0x04006DC2 RID: 28098
		[global::Cpp2ILInjected.Token(Token = "0x4008643")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Item[] _itemSlotsForUI;

		// Token: 0x04006DC3 RID: 28099
		[global::Cpp2ILInjected.Token(Token = "0x4008644")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private List<int> _itemIdsAvailableInfinitely;

		// Token: 0x04006DC4 RID: 28100
		[global::Cpp2ILInjected.Token(Token = "0x4008645")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private UserInterface _powersUI;

		// Token: 0x04006DC5 RID: 28101
		[global::Cpp2ILInjected.Token(Token = "0x4008646")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public int GamepadPointIdForInfiniteItemSearchHack;

		// Token: 0x04006DC6 RID: 28102
		[global::Cpp2ILInjected.Token(Token = "0x4008647")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public bool GamepadMoveToSearchButtonHack;

		// Token: 0x04006DC7 RID: 28103
		[global::Cpp2ILInjected.Token(Token = "0x4008648")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private UICreativePowersMenu _uiState;

		// Token: 0x02000A71 RID: 2673
		[global::Cpp2ILInjected.Token(Token = "0x2000A13")]
		public enum ItemSacrificeResult
		{
			// Token: 0x04008E9B RID: 36507
			[global::Cpp2ILInjected.Token(Token = "0x400864A")]
			CannotSacrifice,
			// Token: 0x04008E9C RID: 36508
			[global::Cpp2ILInjected.Token(Token = "0x400864B")]
			SacrificedButNotDone,
			// Token: 0x04008E9D RID: 36509
			[global::Cpp2ILInjected.Token(Token = "0x400864C")]
			SacrificedAndDone
		}
	}
}
