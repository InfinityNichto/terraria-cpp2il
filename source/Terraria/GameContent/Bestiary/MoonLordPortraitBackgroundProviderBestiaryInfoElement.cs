using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000638 RID: 1592
	[global::Cpp2ILInjected.Token(Token = "0x200095B")]
	public class MoonLordPortraitBackgroundProviderBestiaryInfoElement : IBestiaryInfoElement, IBestiaryBackgroundImagePathAndColorProvider
	{
		// Token: 0x06003ED8 RID: 16088 RVA: 0x0002D383 File Offset: 0x0002B583
		[global::Cpp2ILInjected.Token(Token = "0x60047EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D590", Offset = "0x81D590", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MoonLordPortraitBackgroundProviderBestiaryInfoElement()
		{
			throw null;
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x0002D386 File Offset: 0x0002B586
		[global::Cpp2ILInjected.Token(Token = "0x60047ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D598", Offset = "0x81D598", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public Asset<Texture2D> GetBackgroundImage()
		{
			throw null;
		}

		// Token: 0x06003EDA RID: 16090 RVA: 0x0002D389 File Offset: 0x0002B589
		[global::Cpp2ILInjected.Token(Token = "0x60047EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D69C", Offset = "0x81D69C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color?), Member = ".ctor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Color? GetBackgroundColor()
		{
			throw null;
		}

		// Token: 0x06003EDB RID: 16091 RVA: 0x0002D38C File Offset: 0x0002B58C
		[global::Cpp2ILInjected.Token(Token = "0x60047EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D728", Offset = "0x81D728", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}
	}
}
