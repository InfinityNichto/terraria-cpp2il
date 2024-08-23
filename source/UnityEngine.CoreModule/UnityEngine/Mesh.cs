using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000045 RID: 69
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000048")]
	public sealed class Mesh : Object
	{
		// Token: 0x060000A5 RID: 165
		[FreeFunction("MeshScripting::CreateMesh")]
		[global::Cpp2ILInjected.Token(Token = "0x60000AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6D4C4", Offset = "0x1F6D4C4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void Internal_Create([Writable] Mesh mono);

		// Token: 0x060000A6 RID: 166 RVA: 0x00002197 File Offset: 0x00000397
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60000AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6D500", Offset = "0x1F6D500", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance", Member = ".ctor", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "get_workerMesh", ReturnType = typeof(Mesh))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_mesh", ReturnType = typeof(Mesh))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Mesh()
		{
			throw null;
		}

		// Token: 0x060000A7 RID: 167
		[FreeFunction(Name = "MeshScripting::SetIndexBufferParams", HasExplicitThis = true, ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60000AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6D588", Offset = "0x1F6D588", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetInstance", MemberParameters = new object[]
		{
			"VertexData[]",
			"System.Int16[]",
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "DrawGeometryWithSubMeshes", MemberParameters = new object[]
		{
			"VertexData[]",
			"System.Int16[]",
			typeof(int),
			typeof(int),
			"Microsoft.Xna.Framework.Vector3",
			"Microsoft.Xna.Framework.Vector3",
			"System.Collections.Generic.List`1<Material>",
			"System.Collections.Generic.List`1<SubMeshDescriptor>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern void SetIndexBufferParams(int indexCount, IndexFormat format);

		// Token: 0x060000A8 RID: 168
		[FreeFunction(Name = "MeshScripting::InternalSetIndexBufferDataFromArray", HasExplicitThis = true, ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60000B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6D5DC", Offset = "0x1F6D5DC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetIndexBufferData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void InternalSetIndexBufferDataFromArray(Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags);

		// Token: 0x060000A9 RID: 169
		[FreeFunction(Name = "MeshScripting::SetVertexBufferParamsFromArray", HasExplicitThis = true, ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60000B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6D660", Offset = "0x1F6D660", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void SetVertexBufferParamsFromArray(int vertexCount, params VertexAttributeDescriptor[] attributes);

		// Token: 0x060000AA RID: 170
		[FreeFunction(Name = "MeshScripting::InternalSetVertexBufferDataFromArray", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60000B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6D6B4", Offset = "0x1F6D6B4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetVertexBufferData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags);

		// Token: 0x060000AB RID: 171
		[FreeFunction(Name = "MeshScripting::GetIndices", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60000B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6D740", Offset = "0x1F6D740", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern int[] GetIndicesImpl(int submesh, bool applyBaseVertex);

		// Token: 0x060000AC RID: 172
		[FreeFunction(Name = "SetMeshIndicesFromScript", HasExplicitThis = true, ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60000B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6D794", Offset = "0x1F6D794", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex);

		// Token: 0x060000AD RID: 173
		[FreeFunction(Name = "MeshScripting::PrintErrorCantAccessChannel", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60000B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6D830", Offset = "0x1F6D830", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(VertexAttribute),
			typeof(VertexAttributeFormat),
			typeof(int)
		}, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "GetListForChannel", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<T>",
			typeof(int),
			typeof(VertexAttribute),
			typeof(int),
			typeof(VertexAttributeFormat)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void PrintErrorCantAccessChannel(VertexAttribute ch);

		// Token: 0x060000AE RID: 174
		[FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60000B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6D874", Offset = "0x1F6D874", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(VertexAttribute),
			typeof(VertexAttributeFormat),
			typeof(int)
		}, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "GetListForChannel", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<T>",
			typeof(int),
			typeof(VertexAttribute),
			typeof(int),
			typeof(VertexAttributeFormat)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern bool HasVertexAttribute(VertexAttribute attr);

		// Token: 0x060000AF RID: 175
		[FreeFunction(Name = "SetMeshComponentFromArrayFromScript", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60000B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6D8B8", Offset = "0x1F6D8B8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags);

		// Token: 0x060000B0 RID: 176
		[FreeFunction(Name = "AllocExtractMeshComponentFromScript", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60000B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6D954", Offset = "0x1F6D954", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(VertexAttribute),
			typeof(VertexAttributeFormat),
			typeof(int)
		}, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim);

		// Token: 0x060000B1 RID: 177
		[FreeFunction(Name = "ExtractMeshComponentFromScript", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60000B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6D9B0", Offset = "0x1F6D9B0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "GetListForChannel", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<T>",
			typeof(int),
			typeof(VertexAttribute),
			typeof(int),
			typeof(VertexAttributeFormat)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values);

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B2 RID: 178
		[global::Cpp2ILInjected.Token(Token = "0x17000026")]
		internal extern bool canAccess
		{
			[NativeMethod("CanAccessFromScript")]
			[global::Cpp2ILInjected.Token(Token = "0x60000BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6DA1C", Offset = "0x1F6DA1C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				typeof(VertexAttribute),
				typeof(VertexAttributeFormat),
				typeof(int)
			}, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "GetListForChannel", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				"System.Collections.Generic.List`1<T>",
				typeof(int),
				typeof(VertexAttribute),
				typeof(int),
				typeof(VertexAttributeFormat)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetVertexBufferData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				"T[]",
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(MeshUpdateFlags)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetIndexBufferData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				"T[]",
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(MeshUpdateFlags)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B3 RID: 179
		[global::Cpp2ILInjected.Token(Token = "0x17000027")]
		public extern int vertexCount
		{
			[NativeMethod("GetVertexCount")]
			[global::Cpp2ILInjected.Token(Token = "0x60000BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6DA58", Offset = "0x1F6DA58", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "GetUVsImpl", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				typeof(int),
				"System.Collections.Generic.List`1<T>",
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B4 RID: 180
		// (set) Token: 0x060000B5 RID: 181
		[global::Cpp2ILInjected.Token(Token = "0x17000028")]
		public extern int subMeshCount
		{
			[NativeMethod(Name = "GetSubMeshCount")]
			[global::Cpp2ILInjected.Token(Token = "0x60000BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6DA94", Offset = "0x1F6DA94", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = true)]
			[global::Cpp2ILInjected.Token(Token = "0x60000BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6DAD0", Offset = "0x1F6DAD0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetInstance", MemberParameters = new object[]
			{
				"VertexData[]",
				"System.Int16[]",
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "DrawGeometryWithSubMeshes", MemberParameters = new object[]
			{
				"VertexData[]",
				"System.Int16[]",
				typeof(int),
				typeof(int),
				"Microsoft.Xna.Framework.Vector3",
				"Microsoft.Xna.Framework.Vector3",
				"System.Collections.Generic.List`1<Material>",
				"System.Collections.Generic.List`1<SubMeshDescriptor>"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000219A File Offset: 0x0000039A
		[FreeFunction("MeshScripting::SetSubMesh", HasExplicitThis = true, ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60000BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6DB14", Offset = "0x1F6DB14", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetInstance", MemberParameters = new object[]
		{
			"VertexData[]",
			"System.Int16[]",
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "DrawGeometryWithSubMeshes", MemberParameters = new object[]
		{
			"VertexData[]",
			"System.Int16[]",
			typeof(int),
			typeof(int),
			"Microsoft.Xna.Framework.Vector3",
			"Microsoft.Xna.Framework.Vector3",
			"System.Collections.Generic.List`1<Material>",
			"System.Collections.Generic.List`1<SubMeshDescriptor>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetSubMesh(int index, SubMeshDescriptor desc, MeshUpdateFlags flags = MeshUpdateFlags.Default)
		{
			throw null;
		}

		// Token: 0x17000027 RID: 39
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000219D File Offset: 0x0000039D
		[global::Cpp2ILInjected.Token(Token = "0x17000029")]
		public Bounds bounds
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6DBCC", Offset = "0x1F6DBCC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance", Member = ".ctor", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetInstance", MemberParameters = new object[]
			{
				"VertexData[]",
				"System.Int16[]",
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetInstance", MemberParameters = new object[]
			{
				"System.Collections.Generic.List`1<Vector3>",
				"System.Collections.Generic.List`1<Vector2>",
				"System.Collections.Generic.List`1<Vector4>",
				"System.Collections.Generic.List`1<Color32>",
				"System.Collections.Generic.List`1<Int32>",
				typeof(int)
			}, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "DrawGeometryWithSubMeshes", MemberParameters = new object[]
			{
				"VertexData[]",
				"System.Int16[]",
				typeof(int),
				typeof(int),
				"Microsoft.Xna.Framework.Vector3",
				"Microsoft.Xna.Framework.Vector3",
				"System.Collections.Generic.List`1<Material>",
				"System.Collections.Generic.List`1<SubMeshDescriptor>"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060000B8 RID: 184
		[NativeMethod("Clear")]
		[global::Cpp2ILInjected.Token(Token = "0x60000C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6DC54", Offset = "0x1F6DC54", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void ClearImpl(bool keepVertexLayout);

		// Token: 0x060000B9 RID: 185
		[NativeMethod("RecalculateBounds")]
		[global::Cpp2ILInjected.Token(Token = "0x60000C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6DC98", Offset = "0x1F6DC98", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void RecalculateBoundsImpl(MeshUpdateFlags flags);

		// Token: 0x060000BA RID: 186
		[NativeMethod("MarkDynamic")]
		[global::Cpp2ILInjected.Token(Token = "0x60000C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6DCDC", Offset = "0x1F6DCDC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void MarkDynamicImpl();

		// Token: 0x060000BB RID: 187
		[NativeMethod("UploadMeshData")]
		[global::Cpp2ILInjected.Token(Token = "0x60000C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6DD18", Offset = "0x1F6DD18", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void UploadMeshDataImpl(bool markNoLongerReadable);

		// Token: 0x060000BC RID: 188 RVA: 0x000021A0 File Offset: 0x000003A0
		[global::Cpp2ILInjected.Token(Token = "0x60000C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6DD5C", Offset = "0x1F6DD5C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetUvsImpl", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			"System.Collections.Generic.List`1<T>",
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "GetUVsImpl", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(int),
			"System.Collections.Generic.List`1<T>",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static VertexAttribute GetUVChannel(int uvIndex)
		{
			throw null;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000021A3 File Offset: 0x000003A3
		[global::Cpp2ILInjected.Token(Token = "0x60000C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6DDD0", Offset = "0x1F6DDD0", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(VertexAttribute) }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(VertexAttribute),
			"System.Collections.Generic.List`1<T>",
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static int DefaultDimensionForChannel(VertexAttribute channel)
		{
			throw null;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000021A6 File Offset: 0x000003A6
		[global::Cpp2ILInjected.Token(Token = "0x60000C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x15925D4", Offset = "0x15925D4", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "get_colors32", ReturnType = typeof(Color32[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "get_canAccess", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "HasVertexAttribute", MemberParameters = new object[] { typeof(VertexAttribute) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "GetAllocArrayFromChannelImpl", MemberParameters = new object[]
		{
			typeof(VertexAttribute),
			typeof(VertexAttributeFormat),
			typeof(int)
		}, ReturnType = typeof(Array))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "PrintErrorCantAccessChannel", MemberParameters = new object[] { typeof(VertexAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim)
		{
			throw null;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000021A9 File Offset: 0x000003A9
		[global::Cpp2ILInjected.Token(Token = "0x60000C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x15924FC", Offset = "0x15924FC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "DefaultDimensionForChannel", MemberParameters = new object[] { typeof(VertexAttribute) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel)
		{
			throw null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000021AC File Offset: 0x000003AC
		[global::Cpp2ILInjected.Token(Token = "0x60000C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6DE6C", Offset = "0x1F6DE6C", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(VertexAttribute),
			typeof(VertexAttributeFormat),
			typeof(int),
			"System.Collections.Generic.List`1<T>",
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(VertexAttribute),
			"System.Collections.Generic.List`1<T>",
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags)
		{
			throw null;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000021AF File Offset: 0x000003AF
		[global::Cpp2ILInjected.Token(Token = "0x60000C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1593150", Offset = "0x1593150", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetColors", MemberParameters = new object[]
		{
			typeof(List<Color32>),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NoAllocHelpers), Member = "ExtractArrayFromList", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(Array))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel", MemberParameters = new object[]
		{
			typeof(VertexAttribute),
			typeof(VertexAttributeFormat),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		private void SetListForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length, MeshUpdateFlags flags)
		{
			throw null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000021B2 File Offset: 0x000003B2
		[global::Cpp2ILInjected.Token(Token = "0x60000CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1592F40", Offset = "0x1592F40", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "DefaultDimensionForChannel", MemberParameters = new object[] { typeof(VertexAttribute) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NoAllocHelpers), Member = "ExtractArrayFromList", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(Array))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel", MemberParameters = new object[]
		{
			typeof(VertexAttribute),
			typeof(VertexAttributeFormat),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		private void SetListForChannel<T>(VertexAttribute channel, List<T> values, int start, int length, MeshUpdateFlags flags)
		{
			throw null;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000021B5 File Offset: 0x000003B5
		[global::Cpp2ILInjected.Token(Token = "0x60000CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1592964", Offset = "0x1592964", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim)
		{
			throw null;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000021B8 File Offset: 0x000003B8
		[global::Cpp2ILInjected.Token(Token = "0x60000CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x159298C", Offset = "0x159298C", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "get_canAccess", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "HasVertexAttribute", MemberParameters = new object[] { typeof(VertexAttribute) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NoAllocHelpers), Member = "ExtractArrayFromList", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(Array))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "GetArrayFromChannelImpl", MemberParameters = new object[]
		{
			typeof(VertexAttribute),
			typeof(VertexAttributeFormat),
			typeof(int),
			typeof(Array)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "PrintErrorCantAccessChannel", MemberParameters = new object[] { typeof(VertexAttribute) }, ReturnType = typeof(void))]
		private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType)
		{
			throw null;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x000021BB File Offset: 0x000003BB
		[global::Cpp2ILInjected.Token(Token = "0x1700002A")]
		public Vector3[] vertices
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6E100", Offset = "0x1F6E100", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = ".ctor", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh[]), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new object[] { typeof(Vector3) }, MemberParameters = new object[] { typeof(VertexAttribute) }, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x000021BE File Offset: 0x000003BE
		[global::Cpp2ILInjected.Token(Token = "0x1700002B")]
		public Vector3[] normals
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6E14C", Offset = "0x1F6E14C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = ".ctor", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh[]), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new object[] { typeof(Vector3) }, MemberParameters = new object[] { typeof(VertexAttribute) }, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x000021C1 File Offset: 0x000003C1
		[global::Cpp2ILInjected.Token(Token = "0x1700002C")]
		public Vector4[] tangents
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6E198", Offset = "0x1F6E198", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = ".ctor", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh[]), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new object[] { typeof(Vector4) }, MemberParameters = new object[] { typeof(VertexAttribute) }, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000021C4 File Offset: 0x000003C4
		[global::Cpp2ILInjected.Token(Token = "0x1700002D")]
		public Color32[] colors32
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6E1E4", Offset = "0x1F6E1E4", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = ".ctor", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "GetAllocArrayFromChannel", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				typeof(VertexAttribute),
				typeof(VertexAttributeFormat),
				typeof(int)
			}, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000021C7 File Offset: 0x000003C7
		[global::Cpp2ILInjected.Token(Token = "0x60000D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E238", Offset = "0x1F6E238", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetInstance", MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<Vector3>",
			"System.Collections.Generic.List`1<Vector2>",
			"System.Collections.Generic.List`1<Vector4>",
			"System.Collections.Generic.List`1<Color32>",
			"System.Collections.Generic.List`1<Int32>",
			typeof(int)
		}, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = "FillMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NoAllocHelpers[]), Member = "SafeLength", MemberTypeParameters = new object[] { typeof(Vector3) }, MemberParameters = new object[] { typeof(List<Vector3>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetVertices", MemberParameters = new object[]
		{
			typeof(List<Vector3>),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetVertices(List<Vector3> inVertices)
		{
			throw null;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000021CA File Offset: 0x000003CA
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x60000D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E2A4", Offset = "0x1F6E2A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetVertices(List<Vector3> inVertices, int start, int length)
		{
			throw null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000021CD File Offset: 0x000003CD
		[global::Cpp2ILInjected.Token(Token = "0x60000D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E2AC", Offset = "0x1F6E2AC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetVertices", MemberParameters = new object[] { typeof(List<Vector3>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh[]), Member = "SetListForChannel", MemberTypeParameters = new object[] { typeof(Vector3) }, MemberParameters = new object[]
		{
			typeof(VertexAttribute),
			typeof(List<Vector3>),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetVertices(List<Vector3> inVertices, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
			throw null;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000021D0 File Offset: 0x000003D0
		[global::Cpp2ILInjected.Token(Token = "0x60000D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E328", Offset = "0x1F6E328", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = "FillMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NoAllocHelpers[]), Member = "SafeLength", MemberTypeParameters = new object[] { typeof(Vector3) }, MemberParameters = new object[] { typeof(List<Vector3>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetNormals", MemberParameters = new object[]
		{
			typeof(List<Vector3>),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetNormals(List<Vector3> inNormals)
		{
			throw null;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000021D3 File Offset: 0x000003D3
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x60000D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E394", Offset = "0x1F6E394", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetNormals(List<Vector3> inNormals, int start, int length)
		{
			throw null;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000021D6 File Offset: 0x000003D6
		[global::Cpp2ILInjected.Token(Token = "0x60000D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E39C", Offset = "0x1F6E39C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetNormals", MemberParameters = new object[] { typeof(List<Vector3>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh[]), Member = "SetListForChannel", MemberTypeParameters = new object[] { typeof(Vector3) }, MemberParameters = new object[]
		{
			typeof(VertexAttribute),
			typeof(List<Vector3>),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetNormals(List<Vector3> inNormals, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
			throw null;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000021D9 File Offset: 0x000003D9
		[global::Cpp2ILInjected.Token(Token = "0x60000D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E418", Offset = "0x1F6E418", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = "FillMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NoAllocHelpers[]), Member = "SafeLength", MemberTypeParameters = new object[] { typeof(Vector4) }, MemberParameters = new object[] { typeof(List<Vector4>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetTangents", MemberParameters = new object[]
		{
			typeof(List<Vector4>),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetTangents(List<Vector4> inTangents)
		{
			throw null;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000021DC File Offset: 0x000003DC
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x60000D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E484", Offset = "0x1F6E484", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetTangents(List<Vector4> inTangents, int start, int length)
		{
			throw null;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000021DF File Offset: 0x000003DF
		[global::Cpp2ILInjected.Token(Token = "0x60000D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E48C", Offset = "0x1F6E48C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetTangents", MemberParameters = new object[] { typeof(List<Vector4>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh[]), Member = "SetListForChannel", MemberTypeParameters = new object[] { typeof(Vector4) }, MemberParameters = new object[]
		{
			typeof(VertexAttribute),
			typeof(List<Vector4>),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetTangents(List<Vector4> inTangents, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
			throw null;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000021E2 File Offset: 0x000003E2
		[global::Cpp2ILInjected.Token(Token = "0x60000DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E508", Offset = "0x1F6E508", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetInstance", MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<Vector3>",
			"System.Collections.Generic.List`1<Vector2>",
			"System.Collections.Generic.List`1<Vector4>",
			"System.Collections.Generic.List`1<Color32>",
			"System.Collections.Generic.List`1<Int32>",
			typeof(int)
		}, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = "FillMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NoAllocHelpers), Member = "SafeLength", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.List`1<T>" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetColors", MemberParameters = new object[]
		{
			typeof(List<Color32>),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetColors(List<Color32> inColors)
		{
			throw null;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000021E5 File Offset: 0x000003E5
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x60000DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E574", Offset = "0x1F6E574", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetColors(List<Color32> inColors, int start, int length)
		{
			throw null;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000021E8 File Offset: 0x000003E8
		[global::Cpp2ILInjected.Token(Token = "0x60000DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E57C", Offset = "0x1F6E57C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetColors", MemberParameters = new object[] { typeof(List<Color32>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(VertexAttribute),
			typeof(VertexAttributeFormat),
			typeof(int),
			"System.Collections.Generic.List`1<T>",
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetColors(List<Color32> inColors, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
			throw null;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000021EB File Offset: 0x000003EB
		[global::Cpp2ILInjected.Token(Token = "0x60000DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x15933F0", Offset = "0x15933F0", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "GetUVChannel", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(VertexAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length, MeshUpdateFlags flags)
		{
			throw null;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000021EE File Offset: 0x000003EE
		[global::Cpp2ILInjected.Token(Token = "0x60000DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E610", Offset = "0x1F6E610", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetInstance", MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<Vector3>",
			"System.Collections.Generic.List`1<Vector2>",
			"System.Collections.Generic.List`1<Vector4>",
			"System.Collections.Generic.List`1<Color32>",
			"System.Collections.Generic.List`1<Int32>",
			typeof(int)
		}, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NoAllocHelpers[]), Member = "SafeLength", MemberTypeParameters = new object[] { typeof(Vector2) }, MemberParameters = new object[] { typeof(List<Vector2>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new object[]
		{
			typeof(int),
			typeof(List<Vector2>),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetUVs(int channel, List<Vector2> uvs)
		{
			throw null;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000021F1 File Offset: 0x000003F1
		[global::Cpp2ILInjected.Token(Token = "0x60000DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E68C", Offset = "0x1F6E68C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetInstance", MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<Vector3>",
			"System.Collections.Generic.List`1<Vector2>",
			"System.Collections.Generic.List`1<Vector4>",
			"System.Collections.Generic.List`1<Color32>",
			"System.Collections.Generic.List`1<Int32>",
			typeof(int)
		}, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = "FillMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NoAllocHelpers[]), Member = "SafeLength", MemberTypeParameters = new object[] { typeof(Vector4) }, MemberParameters = new object[] { typeof(List<Vector4>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new object[]
		{
			typeof(int),
			typeof(List<Vector4>),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetUVs(int channel, List<Vector4> uvs)
		{
			throw null;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000021F4 File Offset: 0x000003F4
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x60000E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E684", Offset = "0x1F6E684", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new object[]
		{
			typeof(int),
			typeof(List<Vector2>),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		public void SetUVs(int channel, List<Vector2> uvs, int start, int length)
		{
			throw null;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000021F7 File Offset: 0x000003F7
		[global::Cpp2ILInjected.Token(Token = "0x60000E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E708", Offset = "0x1F6E708", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new object[]
		{
			typeof(int),
			typeof(List<Vector2>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new object[]
		{
			typeof(int),
			typeof(List<Vector2>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh[]), Member = "SetUvsImpl", MemberTypeParameters = new object[] { typeof(Vector2) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(List<Vector2>),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetUVs(int channel, List<Vector2> uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
			throw null;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000021FA File Offset: 0x000003FA
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x60000E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E700", Offset = "0x1F6E700", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new object[]
		{
			typeof(int),
			typeof(List<Vector4>),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		public void SetUVs(int channel, List<Vector4> uvs, int start, int length)
		{
			throw null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000021FD File Offset: 0x000003FD
		[global::Cpp2ILInjected.Token(Token = "0x60000E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E794", Offset = "0x1F6E794", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new object[]
		{
			typeof(int),
			typeof(List<Vector4>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new object[]
		{
			typeof(int),
			typeof(List<Vector4>),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh[]), Member = "SetUvsImpl", MemberTypeParameters = new object[] { typeof(Vector4) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(List<Vector4>),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetUVs(int channel, List<Vector4> uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
			throw null;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002200 File Offset: 0x00000400
		[global::Cpp2ILInjected.Token(Token = "0x60000E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1592B5C", Offset = "0x1592B5C", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "get_vertexCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "GetUVChannel", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(VertexAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void GetUVsImpl<T>(int uvIndex, List<T> uvs, int dim)
		{
			throw null;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002203 File Offset: 0x00000403
		[global::Cpp2ILInjected.Token(Token = "0x60000E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E820", Offset = "0x1F6E820", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = ".ctor", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh[]), Member = "GetUVsImpl", MemberTypeParameters = new object[] { typeof(Vector4) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(List<Vector4>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void GetUVs(int channel, List<Vector4> uvs)
		{
			throw null;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002206 File Offset: 0x00000406
		[global::Cpp2ILInjected.Token(Token = "0x60000E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E884", Offset = "0x1F6E884", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetInstance", MemberParameters = new object[]
		{
			"VertexData[]",
			"System.Int16[]",
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "DrawGeometryWithSubMeshes", MemberParameters = new object[]
		{
			"VertexData[]",
			"System.Int16[]",
			typeof(int),
			typeof(int),
			"Microsoft.Xna.Framework.Vector3",
			"Microsoft.Xna.Framework.Vector3",
			"System.Collections.Generic.List`1<Material>",
			"System.Collections.Generic.List`1<SubMeshDescriptor>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetVertexBufferParams(int vertexCount, params VertexAttributeDescriptor[] attributes)
		{
			throw null;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002209 File Offset: 0x00000409
		[global::Cpp2ILInjected.Token(Token = "0x60000E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1593714", Offset = "0x1593714", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetInstance", MemberParameters = new object[]
		{
			"VertexData[]",
			"System.Int16[]",
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "DrawGeometryWithSubMeshes", MemberParameters = new object[]
		{
			"VertexData[]",
			"System.Int16[]",
			typeof(int),
			typeof(int),
			"Microsoft.Xna.Framework.Vector3",
			"Microsoft.Xna.Framework.Vector3",
			"System.Collections.Generic.List`1<Material>",
			"System.Collections.Generic.List`1<SubMeshDescriptor>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "get_canAccess", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeUtility), Member = "IsArrayBlittable", MemberParameters = new object[] { typeof(Array) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "InternalSetVertexBufferDataFromArray", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeUtility), Member = "GetReasonForArrayNonBlittable", MemberParameters = new object[] { typeof(Array) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public void SetVertexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct
		{
			throw null;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000220C File Offset: 0x0000040C
		[global::Cpp2ILInjected.Token(Token = "0x60000E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E8D8", Offset = "0x1F6E8D8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetIndexBufferData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void PrintErrorCantAccessIndices()
		{
			throw null;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000220F File Offset: 0x0000040F
		[global::Cpp2ILInjected.Token(Token = "0x60000E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6E9E0", Offset = "0x1F6E9E0", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "CheckCanAccessSubmeshTriangles", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "CheckCanAccessSubmeshIndices", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "GetIndices", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new object[]
		{
			typeof(List<int>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "PrintErrorCantAccessIndices", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles)
		{
			throw null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002212 File Offset: 0x00000412
		[global::Cpp2ILInjected.Token(Token = "0x60000EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6EB20", Offset = "0x1F6EB20", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		private bool CheckCanAccessSubmeshTriangles(int submesh)
		{
			throw null;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002215 File Offset: 0x00000415
		[global::Cpp2ILInjected.Token(Token = "0x60000EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6EB28", Offset = "0x1F6EB28", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		private bool CheckCanAccessSubmeshIndices(int submesh)
		{
			throw null;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002218 File Offset: 0x00000418
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x60000EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6EB30", Offset = "0x1F6EB30", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = ".ctor", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public int[] GetIndices(int submesh)
		{
			throw null;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000221B File Offset: 0x0000041B
		[global::Cpp2ILInjected.Token(Token = "0x60000ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6EB38", Offset = "0x1F6EB38", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public int[] GetIndices(int submesh, [DefaultValue("true")] bool applyBaseVertex)
		{
			throw null;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000221E File Offset: 0x0000041E
		[global::Cpp2ILInjected.Token(Token = "0x60000EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1592D74", Offset = "0x1592D74", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetInstance", MemberParameters = new object[]
		{
			"VertexData[]",
			"System.Int16[]",
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "DrawGeometryWithSubMeshes", MemberParameters = new object[]
		{
			"VertexData[]",
			"System.Int16[]",
			typeof(int),
			typeof(int),
			"Microsoft.Xna.Framework.Vector3",
			"Microsoft.Xna.Framework.Vector3",
			"System.Collections.Generic.List`1<Material>",
			"System.Collections.Generic.List`1<SubMeshDescriptor>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "get_canAccess", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeUtility), Member = "IsArrayBlittable", MemberParameters = new object[] { typeof(Array) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "InternalSetIndexBufferDataFromArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(MeshUpdateFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "PrintErrorCantAccessIndices", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeUtility), Member = "GetReasonForArrayNonBlittable", MemberParameters = new object[] { typeof(Array) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void SetIndexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = MeshUpdateFlags.Default) where T : struct
		{
			throw null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002221 File Offset: 0x00000421
		[global::Cpp2ILInjected.Token(Token = "0x60000EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6EBE0", Offset = "0x1F6EBE0", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetTrianglesImpl", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IndexFormat),
			typeof(Array),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private void CheckIndicesArrayRange(int valuesLength, int start, int length)
		{
			throw null;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002224 File Offset: 0x00000424
		[global::Cpp2ILInjected.Token(Token = "0x60000F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6ED7C", Offset = "0x1F6ED7C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new object[]
		{
			typeof(List<int>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "CheckIndicesArrayRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex)
		{
			throw null;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002227 File Offset: 0x00000427
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x60000F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6EE1C", Offset = "0x1F6EE1C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = "FillMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void SetTriangles(List<int> triangles, int submesh)
		{
			throw null;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000222A File Offset: 0x0000042A
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x60000F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6EEB0", Offset = "0x1F6EEB0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetInstance", MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<Vector3>",
			"System.Collections.Generic.List`1<Vector2>",
			"System.Collections.Generic.List`1<Vector4>",
			"System.Collections.Generic.List`1<Color32>",
			"System.Collections.Generic.List`1<Int32>",
			typeof(int)
		}, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new object[]
		{
			typeof(List<int>),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds)
		{
			throw null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000222D File Offset: 0x0000042D
		[global::Cpp2ILInjected.Token(Token = "0x60000F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6EE28", Offset = "0x1F6EE28", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new object[]
		{
			typeof(List<int>),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NoAllocHelpers[]), Member = "SafeLength", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new object[]
		{
			typeof(List<int>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetTriangles(List<int> triangles, int submesh, [DefaultValue("true")] bool calculateBounds, [DefaultValue("0")] int baseVertex)
		{
			throw null;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002230 File Offset: 0x00000430
		[global::Cpp2ILInjected.Token(Token = "0x60000F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6EEBC", Offset = "0x1F6EEBC", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new object[]
		{
			typeof(List<int>),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NoAllocHelpers[]), Member = "SafeLength", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(List<int>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mesh), Member = "SetTrianglesImpl", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IndexFormat),
			typeof(Array),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
			throw null;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002233 File Offset: 0x00000433
		[global::Cpp2ILInjected.Token(Token = "0x60000F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6EFE4", Offset = "0x1F6EFE4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetInstance", MemberParameters = new object[]
		{
			"VertexData[]",
			"System.Int16[]",
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetInstance", MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<Vector3>",
			"System.Collections.Generic.List`1<Vector2>",
			"System.Collections.Generic.List`1<Vector4>",
			"System.Collections.Generic.List`1<Color32>",
			"System.Collections.Generic.List`1<Int32>",
			typeof(int)
		}, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "DrawGeometryWithSubMeshes", MemberParameters = new object[]
		{
			"VertexData[]",
			"System.Int16[]",
			typeof(int),
			typeof(int),
			"Microsoft.Xna.Framework.Vector3",
			"Microsoft.Xna.Framework.Vector3",
			"System.Collections.Generic.List`1<Material>",
			"System.Collections.Generic.List`1<SubMeshDescriptor>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Clear([DefaultValue("true")] bool keepVertexLayout)
		{
			throw null;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002236 File Offset: 0x00000436
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x60000F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6F028", Offset = "0x1F6F028", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "DoLegacyMeshGeneration", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = "FillMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002239 File Offset: 0x00000439
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x60000F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6F068", Offset = "0x1F6F068", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = "FillMesh", MemberParameters = new object[] { typeof(Mesh) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void RecalculateBounds()
		{
			throw null;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000223C File Offset: 0x0000043C
		[global::Cpp2ILInjected.Token(Token = "0x60000F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6F070", Offset = "0x1F6F070", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void RecalculateBounds([DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
			throw null;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000223F File Offset: 0x0000043F
		[global::Cpp2ILInjected.Token(Token = "0x60000F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6F160", Offset = "0x1F6F160", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance", Member = ".ctor", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void MarkDynamic()
		{
			throw null;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002242 File Offset: 0x00000442
		[global::Cpp2ILInjected.Token(Token = "0x60000FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6F1D4", Offset = "0x1F6F1D4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetInstance", MemberParameters = new object[]
		{
			"VertexData[]",
			"System.Int16[]",
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "DrawGeometryWithSubMeshes", MemberParameters = new object[]
		{
			"VertexData[]",
			"System.Int16[]",
			typeof(int),
			typeof(int),
			"Microsoft.Xna.Framework.Vector3",
			"Microsoft.Xna.Framework.Vector3",
			"System.Collections.Generic.List`1<Material>",
			"System.Collections.Generic.List`1<SubMeshDescriptor>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void UploadMeshData(bool markNoLongerReadable)
		{
			throw null;
		}

		// Token: 0x060000F3 RID: 243
		[global::Cpp2ILInjected.Token(Token = "0x60000FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6DB70", Offset = "0x1F6DB70", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void SetSubMesh_Injected(int index, ref SubMeshDescriptor desc, MeshUpdateFlags flags = MeshUpdateFlags.Default);

		// Token: 0x060000F4 RID: 244
		[global::Cpp2ILInjected.Token(Token = "0x60000FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6DC10", Offset = "0x1F6DC10", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void set_bounds_Injected(ref Bounds value);

		// Token: 0x02000163 RID: 355
		[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
		[StaticAccessor("MeshDataBindings", StaticAccessorType.DoubleColon)]
		[global::Cpp2ILInjected.Token(Token = "0x2000049")]
		public struct MeshData
		{
			// Token: 0x04000634 RID: 1588
			[NativeDisableUnsafePtrRestriction]
			[global::Cpp2ILInjected.Token(Token = "0x4000210")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal IntPtr m_Ptr;
		}
	}
}
