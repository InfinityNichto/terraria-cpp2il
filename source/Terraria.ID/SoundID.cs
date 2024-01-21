using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.Audio;

namespace Terraria.ID;

[Cpp2IlInjected.Token(Token = "0x2000406")]
public class SoundID
{
	[Cpp2IlInjected.Token(Token = "0x200091D")]
	private struct SoundStyleDefaults
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008A2D")]
		public readonly float PitchVariance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008A2E")]
		public readonly float Volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008A2F")]
		public readonly SoundType Type;

		[Cpp2IlInjected.Token(Token = "0x6004CBA")]
		[Cpp2IlInjected.Address(RVA = "0x39F348", Offset = "0x39F348", VA = "0x39F348")]
		public SoundStyleDefaults(float volume, float pitchVariance, SoundType type = SoundType.Sound)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4005A7A")]
	private static readonly SoundStyleDefaults ItemDefaults;

	[Cpp2IlInjected.Token(Token = "0x4005A7B")]
	public const int Dig = 0;

	[Cpp2IlInjected.Token(Token = "0x4005A7C")]
	public const int PlayerHit = 1;

	[Cpp2IlInjected.Token(Token = "0x4005A7D")]
	public const int Item = 2;

	[Cpp2IlInjected.Token(Token = "0x4005A7E")]
	public const int NPCHit = 3;

	[Cpp2IlInjected.Token(Token = "0x4005A7F")]
	public const int NPCKilled = 4;

	[Cpp2IlInjected.Token(Token = "0x4005A80")]
	public const int PlayerKilled = 5;

	[Cpp2IlInjected.Token(Token = "0x4005A81")]
	public const int Grass = 6;

	[Cpp2IlInjected.Token(Token = "0x4005A82")]
	public const int Grab = 7;

	[Cpp2IlInjected.Token(Token = "0x4005A83")]
	public const int DoorOpen = 8;

	[Cpp2IlInjected.Token(Token = "0x4005A84")]
	public const int DoorClosed = 9;

	[Cpp2IlInjected.Token(Token = "0x4005A85")]
	public const int MenuOpen = 10;

	[Cpp2IlInjected.Token(Token = "0x4005A86")]
	public const int MenuClose = 11;

	[Cpp2IlInjected.Token(Token = "0x4005A87")]
	public const int MenuTick = 12;

	[Cpp2IlInjected.Token(Token = "0x4005A88")]
	public const int Shatter = 13;

	[Cpp2IlInjected.Token(Token = "0x4005A89")]
	public const int ZombieMoan = 14;

	[Cpp2IlInjected.Token(Token = "0x4005A8A")]
	public const int Roar = 15;

	[Cpp2IlInjected.Token(Token = "0x4005A8B")]
	public const int DoubleJump = 16;

	[Cpp2IlInjected.Token(Token = "0x4005A8C")]
	public const int Run = 17;

	[Cpp2IlInjected.Token(Token = "0x4005A8D")]
	public const int Coins = 18;

	[Cpp2IlInjected.Token(Token = "0x4005A8E")]
	public const int Splash = 19;

	[Cpp2IlInjected.Token(Token = "0x4005A8F")]
	public const int FemaleHit = 20;

	[Cpp2IlInjected.Token(Token = "0x4005A90")]
	public const int Tink = 21;

	[Cpp2IlInjected.Token(Token = "0x4005A91")]
	public const int Unlock = 22;

	[Cpp2IlInjected.Token(Token = "0x4005A92")]
	public const int Drown = 23;

	[Cpp2IlInjected.Token(Token = "0x4005A93")]
	public const int Chat = 24;

	[Cpp2IlInjected.Token(Token = "0x4005A94")]
	public const int MaxMana = 25;

	[Cpp2IlInjected.Token(Token = "0x4005A95")]
	public const int Mummy = 26;

	[Cpp2IlInjected.Token(Token = "0x4005A96")]
	public const int Pixie = 27;

	[Cpp2IlInjected.Token(Token = "0x4005A97")]
	public const int Mech = 28;

	[Cpp2IlInjected.Token(Token = "0x4005A98")]
	public const int Zombie = 29;

	[Cpp2IlInjected.Token(Token = "0x4005A99")]
	public const int Duck = 30;

	[Cpp2IlInjected.Token(Token = "0x4005A9A")]
	public const int Frog = 31;

	[Cpp2IlInjected.Token(Token = "0x4005A9B")]
	public const int Bird = 32;

	[Cpp2IlInjected.Token(Token = "0x4005A9C")]
	public const int Critter = 33;

	[Cpp2IlInjected.Token(Token = "0x4005A9D")]
	public const int Waterfall = 34;

	[Cpp2IlInjected.Token(Token = "0x4005A9E")]
	public const int Lavafall = 35;

	[Cpp2IlInjected.Token(Token = "0x4005A9F")]
	public const int ForceRoar = 36;

	[Cpp2IlInjected.Token(Token = "0x4005AA0")]
	public const int Meowmere = 37;

	[Cpp2IlInjected.Token(Token = "0x4005AA1")]
	public const int CoinPickup = 38;

	[Cpp2IlInjected.Token(Token = "0x4005AA2")]
	public const int Drip = 39;

	[Cpp2IlInjected.Token(Token = "0x4005AA3")]
	public const int Camera = 40;

	[Cpp2IlInjected.Token(Token = "0x4005AA4")]
	public const int MoonLord = 41;

	[Cpp2IlInjected.Token(Token = "0x4005AA5")]
	public const int Trackable = 42;

	[Cpp2IlInjected.Token(Token = "0x4005AA6")]
	public const int Thunder = 43;

	[Cpp2IlInjected.Token(Token = "0x4005AA7")]
	public const int Seagull = 44;

	[Cpp2IlInjected.Token(Token = "0x4005AA8")]
	public const int Dolphin = 45;

	[Cpp2IlInjected.Token(Token = "0x4005AA9")]
	public const int Owl = 46;

	[Cpp2IlInjected.Token(Token = "0x4005AAA")]
	public const int GuitarC = 47;

	[Cpp2IlInjected.Token(Token = "0x4005AAB")]
	public const int GuitarD = 48;

	[Cpp2IlInjected.Token(Token = "0x4005AAC")]
	public const int GuitarEm = 49;

	[Cpp2IlInjected.Token(Token = "0x4005AAD")]
	public const int GuitarG = 50;

	[Cpp2IlInjected.Token(Token = "0x4005AAE")]
	public const int GuitarBm = 51;

	[Cpp2IlInjected.Token(Token = "0x4005AAF")]
	public const int GuitarAm = 52;

	[Cpp2IlInjected.Token(Token = "0x4005AB0")]
	public const int DrumHiHat = 53;

	[Cpp2IlInjected.Token(Token = "0x4005AB1")]
	public const int DrumTomHigh = 54;

	[Cpp2IlInjected.Token(Token = "0x4005AB2")]
	public const int DrumTomLow = 55;

	[Cpp2IlInjected.Token(Token = "0x4005AB3")]
	public const int DrumTomMid = 56;

	[Cpp2IlInjected.Token(Token = "0x4005AB4")]
	public const int DrumClosedHiHat = 57;

	[Cpp2IlInjected.Token(Token = "0x4005AB5")]
	public const int DrumCymbal1 = 58;

	[Cpp2IlInjected.Token(Token = "0x4005AB6")]
	public const int DrumCymbal2 = 59;

	[Cpp2IlInjected.Token(Token = "0x4005AB7")]
	public const int DrumKick = 60;

	[Cpp2IlInjected.Token(Token = "0x4005AB8")]
	public const int DrumTamaSnare = 61;

	[Cpp2IlInjected.Token(Token = "0x4005AB9")]
	public const int DrumFloorTom = 62;

	[Cpp2IlInjected.Token(Token = "0x4005ABA")]
	public const int Research = 63;

	[Cpp2IlInjected.Token(Token = "0x4005ABB")]
	public const int ResearchComplete = 64;

	[Cpp2IlInjected.Token(Token = "0x4005ABC")]
	public const int QueenSlime = 65;

	[Cpp2IlInjected.Token(Token = "0x4005ABD")]
	public const int Clown = 66;

