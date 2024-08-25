using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ReLogic.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B38")]
	public interface IDebugDrawer
	{
		[global::Cpp2ILInjected.Token(Token = "0x60053BB")]
		void DrawSquare(Vector4 positionAndSize, Color color);

		[global::Cpp2ILInjected.Token(Token = "0x60053BC")]
		void DrawSquareFromCenter(Vector2 center, Vector2 size, float rotation, Color color);
	}
}
