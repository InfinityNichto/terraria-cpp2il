using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x200062D")]
public interface IBestiaryBackgroundOverlayAndColorProvider
{
	[Cpp2IlInjected.Token(Token = "0x1700076A")]
	float DisplayPriority
	{
		[Cpp2IlInjected.Token(Token = "0x6003EDB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6003ED9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Asset<Texture2D> GetBackgroundOverlayImage();

	[Cpp2IlInjected.Token(Token = "0x6003EDA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Color? GetBackgroundOverlayColor();
}
