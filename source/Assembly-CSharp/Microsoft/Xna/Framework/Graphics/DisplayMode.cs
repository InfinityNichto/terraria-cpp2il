using System;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x0200029C RID: 668
	[DataContract]
	[global::Cpp2ILInjected.Token(Token = "0x200035F")]
	public class DisplayMode
	{
		// Token: 0x0600151E RID: 5406 RVA: 0x000259E2 File Offset: 0x00023BE2
		[global::Cpp2ILInjected.Token(Token = "0x600167D")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA3C04", Offset = "0xAA3C04", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsAdapter), Member = "set_VirtualScreenSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void UpdateSize(int newWidth, int newHeight)
		{
			throw null;
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x000259E5 File Offset: 0x00023BE5
		[global::Cpp2ILInjected.Token(Token = "0x17000292")]
		public float AspectRatio
		{
			[global::Cpp2ILInjected.Token(Token = "0x600167E")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA3C0C", Offset = "0xAA3C0C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsAdapter), Member = "get_IsWideScreen", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x000259E8 File Offset: 0x00023BE8
		[global::Cpp2ILInjected.Token(Token = "0x17000293")]
		public SurfaceFormat Format
		{
			[global::Cpp2ILInjected.Token(Token = "0x600167F")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3C20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x000259EB File Offset: 0x00023BEB
		[global::Cpp2ILInjected.Token(Token = "0x17000294")]
		public int Height
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001680")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA3C28", Offset = "0xAA3C28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x000259EE File Offset: 0x00023BEE
		[global::Cpp2ILInjected.Token(Token = "0x17000295")]
		public int Width
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001681")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA3C30", Offset = "0xAA3C30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x000259F1 File Offset: 0x00023BF1
		[global::Cpp2ILInjected.Token(Token = "0x17000296")]
		public Rectangle TitleSafeArea
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001682")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA3C38", Offset = "0xAA3C38", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDevice), Member = "GetTitleSafeArea", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x000259F4 File Offset: 0x00023BF4
		[global::Cpp2ILInjected.Token(Token = "0x6001683")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA3CA0", Offset = "0xAA3CA0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsAdapter), Member = "PlatformInitializeAdapters", MemberParameters = new object[] { typeof(ref ReadOnlyCollection<GraphicsAdapter>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal DisplayMode(int width, int height, SurfaceFormat format)
		{
			throw null;
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x000259F7 File Offset: 0x00023BF7
		[global::Cpp2ILInjected.Token(Token = "0x6001684")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA3CDC", Offset = "0xAA3CDC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(DisplayMode left, DisplayMode right)
		{
			throw null;
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x000259FA File Offset: 0x00023BFA
		[global::Cpp2ILInjected.Token(Token = "0x6001685")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA3D38", Offset = "0xAA3D38", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(DisplayMode left, DisplayMode right)
		{
			throw null;
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x000259FD File Offset: 0x00023BFD
		[global::Cpp2ILInjected.Token(Token = "0x6001686")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA3D94", Offset = "0xAA3D94", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00025A00 File Offset: 0x00023C00
		[global::Cpp2ILInjected.Token(Token = "0x6001687")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA3E54", Offset = "0xAA3E54", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00025A03 File Offset: 0x00023C03
		[global::Cpp2ILInjected.Token(Token = "0x6001688")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA3EA0", Offset = "0xAA3EA0", Length = "0x284")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04001EED RID: 7917
		[global::Cpp2ILInjected.Token(Token = "0x40024CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private SurfaceFormat format;

		// Token: 0x04001EEE RID: 7918
		[global::Cpp2ILInjected.Token(Token = "0x40024D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int height;

		// Token: 0x04001EEF RID: 7919
		[global::Cpp2ILInjected.Token(Token = "0x40024D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int width;
	}
}
