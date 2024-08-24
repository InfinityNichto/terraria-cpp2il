using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002AC RID: 684
	[global::Cpp2ILInjected.Token(Token = "0x2000374")]
	public class MaterialBuffer
	{
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x00025B74 File Offset: 0x00023D74
		[global::Cpp2ILInjected.Token(Token = "0x170002B8")]
		private static Dictionary<int, MaterialBuffer.MaterialPartition> _availableMaterials
		{
			[global::Cpp2ILInjected.Token(Token = "0x600170D")]
			[global::Cpp2ILInjected.Address(RVA = "0xAAF158", Offset = "0xAAF158", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaterialBuffer), Member = "DestroyMaterials", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaterialBuffer), Member = "GetMaterial", MemberParameters = new object[]
			{
				typeof(EffectPass),
				typeof(Texture2D),
				typeof(Texture2D),
				typeof(Texture2D),
				typeof(Texture2D)
			}, ReturnType = typeof(Material))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060015A5 RID: 5541 RVA: 0x00025B77 File Offset: 0x00023D77
		[global::Cpp2ILInjected.Token(Token = "0x170002B9")]
		private static List<MaterialBuffer.MaterialEntry> _usedMaterialsDefault
		{
			[global::Cpp2ILInjected.Token(Token = "0x600170E")]
			[global::Cpp2ILInjected.Address(RVA = "0xAAF1B4", Offset = "0xAAF1B4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaterialBuffer), Member = "SetUsedMaterialList", MemberParameters = new object[] { typeof(List<MaterialBuffer.MaterialEntry>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x00025B7A File Offset: 0x00023D7A
		// (set) Token: 0x060015A7 RID: 5543 RVA: 0x00025B7D File Offset: 0x00023D7D
		[global::Cpp2ILInjected.Token(Token = "0x170002BA")]
		private static List<MaterialBuffer.MaterialEntry> _usedMaterials
		{
			[global::Cpp2ILInjected.Token(Token = "0x600170F")]
			[global::Cpp2ILInjected.Address(RVA = "0xAAF210", Offset = "0xAAF210", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaterialBuffer), Member = "DestroyMaterials", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaterialBuffer), Member = "GetMaterial", MemberParameters = new object[]
			{
				typeof(EffectPass),
				typeof(Texture2D),
				typeof(Texture2D),
				typeof(Texture2D),
				typeof(Texture2D)
			}, ReturnType = typeof(Material))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaterialBuffer), Member = "ClearInstances", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001710")]
			[global::Cpp2ILInjected.Address(RVA = "0xAAF26C", Offset = "0xAAF26C", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaterialBuffer), Member = "SetUsedMaterialList", MemberParameters = new object[] { typeof(List<MaterialBuffer.MaterialEntry>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00025B80 File Offset: 0x00023D80
		[global::Cpp2ILInjected.Token(Token = "0x6001711")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAC7A0", Offset = "0xAAC7A0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "BeginBuffer", MemberParameters = new object[]
		{
			typeof(GeometryBufferInstance.BatchBuffer),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "EndBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaterialBuffer), Member = "DestroyMaterials", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer), Member = "get__usedMaterialsDefault", ReturnType = typeof(List<MaterialBuffer.MaterialEntry>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer), Member = "set__usedMaterials", MemberParameters = new object[] { typeof(List<MaterialBuffer.MaterialEntry>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SetUsedMaterialList(List<MaterialBuffer.MaterialEntry> list)
		{
			throw null;
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x00025B83 File Offset: 0x00023D83
		[global::Cpp2ILInjected.Token(Token = "0x6001712")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAF2CC", Offset = "0xAAF2CC", Length = "0x4EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextureAtlasDB), Member = "ActionPendingUnloadAssets", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "SetActive", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer), Member = "SetUsedMaterialList", MemberParameters = new object[] { typeof(List<MaterialBuffer.MaterialEntry>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer), Member = "get__usedMaterials", ReturnType = typeof(List<MaterialBuffer.MaterialEntry>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "DestroyImmediate", MemberParameters = new object[] { typeof(global::UnityEngine.Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer), Member = "get__availableMaterials", ReturnType = typeof(Dictionary<int, MaterialBuffer.MaterialPartition>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer.MaterialPartition), Member = "DestroyMaterials", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		public static void DestroyMaterials()
		{
			throw null;
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x00025B86 File Offset: 0x00023D86
		[global::Cpp2ILInjected.Token(Token = "0x6001713")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAB610", Offset = "0xAAB610", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBuffer), Member = "RenderAndFlush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "GetMaterial", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer), Member = "get__availableMaterials", ReturnType = typeof(Dictionary<int, MaterialBuffer.MaterialPartition>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer.MaterialPartition), Member = ".ctor", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer.MaterialPartition), Member = "GetMaterial", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Texture2D),
			typeof(Texture2D),
			typeof(Texture2D)
		}, ReturnType = typeof(MaterialBuffer.MaterialEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer.MaterialEntry), Member = "SetupTrimming", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer.MaterialEntry), Member = "ClearTrimming", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer), Member = "get__usedMaterials", ReturnType = typeof(List<MaterialBuffer.MaterialEntry>))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static Material GetMaterial(EffectPass baseEffect, Texture2D t0, Texture2D t1, Texture2D t2, Texture2D t3)
		{
			throw null;
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x00025B89 File Offset: 0x00023D89
		[global::Cpp2ILInjected.Token(Token = "0x6001714")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAC804", Offset = "0xAAC804", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Game), Member = "UnityDraw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "BeginBuffer", MemberParameters = new object[]
		{
			typeof(GeometryBufferInstance.BatchBuffer),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer), Member = "get__usedMaterials", ReturnType = typeof(List<MaterialBuffer.MaterialEntry>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer.MaterialEntry), Member = "Relase", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void ClearInstances()
		{
			throw null;
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00025B8C File Offset: 0x00023D8C
		[global::Cpp2ILInjected.Token(Token = "0x6001715")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAFE58", Offset = "0xAAFE58", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MaterialBuffer()
		{
			throw null;
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x00025B8F File Offset: 0x00023D8F
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001716")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAFE60", Offset = "0xAAFE60", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		static MaterialBuffer()
		{
			throw null;
		}

		// Token: 0x04001F70 RID: 8048
		[global::Cpp2ILInjected.Token(Token = "0x40025A9")]
		private static int MainTexId;

		// Token: 0x04001F71 RID: 8049
		[global::Cpp2ILInjected.Token(Token = "0x40025AA")]
		private static int MainAlphaTexId;

		// Token: 0x04001F72 RID: 8050
		[global::Cpp2ILInjected.Token(Token = "0x40025AB")]
		private static int MainPalTexId;

		// Token: 0x04001F73 RID: 8051
		[global::Cpp2ILInjected.Token(Token = "0x40025AC")]
		private static int PalScaleSizeId;

		// Token: 0x04001F74 RID: 8052
		[global::Cpp2ILInjected.Token(Token = "0x40025AD")]
		public static int SecTexId;

		// Token: 0x04001F75 RID: 8053
		[global::Cpp2ILInjected.Token(Token = "0x40025AE")]
		private static int ThirdTexId;

		// Token: 0x04001F76 RID: 8054
		[global::Cpp2ILInjected.Token(Token = "0x40025AF")]
		private static int ForthTexId;

		// Token: 0x04001F77 RID: 8055
		[global::Cpp2ILInjected.Token(Token = "0x40025B0")]
		private static int TrimMinId;

		// Token: 0x04001F78 RID: 8056
		[global::Cpp2ILInjected.Token(Token = "0x40025B1")]
		private static int TrimMaxId;

		// Token: 0x02000827 RID: 2087
		[global::Cpp2ILInjected.Token(Token = "0x2000375")]
		public class MaterialEntry
		{
			// Token: 0x0600493C RID: 18748 RVA: 0x0002EFCD File Offset: 0x0002D1CD
			[global::Cpp2ILInjected.Token(Token = "0x6001717")]
			[global::Cpp2ILInjected.Address(RVA = "0xAB0048", Offset = "0xAB0048", Length = "0x618")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaterialBuffer.MaterialPartition), Member = "GetMaterial", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(Texture2D),
				typeof(Texture2D),
				typeof(Texture2D)
			}, ReturnType = typeof(MaterialBuffer.MaterialEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "get_shader", ReturnType = typeof(Shader))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new object[] { typeof(Shader) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = "get_UnityBindTexture", ReturnType = typeof(Texture))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "SetTexture", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Texture)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::UnityEngine.Object),
				typeof(global::UnityEngine.Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new object[]
			{
				typeof(int),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
			public MaterialEntry(MaterialBuffer.MaterialPartition materialPartition, List<MaterialBuffer.MaterialEntry> list, Texture2D t0, Texture2D t1, Texture2D t2, Texture2D t3)
			{
				throw null;
			}

			// Token: 0x0600493D RID: 18749 RVA: 0x0002EFD0 File Offset: 0x0002D1D0
			[global::Cpp2ILInjected.Token(Token = "0x6001718")]
			[global::Cpp2ILInjected.Address(RVA = "0xAAFD00", Offset = "0xAAFD00", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaterialBuffer), Member = "GetMaterial", MemberParameters = new object[]
			{
				typeof(EffectPass),
				typeof(Texture2D),
				typeof(Texture2D),
				typeof(Texture2D),
				typeof(Texture2D)
			}, ReturnType = typeof(Material))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Vector4)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public void SetupTrimming(Vector2 min, Vector2 max)
			{
				throw null;
			}

			// Token: 0x0600493E RID: 18750 RVA: 0x0002EFD3 File Offset: 0x0002D1D3
			[global::Cpp2ILInjected.Token(Token = "0x6001719")]
			[global::Cpp2ILInjected.Address(RVA = "0xAAFDF4", Offset = "0xAAFDF4", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaterialBuffer), Member = "GetMaterial", MemberParameters = new object[]
			{
				typeof(EffectPass),
				typeof(Texture2D),
				typeof(Texture2D),
				typeof(Texture2D),
				typeof(Texture2D)
			}, ReturnType = typeof(Material))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "DisableKeyword", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void ClearTrimming()
			{
				throw null;
			}

			// Token: 0x0600493F RID: 18751 RVA: 0x0002EFD6 File Offset: 0x0002D1D6
			[global::Cpp2ILInjected.Token(Token = "0x600171A")]
			[global::Cpp2ILInjected.Address(RVA = "0xAABC88", Offset = "0xAABC88", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "ClearBuffers", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaterialBuffer), Member = "ClearInstances", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public void Relase()
			{
				throw null;
			}

			// Token: 0x04007DF7 RID: 32247
			[global::Cpp2ILInjected.Token(Token = "0x40025B2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly List<MaterialBuffer.MaterialEntry> MaterialList;

			// Token: 0x04007DF8 RID: 32248
			[global::Cpp2ILInjected.Token(Token = "0x40025B3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public readonly Texture2D T0;

			// Token: 0x04007DF9 RID: 32249
			[global::Cpp2ILInjected.Token(Token = "0x40025B4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public readonly Texture2D T1;

			// Token: 0x04007DFA RID: 32250
			[global::Cpp2ILInjected.Token(Token = "0x40025B5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public readonly Material Material;

			// Token: 0x04007DFB RID: 32251
			[global::Cpp2ILInjected.Token(Token = "0x40025B6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private bool useTrimming;
		}

		// Token: 0x02000828 RID: 2088
		[global::Cpp2ILInjected.Token(Token = "0x2000376")]
		public class MaterialPartition : Dictionary<int, List<MaterialBuffer.MaterialEntry>>
		{
			// Token: 0x06004940 RID: 18752 RVA: 0x0002EFD9 File Offset: 0x0002D1D9
			[global::Cpp2ILInjected.Token(Token = "0x600171B")]
			[global::Cpp2ILInjected.Address(RVA = "0xAAFA54", Offset = "0xAAFA54", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaterialBuffer), Member = "GetMaterial", MemberParameters = new object[]
			{
				typeof(EffectPass),
				typeof(Texture2D),
				typeof(Texture2D),
				typeof(Texture2D),
				typeof(Texture2D)
			}, ReturnType = typeof(Material))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public MaterialPartition(Material baseMaterial)
			{
				throw null;
			}

			// Token: 0x06004941 RID: 18753 RVA: 0x0002EFDC File Offset: 0x0002D1DC
			[global::Cpp2ILInjected.Token(Token = "0x600171C")]
			[global::Cpp2ILInjected.Address(RVA = "0xAAF7B8", Offset = "0xAAF7B8", Length = "0x29C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaterialBuffer), Member = "DestroyMaterials", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "DestroyImmediate", MemberParameters = new object[] { typeof(global::UnityEngine.Object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Clear", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
			public void DestroyMaterials()
			{
				throw null;
			}

			// Token: 0x06004942 RID: 18754 RVA: 0x0002EFDF File Offset: 0x0002D1DF
			[global::Cpp2ILInjected.Token(Token = "0x600171D")]
			[global::Cpp2ILInjected.Address(RVA = "0xAAFB34", Offset = "0xAAFB34", Length = "0x1CC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MaterialBuffer), Member = "GetMaterial", MemberParameters = new object[]
			{
				typeof(EffectPass),
				typeof(Texture2D),
				typeof(Texture2D),
				typeof(Texture2D),
				typeof(Texture2D)
			}, ReturnType = typeof(Material))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaterialBuffer.MaterialEntry), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(MaterialBuffer.MaterialPartition),
				typeof(List<MaterialBuffer.MaterialEntry>),
				typeof(Texture2D),
				typeof(Texture2D),
				typeof(Texture2D),
				typeof(Texture2D)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			public MaterialBuffer.MaterialEntry GetMaterial(Texture2D t0, Texture2D t1, Texture2D t2, Texture2D t3)
			{
				throw null;
			}

			// Token: 0x04007DFC RID: 32252
			[global::Cpp2ILInjected.Token(Token = "0x40025B7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			public readonly Material BaseMaterial;

			// Token: 0x04007DFD RID: 32253
			[global::Cpp2ILInjected.Token(Token = "0x40025B8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			public readonly bool HasTexture2;

			// Token: 0x04007DFE RID: 32254
			[global::Cpp2ILInjected.Token(Token = "0x40025B9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x59")]
			public readonly bool HasTexture3;

			// Token: 0x04007DFF RID: 32255
			[global::Cpp2ILInjected.Token(Token = "0x40025BA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x5A")]
			public readonly bool HasTexture4;
		}
	}
}
