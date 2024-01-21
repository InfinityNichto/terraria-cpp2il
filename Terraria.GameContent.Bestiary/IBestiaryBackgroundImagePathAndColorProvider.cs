using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x200062B")]
public interface IBestiaryBackgroundImagePathAndColorProvider
{
	[Cpp2IlInjected.Token(Token = "0x6003ED6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Asset<Texture2D> GetBackgroundImage();

	[Cpp2IlInjected.Token(Token = "0x6003ED7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Color? GetBackgroundColor();
}
