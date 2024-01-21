using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class ControlsTouchTagHandler : ITagHandler
{
	[Cpp2IlInjected.Token(Token = "0x20007A4")]
	private class ControlsTouchSnippet : TextSnippet
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400798F")]
		private int _controlType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4007990")]
		private int _itemId;

		[Cpp2IlInjected.Token(Token = "0x60048DA")]
		[Cpp2IlInjected.Address(RVA = "0x20C4F1C", Offset = "0x20C4F1C", VA = "0x20C4F1C")]
		public ControlsTouchSnippet(int controlType, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60048DB")]
		[Cpp2IlInjected.Address(RVA = "0x20C4038", Offset = "0x20C4038", VA = "0x20C4038")]
		public static bool Draw(int touchControl, int itemId, bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60048DC")]
		[Cpp2IlInjected.Address(RVA = "0x20C4FD0", Offset = "0x20C4FD0", VA = "0x20C4FD0", Slot = "8")]
		public override bool UniqueDraw(bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60048DD")]
		[Cpp2IlInjected.Address(RVA = "0x20C5020", Offset = "0x20C5020", VA = "0x20C5020", Slot = "10")]
		public override float GetStringLength(SpriteFont font)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60048DE")]
		[Cpp2IlInjected.Address(RVA = "0x20C502C", Offset = "0x20C502C", VA = "0x20C502C")]
		public static Vector2 GetSize(int touchControl)
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x20C3A10", Offset = "0x20C3A10", VA = "0x20C3A10")]
	public static bool MeasureInline(ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x20C3D20", Offset = "0x20C3D20", VA = "0x20C3D20")]
	public static bool PrintInline(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x20C4C54", Offset = "0x20C4C54", VA = "0x20C4C54", Slot = "4")]
	public TextSnippet Parse(string text, [Optional] Color baseColor, [Optional] string options)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x20C4FC8", Offset = "0x20C4FC8", VA = "0x20C4FC8")]
	public ControlsTouchTagHandler()
	{
	}
}
