using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Biomes.Desert;
using Terraria.GameContent.Generation;
using Terraria.IO;
using Terraria.WorldBuilding;

namespace ReLogic.Utilities
{
	// Token: 0x02000714 RID: 1812
	[DebuggerDisplay("{DebugDisplayString,nq}")]
	[global::Cpp2ILInjected.Token(Token = "0x2000B0D")]
	[Serializable]
	public struct Vector2D : IEquatable<Vector2D>
	{
		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06004613 RID: 17939 RVA: 0x0002E8AD File Offset: 0x0002CAAD
		[global::Cpp2ILInjected.Token(Token = "0x170008EA")]
		public static Vector2D Zero
		{
			[global::Cpp2ILInjected.Token(Token = "0x60052BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x93EEC8", Offset = "0x93EEC8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06004614 RID: 17940 RVA: 0x0002E8B0 File Offset: 0x0002CAB0
		[global::Cpp2ILInjected.Token(Token = "0x170008EB")]
		public static Vector2D One
		{
			[global::Cpp2ILInjected.Token(Token = "0x60052BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x93EF20", Offset = "0x93EF20", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06004615 RID: 17941 RVA: 0x0002E8B3 File Offset: 0x0002CAB3
		[global::Cpp2ILInjected.Token(Token = "0x170008EC")]
		public static Vector2D UnitX
		{
			[global::Cpp2ILInjected.Token(Token = "0x60052BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x93EF78", Offset = "0x93EF78", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06004616 RID: 17942 RVA: 0x0002E8B6 File Offset: 0x0002CAB6
		[global::Cpp2ILInjected.Token(Token = "0x170008ED")]
		public static Vector2D UnitY
		{
			[global::Cpp2ILInjected.Token(Token = "0x60052BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x93EFD0", Offset = "0x93EFD0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06004617 RID: 17943 RVA: 0x0002E8B9 File Offset: 0x0002CAB9
		[global::Cpp2ILInjected.Token(Token = "0x170008EE")]
		internal string DebugDisplayString
		{
			[global::Cpp2ILInjected.Token(Token = "0x60052BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x93F028", Offset = "0x93F028", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004618 RID: 17944 RVA: 0x0002E8BC File Offset: 0x0002CABC
		[global::Cpp2ILInjected.Token(Token = "0x60052BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F094", Offset = "0x93F094", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 80)]
		public Vector2D(double x, double y)
		{
			throw null;
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x0002E8BF File Offset: 0x0002CABF
		[global::Cpp2ILInjected.Token(Token = "0x60052C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F09C", Offset = "0x93F09C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Vector2D(double value)
		{
			throw null;
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x0002E8C2 File Offset: 0x0002CAC2
		[global::Cpp2ILInjected.Token(Token = "0x60052C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F0A4", Offset = "0x93F0A4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600461B RID: 17947 RVA: 0x0002E8C5 File Offset: 0x0002CAC5
		[global::Cpp2ILInjected.Token(Token = "0x60052C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F12C", Offset = "0x93F12C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(Vector2D other)
		{
			throw null;
		}

		// Token: 0x0600461C RID: 17948 RVA: 0x0002E8C8 File Offset: 0x0002CAC8
		[global::Cpp2ILInjected.Token(Token = "0x60052C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F150", Offset = "0x93F150", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600461D RID: 17949 RVA: 0x0002E8CB File Offset: 0x0002CACB
		[global::Cpp2ILInjected.Token(Token = "0x60052C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F228", Offset = "0x93F228", Length = "0x6C")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowLivingTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowDungeonTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "oceanCave", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeBranch), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "SimulatePressure", MemberParameters = new object[] { typeof(ref Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup",
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public double Length()
		{
			throw null;
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x0002E8CE File Offset: 0x0002CACE
		[global::Cpp2ILInjected.Token(Token = "0x60052C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F294", Offset = "0x93F294", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public double LengthSquared()
		{
			throw null;
		}

		// Token: 0x0600461F RID: 17951 RVA: 0x0002E8D1 File Offset: 0x0002CAD1
		[global::Cpp2ILInjected.Token(Token = "0x60052C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F2A8", Offset = "0x93F2A8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Normalize()
		{
			throw null;
		}

		// Token: 0x06004620 RID: 17952 RVA: 0x0002E8D4 File Offset: 0x0002CAD4
		[global::Cpp2ILInjected.Token(Token = "0x60052C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F334", Offset = "0x93F334", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06004621 RID: 17953 RVA: 0x0002E8D7 File Offset: 0x0002CAD7
		[global::Cpp2ILInjected.Token(Token = "0x60052C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F498", Offset = "0x93F498", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2D Add(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		// Token: 0x06004622 RID: 17954 RVA: 0x0002E8DA File Offset: 0x0002CADA
		[global::Cpp2ILInjected.Token(Token = "0x60052C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F4A4", Offset = "0x93F4A4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Add(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
		{
			throw null;
		}

		// Token: 0x06004623 RID: 17955 RVA: 0x0002E8DD File Offset: 0x0002CADD
		[global::Cpp2ILInjected.Token(Token = "0x60052CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F4B8", Offset = "0x93F4B8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2D Barycentric(Vector2D value1, Vector2D value2, Vector2D value3, double amount1, double amount2)
		{
			throw null;
		}

		// Token: 0x06004624 RID: 17956 RVA: 0x0002E8E0 File Offset: 0x0002CAE0
		[global::Cpp2ILInjected.Token(Token = "0x60052CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F590", Offset = "0x93F590", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Barycentric(ref Vector2D value1, ref Vector2D value2, ref Vector2D value3, double amount1, double amount2, out Vector2D result)
		{
			throw null;
		}

		// Token: 0x06004625 RID: 17957 RVA: 0x0002E8E3 File Offset: 0x0002CAE3
		[global::Cpp2ILInjected.Token(Token = "0x60052CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F664", Offset = "0x93F664", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2D CatmullRom(Vector2D value1, Vector2D value2, Vector2D value3, Vector2D value4, double amount)
		{
			throw null;
		}

		// Token: 0x06004626 RID: 17958 RVA: 0x0002E8E6 File Offset: 0x0002CAE6
		[global::Cpp2ILInjected.Token(Token = "0x60052CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F7EC", Offset = "0x93F7EC", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void CatmullRom(ref Vector2D value1, ref Vector2D value2, ref Vector2D value3, ref Vector2D value4, double amount, out Vector2D result)
		{
			throw null;
		}

		// Token: 0x06004627 RID: 17959 RVA: 0x0002E8E9 File Offset: 0x0002CAE9
		[global::Cpp2ILInjected.Token(Token = "0x60052CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F920", Offset = "0x93F920", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeRunner), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2D Clamp(Vector2D value1, Vector2D min, Vector2D max)
		{
			throw null;
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x0002E8EC File Offset: 0x0002CAEC
		[global::Cpp2ILInjected.Token(Token = "0x60052CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F9D0", Offset = "0x93F9D0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Clamp(ref Vector2D value1, ref Vector2D min, ref Vector2D max, out Vector2D result)
		{
			throw null;
		}

		// Token: 0x06004629 RID: 17961 RVA: 0x0002E8EF File Offset: 0x0002CAEF
		[global::Cpp2ILInjected.Token(Token = "0x60052D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FA8C", Offset = "0x93FA8C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_20", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_43", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_55", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_64", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "placeTrap", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "PlaceOasis", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Modifiers.RadialDither), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HiveBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static double Distance(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		// Token: 0x0600462A RID: 17962 RVA: 0x0002E8F2 File Offset: 0x0002CAF2
		[global::Cpp2ILInjected.Token(Token = "0x60052D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FB10", Offset = "0x93FB10", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Distance(ref Vector2D value1, ref Vector2D value2, out double result)
		{
			throw null;
		}

		// Token: 0x0600462B RID: 17963 RVA: 0x0002E8F5 File Offset: 0x0002CAF5
		[global::Cpp2ILInjected.Token(Token = "0x60052D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FB9C", Offset = "0x93FB9C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static double DistanceSquared(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		// Token: 0x0600462C RID: 17964 RVA: 0x0002E8F8 File Offset: 0x0002CAF8
		[global::Cpp2ILInjected.Token(Token = "0x60052D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FBB4", Offset = "0x93FBB4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void DistanceSquared(ref Vector2D value1, ref Vector2D value2, out double result)
		{
			throw null;
		}

		// Token: 0x0600462D RID: 17965 RVA: 0x0002E8FB File Offset: 0x0002CAFB
		[global::Cpp2ILInjected.Token(Token = "0x60052D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FBD8", Offset = "0x93FBD8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2D Divide(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		// Token: 0x0600462E RID: 17966 RVA: 0x0002E8FE File Offset: 0x0002CAFE
		[global::Cpp2ILInjected.Token(Token = "0x60052D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FBE4", Offset = "0x93FBE4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Divide(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
		{
			throw null;
		}

		// Token: 0x0600462F RID: 17967 RVA: 0x0002E901 File Offset: 0x0002CB01
		[global::Cpp2ILInjected.Token(Token = "0x60052D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FBF8", Offset = "0x93FBF8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2D Divide(Vector2D value1, double divider)
		{
			throw null;
		}

		// Token: 0x06004630 RID: 17968 RVA: 0x0002E904 File Offset: 0x0002CB04
		[global::Cpp2ILInjected.Token(Token = "0x60052D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FC0C", Offset = "0x93FC0C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Divide(ref Vector2D value1, double divider, out Vector2D result)
		{
			throw null;
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x0002E907 File Offset: 0x0002CB07
		[global::Cpp2ILInjected.Token(Token = "0x60052D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FC24", Offset = "0x93FC24", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static double Dot(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x0002E90A File Offset: 0x0002CB0A
		[global::Cpp2ILInjected.Token(Token = "0x60052D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FC34", Offset = "0x93FC34", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Dot(ref Vector2D value1, ref Vector2D value2, out double result)
		{
			throw null;
		}

		// Token: 0x06004633 RID: 17971 RVA: 0x0002E90D File Offset: 0x0002CB0D
		[global::Cpp2ILInjected.Token(Token = "0x60052DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FC50", Offset = "0x93FC50", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "Hermite", MemberParameters = new object[]
		{
			typeof(ref Vector2D),
			typeof(ref Vector2D),
			typeof(ref Vector2D),
			typeof(ref Vector2D),
			typeof(double),
			typeof(ref Vector2D)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2D Hermite(Vector2D value1, Vector2D tangent1, Vector2D value2, Vector2D tangent2, double amount)
		{
			throw null;
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x0002E910 File Offset: 0x0002CB10
		[global::Cpp2ILInjected.Token(Token = "0x60052DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FCE4", Offset = "0x93FCE4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector2D), Member = "Hermite", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "Hermite", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double),
			typeof(double),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Hermite(ref Vector2D value1, ref Vector2D tangent1, ref Vector2D value2, ref Vector2D tangent2, double amount, out Vector2D result)
		{
			throw null;
		}

		// Token: 0x06004635 RID: 17973 RVA: 0x0002E913 File Offset: 0x0002CB13
		[global::Cpp2ILInjected.Token(Token = "0x60052DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FED4", Offset = "0x93FED4", Length = "0x90")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2D Lerp(Vector2D value1, Vector2D value2, double amount)
		{
			throw null;
		}

		// Token: 0x06004636 RID: 17974 RVA: 0x0002E916 File Offset: 0x0002CB16
		[global::Cpp2ILInjected.Token(Token = "0x60052DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FF74", Offset = "0x93FF74", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Lerp(ref Vector2D value1, ref Vector2D value2, double amount, out Vector2D result)
		{
			throw null;
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x0002E919 File Offset: 0x0002CB19
		[global::Cpp2ILInjected.Token(Token = "0x60052DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x940018", Offset = "0x940018", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2D Max(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		// Token: 0x06004638 RID: 17976 RVA: 0x0002E91C File Offset: 0x0002CB1C
		[global::Cpp2ILInjected.Token(Token = "0x60052DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x94002C", Offset = "0x94002C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Max(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
		{
			throw null;
		}

		// Token: 0x06004639 RID: 17977 RVA: 0x0002E91F File Offset: 0x0002CB1F
		[global::Cpp2ILInjected.Token(Token = "0x60052E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x940058", Offset = "0x940058", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2D Min(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		// Token: 0x0600463A RID: 17978 RVA: 0x0002E922 File Offset: 0x0002CB22
		[global::Cpp2ILInjected.Token(Token = "0x60052E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x94006C", Offset = "0x94006C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Min(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
		{
			throw null;
		}

		// Token: 0x0600463B RID: 17979 RVA: 0x0002E925 File Offset: 0x0002CB25
		[global::Cpp2ILInjected.Token(Token = "0x60052E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x940098", Offset = "0x940098", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2D Multiply(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		// Token: 0x0600463C RID: 17980 RVA: 0x0002E928 File Offset: 0x0002CB28
		[global::Cpp2ILInjected.Token(Token = "0x60052E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x9400A4", Offset = "0x9400A4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2D Multiply(Vector2D value1, double scaleFactor)
		{
			throw null;
		}

		// Token: 0x0600463D RID: 17981 RVA: 0x0002E92B File Offset: 0x0002CB2B
		[global::Cpp2ILInjected.Token(Token = "0x60052E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x9400B0", Offset = "0x9400B0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Multiply(ref Vector2D value1, double scaleFactor, out Vector2D result)
		{
			throw null;
		}

		// Token: 0x0600463E RID: 17982 RVA: 0x0002E92E File Offset: 0x0002CB2E
		[global::Cpp2ILInjected.Token(Token = "0x60052E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x9400C0", Offset = "0x9400C0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Multiply(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
		{
			throw null;
		}

		// Token: 0x0600463F RID: 17983 RVA: 0x0002E931 File Offset: 0x0002CB31
		[global::Cpp2ILInjected.Token(Token = "0x60052E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x9400D4", Offset = "0x9400D4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2D Negate(Vector2D value)
		{
			throw null;
		}

		// Token: 0x06004640 RID: 17984 RVA: 0x0002E934 File Offset: 0x0002CB34
		[global::Cpp2ILInjected.Token(Token = "0x60052E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x9400E0", Offset = "0x9400E0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Negate(ref Vector2D value, out Vector2D result)
		{
			throw null;
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x0002E937 File Offset: 0x0002CB37
		[global::Cpp2ILInjected.Token(Token = "0x60052E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x9400F0", Offset = "0x9400F0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2D Normalize(Vector2D value)
		{
			throw null;
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x0002E93A File Offset: 0x0002CB3A
		[global::Cpp2ILInjected.Token(Token = "0x60052E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x94016C", Offset = "0x94016C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Normalize(ref Vector2D value, out Vector2D result)
		{
			throw null;
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x0002E93D File Offset: 0x0002CB3D
		[global::Cpp2ILInjected.Token(Token = "0x60052EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x940204", Offset = "0x940204", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2D Reflect(Vector2D vector, Vector2D normal)
		{
			throw null;
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x0002E940 File Offset: 0x0002CB40
		[global::Cpp2ILInjected.Token(Token = "0x60052EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x940228", Offset = "0x940228", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Reflect(ref Vector2D vector, ref Vector2D normal, out Vector2D result)
		{
			throw null;
		}

		// Token: 0x06004645 RID: 17989 RVA: 0x0002E943 File Offset: 0x0002CB43
		[global::Cpp2ILInjected.Token(Token = "0x60052EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x940258", Offset = "0x940258", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Vector2D SmoothStep(Vector2D value1, Vector2D value2, double amount)
		{
			throw null;
		}

		// Token: 0x06004646 RID: 17990 RVA: 0x0002E946 File Offset: 0x0002CB46
		[global::Cpp2ILInjected.Token(Token = "0x60052ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x940384", Offset = "0x940384", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SmoothStep(ref Vector2D value1, ref Vector2D value2, double amount, out Vector2D result)
		{
			throw null;
		}

		// Token: 0x06004647 RID: 17991 RVA: 0x0002E949 File Offset: 0x0002CB49
		[global::Cpp2ILInjected.Token(Token = "0x60052EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x940428", Offset = "0x940428", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Vector2D Subtract(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x0002E94C File Offset: 0x0002CB4C
		[global::Cpp2ILInjected.Token(Token = "0x60052EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x940434", Offset = "0x940434", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Subtract(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
		{
			throw null;
		}

		// Token: 0x06004649 RID: 17993 RVA: 0x0002E94F File Offset: 0x0002CB4F
		[global::Cpp2ILInjected.Token(Token = "0x60052F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x940448", Offset = "0x940448", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "IsSafeFromRain", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeRunner), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static Vector2D operator -(Vector2D value)
		{
			throw null;
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x0002E952 File Offset: 0x0002CB52
		[global::Cpp2ILInjected.Token(Token = "0x60052F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x940454", Offset = "0x940454", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeRunner), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool operator ==(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x0002E955 File Offset: 0x0002CB55
		[global::Cpp2ILInjected.Token(Token = "0x60052F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x94046C", Offset = "0x94046C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "DungeonHalls", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool operator !=(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x0002E958 File Offset: 0x0002CB58
		[global::Cpp2ILInjected.Token(Token = "0x60052F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x9404EC", Offset = "0x9404EC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 59)]
		public static Vector2D operator +(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x0002E95B File Offset: 0x0002CB5B
		[global::Cpp2ILInjected.Token(Token = "0x60052F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x9404F8", Offset = "0x9404F8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(double),
			typeof(Vector2D)
		}, ReturnType = typeof(Vector2D))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowLivingTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GrowDungeonTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup",
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		public static Vector2D operator -(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		// Token: 0x0600464E RID: 17998 RVA: 0x0002E95E File Offset: 0x0002CB5E
		[global::Cpp2ILInjected.Token(Token = "0x60052F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x940504", Offset = "0x940504", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup",
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static Vector2D operator *(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x0002E961 File Offset: 0x0002CB61
		[global::Cpp2ILInjected.Token(Token = "0x60052F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x940510", Offset = "0x940510", Length = "0xC")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "<PlotLineOffsetTale>g__PlotAtOffset|150_0", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref Utils.<>c__DisplayClass150_0)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "neonMossBiome", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "IsSafeFromRain", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Shapes.Tail), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(double),
			typeof(Vector2D)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShapeBranch), Member = "Perform", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(GenAction)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup",
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		public static Vector2D operator *(Vector2D value, double scaleFactor)
		{
			throw null;
		}

		// Token: 0x06004650 RID: 18000 RVA: 0x0002E964 File Offset: 0x0002CB64
		[global::Cpp2ILInjected.Token(Token = "0x60052F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x94051C", Offset = "0x94051C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraniteBiome), Member = "SimulatePressure", MemberParameters = new object[] { typeof(ref Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static Vector2D operator *(double scaleFactor, Vector2D value)
		{
			throw null;
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x0002E967 File Offset: 0x0002CB67
		[global::Cpp2ILInjected.Token(Token = "0x60052F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x94052C", Offset = "0x94052C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup",
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static Vector2D operator /(Vector2D value1, Vector2D value2)
		{
			throw null;
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x0002E96A File Offset: 0x0002CB6A
		[global::Cpp2ILInjected.Token(Token = "0x60052F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x940538", Offset = "0x940538", Length = "0x14")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DesertHive), Member = "PlaceClustersArea", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			"Terraria.GameContent.Biomes.Desert.DesertHive.ClusterGroup",
			typeof(Rectangle),
			typeof(DesertHive.PostPlacementEffect[,,]),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public static Vector2D operator /(Vector2D value1, double divider)
		{
			throw null;
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x0002E96D File Offset: 0x0002CB6D
		[global::Cpp2ILInjected.Token(Token = "0x60052FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F9BC", Offset = "0x93F9BC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static double Clamp(double value, double min, double max)
		{
			throw null;
		}

		// Token: 0x06004654 RID: 18004 RVA: 0x0002E970 File Offset: 0x0002CB70
		[global::Cpp2ILInjected.Token(Token = "0x60052FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FF64", Offset = "0x93FF64", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static double Lerp(double value1, double value2, double amount)
		{
			throw null;
		}

		// Token: 0x06004655 RID: 18005 RVA: 0x0002E973 File Offset: 0x0002CB73
		[global::Cpp2ILInjected.Token(Token = "0x60052FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x9402FC", Offset = "0x9402FC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector2D), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(Vector2D),
			typeof(Vector2D),
			typeof(double)
		}, ReturnType = typeof(Vector2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector2D), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(ref Vector2D),
			typeof(ref Vector2D),
			typeof(double),
			typeof(ref Vector2D)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2D), Member = "Hermite", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double),
			typeof(double),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static double SmoothStep(double value1, double value2, double amount)
		{
			throw null;
		}

		// Token: 0x06004656 RID: 18006 RVA: 0x0002E976 File Offset: 0x0002CB76
		[global::Cpp2ILInjected.Token(Token = "0x60052FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x93FDB8", Offset = "0x93FDB8", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector2D), Member = "Hermite", MemberParameters = new object[]
		{
			typeof(ref Vector2D),
			typeof(ref Vector2D),
			typeof(ref Vector2D),
			typeof(ref Vector2D),
			typeof(double),
			typeof(ref Vector2D)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Vector2D), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static double Hermite(double value1, double tangent1, double value2, double tangent2, double amount)
		{
			throw null;
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x0002E979 File Offset: 0x0002CB79
		[global::Cpp2ILInjected.Token(Token = "0x60052FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F574", Offset = "0x93F574", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static double Barycentric(double value1, double value2, double value3, double amount1, double amount2)
		{
			throw null;
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x0002E97C File Offset: 0x0002CB7C
		[global::Cpp2ILInjected.Token(Token = "0x60052FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x93F780", Offset = "0x93F780", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static double CatmullRom(double value1, double value2, double value3, double value4, double amount)
		{
			throw null;
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x0002E97F File Offset: 0x0002CB7F
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6005300")]
		[global::Cpp2ILInjected.Address(RVA = "0x94054C", Offset = "0x94054C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static Vector2D()
		{
			throw null;
		}

		// Token: 0x0400715A RID: 29018
		[global::Cpp2ILInjected.Token(Token = "0x4008AE0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public double X;

		// Token: 0x0400715B RID: 29019
		[global::Cpp2ILInjected.Token(Token = "0x4008AE1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public double Y;

		// Token: 0x0400715C RID: 29020
		[global::Cpp2ILInjected.Token(Token = "0x4008AE2")]
		private static Vector2D zeroVector;

		// Token: 0x0400715D RID: 29021
		[global::Cpp2ILInjected.Token(Token = "0x4008AE3")]
		private static Vector2D unitVector;

		// Token: 0x0400715E RID: 29022
		[global::Cpp2ILInjected.Token(Token = "0x4008AE4")]
		private static Vector2D unitXVector;

		// Token: 0x0400715F RID: 29023
		[global::Cpp2ILInjected.Token(Token = "0x4008AE5")]
		private static Vector2D unitYVector;

		// Token: 0x04007160 RID: 29024
		[global::Cpp2ILInjected.Token(Token = "0x4008AE6")]
		public static readonly double DoubleEpsilon;
	}
}
