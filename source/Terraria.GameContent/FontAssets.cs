using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x200054C")]
public static class FontAssets
{
	[Cpp2IlInjected.Token(Token = "0x40068DD")]
	public static Asset<SpriteFont> ItemStack;

	[Cpp2IlInjected.Token(Token = "0x40068DE")]
	public static Asset<SpriteFont> MouseText;

	[Cpp2IlInjected.Token(Token = "0x40068DF")]
	public static Asset<SpriteFont> DeathText;

	[Cpp2IlInjected.Token(Token = "0x40068E0")]
	public static Asset<SpriteFont>[] CombatText;
}
