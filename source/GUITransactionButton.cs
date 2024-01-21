using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class GUITransactionButton
{
	[Cpp2IlInjected.Token(Token = "0x20007B0")]
	public delegate void DrawItemHandler(Vector2 position, float itemScale);

	[Cpp2IlInjected.Token(Token = "0x20007B1")]
	public enum InputState
	{
		[Cpp2IlInjected.Token(Token = "0x40079C2")]
		Clicked,
		[Cpp2IlInjected.Token(Token = "0x40079C3")]
		Over,
		[Cpp2IlInjected.Token(Token = "0x40079C4")]
		Down,
		[Cpp2IlInjected.Token(Token = "0x40079C5")]
		None
	}

	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	public static bool disableControllerInput;

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0xEC9A58", Offset = "0xEC9A58", VA = "0xEC9A58")]
	public static Rectangle GetRegion(TransactionButton_Layout layout)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0xEC9C18", Offset = "0xEC9C18", VA = "0xEC9C18")]
	public static Rectangle GetPickRegion(TransactionButton_Layout layout)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0xEC9EA4", Offset = "0xEC9EA4", VA = "0xEC9EA4")]
	private static void DrawBacking(TransactionButton_Layout layout, Texture2D backing, Texture2D additionalBacking, Color backingColour, Color additionalbackingColour, Texture2D border, Color borderColour, float scale, bool over)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0xECAC84", Offset = "0xECAC84", VA = "0xECAC84")]
	private static void DrawControlIcon(TransactionButton_Layout layout, Texture2D backing, Color iconColour, float scale, bool hasControllerFocus)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0xECAF68", Offset = "0xECAF68", VA = "0xECAF68")]
	public static InputState DrawWithBanner(TransactionButton_Layout layout, GUIControlsBanner.ActionSource source, ControllerActionButton action, DrawItemHandler itemHandler, Vector2 itemSize, string label, bool disabled, ref float scale, bool forcePressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false, bool drawWhenControllerConnected = false)
	{
		return default(InputState);
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0xECB3F0", Offset = "0xECB3F0", VA = "0xECB3F0")]
	public static InputState Draw(TransactionButton_Layout layout, DrawItemHandler itemHandler, Vector2 itemSize, string label, bool disabled, ref float scale, bool forcePressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false)
	{
		return default(InputState);
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0xEC9D30", Offset = "0xEC9D30", VA = "0xEC9D30")]
	public static Rectangle GetOverloadedPickingRegion(TransactionButton_Layout layout, float scale)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0xECC408", Offset = "0xECC408", VA = "0xECC408")]
	public static Rectangle LoadButtonRegion(TransactionButton_Layout layout, float scale)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0xECCB80", Offset = "0xECCB80", VA = "0xECCB80")]
	public static InputState DrawWithBanner(TransactionButton_Layout layout, GUIControlsBanner.ActionSource source, ControllerActionButton action, Item item, string label, bool disabled, ref float scale, bool forcedPressed = false, bool hasControllerFocus = true, bool forceOver = false, bool disablePressedState = false, bool drawWhenControllerConnected = false, bool addTouchBanner = false)
	{
		return default(InputState);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0xEC5978", Offset = "0xEC5978", VA = "0xEC5978")]
	public static InputState Draw(TransactionButton_Layout layout, Item item, string label, bool disabled, ref float scale, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false)
	{
		return default(InputState);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0xECCD80", Offset = "0xECCD80", VA = "0xECCD80")]
	private static void DrawItem(TransactionButton_Layout layout, Texture2D backing, Texture2D itemTexture, Color itemColour, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0xECB114", Offset = "0xECB114", VA = "0xECB114")]
	private static InputState HandleControllerAction(TransactionButton_Layout layout, ControllerActionButton action, string label, bool disabled, bool disablePressedState, bool hasControllerFocus)
	{
		return default(InputState);
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0xECCFCC", Offset = "0xECCFCC", VA = "0xECCFCC")]
	public static InputState DrawWithBanner(TransactionButton_Layout layout, GUIControlsBanner.ActionSource source, ControllerActionButton action, Texture2D itemTexture, string label, bool disabled, ref float scale, Color? overloadedItemColour, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false, bool drawWhenControllerConnected = false)
	{
		return default(InputState);
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0xECD404", Offset = "0xECD404", VA = "0xECD404")]
	public static InputState Draw(TransactionButton_Layout layout, Texture2D itemTexture, string label, bool disabled, ref float scale, Color? overloadedItemColour, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false)
	{
		return default(InputState);
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0xECD5A0", Offset = "0xECD5A0", VA = "0xECD5A0")]
	public static InputState DrawWithBanner(TransactionButton_Layout layout, GUIControlsBanner.ActionSource source, ControllerActionButton action, Texture2D itemTexture, Rectangle srcRect, string label, bool disabled, ref float scale, Color? overloadedItemColour, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false, bool drawWhenControllerConnected = false)
	{
		return default(InputState);
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0xECD6CC", Offset = "0xECD6CC", VA = "0xECD6CC")]
	public static InputState DrawWithBanner(TransactionButton_Layout layout, GUIControlsBanner.ActionSource source, ControllerActionButton action, Texture2D itemTexture, Rectangle srcRect, Texture2D itemTextureHighlight, Rectangle srcRectHighlight, string label, bool disabled, ref float scale, Color? overloadedItemColour, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false, bool drawWhenControllerConnected = false)
	{
		return default(InputState);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0xECC8CC", Offset = "0xECC8CC", VA = "0xECC8CC")]
	private static void DrawLabel(TransactionButton_Layout layout, string label, Color labelColour, bool over)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0xECD2D4", Offset = "0xECD2D4", VA = "0xECD2D4")]
	public static InputState Draw(TransactionButton_Layout layout, Texture2D itemTexture, Rectangle srcRect, string label, bool disabled, ref float scale, Color? overloadedItemColour, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false)
	{
		return default(InputState);
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0xECD924", Offset = "0xECD924", VA = "0xECD924")]
	public static InputState Draw(TransactionButton_Layout layout, Texture2D itemTexture, Rectangle srcRect, Texture2D itemTextureHighlight, Rectangle srcRectHighlight, string label, bool disabled, ref float scale, Color? overloadedItemColour, bool forcedPressed = false, bool hasControllerFocus = false, bool forceOver = false, bool disablePressedState = false)
	{
		return default(InputState);
	}
}
