using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using UnityEngine;
using UnityEngine.Rendering;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002AA RID: 682
	[global::Cpp2ILInjected.Token(Token = "0x2000370")]
	public class GeometryBufferInstance
	{
		// Token: 0x06001580 RID: 5504 RVA: 0x00025B08 File Offset: 0x00023D08
		[global::Cpp2ILInjected.Token(Token = "0x60016E8")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAB81C", Offset = "0xAAB81C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = "LoadState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaterialBuffer), Member = "DestroyMaterials", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SetActive(int index)
		{
			throw null;
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x00025B0B File Offset: 0x00023D0B
		[global::Cpp2ILInjected.Token(Token = "0x170002B0")]
		private static GeometryBufferInstanceList[] bufferList
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016E9")]
			[global::Cpp2ILInjected.Address(RVA = "0xAAB884", Offset = "0xAAB884", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "ClearBuffers", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "EndBuffer", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "GetBatchInstance", ReturnType = typeof(GeometryBufferInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "GetInstance", MemberParameters = new object[]
			{
				typeof(SpriteBatcher.VertexData[]),
				typeof(short[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(GeometryBufferInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "GetInstance", MemberParameters = new object[]
			{
				typeof(List<Vector3>),
				typeof(List<Vector2>),
				typeof(List<Vector4>),
				typeof(List<Color32>),
				typeof(List<int>)
			}, ReturnType = typeof(GeometryBufferInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "ClearInstances", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x00025B0E File Offset: 0x00023D0E
		[global::Cpp2ILInjected.Token(Token = "0x170002B1")]
		private static List<MaterialBuffer.MaterialEntry>[] bufferMaterialList
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016EA")]
			[global::Cpp2ILInjected.Address(RVA = "0xAAB8E0", Offset = "0xAAB8E0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "ClearBuffers", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "BeginBuffer", MemberParameters = new object[]
			{
				typeof(GeometryBufferInstance.BatchBuffer),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x00025B11 File Offset: 0x00023D11
		[global::Cpp2ILInjected.Token(Token = "0x170002B2")]
		private static Vector2[] bufferListPositions
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016EB")]
			[global::Cpp2ILInjected.Address(RVA = "0xAAB93C", Offset = "0xAAB93C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "BeginBuffer", MemberParameters = new object[]
			{
				typeof(GeometryBufferInstance.BatchBuffer),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "EndBuffer", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "ClearInstances", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x00025B14 File Offset: 0x00023D14
		[global::Cpp2ILInjected.Token(Token = "0x170002B3")]
		private static float[] bufferZoom
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016EC")]
			[global::Cpp2ILInjected.Address(RVA = "0xAAB998", Offset = "0xAAB998", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "InvalidateBuffers", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "BeginBuffer", MemberParameters = new object[]
			{
				typeof(GeometryBufferInstance.BatchBuffer),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "ClearInstances", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x00025B17 File Offset: 0x00023D17
		[global::Cpp2ILInjected.Token(Token = "0x170002B4")]
		private static bool[] bufferUseAntiGrav
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016ED")]
			[global::Cpp2ILInjected.Address(RVA = "0xAAB9F4", Offset = "0xAAB9F4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "BeginBuffer", MemberParameters = new object[]
			{
				typeof(GeometryBufferInstance.BatchBuffer),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x00025B1A File Offset: 0x00023D1A
		[global::Cpp2ILInjected.Token(Token = "0x170002B5")]
		private static GeometryBufferInstanceList list
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016EE")]
			[global::Cpp2ILInjected.Address(RVA = "0xAABA50", Offset = "0xAABA50", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "GetBatchInstance", ReturnType = typeof(GeometryBufferInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "GetInstance", MemberParameters = new object[]
			{
				typeof(SpriteBatcher.VertexData[]),
				typeof(short[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(GeometryBufferInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "GetInstance", MemberParameters = new object[]
			{
				typeof(List<Vector3>),
				typeof(List<Vector2>),
				typeof(List<Vector4>),
				typeof(List<Color32>),
				typeof(List<int>)
			}, ReturnType = typeof(GeometryBufferInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "FinaliseInstances", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "ClearInstances", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x00025B1D File Offset: 0x00023D1D
		[global::Cpp2ILInjected.Token(Token = "0x170002B6")]
		private static GeometryBufferInstanceList list_8
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016EF")]
			[global::Cpp2ILInjected.Address(RVA = "0xAABAAC", Offset = "0xAABAAC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "GetBatchInstance", ReturnType = typeof(GeometryBufferInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "GetInstance", MemberParameters = new object[]
			{
				typeof(SpriteBatcher.VertexData[]),
				typeof(short[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(GeometryBufferInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "GetInstance", MemberParameters = new object[]
			{
				typeof(List<Vector3>),
				typeof(List<Vector2>),
				typeof(List<Vector4>),
				typeof(List<Color32>),
				typeof(List<int>)
			}, ReturnType = typeof(GeometryBufferInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "FinaliseInstances", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "ClearInstances", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06001588 RID: 5512 RVA: 0x00025B20 File Offset: 0x00023D20
		[global::Cpp2ILInjected.Token(Token = "0x170002B7")]
		private static GeometryBufferInstanceList list_10
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016F0")]
			[global::Cpp2ILInjected.Address(RVA = "0xAABB08", Offset = "0xAABB08", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "GetBatchInstance", ReturnType = typeof(GeometryBufferInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "GetInstance", MemberParameters = new object[]
			{
				typeof(SpriteBatcher.VertexData[]),
				typeof(short[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(GeometryBufferInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "GetInstance", MemberParameters = new object[]
			{
				typeof(List<Vector3>),
				typeof(List<Vector2>),
				typeof(List<Vector4>),
				typeof(List<Color32>),
				typeof(List<int>)
			}, ReturnType = typeof(GeometryBufferInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "FinaliseInstances", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "ClearInstances", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x00025B23 File Offset: 0x00023D23
		[global::Cpp2ILInjected.Token(Token = "0x60016F1")]
		[global::Cpp2ILInjected.Address(RVA = "0xAABB64", Offset = "0xAABB64", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "BeginBuffer", MemberParameters = new object[]
		{
			typeof(GeometryBufferInstance.BatchBuffer),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "ClearInstances", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_bufferMaterialList", ReturnType = typeof(List<MaterialBuffer.MaterialEntry>[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer.MaterialEntry), Member = "Relase", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_bufferList", ReturnType = typeof(GeometryBufferInstanceList[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstanceList), Member = "ClearInstances", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void ClearBuffers()
		{
			throw null;
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x00025B26 File Offset: 0x00023D26
		[global::Cpp2ILInjected.Token(Token = "0x60016F2")]
		[global::Cpp2ILInjected.Address(RVA = "0xAABEB0", Offset = "0xAABEB0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoLightTiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_bufferZoom", ReturnType = typeof(float[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void InvalidateBuffers()
		{
			throw null;
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00025B29 File Offset: 0x00023D29
		[global::Cpp2ILInjected.Token(Token = "0x60016F3")]
		[global::Cpp2ILInjected.Address(RVA = "0xAABF2C", Offset = "0xAABF2C", Length = "0x59C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DistortionRenderTargetManager), Member = "BeginRenderTarget", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_Tiles_Solid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_Tiles_NonSolid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_WallsAndBlacks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "FlushBatches", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_bufferZoom", ReturnType = typeof(float[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_bufferListPositions", ReturnType = typeof(Vector2[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "ClearBuffers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_bufferUseAntiGrav", ReturnType = typeof(bool[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_renderCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_bufferMaterialList", ReturnType = typeof(List<MaterialBuffer.MaterialEntry>[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer), Member = "SetUsedMaterialList", MemberParameters = new object[] { typeof(List<MaterialBuffer.MaterialEntry>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer), Member = "ClearInstances", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		public static bool BeginBuffer(GeometryBufferInstance.BatchBuffer bufferListId, int renderCountRefresh)
		{
			throw null;
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00025B2C File Offset: 0x00023D2C
		[global::Cpp2ILInjected.Token(Token = "0x60016F4")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAC8F8", Offset = "0xAAC8F8", Length = "0x660")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DistortionRenderTargetManager), Member = "EndRenderTarget", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_Tiles_Solid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_Tiles_NonSolid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_WallsAndBlacks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "FlushBatches", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_bufferList", ReturnType = typeof(GeometryBufferInstanceList[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstanceList), Member = "FinaliseInstances", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_bufferListPositions", ReturnType = typeof(Vector2[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_caveParallax", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstanceList), Member = "SetOffset", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_WaveQuality", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaterRenderTargetManager), Member = "get_Instance", ReturnType = typeof(WaterRenderTargetManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaterRenderTargetManager), Member = "UpdateRenderTarget", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer), Member = "SetUsedMaterialList", MemberParameters = new object[] { typeof(List<MaterialBuffer.MaterialEntry>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		public static void EndBuffer()
		{
			throw null;
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00025B2F File Offset: 0x00023D2F
		[global::Cpp2ILInjected.Token(Token = "0x60016F5")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAD084", Offset = "0xAAD084", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "DrawGeometryWithSubMeshes", MemberParameters = new object[]
		{
			typeof(SpriteBatcher.VertexData[]),
			typeof(short[]),
			typeof(int),
			typeof(int),
			typeof(Vector3),
			typeof(Vector3),
			typeof(List<Material>),
			typeof(List<SubMeshDescriptor>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_bufferList", ReturnType = typeof(GeometryBufferInstanceList[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_list_10", ReturnType = typeof(GeometryBufferInstanceList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_list_8", ReturnType = typeof(GeometryBufferInstanceList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_list", ReturnType = typeof(GeometryBufferInstanceList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstanceList), Member = "GetBatchInstance", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GeometryBufferInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static GeometryBufferInstance GetBatchInstance()
		{
			throw null;
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x00025B32 File Offset: 0x00023D32
		[global::Cpp2ILInjected.Token(Token = "0x60016F6")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAD3F8", Offset = "0xAAD3F8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "DrawGeometryWithSubMeshes", MemberParameters = new object[]
		{
			typeof(SpriteBatcher.VertexData[]),
			typeof(short[]),
			typeof(int),
			typeof(int),
			typeof(Vector3),
			typeof(Vector3),
			typeof(List<Material>),
			typeof(List<SubMeshDescriptor>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void IncrementBufferOffset()
		{
			throw null;
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x00025B35 File Offset: 0x00023D35
		[global::Cpp2ILInjected.Token(Token = "0x60016F7")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAD458", Offset = "0xAAD458", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "DrawGeometry", MemberParameters = new object[]
		{
			typeof(SpriteBatcher.VertexData[]),
			typeof(short[]),
			typeof(int),
			typeof(int),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_bufferList", ReturnType = typeof(GeometryBufferInstanceList[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_list_10", ReturnType = typeof(GeometryBufferInstanceList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_list_8", ReturnType = typeof(GeometryBufferInstanceList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_list", ReturnType = typeof(GeometryBufferInstanceList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstanceList), Member = "GetInstance", MemberParameters = new object[]
		{
			typeof(SpriteBatcher.VertexData[]),
			typeof(short[]),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(GeometryBufferInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static GeometryBufferInstance GetInstance(SpriteBatcher.VertexData[] vertices, short[] indices, int vertexCount, int indexCount)
		{
			throw null;
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x00025B38 File Offset: 0x00023D38
		[global::Cpp2ILInjected.Token(Token = "0x60016F8")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAD9BC", Offset = "0xAAD9BC", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "DrawGeometry", MemberParameters = new object[]
		{
			typeof(List<Vector3>),
			typeof(List<Vector2>),
			typeof(List<Vector4>),
			typeof(List<Color32>),
			typeof(List<int>),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_bufferList", ReturnType = typeof(GeometryBufferInstanceList[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_list_10", ReturnType = typeof(GeometryBufferInstanceList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_list_8", ReturnType = typeof(GeometryBufferInstanceList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_list", ReturnType = typeof(GeometryBufferInstanceList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstanceList), Member = "GetInstance", MemberParameters = new object[]
		{
			typeof(List<Vector3>),
			typeof(List<Vector2>),
			typeof(List<Vector4>),
			typeof(List<Color32>),
			typeof(List<int>),
			typeof(int)
		}, ReturnType = typeof(GeometryBufferInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static GeometryBufferInstance GetInstance(List<Vector3> positions, List<Vector2> uvs, List<Vector4> uv2s, List<Color32> colours, List<int> indices)
		{
			throw null;
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x00025B3B File Offset: 0x00023D3B
		[global::Cpp2ILInjected.Token(Token = "0x60016F9")]
		[global::Cpp2ILInjected.Address(RVA = "0xAADEB0", Offset = "0xAADEB0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Game), Member = "UnityDraw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_list", ReturnType = typeof(GeometryBufferInstanceList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstanceList), Member = "FinaliseInstances", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_list_8", ReturnType = typeof(GeometryBufferInstanceList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_list_10", ReturnType = typeof(GeometryBufferInstanceList))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void FinaliseInstances()
		{
			throw null;
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00025B3E File Offset: 0x00023D3E
		[global::Cpp2ILInjected.Token(Token = "0x60016FA")]
		[global::Cpp2ILInjected.Address(RVA = "0xAADF10", Offset = "0xAADF10", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Game), Member = "UnityDraw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mapFullscreen", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_bufferZoom", ReturnType = typeof(float[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_bufferListPositions", ReturnType = typeof(Vector2[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "ClearBuffers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_bufferList", ReturnType = typeof(GeometryBufferInstanceList[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstanceList), Member = "FinaliseInstances", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_list", ReturnType = typeof(GeometryBufferInstanceList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstanceList), Member = "ClearInstances", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_list_8", ReturnType = typeof(GeometryBufferInstanceList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "get_list_10", ReturnType = typeof(GeometryBufferInstanceList))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void ClearInstances()
		{
			throw null;
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x00025B41 File Offset: 0x00023D41
		[global::Cpp2ILInjected.Token(Token = "0x60016FB")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAE07C", Offset = "0xAAE07C", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstanceList), Member = "GetBatchInstance", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(GeometryBufferInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstanceList), Member = "GetInstance", MemberParameters = new object[]
		{
			typeof(SpriteBatcher.VertexData[]),
			typeof(short[]),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(GeometryBufferInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstanceList), Member = "GetInstance", MemberParameters = new object[]
		{
			typeof(List<Vector3>),
			typeof(List<Vector2>),
			typeof(List<Vector4>),
			typeof(List<Color32>),
			typeof(List<int>),
			typeof(int)
		}, ReturnType = typeof(GeometryBufferInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_parent", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "MarkDynamic", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "set_name", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "set_bounds", MemberParameters = new object[] { typeof(Bounds) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MeshFilter), Member = "set_mesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public GeometryBufferInstance(Transform parentObject)
		{
			throw null;
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00025B44 File Offset: 0x00023D44
		[global::Cpp2ILInjected.Token(Token = "0x60016FC")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAE264", Offset = "0xAAE264", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "DrawGeometry", MemberParameters = new object[]
		{
			typeof(SpriteBatcher.VertexData[]),
			typeof(short[]),
			typeof(int),
			typeof(int),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "DrawGeometryWithSubMeshes", MemberParameters = new object[]
		{
			typeof(SpriteBatcher.VertexData[]),
			typeof(short[]),
			typeof(int),
			typeof(int),
			typeof(Vector3),
			typeof(Vector3),
			typeof(List<Material>),
			typeof(List<SubMeshDescriptor>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "DrawGeometry", MemberParameters = new object[]
		{
			typeof(List<Vector3>),
			typeof(List<Vector2>),
			typeof(List<Vector4>),
			typeof(List<Color32>),
			typeof(List<int>),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "UnityVec3", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		public void SetPosition(Vector3 position, Vector3 scale)
		{
			throw null;
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00025B47 File Offset: 0x00023D47
		[global::Cpp2ILInjected.Token(Token = "0x60016FD")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAE2CC", Offset = "0xAAE2CC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetPosition(Matrix matrix)
		{
			throw null;
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00025B4A File Offset: 0x00023D4A
		[global::Cpp2ILInjected.Token(Token = "0x60016FE")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAE2D0", Offset = "0xAAE2D0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "get_Translation", ReturnType = typeof(Vector3))]
		public static Vector3 ExtractTranslationFromMatrix(ref Matrix matrix)
		{
			throw null;
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00025B4D File Offset: 0x00023D4D
		[global::Cpp2ILInjected.Token(Token = "0x60016FF")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAE2D8", Offset = "0xAAE2D8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "SetTransformFromMatrix", MemberParameters = new object[]
		{
			typeof(Transform),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "get_Forward", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "get_Up", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static Quaternion ExtractRotationFromMatrix(ref Matrix matrix)
		{
			throw null;
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00025B50 File Offset: 0x00023D50
		[global::Cpp2ILInjected.Token(Token = "0x6001700")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAE334", Offset = "0xAAE334", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "SetTransformFromMatrix", MemberParameters = new object[]
		{
			typeof(Transform),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static Vector3 ExtractScaleFromMatrix(ref Matrix matrix)
		{
			throw null;
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00025B53 File Offset: 0x00023D53
		[global::Cpp2ILInjected.Token(Token = "0x6001701")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAE378", Offset = "0xAAE378", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "get_Translation", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "ExtractRotationFromMatrix", MemberParameters = new object[] { typeof(ref Matrix) }, ReturnType = typeof(Quaternion))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new object[] { typeof(Quaternion) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "ExtractScaleFromMatrix", MemberParameters = new object[] { typeof(ref Matrix) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SetTransformFromMatrix(Transform transform, ref Matrix matrix)
		{
			throw null;
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00025B56 File Offset: 0x00023D56
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001702")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAE40C", Offset = "0xAAE40C", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance.PlayerBatchBuffers), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		static GeometryBufferInstance()
		{
			throw null;
		}

		// Token: 0x04001F56 RID: 8022
		[global::Cpp2ILInjected.Token(Token = "0x400257B")]
		private const int NumPerPartition = 400;

		// Token: 0x04001F57 RID: 8023
		[global::Cpp2ILInjected.Token(Token = "0x400257C")]
		private static GeometryBufferInstance.PlayerBatchBuffers[] playerBatchBuffers;

		// Token: 0x04001F58 RID: 8024
		[global::Cpp2ILInjected.Token(Token = "0x400257D")]
		public static GeometryBufferInstance.PlayerBatchBuffers Active;

		// Token: 0x04001F59 RID: 8025
		[global::Cpp2ILInjected.Token(Token = "0x400257E")]
		private static int[] bufferListOffsets;

		// Token: 0x04001F5A RID: 8026
		[global::Cpp2ILInjected.Token(Token = "0x400257F")]
		private static int BatchBufferList;

		// Token: 0x04001F5B RID: 8027
		[global::Cpp2ILInjected.Token(Token = "0x4002580")]
		private static int _bufferOffest;

		// Token: 0x04001F5C RID: 8028
		[global::Cpp2ILInjected.Token(Token = "0x4002581")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public GameObject _object;

		// Token: 0x04001F5D RID: 8029
		[global::Cpp2ILInjected.Token(Token = "0x4002582")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private MeshFilter _meshFilter;

		// Token: 0x04001F5E RID: 8030
		[global::Cpp2ILInjected.Token(Token = "0x4002583")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Transform _transform;

		// Token: 0x04001F5F RID: 8031
		[global::Cpp2ILInjected.Token(Token = "0x4002584")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public MeshRenderer _meshRenderer;

		// Token: 0x04001F60 RID: 8032
		[global::Cpp2ILInjected.Token(Token = "0x4002585")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public int _offset;

		// Token: 0x04001F61 RID: 8033
		[global::Cpp2ILInjected.Token(Token = "0x4002586")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public Mesh Mesh;

		// Token: 0x04001F62 RID: 8034
		[global::Cpp2ILInjected.Token(Token = "0x4002587")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int meshindex;

		// Token: 0x04001F63 RID: 8035
		[global::Cpp2ILInjected.Token(Token = "0x4002588")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public Mesh Mesh1;

		// Token: 0x02000825 RID: 2085
		[global::Cpp2ILInjected.Token(Token = "0x2000371")]
		public enum BatchBuffer
		{
			// Token: 0x04007DE4 RID: 32228
			[global::Cpp2ILInjected.Token(Token = "0x400258A")]
			BackgroundWater,
			// Token: 0x04007DE5 RID: 32229
			[global::Cpp2ILInjected.Token(Token = "0x400258B")]
			Background,
			// Token: 0x04007DE6 RID: 32230
			[global::Cpp2ILInjected.Token(Token = "0x400258C")]
			Walls,
			// Token: 0x04007DE7 RID: 32231
			[global::Cpp2ILInjected.Token(Token = "0x400258D")]
			TileNonSolid,
			// Token: 0x04007DE8 RID: 32232
			[global::Cpp2ILInjected.Token(Token = "0x400258E")]
			TilesSolid,
			// Token: 0x04007DE9 RID: 32233
			[global::Cpp2ILInjected.Token(Token = "0x400258F")]
			Water,
			// Token: 0x04007DEA RID: 32234
			[global::Cpp2ILInjected.Token(Token = "0x4002590")]
			Distortion,
			// Token: 0x04007DEB RID: 32235
			[global::Cpp2ILInjected.Token(Token = "0x4002591")]
			Count
		}

		// Token: 0x02000826 RID: 2086
		[global::Cpp2ILInjected.Token(Token = "0x2000372")]
		public class PlayerBatchBuffers
		{
			// Token: 0x0600493B RID: 18747 RVA: 0x0002EFCA File Offset: 0x0002D1CA
			[global::Cpp2ILInjected.Token(Token = "0x6001703")]
			[global::Cpp2ILInjected.Address(RVA = "0xAAE5C8", Offset = "0xAAE5C8", Length = "0x7AC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstanceList), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 60)]
			public PlayerBatchBuffers(int index)
			{
				throw null;
			}

			// Token: 0x04007DEC RID: 32236
			[global::Cpp2ILInjected.Token(Token = "0x4002592")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly GeometryBufferInstanceList[] bufferList;

			// Token: 0x04007DED RID: 32237
			[global::Cpp2ILInjected.Token(Token = "0x4002593")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public readonly List<MaterialBuffer.MaterialEntry>[] bufferMaterialList;

			// Token: 0x04007DEE RID: 32238
			[global::Cpp2ILInjected.Token(Token = "0x4002594")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public readonly Vector2[] bufferListPositions;

			// Token: 0x04007DEF RID: 32239
			[global::Cpp2ILInjected.Token(Token = "0x4002595")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public readonly float[] bufferZoom;

			// Token: 0x04007DF0 RID: 32240
			[global::Cpp2ILInjected.Token(Token = "0x4002596")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public readonly bool[] bufferUseAntiGrav;

			// Token: 0x04007DF1 RID: 32241
			[global::Cpp2ILInjected.Token(Token = "0x4002597")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public readonly GeometryBufferInstanceList list;

			// Token: 0x04007DF2 RID: 32242
			[global::Cpp2ILInjected.Token(Token = "0x4002598")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public readonly GeometryBufferInstanceList list_8;

			// Token: 0x04007DF3 RID: 32243
			[global::Cpp2ILInjected.Token(Token = "0x4002599")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			public readonly GeometryBufferInstanceList list_10;

			// Token: 0x04007DF4 RID: 32244
			[global::Cpp2ILInjected.Token(Token = "0x400259A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			public readonly Dictionary<int, MaterialBuffer.MaterialPartition> _availableMaterials;

			// Token: 0x04007DF5 RID: 32245
			[global::Cpp2ILInjected.Token(Token = "0x400259B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			public readonly List<MaterialBuffer.MaterialEntry> _usedMaterialsDefault;

			// Token: 0x04007DF6 RID: 32246
			[global::Cpp2ILInjected.Token(Token = "0x400259C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			public List<MaterialBuffer.MaterialEntry> _usedMaterials;
		}
	}
}
