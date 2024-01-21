using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Light;

[Cpp2IlInjected.Token(Token = "0x2000511")]
public interface ILightingEngine
{
	[Cpp2IlInjected.Token(Token = "0x6003828")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Rebuild();

	[Cpp2IlInjected.Token(Token = "0x6003829")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddLight(int x, int y, Vector3 color);

	[Cpp2IlInjected.Token(Token = "0x600382A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ProcessArea(Rectangle area);

	[Cpp2IlInjected.Token(Token = "0x600382B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Vector3 GetColor(int x, int y);

	[Cpp2IlInjected.Token(Token = "0x600382C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void Clear();

	[Cpp2IlInjected.Token(Token = "0x600382D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LightMap GetLightMap(out Rectangle lightMapRegion);

	[Cpp2IlInjected.Token(Token = "0x600382E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Rectangle GetScanRegion();
}
