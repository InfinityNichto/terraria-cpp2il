using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Light
{
	[global::Cpp2ILInjected.Token(Token = "0x2000775")]
	public interface ILightingEngine
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003E8A")]
		void Rebuild();

		[global::Cpp2ILInjected.Token(Token = "0x6003E8B")]
		void AddLight(int x, int y, Vector3 color);

		[global::Cpp2ILInjected.Token(Token = "0x6003E8C")]
		void ProcessArea(Rectangle area);

		[global::Cpp2ILInjected.Token(Token = "0x6003E8D")]
		Vector3 GetColor(int x, int y);

		[global::Cpp2ILInjected.Token(Token = "0x6003E8E")]
		void Clear();

		[global::Cpp2ILInjected.Token(Token = "0x6003E8F")]
		LightMap GetLightMap(out Rectangle lightMapRegion);

		[global::Cpp2ILInjected.Token(Token = "0x6003E90")]
		Rectangle GetScanRegion();
	}
}
