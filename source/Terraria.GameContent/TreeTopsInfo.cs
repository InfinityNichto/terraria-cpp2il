using System.IO;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.Utilities;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000573")]
public class TreeTopsInfo
{
	[Cpp2IlInjected.Token(Token = "0x2000996")]
	public class AreaId
	{
		[Cpp2IlInjected.Token(Token = "0x4008C6B")]
		public const int Forest1 = 0;

		[Cpp2IlInjected.Token(Token = "0x4008C6C")]
		public const int Forest2 = 1;

		[Cpp2IlInjected.Token(Token = "0x4008C6D")]
		public const int Forest3 = 2;

		[Cpp2IlInjected.Token(Token = "0x4008C6E")]
		public const int Forest4 = 3;

		[Cpp2IlInjected.Token(Token = "0x4008C6F")]
		public const int Corruption = 4;

		[Cpp2IlInjected.Token(Token = "0x4008C70")]
		public const int Jungle = 5;

		[Cpp2IlInjected.Token(Token = "0x4008C71")]
		public const int Snow = 6;

		[Cpp2IlInjected.Token(Token = "0x4008C72")]
		public const int Hallow = 7;

		[Cpp2IlInjected.Token(Token = "0x4008C73")]
		public const int Crimson = 8;

		[Cpp2IlInjected.Token(Token = "0x4008C74")]
		public const int Desert = 9;

		[Cpp2IlInjected.Token(Token = "0x4008C75")]
		public const int Ocean = 10;

		[Cpp2IlInjected.Token(Token = "0x4008C76")]
		public const int GlowingMushroom = 11;

		[Cpp2IlInjected.Token(Token = "0x4008C77")]
		public const int Underworld = 12;

		[Cpp2IlInjected.Token(Token = "0x4008C78")]
		public static readonly int Count;

		[Cpp2IlInjected.Token(Token = "0x6004E1D")]
		[Cpp2IlInjected.Address(RVA = "0x117C19C", Offset = "0x117C19C", VA = "0x117C19C")]
		public AreaId()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006AC1")]
	private int[] _variations;

	[Cpp2IlInjected.Token(Token = "0x6003AEB")]
	[Cpp2IlInjected.Address(RVA = "0x117B708", Offset = "0x117B708", VA = "0x117B708")]
	public void Save(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AEC")]
	[Cpp2IlInjected.Address(RVA = "0x117B77C", Offset = "0x117B77C", VA = "0x117B77C")]
	public void Load(BinaryReader reader, int loadVersion)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AED")]
	[Cpp2IlInjected.Address(RVA = "0x117BB28", Offset = "0x117BB28", VA = "0x117BB28")]
	public void SyncSend(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AEE")]
	[Cpp2IlInjected.Address(RVA = "0x117BB80", Offset = "0x117BB80", VA = "0x117BB80")]
	public void SyncReceive(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AEF")]
	[Cpp2IlInjected.Address(RVA = "0x117BBDC", Offset = "0x117BBDC", VA = "0x117BBDC")]
	public int GetTreeStyle(int areaId)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003AF0")]
	[Cpp2IlInjected.Address(RVA = "0x117BBEC", Offset = "0x117BBEC", VA = "0x117BBEC")]
	public void RandomizeTreeStyleBasedOnWorldPosition(UnifiedRandom rand, Vector2 worldPosition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AF1")]
	[Cpp2IlInjected.Address(RVA = "0x117BEEC", Offset = "0x117BEEC", VA = "0x117BEEC")]
	public void RandomizeTreeStyle(UnifiedRandom rand, int areaId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AF2")]
	[Cpp2IlInjected.Address(RVA = "0x117BBD8", Offset = "0x117BBD8", VA = "0x117BBD8")]
	private void DoTreeFX(int areaID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AF3")]
	[Cpp2IlInjected.Address(RVA = "0x117C0F8", Offset = "0x117C0F8", VA = "0x117C0F8")]
	public void CopyExistingWorldInfoForWorldGeneration()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AF4")]
	[Cpp2IlInjected.Address(RVA = "0x117B978", Offset = "0x117B978", VA = "0x117B978")]
	public void CopyExistingWorldInfo()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AF5")]
	[Cpp2IlInjected.Address(RVA = "0x117C0FC", Offset = "0x117C0FC", VA = "0x117C0FC")]
	public TreeTopsInfo()
	{
	}
}
