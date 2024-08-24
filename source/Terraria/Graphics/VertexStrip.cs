using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Unity.IL2CPP.CompilerServices;

namespace Terraria.Graphics
{
	// Token: 0x020004E8 RID: 1256
	[global::Cpp2ILInjected.Token(Token = "0x2000740")]
	public class VertexStrip
	{
		// Token: 0x060036CC RID: 14028 RVA: 0x0002BCA9 File Offset: 0x00029EA9
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6003D36")]
		[global::Cpp2ILInjected.Address(RVA = "0x149EBB4", Offset = "0x149EBB4", Length = "0x258")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2Array_10), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Resize", MemberTypeParameters = new object[] { typeof(VertexStrip.CustomVertexInfo) }, MemberParameters = new object[]
		{
			typeof(ref VertexStrip.CustomVertexInfo[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2Array_10), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatArray_10), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "WrapAngle", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexStrip), Member = "AddVertex", MemberParameters = new object[]
		{
			typeof(VertexStrip.StripColorFunction),
			typeof(VertexStrip.StripHalfWidthFunction),
			typeof(Vector2),
			typeof(float),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexStrip), Member = "PrepareIndices", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void PrepareStrip(ref Vector2Array_10 positions, ref FloatArray_10 rotations, VertexStrip.StripColorFunction colorFunction, VertexStrip.StripHalfWidthFunction widthFunction, Vector2 offsetForAllPositions = default(Vector2), int? expectedVertexPairsAmount = null, bool includeBacksides = false)
		{
			throw null;
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x0002BCAC File Offset: 0x00029EAC
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6003D37")]
		[global::Cpp2ILInjected.Address(RVA = "0x149AFF4", Offset = "0x149AFF4", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FinalFractalHelper), Member = "Draw", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmpressBladeDrawer), Member = "Draw", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Resize", MemberTypeParameters = new object[] { typeof(VertexStrip.CustomVertexInfo) }, MemberParameters = new object[]
		{
			typeof(ref VertexStrip.CustomVertexInfo[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexStrip), Member = "AddVertex", MemberParameters = new object[]
		{
			typeof(VertexStrip.StripColorFunction),
			typeof(VertexStrip.StripHalfWidthFunction),
			typeof(Vector2),
			typeof(float),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexStrip), Member = "PrepareIndices", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void PrepareStrip(Vector2[] positions, float[] rotations, VertexStrip.StripColorFunction colorFunction, VertexStrip.StripHalfWidthFunction widthFunction, Vector2 offsetForAllPositions = default(Vector2), int? expectedVertexPairsAmount = null, bool includeBacksides = false)
		{
			throw null;
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x0002BCAF File Offset: 0x00029EAF
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6003D38")]
		[global::Cpp2ILInjected.Address(RVA = "0x149F0E8", Offset = "0x149F0E8", Length = "0x6D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2Array_10), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2Array_10), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatArray_10), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "WrapAngle", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "CatmullRom", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DirectionTo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<float>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexStrip), Member = "AddVertex", MemberParameters = new object[]
		{
			typeof(VertexStrip.StripColorFunction),
			typeof(VertexStrip.StripHalfWidthFunction),
			typeof(Vector2),
			typeof(float),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexStrip), Member = "PrepareIndices", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public void PrepareStripWithProceduralPadding(ref Vector2Array_10 positions, ref FloatArray_10 rotations, VertexStrip.StripColorFunction colorFunction, VertexStrip.StripHalfWidthFunction widthFunction, Vector2 offsetForAllPositions = default(Vector2), bool includeBacksides = false)
		{
			throw null;
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x0002BCB2 File Offset: 0x00029EB2
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6003D39")]
		[global::Cpp2ILInjected.Address(RVA = "0x149D1A4", Offset = "0x149D1A4", Length = "0x6AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MagicMissileDrawer), Member = "Draw", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightDiscDrawer), Member = "Draw", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlameLashDrawer), Member = "Draw", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RainbowRodDrawer), Member = "Draw", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "WrapAngle", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "CatmullRom", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DirectionTo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<float>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexStrip), Member = "AddVertex", MemberParameters = new object[]
		{
			typeof(VertexStrip.StripColorFunction),
			typeof(VertexStrip.StripHalfWidthFunction),
			typeof(Vector2),
			typeof(float),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexStrip), Member = "PrepareIndices", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public void PrepareStripWithProceduralPadding(Vector2[] positions, float[] rotations, VertexStrip.StripColorFunction colorFunction, VertexStrip.StripHalfWidthFunction widthFunction, Vector2 offsetForAllPositions = default(Vector2), bool includeBacksides = false)
		{
			throw null;
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x0002BCB5 File Offset: 0x00029EB5
		[global::Cpp2ILInjected.Token(Token = "0x6003D3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x149EFF8", Offset = "0x149EFF8", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexStrip), Member = "PrepareStrip", MemberParameters = new object[]
		{
			typeof(ref Vector2Array_10),
			typeof(ref FloatArray_10),
			typeof(VertexStrip.StripColorFunction),
			typeof(VertexStrip.StripHalfWidthFunction),
			typeof(Vector2),
			typeof(int?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexStrip), Member = "PrepareStrip", MemberParameters = new object[]
		{
			typeof(Vector2[]),
			typeof(float[]),
			typeof(VertexStrip.StripColorFunction),
			typeof(VertexStrip.StripHalfWidthFunction),
			typeof(Vector2),
			typeof(int?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexStrip), Member = "PrepareStripWithProceduralPadding", MemberParameters = new object[]
		{
			typeof(ref Vector2Array_10),
			typeof(ref FloatArray_10),
			typeof(VertexStrip.StripColorFunction),
			typeof(VertexStrip.StripHalfWidthFunction),
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexStrip), Member = "PrepareStripWithProceduralPadding", MemberParameters = new object[]
		{
			typeof(Vector2[]),
			typeof(float[]),
			typeof(VertexStrip.StripColorFunction),
			typeof(VertexStrip.StripHalfWidthFunction),
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Resize", MemberTypeParameters = new object[] { typeof(short) }, MemberParameters = new object[]
		{
			typeof(ref short[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void PrepareIndices(int vertexPaidsAdded)
		{
			throw null;
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x0002BCB8 File Offset: 0x00029EB8
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6003D3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x149EE0C", Offset = "0x149EE0C", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexStrip), Member = "PrepareStrip", MemberParameters = new object[]
		{
			typeof(ref Vector2Array_10),
			typeof(ref FloatArray_10),
			typeof(VertexStrip.StripColorFunction),
			typeof(VertexStrip.StripHalfWidthFunction),
			typeof(Vector2),
			typeof(int?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexStrip), Member = "PrepareStrip", MemberParameters = new object[]
		{
			typeof(Vector2[]),
			typeof(float[]),
			typeof(VertexStrip.StripColorFunction),
			typeof(VertexStrip.StripHalfWidthFunction),
			typeof(Vector2),
			typeof(int?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexStrip), Member = "PrepareStripWithProceduralPadding", MemberParameters = new object[]
		{
			typeof(ref Vector2Array_10),
			typeof(ref FloatArray_10),
			typeof(VertexStrip.StripColorFunction),
			typeof(VertexStrip.StripHalfWidthFunction),
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexStrip), Member = "PrepareStripWithProceduralPadding", MemberParameters = new object[]
		{
			typeof(Vector2[]),
			typeof(float[]),
			typeof(VertexStrip.StripColorFunction),
			typeof(VertexStrip.StripHalfWidthFunction),
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Resize", MemberTypeParameters = new object[] { typeof(VertexStrip.CustomVertexInfo) }, MemberParameters = new object[]
		{
			typeof(ref VertexStrip.CustomVertexInfo[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void AddVertex(VertexStrip.StripColorFunction colorFunction, VertexStrip.StripHalfWidthFunction widthFunction, Vector2 pos, float rot, int indexOnVertexArray, float progressOnStrip)
		{
			throw null;
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x0002BCBB File Offset: 0x00029EBB
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6003D3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x149B1FC", Offset = "0x149B1FC", Length = "0x318")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FinalFractalHelper), Member = "Draw", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmpressBladeDrawer), Member = "Draw", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MagicMissileDrawer), Member = "Draw", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightDiscDrawer), Member = "Draw", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlameLashDrawer), Member = "Draw", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RainbowRodDrawer), Member = "Draw", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDeviceManager), Member = "get_GraphicsDevice", ReturnType = typeof(GraphicsDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void DrawTrail(bool includeBacksides)
		{
			throw null;
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x0002BCBE File Offset: 0x00029EBE
		[global::Cpp2ILInjected.Token(Token = "0x6003D3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x149BE34", Offset = "0x149BE34", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FinalFractalHelper), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmpressBladeDrawer), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MagicMissileDrawer), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightDiscDrawer), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlameLashDrawer), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RainbowRodDrawer), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<float>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public VertexStrip()
		{
			throw null;
		}

		// Token: 0x0400673A RID: 26426
		[global::Cpp2ILInjected.Token(Token = "0x4007C1F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private VertexStrip.CustomVertexInfo[] _vertices;

		// Token: 0x0400673B RID: 26427
		[global::Cpp2ILInjected.Token(Token = "0x4007C20")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _vertexAmountCurrentlyMaintained;

		// Token: 0x0400673C RID: 26428
		[global::Cpp2ILInjected.Token(Token = "0x4007C21")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private short[] _indices;

		// Token: 0x0400673D RID: 26429
		[global::Cpp2ILInjected.Token(Token = "0x4007C22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _indicesAmountCurrentlyMaintained;

		// Token: 0x0400673E RID: 26430
		[global::Cpp2ILInjected.Token(Token = "0x4007C23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private List<Vector2> _temporaryPositionsCache;

		// Token: 0x0400673F RID: 26431
		[global::Cpp2ILInjected.Token(Token = "0x4007C24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private List<float> _temporaryRotationsCache;

		// Token: 0x02000965 RID: 2405
		// (Invoke) Token: 0x06004D45 RID: 19781
		[global::Cpp2ILInjected.Token(Token = "0x2000741")]
		public delegate void StripColorFunction(float progressOnStrip, out Color col);

		// Token: 0x02000966 RID: 2406
		// (Invoke) Token: 0x06004D49 RID: 19785
		[global::Cpp2ILInjected.Token(Token = "0x2000742")]
		public delegate float StripHalfWidthFunction(float progressOnStrip);

		// Token: 0x02000967 RID: 2407
		[global::Cpp2ILInjected.Token(Token = "0x2000743")]
		private struct CustomVertexInfo
		{
			// Token: 0x06004D4C RID: 19788 RVA: 0x0002FA4D File Offset: 0x0002DC4D
			[global::Cpp2ILInjected.Token(Token = "0x6003D46")]
			[global::Cpp2ILInjected.Address(RVA = "0x149F958", Offset = "0x149F958", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public CustomVertexInfo(Vector2 position, Color color, Vector3 texCoord)
			{
				throw null;
			}

			// Token: 0x04008B9B RID: 35739
			[global::Cpp2ILInjected.Token(Token = "0x4007C25")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Vector2 Position;

			// Token: 0x04008B9C RID: 35740
			[global::Cpp2ILInjected.Token(Token = "0x4007C26")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public Color Color;

			// Token: 0x04008B9D RID: 35741
			[global::Cpp2ILInjected.Token(Token = "0x4007C27")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public Vector3 TexCoord;
		}
	}
}
