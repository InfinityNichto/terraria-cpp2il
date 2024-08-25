using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Golf;
using Terraria.GameContent.ObjectInteractions;
using Terraria.GameInput;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Renderers;
using Terraria.UI;

namespace Terraria.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x2000733")]
	public class SpriteViewMatrix
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000775")]
		public Vector2 Zoom
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003CF8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1499220", Offset = "0x1499220", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003CF9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1499228", Offset = "0x1499228", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000776")]
		public Vector2 Translation
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003CFA")]
			[global::Cpp2ILInjected.Address(RVA = "0x14992BC", Offset = "0x14992BC", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "get_ViewPosition", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ClampScreenPositionToWorld", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteViewMatrix), Member = "ShouldRebuild", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteViewMatrix), Member = "Rebuild", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000777")]
		public Matrix ZoomMatrix
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003CFB")]
			[global::Cpp2ILInjected.Address(RVA = "0x14999E8", Offset = "0x14999E8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TryInteractingWithVoidLens", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TryInteractingWithMoneyTrough", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCChatBubble", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_1_1_DrawEmoteBubblesInWorld", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_1_2_DrawEntityMarkersInWorld", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "ToScreenPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "HandleDpadSnap", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameInterfaceLayer), Member = "Draw", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReturnGatePlayerRenderer), Member = "OverReturnGateInWorld", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AHoverInteractionChecker), Member = "AttemptInteraction", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(Rectangle)
			}, ReturnType = typeof(AHoverInteractionChecker.HoverStatus))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteViewMatrix), Member = "ShouldRebuild", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteViewMatrix), Member = "Rebuild", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000778")]
		public Matrix TransformationMatrix
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003CFC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1499A24", Offset = "0x1499A24", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "get_RenderTargetsRequired", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "get_Transform", ReturnType = typeof(Matrix))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyPlayerRenderer), Member = "DrawPlayerFull", MemberParameters = new object[]
			{
				typeof(Camera),
				typeof(Player)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReturnGatePlayerRenderer), Member = "DrawReturnGateInWorld", MemberParameters = new object[]
			{
				typeof(Camera),
				typeof(Player)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FancyGolfPredictionLine), Member = "Draw", MemberParameters = new object[]
			{
				typeof(Camera),
				typeof(SpriteBatch),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteViewMatrix), Member = "ShouldRebuild", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteViewMatrix), Member = "Rebuild", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000779")]
		public Matrix NormalizedTransformationmatrix
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003CFD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1499A60", Offset = "0x1499A60", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteViewMatrix), Member = "ShouldRebuild", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteViewMatrix), Member = "Rebuild", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700077A")]
		public SpriteEffects Effects
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003CFE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1499A9C", Offset = "0x1499A9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003CFF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1499AA4", Offset = "0x1499AA4", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700077B")]
		public Matrix EffectMatrix
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003D00")]
			[global::Cpp2ILInjected.Address(RVA = "0x1499AC0", Offset = "0x1499AC0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FilterManager), Member = "EndCapture", MemberParameters = new object[]
			{
				typeof(RenderTarget2D),
				typeof(RenderTarget2D),
				typeof(RenderTarget2D),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteViewMatrix), Member = "ShouldRebuild", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteViewMatrix), Member = "Rebuild", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003D01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1499B04", Offset = "0x1499B04", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public SpriteViewMatrix(GraphicsDevice graphicsDevice)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003D02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1499358", Offset = "0x1499358", Length = "0x690")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteViewMatrix), Member = "get_Translation", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteViewMatrix), Member = "get_ZoomMatrix", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteViewMatrix), Member = "get_TransformationMatrix", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteViewMatrix), Member = "get_NormalizedTransformationmatrix", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteViewMatrix), Member = "get_EffectMatrix", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "get_Viewport", ReturnType = typeof(Viewport))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "CreateScale", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "CreateTranslation", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Matrix),
			typeof(Matrix)
		}, ReturnType = typeof(Matrix))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "CreateOrthographicOffCenter", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "Invert", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void Rebuild()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003D03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1499D10", Offset = "0x1499D10", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetViewportOverride(Viewport viewport)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003D04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1499D2C", Offset = "0x1499D2C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ClearViewportOverride()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003D05")]
		[global::Cpp2ILInjected.Address(RVA = "0x14992E0", Offset = "0x14992E0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteViewMatrix), Member = "get_Translation", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteViewMatrix), Member = "get_ZoomMatrix", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteViewMatrix), Member = "get_TransformationMatrix", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteViewMatrix), Member = "get_NormalizedTransformationmatrix", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteViewMatrix), Member = "get_EffectMatrix", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "get_Viewport", ReturnType = typeof(Viewport))]
		private bool ShouldRebuild()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007BF3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Vector2 _zoom;

		[global::Cpp2ILInjected.Token(Token = "0x4007BF4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Vector2 _translation;

		[global::Cpp2ILInjected.Token(Token = "0x4007BF5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Matrix _zoomMatrix;

		[global::Cpp2ILInjected.Token(Token = "0x4007BF6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Matrix _transformationMatrix;

		[global::Cpp2ILInjected.Token(Token = "0x4007BF7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private Matrix _normalizedTransformationMatrix;

		[global::Cpp2ILInjected.Token(Token = "0x4007BF8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private SpriteEffects _effects;

		[global::Cpp2ILInjected.Token(Token = "0x4007BF9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
		private Matrix _effectMatrix;

		[global::Cpp2ILInjected.Token(Token = "0x4007BFA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		private GraphicsDevice _graphicsDevice;

		[global::Cpp2ILInjected.Token(Token = "0x4007BFB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		private Viewport _viewport;

		[global::Cpp2ILInjected.Token(Token = "0x4007BFC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private bool _overrideSystemViewport;

		[global::Cpp2ILInjected.Token(Token = "0x4007BFD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x149")]
		private bool _needsRebuild;
	}
}
