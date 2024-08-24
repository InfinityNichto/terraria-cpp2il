using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Liquid;
using Terraria.GameContent.UI.Chat;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.Minimap;
using Terraria.Graphics;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Effects;
using Terraria.UI.Chat;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002C1 RID: 705
	[global::Cpp2ILInjected.Token(Token = "0x200038C")]
	public class SpriteBatch : GraphicsResource
	{
		// Token: 0x0600169B RID: 5787 RVA: 0x00025E3B File Offset: 0x0002403B
		[global::Cpp2ILInjected.Token(Token = "0x600180B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB4710", Offset = "0xAB4710", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadedRenderManager.RenderThreadInstance), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileBatch), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BasicDebugDrawer), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteEffect), Member = "get_Effect", ReturnType = typeof(SpriteEffect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public SpriteBatch(GraphicsDevice graphicsDevice)
		{
			throw null;
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00025E3E File Offset: 0x0002403E
		[global::Cpp2ILInjected.Token(Token = "0x600180C")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB4830", Offset = "0xAB4830", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public void Begin(SpriteSortMode sortMode, bool useTransformMatrix, bool defferedBatch)
		{
			throw null;
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x00025E41 File Offset: 0x00024041
		[global::Cpp2ILInjected.Token(Token = "0x600180D")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAC5E0", Offset = "0xAAC5E0", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 403)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void Begin(SpriteSortMode sortMode = SpriteSortMode.Deferred, BlendState blendState = null, SamplerState samplerState = null, DepthStencilState depthStencilState = null, RasterizerState rasterizerState = null, Effect effect = null, Matrix? transformMatrix = null, bool defferedBatch = true)
		{
			throw null;
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00025E44 File Offset: 0x00024044
		[global::Cpp2ILInjected.Token(Token = "0x600180E")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAC4C8", Offset = "0xAAC4C8", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 401)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawBatch", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(Effect),
			typeof(bool),
			typeof(bool),
			typeof(SpriteBatchItem)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void End()
		{
			throw null;
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00025E47 File Offset: 0x00024047
		[global::Cpp2ILInjected.Token(Token = "0x600180F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB4A1C", Offset = "0xAB4A1C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "FlushBatches", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ProcessBatchFinished", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "WaitBackgroundDrawThreads", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "oldDrawWater", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "ProcessBatchFinished", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "WaitDrawThreads", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallDrawing), Member = "ProcessBatchFinished", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallDrawing), Member = "WaitDrawThreads", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "DrawNormalLiquids", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(int),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "DrawShimmer", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "FlushBatches", ReturnType = typeof(void))]
		public void Flush()
		{
			throw null;
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00025E4A File Offset: 0x0002404A
		[global::Cpp2ILInjected.Token(Token = "0x6001810")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB49D0", Offset = "0xAB49D0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Setup()
		{
			throw null;
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00025E4D File Offset: 0x0002404D
		[global::Cpp2ILInjected.Token(Token = "0x6001811")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB4A28", Offset = "0xAB4A28", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void CheckValid(Texture2D texture)
		{
			throw null;
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00025E50 File Offset: 0x00024050
		[global::Cpp2ILInjected.Token(Token = "0x6001812")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB4ABC", Offset = "0xAB4ABC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawStringMultiLineRight", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawStringMultiLineCentre", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void CheckValid(SpriteFont spriteFont, string text)
		{
			throw null;
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00025E53 File Offset: 0x00024053
		[global::Cpp2ILInjected.Token(Token = "0x6001813")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB4B74", Offset = "0xAB4B74", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void CheckValid(SpriteFont spriteFont, StringBuilder text)
		{
			throw null;
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00025E56 File Offset: 0x00024056
		[global::Cpp2ILInjected.Token(Token = "0x6001814")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB4C2C", Offset = "0xAB4C2C", Length = "0x3B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color?), Member = ".ctor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public void Draw(Texture2D texture, Vector2? position = null, Rectangle? destinationRectangle = null, Rectangle? sourceRectangle = null, Vector2? origin = null, float rotation = 0f, Vector2? scale = null, Color? color = null, SpriteEffects effects = SpriteEffects.None, float layerDepth = 0f)
		{
			throw null;
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00025E59 File Offset: 0x00024059
		[global::Cpp2ILInjected.Token(Token = "0x6001815")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB55D4", Offset = "0xAB55D4", Length = "0x314")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(ref VertexColors),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Rectangle?),
			typeof(ref VertexColors),
			typeof(float),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public void Draw(Texture2D texture, Vector2? position, Rectangle? destinationRectangle, Rectangle? sourceRectangle, Vector2? origin, float rotation, Vector2? scale, ref VertexColors color, SpriteEffects effects = SpriteEffects.None, float layerDepth = 0f)
		{
			throw null;
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00025E5C File Offset: 0x0002405C
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6001816")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB5F04", Offset = "0xAB5F04", Length = "0x288")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 35)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Resize", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(ref object[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "CreateBatchItemList", MemberParameters = new object[] { typeof(ref SpriteBatchItemList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public SpriteBatchItem InsertNewBatchItem(Texture2D texture)
		{
			throw null;
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00025E5F File Offset: 0x0002405F
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6001817")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB618C", Offset = "0xAB618C", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterfallManager), Member = "DrawWaterfall", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterfallManager), Member = "DrawWaterfall", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(Vector2),
			typeof(ref Rectangle),
			typeof(ref Color),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawVineStrip", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects = SpriteEffects.None)
		{
			throw null;
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00025E62 File Offset: 0x00024062
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6001818")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB63C4", Offset = "0xAB63C4", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "DrawLaser", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Utils.LaserLineFraming)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrawData), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DrawData), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects = SpriteEffects.None)
		{
			throw null;
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00025E65 File Offset: 0x00024065
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6001819")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB65D4", Offset = "0xAB65D4", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawDust", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color, float rotation, Vector2 origin, float scale)
		{
			throw null;
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00025E68 File Offset: 0x00024068
		[global::Cpp2ILInjected.Token(Token = "0x600181A")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB67AC", Offset = "0xAB67AC", Length = "0x258")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawStar", MemberParameters = new object[]
		{
			typeof(ref Main.SceneArea),
			typeof(float),
			typeof(Color),
			typeof(int),
			typeof(Star),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void Draw(Texture2D texture, ref Vector2 position, ref Color color, float rotation, Vector2 origin, float scale)
		{
			throw null;
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00025E6B File Offset: 0x0002406B
		[global::Cpp2ILInjected.Token(Token = "0x600181B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB4FE4", Offset = "0xAB4FE4", Length = "0x2F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 94)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
			throw null;
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00025E6E File Offset: 0x0002406E
		[global::Cpp2ILInjected.Token(Token = "0x600181C")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB6A04", Offset = "0xAB6A04", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Draw(Texture2D texture, Vector2 position, ref Rectangle srcRect, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
			throw null;
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00025E71 File Offset: 0x00024071
		[global::Cpp2ILInjected.Token(Token = "0x600181D")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB58E8", Offset = "0xAB58E8", Length = "0x2F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2?),
			typeof(Rectangle?),
			typeof(Rectangle?),
			typeof(Vector2?),
			typeof(float),
			typeof(Vector2?),
			typeof(ref VertexColors),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(ref VertexColors),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector4),
			typeof(VertexColors)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector4),
			typeof(Rectangle?),
			typeof(VertexColors)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector4),
			typeof(Rectangle?),
			typeof(VertexColors),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(ref VertexColors),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref VertexColors),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref VertexColors),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, ref VertexColors color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
			throw null;
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00025E74 File Offset: 0x00024074
		[global::Cpp2ILInjected.Token(Token = "0x600181E")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB6BE4", Offset = "0xAB6BE4", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref VertexColors),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref VertexColors),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Draw(Texture2D texture, Vector2 position, ref Rectangle srcRect, ref VertexColors color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
			throw null;
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00025E77 File Offset: 0x00024077
		[global::Cpp2ILInjected.Token(Token = "0x600181F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB6DF0", Offset = "0xAB6DF0", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterfallManager), Member = "DrawWaterfall", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterfallManager), Member = "DrawWaterfall", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(Vector2),
			typeof(ref Rectangle),
			typeof(ref Color),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "DrawShimmer", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref VertexColors),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref VertexColors),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Draw(Texture2D texture, Vector2 position, ref Rectangle srcRect, ref VertexColors color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
		{
			throw null;
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00025E7A File Offset: 0x0002407A
		[global::Cpp2ILInjected.Token(Token = "0x6001820")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB6FF8", Offset = "0xAB6FF8", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void ForceDrawScale(float scale, Vector2 origin, Vector2 position)
		{
			throw null;
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00025E7D File Offset: 0x0002407D
		[global::Cpp2ILInjected.Token(Token = "0x6001821")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB70C0", Offset = "0xAB70C0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void ClearDrawScale()
		{
			throw null;
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00025E80 File Offset: 0x00024080
		[global::Cpp2ILInjected.Token(Token = "0x6001822")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB7118", Offset = "0xAB7118", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
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
		public static void TransformPosition(ref Vector2 position, ref Vector2 scale)
		{
			throw null;
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00025E83 File Offset: 0x00024083
		[global::Cpp2ILInjected.Token(Token = "0x6001823")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB7224", Offset = "0xAB7224", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1001)]
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
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth = 0f)
		{
			throw null;
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00025E86 File Offset: 0x00024086
		[global::Cpp2ILInjected.Token(Token = "0x6001824")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB72E0", Offset = "0xAB72E0", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCurrentBackground", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMagmaLayer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawRockLayer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallDrawing), Member = "DrawWalls", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color)
		{
			throw null;
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00025E89 File Offset: 0x00024089
		[global::Cpp2ILInjected.Token(Token = "0x6001825")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB7394", Offset = "0xAB7394", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCurrentBackground", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMagmaLayer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawRockLayer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawPartialLiquid", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(bool),
			typeof(TileDrawInfo),
			typeof(ref Vector2),
			typeof(ref Rectangle),
			typeof(int),
			typeof(ref VertexColors)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallDrawing), Member = "DrawWalls", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "DrawNormalLiquids", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(int),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref VertexColors),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref VertexColors color)
		{
			throw null;
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00025E8C File Offset: 0x0002408C
		[global::Cpp2ILInjected.Token(Token = "0x6001826")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB7448", Offset = "0xAB7448", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref Color color, SpriteEffects effects)
		{
			throw null;
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00025E8F File Offset: 0x0002408F
		[global::Cpp2ILInjected.Token(Token = "0x6001827")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB7534", Offset = "0xAB7534", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref VertexColors),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		public void Draw(Texture2D texture, ref Vector2 position, ref Rectangle srcRect, ref VertexColors color, SpriteEffects effects)
		{
			throw null;
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00025E92 File Offset: 0x00024092
		[global::Cpp2ILInjected.Token(Token = "0x6001828")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB7620", Offset = "0xAB7620", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawSingleTile_Flames", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawMultiTileVinesInWind", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Draw(Texture2D texture, Vector2 position, ref Rectangle srcRect, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth = 0f)
		{
			throw null;
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00025E95 File Offset: 0x00024095
		[global::Cpp2ILInjected.Token(Token = "0x6001829")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB77FC", Offset = "0xAB77FC", Length = "0xBC")]
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
			typeof(ref VertexColors),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, ref VertexColors color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth = 0f)
		{
			throw null;
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x00025E98 File Offset: 0x00024098
		[global::Cpp2ILInjected.Token(Token = "0x600182A")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB52D4", Offset = "0xAB52D4", Length = "0x300")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutCalculator), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Texture2D),
			typeof(Color?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2?),
			typeof(Rectangle?),
			typeof(Rectangle?),
			typeof(Vector2?),
			typeof(float),
			typeof(Vector2?),
			typeof(Color?),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void Draw(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, SpriteEffects effects, float layerDepth)
		{
			throw null;
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00025E9B File Offset: 0x0002409B
		[global::Cpp2ILInjected.Token(Token = "0x600182B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB5BD8", Offset = "0xAB5BD8", Length = "0x32C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2?),
			typeof(Rectangle?),
			typeof(Rectangle?),
			typeof(Vector2?),
			typeof(float),
			typeof(Vector2?),
			typeof(ref VertexColors),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref VertexColors),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref VertexColors),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void Draw(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, ref VertexColors color, float rotation, Vector2 origin, SpriteEffects effects, float layerDepth)
		{
			throw null;
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00025E9E File Offset: 0x0002409E
		[global::Cpp2ILInjected.Token(Token = "0x600182C")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB6398", Offset = "0xAB6398", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		internal void FlushIfNeeded()
		{
			throw null;
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00025EA1 File Offset: 0x000240A1
		[global::Cpp2ILInjected.Token(Token = "0x600182D")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB78B8", Offset = "0xAB78B8", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_Resources_GolfPower", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawBackground", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "OldDrawBackground", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawBlack", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "DrawPanel", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(int),
			typeof(int),
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeChangeSettings", Member = "DrawWaterChoices", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Point),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = "DrawPanelTop", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = "DrawPanelBottom", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIGenProgressBar), Member = "DrawFilling", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Texture2D),
			typeof(Texture2D),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIImageFramed), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 34)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color)
		{
			throw null;
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00025EA4 File Offset: 0x000240A4
		[global::Cpp2ILInjected.Token(Token = "0x600182E")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB7AA4", Offset = "0xAB7AA4", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref VertexColors),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, ref VertexColors color)
		{
			throw null;
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00025EA7 File Offset: 0x000240A7
		[global::Cpp2ILInjected.Token(Token = "0x600182F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB7C90", Offset = "0xAB7C90", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 94)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void Draw(Texture2D texture, Rectangle destinationRectangle, Rectangle? sourceRectangle, Color color)
		{
			throw null;
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00025EAA File Offset: 0x000240AA
		[global::Cpp2ILInjected.Token(Token = "0x6001830")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB7E48", Offset = "0xAB7E48", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipmentUtility), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawWallOfCopperShortswords", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawWallOfBoulders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_Tiles_Solid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_Tiles_NonSolid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_WallsAndBlacks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FilterManager), Member = "EndCapture", MemberParameters = new object[]
		{
			typeof(RenderTarget2D),
			typeof(RenderTarget2D),
			typeof(RenderTarget2D),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.Minimap.MinimapFrame.Button", Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrame), Member = "DrawForeground", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GroupOptionButton<>), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIGenProgressBar), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIHairStyleButton), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIIconTextButton), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIImageButton), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIWorldCreationPreview), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Draw(Texture2D texture, Vector2 position, Color color)
		{
			throw null;
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00025EAD File Offset: 0x000240AD
		[global::Cpp2ILInjected.Token(Token = "0x6001831")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB7FA4", Offset = "0xAB7FA4", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 57)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Draw(Texture2D texture, Rectangle destinationRectangle, Color color)
		{
			throw null;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00025EB0 File Offset: 0x000240B0
		[global::Cpp2ILInjected.Token(Token = "0x6001832")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB8104", Offset = "0xAB8104", Length = "0x478")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIHeader), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "CheckValid", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont.CharacterSource), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "GetGlyphIndexOrDefault", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsAxisTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchAxisHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsKeyboardTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color)
		{
			throw null;
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00025EB3 File Offset: 0x000240B3
		[global::Cpp2ILInjected.Token(Token = "0x6001833")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB857C", Offset = "0xAB857C", Length = "0x568")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "CheckValid", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont.CharacterSource), Member = ".ctor", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "GetGlyphIndexOrDefault", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsAxisTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchAxisHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsKeyboardTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void DrawString(SpriteFont spriteFont, StringBuilder text, Vector2 position, Color color)
		{
			throw null;
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00025EB6 File Offset: 0x000240B6
		[global::Cpp2ILInjected.Token(Token = "0x6001834")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB8AE4", Offset = "0xAB8AE4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 78)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		public void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
		{
			throw null;
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00025EB9 File Offset: 0x000240B9
		[global::Cpp2ILInjected.Token(Token = "0x6001835")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB93A4", Offset = "0xAB93A4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawFPS", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		public void DrawString(SpriteFont spriteFont, StringBuilder text, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
		{
			throw null;
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00025EBC File Offset: 0x000240BC
		[global::Cpp2ILInjected.Token(Token = "0x6001836")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB8B88", Offset = "0xAB8B88", Length = "0x81C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "CheckValid", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont.CharacterSource), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "GetGlyphIndexOrDefault", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Transform", MemberParameters = new object[]
		{
			typeof(ref Vector2),
			typeof(ref Matrix),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsAxisTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchAxisHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsKeyboardTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
			throw null;
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00025EBF File Offset: 0x000240BF
		[global::Cpp2ILInjected.Token(Token = "0x6001837")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB9C60", Offset = "0xAB9C60", Length = "0xCF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
		{
			typeof(String_Layout),
			typeof(string),
			typeof(Color),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIString), Member = "DrawButton", MemberParameters = new object[]
		{
			typeof(String_Layout),
			typeof(string),
			typeof(Color)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "MouseText_DrawItemTooltip", MemberParameters = new object[]
		{
			typeof(Main.MouseTextCache),
			typeof(int),
			typeof(byte),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "CheckValid", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont.CharacterSource), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "GetGlyphIndexOrDefault", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Transform", MemberParameters = new object[]
		{
			typeof(ref Vector2),
			typeof(ref Matrix),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsAxisTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchAxisHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsKeyboardTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<float>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		public void DrawStringMultiLineRight(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
			throw null;
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00025EC2 File Offset: 0x000240C2
		[global::Cpp2ILInjected.Token(Token = "0x6001838")]
		[global::Cpp2ILInjected.Address(RVA = "0xABA950", Offset = "0xABA950", Length = "0xCF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIString), Member = "Draw", MemberParameters = new object[]
		{
			typeof(String_Layout),
			typeof(string),
			typeof(Color),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIString), Member = "DrawButton", MemberParameters = new object[]
		{
			typeof(String_Layout),
			typeof(string),
			typeof(Color)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "CheckValid", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont.CharacterSource), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "GetGlyphIndexOrDefault", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Transform", MemberParameters = new object[]
		{
			typeof(ref Vector2),
			typeof(ref Matrix),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsAxisTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchAxisHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsKeyboardTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<float>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		public void DrawStringMultiLineCentre(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
			throw null;
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x00025EC5 File Offset: 0x000240C5
		[global::Cpp2ILInjected.Token(Token = "0x6001839")]
		[global::Cpp2ILInjected.Address(RVA = "0xAB9448", Offset = "0xAB9448", Length = "0x818")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "CheckValid", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont.CharacterSource), Member = ".ctor", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "GetGlyphIndexOrDefault", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Transform", MemberParameters = new object[]
		{
			typeof(ref Vector2),
			typeof(ref Matrix),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsAxisTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchAxisHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsKeyboardTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public void DrawString(SpriteFont spriteFont, StringBuilder text, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
			throw null;
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00025EC8 File Offset: 0x000240C8
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x600183A")]
		[global::Cpp2ILInjected.Address(RVA = "0xABB648", Offset = "0xABB648", Length = "0x878")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
		{
			typeof(Vector2[]),
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "CheckValid", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont.CharacterSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont.CharacterSource), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "GetGlyphIndexOrDefault", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsAxisTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchAxisHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsKeyboardTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Transform", MemberParameters = new object[]
		{
			typeof(ref Vector2),
			typeof(ref Matrix),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public void DrawString(SpriteFont spriteFont, string text, int start, int end, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, Vector2[] offsets)
		{
			throw null;
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00025ECB File Offset: 0x000240CB
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x600183B")]
		[global::Cpp2ILInjected.Address(RVA = "0xABBEC0", Offset = "0xABBEC0", Length = "0x720")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
		{
			typeof(Vector2[]),
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "CheckValid", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont.CharacterSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont.CharacterSource), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "GetGlyphIndexOrDefault", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsAxisTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchAxisHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsKeyboardTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void DrawString(SpriteFont spriteFont, StringBuilder text, int start, int end, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, Vector2[] offsets)
		{
			throw null;
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x00025ECE File Offset: 0x000240CE
		[global::Cpp2ILInjected.Token(Token = "0x600183C")]
		[global::Cpp2ILInjected.Address(RVA = "0xABC5E0", Offset = "0xABC5E0", Length = "0x8C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(TextSnippet[]),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(ref int),
			typeof(float),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "CheckValid", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont.CharacterSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont.CharacterSource), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "GetGlyphIndexOrDefault", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Transform", MemberParameters = new object[]
		{
			typeof(ref Vector2),
			typeof(ref Matrix),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsAxisTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchAxisHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsKeyboardTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public void DrawString(SpriteFont spriteFont, string text, int start, int end, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
			throw null;
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00025ED1 File Offset: 0x000240D1
		[global::Cpp2ILInjected.Token(Token = "0x600183D")]
		[global::Cpp2ILInjected.Address(RVA = "0xABCEA8", Offset = "0xABCEA8", Length = "0x820")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatManager), Member = "DrawColorCodedString", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(StringBuilder),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "CheckValid", MemberParameters = new object[]
		{
			typeof(SpriteFont),
			typeof(StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont.CharacterSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(StringBuilder),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[]
		{
			typeof(ref SpriteFont.CharacterSource),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont.CharacterSource), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "GetGlyphIndexOrDefault", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Transform", MemberParameters = new object[]
		{
			typeof(ref Vector2),
			typeof(ref Matrix),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsAxisTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsTouchAxisHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsButtonTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsKeyboardTagHandler), Member = "PrintInlineMapping", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemTagHandler), Member = "PrintInline", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(ref SpriteFont.CharacterSource),
			typeof(int),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public void DrawString(SpriteFont spriteFont, StringBuilder text, int start, int end, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
			throw null;
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x00025ED4 File Offset: 0x000240D4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600183E")]
		[global::Cpp2ILInjected.Address(RVA = "0xABD6C8", Offset = "0xABD6C8", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<float>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		static SpriteBatch()
		{
			throw null;
		}

		// Token: 0x04002007 RID: 8199
		[global::Cpp2ILInjected.Token(Token = "0x400264D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public bool BatchDeffered;

		// Token: 0x04002008 RID: 8200
		[global::Cpp2ILInjected.Token(Token = "0x400264E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
		public bool BatchDefferedHeadInsert;

		// Token: 0x04002009 RID: 8201
		[global::Cpp2ILInjected.Token(Token = "0x400264F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly SpriteBatcher _batcher;

		// Token: 0x0400200A RID: 8202
		[global::Cpp2ILInjected.Token(Token = "0x4002650")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private SpriteSortMode _sortMode;

		// Token: 0x0400200B RID: 8203
		[global::Cpp2ILInjected.Token(Token = "0x4002651")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private BlendState _blendState;

		// Token: 0x0400200C RID: 8204
		[global::Cpp2ILInjected.Token(Token = "0x4002652")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private DepthStencilState _depthStencilState;

		// Token: 0x0400200D RID: 8205
		[global::Cpp2ILInjected.Token(Token = "0x4002653")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private RasterizerState _rasterizerState;

		// Token: 0x0400200E RID: 8206
		[global::Cpp2ILInjected.Token(Token = "0x4002654")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Effect _effect;

		// Token: 0x0400200F RID: 8207
		[global::Cpp2ILInjected.Token(Token = "0x4002655")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public bool _beginCalled;

		// Token: 0x04002010 RID: 8208
		[global::Cpp2ILInjected.Token(Token = "0x4002656")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		private int _batchOffset;

		// Token: 0x04002011 RID: 8209
		[global::Cpp2ILInjected.Token(Token = "0x4002657")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private SpriteBatchItem _lastBatchItem;

		// Token: 0x04002012 RID: 8210
		[global::Cpp2ILInjected.Token(Token = "0x4002658")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private SpriteBatchItemList _firstBatchList;

		// Token: 0x04002013 RID: 8211
		[global::Cpp2ILInjected.Token(Token = "0x4002659")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private SpriteBatchItemList _lastBatchList;

		// Token: 0x04002014 RID: 8212
		[global::Cpp2ILInjected.Token(Token = "0x400265A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private Effect _spriteEffect;

		// Token: 0x04002015 RID: 8213
		[global::Cpp2ILInjected.Token(Token = "0x400265B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private readonly EffectPass _spritePass;

		// Token: 0x04002016 RID: 8214
		[global::Cpp2ILInjected.Token(Token = "0x400265C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private Matrix _renderMatrix;

		// Token: 0x04002017 RID: 8215
		[global::Cpp2ILInjected.Token(Token = "0x400265D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private bool _hasMatrix;

		// Token: 0x04002018 RID: 8216
		[global::Cpp2ILInjected.Token(Token = "0x400265E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
		private Viewport _lastViewport;

		// Token: 0x04002019 RID: 8217
		[global::Cpp2ILInjected.Token(Token = "0x400265F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
		private Matrix _projection;

		// Token: 0x0400201A RID: 8218
		[global::Cpp2ILInjected.Token(Token = "0x4002660")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x134")]
		private Rectangle _tempRect;

		// Token: 0x0400201B RID: 8219
		[global::Cpp2ILInjected.Token(Token = "0x4002661")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x144")]
		private Vector2 _texCoordTL;

		// Token: 0x0400201C RID: 8220
		[global::Cpp2ILInjected.Token(Token = "0x4002662")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14C")]
		private Vector2 _texCoordBR;

		// Token: 0x0400201D RID: 8221
		[global::Cpp2ILInjected.Token(Token = "0x4002663")]
		internal static bool NeedsHalfPixelOffset;

		// Token: 0x0400201E RID: 8222
		[global::Cpp2ILInjected.Token(Token = "0x4002664")]
		public static string LastBeginCall;

		// Token: 0x0400201F RID: 8223
		[global::Cpp2ILInjected.Token(Token = "0x4002665")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		public EffectPass OverloadedEffectPass;

		// Token: 0x04002020 RID: 8224
		[global::Cpp2ILInjected.Token(Token = "0x4002666")]
		public static bool forceDrawScale;

		// Token: 0x04002021 RID: 8225
		[global::Cpp2ILInjected.Token(Token = "0x4002667")]
		public static Vector2 forcedDrawScale;

		// Token: 0x04002022 RID: 8226
		[global::Cpp2ILInjected.Token(Token = "0x4002668")]
		public static Vector2 forcedDrawOrigin;

		// Token: 0x04002023 RID: 8227
		[global::Cpp2ILInjected.Token(Token = "0x4002669")]
		public static Vector2 forcedDrawPosition;

		// Token: 0x04002024 RID: 8228
		[global::Cpp2ILInjected.Token(Token = "0x400266A")]
		private static List<float> rightLineLengths;

		// Token: 0x04002025 RID: 8229
		[global::Cpp2ILInjected.Token(Token = "0x400266B")]
		private static List<int> rightLineOffsets;

		// Token: 0x04002026 RID: 8230
		[global::Cpp2ILInjected.Token(Token = "0x400266C")]
		private static List<SpriteBatchItem> rightLineElements;
	}
}
