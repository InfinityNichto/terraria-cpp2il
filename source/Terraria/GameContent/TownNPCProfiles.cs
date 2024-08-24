using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Animations;
using Terraria.GameContent.Bestiary;

namespace Terraria.GameContent
{
	// Token: 0x0200056C RID: 1388
	[global::Cpp2ILInjected.Token(Token = "0x20007FA")]
	public class TownNPCProfiles
	{
		// Token: 0x06003A92 RID: 14994 RVA: 0x0002C759 File Offset: 0x0002A959
		[global::Cpp2ILInjected.Token(Token = "0x600418A")]
		[global::Cpp2ILInjected.Address(RVA = "0x77F9FC", Offset = "0x77F9FC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "CanInteract", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Item),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "RefreshNPCEntries", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "NPCDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMap), Member = "DrawMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "DrawControls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCCheckAlt", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GiveTownUniqueDataToNPCsThatNeedIt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "RerollVariation", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TownNPCProfiles), Member = "GetHeadIndexSafe", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnlockableNPCEntryIcon), Member = "Draw", MemberParameters = new object[]
		{
			typeof(BestiaryUICollectionInfo),
			typeof(SpriteBatch),
			typeof(EntryIconDrawSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Segments.NPCSegment), Member = "Draw", MemberParameters = new object[] { typeof(ref GameAnimationSegment) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool GetProfile(int npcId, out ITownNPCProfile profile)
		{
			throw null;
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x0002C75C File Offset: 0x0002A95C
		[global::Cpp2ILInjected.Token(Token = "0x600418B")]
		[global::Cpp2ILInjected.Address(RVA = "0x77FA5C", Offset = "0x77FA5C", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TownNPCProfiles), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Profiles.LegacyNPCProfile), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static ITownNPCProfile LegacyWithSimpleShimmer(string subPath, int headIdNormal, int headIdShimmered, bool uniquePartyTexture = true, bool uniquePartyTextureShimmered = true)
		{
			throw null;
		}

		// Token: 0x06003A94 RID: 14996 RVA: 0x0002C75F File Offset: 0x0002A95F
		[global::Cpp2ILInjected.Token(Token = "0x600418C")]
		[global::Cpp2ILInjected.Address(RVA = "0x77FE90", Offset = "0x77FE90", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TownNPCProfiles), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Profiles.TransformableNPCProfile), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static ITownNPCProfile TransformableWithSimpleShimmer(string subPath, int headIdNormal, int headIdShimmered, bool uniqueCreditTexture = true, bool uniqueCreditTextureShimmered = true)
		{
			throw null;
		}

		// Token: 0x06003A95 RID: 14997 RVA: 0x0002C762 File Offset: 0x0002A962
		[global::Cpp2ILInjected.Token(Token = "0x600418D")]
		[global::Cpp2ILInjected.Address(RVA = "0x780308", Offset = "0x780308", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCHousesInWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_38_MouseCarriedObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TownNPCProfiles), Member = "GetProfile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref ITownNPCProfile)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "TypeToDefaultHeadIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static int GetHeadIndexSafe(NPC npc)
		{
			throw null;
		}

		// Token: 0x06003A96 RID: 14998 RVA: 0x0002C765 File Offset: 0x0002A965
		[global::Cpp2ILInjected.Token(Token = "0x600418E")]
		[global::Cpp2ILInjected.Address(RVA = "0x780430", Offset = "0x780430", Length = "0xFA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TownNPCProfiles), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TownNPCProfiles), Member = "LegacyWithSimpleShimmer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(ITownNPCProfile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TownNPCProfiles), Member = "TransformableWithSimpleShimmer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(ITownNPCProfile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Profiles.VariantNPCProfile), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int[]),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Profiles.LegacyNPCProfile), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 102)]
		public TownNPCProfiles()
		{
			throw null;
		}

		// Token: 0x06003A97 RID: 14999 RVA: 0x0002C768 File Offset: 0x0002A968
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600418F")]
		[global::Cpp2ILInjected.Address(RVA = "0x7815F4", Offset = "0x7815F4", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TownNPCProfiles), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		static TownNPCProfiles()
		{
			throw null;
		}

		// Token: 0x04006AB5 RID: 27317
		[global::Cpp2ILInjected.Token(Token = "0x400806D")]
		private const string DefaultNPCFileFolderPath = "Images/TownNPCs/";

		// Token: 0x04006AB6 RID: 27318
		[global::Cpp2ILInjected.Token(Token = "0x400806E")]
		private const string ShimmeredNPCFileFolderPath = "Images/TownNPCs/Shimmered/";

		// Token: 0x04006AB7 RID: 27319
		[global::Cpp2ILInjected.Token(Token = "0x400806F")]
		private static readonly int[] CatHeadIDs;

		// Token: 0x04006AB8 RID: 27320
		[global::Cpp2ILInjected.Token(Token = "0x4008070")]
		private static readonly int[] DogHeadIDs;

		// Token: 0x04006AB9 RID: 27321
		[global::Cpp2ILInjected.Token(Token = "0x4008071")]
		private static readonly int[] BunnyHeadIDs;

		// Token: 0x04006ABA RID: 27322
		[global::Cpp2ILInjected.Token(Token = "0x4008072")]
		private static readonly int[] SlimeHeadIDs;

		// Token: 0x04006ABB RID: 27323
		[global::Cpp2ILInjected.Token(Token = "0x4008073")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Dictionary<int, ITownNPCProfile> _townNPCProfiles;

		// Token: 0x04006ABC RID: 27324
		[global::Cpp2ILInjected.Token(Token = "0x4008074")]
		public static TownNPCProfiles Instance;
	}
}
