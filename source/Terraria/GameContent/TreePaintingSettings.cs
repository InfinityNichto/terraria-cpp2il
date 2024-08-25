using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007D0")]
	public class TreePaintingSettings
	{
		[global::Cpp2ILInjected.Token(Token = "0x60040B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x772E94", Offset = "0x772E94", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TreePaintingSettings()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007E60")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public TreePaintingSettings.TreePaintingSettingsId Id;

		[global::Cpp2ILInjected.Token(Token = "0x4007E61")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public float SpecialGroupMinimalHueValue;

		[global::Cpp2ILInjected.Token(Token = "0x4007E62")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public float SpecialGroupMaximumHueValue;

		[global::Cpp2ILInjected.Token(Token = "0x4007E63")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public float SpecialGroupMinimumSaturationValue;

		[global::Cpp2ILInjected.Token(Token = "0x4007E64")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public float SpecialGroupMaximumSaturationValue;

		[global::Cpp2ILInjected.Token(Token = "0x4007E65")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public float HueTestOffset;

		[global::Cpp2ILInjected.Token(Token = "0x4007E66")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public bool UseSpecialGroups;

		[global::Cpp2ILInjected.Token(Token = "0x4007E67")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		public bool UseWallShaderHacks;

		[global::Cpp2ILInjected.Token(Token = "0x4007E68")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
		public bool InvertSpecialGroupResult;

		[global::Cpp2ILInjected.Token(Token = "0x20007D1")]
		public enum TreePaintingSettingsId
		{
			[global::Cpp2ILInjected.Token(Token = "0x4007E6A")]
			None,
			[global::Cpp2ILInjected.Token(Token = "0x4007E6B")]
			DefaultDirt,
			[global::Cpp2ILInjected.Token(Token = "0x4007E6C")]
			CullMud,
			[global::Cpp2ILInjected.Token(Token = "0x4007E6D")]
			WoodPurity,
			[global::Cpp2ILInjected.Token(Token = "0x4007E6E")]
			WoodCorruption,
			[global::Cpp2ILInjected.Token(Token = "0x4007E6F")]
			WoodJungle,
			[global::Cpp2ILInjected.Token(Token = "0x4007E70")]
			WoodHallow,
			[global::Cpp2ILInjected.Token(Token = "0x4007E71")]
			WoodSnow,
			[global::Cpp2ILInjected.Token(Token = "0x4007E72")]
			WoodCrimson,
			[global::Cpp2ILInjected.Token(Token = "0x4007E73")]
			WoodJungleUnderground,
			[global::Cpp2ILInjected.Token(Token = "0x4007E74")]
			WoodGlowingMushroom,
			[global::Cpp2ILInjected.Token(Token = "0x4007E75")]
			VanityCherry,
			[global::Cpp2ILInjected.Token(Token = "0x4007E76")]
			VanityYellowWillow,
			[global::Cpp2ILInjected.Token(Token = "0x4007E77")]
			GemTree,
			[global::Cpp2ILInjected.Token(Token = "0x4007E78")]
			PalmTreePurity,
			[global::Cpp2ILInjected.Token(Token = "0x4007E79")]
			PalmTreeCorruption,
			[global::Cpp2ILInjected.Token(Token = "0x4007E7A")]
			PalmTreeCrimson,
			[global::Cpp2ILInjected.Token(Token = "0x4007E7B")]
			PalmTreeHallow,
			[global::Cpp2ILInjected.Token(Token = "0x4007E7C")]
			Count
		}
	}
}
