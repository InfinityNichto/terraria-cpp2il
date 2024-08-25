using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Audio;

namespace Terraria.ID
{
	[global::Cpp2ILInjected.Token(Token = "0x20005EF")]
	public class SoundID
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000688")]
		public static int TrackableLegacySoundCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x600358B")]
			[global::Cpp2ILInjected.Address(RVA = "0x13CFB50", Offset = "0x13CFB50", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacySoundPlayer), Member = "LoadAll", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600358C")]
		[global::Cpp2ILInjected.Address(RVA = "0x13CFBB8", Offset = "0x13CFBB8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacySoundPlayer), Member = "LoadAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static string GetTrackableLegacySoundPath(int id)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600358D")]
		[global::Cpp2ILInjected.Address(RVA = "0x13CFC30", Offset = "0x13CFC30", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundID), Member = "CreateTrackable", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(SoundType)
		}, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundStyle), Member = "WithPitchVariance", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundStyle), Member = "WithVolume", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static LegacySoundStyle CreateTrackable(string name, SoundID.SoundStyleDefaults defaults)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600358E")]
		[global::Cpp2ILInjected.Address(RVA = "0x13CFF58", Offset = "0x13CFF58", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundID), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundID), Member = "CreateTrackable", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(SoundType)
		}, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundStyle), Member = "WithPitchVariance", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundStyle), Member = "WithVolume", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static LegacySoundStyle CreateTrackable(string name, int variations, SoundID.SoundStyleDefaults defaults)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600358F")]
		[global::Cpp2ILInjected.Address(RVA = "0x13CFFEC", Offset = "0x13CFFEC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundID), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundID), Member = "CreateTrackable", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(SoundType)
		}, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static LegacySoundStyle CreateTrackable(string name, SoundType type = SoundType.Sound)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003590")]
		[global::Cpp2ILInjected.Address(RVA = "0x13CFCC0", Offset = "0x13CFCC0", Length = "0x298")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundID), Member = "CreateTrackable", MemberParameters = new object[]
		{
			typeof(string),
			typeof(SoundID.SoundStyleDefaults)
		}, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundID), Member = "CreateTrackable", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(SoundID.SoundStyleDefaults)
		}, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundID), Member = "CreateTrackable", MemberParameters = new object[]
		{
			typeof(string),
			typeof(SoundType)
		}, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SoundID), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 83)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundStyle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(SoundType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private static LegacySoundStyle CreateTrackable(string name, int variations, SoundType type = SoundType.Sound)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003591")]
		[global::Cpp2ILInjected.Address(RVA = "0x13D0054", Offset = "0x13D0054", Length = "0x3DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, ushort>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ForEach", MemberParameters = new object[] { typeof(Action<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		public static void FillAccessMap()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003592")]
		[global::Cpp2ILInjected.Address(RVA = "0x13D0438", Offset = "0x13D0438", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SoundID()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003593")]
		[global::Cpp2ILInjected.Address(RVA = "0x13D0440", Offset = "0x13D0440", Length = "0x4940")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundStyle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(SoundType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundStyle), Member = "WithVolume", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundID), Member = "CreateTrackable", MemberParameters = new object[]
		{
			typeof(string),
			typeof(SoundType)
		}, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundID), Member = "CreateTrackable", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(SoundType)
		}, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundID), Member = "CreateTrackable", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(SoundID.SoundStyleDefaults)
		}, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacySoundStyle), Member = "WithPitchVariance", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(LegacySoundStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 410)]
		static SoundID()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4006DB7")]
		private static readonly SoundID.SoundStyleDefaults ItemDefaults;

		[global::Cpp2ILInjected.Token(Token = "0x4006DB8")]
		public const int Dig = 0;

		[global::Cpp2ILInjected.Token(Token = "0x4006DB9")]
		public const int PlayerHit = 1;

		[global::Cpp2ILInjected.Token(Token = "0x4006DBA")]
		public const int Item = 2;

		[global::Cpp2ILInjected.Token(Token = "0x4006DBB")]
		public const int NPCHit = 3;

		[global::Cpp2ILInjected.Token(Token = "0x4006DBC")]
		public const int NPCKilled = 4;

		[global::Cpp2ILInjected.Token(Token = "0x4006DBD")]
		public const int PlayerKilled = 5;

		[global::Cpp2ILInjected.Token(Token = "0x4006DBE")]
		public const int Grass = 6;

		[global::Cpp2ILInjected.Token(Token = "0x4006DBF")]
		public const int Grab = 7;

		[global::Cpp2ILInjected.Token(Token = "0x4006DC0")]
		public const int DoorOpen = 8;

		[global::Cpp2ILInjected.Token(Token = "0x4006DC1")]
		public const int DoorClosed = 9;

		[global::Cpp2ILInjected.Token(Token = "0x4006DC2")]
		public const int MenuOpen = 10;

		[global::Cpp2ILInjected.Token(Token = "0x4006DC3")]
		public const int MenuClose = 11;

		[global::Cpp2ILInjected.Token(Token = "0x4006DC4")]
		public const int MenuTick = 12;

		[global::Cpp2ILInjected.Token(Token = "0x4006DC5")]
		public const int Shatter = 13;

		[global::Cpp2ILInjected.Token(Token = "0x4006DC6")]
		public const int ZombieMoan = 14;

		[global::Cpp2ILInjected.Token(Token = "0x4006DC7")]
		public const int Roar = 15;

		[global::Cpp2ILInjected.Token(Token = "0x4006DC8")]
		public const int DoubleJump = 16;

		[global::Cpp2ILInjected.Token(Token = "0x4006DC9")]
		public const int Run = 17;

		[global::Cpp2ILInjected.Token(Token = "0x4006DCA")]
		public const int Coins = 18;

		[global::Cpp2ILInjected.Token(Token = "0x4006DCB")]
		public const int Splash = 19;

		[global::Cpp2ILInjected.Token(Token = "0x4006DCC")]
		public const int FemaleHit = 20;

		[global::Cpp2ILInjected.Token(Token = "0x4006DCD")]
		public const int Tink = 21;

		[global::Cpp2ILInjected.Token(Token = "0x4006DCE")]
		public const int Unlock = 22;

		[global::Cpp2ILInjected.Token(Token = "0x4006DCF")]
		public const int Drown = 23;

		[global::Cpp2ILInjected.Token(Token = "0x4006DD0")]
		public const int Chat = 24;

		[global::Cpp2ILInjected.Token(Token = "0x4006DD1")]
		public const int MaxMana = 25;

		[global::Cpp2ILInjected.Token(Token = "0x4006DD2")]
		public const int Mummy = 26;

		[global::Cpp2ILInjected.Token(Token = "0x4006DD3")]
		public const int Pixie = 27;

		[global::Cpp2ILInjected.Token(Token = "0x4006DD4")]
		public const int Mech = 28;

		[global::Cpp2ILInjected.Token(Token = "0x4006DD5")]
		public const int Zombie = 29;

		[global::Cpp2ILInjected.Token(Token = "0x4006DD6")]
		public const int Duck = 30;

		[global::Cpp2ILInjected.Token(Token = "0x4006DD7")]
		public const int Frog = 31;

		[global::Cpp2ILInjected.Token(Token = "0x4006DD8")]
		public const int Bird = 32;

		[global::Cpp2ILInjected.Token(Token = "0x4006DD9")]
		public const int Critter = 33;

		[global::Cpp2ILInjected.Token(Token = "0x4006DDA")]
		public const int Waterfall = 34;

		[global::Cpp2ILInjected.Token(Token = "0x4006DDB")]
		public const int Lavafall = 35;

		[global::Cpp2ILInjected.Token(Token = "0x4006DDC")]
		public const int ForceRoar = 36;

		[global::Cpp2ILInjected.Token(Token = "0x4006DDD")]
		public const int Meowmere = 37;

		[global::Cpp2ILInjected.Token(Token = "0x4006DDE")]
		public const int CoinPickup = 38;

		[global::Cpp2ILInjected.Token(Token = "0x4006DDF")]
		public const int Drip = 39;

		[global::Cpp2ILInjected.Token(Token = "0x4006DE0")]
		public const int Camera = 40;

		[global::Cpp2ILInjected.Token(Token = "0x4006DE1")]
		public const int MoonLord = 41;

		[global::Cpp2ILInjected.Token(Token = "0x4006DE2")]
		public const int Trackable = 42;

		[global::Cpp2ILInjected.Token(Token = "0x4006DE3")]
		public const int Thunder = 43;

		[global::Cpp2ILInjected.Token(Token = "0x4006DE4")]
		public const int Seagull = 44;

		[global::Cpp2ILInjected.Token(Token = "0x4006DE5")]
		public const int Dolphin = 45;

		[global::Cpp2ILInjected.Token(Token = "0x4006DE6")]
		public const int Owl = 46;

		[global::Cpp2ILInjected.Token(Token = "0x4006DE7")]
		public const int GuitarC = 47;

		[global::Cpp2ILInjected.Token(Token = "0x4006DE8")]
		public const int GuitarD = 48;

		[global::Cpp2ILInjected.Token(Token = "0x4006DE9")]
		public const int GuitarEm = 49;

		[global::Cpp2ILInjected.Token(Token = "0x4006DEA")]
		public const int GuitarG = 50;

		[global::Cpp2ILInjected.Token(Token = "0x4006DEB")]
		public const int GuitarBm = 51;

		[global::Cpp2ILInjected.Token(Token = "0x4006DEC")]
		public const int GuitarAm = 52;

		[global::Cpp2ILInjected.Token(Token = "0x4006DED")]
		public const int DrumHiHat = 53;

		[global::Cpp2ILInjected.Token(Token = "0x4006DEE")]
		public const int DrumTomHigh = 54;

		[global::Cpp2ILInjected.Token(Token = "0x4006DEF")]
		public const int DrumTomLow = 55;

		[global::Cpp2ILInjected.Token(Token = "0x4006DF0")]
		public const int DrumTomMid = 56;

		[global::Cpp2ILInjected.Token(Token = "0x4006DF1")]
		public const int DrumClosedHiHat = 57;

		[global::Cpp2ILInjected.Token(Token = "0x4006DF2")]
		public const int DrumCymbal1 = 58;

		[global::Cpp2ILInjected.Token(Token = "0x4006DF3")]
		public const int DrumCymbal2 = 59;

		[global::Cpp2ILInjected.Token(Token = "0x4006DF4")]
		public const int DrumKick = 60;

		[global::Cpp2ILInjected.Token(Token = "0x4006DF5")]
		public const int DrumTamaSnare = 61;

		[global::Cpp2ILInjected.Token(Token = "0x4006DF6")]
		public const int DrumFloorTom = 62;

		[global::Cpp2ILInjected.Token(Token = "0x4006DF7")]
		public const int Research = 63;

		[global::Cpp2ILInjected.Token(Token = "0x4006DF8")]
		public const int ResearchComplete = 64;

		[global::Cpp2ILInjected.Token(Token = "0x4006DF9")]
		public const int QueenSlime = 65;

		[global::Cpp2ILInjected.Token(Token = "0x4006DFA")]
		public const int Clown = 66;

		[global::Cpp2ILInjected.Token(Token = "0x4006DFB")]
		public const int Cockatiel = 67;

		[global::Cpp2ILInjected.Token(Token = "0x4006DFC")]
		public const int Macaw = 68;

		[global::Cpp2ILInjected.Token(Token = "0x4006DFD")]
		public const int Toucan = 69;

		[global::Cpp2ILInjected.Token(Token = "0x4006DFE")]
		public static readonly LegacySoundStyle NPCHit1;

		[global::Cpp2ILInjected.Token(Token = "0x4006DFF")]
		public static readonly LegacySoundStyle NPCHit2;

		[global::Cpp2ILInjected.Token(Token = "0x4006E00")]
		public static readonly LegacySoundStyle NPCHit3;

		[global::Cpp2ILInjected.Token(Token = "0x4006E01")]
		public static readonly LegacySoundStyle NPCHit4;

		[global::Cpp2ILInjected.Token(Token = "0x4006E02")]
		public static readonly LegacySoundStyle NPCHit5;

		[global::Cpp2ILInjected.Token(Token = "0x4006E03")]
		public static readonly LegacySoundStyle NPCHit6;

		[global::Cpp2ILInjected.Token(Token = "0x4006E04")]
		public static readonly LegacySoundStyle NPCHit7;

		[global::Cpp2ILInjected.Token(Token = "0x4006E05")]
		public static readonly LegacySoundStyle NPCHit8;

		[global::Cpp2ILInjected.Token(Token = "0x4006E06")]
		public static readonly LegacySoundStyle NPCHit9;

		[global::Cpp2ILInjected.Token(Token = "0x4006E07")]
		public static readonly LegacySoundStyle NPCHit10;

		[global::Cpp2ILInjected.Token(Token = "0x4006E08")]
		public static readonly LegacySoundStyle NPCHit11;

		[global::Cpp2ILInjected.Token(Token = "0x4006E09")]
		public static readonly LegacySoundStyle NPCHit12;

		[global::Cpp2ILInjected.Token(Token = "0x4006E0A")]
		public static readonly LegacySoundStyle NPCHit13;

		[global::Cpp2ILInjected.Token(Token = "0x4006E0B")]
		public static readonly LegacySoundStyle NPCHit14;

		[global::Cpp2ILInjected.Token(Token = "0x4006E0C")]
		public static readonly LegacySoundStyle NPCHit15;

		[global::Cpp2ILInjected.Token(Token = "0x4006E0D")]
		public static readonly LegacySoundStyle NPCHit16;

		[global::Cpp2ILInjected.Token(Token = "0x4006E0E")]
		public static readonly LegacySoundStyle NPCHit17;

		[global::Cpp2ILInjected.Token(Token = "0x4006E0F")]
		public static readonly LegacySoundStyle NPCHit18;

		[global::Cpp2ILInjected.Token(Token = "0x4006E10")]
		public static readonly LegacySoundStyle NPCHit19;

		[global::Cpp2ILInjected.Token(Token = "0x4006E11")]
		public static readonly LegacySoundStyle NPCHit20;

		[global::Cpp2ILInjected.Token(Token = "0x4006E12")]
		public static readonly LegacySoundStyle NPCHit21;

		[global::Cpp2ILInjected.Token(Token = "0x4006E13")]
		public static readonly LegacySoundStyle NPCHit22;

		[global::Cpp2ILInjected.Token(Token = "0x4006E14")]
		public static readonly LegacySoundStyle NPCHit23;

		[global::Cpp2ILInjected.Token(Token = "0x4006E15")]
		public static readonly LegacySoundStyle NPCHit24;

		[global::Cpp2ILInjected.Token(Token = "0x4006E16")]
		public static readonly LegacySoundStyle NPCHit25;

		[global::Cpp2ILInjected.Token(Token = "0x4006E17")]
		public static readonly LegacySoundStyle NPCHit26;

		[global::Cpp2ILInjected.Token(Token = "0x4006E18")]
		public static readonly LegacySoundStyle NPCHit27;

		[global::Cpp2ILInjected.Token(Token = "0x4006E19")]
		public static readonly LegacySoundStyle NPCHit28;

		[global::Cpp2ILInjected.Token(Token = "0x4006E1A")]
		public static readonly LegacySoundStyle NPCHit29;

		[global::Cpp2ILInjected.Token(Token = "0x4006E1B")]
		public static readonly LegacySoundStyle NPCHit30;

		[global::Cpp2ILInjected.Token(Token = "0x4006E1C")]
		public static readonly LegacySoundStyle NPCHit31;

		[global::Cpp2ILInjected.Token(Token = "0x4006E1D")]
		public static readonly LegacySoundStyle NPCHit32;

		[global::Cpp2ILInjected.Token(Token = "0x4006E1E")]
		public static readonly LegacySoundStyle NPCHit33;

		[global::Cpp2ILInjected.Token(Token = "0x4006E1F")]
		public static readonly LegacySoundStyle NPCHit34;

		[global::Cpp2ILInjected.Token(Token = "0x4006E20")]
		public static readonly LegacySoundStyle NPCHit35;

		[global::Cpp2ILInjected.Token(Token = "0x4006E21")]
		public static readonly LegacySoundStyle NPCHit36;

		[global::Cpp2ILInjected.Token(Token = "0x4006E22")]
		public static readonly LegacySoundStyle NPCHit37;

		[global::Cpp2ILInjected.Token(Token = "0x4006E23")]
		public static readonly LegacySoundStyle NPCHit38;

		[global::Cpp2ILInjected.Token(Token = "0x4006E24")]
		public static readonly LegacySoundStyle NPCHit39;

		[global::Cpp2ILInjected.Token(Token = "0x4006E25")]
		public static readonly LegacySoundStyle NPCHit40;

		[global::Cpp2ILInjected.Token(Token = "0x4006E26")]
		public static readonly LegacySoundStyle NPCHit41;

		[global::Cpp2ILInjected.Token(Token = "0x4006E27")]
		public static readonly LegacySoundStyle NPCHit42;

		[global::Cpp2ILInjected.Token(Token = "0x4006E28")]
		public static readonly LegacySoundStyle NPCHit43;

		[global::Cpp2ILInjected.Token(Token = "0x4006E29")]
		public static readonly LegacySoundStyle NPCHit44;

		[global::Cpp2ILInjected.Token(Token = "0x4006E2A")]
		public static readonly LegacySoundStyle NPCHit45;

		[global::Cpp2ILInjected.Token(Token = "0x4006E2B")]
		public static readonly LegacySoundStyle NPCHit46;

		[global::Cpp2ILInjected.Token(Token = "0x4006E2C")]
		public static readonly LegacySoundStyle NPCHit47;

		[global::Cpp2ILInjected.Token(Token = "0x4006E2D")]
		public static readonly LegacySoundStyle NPCHit48;

		[global::Cpp2ILInjected.Token(Token = "0x4006E2E")]
		public static readonly LegacySoundStyle NPCHit49;

		[global::Cpp2ILInjected.Token(Token = "0x4006E2F")]
		public static readonly LegacySoundStyle NPCHit50;

		[global::Cpp2ILInjected.Token(Token = "0x4006E30")]
		public static readonly LegacySoundStyle NPCHit51;

		[global::Cpp2ILInjected.Token(Token = "0x4006E31")]
		public static readonly LegacySoundStyle NPCHit52;

		[global::Cpp2ILInjected.Token(Token = "0x4006E32")]
		public static readonly LegacySoundStyle NPCHit53;

		[global::Cpp2ILInjected.Token(Token = "0x4006E33")]
		public static readonly LegacySoundStyle NPCHit54;

		[global::Cpp2ILInjected.Token(Token = "0x4006E34")]
		public static readonly LegacySoundStyle NPCHit55;

		[global::Cpp2ILInjected.Token(Token = "0x4006E35")]
		public static readonly LegacySoundStyle NPCHit56;

		[global::Cpp2ILInjected.Token(Token = "0x4006E36")]
		public static readonly LegacySoundStyle NPCHit57;

		[global::Cpp2ILInjected.Token(Token = "0x4006E37")]
		public static readonly LegacySoundStyle NPCDeath1;

		[global::Cpp2ILInjected.Token(Token = "0x4006E38")]
		public static readonly LegacySoundStyle NPCDeath2;

		[global::Cpp2ILInjected.Token(Token = "0x4006E39")]
		public static readonly LegacySoundStyle NPCDeath3;

		[global::Cpp2ILInjected.Token(Token = "0x4006E3A")]
		public static readonly LegacySoundStyle NPCDeath4;

		[global::Cpp2ILInjected.Token(Token = "0x4006E3B")]
		public static readonly LegacySoundStyle NPCDeath5;

		[global::Cpp2ILInjected.Token(Token = "0x4006E3C")]
		public static readonly LegacySoundStyle NPCDeath6;

		[global::Cpp2ILInjected.Token(Token = "0x4006E3D")]
		public static readonly LegacySoundStyle NPCDeath7;

		[global::Cpp2ILInjected.Token(Token = "0x4006E3E")]
		public static readonly LegacySoundStyle NPCDeath8;

		[global::Cpp2ILInjected.Token(Token = "0x4006E3F")]
		public static readonly LegacySoundStyle NPCDeath9;

		[global::Cpp2ILInjected.Token(Token = "0x4006E40")]
		public static readonly LegacySoundStyle NPCDeath10;

		[global::Cpp2ILInjected.Token(Token = "0x4006E41")]
		public static readonly LegacySoundStyle NPCDeath11;

		[global::Cpp2ILInjected.Token(Token = "0x4006E42")]
		public static readonly LegacySoundStyle NPCDeath12;

		[global::Cpp2ILInjected.Token(Token = "0x4006E43")]
		public static readonly LegacySoundStyle NPCDeath13;

		[global::Cpp2ILInjected.Token(Token = "0x4006E44")]
		public static readonly LegacySoundStyle NPCDeath14;

		[global::Cpp2ILInjected.Token(Token = "0x4006E45")]
		public static readonly LegacySoundStyle NPCDeath15;

		[global::Cpp2ILInjected.Token(Token = "0x4006E46")]
		public static readonly LegacySoundStyle NPCDeath16;

		[global::Cpp2ILInjected.Token(Token = "0x4006E47")]
		public static readonly LegacySoundStyle NPCDeath17;

		[global::Cpp2ILInjected.Token(Token = "0x4006E48")]
		public static readonly LegacySoundStyle NPCDeath18;

		[global::Cpp2ILInjected.Token(Token = "0x4006E49")]
		public static readonly LegacySoundStyle NPCDeath19;

		[global::Cpp2ILInjected.Token(Token = "0x4006E4A")]
		public static readonly LegacySoundStyle NPCDeath20;

		[global::Cpp2ILInjected.Token(Token = "0x4006E4B")]
		public static readonly LegacySoundStyle NPCDeath21;

		[global::Cpp2ILInjected.Token(Token = "0x4006E4C")]
		public static readonly LegacySoundStyle NPCDeath22;

		[global::Cpp2ILInjected.Token(Token = "0x4006E4D")]
		public static readonly LegacySoundStyle NPCDeath23;

		[global::Cpp2ILInjected.Token(Token = "0x4006E4E")]
		public static readonly LegacySoundStyle NPCDeath24;

		[global::Cpp2ILInjected.Token(Token = "0x4006E4F")]
		public static readonly LegacySoundStyle NPCDeath25;

		[global::Cpp2ILInjected.Token(Token = "0x4006E50")]
		public static readonly LegacySoundStyle NPCDeath26;

		[global::Cpp2ILInjected.Token(Token = "0x4006E51")]
		public static readonly LegacySoundStyle NPCDeath27;

		[global::Cpp2ILInjected.Token(Token = "0x4006E52")]
		public static readonly LegacySoundStyle NPCDeath28;

		[global::Cpp2ILInjected.Token(Token = "0x4006E53")]
		public static readonly LegacySoundStyle NPCDeath29;

		[global::Cpp2ILInjected.Token(Token = "0x4006E54")]
		public static readonly LegacySoundStyle NPCDeath30;

		[global::Cpp2ILInjected.Token(Token = "0x4006E55")]
		public static readonly LegacySoundStyle NPCDeath31;

		[global::Cpp2ILInjected.Token(Token = "0x4006E56")]
		public static readonly LegacySoundStyle NPCDeath32;

		[global::Cpp2ILInjected.Token(Token = "0x4006E57")]
		public static readonly LegacySoundStyle NPCDeath33;

		[global::Cpp2ILInjected.Token(Token = "0x4006E58")]
		public static readonly LegacySoundStyle NPCDeath34;

		[global::Cpp2ILInjected.Token(Token = "0x4006E59")]
		public static readonly LegacySoundStyle NPCDeath35;

		[global::Cpp2ILInjected.Token(Token = "0x4006E5A")]
		public static readonly LegacySoundStyle NPCDeath36;

		[global::Cpp2ILInjected.Token(Token = "0x4006E5B")]
		public static readonly LegacySoundStyle NPCDeath37;

		[global::Cpp2ILInjected.Token(Token = "0x4006E5C")]
		public static readonly LegacySoundStyle NPCDeath38;

		[global::Cpp2ILInjected.Token(Token = "0x4006E5D")]
		public static readonly LegacySoundStyle NPCDeath39;

		[global::Cpp2ILInjected.Token(Token = "0x4006E5E")]
		public static readonly LegacySoundStyle NPCDeath40;

		[global::Cpp2ILInjected.Token(Token = "0x4006E5F")]
		public static readonly LegacySoundStyle NPCDeath41;

		[global::Cpp2ILInjected.Token(Token = "0x4006E60")]
		public static readonly LegacySoundStyle NPCDeath42;

		[global::Cpp2ILInjected.Token(Token = "0x4006E61")]
		public static readonly LegacySoundStyle NPCDeath43;

		[global::Cpp2ILInjected.Token(Token = "0x4006E62")]
		public static readonly LegacySoundStyle NPCDeath44;

		[global::Cpp2ILInjected.Token(Token = "0x4006E63")]
		public static readonly LegacySoundStyle NPCDeath45;

		[global::Cpp2ILInjected.Token(Token = "0x4006E64")]
		public static readonly LegacySoundStyle NPCDeath46;

		[global::Cpp2ILInjected.Token(Token = "0x4006E65")]
		public static readonly LegacySoundStyle NPCDeath47;

		[global::Cpp2ILInjected.Token(Token = "0x4006E66")]
		public static readonly LegacySoundStyle NPCDeath48;

		[global::Cpp2ILInjected.Token(Token = "0x4006E67")]
		public static readonly LegacySoundStyle NPCDeath49;

		[global::Cpp2ILInjected.Token(Token = "0x4006E68")]
		public static readonly LegacySoundStyle NPCDeath50;

		[global::Cpp2ILInjected.Token(Token = "0x4006E69")]
		public static readonly LegacySoundStyle NPCDeath51;

		[global::Cpp2ILInjected.Token(Token = "0x4006E6A")]
		public static readonly LegacySoundStyle NPCDeath52;

		[global::Cpp2ILInjected.Token(Token = "0x4006E6B")]
		public static readonly LegacySoundStyle NPCDeath53;

		[global::Cpp2ILInjected.Token(Token = "0x4006E6C")]
		public static readonly LegacySoundStyle NPCDeath54;

		[global::Cpp2ILInjected.Token(Token = "0x4006E6D")]
		public static readonly LegacySoundStyle NPCDeath55;

		[global::Cpp2ILInjected.Token(Token = "0x4006E6E")]
		public static readonly LegacySoundStyle NPCDeath56;

		[global::Cpp2ILInjected.Token(Token = "0x4006E6F")]
		public static readonly LegacySoundStyle NPCDeath57;

		[global::Cpp2ILInjected.Token(Token = "0x4006E70")]
		public static readonly LegacySoundStyle NPCDeath58;

		[global::Cpp2ILInjected.Token(Token = "0x4006E71")]
		public static readonly LegacySoundStyle NPCDeath59;

		[global::Cpp2ILInjected.Token(Token = "0x4006E72")]
		public static readonly LegacySoundStyle NPCDeath60;

		[global::Cpp2ILInjected.Token(Token = "0x4006E73")]
		public static readonly LegacySoundStyle NPCDeath61;

		[global::Cpp2ILInjected.Token(Token = "0x4006E74")]
		public static readonly LegacySoundStyle NPCDeath62;

		[global::Cpp2ILInjected.Token(Token = "0x4006E75")]
		public static readonly LegacySoundStyle NPCDeath63;

		[global::Cpp2ILInjected.Token(Token = "0x4006E76")]
		public static readonly LegacySoundStyle NPCDeath64;

		[global::Cpp2ILInjected.Token(Token = "0x4006E77")]
		public static readonly LegacySoundStyle NPCDeath65;

		[global::Cpp2ILInjected.Token(Token = "0x4006E78")]
		public static readonly LegacySoundStyle NPCDeath66;

		[global::Cpp2ILInjected.Token(Token = "0x4006E79")]
		public static short NPCDeathCount;

		[global::Cpp2ILInjected.Token(Token = "0x4006E7A")]
		public static readonly LegacySoundStyle Item1;

		[global::Cpp2ILInjected.Token(Token = "0x4006E7B")]
		public static readonly LegacySoundStyle Item2;

		[global::Cpp2ILInjected.Token(Token = "0x4006E7C")]
		public static readonly LegacySoundStyle Item3;

		[global::Cpp2ILInjected.Token(Token = "0x4006E7D")]
		public static readonly LegacySoundStyle Item4;

		[global::Cpp2ILInjected.Token(Token = "0x4006E7E")]
		public static readonly LegacySoundStyle Item5;

		[global::Cpp2ILInjected.Token(Token = "0x4006E7F")]
		public static readonly LegacySoundStyle Item6;

		[global::Cpp2ILInjected.Token(Token = "0x4006E80")]
		public static readonly LegacySoundStyle Item7;

		[global::Cpp2ILInjected.Token(Token = "0x4006E81")]
		public static readonly LegacySoundStyle Item8;

		[global::Cpp2ILInjected.Token(Token = "0x4006E82")]
		public static readonly LegacySoundStyle Item9;

		[global::Cpp2ILInjected.Token(Token = "0x4006E83")]
		public static readonly LegacySoundStyle Item10;

		[global::Cpp2ILInjected.Token(Token = "0x4006E84")]
		public static readonly LegacySoundStyle Item11;

		[global::Cpp2ILInjected.Token(Token = "0x4006E85")]
		public static readonly LegacySoundStyle Item12;

		[global::Cpp2ILInjected.Token(Token = "0x4006E86")]
		public static readonly LegacySoundStyle Item13;

		[global::Cpp2ILInjected.Token(Token = "0x4006E87")]
		public static readonly LegacySoundStyle Item14;

		[global::Cpp2ILInjected.Token(Token = "0x4006E88")]
		public static readonly LegacySoundStyle Item15;

		[global::Cpp2ILInjected.Token(Token = "0x4006E89")]
		public static readonly LegacySoundStyle Item16;

		[global::Cpp2ILInjected.Token(Token = "0x4006E8A")]
		public static readonly LegacySoundStyle Item17;

		[global::Cpp2ILInjected.Token(Token = "0x4006E8B")]
		public static readonly LegacySoundStyle Item18;

		[global::Cpp2ILInjected.Token(Token = "0x4006E8C")]
		public static readonly LegacySoundStyle Item19;

		[global::Cpp2ILInjected.Token(Token = "0x4006E8D")]
		public static readonly LegacySoundStyle Item20;

		[global::Cpp2ILInjected.Token(Token = "0x4006E8E")]
		public static readonly LegacySoundStyle Item21;

		[global::Cpp2ILInjected.Token(Token = "0x4006E8F")]
		public static readonly LegacySoundStyle Item22;

		[global::Cpp2ILInjected.Token(Token = "0x4006E90")]
		public static readonly LegacySoundStyle Item23;

		[global::Cpp2ILInjected.Token(Token = "0x4006E91")]
		public static readonly LegacySoundStyle Item24;

		[global::Cpp2ILInjected.Token(Token = "0x4006E92")]
		public static readonly LegacySoundStyle Item25;

		[global::Cpp2ILInjected.Token(Token = "0x4006E93")]
		public static readonly LegacySoundStyle Item26;

		[global::Cpp2ILInjected.Token(Token = "0x4006E94")]
		public static readonly LegacySoundStyle Item27;

		[global::Cpp2ILInjected.Token(Token = "0x4006E95")]
		public static readonly LegacySoundStyle Item28;

		[global::Cpp2ILInjected.Token(Token = "0x4006E96")]
		public static readonly LegacySoundStyle Item29;

		[global::Cpp2ILInjected.Token(Token = "0x4006E97")]
		public static readonly LegacySoundStyle Item30;

		[global::Cpp2ILInjected.Token(Token = "0x4006E98")]
		public static readonly LegacySoundStyle Item31;

		[global::Cpp2ILInjected.Token(Token = "0x4006E99")]
		public static readonly LegacySoundStyle Item32;

		[global::Cpp2ILInjected.Token(Token = "0x4006E9A")]
		public static readonly LegacySoundStyle Item33;

		[global::Cpp2ILInjected.Token(Token = "0x4006E9B")]
		public static readonly LegacySoundStyle Item34;

		[global::Cpp2ILInjected.Token(Token = "0x4006E9C")]
		public static readonly LegacySoundStyle Item35;

		[global::Cpp2ILInjected.Token(Token = "0x4006E9D")]
		public static readonly LegacySoundStyle Item36;

		[global::Cpp2ILInjected.Token(Token = "0x4006E9E")]
		public static readonly LegacySoundStyle Item37;

		[global::Cpp2ILInjected.Token(Token = "0x4006E9F")]
		public static readonly LegacySoundStyle Item38;

		[global::Cpp2ILInjected.Token(Token = "0x4006EA0")]
		public static readonly LegacySoundStyle Item39;

		[global::Cpp2ILInjected.Token(Token = "0x4006EA1")]
		public static readonly LegacySoundStyle Item40;

		[global::Cpp2ILInjected.Token(Token = "0x4006EA2")]
		public static readonly LegacySoundStyle Item41;

		[global::Cpp2ILInjected.Token(Token = "0x4006EA3")]
		public static readonly LegacySoundStyle Item42;

		[global::Cpp2ILInjected.Token(Token = "0x4006EA4")]
		public static readonly LegacySoundStyle Item43;

		[global::Cpp2ILInjected.Token(Token = "0x4006EA5")]
		public static readonly LegacySoundStyle Item44;

		[global::Cpp2ILInjected.Token(Token = "0x4006EA6")]
		public static readonly LegacySoundStyle Item45;

		[global::Cpp2ILInjected.Token(Token = "0x4006EA7")]
		public static readonly LegacySoundStyle Item46;

		[global::Cpp2ILInjected.Token(Token = "0x4006EA8")]
		public static readonly LegacySoundStyle Item47;

		[global::Cpp2ILInjected.Token(Token = "0x4006EA9")]
		public static readonly LegacySoundStyle Item48;

		[global::Cpp2ILInjected.Token(Token = "0x4006EAA")]
		public static readonly LegacySoundStyle Item49;

		[global::Cpp2ILInjected.Token(Token = "0x4006EAB")]
		public static readonly LegacySoundStyle Item50;

		[global::Cpp2ILInjected.Token(Token = "0x4006EAC")]
		public static readonly LegacySoundStyle Item51;

		[global::Cpp2ILInjected.Token(Token = "0x4006EAD")]
		public static readonly LegacySoundStyle Item52;

		[global::Cpp2ILInjected.Token(Token = "0x4006EAE")]
		public static readonly LegacySoundStyle Item53;

		[global::Cpp2ILInjected.Token(Token = "0x4006EAF")]
		public static readonly LegacySoundStyle Item54;

		[global::Cpp2ILInjected.Token(Token = "0x4006EB0")]
		public static readonly LegacySoundStyle Item55;

		[global::Cpp2ILInjected.Token(Token = "0x4006EB1")]
		public static readonly LegacySoundStyle Item56;

		[global::Cpp2ILInjected.Token(Token = "0x4006EB2")]
		public static readonly LegacySoundStyle Item57;

		[global::Cpp2ILInjected.Token(Token = "0x4006EB3")]
		public static readonly LegacySoundStyle Item58;

		[global::Cpp2ILInjected.Token(Token = "0x4006EB4")]
		public static readonly LegacySoundStyle Item59;

		[global::Cpp2ILInjected.Token(Token = "0x4006EB5")]
		public static readonly LegacySoundStyle Item60;

		[global::Cpp2ILInjected.Token(Token = "0x4006EB6")]
		public static readonly LegacySoundStyle Item61;

		[global::Cpp2ILInjected.Token(Token = "0x4006EB7")]
		public static readonly LegacySoundStyle Item62;

		[global::Cpp2ILInjected.Token(Token = "0x4006EB8")]
		public static readonly LegacySoundStyle Item63;

		[global::Cpp2ILInjected.Token(Token = "0x4006EB9")]
		public static readonly LegacySoundStyle Item64;

		[global::Cpp2ILInjected.Token(Token = "0x4006EBA")]
		public static readonly LegacySoundStyle Item65;

		[global::Cpp2ILInjected.Token(Token = "0x4006EBB")]
		public static readonly LegacySoundStyle Item66;

		[global::Cpp2ILInjected.Token(Token = "0x4006EBC")]
		public static readonly LegacySoundStyle Item67;

		[global::Cpp2ILInjected.Token(Token = "0x4006EBD")]
		public static readonly LegacySoundStyle Item68;

		[global::Cpp2ILInjected.Token(Token = "0x4006EBE")]
		public static readonly LegacySoundStyle Item69;

		[global::Cpp2ILInjected.Token(Token = "0x4006EBF")]
		public static readonly LegacySoundStyle Item70;

		[global::Cpp2ILInjected.Token(Token = "0x4006EC0")]
		public static readonly LegacySoundStyle Item71;

		[global::Cpp2ILInjected.Token(Token = "0x4006EC1")]
		public static readonly LegacySoundStyle Item72;

		[global::Cpp2ILInjected.Token(Token = "0x4006EC2")]
		public static readonly LegacySoundStyle Item73;

		[global::Cpp2ILInjected.Token(Token = "0x4006EC3")]
		public static readonly LegacySoundStyle Item74;

		[global::Cpp2ILInjected.Token(Token = "0x4006EC4")]
		public static readonly LegacySoundStyle Item75;

		[global::Cpp2ILInjected.Token(Token = "0x4006EC5")]
		public static readonly LegacySoundStyle Item76;

		[global::Cpp2ILInjected.Token(Token = "0x4006EC6")]
		public static readonly LegacySoundStyle Item77;

		[global::Cpp2ILInjected.Token(Token = "0x4006EC7")]
		public static readonly LegacySoundStyle Item78;

		[global::Cpp2ILInjected.Token(Token = "0x4006EC8")]
		public static readonly LegacySoundStyle Item79;

		[global::Cpp2ILInjected.Token(Token = "0x4006EC9")]
		public static readonly LegacySoundStyle Item80;

		[global::Cpp2ILInjected.Token(Token = "0x4006ECA")]
		public static readonly LegacySoundStyle Item81;

		[global::Cpp2ILInjected.Token(Token = "0x4006ECB")]
		public static readonly LegacySoundStyle Item82;

		[global::Cpp2ILInjected.Token(Token = "0x4006ECC")]
		public static readonly LegacySoundStyle Item83;

		[global::Cpp2ILInjected.Token(Token = "0x4006ECD")]
		public static readonly LegacySoundStyle Item84;

		[global::Cpp2ILInjected.Token(Token = "0x4006ECE")]
		public static readonly LegacySoundStyle Item85;

		[global::Cpp2ILInjected.Token(Token = "0x4006ECF")]
		public static readonly LegacySoundStyle Item86;

		[global::Cpp2ILInjected.Token(Token = "0x4006ED0")]
		public static readonly LegacySoundStyle Item87;

		[global::Cpp2ILInjected.Token(Token = "0x4006ED1")]
		public static readonly LegacySoundStyle Item88;

		[global::Cpp2ILInjected.Token(Token = "0x4006ED2")]
		public static readonly LegacySoundStyle Item89;

		[global::Cpp2ILInjected.Token(Token = "0x4006ED3")]
		public static readonly LegacySoundStyle Item90;

		[global::Cpp2ILInjected.Token(Token = "0x4006ED4")]
		public static readonly LegacySoundStyle Item91;

		[global::Cpp2ILInjected.Token(Token = "0x4006ED5")]
		public static readonly LegacySoundStyle Item92;

		[global::Cpp2ILInjected.Token(Token = "0x4006ED6")]
		public static readonly LegacySoundStyle Item93;

		[global::Cpp2ILInjected.Token(Token = "0x4006ED7")]
		public static readonly LegacySoundStyle Item94;

		[global::Cpp2ILInjected.Token(Token = "0x4006ED8")]
		public static readonly LegacySoundStyle Item95;

		[global::Cpp2ILInjected.Token(Token = "0x4006ED9")]
		public static readonly LegacySoundStyle Item96;

		[global::Cpp2ILInjected.Token(Token = "0x4006EDA")]
		public static readonly LegacySoundStyle Item97;

		[global::Cpp2ILInjected.Token(Token = "0x4006EDB")]
		public static readonly LegacySoundStyle Item98;

		[global::Cpp2ILInjected.Token(Token = "0x4006EDC")]
		public static readonly LegacySoundStyle Item99;

		[global::Cpp2ILInjected.Token(Token = "0x4006EDD")]
		public static readonly LegacySoundStyle Item100;

		[global::Cpp2ILInjected.Token(Token = "0x4006EDE")]
		public static readonly LegacySoundStyle Item101;

		[global::Cpp2ILInjected.Token(Token = "0x4006EDF")]
		public static readonly LegacySoundStyle Item102;

		[global::Cpp2ILInjected.Token(Token = "0x4006EE0")]
		public static readonly LegacySoundStyle Item103;

		[global::Cpp2ILInjected.Token(Token = "0x4006EE1")]
		public static readonly LegacySoundStyle Item104;

		[global::Cpp2ILInjected.Token(Token = "0x4006EE2")]
		public static readonly LegacySoundStyle Item105;

		[global::Cpp2ILInjected.Token(Token = "0x4006EE3")]
		public static readonly LegacySoundStyle Item106;

		[global::Cpp2ILInjected.Token(Token = "0x4006EE4")]
		public static readonly LegacySoundStyle Item107;

		[global::Cpp2ILInjected.Token(Token = "0x4006EE5")]
		public static readonly LegacySoundStyle Item108;

		[global::Cpp2ILInjected.Token(Token = "0x4006EE6")]
		public static readonly LegacySoundStyle Item109;

		[global::Cpp2ILInjected.Token(Token = "0x4006EE7")]
		public static readonly LegacySoundStyle Item110;

		[global::Cpp2ILInjected.Token(Token = "0x4006EE8")]
		public static readonly LegacySoundStyle Item111;

		[global::Cpp2ILInjected.Token(Token = "0x4006EE9")]
		public static readonly LegacySoundStyle Item112;

		[global::Cpp2ILInjected.Token(Token = "0x4006EEA")]
		public static readonly LegacySoundStyle Item113;

		[global::Cpp2ILInjected.Token(Token = "0x4006EEB")]
		public static readonly LegacySoundStyle Item114;

		[global::Cpp2ILInjected.Token(Token = "0x4006EEC")]
		public static readonly LegacySoundStyle Item115;

		[global::Cpp2ILInjected.Token(Token = "0x4006EED")]
		public static readonly LegacySoundStyle Item116;

		[global::Cpp2ILInjected.Token(Token = "0x4006EEE")]
		public static readonly LegacySoundStyle Item117;

		[global::Cpp2ILInjected.Token(Token = "0x4006EEF")]
		public static readonly LegacySoundStyle Item118;

		[global::Cpp2ILInjected.Token(Token = "0x4006EF0")]
		public static readonly LegacySoundStyle Item119;

		[global::Cpp2ILInjected.Token(Token = "0x4006EF1")]
		public static readonly LegacySoundStyle Item120;

		[global::Cpp2ILInjected.Token(Token = "0x4006EF2")]
		public static readonly LegacySoundStyle Item121;

		[global::Cpp2ILInjected.Token(Token = "0x4006EF3")]
		public static readonly LegacySoundStyle Item122;

		[global::Cpp2ILInjected.Token(Token = "0x4006EF4")]
		public static readonly LegacySoundStyle Item123;

		[global::Cpp2ILInjected.Token(Token = "0x4006EF5")]
		public static readonly LegacySoundStyle Item124;

		[global::Cpp2ILInjected.Token(Token = "0x4006EF6")]
		public static readonly LegacySoundStyle Item125;

		[global::Cpp2ILInjected.Token(Token = "0x4006EF7")]
		public static readonly LegacySoundStyle Item126;

		[global::Cpp2ILInjected.Token(Token = "0x4006EF8")]
		public static readonly LegacySoundStyle Item127;

		[global::Cpp2ILInjected.Token(Token = "0x4006EF9")]
		public static readonly LegacySoundStyle Item128;

		[global::Cpp2ILInjected.Token(Token = "0x4006EFA")]
		public static readonly LegacySoundStyle Item129;

		[global::Cpp2ILInjected.Token(Token = "0x4006EFB")]
		public static readonly LegacySoundStyle Item130;

		[global::Cpp2ILInjected.Token(Token = "0x4006EFC")]
		public static readonly LegacySoundStyle Item131;

		[global::Cpp2ILInjected.Token(Token = "0x4006EFD")]
		public static readonly LegacySoundStyle Item132;

		[global::Cpp2ILInjected.Token(Token = "0x4006EFE")]
		public static readonly LegacySoundStyle Item133;

		[global::Cpp2ILInjected.Token(Token = "0x4006EFF")]
		public static readonly LegacySoundStyle Item134;

		[global::Cpp2ILInjected.Token(Token = "0x4006F00")]
		public static readonly LegacySoundStyle Item135;

		[global::Cpp2ILInjected.Token(Token = "0x4006F01")]
		public static readonly LegacySoundStyle Item136;

		[global::Cpp2ILInjected.Token(Token = "0x4006F02")]
		public static readonly LegacySoundStyle Item137;

		[global::Cpp2ILInjected.Token(Token = "0x4006F03")]
		public static readonly LegacySoundStyle Item138;

		[global::Cpp2ILInjected.Token(Token = "0x4006F04")]
		public static readonly LegacySoundStyle Item139;

		[global::Cpp2ILInjected.Token(Token = "0x4006F05")]
		public static readonly LegacySoundStyle Item140;

		[global::Cpp2ILInjected.Token(Token = "0x4006F06")]
		public static readonly LegacySoundStyle Item141;

		[global::Cpp2ILInjected.Token(Token = "0x4006F07")]
		public static readonly LegacySoundStyle Item142;

		[global::Cpp2ILInjected.Token(Token = "0x4006F08")]
		public static readonly LegacySoundStyle Item143;

		[global::Cpp2ILInjected.Token(Token = "0x4006F09")]
		public static readonly LegacySoundStyle Item144;

		[global::Cpp2ILInjected.Token(Token = "0x4006F0A")]
		public static readonly LegacySoundStyle Item145;

		[global::Cpp2ILInjected.Token(Token = "0x4006F0B")]
		public static readonly LegacySoundStyle Item146;

		[global::Cpp2ILInjected.Token(Token = "0x4006F0C")]
		public static readonly LegacySoundStyle Item147;

		[global::Cpp2ILInjected.Token(Token = "0x4006F0D")]
		public static readonly LegacySoundStyle Item148;

		[global::Cpp2ILInjected.Token(Token = "0x4006F0E")]
		public static readonly LegacySoundStyle Item149;

		[global::Cpp2ILInjected.Token(Token = "0x4006F0F")]
		public static readonly LegacySoundStyle Item150;

		[global::Cpp2ILInjected.Token(Token = "0x4006F10")]
		public static readonly LegacySoundStyle Item151;

		[global::Cpp2ILInjected.Token(Token = "0x4006F11")]
		public static readonly LegacySoundStyle Item152;

		[global::Cpp2ILInjected.Token(Token = "0x4006F12")]
		public static readonly LegacySoundStyle Item153;

		[global::Cpp2ILInjected.Token(Token = "0x4006F13")]
		public static readonly LegacySoundStyle Item154;

		[global::Cpp2ILInjected.Token(Token = "0x4006F14")]
		public static readonly LegacySoundStyle Item155;

		[global::Cpp2ILInjected.Token(Token = "0x4006F15")]
		public static readonly LegacySoundStyle Item156;

		[global::Cpp2ILInjected.Token(Token = "0x4006F16")]
		public static readonly LegacySoundStyle Item157;

		[global::Cpp2ILInjected.Token(Token = "0x4006F17")]
		public static readonly LegacySoundStyle Item158;

		[global::Cpp2ILInjected.Token(Token = "0x4006F18")]
		public static readonly LegacySoundStyle Item159;

		[global::Cpp2ILInjected.Token(Token = "0x4006F19")]
		public static readonly LegacySoundStyle Item160;

		[global::Cpp2ILInjected.Token(Token = "0x4006F1A")]
		public static readonly LegacySoundStyle Item161;

		[global::Cpp2ILInjected.Token(Token = "0x4006F1B")]
		public static readonly LegacySoundStyle Item162;

		[global::Cpp2ILInjected.Token(Token = "0x4006F1C")]
		public static readonly LegacySoundStyle Item163;

		[global::Cpp2ILInjected.Token(Token = "0x4006F1D")]
		public static readonly LegacySoundStyle Item164;

		[global::Cpp2ILInjected.Token(Token = "0x4006F1E")]
		public static readonly LegacySoundStyle Item165;

		[global::Cpp2ILInjected.Token(Token = "0x4006F1F")]
		public static readonly LegacySoundStyle Item166;

		[global::Cpp2ILInjected.Token(Token = "0x4006F20")]
		public static readonly LegacySoundStyle Item167;

		[global::Cpp2ILInjected.Token(Token = "0x4006F21")]
		public static readonly LegacySoundStyle Item168;

		[global::Cpp2ILInjected.Token(Token = "0x4006F22")]
		public static readonly LegacySoundStyle Item169;

		[global::Cpp2ILInjected.Token(Token = "0x4006F23")]
		public static readonly LegacySoundStyle Item170;

		[global::Cpp2ILInjected.Token(Token = "0x4006F24")]
		public static readonly LegacySoundStyle Item171;

		[global::Cpp2ILInjected.Token(Token = "0x4006F25")]
		public static readonly LegacySoundStyle Item172;

		[global::Cpp2ILInjected.Token(Token = "0x4006F26")]
		public static readonly LegacySoundStyle Item173;

		[global::Cpp2ILInjected.Token(Token = "0x4006F27")]
		public static readonly LegacySoundStyle Item174;

		[global::Cpp2ILInjected.Token(Token = "0x4006F28")]
		public static readonly LegacySoundStyle Item175;

		[global::Cpp2ILInjected.Token(Token = "0x4006F29")]
		public static readonly LegacySoundStyle Item176;

		[global::Cpp2ILInjected.Token(Token = "0x4006F2A")]
		public static readonly LegacySoundStyle Item177;

		[global::Cpp2ILInjected.Token(Token = "0x4006F2B")]
		public static readonly LegacySoundStyle Item178;

		[global::Cpp2ILInjected.Token(Token = "0x4006F2C")]
		public static short ItemSoundCount;

		[global::Cpp2ILInjected.Token(Token = "0x4006F2D")]
		public static readonly LegacySoundStyle DD2_GoblinBomb;

		[global::Cpp2ILInjected.Token(Token = "0x4006F2E")]
		public static readonly LegacySoundStyle AchievementComplete;

		[global::Cpp2ILInjected.Token(Token = "0x4006F2F")]
		public static readonly LegacySoundStyle BlizzardInsideBuildingLoop;

		[global::Cpp2ILInjected.Token(Token = "0x4006F30")]
		public static readonly LegacySoundStyle BlizzardStrongLoop;

		[global::Cpp2ILInjected.Token(Token = "0x4006F31")]
		public static readonly LegacySoundStyle LiquidsHoneyWater;

		[global::Cpp2ILInjected.Token(Token = "0x4006F32")]
		public static readonly LegacySoundStyle LiquidsHoneyLava;

		[global::Cpp2ILInjected.Token(Token = "0x4006F33")]
		public static readonly LegacySoundStyle LiquidsWaterLava;

		[global::Cpp2ILInjected.Token(Token = "0x4006F34")]
		public static readonly LegacySoundStyle DD2_BallistaTowerShot;

		[global::Cpp2ILInjected.Token(Token = "0x4006F35")]
		public static readonly LegacySoundStyle DD2_ExplosiveTrapExplode;

		[global::Cpp2ILInjected.Token(Token = "0x4006F36")]
		public static readonly LegacySoundStyle DD2_FlameburstTowerShot;

		[global::Cpp2ILInjected.Token(Token = "0x4006F37")]
		public static readonly LegacySoundStyle DD2_LightningAuraZap;

		[global::Cpp2ILInjected.Token(Token = "0x4006F38")]
		public static readonly LegacySoundStyle DD2_DefenseTowerSpawn;

		[global::Cpp2ILInjected.Token(Token = "0x4006F39")]
		public static readonly LegacySoundStyle DD2_BetsyDeath;

		[global::Cpp2ILInjected.Token(Token = "0x4006F3A")]
		public static readonly LegacySoundStyle DD2_BetsyFireballShot;

		[global::Cpp2ILInjected.Token(Token = "0x4006F3B")]
		public static readonly LegacySoundStyle DD2_BetsyFireballImpact;

		[global::Cpp2ILInjected.Token(Token = "0x4006F3C")]
		public static readonly LegacySoundStyle DD2_BetsyFlameBreath;

		[global::Cpp2ILInjected.Token(Token = "0x4006F3D")]
		public static readonly LegacySoundStyle DD2_BetsyFlyingCircleAttack;

		[global::Cpp2ILInjected.Token(Token = "0x4006F3E")]
		public static readonly LegacySoundStyle DD2_BetsyHurt;

		[global::Cpp2ILInjected.Token(Token = "0x4006F3F")]
		public static readonly LegacySoundStyle DD2_BetsyScream;

		[global::Cpp2ILInjected.Token(Token = "0x4006F40")]
		public static readonly LegacySoundStyle DD2_BetsySummon;

		[global::Cpp2ILInjected.Token(Token = "0x4006F41")]
		public static readonly LegacySoundStyle DD2_BetsyWindAttack;

		[global::Cpp2ILInjected.Token(Token = "0x4006F42")]
		public static readonly LegacySoundStyle DD2_DarkMageAttack;

		[global::Cpp2ILInjected.Token(Token = "0x4006F43")]
		public static readonly LegacySoundStyle DD2_DarkMageCastHeal;

		[global::Cpp2ILInjected.Token(Token = "0x4006F44")]
		public static readonly LegacySoundStyle DD2_DarkMageDeath;

		[global::Cpp2ILInjected.Token(Token = "0x4006F45")]
		public static readonly LegacySoundStyle DD2_DarkMageHealImpact;

		[global::Cpp2ILInjected.Token(Token = "0x4006F46")]
		public static readonly LegacySoundStyle DD2_DarkMageHurt;

		[global::Cpp2ILInjected.Token(Token = "0x4006F47")]
		public static readonly LegacySoundStyle DD2_DarkMageSummonSkeleton;

		[global::Cpp2ILInjected.Token(Token = "0x4006F48")]
		public static readonly LegacySoundStyle DD2_DrakinBreathIn;

		[global::Cpp2ILInjected.Token(Token = "0x4006F49")]
		public static readonly LegacySoundStyle DD2_DrakinDeath;

		[global::Cpp2ILInjected.Token(Token = "0x4006F4A")]
		public static readonly LegacySoundStyle DD2_DrakinHurt;

		[global::Cpp2ILInjected.Token(Token = "0x4006F4B")]
		public static readonly LegacySoundStyle DD2_DrakinShot;

		[global::Cpp2ILInjected.Token(Token = "0x4006F4C")]
		public static readonly LegacySoundStyle DD2_GoblinDeath;

		[global::Cpp2ILInjected.Token(Token = "0x4006F4D")]
		public static readonly LegacySoundStyle DD2_GoblinHurt;

		[global::Cpp2ILInjected.Token(Token = "0x4006F4E")]
		public static readonly LegacySoundStyle DD2_GoblinScream;

		[global::Cpp2ILInjected.Token(Token = "0x4006F4F")]
		public static readonly LegacySoundStyle DD2_GoblinBomberDeath;

		[global::Cpp2ILInjected.Token(Token = "0x4006F50")]
		public static readonly LegacySoundStyle DD2_GoblinBomberHurt;

		[global::Cpp2ILInjected.Token(Token = "0x4006F51")]
		public static readonly LegacySoundStyle DD2_GoblinBomberScream;

		[global::Cpp2ILInjected.Token(Token = "0x4006F52")]
		public static readonly LegacySoundStyle DD2_GoblinBomberThrow;

		[global::Cpp2ILInjected.Token(Token = "0x4006F53")]
		public static readonly LegacySoundStyle DD2_JavelinThrowersAttack;

		[global::Cpp2ILInjected.Token(Token = "0x4006F54")]
		public static readonly LegacySoundStyle DD2_JavelinThrowersDeath;

		[global::Cpp2ILInjected.Token(Token = "0x4006F55")]
		public static readonly LegacySoundStyle DD2_JavelinThrowersHurt;

		[global::Cpp2ILInjected.Token(Token = "0x4006F56")]
		public static readonly LegacySoundStyle DD2_JavelinThrowersTaunt;

		[global::Cpp2ILInjected.Token(Token = "0x4006F57")]
		public static readonly LegacySoundStyle DD2_KoboldDeath;

		[global::Cpp2ILInjected.Token(Token = "0x4006F58")]
		public static readonly LegacySoundStyle DD2_KoboldExplosion;

		[global::Cpp2ILInjected.Token(Token = "0x4006F59")]
		public static readonly LegacySoundStyle DD2_KoboldHurt;

		[global::Cpp2ILInjected.Token(Token = "0x4006F5A")]
		public static readonly LegacySoundStyle DD2_KoboldIgnite;

		[global::Cpp2ILInjected.Token(Token = "0x4006F5B")]
		public static readonly LegacySoundStyle DD2_KoboldIgniteLoop;

		[global::Cpp2ILInjected.Token(Token = "0x4006F5C")]
		public static readonly LegacySoundStyle DD2_KoboldScreamChargeLoop;

		[global::Cpp2ILInjected.Token(Token = "0x4006F5D")]
		public static readonly LegacySoundStyle DD2_KoboldFlyerChargeScream;

		[global::Cpp2ILInjected.Token(Token = "0x4006F5E")]
		public static readonly LegacySoundStyle DD2_KoboldFlyerDeath;

		[global::Cpp2ILInjected.Token(Token = "0x4006F5F")]
		public static readonly LegacySoundStyle DD2_KoboldFlyerHurt;

		[global::Cpp2ILInjected.Token(Token = "0x4006F60")]
		public static readonly LegacySoundStyle DD2_LightningBugDeath;

		[global::Cpp2ILInjected.Token(Token = "0x4006F61")]
		public static readonly LegacySoundStyle DD2_LightningBugHurt;

		[global::Cpp2ILInjected.Token(Token = "0x4006F62")]
		public static readonly LegacySoundStyle DD2_LightningBugZap;

		[global::Cpp2ILInjected.Token(Token = "0x4006F63")]
		public static readonly LegacySoundStyle DD2_OgreAttack;

		[global::Cpp2ILInjected.Token(Token = "0x4006F64")]
		public static readonly LegacySoundStyle DD2_OgreDeath;

		[global::Cpp2ILInjected.Token(Token = "0x4006F65")]
		public static readonly LegacySoundStyle DD2_OgreGroundPound;

		[global::Cpp2ILInjected.Token(Token = "0x4006F66")]
		public static readonly LegacySoundStyle DD2_OgreHurt;

		[global::Cpp2ILInjected.Token(Token = "0x4006F67")]
		public static readonly LegacySoundStyle DD2_OgreRoar;

		[global::Cpp2ILInjected.Token(Token = "0x4006F68")]
		public static readonly LegacySoundStyle DD2_OgreSpit;

		[global::Cpp2ILInjected.Token(Token = "0x4006F69")]
		public static readonly LegacySoundStyle DD2_SkeletonDeath;

		[global::Cpp2ILInjected.Token(Token = "0x4006F6A")]
		public static readonly LegacySoundStyle DD2_SkeletonHurt;

		[global::Cpp2ILInjected.Token(Token = "0x4006F6B")]
		public static readonly LegacySoundStyle DD2_SkeletonSummoned;

		[global::Cpp2ILInjected.Token(Token = "0x4006F6C")]
		public static readonly LegacySoundStyle DD2_WitherBeastAuraPulse;

		[global::Cpp2ILInjected.Token(Token = "0x4006F6D")]
		public static readonly LegacySoundStyle DD2_WitherBeastCrystalImpact;

		[global::Cpp2ILInjected.Token(Token = "0x4006F6E")]
		public static readonly LegacySoundStyle DD2_WitherBeastDeath;

		[global::Cpp2ILInjected.Token(Token = "0x4006F6F")]
		public static readonly LegacySoundStyle DD2_WitherBeastHurt;

		[global::Cpp2ILInjected.Token(Token = "0x4006F70")]
		public static readonly LegacySoundStyle DD2_WyvernDeath;

		[global::Cpp2ILInjected.Token(Token = "0x4006F71")]
		public static readonly LegacySoundStyle DD2_WyvernHurt;

		[global::Cpp2ILInjected.Token(Token = "0x4006F72")]
		public static readonly LegacySoundStyle DD2_WyvernScream;

		[global::Cpp2ILInjected.Token(Token = "0x4006F73")]
		public static readonly LegacySoundStyle DD2_WyvernDiveDown;

		[global::Cpp2ILInjected.Token(Token = "0x4006F74")]
		public static readonly LegacySoundStyle DD2_EtherianPortalDryadTouch;

		[global::Cpp2ILInjected.Token(Token = "0x4006F75")]
		public static readonly LegacySoundStyle DD2_EtherianPortalIdleLoop;

		[global::Cpp2ILInjected.Token(Token = "0x4006F76")]
		public static readonly LegacySoundStyle DD2_EtherianPortalOpen;

		[global::Cpp2ILInjected.Token(Token = "0x4006F77")]
		public static readonly LegacySoundStyle DD2_EtherianPortalSpawnEnemy;

		[global::Cpp2ILInjected.Token(Token = "0x4006F78")]
		public static readonly LegacySoundStyle DD2_CrystalCartImpact;

		[global::Cpp2ILInjected.Token(Token = "0x4006F79")]
		public static readonly LegacySoundStyle DD2_DefeatScene;

		[global::Cpp2ILInjected.Token(Token = "0x4006F7A")]
		public static readonly LegacySoundStyle DD2_WinScene;

		[global::Cpp2ILInjected.Token(Token = "0x4006F7B")]
		public static readonly LegacySoundStyle DD2_BetsysWrathShot;

		[global::Cpp2ILInjected.Token(Token = "0x4006F7C")]
		public static readonly LegacySoundStyle DD2_BetsysWrathImpact;

		[global::Cpp2ILInjected.Token(Token = "0x4006F7D")]
		public static readonly LegacySoundStyle DD2_BookStaffCast;

		[global::Cpp2ILInjected.Token(Token = "0x4006F7E")]
		public static readonly LegacySoundStyle DD2_BookStaffTwisterLoop;

		[global::Cpp2ILInjected.Token(Token = "0x4006F7F")]
		public static readonly LegacySoundStyle DD2_GhastlyGlaiveImpactGhost;

		[global::Cpp2ILInjected.Token(Token = "0x4006F80")]
		public static readonly LegacySoundStyle DD2_GhastlyGlaivePierce;

		[global::Cpp2ILInjected.Token(Token = "0x4006F81")]
		public static readonly LegacySoundStyle DD2_MonkStaffGroundImpact;

		[global::Cpp2ILInjected.Token(Token = "0x4006F82")]
		public static readonly LegacySoundStyle DD2_MonkStaffGroundMiss;

		[global::Cpp2ILInjected.Token(Token = "0x4006F83")]
		public static readonly LegacySoundStyle DD2_MonkStaffSwing;

		[global::Cpp2ILInjected.Token(Token = "0x4006F84")]
		public static readonly LegacySoundStyle DD2_PhantomPhoenixShot;

		[global::Cpp2ILInjected.Token(Token = "0x4006F85")]
		public static readonly LegacySoundStyle DD2_SonicBoomBladeSlash;

		[global::Cpp2ILInjected.Token(Token = "0x4006F86")]
		public static readonly LegacySoundStyle DD2_SkyDragonsFuryCircle;

		[global::Cpp2ILInjected.Token(Token = "0x4006F87")]
		public static readonly LegacySoundStyle DD2_SkyDragonsFuryShot;

		[global::Cpp2ILInjected.Token(Token = "0x4006F88")]
		public static readonly LegacySoundStyle DD2_SkyDragonsFurySwing;

		[global::Cpp2ILInjected.Token(Token = "0x4006F89")]
		public static readonly LegacySoundStyle LucyTheAxeTalk;

		[global::Cpp2ILInjected.Token(Token = "0x4006F8A")]
		public static readonly LegacySoundStyle DeerclopsHit;

		[global::Cpp2ILInjected.Token(Token = "0x4006F8B")]
		public static readonly LegacySoundStyle DeerclopsDeath;

		[global::Cpp2ILInjected.Token(Token = "0x4006F8C")]
		public static readonly LegacySoundStyle DeerclopsScream;

		[global::Cpp2ILInjected.Token(Token = "0x4006F8D")]
		public static readonly LegacySoundStyle DeerclopsIceAttack;

		[global::Cpp2ILInjected.Token(Token = "0x4006F8E")]
		public static readonly LegacySoundStyle DeerclopsRubbleAttack;

		[global::Cpp2ILInjected.Token(Token = "0x4006F8F")]
		public static readonly LegacySoundStyle DeerclopsStep;

		[global::Cpp2ILInjected.Token(Token = "0x4006F90")]
		public static readonly LegacySoundStyle ChesterOpen;

		[global::Cpp2ILInjected.Token(Token = "0x4006F91")]
		public static readonly LegacySoundStyle ChesterClose;

		[global::Cpp2ILInjected.Token(Token = "0x4006F92")]
		public static readonly LegacySoundStyle AbigailSummon;

		[global::Cpp2ILInjected.Token(Token = "0x4006F93")]
		public static readonly LegacySoundStyle AbigailCry;

		[global::Cpp2ILInjected.Token(Token = "0x4006F94")]
		public static readonly LegacySoundStyle AbigailAttack;

		[global::Cpp2ILInjected.Token(Token = "0x4006F95")]
		public static readonly LegacySoundStyle AbigailUpgrade;

		[global::Cpp2ILInjected.Token(Token = "0x4006F96")]
		public static readonly LegacySoundStyle GlommerBounce;

		[global::Cpp2ILInjected.Token(Token = "0x4006F97")]
		public static readonly LegacySoundStyle DSTMaleHurt;

		[global::Cpp2ILInjected.Token(Token = "0x4006F98")]
		public static readonly LegacySoundStyle DSTFemaleHurt;

		[global::Cpp2ILInjected.Token(Token = "0x4006F99")]
		public static readonly LegacySoundStyle JimsDrone;

		[global::Cpp2ILInjected.Token(Token = "0x4006F9A")]
		private static List<string> _trackableLegacySoundPathList;

		[global::Cpp2ILInjected.Token(Token = "0x4006F9B")]
		public static Dictionary<string, LegacySoundStyle> SoundByName;

		[global::Cpp2ILInjected.Token(Token = "0x4006F9C")]
		public static Dictionary<string, ushort> IndexByName;

		[global::Cpp2ILInjected.Token(Token = "0x4006F9D")]
		public static Dictionary<ushort, LegacySoundStyle> SoundByIndex;

		[global::Cpp2ILInjected.Token(Token = "0x20005F0")]
		private struct SoundStyleDefaults
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003594")]
			[global::Cpp2ILInjected.Address(RVA = "0x13D4D80", Offset = "0x13D4D80", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public SoundStyleDefaults(float volume, float pitchVariance, SoundType type = SoundType.Sound)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4006F9E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly float PitchVariance;

			[global::Cpp2ILInjected.Token(Token = "0x4006F9F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public readonly float Volume;

			[global::Cpp2ILInjected.Token(Token = "0x4006FA0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly SoundType Type;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20005F1")]
		private sealed class <>c__DisplayClass495_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003595")]
			[global::Cpp2ILInjected.Address(RVA = "0x13D0430", Offset = "0x13D0430", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass495_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003596")]
			[global::Cpp2ILInjected.Address(RVA = "0x13D4D8C", Offset = "0x13D4D8C", Length = "0x1A4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, ushort>), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ushort)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ushort, object>), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(ushort),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal void <FillAccessMap>b__2(FieldInfo field)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4006FA1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Dictionary<string, LegacySoundStyle> ret;

			[global::Cpp2ILInjected.Token(Token = "0x4006FA2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Dictionary<string, ushort> ret2;

			[global::Cpp2ILInjected.Token(Token = "0x4006FA3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public ushort nextIndex;

			[global::Cpp2ILInjected.Token(Token = "0x4006FA4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public Dictionary<ushort, LegacySoundStyle> ret3;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20005F2")]
		[Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003597")]
			[global::Cpp2ILInjected.Address(RVA = "0x13D4F30", Offset = "0x13D4F30", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003598")]
			[global::Cpp2ILInjected.Address(RVA = "0x13D4F8C", Offset = "0x13D4F8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003599")]
			[global::Cpp2ILInjected.Address(RVA = "0x13D4F94", Offset = "0x13D4F94", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal bool <FillAccessMap>b__495_0(FieldInfo f)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600359A")]
			[global::Cpp2ILInjected.Address(RVA = "0x13D5038", Offset = "0x13D5038", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(int))]
			internal int <FillAccessMap>b__495_1(FieldInfo a, FieldInfo b)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4006FA5")]
			public static readonly SoundID.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x4006FA6")]
			public static Func<FieldInfo, bool> <>9__495_0;

			[global::Cpp2ILInjected.Token(Token = "0x4006FA7")]
			public static Comparison<FieldInfo> <>9__495_1;
		}
	}
}
