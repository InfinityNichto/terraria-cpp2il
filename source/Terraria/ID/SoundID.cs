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
	// Token: 0x02000403 RID: 1027
	[global::Cpp2ILInjected.Token(Token = "0x20005EF")]
	public class SoundID
	{
		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06003082 RID: 12418 RVA: 0x0002AAD0 File Offset: 0x00028CD0
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

		// Token: 0x06003083 RID: 12419 RVA: 0x0002AAD3 File Offset: 0x00028CD3
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

		// Token: 0x06003084 RID: 12420 RVA: 0x0002AAD6 File Offset: 0x00028CD6
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

		// Token: 0x06003085 RID: 12421 RVA: 0x0002AAD9 File Offset: 0x00028CD9
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

		// Token: 0x06003086 RID: 12422 RVA: 0x0002AADC File Offset: 0x00028CDC
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

		// Token: 0x06003087 RID: 12423 RVA: 0x0002AADF File Offset: 0x00028CDF
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

		// Token: 0x06003088 RID: 12424 RVA: 0x0002AAE2 File Offset: 0x00028CE2
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

		// Token: 0x06003089 RID: 12425 RVA: 0x0002AAE5 File Offset: 0x00028CE5
		[global::Cpp2ILInjected.Token(Token = "0x6003592")]
		[global::Cpp2ILInjected.Address(RVA = "0x13D0438", Offset = "0x13D0438", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SoundID()
		{
			throw null;
		}

		// Token: 0x0600308A RID: 12426 RVA: 0x0002AAE8 File Offset: 0x00028CE8
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

		// Token: 0x04005A79 RID: 23161
		[global::Cpp2ILInjected.Token(Token = "0x4006DB7")]
		private static readonly SoundID.SoundStyleDefaults ItemDefaults;

		// Token: 0x04005A7A RID: 23162
		[global::Cpp2ILInjected.Token(Token = "0x4006DB8")]
		public const int Dig = 0;

		// Token: 0x04005A7B RID: 23163
		[global::Cpp2ILInjected.Token(Token = "0x4006DB9")]
		public const int PlayerHit = 1;

		// Token: 0x04005A7C RID: 23164
		[global::Cpp2ILInjected.Token(Token = "0x4006DBA")]
		public const int Item = 2;

		// Token: 0x04005A7D RID: 23165
		[global::Cpp2ILInjected.Token(Token = "0x4006DBB")]
		public const int NPCHit = 3;

		// Token: 0x04005A7E RID: 23166
		[global::Cpp2ILInjected.Token(Token = "0x4006DBC")]
		public const int NPCKilled = 4;

		// Token: 0x04005A7F RID: 23167
		[global::Cpp2ILInjected.Token(Token = "0x4006DBD")]
		public const int PlayerKilled = 5;

		// Token: 0x04005A80 RID: 23168
		[global::Cpp2ILInjected.Token(Token = "0x4006DBE")]
		public const int Grass = 6;

		// Token: 0x04005A81 RID: 23169
		[global::Cpp2ILInjected.Token(Token = "0x4006DBF")]
		public const int Grab = 7;

		// Token: 0x04005A82 RID: 23170
		[global::Cpp2ILInjected.Token(Token = "0x4006DC0")]
		public const int DoorOpen = 8;

		// Token: 0x04005A83 RID: 23171
		[global::Cpp2ILInjected.Token(Token = "0x4006DC1")]
		public const int DoorClosed = 9;

		// Token: 0x04005A84 RID: 23172
		[global::Cpp2ILInjected.Token(Token = "0x4006DC2")]
		public const int MenuOpen = 10;

		// Token: 0x04005A85 RID: 23173
		[global::Cpp2ILInjected.Token(Token = "0x4006DC3")]
		public const int MenuClose = 11;

		// Token: 0x04005A86 RID: 23174
		[global::Cpp2ILInjected.Token(Token = "0x4006DC4")]
		public const int MenuTick = 12;

		// Token: 0x04005A87 RID: 23175
		[global::Cpp2ILInjected.Token(Token = "0x4006DC5")]
		public const int Shatter = 13;

		// Token: 0x04005A88 RID: 23176
		[global::Cpp2ILInjected.Token(Token = "0x4006DC6")]
		public const int ZombieMoan = 14;

		// Token: 0x04005A89 RID: 23177
		[global::Cpp2ILInjected.Token(Token = "0x4006DC7")]
		public const int Roar = 15;

		// Token: 0x04005A8A RID: 23178
		[global::Cpp2ILInjected.Token(Token = "0x4006DC8")]
		public const int DoubleJump = 16;

		// Token: 0x04005A8B RID: 23179
		[global::Cpp2ILInjected.Token(Token = "0x4006DC9")]
		public const int Run = 17;

		// Token: 0x04005A8C RID: 23180
		[global::Cpp2ILInjected.Token(Token = "0x4006DCA")]
		public const int Coins = 18;

		// Token: 0x04005A8D RID: 23181
		[global::Cpp2ILInjected.Token(Token = "0x4006DCB")]
		public const int Splash = 19;

		// Token: 0x04005A8E RID: 23182
		[global::Cpp2ILInjected.Token(Token = "0x4006DCC")]
		public const int FemaleHit = 20;

		// Token: 0x04005A8F RID: 23183
		[global::Cpp2ILInjected.Token(Token = "0x4006DCD")]
		public const int Tink = 21;

		// Token: 0x04005A90 RID: 23184
		[global::Cpp2ILInjected.Token(Token = "0x4006DCE")]
		public const int Unlock = 22;

		// Token: 0x04005A91 RID: 23185
		[global::Cpp2ILInjected.Token(Token = "0x4006DCF")]
		public const int Drown = 23;

		// Token: 0x04005A92 RID: 23186
		[global::Cpp2ILInjected.Token(Token = "0x4006DD0")]
		public const int Chat = 24;

		// Token: 0x04005A93 RID: 23187
		[global::Cpp2ILInjected.Token(Token = "0x4006DD1")]
		public const int MaxMana = 25;

		// Token: 0x04005A94 RID: 23188
		[global::Cpp2ILInjected.Token(Token = "0x4006DD2")]
		public const int Mummy = 26;

		// Token: 0x04005A95 RID: 23189
		[global::Cpp2ILInjected.Token(Token = "0x4006DD3")]
		public const int Pixie = 27;

		// Token: 0x04005A96 RID: 23190
		[global::Cpp2ILInjected.Token(Token = "0x4006DD4")]
		public const int Mech = 28;

		// Token: 0x04005A97 RID: 23191
		[global::Cpp2ILInjected.Token(Token = "0x4006DD5")]
		public const int Zombie = 29;

		// Token: 0x04005A98 RID: 23192
		[global::Cpp2ILInjected.Token(Token = "0x4006DD6")]
		public const int Duck = 30;

		// Token: 0x04005A99 RID: 23193
		[global::Cpp2ILInjected.Token(Token = "0x4006DD7")]
		public const int Frog = 31;

		// Token: 0x04005A9A RID: 23194
		[global::Cpp2ILInjected.Token(Token = "0x4006DD8")]
		public const int Bird = 32;

		// Token: 0x04005A9B RID: 23195
		[global::Cpp2ILInjected.Token(Token = "0x4006DD9")]
		public const int Critter = 33;

		// Token: 0x04005A9C RID: 23196
		[global::Cpp2ILInjected.Token(Token = "0x4006DDA")]
		public const int Waterfall = 34;

		// Token: 0x04005A9D RID: 23197
		[global::Cpp2ILInjected.Token(Token = "0x4006DDB")]
		public const int Lavafall = 35;

		// Token: 0x04005A9E RID: 23198
		[global::Cpp2ILInjected.Token(Token = "0x4006DDC")]
		public const int ForceRoar = 36;

		// Token: 0x04005A9F RID: 23199
		[global::Cpp2ILInjected.Token(Token = "0x4006DDD")]
		public const int Meowmere = 37;

		// Token: 0x04005AA0 RID: 23200
		[global::Cpp2ILInjected.Token(Token = "0x4006DDE")]
		public const int CoinPickup = 38;

		// Token: 0x04005AA1 RID: 23201
		[global::Cpp2ILInjected.Token(Token = "0x4006DDF")]
		public const int Drip = 39;

		// Token: 0x04005AA2 RID: 23202
		[global::Cpp2ILInjected.Token(Token = "0x4006DE0")]
		public const int Camera = 40;

		// Token: 0x04005AA3 RID: 23203
		[global::Cpp2ILInjected.Token(Token = "0x4006DE1")]
		public const int MoonLord = 41;

		// Token: 0x04005AA4 RID: 23204
		[global::Cpp2ILInjected.Token(Token = "0x4006DE2")]
		public const int Trackable = 42;

		// Token: 0x04005AA5 RID: 23205
		[global::Cpp2ILInjected.Token(Token = "0x4006DE3")]
		public const int Thunder = 43;

		// Token: 0x04005AA6 RID: 23206
		[global::Cpp2ILInjected.Token(Token = "0x4006DE4")]
		public const int Seagull = 44;

		// Token: 0x04005AA7 RID: 23207
		[global::Cpp2ILInjected.Token(Token = "0x4006DE5")]
		public const int Dolphin = 45;

		// Token: 0x04005AA8 RID: 23208
		[global::Cpp2ILInjected.Token(Token = "0x4006DE6")]
		public const int Owl = 46;

		// Token: 0x04005AA9 RID: 23209
		[global::Cpp2ILInjected.Token(Token = "0x4006DE7")]
		public const int GuitarC = 47;

		// Token: 0x04005AAA RID: 23210
		[global::Cpp2ILInjected.Token(Token = "0x4006DE8")]
		public const int GuitarD = 48;

		// Token: 0x04005AAB RID: 23211
		[global::Cpp2ILInjected.Token(Token = "0x4006DE9")]
		public const int GuitarEm = 49;

		// Token: 0x04005AAC RID: 23212
		[global::Cpp2ILInjected.Token(Token = "0x4006DEA")]
		public const int GuitarG = 50;

		// Token: 0x04005AAD RID: 23213
		[global::Cpp2ILInjected.Token(Token = "0x4006DEB")]
		public const int GuitarBm = 51;

		// Token: 0x04005AAE RID: 23214
		[global::Cpp2ILInjected.Token(Token = "0x4006DEC")]
		public const int GuitarAm = 52;

		// Token: 0x04005AAF RID: 23215
		[global::Cpp2ILInjected.Token(Token = "0x4006DED")]
		public const int DrumHiHat = 53;

		// Token: 0x04005AB0 RID: 23216
		[global::Cpp2ILInjected.Token(Token = "0x4006DEE")]
		public const int DrumTomHigh = 54;

		// Token: 0x04005AB1 RID: 23217
		[global::Cpp2ILInjected.Token(Token = "0x4006DEF")]
		public const int DrumTomLow = 55;

		// Token: 0x04005AB2 RID: 23218
		[global::Cpp2ILInjected.Token(Token = "0x4006DF0")]
		public const int DrumTomMid = 56;

		// Token: 0x04005AB3 RID: 23219
		[global::Cpp2ILInjected.Token(Token = "0x4006DF1")]
		public const int DrumClosedHiHat = 57;

		// Token: 0x04005AB4 RID: 23220
		[global::Cpp2ILInjected.Token(Token = "0x4006DF2")]
		public const int DrumCymbal1 = 58;

		// Token: 0x04005AB5 RID: 23221
		[global::Cpp2ILInjected.Token(Token = "0x4006DF3")]
		public const int DrumCymbal2 = 59;

		// Token: 0x04005AB6 RID: 23222
		[global::Cpp2ILInjected.Token(Token = "0x4006DF4")]
		public const int DrumKick = 60;

		// Token: 0x04005AB7 RID: 23223
		[global::Cpp2ILInjected.Token(Token = "0x4006DF5")]
		public const int DrumTamaSnare = 61;

		// Token: 0x04005AB8 RID: 23224
		[global::Cpp2ILInjected.Token(Token = "0x4006DF6")]
		public const int DrumFloorTom = 62;

		// Token: 0x04005AB9 RID: 23225
		[global::Cpp2ILInjected.Token(Token = "0x4006DF7")]
		public const int Research = 63;

		// Token: 0x04005ABA RID: 23226
		[global::Cpp2ILInjected.Token(Token = "0x4006DF8")]
		public const int ResearchComplete = 64;

		// Token: 0x04005ABB RID: 23227
		[global::Cpp2ILInjected.Token(Token = "0x4006DF9")]
		public const int QueenSlime = 65;

		// Token: 0x04005ABC RID: 23228
		[global::Cpp2ILInjected.Token(Token = "0x4006DFA")]
		public const int Clown = 66;

		// Token: 0x04005ABD RID: 23229
		[global::Cpp2ILInjected.Token(Token = "0x4006DFB")]
		public const int Cockatiel = 67;

		// Token: 0x04005ABE RID: 23230
		[global::Cpp2ILInjected.Token(Token = "0x4006DFC")]
		public const int Macaw = 68;

		// Token: 0x04005ABF RID: 23231
		[global::Cpp2ILInjected.Token(Token = "0x4006DFD")]
		public const int Toucan = 69;

		// Token: 0x04005AC0 RID: 23232
		[global::Cpp2ILInjected.Token(Token = "0x4006DFE")]
		public static readonly LegacySoundStyle NPCHit1;

		// Token: 0x04005AC1 RID: 23233
		[global::Cpp2ILInjected.Token(Token = "0x4006DFF")]
		public static readonly LegacySoundStyle NPCHit2;

		// Token: 0x04005AC2 RID: 23234
		[global::Cpp2ILInjected.Token(Token = "0x4006E00")]
		public static readonly LegacySoundStyle NPCHit3;

		// Token: 0x04005AC3 RID: 23235
		[global::Cpp2ILInjected.Token(Token = "0x4006E01")]
		public static readonly LegacySoundStyle NPCHit4;

		// Token: 0x04005AC4 RID: 23236
		[global::Cpp2ILInjected.Token(Token = "0x4006E02")]
		public static readonly LegacySoundStyle NPCHit5;

		// Token: 0x04005AC5 RID: 23237
		[global::Cpp2ILInjected.Token(Token = "0x4006E03")]
		public static readonly LegacySoundStyle NPCHit6;

		// Token: 0x04005AC6 RID: 23238
		[global::Cpp2ILInjected.Token(Token = "0x4006E04")]
		public static readonly LegacySoundStyle NPCHit7;

		// Token: 0x04005AC7 RID: 23239
		[global::Cpp2ILInjected.Token(Token = "0x4006E05")]
		public static readonly LegacySoundStyle NPCHit8;

		// Token: 0x04005AC8 RID: 23240
		[global::Cpp2ILInjected.Token(Token = "0x4006E06")]
		public static readonly LegacySoundStyle NPCHit9;

		// Token: 0x04005AC9 RID: 23241
		[global::Cpp2ILInjected.Token(Token = "0x4006E07")]
		public static readonly LegacySoundStyle NPCHit10;

		// Token: 0x04005ACA RID: 23242
		[global::Cpp2ILInjected.Token(Token = "0x4006E08")]
		public static readonly LegacySoundStyle NPCHit11;

		// Token: 0x04005ACB RID: 23243
		[global::Cpp2ILInjected.Token(Token = "0x4006E09")]
		public static readonly LegacySoundStyle NPCHit12;

		// Token: 0x04005ACC RID: 23244
		[global::Cpp2ILInjected.Token(Token = "0x4006E0A")]
		public static readonly LegacySoundStyle NPCHit13;

		// Token: 0x04005ACD RID: 23245
		[global::Cpp2ILInjected.Token(Token = "0x4006E0B")]
		public static readonly LegacySoundStyle NPCHit14;

		// Token: 0x04005ACE RID: 23246
		[global::Cpp2ILInjected.Token(Token = "0x4006E0C")]
		public static readonly LegacySoundStyle NPCHit15;

		// Token: 0x04005ACF RID: 23247
		[global::Cpp2ILInjected.Token(Token = "0x4006E0D")]
		public static readonly LegacySoundStyle NPCHit16;

		// Token: 0x04005AD0 RID: 23248
		[global::Cpp2ILInjected.Token(Token = "0x4006E0E")]
		public static readonly LegacySoundStyle NPCHit17;

		// Token: 0x04005AD1 RID: 23249
		[global::Cpp2ILInjected.Token(Token = "0x4006E0F")]
		public static readonly LegacySoundStyle NPCHit18;

		// Token: 0x04005AD2 RID: 23250
		[global::Cpp2ILInjected.Token(Token = "0x4006E10")]
		public static readonly LegacySoundStyle NPCHit19;

		// Token: 0x04005AD3 RID: 23251
		[global::Cpp2ILInjected.Token(Token = "0x4006E11")]
		public static readonly LegacySoundStyle NPCHit20;

		// Token: 0x04005AD4 RID: 23252
		[global::Cpp2ILInjected.Token(Token = "0x4006E12")]
		public static readonly LegacySoundStyle NPCHit21;

		// Token: 0x04005AD5 RID: 23253
		[global::Cpp2ILInjected.Token(Token = "0x4006E13")]
		public static readonly LegacySoundStyle NPCHit22;

		// Token: 0x04005AD6 RID: 23254
		[global::Cpp2ILInjected.Token(Token = "0x4006E14")]
		public static readonly LegacySoundStyle NPCHit23;

		// Token: 0x04005AD7 RID: 23255
		[global::Cpp2ILInjected.Token(Token = "0x4006E15")]
		public static readonly LegacySoundStyle NPCHit24;

		// Token: 0x04005AD8 RID: 23256
		[global::Cpp2ILInjected.Token(Token = "0x4006E16")]
		public static readonly LegacySoundStyle NPCHit25;

		// Token: 0x04005AD9 RID: 23257
		[global::Cpp2ILInjected.Token(Token = "0x4006E17")]
		public static readonly LegacySoundStyle NPCHit26;

		// Token: 0x04005ADA RID: 23258
		[global::Cpp2ILInjected.Token(Token = "0x4006E18")]
		public static readonly LegacySoundStyle NPCHit27;

		// Token: 0x04005ADB RID: 23259
		[global::Cpp2ILInjected.Token(Token = "0x4006E19")]
		public static readonly LegacySoundStyle NPCHit28;

		// Token: 0x04005ADC RID: 23260
		[global::Cpp2ILInjected.Token(Token = "0x4006E1A")]
		public static readonly LegacySoundStyle NPCHit29;

		// Token: 0x04005ADD RID: 23261
		[global::Cpp2ILInjected.Token(Token = "0x4006E1B")]
		public static readonly LegacySoundStyle NPCHit30;

		// Token: 0x04005ADE RID: 23262
		[global::Cpp2ILInjected.Token(Token = "0x4006E1C")]
		public static readonly LegacySoundStyle NPCHit31;

		// Token: 0x04005ADF RID: 23263
		[global::Cpp2ILInjected.Token(Token = "0x4006E1D")]
		public static readonly LegacySoundStyle NPCHit32;

		// Token: 0x04005AE0 RID: 23264
		[global::Cpp2ILInjected.Token(Token = "0x4006E1E")]
		public static readonly LegacySoundStyle NPCHit33;

		// Token: 0x04005AE1 RID: 23265
		[global::Cpp2ILInjected.Token(Token = "0x4006E1F")]
		public static readonly LegacySoundStyle NPCHit34;

		// Token: 0x04005AE2 RID: 23266
		[global::Cpp2ILInjected.Token(Token = "0x4006E20")]
		public static readonly LegacySoundStyle NPCHit35;

		// Token: 0x04005AE3 RID: 23267
		[global::Cpp2ILInjected.Token(Token = "0x4006E21")]
		public static readonly LegacySoundStyle NPCHit36;

		// Token: 0x04005AE4 RID: 23268
		[global::Cpp2ILInjected.Token(Token = "0x4006E22")]
		public static readonly LegacySoundStyle NPCHit37;

		// Token: 0x04005AE5 RID: 23269
		[global::Cpp2ILInjected.Token(Token = "0x4006E23")]
		public static readonly LegacySoundStyle NPCHit38;

		// Token: 0x04005AE6 RID: 23270
		[global::Cpp2ILInjected.Token(Token = "0x4006E24")]
		public static readonly LegacySoundStyle NPCHit39;

		// Token: 0x04005AE7 RID: 23271
		[global::Cpp2ILInjected.Token(Token = "0x4006E25")]
		public static readonly LegacySoundStyle NPCHit40;

		// Token: 0x04005AE8 RID: 23272
		[global::Cpp2ILInjected.Token(Token = "0x4006E26")]
		public static readonly LegacySoundStyle NPCHit41;

		// Token: 0x04005AE9 RID: 23273
		[global::Cpp2ILInjected.Token(Token = "0x4006E27")]
		public static readonly LegacySoundStyle NPCHit42;

		// Token: 0x04005AEA RID: 23274
		[global::Cpp2ILInjected.Token(Token = "0x4006E28")]
		public static readonly LegacySoundStyle NPCHit43;

		// Token: 0x04005AEB RID: 23275
		[global::Cpp2ILInjected.Token(Token = "0x4006E29")]
		public static readonly LegacySoundStyle NPCHit44;

		// Token: 0x04005AEC RID: 23276
		[global::Cpp2ILInjected.Token(Token = "0x4006E2A")]
		public static readonly LegacySoundStyle NPCHit45;

		// Token: 0x04005AED RID: 23277
		[global::Cpp2ILInjected.Token(Token = "0x4006E2B")]
		public static readonly LegacySoundStyle NPCHit46;

		// Token: 0x04005AEE RID: 23278
		[global::Cpp2ILInjected.Token(Token = "0x4006E2C")]
		public static readonly LegacySoundStyle NPCHit47;

		// Token: 0x04005AEF RID: 23279
		[global::Cpp2ILInjected.Token(Token = "0x4006E2D")]
		public static readonly LegacySoundStyle NPCHit48;

		// Token: 0x04005AF0 RID: 23280
		[global::Cpp2ILInjected.Token(Token = "0x4006E2E")]
		public static readonly LegacySoundStyle NPCHit49;

		// Token: 0x04005AF1 RID: 23281
		[global::Cpp2ILInjected.Token(Token = "0x4006E2F")]
		public static readonly LegacySoundStyle NPCHit50;

		// Token: 0x04005AF2 RID: 23282
		[global::Cpp2ILInjected.Token(Token = "0x4006E30")]
		public static readonly LegacySoundStyle NPCHit51;

		// Token: 0x04005AF3 RID: 23283
		[global::Cpp2ILInjected.Token(Token = "0x4006E31")]
		public static readonly LegacySoundStyle NPCHit52;

		// Token: 0x04005AF4 RID: 23284
		[global::Cpp2ILInjected.Token(Token = "0x4006E32")]
		public static readonly LegacySoundStyle NPCHit53;

		// Token: 0x04005AF5 RID: 23285
		[global::Cpp2ILInjected.Token(Token = "0x4006E33")]
		public static readonly LegacySoundStyle NPCHit54;

		// Token: 0x04005AF6 RID: 23286
		[global::Cpp2ILInjected.Token(Token = "0x4006E34")]
		public static readonly LegacySoundStyle NPCHit55;

		// Token: 0x04005AF7 RID: 23287
		[global::Cpp2ILInjected.Token(Token = "0x4006E35")]
		public static readonly LegacySoundStyle NPCHit56;

		// Token: 0x04005AF8 RID: 23288
		[global::Cpp2ILInjected.Token(Token = "0x4006E36")]
		public static readonly LegacySoundStyle NPCHit57;

		// Token: 0x04005AF9 RID: 23289
		[global::Cpp2ILInjected.Token(Token = "0x4006E37")]
		public static readonly LegacySoundStyle NPCDeath1;

		// Token: 0x04005AFA RID: 23290
		[global::Cpp2ILInjected.Token(Token = "0x4006E38")]
		public static readonly LegacySoundStyle NPCDeath2;

		// Token: 0x04005AFB RID: 23291
		[global::Cpp2ILInjected.Token(Token = "0x4006E39")]
		public static readonly LegacySoundStyle NPCDeath3;

		// Token: 0x04005AFC RID: 23292
		[global::Cpp2ILInjected.Token(Token = "0x4006E3A")]
		public static readonly LegacySoundStyle NPCDeath4;

		// Token: 0x04005AFD RID: 23293
		[global::Cpp2ILInjected.Token(Token = "0x4006E3B")]
		public static readonly LegacySoundStyle NPCDeath5;

		// Token: 0x04005AFE RID: 23294
		[global::Cpp2ILInjected.Token(Token = "0x4006E3C")]
		public static readonly LegacySoundStyle NPCDeath6;

		// Token: 0x04005AFF RID: 23295
		[global::Cpp2ILInjected.Token(Token = "0x4006E3D")]
		public static readonly LegacySoundStyle NPCDeath7;

		// Token: 0x04005B00 RID: 23296
		[global::Cpp2ILInjected.Token(Token = "0x4006E3E")]
		public static readonly LegacySoundStyle NPCDeath8;

		// Token: 0x04005B01 RID: 23297
		[global::Cpp2ILInjected.Token(Token = "0x4006E3F")]
		public static readonly LegacySoundStyle NPCDeath9;

		// Token: 0x04005B02 RID: 23298
		[global::Cpp2ILInjected.Token(Token = "0x4006E40")]
		public static readonly LegacySoundStyle NPCDeath10;

		// Token: 0x04005B03 RID: 23299
		[global::Cpp2ILInjected.Token(Token = "0x4006E41")]
		public static readonly LegacySoundStyle NPCDeath11;

		// Token: 0x04005B04 RID: 23300
		[global::Cpp2ILInjected.Token(Token = "0x4006E42")]
		public static readonly LegacySoundStyle NPCDeath12;

		// Token: 0x04005B05 RID: 23301
		[global::Cpp2ILInjected.Token(Token = "0x4006E43")]
		public static readonly LegacySoundStyle NPCDeath13;

		// Token: 0x04005B06 RID: 23302
		[global::Cpp2ILInjected.Token(Token = "0x4006E44")]
		public static readonly LegacySoundStyle NPCDeath14;

		// Token: 0x04005B07 RID: 23303
		[global::Cpp2ILInjected.Token(Token = "0x4006E45")]
		public static readonly LegacySoundStyle NPCDeath15;

		// Token: 0x04005B08 RID: 23304
		[global::Cpp2ILInjected.Token(Token = "0x4006E46")]
		public static readonly LegacySoundStyle NPCDeath16;

		// Token: 0x04005B09 RID: 23305
		[global::Cpp2ILInjected.Token(Token = "0x4006E47")]
		public static readonly LegacySoundStyle NPCDeath17;

		// Token: 0x04005B0A RID: 23306
		[global::Cpp2ILInjected.Token(Token = "0x4006E48")]
		public static readonly LegacySoundStyle NPCDeath18;

		// Token: 0x04005B0B RID: 23307
		[global::Cpp2ILInjected.Token(Token = "0x4006E49")]
		public static readonly LegacySoundStyle NPCDeath19;

		// Token: 0x04005B0C RID: 23308
		[global::Cpp2ILInjected.Token(Token = "0x4006E4A")]
		public static readonly LegacySoundStyle NPCDeath20;

		// Token: 0x04005B0D RID: 23309
		[global::Cpp2ILInjected.Token(Token = "0x4006E4B")]
		public static readonly LegacySoundStyle NPCDeath21;

		// Token: 0x04005B0E RID: 23310
		[global::Cpp2ILInjected.Token(Token = "0x4006E4C")]
		public static readonly LegacySoundStyle NPCDeath22;

		// Token: 0x04005B0F RID: 23311
		[global::Cpp2ILInjected.Token(Token = "0x4006E4D")]
		public static readonly LegacySoundStyle NPCDeath23;

		// Token: 0x04005B10 RID: 23312
		[global::Cpp2ILInjected.Token(Token = "0x4006E4E")]
		public static readonly LegacySoundStyle NPCDeath24;

		// Token: 0x04005B11 RID: 23313
		[global::Cpp2ILInjected.Token(Token = "0x4006E4F")]
		public static readonly LegacySoundStyle NPCDeath25;

		// Token: 0x04005B12 RID: 23314
		[global::Cpp2ILInjected.Token(Token = "0x4006E50")]
		public static readonly LegacySoundStyle NPCDeath26;

		// Token: 0x04005B13 RID: 23315
		[global::Cpp2ILInjected.Token(Token = "0x4006E51")]
		public static readonly LegacySoundStyle NPCDeath27;

		// Token: 0x04005B14 RID: 23316
		[global::Cpp2ILInjected.Token(Token = "0x4006E52")]
		public static readonly LegacySoundStyle NPCDeath28;

		// Token: 0x04005B15 RID: 23317
		[global::Cpp2ILInjected.Token(Token = "0x4006E53")]
		public static readonly LegacySoundStyle NPCDeath29;

		// Token: 0x04005B16 RID: 23318
		[global::Cpp2ILInjected.Token(Token = "0x4006E54")]
		public static readonly LegacySoundStyle NPCDeath30;

		// Token: 0x04005B17 RID: 23319
		[global::Cpp2ILInjected.Token(Token = "0x4006E55")]
		public static readonly LegacySoundStyle NPCDeath31;

		// Token: 0x04005B18 RID: 23320
		[global::Cpp2ILInjected.Token(Token = "0x4006E56")]
		public static readonly LegacySoundStyle NPCDeath32;

		// Token: 0x04005B19 RID: 23321
		[global::Cpp2ILInjected.Token(Token = "0x4006E57")]
		public static readonly LegacySoundStyle NPCDeath33;

		// Token: 0x04005B1A RID: 23322
		[global::Cpp2ILInjected.Token(Token = "0x4006E58")]
		public static readonly LegacySoundStyle NPCDeath34;

		// Token: 0x04005B1B RID: 23323
		[global::Cpp2ILInjected.Token(Token = "0x4006E59")]
		public static readonly LegacySoundStyle NPCDeath35;

		// Token: 0x04005B1C RID: 23324
		[global::Cpp2ILInjected.Token(Token = "0x4006E5A")]
		public static readonly LegacySoundStyle NPCDeath36;

		// Token: 0x04005B1D RID: 23325
		[global::Cpp2ILInjected.Token(Token = "0x4006E5B")]
		public static readonly LegacySoundStyle NPCDeath37;

		// Token: 0x04005B1E RID: 23326
		[global::Cpp2ILInjected.Token(Token = "0x4006E5C")]
		public static readonly LegacySoundStyle NPCDeath38;

		// Token: 0x04005B1F RID: 23327
		[global::Cpp2ILInjected.Token(Token = "0x4006E5D")]
		public static readonly LegacySoundStyle NPCDeath39;

		// Token: 0x04005B20 RID: 23328
		[global::Cpp2ILInjected.Token(Token = "0x4006E5E")]
		public static readonly LegacySoundStyle NPCDeath40;

		// Token: 0x04005B21 RID: 23329
		[global::Cpp2ILInjected.Token(Token = "0x4006E5F")]
		public static readonly LegacySoundStyle NPCDeath41;

		// Token: 0x04005B22 RID: 23330
		[global::Cpp2ILInjected.Token(Token = "0x4006E60")]
		public static readonly LegacySoundStyle NPCDeath42;

		// Token: 0x04005B23 RID: 23331
		[global::Cpp2ILInjected.Token(Token = "0x4006E61")]
		public static readonly LegacySoundStyle NPCDeath43;

		// Token: 0x04005B24 RID: 23332
		[global::Cpp2ILInjected.Token(Token = "0x4006E62")]
		public static readonly LegacySoundStyle NPCDeath44;

		// Token: 0x04005B25 RID: 23333
		[global::Cpp2ILInjected.Token(Token = "0x4006E63")]
		public static readonly LegacySoundStyle NPCDeath45;

		// Token: 0x04005B26 RID: 23334
		[global::Cpp2ILInjected.Token(Token = "0x4006E64")]
		public static readonly LegacySoundStyle NPCDeath46;

		// Token: 0x04005B27 RID: 23335
		[global::Cpp2ILInjected.Token(Token = "0x4006E65")]
		public static readonly LegacySoundStyle NPCDeath47;

		// Token: 0x04005B28 RID: 23336
		[global::Cpp2ILInjected.Token(Token = "0x4006E66")]
		public static readonly LegacySoundStyle NPCDeath48;

		// Token: 0x04005B29 RID: 23337
		[global::Cpp2ILInjected.Token(Token = "0x4006E67")]
		public static readonly LegacySoundStyle NPCDeath49;

		// Token: 0x04005B2A RID: 23338
		[global::Cpp2ILInjected.Token(Token = "0x4006E68")]
		public static readonly LegacySoundStyle NPCDeath50;

		// Token: 0x04005B2B RID: 23339
		[global::Cpp2ILInjected.Token(Token = "0x4006E69")]
		public static readonly LegacySoundStyle NPCDeath51;

		// Token: 0x04005B2C RID: 23340
		[global::Cpp2ILInjected.Token(Token = "0x4006E6A")]
		public static readonly LegacySoundStyle NPCDeath52;

		// Token: 0x04005B2D RID: 23341
		[global::Cpp2ILInjected.Token(Token = "0x4006E6B")]
		public static readonly LegacySoundStyle NPCDeath53;

		// Token: 0x04005B2E RID: 23342
		[global::Cpp2ILInjected.Token(Token = "0x4006E6C")]
		public static readonly LegacySoundStyle NPCDeath54;

		// Token: 0x04005B2F RID: 23343
		[global::Cpp2ILInjected.Token(Token = "0x4006E6D")]
		public static readonly LegacySoundStyle NPCDeath55;

		// Token: 0x04005B30 RID: 23344
		[global::Cpp2ILInjected.Token(Token = "0x4006E6E")]
		public static readonly LegacySoundStyle NPCDeath56;

		// Token: 0x04005B31 RID: 23345
		[global::Cpp2ILInjected.Token(Token = "0x4006E6F")]
		public static readonly LegacySoundStyle NPCDeath57;

		// Token: 0x04005B32 RID: 23346
		[global::Cpp2ILInjected.Token(Token = "0x4006E70")]
		public static readonly LegacySoundStyle NPCDeath58;

		// Token: 0x04005B33 RID: 23347
		[global::Cpp2ILInjected.Token(Token = "0x4006E71")]
		public static readonly LegacySoundStyle NPCDeath59;

		// Token: 0x04005B34 RID: 23348
		[global::Cpp2ILInjected.Token(Token = "0x4006E72")]
		public static readonly LegacySoundStyle NPCDeath60;

		// Token: 0x04005B35 RID: 23349
		[global::Cpp2ILInjected.Token(Token = "0x4006E73")]
		public static readonly LegacySoundStyle NPCDeath61;

		// Token: 0x04005B36 RID: 23350
		[global::Cpp2ILInjected.Token(Token = "0x4006E74")]
		public static readonly LegacySoundStyle NPCDeath62;

		// Token: 0x04005B37 RID: 23351
		[global::Cpp2ILInjected.Token(Token = "0x4006E75")]
		public static readonly LegacySoundStyle NPCDeath63;

		// Token: 0x04005B38 RID: 23352
		[global::Cpp2ILInjected.Token(Token = "0x4006E76")]
		public static readonly LegacySoundStyle NPCDeath64;

		// Token: 0x04005B39 RID: 23353
		[global::Cpp2ILInjected.Token(Token = "0x4006E77")]
		public static readonly LegacySoundStyle NPCDeath65;

		// Token: 0x04005B3A RID: 23354
		[global::Cpp2ILInjected.Token(Token = "0x4006E78")]
		public static readonly LegacySoundStyle NPCDeath66;

		// Token: 0x04005B3B RID: 23355
		[global::Cpp2ILInjected.Token(Token = "0x4006E79")]
		public static short NPCDeathCount;

		// Token: 0x04005B3C RID: 23356
		[global::Cpp2ILInjected.Token(Token = "0x4006E7A")]
		public static readonly LegacySoundStyle Item1;

		// Token: 0x04005B3D RID: 23357
		[global::Cpp2ILInjected.Token(Token = "0x4006E7B")]
		public static readonly LegacySoundStyle Item2;

		// Token: 0x04005B3E RID: 23358
		[global::Cpp2ILInjected.Token(Token = "0x4006E7C")]
		public static readonly LegacySoundStyle Item3;

		// Token: 0x04005B3F RID: 23359
		[global::Cpp2ILInjected.Token(Token = "0x4006E7D")]
		public static readonly LegacySoundStyle Item4;

		// Token: 0x04005B40 RID: 23360
		[global::Cpp2ILInjected.Token(Token = "0x4006E7E")]
		public static readonly LegacySoundStyle Item5;

		// Token: 0x04005B41 RID: 23361
		[global::Cpp2ILInjected.Token(Token = "0x4006E7F")]
		public static readonly LegacySoundStyle Item6;

		// Token: 0x04005B42 RID: 23362
		[global::Cpp2ILInjected.Token(Token = "0x4006E80")]
		public static readonly LegacySoundStyle Item7;

		// Token: 0x04005B43 RID: 23363
		[global::Cpp2ILInjected.Token(Token = "0x4006E81")]
		public static readonly LegacySoundStyle Item8;

		// Token: 0x04005B44 RID: 23364
		[global::Cpp2ILInjected.Token(Token = "0x4006E82")]
		public static readonly LegacySoundStyle Item9;

		// Token: 0x04005B45 RID: 23365
		[global::Cpp2ILInjected.Token(Token = "0x4006E83")]
		public static readonly LegacySoundStyle Item10;

		// Token: 0x04005B46 RID: 23366
		[global::Cpp2ILInjected.Token(Token = "0x4006E84")]
		public static readonly LegacySoundStyle Item11;

		// Token: 0x04005B47 RID: 23367
		[global::Cpp2ILInjected.Token(Token = "0x4006E85")]
		public static readonly LegacySoundStyle Item12;

		// Token: 0x04005B48 RID: 23368
		[global::Cpp2ILInjected.Token(Token = "0x4006E86")]
		public static readonly LegacySoundStyle Item13;

		// Token: 0x04005B49 RID: 23369
		[global::Cpp2ILInjected.Token(Token = "0x4006E87")]
		public static readonly LegacySoundStyle Item14;

		// Token: 0x04005B4A RID: 23370
		[global::Cpp2ILInjected.Token(Token = "0x4006E88")]
		public static readonly LegacySoundStyle Item15;

		// Token: 0x04005B4B RID: 23371
		[global::Cpp2ILInjected.Token(Token = "0x4006E89")]
		public static readonly LegacySoundStyle Item16;

		// Token: 0x04005B4C RID: 23372
		[global::Cpp2ILInjected.Token(Token = "0x4006E8A")]
		public static readonly LegacySoundStyle Item17;

		// Token: 0x04005B4D RID: 23373
		[global::Cpp2ILInjected.Token(Token = "0x4006E8B")]
		public static readonly LegacySoundStyle Item18;

		// Token: 0x04005B4E RID: 23374
		[global::Cpp2ILInjected.Token(Token = "0x4006E8C")]
		public static readonly LegacySoundStyle Item19;

		// Token: 0x04005B4F RID: 23375
		[global::Cpp2ILInjected.Token(Token = "0x4006E8D")]
		public static readonly LegacySoundStyle Item20;

		// Token: 0x04005B50 RID: 23376
		[global::Cpp2ILInjected.Token(Token = "0x4006E8E")]
		public static readonly LegacySoundStyle Item21;

		// Token: 0x04005B51 RID: 23377
		[global::Cpp2ILInjected.Token(Token = "0x4006E8F")]
		public static readonly LegacySoundStyle Item22;

		// Token: 0x04005B52 RID: 23378
		[global::Cpp2ILInjected.Token(Token = "0x4006E90")]
		public static readonly LegacySoundStyle Item23;

		// Token: 0x04005B53 RID: 23379
		[global::Cpp2ILInjected.Token(Token = "0x4006E91")]
		public static readonly LegacySoundStyle Item24;

		// Token: 0x04005B54 RID: 23380
		[global::Cpp2ILInjected.Token(Token = "0x4006E92")]
		public static readonly LegacySoundStyle Item25;

		// Token: 0x04005B55 RID: 23381
		[global::Cpp2ILInjected.Token(Token = "0x4006E93")]
		public static readonly LegacySoundStyle Item26;

		// Token: 0x04005B56 RID: 23382
		[global::Cpp2ILInjected.Token(Token = "0x4006E94")]
		public static readonly LegacySoundStyle Item27;

		// Token: 0x04005B57 RID: 23383
		[global::Cpp2ILInjected.Token(Token = "0x4006E95")]
		public static readonly LegacySoundStyle Item28;

		// Token: 0x04005B58 RID: 23384
		[global::Cpp2ILInjected.Token(Token = "0x4006E96")]
		public static readonly LegacySoundStyle Item29;

		// Token: 0x04005B59 RID: 23385
		[global::Cpp2ILInjected.Token(Token = "0x4006E97")]
		public static readonly LegacySoundStyle Item30;

		// Token: 0x04005B5A RID: 23386
		[global::Cpp2ILInjected.Token(Token = "0x4006E98")]
		public static readonly LegacySoundStyle Item31;

		// Token: 0x04005B5B RID: 23387
		[global::Cpp2ILInjected.Token(Token = "0x4006E99")]
		public static readonly LegacySoundStyle Item32;

		// Token: 0x04005B5C RID: 23388
		[global::Cpp2ILInjected.Token(Token = "0x4006E9A")]
		public static readonly LegacySoundStyle Item33;

		// Token: 0x04005B5D RID: 23389
		[global::Cpp2ILInjected.Token(Token = "0x4006E9B")]
		public static readonly LegacySoundStyle Item34;

		// Token: 0x04005B5E RID: 23390
		[global::Cpp2ILInjected.Token(Token = "0x4006E9C")]
		public static readonly LegacySoundStyle Item35;

		// Token: 0x04005B5F RID: 23391
		[global::Cpp2ILInjected.Token(Token = "0x4006E9D")]
		public static readonly LegacySoundStyle Item36;

		// Token: 0x04005B60 RID: 23392
		[global::Cpp2ILInjected.Token(Token = "0x4006E9E")]
		public static readonly LegacySoundStyle Item37;

		// Token: 0x04005B61 RID: 23393
		[global::Cpp2ILInjected.Token(Token = "0x4006E9F")]
		public static readonly LegacySoundStyle Item38;

		// Token: 0x04005B62 RID: 23394
		[global::Cpp2ILInjected.Token(Token = "0x4006EA0")]
		public static readonly LegacySoundStyle Item39;

		// Token: 0x04005B63 RID: 23395
		[global::Cpp2ILInjected.Token(Token = "0x4006EA1")]
		public static readonly LegacySoundStyle Item40;

		// Token: 0x04005B64 RID: 23396
		[global::Cpp2ILInjected.Token(Token = "0x4006EA2")]
		public static readonly LegacySoundStyle Item41;

		// Token: 0x04005B65 RID: 23397
		[global::Cpp2ILInjected.Token(Token = "0x4006EA3")]
		public static readonly LegacySoundStyle Item42;

		// Token: 0x04005B66 RID: 23398
		[global::Cpp2ILInjected.Token(Token = "0x4006EA4")]
		public static readonly LegacySoundStyle Item43;

		// Token: 0x04005B67 RID: 23399
		[global::Cpp2ILInjected.Token(Token = "0x4006EA5")]
		public static readonly LegacySoundStyle Item44;

		// Token: 0x04005B68 RID: 23400
		[global::Cpp2ILInjected.Token(Token = "0x4006EA6")]
		public static readonly LegacySoundStyle Item45;

		// Token: 0x04005B69 RID: 23401
		[global::Cpp2ILInjected.Token(Token = "0x4006EA7")]
		public static readonly LegacySoundStyle Item46;

		// Token: 0x04005B6A RID: 23402
		[global::Cpp2ILInjected.Token(Token = "0x4006EA8")]
		public static readonly LegacySoundStyle Item47;

		// Token: 0x04005B6B RID: 23403
		[global::Cpp2ILInjected.Token(Token = "0x4006EA9")]
		public static readonly LegacySoundStyle Item48;

		// Token: 0x04005B6C RID: 23404
		[global::Cpp2ILInjected.Token(Token = "0x4006EAA")]
		public static readonly LegacySoundStyle Item49;

		// Token: 0x04005B6D RID: 23405
		[global::Cpp2ILInjected.Token(Token = "0x4006EAB")]
		public static readonly LegacySoundStyle Item50;

		// Token: 0x04005B6E RID: 23406
		[global::Cpp2ILInjected.Token(Token = "0x4006EAC")]
		public static readonly LegacySoundStyle Item51;

		// Token: 0x04005B6F RID: 23407
		[global::Cpp2ILInjected.Token(Token = "0x4006EAD")]
		public static readonly LegacySoundStyle Item52;

		// Token: 0x04005B70 RID: 23408
		[global::Cpp2ILInjected.Token(Token = "0x4006EAE")]
		public static readonly LegacySoundStyle Item53;

		// Token: 0x04005B71 RID: 23409
		[global::Cpp2ILInjected.Token(Token = "0x4006EAF")]
		public static readonly LegacySoundStyle Item54;

		// Token: 0x04005B72 RID: 23410
		[global::Cpp2ILInjected.Token(Token = "0x4006EB0")]
		public static readonly LegacySoundStyle Item55;

		// Token: 0x04005B73 RID: 23411
		[global::Cpp2ILInjected.Token(Token = "0x4006EB1")]
		public static readonly LegacySoundStyle Item56;

		// Token: 0x04005B74 RID: 23412
		[global::Cpp2ILInjected.Token(Token = "0x4006EB2")]
		public static readonly LegacySoundStyle Item57;

		// Token: 0x04005B75 RID: 23413
		[global::Cpp2ILInjected.Token(Token = "0x4006EB3")]
		public static readonly LegacySoundStyle Item58;

		// Token: 0x04005B76 RID: 23414
		[global::Cpp2ILInjected.Token(Token = "0x4006EB4")]
		public static readonly LegacySoundStyle Item59;

		// Token: 0x04005B77 RID: 23415
		[global::Cpp2ILInjected.Token(Token = "0x4006EB5")]
		public static readonly LegacySoundStyle Item60;

		// Token: 0x04005B78 RID: 23416
		[global::Cpp2ILInjected.Token(Token = "0x4006EB6")]
		public static readonly LegacySoundStyle Item61;

		// Token: 0x04005B79 RID: 23417
		[global::Cpp2ILInjected.Token(Token = "0x4006EB7")]
		public static readonly LegacySoundStyle Item62;

		// Token: 0x04005B7A RID: 23418
		[global::Cpp2ILInjected.Token(Token = "0x4006EB8")]
		public static readonly LegacySoundStyle Item63;

		// Token: 0x04005B7B RID: 23419
		[global::Cpp2ILInjected.Token(Token = "0x4006EB9")]
		public static readonly LegacySoundStyle Item64;

		// Token: 0x04005B7C RID: 23420
		[global::Cpp2ILInjected.Token(Token = "0x4006EBA")]
		public static readonly LegacySoundStyle Item65;

		// Token: 0x04005B7D RID: 23421
		[global::Cpp2ILInjected.Token(Token = "0x4006EBB")]
		public static readonly LegacySoundStyle Item66;

		// Token: 0x04005B7E RID: 23422
		[global::Cpp2ILInjected.Token(Token = "0x4006EBC")]
		public static readonly LegacySoundStyle Item67;

		// Token: 0x04005B7F RID: 23423
		[global::Cpp2ILInjected.Token(Token = "0x4006EBD")]
		public static readonly LegacySoundStyle Item68;

		// Token: 0x04005B80 RID: 23424
		[global::Cpp2ILInjected.Token(Token = "0x4006EBE")]
		public static readonly LegacySoundStyle Item69;

		// Token: 0x04005B81 RID: 23425
		[global::Cpp2ILInjected.Token(Token = "0x4006EBF")]
		public static readonly LegacySoundStyle Item70;

		// Token: 0x04005B82 RID: 23426
		[global::Cpp2ILInjected.Token(Token = "0x4006EC0")]
		public static readonly LegacySoundStyle Item71;

		// Token: 0x04005B83 RID: 23427
		[global::Cpp2ILInjected.Token(Token = "0x4006EC1")]
		public static readonly LegacySoundStyle Item72;

		// Token: 0x04005B84 RID: 23428
		[global::Cpp2ILInjected.Token(Token = "0x4006EC2")]
		public static readonly LegacySoundStyle Item73;

		// Token: 0x04005B85 RID: 23429
		[global::Cpp2ILInjected.Token(Token = "0x4006EC3")]
		public static readonly LegacySoundStyle Item74;

		// Token: 0x04005B86 RID: 23430
		[global::Cpp2ILInjected.Token(Token = "0x4006EC4")]
		public static readonly LegacySoundStyle Item75;

		// Token: 0x04005B87 RID: 23431
		[global::Cpp2ILInjected.Token(Token = "0x4006EC5")]
		public static readonly LegacySoundStyle Item76;

		// Token: 0x04005B88 RID: 23432
		[global::Cpp2ILInjected.Token(Token = "0x4006EC6")]
		public static readonly LegacySoundStyle Item77;

		// Token: 0x04005B89 RID: 23433
		[global::Cpp2ILInjected.Token(Token = "0x4006EC7")]
		public static readonly LegacySoundStyle Item78;

		// Token: 0x04005B8A RID: 23434
		[global::Cpp2ILInjected.Token(Token = "0x4006EC8")]
		public static readonly LegacySoundStyle Item79;

		// Token: 0x04005B8B RID: 23435
		[global::Cpp2ILInjected.Token(Token = "0x4006EC9")]
		public static readonly LegacySoundStyle Item80;

		// Token: 0x04005B8C RID: 23436
		[global::Cpp2ILInjected.Token(Token = "0x4006ECA")]
		public static readonly LegacySoundStyle Item81;

		// Token: 0x04005B8D RID: 23437
		[global::Cpp2ILInjected.Token(Token = "0x4006ECB")]
		public static readonly LegacySoundStyle Item82;

		// Token: 0x04005B8E RID: 23438
		[global::Cpp2ILInjected.Token(Token = "0x4006ECC")]
		public static readonly LegacySoundStyle Item83;

		// Token: 0x04005B8F RID: 23439
		[global::Cpp2ILInjected.Token(Token = "0x4006ECD")]
		public static readonly LegacySoundStyle Item84;

		// Token: 0x04005B90 RID: 23440
		[global::Cpp2ILInjected.Token(Token = "0x4006ECE")]
		public static readonly LegacySoundStyle Item85;

		// Token: 0x04005B91 RID: 23441
		[global::Cpp2ILInjected.Token(Token = "0x4006ECF")]
		public static readonly LegacySoundStyle Item86;

		// Token: 0x04005B92 RID: 23442
		[global::Cpp2ILInjected.Token(Token = "0x4006ED0")]
		public static readonly LegacySoundStyle Item87;

		// Token: 0x04005B93 RID: 23443
		[global::Cpp2ILInjected.Token(Token = "0x4006ED1")]
		public static readonly LegacySoundStyle Item88;

		// Token: 0x04005B94 RID: 23444
		[global::Cpp2ILInjected.Token(Token = "0x4006ED2")]
		public static readonly LegacySoundStyle Item89;

		// Token: 0x04005B95 RID: 23445
		[global::Cpp2ILInjected.Token(Token = "0x4006ED3")]
		public static readonly LegacySoundStyle Item90;

		// Token: 0x04005B96 RID: 23446
		[global::Cpp2ILInjected.Token(Token = "0x4006ED4")]
		public static readonly LegacySoundStyle Item91;

		// Token: 0x04005B97 RID: 23447
		[global::Cpp2ILInjected.Token(Token = "0x4006ED5")]
		public static readonly LegacySoundStyle Item92;

		// Token: 0x04005B98 RID: 23448
		[global::Cpp2ILInjected.Token(Token = "0x4006ED6")]
		public static readonly LegacySoundStyle Item93;

		// Token: 0x04005B99 RID: 23449
		[global::Cpp2ILInjected.Token(Token = "0x4006ED7")]
		public static readonly LegacySoundStyle Item94;

		// Token: 0x04005B9A RID: 23450
		[global::Cpp2ILInjected.Token(Token = "0x4006ED8")]
		public static readonly LegacySoundStyle Item95;

		// Token: 0x04005B9B RID: 23451
		[global::Cpp2ILInjected.Token(Token = "0x4006ED9")]
		public static readonly LegacySoundStyle Item96;

		// Token: 0x04005B9C RID: 23452
		[global::Cpp2ILInjected.Token(Token = "0x4006EDA")]
		public static readonly LegacySoundStyle Item97;

		// Token: 0x04005B9D RID: 23453
		[global::Cpp2ILInjected.Token(Token = "0x4006EDB")]
		public static readonly LegacySoundStyle Item98;

		// Token: 0x04005B9E RID: 23454
		[global::Cpp2ILInjected.Token(Token = "0x4006EDC")]
		public static readonly LegacySoundStyle Item99;

		// Token: 0x04005B9F RID: 23455
		[global::Cpp2ILInjected.Token(Token = "0x4006EDD")]
		public static readonly LegacySoundStyle Item100;

		// Token: 0x04005BA0 RID: 23456
		[global::Cpp2ILInjected.Token(Token = "0x4006EDE")]
		public static readonly LegacySoundStyle Item101;

		// Token: 0x04005BA1 RID: 23457
		[global::Cpp2ILInjected.Token(Token = "0x4006EDF")]
		public static readonly LegacySoundStyle Item102;

		// Token: 0x04005BA2 RID: 23458
		[global::Cpp2ILInjected.Token(Token = "0x4006EE0")]
		public static readonly LegacySoundStyle Item103;

		// Token: 0x04005BA3 RID: 23459
		[global::Cpp2ILInjected.Token(Token = "0x4006EE1")]
		public static readonly LegacySoundStyle Item104;

		// Token: 0x04005BA4 RID: 23460
		[global::Cpp2ILInjected.Token(Token = "0x4006EE2")]
		public static readonly LegacySoundStyle Item105;

		// Token: 0x04005BA5 RID: 23461
		[global::Cpp2ILInjected.Token(Token = "0x4006EE3")]
		public static readonly LegacySoundStyle Item106;

		// Token: 0x04005BA6 RID: 23462
		[global::Cpp2ILInjected.Token(Token = "0x4006EE4")]
		public static readonly LegacySoundStyle Item107;

		// Token: 0x04005BA7 RID: 23463
		[global::Cpp2ILInjected.Token(Token = "0x4006EE5")]
		public static readonly LegacySoundStyle Item108;

		// Token: 0x04005BA8 RID: 23464
		[global::Cpp2ILInjected.Token(Token = "0x4006EE6")]
		public static readonly LegacySoundStyle Item109;

		// Token: 0x04005BA9 RID: 23465
		[global::Cpp2ILInjected.Token(Token = "0x4006EE7")]
		public static readonly LegacySoundStyle Item110;

		// Token: 0x04005BAA RID: 23466
		[global::Cpp2ILInjected.Token(Token = "0x4006EE8")]
		public static readonly LegacySoundStyle Item111;

		// Token: 0x04005BAB RID: 23467
		[global::Cpp2ILInjected.Token(Token = "0x4006EE9")]
		public static readonly LegacySoundStyle Item112;

		// Token: 0x04005BAC RID: 23468
		[global::Cpp2ILInjected.Token(Token = "0x4006EEA")]
		public static readonly LegacySoundStyle Item113;

		// Token: 0x04005BAD RID: 23469
		[global::Cpp2ILInjected.Token(Token = "0x4006EEB")]
		public static readonly LegacySoundStyle Item114;

		// Token: 0x04005BAE RID: 23470
		[global::Cpp2ILInjected.Token(Token = "0x4006EEC")]
		public static readonly LegacySoundStyle Item115;

		// Token: 0x04005BAF RID: 23471
		[global::Cpp2ILInjected.Token(Token = "0x4006EED")]
		public static readonly LegacySoundStyle Item116;

		// Token: 0x04005BB0 RID: 23472
		[global::Cpp2ILInjected.Token(Token = "0x4006EEE")]
		public static readonly LegacySoundStyle Item117;

		// Token: 0x04005BB1 RID: 23473
		[global::Cpp2ILInjected.Token(Token = "0x4006EEF")]
		public static readonly LegacySoundStyle Item118;

		// Token: 0x04005BB2 RID: 23474
		[global::Cpp2ILInjected.Token(Token = "0x4006EF0")]
		public static readonly LegacySoundStyle Item119;

		// Token: 0x04005BB3 RID: 23475
		[global::Cpp2ILInjected.Token(Token = "0x4006EF1")]
		public static readonly LegacySoundStyle Item120;

		// Token: 0x04005BB4 RID: 23476
		[global::Cpp2ILInjected.Token(Token = "0x4006EF2")]
		public static readonly LegacySoundStyle Item121;

		// Token: 0x04005BB5 RID: 23477
		[global::Cpp2ILInjected.Token(Token = "0x4006EF3")]
		public static readonly LegacySoundStyle Item122;

		// Token: 0x04005BB6 RID: 23478
		[global::Cpp2ILInjected.Token(Token = "0x4006EF4")]
		public static readonly LegacySoundStyle Item123;

		// Token: 0x04005BB7 RID: 23479
		[global::Cpp2ILInjected.Token(Token = "0x4006EF5")]
		public static readonly LegacySoundStyle Item124;

		// Token: 0x04005BB8 RID: 23480
		[global::Cpp2ILInjected.Token(Token = "0x4006EF6")]
		public static readonly LegacySoundStyle Item125;

		// Token: 0x04005BB9 RID: 23481
		[global::Cpp2ILInjected.Token(Token = "0x4006EF7")]
		public static readonly LegacySoundStyle Item126;

		// Token: 0x04005BBA RID: 23482
		[global::Cpp2ILInjected.Token(Token = "0x4006EF8")]
		public static readonly LegacySoundStyle Item127;

		// Token: 0x04005BBB RID: 23483
		[global::Cpp2ILInjected.Token(Token = "0x4006EF9")]
		public static readonly LegacySoundStyle Item128;

		// Token: 0x04005BBC RID: 23484
		[global::Cpp2ILInjected.Token(Token = "0x4006EFA")]
		public static readonly LegacySoundStyle Item129;

		// Token: 0x04005BBD RID: 23485
		[global::Cpp2ILInjected.Token(Token = "0x4006EFB")]
		public static readonly LegacySoundStyle Item130;

		// Token: 0x04005BBE RID: 23486
		[global::Cpp2ILInjected.Token(Token = "0x4006EFC")]
		public static readonly LegacySoundStyle Item131;

		// Token: 0x04005BBF RID: 23487
		[global::Cpp2ILInjected.Token(Token = "0x4006EFD")]
		public static readonly LegacySoundStyle Item132;

		// Token: 0x04005BC0 RID: 23488
		[global::Cpp2ILInjected.Token(Token = "0x4006EFE")]
		public static readonly LegacySoundStyle Item133;

		// Token: 0x04005BC1 RID: 23489
		[global::Cpp2ILInjected.Token(Token = "0x4006EFF")]
		public static readonly LegacySoundStyle Item134;

		// Token: 0x04005BC2 RID: 23490
		[global::Cpp2ILInjected.Token(Token = "0x4006F00")]
		public static readonly LegacySoundStyle Item135;

		// Token: 0x04005BC3 RID: 23491
		[global::Cpp2ILInjected.Token(Token = "0x4006F01")]
		public static readonly LegacySoundStyle Item136;

		// Token: 0x04005BC4 RID: 23492
		[global::Cpp2ILInjected.Token(Token = "0x4006F02")]
		public static readonly LegacySoundStyle Item137;

		// Token: 0x04005BC5 RID: 23493
		[global::Cpp2ILInjected.Token(Token = "0x4006F03")]
		public static readonly LegacySoundStyle Item138;

		// Token: 0x04005BC6 RID: 23494
		[global::Cpp2ILInjected.Token(Token = "0x4006F04")]
		public static readonly LegacySoundStyle Item139;

		// Token: 0x04005BC7 RID: 23495
		[global::Cpp2ILInjected.Token(Token = "0x4006F05")]
		public static readonly LegacySoundStyle Item140;

		// Token: 0x04005BC8 RID: 23496
		[global::Cpp2ILInjected.Token(Token = "0x4006F06")]
		public static readonly LegacySoundStyle Item141;

		// Token: 0x04005BC9 RID: 23497
		[global::Cpp2ILInjected.Token(Token = "0x4006F07")]
		public static readonly LegacySoundStyle Item142;

		// Token: 0x04005BCA RID: 23498
		[global::Cpp2ILInjected.Token(Token = "0x4006F08")]
		public static readonly LegacySoundStyle Item143;

		// Token: 0x04005BCB RID: 23499
		[global::Cpp2ILInjected.Token(Token = "0x4006F09")]
		public static readonly LegacySoundStyle Item144;

		// Token: 0x04005BCC RID: 23500
		[global::Cpp2ILInjected.Token(Token = "0x4006F0A")]
		public static readonly LegacySoundStyle Item145;

		// Token: 0x04005BCD RID: 23501
		[global::Cpp2ILInjected.Token(Token = "0x4006F0B")]
		public static readonly LegacySoundStyle Item146;

		// Token: 0x04005BCE RID: 23502
		[global::Cpp2ILInjected.Token(Token = "0x4006F0C")]
		public static readonly LegacySoundStyle Item147;

		// Token: 0x04005BCF RID: 23503
		[global::Cpp2ILInjected.Token(Token = "0x4006F0D")]
		public static readonly LegacySoundStyle Item148;

		// Token: 0x04005BD0 RID: 23504
		[global::Cpp2ILInjected.Token(Token = "0x4006F0E")]
		public static readonly LegacySoundStyle Item149;

		// Token: 0x04005BD1 RID: 23505
		[global::Cpp2ILInjected.Token(Token = "0x4006F0F")]
		public static readonly LegacySoundStyle Item150;

		// Token: 0x04005BD2 RID: 23506
		[global::Cpp2ILInjected.Token(Token = "0x4006F10")]
		public static readonly LegacySoundStyle Item151;

		// Token: 0x04005BD3 RID: 23507
		[global::Cpp2ILInjected.Token(Token = "0x4006F11")]
		public static readonly LegacySoundStyle Item152;

		// Token: 0x04005BD4 RID: 23508
		[global::Cpp2ILInjected.Token(Token = "0x4006F12")]
		public static readonly LegacySoundStyle Item153;

		// Token: 0x04005BD5 RID: 23509
		[global::Cpp2ILInjected.Token(Token = "0x4006F13")]
		public static readonly LegacySoundStyle Item154;

		// Token: 0x04005BD6 RID: 23510
		[global::Cpp2ILInjected.Token(Token = "0x4006F14")]
		public static readonly LegacySoundStyle Item155;

		// Token: 0x04005BD7 RID: 23511
		[global::Cpp2ILInjected.Token(Token = "0x4006F15")]
		public static readonly LegacySoundStyle Item156;

		// Token: 0x04005BD8 RID: 23512
		[global::Cpp2ILInjected.Token(Token = "0x4006F16")]
		public static readonly LegacySoundStyle Item157;

		// Token: 0x04005BD9 RID: 23513
		[global::Cpp2ILInjected.Token(Token = "0x4006F17")]
		public static readonly LegacySoundStyle Item158;

		// Token: 0x04005BDA RID: 23514
		[global::Cpp2ILInjected.Token(Token = "0x4006F18")]
		public static readonly LegacySoundStyle Item159;

		// Token: 0x04005BDB RID: 23515
		[global::Cpp2ILInjected.Token(Token = "0x4006F19")]
		public static readonly LegacySoundStyle Item160;

		// Token: 0x04005BDC RID: 23516
		[global::Cpp2ILInjected.Token(Token = "0x4006F1A")]
		public static readonly LegacySoundStyle Item161;

		// Token: 0x04005BDD RID: 23517
		[global::Cpp2ILInjected.Token(Token = "0x4006F1B")]
		public static readonly LegacySoundStyle Item162;

		// Token: 0x04005BDE RID: 23518
		[global::Cpp2ILInjected.Token(Token = "0x4006F1C")]
		public static readonly LegacySoundStyle Item163;

		// Token: 0x04005BDF RID: 23519
		[global::Cpp2ILInjected.Token(Token = "0x4006F1D")]
		public static readonly LegacySoundStyle Item164;

		// Token: 0x04005BE0 RID: 23520
		[global::Cpp2ILInjected.Token(Token = "0x4006F1E")]
		public static readonly LegacySoundStyle Item165;

		// Token: 0x04005BE1 RID: 23521
		[global::Cpp2ILInjected.Token(Token = "0x4006F1F")]
		public static readonly LegacySoundStyle Item166;

		// Token: 0x04005BE2 RID: 23522
		[global::Cpp2ILInjected.Token(Token = "0x4006F20")]
		public static readonly LegacySoundStyle Item167;

		// Token: 0x04005BE3 RID: 23523
		[global::Cpp2ILInjected.Token(Token = "0x4006F21")]
		public static readonly LegacySoundStyle Item168;

		// Token: 0x04005BE4 RID: 23524
		[global::Cpp2ILInjected.Token(Token = "0x4006F22")]
		public static readonly LegacySoundStyle Item169;

		// Token: 0x04005BE5 RID: 23525
		[global::Cpp2ILInjected.Token(Token = "0x4006F23")]
		public static readonly LegacySoundStyle Item170;

		// Token: 0x04005BE6 RID: 23526
		[global::Cpp2ILInjected.Token(Token = "0x4006F24")]
		public static readonly LegacySoundStyle Item171;

		// Token: 0x04005BE7 RID: 23527
		[global::Cpp2ILInjected.Token(Token = "0x4006F25")]
		public static readonly LegacySoundStyle Item172;

		// Token: 0x04005BE8 RID: 23528
		[global::Cpp2ILInjected.Token(Token = "0x4006F26")]
		public static readonly LegacySoundStyle Item173;

		// Token: 0x04005BE9 RID: 23529
		[global::Cpp2ILInjected.Token(Token = "0x4006F27")]
		public static readonly LegacySoundStyle Item174;

		// Token: 0x04005BEA RID: 23530
		[global::Cpp2ILInjected.Token(Token = "0x4006F28")]
		public static readonly LegacySoundStyle Item175;

		// Token: 0x04005BEB RID: 23531
		[global::Cpp2ILInjected.Token(Token = "0x4006F29")]
		public static readonly LegacySoundStyle Item176;

		// Token: 0x04005BEC RID: 23532
		[global::Cpp2ILInjected.Token(Token = "0x4006F2A")]
		public static readonly LegacySoundStyle Item177;

		// Token: 0x04005BED RID: 23533
		[global::Cpp2ILInjected.Token(Token = "0x4006F2B")]
		public static readonly LegacySoundStyle Item178;

		// Token: 0x04005BEE RID: 23534
		[global::Cpp2ILInjected.Token(Token = "0x4006F2C")]
		public static short ItemSoundCount;

		// Token: 0x04005BEF RID: 23535
		[global::Cpp2ILInjected.Token(Token = "0x4006F2D")]
		public static readonly LegacySoundStyle DD2_GoblinBomb;

		// Token: 0x04005BF0 RID: 23536
		[global::Cpp2ILInjected.Token(Token = "0x4006F2E")]
		public static readonly LegacySoundStyle AchievementComplete;

		// Token: 0x04005BF1 RID: 23537
		[global::Cpp2ILInjected.Token(Token = "0x4006F2F")]
		public static readonly LegacySoundStyle BlizzardInsideBuildingLoop;

		// Token: 0x04005BF2 RID: 23538
		[global::Cpp2ILInjected.Token(Token = "0x4006F30")]
		public static readonly LegacySoundStyle BlizzardStrongLoop;

		// Token: 0x04005BF3 RID: 23539
		[global::Cpp2ILInjected.Token(Token = "0x4006F31")]
		public static readonly LegacySoundStyle LiquidsHoneyWater;

		// Token: 0x04005BF4 RID: 23540
		[global::Cpp2ILInjected.Token(Token = "0x4006F32")]
		public static readonly LegacySoundStyle LiquidsHoneyLava;

		// Token: 0x04005BF5 RID: 23541
		[global::Cpp2ILInjected.Token(Token = "0x4006F33")]
		public static readonly LegacySoundStyle LiquidsWaterLava;

		// Token: 0x04005BF6 RID: 23542
		[global::Cpp2ILInjected.Token(Token = "0x4006F34")]
		public static readonly LegacySoundStyle DD2_BallistaTowerShot;

		// Token: 0x04005BF7 RID: 23543
		[global::Cpp2ILInjected.Token(Token = "0x4006F35")]
		public static readonly LegacySoundStyle DD2_ExplosiveTrapExplode;

		// Token: 0x04005BF8 RID: 23544
		[global::Cpp2ILInjected.Token(Token = "0x4006F36")]
		public static readonly LegacySoundStyle DD2_FlameburstTowerShot;

		// Token: 0x04005BF9 RID: 23545
		[global::Cpp2ILInjected.Token(Token = "0x4006F37")]
		public static readonly LegacySoundStyle DD2_LightningAuraZap;

		// Token: 0x04005BFA RID: 23546
		[global::Cpp2ILInjected.Token(Token = "0x4006F38")]
		public static readonly LegacySoundStyle DD2_DefenseTowerSpawn;

		// Token: 0x04005BFB RID: 23547
		[global::Cpp2ILInjected.Token(Token = "0x4006F39")]
		public static readonly LegacySoundStyle DD2_BetsyDeath;

		// Token: 0x04005BFC RID: 23548
		[global::Cpp2ILInjected.Token(Token = "0x4006F3A")]
		public static readonly LegacySoundStyle DD2_BetsyFireballShot;

		// Token: 0x04005BFD RID: 23549
		[global::Cpp2ILInjected.Token(Token = "0x4006F3B")]
		public static readonly LegacySoundStyle DD2_BetsyFireballImpact;

		// Token: 0x04005BFE RID: 23550
		[global::Cpp2ILInjected.Token(Token = "0x4006F3C")]
		public static readonly LegacySoundStyle DD2_BetsyFlameBreath;

		// Token: 0x04005BFF RID: 23551
		[global::Cpp2ILInjected.Token(Token = "0x4006F3D")]
		public static readonly LegacySoundStyle DD2_BetsyFlyingCircleAttack;

		// Token: 0x04005C00 RID: 23552
		[global::Cpp2ILInjected.Token(Token = "0x4006F3E")]
		public static readonly LegacySoundStyle DD2_BetsyHurt;

		// Token: 0x04005C01 RID: 23553
		[global::Cpp2ILInjected.Token(Token = "0x4006F3F")]
		public static readonly LegacySoundStyle DD2_BetsyScream;

		// Token: 0x04005C02 RID: 23554
		[global::Cpp2ILInjected.Token(Token = "0x4006F40")]
		public static readonly LegacySoundStyle DD2_BetsySummon;

		// Token: 0x04005C03 RID: 23555
		[global::Cpp2ILInjected.Token(Token = "0x4006F41")]
		public static readonly LegacySoundStyle DD2_BetsyWindAttack;

		// Token: 0x04005C04 RID: 23556
		[global::Cpp2ILInjected.Token(Token = "0x4006F42")]
		public static readonly LegacySoundStyle DD2_DarkMageAttack;

		// Token: 0x04005C05 RID: 23557
		[global::Cpp2ILInjected.Token(Token = "0x4006F43")]
		public static readonly LegacySoundStyle DD2_DarkMageCastHeal;

		// Token: 0x04005C06 RID: 23558
		[global::Cpp2ILInjected.Token(Token = "0x4006F44")]
		public static readonly LegacySoundStyle DD2_DarkMageDeath;

		// Token: 0x04005C07 RID: 23559
		[global::Cpp2ILInjected.Token(Token = "0x4006F45")]
		public static readonly LegacySoundStyle DD2_DarkMageHealImpact;

		// Token: 0x04005C08 RID: 23560
		[global::Cpp2ILInjected.Token(Token = "0x4006F46")]
		public static readonly LegacySoundStyle DD2_DarkMageHurt;

		// Token: 0x04005C09 RID: 23561
		[global::Cpp2ILInjected.Token(Token = "0x4006F47")]
		public static readonly LegacySoundStyle DD2_DarkMageSummonSkeleton;

		// Token: 0x04005C0A RID: 23562
		[global::Cpp2ILInjected.Token(Token = "0x4006F48")]
		public static readonly LegacySoundStyle DD2_DrakinBreathIn;

		// Token: 0x04005C0B RID: 23563
		[global::Cpp2ILInjected.Token(Token = "0x4006F49")]
		public static readonly LegacySoundStyle DD2_DrakinDeath;

		// Token: 0x04005C0C RID: 23564
		[global::Cpp2ILInjected.Token(Token = "0x4006F4A")]
		public static readonly LegacySoundStyle DD2_DrakinHurt;

		// Token: 0x04005C0D RID: 23565
		[global::Cpp2ILInjected.Token(Token = "0x4006F4B")]
		public static readonly LegacySoundStyle DD2_DrakinShot;

		// Token: 0x04005C0E RID: 23566
		[global::Cpp2ILInjected.Token(Token = "0x4006F4C")]
		public static readonly LegacySoundStyle DD2_GoblinDeath;

		// Token: 0x04005C0F RID: 23567
		[global::Cpp2ILInjected.Token(Token = "0x4006F4D")]
		public static readonly LegacySoundStyle DD2_GoblinHurt;

		// Token: 0x04005C10 RID: 23568
		[global::Cpp2ILInjected.Token(Token = "0x4006F4E")]
		public static readonly LegacySoundStyle DD2_GoblinScream;

		// Token: 0x04005C11 RID: 23569
		[global::Cpp2ILInjected.Token(Token = "0x4006F4F")]
		public static readonly LegacySoundStyle DD2_GoblinBomberDeath;

		// Token: 0x04005C12 RID: 23570
		[global::Cpp2ILInjected.Token(Token = "0x4006F50")]
		public static readonly LegacySoundStyle DD2_GoblinBomberHurt;

		// Token: 0x04005C13 RID: 23571
		[global::Cpp2ILInjected.Token(Token = "0x4006F51")]
		public static readonly LegacySoundStyle DD2_GoblinBomberScream;

		// Token: 0x04005C14 RID: 23572
		[global::Cpp2ILInjected.Token(Token = "0x4006F52")]
		public static readonly LegacySoundStyle DD2_GoblinBomberThrow;

		// Token: 0x04005C15 RID: 23573
		[global::Cpp2ILInjected.Token(Token = "0x4006F53")]
		public static readonly LegacySoundStyle DD2_JavelinThrowersAttack;

		// Token: 0x04005C16 RID: 23574
		[global::Cpp2ILInjected.Token(Token = "0x4006F54")]
		public static readonly LegacySoundStyle DD2_JavelinThrowersDeath;

		// Token: 0x04005C17 RID: 23575
		[global::Cpp2ILInjected.Token(Token = "0x4006F55")]
		public static readonly LegacySoundStyle DD2_JavelinThrowersHurt;

		// Token: 0x04005C18 RID: 23576
		[global::Cpp2ILInjected.Token(Token = "0x4006F56")]
		public static readonly LegacySoundStyle DD2_JavelinThrowersTaunt;

		// Token: 0x04005C19 RID: 23577
		[global::Cpp2ILInjected.Token(Token = "0x4006F57")]
		public static readonly LegacySoundStyle DD2_KoboldDeath;

		// Token: 0x04005C1A RID: 23578
		[global::Cpp2ILInjected.Token(Token = "0x4006F58")]
		public static readonly LegacySoundStyle DD2_KoboldExplosion;

		// Token: 0x04005C1B RID: 23579
		[global::Cpp2ILInjected.Token(Token = "0x4006F59")]
		public static readonly LegacySoundStyle DD2_KoboldHurt;

		// Token: 0x04005C1C RID: 23580
		[global::Cpp2ILInjected.Token(Token = "0x4006F5A")]
		public static readonly LegacySoundStyle DD2_KoboldIgnite;

		// Token: 0x04005C1D RID: 23581
		[global::Cpp2ILInjected.Token(Token = "0x4006F5B")]
		public static readonly LegacySoundStyle DD2_KoboldIgniteLoop;

		// Token: 0x04005C1E RID: 23582
		[global::Cpp2ILInjected.Token(Token = "0x4006F5C")]
		public static readonly LegacySoundStyle DD2_KoboldScreamChargeLoop;

		// Token: 0x04005C1F RID: 23583
		[global::Cpp2ILInjected.Token(Token = "0x4006F5D")]
		public static readonly LegacySoundStyle DD2_KoboldFlyerChargeScream;

		// Token: 0x04005C20 RID: 23584
		[global::Cpp2ILInjected.Token(Token = "0x4006F5E")]
		public static readonly LegacySoundStyle DD2_KoboldFlyerDeath;

		// Token: 0x04005C21 RID: 23585
		[global::Cpp2ILInjected.Token(Token = "0x4006F5F")]
		public static readonly LegacySoundStyle DD2_KoboldFlyerHurt;

		// Token: 0x04005C22 RID: 23586
		[global::Cpp2ILInjected.Token(Token = "0x4006F60")]
		public static readonly LegacySoundStyle DD2_LightningBugDeath;

		// Token: 0x04005C23 RID: 23587
		[global::Cpp2ILInjected.Token(Token = "0x4006F61")]
		public static readonly LegacySoundStyle DD2_LightningBugHurt;

		// Token: 0x04005C24 RID: 23588
		[global::Cpp2ILInjected.Token(Token = "0x4006F62")]
		public static readonly LegacySoundStyle DD2_LightningBugZap;

		// Token: 0x04005C25 RID: 23589
		[global::Cpp2ILInjected.Token(Token = "0x4006F63")]
		public static readonly LegacySoundStyle DD2_OgreAttack;

		// Token: 0x04005C26 RID: 23590
		[global::Cpp2ILInjected.Token(Token = "0x4006F64")]
		public static readonly LegacySoundStyle DD2_OgreDeath;

		// Token: 0x04005C27 RID: 23591
		[global::Cpp2ILInjected.Token(Token = "0x4006F65")]
		public static readonly LegacySoundStyle DD2_OgreGroundPound;

		// Token: 0x04005C28 RID: 23592
		[global::Cpp2ILInjected.Token(Token = "0x4006F66")]
		public static readonly LegacySoundStyle DD2_OgreHurt;

		// Token: 0x04005C29 RID: 23593
		[global::Cpp2ILInjected.Token(Token = "0x4006F67")]
		public static readonly LegacySoundStyle DD2_OgreRoar;

		// Token: 0x04005C2A RID: 23594
		[global::Cpp2ILInjected.Token(Token = "0x4006F68")]
		public static readonly LegacySoundStyle DD2_OgreSpit;

		// Token: 0x04005C2B RID: 23595
		[global::Cpp2ILInjected.Token(Token = "0x4006F69")]
		public static readonly LegacySoundStyle DD2_SkeletonDeath;

		// Token: 0x04005C2C RID: 23596
		[global::Cpp2ILInjected.Token(Token = "0x4006F6A")]
		public static readonly LegacySoundStyle DD2_SkeletonHurt;

		// Token: 0x04005C2D RID: 23597
		[global::Cpp2ILInjected.Token(Token = "0x4006F6B")]
		public static readonly LegacySoundStyle DD2_SkeletonSummoned;

		// Token: 0x04005C2E RID: 23598
		[global::Cpp2ILInjected.Token(Token = "0x4006F6C")]
		public static readonly LegacySoundStyle DD2_WitherBeastAuraPulse;

		// Token: 0x04005C2F RID: 23599
		[global::Cpp2ILInjected.Token(Token = "0x4006F6D")]
		public static readonly LegacySoundStyle DD2_WitherBeastCrystalImpact;

		// Token: 0x04005C30 RID: 23600
		[global::Cpp2ILInjected.Token(Token = "0x4006F6E")]
		public static readonly LegacySoundStyle DD2_WitherBeastDeath;

		// Token: 0x04005C31 RID: 23601
		[global::Cpp2ILInjected.Token(Token = "0x4006F6F")]
		public static readonly LegacySoundStyle DD2_WitherBeastHurt;

		// Token: 0x04005C32 RID: 23602
		[global::Cpp2ILInjected.Token(Token = "0x4006F70")]
		public static readonly LegacySoundStyle DD2_WyvernDeath;

		// Token: 0x04005C33 RID: 23603
		[global::Cpp2ILInjected.Token(Token = "0x4006F71")]
		public static readonly LegacySoundStyle DD2_WyvernHurt;

		// Token: 0x04005C34 RID: 23604
		[global::Cpp2ILInjected.Token(Token = "0x4006F72")]
		public static readonly LegacySoundStyle DD2_WyvernScream;

		// Token: 0x04005C35 RID: 23605
		[global::Cpp2ILInjected.Token(Token = "0x4006F73")]
		public static readonly LegacySoundStyle DD2_WyvernDiveDown;

		// Token: 0x04005C36 RID: 23606
		[global::Cpp2ILInjected.Token(Token = "0x4006F74")]
		public static readonly LegacySoundStyle DD2_EtherianPortalDryadTouch;

		// Token: 0x04005C37 RID: 23607
		[global::Cpp2ILInjected.Token(Token = "0x4006F75")]
		public static readonly LegacySoundStyle DD2_EtherianPortalIdleLoop;

		// Token: 0x04005C38 RID: 23608
		[global::Cpp2ILInjected.Token(Token = "0x4006F76")]
		public static readonly LegacySoundStyle DD2_EtherianPortalOpen;

		// Token: 0x04005C39 RID: 23609
		[global::Cpp2ILInjected.Token(Token = "0x4006F77")]
		public static readonly LegacySoundStyle DD2_EtherianPortalSpawnEnemy;

		// Token: 0x04005C3A RID: 23610
		[global::Cpp2ILInjected.Token(Token = "0x4006F78")]
		public static readonly LegacySoundStyle DD2_CrystalCartImpact;

		// Token: 0x04005C3B RID: 23611
		[global::Cpp2ILInjected.Token(Token = "0x4006F79")]
		public static readonly LegacySoundStyle DD2_DefeatScene;

		// Token: 0x04005C3C RID: 23612
		[global::Cpp2ILInjected.Token(Token = "0x4006F7A")]
		public static readonly LegacySoundStyle DD2_WinScene;

		// Token: 0x04005C3D RID: 23613
		[global::Cpp2ILInjected.Token(Token = "0x4006F7B")]
		public static readonly LegacySoundStyle DD2_BetsysWrathShot;

		// Token: 0x04005C3E RID: 23614
		[global::Cpp2ILInjected.Token(Token = "0x4006F7C")]
		public static readonly LegacySoundStyle DD2_BetsysWrathImpact;

		// Token: 0x04005C3F RID: 23615
		[global::Cpp2ILInjected.Token(Token = "0x4006F7D")]
		public static readonly LegacySoundStyle DD2_BookStaffCast;

		// Token: 0x04005C40 RID: 23616
		[global::Cpp2ILInjected.Token(Token = "0x4006F7E")]
		public static readonly LegacySoundStyle DD2_BookStaffTwisterLoop;

		// Token: 0x04005C41 RID: 23617
		[global::Cpp2ILInjected.Token(Token = "0x4006F7F")]
		public static readonly LegacySoundStyle DD2_GhastlyGlaiveImpactGhost;

		// Token: 0x04005C42 RID: 23618
		[global::Cpp2ILInjected.Token(Token = "0x4006F80")]
		public static readonly LegacySoundStyle DD2_GhastlyGlaivePierce;

		// Token: 0x04005C43 RID: 23619
		[global::Cpp2ILInjected.Token(Token = "0x4006F81")]
		public static readonly LegacySoundStyle DD2_MonkStaffGroundImpact;

		// Token: 0x04005C44 RID: 23620
		[global::Cpp2ILInjected.Token(Token = "0x4006F82")]
		public static readonly LegacySoundStyle DD2_MonkStaffGroundMiss;

		// Token: 0x04005C45 RID: 23621
		[global::Cpp2ILInjected.Token(Token = "0x4006F83")]
		public static readonly LegacySoundStyle DD2_MonkStaffSwing;

		// Token: 0x04005C46 RID: 23622
		[global::Cpp2ILInjected.Token(Token = "0x4006F84")]
		public static readonly LegacySoundStyle DD2_PhantomPhoenixShot;

		// Token: 0x04005C47 RID: 23623
		[global::Cpp2ILInjected.Token(Token = "0x4006F85")]
		public static readonly LegacySoundStyle DD2_SonicBoomBladeSlash;

		// Token: 0x04005C48 RID: 23624
		[global::Cpp2ILInjected.Token(Token = "0x4006F86")]
		public static readonly LegacySoundStyle DD2_SkyDragonsFuryCircle;

		// Token: 0x04005C49 RID: 23625
		[global::Cpp2ILInjected.Token(Token = "0x4006F87")]
		public static readonly LegacySoundStyle DD2_SkyDragonsFuryShot;

		// Token: 0x04005C4A RID: 23626
		[global::Cpp2ILInjected.Token(Token = "0x4006F88")]
		public static readonly LegacySoundStyle DD2_SkyDragonsFurySwing;

		// Token: 0x04005C4B RID: 23627
		[global::Cpp2ILInjected.Token(Token = "0x4006F89")]
		public static readonly LegacySoundStyle LucyTheAxeTalk;

		// Token: 0x04005C4C RID: 23628
		[global::Cpp2ILInjected.Token(Token = "0x4006F8A")]
		public static readonly LegacySoundStyle DeerclopsHit;

		// Token: 0x04005C4D RID: 23629
		[global::Cpp2ILInjected.Token(Token = "0x4006F8B")]
		public static readonly LegacySoundStyle DeerclopsDeath;

		// Token: 0x04005C4E RID: 23630
		[global::Cpp2ILInjected.Token(Token = "0x4006F8C")]
		public static readonly LegacySoundStyle DeerclopsScream;

		// Token: 0x04005C4F RID: 23631
		[global::Cpp2ILInjected.Token(Token = "0x4006F8D")]
		public static readonly LegacySoundStyle DeerclopsIceAttack;

		// Token: 0x04005C50 RID: 23632
		[global::Cpp2ILInjected.Token(Token = "0x4006F8E")]
		public static readonly LegacySoundStyle DeerclopsRubbleAttack;

		// Token: 0x04005C51 RID: 23633
		[global::Cpp2ILInjected.Token(Token = "0x4006F8F")]
		public static readonly LegacySoundStyle DeerclopsStep;

		// Token: 0x04005C52 RID: 23634
		[global::Cpp2ILInjected.Token(Token = "0x4006F90")]
		public static readonly LegacySoundStyle ChesterOpen;

		// Token: 0x04005C53 RID: 23635
		[global::Cpp2ILInjected.Token(Token = "0x4006F91")]
		public static readonly LegacySoundStyle ChesterClose;

		// Token: 0x04005C54 RID: 23636
		[global::Cpp2ILInjected.Token(Token = "0x4006F92")]
		public static readonly LegacySoundStyle AbigailSummon;

		// Token: 0x04005C55 RID: 23637
		[global::Cpp2ILInjected.Token(Token = "0x4006F93")]
		public static readonly LegacySoundStyle AbigailCry;

		// Token: 0x04005C56 RID: 23638
		[global::Cpp2ILInjected.Token(Token = "0x4006F94")]
		public static readonly LegacySoundStyle AbigailAttack;

		// Token: 0x04005C57 RID: 23639
		[global::Cpp2ILInjected.Token(Token = "0x4006F95")]
		public static readonly LegacySoundStyle AbigailUpgrade;

		// Token: 0x04005C58 RID: 23640
		[global::Cpp2ILInjected.Token(Token = "0x4006F96")]
		public static readonly LegacySoundStyle GlommerBounce;

		// Token: 0x04005C59 RID: 23641
		[global::Cpp2ILInjected.Token(Token = "0x4006F97")]
		public static readonly LegacySoundStyle DSTMaleHurt;

		// Token: 0x04005C5A RID: 23642
		[global::Cpp2ILInjected.Token(Token = "0x4006F98")]
		public static readonly LegacySoundStyle DSTFemaleHurt;

		// Token: 0x04005C5B RID: 23643
		[global::Cpp2ILInjected.Token(Token = "0x4006F99")]
		public static readonly LegacySoundStyle JimsDrone;

		// Token: 0x04005C5C RID: 23644
		[global::Cpp2ILInjected.Token(Token = "0x4006F9A")]
		private static List<string> _trackableLegacySoundPathList;

		// Token: 0x04005C5D RID: 23645
		[global::Cpp2ILInjected.Token(Token = "0x4006F9B")]
		public static Dictionary<string, LegacySoundStyle> SoundByName;

		// Token: 0x04005C5E RID: 23646
		[global::Cpp2ILInjected.Token(Token = "0x4006F9C")]
		public static Dictionary<string, ushort> IndexByName;

		// Token: 0x04005C5F RID: 23647
		[global::Cpp2ILInjected.Token(Token = "0x4006F9D")]
		public static Dictionary<ushort, LegacySoundStyle> SoundByIndex;

		// Token: 0x02000926 RID: 2342
		[global::Cpp2ILInjected.Token(Token = "0x20005F0")]
		private struct SoundStyleDefaults
		{
			// Token: 0x06004C83 RID: 19587 RVA: 0x0002F8B2 File Offset: 0x0002DAB2
			[global::Cpp2ILInjected.Token(Token = "0x6003594")]
			[global::Cpp2ILInjected.Address(RVA = "0x13D4D80", Offset = "0x13D4D80", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public SoundStyleDefaults(float volume, float pitchVariance, SoundType type = SoundType.Sound)
			{
				throw null;
			}

			// Token: 0x04008A40 RID: 35392
			[global::Cpp2ILInjected.Token(Token = "0x4006F9E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly float PitchVariance;

			// Token: 0x04008A41 RID: 35393
			[global::Cpp2ILInjected.Token(Token = "0x4006F9F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public readonly float Volume;

			// Token: 0x04008A42 RID: 35394
			[global::Cpp2ILInjected.Token(Token = "0x4006FA0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly SoundType Type;
		}

		// Token: 0x02000927 RID: 2343
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20005F1")]
		private sealed class <>c__DisplayClass495_0
		{
			// Token: 0x06004C84 RID: 19588 RVA: 0x0002F8B5 File Offset: 0x0002DAB5
			[global::Cpp2ILInjected.Token(Token = "0x6003595")]
			[global::Cpp2ILInjected.Address(RVA = "0x13D0430", Offset = "0x13D0430", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass495_0()
			{
				throw null;
			}

			// Token: 0x06004C85 RID: 19589 RVA: 0x0002F8B8 File Offset: 0x0002DAB8
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

			// Token: 0x04008A43 RID: 35395
			[global::Cpp2ILInjected.Token(Token = "0x4006FA1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Dictionary<string, LegacySoundStyle> ret;

			// Token: 0x04008A44 RID: 35396
			[global::Cpp2ILInjected.Token(Token = "0x4006FA2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Dictionary<string, ushort> ret2;

			// Token: 0x04008A45 RID: 35397
			[global::Cpp2ILInjected.Token(Token = "0x4006FA3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public ushort nextIndex;

			// Token: 0x04008A46 RID: 35398
			[global::Cpp2ILInjected.Token(Token = "0x4006FA4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public Dictionary<ushort, LegacySoundStyle> ret3;
		}

		// Token: 0x02000928 RID: 2344
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20005F2")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004C86 RID: 19590 RVA: 0x0002F8BB File Offset: 0x0002DABB
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

			// Token: 0x06004C87 RID: 19591 RVA: 0x0002F8BE File Offset: 0x0002DABE
			[global::Cpp2ILInjected.Token(Token = "0x6003598")]
			[global::Cpp2ILInjected.Address(RVA = "0x13D4F8C", Offset = "0x13D4F8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004C88 RID: 19592 RVA: 0x0002F8C1 File Offset: 0x0002DAC1
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

			// Token: 0x06004C89 RID: 19593 RVA: 0x0002F8C4 File Offset: 0x0002DAC4
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

			// Token: 0x04008A47 RID: 35399
			[global::Cpp2ILInjected.Token(Token = "0x4006FA5")]
			public static readonly SoundID.<>c <>9;

			// Token: 0x04008A48 RID: 35400
			[global::Cpp2ILInjected.Token(Token = "0x4006FA6")]
			public static Func<FieldInfo, bool> <>9__495_0;

			// Token: 0x04008A49 RID: 35401
			[global::Cpp2ILInjected.Token(Token = "0x4006FA7")]
			public static Comparison<FieldInfo> <>9__495_1;
		}
	}
}
