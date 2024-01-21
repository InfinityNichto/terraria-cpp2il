using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004C1")]
public class ChestUI
{
	[Cpp2IlInjected.Token(Token = "0x200094A")]
	public class ButtonID
	{
		[Cpp2IlInjected.Token(Token = "0x4008B25")]
		public const int LootAll = 0;

		[Cpp2IlInjected.Token(Token = "0x4008B26")]
		public const int DepositAll = 1;

		[Cpp2IlInjected.Token(Token = "0x4008B27")]
		public const int QuickStack = 2;

		[Cpp2IlInjected.Token(Token = "0x4008B28")]
		public const int Restock = 3;

		[Cpp2IlInjected.Token(Token = "0x4008B29")]
		public const int Sort = 4;

		[Cpp2IlInjected.Token(Token = "0x4008B2A")]
		public const int RenameChest = 5;

		[Cpp2IlInjected.Token(Token = "0x4008B2B")]
		public const int RenameChestCancel = 6;

		[Cpp2IlInjected.Token(Token = "0x4008B2C")]
		public const int ToggleVacuum = 7;

		[Cpp2IlInjected.Token(Token = "0x4008B2D")]
		public static readonly int Count;

		[Cpp2IlInjected.Token(Token = "0x6004D2D")]
		[Cpp2IlInjected.Address(RVA = "0x13A42E0", Offset = "0x13A42E0", VA = "0x13A42E0")]
		public ButtonID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006688")]
	public const float buttonScaleMinimum = 0.75f;

	[Cpp2IlInjected.Token(Token = "0x4006689")]
	public const float buttonScaleMaximum = 1f;

	[Cpp2IlInjected.Token(Token = "0x400668A")]
	public static float[] ButtonScale;

	[Cpp2IlInjected.Token(Token = "0x400668B")]
	public static bool[] ButtonHovered;

	[Cpp2IlInjected.Token(Token = "0x60035B2")]
	[Cpp2IlInjected.Address(RVA = "0x14BA198", Offset = "0x14BA198", VA = "0x14BA198")]
	public static void UpdateHover(int ID, bool hovering)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035B3")]
	[Cpp2IlInjected.Address(RVA = "0x14BA3D4", Offset = "0x14BA3D4", VA = "0x14BA3D4")]
	public static void Draw(SpriteBatch spritebatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035B4")]
	[Cpp2IlInjected.Address(RVA = "0x14BA708", Offset = "0x14BA708", VA = "0x14BA708")]
	private static void DrawName(SpriteBatch spritebatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035B5")]
	[Cpp2IlInjected.Address(RVA = "0x14BB250", Offset = "0x14BB250", VA = "0x14BB250")]
	private static void DrawButtons(SpriteBatch spritebatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035B6")]
	[Cpp2IlInjected.Address(RVA = "0x14BB940", Offset = "0x14BB940", VA = "0x14BB940")]
	private static void DrawButton(SpriteBatch spriteBatch, int ID, int X, int Y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035B7")]
	[Cpp2IlInjected.Address(RVA = "0x14BFB70", Offset = "0x14BFB70", VA = "0x14BFB70")]
	private static void ToggleVacuum()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035B8")]
	[Cpp2IlInjected.Address(RVA = "0x14BB364", Offset = "0x14BB364", VA = "0x14BB364")]
	private static void DrawSlots(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035B9")]
	[Cpp2IlInjected.Address(RVA = "0x14BFC14", Offset = "0x14BFC14", VA = "0x14BFC14")]
	public static bool CanBeDepositied(int p)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60035BA")]
	[Cpp2IlInjected.Address(RVA = "0x14C00C4", Offset = "0x14C00C4", VA = "0x14C00C4")]
	public static void Deposit(int p)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035BB")]
	[Cpp2IlInjected.Address(RVA = "0x14C0DB4", Offset = "0x14C0DB4", VA = "0x14C0DB4")]
	public static void LootItem(int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035BC")]
	[Cpp2IlInjected.Address(RVA = "0x14BC640", Offset = "0x14BC640", VA = "0x14BC640")]
	public static void LootAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035BD")]
	[Cpp2IlInjected.Address(RVA = "0x14BCCA4", Offset = "0x14BCCA4", VA = "0x14BCCA4")]
	public static void DepositAll(ContainerTransferContext context)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035BE")]
	[Cpp2IlInjected.Address(RVA = "0x14BDC80", Offset = "0x14BDC80", VA = "0x14BDC80")]
	public static void QuickStack(ContainerTransferContext context, bool voidStack = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035BF")]
	[Cpp2IlInjected.Address(RVA = "0x14BEC04", Offset = "0x14BEC04", VA = "0x14BEC04")]
	public static void RenameChest()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035C0")]
	[Cpp2IlInjected.Address(RVA = "0x14C1F2C", Offset = "0x14C1F2C", VA = "0x14C1F2C")]
	public static void RenameChestSubmit(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035C1")]
	[Cpp2IlInjected.Address(RVA = "0x14BEFE0", Offset = "0x14BEFE0", VA = "0x14BEFE0")]
	public static void RenameChestCancel()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035C2")]
	[Cpp2IlInjected.Address(RVA = "0x14BF104", Offset = "0x14BF104", VA = "0x14BF104")]
	public static void Restock()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035C3")]
	[Cpp2IlInjected.Address(RVA = "0x14C1264", Offset = "0x14C1264", VA = "0x14C1264")]
	public static long MoveCoins(Item[] pInv, Item[] cInv, ContainerTransferContext context)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60035C4")]
	[Cpp2IlInjected.Address(RVA = "0x14C2114", Offset = "0x14C2114", VA = "0x14C2114")]
	public static bool TryPlacingInChest(Item I, bool justCheck, int itemSlotContext)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60035C5")]
	[Cpp2IlInjected.Address(RVA = "0x14C25F8", Offset = "0x14C25F8", VA = "0x14C25F8")]
	public static void GetContainerUsageInfo(out bool sync, out Item[] chestinv)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035C6")]
	[Cpp2IlInjected.Address(RVA = "0x14C2744", Offset = "0x14C2744", VA = "0x14C2744")]
	public static bool IsBlockedFromTransferIntoChest(Item item, Item[] container)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60035C7")]
	[Cpp2IlInjected.Address(RVA = "0x14C2860", Offset = "0x14C2860", VA = "0x14C2860")]
	public static bool TryPlacingInPlayer(int slot, bool justCheck)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60035C8")]
	[Cpp2IlInjected.Address(RVA = "0x14C2D24", Offset = "0x14C2D24", VA = "0x14C2D24")]
	public ChestUI()
	{
	}
}
