using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using Terraria.GameContent.Biomes.Desert;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes;

[Cpp2IlInjected.Token(Token = "0x20005F7")]
public class DunesBiome : MicroBiome
{
	[Cpp2IlInjected.Token(Token = "0x20009F7")]
	private class DunesDescription
	{
		[Cpp2IlInjected.Token(Token = "0x170008CA")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6004F82")]
			[Cpp2IlInjected.Address(RVA = "0x145F6B0", Offset = "0x145F6B0", VA = "0x145F6B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6004F83")]
			[Cpp2IlInjected.Address(RVA = "0x145F6B8", Offset = "0x145F6B8", VA = "0x145F6B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008CB")]
		public SurfaceMap Surface
		{
			[Cpp2IlInjected.Token(Token = "0x6004F84")]
			[Cpp2IlInjected.Address(RVA = "0x145F6C0", Offset = "0x145F6C0", VA = "0x145F6C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6004F85")]
			[Cpp2IlInjected.Address(RVA = "0x145F6C8", Offset = "0x145F6C8", VA = "0x145F6C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008CC")]
		public Rectangle Area
		{
			[Cpp2IlInjected.Token(Token = "0x6004F86")]
			[Cpp2IlInjected.Address(RVA = "0x145F6D0", Offset = "0x145F6D0", VA = "0x145F6D0")]
			[CompilerGenerated]
			get
			{
				return default(Rectangle);
			}
			[Cpp2IlInjected.Token(Token = "0x6004F87")]
			[Cpp2IlInjected.Address(RVA = "0x145F6E0", Offset = "0x145F6E0", VA = "0x145F6E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170008CD")]
		public WindDirection WindDirection
		{
			[Cpp2IlInjected.Token(Token = "0x6004F88")]
			[Cpp2IlInjected.Address(RVA = "0x145F6F0", Offset = "0x145F6F0", VA = "0x145F6F0")]
			[CompilerGenerated]
			get
			{
				return default(WindDirection);
			}
			[Cpp2IlInjected.Token(Token = "0x6004F89")]
			[Cpp2IlInjected.Address(RVA = "0x145F6F8", Offset = "0x145F6F8", VA = "0x145F6F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004F8A")]
		[Cpp2IlInjected.Address(RVA = "0x145F700", Offset = "0x145F700", VA = "0x145F700")]
		private DunesDescription()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004F8B")]
		[Cpp2IlInjected.Address(RVA = "0x145E90C", Offset = "0x145E90C", VA = "0x145E90C")]
		public static DunesDescription CreateFromPlacement(Point origin, int width, int height)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20009F8")]
	private enum WindDirection
	{
		[Cpp2IlInjected.Token(Token = "0x4008CFE")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x4008CFF")]
		Right
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006BF8")]
	[JsonProperty]
	private WorldGenRange _singleDunesWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006BF9")]
	[JsonProperty]
	private double _heightScale;

	[Cpp2IlInjected.Token(Token = "0x17000744")]
	public int MaximumWidth
	{
		[Cpp2IlInjected.Token(Token = "0x6003DBB")]
		[Cpp2IlInjected.Address(RVA = "0x145E774", Offset = "0x145E774", VA = "0x145E774")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003DBC")]
	[Cpp2IlInjected.Address(RVA = "0x145E790", Offset = "0x145E790", VA = "0x145E790", Slot = "4")]
	public override bool Place(Point origin, StructureMap structures)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DBD")]
	[Cpp2IlInjected.Address(RVA = "0x145EA40", Offset = "0x145EA40", VA = "0x145EA40")]
	private void PlaceSingle(DunesDescription description, StructureMap structures)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DBE")]
	[Cpp2IlInjected.Address(RVA = "0x145ECD0", Offset = "0x145ECD0", VA = "0x145ECD0")]
	private static void PlaceHill(int startX, int endX, double scale, DunesDescription description)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DBF")]
	[Cpp2IlInjected.Address(RVA = "0x145EF44", Offset = "0x145EF44", VA = "0x145EF44")]
	private static void PlaceCurvedLine(Point startPoint, Point endPoint, Point anchorOffset, DunesDescription description)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DC0")]
	[Cpp2IlInjected.Address(RVA = "0x145F610", Offset = "0x145F610", VA = "0x145F610")]
	public DunesBiome()
	{
	}
}
