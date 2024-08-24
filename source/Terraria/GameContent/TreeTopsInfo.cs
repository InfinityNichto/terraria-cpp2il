using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.IO;
using Terraria.Localization;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent
{
	// Token: 0x02000570 RID: 1392
	[global::Cpp2ILInjected.Token(Token = "0x2000804")]
	public class TreeTopsInfo
	{
		// Token: 0x06003AAF RID: 15023 RVA: 0x0002C7A4 File Offset: 0x0002A9A4
		[global::Cpp2ILInjected.Token(Token = "0x60041C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x7831B4", Offset = "0x7831B4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "SaveWorldHeader", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Save(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x0002C7A7 File Offset: 0x0002A9A7
		[global::Cpp2ILInjected.Token(Token = "0x60041C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x783230", Offset = "0x783230", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadHeader", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Load(BinaryReader reader, int loadVersion)
		{
			throw null;
		}

		// Token: 0x06003AB1 RID: 15025 RVA: 0x0002C7AA File Offset: 0x0002A9AA
		[global::Cpp2ILInjected.Token(Token = "0x60041C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x783500", Offset = "0x783500", Length = "0x5C")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void SyncSend(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x06003AB2 RID: 15026 RVA: 0x0002C7AD File Offset: 0x0002A9AD
		[global::Cpp2ILInjected.Token(Token = "0x60041C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x78355C", Offset = "0x78355C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void SyncReceive(BinaryReader reader)
		{
			throw null;
		}

		// Token: 0x06003AB3 RID: 15027 RVA: 0x0002C7B0 File Offset: 0x0002A9B0
		[global::Cpp2ILInjected.Token(Token = "0x60041C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x7835C8", Offset = "0x7835C8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GetCommonTreeFoliageData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GetHollowTreeFoliageStyle", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public int GetTreeStyle(int areaId)
		{
			throw null;
		}

		// Token: 0x06003AB4 RID: 15028 RVA: 0x0002C7B3 File Offset: 0x0002A9B3
		[global::Cpp2ILInjected.Token(Token = "0x60041C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x7835D8", Offset = "0x7835D8", Length = "0x30C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Framing), Member = "GetTileSafely", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "oceanDepths", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TreeTopsInfo), Member = "RandomizeTreeStyle", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void RandomizeTreeStyleBasedOnWorldPosition(UnifiedRandom rand, Vector2 worldPosition)
		{
			throw null;
		}

		// Token: 0x06003AB5 RID: 15029 RVA: 0x0002C7B6 File Offset: 0x0002A9B6
		[global::Cpp2ILInjected.Token(Token = "0x60041C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x7838E4", Offset = "0x7838E4", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TreeTopsInfo), Member = "RandomizeTreeStyleBasedOnWorldPosition", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "NextFromList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(int[])
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void RandomizeTreeStyle(UnifiedRandom rand, int areaId)
		{
			throw null;
		}

		// Token: 0x06003AB6 RID: 15030 RVA: 0x0002C7B9 File Offset: 0x0002A9B9
		[global::Cpp2ILInjected.Token(Token = "0x60041C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x7835C4", Offset = "0x7835C4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void DoTreeFX(int areaID)
		{
			throw null;
		}

		// Token: 0x06003AB7 RID: 15031 RVA: 0x0002C7BC File Offset: 0x0002A9BC
		[global::Cpp2ILInjected.Token(Token = "0x60041C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x783AC4", Offset = "0x783AC4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_0", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TreeTopsInfo), Member = "CopyExistingWorldInfo", ReturnType = typeof(void))]
		public void CopyExistingWorldInfoForWorldGeneration()
		{
			throw null;
		}

		// Token: 0x06003AB8 RID: 15032 RVA: 0x0002C7BF File Offset: 0x0002A9BF
		[global::Cpp2ILInjected.Token(Token = "0x60041C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x7833EC", Offset = "0x7833EC", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadHeader", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadHeader", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TreeTopsInfo), Member = "CopyExistingWorldInfoForWorldGeneration", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void CopyExistingWorldInfo()
		{
			throw null;
		}

		// Token: 0x06003AB9 RID: 15033 RVA: 0x0002C7C2 File Offset: 0x0002A9C2
		[global::Cpp2ILInjected.Token(Token = "0x60041CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x783AC8", Offset = "0x783AC8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public TreeTopsInfo()
		{
			throw null;
		}

		// Token: 0x04006AC0 RID: 27328
		[global::Cpp2ILInjected.Token(Token = "0x4008089")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int[] _variations;

		// Token: 0x0200099F RID: 2463
		[global::Cpp2ILInjected.Token(Token = "0x2000805")]
		public class AreaId
		{
			// Token: 0x06004DE6 RID: 19942 RVA: 0x0002FBFA File Offset: 0x0002DDFA
			[global::Cpp2ILInjected.Token(Token = "0x60041CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x783B4C", Offset = "0x783B4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public AreaId()
			{
				throw null;
			}

			// Token: 0x06004DE7 RID: 19943 RVA: 0x0002FBFD File Offset: 0x0002DDFD
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60041CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x783B54", Offset = "0x783B54", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			static AreaId()
			{
				throw null;
			}

			// Token: 0x04008C7E RID: 35966
			[global::Cpp2ILInjected.Token(Token = "0x400808A")]
			public const int Forest1 = 0;

			// Token: 0x04008C7F RID: 35967
			[global::Cpp2ILInjected.Token(Token = "0x400808B")]
			public const int Forest2 = 1;

			// Token: 0x04008C80 RID: 35968
			[global::Cpp2ILInjected.Token(Token = "0x400808C")]
			public const int Forest3 = 2;

			// Token: 0x04008C81 RID: 35969
			[global::Cpp2ILInjected.Token(Token = "0x400808D")]
			public const int Forest4 = 3;

			// Token: 0x04008C82 RID: 35970
			[global::Cpp2ILInjected.Token(Token = "0x400808E")]
			public const int Corruption = 4;

			// Token: 0x04008C83 RID: 35971
			[global::Cpp2ILInjected.Token(Token = "0x400808F")]
			public const int Jungle = 5;

			// Token: 0x04008C84 RID: 35972
			[global::Cpp2ILInjected.Token(Token = "0x4008090")]
			public const int Snow = 6;

			// Token: 0x04008C85 RID: 35973
			[global::Cpp2ILInjected.Token(Token = "0x4008091")]
			public const int Hallow = 7;

			// Token: 0x04008C86 RID: 35974
			[global::Cpp2ILInjected.Token(Token = "0x4008092")]
			public const int Crimson = 8;

			// Token: 0x04008C87 RID: 35975
			[global::Cpp2ILInjected.Token(Token = "0x4008093")]
			public const int Desert = 9;

			// Token: 0x04008C88 RID: 35976
			[global::Cpp2ILInjected.Token(Token = "0x4008094")]
			public const int Ocean = 10;

			// Token: 0x04008C89 RID: 35977
			[global::Cpp2ILInjected.Token(Token = "0x4008095")]
			public const int GlowingMushroom = 11;

			// Token: 0x04008C8A RID: 35978
			[global::Cpp2ILInjected.Token(Token = "0x4008096")]
			public const int Underworld = 12;

			// Token: 0x04008C8B RID: 35979
			[global::Cpp2ILInjected.Token(Token = "0x4008097")]
			public static readonly int Count;
		}
	}
}
