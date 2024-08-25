using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Renderers;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	[global::Cpp2ILInjected.Token(Token = "0x2000AC6")]
	public class UIParticleLayer : UIElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x6005121")]
		[global::Cpp2ILInjected.Address(RVA = "0x92CDE8", Offset = "0x92CDE8", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildSacrificeMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public UIParticleLayer()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005122")]
		[global::Cpp2ILInjected.Address(RVA = "0x92CED0", Offset = "0x92CED0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Update", ReturnType = typeof(void))]
		private void ParticleSystemUpdate(UIElement affectedElement)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005123")]
		[global::Cpp2ILInjected.Address(RVA = "0x92CEDC", Offset = "0x92CEDC", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "ToRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "TopLeft", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Recalculate()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005124")]
		[global::Cpp2ILInjected.Address(RVA = "0x92D020", Offset = "0x92D020", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005125")]
		[global::Cpp2ILInjected.Address(RVA = "0x92D02C", Offset = "0x92D02C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "UpdateVisualFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		public void AddParticle(IParticle particle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005126")]
		[global::Cpp2ILInjected.Address(RVA = "0x92D038", Offset = "0x92D038", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "StopPlayingAnimation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Clear", ReturnType = typeof(void))]
		public void ClearParticles()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40089C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		public ParticleRenderer ParticleSystem;

		[global::Cpp2ILInjected.Token(Token = "0x40089CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		public Vector2 AnchorPositionOffsetByPercents;

		[global::Cpp2ILInjected.Token(Token = "0x40089CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		public Vector2 AnchorPositionOffsetByPixels;
	}
}