	[Cpp2IlInjected.Token(Token = "0x4005ABE")]
	public const int Cockatiel = 67;

	[Cpp2IlInjected.Token(Token = "0x4005ABF")]
	public const int Macaw = 68;

	[Cpp2IlInjected.Token(Token = "0x4005AC0")]
	public const int Toucan = 69;

	[Cpp2IlInjected.Token(Token = "0x4005AC1")]
	public static readonly LegacySoundStyle NPCHit1;

	[Cpp2IlInjected.Token(Token = "0x4005AC2")]
	public static readonly LegacySoundStyle NPCHit2;

	[Cpp2IlInjected.Token(Token = "0x4005AC3")]
	public static readonly LegacySoundStyle NPCHit3;

	[Cpp2IlInjected.Token(Token = "0x4005AC4")]
	public static readonly LegacySoundStyle NPCHit4;

	[Cpp2IlInjected.Token(Token = "0x4005AC5")]
	public static readonly LegacySoundStyle NPCHit5;

	[Cpp2IlInjected.Token(Token = "0x4005AC6")]
	public static readonly LegacySoundStyle NPCHit6;

	[Cpp2IlInjected.Token(Token = "0x4005AC7")]
	public static readonly LegacySoundStyle NPCHit7;

	[Cpp2IlInjected.Token(Token = "0x4005AC8")]
	public static readonly LegacySoundStyle NPCHit8;

	[Cpp2IlInjected.Token(Token = "0x4005AC9")]
	public static readonly LegacySoundStyle NPCHit9;

	[Cpp2IlInjected.Token(Token = "0x4005ACA")]
	public static readonly LegacySoundStyle NPCHit10;

	[Cpp2IlInjected.Token(Token = "0x4005ACB")]
	public static readonly LegacySoundStyle NPCHit11;

	[Cpp2IlInjected.Token(Token = "0x4005ACC")]
	public static readonly LegacySoundStyle NPCHit12;

	[Cpp2IlInjected.Token(Token = "0x4005ACD")]
	public static readonly LegacySoundStyle NPCHit13;

	[Cpp2IlInjected.Token(Token = "0x4005ACE")]
	public static readonly LegacySoundStyle NPCHit14;

	[Cpp2IlInjected.Token(Token = "0x4005ACF")]
	public static readonly LegacySoundStyle NPCHit15;

	[Cpp2IlInjected.Token(Token = "0x4005AD0")]
	public static readonly LegacySoundStyle NPCHit16;

	[Cpp2IlInjected.Token(Token = "0x4005AD1")]
	public static readonly LegacySoundStyle NPCHit17;

	[Cpp2IlInjected.Token(Token = "0x4005AD2")]
	public static readonly LegacySoundStyle NPCHit18;

	[Cpp2IlInjected.Token(Token = "0x4005AD3")]
	public static readonly LegacySoundStyle NPCHit19;

	[Cpp2IlInjected.Token(Token = "0x4005AD4")]
	public static readonly LegacySoundStyle NPCHit20;

	[Cpp2IlInjected.Token(Token = "0x4005AD5")]
	public static readonly LegacySoundStyle NPCHit21;

	[Cpp2IlInjected.Token(Token = "0x4005AD6")]
	public static readonly LegacySoundStyle NPCHit22;

	[Cpp2IlInjected.Token(Token = "0x4005AD7")]
	public static readonly LegacySoundStyle NPCHit23;

	[Cpp2IlInjected.Token(Token = "0x4005AD8")]
	public static readonly LegacySoundStyle NPCHit24;

	[Cpp2IlInjected.Token(Token = "0x4005AD9")]
	public static readonly LegacySoundStyle NPCHit25;

	[Cpp2IlInjected.Token(Token = "0x4005ADA")]
	public static readonly LegacySoundStyle NPCHit26;

	[Cpp2IlInjected.Token(Token = "0x4005ADB")]
	public static readonly LegacySoundStyle NPCHit27;

	[Cpp2IlInjected.Token(Token = "0x4005ADC")]
	public static readonly LegacySoundStyle NPCHit28;

	[Cpp2IlInjected.Token(Token = "0x4005ADD")]
	public static readonly LegacySoundStyle NPCHit29;

	[Cpp2IlInjected.Token(Token = "0x4005ADE")]
	public static readonly LegacySoundStyle NPCHit30;

	[Cpp2IlInjected.Token(Token = "0x4005ADF")]
	public static readonly LegacySoundStyle NPCHit31;

	[Cpp2IlInjected.Token(Token = "0x4005AE0")]
	public static readonly LegacySoundStyle NPCHit32;

	[Cpp2IlInjected.Token(Token = "0x4005AE1")]
	public static readonly LegacySoundStyle NPCHit33;

	[Cpp2IlInjected.Token(Token = "0x4005AE2")]
	public static readonly LegacySoundStyle NPCHit34;

	[Cpp2IlInjected.Token(Token = "0x4005AE3")]
	public static readonly LegacySoundStyle NPCHit35;

	[Cpp2IlInjected.Token(Token = "0x4005AE4")]
	public static readonly LegacySoundStyle NPCHit36;

	[Cpp2IlInjected.Token(Token = "0x4005AE5")]
	public static readonly LegacySoundStyle NPCHit37;

	[Cpp2IlInjected.Token(Token = "0x4005AE6")]
	public static readonly LegacySoundStyle NPCHit38;

	[Cpp2IlInjected.Token(Token = "0x4005AE7")]
	public static readonly LegacySoundStyle NPCHit39;

	[Cpp2IlInjected.Token(Token = "0x4005AE8")]
	public static readonly LegacySoundStyle NPCHit40;

	[Cpp2IlInjected.Token(Token = "0x4005AE9")]
	public static readonly LegacySoundStyle NPCHit41;

	[Cpp2IlInjected.Token(Token = "0x4005AEA")]
	public static readonly LegacySoundStyle NPCHit42;

	[Cpp2IlInjected.Token(Token = "0x4005AEB")]
	public static readonly LegacySoundStyle NPCHit43;

	[Cpp2IlInjected.Token(Token = "0x4005AEC")]
	public static readonly LegacySoundStyle NPCHit44;

	[Cpp2IlInjected.Token(Token = "0x4005AED")]
	public static readonly LegacySoundStyle NPCHit45;

	[Cpp2IlInjected.Token(Token = "0x4005AEE")]
	public static readonly LegacySoundStyle NPCHit46;

	[Cpp2IlInjected.Token(Token = "0x4005AEF")]
	public static readonly LegacySoundStyle NPCHit47;

	[Cpp2IlInjected.Token(Token = "0x4005AF0")]
	public static readonly LegacySoundStyle NPCHit48;

	[Cpp2IlInjected.Token(Token = "0x4005AF1")]
	public static readonly LegacySoundStyle NPCHit49;

	[Cpp2IlInjected.Token(Token = "0x4005AF2")]
	public static readonly LegacySoundStyle NPCHit50;

	[Cpp2IlInjected.Token(Token = "0x4005AF3")]
	public static readonly LegacySoundStyle NPCHit51;

	[Cpp2IlInjected.Token(Token = "0x4005AF4")]
	public static readonly LegacySoundStyle NPCHit52;

	[Cpp2IlInjected.Token(Token = "0x4005AF5")]
	public static readonly LegacySoundStyle NPCHit53;

	[Cpp2IlInjected.Token(Token = "0x4005AF6")]
	public static readonly LegacySoundStyle NPCHit54;

	[Cpp2IlInjected.Token(Token = "0x4005AF7")]
	public static readonly LegacySoundStyle NPCHit55;

	[Cpp2IlInjected.Token(Token = "0x4005AF8")]
	public static readonly LegacySoundStyle NPCHit56;

	[Cpp2IlInjected.Token(Token = "0x4005AF9")]
	public static readonly LegacySoundStyle NPCHit57;

	[Cpp2IlInjected.Token(Token = "0x4005AFA")]
	public static readonly LegacySoundStyle NPCDeath1;

	[Cpp2IlInjected.Token(Token = "0x4005AFB")]
	public static readonly LegacySoundStyle NPCDeath2;

	[Cpp2IlInjected.Token(Token = "0x4005AFC")]
	public static readonly LegacySoundStyle NPCDeath3;

