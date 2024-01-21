using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class ControlsKeyboardTagHandler : ITagHandler
{
	[Cpp2IlInjected.Token(Token = "0x20007A2")]
	public class ControlsKeyboardSnippet : TextSnippet
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4007974")]
		private readonly GUIControllerInputButton.LinkedControlType _control;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4007975")]
		private readonly string _binding;

		[Cpp2IlInjected.Token(Token = "0x60048D7")]
		[Cpp2IlInjected.Address(RVA = "0x20C2E58", Offset = "0x20C2E58", VA = "0x20C2E58")]
		public ControlsKeyboardSnippet(GUIControllerInputButton.LinkedControlType control)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60048D8")]
		[Cpp2IlInjected.Address(RVA = "0x20C1D98", Offset = "0x20C1D98", VA = "0x20C1D98")]
		public static bool Draw(string binding, bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, SpriteFont spriteFont, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60048D9")]
		[Cpp2IlInjected.Address(RVA = "0x20C2EEC", Offset = "0x20C2EEC", VA = "0x20C2EEC", Slot = "10")]
		public override float GetStringLength(SpriteFont font)
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20007A3")]
	public enum MappingType
	{
		[Cpp2IlInjected.Token(Token = "0x4007977")]
		MoveUp,
		[Cpp2IlInjected.Token(Token = "0x4007978")]
		MoveDown,
		[Cpp2IlInjected.Token(Token = "0x4007979")]
		MoveLeft,
		[Cpp2IlInjected.Token(Token = "0x400797A")]
		MoveRight,
		[Cpp2IlInjected.Token(Token = "0x400797B")]
		Aim,
		[Cpp2IlInjected.Token(Token = "0x400797C")]
		Fire,
		[Cpp2IlInjected.Token(Token = "0x400797D")]
		Jump,
		[Cpp2IlInjected.Token(Token = "0x400797E")]
		Interact,
		[Cpp2IlInjected.Token(Token = "0x400797F")]
		InventoryToggle,
		[Cpp2IlInjected.Token(Token = "0x4007980")]
		CycleLeftPage,
		[Cpp2IlInjected.Token(Token = "0x4007981")]
		CycleRightPage,
		[Cpp2IlInjected.Token(Token = "0x4007982")]
		CyclePreviousHotbarItem,
		[Cpp2IlInjected.Token(Token = "0x4007983")]
		CycleNextHotbarItem,
		[Cpp2IlInjected.Token(Token = "0x4007984")]
		SwitchToWorld,
		[Cpp2IlInjected.Token(Token = "0x4007985")]
		CraftItem,
		[Cpp2IlInjected.Token(Token = "0x4007986")]
		PickupItem,
		[Cpp2IlInjected.Token(Token = "0x4007987")]
		EquipItem,
		[Cpp2IlInjected.Token(Token = "0x4007988")]
		Settings,
		[Cpp2IlInjected.Token(Token = "0x4007989")]
		NavigateInventory,
		[Cpp2IlInjected.Token(Token = "0x400798A")]
		Teleport,
		[Cpp2IlInjected.Token(Token = "0x400798B")]
		ZoomIn,
		[Cpp2IlInjected.Token(Token = "0x400798C")]
		ZoomOut,
		[Cpp2IlInjected.Token(Token = "0x400798D")]
		NavigateHotbar,
		[Cpp2IlInjected.Token(Token = "0x400798E")]
		Count
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x20C1D1C", Offset = "0x20C1D1C", VA = "0x20C1D1C")]
	private static void DrawKeyboardBinding(SpriteBatch spriteBatch, SpriteFont spriteFont, Vector2 position, Color color, float scale, string bindingText, bool measure = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x20C1FA8", Offset = "0x20C1FA8", VA = "0x20C1FA8")]
	public static bool PrintInlineMapping(SpriteBatch spriteBatch, SpriteFont spriteFont, Vector2 position, Color color, float scale, ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x20C26F4", Offset = "0x20C26F4", VA = "0x20C26F4")]
	public static bool MeasureInlineMapping(SpriteFont spriteFont, ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 tagSize)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x20C2D3C", Offset = "0x20C2D3C", VA = "0x20C2D3C", Slot = "4")]
	public TextSnippet Parse(string text, [Optional] Color baseColor, [Optional] string options)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x20C2EE4", Offset = "0x20C2EE4", VA = "0x20C2EE4")]
	public ControlsKeyboardTagHandler()
	{
	}
}
