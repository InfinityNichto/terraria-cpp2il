using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.States;
using Terraria.Localization;

namespace Terraria.UI
{
	// Token: 0x020004CE RID: 1230
	[global::Cpp2ILInjected.Token(Token = "0x200071B")]
	public struct StyleDimension
	{
		// Token: 0x060035ED RID: 13805 RVA: 0x0002BA12 File Offset: 0x00029C12
		[global::Cpp2ILInjected.Token(Token = "0x6003C2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x148E180", Offset = "0x148E180", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 228)]
		public StyleDimension(float pixels, float precent)
		{
			throw null;
		}

		// Token: 0x060035EE RID: 13806 RVA: 0x0002BA15 File Offset: 0x00029C15
		[global::Cpp2ILInjected.Token(Token = "0x6003C2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x148E188", Offset = "0x148E188", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 116)]
		public void Set(float pixels, float precent)
		{
			throw null;
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x0002BA18 File Offset: 0x00029C18
		[global::Cpp2ILInjected.Token(Token = "0x6003C2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x148E190", Offset = "0x148E190", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float GetValue(float containerSize)
		{
			throw null;
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x0002BA1B File Offset: 0x00029C1B
		[global::Cpp2ILInjected.Token(Token = "0x6003C30")]
		[global::Cpp2ILInjected.Address(RVA = "0x148E1A0", Offset = "0x148E1A0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "MakeExitButton", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmotesGroupListItem), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupOptionButton<>), Member = ".ctor", MemberParameters = new object[]
		{
			"T",
			typeof(LocalizedText),
			typeof(LocalizedText),
			typeof(Color),
			typeof(string),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupOptionButton<>), Member = "SetText", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICharacterNameButton), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(LocalizedText),
			typeof(LocalizedText)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICharacterNameButton), Member = "SetContents", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIDifficultyButton), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(LocalizedText),
			typeof(LocalizedText),
			typeof(byte),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIHairStyleButton), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIIconTextButton), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(Color),
			typeof(string),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIIconTextButton), Member = "SetText", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		public static StyleDimension FromPixels(float pixels)
		{
			throw null;
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x0002BA1E File Offset: 0x00029C1E
		[global::Cpp2ILInjected.Token(Token = "0x6003C31")]
		[global::Cpp2ILInjected.Address(RVA = "0x148E1A8", Offset = "0x148E1A8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static StyleDimension FromPercent(float percent)
		{
			throw null;
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x0002BA21 File Offset: 0x00029C21
		[global::Cpp2ILInjected.Token(Token = "0x6003C32")]
		[global::Cpp2ILInjected.Address(RVA = "0x148E1B4", Offset = "0x148E1B4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlavorTextBestiaryInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnlockProgressDisplayBestiaryInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCStatsReportInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "MakeExitButton", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmotesGroupListItem), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(int),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupOptionButton<>), Member = ".ctor", MemberParameters = new object[]
		{
			"T",
			typeof(LocalizedText),
			typeof(LocalizedText),
			typeof(Color),
			typeof(string),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupOptionButton<>), Member = "SetText", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryInfoPage), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryInfoPage), Member = "AddInfoToList", MemberParameters = new object[]
		{
			typeof(BestiaryEntry),
			typeof(ExtraBestiaryInfoPageInformation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIDifficultyButton), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(LocalizedText),
			typeof(LocalizedText),
			typeof(byte),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIIconTextButton), Member = "SetText", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		public static StyleDimension FromPixelsAndPercent(float pixels, float percent)
		{
			throw null;
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x0002BA24 File Offset: 0x00029C24
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003C33")]
		[global::Cpp2ILInjected.Address(RVA = "0x148E1B8", Offset = "0x148E1B8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static StyleDimension()
		{
			throw null;
		}

		// Token: 0x040066B0 RID: 26288
		[global::Cpp2ILInjected.Token(Token = "0x4007B7C")]
		public static StyleDimension Fill;

		// Token: 0x040066B1 RID: 26289
		[global::Cpp2ILInjected.Token(Token = "0x4007B7D")]
		public static StyleDimension Empty;

		// Token: 0x040066B2 RID: 26290
		[global::Cpp2ILInjected.Token(Token = "0x4007B7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float Pixels;

		// Token: 0x040066B3 RID: 26291
		[global::Cpp2ILInjected.Token(Token = "0x4007B7F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float Precent;
	}
}
