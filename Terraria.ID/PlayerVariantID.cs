using Cpp2IlInjected;

namespace Terraria.ID;

[Cpp2IlInjected.Token(Token = "0x20003FF")]
public static class PlayerVariantID
{
	[Cpp2IlInjected.Token(Token = "0x200091A")]
	public class Sets
	{
		[Cpp2IlInjected.Token(Token = "0x40089FA")]
		public static SetFactory Factory;

		[Cpp2IlInjected.Token(Token = "0x40089FB")]
		public static bool[] Male;

		[Cpp2IlInjected.Token(Token = "0x40089FC")]
		public static int[] AltGenderReference;

		[Cpp2IlInjected.Token(Token = "0x40089FD")]
		public static int[] VariantOrderMale;

		[Cpp2IlInjected.Token(Token = "0x40089FE")]
		public static int[] VariantOrderFemale;

		[Cpp2IlInjected.Token(Token = "0x6004CB5")]
		[Cpp2IlInjected.Address(RVA = "0x1468B28", Offset = "0x1468B28", VA = "0x1468B28")]
		public Sets()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40055D4")]
	public const int MaleStarter = 0;

	[Cpp2IlInjected.Token(Token = "0x40055D5")]
	public const int MaleSticker = 1;

	[Cpp2IlInjected.Token(Token = "0x40055D6")]
	public const int MaleGangster = 2;

	[Cpp2IlInjected.Token(Token = "0x40055D7")]
	public const int MaleCoat = 3;

	[Cpp2IlInjected.Token(Token = "0x40055D8")]
	public const int FemaleStarter = 4;

	[Cpp2IlInjected.Token(Token = "0x40055D9")]
	public const int FemaleSticker = 5;

	[Cpp2IlInjected.Token(Token = "0x40055DA")]
	public const int FemaleGangster = 6;

	[Cpp2IlInjected.Token(Token = "0x40055DB")]
	public const int FemaleCoat = 7;

	[Cpp2IlInjected.Token(Token = "0x40055DC")]
	public const int MaleDress = 8;

	[Cpp2IlInjected.Token(Token = "0x40055DD")]
	public const int FemaleDress = 9;

	[Cpp2IlInjected.Token(Token = "0x40055DE")]
	public const int MaleDisplayDoll = 10;

	[Cpp2IlInjected.Token(Token = "0x40055DF")]
	public const int FemaleDisplayDoll = 11;

	[Cpp2IlInjected.Token(Token = "0x40055E0")]
	public static readonly int Count;
}
