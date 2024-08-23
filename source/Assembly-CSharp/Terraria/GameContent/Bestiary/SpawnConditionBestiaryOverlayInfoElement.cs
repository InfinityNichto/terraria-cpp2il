using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200063A RID: 1594
	[global::Cpp2ILInjected.Token(Token = "0x200095D")]
	public class SpawnConditionBestiaryOverlayInfoElement : FilterProviderInfoElement, IBestiaryBackgroundOverlayAndColorProvider, IBestiaryPrioritizedElement
	{
		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06003EE1 RID: 16097 RVA: 0x0002D39E File Offset: 0x0002B59E
		// (set) Token: 0x06003EE2 RID: 16098 RVA: 0x0002D3A1 File Offset: 0x0002B5A1
		[global::Cpp2ILInjected.Token(Token = "0x17000829")]
		public float DisplayPriority
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60047F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x81D85C", Offset = "0x81D85C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60047F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x81D864", Offset = "0x81D864", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06003EE3 RID: 16099 RVA: 0x0002D3A4 File Offset: 0x0002B5A4
		// (set) Token: 0x06003EE4 RID: 16100 RVA: 0x0002D3A7 File Offset: 0x0002B5A7
		[global::Cpp2ILInjected.Token(Token = "0x1700082A")]
		public float OrderPriority
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60047F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x81D86C", Offset = "0x81D86C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60047F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x81D874", Offset = "0x81D874", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x0002D3AA File Offset: 0x0002B5AA
		[global::Cpp2ILInjected.Token(Token = "0x60047F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x81243C", Offset = "0x81243C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SpawnConditionBestiaryOverlayInfoElement(string nameLanguageKey, int filterIconFrame, string overlayImagePath = null, Color? overlayColor = null)
		{
			throw null;
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x0002D3AD File Offset: 0x0002B5AD
		[global::Cpp2ILInjected.Token(Token = "0x60047FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D87C", Offset = "0x81D87C", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Asset<Texture2D> GetBackgroundOverlayImage()
		{
			throw null;
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x0002D3B0 File Offset: 0x0002B5B0
		[global::Cpp2ILInjected.Token(Token = "0x60047FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D988", Offset = "0x81D988", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Color? GetBackgroundOverlayColor()
		{
			throw null;
		}

		// Token: 0x04006C7A RID: 27770
		[global::Cpp2ILInjected.Token(Token = "0x4008399")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string _overlayImagePath;

		// Token: 0x04006C7B RID: 27771
		[global::Cpp2ILInjected.Token(Token = "0x400839A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Color? _overlayColor;

		// Token: 0x04006C7C RID: 27772
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400839B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private float <DisplayPriority>k__BackingField;

		// Token: 0x04006C7D RID: 27773
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400839C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private float <OrderPriority>k__BackingField;
	}
}
