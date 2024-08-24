using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002D8 RID: 728
	[global::Cpp2ILInjected.Token(Token = "0x20003A9")]
	public abstract class Texture : GraphicsResource
	{
		// Token: 0x17000320 RID: 800
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x0002610E File Offset: 0x0002430E
		[global::Cpp2ILInjected.Token(Token = "0x1700034B")]
		internal int SortingKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001908")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC5CD4", Offset = "0xAC5CD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x00026111 File Offset: 0x00024311
		[global::Cpp2ILInjected.Token(Token = "0x1700034C")]
		public SurfaceFormat Format
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001909")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC5CDC", Offset = "0xAC5CDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x00026114 File Offset: 0x00024314
		[global::Cpp2ILInjected.Token(Token = "0x1700034D")]
		public int LevelCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x600190A")]
			[global::Cpp2ILInjected.Address(RVA = "0xAC5CE4", Offset = "0xAC5CE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x00026117 File Offset: 0x00024317
		[global::Cpp2ILInjected.Token(Token = "0x600190B")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC5CEC", Offset = "0xAC5CEC", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(Texture2D.SurfaceType),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static int CalculateMipLevels(int width, int height = 0, int depth = 0)
		{
			throw null;
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x0002611A File Offset: 0x0002431A
		[global::Cpp2ILInjected.Token(Token = "0x600190C")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC5D98", Offset = "0xAC5D98", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void GetSizeForLevel(int width, int height, int level, out int w, out int h)
		{
			throw null;
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x0002611D File Offset: 0x0002431D
		[global::Cpp2ILInjected.Token(Token = "0x600190D")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC5E0C", Offset = "0xAC5E0C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void GetSizeForLevel(int width, int height, int depth, int level, out int w, out int h, out int d)
		{
			throw null;
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x00026120 File Offset: 0x00024320
		[global::Cpp2ILInjected.Token(Token = "0x600190E")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC5EA4", Offset = "0xAC5EA4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsExtensions), Member = "GetSize", MemberParameters = new object[] { typeof(SurfaceFormat) }, ReturnType = typeof(int))]
		internal int GetPitch(int width)
		{
			throw null;
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x00026123 File Offset: 0x00024323
		[global::Cpp2ILInjected.Token(Token = "0x600190F")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC5F38", Offset = "0xAC5F38", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderTarget2D), Member = "GraphicsDeviceResetting", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		protected internal override void GraphicsDeviceResetting()
		{
			throw null;
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x00026126 File Offset: 0x00024326
		[global::Cpp2ILInjected.Token(Token = "0x6001910")]
		[global::Cpp2ILInjected.Address(RVA = "0xAC5F3C", Offset = "0xAC5F3C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(SurfaceFormat),
			typeof(Texture2D.SurfaceType),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsResource), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected Texture()
		{
			throw null;
		}

		// Token: 0x04002118 RID: 8472
		[global::Cpp2ILInjected.Token(Token = "0x4002774")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal SurfaceFormat _format;

		// Token: 0x04002119 RID: 8473
		[global::Cpp2ILInjected.Token(Token = "0x4002775")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		internal int _levelCount;

		// Token: 0x0400211A RID: 8474
		[global::Cpp2ILInjected.Token(Token = "0x4002776")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly int _sortingKey;

		// Token: 0x0400211B RID: 8475
		[global::Cpp2ILInjected.Token(Token = "0x4002777")]
		private static int _lastSortingKey;
	}
}
