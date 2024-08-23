using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	public struct TextGenerationSettings
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[global::Cpp2ILInjected.Token(Token = "0x6000001")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA4258", Offset = "0x1FA4258", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextGenerationSettings), Member = "Equals", MemberParameters = new object[] { typeof(TextGenerationSettings) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool CompareColors(Color left, Color right)
		{
			throw null;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002053 File Offset: 0x00000253
		[global::Cpp2ILInjected.Token(Token = "0x6000002")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA4390", Offset = "0x1FA4390", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextGenerationSettings), Member = "Equals", MemberParameters = new object[] { typeof(TextGenerationSettings) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool CompareVector2(Vector2 left, Vector2 right)
		{
			throw null;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002056 File Offset: 0x00000256
		[global::Cpp2ILInjected.Token(Token = "0x6000003")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA4458", Offset = "0x1FA4458", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextGenerator), Member = "PopulateWithError", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextGenerationSettings)
		}, ReturnType = typeof(TextGenerationError))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerationSettings), Member = "CompareColors", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextGenerationSettings), Member = "CompareVector2", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool Equals(TextGenerationSettings other)
		{
			throw null;
		}

		// Token: 0x0400000B RID: 11
		[global::Cpp2ILInjected.Token(Token = "0x400000B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Font font;

		// Token: 0x0400000C RID: 12
		[global::Cpp2ILInjected.Token(Token = "0x400000C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Color color;

		// Token: 0x0400000D RID: 13
		[global::Cpp2ILInjected.Token(Token = "0x400000D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int fontSize;

		// Token: 0x0400000E RID: 14
		[global::Cpp2ILInjected.Token(Token = "0x400000E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public float lineSpacing;

		// Token: 0x0400000F RID: 15
		[global::Cpp2ILInjected.Token(Token = "0x400000F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public bool richText;

		// Token: 0x04000010 RID: 16
		[global::Cpp2ILInjected.Token(Token = "0x4000010")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public float scaleFactor;

		// Token: 0x04000011 RID: 17
		[global::Cpp2ILInjected.Token(Token = "0x4000011")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public FontStyle fontStyle;

		// Token: 0x04000012 RID: 18
		[global::Cpp2ILInjected.Token(Token = "0x4000012")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public TextAnchor textAnchor;

		// Token: 0x04000013 RID: 19
		[global::Cpp2ILInjected.Token(Token = "0x4000013")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public bool alignByGeometry;

		// Token: 0x04000014 RID: 20
		[global::Cpp2ILInjected.Token(Token = "0x4000014")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
		public bool resizeTextForBestFit;

		// Token: 0x04000015 RID: 21
		[global::Cpp2ILInjected.Token(Token = "0x4000015")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public int resizeTextMinSize;

		// Token: 0x04000016 RID: 22
		[global::Cpp2ILInjected.Token(Token = "0x4000016")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int resizeTextMaxSize;

		// Token: 0x04000017 RID: 23
		[global::Cpp2ILInjected.Token(Token = "0x4000017")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public bool updateBounds;

		// Token: 0x04000018 RID: 24
		[global::Cpp2ILInjected.Token(Token = "0x4000018")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public VerticalWrapMode verticalOverflow;

		// Token: 0x04000019 RID: 25
		[global::Cpp2ILInjected.Token(Token = "0x4000019")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public HorizontalWrapMode horizontalOverflow;

		// Token: 0x0400001A RID: 26
		[global::Cpp2ILInjected.Token(Token = "0x400001A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public Vector2 generationExtents;

		// Token: 0x0400001B RID: 27
		[global::Cpp2ILInjected.Token(Token = "0x400001B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public Vector2 pivot;

		// Token: 0x0400001C RID: 28
		[global::Cpp2ILInjected.Token(Token = "0x400001C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public bool generateOutOfBounds;
	}
}
