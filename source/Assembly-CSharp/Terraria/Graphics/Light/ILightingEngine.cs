using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Light
{
	// Token: 0x0200050E RID: 1294
	[global::Cpp2ILInjected.Token(Token = "0x2000775")]
	public interface ILightingEngine
	{
		// Token: 0x060037EC RID: 14316
		[global::Cpp2ILInjected.Token(Token = "0x6003E8A")]
		void Rebuild();

		// Token: 0x060037ED RID: 14317
		[global::Cpp2ILInjected.Token(Token = "0x6003E8B")]
		void AddLight(int x, int y, Vector3 color);

		// Token: 0x060037EE RID: 14318
		[global::Cpp2ILInjected.Token(Token = "0x6003E8C")]
		void ProcessArea(Rectangle area);

		// Token: 0x060037EF RID: 14319
		[global::Cpp2ILInjected.Token(Token = "0x6003E8D")]
		Vector3 GetColor(int x, int y);

		// Token: 0x060037F0 RID: 14320
		[global::Cpp2ILInjected.Token(Token = "0x6003E8E")]
		void Clear();

		// Token: 0x060037F1 RID: 14321
		[global::Cpp2ILInjected.Token(Token = "0x6003E8F")]
		LightMap GetLightMap(out Rectangle lightMapRegion);

		// Token: 0x060037F2 RID: 14322
		[global::Cpp2ILInjected.Token(Token = "0x6003E90")]
		Rectangle GetScanRegion();
	}
}
