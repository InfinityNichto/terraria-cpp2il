using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class ControlsAxisTagHandler : ITagHandler
{
	[Cpp2IlInjected.Token(Token = "0x200079F")]
	public class ControlsAxisSnippet : TextSnippet
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400795F")]
		private readonly GUIControllerInputButton.AxisControl _axisControl;

		[Cpp2IlInjected.Token(Token = "0x60048CF")]
		[Cpp2IlInjected.Address(RVA = "0x1210648", Offset = "0x1210648", VA = "0x1210648")]
		public ControlsAxisSnippet(GUIControllerInputButton.AxisControl axisControl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60048D0")]
		[Cpp2IlInjected.Address(RVA = "0x12102FC", Offset = "0x12102FC", VA = "0x12102FC")]
		public static bool Draw(GUIControllerInputButton.AxisControl axisControl, bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60048D1")]
		[Cpp2IlInjected.Address(RVA = "0x12106F4", Offset = "0x12106F4", VA = "0x12106F4", Slot = "8")]
		public override bool UniqueDraw(bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60048D2")]
		[Cpp2IlInjected.Address(RVA = "0x1210734", Offset = "0x1210734", VA = "0x1210734", Slot = "10")]
		public override float GetStringLength(SpriteFont font)
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x120FFD0", Offset = "0x120FFD0", VA = "0x120FFD0")]
	public static bool MeasureInline(ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x1210140", Offset = "0x1210140", VA = "0x1210140")]
	public static bool PrintInline(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x121052C", Offset = "0x121052C", VA = "0x121052C", Slot = "4")]
	public TextSnippet Parse(string text, [Optional] Color baseColor, [Optional] string options)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x12106EC", Offset = "0x12106EC", VA = "0x12106EC")]
	public ControlsAxisTagHandler()
	{
	}
}
