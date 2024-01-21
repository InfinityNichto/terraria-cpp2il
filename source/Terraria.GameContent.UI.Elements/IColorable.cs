using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006DB")]
public interface IColorable
{
	[Cpp2IlInjected.Token(Token = "0x170007C7")]
	Color Color
	{
		[Cpp2IlInjected.Token(Token = "0x60044E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60044E2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
