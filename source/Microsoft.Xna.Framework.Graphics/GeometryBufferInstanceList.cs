using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002AE")]
public class GeometryBufferInstanceList
{
	[Cpp2IlInjected.Token(Token = "0x4001F6A")]
	private static GameObject _root;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001F6B")]
	private readonly string _rootName;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001F6C")]
	private GameObject _parent;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001F6D")]
	private Transform _parentTransform;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001F6E")]
	private List<GeometryBufferInstance> _freeInstances;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001F6F")]
	private List<GeometryBufferInstance> _usedInstances;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001F70")]
	private int _resetOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001F71")]
	private int _vertexCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001F72")]
	private int _forcedLayer;

	[Cpp2IlInjected.Token(Token = "0x4001F73")]
	public static VertexAttributeDescriptor[] vertexDescription;

	[Cpp2IlInjected.Token(Token = "0x4001F74")]
	private static SubMeshDescriptor[] subMeshes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001F75")]
	private bool _finalPending;

	[Cpp2IlInjected.Token(Token = "0x60015D3")]
	[Cpp2IlInjected.Address(RVA = "0x139FF54", Offset = "0x139FF54", VA = "0x139FF54")]
	public GeometryBufferInstanceList(int vertexCount, [Optional] string rootName, int forcedLayer = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015D4")]
	[Cpp2IlInjected.Address(RVA = "0x139E1E0", Offset = "0x139E1E0", VA = "0x139E1E0")]
	public GeometryBufferInstance GetBatchInstance(int bufferOffest)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60015D5")]
	[Cpp2IlInjected.Address(RVA = "0x139E6B4", Offset = "0x139E6B4", VA = "0x139E6B4")]
	public GeometryBufferInstance GetInstance(SpriteBatcher.VertexData[] vertices, short[] indices, int vertexCount, int indexCount, int bufferOffest)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60015D6")]
	[Cpp2IlInjected.Address(RVA = "0x139ED30", Offset = "0x139ED30", VA = "0x139ED30")]
	public GeometryBufferInstance GetInstance(List<UnityEngine.Vector3> positions, List<UnityEngine.Vector2> uvs, List<UnityEngine.Vector4> uv2s, List<Color32> colours, List<int> indices, int bufferOffest)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60015D7")]
	[Cpp2IlInjected.Address(RVA = "0x13A000C", Offset = "0x13A000C", VA = "0x13A000C")]
	private void SetupParent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015D8")]
	[Cpp2IlInjected.Address(RVA = "0x139DE6C", Offset = "0x139DE6C", VA = "0x139DE6C")]
	public void SetOffset(Vector2 offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015D9")]
	[Cpp2IlInjected.Address(RVA = "0x139DDCC", Offset = "0x139DDCC", VA = "0x139DDCC")]
	public void FinaliseInstances()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015DA")]
	[Cpp2IlInjected.Address(RVA = "0x139CA3C", Offset = "0x139CA3C", VA = "0x139CA3C")]
	public void ClearInstances()
	{
	}
}
