using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Graphics;
using Unity.IL2CPP.CompilerServices;

namespace Microsoft.Xna.Framework.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x200035B")]
	public class Clipper
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6001657")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA0498", Offset = "0xAA0498", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "PushExpandedClippingRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void PushExpandedClippingRegion()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001658")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA04C0", Offset = "0xAA04C0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "PopExpandedClippingRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void PopExpandedClippingRegion()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4002414")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private SpriteBatch clippingBatch;

		[global::Cpp2ILInjected.Token(Token = "0x4002415")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private SpriteBatcher.VertexData[] cache1;

		[global::Cpp2ILInjected.Token(Token = "0x4002416")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private SpriteBatcher.VertexData[] cache2;

		[global::Cpp2ILInjected.Token(Token = "0x4002417")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int inputCount;

		[global::Cpp2ILInjected.Token(Token = "0x4002418")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int outputCount;

		[global::Cpp2ILInjected.Token(Token = "0x4002419")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private SpriteBatcher.VertexData[] input;

		[global::Cpp2ILInjected.Token(Token = "0x400241A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private SpriteBatcher.VertexData[] output;

		[global::Cpp2ILInjected.Token(Token = "0x400241B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int Left;

		[global::Cpp2ILInjected.Token(Token = "0x400241C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private int Right;

		[global::Cpp2ILInjected.Token(Token = "0x400241D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int Top;

		[global::Cpp2ILInjected.Token(Token = "0x400241E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private int Bottom;

		[global::Cpp2ILInjected.Token(Token = "0x400241F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private int OuterLeft;

		[global::Cpp2ILInjected.Token(Token = "0x4002420")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private int OuterRight;

		[global::Cpp2ILInjected.Token(Token = "0x4002421")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int OuterTop;

		[global::Cpp2ILInjected.Token(Token = "0x4002422")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private int OuterBottom;

		[global::Cpp2ILInjected.Token(Token = "0x4002423")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private int FadeOuterLeft;

		[global::Cpp2ILInjected.Token(Token = "0x4002424")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private int FadeOuterRight;

		[global::Cpp2ILInjected.Token(Token = "0x4002425")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private int FadeOuterTop;

		[global::Cpp2ILInjected.Token(Token = "0x4002426")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		private int FadeOuterBottom;

		[global::Cpp2ILInjected.Token(Token = "0x4002427")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private bool clipVertical;

		[global::Cpp2ILInjected.Token(Token = "0x4002428")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x71")]
		private bool clipHorizontal;

		[global::Cpp2ILInjected.Token(Token = "0x4002429")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x72")]
		private bool geometryScaleEnabled;

		[global::Cpp2ILInjected.Token(Token = "0x400242A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		private Vector2 geometryScaleCentre;

		[global::Cpp2ILInjected.Token(Token = "0x400242B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		private float geometryScale;

		[global::Cpp2ILInjected.Token(Token = "0x400242C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private bool geometryOffsetEnabled;

		[global::Cpp2ILInjected.Token(Token = "0x400242D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		private Vector2 geometryOffset;
	}
}
