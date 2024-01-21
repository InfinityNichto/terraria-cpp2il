using System.IO;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Drawing;

[Cpp2IlInjected.Token(Token = "0x200066B")]
public struct ParticleOrchestraSettings
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006D45")]
	public Vector2 PositionInWorld;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006D46")]
	public Vector2 MovementVector;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006D47")]
	public int UniqueInfoPiece;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006D48")]
	public byte IndexOfPlayerWhoInvokedThis;

	[Cpp2IlInjected.Token(Token = "0x4006D49")]
	public const int SerializationSize = 21;

	[Cpp2IlInjected.Token(Token = "0x600408B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF718", Offset = "0x2AF718", VA = "0x2AF718")]
	public void Serialize(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600408C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF720", Offset = "0x2AF720", VA = "0x2AF720")]
	public void DeserializeFrom(BinaryReader reader)
	{
	}
}
