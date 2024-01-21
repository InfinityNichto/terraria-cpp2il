using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ReLogic.Graphics;

[Cpp2IlInjected.Token(Token = "0x200073B")]
public interface IDebugDrawer
{
	[Cpp2IlInjected.Token(Token = "0x6004741")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DrawSquare(Vector4 positionAndSize, Color color);

	[Cpp2IlInjected.Token(Token = "0x6004742")]
	[Cpp2IlInjected.Address(RVA = "0x815A28E7", VA = "0x815A28E7", Slot = "1")]
	void DrawSquareFromCenter(Vector2 center, Vector2 size, float rotation, Color color);
}
