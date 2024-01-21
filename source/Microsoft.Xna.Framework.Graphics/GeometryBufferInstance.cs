using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002AD")]
public class GeometryBufferInstance
{
	[Cpp2IlInjected.Token(Token = "0x200081C")]
	public enum BatchBuffer
	{
		[Cpp2IlInjected.Token(Token = "0x4007DD1")]
		BackgroundWater,
		[Cpp2IlInjected.Token(Token = "0x4007DD2")]
		Background,
		[Cpp2IlInjected.Token(Token = "0x4007DD3")]
		Walls,
		[Cpp2IlInjected.Token(Token = "0x4007DD4")]
		TileNonSolid,
		[Cpp2IlInjected.Token(Token = "0x4007DD5")]
		TilesSolid,
		[Cpp2IlInjected.Token(Token = "0x4007DD6")]
		Water,
		[Cpp2IlInjected.Token(Token = "0x4007DD7")]
		Distortion,
		[Cpp2IlInjected.Token(Token = "0x4007DD8")]
		Count
	}

	[Cpp2IlInjected.Token(Token = "0x200081D")]
	public class PlayerBatchBuffers
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007DD9")]
		public readonly GeometryBufferInstanceList[] bufferList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007DDA")]
		public readonly List<MaterialBuffer.MaterialEntry>[] bufferMaterialList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007DDB")]
		public readonly Vector2[] bufferListPositions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007DDC")]
		public readonly float[] bufferZoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007DDD")]
		public readonly bool[] bufferUseAntiGrav;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4007DDE")]
		public readonly GeometryBufferInstanceList list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4007DDF")]
		public readonly GeometryBufferInstanceList list_8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4007DE0")]
		public readonly GeometryBufferInstanceList list_10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4007DE1")]
		public readonly Dictionary<int, MaterialBuffer.MaterialPartition> _availableMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4007DE2")]
		public readonly List<MaterialBuffer.MaterialEntry> _usedMaterialsDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4007DE3")]
		public List<MaterialBuffer.MaterialEntry> _usedMaterials;

		[Cpp2IlInjected.Token(Token = "0x6004971")]
		[Cpp2IlInjected.Address(RVA = "0x139F748", Offset = "0x139F748", VA = "0x139F748")]
		public PlayerBatchBuffers(int index)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4001F5C")]
	private const int NumPerPartition = 400;

	[Cpp2IlInjected.Token(Token = "0x4001F5D")]
	private static PlayerBatchBuffers[] playerBatchBuffers;

	[Cpp2IlInjected.Token(Token = "0x4001F5E")]
	public static PlayerBatchBuffers Active;

	[Cpp2IlInjected.Token(Token = "0x4001F5F")]
	private static int[] bufferListOffsets;

	[Cpp2IlInjected.Token(Token = "0x4001F60")]
	private static int BatchBufferList;

	[Cpp2IlInjected.Token(Token = "0x4001F61")]
	private static int _bufferOffest;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001F62")]
	public GameObject _object;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001F63")]
	private MeshFilter _meshFilter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001F64")]
	private Transform _transform;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001F65")]
	public MeshRenderer _meshRenderer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001F66")]
	public int _offset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001F67")]
	public Mesh Mesh;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001F68")]
	private int meshindex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001F69")]
	public Mesh Mesh1;

