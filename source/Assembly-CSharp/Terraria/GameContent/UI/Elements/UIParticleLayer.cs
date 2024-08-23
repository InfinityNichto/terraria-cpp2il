using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Renderers;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006DE RID: 1758
	[global::Cpp2ILInjected.Token(Token = "0x2000AC6")]
	public class UIParticleLayer : UIElement
	{
		// Token: 0x060044C0 RID: 17600 RVA: 0x0002E4DB File Offset: 0x0002C6DB
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

		// Token: 0x060044C1 RID: 17601 RVA: 0x0002E4DE File Offset: 0x0002C6DE
		[global::Cpp2ILInjected.Token(Token = "0x6005122")]
		[global::Cpp2ILInjected.Address(RVA = "0x92CED0", Offset = "0x92CED0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Update", ReturnType = typeof(void))]
		private void ParticleSystemUpdate(UIElement affectedElement)
		{
			throw null;
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x0002E4E1 File Offset: 0x0002C6E1
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

		// Token: 0x060044C3 RID: 17603 RVA: 0x0002E4E4 File Offset: 0x0002C6E4
		[global::Cpp2ILInjected.Token(Token = "0x6005124")]
		[global::Cpp2ILInjected.Address(RVA = "0x92D020", Offset = "0x92D020", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x060044C4 RID: 17604 RVA: 0x0002E4E7 File Offset: 0x0002C6E7
		[global::Cpp2ILInjected.Token(Token = "0x6005125")]
		[global::Cpp2ILInjected.Address(RVA = "0x92D02C", Offset = "0x92D02C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "UpdateVisualFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Add", MemberParameters = new object[] { typeof(IParticle) }, ReturnType = typeof(void))]
		public void AddParticle(IParticle particle)
		{
			throw null;
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x0002E4EA File Offset: 0x0002C6EA
		[global::Cpp2ILInjected.Token(Token = "0x6005126")]
		[global::Cpp2ILInjected.Address(RVA = "0x92D038", Offset = "0x92D038", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "StopPlayingAnimation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleRenderer), Member = "Clear", ReturnType = typeof(void))]
		public void ClearParticles()
		{
			throw null;
		}

		// Token: 0x0400707D RID: 28797
		[global::Cpp2ILInjected.Token(Token = "0x40089C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		public ParticleRenderer ParticleSystem;

		// Token: 0x0400707E RID: 28798
		[global::Cpp2ILInjected.Token(Token = "0x40089CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		public Vector2 AnchorPositionOffsetByPercents;

		// Token: 0x0400707F RID: 28799
		[global::Cpp2ILInjected.Token(Token = "0x40089CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		public Vector2 AnchorPositionOffsetByPixels;
	}
}
