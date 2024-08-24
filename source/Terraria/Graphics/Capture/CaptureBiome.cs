using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Capture
{
	// Token: 0x02000505 RID: 1285
	[global::Cpp2ILInjected.Token(Token = "0x2000761")]
	public class CaptureBiome
	{
		// Token: 0x060037A2 RID: 14242 RVA: 0x0002BF0D File Offset: 0x0002A10D
		[global::Cpp2ILInjected.Token(Token = "0x6003E19")]
		[global::Cpp2ILInjected.Address(RVA = "0x14ACE78", Offset = "0x14ACE78", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CaptureBiome(int backgroundIndex, int waterStyle, CaptureBiome.TileColorStyle tileColorStyle = CaptureBiome.TileColorStyle.Normal)
		{
			throw null;
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x0002BF10 File Offset: 0x0002A110
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

		// Token: 0x060037A4 RID: 14244 RVA: 0x0002BF13 File Offset: 0x0002A113
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

		// Token: 0x060037A5 RID: 14245 RVA: 0x0002BF16 File Offset: 0x0002A116
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

		// Token: 0x060037A6 RID: 14246 RVA: 0x0002BF19 File Offset: 0x0002A119
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

		// Token: 0x060037A7 RID: 14247 RVA: 0x0002BF1C File Offset: 0x0002A11C
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

		// Token: 0x040067E7 RID: 26599
		[global::Cpp2ILInjected.Token(Token = "0x4007CCF")]
		public static readonly CaptureBiome DefaultPurity;

		// Token: 0x040067E8 RID: 26600
		[global::Cpp2ILInjected.Token(Token = "0x4007CD0")]
		public static CaptureBiome[] BiomesByWaterStyle;

		// Token: 0x040067E9 RID: 26601
		[global::Cpp2ILInjected.Token(Token = "0x4007CD1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly int WaterStyle;

		// Token: 0x040067EA RID: 26602
		[global::Cpp2ILInjected.Token(Token = "0x4007CD2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public readonly int BackgroundIndex;

		// Token: 0x040067EB RID: 26603
		[global::Cpp2ILInjected.Token(Token = "0x4007CD3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly CaptureBiome.TileColorStyle TileColor;

		// Token: 0x02000969 RID: 2409
		[global::Cpp2ILInjected.Token(Token = "0x2000762")]
		public enum TileColorStyle
		{
			// Token: 0x04008B9F RID: 35743
			[global::Cpp2ILInjected.Token(Token = "0x4007CD5")]
			Normal,
			// Token: 0x04008BA0 RID: 35744
			[global::Cpp2ILInjected.Token(Token = "0x4007CD6")]
			Jungle,
			// Token: 0x04008BA1 RID: 35745
			[global::Cpp2ILInjected.Token(Token = "0x4007CD7")]
			Crimson,
			// Token: 0x04008BA2 RID: 35746
			[global::Cpp2ILInjected.Token(Token = "0x4007CD8")]
			Corrupt,
			// Token: 0x04008BA3 RID: 35747
			[global::Cpp2ILInjected.Token(Token = "0x4007CD9")]
			Mushroom
		}

		// Token: 0x0200096A RID: 2410
		[global::Cpp2ILInjected.Token(Token = "0x2000763")]
		public class Sets
		{
			// Token: 0x06004D51 RID: 19793 RVA: 0x0002FA50 File Offset: 0x0002DC50
			[global::Cpp2ILInjected.Token(Token = "0x6003E1F")]
			[global::Cpp2ILInjected.Address(RVA = "0x14AD7D0", Offset = "0x14AD7D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Sets()
			{
				throw null;
			}

			// Token: 0x02000BA8 RID: 2984
			[global::Cpp2ILInjected.Token(Token = "0x2000764")]
			public class WaterStyles
			{
				// Token: 0x06005417 RID: 21527 RVA: 0x00030D37 File Offset: 0x0002EF37
				[global::Cpp2ILInjected.Token(Token = "0x6003E20")]
				[global::Cpp2ILInjected.Address(RVA = "0x14AD7D8", Offset = "0x14AD7D8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public WaterStyles()
				{
					throw null;
				}

				// Token: 0x04009100 RID: 37120
				[global::Cpp2ILInjected.Token(Token = "0x4007CDA")]
				public const int BloodMoon = 9;
			}
		}

		// Token: 0x0200096B RID: 2411
		[global::Cpp2ILInjected.Token(Token = "0x2000765")]
		public class Styles
		{
			// Token: 0x06004D52 RID: 19794 RVA: 0x0002FA53 File Offset: 0x0002DC53
			[global::Cpp2ILInjected.Token(Token = "0x6003E21")]
			[global::Cpp2ILInjected.Address(RVA = "0x14AD7E0", Offset = "0x14AD7E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Styles()
			{
				throw null;
			}

			// Token: 0x06004D53 RID: 19795 RVA: 0x0002FA56 File Offset: 0x0002DC56
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

			// Token: 0x04008BA4 RID: 35748
			[global::Cpp2ILInjected.Token(Token = "0x4007CDB")]
			public static CaptureBiome Purity;

			// Token: 0x04008BA5 RID: 35749
			[global::Cpp2ILInjected.Token(Token = "0x4007CDC")]
			public static CaptureBiome Purity2;

			// Token: 0x04008BA6 RID: 35750
			[global::Cpp2ILInjected.Token(Token = "0x4007CDD")]
			public static CaptureBiome Purity3;

			// Token: 0x04008BA7 RID: 35751
			[global::Cpp2ILInjected.Token(Token = "0x4007CDE")]
			public static CaptureBiome Purity4;

			// Token: 0x04008BA8 RID: 35752
			[global::Cpp2ILInjected.Token(Token = "0x4007CDF")]
			public static CaptureBiome Corruption;

			// Token: 0x04008BA9 RID: 35753
			[global::Cpp2ILInjected.Token(Token = "0x4007CE0")]
			public static CaptureBiome Jungle;

			// Token: 0x04008BAA RID: 35754
			[global::Cpp2ILInjected.Token(Token = "0x4007CE1")]
			public static CaptureBiome Hallow;

			// Token: 0x04008BAB RID: 35755
			[global::Cpp2ILInjected.Token(Token = "0x4007CE2")]
			public static CaptureBiome Snow;

			// Token: 0x04008BAC RID: 35756
			[global::Cpp2ILInjected.Token(Token = "0x4007CE3")]
			public static CaptureBiome Desert;

			// Token: 0x04008BAD RID: 35757
			[global::Cpp2ILInjected.Token(Token = "0x4007CE4")]
			public static CaptureBiome DirtLayer;

			// Token: 0x04008BAE RID: 35758
			[global::Cpp2ILInjected.Token(Token = "0x4007CE5")]
			public static CaptureBiome RockLayer;

			// Token: 0x04008BAF RID: 35759
			[global::Cpp2ILInjected.Token(Token = "0x4007CE6")]
			public static CaptureBiome BloodMoon;

			// Token: 0x04008BB0 RID: 35760
			[global::Cpp2ILInjected.Token(Token = "0x4007CE7")]
			public static CaptureBiome Crimson;

			// Token: 0x04008BB1 RID: 35761
			[global::Cpp2ILInjected.Token(Token = "0x4007CE8")]
			public static CaptureBiome UndergroundDesert;

			// Token: 0x04008BB2 RID: 35762
			[global::Cpp2ILInjected.Token(Token = "0x4007CE9")]
			public static CaptureBiome Ocean;

			// Token: 0x04008BB3 RID: 35763
			[global::Cpp2ILInjected.Token(Token = "0x4007CEA")]
			public static CaptureBiome Mushroom;
		}

		// Token: 0x0200096C RID: 2412
		[global::Cpp2ILInjected.Token(Token = "0x2000766")]
		private enum BiomeChoiceIndex
		{
			// Token: 0x04008BB5 RID: 35765
			[global::Cpp2ILInjected.Token(Token = "0x4007CEC")]
			AutomatedForPlayer = -1,
			// Token: 0x04008BB6 RID: 35766
			[global::Cpp2ILInjected.Token(Token = "0x4007CED")]
			Purity = 1,
			// Token: 0x04008BB7 RID: 35767
			[global::Cpp2ILInjected.Token(Token = "0x4007CEE")]
			Corruption,
			// Token: 0x04008BB8 RID: 35768
			[global::Cpp2ILInjected.Token(Token = "0x4007CEF")]
			Jungle,
			// Token: 0x04008BB9 RID: 35769
			[global::Cpp2ILInjected.Token(Token = "0x4007CF0")]
			Hallow,
			// Token: 0x04008BBA RID: 35770
			[global::Cpp2ILInjected.Token(Token = "0x4007CF1")]
			Snow,
			// Token: 0x04008BBB RID: 35771
			[global::Cpp2ILInjected.Token(Token = "0x4007CF2")]
			Desert,
			// Token: 0x04008BBC RID: 35772
			[global::Cpp2ILInjected.Token(Token = "0x4007CF3")]
			DirtLayer,
			// Token: 0x04008BBD RID: 35773
			[global::Cpp2ILInjected.Token(Token = "0x4007CF4")]
			RockLayer,
			// Token: 0x04008BBE RID: 35774
			[global::Cpp2ILInjected.Token(Token = "0x4007CF5")]
			Crimson,
			// Token: 0x04008BBF RID: 35775
			[global::Cpp2ILInjected.Token(Token = "0x4007CF6")]
			UndergroundDesert,
			// Token: 0x04008BC0 RID: 35776
			[global::Cpp2ILInjected.Token(Token = "0x4007CF7")]
			Ocean,
			// Token: 0x04008BC1 RID: 35777
			[global::Cpp2ILInjected.Token(Token = "0x4007CF8")]
			Mushroom
		}
	}
}
