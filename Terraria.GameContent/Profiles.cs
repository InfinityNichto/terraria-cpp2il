using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000571")]
public class Profiles
{
	[Cpp2IlInjected.Token(Token = "0x2000990")]
	public class StackedNPCProfile : ITownNPCProfile
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008C5A")]
		internal ITownNPCProfile[] _profiles;

		[Cpp2IlInjected.Token(Token = "0x6004E04")]
		[Cpp2IlInjected.Address(RVA = "0x11A4350", Offset = "0x11A4350", VA = "0x11A4350")]
		public StackedNPCProfile(params ITownNPCProfile[] profilesInOrderOfVariants)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E05")]
		[Cpp2IlInjected.Address(RVA = "0x11A4370", Offset = "0x11A4370", VA = "0x11A4370", Slot = "4")]
		public int RollVariation()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E06")]
		[Cpp2IlInjected.Address(RVA = "0x11A4378", Offset = "0x11A4378", VA = "0x11A4378", Slot = "5")]
		public string GetNameForVariant(NPC npc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E07")]
		[Cpp2IlInjected.Address(RVA = "0x11A44A4", Offset = "0x11A44A4", VA = "0x11A44A4", Slot = "6")]
		public Asset<Texture2D> GetTextureNPCShouldUse(NPC npc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E08")]
		[Cpp2IlInjected.Address(RVA = "0x11A45D0", Offset = "0x11A45D0", VA = "0x11A45D0", Slot = "7")]
		public int GetHeadTextureIndex(NPC npc)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000991")]
	public class LegacyNPCProfile : ITownNPCProfile
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008C5B")]
		private string _rootFilePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008C5C")]
		private int _defaultVariationHeadIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008C5D")]
		internal Asset<Texture2D> _defaultNoAlt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008C5E")]
		internal Asset<Texture2D> _defaultParty;

		[Cpp2IlInjected.Token(Token = "0x6004E09")]
		[Cpp2IlInjected.Address(RVA = "0x11A3FC8", Offset = "0x11A3FC8", VA = "0x11A3FC8")]
		public LegacyNPCProfile(string npcFileTitleFilePath, int defaultHeadIndex, bool includeDefault = true, bool uniquePartyTexture = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E0A")]
		[Cpp2IlInjected.Address(RVA = "0x11A4288", Offset = "0x11A4288", VA = "0x11A4288", Slot = "4")]
		public int RollVariation()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E0B")]
		[Cpp2IlInjected.Address(RVA = "0x11A4290", Offset = "0x11A4290", VA = "0x11A4290", Slot = "5")]
		public string GetNameForVariant(NPC npc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E0C")]
		[Cpp2IlInjected.Address(RVA = "0x11A4310", Offset = "0x11A4310", VA = "0x11A4310", Slot = "6")]
		public Asset<Texture2D> GetTextureNPCShouldUse(NPC npc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E0D")]
		[Cpp2IlInjected.Address(RVA = "0x11A4348", Offset = "0x11A4348", VA = "0x11A4348", Slot = "7")]
		public int GetHeadTextureIndex(NPC npc)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000992")]
	public class TransformableNPCProfile : ITownNPCProfile
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008C5F")]
		private string _rootFilePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008C60")]
		private int _defaultVariationHeadIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008C61")]
		internal Asset<Texture2D> _defaultNoAlt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008C62")]
		internal Asset<Texture2D> _defaultTransformed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008C63")]
		internal Asset<Texture2D> _defaultCredits;

		[Cpp2IlInjected.Token(Token = "0x6004E0E")]
		[Cpp2IlInjected.Address(RVA = "0x11A46FC", Offset = "0x11A46FC", VA = "0x11A46FC")]
		public TransformableNPCProfile(string npcFileTitleFilePath, int defaultHeadIndex, bool includeCredits = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E0F")]
		[Cpp2IlInjected.Address(RVA = "0x11A4A60", Offset = "0x11A4A60", VA = "0x11A4A60", Slot = "4")]
		public int RollVariation()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E10")]
		[Cpp2IlInjected.Address(RVA = "0x11A4A68", Offset = "0x11A4A68", VA = "0x11A4A68", Slot = "5")]
		public string GetNameForVariant(NPC npc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E11")]
		[Cpp2IlInjected.Address(RVA = "0x11A4AE8", Offset = "0x11A4AE8", VA = "0x11A4AE8", Slot = "6")]
		public Asset<Texture2D> GetTextureNPCShouldUse(NPC npc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E12")]
		[Cpp2IlInjected.Address(RVA = "0x11A4B28", Offset = "0x11A4B28", VA = "0x11A4B28", Slot = "7")]
		public int GetHeadTextureIndex(NPC npc)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000993")]
	public class VariantNPCProfile : ITownNPCProfile
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008C64")]
		private string _rootFilePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008C65")]
		private string _npcBaseName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008C66")]
		private int[] _variantHeadIDs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008C67")]
		private string[] _variants;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008C68")]
		internal Dictionary<string, Asset<Texture2D>> _variantTextures;

		[Cpp2IlInjected.Token(Token = "0x6004E13")]
		[Cpp2IlInjected.Address(RVA = "0x11A4B30", Offset = "0x11A4B30", VA = "0x11A4B30")]
		public VariantNPCProfile(string npcFileTitleFilePath, string npcBaseName, int[] variantHeadIds, params string[] variantTextureNames)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E14")]
		[Cpp2IlInjected.Address(RVA = "0x11A4D7C", Offset = "0x11A4D7C", VA = "0x11A4D7C")]
		public VariantNPCProfile SetPartyTextures(params string[] variantTextureNames)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E15")]
		[Cpp2IlInjected.Address(RVA = "0x11A4F94", Offset = "0x11A4F94", VA = "0x11A4F94", Slot = "4")]
		public int RollVariation()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E16")]
		[Cpp2IlInjected.Address(RVA = "0x11A5020", Offset = "0x11A5020", VA = "0x11A5020", Slot = "5")]
		public string GetNameForVariant(NPC npc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E17")]
		[Cpp2IlInjected.Address(RVA = "0x11A50E0", Offset = "0x11A50E0", VA = "0x11A50E0", Slot = "6")]
		public Asset<Texture2D> GetTextureNPCShouldUse(NPC npc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E18")]
		[Cpp2IlInjected.Address(RVA = "0x11A51EC", Offset = "0x11A51EC", VA = "0x11A51EC", Slot = "7")]
		public int GetHeadTextureIndex(NPC npc)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003AD8")]
	[Cpp2IlInjected.Address(RVA = "0x11A3FC0", Offset = "0x11A3FC0", VA = "0x11A3FC0")]
	public Profiles()
	{
	}
}
