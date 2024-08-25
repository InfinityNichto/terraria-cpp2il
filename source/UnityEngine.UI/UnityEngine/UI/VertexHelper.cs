using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Pool;

namespace UnityEngine.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x200007F")]
	public class VertexHelper : IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x600050E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE07E8", Offset = "0x1FE07E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnFillVBO", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public VertexHelper()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600050F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE07F0", Offset = "0x1FE07F0", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BaseMeshEffect), Member = "ModifyMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "get_vertices", ReturnType = typeof(Vector3[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector3>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<Vector3>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "get_colors32", ReturnType = typeof(Color32[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Color32>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<Color32>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector4>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "GetUVs", MemberParameters = new object[]
		{
			typeof(int),
			typeof(List<Vector4>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector4>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<Vector4>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "get_normals", ReturnType = typeof(Vector3[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "get_tangents", ReturnType = typeof(Vector4[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "GetIndices", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public VertexHelper(Mesh m)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000510")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE0A08", Offset = "0x1FE0A08", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexHelper), Member = ".ctor", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexHelper), Member = "PopulateUIVertex", MemberParameters = new object[]
		{
			typeof(ref UIVertex),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexHelper), Member = "SetUIVertex", MemberParameters = new object[]
		{
			typeof(UIVertex),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexHelper), Member = "FillMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Color32),
			typeof(Vector4),
			typeof(Vector4),
			typeof(Vector4),
			typeof(Vector4),
			typeof(Vector3),
			typeof(Vector4)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexHelper), Member = "AddUIVertexStream", MemberParameters = new object[]
		{
			typeof(List<UIVertex>),
			typeof(List<int>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexHelper), Member = "AddUIVertexTriangleStream", MemberParameters = new object[] { typeof(List<UIVertex>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexHelper), Member = "GetUIVertexStream", MemberParameters = new object[] { typeof(List<UIVertex>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, Vector3>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<, >), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, Vector4>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, int>), Member = "Get", ReturnType = "TCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void InitializeListIfRequired()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000511")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE0B98", Offset = "0x1FE0B98", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, Vector3>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<, >), Member = "Release", MemberParameters = new object[] { "TCollection" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, Vector4>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionPool<object, int>), Member = "Release", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000512")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD15D4", Offset = "0x1FD15D4", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "DoMeshGeneration", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateSimpleSprite", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateSprite", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateFilledSprite", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RawImage), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Outline), Member = "ModifyMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Shadow), Member = "ModifyMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000152")]
		public int currentVertCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000513")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE0D4C", Offset = "0x1FE0D4C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new object[]
			{
				typeof(VertexHelper),
				typeof(Vector3[]),
				typeof(Color32),
				typeof(Vector3[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new object[]
			{
				typeof(VertexHelper),
				typeof(Vector2),
				typeof(Vector2),
				typeof(Color32),
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new object[]
			{
				typeof(VertexHelper),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PositionAsUV1), Member = "ModifyMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000153")]
		public int currentIndexCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000514")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE0D98", Offset = "0x1FE0D98", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000515")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE0DE4", Offset = "0x1FE0DE4", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PositionAsUV1), Member = "ModifyMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector3>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Color32>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector4>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void PopulateUIVertex(ref UIVertex vertex, int i)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000516")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE0F28", Offset = "0x1FE0F28", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PositionAsUV1), Member = "ModifyMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector3>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Color32>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Color32)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Vector4>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector4)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void SetUIVertex(UIVertex vertex, int i)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000517")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE1068", Offset = "0x1FE1068", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "DoMeshGeneration", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "OnFillVBO", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BaseMeshEffect), Member = "ModifyMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetVertices", MemberParameters = new object[] { typeof(List<Vector3>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetColors", MemberParameters = new object[] { typeof(List<Color32>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new object[]
		{
			typeof(int),
			typeof(List<Vector4>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetNormals", MemberParameters = new object[] { typeof(List<Vector3>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetTangents", MemberParameters = new object[] { typeof(List<Vector4>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new object[]
		{
			typeof(List<int>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void FillMesh(Mesh mesh)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000518")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE11BC", Offset = "0x1FE11BC", Length = "0x4C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Color32),
			typeof(Vector4),
			typeof(Vector4),
			typeof(Vector3),
			typeof(Vector4)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new object[] { typeof(UIVertex) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000519")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE1680", Offset = "0x1FE1680", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Color32),
			typeof(Vector4)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexHelper), Member = "AddUIVertexQuad", MemberParameters = new object[] { typeof(UIVertex[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Color32),
			typeof(Vector4),
			typeof(Vector4),
			typeof(Vector4),
			typeof(Vector4),
			typeof(Vector3),
			typeof(Vector4)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600051A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD16C8", Offset = "0x1FD16C8", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateSimpleSprite", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateSprite", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(Vector3[]),
			typeof(Color32),
			typeof(Vector3[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Color32),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RawImage), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Color32),
			typeof(Vector4),
			typeof(Vector4),
			typeof(Vector3),
			typeof(Vector4)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void AddVert(Vector3 position, Color32 color, Vector4 uv0)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600051B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE1790", Offset = "0x1FE1790", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Color32),
			typeof(Vector4),
			typeof(Vector4),
			typeof(Vector4),
			typeof(Vector4),
			typeof(Vector3),
			typeof(Vector4)
		}, ReturnType = typeof(void))]
		public void AddVert(UIVertex v)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600051C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD17F8", Offset = "0x1FD17F8", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateSimpleSprite", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateSprite", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(Vector3[]),
			typeof(Color32),
			typeof(Vector3[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Color32),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RawImage), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexHelper), Member = "AddUIVertexQuad", MemberParameters = new object[] { typeof(UIVertex[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void AddTriangle(int idx0, int idx1, int idx2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600051D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDDAD4", Offset = "0x1FDDAD4", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Color32),
			typeof(Vector4),
			typeof(Vector4),
			typeof(Vector3),
			typeof(Vector4)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddUIVertexQuad(UIVertex[] verts)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600051E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE1824", Offset = "0x1FE1824", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "AddUIVertexStream", MemberParameters = new object[]
		{
			typeof(List<UIVertex>),
			typeof(List<Vector3>),
			typeof(List<Color32>),
			typeof(List<Vector4>),
			typeof(List<Vector4>),
			typeof(List<Vector4>),
			typeof(List<Vector4>),
			typeof(List<Vector3>),
			typeof(List<Vector4>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddUIVertexStream(List<UIVertex> verts, List<int> indices)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600051F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE18C8", Offset = "0x1FE18C8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Outline), Member = "ModifyMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Shadow), Member = "ModifyMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "SplitUIVertexStreams", MemberParameters = new object[]
		{
			typeof(List<UIVertex>),
			typeof(List<Vector3>),
			typeof(List<Color32>),
			typeof(List<Vector4>),
			typeof(List<Vector4>),
			typeof(List<Vector4>),
			typeof(List<Vector4>),
			typeof(List<Vector3>),
			typeof(List<Vector4>),
			typeof(List<int>)
		}, ReturnType = typeof(void))]
		public void AddUIVertexTriangleStream(List<UIVertex> verts)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000520")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE1918", Offset = "0x1FE1918", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Outline), Member = "ModifyMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Shadow), Member = "ModifyMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "CreateUIVertexStream", MemberParameters = new object[]
		{
			typeof(List<UIVertex>),
			typeof(List<Vector3>),
			typeof(List<Color32>),
			typeof(List<Vector4>),
			typeof(List<Vector4>),
			typeof(List<Vector4>),
			typeof(List<Vector4>),
			typeof(List<Vector3>),
			typeof(List<Vector4>),
			typeof(List<int>)
		}, ReturnType = typeof(void))]
		public void GetUIVertexStream(List<UIVertex> stream)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000521")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE1968", Offset = "0x1FE1968", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static VertexHelper()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400025E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<Vector3> m_Positions;

		[global::Cpp2ILInjected.Token(Token = "0x400025F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<Color32> m_Colors;

		[global::Cpp2ILInjected.Token(Token = "0x4000260")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<Vector4> m_Uv0S;

		[global::Cpp2ILInjected.Token(Token = "0x4000261")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private List<Vector4> m_Uv1S;

		[global::Cpp2ILInjected.Token(Token = "0x4000262")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private List<Vector4> m_Uv2S;

		[global::Cpp2ILInjected.Token(Token = "0x4000263")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private List<Vector4> m_Uv3S;

		[global::Cpp2ILInjected.Token(Token = "0x4000264")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private List<Vector3> m_Normals;

		[global::Cpp2ILInjected.Token(Token = "0x4000265")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private List<Vector4> m_Tangents;

		[global::Cpp2ILInjected.Token(Token = "0x4000266")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private List<int> m_Indices;

		[global::Cpp2ILInjected.Token(Token = "0x4000267")]
		private static readonly Vector4 s_DefaultTangent;

		[global::Cpp2ILInjected.Token(Token = "0x4000268")]
		private static readonly Vector3 s_DefaultNormal;

		[global::Cpp2ILInjected.Token(Token = "0x4000269")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private bool m_ListsInitalized;
	}
}
