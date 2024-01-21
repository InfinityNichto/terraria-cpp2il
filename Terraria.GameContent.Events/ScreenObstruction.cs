using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Events;

[Cpp2IlInjected.Token(Token = "0x2000699")]
public class ScreenObstruction
{
	[Cpp2IlInjected.Token(Token = "0x4006E12")]
	public static float screenObstruction;

	[Cpp2IlInjected.Token(Token = "0x600427E")]
	[Cpp2IlInjected.Address(RVA = "0xF64528", Offset = "0xF64528", VA = "0xF64528")]
	public static void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600427F")]
	[Cpp2IlInjected.Address(RVA = "0xF6460C", Offset = "0xF6460C", VA = "0xF6460C")]
	public static void Draw(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004280")]
	[Cpp2IlInjected.Address(RVA = "0xF64F20", Offset = "0xF64F20", VA = "0xF64F20")]
	public ScreenObstruction()
	{
	}
}
