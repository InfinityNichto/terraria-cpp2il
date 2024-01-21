using System.IO;
using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000421")]
public struct BinaryWriterHelper
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062A9")]
	private long _placeInWriter;

	[Cpp2IlInjected.Token(Token = "0x60030D7")]
	[Cpp2IlInjected.Address(RVA = "0x39AB78", Offset = "0x39AB78", VA = "0x39AB78")]
	public void ReservePointToFillLengthLaterByFilling6Bytes(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030D8")]
	[Cpp2IlInjected.Address(RVA = "0x39AB80", Offset = "0x39AB80", VA = "0x39AB80")]
	public void FillReservedPoint(BinaryWriter writer, ushort dataId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030D9")]
	[Cpp2IlInjected.Address(RVA = "0x39AB88", Offset = "0x39AB88", VA = "0x39AB88")]
	public void FillOnlyIfThereIsLengthOrRevertToSavedPosition(BinaryWriter writer, ushort dataId, out bool wroteSomething)
	{
	}
}
