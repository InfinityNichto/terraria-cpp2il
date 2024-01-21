using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using ReLogic.Content;

namespace Terraria.GameContent.UI.Minimap;

[Cpp2IlInjected.Token(Token = "0x20006B6")]
public class MinimapFrameTemplate
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006F80")]
	private string name;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006F81")]
	private Vector2 frameOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006F82")]
	private Vector2 resetPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006F83")]
	private Vector2 zoomInPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006F84")]
	private Vector2 zoomOutPosition;

	[Cpp2IlInjected.Token(Token = "0x60043D3")]
	[Cpp2IlInjected.Address(RVA = "0x109D8E8", Offset = "0x109D8E8", VA = "0x109D8E8")]
	public MinimapFrameTemplate(string name, Vector2 frameOffset, Vector2 resetPosition, Vector2 zoomInPosition, Vector2 zoomOutPosition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043D4")]
	[Cpp2IlInjected.Address(RVA = "0x109D938", Offset = "0x109D938", VA = "0x109D938")]
	public MinimapFrame CreateInstance(AssetRequestMode mode)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60043D5")]
	[Cpp2IlInjected.Address(RVA = "0x166B524", Offset = "0x166B524", VA = "0x166B524")]
	private static Asset<T> LoadAsset<T>(string assetName, AssetRequestMode mode) where T : class
	{
		return null;
	}
}
