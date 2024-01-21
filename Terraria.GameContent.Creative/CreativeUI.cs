using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.UI.States;
using Terraria.UI;

namespace Terraria.GameContent.Creative;

[Cpp2IlInjected.Token(Token = "0x2000683")]
public class CreativeUI
{
	[Cpp2IlInjected.Token(Token = "0x2000A68")]
	public enum ItemSacrificeResult
	{
		[Cpp2IlInjected.Token(Token = "0x4008E88")]
		CannotSacrifice,
		[Cpp2IlInjected.Token(Token = "0x4008E89")]
		SacrificedButNotDone,
		[Cpp2IlInjected.Token(Token = "0x4008E8A")]
		SacrificedAndDone
	}

	[Cpp2IlInjected.Token(Token = "0x4006DBD")]
	public const int ItemSlotIndexes_SacrificeItem = 0;

	[Cpp2IlInjected.Token(Token = "0x4006DBE")]
	public const int ItemSlotIndexes_Count = 1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4006DC0")]
	private bool _initialized;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006DC1")]
	private Asset<Texture2D> _buttonTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006DC2")]
	private Asset<Texture2D> _buttonBorderTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006DC3")]
	private Item[] _itemSlotsForUI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006DC4")]
	private List<int> _itemIdsAvailableInfinitely;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006DC5")]
	private UserInterface _powersUI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006DC6")]
	public int GamepadPointIdForInfiniteItemSearchHack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006DC7")]
	public bool GamepadMoveToSearchButtonHack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006DC8")]
	private UICreativePowersMenu _uiState;

	[Cpp2IlInjected.Token(Token = "0x17000797")]
	public bool Enabled
	{
		[Cpp2IlInjected.Token(Token = "0x60041BD")]
		[Cpp2IlInjected.Address(RVA = "0x108EA08", Offset = "0x108EA08", VA = "0x108EA08")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60041BE")]
		[Cpp2IlInjected.Address(RVA = "0x108EA10", Offset = "0x108EA10", VA = "0x108EA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000798")]
	public bool Blocked
	{
		[Cpp2IlInjected.Token(Token = "0x60041BF")]
		[Cpp2IlInjected.Address(RVA = "0x108EA18", Offset = "0x108EA18", VA = "0x108EA18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60041C0")]
	[Cpp2IlInjected.Address(RVA = "0x108EAD4", Offset = "0x108EAD4", VA = "0x108EAD4")]
	public CreativeUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041C1")]
	[Cpp2IlInjected.Address(RVA = "0x108EC1C", Offset = "0x108EC1C", VA = "0x108EC1C")]
	public void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041C2")]
	[Cpp2IlInjected.Address(RVA = "0x108EE5C", Offset = "0x108EE5C", VA = "0x108EE5C")]
	public void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041C3")]
	[Cpp2IlInjected.Address(RVA = "0x108EF00", Offset = "0x108EF00", VA = "0x108EF00")]
	public void Draw(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041C4")]
	[Cpp2IlInjected.Address(RVA = "0x108F6FC", Offset = "0x108F6FC", VA = "0x108F6FC")]
	public UIElement ProvideItemSlotElement(int itemSlotContext)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60041C5")]
	[Cpp2IlInjected.Address(RVA = "0x108F794", Offset = "0x108F794", VA = "0x108F794")]
	public Item GetItemByIndex(int itemSlotContext)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60041C6")]
	[Cpp2IlInjected.Address(RVA = "0x108F7AC", Offset = "0x108F7AC", VA = "0x108F7AC")]
	public void SetItembyIndex(Item item, int itemSlotContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041C7")]
	[Cpp2IlInjected.Address(RVA = "0x108F17C", Offset = "0x108F17C", VA = "0x108F17C")]
	private void DrawToggleButton(SpriteBatch spritebatch, Vector2 location)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041C8")]
	[Cpp2IlInjected.Address(RVA = "0x108FA58", Offset = "0x108FA58", VA = "0x108FA58")]
	public void SwapItem(ref Item item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041C9")]
	[Cpp2IlInjected.Address(RVA = "0x108FAEC", Offset = "0x108FAEC", VA = "0x108FAEC")]
	public void CloseMenu()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041CA")]
	[Cpp2IlInjected.Address(RVA = "0x108F7FC", Offset = "0x108F7FC", VA = "0x108F7FC")]
	public void ToggleMenu()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041CB")]
	[Cpp2IlInjected.Address(RVA = "0x108FCFC", Offset = "0x108FCFC", VA = "0x108FCFC")]
	public bool IsShowingResearchMenu()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60041CC")]
	[Cpp2IlInjected.Address(RVA = "0x108FD20", Offset = "0x108FD20", VA = "0x108FD20")]
	public void SacrificeItemInSacrificeSlot()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041CD")]
	[Cpp2IlInjected.Address(RVA = "0x108FC48", Offset = "0x108FC48", VA = "0x108FC48")]
	public void StopPlayingSacrificeAnimations()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041CE")]
	[Cpp2IlInjected.Address(RVA = "0x108FD34", Offset = "0x108FD34", VA = "0x108FD34")]
	public bool ShouldDrawSacrificeArea()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60041CF")]
	[Cpp2IlInjected.Address(RVA = "0x108FE88", Offset = "0x108FE88", VA = "0x108FE88")]
	public bool GetSacrificeNumbers(out int itemIdChecked, out int amountWeHave, out int amountNeededTotal)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60041D0")]
	[Cpp2IlInjected.Address(RVA = "0x108FF60", Offset = "0x108FF60", VA = "0x108FF60")]
	public ItemSacrificeResult SacrificeItem(out int amountWeSacrificed)
	{
		return default(ItemSacrificeResult);
	}

	[Cpp2IlInjected.Token(Token = "0x60041D1")]
	[Cpp2IlInjected.Address(RVA = "0x108FC5C", Offset = "0x108FC5C", VA = "0x108FC5C")]
	private void RefreshAvailableInfiniteItemsList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60041D2")]
	[Cpp2IlInjected.Address(RVA = "0x1090380", Offset = "0x1090380", VA = "0x1090380")]
	public void Reset()
	{
	}
}