	[Cpp2IlInjected.Token(Token = "0x4005AFD")]
	public static readonly LegacySoundStyle NPCDeath4;

	[Cpp2IlInjected.Token(Token = "0x4005AFE")]
	public static readonly LegacySoundStyle NPCDeath5;

	[Cpp2IlInjected.Token(Token = "0x4005AFF")]
	public static readonly LegacySoundStyle NPCDeath6;

	[Cpp2IlInjected.Token(Token = "0x4005B00")]
	public static readonly LegacySoundStyle NPCDeath7;

	[Cpp2IlInjected.Token(Token = "0x4005B01")]
	public static readonly LegacySoundStyle NPCDeath8;

	[Cpp2IlInjected.Token(Token = "0x4005B02")]
	public static readonly LegacySoundStyle NPCDeath9;

	[Cpp2IlInjected.Token(Token = "0x4005B03")]
	public static readonly LegacySoundStyle NPCDeath10;

	[Cpp2IlInjected.Token(Token = "0x4005B04")]
	public static readonly LegacySoundStyle NPCDeath11;

	[Cpp2IlInjected.Token(Token = "0x4005B05")]
	public static readonly LegacySoundStyle NPCDeath12;

	[Cpp2IlInjected.Token(Token = "0x4005B06")]
	public static readonly LegacySoundStyle NPCDeath13;

	[Cpp2IlInjected.Token(Token = "0x4005B07")]
	public static readonly LegacySoundStyle NPCDeath14;

	[Cpp2IlInjected.Token(Token = "0x4005B08")]
	public static readonly LegacySoundStyle NPCDeath15;

	[Cpp2IlInjected.Token(Token = "0x4005B09")]
	public static readonly LegacySoundStyle NPCDeath16;

	[Cpp2IlInjected.Token(Token = "0x4005B0A")]
	public static readonly LegacySoundStyle NPCDeath17;

	[Cpp2IlInjected.Token(Token = "0x4005B0B")]
	public static readonly LegacySoundStyle NPCDeath18;

	[Cpp2IlInjected.Token(Token = "0x4005B0C")]
	public static readonly LegacySoundStyle NPCDeath19;

	[Cpp2IlInjected.Token(Token = "0x4005B0D")]
	public static readonly LegacySoundStyle NPCDeath20;

	[Cpp2IlInjected.Token(Token = "0x4005B0E")]
	public static readonly LegacySoundStyle NPCDeath21;

	[Cpp2IlInjected.Token(Token = "0x4005B0F")]
	public static readonly LegacySoundStyle NPCDeath22;

	[Cpp2IlInjected.Token(Token = "0x4005B10")]
	public static readonly LegacySoundStyle NPCDeath23;

	[Cpp2IlInjected.Token(Token = "0x4005B11")]
	public static readonly LegacySoundStyle NPCDeath24;

	[Cpp2IlInjected.Token(Token = "0x4005B12")]
	public static readonly LegacySoundStyle NPCDeath25;

	[Cpp2IlInjected.Token(Token = "0x4005B13")]
	public static readonly LegacySoundStyle NPCDeath26;

	[Cpp2IlInjected.Token(Token = "0x4005B14")]
	public static readonly LegacySoundStyle NPCDeath27;

	[Cpp2IlInjected.Token(Token = "0x4005B15")]
	public static readonly LegacySoundStyle NPCDeath28;

	[Cpp2IlInjected.Token(Token = "0x4005B16")]
	public static readonly LegacySoundStyle NPCDeath29;

	[Cpp2IlInjected.Token(Token = "0x4005B17")]
	public static readonly LegacySoundStyle NPCDeath30;

	[Cpp2IlInjected.Token(Token = "0x4005B18")]
	public static readonly LegacySoundStyle NPCDeath31;

	[Cpp2IlInjected.Token(Token = "0x4005B19")]
	public static readonly LegacySoundStyle NPCDeath32;

	[Cpp2IlInjected.Token(Token = "0x4005B1A")]
	public static readonly LegacySoundStyle NPCDeath33;

	[Cpp2IlInjected.Token(Token = "0x4005B1B")]
	public static readonly LegacySoundStyle NPCDeath34;

	[Cpp2IlInjected.Token(Token = "0x4005B1C")]
	public static readonly LegacySoundStyle NPCDeath35;

	[Cpp2IlInjected.Token(Token = "0x4005B1D")]
	public static readonly LegacySoundStyle NPCDeath36;

	[Cpp2IlInjected.Token(Token = "0x4005B1E")]
	public static readonly LegacySoundStyle NPCDeath37;

	[Cpp2IlInjected.Token(Token = "0x4005B1F")]
	public static readonly LegacySoundStyle NPCDeath38;

	[Cpp2IlInjected.Token(Token = "0x4005B20")]
	public static readonly LegacySoundStyle NPCDeath39;

	[Cpp2IlInjected.Token(Token = "0x4005B21")]
	public static readonly LegacySoundStyle NPCDeath40;

	[Cpp2IlInjected.Token(Token = "0x4005B22")]
	public static readonly LegacySoundStyle NPCDeath41;

	[Cpp2IlInjected.Token(Token = "0x4005B23")]
	public static readonly LegacySoundStyle NPCDeath42;

	[Cpp2IlInjected.Token(Token = "0x4005B24")]
	public static readonly LegacySoundStyle NPCDeath43;

	[Cpp2IlInjected.Token(Token = "0x4005B25")]
	public static readonly LegacySoundStyle NPCDeath44;

	[Cpp2IlInjected.Token(Token = "0x4005B26")]
	public static readonly LegacySoundStyle NPCDeath45;

	[Cpp2IlInjected.Token(Token = "0x4005B27")]
	public static readonly LegacySoundStyle NPCDeath46;

	[Cpp2IlInjected.Token(Token = "0x4005B28")]
	public static readonly LegacySoundStyle NPCDeath47;

	[Cpp2IlInjected.Token(Token = "0x4005B29")]
	public static readonly LegacySoundStyle NPCDeath48;

	[Cpp2IlInjected.Token(Token = "0x4005B2A")]
	public static readonly LegacySoundStyle NPCDeath49;

	[Cpp2IlInjected.Token(Token = "0x4005B2B")]
	public static readonly LegacySoundStyle NPCDeath50;

	[Cpp2IlInjected.Token(Token = "0x4005B2C")]
	public static readonly LegacySoundStyle NPCDeath51;

	[Cpp2IlInjected.Token(Token = "0x4005B2D")]
	public static readonly LegacySoundStyle NPCDeath52;

	[Cpp2IlInjected.Token(Token = "0x4005B2E")]
	public static readonly LegacySoundStyle NPCDeath53;

	[Cpp2IlInjected.Token(Token = "0x4005B2F")]
	public static readonly LegacySoundStyle NPCDeath54;

	[Cpp2IlInjected.Token(Token = "0x4005B30")]
	public static readonly LegacySoundStyle NPCDeath55;

	[Cpp2IlInjected.Token(Token = "0x4005B31")]
	public static readonly LegacySoundStyle NPCDeath56;

	[Cpp2IlInjected.Token(Token = "0x4005B32")]
	public static readonly LegacySoundStyle NPCDeath57;

	[Cpp2IlInjected.Token(Token = "0x4005B33")]
	public static readonly LegacySoundStyle NPCDeath58;

	[Cpp2IlInjected.Token(Token = "0x4005B34")]
	public static readonly LegacySoundStyle NPCDeath59;

	[Cpp2IlInjected.Token(Token = "0x4005B35")]
	public static readonly LegacySoundStyle NPCDeath60;

	[Cpp2IlInjected.Token(Token = "0x4005B36")]
	public static readonly LegacySoundStyle NPCDeath61;

	[Cpp2IlInjected.Token(Token = "0x4005B37")]
	public static readonly LegacySoundStyle NPCDeath62;

	[Cpp2IlInjected.Token(Token = "0x4005B38")]
	public static readonly LegacySoundStyle NPCDeath63;

	[Cpp2IlInjected.Token(Token = "0x4005B39")]
	public static readonly LegacySoundStyle NPCDeath64;

