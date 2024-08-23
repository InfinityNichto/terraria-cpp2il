using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Localization;
using Terraria.Utilities;

namespace Terraria.GameContent.Events
{
	// Token: 0x0200068D RID: 1677
	[global::Cpp2ILInjected.Token(Token = "0x2000A4C")]
	public class BirthdayParty
	{
		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060041B8 RID: 16824 RVA: 0x0002DBDE File Offset: 0x0002BDDE
		[global::Cpp2ILInjected.Token(Token = "0x17000893")]
		public static bool PartyIsUp
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004DA1")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C4218", Offset = "0x8C4218", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "SetupShop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(NetworkText),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_007_TownEntities", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "UsesPartyHat", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "SpawnNPC", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "UpdateAltTexture", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "HasSpecialEventText", MemberParameters = new object[]
			{
				typeof(string),
				typeof(ref string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "HitWireSingle", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_Head_GetTVScreen", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(TileDrawInfo),
				typeof(ushort),
				typeof(ref short),
				typeof(ref short),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref SpriteEffects),
				typeof(ref Texture2D),
				typeof(ref Rectangle),
				typeof(ref Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(ushort),
				typeof(ref short),
				typeof(ref short),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref SpriteEffects),
				typeof(ref Texture2D),
				typeof(ref Rectangle),
				typeof(ref Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(Tile),
				typeof(ushort),
				typeof(ref short),
				typeof(ref short),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref SpriteEffects),
				typeof(ref Texture2D),
				typeof(ref Rectangle),
				typeof(ref Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BirthdayParty), Member = "ToggleManualParty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BirthdayParty), Member = "CheckForAchievement", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BirthdayParty), Member = "UpdateTime", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmoteBubble), Member = "ProbeEvents", MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060041B9 RID: 16825 RVA: 0x0002DBE1 File Offset: 0x0002BDE1
		[global::Cpp2ILInjected.Token(Token = "0x6004DA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C429C", Offset = "0x8C429C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime_StartDay", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void CheckMorning()
		{
			throw null;
		}

		// Token: 0x060041BA RID: 16826 RVA: 0x0002DBE4 File Offset: 0x0002BDE4
		[global::Cpp2ILInjected.Token(Token = "0x6004DA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C4D54", Offset = "0x8C4D54", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime_StartNight", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "BroadcastText", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static void CheckNight()
		{
			throw null;
		}

		// Token: 0x060041BB RID: 16827 RVA: 0x0002DBE7 File Offset: 0x0002BDE7
		[global::Cpp2ILInjected.Token(Token = "0x6004DA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C4F54", Offset = "0x8C4F54", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BirthdayParty), Member = "NaturalAttempt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BirthdayParty), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool CanNPCParty(NPC n)
		{
			throw null;
		}

		// Token: 0x060041BC RID: 16828 RVA: 0x0002DBEA File Offset: 0x0002BDEA
		[global::Cpp2ILInjected.Token(Token = "0x6004DA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C42E8", Offset = "0x8C42E8", Length = "0xA6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "AnyNPCs", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BirthdayParty), Member = "CanNPCParty", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, int>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "OrderBy", MemberTypeParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, int>)
		}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetGivenOrTypeNetName", ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "BroadcastText", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BirthdayParty), Member = "CheckForAchievement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 73)]
		private static void NaturalAttempt()
		{
			throw null;
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x0002DBED File Offset: 0x0002BDED
		[global::Cpp2ILInjected.Token(Token = "0x6004DA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C5068", Offset = "0x8C5068", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TileInteractionsUse", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "HitWireSingle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BirthdayParty), Member = "get_PartyIsUp", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BirthdayParty), Member = "CheckForAchievement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void ToggleManualParty()
		{
			throw null;
		}

		// Token: 0x060041BE RID: 16830 RVA: 0x0002DBF0 File Offset: 0x0002BDF0
		[global::Cpp2ILInjected.Token(Token = "0x6004DA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C5000", Offset = "0x8C5000", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BirthdayParty), Member = "NaturalAttempt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BirthdayParty), Member = "ToggleManualParty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BirthdayParty), Member = "get_PartyIsUp", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementsHelper), Member = "NotifyProgressionEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void CheckForAchievement()
		{
			throw null;
		}

		// Token: 0x060041BF RID: 16831 RVA: 0x0002DBF3 File Offset: 0x0002BDF3
		[global::Cpp2ILInjected.Token(Token = "0x6004DA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C5220", Offset = "0x8C5220", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ClearVisualPostProcessEffects", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void WorldClear()
		{
			throw null;
		}

		// Token: 0x060041C0 RID: 16832 RVA: 0x0002DBF6 File Offset: 0x0002BDF6
		[global::Cpp2ILInjected.Token(Token = "0x6004DA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C529C", Offset = "0x8C529C", Length = "0x4F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BirthdayParty), Member = "get_PartyIsUp", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHostOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "Activate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Vector2),
			typeof(object[])
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectManager<>), Member = "Deactivate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetClientOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BirthdayParty), Member = "CanNPCParty", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "BroadcastText", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
		public static void UpdateTime()
		{
			throw null;
		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x0002DBF9 File Offset: 0x0002BDF9
		[global::Cpp2ILInjected.Token(Token = "0x6004DAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C578C", Offset = "0x8C578C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BirthdayParty()
		{
			throw null;
		}

		// Token: 0x060041C2 RID: 16834 RVA: 0x0002DBFC File Offset: 0x0002BDFC
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004DAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x8C5794", Offset = "0x8C5794", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static BirthdayParty()
		{
			throw null;
		}

		// Token: 0x04006DD7 RID: 28119
		[global::Cpp2ILInjected.Token(Token = "0x400869B")]
		public static bool ManualParty;

		// Token: 0x04006DD8 RID: 28120
		[global::Cpp2ILInjected.Token(Token = "0x400869C")]
		public static bool GenuineParty;

		// Token: 0x04006DD9 RID: 28121
		[global::Cpp2ILInjected.Token(Token = "0x400869D")]
		public static int PartyDaysOnCooldown;

		// Token: 0x04006DDA RID: 28122
		[global::Cpp2ILInjected.Token(Token = "0x400869E")]
		public static List<int> CelebratingNPCs;

		// Token: 0x04006DDB RID: 28123
		[global::Cpp2ILInjected.Token(Token = "0x400869F")]
		private static bool _wasCelebrating;

		// Token: 0x02000A9C RID: 2716
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000A4D")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005215 RID: 21013 RVA: 0x000307A9 File Offset: 0x0002E9A9
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6004DAC")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C5820", Offset = "0x8C5820", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06005216 RID: 21014 RVA: 0x000307AC File Offset: 0x0002E9AC
			[global::Cpp2ILInjected.Token(Token = "0x6004DAD")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C587C", Offset = "0x8C587C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06005217 RID: 21015 RVA: 0x000307AF File Offset: 0x0002E9AF
			[global::Cpp2ILInjected.Token(Token = "0x6004DAE")]
			[global::Cpp2ILInjected.Address(RVA = "0x8C5884", Offset = "0x8C5884", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal int <NaturalAttempt>b__10_0(NPC i)
			{
				throw null;
			}

			// Token: 0x04008ED7 RID: 36567
			[global::Cpp2ILInjected.Token(Token = "0x40086A0")]
			public static readonly BirthdayParty.<>c <>9;

			// Token: 0x04008ED8 RID: 36568
			[global::Cpp2ILInjected.Token(Token = "0x40086A1")]
			public static Func<NPC, int> <>9__10_0;
		}
	}
}
