using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json;
using Terraria;
using Terraria.Cinematics;
using Terraria.DataStructures;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Events;
using Terraria.GameContent.Shaders;
using Terraria.GameContent.UI.Chat;
using Terraria.GameContent.UI.Elements;
using Terraria.Graphics;
using Terraria.ID;
using Terraria.Localization;
using Terraria.Map;
using Terraria.UI;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000299 RID: 665
	[JsonObject(MemberSerialization.OptIn)]
	[global::Cpp2ILInjected.Token(Token = "0x200035C")]
	[Serializable]
	public struct Color : IEquatable<Color>
	{
		// Token: 0x06001502 RID: 5378 RVA: 0x0002598E File Offset: 0x00023B8E
		[global::Cpp2ILInjected.Token(Token = "0x6001661")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA1D24", Offset = "0xAA1D24", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "GetAlpha", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Color)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColorClamped", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(int),
			typeof(Player),
			typeof(Vector2),
			typeof(Color),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "BroadcastText", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawSet), Member = "BoringSetup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(DrawData[]),
			typeof(List<int>),
			typeof(List<int>),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = "DryadPortalFade", MemberParameters = new object[] { typeof(FrameEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonlordDeathDrama.MoonlordPiece), Member = "GetLight", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Color(Vector3 vector)
		{
			throw null;
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00025991 File Offset: 0x00023B91
		[global::Cpp2ILInjected.Token(Token = "0x6001662")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA1F50", Offset = "0xAA1F50", Length = "0x2B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 34)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public Color(Vector4 vector)
		{
			throw null;
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x00025994 File Offset: 0x00023B94
		[global::Cpp2ILInjected.Token(Token = "0x6001663")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA2208", Offset = "0xAA2208", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1880)]
		public Color(int r, int g, int b)
		{
			throw null;
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x00025997 File Offset: 0x00023B97
		[global::Cpp2ILInjected.Token(Token = "0x6001664")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA2220", Offset = "0xAA2220", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 929)]
		public Color(int r, int g, int b, int a)
		{
			throw null;
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x0002599A File Offset: 0x00023B9A
		[global::Cpp2ILInjected.Token(Token = "0x6001665")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA2234", Offset = "0xAA2234", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "DrawItem", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ItemGrid_Layout),
			typeof(Item[]),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "GetFairyQueenWeaponsColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float?)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "GetLastPrismHue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(ref float),
			typeof(ref float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "KillTile_MakeTileDust", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.DyeInitializer.<>c", Member = "<LoadLegacyHairdyes>b__5_6", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Color),
			typeof(ref bool)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Colors), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_05_ForbiddenSetRing", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Item[]),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "DrawWaves", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_GasTrap", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Color(float r, float g, float b)
		{
			throw null;
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x0002599D File Offset: 0x00023B9D
		[global::Cpp2ILInjected.Token(Token = "0x6001666")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA2448", Offset = "0xAA2448", Length = "0x298")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 55)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public Color(float r, float g, float b, float a)
		{
			throw null;
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x000259A0 File Offset: 0x00023BA0
		[global::Cpp2ILInjected.Token(Token = "0x6001667")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA26E0", Offset = "0xAA26E0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Color(Color rgb, int a)
		{
			throw null;
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x000259A3 File Offset: 0x00023BA3
		[global::Cpp2ILInjected.Token(Token = "0x6001668")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA2700", Offset = "0xAA2700", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Color(Color rgb, float a)
		{
			throw null;
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x000259A6 File Offset: 0x00023BA6
		[global::Cpp2ILInjected.Token(Token = "0x6001669")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA2808", Offset = "0xAA2808", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawToMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "ApplySection", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawToMap_Section", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public ushort RGB565()
		{
			throw null;
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x000259A9 File Offset: 0x00023BA9
		[global::Cpp2ILInjected.Token(Token = "0x600166A")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA2830", Offset = "0xAA2830", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawToMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "ApplySection", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawToMap_Section", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public ushort ARGB4444()
		{
			throw null;
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x000259AC File Offset: 0x00023BAC
		[global::Cpp2ILInjected.Token(Token = "0x600166B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA2868", Offset = "0xAA2868", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Color32 RenderColour()
		{
			throw null;
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x000259AF File Offset: 0x00023BAF
		// (set) Token: 0x0600150E RID: 5390 RVA: 0x000259B2 File Offset: 0x00023BB2
		[global::Cpp2ILInjected.Token(Token = "0x17000291")]
		public uint PackedValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x600166C")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA288C", Offset = "0xAA288C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "EntitySpriteDraw", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(Vector2),
				typeof(Rectangle),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(Vector2),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawDust", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "oldDrawWater", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(int),
				typeof(float)
			}, ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "HealEffect", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawCompositeArmorPiece", MemberParameters = new object[]
			{
				typeof(ref PlayerDrawSet),
				typeof(CompositePlayerDrawContext),
				typeof(DrawData)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600166D")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA2898", Offset = "0xAA2898", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetCornerColors", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(ref VertexColors),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIGenProgressBar), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x000259B5 File Offset: 0x00023BB5
		[global::Cpp2ILInjected.Token(Token = "0x600166E")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA28A4", Offset = "0xAA28A4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "DrawProgressBar", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(Color),
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "set_BlendFactor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawWorldCursor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawWires", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(int),
			typeof(Player),
			typeof(Vector2),
			typeof(Color),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "DrawInvBG", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_21_1_Magiluminescence", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawStarboardRainbowTrail", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_AddSelectionGlow", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = "DrawProgressBar", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(Color),
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyChatMonitor), Member = "NewTextMultiline", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileChatMonitor), Member = "NewTextMultiline", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		public static bool operator ==(Color colorA, Color colorB)
		{
			throw null;
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x000259B8 File Offset: 0x00023BB8
		[global::Cpp2ILInjected.Token(Token = "0x600166F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA28B4", Offset = "0xAA28B4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 47)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool operator !=(Color colorA, Color colorB)
		{
			throw null;
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x000259BB File Offset: 0x00023BBB
		[global::Cpp2ILInjected.Token(Token = "0x6001670")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA291C", Offset = "0xAA291C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal float GetBrightness()
		{
			throw null;
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x000259BE File Offset: 0x00023BBE
		[global::Cpp2ILInjected.Token(Token = "0x6001671")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA29E4", Offset = "0xAA29E4", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal float GetSaturation()
		{
			throw null;
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x000259C1 File Offset: 0x00023BC1
		[global::Cpp2ILInjected.Token(Token = "0x6001672")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA2ACC", Offset = "0xAA2ACC", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal float GetHue()
		{
			throw null;
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x000259C4 File Offset: 0x00023BC4
		[global::Cpp2ILInjected.Token(Token = "0x6001673")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA2C30", Offset = "0xAA2C30", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool Equals(object o)
		{
			throw null;
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x000259C7 File Offset: 0x00023BC7
		[global::Cpp2ILInjected.Token(Token = "0x6001674")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA2CBC", Offset = "0xAA2CBC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x000259CA File Offset: 0x00023BCA
		[global::Cpp2ILInjected.Token(Token = "0x6001675")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA2CE0", Offset = "0xAA2CE0", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x000259CD File Offset: 0x00023BCD
		[global::Cpp2ILInjected.Token(Token = "0x6001676")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA2E54", Offset = "0xAA2E54", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 39)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public Vector4 ToVector4()
		{
			throw null;
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x000259D0 File Offset: 0x00023BD0
		[global::Cpp2ILInjected.Token(Token = "0x6001677")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA2EB8", Offset = "0xAA2EB8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 91)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public Vector3 ToVector3()
		{
			throw null;
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x000259D3 File Offset: 0x00023BD3
		[global::Cpp2ILInjected.Token(Token = "0x6001678")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA2F14", Offset = "0xAA2F14", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1229)]
		public static Color operator *(Color a, float amount)
		{
			throw null;
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x000259D6 File Offset: 0x00023BD6
		[global::Cpp2ILInjected.Token(Token = "0x6001679")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA2F94", Offset = "0xAA2F94", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetImmuneAlpha", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetImmuneAlphaPure", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(int),
			typeof(Player),
			typeof(Vector2),
			typeof(Color),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawSet), Member = "BoringSetup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(DrawData[]),
			typeof(List<int>),
			typeof(List<int>),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Color Multiply(Color a, float amount)
		{
			throw null;
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x000259D9 File Offset: 0x00023BD9
		[global::Cpp2ILInjected.Token(Token = "0x600167A")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA3000", Offset = "0xAA3000", Length = "0x304")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 317)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static Color Lerp(Color value1, Color value2, float amount)
		{
			throw null;
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x000259DC File Offset: 0x00023BDC
		[global::Cpp2ILInjected.Token(Token = "0x600167B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA3304", Offset = "0xAA3304", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(Color other)
		{
			throw null;
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x000259DF File Offset: 0x00023BDF
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600167C")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA336C", Offset = "0xAA336C", Length = "0x898")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Color()
		{
			throw null;
		}

		// Token: 0x04001E4C RID: 7756
		[JsonProperty]
		[global::Cpp2ILInjected.Token(Token = "0x400242E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public byte A;

		// Token: 0x04001E4D RID: 7757
		[JsonProperty]
		[global::Cpp2ILInjected.Token(Token = "0x400242F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		public byte B;

		// Token: 0x04001E4E RID: 7758
		[JsonProperty]
		[global::Cpp2ILInjected.Token(Token = "0x4002430")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public byte G;

		// Token: 0x04001E4F RID: 7759
		[JsonProperty]
		[global::Cpp2ILInjected.Token(Token = "0x4002431")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3")]
		public byte R;

		// Token: 0x04001E50 RID: 7760
		[global::Cpp2ILInjected.Token(Token = "0x4002432")]
		public static readonly Color Transparent;

		// Token: 0x04001E51 RID: 7761
		[global::Cpp2ILInjected.Token(Token = "0x4002433")]
		public static readonly Color TransparentBlack;

		// Token: 0x04001E52 RID: 7762
		[global::Cpp2ILInjected.Token(Token = "0x4002434")]
		public static readonly Color TransparentWhite;

		// Token: 0x04001E53 RID: 7763
		[global::Cpp2ILInjected.Token(Token = "0x4002435")]
		public static readonly Color AliceBlue;

		// Token: 0x04001E54 RID: 7764
		[global::Cpp2ILInjected.Token(Token = "0x4002436")]
		public static readonly Color AntiqueWhite;

		// Token: 0x04001E55 RID: 7765
		[global::Cpp2ILInjected.Token(Token = "0x4002437")]
		public static readonly Color Aqua;

		// Token: 0x04001E56 RID: 7766
		[global::Cpp2ILInjected.Token(Token = "0x4002438")]
		public static readonly Color Aquamarine;

		// Token: 0x04001E57 RID: 7767
		[global::Cpp2ILInjected.Token(Token = "0x4002439")]
		public static readonly Color Azure;

		// Token: 0x04001E58 RID: 7768
		[global::Cpp2ILInjected.Token(Token = "0x400243A")]
		public static readonly Color Beige;

		// Token: 0x04001E59 RID: 7769
		[global::Cpp2ILInjected.Token(Token = "0x400243B")]
		public static readonly Color Bisque;

		// Token: 0x04001E5A RID: 7770
		[global::Cpp2ILInjected.Token(Token = "0x400243C")]
		public static readonly Color Black;

		// Token: 0x04001E5B RID: 7771
		[global::Cpp2ILInjected.Token(Token = "0x400243D")]
		public static readonly Color BlanchedAlmond;

		// Token: 0x04001E5C RID: 7772
		[global::Cpp2ILInjected.Token(Token = "0x400243E")]
		public static readonly Color Blue;

		// Token: 0x04001E5D RID: 7773
		[global::Cpp2ILInjected.Token(Token = "0x400243F")]
		public static readonly Color BlueViolet;

		// Token: 0x04001E5E RID: 7774
		[global::Cpp2ILInjected.Token(Token = "0x4002440")]
		public static readonly Color Brown;

		// Token: 0x04001E5F RID: 7775
		[global::Cpp2ILInjected.Token(Token = "0x4002441")]
		public static readonly Color BurlyWood;

		// Token: 0x04001E60 RID: 7776
		[global::Cpp2ILInjected.Token(Token = "0x4002442")]
		public static readonly Color CadetBlue;

		// Token: 0x04001E61 RID: 7777
		[global::Cpp2ILInjected.Token(Token = "0x4002443")]
		public static readonly Color Chartreuse;

		// Token: 0x04001E62 RID: 7778
		[global::Cpp2ILInjected.Token(Token = "0x4002444")]
		public static readonly Color Chocolate;

		// Token: 0x04001E63 RID: 7779
		[global::Cpp2ILInjected.Token(Token = "0x4002445")]
		public static readonly Color Coral;

		// Token: 0x04001E64 RID: 7780
		[global::Cpp2ILInjected.Token(Token = "0x4002446")]
		public static readonly Color CornflowerBlue;

		// Token: 0x04001E65 RID: 7781
		[global::Cpp2ILInjected.Token(Token = "0x4002447")]
		public static readonly Color Cornsilk;

		// Token: 0x04001E66 RID: 7782
		[global::Cpp2ILInjected.Token(Token = "0x4002448")]
		public static readonly Color Crimson;

		// Token: 0x04001E67 RID: 7783
		[global::Cpp2ILInjected.Token(Token = "0x4002449")]
		public static readonly Color Cyan;

		// Token: 0x04001E68 RID: 7784
		[global::Cpp2ILInjected.Token(Token = "0x400244A")]
		public static readonly Color DarkBlue;

		// Token: 0x04001E69 RID: 7785
		[global::Cpp2ILInjected.Token(Token = "0x400244B")]
		public static readonly Color DarkCyan;

		// Token: 0x04001E6A RID: 7786
		[global::Cpp2ILInjected.Token(Token = "0x400244C")]
		public static readonly Color DarkGoldenrod;

		// Token: 0x04001E6B RID: 7787
		[global::Cpp2ILInjected.Token(Token = "0x400244D")]
		public static readonly Color DarkGray;

		// Token: 0x04001E6C RID: 7788
		[global::Cpp2ILInjected.Token(Token = "0x400244E")]
		public static readonly Color DarkGreen;

		// Token: 0x04001E6D RID: 7789
		[global::Cpp2ILInjected.Token(Token = "0x400244F")]
		public static readonly Color DarkKhaki;

		// Token: 0x04001E6E RID: 7790
		[global::Cpp2ILInjected.Token(Token = "0x4002450")]
		public static readonly Color DarkMagenta;

		// Token: 0x04001E6F RID: 7791
		[global::Cpp2ILInjected.Token(Token = "0x4002451")]
		public static readonly Color DarkOliveGreen;

		// Token: 0x04001E70 RID: 7792
		[global::Cpp2ILInjected.Token(Token = "0x4002452")]
		public static readonly Color DarkOrange;

		// Token: 0x04001E71 RID: 7793
		[global::Cpp2ILInjected.Token(Token = "0x4002453")]
		public static readonly Color DarkOrchid;

		// Token: 0x04001E72 RID: 7794
		[global::Cpp2ILInjected.Token(Token = "0x4002454")]
		public static readonly Color DarkRed;

		// Token: 0x04001E73 RID: 7795
		[global::Cpp2ILInjected.Token(Token = "0x4002455")]
		public static readonly Color DarkSalmon;

		// Token: 0x04001E74 RID: 7796
		[global::Cpp2ILInjected.Token(Token = "0x4002456")]
		public static readonly Color DarkSeaGreen;

		// Token: 0x04001E75 RID: 7797
		[global::Cpp2ILInjected.Token(Token = "0x4002457")]
		public static readonly Color DarkSlateBlue;

		// Token: 0x04001E76 RID: 7798
		[global::Cpp2ILInjected.Token(Token = "0x4002458")]
		public static readonly Color DarkSlateGray;

		// Token: 0x04001E77 RID: 7799
		[global::Cpp2ILInjected.Token(Token = "0x4002459")]
		public static readonly Color DarkTurquoise;

		// Token: 0x04001E78 RID: 7800
		[global::Cpp2ILInjected.Token(Token = "0x400245A")]
		public static readonly Color DarkViolet;

		// Token: 0x04001E79 RID: 7801
		[global::Cpp2ILInjected.Token(Token = "0x400245B")]
		public static readonly Color DeepPink;

		// Token: 0x04001E7A RID: 7802
		[global::Cpp2ILInjected.Token(Token = "0x400245C")]
		public static readonly Color DeepSkyBlue;

		// Token: 0x04001E7B RID: 7803
		[global::Cpp2ILInjected.Token(Token = "0x400245D")]
		public static readonly Color DimGray;

		// Token: 0x04001E7C RID: 7804
		[global::Cpp2ILInjected.Token(Token = "0x400245E")]
		public static readonly Color DodgerBlue;

		// Token: 0x04001E7D RID: 7805
		[global::Cpp2ILInjected.Token(Token = "0x400245F")]
		public static readonly Color Firebrick;

		// Token: 0x04001E7E RID: 7806
		[global::Cpp2ILInjected.Token(Token = "0x4002460")]
		public static readonly Color FloralWhite;

		// Token: 0x04001E7F RID: 7807
		[global::Cpp2ILInjected.Token(Token = "0x4002461")]
		public static readonly Color ForestGreen;

		// Token: 0x04001E80 RID: 7808
		[global::Cpp2ILInjected.Token(Token = "0x4002462")]
		public static readonly Color Fuchsia;

		// Token: 0x04001E81 RID: 7809
		[global::Cpp2ILInjected.Token(Token = "0x4002463")]
		public static readonly Color Gainsboro;

		// Token: 0x04001E82 RID: 7810
		[global::Cpp2ILInjected.Token(Token = "0x4002464")]
		public static readonly Color GhostWhite;

		// Token: 0x04001E83 RID: 7811
		[global::Cpp2ILInjected.Token(Token = "0x4002465")]
		public static readonly Color Gold;

		// Token: 0x04001E84 RID: 7812
		[global::Cpp2ILInjected.Token(Token = "0x4002466")]
		public static readonly Color Goldenrod;

		// Token: 0x04001E85 RID: 7813
		[global::Cpp2ILInjected.Token(Token = "0x4002467")]
		public static readonly Color Gray;

		// Token: 0x04001E86 RID: 7814
		[global::Cpp2ILInjected.Token(Token = "0x4002468")]
		public static readonly Color Green;

		// Token: 0x04001E87 RID: 7815
		[global::Cpp2ILInjected.Token(Token = "0x4002469")]
		public static readonly Color GreenYellow;

		// Token: 0x04001E88 RID: 7816
		[global::Cpp2ILInjected.Token(Token = "0x400246A")]
		public static readonly Color Honeydew;

		// Token: 0x04001E89 RID: 7817
		[global::Cpp2ILInjected.Token(Token = "0x400246B")]
		public static readonly Color HotPink;

		// Token: 0x04001E8A RID: 7818
		[global::Cpp2ILInjected.Token(Token = "0x400246C")]
		public static readonly Color IndianRed;

		// Token: 0x04001E8B RID: 7819
		[global::Cpp2ILInjected.Token(Token = "0x400246D")]
		public static readonly Color Indigo;

		// Token: 0x04001E8C RID: 7820
		[global::Cpp2ILInjected.Token(Token = "0x400246E")]
		public static readonly Color Ivory;

		// Token: 0x04001E8D RID: 7821
		[global::Cpp2ILInjected.Token(Token = "0x400246F")]
		public static readonly Color Khaki;

		// Token: 0x04001E8E RID: 7822
		[global::Cpp2ILInjected.Token(Token = "0x4002470")]
		public static readonly Color Lavender;

		// Token: 0x04001E8F RID: 7823
		[global::Cpp2ILInjected.Token(Token = "0x4002471")]
		public static readonly Color LavenderBlush;

		// Token: 0x04001E90 RID: 7824
		[global::Cpp2ILInjected.Token(Token = "0x4002472")]
		public static readonly Color LawnGreen;

		// Token: 0x04001E91 RID: 7825
		[global::Cpp2ILInjected.Token(Token = "0x4002473")]
		public static readonly Color LemonChiffon;

		// Token: 0x04001E92 RID: 7826
		[global::Cpp2ILInjected.Token(Token = "0x4002474")]
		public static readonly Color LightBlue;

		// Token: 0x04001E93 RID: 7827
		[global::Cpp2ILInjected.Token(Token = "0x4002475")]
		public static readonly Color LightCoral;

		// Token: 0x04001E94 RID: 7828
		[global::Cpp2ILInjected.Token(Token = "0x4002476")]
		public static readonly Color LightCyan;

		// Token: 0x04001E95 RID: 7829
		[global::Cpp2ILInjected.Token(Token = "0x4002477")]
		public static readonly Color LightGoldenrodYellow;

		// Token: 0x04001E96 RID: 7830
		[global::Cpp2ILInjected.Token(Token = "0x4002478")]
		public static readonly Color LightGreen;

		// Token: 0x04001E97 RID: 7831
		[global::Cpp2ILInjected.Token(Token = "0x4002479")]
		public static readonly Color LightGray;

		// Token: 0x04001E98 RID: 7832
		[global::Cpp2ILInjected.Token(Token = "0x400247A")]
		public static readonly Color LightPink;

		// Token: 0x04001E99 RID: 7833
		[global::Cpp2ILInjected.Token(Token = "0x400247B")]
		public static readonly Color LightSalmon;

		// Token: 0x04001E9A RID: 7834
		[global::Cpp2ILInjected.Token(Token = "0x400247C")]
		public static readonly Color LightSeaGreen;

		// Token: 0x04001E9B RID: 7835
		[global::Cpp2ILInjected.Token(Token = "0x400247D")]
		public static readonly Color LightSkyBlue;

		// Token: 0x04001E9C RID: 7836
		[global::Cpp2ILInjected.Token(Token = "0x400247E")]
		public static readonly Color LightSlateGray;

		// Token: 0x04001E9D RID: 7837
		[global::Cpp2ILInjected.Token(Token = "0x400247F")]
		public static readonly Color LightSteelBlue;

		// Token: 0x04001E9E RID: 7838
		[global::Cpp2ILInjected.Token(Token = "0x4002480")]
		public static readonly Color LightYellow;

		// Token: 0x04001E9F RID: 7839
		[global::Cpp2ILInjected.Token(Token = "0x4002481")]
		public static readonly Color Lime;

		// Token: 0x04001EA0 RID: 7840
		[global::Cpp2ILInjected.Token(Token = "0x4002482")]
		public static readonly Color LimeGreen;

		// Token: 0x04001EA1 RID: 7841
		[global::Cpp2ILInjected.Token(Token = "0x4002483")]
		public static readonly Color Linen;

		// Token: 0x04001EA2 RID: 7842
		[global::Cpp2ILInjected.Token(Token = "0x4002484")]
		public static readonly Color Magenta;

		// Token: 0x04001EA3 RID: 7843
		[global::Cpp2ILInjected.Token(Token = "0x4002485")]
		public static readonly Color Maroon;

		// Token: 0x04001EA4 RID: 7844
		[global::Cpp2ILInjected.Token(Token = "0x4002486")]
		public static readonly Color MediumAquamarine;

		// Token: 0x04001EA5 RID: 7845
		[global::Cpp2ILInjected.Token(Token = "0x4002487")]
		public static readonly Color MediumBlue;

		// Token: 0x04001EA6 RID: 7846
		[global::Cpp2ILInjected.Token(Token = "0x4002488")]
		public static readonly Color MediumOrchid;

		// Token: 0x04001EA7 RID: 7847
		[global::Cpp2ILInjected.Token(Token = "0x4002489")]
		public static readonly Color MediumPurple;

		// Token: 0x04001EA8 RID: 7848
		[global::Cpp2ILInjected.Token(Token = "0x400248A")]
		public static readonly Color MediumSeaGreen;

		// Token: 0x04001EA9 RID: 7849
		[global::Cpp2ILInjected.Token(Token = "0x400248B")]
		public static readonly Color MediumSlateBlue;

		// Token: 0x04001EAA RID: 7850
		[global::Cpp2ILInjected.Token(Token = "0x400248C")]
		public static readonly Color MediumSpringGreen;

		// Token: 0x04001EAB RID: 7851
		[global::Cpp2ILInjected.Token(Token = "0x400248D")]
		public static readonly Color MediumTurquoise;

		// Token: 0x04001EAC RID: 7852
		[global::Cpp2ILInjected.Token(Token = "0x400248E")]
		public static readonly Color MediumVioletRed;

		// Token: 0x04001EAD RID: 7853
		[global::Cpp2ILInjected.Token(Token = "0x400248F")]
		public static readonly Color MidnightBlue;

		// Token: 0x04001EAE RID: 7854
		[global::Cpp2ILInjected.Token(Token = "0x4002490")]
		public static readonly Color MintCream;

		// Token: 0x04001EAF RID: 7855
		[global::Cpp2ILInjected.Token(Token = "0x4002491")]
		public static readonly Color MistyRose;

		// Token: 0x04001EB0 RID: 7856
		[global::Cpp2ILInjected.Token(Token = "0x4002492")]
		public static readonly Color Moccasin;

		// Token: 0x04001EB1 RID: 7857
		[global::Cpp2ILInjected.Token(Token = "0x4002493")]
		public static readonly Color NavajoWhite;

		// Token: 0x04001EB2 RID: 7858
		[global::Cpp2ILInjected.Token(Token = "0x4002494")]
		public static readonly Color Navy;

		// Token: 0x04001EB3 RID: 7859
		[global::Cpp2ILInjected.Token(Token = "0x4002495")]
		public static readonly Color OldLace;

		// Token: 0x04001EB4 RID: 7860
		[global::Cpp2ILInjected.Token(Token = "0x4002496")]
		public static readonly Color Olive;

		// Token: 0x04001EB5 RID: 7861
		[global::Cpp2ILInjected.Token(Token = "0x4002497")]
		public static readonly Color OliveDrab;

		// Token: 0x04001EB6 RID: 7862
		[global::Cpp2ILInjected.Token(Token = "0x4002498")]
		public static readonly Color Orange;

		// Token: 0x04001EB7 RID: 7863
		[global::Cpp2ILInjected.Token(Token = "0x4002499")]
		public static readonly Color OrangeRed;

		// Token: 0x04001EB8 RID: 7864
		[global::Cpp2ILInjected.Token(Token = "0x400249A")]
		public static readonly Color Orchid;

		// Token: 0x04001EB9 RID: 7865
		[global::Cpp2ILInjected.Token(Token = "0x400249B")]
		public static readonly Color PaleGoldenrod;

		// Token: 0x04001EBA RID: 7866
		[global::Cpp2ILInjected.Token(Token = "0x400249C")]
		public static readonly Color PaleGreen;

		// Token: 0x04001EBB RID: 7867
		[global::Cpp2ILInjected.Token(Token = "0x400249D")]
		public static readonly Color PaleTurquoise;

		// Token: 0x04001EBC RID: 7868
		[global::Cpp2ILInjected.Token(Token = "0x400249E")]
		public static readonly Color PaleVioletRed;

		// Token: 0x04001EBD RID: 7869
		[global::Cpp2ILInjected.Token(Token = "0x400249F")]
		public static readonly Color PapayaWhip;

		// Token: 0x04001EBE RID: 7870
		[global::Cpp2ILInjected.Token(Token = "0x40024A0")]
		public static readonly Color PeachPuff;

		// Token: 0x04001EBF RID: 7871
		[global::Cpp2ILInjected.Token(Token = "0x40024A1")]
		public static readonly Color Peru;

		// Token: 0x04001EC0 RID: 7872
		[global::Cpp2ILInjected.Token(Token = "0x40024A2")]
		public static readonly Color Pink;

		// Token: 0x04001EC1 RID: 7873
		[global::Cpp2ILInjected.Token(Token = "0x40024A3")]
		public static readonly Color Plum;

		// Token: 0x04001EC2 RID: 7874
		[global::Cpp2ILInjected.Token(Token = "0x40024A4")]
		public static readonly Color PowderBlue;

		// Token: 0x04001EC3 RID: 7875
		[global::Cpp2ILInjected.Token(Token = "0x40024A5")]
		public static readonly Color Purple;

		// Token: 0x04001EC4 RID: 7876
		[global::Cpp2ILInjected.Token(Token = "0x40024A6")]
		public static readonly Color Red;

		// Token: 0x04001EC5 RID: 7877
		[global::Cpp2ILInjected.Token(Token = "0x40024A7")]
		public static readonly Color RosyBrown;

		// Token: 0x04001EC6 RID: 7878
		[global::Cpp2ILInjected.Token(Token = "0x40024A8")]
		public static readonly Color RoyalBlue;

		// Token: 0x04001EC7 RID: 7879
		[global::Cpp2ILInjected.Token(Token = "0x40024A9")]
		public static readonly Color SaddleBrown;

		// Token: 0x04001EC8 RID: 7880
		[global::Cpp2ILInjected.Token(Token = "0x40024AA")]
		public static readonly Color Salmon;

		// Token: 0x04001EC9 RID: 7881
		[global::Cpp2ILInjected.Token(Token = "0x40024AB")]
		public static readonly Color SandyBrown;

		// Token: 0x04001ECA RID: 7882
		[global::Cpp2ILInjected.Token(Token = "0x40024AC")]
		public static readonly Color SeaGreen;

		// Token: 0x04001ECB RID: 7883
		[global::Cpp2ILInjected.Token(Token = "0x40024AD")]
		public static readonly Color SeaShell;

		// Token: 0x04001ECC RID: 7884
		[global::Cpp2ILInjected.Token(Token = "0x40024AE")]
		public static readonly Color Sienna;

		// Token: 0x04001ECD RID: 7885
		[global::Cpp2ILInjected.Token(Token = "0x40024AF")]
		public static readonly Color Silver;

		// Token: 0x04001ECE RID: 7886
		[global::Cpp2ILInjected.Token(Token = "0x40024B0")]
		public static readonly Color SkyBlue;

		// Token: 0x04001ECF RID: 7887
		[global::Cpp2ILInjected.Token(Token = "0x40024B1")]
		public static readonly Color SlateBlue;

		// Token: 0x04001ED0 RID: 7888
		[global::Cpp2ILInjected.Token(Token = "0x40024B2")]
		public static readonly Color SlateGray;

		// Token: 0x04001ED1 RID: 7889
		[global::Cpp2ILInjected.Token(Token = "0x40024B3")]
		public static readonly Color Snow;

		// Token: 0x04001ED2 RID: 7890
		[global::Cpp2ILInjected.Token(Token = "0x40024B4")]
		public static readonly Color SpringGreen;

		// Token: 0x04001ED3 RID: 7891
		[global::Cpp2ILInjected.Token(Token = "0x40024B5")]
		public static readonly Color SteelBlue;

		// Token: 0x04001ED4 RID: 7892
		[global::Cpp2ILInjected.Token(Token = "0x40024B6")]
		public static readonly Color Tan;

		// Token: 0x04001ED5 RID: 7893
		[global::Cpp2ILInjected.Token(Token = "0x40024B7")]
		public static readonly Color Teal;

		// Token: 0x04001ED6 RID: 7894
		[global::Cpp2ILInjected.Token(Token = "0x40024B8")]
		public static readonly Color Thistle;

		// Token: 0x04001ED7 RID: 7895
		[global::Cpp2ILInjected.Token(Token = "0x40024B9")]
		public static readonly Color Tomato;

		// Token: 0x04001ED8 RID: 7896
		[global::Cpp2ILInjected.Token(Token = "0x40024BA")]
		public static readonly Color Turquoise;

		// Token: 0x04001ED9 RID: 7897
		[global::Cpp2ILInjected.Token(Token = "0x40024BB")]
		public static readonly Color Violet;

		// Token: 0x04001EDA RID: 7898
		[global::Cpp2ILInjected.Token(Token = "0x40024BC")]
		public static readonly Color Wheat;

		// Token: 0x04001EDB RID: 7899
		[global::Cpp2ILInjected.Token(Token = "0x40024BD")]
		public static readonly Color White;

		// Token: 0x04001EDC RID: 7900
		[global::Cpp2ILInjected.Token(Token = "0x40024BE")]
		public static readonly Color WhiteSmoke;

		// Token: 0x04001EDD RID: 7901
		[global::Cpp2ILInjected.Token(Token = "0x40024BF")]
		public static readonly Color Yellow;

		// Token: 0x04001EDE RID: 7902
		[global::Cpp2ILInjected.Token(Token = "0x40024C0")]
		public static readonly Color YellowGreen;
	}
}