	[Cpp2IlInjected.Token(Token = "0x4005B3A")]
	public static readonly LegacySoundStyle NPCDeath65;

	[Cpp2IlInjected.Token(Token = "0x4005B3B")]
	public static readonly LegacySoundStyle NPCDeath66;

	[Cpp2IlInjected.Token(Token = "0x4005B3C")]
	public static short NPCDeathCount;

	[Cpp2IlInjected.Token(Token = "0x4005B3D")]
	public static readonly LegacySoundStyle Item1;

	[Cpp2IlInjected.Token(Token = "0x4005B3E")]
	public static readonly LegacySoundStyle Item2;

	[Cpp2IlInjected.Token(Token = "0x4005B3F")]
	public static readonly LegacySoundStyle Item3;

	[Cpp2IlInjected.Token(Token = "0x4005B40")]
	public static readonly LegacySoundStyle Item4;

	[Cpp2IlInjected.Token(Token = "0x4005B41")]
	public static readonly LegacySoundStyle Item5;

	[Cpp2IlInjected.Token(Token = "0x4005B42")]
	public static readonly LegacySoundStyle Item6;

	[Cpp2IlInjected.Token(Token = "0x4005B43")]
	public static readonly LegacySoundStyle Item7;

	[Cpp2IlInjected.Token(Token = "0x4005B44")]
	public static readonly LegacySoundStyle Item8;

	[Cpp2IlInjected.Token(Token = "0x4005B45")]
	public static readonly LegacySoundStyle Item9;

	[Cpp2IlInjected.Token(Token = "0x4005B46")]
	public static readonly LegacySoundStyle Item10;

	[Cpp2IlInjected.Token(Token = "0x4005B47")]
	public static readonly LegacySoundStyle Item11;

	[Cpp2IlInjected.Token(Token = "0x4005B48")]
	public static readonly LegacySoundStyle Item12;

	[Cpp2IlInjected.Token(Token = "0x4005B49")]
	public static readonly LegacySoundStyle Item13;

	[Cpp2IlInjected.Token(Token = "0x4005B4A")]
	public static readonly LegacySoundStyle Item14;

	[Cpp2IlInjected.Token(Token = "0x4005B4B")]
	public static readonly LegacySoundStyle Item15;

	[Cpp2IlInjected.Token(Token = "0x4005B4C")]
	public static readonly LegacySoundStyle Item16;

	[Cpp2IlInjected.Token(Token = "0x4005B4D")]
	public static readonly LegacySoundStyle Item17;

	[Cpp2IlInjected.Token(Token = "0x4005B4E")]
	public static readonly LegacySoundStyle Item18;

	[Cpp2IlInjected.Token(Token = "0x4005B4F")]
	public static readonly LegacySoundStyle Item19;

	[Cpp2IlInjected.Token(Token = "0x4005B50")]
	public static readonly LegacySoundStyle Item20;

	[Cpp2IlInjected.Token(Token = "0x4005B51")]
	public static readonly LegacySoundStyle Item21;

	[Cpp2IlInjected.Token(Token = "0x4005B52")]
	public static readonly LegacySoundStyle Item22;

	[Cpp2IlInjected.Token(Token = "0x4005B53")]
	public static readonly LegacySoundStyle Item23;

	[Cpp2IlInjected.Token(Token = "0x4005B54")]
	public static readonly LegacySoundStyle Item24;

	[Cpp2IlInjected.Token(Token = "0x4005B55")]
	public static readonly LegacySoundStyle Item25;

	[Cpp2IlInjected.Token(Token = "0x4005B56")]
	public static readonly LegacySoundStyle Item26;

	[Cpp2IlInjected.Token(Token = "0x4005B57")]
	public static readonly LegacySoundStyle Item27;

	[Cpp2IlInjected.Token(Token = "0x4005B58")]
	public static readonly LegacySoundStyle Item28;

	[Cpp2IlInjected.Token(Token = "0x4005B59")]
	public static readonly LegacySoundStyle Item29;

	[Cpp2IlInjected.Token(Token = "0x4005B5A")]
	public static readonly LegacySoundStyle Item30;

	[Cpp2IlInjected.Token(Token = "0x4005B5B")]
	public static readonly LegacySoundStyle Item31;

	[Cpp2IlInjected.Token(Token = "0x4005B5C")]
	public static readonly LegacySoundStyle Item32;

	[Cpp2IlInjected.Token(Token = "0x4005B5D")]
	public static readonly LegacySoundStyle Item33;

	[Cpp2IlInjected.Token(Token = "0x4005B5E")]
	public static readonly LegacySoundStyle Item34;

	[Cpp2IlInjected.Token(Token = "0x4005B5F")]
	public static readonly LegacySoundStyle Item35;

	[Cpp2IlInjected.Token(Token = "0x4005B60")]
	public static readonly LegacySoundStyle Item36;

	[Cpp2IlInjected.Token(Token = "0x4005B61")]
	public static readonly LegacySoundStyle Item37;

	[Cpp2IlInjected.Token(Token = "0x4005B62")]
	public static readonly LegacySoundStyle Item38;

	[Cpp2IlInjected.Token(Token = "0x4005B63")]
	public static readonly LegacySoundStyle Item39;

	[Cpp2IlInjected.Token(Token = "0x4005B64")]
	public static readonly LegacySoundStyle Item40;

	[Cpp2IlInjected.Token(Token = "0x4005B65")]
	public static readonly LegacySoundStyle Item41;

	[Cpp2IlInjected.Token(Token = "0x4005B66")]
	public static readonly LegacySoundStyle Item42;

	[Cpp2IlInjected.Token(Token = "0x4005B67")]
	public static readonly LegacySoundStyle Item43;

	[Cpp2IlInjected.Token(Token = "0x4005B68")]
	public static readonly LegacySoundStyle Item44;

	[Cpp2IlInjected.Token(Token = "0x4005B69")]
	public static readonly LegacySoundStyle Item45;

	[Cpp2IlInjected.Token(Token = "0x4005B6A")]
	public static readonly LegacySoundStyle Item46;

	[Cpp2IlInjected.Token(Token = "0x4005B6B")]
	public static readonly LegacySoundStyle Item47;

	[Cpp2IlInjected.Token(Token = "0x4005B6C")]
	public static readonly LegacySoundStyle Item48;

	[Cpp2IlInjected.Token(Token = "0x4005B6D")]
	public static readonly LegacySoundStyle Item49;

	[Cpp2IlInjected.Token(Token = "0x4005B6E")]
	public static readonly LegacySoundStyle Item50;

	[Cpp2IlInjected.Token(Token = "0x4005B6F")]
	public static readonly LegacySoundStyle Item51;

	[Cpp2IlInjected.Token(Token = "0x4005B70")]
	public static readonly LegacySoundStyle Item52;

	[Cpp2IlInjected.Token(Token = "0x4005B71")]
	public static readonly LegacySoundStyle Item53;

	[Cpp2IlInjected.Token(Token = "0x4005B72")]
	public static readonly LegacySoundStyle Item54;

	[Cpp2IlInjected.Token(Token = "0x4005B73")]
	public static readonly LegacySoundStyle Item55;

	[Cpp2IlInjected.Token(Token = "0x4005B74")]
	public static readonly LegacySoundStyle Item56;

	[Cpp2IlInjected.Token(Token = "0x4005B75")]
	public static readonly LegacySoundStyle Item57;

	[Cpp2IlInjected.Token(Token = "0x4005B76")]
	public static readonly LegacySoundStyle Item58;

	[Cpp2IlInjected.Token(Token = "0x4005B77")]
	public static readonly LegacySoundStyle Item59;

	[Cpp2IlInjected.Token(Token = "0x4005B78")]
	public static readonly LegacySoundStyle Item60;

	[Cpp2IlInjected.Token(Token = "0x4005B79")]
	public static readonly LegacySoundStyle Item61;

	[Cpp2IlInjected.Token(Token = "0x4005B7A")]
	public static readonly LegacySoundStyle Item62;

	[Cpp2IlInjected.Token(Token = "0x4005B7B")]
	public static readonly LegacySoundStyle Item63;

	[Cpp2IlInjected.Token(Token = "0x4005B7C")]
	public static readonly LegacySoundStyle Item64;

