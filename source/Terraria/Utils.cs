using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Graphics.PackedVector;
using Microsoft.Xna.Framework.Input;
using ReLogic.Content;
using ReLogic.Utilities;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Animations;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Biomes.Desert;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Events;
using Terraria.GameContent.Generation;
using Terraria.GameContent.Golf;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.ObjectInteractions;
using Terraria.GameContent.Shaders;
using Terraria.GameContent.Skies;
using Terraria.GameContent.Skies.CreditsRoll;
using Terraria.GameContent.Tile_Entities;
using Terraria.GameContent.UI;
using Terraria.GameContent.UI.BigProgressBar;
using Terraria.GameContent.UI.Chat;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.States;
using Terraria.GameInput;
using Terraria.Graphics;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Light;
using Terraria.Graphics.Renderers;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.Map;
using Terraria.Net;
using Terraria.ObjectData;
using Terraria.Physics;
using Terraria.UI;
using Terraria.UI.Chat;
using Terraria.Utilities;
using Terraria.Utilities.Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria
{
	// Token: 0x0200034E RID: 846
	[global::Cpp2ILInjected.Token(Token = "0x2000465")]
	public static class Utils
	{
		// Token: 0x06002886 RID: 10374 RVA: 0x000293C9 File Offset: 0x000275C9
		[global::Cpp2ILInjected.Token(Token = "0x6002B40")]
		[global::Cpp2ILInjected.Address(RVA = "0x117D5E0", Offset = "0x117D5E0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Color ColorLerp_BlackToWhite(float percent)
		{
			throw null;
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x000293CC File Offset: 0x000275CC
		[global::Cpp2ILInjected.Token(Token = "0x6002B41")]
		[global::Cpp2ILInjected.Address(RVA = "0x117D658", Offset = "0x117D658", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "UpdateWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "SonOfLakinater", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeRoot), Member = "DoRoot", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction),
			typeof(double),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarbleBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public static double Lerp(double value1, double value2, double amount)
		{
			throw null;
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x000293CF File Offset: 0x000275CF
		[global::Cpp2ILInjected.Token(Token = "0x6002B42")]
		[global::Cpp2ILInjected.Address(RVA = "0x117D668", Offset = "0x117D668", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ClampScreenPositionToWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Vector2 Round(Vector2 input)
		{
			throw null;
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x000293D2 File Offset: 0x000275D2
		[global::Cpp2ILInjected.Token(Token = "0x6002B43")]
		[global::Cpp2ILInjected.Address(RVA = "0x117D7D8", Offset = "0x117D7D8", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool IsPowerOfTwo(int x)
		{
			throw null;
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x000293D5 File Offset: 0x000275D5
		[global::Cpp2ILInjected.Token(Token = "0x6002B44")]
		[global::Cpp2ILInjected.Address(RVA = "0x117D7F8", Offset = "0x117D7F8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BloodMoonScreenShaderData), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SepiaScreenShaderData), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonLordSky), Member = "GetIntensity", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static float SmoothStep(float min, float max, float x)
		{
			throw null;
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x000293D8 File Offset: 0x000275D8
		[global::Cpp2ILInjected.Token(Token = "0x6002B45")]
		[global::Cpp2ILInjected.Address(RVA = "0x117D814", Offset = "0x117D814", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Clamp", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T", "T", "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static double SmoothStep(double min, double max, double x)
		{
			throw null;
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x000293DB File Offset: 0x000275DB
		[global::Cpp2ILInjected.Token(Token = "0x6002B46")]
		[global::Cpp2ILInjected.Address(RVA = "0x117D8A8", Offset = "0x117D8A8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static float UnclampedSmoothStep(float min, float max, float x)
		{
			throw null;
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x000293DE File Offset: 0x000275DE
		[global::Cpp2ILInjected.Token(Token = "0x6002B47")]
		[global::Cpp2ILInjected.Address(RVA = "0x117D8B8", Offset = "0x117D8B8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SandMound), Member = "Place", MemberParameters = new object[] { typeof(DesertDescription) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static double UnclampedSmoothStep(double min, double max, double x)
		{
			throw null;
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x000293E1 File Offset: 0x000275E1
		[global::Cpp2ILInjected.Token(Token = "0x6002B48")]
		[global::Cpp2ILInjected.Address(RVA = "0x117D8C8", Offset = "0x117D8C8", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Program), Member = "LaunchGame", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static Dictionary<string, string> ParseArguements(string[] args)
		{
			throw null;
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x000293E4 File Offset: 0x000275E4
		[global::Cpp2ILInjected.Token(Token = "0x6002B49")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A42A4", Offset = "0x15A42A4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EquipmentLoadout), Member = "Swap", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "LeftClick", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public static void Swap<T>(ref T t1, ref T t2)
		{
			throw null;
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x000293E7 File Offset: 0x000275E7
		[global::Cpp2ILInjected.Token(Token = "0x6002B4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A3910", Offset = "0x15A3910", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "AdjustRespawnTimerForWorldJoining", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "neonMossBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "StonePatch", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ShellPile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "MarblePileWithStatues", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "OrePatch", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "UpdateWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "oceanCave", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "digTunnel", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double),
			typeof(double),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GenerationProgress), Member = "set_Value", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeRoot), Member = "DoRoot", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction),
			typeof(double),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TerrainPass), Member = "ApplyPass", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PitEntrance), Member = "PlaceAt", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PitEntrance), Member = "SmootherStep", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SandMound), Member = "Place", MemberParameters = new object[] { typeof(DesertDescription) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double), Member = "CompareTo", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(int))]
		public static T Clamp<T>(T value, T min, T max) where T : IComparable<T>
		{
			throw null;
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x000293EA File Offset: 0x000275EA
		[global::Cpp2ILInjected.Token(Token = "0x6002B4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x117DA84", Offset = "0x117DA84", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static float Turn01ToCyclic010(float value)
		{
			throw null;
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x000293ED File Offset: 0x000275ED
		[global::Cpp2ILInjected.Token(Token = "0x6002B4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x117DB08", Offset = "0x117DB08", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static float PingPongFrom01To010(float value)
		{
			throw null;
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x000293F0 File Offset: 0x000275F0
		[global::Cpp2ILInjected.Token(Token = "0x6002B4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x117DB4C", Offset = "0x117DB4C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetAttackDamage_ForProjectiles_MultiLerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegateMethods.CharacterPreview), Member = "CompanionCubePet", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegateMethods.CharacterPreview), Member = "SlimePet", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static float MultiLerp(float percent, params float[] floats)
		{
			throw null;
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x000293F3 File Offset: 0x000275F3
		[global::Cpp2ILInjected.Token(Token = "0x6002B4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x117DBD0", Offset = "0x117DBD0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_007_TownEntities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "FindFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetAlpha", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "GetAlpha", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static float WrappedLerp(float value1, float value2, float percent)
		{
			throw null;
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x000293F6 File Offset: 0x000275F6
		[global::Cpp2ILInjected.Token(Token = "0x6002B4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x117DBF0", Offset = "0x117DBF0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 301)]
		public static float GetLerpValue(float from, float to, float t, bool clamped = false)
		{
			throw null;
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x000293F9 File Offset: 0x000275F9
		[global::Cpp2ILInjected.Token(Token = "0x6002B50")]
		[global::Cpp2ILInjected.Address(RVA = "0x117DC44", Offset = "0x117DC44", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 209)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static float Remap(float fromValue, float fromMin, float fromMax, float toMin, float toMax, bool clamped = true)
		{
			throw null;
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x000293FC File Offset: 0x000275FC
		[global::Cpp2ILInjected.Token(Token = "0x6002B51")]
		[global::Cpp2ILInjected.Address(RVA = "0x117DD20", Offset = "0x117DD20", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_CutTiles", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Rectangle),
			typeof(bool[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void ClampWithinWorld(ref int minX, ref int minY, ref int maxX, ref int maxY, bool lastValuesInclusiveToIteration = false, int fluffX = 0, int fluffY = 0)
		{
			throw null;
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x000293FF File Offset: 0x000275FF
		[global::Cpp2ILInjected.Token(Token = "0x6002B52")]
		[global::Cpp2ILInjected.Address(RVA = "0x117DE90", Offset = "0x117DE90", Length = "0x348")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_003_Fighters", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "OnHit", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(Entity)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_066_TryInterceptingTarget", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_042", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Dot", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "SolveQuadratic", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref float),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static Utils.ChaseResults GetChaseResults(Vector2 chaserPosition, float chaserSpeed, Vector2 runnerPosition, Vector2 runnerVelocity)
		{
			throw null;
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x00029402 File Offset: 0x00027602
		[global::Cpp2ILInjected.Token(Token = "0x6002B53")]
		[global::Cpp2ILInjected.Address(RVA = "0x117E2CC", Offset = "0x117E2CC", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_003_Fighters", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Vector2 FactorAcceleration(Vector2 currentVelocity, float timeToInterception, Vector2 descendOfProjectile, int framesOfLenience)
		{
			throw null;
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x00029405 File Offset: 0x00027605
		[global::Cpp2ILInjected.Token(Token = "0x6002B54")]
		[global::Cpp2ILInjected.Address(RVA = "0x117E1D8", Offset = "0x117E1D8", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "GetChaseResults", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Utils.ChaseResults))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool SolveQuadratic(float a, float b, float c, out float result1, out float result2)
		{
			throw null;
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x00029408 File Offset: 0x00027608
		[global::Cpp2ILInjected.Token(Token = "0x6002B55")]
		[global::Cpp2ILInjected.Address(RVA = "0x117E3C4", Offset = "0x117E3C4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.GameTipsDisplay.GameTip", Member = "Update", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static double GetLerpValue(double from, double to, double t, bool clamped = false)
		{
			throw null;
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x0002940B File Offset: 0x0002760B
		[global::Cpp2ILInjected.Token(Token = "0x6002B56")]
		[global::Cpp2ILInjected.Address(RVA = "0x117E418", Offset = "0x117E418", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "GetDayTimeAsDirectionIn24HClock", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static float GetDayTimeAs24FloatStartingFromMidnight()
		{
			throw null;
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x0002940E File Offset: 0x0002760E
		[global::Cpp2ILInjected.Token(Token = "0x6002B57")]
		[global::Cpp2ILInjected.Address(RVA = "0x117E4D8", Offset = "0x117E4D8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SepiaScreenShaderData), Member = "GetDaylightPowers", MemberParameters = new object[]
		{
			typeof(ref float),
			typeof(ref float),
			typeof(ref float),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetDayTimeAs24FloatStartingFromMidnight", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2 GetDayTimeAsDirectionIn24HClock()
		{
			throw null;
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x00029411 File Offset: 0x00027611
		[global::Cpp2ILInjected.Token(Token = "0x6002B58")]
		[global::Cpp2ILInjected.Address(RVA = "0x117E528", Offset = "0x117E528", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SepiaScreenShaderData), Member = "GetDaylightPowers", MemberParameters = new object[]
		{
			typeof(ref float),
			typeof(ref float),
			typeof(ref float),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2 GetDayTimeAsDirectionIn24HClock(float timeFrom0To24)
		{
			throw null;
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x00029414 File Offset: 0x00027614
		[global::Cpp2ILInjected.Token(Token = "0x6002B59")]
		[global::Cpp2ILInjected.Address(RVA = "0x117E6C4", Offset = "0x117E6C4", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Program), Member = "LaunchGame", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static string[] ConvertMonoArgsToDotNet(string[] brokenArgs)
		{
			throw null;
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x00029417 File Offset: 0x00027617
		[global::Cpp2ILInjected.Token(Token = "0x6002B5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A3EA4", Offset = "0x15A3EA4", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DontStarveSeed), Member = "ModifyMinimumLightColorAtNight", MemberParameters = new object[] { typeof(ref byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static T Max<T>(params T[] args) where T : IComparable
		{
			throw null;
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x0002941A File Offset: 0x0002761A
		[global::Cpp2ILInjected.Token(Token = "0x6002B5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x117E8B8", Offset = "0x117E8B8", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ProcessHitAgainstNPC", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Rectangle),
			typeof(int),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "BottomLeft", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "BottomRight", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ClosestPointOnLine", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static float LineRectangleDistance(Rectangle rect, Vector2 lineStart, Vector2 lineEnd)
		{
			throw null;
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x0002941D File Offset: 0x0002761D
		[global::Cpp2ILInjected.Token(Token = "0x6002B5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x117EE08", Offset = "0x117EE08", Length = "0x810")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatMessageContainer), Member = "Refresh", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyChatMonitor), Member = "NewTextMultiline", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(Color),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "ParseMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(TextSnippet[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToArray", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "TSource[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char),
			typeof(StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Take", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[]
		{
			"System.Collections.Generic.IEnumerable`1<TSource>",
			typeof(int)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public static List<List<TextSnippet>> WordwrapStringSmart(string text, Color c, SpriteFont font, int maxWidth, int maxLines)
		{
			throw null;
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x00029420 File Offset: 0x00027620
		[global::Cpp2ILInjected.Token(Token = "0x6002B5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x117F618", Offset = "0x117F618", Length = "0x574")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMouseOver", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestUI), Member = "DrawName", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(char),
			typeof(StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public static string[] WordwrapString(string text, SpriteFont font, int maxWidth, int maxLines, out int lineAmount)
		{
			throw null;
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x00029423 File Offset: 0x00027623
		[global::Cpp2ILInjected.Token(Token = "0x6002B5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x117FB8C", Offset = "0x117FB8C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 84)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public static Rectangle CenteredRectangle(Vector2 center, Vector2 size)
		{
			throw null;
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x00029426 File Offset: 0x00027626
		[global::Cpp2ILInjected.Token(Token = "0x6002B5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x117FC04", Offset = "0x117FC04", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(bool),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(bool),
			typeof(Vector2),
			typeof(LightMap),
			typeof(ref Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static Vector2 Vector2FromElipse(Vector2 angleVector, Vector2 elipseSizes)
		{
			throw null;
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x00029429 File Offset: 0x00027629
		[global::Cpp2ILInjected.Token(Token = "0x6002B60")]
		[global::Cpp2ILInjected.Address(RVA = "0x117FE48", Offset = "0x117FE48", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Collision), Member = "SwitchTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Collision), Member = "StepDown", MemberParameters = new object[]
		{
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(int),
			typeof(int),
			typeof(ref float),
			typeof(ref float),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestUI), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestUI), Member = "DrawButton", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestUI), Member = "DrawSlots", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEDisplayDoll), Member = "DrawSlotPairSet", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(SpriteBatch),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEHatRack), Member = "DrawSlotPairSet", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(SpriteBatch),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		public static bool FloatIntersect(float r1StartX, float r1StartY, float r1Width, float r1Height, float r2StartX, float r2StartY, float r2Width, float r2Height)
		{
			throw null;
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x0002942C File Offset: 0x0002762C
		[global::Cpp2ILInjected.Token(Token = "0x6002B61")]
		[global::Cpp2ILInjected.Address(RVA = "0x117FE84", Offset = "0x117FE84", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "CanAffordItem", MemberParameters = new object[]
		{
			typeof(long),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "BuyItem", MemberParameters = new object[]
		{
			typeof(long),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "KillMe", MemberParameters = new object[]
		{
			typeof(PlayerDeathReason),
			typeof(double),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawSavings", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Panel_Layout),
			typeof(float),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(bool),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawSavings", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float),
			typeof(bool),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestUI), Member = "MoveCoins", MemberParameters = new object[]
		{
			typeof(Item[]),
			typeof(Item[]),
			typeof(ContainerTransferContext)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSorting), Member = "SortCoins", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Contains", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static long CoinsCount(out bool overFlowing, Item[] inv, params int[] ignoreSlots)
		{
			throw null;
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x0002942F File Offset: 0x0002762F
		[global::Cpp2ILInjected.Token(Token = "0x6002B62")]
		[global::Cpp2ILInjected.Address(RVA = "0x117FFF0", Offset = "0x117FFF0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawCoins", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "VisualizeChestTransfer_CoinsBatch", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "MouseText_DrawItemTooltip", MemberParameters = new object[]
		{
			typeof(Main.MouseTextCache),
			typeof(int),
			typeof(byte),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawCost", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float),
			typeof(long),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawSavings", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Panel_Layout),
			typeof(float),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(bool),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawSavings", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float),
			typeof(bool),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSorting), Member = "SortCoins", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoinLossRevengeSystem.RevengeMarker), Member = "UseMouseOver", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ref string),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static int[] CoinsSplit(long count)
		{
			throw null;
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x00029432 File Offset: 0x00027632
		[global::Cpp2ILInjected.Token(Token = "0x6002B63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1180090", Offset = "0x1180090", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "CanAffordItem", MemberParameters = new object[]
		{
			typeof(long),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "BuyItem", MemberParameters = new object[]
		{
			typeof(long),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawSavings", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Panel_Layout),
			typeof(float),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(bool),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawSavings", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float),
			typeof(bool),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static long CoinsCombineStacks(out bool overFlowing, params long[] coinCounts)
		{
			throw null;
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x00029435 File Offset: 0x00027635
		[global::Cpp2ILInjected.Token(Token = "0x6002B64")]
		[global::Cpp2ILInjected.Address(RVA = "0x11800F4", Offset = "0x11800F4", Length = "0x3D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "TryTeleportingCaughtMysticFrog", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "CatchNPC", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "HitEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "MakeTransitionEffectsForTextureChanges", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Damage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "CheckLogicGate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "HitWireSingle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gore), Member = "NewGore", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(float)
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public static void PoofOfSmoke(Vector2 position)
		{
			throw null;
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x00029438 File Offset: 0x00027638
		[global::Cpp2ILInjected.Token(Token = "0x6002B65")]
		[global::Cpp2ILInjected.Address(RVA = "0x118056C", Offset = "0x118056C", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteViewMatrix), Member = "get_ZoomMatrix", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Transform", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Matrix)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static Vector2 ToScreenPosition(this Vector2 worldPosition)
		{
			throw null;
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x0002943B File Offset: 0x0002763B
		[global::Cpp2ILInjected.Token(Token = "0x6002B66")]
		[global::Cpp2ILInjected.Address(RVA = "0x11806C4", Offset = "0x11806C4", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnlockProgressDisplayBestiaryInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "GetCompletionPercentText", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryInfoItemLine), Member = "GetDropInfo", MemberParameters = new object[]
		{
			typeof(DropRateInfo),
			typeof(BestiaryUICollectionInfo),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "TrimEnd", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "TrimStart", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static string PrettifyPercentDisplay(float percent, string originalFormat)
		{
			throw null;
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x0002943E File Offset: 0x0002763E
		[global::Cpp2ILInjected.Token(Token = "0x6002B67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1180818", Offset = "0x1180818", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "DrawInNotificationsArea", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Rectangle),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void TrimTextIfNeeded(ref string text, SpriteFont font, float scale, float maxWidth)
		{
			throw null;
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x00029441 File Offset: 0x00027641
		[global::Cpp2ILInjected.Token(Token = "0x6002B68")]
		[global::Cpp2ILInjected.Address(RVA = "0x118096C", Offset = "0x118096C", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "DrawInGame", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "DrawInNotificationsArea", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Rectangle),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MatchEvaluator), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(MatchEvaluator)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static string FormatWith(string original, object obj)
		{
			throw null;
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x00029444 File Offset: 0x00027644
		[global::Cpp2ILInjected.Token(Token = "0x6002B69")]
		[global::Cpp2ILInjected.Address(RVA = "0x1180A98", Offset = "0x1180A98", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DirectoryInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static bool TryCreatingDirectory(string folderPath)
		{
			throw null;
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x00029447 File Offset: 0x00027647
		[global::Cpp2ILInjected.Token(Token = "0x6002B6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1180B38", Offset = "0x1180B38", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "Exists", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Process), Member = "Start", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Process))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void OpenFolder(string folderPath)
		{
			throw null;
		}

		// Token: 0x060028B1 RID: 10417 RVA: 0x0002944A File Offset: 0x0002764A
		[global::Cpp2ILInjected.Token(Token = "0x6002B6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1180BC0", Offset = "0x1180BC0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte[] ToByteArray(this string str)
		{
			throw null;
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x0002944D File Offset: 0x0002764D
		[global::Cpp2ILInjected.Token(Token = "0x6002B6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x11804C4", Offset = "0x11804C4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 901)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		public static float NextFloat(this UnifiedRandom r)
		{
			throw null;
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x00029450 File Offset: 0x00027650
		[global::Cpp2ILInjected.Token(Token = "0x6002B6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1180C3C", Offset = "0x1180C3C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 114)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		public static float NextFloatDirection(this UnifiedRandom r)
		{
			throw null;
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x00029453 File Offset: 0x00027653
		[global::Cpp2ILInjected.Token(Token = "0x6002B6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1180C60", Offset = "0x1180C60", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static float NextFloat(this UnifiedRandom random, FloatRange range)
		{
			throw null;
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x00029456 File Offset: 0x00027656
		[global::Cpp2ILInjected.Token(Token = "0x6002B6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A4118", Offset = "0x15A4118", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "NewItem", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "RollDragonflyType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "OpenShadowLockbox", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SpawnFastRunParticles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "DashMovement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "RocketBootVisuals", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "FishingCheck_RollItemDrop", MemberParameters = new object[] { typeof(ref FishingAttempt) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_61", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ShakeTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_FlameWaders", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_WallOfFleshGoatMountFlames", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		public static T NextFromList<T>(this UnifiedRandom random, params T[] objs)
		{
			throw null;
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x00029459 File Offset: 0x00027659
		[global::Cpp2ILInjected.Token(Token = "0x6002B70")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A40C0", Offset = "0x15A40C0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SpawnHallucination", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static T NextFromCollection<T>(this UnifiedRandom random, List<T> objs)
		{
			throw null;
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x0002945C File Offset: 0x0002765C
		[global::Cpp2ILInjected.Token(Token = "0x6002B71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1180CDC", Offset = "0x1180CDC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "FindBoulderTrapSpots", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = "FindDartTrapSpots", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		public static int Next(this UnifiedRandom random, IntRange range)
		{
			throw null;
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x0002945F File Offset: 0x0002765F
		[global::Cpp2ILInjected.Token(Token = "0x6002B72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1180CEC", Offset = "0x1180CEC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawWallOfCopperShortswords", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawWallOfBoulders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_117_BloodNautilus", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_EmitFoodParticles", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_EmitDrinkParticles", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "FindSharpTearsSpot", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_162_TigerPounce", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_075", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_142_MonkStaffT2And3", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_145_BookStaffStorm", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "DoGemMinecartEffect", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "DoSteamMinecartEffect", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "DoExhaustMinecartEffect", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "DoConfettiMinecartEffect", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_Keybrand", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Vector2 NextVector2Square(this UnifiedRandom r, float min, float max)
		{
			throw null;
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x00029462 File Offset: 0x00027662
		[global::Cpp2ILInjected.Token(Token = "0x6002B73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1180D5C", Offset = "0x1180D5C", Length = "0xD4")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_007_TownEntities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_003_Fighters", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_001_Slimes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "UpdateNPC_BuffApplyVFX", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ApplyNPCOnHitEffects", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Rectangle),
			typeof(int),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_Shoot", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Damage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_ShimmerTownNPCSend", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_ShimmerTownNPC", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_LoadOutChange", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2 NextVector2FromRectangle(this UnifiedRandom r, Rectangle rect)
		{
			throw null;
		}

		// Token: 0x060028BA RID: 10426 RVA: 0x00029465 File Offset: 0x00027665
		[global::Cpp2ILInjected.Token(Token = "0x6002B74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1180E30", Offset = "0x1180E30", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_137_LightningAura", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "NextVector2CircularEdge", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2 NextVector2Unit(this UnifiedRandom r, float startRotation = 0f, float rotationRange = 6.2831855f)
		{
			throw null;
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x00029468 File Offset: 0x00027668
		[global::Cpp2ILInjected.Token(Token = "0x6002B75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1180EA8", Offset = "0x1180EA8", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 155)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Unit", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Vector2 NextVector2Circular(this UnifiedRandom r, float circleHalfWidth, float circleHalfHeight)
		{
			throw null;
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x0002946B File Offset: 0x0002766B
		[global::Cpp2ILInjected.Token(Token = "0x6002B76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1180FAC", Offset = "0x1180FAC", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "UpdateItem_VisualEffects", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_121_QueenSlime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_120_HallowBoss_DoMagicEffect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_114_Dragonflies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_001_Slimes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_Shoot", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_ApplyUseStyle", MemberParameters = new object[]
		{
			typeof(float),
			typeof(Item),
			typeof(Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "SummonSuperStarSlash", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_195_JimsDrone", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_171_HallowBossRainbowStreak", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_169_Smolstars", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_163_Chum", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_026", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_062", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ShakeTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles_EmitParticles", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(short),
			typeof(short),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper.ContactListener), Member = "OnCollision", MemberParameters = new object[]
		{
			typeof(PhysicsProperties),
			typeof(ref Vector2),
			typeof(ref Vector2),
			typeof(ref BallCollisionEvent)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Unit", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Vector2 NextVector2CircularEdge(this UnifiedRandom r, float circleHalfWidth, float circleHalfHeight)
		{
			throw null;
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x0002946E File Offset: 0x0002766E
		[global::Cpp2ILInjected.Token(Token = "0x6002B77")]
		[global::Cpp2ILInjected.Address(RVA = "0x1181088", Offset = "0x1181088", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 688)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Asset<>), Member = "get_IsLoaded", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int Width(this Asset<Texture2D> asset)
		{
			throw null;
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x00029471 File Offset: 0x00027671
		[global::Cpp2ILInjected.Token(Token = "0x6002B78")]
		[global::Cpp2ILInjected.Address(RVA = "0x11810F4", Offset = "0x11810F4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 683)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Asset<>), Member = "get_IsLoaded", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int Height(this Asset<Texture2D> asset)
		{
			throw null;
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x00029474 File Offset: 0x00027674
		[global::Cpp2ILInjected.Token(Token = "0x6002B79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1181160", Offset = "0x1181160", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 112)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Asset<>), Member = "get_IsLoaded", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static Rectangle Frame(this Asset<Texture2D> tex, int horizontalFrames = 1, int verticalFrames = 1, int frameX = 0, int frameY = 0, int sizeOffsetX = 0, int sizeOffsetY = 0)
		{
			throw null;
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x00029477 File Offset: 0x00027677
		[global::Cpp2ILInjected.Token(Token = "0x6002B7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x11812F4", Offset = "0x11812F4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		public static Rectangle OffsetSize(this Rectangle rect, int xSize, int ySize)
		{
			throw null;
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x0002947A File Offset: 0x0002767A
		[global::Cpp2ILInjected.Token(Token = "0x6002B7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1181308", Offset = "0x1181308", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfoToggles), Member = "InfoAccDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "DrawHotbarItem", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ItemGrid_Layout),
			typeof(Item[]),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIShop), Member = "DrawPurchaseButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_FlailChains", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSplash", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCHeadFriendly", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(byte),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCHeadBoss", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(byte),
			typeof(float),
			typeof(float),
			typeof(SpriteEffects),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnlockableNPCEntryIcon), Member = "Draw", MemberParameters = new object[]
		{
			typeof(BestiaryUICollectionInfo),
			typeof(SpriteBatch),
			typeof(EntryIconDrawSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_GuideEmotingAtRainbowPanel", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SkeletonMerchantSearchesThroughBones", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_ZoologistAndPetsAnnoyGolfer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeUI), Member = "DrawToggleButton", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIColoredImageButton), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "AddSymetricalCogsPair", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(Vector2),
			typeof(string),
			typeof(List<UIImage>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIHairStyleButton), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Asset<>), Member = "get_IsLoaded", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static Vector2 Size(this Asset<Texture2D> tex)
		{
			throw null;
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x0002947D File Offset: 0x0002767D
		[global::Cpp2ILInjected.Token(Token = "0x6002B7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x11812B0", Offset = "0x11812B0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 441)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public static Rectangle Frame(this Texture2D tex, int horizontalFrames = 1, int verticalFrames = 1, int frameX = 0, int frameY = 0, int sizeOffsetX = 0, int sizeOffsetY = 0)
		{
			throw null;
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x00029480 File Offset: 0x00027680
		[global::Cpp2ILInjected.Token(Token = "0x6002B7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1181444", Offset = "0x1181444", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(bool),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(bool),
			typeof(Vector2),
			typeof(LightMap),
			typeof(ref Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static Vector2 OriginFlip(this Rectangle rect, Vector2 origin, SpriteEffects effects)
		{
			throw null;
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x00029483 File Offset: 0x00027683
		[global::Cpp2ILInjected.Token(Token = "0x6002B7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1181418", Offset = "0x1181418", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 224)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Vector2 Size(this Texture2D tex)
		{
			throw null;
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x00029486 File Offset: 0x00027686
		[global::Cpp2ILInjected.Token(Token = "0x6002B7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1181468", Offset = "0x1181468", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTextModule), Member = "SerializeServerMessage", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(byte)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void WriteRGB(this BinaryWriter bb, Color c)
		{
			throw null;
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x00029489 File Offset: 0x00027689
		[global::Cpp2ILInjected.Token(Token = "0x6002B80")]
		[global::Cpp2ILInjected.Address(RVA = "0x11814BC", Offset = "0x11814BC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage.NetSoundInfo), Member = "WriteSelfTo", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveNPCs", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoinLossRevengeSystem.RevengeMarker), Member = "WriteSelfTo", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestraSettings), Member = "Serialize", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetPingModule), Member = "Serialize", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void WriteVector2(this BinaryWriter bb, Vector2 v)
		{
			throw null;
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x0002948C File Offset: 0x0002768C
		[global::Cpp2ILInjected.Token(Token = "0x6002B81")]
		[global::Cpp2ILInjected.Address(RVA = "0x11814FC", Offset = "0x11814FC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HalfVector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static void WritePackedVector2(this BinaryWriter bb, Vector2 v)
		{
			throw null;
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x0002948F File Offset: 0x0002768F
		[global::Cpp2ILInjected.Token(Token = "0x6002B82")]
		[global::Cpp2ILInjected.Address(RVA = "0x118153C", Offset = "0x118153C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldConsole), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(PlayerFileData)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldSwitch), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(PlayerFileData)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadTutorialPlayer", ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTextModule), Member = "DeserializeAsClient", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 39)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public static Color ReadRGB(this BinaryReader bb)
		{
			throw null;
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x00029492 File Offset: 0x00027692
		[global::Cpp2ILInjected.Token(Token = "0x6002B83")]
		[global::Cpp2ILInjected.Address(RVA = "0x11815B0", Offset = "0x11815B0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadNPCs", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadNPCs", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadNPCs", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoinLossRevengeSystem), Member = "AddMarkerFromReader", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestraSettings), Member = "DeserializeFrom", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetPingModule), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Vector2 ReadVector2(this BinaryReader bb)
		{
			throw null;
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x00029495 File Offset: 0x00027695
		[global::Cpp2ILInjected.Token(Token = "0x6002B84")]
		[global::Cpp2ILInjected.Address(RVA = "0x118160C", Offset = "0x118160C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HalfVector2), Member = "ToVector2", ReturnType = typeof(Vector2))]
		public static Vector2 ReadPackedVector2(this BinaryReader bb)
		{
			throw null;
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x00029498 File Offset: 0x00027698
		[global::Cpp2ILInjected.Token(Token = "0x6002B85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1181638", Offset = "0x1181638", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.AchievementUnlockedPopup), Member = "DrawInGame", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Vector2 Left(this Rectangle r)
		{
			throw null;
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x0002949B File Offset: 0x0002769B
		[global::Cpp2ILInjected.Token(Token = "0x6002B86")]
		[global::Cpp2ILInjected.Address(RVA = "0x1181674", Offset = "0x1181674", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.AchievementUnlockedPopup), Member = "DrawInGame", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Vector2 Right(this Rectangle r)
		{
			throw null;
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x0002949E File Offset: 0x0002769E
		[global::Cpp2ILInjected.Token(Token = "0x6002B87")]
		[global::Cpp2ILInjected.Address(RVA = "0x11816B4", Offset = "0x11816B4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Vector2 Top(this Rectangle r)
		{
			throw null;
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x000294A1 File Offset: 0x000276A1
		[global::Cpp2ILInjected.Token(Token = "0x6002B88")]
		[global::Cpp2ILInjected.Address(RVA = "0x11816EC", Offset = "0x11816EC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_UpdateCameraPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Vector2 Bottom(this Rectangle r)
		{
			throw null;
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x000294A4 File Offset: 0x000276A4
		[global::Cpp2ILInjected.Token(Token = "0x6002B89")]
		[global::Cpp2ILInjected.Address(RVA = "0x117EB2C", Offset = "0x117EB2C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 135)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Vector2 TopLeft(this Rectangle r)
		{
			throw null;
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x000294A7 File Offset: 0x000276A7
		[global::Cpp2ILInjected.Token(Token = "0x6002B8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x117EB58", Offset = "0x117EB58", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "SetPageControlsAndAdjust", MemberParameters = new object[] { typeof(GUIPageIcons.PageControlsType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeChangeSettings", Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Vector2 TopRight(this Rectangle r)
		{
			throw null;
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x000294AA File Offset: 0x000276AA
		[global::Cpp2ILInjected.Token(Token = "0x6002B8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x117EB88", Offset = "0x117EB88", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "LineRectangleDistance", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "IntersectsConeSlowMoreAccurate", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Vector2 BottomLeft(this Rectangle r)
		{
			throw null;
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x000294AD File Offset: 0x000276AD
		[global::Cpp2ILInjected.Token(Token = "0x6002B8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x117EBBC", Offset = "0x117EBBC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfo), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "DrawLeftControlsBanner", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "DrawRightControlsBanner", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "DrawControlsBanner", MemberParameters = new object[] { typeof(GUIControlsBanner.ActionSource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITalkerList), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "DrawDebugBox", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "LineRectangleDistance", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "IntersectsConeSlowMoreAccurate", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DoorOpeningHelper), Member = "GetPlayerInfoForOpeningDoor", MemberParameters = new object[] { typeof(Player) }, ReturnType = "Terraria.GameContent.DoorOpeningHelper.PlayerInfoForOpeningDoors")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Vector2 BottomRight(this Rectangle r)
		{
			throw null;
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x000294B0 File Offset: 0x000276B0
		[global::Cpp2ILInjected.Token(Token = "0x6002B8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x118172C", Offset = "0x118172C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "NPCDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DrawSelectedEntry", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "BeginResearchAnimation", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Vector2 Center(this Rectangle r)
		{
			throw null;
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x000294B3 File Offset: 0x000276B3
		[global::Cpp2ILInjected.Token(Token = "0x6002B8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1181774", Offset = "0x1181774", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 357)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Vector2 Size(this Rectangle r)
		{
			throw null;
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x000294B6 File Offset: 0x000276B6
		[global::Cpp2ILInjected.Token(Token = "0x6002B8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x11817A0", Offset = "0x11817A0", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCExtras", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(bool),
			typeof(float),
			typeof(float),
			typeof(Color),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_065_Butterflies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_114_Dragonflies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TouchBlockSurfaceCenter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(ref int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "MinionNPCTargetAim", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateMinionTarget", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Colliding", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Rectangle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_137_LightningAura", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "TryGoingThroughPortals", MemberParameters = new object[] { typeof(Entity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCSmartInteractCandidateProvider), Member = "ProvideCandidate", MemberParameters = new object[]
		{
			typeof(SmartInteractScanSettings),
			typeof(ref ISmartInteractCandidate)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProjectileSmartInteractCandidateProvider), Member = "ProvideCandidate", MemberParameters = new object[]
		{
			typeof(SmartInteractScanSettings),
			typeof(ref ISmartInteractCandidate)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "BottomLeft", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "BottomRight", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static float Distance(this Rectangle r, Vector2 point)
		{
			throw null;
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x000294B9 File Offset: 0x000276B9
		[global::Cpp2ILInjected.Token(Token = "0x6002B90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1181A00", Offset = "0x1181A00", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_123_Deerclops", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_112_FairyCritter", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetNearbyContainerProjectilesList", ReturnType = typeof(List<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "IsProjectileInteractibleAndInInteractionRange", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "HandleBeingInChestRange", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "IsInInteractionRangeToMultiTileHitbox", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TentacleSpike_TrySpiking", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(Item),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "BloodButcherer_TryButchering", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(Item),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ProcessHitAgainstNPC", MemberParameters = new object[]
		{
			typeof(Item),
			typeof(Rectangle),
			typeof(int),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Damage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Colliding", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Rectangle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "IntersectsConeFastInaccurate", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "IntersectsConeSlowMoreAccurate", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReturnGatePlayerRenderer), Member = "OverReturnGateInWorld", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AHoverInteractionChecker), Member = "AttemptInteraction", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Rectangle)
		}, ReturnType = typeof(AHoverInteractionChecker.HoverStatus))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileSmartInteractCandidateProvider), Member = "ProvideCandidate", MemberParameters = new object[]
		{
			typeof(SmartInteractScanSettings),
			typeof(ref ISmartInteractCandidate)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PotionOfReturnSmartInteractCandidateProvider), Member = "ProvideCandidate", MemberParameters = new object[]
		{
			typeof(SmartInteractScanSettings),
			typeof(ref ISmartInteractCandidate)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		public static Vector2 ClosestPointInRect(this Rectangle r, Vector2 point)
		{
			throw null;
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x000294BC File Offset: 0x000276BC
		[global::Cpp2ILInjected.Token(Token = "0x6002B91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1181A98", Offset = "0x1181A98", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_AttemptToFindTeleportSpot", MemberParameters = new object[]
		{
			typeof(ref Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public static Rectangle Modified(this Rectangle r, int x, int y, int w, int h)
		{
			throw null;
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x000294BF File Offset: 0x000276BF
		[global::Cpp2ILInjected.Token(Token = "0x6002B92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1181AE0", Offset = "0x1181AE0", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Colliding", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Rectangle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ClosestPointInRect", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool IntersectsConeFastInaccurate(this Rectangle targetRect, Vector2 coneCenter, float coneLength, float coneRotation, float maximumAngle)
		{
			throw null;
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x000294C2 File Offset: 0x000276C2
		[global::Cpp2ILInjected.Token(Token = "0x6002B93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1181CAC", Offset = "0x1181CAC", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Colliding", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Rectangle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ClosestPointInRect", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DoesFitInCone", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "BottomLeft", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "BottomRight", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static bool IntersectsConeSlowMoreAccurate(this Rectangle targetRect, Vector2 coneCenter, float coneLength, float coneRotation, float maximumAngle)
		{
			throw null;
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x000294C5 File Offset: 0x000276C5
		[global::Cpp2ILInjected.Token(Token = "0x6002B94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1181EE0", Offset = "0x1181EE0", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "IntersectsConeSlowMoreAccurate", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool DoesFitInCone(Vector2 point, Vector2 coneCenter, float coneLength, float coneRotation, float maximumAngle)
		{
			throw null;
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x000294C8 File Offset: 0x000276C8
		[global::Cpp2ILInjected.Token(Token = "0x6002B95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1181C40", Offset = "0x1181C40", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 342)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static float ToRotation(this Vector2 v)
		{
			throw null;
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x000294CB File Offset: 0x000276CB
		[global::Cpp2ILInjected.Token(Token = "0x6002B96")]
		[global::Cpp2ILInjected.Address(RVA = "0x11804DC", Offset = "0x11804DC", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 412)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Vector2 ToRotationVector2(this float f)
		{
			throw null;
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x000294CE File Offset: 0x000276CE
		[global::Cpp2ILInjected.Token(Token = "0x6002B97")]
		[global::Cpp2ILInjected.Address(RVA = "0x117E5C8", Offset = "0x117E5C8", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 671)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static Vector2 RotatedBy(this Vector2 spinningpoint, double radians, Vector2 center = default(Vector2))
		{
			throw null;
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x000294D1 File Offset: 0x000276D1
		[global::Cpp2ILInjected.Token(Token = "0x6002B98")]
		[global::Cpp2ILInjected.Address(RVA = "0x1182008", Offset = "0x1182008", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeBranch), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static Vector2D RotatedBy(this Vector2D spinningpoint, double radians, Vector2D center = default(Vector2D))
		{
			throw null;
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x000294D4 File Offset: 0x000276D4
		[global::Cpp2ILInjected.Token(Token = "0x6002B99")]
		[global::Cpp2ILInjected.Address(RVA = "0x11820FC", Offset = "0x11820FC", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 168)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static Vector2 RotatedByRandom(this Vector2 spinninpoint, double maxRadians)
		{
			throw null;
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x000294D7 File Offset: 0x000276D7
		[global::Cpp2ILInjected.Token(Token = "0x6002B9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x11821DC", Offset = "0x11821DC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 93)]
		public static Vector2 Floor(this Vector2 vec)
		{
			throw null;
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x000294DA File Offset: 0x000276DA
		[global::Cpp2ILInjected.Token(Token = "0x6002B9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1182210", Offset = "0x1182210", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 49)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool HasNaNs(this Vector2 vec)
		{
			throw null;
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x000294DD File Offset: 0x000276DD
		[global::Cpp2ILInjected.Token(Token = "0x6002B9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x117EBF4", Offset = "0x117EBF4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_109_DarkMage", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "GetStringSize", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(TextSnippet[]),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(TextSnippet[]),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(ref int),
			typeof(float),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public static bool Between(this Vector2 vec, Vector2 minimum, Vector2 maximum)
		{
			throw null;
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x000294E0 File Offset: 0x000276E0
		[global::Cpp2ILInjected.Token(Token = "0x6002B9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x11822C8", Offset = "0x11822C8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 82)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Vector2 ToVector2(this Point p)
		{
			throw null;
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x000294E3 File Offset: 0x000276E3
		[global::Cpp2ILInjected.Token(Token = "0x6002B9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x11822F4", Offset = "0x11822F4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsMapLayer), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref MapOverlayDrawContext),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Vector2 ToVector2(this Point16 p)
		{
			throw null;
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x000294E6 File Offset: 0x000276E6
		[global::Cpp2ILInjected.Token(Token = "0x6002B9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1182324", Offset = "0x1182324", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_20", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceOasis", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DunesBiome), Member = "PlaceCurvedLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point),
			typeof(Point),
			"Terraria.GameContent.Biomes.DunesBiome.DunesDescription"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HiveBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(void))]
		public static Vector2D ToVector2D(this Point p)
		{
			throw null;
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x000294E9 File Offset: 0x000276E9
		[global::Cpp2ILInjected.Token(Token = "0x6002BA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1182358", Offset = "0x1182358", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(void))]
		public static Vector2D ToVector2D(this Point16 p)
		{
			throw null;
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x000294EC File Offset: 0x000276EC
		[global::Cpp2ILInjected.Token(Token = "0x6002BA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1182390", Offset = "0x1182390", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 32)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Vector2 ToWorldCoordinates(this Point p, float autoAddX = 8f, float autoAddY = 8f)
		{
			throw null;
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x000294EF File Offset: 0x000276EF
		[global::Cpp2ILInjected.Token(Token = "0x6002BA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x118248C", Offset = "0x118248C", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsSystem), Member = "HandleTeleportRequest", MemberParameters = new object[]
		{
			typeof(TeleportPylonInfo),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Vector2 ToWorldCoordinates(this Point16 p, float autoAddX = 8f, float autoAddY = 8f)
		{
			throw null;
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x000294F2 File Offset: 0x000276F2
		[global::Cpp2ILInjected.Token(Token = "0x6002BA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x118258C", Offset = "0x118258C", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_FlailChains", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_122_PirateGhost", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_009_MagicMissiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_015_Flails", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_120_StardustGuardian", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_067_FreakingPirates", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_156_Think", MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "SafeNormalize", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static Vector2 MoveTowards(this Vector2 currentPosition, Vector2 targetPosition, float maxAmountAllowedToMove)
		{
			throw null;
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x000294F5 File Offset: 0x000276F5
		[global::Cpp2ILInjected.Token(Token = "0x6002BA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1182828", Offset = "0x1182828", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Chest), Member = "SetupShop", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public static Point16 ToTileCoordinates16(this Vector2 vec)
		{
			throw null;
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x000294F8 File Offset: 0x000276F8
		[global::Cpp2ILInjected.Token(Token = "0x6002BA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1182874", Offset = "0x1182874", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public static Point16 ToTileCoordinates16(this Vector2D vec)
		{
			throw null;
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x000294FB File Offset: 0x000276FB
		[global::Cpp2ILInjected.Token(Token = "0x6002BA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x11828C0", Offset = "0x11828C0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 254)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public static Point ToTileCoordinates(this Vector2 vec)
		{
			throw null;
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x000294FE File Offset: 0x000276FE
		[global::Cpp2ILInjected.Token(Token = "0x6002BA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x118290C", Offset = "0x118290C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotLineOffset", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileLine", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileTale", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "<PlotLineOffsetTale>g__PlotAtOffset|150_0", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref Utils.<>c__DisplayClass150_0)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public static Point ToTileCoordinates(this Vector2D vec)
		{
			throw null;
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x00029501 File Offset: 0x00027701
		[global::Cpp2ILInjected.Token(Token = "0x6002BA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1182958", Offset = "0x1182958", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 64)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public static Point ToPoint(this Vector2 v)
		{
			throw null;
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x00029504 File Offset: 0x00027704
		[global::Cpp2ILInjected.Token(Token = "0x6002BA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x118299C", Offset = "0x118299C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "CrimVein", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DunesBiome), Member = "PlaceCurvedLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point),
			typeof(Point),
			"Terraria.GameContent.Biomes.DunesBiome.DunesDescription"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChambersEntrance), Member = "PlaceAt", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public static Point ToPoint(this Vector2D v)
		{
			throw null;
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x00029507 File Offset: 0x00027707
		[global::Cpp2ILInjected.Token(Token = "0x6002BAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x11829E0", Offset = "0x11829E0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "IsSafeFromRain", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(void))]
		public static Vector2D ToVector2D(this Vector2 v)
		{
			throw null;
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x0002950A File Offset: 0x0002770A
		[global::Cpp2ILInjected.Token(Token = "0x6002BAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1182708", Offset = "0x1182708", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 231)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "HasNaNs", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static Vector2 SafeNormalize(this Vector2 v, Vector2 defaultValue)
		{
			throw null;
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x0002950D File Offset: 0x0002770D
		[global::Cpp2ILInjected.Token(Token = "0x6002BAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x117EC24", Offset = "0x117EC24", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "LineRectangleDistance", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "RectangleLineCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "LengthSquared", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Dot", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Vector2 ClosestPointOnLine(this Vector2 P, Vector2 A, Vector2 B)
		{
			throw null;
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x00029510 File Offset: 0x00027710
		[global::Cpp2ILInjected.Token(Token = "0x6002BAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1182A10", Offset = "0x1182A10", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Collision), Member = "CheckAABBvLineCollision2", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ClosestPointOnLine", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool RectangleLineCollision(Vector2 rectTopLeft, Vector2 rectBottomRight, Vector2 lineStart, Vector2 lineEnd)
		{
			throw null;
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x00029513 File Offset: 0x00027713
		[global::Cpp2ILInjected.Token(Token = "0x6002BAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1182C34", Offset = "0x1182C34", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static Vector2 RotateRandom(this Vector2 spinninpoint, double maxRadians)
		{
			throw null;
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x00029516 File Offset: 0x00027716
		[global::Cpp2ILInjected.Token(Token = "0x6002BAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1182D14", Offset = "0x1182D14", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_142_MonkStaffT2And3", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "rotateTowards", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static float AngleTo(this Vector2 Origin, Vector2 Target)
		{
			throw null;
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x00029519 File Offset: 0x00027719
		[global::Cpp2ILInjected.Token(Token = "0x6002BB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1182D98", Offset = "0x1182D98", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static float AngleFrom(this Vector2 Origin, Vector2 Target)
		{
			throw null;
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x0002951C File Offset: 0x0002771C
		[global::Cpp2ILInjected.Token(Token = "0x6002BB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1182E1C", Offset = "0x1182E1C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "AngleTo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "AngleTowards", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Vector2 rotateTowards(Vector2 currentPosition, Vector2 currentVelocity, Vector2 targetPosition, float maxChange)
		{
			throw null;
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x0002951F File Offset: 0x0002771F
		[global::Cpp2ILInjected.Token(Token = "0x6002BB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x117ED88", Offset = "0x117ED88", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 31)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static float Distance(this Vector2 Origin, Vector2 Target)
		{
			throw null;
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x00029522 File Offset: 0x00027722
		[global::Cpp2ILInjected.Token(Token = "0x6002BB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1182FB0", Offset = "0x1182FB0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "DistanceSquared", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static float DistanceSQ(this Vector2 Origin, Vector2 Target)
		{
			throw null;
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x00029525 File Offset: 0x00027725
		[global::Cpp2ILInjected.Token(Token = "0x6002BB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1183030", Offset = "0x1183030", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_120_HallowBoss", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_117_BloodNautilus", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "DoQueenSlimeHookTeleport", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_Shoot", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_EmitHeldItemLight", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_015_Flails", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_165_Whip", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_142_MonkStaffT2And3", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UpdateEffects", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexStrip), Member = "PrepareStripWithProceduralPadding", MemberParameters = new object[]
		{
			typeof(ref Vector2Array_10),
			typeof(ref FloatArray_10),
			typeof(VertexStrip.StripColorFunction),
			typeof(VertexStrip.StripHalfWidthFunction),
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexStrip), Member = "PrepareStripWithProceduralPadding", MemberParameters = new object[]
		{
			typeof(Vector2[]),
			typeof(float[]),
			typeof(VertexStrip.StripColorFunction),
			typeof(VertexStrip.StripHalfWidthFunction),
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 35)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2 DirectionTo(this Vector2 Origin, Vector2 Target)
		{
			throw null;
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x00029528 File Offset: 0x00027728
		[global::Cpp2ILInjected.Token(Token = "0x6002BB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x11830B8", Offset = "0x11830B8", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_117_BloodNautilus", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_015_Flails", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2 DirectionFrom(this Vector2 Origin, Vector2 Target)
		{
			throw null;
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x0002952B File Offset: 0x0002772B
		[global::Cpp2ILInjected.Token(Token = "0x6002BB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1183140", Offset = "0x1183140", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "DistanceSquared", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool WithinRange(this Vector2 Origin, Vector2 Target, float MaxRange)
		{
			throw null;
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x0002952E File Offset: 0x0002772E
		[global::Cpp2ILInjected.Token(Token = "0x6002BB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x11831DC", Offset = "0x11831DC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Vector2 XY(this Vector4 vec)
		{
			throw null;
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x00029531 File Offset: 0x00027731
		[global::Cpp2ILInjected.Token(Token = "0x6002BB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x11831FC", Offset = "0x11831FC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Vector2 ZW(this Vector4 vec)
		{
			throw null;
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x00029534 File Offset: 0x00027734
		[global::Cpp2ILInjected.Token(Token = "0x6002BB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1183224", Offset = "0x1183224", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Collision), Member = "FindCollisionTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(List<Point>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Vector3 XZW(this Vector4 vec)
		{
			throw null;
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x00029537 File Offset: 0x00027737
		[global::Cpp2ILInjected.Token(Token = "0x6002BBA")]
		[global::Cpp2ILInjected.Address(RVA = "0x118325C", Offset = "0x118325C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Collision), Member = "FindCollisionTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(List<Point>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Vector3 YZW(this Vector4 vec)
		{
			throw null;
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x0002953A File Offset: 0x0002773A
		[global::Cpp2ILInjected.Token(Token = "0x6002BBB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1183298", Offset = "0x1183298", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "DrawCursorSingle", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Color),
			typeof(float),
			typeof(float),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_05_ForbiddenSetRing", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public static Color MultiplyRGB(this Color firstColor, Color secondColor)
		{
			throw null;
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x0002953D File Offset: 0x0002773D
		[global::Cpp2ILInjected.Token(Token = "0x6002BBC")]
		[global::Cpp2ILInjected.Address(RVA = "0x118332C", Offset = "0x118332C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuilderAccToggles), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAchievementsMenu), Member = "AchievementDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(bool),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(bool),
			typeof(Vector2),
			typeof(LightMap),
			typeof(ref Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_27_HeldItem", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "ExportTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(LightMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "ApplyTileLight", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref FastRandom),
			typeof(ref Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawSpecialTilesLegacy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIKeybindingSimpleListItem), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIKeybindingToggleListItem), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public static Color MultiplyRGBA(this Color firstColor, Color secondColor)
		{
			throw null;
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x00029540 File Offset: 0x00027740
		[global::Cpp2ILInjected.Token(Token = "0x6002BBD")]
		[global::Cpp2ILInjected.Address(RVA = "0x11833E4", Offset = "0x11833E4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static string Hex3(this Color color)
		{
			throw null;
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x00029543 File Offset: 0x00027743
		[global::Cpp2ILInjected.Token(Token = "0x6002BBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1183484", Offset = "0x1183484", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static string Hex4(this Color color)
		{
			throw null;
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x00029546 File Offset: 0x00027746
		[global::Cpp2ILInjected.Token(Token = "0x6002BBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x118353C", Offset = "0x118353C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 62)]
		public static int ToDirectionInt(this bool value)
		{
			throw null;
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x00029549 File Offset: 0x00027749
		[global::Cpp2ILInjected.Token(Token = "0x6002BC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x118354C", Offset = "0x118354C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 124)]
		public static int ToInt(this bool value)
		{
			throw null;
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x0002954C File Offset: 0x0002774C
		[global::Cpp2ILInjected.Token(Token = "0x6002BC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1183554", Offset = "0x1183554", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetAdvancedShadow", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(EntityShadowInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static int ModulusPositive(this int myInteger, int modulusNumber)
		{
			throw null;
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x0002954F File Offset: 0x0002774F
		[global::Cpp2ILInjected.Token(Token = "0x6002BC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x118356C", Offset = "0x118356C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_117_BloodNautilus", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_009_MagicMissiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_169_Smolstars", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_016", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_156_Think", MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_001", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_134_Ballista", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "WrapAngle", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		public static float AngleLerp(this float curAngle, float targetAngle, float amount)
		{
			throw null;
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x00029552 File Offset: 0x00027752
		[global::Cpp2ILInjected.Token(Token = "0x6002BC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1182F24", Offset = "0x1182F24", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_117_BloodNautilus", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_006_Worms", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_110_Betsy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "FindFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_009_MagicMissiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_174_MultisegmentPet", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_016", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_067_FreakingPirates", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_156_Think", MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "rotateTowards", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WiresUI.WiresRadial), Member = "DrawFlower", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "WrapAngle", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public static float AngleTowards(this float curAngle, float targetAngle, float maxChange)
		{
			throw null;
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x00029555 File Offset: 0x00027755
		[global::Cpp2ILInjected.Token(Token = "0x6002BC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x11835D4", Offset = "0x11835D4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_AnchorValidTiles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_AnchorInvalidTiles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_AnchorAlternateTiles", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_CoordinateHeights", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static bool deepCompare(this int[] firstArray, int[] secondArray)
		{
			throw null;
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x00029558 File Offset: 0x00027758
		[global::Cpp2ILInjected.Token(Token = "0x6002BC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x118363C", Offset = "0x118363C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "GetTrueIndexes", MemberParameters = new object[] { typeof(bool[][]) }, ReturnType = typeof(List<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static List<int> GetTrueIndexes(this bool[] array)
		{
			throw null;
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x0002955B File Offset: 0x0002775B
		[global::Cpp2ILInjected.Token(Token = "0x6002BC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1183744", Offset = "0x1183744", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetTrueIndexes", MemberParameters = new object[] { typeof(bool[]) }, ReturnType = typeof(List<int>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Distinct", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static List<int> GetTrueIndexes(params bool[][] arrays)
		{
			throw null;
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x0002955E File Offset: 0x0002775E
		[global::Cpp2ILInjected.Token(Token = "0x6002BC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A3B8C", Offset = "0x15A3B8C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveNPCs", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static int Count<T>(this T[] arr, T value)
		{
			throw null;
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x00029561 File Offset: 0x00027761
		[global::Cpp2ILInjected.Token(Token = "0x6002BC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1183874", Offset = "0x1183874", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardState), Member = "IsKeyDown", MemberParameters = new object[] { typeof(Keys) }, ReturnType = typeof(bool))]
		public static bool PressingShift(this KeyboardState kb)
		{
			throw null;
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x00029564 File Offset: 0x00027764
		[global::Cpp2ILInjected.Token(Token = "0x6002BC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x11838AC", Offset = "0x11838AC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardState), Member = "IsKeyDown", MemberParameters = new object[] { typeof(Keys) }, ReturnType = typeof(bool))]
		public static bool PressingControl(this KeyboardState kb)
		{
			throw null;
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x00029567 File Offset: 0x00027767
		[global::Cpp2ILInjected.Token(Token = "0x6002BCA")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A3D58", Offset = "0x15A3D58", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShimmerTransforms), Member = "UpdateRecipeSets", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static R[] MapArray<T, R>(T[] array, Func<T, R> mapper)
		{
			throw null;
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x0002956A File Offset: 0x0002776A
		[global::Cpp2ILInjected.Token(Token = "0x6002BCB")]
		[global::Cpp2ILInjected.Address(RVA = "0x11838E4", Offset = "0x11838E4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool PlotLine(Point16 p0, Point16 p1, Utils.TileActionAttempt plot, bool jump = true)
		{
			throw null;
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x0002956D File Offset: 0x0002776D
		[global::Cpp2ILInjected.Token(Token = "0x6002BCC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1183B98", Offset = "0x1183B98", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PortalHelper), Member = "FindCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeBranch), Member = "PerformSegment", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction),
			typeof(Point),
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "PlotLine", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool PlotLine(Point p0, Point p1, Utils.TileActionAttempt plot, bool jump = true)
		{
			throw null;
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x00029570 File Offset: 0x00027770
		[global::Cpp2ILInjected.Token(Token = "0x6002BCD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1183C2C", Offset = "0x1183C2C", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileTale", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Swap", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void PlotLineLength(int x0, int y0, int x1, int y1, ref int length, bool jump = true)
		{
			throw null;
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x00029573 File Offset: 0x00027773
		[global::Cpp2ILInjected.Token(Token = "0x6002BCE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1183DCC", Offset = "0x1183DCC", Length = "0x3E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileLine", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "Length", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(double)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(double)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2D) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Swap", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "<PlotLineOffset>g__PlotAtOffset|149_0", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref Utils.<>c__DisplayClass149_0)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static bool PlotLineOffset(Vector2D start, Vector2D end, double halfWidth, int x0, int y0, int x1, int y1, Utils.TileActionAttempt plot, bool jump = true)
		{
			throw null;
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x00029576 File Offset: 0x00027776
		[global::Cpp2ILInjected.Token(Token = "0x6002BCF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1184238", Offset = "0x1184238", Length = "0x324")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileTale", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "Length", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(double)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Swap", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "<PlotLineOffsetTale>g__PlotAtOffset|150_0", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref Utils.<>c__DisplayClass150_0)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static bool PlotLineOffsetTale(Vector2D start, Vector2D end, int length, double halfWidth, int x0, int y0, int x1, int y1, Utils.TileActionAttempt plot, bool jump = true)
		{
			throw null;
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x00029579 File Offset: 0x00027779
		[global::Cpp2ILInjected.Token(Token = "0x6002BD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1183968", Offset = "0x1183968", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotLine", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(Point),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileLineInner", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "<PlotLineOffset>g__PlotAtOffset|149_0", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref Utils.<>c__DisplayClass149_0)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "<PlotLineOffsetTale>g__PlotAtOffset|150_0", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref Utils.<>c__DisplayClass150_0)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Swap", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static bool PlotLine(int x0, int y0, int x1, int y1, Utils.TileActionAttempt plot, bool jump = true)
		{
			throw null;
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x0002957C File Offset: 0x0002777C
		[global::Cpp2ILInjected.Token(Token = "0x6002BD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1184734", Offset = "0x1184734", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "RandomFloat", MemberParameters = new object[] { typeof(ref ulong) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "RandomInt", MemberParameters = new object[]
		{
			typeof(ref ulong),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int RandomNext(ref ulong seed, int bits)
		{
			throw null;
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x0002957F File Offset: 0x0002777F
		[global::Cpp2ILInjected.Token(Token = "0x6002BD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x11847BC", Offset = "0x11847BC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static ulong RandomNextSeed(ulong seed)
		{
			throw null;
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x00029582 File Offset: 0x00027782
		[global::Cpp2ILInjected.Token(Token = "0x6002BD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x11847D8", Offset = "0x11847D8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RandomNext", MemberParameters = new object[]
		{
			typeof(ref ulong),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static float RandomFloat(ref ulong seed)
		{
			throw null;
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x00029585 File Offset: 0x00027785
		[global::Cpp2ILInjected.Token(Token = "0x6002BD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1184844", Offset = "0x1184844", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "RandomInt", MemberParameters = new object[]
		{
			typeof(ref ulong),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RandomNext", MemberParameters = new object[]
		{
			typeof(ref ulong),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static int RandomInt(ref ulong seed, int max)
		{
			throw null;
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x00029588 File Offset: 0x00027788
		[global::Cpp2ILInjected.Token(Token = "0x6002BD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x11848F8", Offset = "0x11848F8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawCompositeArmorPiece", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(CompositePlayerDrawContext),
			typeof(DrawData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_21_Head", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_28_ArmOverItem", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlameParticle), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref ParticleRendererSettings),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawSingleTile_Flames", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileVinesInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 85)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RandomInt", MemberParameters = new object[]
		{
			typeof(ref ulong),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int RandomInt(ref ulong seed, int min, int max)
		{
			throw null;
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x0002958B File Offset: 0x0002778B
		[global::Cpp2ILInjected.Token(Token = "0x6002BD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1184968", Offset = "0x1184968", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "PlotLine", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool PlotTileLineInner(int x, int y)
		{
			throw null;
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x0002958E File Offset: 0x0002778E
		[global::Cpp2ILInjected.Token(Token = "0x6002BD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x11849EC", Offset = "0x11849EC", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 50)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "PlotTileLine", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool PlotTileLine(Vector2 start, Vector2 end, float width, Utils.TileActionAttempt plot)
		{
			throw null;
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x00029591 File Offset: 0x00027791
		[global::Cpp2ILInjected.Token(Token = "0x6002BD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1184AC0", Offset = "0x1184AC0", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotTileLine", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "IsSafeFromRain", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "Length", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(double)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(double)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2D) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "PlotLineOffset", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool PlotTileLine(Vector2D start, Vector2D end, double width, Utils.TileActionAttempt plot)
		{
			throw null;
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x00029594 File Offset: 0x00027794
		[global::Cpp2ILInjected.Token(Token = "0x6002BD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1184CF4", Offset = "0x1184CF4", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Shapes.Tail), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "Length", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(double)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2D) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "PlotLineLength", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "PlotLineOffsetTale", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(int),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool PlotTileTale(Vector2D start, Vector2D end, double width, Utils.TileActionAttempt plot)
		{
			throw null;
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x00029597 File Offset: 0x00027797
		[global::Cpp2ILInjected.Token(Token = "0x6002BDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1184E9C", Offset = "0x1184E9C", Length = "0xA90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_EmitHeldItemLight", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "ProjLight", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill_DirtAndFluidProjectiles_RunDelegateMethodPushUpForHalfBricks", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(float),
			typeof(Utils.TileActionAttempt)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "InWorld", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "StartNewSearch", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen.nextCountNode), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen.nextCountNode), Member = "Setup", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_TileSeachUID", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "SetTileSeachUID", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
		public static bool PlotTileArea(int x, int y, Utils.TileActionAttempt plot)
		{
			throw null;
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x0002959A File Offset: 0x0002779A
		[global::Cpp2ILInjected.Token(Token = "0x6002BDB")]
		[global::Cpp2ILInjected.Address(RVA = "0x118592C", Offset = "0x118592C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Log", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int RandomConsecutive(double random, int odds)
		{
			throw null;
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x0002959D File Offset: 0x0002779D
		[global::Cpp2ILInjected.Token(Token = "0x6002BDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x11859B8", Offset = "0x11859B8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_007_TownEntities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_003_Fighters", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_107_ImprovedWalkers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_111_DD2LightningBug", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "HitEffect", MemberParameters = new object[]
		{
			typeof(int),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_EmitHeldItemLight", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Damage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_001", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_075", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_136_BetsyBreath", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "CastSuperCartLaser", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TreeGrowFX", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TreeGrowFX_AshShake", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "ElderSlimeEffect", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "EmitTreeLeaves", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Sandstorm), Member = "EmitDust", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 48)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static Vector2 RandomVector2(UnifiedRandom random, float min, float max)
		{
			throw null;
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x000295A0 File Offset: 0x000277A0
		[global::Cpp2ILInjected.Token(Token = "0x6002BDD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1185A28", Offset = "0x1185A28", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeRunner), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(void))]
		public static Vector2D RandomVector2D(UnifiedRandom random, double min, double max)
		{
			throw null;
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x000295A3 File Offset: 0x000277A3
		[global::Cpp2ILInjected.Token(Token = "0x6002BDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A3CB4", Offset = "0x15A3CB4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "ScaleStats", MemberParameters = new object[]
		{
			typeof(int?),
			typeof(GameModeData),
			typeof(float?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Hurt", MemberParameters = new object[]
		{
			typeof(PlayerDeathReason),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemFilters.MiscFallback), Member = "FitsFilter", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "IsEnabledForPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public static bool IndexInRange<T>(this T[] t, int index)
		{
			throw null;
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x000295A6 File Offset: 0x000277A6
		[global::Cpp2ILInjected.Token(Token = "0x6002BDF")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A3CD0", Offset = "0x15A3CD0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool IndexInRange<T>(this List<T> t, int index)
		{
			throw null;
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x000295A9 File Offset: 0x000277A9
		[global::Cpp2ILInjected.Token(Token = "0x6002BE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A41A8", Offset = "0x15A41A8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_068", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		public static T SelectRandom<T>(UnifiedRandom random, params T[] choices)
		{
			throw null;
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x000295AC File Offset: 0x000277AC
		[global::Cpp2ILInjected.Token(Token = "0x6002BE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1185A98", Offset = "0x1185A98", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIShop), Member = "DrawPurchaseButton", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMouseOver", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawMoney", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(string),
			typeof(float),
			typeof(float),
			typeof(int[]),
			typeof(bool),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawSavings", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Panel_Layout),
			typeof(float),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(bool),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomCurrencySingleCoin), Member = "DrawSavingsMoney", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(string),
			typeof(float),
			typeof(float),
			typeof(long),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomCurrencyManager), Member = "DrawSavings", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementsMenu), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigProgressBarHelper), Member = "DrawHealthText", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Rectangle),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void DrawBorderStringFourWay(SpriteBatch sb, SpriteFont font, string text, float x, float y, Color textColor, Color borderColor, Vector2 origin, float scale = 1f)
		{
			throw null;
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x000295AF File Offset: 0x000277AF
		[global::Cpp2ILInjected.Token(Token = "0x6002BE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1185C44", Offset = "0x1185C44", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_33_MouseText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.AchievementUnlockedPopup), Member = "DrawInGame", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "DrawInGame", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "DrawInNotificationsArea", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Rectangle),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryInfoLine<>), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UITextBox), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UITextPanel<>), Member = "DrawText", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedStringWithShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static Vector2 DrawBorderString(SpriteBatch sb, string text, Vector2 pos, Color color, float scale = 1f, float anchorx = 0f, float anchory = 0f, int maxCharactersDisplayed = -1)
		{
			throw null;
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x000295B2 File Offset: 0x000277B2
		[global::Cpp2ILInjected.Token(Token = "0x6002BE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1185E28", Offset = "0x1185E28", Length = "0x2D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaptureInterface), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UITextBox), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UITextPanel<>), Member = "DrawText", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static Vector2 DrawBorderStringBig(SpriteBatch spriteBatch, string text, Vector2 pos, Color color, float scale = 1f, float anchorx = 0f, float anchory = 0f, int maxCharactersDisplayed = -1)
		{
			throw null;
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x000295B5 File Offset: 0x000277B5
		[global::Cpp2ILInjected.Token(Token = "0x6002BE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x11860FC", Offset = "0x11860FC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPopoutMenu), Member = "DrawMenu", MemberParameters = new object[]
		{
			typeof(PopoutMenu_Layout),
			typeof(string[]),
			typeof(ref Rectangle)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.AchievementUnlockedPopup), Member = "DrawInGame", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.AchievementUnlockedPopup), Member = "DrawInNotificationsArea", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Rectangle),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "DrawInGame", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "DrawInNotificationsArea", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Rectangle),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeChangeSettings", Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void DrawInvBG(SpriteBatch sb, Rectangle R, Color c = default(Color))
		{
			throw null;
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x000295B8 File Offset: 0x000277B8
		[global::Cpp2ILInjected.Token(Token = "0x6002BE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1186810", Offset = "0x1186810", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawInvBG", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void DrawInvBG(SpriteBatch sb, float x, float y, float w, float h, Color c = default(Color))
		{
			throw null;
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x000295BB File Offset: 0x000277BB
		[global::Cpp2ILInjected.Token(Token = "0x6002BE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1186188", Offset = "0x1186188", Length = "0x688")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "DrawInvBG", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetDiagnosticsUI), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Rectangle?),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void DrawInvBG(SpriteBatch sb, int x, int y, int w, int h, Color c = default(Color))
		{
			throw null;
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x000295BE File Offset: 0x000277BE
		[global::Cpp2ILInjected.Token(Token = "0x6002BE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x11868D0", Offset = "0x11868D0", Length = "0x300")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VanillaContentValidator), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public static string ReadEmbeddedResource(string path)
		{
			throw null;
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x000295C1 File Offset: 0x000277C1
		[global::Cpp2ILInjected.Token(Token = "0x6002BE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1186BD0", Offset = "0x1186BD0", Length = "0x644")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupOptionButton<>), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICharacterNameButton), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIColoredSliderSimple), Member = "DrawValueBarDynamicWidth", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIDifficultyButton), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIIconTextButton), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIResourcePackInfoButton<>), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UISelectableTextPanel<>), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UISlicedImage), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVerticalSlider), Member = "DrawValueBarDynamicWidth", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Rectangle?),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void DrawSplicedPanel(SpriteBatch sb, Texture2D texture, int x, int y, int w, int h, int leftEnd, int rightEnd, int topEnd, int bottomEnd, Color c)
		{
			throw null;
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x000295C4 File Offset: 0x000277C4
		[global::Cpp2ILInjected.Token(Token = "0x6002BE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1187214", Offset = "0x1187214", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIKeybindingToggleListItem), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void DrawSettingsPanel(SpriteBatch spriteBatch, Vector2 position, float width, Color color)
		{
			throw null;
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x000295C7 File Offset: 0x000277C7
		[global::Cpp2ILInjected.Token(Token = "0x6002BEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x118759C", Offset = "0x118759C", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIKeybindingSimpleListItem), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawPanel", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(int),
			typeof(int),
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void DrawSettings2Panel(SpriteBatch spriteBatch, Vector2 position, float width, Color color)
		{
			throw null;
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x000295CA File Offset: 0x000277CA
		[global::Cpp2ILInjected.Token(Token = "0x6002BEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x11872EC", Offset = "0x11872EC", Length = "0x2B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "DrawSettings2Panel", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIHorizontalSeparator), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void DrawPanel(Texture2D texture, int edgeWidth, int edgeShove, SpriteBatch spriteBatch, Vector2 position, float width, Color color)
		{
			throw null;
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x000295CD File Offset: 0x000277CD
		[global::Cpp2ILInjected.Token(Token = "0x6002BEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1187674", Offset = "0x1187674", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawWires", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawLine", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void DrawRectangle(SpriteBatch sb, Vector2 start, Vector2 end, Color colorStart, Color colorEnd, float width)
		{
			throw null;
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x000295D0 File Offset: 0x000277D0
		[global::Cpp2ILInjected.Token(Token = "0x6002BED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1187AF4", Offset = "0x1187AF4", Length = "0x3E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "HasNaNs", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(ref Vector2),
			typeof(ref Rectangle),
			typeof(ref Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void DrawLaser(SpriteBatch sb, Texture2D tex, Vector2 start, Vector2 end, Vector2 scale, Utils.LaserLineFraming framing)
		{
			throw null;
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x000295D3 File Offset: 0x000277D3
		[global::Cpp2ILInjected.Token(Token = "0x6002BEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1187EDC", Offset = "0x1187EDC", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawLine", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void DrawLine(SpriteBatch spriteBatch, Point start, Point end, Color color)
		{
			throw null;
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x000295D6 File Offset: 0x000277D6
		[global::Cpp2ILInjected.Token(Token = "0x6002BEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1187FAC", Offset = "0x1187FAC", Length = "0x320")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "DrawLine", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Point),
			typeof(Point),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "DrawRect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "DrawRect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector4),
			typeof(Vector4)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void DrawLine(SpriteBatch spriteBatch, Vector2 start, Vector2 end, Color color)
		{
			throw null;
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x000295D9 File Offset: 0x000277D9
		[global::Cpp2ILInjected.Token(Token = "0x6002BF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x11877F0", Offset = "0x11877F0", Length = "0x304")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "DrawRectangle", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void DrawLine(SpriteBatch spriteBatch, Vector2 start, Vector2 end, Color colorStart, Color colorEnd, float width)
		{
			throw null;
		}

		// Token: 0x06002937 RID: 10551 RVA: 0x000295DC File Offset: 0x000277DC
		[global::Cpp2ILInjected.Token(Token = "0x6002BF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x11882CC", Offset = "0x11882CC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawRectForTilesInWorld", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Point),
			typeof(Point),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void DrawRectForTilesInWorld(SpriteBatch spriteBatch, Rectangle rect, Color color)
		{
			throw null;
		}

		// Token: 0x06002938 RID: 10552 RVA: 0x000295DF File Offset: 0x000277DF
		[global::Cpp2ILInjected.Token(Token = "0x6002BF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1188388", Offset = "0x1188388", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "DrawRectForTilesInWorld", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Rectangle),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawRect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void DrawRectForTilesInWorld(SpriteBatch spriteBatch, Point start, Point end, Color color)
		{
			throw null;
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x000295E2 File Offset: 0x000277E2
		[global::Cpp2ILInjected.Token(Token = "0x6002BF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x11885A8", Offset = "0x11885A8", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawRect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void DrawRect(SpriteBatch spriteBatch, Rectangle rect, Color color)
		{
			throw null;
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x000295E5 File Offset: 0x000277E5
		[global::Cpp2ILInjected.Token(Token = "0x6002BF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1188460", Offset = "0x1188460", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "DrawRectForTilesInWorld", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Point),
			typeof(Point),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "DrawRect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Rectangle),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_DrawSelectionRect", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_DrawSelectionRect", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawLine", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void DrawRect(SpriteBatch spriteBatch, Vector2 start, Vector2 end, Color color)
		{
			throw null;
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x000295E8 File Offset: 0x000277E8
		[global::Cpp2ILInjected.Token(Token = "0x6002BF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1188670", Offset = "0x1188670", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawLine", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void DrawRect(SpriteBatch spriteBatch, Vector2 topLeft, Vector2 topRight, Vector2 bottomRight, Vector2 bottomLeft, Color color)
		{
			throw null;
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x000295EB File Offset: 0x000277EB
		[global::Cpp2ILInjected.Token(Token = "0x6002BF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x118877C", Offset = "0x118877C", Length = "0x53C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeEdgeSelection", Member = "DrawCursors", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaptureInterface), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ThickMouse", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "DrawThickCursor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "MultiplyRGB", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public static void DrawCursorSingle(SpriteBatch sb, Color color, float rot = float.NaN, float scale = 1f, Vector2 manualPosition = default(Vector2), int cursorSlot = 0, int specialMode = 0)
		{
			throw null;
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x000295EE File Offset: 0x000277EE
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002BF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1188CB8", Offset = "0x1188CB8", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils.TileActionAttempt), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		static Utils()
		{
			throw null;
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x000295F1 File Offset: 0x000277F1
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6002BF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x11841AC", Offset = "0x11841AC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotLineOffset", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "PlotLine", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static bool Method_Internal_Static_Boolean_Int32_Int32_<>c__DisplayClass149_0_0(int xVal, int yVal, ref Utils.<>c__DisplayClass149_0 A_2)
		{
			throw null;
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x000295F4 File Offset: 0x000277F4
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6002BF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x118455C", Offset = "0x118455C", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "PlotLineOffsetTale", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(int),
			typeof(double),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(double)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2D) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "PlotLine", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Utils.TileActionAttempt),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static bool Method_Internal_Static_Boolean_Int32_Int32_<>c__DisplayClass150_0_0(int xVal, int yVal, ref Utils.<>c__DisplayClass150_0 A_2)
		{
			throw null;
		}

		// Token: 0x04002FBA RID: 12218
		[global::Cpp2ILInjected.Token(Token = "0x400379F")]
		public const long MaxCoins = 999999999L;

		// Token: 0x04002FBB RID: 12219
		[global::Cpp2ILInjected.Token(Token = "0x40037A0")]
		public static Dictionary<SpriteFont, float[]> charLengths;

		// Token: 0x04002FBC RID: 12220
		[global::Cpp2ILInjected.Token(Token = "0x40037A1")]
		private static Regex _substitutionRegex;

		// Token: 0x04002FBD RID: 12221
		[global::Cpp2ILInjected.Token(Token = "0x40037A2")]
		private const ulong RANDOM_MULTIPLIER = 25214903917UL;

		// Token: 0x04002FBE RID: 12222
		[global::Cpp2ILInjected.Token(Token = "0x40037A3")]
		private const ulong RANDOM_ADD = 11UL;

		// Token: 0x04002FBF RID: 12223
		[global::Cpp2ILInjected.Token(Token = "0x40037A4")]
		private const ulong RANDOM_MASK = 281474976710655UL;

		// Token: 0x04002FC0 RID: 12224
		[global::Cpp2ILInjected.Token(Token = "0x40037A5")]
		private static Utils.TileActionAttempt plotInnerCall;

		// Token: 0x04002FC1 RID: 12225
		[global::Cpp2ILInjected.Token(Token = "0x40037A6")]
		private static Point plotInnerLineMinOffset;

		// Token: 0x04002FC2 RID: 12226
		[global::Cpp2ILInjected.Token(Token = "0x40037A7")]
		private static Point plotInnerLineMaxOffset;

		// Token: 0x04002FC3 RID: 12227
		[global::Cpp2ILInjected.Token(Token = "0x40037A8")]
		private static Utils.TileActionAttempt PlotTileLineInnerInstance;

		// Token: 0x02000870 RID: 2160
		// (Invoke) Token: 0x06004A82 RID: 19074
		[global::Cpp2ILInjected.Token(Token = "0x2000466")]
		public delegate bool TileActionAttempt(int x, int y);

		// Token: 0x02000871 RID: 2161
		// (Invoke) Token: 0x06004A86 RID: 19078
		[global::Cpp2ILInjected.Token(Token = "0x2000467")]
		public delegate void LaserLineFraming(int stage, out float distanceCovered, out Rectangle frame, out Vector2 origin, out Color color);

		// Token: 0x02000872 RID: 2162
		// (Invoke) Token: 0x06004A8A RID: 19082
		[global::Cpp2ILInjected.Token(Token = "0x2000468")]
		public delegate Color ColorLerpMethod(float percent);

		// Token: 0x02000873 RID: 2163
		[global::Cpp2ILInjected.Token(Token = "0x2000469")]
		public struct ChaseResults
		{
			// Token: 0x04007F9B RID: 32667
			[global::Cpp2ILInjected.Token(Token = "0x40037A9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public bool InterceptionHappens;

			// Token: 0x04007F9C RID: 32668
			[global::Cpp2ILInjected.Token(Token = "0x40037AA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public Vector2 InterceptionPosition;

			// Token: 0x04007F9D RID: 32669
			[global::Cpp2ILInjected.Token(Token = "0x40037AB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public float InterceptionTime;

			// Token: 0x04007F9E RID: 32670
			[global::Cpp2ILInjected.Token(Token = "0x40037AC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Vector2 ChaserVelocity;
		}

		// Token: 0x02000874 RID: 2164
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200046A")]
		private sealed class <>c__DisplayClass47_0
		{
			// Token: 0x06004A8D RID: 19085 RVA: 0x0002F354 File Offset: 0x0002D554
			[global::Cpp2ILInjected.Token(Token = "0x6002C06")]
			[global::Cpp2ILInjected.Address(RVA = "0x1180A90", Offset = "0x1180A90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass47_0()
			{
				throw null;
			}

			// Token: 0x06004A8E RID: 19086 RVA: 0x0002F357 File Offset: 0x0002D557
			[global::Cpp2ILInjected.Token(Token = "0x6002C07")]
			[global::Cpp2ILInjected.Address(RVA = "0x1189358", Offset = "0x1189358", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Group))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal string <FormatWith>b__0(Match match)
			{
				throw null;
			}

			// Token: 0x04007F9F RID: 32671
			[global::Cpp2ILInjected.Token(Token = "0x40037AD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public PropertyDescriptorCollection properties;

			// Token: 0x04007FA0 RID: 32672
			[global::Cpp2ILInjected.Token(Token = "0x40037AE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public object obj;
		}

		// Token: 0x02000875 RID: 2165
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200046B")]
		[StructLayout(3)]
		private struct <>c__DisplayClass149_0
		{
			// Token: 0x04007FA1 RID: 32673
			[global::Cpp2ILInjected.Token(Token = "0x40037AF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Point lineMinOffset;

			// Token: 0x04007FA2 RID: 32674
			[global::Cpp2ILInjected.Token(Token = "0x40037B0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public Point lineMaxOffset;

			// Token: 0x04007FA3 RID: 32675
			[global::Cpp2ILInjected.Token(Token = "0x40037B1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Utils.TileActionAttempt plot;
		}

		// Token: 0x02000876 RID: 2166
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200046C")]
		[StructLayout(3)]
		private struct <>c__DisplayClass150_0
		{
			// Token: 0x04007FA4 RID: 32676
			[global::Cpp2ILInjected.Token(Token = "0x40037B2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int curLength;

			// Token: 0x04007FA5 RID: 32677
			[global::Cpp2ILInjected.Token(Token = "0x40037B3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int length;

			// Token: 0x04007FA6 RID: 32678
			[global::Cpp2ILInjected.Token(Token = "0x40037B4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public Point lineStartMinOffset;

			// Token: 0x04007FA7 RID: 32679
			[global::Cpp2ILInjected.Token(Token = "0x40037B5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Vector2D start;

			// Token: 0x04007FA8 RID: 32680
			[global::Cpp2ILInjected.Token(Token = "0x40037B6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public Vector2D perpOffset;

			// Token: 0x04007FA9 RID: 32681
			[global::Cpp2ILInjected.Token(Token = "0x40037B7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public double halfWidth;

			// Token: 0x04007FAA RID: 32682
			[global::Cpp2ILInjected.Token(Token = "0x40037B8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public Point lineStartMaxOffset;

			// Token: 0x04007FAB RID: 32683
			[global::Cpp2ILInjected.Token(Token = "0x40037B9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public Point lineMinOffset;

			// Token: 0x04007FAC RID: 32684
			[global::Cpp2ILInjected.Token(Token = "0x40037BA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			public int x0;

			// Token: 0x04007FAD RID: 32685
			[global::Cpp2ILInjected.Token(Token = "0x40037BB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
			public int y0;

			// Token: 0x04007FAE RID: 32686
			[global::Cpp2ILInjected.Token(Token = "0x40037BC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			public Point lineMaxOffset;

			// Token: 0x04007FAF RID: 32687
			[global::Cpp2ILInjected.Token(Token = "0x40037BD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			public Utils.TileActionAttempt plot;
		}
	}
}
