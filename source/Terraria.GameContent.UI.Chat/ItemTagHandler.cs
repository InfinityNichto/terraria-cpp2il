using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20006F6")]
public class ItemTagHandler : ITagHandler
{
	[Cpp2IlInjected.Token(Token = "0x2000ABF")]
	private class ItemSnippet : TextSnippet
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008F4A")]
		private Item _item;

		[Cpp2IlInjected.Token(Token = "0x60052CF")]
		[Cpp2IlInjected.Address(RVA = "0x118487C", Offset = "0x118487C", VA = "0x118487C")]
		public ItemSnippet(Item item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60052D0")]
		[Cpp2IlInjected.Address(RVA = "0x1184BC4", Offset = "0x1184BC4", VA = "0x1184BC4", Slot = "5")]
		public override void OnHover()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60052D1")]
		[Cpp2IlInjected.Address(RVA = "0x1184CA4", Offset = "0x1184CA4", VA = "0x1184CA4", Slot = "8")]
		public override bool UniqueDraw(bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60052D2")]
		[Cpp2IlInjected.Address(RVA = "0x118510C", Offset = "0x118510C", VA = "0x118510C", Slot = "10")]
		public override float GetStringLength(SpriteFont font)
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40070F7")]
	private static Item displayItem;

	[Cpp2IlInjected.Token(Token = "0x60045AE")]
	[Cpp2IlInjected.Address(RVA = "0x1183BD4", Offset = "0x1183BD4", VA = "0x1183BD4")]
	public static bool PrintInline(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60045AF")]
	[Cpp2IlInjected.Address(RVA = "0x1184268", Offset = "0x1184268", VA = "0x1184268")]
	public static bool MeasureInline(ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60045B0")]
	[Cpp2IlInjected.Address(RVA = "0x11844DC", Offset = "0x11844DC", VA = "0x11844DC", Slot = "4")]
	TextSnippet ITagHandler.Parse(string text, Color baseColor, string options)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60045B1")]
	[Cpp2IlInjected.Address(RVA = "0x1184924", Offset = "0x1184924", VA = "0x1184924")]
	public static string GenerateTag(Item I)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60045B2")]
	[Cpp2IlInjected.Address(RVA = "0x1184B44", Offset = "0x1184B44", VA = "0x1184B44")]
	public ItemTagHandler()
	{
	}
}
