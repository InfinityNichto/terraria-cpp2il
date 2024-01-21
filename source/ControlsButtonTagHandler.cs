using System.Runtime.InteropServices;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class ControlsButtonTagHandler : ITagHandler
{
	[Cpp2IlInjected.Token(Token = "0x20007A0")]
	private class ControlsButtonSnippet : TextSnippet
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4007960")]
		private GUIControllerInputButton.LinkedControlType _control;

		[Cpp2IlInjected.Token(Token = "0x60048D3")]
		[Cpp2IlInjected.Address(RVA = "0x20C1C24", Offset = "0x20C1C24", VA = "0x20C1C24")]
		public ControlsButtonSnippet(GUIControllerInputButton.LinkedControlType control)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60048D4")]
		[Cpp2IlInjected.Address(RVA = "0x20C09E4", Offset = "0x20C09E4", VA = "0x20C09E4")]
		public static bool Draw(GUIControllerInputButton.LinkedControlType control, bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60048D5")]
		[Cpp2IlInjected.Address(RVA = "0x20C1CD0", Offset = "0x20C1CD0", VA = "0x20C1CD0", Slot = "8")]
		public override bool UniqueDraw(bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60048D6")]
		[Cpp2IlInjected.Address(RVA = "0x20C1D10", Offset = "0x20C1D10", VA = "0x20C1D10", Slot = "10")]
		public override float GetStringLength(SpriteFont font)
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20007A1")]
	public enum MappingType
	{
		[Cpp2IlInjected.Token(Token = "0x4007962")]
		Movement,
		[Cpp2IlInjected.Token(Token = "0x4007963")]
		Aim,
		[Cpp2IlInjected.Token(Token = "0x4007964")]
		Fire,
		[Cpp2IlInjected.Token(Token = "0x4007965")]
		Jump,
		[Cpp2IlInjected.Token(Token = "0x4007966")]
		Interact,
		[Cpp2IlInjected.Token(Token = "0x4007967")]
		OpenInventory,
		[Cpp2IlInjected.Token(Token = "0x4007968")]
		CloseInventory,
		[Cpp2IlInjected.Token(Token = "0x4007969")]
		CycleLeftPage,
		[Cpp2IlInjected.Token(Token = "0x400796A")]
		CycleRightPage,
		[Cpp2IlInjected.Token(Token = "0x400796B")]
		CyclePreviousHotbarItem,
		[Cpp2IlInjected.Token(Token = "0x400796C")]
		CycleNextHotbarItem,
		[Cpp2IlInjected.Token(Token = "0x400796D")]
		SwitchToWorld,
		[Cpp2IlInjected.Token(Token = "0x400796E")]
		CraftItem,
		[Cpp2IlInjected.Token(Token = "0x400796F")]
		PickupItem,
		[Cpp2IlInjected.Token(Token = "0x4007970")]
		EquipItem,
		[Cpp2IlInjected.Token(Token = "0x4007971")]
		Settings,
		[Cpp2IlInjected.Token(Token = "0x4007972")]
		NavigateInventory,
		[Cpp2IlInjected.Token(Token = "0x4007973")]
		Count
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x20C0618", Offset = "0x20C0618", VA = "0x20C0618")]
	public static bool MeasureInline(ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x20C0788", Offset = "0x20C0788", VA = "0x20C0788")]
	private static int DrawButtonControl(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ControllerActionButton action, bool mesaureOnly = false)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x20C0C14", Offset = "0x20C0C14", VA = "0x20C0C14")]
	private static int DrawAxisControl(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ControllerActionVector action, bool mesasure = false)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x20C0E34", Offset = "0x20C0E34", VA = "0x20C0E34")]
	public static bool PrintInlineMapping(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x20C1350", Offset = "0x20C1350", VA = "0x20C1350")]
	public static bool MeasureInlineMapping(ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x20C194C", Offset = "0x20C194C", VA = "0x20C194C")]
	public static bool PrintInline(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x20C1B08", Offset = "0x20C1B08", VA = "0x20C1B08", Slot = "4")]
	public TextSnippet Parse(string text, [Optional] Color baseColor, [Optional] string options)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x20C1CC8", Offset = "0x20C1CC8", VA = "0x20C1CC8")]
	public ControlsButtonTagHandler()
	{
	}
}
