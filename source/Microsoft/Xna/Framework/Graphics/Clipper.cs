using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Graphics;
using Unity.IL2CPP.CompilerServices;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x02000298 RID: 664
	[global::Cpp2ILInjected.Token(Token = "0x200035B")]
	public class Clipper
	{
		// Token: 0x060014F5 RID: 5365 RVA: 0x00025967 File Offset: 0x00023B67
		[global::Cpp2ILInjected.Token(Token = "0x6001654")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA03FC", Offset = "0xAA03FC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "EnableClipping", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Rectangle),
			typeof(SpriteBatch),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "PushClippedImageRegion", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(SpriteBatch),
			typeof(bool),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "SetGeometryOffset", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(bool),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Clipper(SpriteBatch owner)
		{
			throw null;
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x0002596A File Offset: 0x00023B6A
		[global::Cpp2ILInjected.Token(Token = "0x6001655")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA0478", Offset = "0xAA0478", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "EnableClipping", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Rectangle),
			typeof(SpriteBatch),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "PushClippedImageRegion", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(SpriteBatch),
			typeof(bool),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "PopClippedImageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public void SetClipState(bool horizonal, bool vertical)
		{
			throw null;
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0002596D File Offset: 0x00023B6D
		[global::Cpp2ILInjected.Token(Token = "0x6001656")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA048C", Offset = "0xAA048C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "EnableClipping", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Rectangle),
			typeof(SpriteBatch),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "PushClippedImageRegion", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(SpriteBatch),
			typeof(bool),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "PopClippedImageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public void SetClipRegionInner(int left, int right, int top, int bottom)
		{
			throw null;
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00025970 File Offset: 0x00023B70
		[global::Cpp2ILInjected.Token(Token = "0x6001657")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA0498", Offset = "0xAA0498", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "PushExpandedClippingRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void PushExpandedClippingRegion()
		{
			throw null;
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x00025973 File Offset: 0x00023B73
		[global::Cpp2ILInjected.Token(Token = "0x6001658")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA04C0", Offset = "0xAA04C0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "PopExpandedClippingRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void PopExpandedClippingRegion()
		{
			throw null;
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00025976 File Offset: 0x00023B76
		[global::Cpp2ILInjected.Token(Token = "0x6001659")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA04E8", Offset = "0xAA04E8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "EnableClipping", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Rectangle),
			typeof(SpriteBatch),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "PushClippedImageRegion", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(SpriteBatch),
			typeof(bool),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "PopClippedImageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public void SetClipRegionOuter(int left, int right, int top, int bottom)
		{
			throw null;
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00025979 File Offset: 0x00023B79
		[global::Cpp2ILInjected.Token(Token = "0x600165A")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA04FC", Offset = "0xAA04FC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "PushClippedImageRegion", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(SpriteBatch),
			typeof(bool),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void SetClipRegionOuter(int left, int right, int top, int bottom, int fadeLeft, int fadeRight, int fadeTop, int fadeBottom)
		{
			throw null;
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0002597C File Offset: 0x00023B7C
		[global::Cpp2ILInjected.Token(Token = "0x600165B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA0514", Offset = "0xAA0514", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "PushClippedImageRegion", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(SpriteBatch),
			typeof(bool),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "PopClippedImageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void SetGeometryScale(bool enable, Vector2 centre, float scale)
		{
			throw null;
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x0002597F File Offset: 0x00023B7F
		[global::Cpp2ILInjected.Token(Token = "0x600165C")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA0528", Offset = "0xAA0528", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "SetGeometryOffset", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(bool),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void SetGeometryOffset(bool enable, Vector2 offset)
		{
			throw null;
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00025982 File Offset: 0x00023B82
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x600165D")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA0538", Offset = "0xAA0538", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref VertexColors),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref VertexColors),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public void Offset(SpriteBatchItem item)
		{
			throw null;
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00025985 File Offset: 0x00023B85
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x600165E")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA05B4", Offset = "0xAA05B4", Length = "0x78C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref VertexColors),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref VertexColors),
			typeof(ref Vector2),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "Clip", MemberParameters = new object[]
		{
			typeof(SpriteBatcher.VertexData),
			typeof(SpriteBatcher.VertexData),
			typeof(SpriteBatcher.VertexData),
			typeof(SpriteBatcher.VertexData),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref SpriteBatcher.VertexData[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Clipper), Member = "InjectBatches", MemberParameters = new object[]
		{
			typeof(SpriteBatchItem),
			typeof(bool),
			typeof(int),
			typeof(SpriteBatcher.VertexData[])
		}, ReturnType = typeof(void))]
		public void Clip(SpriteBatchItem item)
		{
			throw null;
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00025988 File Offset: 0x00023B88
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x600165F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA1BD8", Offset = "0xAA1BD8", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Clipper), Member = "Clip", MemberParameters = new object[] { typeof(SpriteBatchItem) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "InsertNewBatchItem", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(SpriteBatchItem))]
		private void InjectBatches(SpriteBatchItem item, bool resuseItem, int outNumPoints, SpriteBatcher.VertexData[] output)
		{
			throw null;
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x0002598B File Offset: 0x00023B8B
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6001660")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA0D40", Offset = "0xAA0D40", Length = "0xE98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Clipper), Member = "Clip", MemberParameters = new object[] { typeof(SpriteBatchItem) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		private bool Clip(SpriteBatcher.VertexData p0, SpriteBatcher.VertexData p1, SpriteBatcher.VertexData p2, SpriteBatcher.VertexData p3, int clipLeft, int clipRight, int clipTop, int clipBottom, out int numResultPoints, out SpriteBatcher.VertexData[] result)
		{
			throw null;
		}

		// Token: 0x04001E32 RID: 7730
		[global::Cpp2ILInjected.Token(Token = "0x4002414")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private SpriteBatch clippingBatch;

		// Token: 0x04001E33 RID: 7731
		[global::Cpp2ILInjected.Token(Token = "0x4002415")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private SpriteBatcher.VertexData[] cache1;

		// Token: 0x04001E34 RID: 7732
		[global::Cpp2ILInjected.Token(Token = "0x4002416")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private SpriteBatcher.VertexData[] cache2;

		// Token: 0x04001E35 RID: 7733
		[global::Cpp2ILInjected.Token(Token = "0x4002417")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int inputCount;

		// Token: 0x04001E36 RID: 7734
		[global::Cpp2ILInjected.Token(Token = "0x4002418")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int outputCount;

		// Token: 0x04001E37 RID: 7735
		[global::Cpp2ILInjected.Token(Token = "0x4002419")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private SpriteBatcher.VertexData[] input;

		// Token: 0x04001E38 RID: 7736
		[global::Cpp2ILInjected.Token(Token = "0x400241A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private SpriteBatcher.VertexData[] output;

		// Token: 0x04001E39 RID: 7737
		[global::Cpp2ILInjected.Token(Token = "0x400241B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int Left;

		// Token: 0x04001E3A RID: 7738
		[global::Cpp2ILInjected.Token(Token = "0x400241C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private int Right;

		// Token: 0x04001E3B RID: 7739
		[global::Cpp2ILInjected.Token(Token = "0x400241D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int Top;

		// Token: 0x04001E3C RID: 7740
		[global::Cpp2ILInjected.Token(Token = "0x400241E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private int Bottom;

		// Token: 0x04001E3D RID: 7741
		[global::Cpp2ILInjected.Token(Token = "0x400241F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private int OuterLeft;

		// Token: 0x04001E3E RID: 7742
		[global::Cpp2ILInjected.Token(Token = "0x4002420")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private int OuterRight;

		// Token: 0x04001E3F RID: 7743
		[global::Cpp2ILInjected.Token(Token = "0x4002421")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int OuterTop;

		// Token: 0x04001E40 RID: 7744
		[global::Cpp2ILInjected.Token(Token = "0x4002422")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private int OuterBottom;

		// Token: 0x04001E41 RID: 7745
		[global::Cpp2ILInjected.Token(Token = "0x4002423")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private int FadeOuterLeft;

		// Token: 0x04001E42 RID: 7746
		[global::Cpp2ILInjected.Token(Token = "0x4002424")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private int FadeOuterRight;

		// Token: 0x04001E43 RID: 7747
		[global::Cpp2ILInjected.Token(Token = "0x4002425")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private int FadeOuterTop;

		// Token: 0x04001E44 RID: 7748
		[global::Cpp2ILInjected.Token(Token = "0x4002426")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		private int FadeOuterBottom;

		// Token: 0x04001E45 RID: 7749
		[global::Cpp2ILInjected.Token(Token = "0x4002427")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private bool clipVertical;

		// Token: 0x04001E46 RID: 7750
		[global::Cpp2ILInjected.Token(Token = "0x4002428")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x71")]
		private bool clipHorizontal;

		// Token: 0x04001E47 RID: 7751
		[global::Cpp2ILInjected.Token(Token = "0x4002429")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x72")]
		private bool geometryScaleEnabled;

		// Token: 0x04001E48 RID: 7752
		[global::Cpp2ILInjected.Token(Token = "0x400242A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		private Vector2 geometryScaleCentre;

		// Token: 0x04001E49 RID: 7753
		[global::Cpp2ILInjected.Token(Token = "0x400242B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		private float geometryScale;

		// Token: 0x04001E4A RID: 7754
		[global::Cpp2ILInjected.Token(Token = "0x400242C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private bool geometryOffsetEnabled;

		// Token: 0x04001E4B RID: 7755
		[global::Cpp2ILInjected.Token(Token = "0x400242D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		private Vector2 geometryOffset;
	}
}
