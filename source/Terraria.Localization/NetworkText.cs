using System.IO;
using Cpp2IlInjected;

namespace Terraria.Localization;

[Cpp2IlInjected.Token(Token = "0x20003BB")]
public class NetworkText
{
	[Cpp2IlInjected.Token(Token = "0x20008EA")]
	private enum Mode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4008142")]
		Literal,
		[Cpp2IlInjected.Token(Token = "0x4008143")]
		Formattable,
		[Cpp2IlInjected.Token(Token = "0x4008144")]
		LocalizationKey
	}

	[Cpp2IlInjected.Token(Token = "0x400327A")]
	public static readonly NetworkText Empty;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400327B")]
	private NetworkText[] _substitutions;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400327C")]
	private string _text;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400327D")]
	private Mode _mode;

	[Cpp2IlInjected.Token(Token = "0x6002F24")]
	[Cpp2IlInjected.Address(RVA = "0x47A60C", Offset = "0x47A60C", VA = "0x47A60C")]
	private NetworkText(string text, Mode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F25")]
	[Cpp2IlInjected.Address(RVA = "0x47A634", Offset = "0x47A634", VA = "0x47A634")]
	private static NetworkText[] ConvertSubstitutionsToNetworkText(object[] substitutions)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F26")]
	[Cpp2IlInjected.Address(RVA = "0x47A7E8", Offset = "0x47A7E8", VA = "0x47A7E8")]
	public static NetworkText FromFormattable(string text, params object[] substitutions)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F27")]
	[Cpp2IlInjected.Address(RVA = "0x47A774", Offset = "0x47A774", VA = "0x47A774")]
	public static NetworkText FromLiteral(string text)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F28")]
	[Cpp2IlInjected.Address(RVA = "0x47A2EC", Offset = "0x47A2EC", VA = "0x47A2EC")]
	public static NetworkText FromKey(string key, params object[] substitutions)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F29")]
	[Cpp2IlInjected.Address(RVA = "0x47A88C", Offset = "0x47A88C", VA = "0x47A88C")]
	public int GetMaxSerializedSize()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002F2A")]
	[Cpp2IlInjected.Address(RVA = "0x47A90C", Offset = "0x47A90C", VA = "0x47A90C")]
	public void Serialize(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F2B")]
	[Cpp2IlInjected.Address(RVA = "0x47A95C", Offset = "0x47A95C", VA = "0x47A95C")]
	private void SerializeSubstitutionList(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F2C")]
	[Cpp2IlInjected.Address(RVA = "0x47A9D0", Offset = "0x47A9D0", VA = "0x47A9D0")]
	public static NetworkText Deserialize(BinaryReader reader)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F2D")]
	[Cpp2IlInjected.Address(RVA = "0x47AB94", Offset = "0x47AB94", VA = "0x47AB94")]
	public static NetworkText DeserializeLiteral(BinaryReader reader)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F2E")]
	[Cpp2IlInjected.Address(RVA = "0x47AA7C", Offset = "0x47AA7C", VA = "0x47AA7C")]
	private void DeserializeSubstitutionList(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F2F")]
	[Cpp2IlInjected.Address(RVA = "0x47ACA4", Offset = "0x47ACA4", VA = "0x47ACA4")]
	private void SetToEmptyLiteral()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F30")]
	[Cpp2IlInjected.Address(RVA = "0x47AD10", Offset = "0x47AD10", VA = "0x47AD10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F31")]
	[Cpp2IlInjected.Address(RVA = "0x47AED8", Offset = "0x47AED8", VA = "0x47AED8")]
	private string ToDebugInfoString(string linePrefix = "")
	{
		return null;
	}
}
