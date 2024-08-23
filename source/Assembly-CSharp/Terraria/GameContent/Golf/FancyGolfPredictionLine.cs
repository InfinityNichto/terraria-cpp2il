using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria.Graphics;
using Terraria.Physics;

namespace Terraria.GameContent.Golf
{
	// Token: 0x02000679 RID: 1657
	[global::Cpp2ILInjected.Token(Token = "0x2000A07")]
	public class FancyGolfPredictionLine
	{
		// Token: 0x06004136 RID: 16694 RVA: 0x0002DA7F File Offset: 0x0002BC7F
		[global::Cpp2ILInjected.Token(Token = "0x6004BC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AEBB8", Offset = "0x8AEBB8", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper), Member = "DrawPredictionLine", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FancyGolfPredictionLine.PredictionEntity), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Game), Member = "get_GraphicsDevice", ReturnType = typeof(GraphicsDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BasicDebugDrawer), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public FancyGolfPredictionLine(int iterations)
		{
			throw null;
		}

		// Token: 0x06004137 RID: 16695 RVA: 0x0002DA82 File Offset: 0x0002BC82
		[global::Cpp2ILInjected.Token(Token = "0x6004BC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AED5C", Offset = "0x8AED5C", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper), Member = "DrawPredictionLine", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfHelper), Member = "HitGolfBall", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfHelper), Member = "StepGolfBall", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(ref float)
		}, ReturnType = typeof(BallStepResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void Update(Entity golfBall, Vector2 impactVelocity, float roughLandResistance)
		{
			throw null;
		}

		// Token: 0x06004138 RID: 16696 RVA: 0x0002DA85 File Offset: 0x0002BC85
		[global::Cpp2ILInjected.Token(Token = "0x6004BC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x8AEF94", Offset = "0x8AEF94", Length = "0x3A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GolfHelper), Member = "DrawPredictionLine", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteViewMatrix), Member = "get_TransformationMatrix", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BasicDebugDrawer), Member = "Begin", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_UnscaledPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FancyGolfPredictionLine), Member = "GetSectionLength", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref float),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FancyGolfPredictionLine), Member = "GetPosition", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FancyGolfPredictionLine), Member = "GetColor2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FancyGolfPredictionLine), Member = "GetScale", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BasicDebugDrawer), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public void Draw(Camera camera, SpriteBatch spriteBatch, float chargeProgress)
		{
			throw null;
		}

		// Token: 0x06004139 RID: 16697 RVA: 0x0002DA88 File Offset: 0x0002BC88
		[global::Cpp2ILInjected.Token(Token = "0x6004BC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B1774", Offset = "0x8B1774", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private Color GetColor(float travelledLength)
		{
			throw null;
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x0002DA8B File Offset: 0x0002BC8B
		[global::Cpp2ILInjected.Token(Token = "0x6004BC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B1544", Offset = "0x8B1544", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FancyGolfPredictionLine), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(SpriteBatch),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private Color GetColor2(float index)
		{
			throw null;
		}

		// Token: 0x0600413B RID: 16699 RVA: 0x0002DA8E File Offset: 0x0002BC8E
		[global::Cpp2ILInjected.Token(Token = "0x6004BCA")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B1688", Offset = "0x8B1688", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FancyGolfPredictionLine), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(SpriteBatch),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private float GetScale(float travelledLength)
		{
			throw null;
		}

		// Token: 0x0600413C RID: 16700 RVA: 0x0002DA91 File Offset: 0x0002BC91
		[global::Cpp2ILInjected.Token(Token = "0x6004BCB")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B128C", Offset = "0x8B128C", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FancyGolfPredictionLine), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(SpriteBatch),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void GetSectionLength(int startIndex, out float length, out float rotation)
		{
			throw null;
		}

		// Token: 0x0600413D RID: 16701 RVA: 0x0002DA94 File Offset: 0x0002BC94
		[global::Cpp2ILInjected.Token(Token = "0x6004BCC")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B1410", Offset = "0x8B1410", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FancyGolfPredictionLine), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(SpriteBatch),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private Vector2 GetPosition(float indexProgress)
		{
			throw null;
		}

		// Token: 0x04006DA0 RID: 28064
		[global::Cpp2ILInjected.Token(Token = "0x4008605")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly List<Vector2> _positions;

		// Token: 0x04006DA1 RID: 28065
		[global::Cpp2ILInjected.Token(Token = "0x4008606")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly Entity _entity;

		// Token: 0x04006DA2 RID: 28066
		[global::Cpp2ILInjected.Token(Token = "0x4008607")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly int _iterations;

		// Token: 0x04006DA3 RID: 28067
		[global::Cpp2ILInjected.Token(Token = "0x4008608")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly Color[] _colors;

		// Token: 0x04006DA4 RID: 28068
		[global::Cpp2ILInjected.Token(Token = "0x4008609")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly BasicDebugDrawer _drawer;

		// Token: 0x04006DA5 RID: 28069
		[global::Cpp2ILInjected.Token(Token = "0x400860A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private float _time;

		// Token: 0x02000A6D RID: 2669
		[global::Cpp2ILInjected.Token(Token = "0x2000A08")]
		private class PredictionEntity : Entity
		{
			// Token: 0x060050BB RID: 20667 RVA: 0x000303CE File Offset: 0x0002E5CE
			[global::Cpp2ILInjected.Token(Token = "0x6004BCD")]
			[global::Cpp2ILInjected.Address(RVA = "0x8B1944", Offset = "0x8B1944", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FancyGolfPredictionLine), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = ".ctor", ReturnType = typeof(void))]
			public PredictionEntity()
			{
				throw null;
			}
		}
	}
}
