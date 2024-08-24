using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200063B RID: 1595
	[global::Cpp2ILInjected.Token(Token = "0x200095E")]
	public class SpawnConditionDecorativeOverlayInfoElement : IBestiaryInfoElement, IBestiaryBackgroundOverlayAndColorProvider
	{
		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06003EE8 RID: 16104 RVA: 0x0002D3B3 File Offset: 0x0002B5B3
		// (set) Token: 0x06003EE9 RID: 16105 RVA: 0x0002D3B6 File Offset: 0x0002B5B6
		[global::Cpp2ILInjected.Token(Token = "0x1700082B")]
		public float DisplayPriority
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60047FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x81D998", Offset = "0x81D998", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60047FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x81D9A0", Offset = "0x81D9A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06003EEA RID: 16106 RVA: 0x0002D3B9 File Offset: 0x0002B5B9
		[global::Cpp2ILInjected.Token(Token = "0x60047FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x813DC4", Offset = "0x813DC4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SpawnConditionDecorativeOverlayInfoElement(string overlayImagePath = null, Color? overlayColor = null)
		{
			throw null;
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x0002D3BC File Offset: 0x0002B5BC
		[global::Cpp2ILInjected.Token(Token = "0x60047FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D9A8", Offset = "0x81D9A8", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Asset<Texture2D> GetBackgroundOverlayImage()
		{
			throw null;
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x0002D3BF File Offset: 0x0002B5BF
		[global::Cpp2ILInjected.Token(Token = "0x6004800")]
		[global::Cpp2ILInjected.Address(RVA = "0x81DAB4", Offset = "0x81DAB4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Color? GetBackgroundOverlayColor()
		{
			throw null;
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x0002D3C2 File Offset: 0x0002B5C2
		[global::Cpp2ILInjected.Token(Token = "0x6004801")]
		[global::Cpp2ILInjected.Address(RVA = "0x81DAC4", Offset = "0x81DAC4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x04006C7E RID: 27774
		[global::Cpp2ILInjected.Token(Token = "0x400839D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _overlayImagePath;

		// Token: 0x04006C7F RID: 27775
		[global::Cpp2ILInjected.Token(Token = "0x400839E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Color? _overlayColor;

		// Token: 0x04006C80 RID: 27776
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400839F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private float <DisplayPriority>k__BackingField;
	}
}