	[Cpp2IlInjected.Token(Token = "0x4005B7D")]
	public static readonly LegacySoundStyle Item65;

	[Cpp2IlInjected.Token(Token = "0x4005B7E")]
	public static readonly LegacySoundStyle Item66;

	[Cpp2IlInjected.Token(Token = "0x4005B7F")]
	public static readonly LegacySoundStyle Item67;

	[Cpp2IlInjected.Token(Token = "0x4005B80")]
	public static readonly LegacySoundStyle Item68;

	[Cpp2IlInjected.Token(Token = "0x4005B81")]
	public static readonly LegacySoundStyle Item69;

	[Cpp2IlInjected.Token(Token = "0x4005B82")]
	public static readonly LegacySoundStyle Item70;

	[Cpp2IlInjected.Token(Token = "0x4005B83")]
	public static readonly LegacySoundStyle Item71;

	[Cpp2IlInjected.Token(Token = "0x4005B84")]
	public static readonly LegacySoundStyle Item72;

	[Cpp2IlInjected.Token(Token = "0x4005B85")]
	public static readonly LegacySoundStyle Item73;

	[Cpp2IlInjected.Token(Token = "0x4005B86")]
	public static readonly LegacySoundStyle Item74;

	[Cpp2IlInjected.Token(Token = "0x4005B87")]
	public static readonly LegacySoundStyle Item75;

	[Cpp2IlInjected.Token(Token = "0x4005B88")]
	public static readonly LegacySoundStyle Item76;

	[Cpp2IlInjected.Token(Token = "0x4005B89")]
	public static readonly LegacySoundStyle Item77;

	[Cpp2IlInjected.Token(Token = "0x4005B8A")]
	public static readonly LegacySoundStyle Item78;

	[Cpp2IlInjected.Token(Token = "0x4005B8B")]
	public static readonly LegacySoundStyle Item79;

	[Cpp2IlInjected.Token(Token = "0x4005B8C")]
	public static readonly LegacySoundStyle Item80;

	[Cpp2IlInjected.Token(Token = "0x4005B8D")]
	public static readonly LegacySoundStyle Item81;

	[Cpp2IlInjected.Token(Token = "0x4005B8E")]
	public static readonly LegacySoundStyle Item82;

	[Cpp2IlInjected.Token(Token = "0x4005B8F")]
	public static readonly LegacySoundStyle Item83;

	[Cpp2IlInjected.Token(Token = "0x4005B90")]
	public static readonly LegacySoundStyle Item84;

	[Cpp2IlInjected.Token(Token = "0x4005B91")]
	public static readonly LegacySoundStyle Item85;

	[Cpp2IlInjected.Token(Token = "0x4005B92")]
	public static readonly LegacySoundStyle Item86;

	[Cpp2IlInjected.Token(Token = "0x4005B93")]
	public static readonly LegacySoundStyle Item87;

	[Cpp2IlInjected.Token(Token = "0x4005B94")]
	public static readonly LegacySoundStyle Item88;

	[Cpp2IlInjected.Token(Token = "0x4005B95")]
	public static readonly LegacySoundStyle Item89;

	[Cpp2IlInjected.Token(Token = "0x4005B96")]
	public static readonly LegacySoundStyle Item90;

	[Cpp2IlInjected.Token(Token = "0x4005B97")]
	public static readonly LegacySoundStyle Item91;

	[Cpp2IlInjected.Token(Token = "0x4005B98")]
	public static readonly LegacySoundStyle Item92;

	[Cpp2IlInjected.Token(Token = "0x4005B99")]
	public static readonly LegacySoundStyle Item93;

	[Cpp2IlInjected.Token(Token = "0x4005B9A")]
	public static readonly LegacySoundStyle Item94;

	[Cpp2IlInjected.Token(Token = "0x4005B9B")]
	public static readonly LegacySoundStyle Item95;

	[Cpp2IlInjected.Token(Token = "0x4005B9C")]
	public static readonly LegacySoundStyle Item96;

	[Cpp2IlInjected.Token(Token = "0x4005B9D")]
	public static readonly LegacySoundStyle Item97;

	[Cpp2IlInjected.Token(Token = "0x4005B9E")]
	public static readonly LegacySoundStyle Item98;

	[Cpp2IlInjected.Token(Token = "0x4005B9F")]
	public static readonly LegacySoundStyle Item99;

	[Cpp2IlInjected.Token(Token = "0x4005BA0")]
	public static readonly LegacySoundStyle Item100;

	[Cpp2IlInjected.Token(Token = "0x4005BA1")]
	public static readonly LegacySoundStyle Item101;

	[Cpp2IlInjected.Token(Token = "0x4005BA2")]
	public static readonly LegacySoundStyle Item102;

	[Cpp2IlInjected.Token(Token = "0x4005BA3")]
	public static readonly LegacySoundStyle Item103;

	[Cpp2IlInjected.Token(Token = "0x4005BA4")]
	public static readonly LegacySoundStyle Item104;

	[Cpp2IlInjected.Token(Token = "0x4005BA5")]
	public static readonly LegacySoundStyle Item105;

	[Cpp2IlInjected.Token(Token = "0x4005BA6")]
	public static readonly LegacySoundStyle Item106;

	[Cpp2IlInjected.Token(Token = "0x4005BA7")]
	public static readonly LegacySoundStyle Item107;

	[Cpp2IlInjected.Token(Token = "0x4005BA8")]
	public static readonly LegacySoundStyle Item108;

	[Cpp2IlInjected.Token(Token = "0x4005BA9")]
	public static readonly LegacySoundStyle Item109;

	[Cpp2IlInjected.Token(Token = "0x4005BAA")]
	public static readonly LegacySoundStyle Item110;

	[Cpp2IlInjected.Token(Token = "0x4005BAB")]
	public static readonly LegacySoundStyle Item111;

	[Cpp2IlInjected.Token(Token = "0x4005BAC")]
	public static readonly LegacySoundStyle Item112;

	[Cpp2IlInjected.Token(Token = "0x4005BAD")]
	public static readonly LegacySoundStyle Item113;

	[Cpp2IlInjected.Token(Token = "0x4005BAE")]
	public static readonly LegacySoundStyle Item114;

	[Cpp2IlInjected.Token(Token = "0x4005BAF")]
	public static readonly LegacySoundStyle Item115;

	[Cpp2IlInjected.Token(Token = "0x4005BB0")]
	public static readonly LegacySoundStyle Item116;

	[Cpp2IlInjected.Token(Token = "0x4005BB1")]
	public static readonly LegacySoundStyle Item117;

	[Cpp2IlInjected.Token(Token = "0x4005BB2")]
	public static readonly LegacySoundStyle Item118;

	[Cpp2IlInjected.Token(Token = "0x4005BB3")]
	public static readonly LegacySoundStyle Item119;

	[Cpp2IlInjected.Token(Token = "0x4005BB4")]
	public static readonly LegacySoundStyle Item120;

	[Cpp2IlInjected.Token(Token = "0x4005BB5")]
	public static readonly LegacySoundStyle Item121;

	[Cpp2IlInjected.Token(Token = "0x4005BB6")]
	public static readonly LegacySoundStyle Item122;

	[Cpp2IlInjected.Token(Token = "0x4005BB7")]
	public static readonly LegacySoundStyle Item123;

	[Cpp2IlInjected.Token(Token = "0x4005BB8")]
	public static readonly LegacySoundStyle Item124;

	[Cpp2IlInjected.Token(Token = "0x4005BB9")]
	public static readonly LegacySoundStyle Item125;

	[Cpp2IlInjected.Token(Token = "0x4005BBA")]
	public static readonly LegacySoundStyle Item126;

	[Cpp2IlInjected.Token(Token = "0x4005BBB")]
	public static readonly LegacySoundStyle Item127;

	[Cpp2IlInjected.Token(Token = "0x4005BBC")]
	public static readonly LegacySoundStyle Item128;

	[Cpp2IlInjected.Token(Token = "0x4005BBD")]
	public static readonly LegacySoundStyle Item129;

	[Cpp2IlInjected.Token(Token = "0x4005BBE")]
	public static readonly LegacySoundStyle Item130;