	[Cpp2IlInjected.Token(Token = "0x17000288")]
	private static GeometryBufferInstanceList[] bufferList
	{
		[Cpp2IlInjected.Token(Token = "0x60015B9")]
		[Cpp2IlInjected.Address(RVA = "0x139C4FC", Offset = "0x139C4FC", VA = "0x139C4FC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000289")]
	private static List<MaterialBuffer.MaterialEntry>[] bufferMaterialList
	{
		[Cpp2IlInjected.Token(Token = "0x60015BA")]
		[Cpp2IlInjected.Address(RVA = "0x139C578", Offset = "0x139C578", VA = "0x139C578")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028A")]
	private static Vector2[] bufferListPositions
	{
		[Cpp2IlInjected.Token(Token = "0x60015BB")]
		[Cpp2IlInjected.Address(RVA = "0x139C5F4", Offset = "0x139C5F4", VA = "0x139C5F4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028B")]
	private static float[] bufferZoom
	{
		[Cpp2IlInjected.Token(Token = "0x60015BC")]
		[Cpp2IlInjected.Address(RVA = "0x139C670", Offset = "0x139C670", VA = "0x139C670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028C")]
	private static bool[] bufferUseAntiGrav
	{
		[Cpp2IlInjected.Token(Token = "0x60015BD")]
		[Cpp2IlInjected.Address(RVA = "0x139C6EC", Offset = "0x139C6EC", VA = "0x139C6EC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028D")]
	private static GeometryBufferInstanceList list
	{
		[Cpp2IlInjected.Token(Token = "0x60015BE")]
		[Cpp2IlInjected.Address(RVA = "0x139C768", Offset = "0x139C768", VA = "0x139C768")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028E")]
	private static GeometryBufferInstanceList list_8
	{
		[Cpp2IlInjected.Token(Token = "0x60015BF")]
		[Cpp2IlInjected.Address(RVA = "0x139C7E4", Offset = "0x139C7E4", VA = "0x139C7E4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028F")]
	private static GeometryBufferInstanceList list_10
	{
		[Cpp2IlInjected.Token(Token = "0x60015C0")]
		[Cpp2IlInjected.Address(RVA = "0x139C860", Offset = "0x139C860", VA = "0x139C860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60015B8")]
	[Cpp2IlInjected.Address(RVA = "0x139C474", Offset = "0x139C474", VA = "0x139C474")]
	public static void SetActive(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015C1")]
	[Cpp2IlInjected.Address(RVA = "0x139C8DC", Offset = "0x139C8DC", VA = "0x139C8DC")]
	private static void ClearBuffers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015C2")]
	[Cpp2IlInjected.Address(RVA = "0x139CB6C", Offset = "0x139CB6C", VA = "0x139CB6C")]
	public static void InvalidateBuffers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015C3")]
	[Cpp2IlInjected.Address(RVA = "0x139CC0C", Offset = "0x139CC0C", VA = "0x139CC0C")]
	public static bool BeginBuffer(BatchBuffer bufferListId, int renderCountRefresh)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60015C4")]
	[Cpp2IlInjected.Address(RVA = "0x139D494", Offset = "0x139D494", VA = "0x139D494")]
	public static void EndBuffer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015C5")]
	[Cpp2IlInjected.Address(RVA = "0x139DF4C", Offset = "0x139DF4C", VA = "0x139DF4C")]
	public static GeometryBufferInstance GetBatchInstance()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60015C6")]
	[Cpp2IlInjected.Address(RVA = "0x139E374", Offset = "0x139E374", VA = "0x139E374")]
	public static void IncrementBufferOffset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015C7")]
	[Cpp2IlInjected.Address(RVA = "0x139E3F4", Offset = "0x139E3F4", VA = "0x139E3F4")]
	public static GeometryBufferInstance GetInstance(SpriteBatcher.VertexData[] vertices, short[] indices, int vertexCount, int indexCount)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60015C8")]
	[Cpp2IlInjected.Address(RVA = "0x139EA6C", Offset = "0x139EA6C", VA = "0x139EA6C")]
	public static GeometryBufferInstance GetInstance(List<UnityEngine.Vector3> positions, List<UnityEngine.Vector2> uvs, List<UnityEngine.Vector4> uv2s, List<Color32> colours, List<int> indices)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60015C9")]
	[Cpp2IlInjected.Address(RVA = "0x1392F30", Offset = "0x1392F30", VA = "0x1392F30")]
	public static void FinaliseInstances()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015CA")]
	[Cpp2IlInjected.Address(RVA = "0x1392BD4", Offset = "0x1392BD4", VA = "0x1392BD4")]
	public static void ClearInstances()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015CB")]
	[Cpp2IlInjected.Address(RVA = "0x139F020", Offset = "0x139F020", VA = "0x139F020")]
	public GeometryBufferInstance(Transform parentObject)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015CC")]
	[Cpp2IlInjected.Address(RVA = "0x139F22C", Offset = "0x139F22C", VA = "0x139F22C")]
	public void SetPosition(Vector3 position, Vector3 scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015CD")]
	[Cpp2IlInjected.Address(RVA = "0x139F2B8", Offset = "0x139F2B8", VA = "0x139F2B8")]
	public void SetPosition(Matrix matrix)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015CE")]
	[Cpp2IlInjected.Address(RVA = "0x139F2BC", Offset = "0x139F2BC", VA = "0x139F2BC")]
	public static UnityEngine.Vector3 ExtractTranslationFromMatrix(ref Matrix matrix)
	{
		return default(UnityEngine.Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60015CF")]
	[Cpp2IlInjected.Address(RVA = "0x139F300", Offset = "0x139F300", VA = "0x139F300")]
	public static UnityEngine.Quaternion ExtractRotationFromMatrix(ref Matrix matrix)
	{
		return default(UnityEngine.Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60015D0")]
	[Cpp2IlInjected.Address(RVA = "0x139F3EC", Offset = "0x139F3EC", VA = "0x139F3EC")]
	public static UnityEngine.Vector3 ExtractScaleFromMatrix(ref Matrix matrix)
	{
		return default(UnityEngine.Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60015D1")]
	[Cpp2IlInjected.Address(RVA = "0x139F468", Offset = "0x139F468", VA = "0x139F468")]
	public static void SetTransformFromMatrix(Transform transform, ref Matrix matrix)
	{
	}
}
