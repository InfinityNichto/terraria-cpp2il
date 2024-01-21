using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class GUIQuickActionButton
{
	[Cpp2IlInjected.Token(Token = "0x20007AD")]
	public enum InteractionState
	{
		[Cpp2IlInjected.Token(Token = "0x40079B9")]
		Disabled,
		[Cpp2IlInjected.Token(Token = "0x40079BA")]
		Pressed,
		[Cpp2IlInjected.Token(Token = "0x40079BB")]
		Normal
	}

	[Cpp2IlInjected.Token(Token = "0x400038D")]
	public static bool ForceOverrideState;

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	public static InteractionState ForcedState;

	[Cpp2IlInjected.Token(Token = "0x400038F")]
	private static Texture2D _smallAxisOuter;

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private static Texture2D _axisInner;

	[Cpp2IlInjected.Token(Token = "0x4000391")]
	private static Texture2D _jump;

	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private static Texture2D _grappleAxis;

	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private static Texture2D _grappleFire;

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	public static Texture2D _unbound;

	[Cpp2IlInjected.Token(Token = "0x4000395")]
	public static Texture2D _zoomIn;

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public static Texture2D _zoomOut;

	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public static Texture2D _zoomDefault;

	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public static Texture2D _mapZoomIn;

	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public static Texture2D _mapZoomOut;

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static Texture2D _mapZoomDefault;

	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public static Texture2D _minimapZoomIn;

	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public static Texture2D _minimapZoomOut;

	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public static Texture2D _minimapZoomDefault;

	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public static Texture2D _smartCursorOn;

	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public static Texture2D _smartCursorOff;

	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public static Texture2D _autoFireOn;

	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public static Texture2D _autoFireOff;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	private static Texture2D _autoSelect;

	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	private static Texture2D _interact;

	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	private static Texture2D _fire;

	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	public static Texture2D _map;

	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	public static Texture2D _mapOpen;

	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	public static Texture2D _combatTargetLockOn;

	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	public static Texture2D _combatTargetIndicator;

	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	private static Texture2D _inventory;

	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	private static Texture2D _inventoryOpen;

	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	public static Texture2D _controlsProfile;

	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	private static Texture2D[] _uncollecedHeads;

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0xE35DF4", Offset = "0xE35DF4", VA = "0xE35DF4")]
	public static void LoadContent(ContentManager content)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0xE365C0", Offset = "0xE365C0", VA = "0xE365C0")]
	public static NPC GetMouseNPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0xE36E98", Offset = "0xE36E98", VA = "0xE36E98")]
	public static void DrawAtPosition(QuickActionButton_Layout layout, Vector2 position, Texture2D buttonTexture, InteractionState state, ref float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0xE374EC", Offset = "0xE374EC", VA = "0xE374EC")]
	public static void GetIconFrame(QuickActionButton_Layout.QuickActionControl actionType, out Texture2D iconTexture, out Rectangle frame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0xE38064", Offset = "0xE38064", VA = "0xE38064")]
	public static void Draw(QuickActionButton_Layout.QuickActionControl actionType, QuickActionButton_Layout layout, bool pressed, ref float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0xE3C4E0", Offset = "0xE3C4E0", VA = "0xE3C4E0")]
	public static void DrawFrame(QuickActionButton_Layout layout, Texture2D buttonTexture, Rectangle srcRect, InteractionState state, ref float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0xE3BCCC", Offset = "0xE3BCCC", VA = "0xE3BCCC")]
	public static void DrawFrame(QuickActionButton_Layout layout, Texture2D buttonTexture, Rectangle srcRect, InteractionState state, ref float scale, int itemType, Color itemColour)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0xE2C894", Offset = "0xE2C894", VA = "0xE2C894")]
	public static void Draw(QuickActionButton_Layout layout, Texture2D buttonTexture, InteractionState state, ref float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0xE3A188", Offset = "0xE3A188", VA = "0xE3A188")]
	private static bool CanInteract(Player player, Item item, ref Texture2D iconTexture, ref Rectangle frame, ref bool useFrame)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0xE3BC08", Offset = "0xE3BC08", VA = "0xE3BC08")]
	private static bool CanFire(Player player, Item selectedItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0xE3BC24", Offset = "0xE3BC24", VA = "0xE3BC24")]
	public static bool CanHeal(Player player, Item bestHealItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0xE3BC58", Offset = "0xE3BC58", VA = "0xE3BC58")]
	public static bool CanMana(Player player, Item bestManaItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0xE3A158", Offset = "0xE3A158", VA = "0xE3A158")]
	public static bool CanBuff(Player player)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0xE3BC9C", Offset = "0xE3BC9C", VA = "0xE3BC9C")]
	public static bool CanMount(Player player, Item quickMountItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0xE3C60C", Offset = "0xE3C60C", VA = "0xE3C60C")]
	public static bool IsMounted(Player player)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0xE3A148", Offset = "0xE3A148", VA = "0xE3A148")]
	private static bool CanGrappleSelect(Player player, Item grappleItem)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0xE3C62C", Offset = "0xE3C62C", VA = "0xE3C62C")]
	public static bool IsCursorOverExpanded(Vector2 position, QuickActionButton_Layout layout, ref float expanded)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0xE3C6DC", Offset = "0xE3C6DC", VA = "0xE3C6DC")]
	public static bool IsCursorOver(Vector2 position, QuickActionButton_Layout layout)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0xE3C788", Offset = "0xE3C788", VA = "0xE3C788")]
	public static bool IsCursorOverAtPosition(Vector2 position, QuickActionButton_Layout layout, Vector2 controlPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0xE3C840", Offset = "0xE3C840", VA = "0xE3C840")]
	public static bool RegisterPickingRegion(QuickActionButton_Layout layout)
	{
		return default(bool);
	}
}
