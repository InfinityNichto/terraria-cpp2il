using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x200095D")]
	public class SpawnConditionBestiaryOverlayInfoElement : FilterProviderInfoElement, IBestiaryBackgroundOverlayAndColorProvider, IBestiaryPrioritizedElement
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60047F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x81243C", Offset = "0x81243C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SpawnConditionBestiaryOverlayInfoElement(string nameLanguageKey, int filterIconFrame, string overlayImagePath = null, Color? overlayColor = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D87C", Offset = "0x81D87C", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Asset<Texture2D> GetBackgroundOverlayImage()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60047FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x81D988", Offset = "0x81D988", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Color? GetBackgroundOverlayColor()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008399")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string _overlayImagePath;

		[global::Cpp2ILInjected.Token(Token = "0x400839A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Color? _overlayColor;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400839B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private float <DisplayPriority>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400839C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private float <OrderPriority>k__BackingField;
	}
}
