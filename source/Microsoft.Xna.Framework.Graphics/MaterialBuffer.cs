using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002AF")]
public class MaterialBuffer
{
	[Cpp2IlInjected.Token(Token = "0x200081E")]
	public class MaterialEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007DE4")]
		public readonly List<MaterialEntry> MaterialList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007DE5")]
		public readonly Texture2D T0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007DE6")]
		public readonly Texture2D T1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007DE7")]
		public readonly Material Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007DE8")]
		private bool useTrimming;

		[Cpp2IlInjected.Token(Token = "0x6004972")]
		[Cpp2IlInjected.Address(RVA = "0x1588CC4", Offset = "0x1588CC4", VA = "0x1588CC4")]
		public MaterialEntry(MaterialPartition materialPartition, List<MaterialEntry> list, Texture2D t0, Texture2D t1, Texture2D t2, Texture2D t3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004973")]
		[Cpp2IlInjected.Address(RVA = "0x15893E4", Offset = "0x15893E4", VA = "0x15893E4")]
		public void SetupTrimming(UnityEngine.Vector2 min, UnityEngine.Vector2 max)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004974")]
		[Cpp2IlInjected.Address(RVA = "0x158955C", Offset = "0x158955C", VA = "0x158955C")]
		public void ClearTrimming()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004975")]
		[Cpp2IlInjected.Address(RVA = "0x15895D4", Offset = "0x15895D4", VA = "0x15895D4")]
		public void Relase()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200081F")]
	public class MaterialPartition : Dictionary<int, List<MaterialEntry>>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4007DE9")]
		public readonly Material BaseMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4007DEA")]
		public readonly bool HasTexture2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x4007DEB")]
		public readonly bool HasTexture3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
		[Cpp2IlInjected.Token(Token = "0x4007DEC")]
		public readonly bool HasTexture4;

		[Cpp2IlInjected.Token(Token = "0x6004976")]
		[Cpp2IlInjected.Address(RVA = "0x1589634", Offset = "0x1589634", VA = "0x1589634")]
		public MaterialPartition(Material baseMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004977")]
		[Cpp2IlInjected.Address(RVA = "0x1589718", Offset = "0x1589718", VA = "0x1589718")]
		public void DestroyMaterials()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004978")]
		[Cpp2IlInjected.Address(RVA = "0x15899A0", Offset = "0x15899A0", VA = "0x15899A0")]
		public MaterialEntry GetMaterial(Texture2D t0, Texture2D t1, Texture2D t2, Texture2D t3)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4001F76")]
	private static int MainTexId;

	[Cpp2IlInjected.Token(Token = "0x4001F77")]
	private static int MainAlphaTexId;

	[Cpp2IlInjected.Token(Token = "0x4001F78")]
	private static int MainPalTexId;

	[Cpp2IlInjected.Token(Token = "0x4001F79")]
	private static int PalScaleSizeId;

	[Cpp2IlInjected.Token(Token = "0x4001F7A")]
	public static int SecTexId;

	[Cpp2IlInjected.Token(Token = "0x4001F7B")]
	private static int ThirdTexId;

	[Cpp2IlInjected.Token(Token = "0x4001F7C")]
	private static int ForthTexId;

	[Cpp2IlInjected.Token(Token = "0x4001F7D")]
	private static int TrimMinId;

	[Cpp2IlInjected.Token(Token = "0x4001F7E")]
	private static int TrimMaxId;

	[Cpp2IlInjected.Token(Token = "0x17000290")]
	private static Dictionary<int, MaterialPartition> _availableMaterials
	{
		[Cpp2IlInjected.Token(Token = "0x60015DC")]
		[Cpp2IlInjected.Address(RVA = "0x13A38EC", Offset = "0x13A38EC", VA = "0x13A38EC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000291")]
	private static List<MaterialEntry> _usedMaterialsDefault
	{
		[Cpp2IlInjected.Token(Token = "0x60015DD")]
		[Cpp2IlInjected.Address(RVA = "0x13A3968", Offset = "0x13A3968", VA = "0x13A3968")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000292")]
	private static List<MaterialEntry> _usedMaterials
	{
		[Cpp2IlInjected.Token(Token = "0x60015DE")]
		[Cpp2IlInjected.Address(RVA = "0x13A39E4", Offset = "0x13A39E4", VA = "0x13A39E4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60015DF")]
		[Cpp2IlInjected.Address(RVA = "0x13A3A60", Offset = "0x13A3A60", VA = "0x13A3A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60015E0")]
	[Cpp2IlInjected.Address(RVA = "0x139D3EC", Offset = "0x139D3EC", VA = "0x139D3EC")]
	public static void SetUsedMaterialList(List<MaterialEntry> list)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015E1")]
	[Cpp2IlInjected.Address(RVA = "0x13A3AE0", Offset = "0x13A3AE0", VA = "0x13A3AE0")]
	public static void DestroyMaterials()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015E2")]
	[Cpp2IlInjected.Address(RVA = "0x139C24C", Offset = "0x139C24C", VA = "0x139C24C")]
	public static Material GetMaterial(EffectPass baseEffect, Texture2D t0, Texture2D t1, Texture2D t2, Texture2D t3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60015E3")]
	[Cpp2IlInjected.Address(RVA = "0x1392E20", Offset = "0x1392E20", VA = "0x1392E20")]
	public static void ClearInstances()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015E4")]
	[Cpp2IlInjected.Address(RVA = "0x13A4148", Offset = "0x13A4148", VA = "0x13A4148")]
	public MaterialBuffer()
	{
	}
}
