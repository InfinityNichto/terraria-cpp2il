using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering
{
	[global::Cpp2ILInjected.Token(Token = "0x200010D")]
	public struct SubMeshDescriptor
	{
		[global::Cpp2ILInjected.Token(Token = "0x600055A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8A190", Offset = "0x1F8A190", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.SpriteBatcher", Member = "AddSubMesh", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.Effect", "Microsoft.Xna.Framework.Graphics.Texture2D", "Microsoft.Xna.Framework.Graphics.EffectPass" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public SubMeshDescriptor(int indexStart, int indexCount, MeshTopology topology = MeshTopology.Triangles)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000119")]
		public Bounds bounds
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600055B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A1A8", Offset = "0x1F8A1A8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600055C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A1BC", Offset = "0x1F8A1BC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700011A")]
		public MeshTopology topology
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600055D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A1D0", Offset = "0x1F8A1D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600055E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A1D8", Offset = "0x1F8A1D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700011B")]
		public int indexStart
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600055F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A1E0", Offset = "0x1F8A1E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000560")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A1E8", Offset = "0x1F8A1E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700011C")]
		public int indexCount
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000561")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A1F0", Offset = "0x1F8A1F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000562")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A1F8", Offset = "0x1F8A1F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700011D")]
		public int baseVertex
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000563")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A200", Offset = "0x1F8A200", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000564")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A208", Offset = "0x1F8A208", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700011E")]
		public int firstVertex
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000565")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A210", Offset = "0x1F8A210", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000566")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A218", Offset = "0x1F8A218", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700011F")]
		public int vertexCount
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000567")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A220", Offset = "0x1F8A220", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000568")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A228", Offset = "0x1F8A228", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000569")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8A230", Offset = "0x1F8A230", Length = "0x240")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override string ToString()
		{
			throw null;
		}

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400046D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Bounds <bounds>k__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400046E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private MeshTopology <topology>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400046F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int <indexStart>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000470")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int <indexCount>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000471")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int <baseVertex>k__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000472")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int <firstVertex>k__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000473")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int <vertexCount>k__BackingField;
	}
}
