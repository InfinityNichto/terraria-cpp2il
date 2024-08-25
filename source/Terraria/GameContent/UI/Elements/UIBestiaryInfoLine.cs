using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Bestiary;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	[global::Cpp2ILInjected.Token(Token = "0x2000AA6")]
	public class UIBestiaryInfoLine<T> : UIElement, IManuallyOrderedUIElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x170008BE")]
		public int OrderInUIList
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005053")]
			[global::Cpp2ILInjected.Address(RVA = "0x18940D0", Offset = "0x18940D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005054")]
			[global::Cpp2ILInjected.Address(RVA = "0x18940D8", Offset = "0x18940D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170008BF")]
		public float TextScale
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005055")]
			[global::Cpp2ILInjected.Address(RVA = "0x18940E0", Offset = "0x18940E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6005056")]
			[global::Cpp2ILInjected.Address(RVA = "0x18940E8", Offset = "0x18940E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170008C0")]
		public Vector2 TextSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005057")]
			[global::Cpp2ILInjected.Address(RVA = "0x18940F0", Offset = "0x18940F0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170008C1")]
		public string Text
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005058")]
			[global::Cpp2ILInjected.Address(RVA = "0x18940FC", Offset = "0x18940FC", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170008C2")]
		public Color TextColor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005059")]
			[global::Cpp2ILInjected.Address(RVA = "0x189415C", Offset = "0x189415C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600505A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1894164", Offset = "0x1894164", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600505B")]
		[global::Cpp2ILInjected.Address(RVA = "0x189416C", Offset = "0x189416C", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemFromCatchingNPCBestiaryInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public UIBestiaryInfoLine(T text, float textScale = 1f)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600505C")]
		[global::Cpp2ILInjected.Address(RVA = "0x189429C", Offset = "0x189429C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Recalculate", ReturnType = typeof(void))]
		public override void Recalculate()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600505D")]
		[global::Cpp2ILInjected.Address(RVA = "0x18942CC", Offset = "0x18942CC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetText(T text)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600505E")]
		[global::Cpp2ILInjected.Address(RVA = "0x18942E0", Offset = "0x18942E0", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual void SetText(T text, float textScale)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600505F")]
		[global::Cpp2ILInjected.Address(RVA = "0x189441C", Offset = "0x189441C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "Position", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawBorderString", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005060")]
		[global::Cpp2ILInjected.Address(RVA = "0x1894520", Offset = "0x1894520", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override int CompareTo(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400891C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private T _text;

		[global::Cpp2ILInjected.Token(Token = "0x400891D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private float _textScale;

		[global::Cpp2ILInjected.Token(Token = "0x400891E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Vector2 _textSize;

		[global::Cpp2ILInjected.Token(Token = "0x400891F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Color _color;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008920")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int <OrderInUIList>k__BackingField;
	}
}
