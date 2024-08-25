using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent;

namespace Terraria.Graphics.Renderers
{
	[global::Cpp2ILInjected.Token(Token = "0x200075F")]
	public class NPCHeadRenderer : INeedRenderTargetContent
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003E0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x14ABDB8", Offset = "0x14ABDB8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main.<LoadContent_Deferred>d__1863", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public NPCHeadRenderer(Asset<Texture2D>[] matchingArray)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003E0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x14ABDE4", Offset = "0x14ABDE4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003E0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x14ABE38", Offset = "0x14ABE38", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCHeadDrawRenderTargetContent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCHeadDrawRenderTargetContent), Member = "SetTexture", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ARenderTargetContentByRequest), Member = "Request", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void DrawWithOutlines(Entity entity, int headId, Vector2 position, Color color, float rotation, float scale, SpriteEffects effects)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700078E")]
		public bool IsReady
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003E10")]
			[global::Cpp2ILInjected.Address(RVA = "0x14AC074", Offset = "0x14AC074", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003E11")]
		[global::Cpp2ILInjected.Address(RVA = "0x14AC07C", Offset = "0x14AC07C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ARenderTargetContentByRequest), Member = "PrepareRenderTarget", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		public void PrepareRenderTarget(GraphicsDevice device, SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007CCB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private NPCHeadDrawRenderTargetContent[] _contents;

		[global::Cpp2ILInjected.Token(Token = "0x4007CCC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Asset<Texture2D>[] _matchingArray;
	}
}
