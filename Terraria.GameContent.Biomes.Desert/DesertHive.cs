using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;

namespace Terraria.GameContent.Biomes.Desert;

[Cpp2IlInjected.Token(Token = "0x2000605")]
public static class DesertHive
{
	[Cpp2IlInjected.Token(Token = "0x2000A00")]
	private struct Block
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008D0F")]
		public Vector2D Position;

		[Cpp2IlInjected.Token(Token = "0x6004FA5")]
		[Cpp2IlInjected.Address(RVA = "0x39F214", Offset = "0x39F214", VA = "0x39F214")]
		public Block(double x, double y)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A01")]
	private struct Cluster
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008D10")]
		public int Offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008D11")]
		public int Count;
	}

	[Cpp2IlInjected.Token(Token = "0x2000A02")]
	private class ClusterGroup
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008D12")]
		public readonly int Width;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008D13")]
		public readonly int Height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008D14")]
		public Vector2D[] Points;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008D15")]
		public Cluster[] Clusters;

		[Cpp2IlInjected.Token(Token = "0x6004FA6")]
		[Cpp2IlInjected.Address(RVA = "0x145B2F4", Offset = "0x145B2F4", VA = "0x145B2F4")]
		private ClusterGroup(int width, int height)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004FA7")]
		[Cpp2IlInjected.Address(RVA = "0x1459600", Offset = "0x1459600", VA = "0x1459600")]
		public static ClusterGroup FromDescription(DesertDescription description)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FA8")]
		[Cpp2IlInjected.Address(RVA = "0x145C278", Offset = "0x145C278", VA = "0x145C278")]
		private static void SearchForCluster(bool[,] blockMap, List<Point> pointCluster, int x, int y, int level = 2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004FA9")]
		[Cpp2IlInjected.Address(RVA = "0x145C44C", Offset = "0x145C44C", VA = "0x145C44C")]
		private static void AttemptClaim(int x, int y, int[,] clusterIndexMap, List<List<Point>> pointClusters, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004FAA")]
		[Cpp2IlInjected.Address(RVA = "0x145B324", Offset = "0x145B324", VA = "0x145B324")]
		private void Generate()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A03")]
	[Flags]
	private enum PostPlacementEffect : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4008D17")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4008D18")]
		Smooth = 1
	}

	[Cpp2IlInjected.Token(Token = "0x6003E0C")]
	[Cpp2IlInjected.Address(RVA = "0x14595D8", Offset = "0x14595D8", VA = "0x14595D8")]
	public static void Place(DesertDescription description)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E0D")]
	[Cpp2IlInjected.Address(RVA = "0x145967C", Offset = "0x145967C", VA = "0x145967C")]
	private static void PlaceClusters(DesertDescription description, ClusterGroup clusters)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E0E")]
	[Cpp2IlInjected.Address(RVA = "0x145A200", Offset = "0x145A200", VA = "0x145A200")]
	private static void PlaceClustersArea(DesertDescription description, ClusterGroup clusters, Rectangle area, PostPlacementEffect[,] postEffectMap, Point postEffectMapOffset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E0F")]
	[Cpp2IlInjected.Address(RVA = "0x1459940", Offset = "0x1459940", VA = "0x1459940")]
	private static void AddTileVariance(DesertDescription description)
	{
	}
}
