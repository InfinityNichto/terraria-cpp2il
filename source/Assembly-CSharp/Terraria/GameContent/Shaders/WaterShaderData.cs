using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.Graphics;
using Terraria.Graphics.Shaders;
using Terraria.Initializers;

namespace Terraria.GameContent.Shaders
{
	// Token: 0x0200058C RID: 1420
	[global::Cpp2ILInjected.Token(Token = "0x2000826")]
	public class WaterShaderData : ScreenShaderData
	{
		// Token: 0x1400004E RID: 78
		// (add) Token: 0x06003BA5 RID: 15269 RVA: 0x0002CA86 File Offset: 0x0002AC86
		// (remove) Token: 0x06003BA6 RID: 15270 RVA: 0x0002CA89 File Offset: 0x0002AC89
		[global::Cpp2ILInjected.Token(Token = "0x14000054")]
		public event Action<TileBatch> OnWaveDraw
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60042C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x79877C", Offset = "0x79877C", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60042C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x79882C", Offset = "0x79882C", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x06003BA7 RID: 15271 RVA: 0x0002CA8C File Offset: 0x0002AC8C
		[global::Cpp2ILInjected.Token(Token = "0x60042C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x7988DC", Offset = "0x7988DC", Length = "0x2F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResolutionChangeEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "add_OnRenderTargetsInitialized", MemberParameters = new object[] { typeof(ResolutionChangeEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "add_OnRenderTargetsReleased", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "add_OnPreDraw", MemberParameters = new object[] { typeof(Action<GameTime>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public WaterShaderData(string passName)
		{
			throw null;
		}

		// Token: 0x06003BA8 RID: 15272 RVA: 0x0002CA8F File Offset: 0x0002AC8F
		[global::Cpp2ILInjected.Token(Token = "0x60042C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x798BD4", Offset = "0x798BD4", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_WaveQuality", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x0002CA92 File Offset: 0x0002AC92
		[global::Cpp2ILInjected.Token(Token = "0x60042C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x798EB0", Offset = "0x798EB0", Length = "0x494")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "PreDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Game), Member = "get_GraphicsDevice", ReturnType = typeof(GraphicsDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DistortionRenderTargetManager), Member = "get_Instance", ReturnType = typeof(DistortionRenderTargetManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DistortionRenderTargetManager), Member = "BeginRenderTarget", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaterShaderData), Member = "DrawWaves", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DistortionRenderTargetManager), Member = "EndRenderTarget", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DistortionRenderTargetManager), Member = "SwapTargets", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(BlendState),
			typeof(SamplerState),
			typeof(DepthStencilState),
			typeof(RasterizerState),
			typeof(Effect),
			typeof(Matrix?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData?), Member = ".ctor", MemberParameters = new object[] { typeof(DrawData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexColors), Member = ".ctor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector4),
			typeof(VertexColors)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private void StepLiquids()
		{
			throw null;
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x0002CA95 File Offset: 0x0002AC95
		[global::Cpp2ILInjected.Token(Token = "0x60042C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x799344", Offset = "0x799344", Length = "0x15D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "StepLiquids", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Game), Member = "get_GraphicsDevice", ReturnType = typeof(GraphicsDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(BlendState),
			typeof(SamplerState),
			typeof(DepthStencilState),
			typeof(RasterizerState),
			typeof(Effect),
			typeof(Matrix?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "CheckAABBvAABBCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "LengthSquared", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector4),
			typeof(float)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexColors), Member = ".ctor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector4),
			typeof(Rectangle?),
			typeof(VertexColors),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaterShaderData), Member = "QueueRipple", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Color),
			typeof(Vector2),
			typeof(RippleShape),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector4),
			typeof(VertexColors)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaterShaderData), Member = "QueueRipple", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float),
			typeof(Vector2),
			typeof(RippleShape),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "LavaCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "WetCollision", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaterShaderData.Ripple), Member = "get_SourceRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 65)]
		private void DrawWaves()
		{
			throw null;
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x0002CA98 File Offset: 0x0002AC98
		[global::Cpp2ILInjected.Token(Token = "0x60042C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x79AAFC", Offset = "0x79AAFC", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaterShaderData), Member = "ValidateRenderTargets", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_IsGraphicsDeviceAvailable", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaterShaderData), Member = "StepLiquids", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DistortionRenderTargetManager), Member = "get_Instance", ReturnType = typeof(DistortionRenderTargetManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DistortionRenderTargetManager), Member = "ClearRenderTarget", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void PreDraw(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x0002CA9B File Offset: 0x0002AC9B
		[global::Cpp2ILInjected.Token(Token = "0x60042C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x79ACD8", Offset = "0x79ACD8", Length = "0x3A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_IsGraphicsDeviceAvailable", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseProgress", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DistortionRenderTargetManager), Member = "get_Instance", ReturnType = typeof(DistortionRenderTargetManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseImage", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(int),
			typeof(SamplerState)
		}, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaterRenderTargetManager), Member = "get_Instance", ReturnType = typeof(WaterRenderTargetManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseTargetPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseImageOffset", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override void Apply()
		{
			throw null;
		}

		// Token: 0x06003BAD RID: 15277 RVA: 0x0002CA9E File Offset: 0x0002AC9E
		[global::Cpp2ILInjected.Token(Token = "0x60042C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x79AC10", Offset = "0x79AC10", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "PreDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Game), Member = "get_GraphicsDevice", ReturnType = typeof(GraphicsDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_WaveQuality", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ValidateRenderTargets()
		{
			throw null;
		}

		// Token: 0x06003BAE RID: 15278 RVA: 0x0002CAA1 File Offset: 0x0002ACA1
		[global::Cpp2ILInjected.Token(Token = "0x60042C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x79B088", Offset = "0x79B088", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void InitRenderTargets(int width, int height)
		{
			throw null;
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x0002CAA4 File Offset: 0x0002ACA4
		[global::Cpp2ILInjected.Token(Token = "0x60042CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x79B080", Offset = "0x79B080", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void ReleaseRenderTargets()
		{
			throw null;
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x0002CAA7 File Offset: 0x0002ACA7
		[global::Cpp2ILInjected.Token(Token = "0x60042CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x79B09C", Offset = "0x79B09C", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Gore), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaterShaderData), Member = "QueueRipple", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Color),
			typeof(Vector2),
			typeof(RippleShape),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void QueueRipple(Vector2 position, float strength = 1f, RippleShape shape = RippleShape.Square, float rotation = 0f)
		{
			throw null;
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x0002CAAA File Offset: 0x0002ACAA
		[global::Cpp2ILInjected.Token(Token = "0x60042CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x79A964", Offset = "0x79A964", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "DrawWaves", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaterShaderData), Member = "QueueRipple", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Color),
			typeof(Vector2),
			typeof(RippleShape),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void QueueRipple(Vector2 position, float strength, Vector2 size, RippleShape shape = RippleShape.Square, float rotation = 0f)
		{
			throw null;
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x0002CAAD File Offset: 0x0002ACAD
		[global::Cpp2ILInjected.Token(Token = "0x60042CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x79A918", Offset = "0x79A918", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "DrawWaves", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "QueueRipple", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float),
			typeof(RippleShape),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "QueueRipple", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float),
			typeof(Vector2),
			typeof(RippleShape),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public void QueueRipple(Vector2 position, Color waveData, Vector2 size, RippleShape shape = RippleShape.Square, float rotation = 0f)
		{
			throw null;
		}

		// Token: 0x04006B14 RID: 27412
		[global::Cpp2ILInjected.Token(Token = "0x40080FB")]
		public const float DISTORTION_BUFFER_SCALE = 0.25f;

		// Token: 0x04006B15 RID: 27413
		[global::Cpp2ILInjected.Token(Token = "0x40080FC")]
		private const float WAVE_FRAMERATE = 0.016666668f;

		// Token: 0x04006B16 RID: 27414
		[global::Cpp2ILInjected.Token(Token = "0x40080FD")]
		private const int MAX_RIPPLES_QUEUED = 200;

		// Token: 0x04006B17 RID: 27415
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40080FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private Action<TileBatch> OnWaveDraw;

		// Token: 0x04006B18 RID: 27416
		[global::Cpp2ILInjected.Token(Token = "0x40080FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public bool _useViscosityFilter;

		// Token: 0x04006B19 RID: 27417
		[global::Cpp2ILInjected.Token(Token = "0x4008100")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x91")]
		private bool _usingRenderTargets;

		// Token: 0x04006B1A RID: 27418
		[global::Cpp2ILInjected.Token(Token = "0x4008101")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		private Vector2 _lastDistortionDrawOffset;

		// Token: 0x04006B1B RID: 27419
		[global::Cpp2ILInjected.Token(Token = "0x4008102")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		private float _progress;

		// Token: 0x04006B1C RID: 27420
		[global::Cpp2ILInjected.Token(Token = "0x4008103")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private WaterShaderData.Ripple[] _rippleQueue;

		// Token: 0x04006B1D RID: 27421
		[global::Cpp2ILInjected.Token(Token = "0x4008104")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private int _rippleQueueCount;

		// Token: 0x04006B1E RID: 27422
		[global::Cpp2ILInjected.Token(Token = "0x4008105")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
		private int _lastScreenWidth;

		// Token: 0x04006B1F RID: 27423
		[global::Cpp2ILInjected.Token(Token = "0x4008106")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private int _lastScreenHeight;

		// Token: 0x04006B20 RID: 27424
		[global::Cpp2ILInjected.Token(Token = "0x4008107")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
		public bool _useProjectileWaves;

		// Token: 0x04006B21 RID: 27425
		[global::Cpp2ILInjected.Token(Token = "0x4008108")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB5")]
		private bool _useNPCWaves;

		// Token: 0x04006B22 RID: 27426
		[global::Cpp2ILInjected.Token(Token = "0x4008109")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB6")]
		private bool _usePlayerWaves;

		// Token: 0x04006B23 RID: 27427
		[global::Cpp2ILInjected.Token(Token = "0x400810A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB7")]
		private bool _useRippleWaves;

		// Token: 0x04006B24 RID: 27428
		[global::Cpp2ILInjected.Token(Token = "0x400810B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private bool _useCustomWaves;

		// Token: 0x04006B25 RID: 27429
		[global::Cpp2ILInjected.Token(Token = "0x400810C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB9")]
		private bool _clearNextFrame;

		// Token: 0x04006B26 RID: 27430
		[global::Cpp2ILInjected.Token(Token = "0x400810D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private Texture2D[] _viscosityMaskChain;

		// Token: 0x04006B27 RID: 27431
		[global::Cpp2ILInjected.Token(Token = "0x400810E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private int _activeViscosityMask;

		// Token: 0x04006B28 RID: 27432
		[global::Cpp2ILInjected.Token(Token = "0x400810F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private Asset<Texture2D> _rippleShapeTexture;

		// Token: 0x04006B29 RID: 27433
		[global::Cpp2ILInjected.Token(Token = "0x4008110")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private bool _isWaveBufferDirty;

		// Token: 0x04006B2A RID: 27434
		[global::Cpp2ILInjected.Token(Token = "0x4008111")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
		private int _queuedSteps;

		// Token: 0x04006B2B RID: 27435
		[global::Cpp2ILInjected.Token(Token = "0x4008112")]
		private const int MAX_QUEUED_STEPS = 1;

		// Token: 0x020009A5 RID: 2469
		[global::Cpp2ILInjected.Token(Token = "0x2000827")]
		private struct Ripple
		{
			// Token: 0x170008BF RID: 2239
			// (get) Token: 0x06004DF0 RID: 19952 RVA: 0x0002FC0C File Offset: 0x0002DE0C
			[global::Cpp2ILInjected.Token(Token = "0x170007C4")]
			public Rectangle SourceRectangle
			{
				[global::Cpp2ILInjected.Token(Token = "0x60042CE")]
				[global::Cpp2ILInjected.Address(RVA = "0x79AA94", Offset = "0x79AA94", Length = "0x68")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "DrawWaves", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004DF1 RID: 19953 RVA: 0x0002FC0F File Offset: 0x0002DE0F
			[global::Cpp2ILInjected.Token(Token = "0x60042CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x79B1F8", Offset = "0x79B1F8", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public Ripple(Vector2 position, Color waveData, Vector2 size, RippleShape shape, float rotation)
			{
				throw null;
			}

			// Token: 0x06004DF2 RID: 19954 RVA: 0x0002FC12 File Offset: 0x0002DE12
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60042D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x79B210", Offset = "0x79B210", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			static Ripple()
			{
				throw null;
			}

			// Token: 0x04008C9C RID: 35996
			[global::Cpp2ILInjected.Token(Token = "0x4008113")]
			private static readonly Rectangle[] RIPPLE_SHAPE_SOURCE_RECTS;

			// Token: 0x04008C9D RID: 35997
			[global::Cpp2ILInjected.Token(Token = "0x4008114")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly Vector2 Position;

			// Token: 0x04008C9E RID: 35998
			[global::Cpp2ILInjected.Token(Token = "0x4008115")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly Color WaveData;

			// Token: 0x04008C9F RID: 35999
			[global::Cpp2ILInjected.Token(Token = "0x4008116")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public readonly Vector2 Size;

			// Token: 0x04008CA0 RID: 36000
			[global::Cpp2ILInjected.Token(Token = "0x4008117")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public readonly RippleShape Shape;

			// Token: 0x04008CA1 RID: 36001
			[global::Cpp2ILInjected.Token(Token = "0x4008118")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public readonly float Rotation;
		}
	}
}
