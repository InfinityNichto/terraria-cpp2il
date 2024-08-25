using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Renderers;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007CC")]
	public class NPCHeadDrawRenderTargetContent : AnOutlinedDrawRenderTargetContent
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4007E5D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Texture2D _theTexture;
	}
}
