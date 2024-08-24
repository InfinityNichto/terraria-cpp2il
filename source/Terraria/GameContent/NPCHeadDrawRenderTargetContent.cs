using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Renderers;

namespace Terraria.GameContent
{
	// Token: 0x02000550 RID: 1360
	[global::Cpp2ILInjected.Token(Token = "0x20007CC")]
	public class NPCHeadDrawRenderTargetContent : AnOutlinedDrawRenderTargetContent
	{
		// Token: 0x060039D4 RID: 14804 RVA: 0x0002C53D File Offset: 0x0002A73D
		[global::Cpp2ILInjected.Token(Token = "0x60040AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x772AA8", Offset = "0x772AA8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCHeadRenderer), Member = "DrawWithOutlines", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(float),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void SetTexture(Texture2D texture)
		{
			throw null;
		}

		// Token: 0x060039D5 RID: 14805 RVA: 0x0002C540 File Offset: 0x0002A740
		[global::Cpp2ILInjected.Token(Token = "0x60040AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x772AD0", Offset = "0x772AD0", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal override void DrawTheContent(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x060039D6 RID: 14806 RVA: 0x0002C543 File Offset: 0x0002A743
		[global::Cpp2ILInjected.Token(Token = "0x60040AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x772C04", Offset = "0x772C04", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCHeadRenderer), Member = "DrawWithOutlines", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(float),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnOutlinedDrawRenderTargetContent), Member = ".ctor", ReturnType = typeof(void))]
		public NPCHeadDrawRenderTargetContent()
		{
			throw null;
		}

		// Token: 0x040068F8 RID: 26872
		[global::Cpp2ILInjected.Token(Token = "0x4007E5D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Texture2D _theTexture;
	}
}
