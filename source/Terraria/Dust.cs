using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Events;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Initializers;
using Terraria.Utilities;
using Unity.IL2CPP.CompilerServices;

namespace Terraria
{
	// Token: 0x02000312 RID: 786
	[global::Cpp2ILInjected.Token(Token = "0x20003EC")]
	public class Dust
	{
		// Token: 0x06001940 RID: 6464 RVA: 0x0002661E File Offset: 0x0002481E
		[global::Cpp2ILInjected.Token(Token = "0x6001AD1")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD7890", Offset = "0xAD7890", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_Entities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "clearWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void Reset()
		{
			throw null;
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x00026621 File Offset: 0x00024821
		[global::Cpp2ILInjected.Token(Token = "0x6001AD2")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD79EC", Offset = "0xAD79EC", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 156)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static Dust NewDustPerfect(Vector2 Position, int Type, Vector2? Velocity = null, int Alpha = 0, Color newColor = default(Color), float Scale = 1f)
		{
			throw null;
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x00026624 File Offset: 0x00024824
		[global::Cpp2ILInjected.Token(Token = "0x6001AD3")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD86DC", Offset = "0xAD86DC", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 283)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "HasNaNs", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static Dust NewDustDirect(Vector2 Position, int Width, int Height, int Type, float SpeedX = 0f, float SpeedY = 0f, int Alpha = 0, Color newColor = default(Color), float Scale = 1f)
		{
			throw null;
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x00026627 File Offset: 0x00024827
		[global::Cpp2ILInjected.Token(Token = "0x6001AD4")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD7B2C", Offset = "0xAD7B2C", Length = "0xBB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1914)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHostOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "WetCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "SetNotActive", MemberParameters = new object[] { typeof(Dust) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 66)]
		public static int NewDust(Vector2 Position, int Width, int Height, int Type, float SpeedX = 0f, float SpeedY = 0f, int Alpha = 0, Color newColor = default(Color), float Scale = 1f)
		{
			throw null;
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x0002662A File Offset: 0x0002482A
		[global::Cpp2ILInjected.Token(Token = "0x6001AD5")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD893C", Offset = "0xAD893C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_065_Butterflies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_120_HallowBoss", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "HitEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_ApplyUseStyle", MemberParameters = new object[]
		{
			typeof(float),
			typeof(Item),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_186_PrincessWeapon", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "DoRainbowCrystalStaffExplosion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_PaladinsHammer", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_PrincessWeapon", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_StardustPunch", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_RainbowRodHit", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Dust CloneDust(int dustIndex)
		{
			throw null;
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x0002662D File Offset: 0x0002482D
		[global::Cpp2ILInjected.Token(Token = "0x6001AD6")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD89C8", Offset = "0xAD89C8", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TeleportEffect", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(TeleportationSide),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "WingFrame", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "LightDisc_Bounce", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_165_Whip", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_001", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "DoSpawnDust", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static Dust CloneDust(Dust rf)
		{
			throw null;
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x00026630 File Offset: 0x00024830
		[global::Cpp2ILInjected.Token(Token = "0x6001AD7")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD8884", Offset = "0xAD8884", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "UpdateDust", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawDust", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void SetNotActive(Dust dust)
		{
			throw null;
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00026633 File Offset: 0x00024833
		[global::Cpp2ILInjected.Token(Token = "0x6001AD8")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD8B24", Offset = "0xAD8B24", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "QuickDust", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Color)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Dust QuickDust(int x, int y, Color color)
		{
			throw null;
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00026636 File Offset: 0x00024836
		[global::Cpp2ILInjected.Token(Token = "0x6001AD9")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD8BB0", Offset = "0xAD8BB0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "QuickDust", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StrayMethods), Member = "SendWalker", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref Point),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TownRoomManager), Member = "DisplayRooms", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToWorldCoordinates", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Dust QuickDust(Point tileCoords, Color color)
		{
			throw null;
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00026639 File Offset: 0x00024839
		[global::Cpp2ILInjected.Token(Token = "0x6001ADA")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD8DB4", Offset = "0xAD8DB4", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StrayMethods), Member = "SendWalker", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref Point),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "QuickDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void QuickBox(Vector2 topLeft, Vector2 bottomRight, int divisions, Color color, Action<Dust> manipulator)
		{
			throw null;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x0002663C File Offset: 0x0002483C
		[global::Cpp2ILInjected.Token(Token = "0x6001ADB")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD9004", Offset = "0xAD9004", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "TopLeft", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "BottomRight", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "QuickDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void DrawDebugBox(Rectangle itemRectangle)
		{
			throw null;
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x0002663F File Offset: 0x0002483F
		[global::Cpp2ILInjected.Token(Token = "0x6001ADC")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD8C60", Offset = "0xAD8C60", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "QuickBox", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(Color),
			typeof(Action<Dust>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "DrawDebugBox", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "QuickDustSmall", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Color),
			typeof(bool)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "QuickDustLine", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCFollowState), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static Dust QuickDust(Vector2 pos, Color color)
		{
			throw null;
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x00026642 File Offset: 0x00024842
		[global::Cpp2ILInjected.Token(Token = "0x6001ADD")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD91EC", Offset = "0xAD91EC", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "QuickDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Floor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Dust QuickDustSmall(Vector2 pos, Color color, bool floorPositionValues = false)
		{
			throw null;
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00026645 File Offset: 0x00024845
		[global::Cpp2ILInjected.Token(Token = "0x6001ADE")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD92C0", Offset = "0xAD92C0", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "QuickDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void QuickDustLine(Vector2 start, Vector2 end, float splits, Color color)
		{
			throw null;
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x00026648 File Offset: 0x00024848
		[global::Cpp2ILInjected.Token(Token = "0x6001ADF")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD9410", Offset = "0xAD9410", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "MoveInWorld", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(ref Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TeleportEffect", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(TeleportationSide),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "Collision_WaterCollision", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_016", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_061_FishingBobber_DoASplash", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegateMethods), Member = "SpreadWater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rain), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_waterStyle", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int dustWater()
		{
			throw null;
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x0002664B File Offset: 0x0002484B
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6001AE0")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD9484", Offset = "0xAD9484", Length = "0x77DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sandstorm), Member = "ShouldSandstormDustPersist", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChildSafety), Member = "get_Disabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "SetNotActive", MemberParameters = new object[] { typeof(Dust) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChildSafety), Member = "DangerousDust", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(float)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "SolidCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(float)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "WetCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Remap", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 287)]
		public static void UpdateDust()
		{
			throw null;
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x0002664E File Offset: 0x0002484E
		[global::Cpp2ILInjected.Token(Token = "0x6001AE1")]
		[global::Cpp2ILInjected.Address(RVA = "0xAE0C60", Offset = "0xAE0C60", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "InitAlphaTable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 48)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void SetupAlpha(short id, Color value)
		{
			throw null;
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x00026651 File Offset: 0x00024851
		[global::Cpp2ILInjected.Token(Token = "0x6001AE2")]
		[global::Cpp2ILInjected.Address(RVA = "0xAE0CE0", Offset = "0xAE0CE0", Length = "0x8A8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.AssetInitializer.<LoadTextures_InSteps>d__11", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadTextures", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "SetupAlpha", MemberParameters = new object[]
		{
			typeof(short),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void InitAlphaTable()
		{
			throw null;
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00026654 File Offset: 0x00024854
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6001AE3")]
		[global::Cpp2ILInjected.Address(RVA = "0xAE1588", Offset = "0xAE1588", Length = "0x838")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawDust", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public void GetAlpha(ref Color newColor)
		{
			throw null;
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x00026657 File Offset: 0x00024857
		[global::Cpp2ILInjected.Token(Token = "0x6001AE4")]
		[global::Cpp2ILInjected.Address(RVA = "0xAE1DC0", Offset = "0xAE1DC0", Length = "0xB34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector4),
			typeof(Vector4)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public Color GetAlpha(Color newColor)
		{
			throw null;
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x0002665A File Offset: 0x0002485A
		[global::Cpp2ILInjected.Token(Token = "0x6001AE5")]
		[global::Cpp2ILInjected.Address(RVA = "0xAE28F4", Offset = "0xAE28F4", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawDust", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void GetColor(ref Color newColor)
		{
			throw null;
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x0002665D File Offset: 0x0002485D
		[global::Cpp2ILInjected.Token(Token = "0x6001AE6")]
		[global::Cpp2ILInjected.Address(RVA = "0xAE2990", Offset = "0xAE2990", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawDust", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public float GetVisualRotation()
		{
			throw null;
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x00026660 File Offset: 0x00024860
		[global::Cpp2ILInjected.Token(Token = "0x6001AE7")]
		[global::Cpp2ILInjected.Address(RVA = "0xAE29A8", Offset = "0xAE29A8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawDust", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public float GetVisualScale()
		{
			throw null;
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x00026663 File Offset: 0x00024863
		[global::Cpp2ILInjected.Token(Token = "0x6001AE8")]
		[global::Cpp2ILInjected.Address(RVA = "0xAD79E4", Offset = "0xAD79E4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Dust()
		{
			throw null;
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00026666 File Offset: 0x00024866
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001AE9")]
		[global::Cpp2ILInjected.Address(RVA = "0xAE29C4", Offset = "0xAE29C4", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		static Dust()
		{
			throw null;
		}

		// Token: 0x04002194 RID: 8596
		[global::Cpp2ILInjected.Token(Token = "0x4002806")]
		public static int activeDustCount;

		// Token: 0x04002195 RID: 8597
		[global::Cpp2ILInjected.Token(Token = "0x4002807")]
		public static Dust[] freeDust;

		// Token: 0x04002196 RID: 8598
		[global::Cpp2ILInjected.Token(Token = "0x4002808")]
		public static int freeDustCount;

		// Token: 0x04002197 RID: 8599
		[global::Cpp2ILInjected.Token(Token = "0x4002809")]
		public static float dCount;

		// Token: 0x04002198 RID: 8600
		[global::Cpp2ILInjected.Token(Token = "0x400280A")]
		public static int lavaBubbles;

		// Token: 0x04002199 RID: 8601
		[global::Cpp2ILInjected.Token(Token = "0x400280B")]
		public static int SandStormCount;

		// Token: 0x0400219A RID: 8602
		[global::Cpp2ILInjected.Token(Token = "0x400280C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int dustIndex;

		// Token: 0x0400219B RID: 8603
		[global::Cpp2ILInjected.Token(Token = "0x400280D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public Vector2 position;

		// Token: 0x0400219C RID: 8604
		[global::Cpp2ILInjected.Token(Token = "0x400280E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public Vector2 velocity;

		// Token: 0x0400219D RID: 8605
		[global::Cpp2ILInjected.Token(Token = "0x400280F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public float fadeIn;

		// Token: 0x0400219E RID: 8606
		[global::Cpp2ILInjected.Token(Token = "0x4002810")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public bool noGravity;

		// Token: 0x0400219F RID: 8607
		[global::Cpp2ILInjected.Token(Token = "0x4002811")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public float scale;

		// Token: 0x040021A0 RID: 8608
		[global::Cpp2ILInjected.Token(Token = "0x4002812")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public float rotation;

		// Token: 0x040021A1 RID: 8609
		[global::Cpp2ILInjected.Token(Token = "0x4002813")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public bool noLight;

		// Token: 0x040021A2 RID: 8610
		[global::Cpp2ILInjected.Token(Token = "0x4002814")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x35")]
		public bool noLightEmittence;

		// Token: 0x040021A3 RID: 8611
		[global::Cpp2ILInjected.Token(Token = "0x4002815")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x36")]
		public bool active;

		// Token: 0x040021A4 RID: 8612
		[global::Cpp2ILInjected.Token(Token = "0x4002816")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int type;

		// Token: 0x040021A5 RID: 8613
		[global::Cpp2ILInjected.Token(Token = "0x4002817")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public Color color;

		// Token: 0x040021A6 RID: 8614
		[global::Cpp2ILInjected.Token(Token = "0x4002818")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public int alpha;

		// Token: 0x040021A7 RID: 8615
		[global::Cpp2ILInjected.Token(Token = "0x4002819")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public Rectangle frame;

		// Token: 0x040021A8 RID: 8616
		[global::Cpp2ILInjected.Token(Token = "0x400281A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public ArmorShaderData shader;

		// Token: 0x040021A9 RID: 8617
		[global::Cpp2ILInjected.Token(Token = "0x400281B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public object customData;

		// Token: 0x040021AA RID: 8618
		[global::Cpp2ILInjected.Token(Token = "0x400281C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public bool firstFrame;

		// Token: 0x040021AB RID: 8619
		[global::Cpp2ILInjected.Token(Token = "0x400281D")]
		private static bool[] StaticAlpha;

		// Token: 0x040021AC RID: 8620
		[global::Cpp2ILInjected.Token(Token = "0x400281E")]
		private static Color[] StaticAlphaValue;
	}
}
