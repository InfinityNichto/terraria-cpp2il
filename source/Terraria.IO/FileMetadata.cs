using System.IO;
using Cpp2IlInjected;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003C8")]
public class FileMetadata
{
	[Cpp2IlInjected.Token(Token = "0x400328D")]
	public const ulong MAGIC_NUMBER = 27981915666277746uL;

	[Cpp2IlInjected.Token(Token = "0x400328E")]
	public const int SIZE = 20;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400328F")]
	public FileType Type;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4003290")]
	public uint Revision;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4003291")]
	public bool IsFavorite;

	[Cpp2IlInjected.Token(Token = "0x6002F81")]
	[Cpp2IlInjected.Address(RVA = "0xE3D378", Offset = "0xE3D378", VA = "0xE3D378")]
	private FileMetadata()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F82")]
	[Cpp2IlInjected.Address(RVA = "0xE3D380", Offset = "0xE3D380", VA = "0xE3D380")]
	public void Write(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F83")]
	[Cpp2IlInjected.Address(RVA = "0xE3D47C", Offset = "0xE3D47C", VA = "0xE3D47C")]
	public void IncrementAndWrite(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F84")]
	[Cpp2IlInjected.Address(RVA = "0xE3D48C", Offset = "0xE3D48C", VA = "0xE3D48C")]
	public static FileMetadata FromCurrentSettings(FileType type)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F85")]
	[Cpp2IlInjected.Address(RVA = "0xE3D504", Offset = "0xE3D504", VA = "0xE3D504")]
	public static FileMetadata Read(BinaryReader reader, FileType expectedType)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F86")]
	[Cpp2IlInjected.Address(RVA = "0xE3D77C", Offset = "0xE3D77C", VA = "0xE3D77C")]
	private void Read(BinaryReader reader)
	{
	}
}
