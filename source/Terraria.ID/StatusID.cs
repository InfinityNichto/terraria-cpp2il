using Cpp2IlInjected;
using ReLogic.Reflection;

namespace Terraria.ID;

[Cpp2IlInjected.Token(Token = "0x2000407")]
public class StatusID
{
	[Cpp2IlInjected.Token(Token = "0x4005C61")]
	public const int Ok = 0;

	[Cpp2IlInjected.Token(Token = "0x4005C62")]
	public const int LaterVersion = 1;

	[Cpp2IlInjected.Token(Token = "0x4005C63")]
	public const int UnknownError = 2;

	[Cpp2IlInjected.Token(Token = "0x4005C64")]
	public const int EmptyFile = 3;

	[Cpp2IlInjected.Token(Token = "0x4005C65")]
	public const int DecryptionError = 4;

	[Cpp2IlInjected.Token(Token = "0x4005C66")]
	public const int BadSectionPointer = 5;

	[Cpp2IlInjected.Token(Token = "0x4005C67")]
	public const int BadFooter = 6;

	[Cpp2IlInjected.Token(Token = "0x4005C68")]
	public static readonly IdDictionary Search;

	[Cpp2IlInjected.Token(Token = "0x60030C6")]
	[Cpp2IlInjected.Address(RVA = "0x147888C", Offset = "0x147888C", VA = "0x147888C")]
	public StatusID()
	{
	}
}
