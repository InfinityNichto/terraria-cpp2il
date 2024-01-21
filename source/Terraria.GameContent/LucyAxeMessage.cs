using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.UI;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x200055F")]
public static class LucyAxeMessage
{
	[Cpp2IlInjected.Token(Token = "0x2000987")]
	public enum MessageSource
	{
		[Cpp2IlInjected.Token(Token = "0x4008C2E")]
		Idle,
		[Cpp2IlInjected.Token(Token = "0x4008C2F")]
		Storage,
		[Cpp2IlInjected.Token(Token = "0x4008C30")]
		ThrownAway,
		[Cpp2IlInjected.Token(Token = "0x4008C31")]
		PickedUp,
		[Cpp2IlInjected.Token(Token = "0x4008C32")]
		ChoppedTree,
		[Cpp2IlInjected.Token(Token = "0x4008C33")]
		ChoppedGemTree,
		[Cpp2IlInjected.Token(Token = "0x4008C34")]
		ChoppedCactus,
		[Cpp2IlInjected.Token(Token = "0x4008C35")]
		Count
	}

	[Cpp2IlInjected.Token(Token = "0x4006926")]
	private static byte _variation;

	[Cpp2IlInjected.Token(Token = "0x4006927")]
	private static int[] _messageCooldownsByType;

	[Cpp2IlInjected.Token(Token = "0x6003A41")]
	[Cpp2IlInjected.Address(RVA = "0x1058480", Offset = "0x1058480", VA = "0x1058480")]
	private static string GetCategoryName(MessageSource source)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003A42")]
	[Cpp2IlInjected.Address(RVA = "0x10584F4", Offset = "0x10584F4", VA = "0x10584F4")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A43")]
	[Cpp2IlInjected.Address(RVA = "0x10585F4", Offset = "0x10585F4", VA = "0x10585F4")]
	private static void Hooks_OnEnterWorld(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A44")]
	[Cpp2IlInjected.Address(RVA = "0x1058768", Offset = "0x1058768", VA = "0x1058768")]
	public static void UpdateMessageCooldowns()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A45")]
	[Cpp2IlInjected.Address(RVA = "0x1058870", Offset = "0x1058870", VA = "0x1058870")]
	public static void TryPlayingIdleMessage()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A46")]
	[Cpp2IlInjected.Address(RVA = "0x1058C38", Offset = "0x1058C38", VA = "0x1058C38")]
	private static void ItemSlot_OnItemTransferred(ItemSlot.ItemTransferInfo info)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A47")]
	[Cpp2IlInjected.Address(RVA = "0x10586A4", Offset = "0x10586A4", VA = "0x10586A4")]
	private static void GiveIdleMessageCooldown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A48")]
	[Cpp2IlInjected.Address(RVA = "0x1058E34", Offset = "0x1058E34", VA = "0x1058E34")]
	public static void PutMessageTypeOnCooldown(MessageSource source, int timeInFrames)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A49")]
	[Cpp2IlInjected.Address(RVA = "0x1058E10", Offset = "0x1058E10", VA = "0x1058E10")]
	private static bool CountsAsStorage(int itemSlotContext)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003A4A")]
	[Cpp2IlInjected.Address(RVA = "0x1058EBC", Offset = "0x1058EBC", VA = "0x1058EBC")]
	public static void TryCreatingMessageWithCooldown(MessageSource messageSource, Vector2 position, Vector2 velocity, int cooldownTimeInTicks)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A4B")]
	[Cpp2IlInjected.Address(RVA = "0x1058A14", Offset = "0x1058A14", VA = "0x1058A14")]
	public static void Create(MessageSource source, Vector2 position, Vector2 velocity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A4C")]
	[Cpp2IlInjected.Address(RVA = "0x10591C4", Offset = "0x10591C4", VA = "0x10591C4")]
	private static void SpawnEmoteBubble()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A4D")]
	[Cpp2IlInjected.Address(RVA = "0x105923C", Offset = "0x105923C", VA = "0x105923C")]
	public static void CreateFromNet(MessageSource source, byte variation, Vector2 position, Vector2 velocity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A4E")]
	[Cpp2IlInjected.Address(RVA = "0x1059134", Offset = "0x1059134", VA = "0x1059134")]
	private static void PlaySound(MessageSource source, Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A4F")]
	[Cpp2IlInjected.Address(RVA = "0x1058FE4", Offset = "0x1058FE4", VA = "0x1058FE4")]
	private static void SpawnPopupText(MessageSource source, int variationUnwrapped, Vector2 position, Vector2 velocity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A50")]
	[Cpp2IlInjected.Address(RVA = "0x10592F0", Offset = "0x10592F0", VA = "0x10592F0")]
	private static string GetTextForVariation(MessageSource source, int variationUnwrapped)
	{
		return null;
	}
}
