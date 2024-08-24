using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002C2 RID: 706
	[global::Cpp2ILInjected.Token(Token = "0x200038D")]
	public class SpriteBatcher
	{
		// Token: 0x060016CF RID: 5839 RVA: 0x00025ED7 File Offset: 0x000240D7
		[global::Cpp2ILInjected.Token(Token = "0x600183F")]
		[global::Cpp2ILInjected.Address(RVA = "0xABD890", Offset = "0xABD890", Length = "0x3F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector3>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector2>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector4>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Color32>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<SubMeshDescriptor>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "InitialiseIndexBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		public SpriteBatcher(GraphicsDevice device)
		{
			throw null;
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00025EDA File Offset: 0x000240DA
		[global::Cpp2ILInjected.Token(Token = "0x6001840")]
		[global::Cpp2ILInjected.Address(RVA = "0xABDCB4", Offset = "0xABDCB4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private void InitialiseIndexBuffer()
		{
			throw null;
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x00025EDD File Offset: 0x000240DD
		[global::Cpp2ILInjected.Token(Token = "0x1700030E")]
		public int BatchCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001841")]
			[global::Cpp2ILInjected.Address(RVA = "0xABDD1C", Offset = "0xABDD1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00025EE0 File Offset: 0x000240E0
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6001842")]
		[global::Cpp2ILInjected.Address(RVA = "0xABDD24", Offset = "0xABDD24", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Resize", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(ref object[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public SpriteBatchItem CreateBatchItem()
		{
			throw null;
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x00025EE3 File Offset: 0x000240E3
		[global::Cpp2ILInjected.Token(Token = "0x6001843")]
		[global::Cpp2ILInjected.Address(RVA = "0xABDE50", Offset = "0xABDE50", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void GetBatchItemList(int id, out SpriteBatchItemList result)
		{
			throw null;
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x00025EE6 File Offset: 0x000240E6
		[global::Cpp2ILInjected.Token(Token = "0x6001844")]
		[global::Cpp2ILInjected.Address(RVA = "0xABDF10", Offset = "0xABDF10", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "GetBatchItemList", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref SpriteBatchItemList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Resize", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(ref object[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void CreateBatchItemList(out SpriteBatchItemList item)
		{
			throw null;
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00025EE9 File Offset: 0x000240E9
		[global::Cpp2ILInjected.Token(Token = "0x6001845")]
		[global::Cpp2ILInjected.Address(RVA = "0xABE044", Offset = "0xABE044", Length = "0x4D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 32)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "RenderVertexArrayWithSubMeshes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "AddSubMesh", MemberParameters = new object[]
		{
			typeof(Effect),
			typeof(Texture2D),
			typeof(EffectPass)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public void DrawImmediateBatch(Effect effect)
		{
			throw null;
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x00025EEC File Offset: 0x000240EC
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6001846")]
		[global::Cpp2ILInjected.Address(RVA = "0xABEBAC", Offset = "0xABEBAC", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "RenderVertexArrayWithSubMeshes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void FlushBatches()
		{
			throw null;
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x00025EEF File Offset: 0x000240EF
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6001847")]
		[global::Cpp2ILInjected.Address(RVA = "0xABEDD0", Offset = "0xABEDD0", Length = "0x424")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "AddSubMesh", MemberParameters = new object[]
		{
			typeof(Effect),
			typeof(Texture2D),
			typeof(EffectPass)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatcher), Member = "RenderVertexArrayWithSubMeshes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public void DrawBatch(SpriteSortMode sortMode, Effect effect, bool overloadTranform, bool deffered, SpriteBatchItem overrideFirstItem = null)
		{
			throw null;
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x00025EF2 File Offset: 0x000240F2
		[global::Cpp2ILInjected.Token(Token = "0x6001848")]
		[global::Cpp2ILInjected.Address(RVA = "0xABF1F4", Offset = "0xABF1F4", Length = "0x318")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "DrawGeometry", MemberParameters = new object[]
		{
			typeof(List<Vector3>),
			typeof(List<Vector2>),
			typeof(List<Vector4>),
			typeof(List<Color32>),
			typeof(List<int>),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "GetEnumerator", ReturnType = typeof(EffectPassCollection.Enumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void RenderVertexArray(Effect effect, Texture2D texture, EffectPass overloadEffectPass, Vector3 position, Vector3 scale)
		{
			throw null;
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00025EF5 File Offset: 0x000240F5
		[global::Cpp2ILInjected.Token(Token = "0x6001849")]
		[global::Cpp2ILInjected.Address(RVA = "0xABE608", Offset = "0xABE608", Length = "0x5A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "DrawBatch", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(Effect),
			typeof(bool),
			typeof(bool),
			typeof(SpriteBatchItem)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<SubMeshDescriptor>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SubMeshDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(MeshTopology)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "GetMaterial", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "GetEnumerator", ReturnType = typeof(EffectPassCollection.Enumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void AddSubMesh(Effect effect, Texture2D texture, EffectPass overloadEffectPass)
		{
			throw null;
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x00025EF8 File Offset: 0x000240F8
		[global::Cpp2ILInjected.Token(Token = "0x600184A")]
		[global::Cpp2ILInjected.Address(RVA = "0xABE514", Offset = "0xABE514", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "DrawImmediateBatch", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "FlushBatches", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "DrawBatch", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(Effect),
			typeof(bool),
			typeof(bool),
			typeof(SpriteBatchItem)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "DrawGeometryWithSubMeshes", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void RenderVertexArrayWithSubMeshes(int vertexCount, int indexCount, Vector3 position, Vector3 scale)
		{
			throw null;
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00025EFB File Offset: 0x000240FB
		[global::Cpp2ILInjected.Token(Token = "0x600184B")]
		[global::Cpp2ILInjected.Address(RVA = "0xABF50C", Offset = "0xABF50C", Length = "0x328")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "DrawGeometry", MemberParameters = new object[]
		{
			typeof(SpriteBatcher.VertexData[]),
			typeof(short[]),
			typeof(int),
			typeof(int),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "GetEnumerator", ReturnType = typeof(EffectPassCollection.Enumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void RenderVertexArray2(Effect effect, Texture2D texture, EffectPass overloadEffectPass, int vertexCount, int indexCount, Vector3 position, Vector3 scale)
		{
			throw null;
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00025EFE File Offset: 0x000240FE
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600184C")]
		[global::Cpp2ILInjected.Address(RVA = "0xABF834", Offset = "0xABF834", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexAttributeDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(VertexAttribute),
			typeof(VertexAttributeFormat),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static SpriteBatcher()
		{
			throw null;
		}

		// Token: 0x04002027 RID: 8231
		[global::Cpp2ILInjected.Token(Token = "0x400266D")]
		private const int InitialBatchSize = 256;

		// Token: 0x04002028 RID: 8232
		[global::Cpp2ILInjected.Token(Token = "0x400266E")]
		private const int MaxBatchSize = 5461;

		// Token: 0x04002029 RID: 8233
		[global::Cpp2ILInjected.Token(Token = "0x400266F")]
		private const int InitialVertexArraySize = 256;

		// Token: 0x0400202A RID: 8234
		[global::Cpp2ILInjected.Token(Token = "0x4002670")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public SpriteBatchItem[] _batchItemList;

		// Token: 0x0400202B RID: 8235
		[global::Cpp2ILInjected.Token(Token = "0x4002671")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int _batchItemCount;

		// Token: 0x0400202C RID: 8236
		[global::Cpp2ILInjected.Token(Token = "0x4002672")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int _lastBatchListId;

		// Token: 0x0400202D RID: 8237
		[global::Cpp2ILInjected.Token(Token = "0x4002673")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public SpriteBatchItemList _lastBatchList;

		// Token: 0x0400202E RID: 8238
		[global::Cpp2ILInjected.Token(Token = "0x4002674")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Dictionary<int, SpriteBatchItemList> _activeBatchLists;

		// Token: 0x0400202F RID: 8239
		[global::Cpp2ILInjected.Token(Token = "0x4002675")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private SpriteBatchItemList[] _batchItemListList;

		// Token: 0x04002030 RID: 8240
		[global::Cpp2ILInjected.Token(Token = "0x4002676")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int _batchItemListCount;

		// Token: 0x04002031 RID: 8241
		[global::Cpp2ILInjected.Token(Token = "0x4002677")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly GraphicsDevice _device;

		// Token: 0x04002032 RID: 8242
		[global::Cpp2ILInjected.Token(Token = "0x4002678")]
		private const int maxQuadCount = 8192;

		// Token: 0x04002033 RID: 8243
		[global::Cpp2ILInjected.Token(Token = "0x4002679")]
		private const int maxVerts = 32768;

		// Token: 0x04002034 RID: 8244
		[global::Cpp2ILInjected.Token(Token = "0x400267A")]
		private const int maxIndices = 49152;

		// Token: 0x04002035 RID: 8245
		[global::Cpp2ILInjected.Token(Token = "0x400267B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int _vertexOffset;

		// Token: 0x04002036 RID: 8246
		[global::Cpp2ILInjected.Token(Token = "0x400267C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private int _indexOffset;

		// Token: 0x04002037 RID: 8247
		[global::Cpp2ILInjected.Token(Token = "0x400267D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private int _materialOffset;

		// Token: 0x04002038 RID: 8248
		[global::Cpp2ILInjected.Token(Token = "0x400267E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private SpriteBatcher.VertexData[] vertexData;

		// Token: 0x04002039 RID: 8249
		[global::Cpp2ILInjected.Token(Token = "0x400267F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private short[] indexData;

		// Token: 0x0400203A RID: 8250
		[global::Cpp2ILInjected.Token(Token = "0x4002680")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private List<Vector3> _positions;

		// Token: 0x0400203B RID: 8251
		[global::Cpp2ILInjected.Token(Token = "0x4002681")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private List<Vector2> _uvs;

		// Token: 0x0400203C RID: 8252
		[global::Cpp2ILInjected.Token(Token = "0x4002682")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private List<Vector4> _uv2s;

		// Token: 0x0400203D RID: 8253
		[global::Cpp2ILInjected.Token(Token = "0x4002683")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private List<Color32> _colours;

		// Token: 0x0400203E RID: 8254
		[global::Cpp2ILInjected.Token(Token = "0x4002684")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private List<int> _indices;

		// Token: 0x0400203F RID: 8255
		[global::Cpp2ILInjected.Token(Token = "0x4002685")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private List<Material> _immediateMaterials;

		// Token: 0x04002040 RID: 8256
		[global::Cpp2ILInjected.Token(Token = "0x4002686")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private List<int> _immediateMaterialsOffsets;

		// Token: 0x04002041 RID: 8257
		[global::Cpp2ILInjected.Token(Token = "0x4002687")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private List<SubMeshDescriptor> _submeshList;

		// Token: 0x04002042 RID: 8258
		[global::Cpp2ILInjected.Token(Token = "0x4002688")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private List<Material> _submeshListMaterials;

		// Token: 0x04002043 RID: 8259
		[global::Cpp2ILInjected.Token(Token = "0x4002689")]
		private static VertexAttributeDescriptor[] vertexDescription;

		// Token: 0x0200082A RID: 2090
		[global::Cpp2ILInjected.Token(Token = "0x200038E")]
		public struct VertexData
		{
			// Token: 0x04007E04 RID: 32260
			[global::Cpp2ILInjected.Token(Token = "0x400268A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Vector2 Position;

			// Token: 0x04007E05 RID: 32261
			[global::Cpp2ILInjected.Token(Token = "0x400268B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public Color32 Color;

			// Token: 0x04007E06 RID: 32262
			[global::Cpp2ILInjected.Token(Token = "0x400268C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public Vector2 TextureCoordinate;
		}
	}
}
