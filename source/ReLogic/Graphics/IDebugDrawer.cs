using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ReLogic.Graphics
{
	// Token: 0x02000738 RID: 1848
	[global::Cpp2ILInjected.Token(Token = "0x2000B38")]
	public interface IDebugDrawer
	{
		// Token: 0x06004702 RID: 18178
		[global::Cpp2ILInjected.Token(Token = "0x60053BB")]
		void DrawSquare(Vector4 positionAndSize, Color color);

		// Token: 0x06004703 RID: 18179
		[global::Cpp2ILInjected.Token(Token = "0x60053BC")]
		void DrawSquareFromCenter(Vector2 center, Vector2 size, float rotation, Color color);
	}
}
