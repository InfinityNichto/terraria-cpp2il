using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Capture
{
	[global::Cpp2ILInjected.Token(Token = "0x2000761")]
	public class CaptureBiome
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003E19")]
		[global::Cpp2ILInjected.Address(RVA = "0x14ACE78", Offset = "0x14ACE78", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CaptureBiome(int backgroundIndex, int waterStyle, CaptureBiome.TileColorStyle tileColorStyle = CaptureBiome.TileColorStyle.Normal)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003E1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x14ACEB4", Offset = "0x14ACEB4", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaptureInterface), Member = "UpdateButtons", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaptureInterface), Member = "QuickScreenshot", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CaptureBiome), Member = "GetBiomeByLocation", ReturnType = typeof(CaptureBiome))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CaptureBiome), Member = "GetBiomeByWater", ReturnType = typeof(CaptureBiome))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static CaptureBiome GetCaptureBiome(int biomeChoice)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003E1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x14AD444", Offset = "0x14AD444", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaptureBiome), Member = "GetCaptureBiome", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CaptureBiome))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "CalculateWaterStyle", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static CaptureBiome GetBiomeByWater()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003E1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x14AD234", Offset = "0x14AD234", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaptureBiome), Member = "GetCaptureBiome", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(CaptureBiome))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "GetPreferredBGStyleForPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static CaptureBiome GetBiomeByLocation()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003E1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x14AD0D8", Offset = "0x14AD0D8", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static CaptureBiome GetPurityForPlayer()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003E1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x14AD520", Offset = "0x14AD520", Length = "0x2B0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		static CaptureBiome()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007CCF")]
		public static readonly CaptureBiome DefaultPurity;

		[global::Cpp2ILInjected.Token(Token = "0x4007CD0")]
		public static CaptureBiome[] BiomesByWaterStyle;

		[global::Cpp2ILInjected.Token(Token = "0x4007CD1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly int WaterStyle;

		[global::Cpp2ILInjected.Token(Token = "0x4007CD2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public readonly int BackgroundIndex;

		[global::Cpp2ILInjected.Token(Token = "0x4007CD3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly CaptureBiome.TileColorStyle TileColor;

		[global::Cpp2ILInjected.Token(Token = "0x2000762")]
		public enum TileColorStyle
		{
			[global::Cpp2ILInjected.Token(Token = "0x4007CD5")]
			Normal,
			[global::Cpp2ILInjected.Token(Token = "0x4007CD6")]
			Jungle,
			[global::Cpp2ILInjected.Token(Token = "0x4007CD7")]
			Crimson,
			[global::Cpp2ILInjected.Token(Token = "0x4007CD8")]
			Corrupt,
			[global::Cpp2ILInjected.Token(Token = "0x4007CD9")]
			Mushroom
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000763")]
		public class Sets
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003E1F")]
			[global::Cpp2ILInjected.Address(RVA = "0x14AD7D0", Offset = "0x14AD7D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Sets()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x2000764")]
			public class WaterStyles
			{
				[global::Cpp2ILInjected.Token(Token = "0x6003E20")]
				[global::Cpp2ILInjected.Address(RVA = "0x14AD7D8", Offset = "0x14AD7D8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public WaterStyles()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4007CDA")]
				public const int BloodMoon = 9;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000765")]
		public class Styles
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003E21")]
			[global::Cpp2ILInjected.Address(RVA = "0x14AD7E0", Offset = "0x14AD7E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Styles()
			{
				throw null;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003E22")]
			[global::Cpp2ILInjected.Address(RVA = "0x14AD7E8", Offset = "0x14AD7E8", Length = "0x354")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
			static Styles()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4007CDB")]
			public static CaptureBiome Purity;

			[global::Cpp2ILInjected.Token(Token = "0x4007CDC")]
			public static CaptureBiome Purity2;

			[global::Cpp2ILInjected.Token(Token = "0x4007CDD")]
			public static CaptureBiome Purity3;

			[global::Cpp2ILInjected.Token(Token = "0x4007CDE")]
			public static CaptureBiome Purity4;

			[global::Cpp2ILInjected.Token(Token = "0x4007CDF")]
			public static CaptureBiome Corruption;

			[global::Cpp2ILInjected.Token(Token = "0x4007CE0")]
			public static CaptureBiome Jungle;

			[global::Cpp2ILInjected.Token(Token = "0x4007CE1")]
			public static CaptureBiome Hallow;

			[global::Cpp2ILInjected.Token(Token = "0x4007CE2")]
			public static CaptureBiome Snow;

			[global::Cpp2ILInjected.Token(Token = "0x4007CE3")]
			public static CaptureBiome Desert;

			[global::Cpp2ILInjected.Token(Token = "0x4007CE4")]
			public static CaptureBiome DirtLayer;

			[global::Cpp2ILInjected.Token(Token = "0x4007CE5")]
			public static CaptureBiome RockLayer;

			[global::Cpp2ILInjected.Token(Token = "0x4007CE6")]
			public static CaptureBiome BloodMoon;

			[global::Cpp2ILInjected.Token(Token = "0x4007CE7")]
			public static CaptureBiome Crimson;

			[global::Cpp2ILInjected.Token(Token = "0x4007CE8")]
			public static CaptureBiome UndergroundDesert;

			[global::Cpp2ILInjected.Token(Token = "0x4007CE9")]
			public static CaptureBiome Ocean;

			[global::Cpp2ILInjected.Token(Token = "0x4007CEA")]
			public static CaptureBiome Mushroom;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000766")]
		private enum BiomeChoiceIndex
		{
			[global::Cpp2ILInjected.Token(Token = "0x4007CEC")]
			AutomatedForPlayer = -1,
			[global::Cpp2ILInjected.Token(Token = "0x4007CED")]
			Purity = 1,
			[global::Cpp2ILInjected.Token(Token = "0x4007CEE")]
			Corruption,
			[global::Cpp2ILInjected.Token(Token = "0x4007CEF")]
			Jungle,
			[global::Cpp2ILInjected.Token(Token = "0x4007CF0")]
			Hallow,
			[global::Cpp2ILInjected.Token(Token = "0x4007CF1")]
			Snow,
			[global::Cpp2ILInjected.Token(Token = "0x4007CF2")]
			Desert,
			[global::Cpp2ILInjected.Token(Token = "0x4007CF3")]
			DirtLayer,
			[global::Cpp2ILInjected.Token(Token = "0x4007CF4")]
			RockLayer,
			[global::Cpp2ILInjected.Token(Token = "0x4007CF5")]
			Crimson,
			[global::Cpp2ILInjected.Token(Token = "0x4007CF6")]
			UndergroundDesert,
			[global::Cpp2ILInjected.Token(Token = "0x4007CF7")]
			Ocean,
			[global::Cpp2ILInjected.Token(Token = "0x4007CF8")]
			Mushroom
		}
	}
}
