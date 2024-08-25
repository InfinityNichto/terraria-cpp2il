using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x200095E")]
	public class SpawnConditionDecorativeOverlayInfoElement : IBestiaryInfoElement, IBestiaryBackgroundOverlayAndColorProvider
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60047FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x813DC4", Offset = "0x813DC4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SpawnConditionDecorativeOverlayInfoElement(string overlayImagePath = null, Color? overlayColor = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D9A8", Offset = "0x81D9A8", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Asset<Texture2D> GetBackgroundOverlayImage()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004800")]
		[global::Cpp2ILInjected.Address(RVA = "0x81DAB4", Offset = "0x81DAB4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Color? GetBackgroundOverlayColor()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004801")]
		[global::Cpp2ILInjected.Address(RVA = "0x81DAC4", Offset = "0x81DAC4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400839D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _overlayImagePath;

		[global::Cpp2ILInjected.Token(Token = "0x400839E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Color? _overlayColor;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400839F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private float <DisplayPriority>k__BackingField;
	}
}