	[Cpp2IlInjected.Token(Token = "0x4005BBF")]
	public static readonly LegacySoundStyle Item131;

	[Cpp2IlInjected.Token(Token = "0x4005BC0")]
	public static readonly LegacySoundStyle Item132;

	[Cpp2IlInjected.Token(Token = "0x4005BC1")]
	public static readonly LegacySoundStyle Item133;

	[Cpp2IlInjected.Token(Token = "0x4005BC2")]
	public static readonly LegacySoundStyle Item134;

	[Cpp2IlInjected.Token(Token = "0x4005BC3")]
	public static readonly LegacySoundStyle Item135;

	[Cpp2IlInjected.Token(Token = "0x4005BC4")]
	public static readonly LegacySoundStyle Item136;

	[Cpp2IlInjected.Token(Token = "0x4005BC5")]
	public static readonly LegacySoundStyle Item137;

	[Cpp2IlInjected.Token(Token = "0x4005BC6")]
	public static readonly LegacySoundStyle Item138;

	[Cpp2IlInjected.Token(Token = "0x4005BC7")]
	public static readonly LegacySoundStyle Item139;

	[Cpp2IlInjected.Token(Token = "0x4005BC8")]
	public static readonly LegacySoundStyle Item140;

	[Cpp2IlInjected.Token(Token = "0x4005BC9")]
	public static readonly LegacySoundStyle Item141;

	[Cpp2IlInjected.Token(Token = "0x4005BCA")]
	public static readonly LegacySoundStyle Item142;

	[Cpp2IlInjected.Token(Token = "0x4005BCB")]
	public static readonly LegacySoundStyle Item143;

	[Cpp2IlInjected.Token(Token = "0x4005BCC")]
	public static readonly LegacySoundStyle Item144;

	[Cpp2IlInjected.Token(Token = "0x4005BCD")]
	public static readonly LegacySoundStyle Item145;

	[Cpp2IlInjected.Token(Token = "0x4005BCE")]
	public static readonly LegacySoundStyle Item146;

	[Cpp2IlInjected.Token(Token = "0x4005BCF")]
	public static readonly LegacySoundStyle Item147;

	[Cpp2IlInjected.Token(Token = "0x4005BD0")]
	public static readonly LegacySoundStyle Item148;

	[Cpp2IlInjected.Token(Token = "0x4005BD1")]
	public static readonly LegacySoundStyle Item149;

	[Cpp2IlInjected.Token(Token = "0x4005BD2")]
	public static readonly LegacySoundStyle Item150;

	[Cpp2IlInjected.Token(Token = "0x4005BD3")]
	public static readonly LegacySoundStyle Item151;

	[Cpp2IlInjected.Token(Token = "0x4005BD4")]
	public static readonly LegacySoundStyle Item152;

	[Cpp2IlInjected.Token(Token = "0x4005BD5")]
	public static readonly LegacySoundStyle Item153;

	[Cpp2IlInjected.Token(Token = "0x4005BD6")]
	public static readonly LegacySoundStyle Item154;

	[Cpp2IlInjected.Token(Token = "0x4005BD7")]
	public static readonly LegacySoundStyle Item155;

	[Cpp2IlInjected.Token(Token = "0x4005BD8")]
	public static readonly LegacySoundStyle Item156;

	[Cpp2IlInjected.Token(Token = "0x4005BD9")]
	public static readonly LegacySoundStyle Item157;

	[Cpp2IlInjected.Token(Token = "0x4005BDA")]
	public static readonly LegacySoundStyle Item158;

	[Cpp2IlInjected.Token(Token = "0x4005BDB")]
	public static readonly LegacySoundStyle Item159;

	[Cpp2IlInjected.Token(Token = "0x4005BDC")]
	public static readonly LegacySoundStyle Item160;

	[Cpp2IlInjected.Token(Token = "0x4005BDD")]
	public static readonly LegacySoundStyle Item161;

	[Cpp2IlInjected.Token(Token = "0x4005BDE")]
	public static readonly LegacySoundStyle Item162;

	[Cpp2IlInjected.Token(Token = "0x4005BDF")]
	public static readonly LegacySoundStyle Item163;

	[Cpp2IlInjected.Token(Token = "0x4005BE0")]
	public static readonly LegacySoundStyle Item164;

	[Cpp2IlInjected.Token(Token = "0x4005BE1")]
	public static readonly LegacySoundStyle Item165;

	[Cpp2IlInjected.Token(Token = "0x4005BE2")]
	public static readonly LegacySoundStyle Item166;

	[Cpp2IlInjected.Token(Token = "0x4005BE3")]
	public static readonly LegacySoundStyle Item167;

	[Cpp2IlInjected.Token(Token = "0x4005BE4")]
	public static readonly LegacySoundStyle Item168;

	[Cpp2IlInjected.Token(Token = "0x4005BE5")]
	public static readonly LegacySoundStyle Item169;

	[Cpp2IlInjected.Token(Token = "0x4005BE6")]
	public static readonly LegacySoundStyle Item170;

	[Cpp2IlInjected.Token(Token = "0x4005BE7")]
	public static readonly LegacySoundStyle Item171;

	[Cpp2IlInjected.Token(Token = "0x4005BE8")]
	public static readonly LegacySoundStyle Item172;

	[Cpp2IlInjected.Token(Token = "0x4005BE9")]
	public static readonly LegacySoundStyle Item173;

	[Cpp2IlInjected.Token(Token = "0x4005BEA")]
	public static readonly LegacySoundStyle Item174;

	[Cpp2IlInjected.Token(Token = "0x4005BEB")]
	public static readonly LegacySoundStyle Item175;

	[Cpp2IlInjected.Token(Token = "0x4005BEC")]
	public static readonly LegacySoundStyle Item176;

	[Cpp2IlInjected.Token(Token = "0x4005BED")]
	public static readonly LegacySoundStyle Item177;

	[Cpp2IlInjected.Token(Token = "0x4005BEE")]
	public static readonly LegacySoundStyle Item178;

	[Cpp2IlInjected.Token(Token = "0x4005BEF")]
	public static short ItemSoundCount;

	[Cpp2IlInjected.Token(Token = "0x4005BF0")]
	public static readonly LegacySoundStyle DD2_GoblinBomb;

	[Cpp2IlInjected.Token(Token = "0x4005BF1")]
	public static readonly LegacySoundStyle AchievementComplete;

	[Cpp2IlInjected.Token(Token = "0x4005BF2")]
	public static readonly LegacySoundStyle BlizzardInsideBuildingLoop;

	[Cpp2IlInjected.Token(Token = "0x4005BF3")]
	public static readonly LegacySoundStyle BlizzardStrongLoop;

	[Cpp2IlInjected.Token(Token = "0x4005BF4")]
	public static readonly LegacySoundStyle LiquidsHoneyWater;

	[Cpp2IlInjected.Token(Token = "0x4005BF5")]
	public static readonly LegacySoundStyle LiquidsHoneyLava;

	[Cpp2IlInjected.Token(Token = "0x4005BF6")]
	public static readonly LegacySoundStyle LiquidsWaterLava;

	[Cpp2IlInjected.Token(Token = "0x4005BF7")]
	public static readonly LegacySoundStyle DD2_BallistaTowerShot;

	[Cpp2IlInjected.Token(Token = "0x4005BF8")]
	public static readonly LegacySoundStyle DD2_ExplosiveTrapExplode;

	[Cpp2IlInjected.Token(Token = "0x4005BF9")]
	public static readonly LegacySoundStyle DD2_FlameburstTowerShot;

	[Cpp2IlInjected.Token(Token = "0x4005BFA")]
	public static readonly LegacySoundStyle DD2_LightningAuraZap;

	[Cpp2IlInjected.Token(Token = "0x4005BFB")]
	public static readonly LegacySoundStyle DD2_DefenseTowerSpawn;

	[Cpp2IlInjected.Token(Token = "0x4005BFC")]
	public static readonly LegacySoundStyle DD2_BetsyDeath;

	[Cpp2IlInjected.Token(Token = "0x4005BFD")]
	public static readonly LegacySoundStyle DD2_BetsyFireballShot;

