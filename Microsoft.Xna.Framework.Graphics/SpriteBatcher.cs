using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002C7")]
public class SpriteBatcher
{
	[Cpp2IlInjected.Token(Token = "0x2000821")]
	public struct VertexData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007DF1")]
		public UnityEngine.Vector2 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007DF2")]
		public Color32 Color;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007DF3")]
		public UnityEngine.Vector2 TextureCoordinate;
	}

	[Cpp2IlInjected.Token(Token = "0x4002048")]
	private const int InitialBatchSize = 256;

	[Cpp2IlInjected.Token(Token = "0x4002049")]
	private const int MaxBatchSize = 5461;

	[Cpp2IlInjected.Token(Token = "0x400204A")]
	private const int InitialVertexArraySize = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400204B")]
	public SpriteBatchItem[] _batchItemList;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400204C")]
	public int _batchItemCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400204D")]
	public int _lastBatchListId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400204E")]
	public SpriteBatchItemList _lastBatchList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400204F")]
	public Dictionary<int, SpriteBatchItemList> _activeBatchLists;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4002050")]
	private SpriteBatchItemList[] _batchItemListList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4002051")]
	private int _batchItemListCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4002052")]
	private readonly GraphicsDevice _device;

	[Cpp2IlInjected.Token(Token = "0x4002053")]
	private const int maxQuadCount = 8192;

	[Cpp2IlInjected.Token(Token = "0x4002054")]
	private const int maxVerts = 32768;

	[Cpp2IlInjected.Token(Token = "0x4002055")]
	private const int maxIndices = 49152;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4002056")]
	private int _vertexOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4002057")]
	private int _indexOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4002058")]
	private int _materialOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4002059")]
	private VertexData[] vertexData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400205A")]
	private short[] indexData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400205B")]
	private List<UnityEngine.Vector3> _positions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400205C")]
	private List<UnityEngine.Vector2> _uvs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400205D")]
	private List<UnityEngine.Vector4> _uv2s;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400205E")]
	private List<Color32> _colours;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400205F")]
	private List<int> _indices;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4002060")]
	private List<Material> _immediateMaterials;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4002061")]
	private List<int> _immediateMaterialsOffsets;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4002062")]
	private List<SubMeshDescriptor> _submeshList;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4002063")]
	private List<Material> _submeshListMaterials;

	[Cpp2IlInjected.Token(Token = "0x4002064")]
	private static VertexAttributeDescriptor[] vertexDescription;

	[Cpp2IlInjected.Token(Token = "0x170002E6")]
	public int BatchCount
	{
		[Cpp2IlInjected.Token(Token = "0x6001716")]
		[Cpp2IlInjected.Address(RVA = "0x1547C50", Offset = "0x1547C50", VA = "0x1547C50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001714")]
	[Cpp2IlInjected.Address(RVA = "0x15477F0", Offset = "0x15477F0", VA = "0x15477F0")]
	public SpriteBatcher(GraphicsDevice device)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001715")]
	[Cpp2IlInjected.Address(RVA = "0x1547B68", Offset = "0x1547B68", VA = "0x1547B68")]
	private void InitialiseIndexBuffer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001717")]
	[Cpp2IlInjected.Address(RVA = "0x1547C58", Offset = "0x1547C58", VA = "0x1547C58")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F89C", Offset = "0x38F89C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F89C", Offset = "0x38F89C")]
	public SpriteBatchItem CreateBatchItem()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001718")]
	[Cpp2IlInjected.Address(RVA = "0x1547D80", Offset = "0x1547D80", VA = "0x1547D80")]
	public void GetBatchItemList(int id, out SpriteBatchItemList result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001719")]
	[Cpp2IlInjected.Address(RVA = "0x1547E44", Offset = "0x1547E44", VA = "0x1547E44")]
	public void CreateBatchItemList(out SpriteBatchItemList item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600171A")]
	[Cpp2IlInjected.Address(RVA = "0x1547F70", Offset = "0x1547F70", VA = "0x1547F70")]
	public void DrawImmediateBatch(Effect effect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600171B")]
	[Cpp2IlInjected.Address(RVA = "0x1548C68", Offset = "0x1548C68", VA = "0x1548C68")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F950", Offset = "0x38F950")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38F950", Offset = "0x38F950")]
	public void FlushBatches()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600171C")]
	[Cpp2IlInjected.Address(RVA = "0x1548F68", Offset = "0x1548F68", VA = "0x1548F68")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38FA04", Offset = "0x38FA04")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x38FA04", Offset = "0x38FA04")]
	public void DrawBatch(SpriteSortMode sortMode, Effect effect, bool overloadTranform, bool deffered, [Optional] SpriteBatchItem overrideFirstItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600171D")]
	[Cpp2IlInjected.Address(RVA = "0x1549530", Offset = "0x1549530", VA = "0x1549530")]
	private void RenderVertexArray(Effect effect, Texture2D texture, EffectPass overloadEffectPass, Vector3 position, Vector3 scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600171E")]
	[Cpp2IlInjected.Address(RVA = "0x154879C", Offset = "0x154879C", VA = "0x154879C")]
	private void AddSubMesh(Effect effect, Texture2D texture, EffectPass overloadEffectPass)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600171F")]
	[Cpp2IlInjected.Address(RVA = "0x15486A4", Offset = "0x15486A4", VA = "0x15486A4")]
	private void RenderVertexArrayWithSubMeshes(int vertexCount, int indexCount, Vector3 position, Vector3 scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001720")]
	[Cpp2IlInjected.Address(RVA = "0x15499E4", Offset = "0x15499E4", VA = "0x15499E4")]
	private void RenderVertexArray2(Effect effect, Texture2D texture, EffectPass overloadEffectPass, int vertexCount, int indexCount, Vector3 position, Vector3 scale)
	{
	}
}
