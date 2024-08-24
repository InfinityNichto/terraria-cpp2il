using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Shaders;
using Terraria.Initializers;

namespace Terraria.Graphics.Effects
{
	// Token: 0x02000522 RID: 1314
	[global::Cpp2ILInjected.Token(Token = "0x200078B")]
	public class SimpleOverlay : Overlay
	{
		// Token: 0x06003876 RID: 14454 RVA: 0x0002C14A File Offset: 0x0002A34A
		[global::Cpp2ILInjected.Token(Token = "0x6003F15")]
		[global::Cpp2ILInjected.Address(RVA = "0x742578", Offset = "0x742578", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public SimpleOverlay(string textureName, ScreenShaderData shader, EffectPriority priority = EffectPriority.VeryLow, RenderLayers layer = RenderLayers.All)
		{
			throw null;
		}

		// Token: 0x06003877 RID: 14455 RVA: 0x0002C14D File Offset: 0x0002A34D
		[global::Cpp2ILInjected.Token(Token = "0x6003F16")]
		[global::Cpp2ILInjected.Address(RVA = "0x742738", Offset = "0x742738", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Ref<Effect>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public SimpleOverlay(string textureName, string shaderName = "Default", EffectPriority priority = EffectPriority.VeryLow, RenderLayers layer = RenderLayers.All)
		{
			throw null;
		}

		// Token: 0x06003878 RID: 14456 RVA: 0x0002C150 File Offset: 0x0002A350
		[global::Cpp2ILInjected.Token(Token = "0x6003F17")]
		[global::Cpp2ILInjected.Address(RVA = "0x742948", Offset = "0x742948", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ScreenShaderData GetShader()
		{
			throw null;
		}

		// Token: 0x06003879 RID: 14457 RVA: 0x0002C153 File Offset: 0x0002A353
		[global::Cpp2ILInjected.Token(Token = "0x6003F18")]
		[global::Cpp2ILInjected.Address(RVA = "0x742950", Offset = "0x742950", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseGlobalOpacity", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseTargetPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void Draw(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x0600387A RID: 14458 RVA: 0x0002C156 File Offset: 0x0002A356
		[global::Cpp2ILInjected.Token(Token = "0x6003F19")]
		[global::Cpp2ILInjected.Address(RVA = "0x742A4C", Offset = "0x742A4C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x0600387B RID: 14459 RVA: 0x0002C159 File Offset: 0x0002A359
		[global::Cpp2ILInjected.Token(Token = "0x6003F1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x742A5C", Offset = "0x742A5C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Activate(Vector2 position, params object[] args)
		{
			throw null;
		}

		// Token: 0x0600387C RID: 14460 RVA: 0x0002C15C File Offset: 0x0002A35C
		[global::Cpp2ILInjected.Token(Token = "0x6003F1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x742A68", Offset = "0x742A68", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Deactivate(params object[] args)
		{
			throw null;
		}

		// Token: 0x0600387D RID: 14461 RVA: 0x0002C15F File Offset: 0x0002A35F
		[global::Cpp2ILInjected.Token(Token = "0x6003F1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x742A74", Offset = "0x742A74", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "get_CombinedOpacity", ReturnType = typeof(float))]
		public override bool IsVisible()
		{
			throw null;
		}

		// Token: 0x04006876 RID: 26742
		[global::Cpp2ILInjected.Token(Token = "0x4007D9C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Asset<Texture2D> _texture;

		// Token: 0x04006877 RID: 26743
		[global::Cpp2ILInjected.Token(Token = "0x4007D9D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ScreenShaderData _shader;

		// Token: 0x04006878 RID: 26744
		[global::Cpp2ILInjected.Token(Token = "0x4007D9E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public Vector2 TargetPosition;
	}
}