	[Cpp2IlInjected.Token(Token = "0x4005BFE")]
	public static readonly LegacySoundStyle DD2_BetsyFireballImpact;

	[Cpp2IlInjected.Token(Token = "0x4005BFF")]
	public static readonly LegacySoundStyle DD2_BetsyFlameBreath;

	[Cpp2IlInjected.Token(Token = "0x4005C00")]
	public static readonly LegacySoundStyle DD2_BetsyFlyingCircleAttack;

	[Cpp2IlInjected.Token(Token = "0x4005C01")]
	public static readonly LegacySoundStyle DD2_BetsyHurt;

	[Cpp2IlInjected.Token(Token = "0x4005C02")]
	public static readonly LegacySoundStyle DD2_BetsyScream;

	[Cpp2IlInjected.Token(Token = "0x4005C03")]
	public static readonly LegacySoundStyle DD2_BetsySummon;

	[Cpp2IlInjected.Token(Token = "0x4005C04")]
	public static readonly LegacySoundStyle DD2_BetsyWindAttack;

	[Cpp2IlInjected.Token(Token = "0x4005C05")]
	public static readonly LegacySoundStyle DD2_DarkMageAttack;

	[Cpp2IlInjected.Token(Token = "0x4005C06")]
	public static readonly LegacySoundStyle DD2_DarkMageCastHeal;

	[Cpp2IlInjected.Token(Token = "0x4005C07")]
	public static readonly LegacySoundStyle DD2_DarkMageDeath;

	[Cpp2IlInjected.Token(Token = "0x4005C08")]
	public static readonly LegacySoundStyle DD2_DarkMageHealImpact;

	[Cpp2IlInjected.Token(Token = "0x4005C09")]
	public static readonly LegacySoundStyle DD2_DarkMageHurt;

	[Cpp2IlInjected.Token(Token = "0x4005C0A")]
	public static readonly LegacySoundStyle DD2_DarkMageSummonSkeleton;

	[Cpp2IlInjected.Token(Token = "0x4005C0B")]
	public static readonly LegacySoundStyle DD2_DrakinBreathIn;

	[Cpp2IlInjected.Token(Token = "0x4005C0C")]
	public static readonly LegacySoundStyle DD2_DrakinDeath;

	[Cpp2IlInjected.Token(Token = "0x4005C0D")]
	public static readonly LegacySoundStyle DD2_DrakinHurt;

	[Cpp2IlInjected.Token(Token = "0x4005C0E")]
	public static readonly LegacySoundStyle DD2_DrakinShot;

	[Cpp2IlInjected.Token(Token = "0x4005C0F")]
	public static readonly LegacySoundStyle DD2_GoblinDeath;

	[Cpp2IlInjected.Token(Token = "0x4005C10")]
	public static readonly LegacySoundStyle DD2_GoblinHurt;

	[Cpp2IlInjected.Token(Token = "0x4005C11")]
	public static readonly LegacySoundStyle DD2_GoblinScream;

	[Cpp2IlInjected.Token(Token = "0x4005C12")]
	public static readonly LegacySoundStyle DD2_GoblinBomberDeath;

	[Cpp2IlInjected.Token(Token = "0x4005C13")]
	public static readonly LegacySoundStyle DD2_GoblinBomberHurt;

	[Cpp2IlInjected.Token(Token = "0x4005C14")]
	public static readonly LegacySoundStyle DD2_GoblinBomberScream;

	[Cpp2IlInjected.Token(Token = "0x4005C15")]
	public static readonly LegacySoundStyle DD2_GoblinBomberThrow;

	[Cpp2IlInjected.Token(Token = "0x4005C16")]
	public static readonly LegacySoundStyle DD2_JavelinThrowersAttack;

	[Cpp2IlInjected.Token(Token = "0x4005C17")]
	public static readonly LegacySoundStyle DD2_JavelinThrowersDeath;

	[Cpp2IlInjected.Token(Token = "0x4005C18")]
	public static readonly LegacySoundStyle DD2_JavelinThrowersHurt;

	[Cpp2IlInjected.Token(Token = "0x4005C19")]
	public static readonly LegacySoundStyle DD2_JavelinThrowersTaunt;

	[Cpp2IlInjected.Token(Token = "0x4005C1A")]
	public static readonly LegacySoundStyle DD2_KoboldDeath;

	[Cpp2IlInjected.Token(Token = "0x4005C1B")]
	public static readonly LegacySoundStyle DD2_KoboldExplosion;

	[Cpp2IlInjected.Token(Token = "0x4005C1C")]
	public static readonly LegacySoundStyle DD2_KoboldHurt;

	[Cpp2IlInjected.Token(Token = "0x4005C1D")]
	public static readonly LegacySoundStyle DD2_KoboldIgnite;

	[Cpp2IlInjected.Token(Token = "0x4005C1E")]
	public static readonly LegacySoundStyle DD2_KoboldIgniteLoop;

	[Cpp2IlInjected.Token(Token = "0x4005C1F")]
	public static readonly LegacySoundStyle DD2_KoboldScreamChargeLoop;

	[Cpp2IlInjected.Token(Token = "0x4005C20")]
	public static readonly LegacySoundStyle DD2_KoboldFlyerChargeScream;

	[Cpp2IlInjected.Token(Token = "0x4005C21")]
	public static readonly LegacySoundStyle DD2_KoboldFlyerDeath;

	[Cpp2IlInjected.Token(Token = "0x4005C22")]
	public static readonly LegacySoundStyle DD2_KoboldFlyerHurt;

	[Cpp2IlInjected.Token(Token = "0x4005C23")]
	public static readonly LegacySoundStyle DD2_LightningBugDeath;

	[Cpp2IlInjected.Token(Token = "0x4005C24")]
	public static readonly LegacySoundStyle DD2_LightningBugHurt;

	[Cpp2IlInjected.Token(Token = "0x4005C25")]
	public static readonly LegacySoundStyle DD2_LightningBugZap;

	[Cpp2IlInjected.Token(Token = "0x4005C26")]
	public static readonly LegacySoundStyle DD2_OgreAttack;

	[Cpp2IlInjected.Token(Token = "0x4005C27")]
	public static readonly LegacySoundStyle DD2_OgreDeath;

	[Cpp2IlInjected.Token(Token = "0x4005C28")]
	public static readonly LegacySoundStyle DD2_OgreGroundPound;

	[Cpp2IlInjected.Token(Token = "0x4005C29")]
	public static readonly LegacySoundStyle DD2_OgreHurt;

	[Cpp2IlInjected.Token(Token = "0x4005C2A")]
	public static readonly LegacySoundStyle DD2_OgreRoar;

	[Cpp2IlInjected.Token(Token = "0x4005C2B")]
	public static readonly LegacySoundStyle DD2_OgreSpit;

	[Cpp2IlInjected.Token(Token = "0x4005C2C")]
	public static readonly LegacySoundStyle DD2_SkeletonDeath;

	[Cpp2IlInjected.Token(Token = "0x4005C2D")]
	public static readonly LegacySoundStyle DD2_SkeletonHurt;

	[Cpp2IlInjected.Token(Token = "0x4005C2E")]
	public static readonly LegacySoundStyle DD2_SkeletonSummoned;

	[Cpp2IlInjected.Token(Token = "0x4005C2F")]
	public static readonly LegacySoundStyle DD2_WitherBeastAuraPulse;

	[Cpp2IlInjected.Token(Token = "0x4005C30")]
	public static readonly LegacySoundStyle DD2_WitherBeastCrystalImpact;

	[Cpp2IlInjected.Token(Token = "0x4005C31")]
	public static readonly LegacySoundStyle DD2_WitherBeastDeath;

	[Cpp2IlInjected.Token(Token = "0x4005C32")]
	public static readonly LegacySoundStyle DD2_WitherBeastHurt;

	[Cpp2IlInjected.Token(Token = "0x4005C33")]
	public static readonly LegacySoundStyle DD2_WyvernDeath;

	[Cpp2IlInjected.Token(Token = "0x4005C34")]
	public static readonly LegacySoundStyle DD2_WyvernHurt;

	[Cpp2IlInjected.Token(Token = "0x4005C35")]
	public static readonly LegacySoundStyle DD2_WyvernScream;

