using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.GameContent.UI.States;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006D6 RID: 1750
	[global::Cpp2ILInjected.Token(Token = "0x2000ABA")]
	public class UIImageButton : UIElement
	{
		// Token: 0x06004494 RID: 17556 RVA: 0x0002E45D File Offset: 0x0002C65D
		[global::Cpp2ILInjected.Token(Token = "0x60050E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x928200", Offset = "0x928200", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "AddBackAndForwardButtons", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "AddSortAndFilterButtons", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(UIBestiaryEntryInfoPage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "AddSearchBar", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(UIBestiaryEntryInfoPage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "AddSearchBar", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIHairStyleButton), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public UIImageButton(Asset<Texture2D> texture)
		{
			throw null;
		}

		// Token: 0x06004495 RID: 17557 RVA: 0x0002E460 File Offset: 0x0002C660
		[global::Cpp2ILInjected.Token(Token = "0x60050E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x92A030", Offset = "0x92A030", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetHoverImage(Asset<Texture2D> texture)
		{
			throw null;
		}

		// Token: 0x06004496 RID: 17558 RVA: 0x0002E463 File Offset: 0x0002C663
		[global::Cpp2ILInjected.Token(Token = "0x60050E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x92A038", Offset = "0x92A038", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetImage(Asset<Texture2D> texture)
		{
			throw null;
		}

		// Token: 0x06004497 RID: 17559 RVA: 0x0002E466 File Offset: 0x0002C666
		[global::Cpp2ILInjected.Token(Token = "0x60050E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x9286E4", Offset = "0x9286E4", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIHairStyleButton), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "Position", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06004498 RID: 17560 RVA: 0x0002E469 File Offset: 0x0002C669
		[global::Cpp2ILInjected.Token(Token = "0x60050EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x9288DC", Offset = "0x9288DC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "MouseOver", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		public override void MouseOver(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x0002E46C File Offset: 0x0002C66C
		[global::Cpp2ILInjected.Token(Token = "0x60050EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x928928", Offset = "0x928928", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "MouseOut", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void MouseOut(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x0600449A RID: 17562 RVA: 0x0002E46F File Offset: 0x0002C66F
		[global::Cpp2ILInjected.Token(Token = "0x60050EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x92A0DC", Offset = "0x92A0DC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "AddBackAndForwardButtons", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "AddSortAndFilterButtons", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(UIBestiaryEntryInfoPage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "AddSearchBar", MemberParameters = new object[]
		{
			typeof(UIElement),
			typeof(UIBestiaryEntryInfoPage)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "AddSearchBar", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public void SetVisibility(float whenActive, float whenInactive)
		{
			throw null;
		}

		// Token: 0x04007062 RID: 28770
		[global::Cpp2ILInjected.Token(Token = "0x40089A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private Asset<Texture2D> _texture;

		// Token: 0x04007063 RID: 28771
		[global::Cpp2ILInjected.Token(Token = "0x40089AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private float _visibilityActive;

		// Token: 0x04007064 RID: 28772
		[global::Cpp2ILInjected.Token(Token = "0x40089AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x154")]
		private float _visibilityInactive;

		// Token: 0x04007065 RID: 28773
		[global::Cpp2ILInjected.Token(Token = "0x40089AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private Asset<Texture2D> _borderTexture;
	}
}