	[Cpp2IlInjected.Token(Token = "0x4005C36")]
	public static readonly LegacySoundStyle DD2_WyvernDiveDown;

	[Cpp2IlInjected.Token(Token = "0x4005C37")]
	public static readonly LegacySoundStyle DD2_EtherianPortalDryadTouch;

	[Cpp2IlInjected.Token(Token = "0x4005C38")]
	public static readonly LegacySoundStyle DD2_EtherianPortalIdleLoop;

	[Cpp2IlInjected.Token(Token = "0x4005C39")]
	public static readonly LegacySoundStyle DD2_EtherianPortalOpen;

	[Cpp2IlInjected.Token(Token = "0x4005C3A")]
	public static readonly LegacySoundStyle DD2_EtherianPortalSpawnEnemy;

	[Cpp2IlInjected.Token(Token = "0x4005C3B")]
	public static readonly LegacySoundStyle DD2_CrystalCartImpact;

	[Cpp2IlInjected.Token(Token = "0x4005C3C")]
	public static readonly LegacySoundStyle DD2_DefeatScene;

	[Cpp2IlInjected.Token(Token = "0x4005C3D")]
	public static readonly LegacySoundStyle DD2_WinScene;

	[Cpp2IlInjected.Token(Token = "0x4005C3E")]
	public static readonly LegacySoundStyle DD2_BetsysWrathShot;

	[Cpp2IlInjected.Token(Token = "0x4005C3F")]
	public static readonly LegacySoundStyle DD2_BetsysWrathImpact;

	[Cpp2IlInjected.Token(Token = "0x4005C40")]
	public static readonly LegacySoundStyle DD2_BookStaffCast;

	[Cpp2IlInjected.Token(Token = "0x4005C41")]
	public static readonly LegacySoundStyle DD2_BookStaffTwisterLoop;

	[Cpp2IlInjected.Token(Token = "0x4005C42")]
	public static readonly LegacySoundStyle DD2_GhastlyGlaiveImpactGhost;

	[Cpp2IlInjected.Token(Token = "0x4005C43")]
	public static readonly LegacySoundStyle DD2_GhastlyGlaivePierce;

	[Cpp2IlInjected.Token(Token = "0x4005C44")]
	public static readonly LegacySoundStyle DD2_MonkStaffGroundImpact;

	[Cpp2IlInjected.Token(Token = "0x4005C45")]
	public static readonly LegacySoundStyle DD2_MonkStaffGroundMiss;

	[Cpp2IlInjected.Token(Token = "0x4005C46")]
	public static readonly LegacySoundStyle DD2_MonkStaffSwing;

	[Cpp2IlInjected.Token(Token = "0x4005C47")]
	public static readonly LegacySoundStyle DD2_PhantomPhoenixShot;

	[Cpp2IlInjected.Token(Token = "0x4005C48")]
	public static readonly LegacySoundStyle DD2_SonicBoomBladeSlash;

	[Cpp2IlInjected.Token(Token = "0x4005C49")]
	public static readonly LegacySoundStyle DD2_SkyDragonsFuryCircle;

	[Cpp2IlInjected.Token(Token = "0x4005C4A")]
	public static readonly LegacySoundStyle DD2_SkyDragonsFuryShot;

	[Cpp2IlInjected.Token(Token = "0x4005C4B")]
	public static readonly LegacySoundStyle DD2_SkyDragonsFurySwing;

	[Cpp2IlInjected.Token(Token = "0x4005C4C")]
	public static readonly LegacySoundStyle LucyTheAxeTalk;

	[Cpp2IlInjected.Token(Token = "0x4005C4D")]
	public static readonly LegacySoundStyle DeerclopsHit;

	[Cpp2IlInjected.Token(Token = "0x4005C4E")]
	public static readonly LegacySoundStyle DeerclopsDeath;

	[Cpp2IlInjected.Token(Token = "0x4005C4F")]
	public static readonly LegacySoundStyle DeerclopsScream;

	[Cpp2IlInjected.Token(Token = "0x4005C50")]
	public static readonly LegacySoundStyle DeerclopsIceAttack;

	[Cpp2IlInjected.Token(Token = "0x4005C51")]
	public static readonly LegacySoundStyle DeerclopsRubbleAttack;

	[Cpp2IlInjected.Token(Token = "0x4005C52")]
	public static readonly LegacySoundStyle DeerclopsStep;

	[Cpp2IlInjected.Token(Token = "0x4005C53")]
	public static readonly LegacySoundStyle ChesterOpen;

	[Cpp2IlInjected.Token(Token = "0x4005C54")]
	public static readonly LegacySoundStyle ChesterClose;

	[Cpp2IlInjected.Token(Token = "0x4005C55")]
	public static readonly LegacySoundStyle AbigailSummon;

	[Cpp2IlInjected.Token(Token = "0x4005C56")]
	public static readonly LegacySoundStyle AbigailCry;

	[Cpp2IlInjected.Token(Token = "0x4005C57")]
	public static readonly LegacySoundStyle AbigailAttack;

	[Cpp2IlInjected.Token(Token = "0x4005C58")]
	public static readonly LegacySoundStyle AbigailUpgrade;

	[Cpp2IlInjected.Token(Token = "0x4005C59")]
	public static readonly LegacySoundStyle GlommerBounce;

	[Cpp2IlInjected.Token(Token = "0x4005C5A")]
	public static readonly LegacySoundStyle DSTMaleHurt;

	[Cpp2IlInjected.Token(Token = "0x4005C5B")]
	public static readonly LegacySoundStyle DSTFemaleHurt;

	[Cpp2IlInjected.Token(Token = "0x4005C5C")]
	public static readonly LegacySoundStyle JimsDrone;

	[Cpp2IlInjected.Token(Token = "0x4005C5D")]
	private static List<string> _trackableLegacySoundPathList;

	[Cpp2IlInjected.Token(Token = "0x4005C5E")]
	public static Dictionary<string, LegacySoundStyle> SoundByName;

	[Cpp2IlInjected.Token(Token = "0x4005C5F")]
	public static Dictionary<string, ushort> IndexByName;

	[Cpp2IlInjected.Token(Token = "0x4005C60")]
	public static Dictionary<ushort, LegacySoundStyle> SoundByIndex;

	[Cpp2IlInjected.Token(Token = "0x17000608")]
	public static int TrackableLegacySoundCount
	{
		[Cpp2IlInjected.Token(Token = "0x60030BD")]
		[Cpp2IlInjected.Address(RVA = "0x14735D8", Offset = "0x14735D8", VA = "0x14735D8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60030BE")]
	[Cpp2IlInjected.Address(RVA = "0x1473654", Offset = "0x1473654", VA = "0x1473654")]
	public static string GetTrackableLegacySoundPath(int id)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030BF")]
	[Cpp2IlInjected.Address(RVA = "0x14736F0", Offset = "0x14736F0", VA = "0x14736F0")]
	private static LegacySoundStyle CreateTrackable(string name, SoundStyleDefaults defaults)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030C0")]
	[Cpp2IlInjected.Address(RVA = "0x1473A4C", Offset = "0x1473A4C", VA = "0x1473A4C")]
	private static LegacySoundStyle CreateTrackable(string name, int variations, SoundStyleDefaults defaults)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030C1")]
	[Cpp2IlInjected.Address(RVA = "0x1473AF4", Offset = "0x1473AF4", VA = "0x1473AF4")]
	private static LegacySoundStyle CreateTrackable(string name, SoundType type = SoundType.Sound)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030C2")]
	[Cpp2IlInjected.Address(RVA = "0x1473794", Offset = "0x1473794", VA = "0x1473794")]
	private static LegacySoundStyle CreateTrackable(string name, int variations, SoundType type = SoundType.Sound)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030C3")]
	[Cpp2IlInjected.Address(RVA = "0x1473B78", Offset = "0x1473B78", VA = "0x1473B78")]
	public static void FillAccessMap()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030C4")]
	[Cpp2IlInjected.Address(RVA = "0x1473F4C", Offset = "0x1473F4C", VA = "0x1473F4C")]
	public SoundID()
	{
	}
}
